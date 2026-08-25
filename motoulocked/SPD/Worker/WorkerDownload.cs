using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.FileIO;
using motoulocked.motoulocked;
using motoulocked.My;
using motoulocked.MyUI;

namespace motoulocked.SPD.Worker;

[StandardModule]
internal sealed class WorkerDownload
{
	public static string UniFirmware = string.Empty;

	public static string UniFoldersave = string.Empty;

	public static string UniStringXML = string.Empty;

	public static string UniFileXML = string.Empty;

	public static long TotProgress = 0L;

	public static int totalchecked2 = 0;

	public static int totaldo = 0;

	public static bool isSpdOneClick = false;

	public static string PortCom = string.Empty;

	public static string String_14;

	public static string String_15;

	private static bool Boolean_2;

	public static void MethodD_113()
	{
		MethodD_115(SPDR.ThisLocation + "Tmp\\" + String_14, Form1.String_7);
	}

	public static void MethodD_115(string AA, string GG)
	{
		byte[] bBB = File.ReadAllBytes(AA);
		byte[] bytes = Encoding.UTF8.GetBytes(GG);
		bytes = SHA256.Create().ComputeHash(bytes);
		byte[] bytes2 = MethodD_116(bBB, bytes);
		File.WriteAllBytes(AA, bytes2);
	}

	public static byte[] MethodD_116(byte[] BBB, byte[] GGG)
	{
		byte[] array = null;
		byte[] salt = new byte[9] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
		checked
		{
			using MemoryStream memoryStream = new MemoryStream();
			using AesCryptoServiceProvider aesCryptoServiceProvider = new AesCryptoServiceProvider();
			aesCryptoServiceProvider.KeySize = 256;
			aesCryptoServiceProvider.BlockSize = 128;
			Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(GGG, salt, 1000);
			aesCryptoServiceProvider.Key = rfc2898DeriveBytes.GetBytes((int)Math.Round((double)aesCryptoServiceProvider.KeySize / 8.0));
			aesCryptoServiceProvider.IV = rfc2898DeriveBytes.GetBytes((int)Math.Round((double)aesCryptoServiceProvider.BlockSize / 8.0));
			aesCryptoServiceProvider.Mode = CipherMode.CBC;
			using (CryptoStream cryptoStream = new CryptoStream(memoryStream, aesCryptoServiceProvider.CreateDecryptor(), CryptoStreamMode.Write))
			{
				cryptoStream.Write(BBB, 0, BBB.Length);
				cryptoStream.Close();
			}
			return memoryStream.ToArray();
		}
	}

