using System;
using System.Threading;
using System.Threading.Tasks;

namespace motoulocked.mtkclient2.library.xflash;

internal class MtkDaWriteService
{
	public static async Task WriteAsync(IMtkDevice device, uint address, int signatureLength, byte[] da, bool validateUploadStatus, CancellationToken cancellationToken)
	{
		cancellationToken.ThrowIfCancellationRequested();
		Console.WriteLine("Preparing da buffer");
		ushort checksum = 0;
		byte[] buffer = null;
		MtkDaWriteDataService.PrepareData(da, signatureLength, out checksum, out buffer);
		Console.WriteLine("Buffer size: {0}; Signature size: {1} Checksum: 0x{2:X4}", buffer.Length, signatureLength, checksum);
		Console.WriteLine("Sending 0xD7");
		await MtkDeviceExtension.EchoAsync(device, 215, cancellationToken);
		Console.WriteLine("Sending address: 0x{0:X8}", address);
		byte[] bytes = BitConverter.GetBytes(address);
		Array.Reverse(bytes);
		await MtkDeviceExtension.EchoAsync(device, bytes, cancellationToken);
		Console.WriteLine("Sending buffer length");
		byte[] bytes2 = BitConverter.GetBytes(buffer.Length);
		Array.Reverse(bytes2);
		await MtkDeviceExtension.EchoAsync(device, bytes2, cancellationToken);
		Console.WriteLine("Sending signature length");
		byte[] bytes3 = BitConverter.GetBytes(signatureLength);
		Array.Reverse(bytes3);
		await MtkDeviceExtension.EchoAsync(device, bytes3, cancellationToken);
		Console.WriteLine("Reading status");
		ushort num = await MtkDeviceExtension.ReadWordAsync(device, little: true, cancellationToken);
		checked
		{
			if (num == 0)
			{
				int i = 0;
				byte[] array = new byte[64];
				Console.WriteLine("Sending data with 64 byte buffer");
				int num2;
				for (; i < buffer.Length; i += num2)
				{
					num2 = Math.Min(array.Length, buffer.Length - i);
					Array.Copy(buffer, i, array, 0, num2);
					await device.WriteAsync(array, 0, num2, cancellationToken);
				}
				Console.WriteLine("Reading checksum response");
				ushort num3 = await MtkDeviceExtension.ReadWordAsync(device, little: true, cancellationToken);
				Console.WriteLine("Reading status");
				num = await MtkDeviceExtension.ReadWordAsync(device, little: true, cancellationToken);
				if (num3 != checksum && num3 != 0)
				{
					Console.WriteLine($"Checksum of DA upload does not match: 0x{checksum:X4} vs 0x{num3:X4}");
				}
				if (validateUploadStatus && num != 0)
				{
					Console.WriteLine($"Invalid DA upload status: 0x{num:X4}");
				}
			}
			else
			{
				Console.WriteLine($"Invalid status: 0x{num:X4}");
			}
		}
	}

	public static async Task JumpAsync(IMtkDevice device, uint address, CancellationToken cancellationToken)
	{
		cancellationToken.ThrowIfCancellationRequested();
		Console.WriteLine("Sending 0xD5");
		await MtkDeviceExtension.EchoAsync(device, 213, cancellationToken);
		byte[] bytes = BitConverter.GetBytes(address);
		Array.Reverse(bytes);
		await MtkDeviceExtension.EchoAsync(device, bytes, cancellationToken);
		Console.WriteLine("Reading status");
		ushort num = await MtkDeviceExtension.ReadWordAsync(device, little: true, cancellationToken);
		if (num != 0)
		{
			Console.WriteLine($"Invalid DA jump status: 0x{num:X4}");
		}
	}
}
