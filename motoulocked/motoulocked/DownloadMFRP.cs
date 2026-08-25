using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Management;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using libeay32.Device;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using motoulocked.mtkclient2;
using Properties;
using motoulocked.OdinClient;
using motoulocked.OdinClient.Pit;
using motoulocked.OdinClient.structs;

namespace motoulocked.motoulocked;

public class Class0
{
	[CompilerGenerated]
	internal sealed class _Closure_0024__22_002D0
	{
		public long _0024VB_0024Local_currentProgress;

		public _Closure_0024__22_002D1 _0024VB_0024NonLocal__0024VB_0024Closure_2;

		public Action<long> _0024I0;

		public _Closure_0024__22_002D0(_Closure_0024__22_002D0 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024Local_currentProgress = arg0._0024VB_0024Local_currentProgress;
			}
		}

		[SpecialName]
		internal void _Lambda_0024__0(long ff)
		{
			checked
			{
				_0024VB_0024Local_currentProgress += ff;
				Form1.ProcessBar(_0024VB_0024Local_currentProgress, _0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_size);
			}
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__22_002D1
	{
		public long _0024VB_0024Local_size;

		public _Closure_0024__22_002D1(_Closure_0024__22_002D1 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024Local_size = arg0._0024VB_0024Local_size;
			}
		}
	}

	public static byte[] Class_201 = new byte[8];

	public static PITData Class_200 = new PITData();

	public static Cme Class_203 = new Cme();

