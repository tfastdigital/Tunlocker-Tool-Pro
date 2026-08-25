using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.VisualBasic.CompilerServices;
using motoulocked.mtkclient2.library.xflash;

namespace motoulocked.mtkclient2.library;

internal class MtkDaxService
{
	public static async Task<byte[]> ReadAsync(IMtkDevice device, CancellationToken cancellationToken)
	{
		await MtkDeviceExtension.ReadDwordAsync(device, little: false, cancellationToken);
		await MtkDeviceExtension.ReadDwordAsync(device, little: false, cancellationToken);
		uint num = await MtkDeviceExtension.ReadDwordAsync(device, little: false, cancellationToken);
		checked
		{
			byte[] array = new byte[(int)(unchecked((long)num) - 1L) + 1];
			await MtkDeviceExtension.ReadExactAsync(device, array, 0, (int)num, cancellationToken);
			return array;
		}
	}

	public static async Task<uint> ReadStatusAsync(IMtkDevice device, CancellationToken cancellationToken)
	{
		byte[] array = await ReadAsync(device, cancellationToken);
		if (array.Length == 2)
		{
			return BitConverter.ToUInt16(array, 0);
		}
		if (array.Length < 4)
		{
			Console.WriteLine("Invalid DAX status buffer length: " + Conversions.ToString(array.Length));
		}
		uint num = BitConverter.ToUInt32(array, 0);
		if (num == 4277071599u)
		{
			return 0u;
		}
		return num;
	}

	public static async Task<uint> ReadAckAsync(IMtkDevice device, CancellationToken cancellationToken)
	{
		await SendAsync(device, 0u, cancellationToken);
		return await ReadStatusAsync(device, cancellationToken);
	}

	public static async Task SendAsync(IMtkDevice device, byte[] data, int bufferSize, CancellationToken cancellationToken)
	{
		checked
		{
			using MemoryStream memoryStream = new MemoryStream();
			Extension.Write(memoryStream, BitConverter.GetBytes(4277071599u));
			Extension.Write(memoryStream, BitConverter.GetBytes(1));
			Extension.Write(memoryStream, BitConverter.GetBytes(data.Length));
			byte[] array = memoryStream.ToArray();
			await device.WriteAsync(array, 0, array.Length, cancellationToken);
			int i = 0;
			byte[] array2 = new byte[bufferSize - 1 + 1];
			int num;
			for (; i < data.Length; i += num)
			{
				num = Math.Min(array2.Length, data.Length - i);
				Array.Copy(data, i, array2, 0, num);
				await device.WriteAsync(array2, 0, num, cancellationToken);
			}
		}
	}

	public static Task SendAsync(IMtkDevice device, byte[] data, CancellationToken cancellationToken)
	{
		return SendAsync(device, data, 512, cancellationToken);
	}

	public static Task SendAsync(IMtkDevice device, uint data, CancellationToken cancellationToken)
	{
		return SendAsync(device, BitConverter.GetBytes(data), cancellationToken);
	}
}
