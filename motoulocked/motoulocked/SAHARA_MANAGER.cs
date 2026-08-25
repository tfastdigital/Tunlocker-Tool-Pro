using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace motoulocked.motoulocked;

[StandardModule]
internal sealed class SAHARA_MANAGER
{
	[CompilerGenerated]
	internal sealed class _Closure_0024__40_002D0
	{
		public string _0024VB_0024Local_string_to_find;

		public _Closure_0024__40_002D0(_Closure_0024__40_002D0 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024Local_string_to_find = arg0._0024VB_0024Local_string_to_find;
			}
		}

		[SpecialName]
		internal bool _Lambda_0024__0(FileSystemInfo i)
		{
			return i.Name.IndexOf(_0024VB_0024Local_string_to_find, StringComparison.CurrentCultureIgnoreCase) >= 0;
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__40_002D1
	{
		public FileSystemInfo _0024VB_0024Local_r;

		public _Closure_0024__40_002D1(_Closure_0024__40_002D1 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024Local_r = arg0._0024VB_0024Local_r;
			}
		}

		[SpecialName]
		internal void _Lambda_0024__1()
		{
			EDL.SharedEDL.txtloader.Text = _0024VB_0024Local_r.FullName;
		}
	}

	public static bool cpu64 = false;

	public static SAHARA.SAHARA_PBL_INFO _pblInfo = default(SAHARA.SAHARA_PBL_INFO);

	public static bool sendingloaderStatus;

	private static bool Boolean_2;

	public static bool IsLoaderExist = false;

	public static string FileLoader;

	public static string String_14;

	public static bool isQualcommNewGenerationChipset = false;

	public static BackgroundWorker SaharaWorker = new BackgroundWorker
	{
		WorkerSupportsCancellation = true,
		WorkerReportsProgress = true
	};

	public static byte[] Loader { get; set; }

	public static bool IsAutoLoader { get; set; } = false;


	public static SAHARA.SAHARA_MODE Mode { get; set; }

	public static void SendBytes(byte[] bytes)
	{
		PortIOMe.PortWrite(bytes);
		Thread.Sleep(80);
	}

	public static object RawDeserialize(byte[] rawData, int position, Type anyType)
	{
		int num = Marshal.SizeOf(anyType);
		if (num > rawData.Length)
		{
			return null;
		}
		IntPtr intPtr = Marshal.AllocHGlobal(num);
		Marshal.Copy(rawData, position, intPtr, num);
		object objectValue = RuntimeHelpers.GetObjectValue(Marshal.PtrToStructure(intPtr, anyType));
		Marshal.FreeHGlobal(intPtr);
		return objectValue;
	}

