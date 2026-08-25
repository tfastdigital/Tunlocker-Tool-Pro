using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace motoulocked.mtkclient2.library;

internal class MtkDaxUploadBootService
{
	public static bool rebootto = false;

	public static async Task BootToAsync(IMtkDevice device, long address, byte[] da, CancellationToken cancellationToken)
	{
		Console.WriteLine("Sending boot command: 0x010008");
		await MtkDaxService.SendAsync(device, 65544u, cancellationToken);
		Console.WriteLine("Reading boot command status");
		uint num = await MtkDaxService.ReadStatusAsync(device, cancellationToken);
		if ((long)num != 0L)
		{
			Console.WriteLine($"Invalid boot command status: 0x{num:X8}");
			return;
		}
		Console.WriteLine("Sending boot parameter: address 0x{0:X16} length {1}", address, da.Length);
		MemoryStream memoryStream = new MemoryStream();
		Extension.Write(memoryStream, BitConverter.GetBytes(address));
		Extension.Write(memoryStream, BitConverter.GetBytes((long)da.Length));
		await MtkDaxService.SendAsync(device, memoryStream.ToArray(), cancellationToken);
		Console.WriteLine("Sending boot DA");
		await MtkDaxService.SendAsync(device, da, 64, cancellationToken);
		Console.WriteLine("Reading boot DA status");
		num = await MtkDaxService.ReadStatusAsync(device, cancellationToken);
		if ((long)num == 0L)
		{
			Console.WriteLine("Delay for 500ms");
			await Task.Delay(TimeSpan.FromMilliseconds(500.0));
			Console.WriteLine("Reading boot status");
			num = await MtkDaxService.ReadStatusAsync(device, cancellationToken);
			Console.WriteLine("Boot status: 0x{0:X8}", num);
			if ((long)num != 0L && (ulong)num != 1129208147)
			{
				Console.WriteLine($"Invalid boot status: 0x{num:X8}");
			}
		}
		else
		{
			Console.WriteLine($"Invalid boot DA status: 0x{num:X8}");
		}
	}

	public static async Task RebootAsync(IMtkDevice device, CancellationToken cancellationToken)
	{
		Console.WriteLine("Sending boot command: 0x010007");
		await MtkDaxService.SendAsync(device, 65543u, cancellationToken);
		Console.WriteLine("Reading command status");
		if ((long)(await MtkDaxService.ReadStatusAsync(device, cancellationToken)) != 0L)
		{
			return;
		}
		Console.WriteLine("Sending boot command param");
		using MemoryStream memoryStream = new MemoryStream(24);
		Extension.Write(memoryStream, BitConverter.GetBytes(1));
		Extension.Write(memoryStream, BitConverter.GetBytes(29098084));
		Extension.Write(memoryStream, BitConverter.GetBytes(0));
		Extension.Write(memoryStream, BitConverter.GetBytes(0));
		Extension.Write(memoryStream, BitConverter.GetBytes(0));
		Extension.Write(memoryStream, BitConverter.GetBytes(0));
		await MtkDaxService.SendAsync(device, memoryStream.ToArray(), cancellationToken);
		Console.WriteLine("Reading param status");
		uint num = await MtkDaxService.ReadStatusAsync(device, cancellationToken);
		if ((long)num != 0L)
		{
			Console.WriteLine($"Invalid boot command param status: 0x{num:X8}");
		}
		Thread.Sleep(500);
		device?.Dispose();
	}
}
