using System;
using System.Threading;
using System.Threading.Tasks;

namespace motoulocked.mtkclient2.library;

internal class MtkDaxDeviceControlService
{
	public static async Task<byte[]> SendDevCtrlAsync(IMtkDevice device, uint cmd, CancellationToken cancellationToken)
	{
		if (await SendDevCtrlNoReadAsync(device, cmd, cancellationToken))
		{
			Console.WriteLine("Reading dev ctrl result");
			byte[] result = await MtkDaxService.ReadAsync(device, cancellationToken);
			Console.WriteLine("Reading dev ctrl result status");
			uint num = await MtkDaxService.ReadStatusAsync(device, cancellationToken);
			if ((long)num != 0L)
			{
				Console.WriteLine($"Invalid dev ctrl result status: 0x{num:X8}");
			}
			return result;
		}
		return new byte[0];
	}

	public static async Task SendDevCtrlAsync(IMtkDevice device, uint cmd, byte[] param, CancellationToken cancellationToken)
	{
		if (await SendDevCtrlNoReadAsync(device, cmd, cancellationToken))
		{
			Console.WriteLine("Sending dev ctrl param: {0}", BitConverter.ToString(param));
			await MtkDaxService.SendAsync(device, param, cancellationToken);
			Console.WriteLine("Reading dev ctrl param status");
			uint num = await MtkDaxService.ReadStatusAsync(device, cancellationToken);
			if ((long)num != 0L)
			{
				Console.WriteLine($"Invalid dev ctrl param status: 0x{num:X8}");
			}
		}
	}

	public static async Task<bool> SendDevCtrlNoReadAsync(IMtkDevice device, uint cmd, CancellationToken cancellationToken)
	{
		await MtkDaxService.SendAsync(device, 65545u, cancellationToken);
		uint num = await MtkDaxService.ReadStatusAsync(device, cancellationToken);
		if ((long)num != 0L)
		{
			Console.WriteLine($"Invalid dev ctrl cmd status: 0x{num:X8}");
		}
		await MtkDaxService.SendAsync(device, cmd, cancellationToken);
		num = await MtkDaxService.ReadStatusAsync(device, cancellationToken);
		switch (num)
		{
		case 0u:
			return true;
		case 3221291012u:
			return false;
		default:
			Console.WriteLine($"Invalid cmd status: 0x{num:X8}");
			return true;
		}
	}
}
