using System;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

namespace motoulocked.mtkclient2.library.xflash;

internal class MtkReadWrite32Service
{
	public static async Task ReadAsync(IMtkDevice device, uint address, int count, CancellationToken cancellationToken)
	{
		await MtkDeviceExtension.EchoAsync(device, 209, cancellationToken);
		byte[] bytes = BitConverter.GetBytes(address);
		Array.Reverse(bytes);
		await MtkDeviceExtension.EchoAsync(device, bytes, cancellationToken);
		byte[] bytes2 = BitConverter.GetBytes(count);
		Array.Reverse(bytes2);
		await MtkDeviceExtension.EchoAsync(device, bytes2, cancellationToken);
		ushort num = await MtkDeviceExtension.ReadWordAsync(device, little: true, cancellationToken);
		if (num > 255 && num != 7432)
		{
			Console.WriteLine("Invalid read32 status: 0x{0:X4}", num);
		}
	}

	public static async Task<uint[]> ReadResultAsync(IMtkDevice device, uint address, int count, bool little, CancellationToken cancellationToken)
	{
		await ReadAsync(device, address, count, cancellationToken);
		checked
		{
			uint[] array = new uint[count - 1 + 1];
			int num = 0;
			TaskAwaiter<uint> taskAwaiter2 = default(TaskAwaiter<uint>);
			while (num < count)
			{
				uint[] array2 = array;
				int num2 = num;
				uint[] array3 = array2;
				int num3 = num2;
				TaskAwaiter<uint> taskAwaiter = MtkDeviceExtension.ReadDwordAsync(device, little, cancellationToken).GetAwaiter();
				if (!taskAwaiter.IsCompleted)
				{
					//await taskAwaiter;
					taskAwaiter = taskAwaiter2;
					taskAwaiter2 = default(TaskAwaiter<uint>);
				}
				array3[num3] = taskAwaiter.GetResult();
				int num4 = num + 1;
				num = num4;
			}
			ushort num5 = await MtkDeviceExtension.ReadWordAsync(device, little: true, cancellationToken);
			if (num5 > 255 && num5 != 7432)
			{
				Console.WriteLine("Invalid read32 value status: 0x{0:X4}", num5);
			}
			return array;
		}
	}

	public static async Task WriteAsync(IMtkDevice device, uint address, uint value, bool bigEndian, CancellationToken cancellationToken)
	{
		Console.WriteLine("Sending 0xD4");
		await MtkDeviceExtension.EchoAsync(device, 212, cancellationToken);
		Console.WriteLine("Sending address: 0x{0:X8}", address);
		byte[] bytes = BitConverter.GetBytes(address);
		Array.Reverse(bytes);
		await MtkDeviceExtension.EchoAsync(device, bytes, cancellationToken);
		Console.WriteLine("Sending length: 1");
		byte[] bytes2 = BitConverter.GetBytes(1);
		Array.Reverse(bytes2);
		await MtkDeviceExtension.EchoAsync(device, bytes2, cancellationToken);
		Console.WriteLine("Reading status");
		ushort num = await MtkDeviceExtension.ReadWordAsync(device, little: true, cancellationToken);
		if (num != 1)
		{
			Console.WriteLine($"Invalid write32 status: 0x{num:X4}");
		}
		Console.WriteLine("Sending value: 0x{0:X8}", value);
		byte[] bytes3 = BitConverter.GetBytes(value);
		if (bigEndian)
		{
			Array.Reverse(bytes3);
		}
		await MtkDeviceExtension.EchoAsync(device, bytes3, cancellationToken);
		Console.WriteLine("Reading status");
		num = await MtkDeviceExtension.ReadWordAsync(device, little: true, cancellationToken);
		if (num != 1)
		{
			Console.WriteLine($"Invalid write32 value status: 0x{num:X4}");
		}
	}
}
