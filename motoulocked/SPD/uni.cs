using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.FileIO;
using motoulocked.motoulocked;
using motoulocked.My;
using Properties;

namespace motoulocked.SPD;

[StandardModule]
internal static class uni
{
	public static bool isRSAExploit = true;

	public static string Temp = string.Empty;

	public static byte[] fdl1;

	public static string fdl1_location = string.Empty;

	public static string fdl1_addr = string.Empty;

	public static string exploit = string.Empty;

	public static byte[] fdl2;

	public static string fdl2_location = string.Empty;

	public static string fdl2_addr = string.Empty;

	public static string Timeout = "5000 ";

	public static string Name;

	public static string UniDir = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts)) + "\\UniDir";

	public static string UniTmp = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts)) + "\\UniTmp";

	public static string uniCommand = string.Empty;

	public static bool isPartitionOperation = false;

	private static string Hexx;

	private static string Stringg;

	private static string brand;

	private static string model;

	private static string device;

	private static string android;

	private static string id;

	private static string securityPatch;

	public static string ByteArrayToString(byte[] ba)
	{
		StringBuilder stringBuilder = new StringBuilder(checked(ba.Length * 2));
		foreach (byte b in ba)
		{
			stringBuilder.AppendFormat("{0:x2}", b);
		}
		return stringBuilder.ToString();
	}

	public static string HexToString(string hexString)
	{
		StringBuilder stringBuilder = new StringBuilder();
		checked
		{
			int num = hexString.Length - 1;
			for (int i = 0; i <= num; i += 2)
			{
				int charCode = Convert.ToInt32(hexString.Substring(i, 2), 16);
				stringBuilder.Append(Strings.Chr(charCode));
			}
			return stringBuilder.ToString();
		}
	}

	public static void get_info()
	{
		Hexx = ByteArrayToString(File.ReadAllBytes("Tmp\\IN"));
		Hexx = Hexx.Replace("00", "2E");
		Stringg = HexToString(Hexx);
		ExtractDeviceInfo(Stringg, "com.android.build.product.fingerprint.", "com.android.build.product.security_patch.");
	}

	public static void ExtractDeviceInfo(string input, string offset_info, string offset_security)
	{
		string text = "Tmp\\IN";
		checked
		{
			int num = input.IndexOf(offset_info) + offset_info.Length;
			if (num == -1)
			{
				brand = "Not found";
				model = "Not found";
				device = "Not found";
				android = "Not found";
				id = "Not found";
				securityPatch = "Not found";
				return;
			}
			int num2 = input.IndexOf(":", num);
			if (num2 == -1)
			{
				num2 = input.Length;
			}
			string[] array = input.Substring(num, num2 - num).Split('/');
			if (array.Length >= 3)
			{
				brand = array[0];
				model = array[1];
				device = array[2];
			}
			else
			{
				brand = "Not found";
				model = "Not found";
				device = "Not found";
			}
			string[] array2 = input.Substring(num2 + 1).Split('/');
			if (array2.Length >= 2)
			{
				android = array2[0];
				id = array2[1];
			}
			else
			{
				android = "Not found";
				id = "Not found";
			}
			int num3 = input.IndexOf(offset_security) + offset_security.Length;
			if (num3 != -1 && num3 < input.Length)
			{
				int num4 = input.IndexOf(" ", num3);
				if (num4 == -1)
				{
					num4 = input.Length;
				}
				securityPatch = input.Substring(num3, num4 - num3);
				securityPatch = securityPatch.Substring(0, 10);
			}
			else
			{
				securityPatch = "Not found";
			}
			if ((Operators.CompareString(brand, "Not found", TextCompare: false) == 0) | (Operators.CompareString(model, "Not found", TextCompare: false) == 0) | (Operators.CompareString(device, "Not found", TextCompare: false) == 0) | (Operators.CompareString(android, "Not found", TextCompare: false) == 0) | (Operators.CompareString(id, "Not found", TextCompare: false) == 0) | (Operators.CompareString(securityPatch, "Not found", TextCompare: false) == 0))
			{
				UiManager.Richlogs("FAIL ", Color.Red);
				UiManager.Richlogs("(EXT4 MOUNT FAILED)", Color.DarkOrange, isBold: true, NextLine: true);
			}
			else
			{
				android = AndroidCommands.AndroidName(android);
				UiManager.Richlogs("OK", Color.FromArgb(0, 85, 207), isBold: true, NextLine: true);
				UiManager.Richlogs("- Manufacturer : ", Color.Black, isBold: false);
				UiManager.Richlogs(brand, Color.Lime, isBold: true, NextLine: true);
				UiManager.Richlogs("- Brand : ", Color.Black, isBold: false);
				UiManager.Richlogs(brand, Color.Lime, isBold: true, NextLine: true);
				UiManager.Richlogs("- Phone Model : ", Color.Black, isBold: false);
				UiManager.Richlogs(model, Color.Lime, isBold: true, NextLine: true);
				UiManager.Richlogs("- Android Version : ", Color.Black, isBold: false);
				UiManager.Richlogs(android, Color.Lime, isBold: true, NextLine: true);
				UiManager.Richlogs("- Build id : ", Color.Black, isBold: false);
				UiManager.Richlogs(id, Color.Lime, isBold: true, NextLine: true);
				UiManager.Richlogs("- Security Patch : ", Color.Black, isBold: false);
				UiManager.Richlogs(securityPatch, Color.Lime, isBold: true, NextLine: true);
				device_info.Brand = brand;
				device_info.model = model;
				device_info.serialno = id;
				device_info.Android = android;
				device_info.security_patch = securityPatch;
			}
			try
			{
				File.Delete(SPDR.ThisLocation + text);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}
	}

	public static void uni_cmd()
	{
		try
		{
			using (Process process = Process.Start(new ProcessStartInfo(UniDir + "\\chiller.tft", uniCommand)
			{
				CreateNoWindow = true,
				WindowStyle = ProcessWindowStyle.Hidden,
				UseShellExecute = false,
				Verb = "runas",
				WorkingDirectory = UniDir,
				RedirectStandardError = true
			}))
			{
				while (!process.StandardError.EndOfStream)
				{
					string text = process.StandardError.ReadLine() ?? string.Empty;
					if (Operators.CompareString(SPDR.cancel, "Cancel", TextCompare: false) == 0)
					{
						return;
					}
					if (text.Contains("Boot Version"))
					{
						try
						{
							File.Delete(SPDR.ThisLocation + "Tmp\\IN");
						}
						catch (Exception ex)
						{
							ProjectData.SetProjectError(ex);
							Exception ex2 = ex;
							ProjectData.ClearProjectError();
						}
						Form1.SharedUI.ProgressBar4.Text = "";
						Form1.SharedUI.ProgressBar4.Value = 0;
						SerialCOM.MSL = "ENREAD";
						UiManager.Richlogs("OK", Color.FromArgb(0, 85, 207), isBold: true, NextLine: true);
						UiManager.Richlogs("- Send Handshak Protocol : ", Color.White, isBold: false);
						Name = "Sending Handshak..(";
					}
					if (text.Contains("Sending FDL 1"))
					{
						UiManager.ProcessBar2(100L);
						UiManager.Richlogs("OK", Color.FromArgb(0, 85, 207), isBold: true, NextLine: true);
						UiManager.Richlogs("- Sending Payload : ", Color.White, isBold: false);
						Name = "Sending Payload..(";
					}
					if (text.Contains("Boot Information  : Spreadtrum Boot Block version 1.1"))
					{
						UiManager.Richlogs("OK", Color.FromArgb(0, 85, 207), isBold: true, NextLine: true);
						UiManager.Richlogs("- Sending Preloader : ", Color.White, isBold: false);
						Name = "Sending Preloader..(";
					}
					if (text.Contains("Sending FDL 2"))
					{
						UiManager.ProcessBar2(100L);
						UiManager.Richlogs("OK", Color.FromArgb(0, 85, 207), isBold: true, NextLine: true);
						UiManager.Richlogs("- Sending FDL Loader : ", Color.White, isBold: false);
						Name = "Sending FDL..(";
					}
					if (text.Contains("Download Config"))
					{
						Form1.SharedUI.ProgressBar4.Value = 100;
						SerialCOM.MSL = "DISREAD";
						Form1.SharedUI.ProgressBar4.Text = "";
						Form1.SharedUI.ProgressBar4.Value = 0;
						UiManager.Richlogs("OK", Color.FromArgb(0, 85, 207), isBold: true, NextLine: true);
						UiManager.Richlogs("- Reading Device Info : ", Color.White, isBold: false);
						Form1.SharedUI.ProgressBar1.Text = "Reading Data...";
						try
						{
							MyProject.Computer.FileSystem.DeleteDirectory("Tmp\\1", DeleteDirectoryOption.DeleteAllContents);
							File.Delete(SPDR.ThisLocation + "Tmp\\1.zip");
						}
						catch (Exception ex3)
						{
							ProjectData.SetProjectError(ex3);
							Exception ex4 = ex3;
							ProjectData.ClearProjectError();
						}
						if (Operators.CompareString(SPDR.Type_Operation, "Remove_Frp", TextCompare: false) == 0)
						{
							SPDR.Type_Operation = "Remove Frp";
						}
						if (Operators.CompareString(SPDR.Type_Operation, "Factory_Reset_Data", TextCompare: false) == 0)
						{
							SPDR.Type_Operation = "Factory Reset Data";
						}
					}
					if (Operators.CompareString(SPDR.Type_Operation, "Remove Frp_Userdata", TextCompare: false) == 0 && text.Contains("FDL2 State"))
					{
						Form1.SharedUI.ProgressBar4.Value = 100;
						SerialCOM.MSL = "DISREAD";
						Form1.SharedUI.ProgressBar4.Text = "";
						Form1.SharedUI.ProgressBar4.Value = 0;
						UiManager.Richlogs("OK", Color.FromArgb(0, 85, 207), isBold: true, NextLine: true);
						UiManager.Richlogs("- Reading Device Info : ", Color.White, isBold: false);
						Form1.SharedUI.ProgressBar1.Text = "Reading Data...";
						try
						{
							MyProject.Computer.FileSystem.DeleteDirectory("Tmp\\1", DeleteDirectoryOption.DeleteAllContents);
							File.Delete(SPDR.ThisLocation + "Tmp\\1.zip");
						}
						catch (Exception ex5)
						{
							ProjectData.SetProjectError(ex5);
							Exception ex6 = ex5;
							ProjectData.ClearProjectError();
						}
						if (Operators.CompareString(SPDR.Type_Operation, "Remove Frp_Userdata", TextCompare: false) == 0)
						{
							SPDR.Type_Operation = "Remove Frp + Userdata";
						}
					}
					if (Operators.CompareString(SPDR.Type_Operation, "Remove Frp + Userdata", TextCompare: false) == 0)
					{
						if (text.Contains("Reading"))
						{
							Form1.SharedUI.ProgressBar1.Text = "Reading Data...";
						}
						if (text.Contains("Done"))
						{
							Form1.SharedUI.ProgressBar1.Text = "Analyzing...";
						}
						if (text.Contains("Erasing Partition : persist"))
						{
							if (Form1.SharedUI.CkReadAndroidInfo.Checked)
							{
								get_info();
							}
							else
							{
								UiManager.Richlogs("FAIL ", Color.Red);
								UiManager.Richlogs("(EXT4 MOUNT FAILED)", Color.DarkOrange, isBold: true, NextLine: true);
							}
							UiManager.Richlogs("- Erasing FRP Lock : ", Color.White, isBold: false);
							Form1.SharedUI.ProgressBar1.Text = "Erasing FRP...";
						}
						if (text.Contains("Erasing Partition : userdata"))
						{
							UiManager.Richlogs("OK", Color.FromArgb(0, 85, 207), isBold: true, NextLine: true);
							UiManager.Richlogs("- Erasing Userdata : ", Color.White, isBold: false);
							Form1.SharedUI.ProgressBar1.Text = "Erasing Data...";
						}
						if (text.Contains("Reset Device"))
						{
							UiManager.Richlogs("OK", Color.FromArgb(0, 85, 207), isBold: true, NextLine: true);
							UiManager.Richlogs("- Reboot Device : ", Color.White, isBold: false);
							Form1.SharedUI.ProgressBar1.Text = "Reboot Device..";
						}
					}
					if (Operators.CompareString(SPDR.Type_Operation, "Remove Frp", TextCompare: false) == 0)
					{
						if (text.Contains("Reading"))
						{
							Form1.SharedUI.ProgressBar1.Text = "Reading Data...";
						}
						if (text.Contains("FRP Data"))
						{
							if (Form1.SharedUI.CkReadAndroidInfo.Checked)
							{
								get_info();
							}
							else
							{
								UiManager.Richlogs("FAIL ", Color.Red);
								UiManager.Richlogs("(EXT4 MOUNT FAILED)", Color.DarkOrange, isBold: true, NextLine: true);
							}
							UiManager.Richlogs("- Remove FRP Lock : ", Color.White, isBold: false);
							Form1.SharedUI.ProgressBar1.Text = "Removing...";
						}
						if (text.Contains("Reset Device"))
						{
							UiManager.Richlogs("OK", Color.FromArgb(0, 85, 207), isBold: true, NextLine: true);
							UiManager.Richlogs("- Reboot Device : ", Color.White, isBold: false);
							Form1.SharedUI.ProgressBar1.Text = "Reboot Device..";
						}
					}
					if (Operators.CompareString(SPDR.Type_Operation, "Factory Reset Data", TextCompare: false) == 0)
					{
						if (text.Contains("Reading"))
						{
							Form1.SharedUI.ProgressBar1.Text = "Reading Data...";
						}
						if (text.Contains("Writing Partition"))
						{
							if (Form1.SharedUI.CkReadAndroidInfo.Checked)
							{
								get_info();
							}
							else
							{
								UiManager.Richlogs("FAIL ", Color.Red);
								UiManager.Richlogs("(EXT4 MOUNT FAILED)", Color.DarkOrange, isBold: true, NextLine: true);
							}
							UiManager.Richlogs("- Factory Reset Data : ", Color.White, isBold: false);
							Form1.SharedUI.ProgressBar1.Text = "Reseting Data...";
						}
						if (text.Contains("Reset Device"))
						{
							UiManager.Richlogs("OK", Color.FromArgb(0, 85, 207), isBold: true, NextLine: true);
							UiManager.Richlogs("- Remove Frp Lock : ", Color.White, isBold: false);
							Form1.SharedUI.ProgressBar1.Text = "Removing...";
							UiManager.Richlogs("OK", Color.FromArgb(0, 85, 207), isBold: true, NextLine: true);
							UiManager.Richlogs("- Reboot Device : ", Color.White, isBold: false);
							Form1.SharedUI.ProgressBar1.Text = "Reboot Device..";
						}
					}
					if (text.Contains("failed") | text.Contains("usb"))
					{
						Form1.SharedUI.ProgressBar4.Value = 100;
						SerialCOM.MSL = "DISREAD";
						Form1.SharedUI.ProgressBar4.Text = "";
						Form1.SharedUI.ProgressBar4.Value = 0;
						UiManager.Richlogs("Failed", Color.Red, isBold: true, NextLine: true);
					}
					if (text.Contains("%"))
					{
						string text2 = text;
						int num = text2.LastIndexOf('[');
						if (num > -1)
						{
							text2 = text2.Substring(checked(num + 1)).Replace("%]", string.Empty);
							UiManager.ProcessBar1n(Convert.ToInt64(text2));
						}
					}
				}
				process.WaitForExit();
			}
			uniCommand = string.Empty;
		}
		catch (Exception ex7)
		{
			ProjectData.SetProjectError(ex7);
			Exception ex8 = ex7;
			UiManager.ProcessBar2(100L);
			UiManager.Richlogs("Failed", Color.Red, isBold: true, NextLine: true);
			ProjectData.ClearProjectError();
		}
	}

	public static bool Prepare_Exploit(string val)
	{
		fdl1_addr = val;
		switch (val)
		{
		case "0x5000":
			exploit = "0x4ee8";
			return true;
		case "0x00005000":
			exploit = "0x4ee8";
			return true;
		case "0x65000800":
			exploit = "0x65015f08";
			return true;
		default:
			exploit = string.Empty;
			return false;
		}
	}

	public static ulong StrToSize(string str)
	{
		int num = 0;
		ulong num2 = Convert.ToUInt64(str.Replace("K", string.Empty).Replace("k", string.Empty).Replace("M", string.Empty)
			.Replace("m", string.Empty)
			.Replace("G", string.Empty)
			.Replace("g", string.Empty));
		if (str.EndsWith("K") || str.EndsWith("k"))
		{
			num = 10;
		}
		else if (str.EndsWith("M") || str.EndsWith("m"))
		{
			num = 20;
		}
		else
		{
			if (!str.EndsWith("G") && !str.EndsWith("g"))
			{
				throw new Exception("unknown size suffix");
			}
			num = 30;
		}
		checked
		{
			if (num != 0)
			{
				long num3 = (long)num2;
				num3 >>= 63 - num;
				if (num3 != 0L && num3 != -1)
				{
					throw new Exception("size overflow on multiply");
				}
			}
			return num2 << num;
		}
	}

	public static byte[] TakeByte(byte[] source, int start, long length)
	{
		return source.Select([SpecialName] (byte element) => element).Skip(start).Take(checked((int)length))
			.ToArray();
	}

	public static byte[][] Split(this byte[] input, byte[] separator)
	{
		List<byte[]> list = new List<byte[]>();
		checked
		{
			using (MemoryStream memoryStream = new MemoryStream(input))
			{
				while (memoryStream.Position + 1 < input.Length)
				{
					int num = Find(input, separator, (int)memoryStream.Position);
					byte[] array = ((num != -1) ? new byte[(int)(num - memoryStream.Position) - 1 + 1] : new byte[(int)(input.Length - memoryStream.Position) - 1 + 1]);
					if (array.Length != 0)
					{
						memoryStream.Read(array, 0, array.Length);
						list.Add(array);
					}
					memoryStream.Seek(separator.Length, SeekOrigin.Current);
				}
			}
			return list.ToArray();
		}
	}

	public static int Find(this byte[] haystack, byte[] needle, int start = 0)
	{
		int num = needle.Length;
		checked
		{
			int num2 = haystack.Length - num;
			int num3 = num2;
			for (int i = start; i <= num3; i++)
			{
				int j;
				for (j = 0; j < num && needle[j] == haystack[i + j]; j++)
				{
				}
				if (j == num)
				{
					return i;
				}
			}
			return -1;
		}
	}

	public static int FindBinary(byte[] data, byte[] needle, int pos = 0)
	{
		byte[][] array = Split(needle, new byte[1] { 46 });
		int num = 0;
		List<int> list = new List<int>();
		checked
		{
			while (true)
			{
				if (num != -1)
				{
					num = Find(data, array[0], pos + num);
					if (num == -1)
					{
						if (list.Count <= 0)
						{
							break;
						}
						foreach (int item in list)
						{
							bool flag = false;
							int num2 = item + array[0].Length;
							int num3 = array.Length - 1;
							for (int i = 1; i <= num3; i++)
							{
								num2++;
								if (Find(data, array[i], num2) == 0)
								{
									num2 += array[i].Length;
									continue;
								}
								flag = true;
								break;
							}
							if (!flag)
							{
								return item + pos;
							}
						}
					}
					else
					{
						list.Add(num);
						num++;
					}
					continue;
				}
				return 0;
			}
			return 0;
		}
	}

	public static byte[] parse_reverse(byte[] data)
	{
		return StringToByteArray(ReverseBytes(BitConverter.ToString(data).Replace("-", " ")));
	}

	public static string ReverseBytes(string value)
	{
		string text = string.Empty;
		string text2 = value.Replace(" ", string.Empty).Replace("-", string.Empty);
		checked
		{
			for (int i = text2.Length - 2; i >= 0; i += -2)
			{
				text += text2.Substring(i, 2);
			}
			return text;
		}
	}

	public static byte[] StringToByteArray(string hex)
	{
		hex = hex.Replace(" ", string.Empty).Replace("-", string.Empty);
		checked
		{
			byte[] array = new byte[unchecked(hex.Length / 2) - 1 + 1];
			int num = array.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				array[i] = Convert.ToByte(hex.Substring(i * 2, 2), 16);
			}
			return array;
		}
	}

	public static void Prepairing()
	{
		if (!Directory.Exists(UniDir))
		{
			Directory.CreateDirectory(UniDir);
			if (Operators.CompareString(SPDR.Type_Operation, "Remove Frp_Userdata", TextCompare: false) == 0)
			{
				File.WriteAllBytes(UniDir + "\\chiller.tft", Resources.sleep2);
			}
			else
			{
				File.WriteAllBytes(UniDir + "\\chiller.tft", Resources.sleep);
			}
			if (Operators.CompareString(SPDR.Type_Operation, "Factory_Reset_Data", TextCompare: false) == 0)
			{
				File.WriteAllBytes(UniDir + "\\2", Resources.m_sp);
			}
			File.WriteAllBytes(UniDir + "\\Channel9.dll", Resources.Channel9);
			File.WriteAllBytes(UniDir + "\\msvcp140d.dll", Resources.msvcp140d);
			File.WriteAllBytes(UniDir + "\\ucrtbased.dll", Resources.ucrtbased);
			File.WriteAllBytes(UniDir + "\\vcruntime140d.dll", Resources.vcruntime140d);
			return;
		}
		ProcessKill();
		UiManager.Delay(1.0);
		Cleaner();
		UiManager.Delay(1.0);
		Directory.CreateDirectory(UniDir);
		if (Operators.CompareString(SPDR.Type_Operation, "Remove Frp_Userdata", TextCompare: false) == 0)
		{
			File.WriteAllBytes(UniDir + "\\chiller.tft", Resources.sleep2);
		}
		else
		{
			File.WriteAllBytes(UniDir + "\\chiller.tft", Resources.sleep);
		}
		if (Operators.CompareString(SPDR.Type_Operation, "Factory_Reset_Data", TextCompare: false) == 0)
		{
			File.WriteAllBytes(UniDir + "\\2", Resources.m_sp);
		}
		File.WriteAllBytes(UniDir + "\\Channel9.dll", Resources.Channel9);
		File.WriteAllBytes(UniDir + "\\msvcp140d.dll", Resources.msvcp140d);
		File.WriteAllBytes(UniDir + "\\ucrtbased.dll", Resources.ucrtbased);
		File.WriteAllBytes(UniDir + "\\vcruntime140d.dll", Resources.vcruntime140d);
	}

	public static void ProcessKill()
	{
		string[] array = new string[4] { "chiller", "chiller.tft", "c4", "c4.exe" };
		foreach (string text in array)
		{
			Process[] processes = Process.GetProcesses();
			foreach (Process process in processes)
			{
				if (Operators.CompareString(process.ProcessName.ToLower() ?? string.Empty, text.ToLower() ?? string.Empty, TextCompare: false) == 0)
				{
					process.Kill();
					process.WaitForExit();
					process.Dispose();
				}
			}
		}
	}

	public static void Cleaner()
	{
		if (!Directory.Exists(UniDir))
		{
			return;
		}
		DirectoryInfo directoryInfo = new DirectoryInfo(UniDir);
		foreach (FileInfo item in directoryInfo.EnumerateFiles())
		{
			item.Delete();
		}
		foreach (DirectoryInfo item2 in directoryInfo.EnumerateDirectories())
		{
			item2.Delete(recursive: true);
		}
		directoryInfo.Delete(recursive: true);
	}

	public static void CleanerTmp()
	{
		if (!Directory.Exists(UniTmp))
		{
			return;
		}
		DirectoryInfo directoryInfo = new DirectoryInfo(UniTmp);
		foreach (FileInfo item in directoryInfo.EnumerateFiles())
		{
			item.Delete();
		}
		foreach (DirectoryInfo item2 in directoryInfo.EnumerateDirectories())
		{
			item2.Delete(recursive: true);
		}
		directoryInfo.Delete(recursive: true);
	}
}
