using System;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace motoulocked.motoulocked;

[StandardModule]
internal sealed class FIREHOSE_PACKET
{
	public static ListBox lb { get; set; } = new ListBox();


	public static void SendXmlFast(string xml)
	{
		DiskWriter.DiskWrite(Encoding.UTF8.GetBytes(xml));
		FIREHOSE_RESPONSE.IsAck(silent: true);
	}

	public static void SendXml(string xml)
	{
		DiskWriter.DiskWrite(Encoding.UTF8.GetBytes(xml));
	}

	public static byte[] ReadByte()
	{
		byte[] array = new byte[0];
		byte[] array2;
		while (true)
		{
			array2 = DiskWriter.DiskRead();
			if (Encoding.UTF8.GetString(array2).ToLower().Contains("ack"))
			{
				if (Encoding.UTF8.GetString(array2).ToLower().Contains("nak"))
				{
					return new byte[0];
				}
				if (Encoding.UTF8.GetString(array2).ToLower().Contains("ack"))
				{
					break;
				}
			}
		}
		FindOffset(array2.Take(512).ToArray(), "</data>");
		int count = lb.Items.Count;
		checked
		{
			int num = Convert.ToInt32(RuntimeHelpers.GetObjectValue(lb.Items[count - 1]));
			return array2.Skip(num + 7).ToArray();
		}
	}

	public static byte[] ReadByte(string len)
	{
		int num = 0;
		int num2 = int.Parse(len);
		long num3 = 0L;
		checked
		{
			byte[] array = new byte[num2 + 512 - 1 + 1];
			byte[] array2 = new byte[0];
			do
			{
				IL_0026:
				if (num == 0)
				{
					byte[] array3 = DiskWriter.DiskRead();
					if (Encoding.UTF8.GetString(array3).ToLower().Contains("nak"))
					{
						return new byte[num2 + 1];
					}
					if (!Encoding.UTF8.GetString(array3).ToLower().Contains("ack"))
					{
						goto IL_0026;
					}
					FindOffset(array3.Take(200).ToArray(), "</data>");
					int count = lb.Items.Count;
					if (count != 0)
					{
						int num4 = Convert.ToInt32(RuntimeHelpers.GetObjectValue(lb.Items[count - 1]));
						array2 = array3.Skip(num4 + 7).ToArray();
					}
				}
				else
				{
					array2 = DiskWriter.DiskRead();
				}
				Buffer.BlockCopy(array2, 0, array, (int)num3, array2.Length);
				num3 += array2.Length;
				num++;
			}
			while (num3 <= num2);
			return array.Take(num2).ToArray();
		}
	}

	public static void FindOffset(byte[] inpubytes, string oldstring)
	{
		byte[] bytes = Encoding.UTF8.GetBytes(oldstring);
		lb.Items.Clear();
		lb = new ListBox();
		checked
		{
			using BinaryReader binaryReader = new BinaryReader(new MemoryStream(inpubytes));
			long length = binaryReader.BaseStream.Length;
			if (bytes.Length > length)
			{
				return;
			}
			byte[] array = binaryReader.ReadBytes(bytes.Length);
			bool flag = false;
			int num = bytes.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				if (array[i] != bytes[i])
				{
					flag = false;
					break;
				}
				flag = true;
			}
			if (flag)
			{
				return;
			}
			int num2 = bytes.Length;
			int num3 = (int)length - 1;
			for (int j = num2; j <= num3; j++)
			{
				Array.Copy(array, 1, array, 0, array.Length - 1);
				array[array.Length - 1] = binaryReader.ReadByte();
				int num4 = bytes.Length - 1;
				for (int k = 0; k <= num4; k++)
				{
					if (array[k] != bytes[k])
					{
						flag = false;
						break;
					}
					flag = true;
				}
				if (flag)
				{
					lb.Items.Add((j - (bytes.Length - 1)).ToString());
				}
			}
		}
	}
}
