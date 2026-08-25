using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.IO.Ports;
using System.Linq;
using System.Management;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace motoulocked;

public class FRP
{
	private class Class85
	{
		public IEnumerable<string> ienumerable_0;

		internal string method_0(string string_0)
		{
			Class86 @class = new Class86();
			@class.string_0 = string_0;
			return @class.string_0 + " - " + ienumerable_0.FirstOrDefault(@class.method_0);
		}
	}

	private class Class86
	{
		public string string_0;

		internal bool method_0(string string_1)
		{
			return string_1.Contains(string_0);
		}
	}

	[Serializable]
	private class Class87
	{
		public static Class87 x = new Class87();

		public static Func<string, string> x__0_0;

		public static Func<ManagementBaseObject, string> x__0_1;

		public static Func<string, ManagementBaseObject, string> x__0_2;

		public static Func<ManagementBaseObject, string> x__0_3;

		internal string method_0(string string_0)
		{
			return string_0;
		}

		internal string method_1(ManagementBaseObject managementBaseObject_0)
		{
			return managementBaseObject_0["DeviceID"].ToString();
		}

		internal string method_2(string string_0, ManagementBaseObject managementBaseObject_0)
		{
			string text = " - ";
			return string_0 + text + RuntimeHelpers.GetObjectValue(managementBaseObject_0["Caption"]);
		}

		internal string method_3(ManagementBaseObject managementBaseObject_0)
		{
			return managementBaseObject_0["Caption"].ToString();
		}
	}

	public static ushort[] ushort_0 = new ushort[256]
	{
		0, 4489, 8978, 12955, 17956, 22445, 25910, 29887, 35912, 40385,
		44890, 48851, 51820, 56293, 59774, 63735, 4225, 264, 13203, 8730,
		22181, 18220, 30135, 25662, 40137, 36160, 49115, 44626, 56045, 52068,
		63999, 59510, 8450, 12427, 528, 5017, 26406, 30383, 17460, 21949,
		44362, 48323, 36440, 40913, 60270, 64231, 51324, 55797, 12675, 8202,
		4753, 792, 30631, 26158, 21685, 17724, 48587, 44098, 40665, 36688,
		64495, 60006, 55549, 51572, 16900, 21389, 24854, 28831, 1056, 5545,
		10034, 14011, 52812, 57285, 60766, 64727, 34920, 39393, 43898, 47859,
		21125, 17164, 29079, 24606, 5281, 1320, 14259, 9786, 57037, 53060,
		64991, 60502, 39145, 35168, 48123, 43634, 25350, 29327, 16404, 20893,
		9506, 13483, 1584, 6073, 61262, 65223, 52316, 56789, 43370, 47331,
		35448, 39921, 29575, 25102, 20629, 16668, 13731, 9258, 5809, 1848,
		65487, 60998, 56541, 52564, 47595, 43106, 39673, 35696, 33800, 38273,
		42778, 46739, 49708, 54181, 57662, 61623, 2112, 6601, 11090, 15067,
		20068, 24557, 28022, 31999, 38025, 34048, 47003, 42514, 53933, 49956,
		61887, 57398, 6337, 2376, 15315, 10842, 24293, 20332, 32247, 27774,
		42250, 46211, 34328, 38801, 58158, 62119, 49212, 53685, 10562, 14539,
		2640, 7129, 28518, 32495, 19572, 24061, 46475, 41986, 38553, 34576,
		62383, 57894, 53437, 49460, 14787, 10314, 6865, 2904, 32743, 28270,
		23797, 19836, 50700, 55173, 58654, 62615, 32808, 37281, 41786, 45747,
		19012, 23501, 26966, 30943, 3168, 7657, 12146, 16123, 54925, 50948,
		62879, 58390, 37033, 33056, 46011, 41522, 23237, 19276, 31191, 26718,
		7393, 3432, 16371, 11898, 59150, 63111, 50204, 54677, 41258, 45219,
		33336, 37809, 27462, 31439, 18516, 23005, 11618, 15595, 3696, 8185,
		63375, 58886, 54429, 50452, 45483, 40994, 37561, 33584, 31687, 27214,
		22741, 18780, 15843, 11370, 7921, 3960
	};

	private static List<string> list_0;

	internal static int int_0 = -1;

	private static long long_0 = 0L;

	public static byte[] byte_0 = new byte[4] { 82, 69, 65, 68 };

	public static Stream stream_0;

	public SaveFileDialog saveBrowser;

	internal static string smethod_54(ref byte[] byte_1)
	{
		return Encoding.ASCII.GetString(byte_1, 0, byte_1.Length);
	}

	public static void smethod_57(SerialPort sender, SerialDataReceivedEventArgs e)
	{
		int bytesToRead = sender.BytesToRead;
		byte[] array = new byte[checked(bytesToRead - 1 + 1)];
		if (sender.BytesToRead > 1)
		{
			sender.Read(array, 0, bytesToRead);
		}
		GClass39.smethod_8(BitConverter.ToString(array).Replace("-", string.Empty));
	}

