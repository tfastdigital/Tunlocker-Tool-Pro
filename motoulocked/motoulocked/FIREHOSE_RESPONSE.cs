using System;
using System.Drawing;
using System.Text;
using System.Threading;
using Microsoft.VisualBasic.CompilerServices;

namespace motoulocked.motoulocked;

[StandardModule]
internal sealed class FIREHOSE_RESPONSE
{
	public static bool IsAck(bool silent = false)
	{
		int num = 0;
		string text = "";
		do
		{
			if (FIREHOSE_MANAGER.FirehoseWorker.CancellationPending)
			{
				throw new Exception(" • Operations Stopped...");
			}
			byte[] array = DiskWriter.DiskRead();
			text += Encoding.UTF8.GetString(array, 0, array.Length);
			Console.WriteLine("");
			Console.WriteLine($"Is Ack Result [ {num} ]: ");
			Console.WriteLine(text);
			Console.WriteLine("");
			if (text.Contains("\"ACK\""))
			{
				return true;
			}
			if (text.Contains("\"NAK\""))
			{
				if (!silent)
				{
					UiManager.Richlogs(text, Color.Red, isBold: false, NextLine: true);
				}
				return false;
			}
			num = checked(num + 1);
			Thread.Sleep(50);
		}
		while (num != 5);
		return false;
	}

	public static string CekResponseConfig()
	{
		int num = 0;
		string text = "";
		do
		{
			if (FIREHOSE_MANAGER.FirehoseWorker.CancellationPending)
			{
				throw new Exception(" • Operations Stopped...");
			}
			byte[] array = DiskWriter.DiskRead();
			text += Encoding.UTF8.GetString(array, 0, array.Length);
			Console.WriteLine("");
			Console.WriteLine($"Check Response Config Result [ {num} ] : ");
			Console.WriteLine(text);
			Console.WriteLine("");
			if (text.ToUpper().Contains("\"ACK\""))
			{
				return text;
			}
			if (text.ToUpper().Contains("\"NAK\""))
			{
				return text;
			}
			num = checked(num + 1);
			Thread.Sleep(100);
		}
		while (num != 3);
		return text;
	}
}
