using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.VisualBasic.CompilerServices;

namespace motoulocked.mtkclient2.library.xflash;

[StandardModule]
internal static class MtkDeviceExtension
{
	public static async Task ReadExactAsync(this IMtkDevice device, byte[] buff, int offset, int len, CancellationToken cancellationToken)
	{
		int num = 0;
		checked
		{
			while (num < len)
			{
				if (!cancellationToken.IsCancellationRequested)
				{
					int num2 = await device.ReadAsync(buff, num + offset, len - num, cancellationToken);
					if (num2 != 0)
					{
						num += num2;
						continue;
					}
				}
				Console.WriteLine("Unexpected device EOF");
				break;
			}
		}
	}

	public static async Task<uint> ReadDwordAsync(this IMtkDevice device, bool little, CancellationToken cancellationToken)
	{
		byte[] array = new byte[4];
		await ReadExactAsync(device, array, 0, array.Length, cancellationToken);
		if (little)
		{
			array = array.Reverse().ToArray();
		}
		return BitConverter.ToUInt32(array, 0);
	}

	public static async Task<ushort> ReadWordAsync(this IMtkDevice device, bool little, CancellationToken cancellationToken)
	{
		byte[] array = new byte[2];
		await ReadExactAsync(device, array, 0, array.Length, cancellationToken);
		if (little)
		{
			array = array.Reverse().ToArray();
		}
		return BitConverter.ToUInt16(array, 0);
	}

	public static async Task<byte> ReadByteAsync(this IMtkDevice device, CancellationToken cancellationToken)
	{
		byte[] array = new byte[1];
		await ReadExactAsync(device, array, 0, array.Length, cancellationToken);
		return array[0];
	}

	public static async Task EchoAsync(this IMtkDevice device, byte[] buff, CancellationToken cancellationToken)
	{
		await device.WriteAsync(buff, 0, buff.Length, cancellationToken);
		byte[] array = new byte[checked(buff.Length - 1 + 1)];
		await ReadExactAsync(device, array, 0, array.Length, cancellationToken);
		if (!buff.SequenceEqual(array))
		{
			Console.WriteLine($"Invalid device echo response. Expected: {BitConverter.ToString(buff)}. Got: {BitConverter.ToString(array)}");
		}
	}

	public static Task EchoAsync(this IMtkDevice device, byte buff, CancellationToken cancellationToken)
	{
		return EchoAsync(device, new byte[1] { buff }, cancellationToken);
	}
}