	internal static string smethod_63(byte[] byte_1)
	{
		return Encoding.ASCII.GetString(byte_1, 0, byte_1.Length);
	}

	private static long smethod_64(string string_0, byte[] byte_1, long long_1, long long_2)
	{
		checked
		{
			long num;
			using (FileStream fileStream = File.OpenRead(string_0))
			{
				for (num = long_1; num < long_2; num++)
				{
					fileStream.Seek(num, SeekOrigin.Begin);
					long num2;
					for (num2 = 0L; num2 < byte_1.Length && fileStream.ReadByte() == byte_1[(int)(IntPtr)num2]; num2++)
					{
					}
					if (num2 == byte_1.Length)
					{
						break;
					}
				}
			}
			return num;
		}
	}

	internal static byte[] smethod_65(string string_0)
	{
		return SoapHexBinary.Parse(string_0).Value;
	}

	internal static byte[] smethod_66(string string_0)
	{
		return smethod_67(smethod_65(string_0), checked((int)Math.Round((double)string_0.Length / 2.0)));
	}

	private static byte[] smethod_67(byte[] byte_1, int int_1)
	{
		List<byte> list = new List<byte>();
		byte byte_2 = 0;
		byte[] result;
		checked
		{
			try
			{
				int num = int_1 - 1;
				for (int i = 0; i <= num; i++)
				{
					if (smethod_68(ref byte_2, byte_1[i]))
					{
						list.Add(125);
					}
					list.Add(byte_2);
				}
				ushort num2 = ushort.MaxValue;
				int num3 = int_1 - 1;
				for (int j = 0; j <= num3; j++)
				{
					num2 = smethod_69(num2, byte_1[j]);
				}
				num2 = unchecked((ushort)(num2 ^ 0xFFFF));
				if (smethod_68(ref byte_2, Convert.ToByte(num2 & 0xFF)))
				{
					list.Add(125);
				}
				list.Add(byte_2);
				if (smethod_68(ref byte_2, Convert.ToByte((ushort)(unchecked((uint)num2) >> 8) & 0xFF)))
				{
					list.Add(125);
				}
				list.Add(byte_2);
				list.Add(126);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				result = list.ToArray();
				ProjectData.ClearProjectError();
				goto IL_00db;
			}
			result = list.ToArray();
			goto IL_00db;
		}
		IL_00db:
		return result;
	}

	private static bool smethod_68(ref byte byte_1, byte byte_2)
	{
		if (byte_2 != 125 && byte_2 != 126)
		{
			byte_1 = byte_2;
			return false;
		}
		int num = byte_2 ^ 0x20;
		byte_1 = checked((byte)num);
		return true;
	}

	private static ushort smethod_69(ushort ushort_1, byte byte_1)
	{
		checked
		{
			return Convert.ToUInt16((ushort)(unchecked((uint)ushort_1) >> 8) ^ ushort_0[(ushort_1 ^ byte_1) & 0xFF]);
		}
	}

	public static string smethod_70(string string_0)
	{
		string s = "dataunlock";
		byte[] sourceArray = SHA256.Create().ComputeHash(Encoding.ASCII.GetBytes(s));
		byte[] iV = new byte[16];
		Aes aes = Aes.Create();
		aes.Mode = CipherMode.CBC;
		byte[] array = new byte[32];
		Array.Copy(sourceArray, 0, array, 0, 32);
		aes.Key = array;
		aes.IV = iV;
		MemoryStream memoryStream = new MemoryStream();
		ICryptoTransform transform = aes.CreateDecryptor();
		CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write);
		string empty = string.Empty;
		try
		{
			byte[] array2 = Convert.FromBase64String(string_0);
			cryptoStream.Write(array2, 0, array2.Length);
			cryptoStream.FlushFinalBlock();
			byte[] array3 = memoryStream.ToArray();
			return Encoding.ASCII.GetString(array3, 0, array3.Length);
		}
		finally
		{
			memoryStream.Close();
			cryptoStream.Close();
		}
	}

	public static string smethod_71(string string_0)
	{
		byte[] array = Convert.FromBase64String(string_0);
		checked
		{
			using MemoryStream memoryStream = new MemoryStream();
			int num = BitConverter.ToInt32(array, 0);
			memoryStream.Write(array, 4, array.Length - 4);
			byte[] array2 = new byte[num - 1 + 1];
			memoryStream.Position = 0L;
			using (GZipStream gZipStream = new GZipStream(memoryStream, CompressionMode.Decompress))
			{
				gZipStream.Read(array2, 0, array2.Length);
			}
			return Encoding.UTF8.GetString(array2);
		}
	}
}