	private static void MethodD_100()
	{
		try
		{
			string text = SPDR.ThisLocation + "Tmp\\" + String_14;
			try
			{
				File.Delete(text);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
			using WebClient webClient = new WebClient();
			webClient.DownloadProgressChanged += MethodD_98;
			webClient.DownloadFileCompleted += MethodD_99;
			webClient.DownloadFileAsync(new Uri(SPDR.Link_Payload), text);
			while (webClient.IsBusy)
			{
				Application.DoEvents();
			}
			if (File.Exists(text))
			{
				Boolean_2 = true;
			}
			else
			{
				Boolean_2 = false;
			}
		}
		catch (Exception ex3)
		{
			ProjectData.SetProjectError(ex3);
			Exception ex4 = ex3;
			ProjectData.ClearProjectError();
		}
	}

	public static void MethodD_144(string Commands)
	{
		Process process = new Process();
		process.StartInfo.FileName = Application.StartupPath + "\\bin\\Tunlocker Tool.exe";
		process.StartInfo.Arguments = "/c " + Commands;
		process.StartInfo.CreateNoWindow = true;
		process.StartInfo.UseShellExecute = false;
		process.StartInfo.RedirectStandardOutput = true;
		process.StartInfo.RedirectStandardError = true;
		process.Start();
		process.WaitForExit();
	}

	private static void MethodD_100(string PPP)
	{
		try
		{
			string text = "Tmp\\" + String_14;
			string text2 = "Tmp\\" + String_15;
			try
			{
				MethodD_144("rd /s /q \"" + text2 + "\"");
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
			try
			{
				MethodD_144("rd /s /q \"" + text2 + "\"");
			}
			catch (Exception ex3)
			{
				ProjectData.SetProjectError(ex3);
				Exception ex4 = ex3;
				ProjectData.ClearProjectError();
			}
			try
			{
				MethodD_144("rd /s /q \"" + text2 + "\"");
			}
			catch (Exception ex5)
			{
				ProjectData.SetProjectError(ex5);
				Exception ex6 = ex5;
				ProjectData.ClearProjectError();
			}
			try
			{
				MyProject.Computer.FileSystem.DeleteDirectory(text2, DeleteDirectoryOption.DeleteAllContents);
			}
			catch (Exception ex7)
			{
				ProjectData.SetProjectError(ex7);
				Exception ex8 = ex7;
				ProjectData.ClearProjectError();
			}
			try
			{
				MyProject.Computer.FileSystem.DeleteDirectory(text2, DeleteDirectoryOption.DeleteAllContents);
			}
			catch (Exception ex9)
			{
				ProjectData.SetProjectError(ex9);
				Exception ex10 = ex9;
				ProjectData.ClearProjectError();
			}
			try
			{
				MyProject.Computer.FileSystem.DeleteDirectory(text2, DeleteDirectoryOption.DeleteAllContents);
			}
			catch (Exception ex11)
			{
				ProjectData.SetProjectError(ex11);
				Exception ex12 = ex11;
				ProjectData.ClearProjectError();
			}
			if (File.Exists(text))
			{
				Form1.SharedUI.ProgressBar1.Text = "Connecting...";
				MethodD_144(("bin\\7z.exe x " + text + " -p" + PPP + " -o" + text2) ?? "");
				if (Directory.Exists(text2))
				{
					Boolean_2 = true;
				}
				else
				{
					Boolean_2 = false;
				}
				return;
			}
			using (WebClient webClient = new WebClient())
			{
				webClient.DownloadProgressChanged += MethodD_98;
				webClient.DownloadFileCompleted += MethodD_99;
				webClient.DownloadFileAsync(new Uri(SPDR.Link_Payload), text);
				while (webClient.IsBusy)
				{
					Application.DoEvents();
				}
			}
			Form1.SharedUI.ProgressBar1.Text = "Connecting...";
			MethodD_144(("bin\\7z.exe x " + text + " -p" + PPP + " -o" + text2) ?? "");
			if (Directory.Exists(text2))
			{
				Boolean_2 = true;
			}
			else
			{
				Boolean_2 = false;
			}
		}
		catch (Exception ex13)
		{
			ProjectData.SetProjectError(ex13);
			Exception ex14 = ex13;
			ProjectData.ClearProjectError();
		}
	}

	private static void MethodD_98(object sender, DownloadProgressChangedEventArgs e)
	{
		Form1.SharedUI.ProgressBar4.Value = e.ProgressPercentage;
	}

	private static void MethodD_99(object sender, AsyncCompletedEventArgs e)
	{
		if (e.Error != null)
		{
			Boolean_2 = false;
		}
		else
		{
			Boolean_2 = true;
		}
	}

	public static bool get_file()
	{
		String_15 = "1";
		String_14 = "1.zip";
		try
		{
			File.Delete(SPDR.ThisLocation + "Tmp\\" + String_14);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
		MethodD_100(Form1.String_7);
		if (Boolean_2)
		{
			return true;
		}
		return false;
	}

	public static bool load_loder()
	{
		bool result;
		try
		{
			string path = SPDR.ThisLocation + "Tmp\\" + String_15 + "\\3";
			string[] array = File.ReadAllText(path).Split(':');
			uni.fdl1_addr = array[0].Trim();
			uni.fdl1_location = SPDR.ThisLocation + "Tmp\\" + String_15 + "\\1";
			uni.fdl2_addr = array[1].Trim();
			uni.fdl2_location = SPDR.ThisLocation + "Tmp\\" + String_15 + "\\2";
			File.Delete(path);
			uni.uniCommand = string.Empty;
			uni.uniCommand += "-progress -wait 5 -timeout " + uni.Timeout;
			if (File.Exists(uni.fdl2_location))
			{
				uni.uniCommand += "-fdl \"" + uni.fdl1_location + "\" " + uni.fdl1_addr + " -fdl \"" + uni.fdl2_location + "\" " + uni.fdl2_addr + " -exec ";
			}
			else
			{
				uni.uniCommand += "-fdl \"" + uni.fdl1_location + "\" " + uni.fdl1_addr + " -exec ";
			}
			result = true;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			result = false;
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public static bool Download_loder()
	{
		UiManager.Richlogs("OK", Color.FromArgb(21, 87, 255), isBold: true, NextLine: true);
		UiManager.Richlogs("- Connecting To Server : ", Color.Black, isBold: false);
		Form1.SharedUI.ProgressBar1.Text = "Connecting..";
		bool result;
		if (get_file())
		{
			result = true;
		}
		else
		{
			try
			{
				File.Delete(SPDR.ThisLocation + "Tmp\\" + String_14);
				UiManager.Richlogs("Failed", Color.Red, isBold: true, NextLine: true);
				result = false;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				UiManager.Richlogs("Failed", Color.Red, isBold: true, NextLine: true);
				result = false;
				ProjectData.ClearProjectError();
			}
		}
		return result;
	}

	public static bool remove_frp()
	{
		string text = "\"" + Application.StartupPath + "\\tmp\\IN\"";
		if (Download())
		{
			if (Form1.SharedUI.CkReadAndroidInfo.Checked)
			{
				uni.uniCommand += "-r vbmeta_product_a " + text + " -erase_frp -reset";
			}
			else
			{
				uni.uniCommand += "-erase_frp -reset";
			}
			uni.uni_cmd();
			return true;
		}
		return false;
	}

	public static bool remove_Userdata()
	{
		string text = "\"" + Application.StartupPath + "\\tmp\\IN\"";
		if (Download())
		{
			if (Form1.SharedUI.CkReadAndroidInfo.Checked)
			{
				uni.uniCommand += "-r vbmeta_product_a " + text + " -erase_frp -e userdata -reset";
			}
			else
			{
				uni.uniCommand += "-erase_frp -e userdata -reset";
			}
			uni.uni_cmd();
			return true;
		}
		return false;
	}

	public static bool Factory_Reset_Data()
	{
		string text = "\"" + Application.StartupPath + "\\tmp\\IN\"";
		string text2 = "\"" + uni.UniDir + "\\2\"";
		if (Download())
		{
			if (Form1.SharedUI.CkReadAndroidInfo.Checked)
			{
				uni.uniCommand += "-r vbmeta_product_a " + text + " -w misc " + text2 + " -erase_frp -reset";
			}
			else
			{
				uni.uniCommand += "-w misc " + text2 + " -erase_frp -reset";
			}
			uni.uni_cmd();
			return true;
		}
		return false;
	}

	public static bool Download()
	{
		UiManager.Richlogs("- Waiting For USB SPRD Devices : ", Color.White, isBold: false);
		switch (MyDisplay.USBSearchPort())
		{
		case "NotFound":
			SerialCOM.MSL = "";
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.Red;
			Form1.SharedUI.RichTextBox1.AppendText("Not Found");
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
			Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- TimeOut, Check The Cable And Try Again");
			Form1.SharedUI.MaterialButton8.Enabled = false;
			Form1.SharedUI.MaterialCard3.Enabled = true;
			Form1.SharedUI.MaterialCard5.Enabled = true;
			Form1.SharedUI.ProgressBar4.Visible = false;
			Form1.SharedUI.ProgressBar4.Maximum = 100;
			Form1.SharedUI.ProgressBar4.Value = 0;
			Form1.SharedUI.Guna2TaskBarProgress1.State = Guna2TaskBarProgress.TaskbarStates.Normal;
			Form1.SharedUI.Guna2TaskBarProgress1.Value = 0;
			Form1.SharedUI.ProgressBar1.Roll = false;
			Form1.SharedUI.ProgressBar1.Text = "100%";
			uni.CleanerTmp();
			uni.Cleaner();
			return false;
		case "Cancel":
			Form1.SharedUI.ProgressBar4.Text = "";
			Form1.SharedUI.ProgressBar4.Value = 0;
			uni.CleanerTmp();
			uni.Cleaner();
			return false;
		case "Connected":
			SerialCOM.MSL = "DISREAD";
			Form1.SharedUI.ProgressBar4.Text = "";
			Form1.SharedUI.ProgressBar4.Value = 0;
			UiManager.Richlogs("OK", Color.FromArgb(0, 85, 207), isBold: true, NextLine: true);
			UiManager.Richlogs("- Prepairing Device : ", Color.White, isBold: false);
			Form1.SharedUI.ProgressBar1.Text = "Prepairing Device..";
			SPDR.startTime = Strings.Format(DateAndTime.TimeOfDay, "hh:mm:ss");
			uni.Cleaner();
			uni.Prepairing();
			if (Download_loder() && load_loder())
			{
				return true;
			}
			return false;
		default:
		{
			bool result = default(bool);
			return result;
		}
		}
	}
}