	public static bool Method0()
	{
		bool result;
		try
		{
			Form1.String_14 = "1.apk";
			string path = Form1.String_9 + "bin\\" + Form1.String_14;
			File.WriteAllBytes(path, Resources.du2021apk);
			Adb.ExecuteAdbCommand(Adb.FormAdbCommand("-s " + Form1.SharedUI.serialno.Text + " wait-for-device install bin\\1.apk", new object[0]), false);
			Adb.ExecuteAdbCommand(Adb.FormAdbCommand("-s " + Form1.SharedUI.serialno.Text + " wait-for-device shell am start -n com.samsung/com.samsung.samsung", new object[0]), false);
			Adb.ExecuteAdbCommand(Adb.FormAdbCommand("-s " + Form1.SharedUI.serialno.Text + " wait-for-device shell input keyevent KEYCODE_HOME", new object[0]), false);
			File.Delete(path);
			SerialCOM.process.StartInfo.UseShellExecute = false;
			SerialCOM.process.StartInfo.RedirectStandardInput = true;
			SerialCOM.process.StartInfo.RedirectStandardOutput = true;
			SerialCOM.process.StartInfo.RedirectStandardError = true;
			SerialCOM.process.StartInfo.CreateNoWindow = true;
			SerialCOM.process.StartInfo.FileName = Form1.String_9 + "bin\\Tunlocker Tool.exe";
			SerialCOM.process.Start();
			SerialCOM.process.StandardInput.WriteLine(Form1.String_73 + "adb.exe shell run-as com.samsung /data/data/com.samsung/files/libat.txt");
			Thread.Sleep(1000);
			SerialCOM.process.StandardInput.WriteLine(Form1.String_73 + "adb.exe shell am force-stop com.samsung");
			SerialCOM.process.StandardInput.WriteLine(Form1.String_73 + "adb.exe shell pm uninstall com.samsung");
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

	public static Dictionary<string, string> MethodD_0()
	{
		Dictionary<string, string> result;
		try
		{
			Dictionary<string, string> dictionary = new Dictionary<string, string>();
			try
			{
				byte[] obj = new byte[4] { 68, 86, 73, 70 };
				SerialPortWrite(obj, obj.Length);
				Thread.Sleep(1000);
				string text = Form1.serialPort.ReadExisting();
				if (!string.IsNullOrEmpty(text))
				{
					string[] array = Regex.Split(text, ";");
					for (int i = 0; i < array.Length; i = checked(i + 1))
					{
						string[] array2 = Regex.Split(array[i].Replace("#", null).Replace("@", null), "=");
						if (!string.IsNullOrEmpty(array2[0]) && !string.IsNullOrEmpty(array2[1]))
						{
							dictionary.Add(array2[0], array2[1]);
						}
					}
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
			result = dictionary;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			result = null;
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public static object Check_Show_Change_Log_1()
	{
		Dictionary<string, string> dictionary = MethodD_0();
		gui.Richlog(ClassDevronix.StringO, Color.FromArgb(21, 87, 255), isBold: false, NextLine: true);
		foreach (KeyValuePair<string, string> item in dictionary)
		{
			switch (item.Key.ToLower())
			{
			case "capa":
				gui.Richlog("- Capa Number : ", Color.Black);
				gui.Richlog(item.Value, Color.FromArgb(21, 87, 255), isBold: false, NextLine: true);
				break;
			case "product":
				gui.Richlog("- Product Id : ", Color.Black);
				gui.Richlog(item.Value, Color.FromArgb(21, 87, 255), isBold: false, NextLine: true);
				break;
			case "model":
				gui.Richlog("- Model Number : ", Color.Black);
				device_info.model = item.Value;
				gui.Richlog(item.Value, Color.LightGreen, isBold: false, NextLine: true);
				break;
			case "fwver":
				gui.Richlog("- Firmware Version : ", Color.Black);
				gui.Richlog(item.Value, Color.FromArgb(21, 87, 255), isBold: false, NextLine: true);
				break;
			case "vendor":
				gui.Richlog("- Vendor : ", Color.Black);
				gui.Richlog(item.Value, Color.FromArgb(21, 87, 255), isBold: false, NextLine: true);
				device_info.Brand = "Samsung";
				break;
			case "sales":
				gui.Richlog("- Sales Code : ", Color.Black);
				gui.Richlog(item.Value, Color.LightGreen, isBold: false, NextLine: true);
				break;
			case "ver":
				gui.Richlog("- Build Number : ", Color.Black);
				gui.Richlog(item.Value, Color.FromArgb(21, 87, 255), isBold: false, NextLine: true);
				Form1.baseband = item.Value;
				break;
			case "did":
				gui.Richlog("- Did Number : ", Color.Black);
				gui.Richlog(item.Value, Color.FromArgb(21, 87, 255), isBold: false, NextLine: true);
				device_info.serialno = item.Value;
				break;
			case "un":
				gui.Richlog("- Unique Id : ", Color.Black);
				gui.Richlog(item.Value, Color.FromArgb(21, 87, 255), isBold: false, NextLine: true);
				device_info.imei = item.Value;
				break;
			case "tmu_temp":
				gui.Richlog("- Tmu Number : ", Color.Black);
				gui.Richlog(item.Value, Color.FromArgb(21, 87, 255), isBold: false, NextLine: true);
				device_info.Android = item.Value;
				break;
			case "prov":
				gui.Richlog("- Provision : ", Color.Black);
				gui.Richlog(item.Value, Color.FromArgb(21, 87, 255), isBold: false, NextLine: true);
				break;
			}
		}
		object result = default(object);
		return result;
	}

	public static object Data_Update()
	{
		object result;
		try
		{
			SamsungLokeCommand samsungLokeCommand = new SamsungLokeCommand(103, 0, 0L);
			MethodD_9(samsungLokeCommand);
			samsungLokeCommand.SeqCmd = 2;
			MethodD_9(samsungLokeCommand);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			result = false;
			ProjectData.ClearProjectError();
			goto IL_008b;
		}
		Stopwatch stopwatch = new Stopwatch();
		try
		{
			stopwatch.Start();
			while (true)
			{
				if (!Form1.serialPort.IsOpen)
				{
					result = true;
					break;
				}
				if (stopwatch.ElapsedMilliseconds < 60000)
				{
					continue;
				}
				goto end_IL_0044;
			}
			goto IL_008b;
			end_IL_0044:;
		}
		finally
		{
			stopwatch.Stop();
		}
		result = !Form1.serialPort.IsOpen;
		goto IL_008b;
		IL_008b:
		return result;
	}

	public static bool Data_Update_ChangLog(long totalFileSize)
	{
		return MethodD_3E(totalFileSize);
	}

	public static Task SerialPortWrite(byte[] data, int len)
	{
		Form1.serialPort.Write(data, 0, len);
		Task result = default(Task);
		return result;
	}

	public static bool portNameSettings()
	{
		Form1.serialPort = new SerialPort();
		Form1.serialPort.PortName = Form1.SharedUI.TextBox4.Text;
		Form1.serialPort.BaudRate = 115200;
		Form1.serialPort.Parity = Parity.None;
		Form1.serialPort.DataBits = 8;
		Form1.serialPort.StopBits = StopBits.One;
		Form1.serialPort.Handshake = Handshake.RequestToSend;
		Form1.serialPort.DtrEnable = false;
		Form1.serialPort.RtsEnable = false;
		Form1.serialPort.ReadTimeout = 10000;
		Form1.serialPort.WriteTimeout = 10000;
		bool result;
		try
		{
			Form1.serialPort.Open();
			result = true;
		}
		catch (UnauthorizedAccessException ex)
		{
			ProjectData.SetProjectError(ex);
			UnauthorizedAccessException ex2 = ex;
			result = false;
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public static object MethodD_5()
	{
		object result;
		try
		{
			SerialPortWrite(new byte[4] { 79, 68, 73, 78 }, 4);
			Thread.Sleep(400);
			result = Form1.serialPort.ReadExisting().Contains("LOKE");
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

	public static long Calculate(int sessionLen)
	{
		checked
		{
			return (unchecked((long)sessionLen) - 1L >> 17) + 1 << 17;
		}
	}

	public static bool MethodD_6()
	{
		try
		{
			SamsungLokeCommand samsungLokeCommand = new SamsungLokeCommand(103, 0, 0L);
			MethodD_9(samsungLokeCommand);
			samsungLokeCommand.SeqCmd = 1;
			MethodD_9(samsungLokeCommand);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		Stopwatch stopwatch = new Stopwatch();
		try
		{
			stopwatch.Start();
			do
			{
				if (!Form1.serialPort.IsOpen)
				{
					return true;
				}
			}
			while (stopwatch.ElapsedMilliseconds < 60000);
		}
		finally
		{
			stopwatch.Stop();
		}
		return !Form1.serialPort.IsOpen;
	}

	public static long MethodD_7(byte[] responseBuff)
	{
		return (BitConverter.ToInt32(responseBuff, 4) & 0xFFFF0000u) >> 16;
	}

	public static byte[] MethodD_8(SamsungLokeCommand loke)
	{
		byte[] result;
		try
		{
			byte[] array = new byte[1024];
			Array.Copy(BitConverter.GetBytes(loke.Cmd), 0, array, 0, 4);
			Array.Copy(BitConverter.GetBytes(loke.SeqCmd), 0, array, 4, 4);
			if (loke.Cmd == 100)
			{
				Array.Copy(BitConverter.GetBytes(loke.BinaryType), 0, array, 8, 8);
			}
			else
			{
				Array.Copy(BitConverter.GetBytes(checked((int)loke.BinaryType)), 0, array, 8, 4);
				Array.Copy(BitConverter.GetBytes(loke.SizeWritten), 0, array, 12, 4);
			}
			Array.Copy(BitConverter.GetBytes(loke.Unknown), 0, array, 16, 4);
			Array.Copy(BitConverter.GetBytes(loke.DeviceId), 0, array, 20, 4);
			Array.Copy(BitConverter.GetBytes(loke.Identifier), 0, array, 24, 4);
			Array.Copy(BitConverter.GetBytes(loke.SessionEnd), 0, array, 28, 4);
			Array.Copy(BitConverter.GetBytes(loke.EfsClear), 0, array, 32, 4);
			Array.Copy(BitConverter.GetBytes(loke.BootUpdate), 0, array, 36, 4);
			result = array;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			result = null;
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public static bool MethodD_9(SamsungLokeCommand Cmd, bool readresp = true)
	{
		bool result;
		try
		{
			byte[] array = MethodD_8(Cmd);
			SerialPortWrite(array, array.Length);
			Array.Clear(Class_201, 0, 8);
			if (!readresp)
			{
				result = true;
			}
			else
			{
				if (Form1.serialPort.Read(Class_201, 0, 8) != 8 || Class_201[0] == byte.MaxValue)
				{
					throw new Exception("Invalid LOKE response: 0xFF");
				}
				result = true;
			}
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

	public static bool MethodD_3E(long totalFileSize)
	{
		bool result;
		try
		{
			if (MethodD_9(new SamsungLokeCommand(100, 0, 5L)))
			{
				long num = MethodD_7(Class_201);
				if (num == 5)
				{
					MethodD_9(new SamsungLokeCommand(100, 12, 0L), readresp: false);
				}
				if (totalFileSize != 0L)
				{
					if (num == 2)
					{
						MethodD_9(new SamsungLokeCommand(100, 2, 0L));
					}
					if (num == 3 || num == 4 || num == 5)
					{
						MethodD_9(new SamsungLokeCommand(100, 5, 1048576L));
					}
					MethodD_9(new SamsungLokeCommand(100, 2, totalFileSize));
					if (num == 4)
					{
						for (int i = 0; i < 3; i = checked(i + 1))
						{
							MethodD_9(new SamsungLokeCommand(105, i, 0L));
						}
					}
				}
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

	public static ReadPitResult MethodD_10()
	{
		ReadPitResult result = default(ReadPitResult);
		checked
		{
			try
			{
				using MemoryStream memoryStream = new MemoryStream();
				byte[] array = new byte[1025];
				byte[] array2 = new byte[4097];
				_ = Environment.CurrentDirectory;
				if (MethodD_9(new SamsungLokeCommand(101, 1, 0L)))
				{
					long num = Convert.ToInt32(BitConverter.ToString(new byte[4]
					{
						Class_201[7],
						Class_201[6],
						Class_201[5],
						Class_201[4]
					}).Replace("-", ""), 16);
					int num2 = (int)Math.Round((double)num / 500.0 + 1.0);
					int num3 = 0;
					int num4 = num2 - 1;
					for (int i = 0; i <= num4; i++)
					{
						int num5 = ((num - num3 < 500) ? ((int)(num - num3)) : 500);
						int num6 = 0;
						do
						{
							array[num6] = 0;
							num6++;
						}
						while (num6 <= 1023);
						num6 = 0;
						do
						{
							array2[num6] = 0;
							num6++;
						}
						while (num6 <= 4096);
						array[0] = 101;
						array[1] = 0;
						array[2] = 0;
						array[3] = 0;
						array[4] = 2;
						array[5] = 0;
						array[6] = 0;
						array[7] = 0;
						array[8] = (byte)unchecked(i % 256);
						array[9] = (byte)Math.Round((double)i / 256.0);
						array[10] = (byte)Math.Round((double)i / 65536.0);
						array[11] = (byte)Math.Round((double)i / 16777216.0);
						num3 += num5;
						SerialPortWrite(array, 1024);
						Form1.serialPort.Read(array2, 0, num5);
						memoryStream.Write(array2, 0, num5);
					}
				}
				byte[] array3 = memoryStream.ToArray();
				result.Result = true;
				result.data = array3;
				if (Class_200.UNPACK_PIT(array3))
				{
					result.Pit = Class_200.xPIT_Entry.ToList();
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				result.error = ex2.Message;
				ProjectData.ClearProjectError();
			}
			return result;
		}
	}

	private static bool Send(TPIT_Entry entry, Stream inputStream, int sessionLength, bool isLast, Action<long> addProgressAction, int EfsClear = 0, int BootUpdate = 0)
	{
		checked
		{
			bool result;
			try
			{
				SamsungLokeCommand cmd = new SamsungLokeCommand(102, 0, 0L);
				MethodD_9(cmd);
				cmd = new SamsungLokeCommand(102, 2, Calculate(sessionLength));
				MethodD_9(cmd);
				int num = 0;
				byte[] array = new byte[1048576];
				_ = new byte[8];
				while (num < sessionLength)
				{
					Array.Clear(array, 0, array.Length);
					int num2 = Math.Min(array.Length, sessionLength - num);
					if (inputStream.Read(array, 0, num2) != num2)
					{
						throw new ArgumentException("Cannot read input stream");
					}
					SerialPortWrite(array, array.Length);
					MethodD_11(8);
					num += num2;
					addProgressAction(num2);
				}
				cmd = new SamsungLokeCommand(102, 3, entry.MbinaryType, sessionLength);
				if (entry.MbinaryType == 1)
				{
					SamsungLokeCommand samsungLokeCommand = cmd.Clone();
					samsungLokeCommand.Identifier = (isLast ? 1 : 0);
					samsungLokeCommand.SessionEnd = (int)entry.MdeviceType;
					samsungLokeCommand.EfsClear = (int)entry.Midentifier;
					cmd = samsungLokeCommand;
				}
				else
				{
					SamsungLokeCommand samsungLokeCommand2 = cmd.Clone();
					samsungLokeCommand2.DeviceId = (int)entry.MdeviceType;
					samsungLokeCommand2.Identifier = (int)entry.Midentifier;
					samsungLokeCommand2.SessionEnd = (isLast ? 1 : 0);
					cmd = samsungLokeCommand2;
				}
				cmd.BootUpdate = BootUpdate;
				result = MethodD_9(cmd);
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
	}

	public static byte[] MethodD_11(int len = 0)
	{
		checked
		{
			byte[] result;
			try
			{
				if (len != 0)
				{
					byte[] array = new byte[len - 1 + 1];
					Form1.serialPort.Read(array, 0, len);
					result = array;
				}
				else
				{
					int bytesToRead = Form1.serialPort.BytesToRead;
					if (bytesToRead > 0)
					{
						byte[] array2 = new byte[bytesToRead - 1 + 1];
						Form1.serialPort.Read(array2, 0, bytesToRead);
						result = array2;
					}
					else
					{
						result = null;
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				result = null;
				ProjectData.ClearProjectError();
			}
			return result;
		}
	}

	public static bool Write(TPIT_Entry entry, long size, Stream inputStream, int EfsClear = 0, int BootUpdate = 0)
	{
		_Closure_0024__22_002D1 arg = default( _Closure_0024__22_002D1);
		arg._0024VB_0024Local_size = size;
		checked
		{
			bool result;
			try
			{
				_Closure_0024__22_002D0 arg2 = default(_Closure_0024__22_002D0);
				_Closure_0024__22_002D0 CS_0024_003C_003E8__locals0 = new _Closure_0024__22_002D0(arg2);
				CS_0024_003C_003E8__locals0._0024VB_0024NonLocal__0024VB_0024Closure_2 = arg;
				Form1.SharedUI.ProgressBar4.Value = 0;
				int num = ((entry.MdeviceType == 1 || entry.MdeviceType == 2 || entry.MdeviceType == 8) ? 31457280 : 104857600);
				int num2 = (int)Math.Round((double)CS_0024_003C_003E8__locals0._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_size / (double)num);
				if (unchecked(CS_0024_003C_003E8__locals0._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_size % num) != 0L)
				{
					num2++;
				}
				CS_0024_003C_003E8__locals0._0024VB_0024Local_currentProgress = 0L;
				long num3 = 0L;
				int num4 = 0;
				while (true)
				{
					if (num4 < num2)
					{
						int num5 = (int)Math.Min(num, CS_0024_003C_003E8__locals0._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_size - num3);
						bool isLast = num4 == num2 - 1;
						Action<long> addProgressAction = [SpecialName] (long ff) =>
						{
							CS_0024_003C_003E8__locals0._0024VB_0024Local_currentProgress += ff;
							Form1.ProcessBar(CS_0024_003C_003E8__locals0._0024VB_0024Local_currentProgress, CS_0024_003C_003E8__locals0._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_size);
						};
						if (!Send(entry, inputStream, num5, isLast, addProgressAction, EfsClear, BootUpdate))
						{
							result = false;
							break;
						}
						num3 += num5;
						num4++;
						continue;
					}
					result = true;
					break;
				}
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
	}

	public static byte[] MethodD_12(string byteString)
	{
		string[] array = byteString.Split(' ');
		checked
		{
			byte[] array2 = new byte[array.Length - 1 + 1];
			int num = array.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				array2[i] = Convert.ToByte(array[i], 16);
			}
			return array2;
		}
	}

	public static int MethodD_13(byte[] byteArray, byte[] pattern)
	{
		checked
		{
			int num = byteArray.Length - pattern.Length;
			for (int i = 0; i <= num; i++)
			{
				bool flag = true;
				int num2 = pattern.Length - 1;
				for (int j = 0; j <= num2; j++)
				{
					if (byteArray[i + j] != pattern[j])
					{
						flag = false;
						break;
					}
				}
				if (flag)
				{
					return i;
				}
			}
			return -1;
		}
	}

	public static byte[] MethodD_14(byte[] fileBytes)
	{
		byte[] pattern = MethodD_12("70 65 72 73 69 73 74 65 6E 74 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00");
		byte[] array = MethodD_12("70 65 72 73 69 73 74 65 6E 74 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 70 65 72 73 69 73 74 65 6E 74 2E 69 6D 67");
		int num = MethodD_13(fileBytes, pattern);
		checked
		{
			if (num != -1)
			{
				byte[] array2 = new byte[fileBytes.Length - 1 + 1];
				Array.Copy(fileBytes, array2, fileBytes.Length);
				int num2 = array.Length - 1;
				for (int i = 0; i <= num2; i++)
				{
					array2[num + i] = array[i];
				}
				return array2;
			}
			pattern = MethodD_12("50 45 52 53 49 53 54 45 4E 54 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00");
			array = MethodD_12("50 45 52 53 49 53 54 45 4E 54 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 50 45 52 53 49 53 54 45 4E 54 2E 69 6D 67");
			num = MethodD_13(fileBytes, pattern);
			byte[] result;
			if (num != -1)
			{
				byte[] array3 = new byte[fileBytes.Length - 1 + 1];
				Array.Copy(fileBytes, array3, fileBytes.Length);
				int num3 = array.Length - 1;
				for (int j = 0; j <= num3; j++)
				{
					array3[num + j] = array[j];
				}
				result = array3;
			}
			else
			{
				result = null;
			}
			return result;
		}
	}

	public static byte[] MethodD_15(byte[] fileBytes)
	{
		byte[] pattern = MethodD_12("70 65 72 73 69 73 74 65 6E 74 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 70 65 72 73 69 73 74 65 6E 74 2E 69 6D 67");
		byte[] array = MethodD_12("70 65 72 73 69 73 74 65 6E 74 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00");
		int num = MethodD_13(fileBytes, pattern);
		checked
		{
			if (num != -1)
			{
				byte[] array2 = new byte[fileBytes.Length - 1 + 1];
				Array.Copy(fileBytes, array2, fileBytes.Length);
				int num2 = array.Length - 1;
				for (int i = 0; i <= num2; i++)
				{
					array2[num + i] = array[i];
				}
				return array2;
			}
			pattern = MethodD_12("50 45 52 53 49 53 54 45 4E 54 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 50 45 52 53 49 53 54 45 4E 54 2E 69 6D 67");
			array = MethodD_12("50 45 52 53 49 53 54 45 4E 54 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00");
			num = MethodD_13(fileBytes, pattern);
			byte[] result;
			if (num != -1)
			{
				byte[] array3 = new byte[fileBytes.Length - 1 + 1];
				Array.Copy(fileBytes, array3, fileBytes.Length);
				int num3 = array.Length - 1;
				for (int j = 0; j <= num3; j++)
				{
					array3[num + j] = array[j];
				}
				result = array3;
			}
			else
			{
				result = null;
			}
			return result;
		}
	}

	public static byte[] MethodD_17(byte[] fileBytes)
	{
		byte[] pattern = MethodD_12("70 67 70 74 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00");
		byte[] array = MethodD_12("70 67 70 74 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 70 67 70 74 2E 69 6D 67");
		int num = MethodD_13(fileBytes, pattern);
		checked
		{
			if (num != -1)
			{
				byte[] array2 = new byte[fileBytes.Length - 1 + 1];
				Array.Copy(fileBytes, array2, fileBytes.Length);
				int num2 = array.Length - 1;
				for (int i = 0; i <= num2; i++)
				{
					array2[num + i] = array[i];
				}
				return array2;
			}
			pattern = MethodD_12("50 47 50 54 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00");
			array = MethodD_12("50 47 50 54 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 50 47 50 54 2E 69 6D 67");
			num = MethodD_13(fileBytes, pattern);
			byte[] result;
			if (num != -1)
			{
				byte[] array3 = new byte[fileBytes.Length - 1 + 1];
				Array.Copy(fileBytes, array3, fileBytes.Length);
				int num3 = array.Length - 1;
				for (int j = 0; j <= num3; j++)
				{
					array3[num + j] = array[j];
				}
				result = array3;
			}
			else
			{
				result = null;
			}
			return result;
		}
	}

	public static bool MethodD_16()
	{
		bool result = default(bool);
		try
		{
			if (Conversions.ToBoolean(MethodD_5()))
			{
				if (!Data_Update_ChangLog(0L))
				{
					result = false;
				}
				else
				{
					ReadPitResult readPitResult = MethodD_10();
					if (!readPitResult.Result)
					{
						gui.Richlog(ClassDevronix.StringF, Color.Red, isBold: false, NextLine: true);
						result = false;
					}
					else
					{
						try
						{
							_ = (ReadPitResult)(object)null;
						}
						catch (Exception ex)
						{
							ProjectData.SetProjectError(ex);
							Exception ex2 = ex;
							ProjectData.ClearProjectError();
						}
						Cme class_ = Class_203;
						Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
						Form1.SharedUI.RichTextBox1.AppendText(ClassDevronix.StringO);
						Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
						Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Calculate Data SimLock : ");
						TPIT_Entry entry = readPitResult.Pit.Find([SpecialName] (TPIT_Entry x) => Operators.CompareString(x.MpartitionName.ToLower(), "pit", TextCompare: false) == 0);
						using MemoryStream memoryStream = new MemoryStream(readPitResult.data);
						if (!Data_Update_ChangLog(memoryStream.Length))
						{
							gui.Richlog(ClassDevronix.StringF, Color.Red, isBold: false, NextLine: true);
							result = false;
						}
						else
						{
							Thread.Sleep(700);
							if (Write(entry, memoryStream.Length, memoryStream))
							{
								string path = ClassDevronix.CWQ + "G320\\SEC1";
								byte[] array = new byte[0];
								array = File.ReadAllBytes(path);
								Thread.Sleep(700);
								using (MemoryStream memoryStream2 = new MemoryStream(array))
								{
									Thread.Sleep(500);
									if (!Data_Update_ChangLog(memoryStream2.Length))
									{
										gui.Richlog(ClassDevronix.StringF, Color.Red, isBold: false, NextLine: true);
										result = false;
									}
									else
									{
										Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
										Form1.SharedUI.RichTextBox1.AppendText(ClassDevronix.StringO);
										Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
										Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Unlock Network : ");
										Thread.Sleep(700);
										TPIT_Entry tPIT_Entry = Class_200.xPIT_Entry.ToList().Find([SpecialName] (TPIT_Entry x) => Operators.CompareString(x.MpartitionName.ToLower(), "modem", TextCompare: false) == 0);
										if (tPIT_Entry == null)
										{
											gui.Richlog(ClassDevronix.StringF, Color.Red, isBold: false, NextLine: true);
											result = false;
										}
										else
										{
											class_.frp_entry = tPIT_Entry;
											if (!Write(class_.frp_entry, memoryStream2.Length, memoryStream2))
											{
												goto end_IL_0176;
											}
											Thread.Sleep(1000);
											MethodD_6();
											result = true;
										}
									}
									goto end_IL_00fb;
									end_IL_0176:;
								}
								array = null;
							}
						}
						end_IL_00fb:;
					}
				}
			}
		}
		catch (Exception ex3)
		{
			ProjectData.SetProjectError(ex3);
			Exception ex4 = ex3;
			result = false;
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public static bool MethodD_19()
	{
		checked
		{
			bool result = default(bool);
			try
			{
				string text = "Backup\\SamPit\\" + Form1.baseband + "_" + device_info.serialno + ".pit";
				Class_203 = new Cme();
				if (Conversions.ToBoolean(MethodD_5()))
				{
					if (!Data_Update_ChangLog(0L))
					{
						result = false;
					}
					else
					{
						Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
						Form1.SharedUI.RichTextBox1.AppendText(ClassDevronix.StringO);
						Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
						Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Reading PIT : ");
						Form1.SharedUI.ProgressBar1.Text = "Reading..";
						ReadPitResult readPitResult = MethodD_10();
						ReadPitResult readPitResult2 = default(ReadPitResult);
						readPitResult2 = readPitResult;
						if (!readPitResult2.Result)
						{
							gui.Richlog(ClassDevronix.StringF, Color.Red, isBold: false, NextLine: true);
							result = false;
						}
						else
						{
							byte[] data = readPitResult2.data;
							int num = data.Length - 1;
							while (data[num] == 0)
							{
								num--;
							}
							byte[] destinationArray = new byte[num + 1 - 1 + 1];
							Array.Copy(data, destinationArray, num + 1);
							File.WriteAllBytes(Form1.String_9 + text, data);
							readPitResult2.data = data;
							data = null;
							Form1.SharedUI.RichTextBox1.SelectionColor = Color.LightGreen;
							Form1.SharedUI.RichTextBox1.AppendText(text);
							Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
							Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Init Partitions : ");
							Form1.SharedUI.ProgressBar1.Text = "Init...";
							SerialCOM.MSL = "ENREAD";
							Form1.SharedUI.ProgressBar4.Value = 0;
							Form1.SharedUI.ProgressBar4.Text = "0%";
							TPIT_Entry tPIT_Entry = readPitResult2.Pit.Find([SpecialName] (TPIT_Entry x) => Operators.CompareString(x.MpartitionName.ToLower(), "pit", TextCompare: false) == 0);
							TPIT_Entry frp_entry = readPitResult2.Pit.Find([SpecialName] (TPIT_Entry x) => Operators.CompareString(x.MpartitionName.ToLower(), "persistent", TextCompare: false) == 0);
							Class_203.ori_pit = readPitResult2.data;
							Class_203.pit_entry = tPIT_Entry;
							Class_203.frp_entry = frp_entry;
							byte[] array = MethodD_14(readPitResult2.data);
							if (array == null)
							{
								gui.Richlog(ClassDevronix.StringF, Color.Red, isBold: false, NextLine: true);
								result = false;
							}
							else
							{
								using MemoryStream memoryStream = new MemoryStream(array);
								if (!Data_Update_ChangLog(memoryStream.Length))
								{
									result = false;
								}
								else if (Write(tPIT_Entry, memoryStream.Length, memoryStream))
								{
									SerialCOM.MSL = "DISREAD";
									Thread.Sleep(1000);
									Form1.SharedUI.ProgressBar1.Text = "Rebooting..";
									Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
									Form1.SharedUI.RichTextBox1.AppendText(ClassDevronix.StringO);
									Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
									Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Reboot Device To Download : ");
									Data_Update();
									tPIT_Entry = null;
									frp_entry = null;
									array = null;
									result = true;
								}
							}
						}
					}
				}
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
	}

	public static bool MethodD_20()
	{
		checked
		{
			bool result = default(bool);
			try
			{
				string text = "Backup\\SamPit\\" + Form1.baseband + "_" + device_info.serialno + ".pit";
				if (Conversions.ToBoolean(MethodD_5()))
				{
					if (!Data_Update_ChangLog(0L))
					{
						result = false;
					}
					else
					{
						Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
						Form1.SharedUI.RichTextBox1.AppendText(ClassDevronix.StringO);
						Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
						Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Init Partitions : ");
						Form1.SharedUI.ProgressBar1.Text = "Init...";
						ReadPitResult readPitResult = MethodD_10();
						ReadPitResult readPitResult2 = default(ReadPitResult);
						readPitResult2 = readPitResult;
						if (!readPitResult2.Result)
						{
							gui.Richlog(ClassDevronix.StringF, Color.Red, isBold: false, NextLine: true);
							result = false;
						}
						else
						{
							byte[] data = readPitResult2.data;
							int num = data.Length - 1;
							while (data[num] == 0)
							{
								num--;
							}
							byte[] destinationArray = new byte[num + 1 - 1 + 1];
							Array.Copy(data, destinationArray, num + 1);
							File.WriteAllBytes(Form1.String_9 + text, data);
							using MemoryStream memoryStream = new MemoryStream(Resources.mtk_enter2_pit);
							if (!Data_Update_ChangLog(memoryStream.Length))
							{
								gui.Richlog(ClassDevronix.StringF, Color.Red, isBold: false, NextLine: true);
								result = false;
							}
							else
							{
								byte[] array = new byte[(int)memoryStream.Length - 1 + 1];
								memoryStream.ReadAsync(array, 0, array.Length);
								memoryStream.Seek(0L, SeekOrigin.Begin);
								if (!Class_200.UNPACK_PIT(array))
								{
									result = false;
								}
								else
								{
									TPIT_Entry tPIT_Entry = Class_200.xPIT_Entry.ToList().Find([SpecialName] (TPIT_Entry x) => Operators.CompareString(x.MpartitionName.ToLower(), "pit", TextCompare: false) == 0);
									if (tPIT_Entry == null)
									{
										gui.Richlog(ClassDevronix.StringF, Color.Red, isBold: false, NextLine: true);
										result = false;
									}
									else
									{
										Thread.Sleep(500);
										if (Write(tPIT_Entry, memoryStream.Length, memoryStream))
										{
											SerialCOM.MSL = "DISREAD";
											Thread.Sleep(1000);
											Form1.SharedUI.ProgressBar1.Text = "Rebooting..";
											Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
											Form1.SharedUI.RichTextBox1.AppendText(ClassDevronix.StringO);
											Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
											Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Reboot Device To Download : ");
											Data_Update();
											result = true;
										}
									}
								}
							}
						}
					}
				}
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
	}

	public static bool MethodD_21()
	{
		bool result = default(bool);
		try
		{
			if (Conversions.ToBoolean(MethodD_5()))
			{
				SerialCOM.MSL = "ENREAD";
				Form1.SharedUI.ProgressBar4.Value = 0;
				Form1.SharedUI.ProgressBar4.Text = "0%";
				using MemoryStream memoryStream = new MemoryStream(Resources.mtk_enter2_bootloader);
				if (!Data_Update_ChangLog(memoryStream.Length))
				{
					gui.Richlog(ClassDevronix.StringF, Color.Red, isBold: false, NextLine: true);
					result = false;
				}
				else
				{
					TPIT_Entry tPIT_Entry = Class_200.xPIT_Entry.ToList().Find([SpecialName] (TPIT_Entry x) => Operators.CompareString(x.MpartitionName.ToLower(), "bootloader", TextCompare: false) == 0);
					if (tPIT_Entry == null)
					{
						gui.Richlog(ClassDevronix.StringF, Color.Red, isBold: false, NextLine: true);
						result = false;
					}
					else
					{
						Thread.Sleep(500);
						if (Write(tPIT_Entry, memoryStream.Length, memoryStream))
						{
							SerialCOM.MSL = "DISREAD";
							Thread.Sleep(1000);
							MethodD_6();
							result = true;
						}
					}
				}
			}
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

	public static bool MethodD_22()
	{
		bool result = default(bool);
		try
		{
			byte[] buffer = File.ReadAllBytes("Backup\\SamPit\\A326USQUADWG4_PIT_d118aa44.pit");
			if (Conversions.ToBoolean(MethodD_5()))
			{
				using MemoryStream memoryStream = new MemoryStream(buffer);
				if (!Data_Update_ChangLog(memoryStream.Length))
				{
					gui.Richlog(ClassDevronix.StringF, Color.Red, isBold: false, NextLine: true);
					result = false;
				}
				else
				{
					byte[] array = new byte[checked((int)memoryStream.Length - 1 + 1)];
					memoryStream.ReadAsync(array, 0, array.Length);
					memoryStream.Seek(0L, SeekOrigin.Begin);
					if (!Class_200.UNPACK_PIT(array))
					{
						result = false;
					}
					else
					{
						TPIT_Entry tPIT_Entry = Class_200.xPIT_Entry.ToList().Find([SpecialName] (TPIT_Entry x) => Operators.CompareString(x.MpartitionName.ToLower(), "pit", TextCompare: false) == 0);
						if (tPIT_Entry == null)
						{
							gui.Richlog(ClassDevronix.StringF, Color.Red, isBold: false, NextLine: true);
							result = false;
						}
						else
						{
							Thread.Sleep(500);
							if (Write(tPIT_Entry, memoryStream.Length, memoryStream))
							{
								Thread.Sleep(500);
								MethodD_6();
								result = true;
							}
						}
					}
				}
			}
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

	public static bool MethodD_23()
	{
		bool result = default(bool);
		try
		{
			if (Conversions.ToBoolean(MethodD_5()))
			{
				if (!Data_Update_ChangLog(0L))
				{
					result = false;
				}
				else
				{
					ReadPitResult readPitResult = MethodD_10();
					ReadPitResult readPitResult2 = default(ReadPitResult);
					readPitResult2 = readPitResult;
					if (!readPitResult2.Result)
					{
						gui.Richlog(ClassDevronix.StringF, Color.Red, isBold: false, NextLine: true);
						result = false;
					}
					else
					{
						Cme class_ = Class_203;
						TPIT_Entry entry = readPitResult2.Pit.Find([SpecialName] (TPIT_Entry x) => Operators.CompareString(x.MpartitionName.ToLower(), "pit", TextCompare: false) == 0);
						byte[] array = MethodD_17(readPitResult2.data);
						if (array == null)
						{
							gui.Richlog(ClassDevronix.StringF, Color.Red, isBold: false, NextLine: true);
							result = false;
						}
						else
						{
							using MemoryStream memoryStream = new MemoryStream(array);
							if (!Data_Update_ChangLog(memoryStream.Length))
							{
								gui.Richlog(ClassDevronix.StringF, Color.Red, isBold: false, NextLine: true);
								result = false;
							}
							else if (Write(entry, memoryStream.Length, memoryStream))
							{
								using MemoryStream memoryStream2 = new MemoryStream(Resources.pgpt);
								if (!Data_Update_ChangLog(memoryStream2.Length))
								{
									gui.Richlog(ClassDevronix.StringF, Color.Red, isBold: false, NextLine: true);
									result = false;
								}
								else
								{
									TPIT_Entry tPIT_Entry = Class_200.xPIT_Entry.ToList().Find([SpecialName] (TPIT_Entry x) => Operators.CompareString(x.MpartitionName.ToLower(), "pgpt", TextCompare: false) == 0);
									if (tPIT_Entry == null)
									{
										gui.Richlog(ClassDevronix.StringF, Color.Red, isBold: false, NextLine: true);
										result = false;
									}
									else
									{
										class_.frp_entry = tPIT_Entry;
										if (Write(class_.frp_entry, memoryStream2.Length, memoryStream2))
										{
											MethodD_6();
											result = true;
										}
									}
								}
							}
						}
					}
				}
			}
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

	public static bool MethodD_24()
	{
		bool result = default(bool);
		try
		{
			if (Conversions.ToBoolean(MethodD_5()))
			{
				if (!Data_Update_ChangLog(0L))
				{
					result = false;
				}
				else
				{
					ReadPitResult readPitResult = MethodD_10();
					ReadPitResult readPitResult2 = default(ReadPitResult);
					readPitResult2 = readPitResult;
					if (!readPitResult2.Result)
					{
						gui.Richlog(ClassDevronix.StringF, Color.Red, isBold: false, NextLine: true);
						result = false;
					}
					else
					{
						TPIT_Entry entry = readPitResult2.Pit.Find([SpecialName] (TPIT_Entry x) => Operators.CompareString(x.MpartitionName.ToLower(), "pit", TextCompare: false) == 0);
						using MemoryStream memoryStream = new MemoryStream(readPitResult2.data);
						if (!Data_Update_ChangLog(memoryStream.Length))
						{
							gui.Richlog(ClassDevronix.StringF, Color.Red, isBold: false, NextLine: true);
							result = false;
						}
						else if (Write(entry, memoryStream.Length, memoryStream))
						{
							using MemoryStream memoryStream2 = new MemoryStream(Resources.pgpt);
							if (!Data_Update_ChangLog(memoryStream2.Length))
							{
								gui.Richlog(ClassDevronix.StringF, Color.Red, isBold: false, NextLine: true);
								result = false;
							}
							else
							{
								Cme class_ = Class_203;
								TPIT_Entry tPIT_Entry = Class_200.xPIT_Entry.ToList().Find([SpecialName] (TPIT_Entry x) => Operators.CompareString(x.MpartitionName.ToLower(), "pgpt", TextCompare: false) == 0);
								if (tPIT_Entry == null)
								{
									gui.Richlog(ClassDevronix.StringF, Color.Red, isBold: false, NextLine: true);
									result = false;
								}
								else
								{
									class_.frp_entry = tPIT_Entry;
									if (Write(class_.frp_entry, memoryStream2.Length, memoryStream2))
									{
										MethodD_6();
										result = true;
									}
								}
							}
						}
					}
				}
			}
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

	public static bool MethodD_25()
	{
		bool result = default(bool);
		try
		{
			if (Conversions.ToBoolean(MethodD_5()))
			{
				Cme class_ = Class_203;
				if (!Data_Update_ChangLog(0L))
				{
					result = false;
				}
				else
				{
					using (MemoryStream memoryStream = new MemoryStream(class_.ori_pit))
					{
						bool num = Data_Update_ChangLog(memoryStream.Length);
						Form1.SharedUI.ProgressBar1.Text = ClassDevronix.I2;
						if (num)
						{
							if (Write(class_.pit_entry, memoryStream.Length, memoryStream))
							{
								using MemoryStream memoryStream2 = new MemoryStream(Resources.per);
								if (Data_Update_ChangLog(memoryStream2.Length))
								{
									Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
									Form1.SharedUI.RichTextBox1.AppendText(ClassDevronix.StringO);
									Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
									Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Removeing FRP : ");
									SerialCOM.MSL = "ENREAD";
									Form1.SharedUI.ProgressBar4.Value = 0;
									Form1.SharedUI.ProgressBar4.Text = "0%";
									if (Write(class_.frp_entry, memoryStream2.Length, memoryStream2))
									{
										Form1.SharedUI.RichTextBox1.SelectionColor = Color.LightGreen;
										Form1.SharedUI.RichTextBox1.AppendText(ClassDevronix.StringO);
										SerialCOM.MSL = "DISREAD";
										Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
										Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Rebooting Device : ");
										Form1.SharedUI.ProgressBar1.Text = "Rebooting..";
										MethodD_6();
										class_ = null;
									}
									goto end_IL_008e;
								}
								gui.Richlog(ClassDevronix.StringF, Color.Red, isBold: false, NextLine: true);
								result = false;
								goto end_IL_0000;
								end_IL_008e:;
							}
							goto end_IL_0031;
						}
						gui.Richlog(ClassDevronix.StringF, Color.Red, isBold: false, NextLine: true);
						result = false;
						goto end_IL_0000;
						end_IL_0031:;
					}
					result = true;
				}
			}
			end_IL_0000:;
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

	public static void PotsModeManagment()
	{
		foreach (ManagementObject item in new ManagementObjectSearcher("SELECT * FROM Win32_POTSModem").Get())
		{
			if (Operators.CompareString(Conversions.ToString(item["Status"]), ClassDevronix.StringO, TextCompare: false) == 0)
			{
				Form1.SharedUI.Port_Name.Items.Add(Operators.AddObject(Operators.AddObject(item["Description"], " ("), Convert.ToString(Operators.AddObject(item["AttachedTo"], ")"))));
				Form1.SharedUI.Port_Name.Text = Conversions.ToString(Operators.AddObject(Operators.AddObject(item["Description"], " ("), Convert.ToString(Operators.AddObject(item["AttachedTo"], ")"))));
				Form1.SharedUI.Port_Name.Update();
				Form1.SharedUI.Port_Name.Refresh();
				Form1.TextBox31 = Conversions.ToString(Form1.SharedUI.Port_Name.FindString("SAMSUNG Mobile USB Modem"));
				if (!Form1.SharedUI.Port_Name.Text.Contains("SAMSUNG Mobile USB Modem"))
				{
					Form1.SharedUI.Port_Name.SelectedIndex = Conversions.ToInteger(Form1.TextBox31);
				}
				if (Form1.SharedUI.Port_Name.Text.Contains("SAMSUNG Mobile USB Modem"))
				{
					Form1.SharedUI.TextBox4.Text = checked(Form1.SharedUI.Port_Name.Text.Substring(Form1.SharedUI.Port_Name.Text.IndexOf("(") + 1, Form1.SharedUI.Port_Name.Text.Length - 2 - Form1.SharedUI.Port_Name.Text.IndexOf("("))).Replace(")", "");
				}
			}
		}
	}

	public static bool Remeber_Me_AutoLogIn()
	{
		bool result = default(bool);
		try
		{
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
			Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Wait For USB Connection : ");
			Form1.SharedUI.ProgressBar1.Text = ClassDevronix.Se + ".";
			Form1.SharedUI.TextBox4.Clear();
			Form1.SharedUI.Port_Name.Items.Clear();
			while (true)
			{
				if (Operators.CompareString(Form1.TextBox41, "Cancel", TextCompare: false) == 0)
				{
					Form1.SharedUI.ProgressBar1.Text = "100%";
					break;
				}
				if (Form1.SharedUI.TextBox4.Text.Contains("COM"))
				{
					Form1.SharedUI.ProgressBar1.Text = "Connecting..";
					Thread.Sleep(500);
					Form1.SharedUI.ProgressBar1.Text = "Connecting..OK";
					break;
				}
				Thread.Sleep(50);
				Form1.SharedUI.ProgressBar1.Text = ClassDevronix.Se + "..";
				Thread.Sleep(50);
				Form1.SharedUI.ProgressBar1.Text = ClassDevronix.Se + "...";
				Thread.Sleep(50);
				Form1.SharedUI.ProgressBar1.Text = ClassDevronix.Se + "....";
				Form1.SharedUI.TextBox4.Clear();
				Form1.SharedUI.Port_Name.Items.Clear();
				PotsModeManagment();
				Thread.Sleep(50);
				Form1.SharedUI.ProgressBar1.Text = ClassDevronix.Se + ".....";
			}
			if (Form1.SharedUI.TextBox4.Text.Contains("COM"))
			{
				result = true;
			}
			else if (Operators.CompareString(Form1.TextBox41, "Cancel", TextCompare: false) == 0)
			{
				result = false;
			}
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

	public static bool PortShow()
	{
		bool result = default(bool);
		try
		{
			Form1.SharedUI.ProgressBar1.Text = ClassDevronix.Se + ".";
			Form1.SharedUI.TextBox4.Clear();
			Form1.SharedUI.Port_Name.Items.Clear();
			while (true)
			{
				if (Operators.CompareString(Form1.TextBox41, "Cancel", TextCompare: false) == 0)
				{
					Form1.SharedUI.ProgressBar1.Text = "100%";
					break;
				}
				if (Form1.SharedUI.TextBox4.Text.Contains("COM"))
				{
					Form1.SharedUI.ProgressBar1.Text = "Connecting..";
					Thread.Sleep(500);
					Form1.SharedUI.ProgressBar1.Text = "Connecting..OK";
					break;
				}
				Thread.Sleep(50);
				Form1.SharedUI.ProgressBar1.Text = ClassDevronix.Se + "..";
				Thread.Sleep(50);
				Form1.SharedUI.ProgressBar1.Text = ClassDevronix.Se + "...";
				Thread.Sleep(50);
				Form1.SharedUI.ProgressBar1.Text = ClassDevronix.Se + "....";
				Form1.SharedUI.TextBox4.Clear();
				Form1.SharedUI.Port_Name.Items.Clear();
				PotsModeManagment();
				Thread.Sleep(50);
				Form1.SharedUI.ProgressBar1.Text = ClassDevronix.Se + ".....";
			}
			if (Form1.SharedUI.TextBox4.Text.Contains("COM"))
			{
				result = true;
			}
			else if (Operators.CompareString(Form1.TextBox41, "Cancel", TextCompare: false) == 0)
			{
				result = false;
			}
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

	public static void dateTimeNow(double dblSecs)
	{
		DateAndTime.Now.AddSeconds(1.1574074074074073E-05);
		DateTime t = DateAndTime.Now.AddSeconds(1.1574074074074073E-05).AddSeconds(dblSecs);
		while (DateTime.Compare(DateAndTime.Now, t) <= 0)
		{
			Application.DoEvents();
		}
	}

	public static bool MethodD_180()
	{
		SerialCOM.MSL = null;
		bool result = default(bool);
		try
		{
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
			Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- Writing Security : ");
			Form1.SharedUI.ProgressBar1.Text = ClassDevronix.AW2;
			Form1.SharedUI.RichTextBox3.Clear();
			if (!Method0())
			{
				result = false;
			}
			else if (Operators.CompareString(Form1.TextBox41, "Cancel", TextCompare: false) == 0)
			{
				Form1.SharedUI.ProgressBar1.Text = "100%";
				result = false;
			}
			else
			{
				Form1.SharedUI.ProgressBar1.Text = ClassDevronix.GA2;
				dateTimeNow(1.0);
				SerialCOM.process.StandardInput.WriteLine(".");
				dateTimeNow(1.0);
				while (true)
				{
					Form1.SharedUI.RichTextBox3.Clear();
					Form1.SharedUI.ProgressBar1.Text = "Calculating Data..";
					SerialCOM.process.StandardInput.WriteLine("AUTH=AKS");
					string text;
					bool flag;
					do
					{
						Form1.SharedUI.ProgressBar1.Text = "Calculating Data..";
						dateTimeNow(0.3);
						text = "\r\n" + SerialCOM.process.StandardOutput.ReadLine();
						Form1.SharedUI.ProgressBar1.Text = "Calculating Data...";
						Form1.SharedUI.RichTextBox3.AppendText(text);
						dateTimeNow(0.3);
						flag = text.Contains("AKSEED Success") | text.Contains("AKSEED Failed") | text.Contains("Invalid Command") | (Operators.CompareString(Form1.TextBox41, "Cancel", TextCompare: false) == 0);
						Form1.SharedUI.ProgressBar1.Text = "Calculating Data....";
						dateTimeNow(0.3);
					}
					while (!flag);
					if (Operators.CompareString(Form1.TextBox41, "Cancel", TextCompare: false) == 0)
					{
						result = false;
						break;
					}
					Form1.SharedUI.RichTextBox3.AppendText(text);
					if (Form1.SharedUI.RichTextBox3.Text.Contains("AKSEED Failed") | Form1.SharedUI.RichTextBox3.Text.Contains("Invalid Command"))
					{
						continue;
					}
					if (!Form1.SharedUI.RichTextBox3.Text.Contains("AKSEED Success"))
					{
						break;
					}
					Form1.SharedUI.ProgressBar1.Text = "Calculating Data : OK";
					SerialCOM.process.StandardInput.WriteLine("AT+MSLSECUR=2,0000000000_01020304050607080910111213141516");
					do
					{
						dateTimeNow(0.3);
						Form1.SharedUI.ProgressBar1.Text = "Checking Data.";
						text = "\r\n" + SerialCOM.process.StandardOutput.ReadLine();
						dateTimeNow(0.3);
						Form1.SharedUI.ProgressBar1.Text = "Checking Data..";
						Form1.SharedUI.RichTextBox3.AppendText(text);
						flag = text.Contains("+MSLSECUR:2,OK") | (Operators.CompareString(Form1.TextBox41, "Cancel", TextCompare: false) == 0);
						dateTimeNow(0.3);
						Form1.SharedUI.ProgressBar1.Text = "Checking Data...";
					}
					while (!flag);
					if (Operators.CompareString(Form1.TextBox41, "Cancel", TextCompare: false) == 0)
					{
						Form1.SharedUI.ProgressBar1.Text = "100%";
						result = false;
						break;
					}
					Form1.SharedUI.RichTextBox3.AppendText(text);
					if (Form1.SharedUI.RichTextBox3.Text.Contains("+MSLSECUR:2,NG"))
					{
						SerialCOM.process.StandardInput.WriteLine("exit");
						SerialCOM.process.Kill();
						Adb.ExecuteAdbCommand(Adb.FormAdbCommand("-s " + Form1.SharedUI.serialno.Text + " wait-for-device shell pm uninstall com.samsung", new object[0]), false);
						Adb.ExecuteAdbCommand(Adb.FormAdbCommand("-s " + Form1.SharedUI.serialno.Text + " wait-for-device shell reboot", new object[0]), false);
						Form1.SharedUI.ProgressBar1.Text = "Checking Data : Failed";
						Form1.SharedUI.RichTextBox1.SelectionColor = Color.Red;
						Form1.SharedUI.RichTextBox1.AppendText(ClassDevronix.StringF);
						result = false;
					}
					else if (Form1.SharedUI.RichTextBox3.Text.Contains("+MSLSECUR:2,OK"))
					{
						Form1.SharedUI.ProgressBar1.Text = "Sanding Data..";
						result = true;
					}
					break;
				}
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception projectError = ex;
			ProjectData.SetProjectError(projectError);
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.Red;
			Form1.SharedUI.RichTextBox1.AppendText(ClassDevronix.StringF);
			SerialCOM.process.StandardInput.WriteLine("exit");
			SerialCOM.process.Kill();
			Adb.ExecuteAdbCommand(Adb.FormAdbCommand("-s " + Form1.SharedUI.serialno.Text + " wait-for-device shell pm uninstall com.samsung", new object[0]), false);
			Adb.ExecuteAdbCommand(Adb.FormAdbCommand("-s " + Form1.SharedUI.serialno.Text + " wait-for-device shell reboot", new object[0]), false);
			ProjectData.ClearProjectError();
			result = false;
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public static bool MethodD_181()
	{
		SerialCOM.MSL = null;
		bool result = default(bool);
		try
		{
			Form1.SharedUI.ProgressBar1.Text = ClassDevronix.AW2;
			Form1.SharedUI.RichTextBox3.Clear();
			if (!Method0())
			{
				result = false;
			}
			else
			{
				Form1.SharedUI.ProgressBar1.Text = ClassDevronix.GA2;
				dateTimeNow(1.0);
				SerialCOM.process.StandardInput.WriteLine(".");
				dateTimeNow(1.0);
				if (Operators.CompareString(Form1.TextBox41, "Cancel", TextCompare: false) == 0)
				{
					Form1.SharedUI.ProgressBar1.Text = "100%";
					result = false;
				}
				else
				{
					Form1.SharedUI.ProgressBar1.Text = "Wipeing Security..";
					SerialCOM.process.StandardInput.WriteLine("WIPE=MSL");
					string text;
					do
					{
						dateTimeNow(0.0);
						text = "\r\n" + SerialCOM.process.StandardOutput.ReadLine();
						Form1.SharedUI.RichTextBox3.AppendText(text);
					}
					while (!(text.Contains("Wiping Success") | (Operators.CompareString(Form1.TextBox41, "Cancel", TextCompare: false) == 0)));
					if (Operators.CompareString(Form1.TextBox41, "Cancel", TextCompare: false) == 0)
					{
						Form1.SharedUI.ProgressBar1.Text = "100%";
						result = false;
					}
					else
					{
						Form1.SharedUI.RichTextBox3.AppendText(text);
						if (Form1.SharedUI.RichTextBox3.Text.Contains("Invalid Command"))
						{
							Form1.SharedUI.RichTextBox1.SelectionColor = Color.Red;
							Form1.SharedUI.RichTextBox1.AppendText(ClassDevronix.StringF);
							SerialCOM.process.StandardInput.WriteLine("exit");
							SerialCOM.process.Kill();
							Adb.ExecuteAdbCommand(Adb.FormAdbCommand("-s " + Form1.SharedUI.serialno.Text + " wait-for-device shell pm uninstall com.samsung", new object[0]), false);
							Adb.ExecuteAdbCommand(Adb.FormAdbCommand("-s " + Form1.SharedUI.serialno.Text + " wait-for-device shell reboot", new object[0]), false);
							result = false;
						}
						else if (Form1.SharedUI.RichTextBox3.Text.Contains("Wiping Success"))
						{
							while (true)
							{
								Form1.SharedUI.RichTextBox3.Clear();
								Form1.SharedUI.ProgressBar1.Text = "Calculating Data..";
								SerialCOM.process.StandardInput.WriteLine("AUTH=AKS");
								bool flag;
								do
								{
									Form1.SharedUI.ProgressBar1.Text = "Calculating Data.";
									dateTimeNow(0.3);
									text = "\r\n" + SerialCOM.process.StandardOutput.ReadLine();
									Form1.SharedUI.ProgressBar1.Text = "Calculating Data..";
									Form1.SharedUI.RichTextBox3.AppendText(text);
									dateTimeNow(0.3);
									flag = text.Contains("AKSEED Success") | text.Contains("AKSEED Failed") | text.Contains("Invalid Command") | (Operators.CompareString(Form1.TextBox41, "Cancel", TextCompare: false) == 0);
									Form1.SharedUI.ProgressBar1.Text = "Calculating Data...";
									dateTimeNow(0.3);
								}
								while (!flag);
								if (Operators.CompareString(Form1.TextBox41, "Cancel", TextCompare: false) == 0)
								{
									Form1.SharedUI.ProgressBar1.Text = "100%";
									result = false;
									break;
								}
								Form1.SharedUI.RichTextBox3.AppendText(text);
								if (Form1.SharedUI.RichTextBox3.Text.Contains("AKSEED Failed") | Form1.SharedUI.RichTextBox3.Text.Contains("Invalid Command"))
								{
									continue;
								}
								if (!Form1.SharedUI.RichTextBox3.Text.Contains("AKSEED Success"))
								{
									break;
								}
								Form1.SharedUI.ProgressBar1.Text = "Calculating Data : OK";
								SerialCOM.process.StandardInput.WriteLine("AT+MSLSECUR=2,0000000000_01020304050607080910111213141516");
								do
								{
									dateTimeNow(0.3);
									Form1.SharedUI.ProgressBar1.Text = "Checking Data.";
									text = "\r\n" + SerialCOM.process.StandardOutput.ReadLine();
									dateTimeNow(0.3);
									Form1.SharedUI.ProgressBar1.Text = "Checking Data..";
									Form1.SharedUI.RichTextBox3.AppendText(text);
									flag = text.Contains("+MSLSECUR:2,OK") | (Operators.CompareString(Form1.TextBox41, "Cancel", TextCompare: false) == 0);
									dateTimeNow(0.3);
									Form1.SharedUI.ProgressBar1.Text = "Checking Data...";
								}
								while (!flag);
								if (Operators.CompareString(Form1.TextBox41, "Cancel", TextCompare: false) == 0)
								{
									Form1.SharedUI.ProgressBar1.Text = "100%";
									result = false;
									break;
								}
								Form1.SharedUI.RichTextBox3.AppendText(text);
								if (Form1.SharedUI.RichTextBox3.Text.Contains("+MSLSECUR:2,NG"))
								{
									Form1.SharedUI.ProgressBar1.Text = "Checking Data : Failed";
									Form1.SharedUI.RichTextBox1.SelectionColor = Color.Red;
									Form1.SharedUI.RichTextBox1.AppendText(ClassDevronix.StringF);
									SerialCOM.process.StandardInput.WriteLine("exit");
									SerialCOM.process.Kill();
									Adb.ExecuteAdbCommand(Adb.FormAdbCommand("-s " + Form1.SharedUI.serialno.Text + " wait-for-device shell pm uninstall com.samsung", new object[0]), false);
									Adb.ExecuteAdbCommand(Adb.FormAdbCommand("-s " + Form1.SharedUI.serialno.Text + " wait-for-device shell reboot", new object[0]), false);
									result = false;
								}
								else if (Form1.SharedUI.RichTextBox3.Text.Contains("+MSLSECUR:2,OK"))
								{
									Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
									Form1.SharedUI.RichTextBox1.AppendText(ClassDevronix.StringO);
									Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
									Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + ClassDevronix.UD);
									Form1.SharedUI.ProgressBar1.Text = "Sanding Data..";
									result = true;
								}
								break;
							}
						}
					}
				}
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception projectError = ex;
			ProjectData.SetProjectError(projectError);
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.Red;
			Form1.SharedUI.RichTextBox1.AppendText(ClassDevronix.StringF);
			SerialCOM.process.StandardInput.WriteLine("exit");
			SerialCOM.process.Kill();
			Adb.ExecuteAdbCommand(Adb.FormAdbCommand("-s " + Form1.SharedUI.serialno.Text + " wait-for-device shell pm uninstall com.samsung", new object[0]), false);
			Adb.ExecuteAdbCommand(Adb.FormAdbCommand("-s " + Form1.SharedUI.serialno.Text + " wait-for-device shell reboot", new object[0]), false);
			ProjectData.ClearProjectError();
			result = false;
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public static string MethodD_39(string Commands)
	{
		Process process = new Process();
		process.StartInfo.FileName = Form1.String_9 + "bin\\Tunlocker Tool.exe";
		process.StartInfo.Arguments = "/c " + Commands;
		process.StartInfo.CreateNoWindow = true;
		process.StartInfo.UseShellExecute = false;
		process.StartInfo.RedirectStandardOutput = true;
		process.StartInfo.RedirectStandardError = true;
		process.Start();
		Form1.SharedUI.RichTextBox4.Text = process.StandardOutput.ReadToEnd();
		return Form1.SharedUI.RichTextBox4.Lines[1];
	}

	public static bool MethodD_182()
	{
		SerialCOM.MSL = null;
		bool result = default(bool);
		try
		{
			Form1.SharedUI.RichTextBox3.Clear();
			Form1.SharedUI.ProgressBar1.Text = ClassDevronix.AW2;
			string path = Form1.String_9 + "bin\\1";
			string path2 = Form1.String_9 + "bin\\1";
			try
			{
				File.Delete(path2);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
			string path3 = Form1.String_9 + "bin\\akseed_calc.exe";
			try
			{
				File.Delete(path3);
			}
			catch (Exception ex3)
			{
				ProjectData.SetProjectError(ex3);
				Exception ex4 = ex3;
				ProjectData.ClearProjectError();
			}
			string path4 = Form1.String_9 + "bin\\akseed_calc.pdb";
			try
			{
				File.Delete(path4);
			}
			catch (Exception ex5)
			{
				ProjectData.SetProjectError(ex5);
				Exception ex6 = ex5;
				ProjectData.ClearProjectError();
			}
			dateTimeNow(1.0);
			File.WriteAllBytes(path, Resources.ATS7Write);
			dateTimeNow(1.0);
			Adb.ExecuteAdbCommand(Adb.FormAdbCommand("-s " + Form1.SharedUI.serialno.Text + " wait-for-device push bin\\1 /data/local/tmp/1", new object[0]), false);
			File.Delete(path);
			if (Operators.CompareString(Form1.TextBox41, "Cancel", TextCompare: false) == 0)
			{
				Form1.SharedUI.ProgressBar1.Text = "100%";
				result = false;
			}
			else
			{
				Adb.ExecuteAdbCommand(Adb.FormAdbCommand("-s " + Form1.SharedUI.serialno.Text + " wait-for-device shell chmod 0777 /data/local/tmp/1", new object[0]), false);
				SerialCOM.process.StartInfo.UseShellExecute = false;
				SerialCOM.process.StartInfo.RedirectStandardInput = true;
				SerialCOM.process.StartInfo.RedirectStandardOutput = true;
				SerialCOM.process.StartInfo.RedirectStandardError = true;
				SerialCOM.process.StartInfo.CreateNoWindow = true;
				SerialCOM.process.StartInfo.FileName = Form1.String_9 + "bin\\Tunlocker Tool.exe";
				SerialCOM.process.Start();
				SerialCOM.process.StandardInput.WriteLine(Form1.String_73 + "adb.exe shell /data/local/tmp/1");
				Form1.SharedUI.ProgressBar1.Text = ClassDevronix.GA2;
				dateTimeNow(1.0);
				SerialCOM.process.StandardInput.WriteLine(".");
				dateTimeNow(1.0);
				if (Operators.CompareString(Form1.TextBox41, "Cancel", TextCompare: false) == 0)
				{
					Form1.SharedUI.ProgressBar1.Text = "100%";
					result = false;
				}
				else
				{
					SerialCOM.process.StandardInput.WriteLine("AT+AKSEEDNO=1,00");
					string text;
					bool flag;
					do
					{
						dateTimeNow(0.3);
						Form1.SharedUI.ProgressBar1.Text = ClassDevronix.GA2;
						text = "\r\n" + SerialCOM.process.StandardOutput.ReadLine();
						dateTimeNow(0.3);
						Form1.SharedUI.ProgressBar1.Text = "Getting Auth..";
						Form1.SharedUI.RichTextBox3.AppendText(text);
						flag = text.Contains("AKSEEDNO:1,") | (Operators.CompareString(Form1.TextBox41, "Cancel", TextCompare: false) == 0);
						dateTimeNow(0.3);
						Form1.SharedUI.ProgressBar1.Text = "Getting Auth...";
					}
					while (!flag);
					if (Operators.CompareString(Form1.TextBox41, "Cancel", TextCompare: false) == 0)
					{
						Form1.SharedUI.ProgressBar1.Text = "100%";
						result = false;
					}
					else
					{
						Form1.SharedUI.ProgressBar1.Text = "Getting Auth : Ok";
						Form1.SharedUI.RichTextBox3.AppendText(text);
						string text2 = text.Split(',')[1];
						Form1.SharedUI.out_akseed.Text = text2;
						string text3 = Form1.SharedUI.out_akseed.Text;
						text3 = text3.Replace("-", " ");
						string path5 = Form1.String_9 + "bin\\akseed_calc.exe";
						File.WriteAllBytes(path5, Resources.akseed1);
						string path6 = Form1.String_9 + "bin\\akseed_calc.pdb";
						File.WriteAllBytes(path6, Resources.akseed2);
						dateTimeNow(1.0);
						Form1.SharedUI.RichTextBox4.Text = MethodD_39("bin\\akseed_calc.exe " + text3);
						Form1.SharedUI.in_akseed.Text = Form1.SharedUI.RichTextBox4.Text;
						Form1.SharedUI.RichTextBox4.Clear();
						File.Delete(path5);
						File.Delete(path6);
						if (Operators.CompareString(Form1.SharedUI.in_akseed.Text, "", TextCompare: false) == 0)
						{
							Form1.SharedUI.ProgressBar1.Text = "Getting Auth : Failed";
							SerialCOM.process.StandardInput.WriteLine("exit");
							SerialCOM.process.Kill();
							Adb.ExecuteAdbCommand(Adb.FormAdbCommand("-s " + Form1.SharedUI.serialno.Text + " wait-for-device shell rm -r /data/local/tmp/1", new object[0]), false);
							Adb.ExecuteAdbCommand(Adb.FormAdbCommand("-s " + Form1.SharedUI.serialno.Text + " wait-for-device shell reboot", new object[0]), false);
							Form1.SharedUI.RichTextBox1.SelectionColor = Color.Red;
							Form1.SharedUI.RichTextBox1.AppendText(ClassDevronix.StringF);
							result = false;
						}
						else
						{
							SerialCOM.process.StandardInput.WriteLine("AT+AKSEEDNO=0," + Form1.SharedUI.in_akseed.Text);
							do
							{
								Form1.SharedUI.ProgressBar1.Text = "Calculating Data..";
								text = "\r\n" + SerialCOM.process.StandardOutput.ReadLine();
								dateTimeNow(0.3);
								Form1.SharedUI.ProgressBar1.Text = "Calculating Data...";
								Form1.SharedUI.RichTextBox3.AppendText(text);
								dateTimeNow(0.3);
								flag = text.Contains(",NA") | text.Contains(",NG") | text.Contains("+AKSEEDNO:0,OK") | (Operators.CompareString(Form1.TextBox41, "Cancel", TextCompare: false) == 0);
								Form1.SharedUI.ProgressBar1.Text = "Calculating Data....";
								dateTimeNow(0.3);
							}
							while (!flag);
							if (Operators.CompareString(Form1.TextBox41, "Cancel", TextCompare: false) == 0)
							{
								Form1.SharedUI.ProgressBar1.Text = "100%";
								result = false;
							}
							else
							{
								Form1.SharedUI.RichTextBox3.AppendText(text);
								if (Form1.SharedUI.RichTextBox3.Text.Contains(",NA") | Form1.SharedUI.RichTextBox3.Text.Contains(",NG"))
								{
									Form1.SharedUI.ProgressBar1.Text = "Calculating Data : Failed";
									SerialCOM.process.StandardInput.WriteLine("exit");
									SerialCOM.process.Kill();
									Adb.ExecuteAdbCommand(Adb.FormAdbCommand("-s " + Form1.SharedUI.serialno.Text + " wait-for-device shell rm -r /data/local/tmp/1", new object[0]), false);
									Adb.ExecuteAdbCommand(Adb.FormAdbCommand("-s " + Form1.SharedUI.serialno.Text + " wait-for-device shell reboot", new object[0]), false);
									Form1.SharedUI.RichTextBox1.SelectionColor = Color.Red;
									Form1.SharedUI.RichTextBox1.AppendText(ClassDevronix.StringF);
									result = false;
								}
								else if (Form1.SharedUI.RichTextBox3.Text.Contains("+AKSEEDNO:0,OK"))
								{
									Form1.SharedUI.ProgressBar1.Text = "Calculating Data : OK";
									SerialCOM.process.StandardInput.WriteLine("AT+MSLSECUR=2,0000000000_01020304050607080910111213141516");
									do
									{
										dateTimeNow(0.3);
										Form1.SharedUI.ProgressBar1.Text = "Checking Data..";
										text = "\r\n" + SerialCOM.process.StandardOutput.ReadLine();
										dateTimeNow(0.3);
										Form1.SharedUI.ProgressBar1.Text = "Checking Data...";
										Form1.SharedUI.RichTextBox3.AppendText(text);
										flag = text.Contains("+MSLSECUR:2,OK") | text.Contains("Error") | (Operators.CompareString(Form1.TextBox41, "Cancel", TextCompare: false) == 0);
										dateTimeNow(0.3);
										Form1.SharedUI.ProgressBar1.Text = "Checking Data....";
									}
									while (!flag);
									if (Operators.CompareString(Form1.TextBox41, "Cancel", TextCompare: false) == 0)
									{
										Form1.SharedUI.ProgressBar1.Text = "100%";
										result = false;
									}
									else if (Form1.SharedUI.RichTextBox3.Text.Contains("Error"))
									{
										Form1.SharedUI.ProgressBar1.Text = "Checking Data : Failed";
										SerialCOM.process.StandardInput.WriteLine("exit");
										SerialCOM.process.Kill();
										Adb.ExecuteAdbCommand(Adb.FormAdbCommand("-s " + Form1.SharedUI.serialno.Text + " wait-for-device shell rm -r /data/local/tmp/1", new object[0]), false);
										Adb.ExecuteAdbCommand(Adb.FormAdbCommand("-s " + Form1.SharedUI.serialno.Text + " wait-for-device shell reboot", new object[0]), false);
										Form1.SharedUI.RichTextBox1.SelectionColor = Color.Red;
										Form1.SharedUI.RichTextBox1.AppendText(ClassDevronix.StringF);
										result = false;
									}
									else if (Form1.SharedUI.RichTextBox3.Text.Contains("+MSLSECUR:2,OK"))
									{
										Form1.SharedUI.ProgressBar1.Text = "Checking Data : OK";
										result = true;
									}
								}
							}
						}
					}
				}
			}
		}
		catch (Exception ex7)
		{
			ProjectData.SetProjectError(ex7);
			Exception projectError = ex7;
			ProjectData.SetProjectError(projectError);
			SerialCOM.process.StandardInput.WriteLine("exit");
			SerialCOM.process.Kill();
			Adb.ExecuteAdbCommand(Adb.FormAdbCommand("-s " + Form1.SharedUI.serialno.Text + " wait-for-device shell rm -r /data/local/tmp/1", new object[0]), false);
			Adb.ExecuteAdbCommand(Adb.FormAdbCommand("-s " + Form1.SharedUI.serialno.Text + " wait-for-device shell reboot", new object[0]), false);
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.Red;
			Form1.SharedUI.RichTextBox1.AppendText(ClassDevronix.StringF);
			ProjectData.ClearProjectError();
			result = false;
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public static object write_cert_For_calcnew()
	{
		if (device_info.security_patch.Contains("2020") | device_info.security_patch.Contains("2021"))
		{
			if (Operators.CompareString(Form1.String_71, null, TextCompare: false) == 0)
			{
				SerialCOM.MSL = null;
				if (Operators.CompareString(Form1.TextBox41, "Cancel", TextCompare: false) == 0)
				{
					Form1.SharedUI.ProgressBar1.Text = "100%";
					return false;
				}
				smethod_2020();
			}
			else
			{
				if (Operators.CompareString(Form1.TextBox41, "Cancel", TextCompare: false) == 0)
				{
					Form1.SharedUI.ProgressBar1.Text = "100%";
					return false;
				}
				SerialCOM.MSL = null;
				smethod_2020writecert();
			}
		}
		else if (Operators.CompareString(Form1.String_71, null, TextCompare: false) == 0)
		{
			SerialCOM.MSL = null;
			if (Operators.CompareString(Form1.TextBox41, "Cancel", TextCompare: false) == 0)
			{
				Form1.SharedUI.ProgressBar1.Text = "100%";
				return false;
			}
			smethod_19();
		}
		else
		{
			SerialCOM.MSL = null;
			if (Operators.CompareString(Form1.TextBox41, "Cancel", TextCompare: false) == 0)
			{
				Form1.SharedUI.ProgressBar1.Text = "100%";
				return false;
			}
			smethod_20();
		}
		return true;
	}

	public static object WriteSECQCATT2()
	{
		ArrayList arrayList = qcert3.newsuucrt(Form1.String_71);
		string text = qcert3.imei.Substring(0, 14);
		string text2 = Conversions.ToString(Operators.AddObject("01", arrayList[0]));
		string text3 = Conversions.ToString(Operators.AddObject("02", arrayList[1]));
		string text4 = Conversions.ToString(Operators.AddObject("03", arrayList[2]));
		string text5 = Conversions.ToString(Operators.AddObject("04", arrayList[3]));
		string text6 = Conversions.ToString(Operators.AddObject("05", arrayList[4]));
		try
		{
			SerialCOM.MSL = "0";
			string text7 = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());
			File.WriteAllBytes(text7, Resources.wrc);
			Adb.ExecuteAdbCommand(Adb.FormAdbCommand("wait-for-device push " + text7 + " /data/local/tmp/tempA", new object[0]), false);
			Thread.Sleep(1000);
			Adb.ExecuteAdbCommand(Adb.FormAdbCommand("wait-for-device shell chmod 0777 /data/local/tmp/tempA", new object[0]), false);
			SerialCOM.process.StartInfo.UseShellExecute = false;
			SerialCOM.process.StartInfo.RedirectStandardInput = true;
			SerialCOM.process.StartInfo.RedirectStandardOutput = true;
			SerialCOM.process.StartInfo.RedirectStandardError = true;
			SerialCOM.process.StartInfo.CreateNoWindow = true;
			SerialCOM.process.StartInfo.FileName = Form1.String_9 + "bin\\Tunlocker Tool.exe";
			SerialCOM.process.Start();
			File.Delete(text7);
			Thread.Sleep(500);
			SerialCOM.process.StandardInput.WriteLine(Form1.String_73 + "adb.exe shell /data/local/tmp/tempA");
			Thread.Sleep(1000);
			SerialCOM.MSL = "1";
			SerialCOM.process.StandardInput.WriteLine("ATSH");
			Thread.Sleep(2000);
			SerialCOM.MSL = "2";
			SerialCOM.process.StandardInput.WriteLine("AT+MSLSECUR=1,0");
			Thread.Sleep(3500);
			SerialCOM.process.StandardInput.WriteLine("AT+MSLSECUR=2,0000000000_01020304050607080910111213141516");
			Thread.Sleep(3000);
			SerialCOM.MSL = "3";
			SerialCOM.process.StandardInput.WriteLine("AT+AKSEEDNO=1,0");
			Thread.Sleep(4000);
			SerialCOM.process.StandardInput.WriteLine("AT+IMEITEST=2," + text);
			Thread.Sleep(4000);
			SerialCOM.MSL = "4";
			SerialCOM.process.StandardInput.WriteLine("AT+IMEISIGN=1,1,0");
			Thread.Sleep(4000);
			SerialCOM.process.StandardInput.WriteLine("AT+IMEISIGN=2,1," + text2);
			Thread.Sleep(4000);
			SerialCOM.process.StandardInput.WriteLine("AT+IMEISIGN=2,1," + text3);
			Thread.Sleep(4000);
			SerialCOM.MSL = "5";
			SerialCOM.process.StandardInput.WriteLine("AT+IMEISIGN=2,1," + text4);
			Thread.Sleep(4000);
			SerialCOM.process.StandardInput.WriteLine("AT+IMEISIGN=2,1," + text5);
			Thread.Sleep(4000);
			SerialCOM.MSL = "6";
			SerialCOM.process.StandardInput.WriteLine("AT+IMEISIGN=2,1," + text6);
			Thread.Sleep(4000);
			SerialCOM.process.StandardInput.WriteLine("AT+IMEISIGN=2,1,FF");
			Thread.Sleep(4000);
			if (device_info.model.Contains("SCV3"))
			{
				SerialCOM.process.StandardInput.WriteLine("AT+RFBYCODE=2,0,DCM");
				Thread.Sleep(2000);
				SerialCOM.process.StandardInput.WriteLine("AT+RFBYCODE=2,1,DCM");
			}
			if (device_info.model.Contains("SC-0"))
			{
				SerialCOM.process.StandardInput.WriteLine("AT+RFBYCODE=2,0,DCM");
				Thread.Sleep(2000);
				SerialCOM.process.StandardInput.WriteLine("AT+RFBYCODE=2,1,DCM");
			}
			if (device_info.Carrier.Contains("SPR"))
			{
				SerialCOM.process.StandardInput.WriteLine("AT+RFBYCODE=2,0,XAA");
				Thread.Sleep(3000);
				SerialCOM.process.StandardInput.WriteLine("AT+RFBYCODE=2,1,XAA");
				Thread.Sleep(3000);
			}
			SerialCOM.process.StandardInput.WriteLine("AT+IMEISIGN=0,1,0");
			SerialCOM.MSL = "7";
			Thread.Sleep(3000);
			SerialCOM.process.StandardInput.WriteLine("AT+DETALOCK=2,00000000,00000000,00000000,00000000,00000000,00000000");
			Thread.Sleep(3500);
			SerialCOM.MSL = "8";
			SerialCOM.process.StandardInput.WriteLine("exit");
			Thread.Sleep(3000);
			Adb.ExecuteAdbCommand(Adb.FormAdbCommand("rm /data/local/tmp/tempA", new object[0]), false);
			SerialCOM.MSL = "9";
			Adb.ExecuteAdbCommand(Adb.FormAdbCommand("reboot debug0x4f4c", new object[0]), false);
			SerialCOM.MSL = null;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
		object result = default(object);
		return result;
	}

	public static object smethod_20()
	{
		SerialCOM.MSL = "0";
		ArrayList arrayList = qcert3.newsuucrt(Form1.String_71);
		string text = qcert3.imei.Substring(0, 14);
		string text2 = "01";
		string text3 = text2 + RuntimeHelpers.GetObjectValue(arrayList[0]);
		string text4 = "02";
		string text5 = text4 + RuntimeHelpers.GetObjectValue(arrayList[1]);
		string text6 = "03";
		string text7 = text6 + RuntimeHelpers.GetObjectValue(arrayList[2]);
		string text8 = "04";
		string text9 = text8 + RuntimeHelpers.GetObjectValue(arrayList[3]);
		string text10 = "05";
		string text11 = text10 + RuntimeHelpers.GetObjectValue(arrayList[4]);
		try
		{
			SerialCOM.process.StandardInput.WriteLine("AT+IMEITEST=2," + text);
			Thread.Sleep(1000);
			SerialCOM.MSL = "1";
			Thread.Sleep(3000);
			SerialCOM.MSL = "2";
			SerialCOM.process.StandardInput.WriteLine("AT+IMEISIGN=2,1," + text3);
			Thread.Sleep(3000);
			SerialCOM.MSL = "3";
			SerialCOM.process.StandardInput.WriteLine("AT+IMEISIGN=2,1," + text5);
			Thread.Sleep(3000);
			SerialCOM.MSL = "4";
			SerialCOM.process.StandardInput.WriteLine("AT+IMEISIGN=2,1," + text7);
			Thread.Sleep(3000);
			SerialCOM.MSL = "5";
			SerialCOM.process.StandardInput.WriteLine("AT+IMEISIGN=2,1," + text9);
			Thread.Sleep(3000);
			SerialCOM.MSL = "6";
			SerialCOM.process.StandardInput.WriteLine("AT+IMEISIGN=2,1," + text11);
			Thread.Sleep(3000);
			SerialCOM.MSL = "7";
			SerialCOM.process.StandardInput.WriteLine("AT+IMEISIGN=2,1,FF");
			Thread.Sleep(3000);
			SerialCOM.MSL = "8";
			if (device_info.model.Contains("SCV3") || device_info.model.Contains("SC-0"))
			{
				SerialCOM.process.StandardInput.WriteLine("AT+RFBYCODE=2,0,DCM");
				Thread.Sleep(3000);
				SerialCOM.process.StandardInput.WriteLine("AT+RFBYCODE=2,1,DCM");
				Thread.Sleep(3000);
			}
			if (device_info.Carrier.Contains("SPR"))
			{
				SerialCOM.process.StandardInput.WriteLine("AT+RFBYCODE=2,0,XAA");
				Thread.Sleep(3000);
				SerialCOM.process.StandardInput.WriteLine("AT+RFBYCODE=2,1,XAA");
				Thread.Sleep(3000);
			}
			SerialCOM.process.StandardInput.WriteLine("AT+DETALOCK=2,00000000,00000000,00000000,00000000,00000000,00000000");
			Thread.Sleep(3000);
			SerialCOM.MSL = "9";
			SerialCOM.process.StandardInput.WriteLine("exit");
			Thread.Sleep(2000);
			Adb.ExecuteAdbCommand(Adb.FormAdbCommand("rm /data/local/tmp/1", new object[0]), false);
			Adb.ExecuteAdbCommand(Adb.FormAdbCommand("reboot debug0x4f4c", new object[0]), false);
			SerialCOM.MSL = null;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
		object result = default(object);
		return result;
	}

	public static object smethod_19()
	{
		SerialCOM.MSL = "0";
		ArrayList arrayList = qcert3.smethod_0();
		string text = device_info.imei.Substring(0, 14);
		string text2 = "01";
		string text3 = text2 + RuntimeHelpers.GetObjectValue(arrayList[0]);
		string text4 = "02";
		string text5 = text4 + RuntimeHelpers.GetObjectValue(arrayList[1]);
		string text6 = "03";
		string text7 = text6 + RuntimeHelpers.GetObjectValue(arrayList[2]);
		string text8 = "04";
		string text9 = text8 + RuntimeHelpers.GetObjectValue(arrayList[3]);
		string text10 = "05";
		string text11 = text10 + RuntimeHelpers.GetObjectValue(arrayList[4]);
		try
		{
			SerialCOM.process.StandardInput.WriteLine("AT+IMEITEST=2," + text);
			Thread.Sleep(1000);
			SerialCOM.MSL = "1";
			Thread.Sleep(3000);
			SerialCOM.MSL = "2";
			SerialCOM.process.StandardInput.WriteLine("AT+IMEISIGN=2,1," + text3);
			Thread.Sleep(3000);
			SerialCOM.MSL = "3";
			SerialCOM.process.StandardInput.WriteLine("AT+IMEISIGN=2,1," + text5);
			Thread.Sleep(3000);
			SerialCOM.MSL = "4";
			SerialCOM.process.StandardInput.WriteLine("AT+IMEISIGN=2,1," + text7);
			Thread.Sleep(3000);
			SerialCOM.MSL = "5";
			SerialCOM.process.StandardInput.WriteLine("AT+IMEISIGN=2,1," + text9);
			Thread.Sleep(3000);
			SerialCOM.MSL = "6";
			SerialCOM.process.StandardInput.WriteLine("AT+IMEISIGN=2,1," + text11);
			Thread.Sleep(3000);
			SerialCOM.MSL = "7";
			SerialCOM.process.StandardInput.WriteLine("AT+IMEISIGN=2,1,FF");
			Thread.Sleep(3000);
			SerialCOM.MSL = "8";
			if (device_info.model.Contains("SCV3") || device_info.model.Contains("SC-0"))
			{
				SerialCOM.process.StandardInput.WriteLine("AT+RFBYCODE=2,0,DCM");
				Thread.Sleep(3000);
				SerialCOM.process.StandardInput.WriteLine("AT+RFBYCODE=2,1,DCM");
				Thread.Sleep(3000);
			}
			if (device_info.Carrier.Contains("SPR"))
			{
				SerialCOM.process.StandardInput.WriteLine("AT+RFBYCODE=2,0,XAA");
				Thread.Sleep(3000);
				SerialCOM.process.StandardInput.WriteLine("AT+RFBYCODE=2,1,XAA");
				Thread.Sleep(3000);
			}
			SerialCOM.process.StandardInput.WriteLine("AT+DETALOCK=2,00000000,00000000,00000000,00000000,00000000,00000000");
			Thread.Sleep(3000);
			SerialCOM.MSL = "9";
			SerialCOM.process.StandardInput.WriteLine("exit");
			Thread.Sleep(2000);
			Adb.ExecuteAdbCommand(Adb.FormAdbCommand("rm /data/local/tmp/1", new object[0]), false);
			Adb.ExecuteAdbCommand(Adb.FormAdbCommand("reboot debug0x4f4c", new object[0]), false);
			SerialCOM.MSL = null;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
		object result = default(object);
		return result;
	}

	public static object smethod_2020()
	{
		SerialCOM.MSL = "0";
		ArrayList arrayList = qcert3.smethod_0();
		string text = device_info.imei.Substring(0, 14);
		string text2 = Conversions.ToString(Operators.AddObject("01", arrayList[0]));
		string text3 = Conversions.ToString(Operators.AddObject("02", arrayList[1]));
		string text4 = Conversions.ToString(Operators.AddObject("03", arrayList[2]));
		string text5 = Conversions.ToString(Operators.AddObject("04", arrayList[3]));
		string text6 = Conversions.ToString(Operators.AddObject("05", arrayList[4]));
		try
		{
			SerialCOM.MSL = "1";
			SerialCOM.process.StandardInput.WriteLine("AT+IMEITEST=2," + text);
			Thread.Sleep(4000);
			SerialCOM.MSL = "2";
			SerialCOM.process.StandardInput.WriteLine("AT+IMEISIGN=2,1," + text2);
			Thread.Sleep(4000);
			SerialCOM.MSL = "3";
			SerialCOM.process.StandardInput.WriteLine("AT+IMEISIGN=2,1," + text3);
			Thread.Sleep(4000);
			SerialCOM.MSL = "4";
			SerialCOM.process.StandardInput.WriteLine("AT+IMEISIGN=2,1," + text4);
			Thread.Sleep(4000);
			SerialCOM.MSL = "5";
			SerialCOM.process.StandardInput.WriteLine("AT+IMEISIGN=2,1," + text5);
			Thread.Sleep(4000);
			SerialCOM.MSL = "6";
			SerialCOM.process.StandardInput.WriteLine("AT+IMEISIGN=2,1," + text6);
			Thread.Sleep(4000);
			SerialCOM.MSL = "7";
			Thread.Sleep(3000);
			SerialCOM.process.StandardInput.WriteLine("AT+DETALOCK=2,00000000,00000000,00000000,00000000,00000000,00000000");
			Thread.Sleep(4000);
			SerialCOM.MSL = "8";
			SerialCOM.process.StandardInput.WriteLine("AT+IMEISIGN=2,1,FF");
			Thread.Sleep(4000);
			SerialCOM.MSL = "9";
			SerialCOM.process.StandardInput.WriteLine("exit");
			Thread.Sleep(2000);
			Adb.ExecuteAdbCommand(Adb.FormAdbCommand("shell am force-stop com.samsung", new object[0]), false);
			Adb.ExecuteAdbCommand(Adb.FormAdbCommand("shell pm uninstall com.samsung", new object[0]), false);
			Adb.ExecuteAdbCommand(Adb.FormAdbCommand("reboot debug0x4f4c", new object[0]), false);
			SerialCOM.MSL = null;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
		object result = default(object);
		return result;
	}

	public static object smethod_2020writecert()
	{
		SerialCOM.MSL = "0";
		ArrayList arrayList = qcert3.newsuucrt(Form1.String_71);
		string text = qcert3.imei.Substring(0, 14);
		string text2 = Conversions.ToString(Operators.AddObject("01", arrayList[0]));
		string text3 = Conversions.ToString(Operators.AddObject("02", arrayList[1]));
		string text4 = Conversions.ToString(Operators.AddObject("03", arrayList[2]));
		string text5 = Conversions.ToString(Operators.AddObject("04", arrayList[3]));
		string text6 = Conversions.ToString(Operators.AddObject("05", arrayList[4]));
		try
		{
			SerialCOM.MSL = "1";
			SerialCOM.process.StandardInput.WriteLine("AT+IMEITEST=2," + text);
			Thread.Sleep(4000);
			SerialCOM.MSL = "2";
			SerialCOM.process.StandardInput.WriteLine("AT+IMEISIGN=2,1," + text2);
			Thread.Sleep(4000);
			SerialCOM.MSL = "3";
			SerialCOM.process.StandardInput.WriteLine("AT+IMEISIGN=2,1," + text3);
			Thread.Sleep(4000);
			SerialCOM.MSL = "4";
			SerialCOM.process.StandardInput.WriteLine("AT+IMEISIGN=2,1," + text4);
			Thread.Sleep(4000);
			SerialCOM.MSL = "5";
			SerialCOM.process.StandardInput.WriteLine("AT+IMEISIGN=2,1," + text5);
			Thread.Sleep(4000);
			SerialCOM.MSL = "6";
			SerialCOM.process.StandardInput.WriteLine("AT+IMEISIGN=2,1," + text6);
			Thread.Sleep(4000);
			SerialCOM.MSL = "7";
			Thread.Sleep(3000);
			SerialCOM.process.StandardInput.WriteLine("AT+DETALOCK=2,00000000,00000000,00000000,00000000,00000000,00000000");
			Thread.Sleep(4000);
			SerialCOM.MSL = "8";
			SerialCOM.process.StandardInput.WriteLine("AT+IMEISIGN=2,1,FF");
			Thread.Sleep(4000);
			SerialCOM.MSL = "9";
			SerialCOM.process.StandardInput.WriteLine("exit");
			Thread.Sleep(2000);
			Adb.ExecuteAdbCommand(Adb.FormAdbCommand("shell am force-stop com.samsung", new object[0]), false);
			Adb.ExecuteAdbCommand(Adb.FormAdbCommand("shell pm uninstall com.samsung", new object[0]), false);
			Adb.ExecuteAdbCommand(Adb.FormAdbCommand("reboot debug0x4f4c", new object[0]), false);
			SerialCOM.MSL = null;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
		object result = default(object);
		return result;
	}
}
