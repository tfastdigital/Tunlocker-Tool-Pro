using System;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;

namespace motoulocked.HuaweiUnlocker.TOOLS;

public class Fastboot
{
	public enum FastbootStatus
	{
		Failed,
		Ok,
		Data,
		Info,
		Unknown
	}

	public class Response
	{
		public FastbootStatus Status;

		public string Payload;

		public byte[] RawData;

		public Response(FastbootStatus status, string payload)
		{
			Status = status;
			Payload = payload;
		}
	}

	private const int USB_VID = 6353;

	private const int USB_PID = 53261;

	private const int HEADER_SIZE = 4;

	private const int BLOCK_SIZE = 524288;

	public int DefaultRWTimeout;

	public int DefaultTimeoutWait;

	public Fastboot()
	{
		DefaultRWTimeout = 500000;
		DefaultTimeoutWait = 100;
	}

	private FastbootStatus GetStatus(string header)
	{
		return header switch
		{
			"INFO" => FastbootStatus.Info, 
			"OKAY" => FastbootStatus.Ok, 
			"DATA" => FastbootStatus.Data, 
			"FAIL" => FastbootStatus.Failed, 
			_ => FastbootStatus.Unknown, 
		};
	}

	public bool Connect(int waittime = 100)
	{
		bool result = default(bool);
		return result;
	}

	public void Disconnect()
	{
	}

	public string GetSerialNumber()
	{
		string result = default(string);
		return result;
	}

	public Response Command(byte[] commandd)
	{
		int num = default(int);
		if (num != commandd.Length)
		{
			throw new Exception("Failed to write command! Transfered: " + num + "of" + commandd.Length + "bytes");
		}
		StringBuilder stringBuilder = new StringBuilder();
		string @string;
		FastbootStatus fastbootStatus;
		int num2 = default(int);
		do
		{
			byte[] bytes = new byte[64];
			@string = Encoding.ASCII.GetString(bytes);
			fastbootStatus = ((@string.Length >= 4) ? GetStatus(new string(@string.Take(4).ToArray())) : FastbootStatus.Unknown);
			stringBuilder.Append(@string.Skip(4).Take(checked(num2 - 4)).ToArray());
			stringBuilder.Append("\n");
		}
		while (fastbootStatus == FastbootStatus.Info);
		return new Response(fastbootStatus, stringBuilder.ToString().Replace("\r", string.Empty).Replace("\0", string.Empty))
		{
			RawData = Encoding.ASCII.GetBytes(@string)
		};
	}

	private bool SendDataCommand(long size)
	{
		Response response = Command($"download:{size:X8}");
		if (response.Status != FastbootStatus.Data)
		{
			throw new Exception($"Invalid response from device! (data size: {size})");
		}
		response.Payload.Contains("too large");
		return !response.Payload.Contains("too large");
	}

	private void TransferBlock(FileStream stream, byte[] buffer, int size)
	{
		stream.Read(buffer, 0, size);
		int num = default(int);
		if (num != size)
		{
			throw new Exception("Failed to transfer block (sent " + num + " of " + size + ")");
		}
	}

	public bool UploadData(string path, string partname)
	{
		FileStream fileStream = new FileStream(path, FileMode.Open);
		string payload = Command("getvar:max-download-size").Payload;
		int num = Conversions.ToInteger(new Int32Converter().ConvertFromString(payload));
		int num2 = 1;
		long num3 = fileStream.Length;
		checked
		{
			if (SendDataCommand(num3))
			{
				while (num3 > 0)
				{
					long num4 = ((num3 >= num) ? num : num3);
					if (num4 == num)
					{
						string text = partname;
						string text2 = " Part: ";
						_ = text + text2 + num2++;
					}
					while (num4 > 0)
					{
						if (num4 < 524288)
						{
							TransferBlock(fileStream, new byte[(int)(num4 - 1) + 1], (int)num4);
							num3 -= num4;
							num4 = 0L;
						}
						else
						{
							TransferBlock(fileStream, new byte[524288], 524288);
							num3 -= 524288;
							num4 -= 524288;
						}
					}
					byte[] bytes = new byte[64];
					string @string = Encoding.ASCII.GetString(bytes);
					if (@string.Length < 4)
					{
						throw new Exception("Invalid response from device: " + @string);
					}
					if (GetStatus(new string(@string.Take(4).ToArray())) != FastbootStatus.Ok)
					{
						throw new Exception("Invalid status: " + @string);
					}
					if (partname.Equals("gpt"))
					{
						partname = "partition";
					}
					if (Command("flash:" + partname).Payload.Contains("table doesn't exist"))
					{
						break;
					}
				}
				fileStream.Close();
				fileStream.Dispose();
				return true;
			}
			fileStream.Close();
			fileStream.Dispose();
			return false;
		}
	}

	public Response Command(string commandd)
	{
		Response result = default(Response);
		return result;
	}
}
