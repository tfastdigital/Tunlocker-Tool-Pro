using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Ports;
using System.Linq;

namespace motoulocked.HuaweiUnlocker.TOOLS;

public class ImageFlasher
{
	private const int BAUDRATE = 115200;

	private const int MAX_DATA_LEN = 1024;

	private static byte[] headframe = new byte[4] { 254, 0, 255, 1 };

	private static byte[] dataframe = new byte[1] { 218 };

	private static byte[] tailframe = new byte[1] { 237 };

	private static ushort[] CRChisi = new ushort[256]
	{
		0, 4129, 8258, 12387, 16516, 20645, 24774, 28903, 33032, 37161,
		41290, 45419, 49548, 53677, 57806, 61935, 4657, 528, 12915, 8786,
		21173, 17044, 29431, 25302, 37689, 33560, 45947, 41818, 54205, 50076,
		62463, 58334, 9314, 13379, 1056, 5121, 25830, 29895, 17572, 21637,
		42346, 46411, 34088, 38153, 58862, 62927, 50604, 54669, 13907, 9842,
		5649, 1584, 30423, 26358, 22165, 18100, 46939, 42874, 38681, 34616,
		63455, 59390, 55197, 51132, 18628, 22757, 26758, 30887, 2112, 6241,
		10242, 14371, 51660, 55789, 59790, 63919, 35144, 39273, 43274, 47403,
		23285, 19156, 31415, 27286, 6769, 2640, 14899, 10770, 56317, 52188,
		64447, 60318, 39801, 35672, 47931, 43802, 27814, 31879, 19684, 23749,
		11298, 15363, 3168, 7233, 60846, 64911, 52716, 56781, 44330, 48395,
		36200, 40265, 32407, 28342, 24277, 20212, 15891, 11826, 7761, 3696,
		65439, 61374, 57309, 53244, 48923, 44858, 40793, 36728, 37256, 33193,
		45514, 41451, 53516, 49453, 61774, 57711, 4224, 161, 12482, 8419,
		20484, 16421, 28742, 24679, 33721, 37784, 41979, 46042, 49981, 54044,
		58239, 62302, 689, 4752, 8947, 13010, 16949, 21012, 25207, 29270,
		46570, 42443, 38312, 34185, 62830, 58703, 54572, 50445, 13538, 9411,
		5280, 1153, 29798, 25671, 21540, 17413, 42971, 47098, 34713, 38840,
		59231, 63358, 50973, 55100, 9939, 14066, 1681, 5808, 26199, 30326,
		17941, 22068, 55628, 51565, 63758, 59695, 39368, 35305, 47498, 43435,
		22596, 18533, 30726, 26663, 6336, 2273, 14466, 10403, 52093, 56156,
		60223, 64286, 35833, 39896, 43963, 48026, 19061, 23124, 27191, 31254,
		2801, 6864, 10931, 14994, 64814, 60687, 56684, 52557, 48554, 44427,
		40424, 36297, 31782, 27655, 23652, 19525, 15522, 11395, 7392, 3265,
		61215, 65342, 53085, 57212, 44955, 49082, 36825, 40952, 28183, 32310,
		20053, 24180, 11923, 16050, 3793, 7920
	};

	private SerialPort port;

	public void Open(string portName)
	{
		port = new SerialPort
		{
			PortName = portName,
			BaudRate = 115200,
			DtrEnable = true,
			RtsEnable = true,
			ReadTimeout = 10000,
			WriteTimeout = 10000
		};
		port.Open();
	}

	public void Close()
	{
		port.Close();
		port.Dispose();
		port = null;
	}

	public void Write(string path, int address, Action<int> reportProgress = null)
	{
		FileStream fileStream = new FileStream(path, FileMode.Open, FileAccess.Read);
		checked
		{
			int num = (int)fileStream.Length;
			int num2 = (int)Math.Round((double)num / (double)(1024 + ((unchecked(num % 1024) > 0) ? 1 : 0)));
			int num3 = 0;
			byte[] array = new byte[1024];
			SendHeadFrame(num, address);
			while (num > 1024)
			{
				fileStream.Read(array, 0, 1024);
				SendDataFrame(num3 + 1, array);
				num3++;
				num -= 1024;
				if (unchecked(num3 % ((num2 > 250) ? 10 : 3)) == 0)
				{
					reportProgress?.Invoke((int)Math.Round(100f * (float)num3 / (float)num2));
				}
			}
			if (num > 0)
			{
				array = new byte[num - 1 + 1];
				fileStream.Read(array, 0, num);
				SendDataFrame(num3 + 1, array);
			}
			reportProgress?.Invoke(100);
			SendTailFrame(num3 + 2);
		}
	}

	private void SendHeadFrame(int length, int address)
	{
		List<byte> list = new List<byte>(headframe);
		list.AddRange(BitConverter.GetBytes(length).Reverse());
		list.AddRange(BitConverter.GetBytes(address).Reverse());
		SendFrame(list.ToArray());
	}

	private void SendDataFrame(int n, byte[] data)
	{
		List<byte> list = checked(new List<byte>(dataframe)
		{
			(byte)(n & 0xFF),
			(byte)(~n & 0xFF)
		});
		list.AddRange(data);
		SendFrame(list.ToArray());
	}

	private void SendTailFrame(int n)
	{
		List<byte> list = checked(new List<byte>(tailframe)
		{
			(byte)(n & 0xFF),
			(byte)(~n & 0xFF)
		});
		SendFrame(list.ToArray());
	}

	public static ushort GetChecksum(byte[] data)
	{
		int num = 0;
		foreach (byte b in data)
		{
			num = ((num << 8) | b) ^ CRChisi[(num >> 8) & 0xFF];
		}
		int num2 = 0;
		checked
		{
			do
			{
				num = (num << 8) ^ CRChisi[(num >> 8) & 0xFF];
				num2++;
			}
			while (num2 <= 1);
			return (ushort)(num & 0xFFFF);
		}
	}

	private void SendFrame(byte[] data)
	{
		ushort checksum = GetChecksum(data);
		checked
		{
			List<byte> obj = new List<byte>(data)
			{
				(byte)(unchecked((ushort)((uint)checksum >> 8)) & 0xFF),
				(byte)(checksum & 0xFFu)
			};
			int count = obj.Count;
			byte[] buffer = obj.ToArray();
			port.Write(buffer, 0, count);
			byte b = (byte)port.ReadByte();
			port.DiscardInBuffer();
			port.DiscardOutBuffer();
			if (b != 170)
			{
				throw new Exception($"ACK is invalid! ACK={b:X2}; Excepted={170:X2}");
			}
		}
	}
}