	public static void MethodD_113()
	{
		MethodD_115(EDL.ThisLocation + "Tmp\\" + String_14, Form1.String_7);
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
			string text = EDL.ThisLocation + "Tmp\\" + String_14;
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
			webClient.DownloadFileAsync(new Uri(EDL.Link_Loader), text);
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
		String_14 = "1";
		try
		{
			File.Delete(EDL.ThisLocation + "Tmp\\" + String_14);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
		MethodD_100();
		if (!Boolean_2)
		{
			return false;
		}
		return true;
	}

	public static bool SaharaConnect()
	{
		cpu64 = false;
		UiManager.Richlogs("OK", Color.FromArgb(21, 87, 255), isBold: true, NextLine: true);
		UiManager.Richlogs("- PortName : ", Color.Black, isBold: false);
		UiManager.Richlogs("Qualcomm HS-USB QDLoader 9008 (COM" + PortIOMe.PortCOM + ")", Color.Orange, isBold: true, NextLine: true);
		UiManager.Richlogs("- Connection State : ", Color.Black, isBold: false);
		UiManager.Richlogs("High-Speed", Color.Lime, isBold: true, NextLine: true);
		UiManager.Richlogs("- Connecting Target : ", Color.Black, isBold: false);
		Form1.SharedUI.ProgressBar1.Text = "Connect Device...";
		bool result;
		if (!PortIOMe.PortsOpen())
		{
			try
			{
				if (PortIOMe.Ports.IsOpen)
				{
					PortIOMe.Ports.Close();
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
			UiManager.Richlogs("Failed To Open Port", Color.Red, isBold: true, NextLine: true);
			result = false;
		}
		else
		{
			UiManager.Richlogs("OK", Color.FromArgb(21, 87, 255), isBold: true, NextLine: true);
			UiManager.Richlogs("- Connecting To Server : ", Color.Black, isBold: false);
			Form1.SharedUI.ProgressBar1.Text = "Connecting..";
			if (EDL.SharedEDL.Guna2RadioButton11.Checked)
			{
				goto IL_020f;
			}
			if (get_file())
			{
				MethodD_113();
				Loader = File.ReadAllBytes(EDL.ThisLocation + "Tmp\\" + String_14);
				if (Encoding.UTF8.GetString(Loader).Contains("ELF"))
				{
					File.Delete(EDL.ThisLocation + "Tmp\\" + String_14);
					goto IL_020f;
				}
				UiManager.Richlogs("Loader is Invalid Or Encrypted", Color.Red, isBold: false);
				File.Delete(EDL.ThisLocation + "Tmp\\" + String_14);
				result = false;
			}
			else
			{
				File.Delete(EDL.ThisLocation + "Tmp\\" + String_14);
				UiManager.Richlogs("Failed", Color.Red, isBold: true, NextLine: true);
				try
				{
					if (PortIOMe.Ports.IsOpen)
					{
						PortIOMe.Ports.Close();
					}
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
				result = false;
			}
		}
		goto IL_0371;
		IL_0371:
		return result;
		IL_020f:
		UiManager.Richlogs("OK", Color.FromArgb(21, 87, 255), isBold: true, NextLine: true);
		UiManager.Richlogs("- Send Handshake Protocol : ", Color.Black, isBold: false);
		Form1.SharedUI.ProgressBar1.Text = "SendHelloResponse...";
		if (Form1.SharedUI.RichTextBox1.Text.Contains("error[0]"))
		{
			result = false;
		}
		else
		{
			try
			{
				byte[] array = PortIOMe.PortRead(50);
				if (array.Length == 0)
				{
					if (HangHack(SAHARA.SAHARA_MODE.SAHARA_MODE_COMMAND))
					{
						result = true;
					}
					else
					{
						try
						{
							if (PortIOMe.Ports.IsOpen)
							{
								PortIOMe.Ports.Close();
							}
						}
						catch (Exception projectError2)
						{
							ProjectData.SetProjectError(projectError2);
							ProjectData.ClearProjectError();
						}
						result = false;
					}
				}
				else if (Form1.SharedUI.RichTextBox1.Text.Contains("error[0]"))
				{
					result = false;
				}
				else
				{
					if (array.Length == Marshal.SizeOf(typeof(SAHARA.SAHARA_REQUESTS_HELLO)))
					{
						SendHelloResponse((SAHARA.SAHARA_REQUESTS_HELLO)RuntimeHelpers.GetObjectValue(RawDeserialize(array, 0, typeof(SAHARA.SAHARA_REQUESTS_HELLO))), SAHARA.SAHARA_MODE.SAHARA_MODE_COMMAND);
					}
					result = !Form1.SharedUI.RichTextBox1.Text.Contains("error[0]");
				}
			}
			catch (Exception ex3)
			{
				ProjectData.SetProjectError(ex3);
				Exception ex4 = ex3;
				try
				{
					if (PortIOMe.Ports.IsOpen)
					{
						PortIOMe.Ports.Close();
					}
				}
				catch (Exception projectError3)
				{
					ProjectData.SetProjectError(projectError3);
					ProjectData.ClearProjectError();
				}
				UiManager.Richlogs("Failed", Color.Red, isBold: true, NextLine: true);
				result = false;
				ProjectData.ClearProjectError();
			}
		}
		goto IL_0371;
	}

	public static bool HangHack(SAHARA.SAHARA_MODE mode_Conflict)
	{
		bool result;
		try
		{
			SAHARA.SAHARA_SWITCH_PACKET msg = default(SAHARA.SAHARA_SWITCH_PACKET);
			msg.header.command = SAHARA.SAHARA_CMD.SAHARA_CMD_SWITCH_MODE;
			msg.header.size = Marshal.SizeOf(typeof(SAHARA.SAHARA_SWITCH_PACKET));
			msg.mode = SAHARA.SAHARA_MODE.SAHARA_MODE_IMAGE_PENDING;
			PortIOMe.PortWrite(SerializeMessage(msg));
			int num = 0;
			while (true)
			{
				if (Form1.SharedUI.RichTextBox1.Text.Contains("error[0]"))
				{
					result = false;
					break;
				}
				byte[] bytes = PortIOMe.PortRead(0);
				if (Encoding.UTF8.GetString(bytes).Contains("xml"))
				{
					UiManager.Richlogs("Already", Color.FromArgb(21, 87, 255), isBold: true, NextLine: true);
					result = true;
					break;
				}
				Thread.Sleep(500);
				if (num == 3)
				{
					UiManager.Richlogs("error[Reconnect Device]", Color.Red, isBold: true, NextLine: true);
					try
					{
						if (PortIOMe.Ports.IsOpen)
						{
							PortIOMe.Ports.Close();
						}
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						ProjectData.ClearProjectError();
					}
					result = false;
					break;
				}
				num = checked(num + 1);
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			UiManager.Richlogs("error[Reconnect Device]", Color.Red, isBold: true, NextLine: true);
			result = false;
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public static byte[] SerializeMessage<T>(T msg) where T : struct
	{
		if (!Form1.SharedUI.RichTextBox1.Text.Contains("error[0]"))
		{
			int num = Marshal.SizeOf(typeof(T));
			byte[] array = new byte[checked(num - 1 + 1)];
			IntPtr intPtr = Marshal.AllocHGlobal(num);
			Marshal.StructureToPtr(msg, intPtr, fDeleteOld: true);
			Marshal.Copy(intPtr, array, 0, num);
			Marshal.FreeHGlobal(intPtr);
			return array;
		}
		byte[] result = default(byte[]);
		return result;
	}

	public static bool ValidateResponse(SAHARA.SAHARA_CMD expectedCMD, byte[] response)
	{
		if (!Form1.SharedUI.RichTextBox1.Text.Contains("error[0]"))
		{
			int num = response.Length;
			if (expectedCMD == SAHARA.SAHARA_CMD.SAHARA_CMD_READ_DATA && num == 20)
			{
				cpu64 = false;
				return true;
			}
			if (expectedCMD == SAHARA.SAHARA_CMD.SAHARA_CMD_READ_DATA && num == 32)
			{
				cpu64 = true;
				return true;
			}
			if (expectedCMD == SAHARA.SAHARA_CMD.SAHARA_CMD_HELLO_REQ && num == 48)
			{
				return true;
			}
			if (expectedCMD == SAHARA.SAHARA_CMD.SAHARA_CMD_IMG_END_TRSFR && num == 16)
			{
				return true;
			}
			if (expectedCMD == SAHARA.SAHARA_CMD.SAHARA_CMD_IMG_DONE_RESP)
			{
				_ = 16;
			}
			if (expectedCMD == SAHARA.SAHARA_CMD.SAHARA_CMD_READY && num == 8)
			{
				return true;
			}
			if (expectedCMD == SAHARA.SAHARA_CMD.SAHARA_CMD_EXECUTE_RESPONSE && num == 16)
			{
				return true;
			}
			return false;
		}
		bool result = default(bool);
		return result;
	}

	public static object SendHelloResponse(SAHARA.SAHARA_REQUESTS_HELLO pkt, SAHARA.SAHARA_MODE mode_Conflict)
	{
		if (!Form1.SharedUI.RichTextBox1.Text.Contains("error[0]"))
		{
			if (mode_Conflict == SAHARA.SAHARA_MODE.SAHARA_MODE_COMMAND)
			{
				pkt.header.command = SAHARA.SAHARA_CMD.SAHARA_CMD_HELLO_RESP;
				pkt.mode = SAHARA.SAHARA_MODE.SAHARA_MODE_COMMAND;
				pkt.header.size = Marshal.SizeOf(typeof(SAHARA.SAHARA_REQUESTS_HELLO));
				pkt.maxCommandPacketSize = 0;
				mode_Conflict = SAHARA.SAHARA_MODE.SAHARA_MODE_COMMAND;
				SendBytes(SerializeMessage(pkt));
				UiManager.Richlogs("OK", Color.Lime, isBold: true, NextLine: true);
			}
			if (Form1.SharedUI.RichTextBox1.Text.Contains("error[0]"))
			{
				return false;
			}
			if (mode_Conflict == SAHARA.SAHARA_MODE.SAHARA_MODE_IMAGE_PENDING)
			{
				pkt.header.command = SAHARA.SAHARA_CMD.SAHARA_CMD_HELLO_RESP;
				pkt.mode = SAHARA.SAHARA_MODE.SAHARA_MODE_IMAGE_PENDING;
				pkt.header.size = Marshal.SizeOf(typeof(SAHARA.SAHARA_REQUESTS_HELLO));
				pkt.maxCommandPacketSize = 0;
				SendBytes(SerializeMessage(pkt));
			}
			if (Form1.SharedUI.RichTextBox1.Text.Contains("error[0]"))
			{
				return false;
			}
			byte[] array = PortIOMe.PortRead(0);
			if (ValidateResponse(SAHARA.SAHARA_CMD.SAHARA_CMD_READY, array))
			{
				if (Form1.SharedUI.RichTextBox1.Text.Contains("error[0]"))
				{
					return false;
				}
				DumpDeviceInfo();
				if (Form1.SharedUI.RichTextBox1.Text.Contains("error[0]"))
				{
					return false;
				}
				if (!SwitchMode(SAHARA.SAHARA_MODE.SAHARA_MODE_IMAGE_PENDING))
				{
					return false;
				}
			}
			if (IsLoaderExist)
			{
				if (Form1.SharedUI.RichTextBox1.Text.Contains("error[0]"))
				{
					return false;
				}
				if (ValidateResponse(SAHARA.SAHARA_CMD.SAHARA_CMD_READ_DATA, array))
				{
					if (cpu64)
					{
						SendFlashLoader64((SAHARA.SAHARA_REQUESTS_READDATA_64)RawDeserialize(array, 0, typeof(SAHARA.SAHARA_REQUESTS_READDATA_64)));
					}
					else
					{
						SendFlashLoader((SAHARA.SAHARA_REQUESTS_READDATA)RawDeserialize(array, 0, typeof(SAHARA.SAHARA_REQUESTS_READDATA)));
					}
				}
			}
			if (Form1.SharedUI.RichTextBox1.Text.Contains("error[0]"))
			{
				return false;
			}
		}
		object result = default(object);
		return result;
	}

	public static void SendFlashLoader(SAHARA.SAHARA_REQUESTS_READDATA initReq)
	{
		if (Form1.SharedUI.RichTextBox1.Text.Contains("error[0]"))
		{
			return;
		}
		checked
		{
			try
			{
				int num = 0;
				int num2 = 1;
				bool flag = false;
				Stopwatch stopwatch = new Stopwatch();
				stopwatch.Start();
				int num3 = 0;
				UiManager.Richlogs("- Sending Config Protocol : ", Color.Black, isBold: false);
				Form1.SharedUI.ProgressBar4.Text = "Sending Config...";
				UiManager.ProcessBar2(0L, 100L);
				SerialCOM.MSL = "ENREAD";
				while (!flag)
				{
					int size = initReq.size;
					int offset = initReq.offset;
					Stream input = new MemoryStream(Loader);
					using BinaryReader binaryReader = new BinaryReader(input);
					byte[] array = new byte[size - 1 + 1];
					binaryReader.BaseStream.Seek(offset, SeekOrigin.Begin);
					binaryReader.Read(array, 0, size);
					PortIOMe.PortWrite(array);
					num += array.Length;
					TimeSpan elapsed = stopwatch.Elapsed;
					UiManager.label_transferrate((double)array.Length / elapsed.TotalSeconds);
					UiManager.ProcessBar3(num, Loader.Length);
					stopwatch.Stop();
					UiManager.label_writensize(num);
					byte[] array2 = PortIOMe.PortRead(0);
					if (array2.Length == 0)
					{
						while (true)
						{
							array2 = PortIOMe.PortRead(10);
							if (array2.Length != 0)
							{
								break;
							}
							num3++;
							if (num3 == 10)
							{
								UiManager.ProcessBar2(100L, 100L);
								SerialCOM.MSL = "DISREAD";
								sendingloaderStatus = false;
								UiManager.Richlogs("error[0]", Color.Red, isBold: true, NextLine: true);
								return;
							}
						}
						num3 = 0;
					}
					if (Form1.SharedUI.RichTextBox1.Text.Contains("error[0]"))
					{
						break;
					}
					if (ValidateResponse(SAHARA.SAHARA_CMD.SAHARA_CMD_READ_DATA, array2))
					{
						initReq = (SAHARA.SAHARA_REQUESTS_READDATA)RawDeserialize(array2, 0, typeof(SAHARA.SAHARA_REQUESTS_READDATA));
						num2 += 5;
						continue;
					}
					if (ValidateResponse(SAHARA.SAHARA_CMD.SAHARA_CMD_IMG_END_TRSFR, array2))
					{
						SAHARA.SAHARA_REQUESTS_IMG_DONE msg = default(SAHARA.SAHARA_REQUESTS_IMG_DONE);
						msg.header.command = SAHARA.SAHARA_CMD.SAHARA_CMD_IMG_DONE_REQ;
						msg.header.size = Marshal.SizeOf(typeof(SAHARA.SAHARA_REQUESTS_IMG_DONE));
						PortIOMe.PortWrite(SerializeMessage(msg));
						if (((SAHARA.SAHARA_RESPONSE_IMGDONE_PACKET)RawDeserialize(PortIOMe.PortRead(100), 0, typeof(SAHARA.SAHARA_RESPONSE_IMGDONE_PACKET))).status == SAHARA.SAHARA_STATUS.SAHARA_STATUS_32)
						{
							UiManager.ProcessBar2(100L, 100L);
							SerialCOM.MSL = "DISREAD";
							UiManager.Richlogs("OK", Color.LimeGreen, isBold: true, NextLine: true);
							Mode = SAHARA.SAHARA_MODE.SAHARA_MODE_IMAGE_TX_COMPLETE;
							sendingloaderStatus = true;
						}
						else
						{
							UiManager.ProcessBar2(100L, 100L);
							SerialCOM.MSL = "DISREAD";
							UiManager.Richlogs("error[0]", Color.Red, isBold: true, NextLine: true);
							sendingloaderStatus = false;
						}
					}
					else
					{
						UiManager.ProcessBar2(100L, 100L);
						SerialCOM.MSL = "DISREAD";
						sendingloaderStatus = false;
						UiManager.Richlogs("error[0]", Color.Red, isBold: true, NextLine: true);
					}
					break;
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				UiManager.ProcessBar2(100L, 100L);
				SerialCOM.MSL = "DISREAD";
				sendingloaderStatus = false;
				UiManager.Richlogs("error[0]", Color.Red, isBold: true, NextLine: true);
				ProjectData.ClearProjectError();
			}
		}
	}

	public static void SendFlashLoader64(SAHARA.SAHARA_REQUESTS_READDATA_64 initReq)
	{
		if (Form1.SharedUI.RichTextBox1.Text.Contains("error[0]"))
		{
			return;
		}
		checked
		{
			try
			{
				int num = 0;
				int num2 = 1;
				bool flag = false;
				int num3 = 0;
				UiManager.Richlogs("- Sending Config Protocol : ", Color.Black, isBold: false);
				Form1.SharedUI.ProgressBar4.Text = "Sending Config...";
				UiManager.ProcessBar2(0L, 100L);
				SerialCOM.MSL = "ENREAD";
				while (!flag)
				{
					int num4 = (int)initReq.size;
					int num5 = (int)initReq.offset;
					Stream input = new MemoryStream(Loader);
					using BinaryReader binaryReader = new BinaryReader(input);
					Stopwatch stopwatch = new Stopwatch();
					stopwatch.Start();
					byte[] array = new byte[num4 - 1 + 1];
					binaryReader.BaseStream.Seek(num5, SeekOrigin.Begin);
					binaryReader.Read(array, 0, num4);
					PortIOMe.PortWrite(array);
					num += num4;
					TimeSpan elapsed = stopwatch.Elapsed;
					UiManager.label_transferrate((double)array.Length / elapsed.TotalSeconds);
					UiManager.ProcessBar3(num, Loader.Length);
					stopwatch.Stop();
					UiManager.label_totalsize(Loader.Length);
					UiManager.label_writensize(num);
					byte[] array2 = PortIOMe.PortRead(0);
					if (array2.Length == 0)
					{
						while (true)
						{
							array2 = PortIOMe.PortRead(10);
							num3++;
							if (array2.Length != 0)
							{
								break;
							}
							if (num3 == 10)
							{
								UiManager.ProcessBar2(100L, 100L);
								SerialCOM.MSL = "DISREAD";
								sendingloaderStatus = false;
								UiManager.Richlogs("error[0]", Color.Red, isBold: true, NextLine: true);
								return;
							}
						}
						num3 = 0;
					}
					if (Form1.SharedUI.RichTextBox1.Text.Contains("error[0]"))
					{
						break;
					}
					if (ValidateResponse(SAHARA.SAHARA_CMD.SAHARA_CMD_READ_DATA, array2))
					{
						initReq = (SAHARA.SAHARA_REQUESTS_READDATA_64)RawDeserialize(array2, 0, typeof(SAHARA.SAHARA_REQUESTS_READDATA_64));
						num2 += 5;
						continue;
					}
					if (ValidateResponse(SAHARA.SAHARA_CMD.SAHARA_CMD_IMG_END_TRSFR, array2))
					{
						SAHARA.SAHARA_REQUESTS_IMG_DONE64 msg = default(SAHARA.SAHARA_REQUESTS_IMG_DONE64);
						msg.header.command = SAHARA.SAHARA_CMD.SAHARA_CMD_IMG_DONE_REQ;
						msg.header.size = Marshal.SizeOf(typeof(SAHARA.SAHARA_REQUESTS_IMG_DONE64));
						PortIOMe.PortWrite(SerializeMessage(msg));
						if (((SAHARA.SAHARA_RESPONSE_IMGDONE_PACKET64)RawDeserialize(PortIOMe.PortRead(100), 0, typeof(SAHARA.SAHARA_RESPONSE_IMGDONE_PACKET64))).status == SAHARA.SAHARA_STATUS.SAHARA_STATUS_64)
						{
							UiManager.ProcessBar2(100L, 100L);
							SerialCOM.MSL = "DISREAD";
							UiManager.Richlogs("OK", Color.FromArgb(21, 87, 255), isBold: true, NextLine: true);
							Mode = SAHARA.SAHARA_MODE.SAHARA_MODE_IMAGE_TX_COMPLETE;
							sendingloaderStatus = true;
						}
						else
						{
							UiManager.ProcessBar2(100L, 100L);
							SerialCOM.MSL = "DISREAD";
							sendingloaderStatus = false;
							UiManager.Richlogs("error[0]", Color.Red, isBold: true, NextLine: true);
						}
					}
					else
					{
						UiManager.ProcessBar2(100L, 100L);
						SerialCOM.MSL = "DISREAD";
						sendingloaderStatus = false;
						UiManager.Richlogs("error[0]", Color.Red, isBold: true, NextLine: true);
					}
					break;
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				UiManager.ProcessBar2(100L, 100L);
				SerialCOM.MSL = "DISREAD";
				sendingloaderStatus = false;
				UiManager.Richlogs("error[0]", Color.Red, isBold: true, NextLine: true);
				ProjectData.ClearProjectError();
			}
		}
	}

	public static void DumpDeviceInfo()
	{
		if (Form1.SharedUI.RichTextBox1.Text.Contains("error[0]"))
		{
			return;
		}
		ReadData(SAHARA.SAHARA_EXEC_CMD.SAHARA_EXEC_CMD_MSM_HW_ID_READ);
		if (!Form1.SharedUI.RichTextBox1.Text.Contains("error[0]"))
		{
			ReadData(SAHARA.SAHARA_EXEC_CMD.SAHARA_EXEC_CMD_SERIAL_NUM_READ);
			if (!Form1.SharedUI.RichTextBox1.Text.Contains("error[0]"))
			{
				ReadData(SAHARA.SAHARA_EXEC_CMD.SAHARA_EXEC_CMD_OEM_PK_HASH_READ);
				Form1.SharedUI.RichTextBox1.Text.Contains("error[0]");
			}
		}
	}

	public static bool SwitchMode(SAHARA.SAHARA_MODE mode_Conflict)
	{
		if (!Form1.SharedUI.RichTextBox1.Text.Contains("error[0]"))
		{
			SAHARA.SAHARA_SWITCH_PACKET msg = default(SAHARA.SAHARA_SWITCH_PACKET);
			msg.header.command = SAHARA.SAHARA_CMD.SAHARA_CMD_SWITCH_MODE;
			msg.header.size = Marshal.SizeOf(typeof(SAHARA.SAHARA_SWITCH_PACKET));
			msg.mode = SAHARA.SAHARA_MODE.SAHARA_MODE_IMAGE_PENDING;
			SendBytes(SerializeMessage(msg));
			byte[] array = PortIOMe.PortRead(0);
			if (Form1.SharedUI.RichTextBox1.Text.Contains("error[0]"))
			{
				return false;
			}
			if (ValidateResponse(SAHARA.SAHARA_CMD.SAHARA_CMD_HELLO_REQ, array))
			{
				if (Form1.SharedUI.RichTextBox1.Text.Contains("error[0]"))
				{
					return false;
				}
				SAHARA.SAHARA_REQUESTS_HELLO pkt = (SAHARA.SAHARA_REQUESTS_HELLO)RuntimeHelpers.GetObjectValue(RawDeserialize(array, 0, typeof(SAHARA.SAHARA_REQUESTS_HELLO)));
				if (mode_Conflict == SAHARA.SAHARA_MODE.SAHARA_MODE_IMAGE_PENDING)
				{
					if (Form1.SharedUI.RichTextBox1.Text.Contains("error[0]"))
					{
						return false;
					}
					SendHelloResponse(pkt, SAHARA.SAHARA_MODE.SAHARA_MODE_IMAGE_PENDING);
				}
			}
			return true;
		}
		bool result = default(bool);
		return result;
	}

	public static void ReadData(SAHARA.SAHARA_EXEC_CMD cmd)
	{
		if (Form1.SharedUI.RichTextBox1.Text.Contains("error[0]"))
		{
			return;
		}
		try
		{
			SAHARA.SAHARA_REQUEST_EXE_CMD msg = default(SAHARA.SAHARA_REQUEST_EXE_CMD);
			msg.header.command = SAHARA.SAHARA_CMD.SAHARA_CMD_EXECUTE_REQ;
			if (Form1.SharedUI.RichTextBox1.Text.Contains("error[0]"))
			{
				return;
			}
			msg.header.size = Marshal.SizeOf(typeof(SAHARA.SAHARA_REQUEST_EXE_CMD));
			msg.clientCmd = cmd;
			SendBytes(SerializeMessage(msg));
			byte[] array = PortIOMe.PortRead(10);
			if (Form1.SharedUI.RichTextBox1.Text.Contains("error[0]"))
			{
				return;
			}
			if (ValidateResponse(SAHARA.SAHARA_CMD.SAHARA_CMD_EXECUTE_RESPONSE, array))
			{
				_ = (SAHARA.SAHARA_RESPONSE_EXECCMD_RESPONSE)RawDeserialize(array, 0, typeof(SAHARA.SAHARA_RESPONSE_EXECCMD_RESPONSE));
				msg.header.command = SAHARA.SAHARA_CMD.SAHARA_CMD_EXECUTE_DATA;
				SendBytes(SerializeMessage(msg));
			}
			if (Form1.SharedUI.RichTextBox1.Text.Contains("error[0]"))
			{
				return;
			}
			byte[] array2 = PortIOMe.PortRead(10);
			if (cmd == SAHARA.SAHARA_EXEC_CMD.SAHARA_EXEC_CMD_MSM_HW_ID_READ)
			{
				Array.Reverse(array2, 0, array2.Length);
				string text = BitConverter.ToString(array2).Replace("-", string.Empty);
				text = text.Substring(0, 14);
				if (Form1.SharedUI.RichTextBox1.Text.Contains("error[0]"))
				{
					return;
				}
				_pblInfo.msm_id = text;
				UiManager.Richlogs("- Getting ID : ", Color.Black, isBold: false);
				UiManager.Richlogs(text, Color.Orange, isBold: true, NextLine: true);
			}
			if (Form1.SharedUI.RichTextBox1.Text.Contains("error[0]"))
			{
				return;
			}
			if (cmd == SAHARA.SAHARA_EXEC_CMD.SAHARA_EXEC_CMD_OEM_PK_HASH_READ)
			{
				string text2 = (_pblInfo.pk_hash = BitConverter.ToString(array2).Replace("-", string.Empty));
				if (Form1.SharedUI.RichTextBox1.Text.Contains("error[0]"))
				{
					return;
				}
				if (FIREHOSE_OPERATIONS.MenuMan == FIREHOSE_OPERATIONS.MenuManual.flash || FIREHOSE_OPERATIONS.MenuMan == FIREHOSE_OPERATIONS.MenuManual.ident || FIREHOSE_OPERATIONS.MenuMan == FIREHOSE_OPERATIONS.MenuManual.read || FIREHOSE_OPERATIONS.MenuMan == FIREHOSE_OPERATIONS.MenuManual.erase || FIREHOSE_OPERATIONS.MenuMan == FIREHOSE_OPERATIONS.MenuManual.patch || FIREHOSE_OPERATIONS.MenuMan == FIREHOSE_OPERATIONS.MenuManual.reboot)
				{
					UiManager.Richlogs("- OEM PK_HASH [0] : ", Color.Black, isBold: false);
					UiManager.Richlogs(text2.Substring(0, 32), Color.Orange, isBold: true, NextLine: true);
					UiManager.Richlogs("- OEM PK_HASH [1] : ", Color.Black, isBold: false);
					UiManager.Richlogs(text2.Substring(checked(text2.Length - 32), 32), Color.Orange, isBold: true, NextLine: true);
				}
				if (IsAutoLoader)
				{
					_Closure_0024__40_002D0 arg = default(_Closure_0024__40_002D0);
					_Closure_0024__40_002D0 CS_0024_003C_003E8__locals0 = new _Closure_0024__40_002D0(arg);
					if (_pblInfo.msm_id.Length < 16)
					{
						do
						{
							string text3 = new StringBuilder().Append("0").ToString();
							_pblInfo.msm_id += text3;
						}
						while (_pblInfo.msm_id.Length != 16);
					}
					string path = Application.StartupPath + "\\Data\\Process\\Autoloader";
					CS_0024_003C_003E8__locals0._0024VB_0024Local_string_to_find = _pblInfo.msm_id + "_" + _pblInfo.pk_hash.Substring(0, 16);
					UiManager.Richlogs("- Searching Auto Loader : ", Color.Black, isBold: false);
					IEnumerable<FileSystemInfo> enumerable = from i in new DirectoryInfo(path).EnumerateFileSystemInfos("*", SearchOption.AllDirectories)
						where i.Name.IndexOf(CS_0024_003C_003E8__locals0._0024VB_0024Local_string_to_find, StringComparison.CurrentCultureIgnoreCase) >= 0
						select i;
					if (enumerable.Count() > 0)
					{
						using IEnumerator<FileSystemInfo> enumerator = enumerable.GetEnumerator();
						_Closure_0024__40_002D1 closure_0024__40_002D = default(_Closure_0024__40_002D1);
						while (enumerator.MoveNext())
						{
							closure_0024__40_002D = new _Closure_0024__40_002D1(closure_0024__40_002D);
							closure_0024__40_002D._0024VB_0024Local_r = enumerator.Current;
							if (!string.IsNullOrEmpty(closure_0024__40_002D._0024VB_0024Local_r.Name))
							{
								EDL.SharedEDL.txtloader.Invoke(new Action(closure_0024__40_002D._Lambda_0024__1));
								Loader = File.ReadAllBytes(closure_0024__40_002D._0024VB_0024Local_r.FullName);
								break;
							}
						}
					}
					else
					{
						UiManager.Richlogs("Please Select Loader File => ", Color.White, isBold: false);
						UiManager.MSL = "ShowDialogLoader";
						while (Operators.CompareString(UiManager.MSL, "", TextCompare: false) != 0)
						{
						}
						if (!IsLoaderExist)
						{
							UiManager.Richlogs("Cencel By User", Color.Red, isBold: true, NextLine: true);
							return;
						}
					}
					if (!Encoding.UTF8.GetString(Loader).Contains("ELF"))
					{
						IsLoaderExist = false;
						UiManager.Richlogs("Invalid", Color.Red, isBold: true, NextLine: true);
						return;
					}
					IsLoaderExist = true;
					UiManager.Richlogs("OK", Color.Lime, isBold: true, NextLine: true);
				}
				else
				{
					if (Form1.SharedUI.RichTextBox1.Text.Contains("error[0]"))
					{
						return;
					}
					if (_pblInfo.msm_id.Length < 16)
					{
						do
						{
							string text4 = new StringBuilder().Append("0").ToString();
							_pblInfo.msm_id += text4;
						}
						while (_pblInfo.msm_id.Length != 16);
					}
					if (Form1.SharedUI.RichTextBox1.Text.Contains("error[0]"))
					{
						return;
					}
					_ = Application.StartupPath + "\\Data\\Process\\Autoloader";
					string msg2 = _pblInfo.msm_id + "_" + _pblInfo.pk_hash.Substring(0, 16);
					UiManager.Richlogs("- PK_HASH : ", Color.Black, isBold: false);
					UiManager.Richlogs(msg2, Color.Orange, isBold: true, NextLine: true);
					UiManager.Richlogs("- Handling Programmer File : ", Color.Black, isBold: false);
					Form1.SharedUI.ProgressBar1.Text = "Handling...";
					if (Form1.SharedUI.RichTextBox1.Text.Contains("error[0]"))
					{
						return;
					}
					if (!Encoding.UTF8.GetString(Loader).Contains("ELF"))
					{
						IsLoaderExist = false;
						UiManager.Richlogs("Loader is Invalid Or Encrypted", Color.Red, isBold: false);
					}
					else
					{
						IsLoaderExist = true;
						UiManager.Richlogs("OK", Color.Lime, isBold: true, NextLine: true);
					}
				}
			}
			if (!Form1.SharedUI.RichTextBox1.Text.Contains("error[0]") && cmd == SAHARA.SAHARA_EXEC_CMD.SAHARA_EXEC_CMD_SERIAL_NUM_READ)
			{
				string msg3 = (_pblInfo.serial = BitConverter.ToString(array2).Replace("-", string.Empty));
				UiManager.Richlogs("- Getting SN : ", Color.Black, isBold: false);
				UiManager.Richlogs(msg3, Color.Orange, isBold: true, NextLine: true);
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}
}
