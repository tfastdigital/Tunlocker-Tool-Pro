using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace motoulocked.mtkclient2.library;

internal class MtkDaxUploadSetupService
{
	public static async Task SetupEnvAsync(IMtkDevice device, CancellationToken cancellationToken)
	{
		Console.WriteLine("Sending setup env command: 0x010100");
		await MtkDaxService.SendAsync(device, 65792u, cancellationToken);
		Console.WriteLine("Sending setup env param");
		using MemoryStream memoryStream = new MemoryStream();
		Extension.Write(memoryStream, BitConverter.GetBytes(2));
		Extension.Write(memoryStream, BitConverter.GetBytes(1));
		Extension.Write(memoryStream, BitConverter.GetBytes(1));
		Extension.Write(memoryStream, BitConverter.GetBytes(0));
		Extension.Write(memoryStream, BitConverter.GetBytes(0));
		await MtkDaxService.SendAsync(device, memoryStream.ToArray(), cancellationToken);
		Console.WriteLine("Reading setup env status");
		uint num = await MtkDaxService.ReadStatusAsync(device, cancellationToken);
		if ((long)num != 0L)
		{
			Console.WriteLine($"Invalid setup env status: 0x{num:X8}");
		}
	}

	public static async Task SetupHardwareInitAsync(IMtkDevice device, CancellationToken cancellationToken)
	{
		Console.WriteLine("Sending setup hardware init command: 0x010101");
		await MtkDaxService.SendAsync(device, 65793u, cancellationToken);
		Console.WriteLine("Sending setup hardware init param");
		await MtkDaxService.SendAsync(device, 0u, cancellationToken);
		Console.WriteLine("Reading setup hardware init status");
		uint num = await MtkDaxService.ReadStatusAsync(device, cancellationToken);
		if ((long)num != 0L)
		{
			Console.WriteLine($"Invalid setup hardware init status: 0x{num:X8}");
		}
	}

	public static async Task SwitchUsbSpeedAsync(IMtkDevice device, CancellationToken cancellationToken)
	{
		Console.WriteLine("Sending usb switch command: 0x01000B");
		await MtkDaxService.SendAsync(device, 65547u, cancellationToken);
		Console.WriteLine("Reading usb switch command status");
		uint num = await MtkDaxService.ReadStatusAsync(device, cancellationToken);
		if ((long)num == 0L)
		{
			Console.WriteLine("Sending usb switch data: 0x0E8D2001");
			await MtkDaxService.SendAsync(device, 244129793u, cancellationToken);
			Console.WriteLine("Reading usb switch data status");
			num = await MtkDaxService.ReadStatusAsync(device, cancellationToken);
			if ((long)num != 0L)
			{
				Console.WriteLine($"Invalid usb switch data status: 0x{num:X8}");
			}
		}
		else
		{
			Console.WriteLine($"Invalid usb switch command status: 0x{num:X8}");
		}
	}
}
