using System;
using System.Collections;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using motoulocked.motoulocked;
using motoulocked.motoulocked.mtkclient2.MTK.Client;
using motoulocked.mtkclient2.devicehandler;
using motoulocked.mtkclient2.library;
using motoulocked.mtkclient2.library.xflash;
using motoulocked.mtkclient2.MTK.Client;
using motoulocked.mtkclient2.MTK.Client.Scatter;

namespace motoulocked.mtkclient2.Tasks;

internal class MtkTask
{
	public enum EXECUTION_STATE : uint
	{
		ES_SYSTEM_REQUIRED = 1u,
		ES_DISPLAY_REQUIRED = 2u,
		ES_CONTINUOUS = 0x80000000u
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__36_002D0
	{
		public double _0024VB_0024Local_percentage;

		public _Closure_0024__36_002D0(_Closure_0024__36_002D0 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024Local_percentage = arg0._0024VB_0024Local_percentage;
			}
		}

		[SpecialName]
		internal void _Lambda_0024__0()
		{
			Form1.SharedUI.ProgressBar4.Value = checked((int)Math.Round(_0024VB_0024Local_percentage));
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__38_002D0
	{
		public double _0024VB_0024Local_percentage;

		public _Closure_0024__38_002D0(_Closure_0024__38_002D0 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024Local_percentage = arg0._0024VB_0024Local_percentage;
			}
		}

		[SpecialName]
		internal void _Lambda_0024__0()
		{
			Form1.SharedUI.ProgressBar4.Value = checked((int)Math.Round(_0024VB_0024Local_percentage));
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__39_002D0
	{
		public double _0024VB_0024Local_percentage;

		public _Closure_0024__39_002D0(_Closure_0024__39_002D0 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024Local_percentage = arg0._0024VB_0024Local_percentage;
			}
		}

		[SpecialName]
		internal void _Lambda_0024__0()
		{
			Form1.SharedUI.ProgressBar4.Value = checked((int)Math.Round(_0024VB_0024Local_percentage));
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__40_002D0
	{
		public double _0024VB_0024Local_percentage;

		public _Closure_0024__40_002D0(_Closure_0024__40_002D0 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024Local_percentage = arg0._0024VB_0024Local_percentage;
			}
		}

		[SpecialName]
		internal void _Lambda_0024__0()
		{
			Form1.SharedUI.ProgressBar4.Value = checked((int)Math.Round(_0024VB_0024Local_percentage));
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__55_002D0
	{
		public string _0024VB_0024Local_sizeboot;

		public _Closure_0024__55_002D1 _0024VB_0024NonLocal__0024VB_0024Closure_2;

		public _Closure_0024__55_002D0(_Closure_0024__55_002D0 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024Local_sizeboot = arg0._0024VB_0024Local_sizeboot;
			}
		}

		[SpecialName]
		internal void _Lambda_0024__0()
		{
			Protocol_MTK_By_Devronix.SharedUI.DataViewmtk.Rows.Add(false, "boot", "preloader", "0x0", utils.LongToHex(Mediatek.BootSize), _0024VB_0024Local_sizeboot, "", _0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_regionBOOT);
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__55_002D1
	{
		public string _0024VB_0024Local_regionBOOT;

		public string _0024VB_0024Local_region;

		public _Closure_0024__55_002D1(_Closure_0024__55_002D1 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024Local_regionBOOT = arg0._0024VB_0024Local_regionBOOT;
				_0024VB_0024Local_region = arg0._0024VB_0024Local_region;
			}
		}

		[SpecialName]
		internal void _Lambda_0024__1()
		{
			Protocol_MTK_By_Devronix.SharedUI.DataViewmtk.Rows.Add(false, "userarea", "PGPT", "0x0", "0x8000", "32.00 KB", "", _0024VB_0024Local_region);
		}

		[SpecialName]
		internal void _Lambda_0024__4()
		{
			Protocol_MTK_By_Devronix.SharedUI.DataViewmtk.Rows.Add(false, "userarea", "PGPT", "0x0", "0x8000", "512 KB", "", _0024VB_0024Local_region);
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__55_002D2
	{
		public MtkGptPartition _0024VB_0024Local_sourceItem;

		public _Closure_0024__55_002D0 _0024VB_0024NonLocal__0024VB_0024Closure_3;

		public _Closure_0024__55_002D2(_Closure_0024__55_002D2 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024Local_sourceItem = arg0._0024VB_0024Local_sourceItem;
			}
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__55_002D3
	{
		public string _0024VB_0024Local_hh1;

		public string _0024VB_0024Local_hh2;

		public string _0024VB_0024Local_size;

		public _Closure_0024__55_002D2 _0024VB_0024NonLocal__0024VB_0024Closure_4;

		public _Closure_0024__55_002D3(_Closure_0024__55_002D3 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024Local_hh1 = arg0._0024VB_0024Local_hh1;
				_0024VB_0024Local_hh2 = arg0._0024VB_0024Local_hh2;
				_0024VB_0024Local_size = arg0._0024VB_0024Local_size;
			}
		}

		[SpecialName]
		internal void _Lambda_0024__2()
		{
			Protocol_MTK_By_Devronix.SharedUI.DataViewmtk.Rows.Add(false, "userarea", _0024VB_0024NonLocal__0024VB_0024Closure_4._0024VB_0024Local_sourceItem.Name, _0024VB_0024Local_hh1, _0024VB_0024Local_hh2, _0024VB_0024Local_size, "", _0024VB_0024NonLocal__0024VB_0024Closure_4._0024VB_0024NonLocal__0024VB_0024Closure_3._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_region);
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__55_002D4
	{
		public string _0024VB_0024Local_sizeboot;

		public _Closure_0024__55_002D1 _0024VB_0024NonLocal__0024VB_0024Closure_5;

		public _Closure_0024__55_002D4(_Closure_0024__55_002D4 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024Local_sizeboot = arg0._0024VB_0024Local_sizeboot;
			}
		}

		[SpecialName]
		internal void _Lambda_0024__3()
		{
			Protocol_MTK_By_Devronix.SharedUI.DataViewmtk.Rows.Add(false, "boot", "preloader", "0x0", utils.LongToHex(Mediatek.BootSize), _0024VB_0024Local_sizeboot, "", _0024VB_0024NonLocal__0024VB_0024Closure_5._0024VB_0024Local_regionBOOT);
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__55_002D5
	{
		public MtkGptPartition _0024VB_0024Local_sourceItem;

		public _Closure_0024__55_002D4 _0024VB_0024NonLocal__0024VB_0024Closure_6;

		public _Closure_0024__55_002D5(_Closure_0024__55_002D5 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024Local_sourceItem = arg0._0024VB_0024Local_sourceItem;
			}
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__55_002D6
	{
		public string _0024VB_0024Local_hh1;

		public string _0024VB_0024Local_hh2;

		public string _0024VB_0024Local_size;

		public _Closure_0024__55_002D5 _0024VB_0024NonLocal__0024VB_0024Closure_7;

		public _Closure_0024__55_002D6(_Closure_0024__55_002D6 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024Local_hh1 = arg0._0024VB_0024Local_hh1;
				_0024VB_0024Local_hh2 = arg0._0024VB_0024Local_hh2;
				_0024VB_0024Local_size = arg0._0024VB_0024Local_size;
			}
		}

		[SpecialName]
		internal void _Lambda_0024__5()
		{
			Protocol_MTK_By_Devronix.SharedUI.DataViewmtk.Rows.Add(false, "userarea", _0024VB_0024NonLocal__0024VB_0024Closure_7._0024VB_0024Local_sourceItem.Name, _0024VB_0024Local_hh1, _0024VB_0024Local_hh2, _0024VB_0024Local_size, "", _0024VB_0024NonLocal__0024VB_0024Closure_7._0024VB_0024NonLocal__0024VB_0024Closure_6._0024VB_0024NonLocal__0024VB_0024Closure_5._0024VB_0024Local_region);
		}
	}

	private static MtkDaxUploadResult uploadResult;

	public static MtkTask[] myObject;

	private static MtkPreloader preloader;

	private static MtkDeviceWaitResult mtkWaitResult;

	public static string storagetype;

	public static string CHECK;

	public static string Crashing;

	public static string READ;

	public static string pre_dump;

	public static string Mhetod;

	public static string Check_Preloader;

	public static bool SBC;

	public static Stream inputStream;

	public static bool SLA;

	public static bool SDA;

	public static bool Timeout;

	public static string Hexx;

	public static string states_lock;

	public static string Stringg;

	public static string serialNumber;

	public static string Hex_New;

	public static string forwhat;

	public static MtkGpt gpt { get; set; }

	public static byte[] bytes { get; set; }

	[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	public static extern EXECUTION_STATE SetThreadExecutionState(EXECUTION_STATE esFlags);

	public static void PreventSleep()
	{
		SetThreadExecutionState((EXECUTION_STATE)2147483651u);
	}

	public static void AllowSleep()
	{
		SetThreadExecutionState(EXECUTION_STATE.ES_CONTINUOUS);
	}

	public static void InitAsync(string Token)
	{
		Process process = new Process
		{
			StartInfo = new ProcessStartInfo
			{
				UseShellExecute = false,
				CreateNoWindow = true,
				FileName = Form1.String_9 + "bin\\Tunlocker Tool.exe",
				Arguments = ClassDevronix.string_10,
				RedirectStandardInput = true,
				RedirectStandardOutput = true
			}
		};
		process.Start();
		Console.WriteLine(ClassDevronix.string_10);
		process.StandardInput.WriteLine(ClassDevronix.string_10);
		process.StandardInput.Flush();
		process.StandardInput.Close();
		if (Operators.CompareString(Token, "Read", TextCompare: false) == 0)
		{
			process.OutputDataReceived += ReturnMe_Brom_Read;
		}
		if (Operators.CompareString(Token, "Erase", TextCompare: false) == 0)
		{
			process.OutputDataReceived += ReturnMe_Brom_Erase;
		}
		if (Operators.CompareString(Token, "Final", TextCompare: false) == 0)
		{
			process.OutputDataReceived += ReturnMe_Brom_Write;
		}
		if (Operators.CompareString(Token, "16Zero", TextCompare: false) == 0)
		{
			process.OutputDataReceived += ReturnMe_Brom_Write_16_Zero;
		}
		if (Operators.CompareString(Token, "Rest", TextCompare: false) == 0)
		{
			process.OutputDataReceived += ReturnMe_Brom_Restore;
		}
		process.BeginOutputReadLine();
		process.WaitForExit();
	}

	private static void ReturnMe_Brom_Read(object sender, DataReceivedEventArgs e)
	{
		try
		{
			string text = e.Data ?? string.Empty;
			if (text.Contains("Preloader - Status: Waiting for PreLoader VCOM, please reconnect mobile to brom mode"))
			{
				gui.Richlog("OK", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
				gui.Richlog("- Waiting For Mtk Usb Device : ", Color.Black);
				Form1.SharedUI.ProgressBar1.Text = "Search...";
				SerialCOM.MSL = "MESSAG_Test_Point";
			}
			if (text.Contains("CPU:"))
			{
				SerialCOM.MSL = "MESSAG_Test_Point=OK";
				gui.Richlog("OK", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
				gui.Richlog("- Chipset : ", Color.Black);
				Form1.SharedUI.ProgressBar1.Text = "Analyzeing...";
				using StringReader stringReader = new StringReader(text);
				while (stringReader.Peek() != -1)
				{
					string text2 = stringReader.ReadLine().Split(':')[1].Replace("  ", "").Replace("\t", "").Substring(0, 6);
					if (text2.Contains("/"))
					{
						text2.Split("/".ToCharArray());
						Mediatek.Platform = Conversions.ToString(text2[0]);
					}
					else
					{
						Mediatek.Platform = text2;
					}
				}
			}
			if (text.Contains("HW code:"))
			{
				using StringReader stringReader2 = new StringReader(text);
				while (stringReader2.Peek() != -1)
				{
					Mediatek.baseband1 = stringReader2.ReadLine().Split(':')[1].Replace("  ", "").Replace("\t", "").Substring(0, 5)
						.Replace("x", "");
				}
			}
			if (text.Contains("SBC enabled:"))
			{
				using StringReader stringReader3 = new StringReader(text);
				while (stringReader3.Peek() != -1)
				{
					SBC = bool.Parse(stringReader3.ReadLine().Split(':')[1].Replace("  ", "").Replace("\t", "").Substring(0, 4)
						.Replace(" ", ""));
				}
			}
			if (text.Contains("SLA enabled:"))
			{
				using StringReader stringReader4 = new StringReader(text);
				while (stringReader4.Peek() != -1)
				{
					SLA = bool.Parse(stringReader4.ReadLine().Split(':')[1].Replace("  ", "").Replace("\t", "").Substring(0, 4)
						.Replace(" ", ""));
				}
			}
			if (text.Contains("DAA enabled:"))
			{
				using StringReader stringReader5 = new StringReader(text);
				while (stringReader5.Peek() != -1)
				{
					SDA = bool.Parse(stringReader5.ReadLine().Split(':')[1].Replace("  ", "").Replace("\t", "").Substring(0, 4)
						.Replace(" ", ""));
				}
			}
			if (text.Contains("HW subcode:"))
			{
				using StringReader stringReader6 = new StringReader(text);
				while (stringReader6.Peek() != -1)
				{
					Mediatek.baseband2 = stringReader6.ReadLine().Split(':')[1].Replace("  ", "").Replace("\t", "").Substring(0, 6)
						.Replace("0x", "")
						.Replace(" ", "");
				}
			}
			if (text.Contains("HW Ver:"))
			{
				using StringReader stringReader7 = new StringReader(text);
				while (stringReader7.Peek() != -1)
				{
					Mediatek.baseband3 = stringReader7.ReadLine().Split(':')[1].Replace("  ", "").Replace("\t", "").Substring(0, 6)
						.Replace("0x", "")
						.Replace(" ", "");
				}
			}
			if (text.Contains("ME_ID:"))
			{
				Mediatek.basebandmtk = Mediatek.baseband1.ToUpper() + ":" + Mediatek.baseband2.ToUpper() + ":" + Mediatek.baseband3.ToUpper() + ":0002";
				gui.Richlog(Mediatek.basebandmtk.ToUpper(), Color.FromArgb(21, 87, 255));
				gui.Richlog("[" + Mediatek.Platform + "]", Color.LightGreen, isBold: false, NextLine: true);
				gui.Richlog("- Brom Security : [", Color.Black);
				if (SBC & SLA & SDA)
				{
					gui.Richlog("SBC", Color.Green);
					gui.Richlog("-SLA", Color.Green);
					gui.Richlog("-SDA", Color.Green);
					gui.Richlog("]", Color.Black, isBold: false, NextLine: true);
				}
				else if (SBC & SLA)
				{
					gui.Richlog("SBC", Color.Green);
					gui.Richlog("-SLA", Color.Green);
					gui.Richlog("]", Color.Black, isBold: false, NextLine: true);
				}
				else if (SLA & SDA)
				{
					gui.Richlog("SLA", Color.Green);
					gui.Richlog("-SDA", Color.Green);
					gui.Richlog("]", Color.Black, isBold: false, NextLine: true);
				}
				else if (SBC & SDA)
				{
					gui.Richlog("SBC", Color.Green);
					gui.Richlog("-SDA", Color.Green);
					gui.Richlog("]", Color.Black, isBold: false, NextLine: true);
				}
				else if (SBC)
				{
					gui.Richlog("SBC", Color.Green);
					gui.Richlog("]", Color.Black, isBold: false, NextLine: true);
				}
				else if (SLA)
				{
					gui.Richlog("SLA", Color.Green);
					gui.Richlog("]", Color.Black, isBold: false, NextLine: true);
				}
				else if (SDA)
				{
					gui.Richlog("SDA", Color.Green);
					gui.Richlog("]", Color.Black, isBold: false, NextLine: true);
				}
				else
				{
					gui.Richlog("Nothing", Color.FromArgb(0, 85, 207));
					gui.Richlog("]", Color.Black, isBold: false, NextLine: true);
				}
				Check_BLOADER();
				gui.Richlog("- Exploitation Brom Mode : ", Color.Black);
				Form1.SharedUI.ProgressBar1.Text = "Exploitation...";
			}
			if (text.Contains("Patching da1 ..."))
			{
				gui.Richlog("OK", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
				gui.Richlog("- Patching Security DA1/DA2 : ", Color.Black);
				Form1.SharedUI.ProgressBar1.Text = "Patching Sec...";
			}
			if (text.Contains("Patching da2 ..."))
			{
				gui.Richlog("OK", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
				gui.Richlog("- Sending EMI Data : ", Color.Black);
				Form1.SharedUI.ProgressBar1.Text = "Sending...";
			}
			if (text.Contains("DA SLA is disabled"))
			{
				gui.Richlog("OK", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
				gui.Richlog("- Initialize Device : ", Color.Black);
				Form1.SharedUI.ProgressBar1.Text = "Initialize Device...";
			}
			if (text.Contains("EMMC Boot1 Size:"))
			{
				Mediatek.Storage = "EMMC";
			}
			if (text.Contains("UFS"))
			{
				Mediatek.Storage = "UFS";
			}
			if (text.Contains("Requesting available partitions"))
			{
				gui.Richlog("OK", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
				gui.Richlog("- Memory Type : ", Color.Black);
				gui.Richlog(Mediatek.Storage, Color.LightGreen, isBold: false, NextLine: true);
				gui.Richlog("- Reading Security : ", Color.Black);
				Form1.SharedUI.ProgressBar4.Text = "0%";
				Form1.SharedUI.ProgressBar4.Value = 0;
				SerialCOM.MSL = "ENREAD";
			}
			if (text.Contains("All partitions were dumped"))
			{
				Form1.SharedUI.ProgressBar4.Value = 100;
				SerialCOM.MSL = "DISREAD";
				Form1.SharedUI.ProgressBar4.Text = "0%";
				Form1.SharedUI.ProgressBar4.Value = 0;
				gui.Richlog("OK", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
				gui.Richlog("- Calculate Security : ", Color.Black);
				Form1.SharedUI.ProgressBar1.Text = "Calculateing...";
			}
			if (text.Contains("All partitions formatted"))
			{
				gui.Richlog("OK", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
				gui.Richlog("- Reboot Device To Normal Mode : ", Color.Black);
				Form1.SharedUI.ProgressBar1.Text = "Rebooting...";
				gui.Richlog("OK", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
				gui.Richlog("- Wait For ADB Connection : ", Color.Black);
				Form1.SharedUI.ProgressBar1.Text = "Wait For Device..(" + device_info.serialno + ")";
				Form1.SharedUI.Guna2MessageDialog1.Text = "If Not Reboot Auto Please Disconnect USB Cable And Reboot Manual\r\nThen Press OK To Continue Process";
				Form1.SharedUI.Guna2MessageDialog1.Show();
			}
			try
			{
				Match match = new Regex("\\d+(\\.\\d+)?%").Match(text);
				if (!match.Success)
				{
					return;
				}
				_Closure_0024__36_002D0 arg = default(_Closure_0024__36_002D0);
				_Closure_0024__36_002D0 CS_0024_003C_003E8__locals0 = new _Closure_0024__36_002D0(arg);
				if (double.TryParse(match.Value.Replace("%", ""), out CS_0024_003C_003E8__locals0._0024VB_0024Local_percentage))
				{
					Form1.SharedUI.ProgressBar4.Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
					{
						Form1.SharedUI.ProgressBar4.Value = checked((int)Math.Round(CS_0024_003C_003E8__locals0._0024VB_0024Local_percentage));
					}));
					UiManager.String_30 = Conversions.ToString(Form1.SharedUI.ProgressBar4.Value);
					Form1.SharedUI.ProgressBar4.Text = UiManager.String_30 + "%";
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}
		catch (Exception ex3)
		{
			ProjectData.SetProjectError(ex3);
			Exception ex4 = ex3;
			ProjectData.ClearProjectError();
		}
	}

	private static void ReturnMe_Brom_Erase(object sender, DataReceivedEventArgs e)
	{
		try
		{
			string text = e.Data ?? string.Empty;
			if (text.Contains("Preloader - Status: Waiting for PreLoader VCOM, please reconnect mobile to brom mode"))
			{
				gui.Richlog("OK", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
				gui.Richlog("- Waiting For Mtk Usb Device : ", Color.Black);
				Form1.SharedUI.ProgressBar1.Text = "Search...";
				SerialCOM.MSL = "MESSAG_Test_Point";
			}
			if (text.Contains("CPU:"))
			{
				SerialCOM.MSL = "MESSAG_Test_Point=OK";
				gui.Richlog("OK", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
				gui.Richlog("- Chipset : ", Color.Black);
				using StringReader stringReader = new StringReader(text);
				while (stringReader.Peek() != -1)
				{
					string text2 = stringReader.ReadLine().Split(':')[1].Replace("  ", "").Replace("\t", "").Substring(0, 6);
					if (text2.Contains("/"))
					{
						text2.Split("/".ToCharArray());
						Mediatek.Platform = Conversions.ToString(text2[0]);
					}
					else
					{
						Mediatek.Platform = text2;
					}
				}
			}
			if (text.Contains("HW code:"))
			{
				using StringReader stringReader2 = new StringReader(text);
				while (stringReader2.Peek() != -1)
				{
					Mediatek.baseband1 = stringReader2.ReadLine().Split(':')[1].Replace("  ", "").Replace("\t", "").Substring(0, 5)
						.Replace("x", "");
				}
			}
			if (text.Contains("SBC enabled:"))
			{
				using StringReader stringReader3 = new StringReader(text);
				while (stringReader3.Peek() != -1)
				{
					SBC = bool.Parse(stringReader3.ReadLine().Split(':')[1].Replace("  ", "").Replace("\t", "").Substring(0, 4)
						.Replace(" ", ""));
				}
			}
			if (text.Contains("SLA enabled:"))
			{
				using StringReader stringReader4 = new StringReader(text);
				while (stringReader4.Peek() != -1)
				{
					SLA = bool.Parse(stringReader4.ReadLine().Split(':')[1].Replace("  ", "").Replace("\t", "").Substring(0, 4)
						.Replace(" ", ""));
				}
			}
			if (text.Contains("DAA enabled:"))
			{
				using StringReader stringReader5 = new StringReader(text);
				while (stringReader5.Peek() != -1)
				{
					SDA = bool.Parse(stringReader5.ReadLine().Split(':')[1].Replace("  ", "").Replace("\t", "").Substring(0, 4)
						.Replace(" ", ""));
				}
			}
			if (text.Contains("HW subcode:"))
			{
				using StringReader stringReader6 = new StringReader(text);
				while (stringReader6.Peek() != -1)
				{
					Mediatek.baseband2 = stringReader6.ReadLine().Split(':')[1].Replace("  ", "").Replace("\t", "").Substring(0, 6)
						.Replace("0x", "")
						.Replace(" ", "");
				}
			}
			if (text.Contains("HW Ver:"))
			{
				using StringReader stringReader7 = new StringReader(text);
				while (stringReader7.Peek() != -1)
				{
					Mediatek.baseband3 = stringReader7.ReadLine().Split(':')[1].Replace("  ", "").Replace("\t", "").Substring(0, 6)
						.Replace("0x", "")
						.Replace(" ", "");
				}
			}
			if (text.Contains("ME_ID:"))
			{
				Mediatek.basebandmtk = Mediatek.baseband1.ToUpper() + ":" + Mediatek.baseband2.ToUpper() + ":" + Mediatek.baseband3.ToUpper() + ":0002";
				gui.Richlog(Mediatek.basebandmtk.ToUpper(), Color.FromArgb(21, 87, 255));
				gui.Richlog("[" + Mediatek.Platform + "]", Color.LightGreen, isBold: false, NextLine: true);
				gui.Richlog("- Brom Security : [", Color.Black);
				if (SBC & SLA & SDA)
				{
					gui.Richlog("SBC", Color.Green);
					gui.Richlog("-SLA", Color.Green);
					gui.Richlog("-SDA", Color.Green);
					gui.Richlog("]", Color.Black, isBold: false, NextLine: true);
				}
				else if (SBC & SLA)
				{
					gui.Richlog("SBC", Color.Green);
					gui.Richlog("-SLA", Color.Green);
					gui.Richlog("]", Color.Black, isBold: false, NextLine: true);
				}
				else if (SLA & SDA)
				{
					gui.Richlog("SLA", Color.Green);
					gui.Richlog("-SDA", Color.Green);
					gui.Richlog("]", Color.Black, isBold: false, NextLine: true);
				}
				else if (SBC & SDA)
				{
					gui.Richlog("SBC", Color.Green);
					gui.Richlog("-SDA", Color.Green);
					gui.Richlog("]", Color.Black, isBold: false, NextLine: true);
				}
				else if (SBC)
				{
					gui.Richlog("SBC", Color.Green);
					gui.Richlog("]", Color.Black, isBold: false, NextLine: true);
				}
				else if (SLA)
				{
					gui.Richlog("SLA", Color.Green);
					gui.Richlog("]", Color.Black, isBold: false, NextLine: true);
				}
				else if (SDA)
				{
					gui.Richlog("SDA", Color.Green);
					gui.Richlog("]", Color.Black, isBold: false, NextLine: true);
				}
				else
				{
					gui.Richlog("Nothing", Color.FromArgb(0, 85, 207));
					gui.Richlog("]", Color.Black, isBold: false, NextLine: true);
				}
				Check_BLOADER();
				gui.Richlog("- Exploitation Brom Mode : ", Color.Black);
				Form1.SharedUI.ProgressBar1.Text = "Exploitation...";
			}
			if (text.Contains("Patching da1 ..."))
			{
				gui.Richlog("OK", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
				gui.Richlog("- Patching Security DA1/DA2 : ", Color.Black);
				Form1.SharedUI.ProgressBar1.Text = "Patching Sec...";
			}
			if (text.Contains("Patching da2 ..."))
			{
				gui.Richlog("OK", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
				gui.Richlog("- Sending EMI Data : ", Color.Black);
				Form1.SharedUI.ProgressBar1.Text = "Sending...";
			}
			if (text.Contains("DA SLA is disabled"))
			{
				gui.Richlog("OK", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
				gui.Richlog("- Initialize Device : ", Color.Black);
				Form1.SharedUI.ProgressBar1.Text = "Initialize Device...";
			}
			if (text.Contains("EMMC Boot1 Size:"))
			{
				Mediatek.Storage = "EMMC";
			}
			if (text.Contains("UFS"))
			{
				Mediatek.Storage = "UFS";
			}
			if (text.Contains("DA Extensions successfully added"))
			{
				gui.Richlog("OK", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
				gui.Richlog("- Memory Type : ", Color.Black);
				gui.Richlog(Mediatek.Storage, Color.LightGreen, isBold: false, NextLine: true);
				gui.Richlog("- Calculate Security : ", Color.Black);
				Form1.SharedUI.ProgressBar1.Text = "Calculateing...";
			}
			if (text.Contains("All partitions formatted"))
			{
				gui.Richlog("OK", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
				gui.Richlog("- Reboot Device To Normal Mode : ", Color.Black);
				Form1.SharedUI.ProgressBar1.Text = "Rebooting...";
				gui.Richlog("OK", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
				gui.Richlog("- Wait For ADB Connection : ", Color.Black);
				Form1.SharedUI.ProgressBar1.Text = "Wait For Device..(" + device_info.serialno + ")";
				Form1.SharedUI.Guna2MessageDialog1.Text = "If Not Reboot Auto Please Disconnect USB Cable And Reboot Manual\r\nThen Press OK To Continue Process";
				Form1.SharedUI.Guna2MessageDialog1.Show();
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	private static void ReturnMe_Brom_Write(object sender, DataReceivedEventArgs e)
	{
		try
		{
			string text = e.Data ?? string.Empty;
			if (text.Contains("Preloader - Status: Waiting for PreLoader VCOM, please reconnect mobile to brom mode"))
			{
				gui.Richlog("OK", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
				gui.Richlog("- Waiting For Mtk Usb Device : ", Color.Black);
				Form1.SharedUI.ProgressBar1.Text = "Search...";
				SerialCOM.MSL = "MESSAG_Test_Point";
			}
			if (text.Contains("CPU:"))
			{
				SerialCOM.MSL = "MESSAG_Test_Point=OK";
				gui.Richlog("OK", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
				gui.Richlog("- Chipset : ", Color.Black);
				using StringReader stringReader = new StringReader(text);
				while (stringReader.Peek() != -1)
				{
					string text2 = stringReader.ReadLine().Split(':')[1].Replace("  ", "").Replace("\t", "").Substring(0, 6);
					if (text2.Contains("/"))
					{
						text2.Split("/".ToCharArray());
						Mediatek.Platform = Conversions.ToString(text2[0]);
					}
					else
					{
						Mediatek.Platform = text2;
					}
				}
			}
			if (text.Contains("HW code:"))
			{
				using StringReader stringReader2 = new StringReader(text);
				while (stringReader2.Peek() != -1)
				{
					Mediatek.baseband1 = stringReader2.ReadLine().Split(':')[1].Replace("  ", "").Replace("\t", "").Substring(0, 5)
						.Replace("x", "");
				}
			}
			if (text.Contains("SBC enabled:"))
			{
				using StringReader stringReader3 = new StringReader(text);
				while (stringReader3.Peek() != -1)
				{
					SBC = bool.Parse(stringReader3.ReadLine().Split(':')[1].Replace("  ", "").Replace("\t", "").Substring(0, 4)
						.Replace(" ", ""));
				}
			}
			if (text.Contains("SLA enabled:"))
			{
				using StringReader stringReader4 = new StringReader(text);
				while (stringReader4.Peek() != -1)
				{
					SLA = bool.Parse(stringReader4.ReadLine().Split(':')[1].Replace("  ", "").Replace("\t", "").Substring(0, 4)
						.Replace(" ", ""));
				}
			}
			if (text.Contains("DAA enabled:"))
			{
				using StringReader stringReader5 = new StringReader(text);
				while (stringReader5.Peek() != -1)
				{
					SDA = bool.Parse(stringReader5.ReadLine().Split(':')[1].Replace("  ", "").Replace("\t", "").Substring(0, 4)
						.Replace(" ", ""));
				}
			}
			if (text.Contains("HW subcode:"))
			{
				using StringReader stringReader6 = new StringReader(text);
				while (stringReader6.Peek() != -1)
				{
					Mediatek.baseband2 = stringReader6.ReadLine().Split(':')[1].Replace("  ", "").Replace("\t", "").Substring(0, 6)
						.Replace("0x", "")
						.Replace(" ", "");
				}
			}
			if (text.Contains("HW Ver:"))
			{
				using StringReader stringReader7 = new StringReader(text);
				while (stringReader7.Peek() != -1)
				{
					Mediatek.baseband3 = stringReader7.ReadLine().Split(':')[1].Replace("  ", "").Replace("\t", "").Substring(0, 6)
						.Replace("0x", "")
						.Replace(" ", "");
				}
			}
			if (text.Contains("ME_ID:"))
			{
				Mediatek.basebandmtk = Mediatek.baseband1.ToUpper() + ":" + Mediatek.baseband2.ToUpper() + ":" + Mediatek.baseband3.ToUpper() + ":0002";
				gui.Richlog(Mediatek.basebandmtk.ToUpper(), Color.FromArgb(21, 87, 255));
				gui.Richlog("[" + Mediatek.Platform + "]", Color.LightGreen, isBold: false, NextLine: true);
				gui.Richlog("- Brom Security : [", Color.Black);
				if (SBC & SLA & SDA)
				{
					gui.Richlog("SBC", Color.Green);
					gui.Richlog("-SLA", Color.Green);
					gui.Richlog("-SDA", Color.Green);
					gui.Richlog("]", Color.Black, isBold: false, NextLine: true);
				}
				else if (SBC & SLA)
				{
					gui.Richlog("SBC", Color.Green);
					gui.Richlog("-SLA", Color.Green);
					gui.Richlog("]", Color.Black, isBold: false, NextLine: true);
				}
				else if (SLA & SDA)
				{
					gui.Richlog("SLA", Color.Green);
					gui.Richlog("-SDA", Color.Green);
					gui.Richlog("]", Color.Black, isBold: false, NextLine: true);
				}
				else if (SBC & SDA)
				{
					gui.Richlog("SBC", Color.Green);
					gui.Richlog("-SDA", Color.Green);
					gui.Richlog("]", Color.Black, isBold: false, NextLine: true);
				}
				else if (SBC)
				{
					gui.Richlog("SBC", Color.Green);
					gui.Richlog("]", Color.Black, isBold: false, NextLine: true);
				}
				else if (SLA)
				{
					gui.Richlog("SLA", Color.Green);
					gui.Richlog("]", Color.Black, isBold: false, NextLine: true);
				}
				else if (SDA)
				{
					gui.Richlog("SDA", Color.Green);
					gui.Richlog("]", Color.Black, isBold: false, NextLine: true);
				}
				else
				{
					gui.Richlog("Nothing", Color.FromArgb(0, 85, 207));
					gui.Richlog("]", Color.Black, isBold: false, NextLine: true);
				}
				Check_BLOADER();
				gui.Richlog("- Exploitation Brom Mode : ", Color.Black);
				Form1.SharedUI.ProgressBar1.Text = "Exploitation...";
			}
			if (text.Contains("Patching da1 ..."))
			{
				gui.Richlog("OK", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
				gui.Richlog("- Patching Security DA1/DA2 : ", Color.Black);
				Form1.SharedUI.ProgressBar1.Text = "Patching Sec...";
			}
			if (text.Contains("Patching da2 ..."))
			{
				gui.Richlog("OK", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
				gui.Richlog("- Sending EMI Data : ", Color.Black);
				Form1.SharedUI.ProgressBar1.Text = "Sending...";
			}
			if (text.Contains("DA SLA is disabled"))
			{
				gui.Richlog("OK", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
				gui.Richlog("- Initialize Device : ", Color.Black);
				Form1.SharedUI.ProgressBar1.Text = "Initialize Device...";
			}
			if (text.Contains("EMMC Boot1 Size:"))
			{
				Mediatek.Storage = "EMMC";
			}
			if (text.Contains("UFS"))
			{
				Mediatek.Storage = "UFS";
			}
			if (text.Contains("DA Extensions successfully added"))
			{
				gui.Richlog("OK", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
				gui.Richlog("- Memory Type : ", Color.Black);
				gui.Richlog(Mediatek.Storage, Color.LightGreen, isBold: false, NextLine: true);
				gui.Richlog("- Read Build Prop Info : ", Color.Black);
				gui.Richlog("OK", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
				if (Operators.CompareString(device_info.Brand, "", TextCompare: false) != 0)
				{
					gui.Richlog("- Manufacturer : ", Color.Black);
					gui.Richlog(device_info.Brand, Color.Green, isBold: false, NextLine: true);
				}
				if (Operators.CompareString(device_info.model, "", TextCompare: false) != 0)
				{
					gui.Richlog("- Phone Model : ", Color.Black);
					gui.Richlog(device_info.model, Color.Green, isBold: false, NextLine: true);
				}
				if (Operators.CompareString(device_info.Android, "", TextCompare: false) != 0)
				{
					gui.Richlog("- Android Version : ", Color.Black);
					gui.Richlog(AndroidCommands.AndroidName(device_info.Android), Color.Green, isBold: false, NextLine: true);
				}
				if (Operators.CompareString(device_info.Build_id, "", TextCompare: false) != 0)
				{
					gui.Richlog("- Build id : ", Color.Black);
					gui.Richlog(device_info.Build_id, Color.Green, isBold: false, NextLine: true);
				}
				if (Operators.CompareString(device_info.security_patch, "", TextCompare: false) != 0)
				{
					gui.Richlog("- Security Patch : ", Color.Black);
					gui.Richlog(device_info.security_patch, Color.Green, isBold: false, NextLine: true);
				}
				if (Operators.CompareString(device_info.Region, "", TextCompare: false) != 0)
				{
					gui.Richlog("- Region : ", Color.Black);
					gui.Richlog(device_info.Region.ToUpper(), Color.Green, isBold: false, NextLine: true);
				}
				if (Operators.CompareString(device_info.cpu_abi, "", TextCompare: false) != 0)
				{
					gui.Richlog("- Cpu Abi Type : ", Color.Black);
					gui.Richlog(device_info.cpu_abi.ToUpper(), Color.Green, isBold: false, NextLine: true);
				}
				if (Operators.CompareString(device_info.Software_Version, "", TextCompare: false) != 0)
				{
					gui.Richlog("- Software Version : ", Color.Black);
					gui.Richlog(device_info.Software_Version, Color.Green, isBold: false, NextLine: true);
				}
				gui.Richlog("- Generation Unlock : ", Color.Black);
				Form1.SharedUI.ProgressBar1.Text = "Generation..";
			}
			if (text.Contains("SEC1 to sector"))
			{
				gui.Richlog("OK", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
				gui.Richlog("- Writing Security : ", Color.Black);
				Form1.SharedUI.ProgressBar4.Text = "0%";
				Form1.SharedUI.ProgressBar4.Value = 0;
				SerialCOM.MSL = "ENREAD";
			}
			if (text.Contains("Data to sector"))
			{
				try
				{
					File.Delete(Form1.String_81 + "Data");
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ProjectData.ClearProjectError();
				}
				Form1.SharedUI.ProgressBar4.Value = 100;
				SerialCOM.MSL = "DISREAD";
				Form1.SharedUI.ProgressBar4.Text = "0%";
				Form1.SharedUI.ProgressBar4.Value = 0;
				gui.Richlog("OK", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
				gui.Richlog("- Unlocking Network : ", Color.Black);
				Form1.SharedUI.ProgressBar1.Text = "Unlocking..";
				gui.Richlog("OK", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
				gui.Richlog("- Verfing SimLock : ", Color.Black);
				Form1.SharedUI.ProgressBar1.Text = "Verfing...";
				gui.Richlog("Unlocked", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
				gui.Richlog("- Reboot Device : ", Color.Black);
				Form1.SharedUI.ProgressBar1.Text = "Rebooting...";
				gui.Richlog("OK", Color.FromArgb(0, 85, 207));
			}
			try
			{
				Match match = new Regex("\\d+(\\.\\d+)?%").Match(text);
				if (!match.Success)
				{
					return;
				}
				_Closure_0024__38_002D0 arg = default(_Closure_0024__38_002D0);
				_Closure_0024__38_002D0 CS_0024_003C_003E8__locals0 = new _Closure_0024__38_002D0(arg);
				if (double.TryParse(match.Value.Replace("%", ""), out CS_0024_003C_003E8__locals0._0024VB_0024Local_percentage))
				{
					Form1.SharedUI.ProgressBar4.Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
					{
						Form1.SharedUI.ProgressBar4.Value = checked((int)Math.Round(CS_0024_003C_003E8__locals0._0024VB_0024Local_percentage));
					}));
					UiManager.String_30 = Conversions.ToString(Form1.SharedUI.ProgressBar4.Value);
					Form1.SharedUI.ProgressBar4.Text = UiManager.String_30 + "%";
				}
			}
			catch (Exception ex3)
			{
				ProjectData.SetProjectError(ex3);
				Exception ex4 = ex3;
				ProjectData.ClearProjectError();
			}
		}
		catch (Exception ex5)
		{
			ProjectData.SetProjectError(ex5);
			Exception ex6 = ex5;
			ProjectData.ClearProjectError();
		}
	}

	private static void ReturnMe_Brom_Write_16_Zero(object sender, DataReceivedEventArgs e)
	{
		try
		{
			string text = e.Data ?? string.Empty;
			if (text.Contains("Preloader - Status: Waiting for PreLoader VCOM, please reconnect mobile to brom mode"))
			{
				gui.Richlog("OK", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
				gui.Richlog("- Waiting For Mtk Usb Device : ", Color.Black);
				Form1.SharedUI.ProgressBar1.Text = "Search...";
				SerialCOM.MSL = "MESSAG_Test_Point";
			}
			if (text.Contains("CPU:"))
			{
				SerialCOM.MSL = "MESSAG_Test_Point=OK";
				gui.Richlog("OK", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
				gui.Richlog("- Chipset : ", Color.Black);
				using StringReader stringReader = new StringReader(text);
				while (stringReader.Peek() != -1)
				{
					string text2 = stringReader.ReadLine().Split(':')[1].Replace("  ", "").Replace("\t", "").Substring(0, 6);
					if (text2.Contains("/"))
					{
						text2.Split("/".ToCharArray());
						Mediatek.Platform = Conversions.ToString(text2[0]);
					}
					else
					{
						Mediatek.Platform = text2;
					}
				}
			}
			if (text.Contains("HW code:"))
			{
				using StringReader stringReader2 = new StringReader(text);
				while (stringReader2.Peek() != -1)
				{
					Mediatek.baseband1 = stringReader2.ReadLine().Split(':')[1].Replace("  ", "").Replace("\t", "").Substring(0, 5)
						.Replace("x", "");
				}
			}
			if (text.Contains("SBC enabled:"))
			{
				using StringReader stringReader3 = new StringReader(text);
				while (stringReader3.Peek() != -1)
				{
					SBC = bool.Parse(stringReader3.ReadLine().Split(':')[1].Replace("  ", "").Replace("\t", "").Substring(0, 4)
						.Replace(" ", ""));
				}
			}
			if (text.Contains("SLA enabled:"))
			{
				using StringReader stringReader4 = new StringReader(text);
				while (stringReader4.Peek() != -1)
				{
					SLA = bool.Parse(stringReader4.ReadLine().Split(':')[1].Replace("  ", "").Replace("\t", "").Substring(0, 4)
						.Replace(" ", ""));
				}
			}
			if (text.Contains("DAA enabled:"))
			{
				using StringReader stringReader5 = new StringReader(text);
				while (stringReader5.Peek() != -1)
				{
					SDA = bool.Parse(stringReader5.ReadLine().Split(':')[1].Replace("  ", "").Replace("\t", "").Substring(0, 4)
						.Replace(" ", ""));
				}
			}
			if (text.Contains("HW subcode:"))
			{
				using StringReader stringReader6 = new StringReader(text);
				while (stringReader6.Peek() != -1)
				{
					Mediatek.baseband2 = stringReader6.ReadLine().Split(':')[1].Replace("  ", "").Replace("\t", "").Substring(0, 6)
						.Replace("0x", "")
						.Replace(" ", "");
				}
			}
			if (text.Contains("HW Ver:"))
			{
				using StringReader stringReader7 = new StringReader(text);
				while (stringReader7.Peek() != -1)
				{
					Mediatek.baseband3 = stringReader7.ReadLine().Split(':')[1].Replace("  ", "").Replace("\t", "").Substring(0, 6)
						.Replace("0x", "")
						.Replace(" ", "");
				}
			}
			if (text.Contains("ME_ID:"))
			{
				Mediatek.basebandmtk = Mediatek.baseband1.ToUpper() + ":" + Mediatek.baseband2.ToUpper() + ":" + Mediatek.baseband3.ToUpper() + ":0002";
				gui.Richlog(Mediatek.basebandmtk.ToUpper(), Color.FromArgb(21, 87, 255));
				gui.Richlog("[" + Mediatek.Platform + "]", Color.LightGreen, isBold: false, NextLine: true);
				gui.Richlog("- Brom Security : [", Color.Black);
				if (SBC & SLA & SDA)
				{
					gui.Richlog("SBC", Color.Green);
					gui.Richlog("-SLA", Color.Green);
					gui.Richlog("-SDA", Color.Green);
					gui.Richlog("]", Color.Black, isBold: false, NextLine: true);
				}
				else if (SBC & SLA)
				{
					gui.Richlog("SBC", Color.Green);
					gui.Richlog("-SLA", Color.Green);
					gui.Richlog("]", Color.Black, isBold: false, NextLine: true);
				}
				else if (SLA & SDA)
				{
					gui.Richlog("SLA", Color.Green);
					gui.Richlog("-SDA", Color.Green);
					gui.Richlog("]", Color.Black, isBold: false, NextLine: true);
				}
				else if (SBC & SDA)
				{
					gui.Richlog("SBC", Color.Green);
					gui.Richlog("-SDA", Color.Green);
					gui.Richlog("]", Color.Black, isBold: false, NextLine: true);
				}
				else if (SBC)
				{
					gui.Richlog("SBC", Color.Green);
					gui.Richlog("]", Color.Black, isBold: false, NextLine: true);
				}
				else if (SLA)
				{
					gui.Richlog("SLA", Color.Green);
					gui.Richlog("]", Color.Black, isBold: false, NextLine: true);
				}
				else if (SDA)
				{
					gui.Richlog("SDA", Color.Green);
					gui.Richlog("]", Color.Black, isBold: false, NextLine: true);
				}
				else
				{
					gui.Richlog("Nothing", Color.FromArgb(0, 85, 207));
					gui.Richlog("]", Color.Black, isBold: false, NextLine: true);
				}
				Check_BLOADER();
				gui.Richlog("- Exploitation Brom Mode : ", Color.Black);
				Form1.SharedUI.ProgressBar1.Text = "Exploitation...";
			}
			if (text.Contains("Patching da1 ..."))
			{
				gui.Richlog("OK", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
				gui.Richlog("- Patching Security DA1/DA2 : ", Color.Black);
				Form1.SharedUI.ProgressBar1.Text = "Patching Sec...";
			}
			if (text.Contains("Patching da2 ..."))
			{
				gui.Richlog("OK", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
				gui.Richlog("- Sending EMI Data : ", Color.Black);
				Form1.SharedUI.ProgressBar1.Text = "Sending...";
			}
			if (text.Contains("DA SLA is disabled"))
			{
				gui.Richlog("OK", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
				gui.Richlog("- Initialize Device : ", Color.Black);
				Form1.SharedUI.ProgressBar1.Text = "Initialize Device...";
			}
			if (text.Contains("EMMC Boot1 Size:"))
			{
				Mediatek.Storage = "EMMC";
			}
			if (text.Contains("UFS"))
			{
				Mediatek.Storage = "UFS";
			}
			if (text.Contains("Requesting available partitions"))
			{
				gui.Richlog("OK", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
				gui.Richlog("- Memory Type : ", Color.Black);
				gui.Richlog(Mediatek.Storage, Color.LightGreen, isBold: false, NextLine: true);
				gui.Richlog("- Read Build Prop Info : ", Color.Black);
				gui.Richlog("OK", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
				if (Operators.CompareString(device_info.Brand, "", TextCompare: false) != 0)
				{
					gui.Richlog("- Manufacturer : ", Color.Black);
					gui.Richlog(device_info.Brand, Color.Green, isBold: false, NextLine: true);
				}
				if (Operators.CompareString(device_info.model, "", TextCompare: false) != 0)
				{
					gui.Richlog("- Phone Model : ", Color.Black);
					gui.Richlog(device_info.model, Color.Green, isBold: false, NextLine: true);
				}
				if (Operators.CompareString(device_info.Android, "", TextCompare: false) != 0)
				{
					gui.Richlog("- Android Version : ", Color.Black);
					gui.Richlog(AndroidCommands.AndroidName(device_info.Android), Color.Green, isBold: false, NextLine: true);
				}
				if (Operators.CompareString(device_info.Build_id, "", TextCompare: false) != 0)
				{
					gui.Richlog("- Build id : ", Color.Black);
					gui.Richlog(device_info.Build_id, Color.Green, isBold: false, NextLine: true);
				}
				if (Operators.CompareString(device_info.security_patch, "", TextCompare: false) != 0)
				{
					gui.Richlog("- Security Patch : ", Color.Black);
					gui.Richlog(device_info.security_patch, Color.Green, isBold: false, NextLine: true);
				}
				if (Operators.CompareString(device_info.Region, "", TextCompare: false) != 0)
				{
					gui.Richlog("- Region : ", Color.Black);
					gui.Richlog(device_info.Region.ToUpper(), Color.Green, isBold: false, NextLine: true);
				}
				if (Operators.CompareString(device_info.cpu_abi, "", TextCompare: false) != 0)
				{
					gui.Richlog("- Cpu Abi Type : ", Color.Black);
					gui.Richlog(device_info.cpu_abi.ToUpper(), Color.Green, isBold: false, NextLine: true);
				}
				if (Operators.CompareString(device_info.Software_Version, "", TextCompare: false) != 0)
				{
					gui.Richlog("- Software Version : ", Color.Black);
					gui.Richlog(device_info.Software_Version, Color.Green, isBold: false, NextLine: true);
				}
				gui.Richlog("- Reading Security : ", Color.Black);
				Form1.SharedUI.ProgressBar4.Text = "0%";
				Form1.SharedUI.ProgressBar4.Value = 0;
				SerialCOM.MSL = "ENREAD";
			}
			if (text.Contains("All partitions were dumped"))
			{
				Form1.SharedUI.ProgressBar4.Value = 100;
				SerialCOM.MSL = "DISREAD";
				Form1.SharedUI.ProgressBar4.Text = "0%";
				Form1.SharedUI.ProgressBar4.Value = 0;
				gui.Richlog("OK", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
				gui.Richlog("- Generation Unlock : ", Color.Black);
				Form1.SharedUI.ProgressBar1.Text = "Generation...";
			}
			if (text.Contains("SEC1 to sector"))
			{
				try
				{
					File.Delete(Form1.String_81 + "SEC1");
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ProjectData.ClearProjectError();
				}
				Form1.SharedUI.ProgressBar4.Value = 100;
				SerialCOM.MSL = "DISREAD";
				Form1.SharedUI.ProgressBar4.Text = "0%";
				Form1.SharedUI.ProgressBar4.Value = 0;
				gui.Richlog("OK", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
				gui.Richlog("- Unlocking Network : ", Color.Black);
				Form1.SharedUI.ProgressBar1.Text = "Unlocking..";
				gui.Richlog("OK", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
				gui.Richlog("- Verfing SimLock : ", Color.Black);
				Form1.SharedUI.ProgressBar1.Text = "Verfing...";
				gui.Richlog("Unlocked", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
				gui.Richlog("- Reboot Device : ", Color.Black);
				Form1.SharedUI.ProgressBar1.Text = "Rebooting...";
				gui.Richlog("OK", Color.FromArgb(0, 85, 207));
			}
			try
			{
				Match match = new Regex("\\d+(\\.\\d+)?%").Match(text);
				if (!match.Success)
				{
					return;
				}
				_Closure_0024__39_002D0 arg = default(_Closure_0024__39_002D0);
				_Closure_0024__39_002D0 CS_0024_003C_003E8__locals0 = new _Closure_0024__39_002D0(arg);
				if (double.TryParse(match.Value.Replace("%", ""), out CS_0024_003C_003E8__locals0._0024VB_0024Local_percentage))
				{
					Form1.SharedUI.ProgressBar4.Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
					{
						Form1.SharedUI.ProgressBar4.Value = checked((int)Math.Round(CS_0024_003C_003E8__locals0._0024VB_0024Local_percentage));
					}));
					UiManager.String_30 = Conversions.ToString(Form1.SharedUI.ProgressBar4.Value);
					Form1.SharedUI.ProgressBar4.Text = UiManager.String_30 + "%";
				}
			}
			catch (Exception ex3)
			{
				ProjectData.SetProjectError(ex3);
				Exception ex4 = ex3;
				ProjectData.ClearProjectError();
			}
		}
		catch (Exception ex5)
		{
			ProjectData.SetProjectError(ex5);
			Exception ex6 = ex5;
			ProjectData.ClearProjectError();
		}
	}

	private static void ReturnMe_Brom_Restore(object sender, DataReceivedEventArgs e)
	{
		try
		{
			string text = e.Data ?? string.Empty;
			if (text.Contains("Preloader - Status: Waiting for PreLoader VCOM, please reconnect mobile to brom mode"))
			{
				gui.Richlog("OK", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
				gui.Richlog("- Waiting For Mtk Usb Device : ", Color.Black);
				Form1.SharedUI.ProgressBar1.Text = "Search...";
				SerialCOM.MSL = "MESSAG_Test_Point";
			}
			if (text.Contains("CPU:"))
			{
				SerialCOM.MSL = "MESSAG_Test_Point=OK";
				gui.Richlog("OK", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
				gui.Richlog("- Chipset : ", Color.Black);
				using StringReader stringReader = new StringReader(text);
				while (stringReader.Peek() != -1)
				{
					string text2 = stringReader.ReadLine().Split(':')[1].Replace("  ", "").Replace("\t", "").Substring(0, 6);
					if (text2.Contains("/"))
					{
						text2.Split("/".ToCharArray());
						Mediatek.Platform = Conversions.ToString(text2[0]);
					}
					else
					{
						Mediatek.Platform = text2;
					}
				}
			}
			if (text.Contains("HW code:"))
			{
				using StringReader stringReader2 = new StringReader(text);
				while (stringReader2.Peek() != -1)
				{
					Mediatek.baseband1 = stringReader2.ReadLine().Split(':')[1].Replace("  ", "").Replace("\t", "").Substring(0, 5)
						.Replace("x", "");
				}
			}
			if (text.Contains("SBC enabled:"))
			{
				using StringReader stringReader3 = new StringReader(text);
				while (stringReader3.Peek() != -1)
				{
					SBC = bool.Parse(stringReader3.ReadLine().Split(':')[1].Replace("  ", "").Replace("\t", "").Substring(0, 4)
						.Replace(" ", ""));
				}
			}
			if (text.Contains("SLA enabled:"))
			{
				using StringReader stringReader4 = new StringReader(text);
				while (stringReader4.Peek() != -1)
				{
					SLA = bool.Parse(stringReader4.ReadLine().Split(':')[1].Replace("  ", "").Replace("\t", "").Substring(0, 4)
						.Replace(" ", ""));
				}
			}
			if (text.Contains("DAA enabled:"))
			{
				using StringReader stringReader5 = new StringReader(text);
				while (stringReader5.Peek() != -1)
				{
					SDA = bool.Parse(stringReader5.ReadLine().Split(':')[1].Replace("  ", "").Replace("\t", "").Substring(0, 4)
						.Replace(" ", ""));
				}
			}
			if (text.Contains("HW subcode:"))
			{
				using StringReader stringReader6 = new StringReader(text);
				while (stringReader6.Peek() != -1)
				{
					Mediatek.baseband2 = stringReader6.ReadLine().Split(':')[1].Replace("  ", "").Replace("\t", "").Substring(0, 6)
						.Replace("0x", "")
						.Replace(" ", "");
				}
			}
			if (text.Contains("HW Ver:"))
			{
				using StringReader stringReader7 = new StringReader(text);
				while (stringReader7.Peek() != -1)
				{
					Mediatek.baseband3 = stringReader7.ReadLine().Split(':')[1].Replace("  ", "").Replace("\t", "").Substring(0, 6)
						.Replace("0x", "")
						.Replace(" ", "");
				}
			}
			if (text.Contains("ME_ID:"))
			{
				Mediatek.basebandmtk = Mediatek.baseband1.ToUpper() + ":" + Mediatek.baseband2.ToUpper() + ":" + Mediatek.baseband3.ToUpper() + ":0002";
				gui.Richlog(Mediatek.basebandmtk.ToUpper(), Color.FromArgb(21, 87, 255));
				gui.Richlog("[" + Mediatek.Platform + "]", Color.LightGreen, isBold: false, NextLine: true);
				gui.Richlog("- Brom Security : [", Color.Black);
				if (SBC & SLA & SDA)
				{
					gui.Richlog("SBC", Color.Green);
					gui.Richlog("-SLA", Color.Green);
					gui.Richlog("-SDA", Color.Green);
					gui.Richlog("]", Color.Black, isBold: false, NextLine: true);
				}
				else if (SBC & SLA)
				{
					gui.Richlog("SBC", Color.Green);
					gui.Richlog("-SLA", Color.Green);
					gui.Richlog("]", Color.Black, isBold: false, NextLine: true);
				}
				else if (SLA & SDA)
				{
					gui.Richlog("SLA", Color.Green);
					gui.Richlog("-SDA", Color.Green);
					gui.Richlog("]", Color.Black, isBold: false, NextLine: true);
				}
				else if (SBC & SDA)
				{
					gui.Richlog("SBC", Color.Green);
					gui.Richlog("-SDA", Color.Green);
					gui.Richlog("]", Color.Black, isBold: false, NextLine: true);
				}
				else if (SBC)
				{
					gui.Richlog("SBC", Color.Green);
					gui.Richlog("]", Color.Black, isBold: false, NextLine: true);
				}
				else if (SLA)
				{
					gui.Richlog("SLA", Color.Green);
					gui.Richlog("]", Color.Black, isBold: false, NextLine: true);
				}
				else if (SDA)
				{
					gui.Richlog("SDA", Color.Green);
					gui.Richlog("]", Color.Black, isBold: false, NextLine: true);
				}
				else
				{
					gui.Richlog("Nothing", Color.FromArgb(0, 85, 207));
					gui.Richlog("]", Color.Black, isBold: false, NextLine: true);
				}
				Check_BLOADER();
				gui.Richlog("- Exploitation Brom Mode : ", Color.Black);
				Form1.SharedUI.ProgressBar1.Text = "Exploitation...";
			}
			if (text.Contains("Patching da1 ..."))
			{
				gui.Richlog("OK", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
				gui.Richlog("- Patching Security DA1/DA2 : ", Color.Black);
				Form1.SharedUI.ProgressBar1.Text = "Patching Sec...";
			}
			if (text.Contains("Patching da2 ..."))
			{
				gui.Richlog("OK", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
				gui.Richlog("- Sending EMI Data : ", Color.Black);
				Form1.SharedUI.ProgressBar1.Text = "Sending...";
			}
			if (text.Contains("DA SLA is disabled"))
			{
				gui.Richlog("OK", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
				gui.Richlog("- Initialize Device : ", Color.Black);
				Form1.SharedUI.ProgressBar1.Text = "Initialize Device...";
			}
			if (text.Contains("EMMC Boot1 Size:"))
			{
				Mediatek.Storage = "EMMC";
			}
			if (text.Contains("UFS"))
			{
				Mediatek.Storage = "UFS";
			}
			if (text.Contains("DA Extensions successfully added"))
			{
				gui.Richlog("OK", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
				gui.Richlog("- Memory Type : ", Color.Black);
				gui.Richlog(Mediatek.Storage, Color.LightGreen, isBold: false, NextLine: true);
				gui.Richlog("- Read Build Prop Info : ", Color.Black);
				gui.Richlog("OK", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
				if (Operators.CompareString(device_info.Brand, "", TextCompare: false) != 0)
				{
					gui.Richlog("- Manufacturer : ", Color.Black);
					gui.Richlog(device_info.Brand, Color.Green, isBold: false, NextLine: true);
				}
				if (Operators.CompareString(device_info.model, "", TextCompare: false) != 0)
				{
					gui.Richlog("- Phone Model : ", Color.Black);
					gui.Richlog(device_info.model, Color.Green, isBold: false, NextLine: true);
				}
				if (Operators.CompareString(device_info.Android, "", TextCompare: false) != 0)
				{
					gui.Richlog("- Android Version : ", Color.Black);
					gui.Richlog(AndroidCommands.AndroidName(device_info.Android), Color.Green, isBold: false, NextLine: true);
				}
				if (Operators.CompareString(device_info.Build_id, "", TextCompare: false) != 0)
				{
					gui.Richlog("- Build id : ", Color.Black);
					gui.Richlog(device_info.Build_id, Color.Green, isBold: false, NextLine: true);
				}
				if (Operators.CompareString(device_info.security_patch, "", TextCompare: false) != 0)
				{
					gui.Richlog("- Security Patch : ", Color.Black);
					gui.Richlog(device_info.security_patch, Color.Green, isBold: false, NextLine: true);
				}
				if (Operators.CompareString(device_info.Region, "", TextCompare: false) != 0)
				{
					gui.Richlog("- Region : ", Color.Black);
					gui.Richlog(device_info.Region.ToUpper(), Color.Green, isBold: false, NextLine: true);
				}
				if (Operators.CompareString(device_info.cpu_abi, "", TextCompare: false) != 0)
				{
					gui.Richlog("- Cpu Abi Type : ", Color.Black);
					gui.Richlog(device_info.cpu_abi.ToUpper(), Color.Green, isBold: false, NextLine: true);
				}
				if (Operators.CompareString(device_info.Software_Version, "", TextCompare: false) != 0)
				{
					gui.Richlog("- Software Version : ", Color.Black);
					gui.Richlog(device_info.Software_Version, Color.Green, isBold: false, NextLine: true);
				}
				gui.Richlog("- Writing Security : ", Color.Black);
				Form1.SharedUI.ProgressBar4.Text = "0%";
				Form1.SharedUI.ProgressBar4.Value = 0;
				SerialCOM.MSL = "ENREAD";
			}
			if (text.Contains(forwhat))
			{
				Form1.SharedUI.ProgressBar4.Value = 100;
				SerialCOM.MSL = "DISREAD";
				Form1.SharedUI.ProgressBar4.Text = "0%";
				Form1.SharedUI.ProgressBar4.Value = 0;
				gui.Richlog("OK", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
				gui.Richlog("- Reboot Device : ", Color.Black);
				Form1.SharedUI.ProgressBar1.Text = "Rebooting...";
				gui.Richlog("OK", Color.FromArgb(0, 85, 207));
			}
			try
			{
				Match match = new Regex("\\d+(\\.\\d+)?%").Match(text);
				if (!match.Success)
				{
					return;
				}
				_Closure_0024__40_002D0 arg = default(_Closure_0024__40_002D0);
				_Closure_0024__40_002D0 CS_0024_003C_003E8__locals0 = new _Closure_0024__40_002D0(arg);
				if (double.TryParse(match.Value.Replace("%", ""), out CS_0024_003C_003E8__locals0._0024VB_0024Local_percentage))
				{
					Form1.SharedUI.ProgressBar4.Invoke((VB_0024AnonymousDelegate_0)([SpecialName] () =>
					{
						Form1.SharedUI.ProgressBar4.Value = checked((int)Math.Round(CS_0024_003C_003E8__locals0._0024VB_0024Local_percentage));
					}));
					UiManager.String_30 = Conversions.ToString(Form1.SharedUI.ProgressBar4.Value);
					Form1.SharedUI.ProgressBar4.Text = UiManager.String_30 + "%";
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}
		catch (Exception ex3)
		{
			ProjectData.SetProjectError(ex3);
			Exception ex4 = ex3;
			ProjectData.ClearProjectError();
		}
	}

	public static object Check_BLOADER()
	{
		gui.Richlog("- EMI Info : ", Color.Black);
		if (Operators.CompareString(Mediatek.Platform, "MT6516", TextCompare: false) == 0)
		{
			gui.Richlog("MTK_BLOADER_INFO_V00", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
		}
		if (Operators.CompareString(Mediatek.Platform, "MT6573", TextCompare: false) == 0)
		{
			gui.Richlog("MTK_BLOADER_INFO_V04", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
		}
		if ((Operators.CompareString(Mediatek.Platform, "MT6575", TextCompare: false) == 0) | (Operators.CompareString(Mediatek.Platform, "MT6577", TextCompare: false) == 0))
		{
			gui.Richlog("MTK_BLOADER_INFO_V07", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
		}
		if ((Operators.CompareString(Mediatek.Platform, "MT6589", TextCompare: false) == 0) | (Operators.CompareString(Mediatek.Platform, "MT8135", TextCompare: false) == 0))
		{
			gui.Richlog("MTK_BLOADER_INFO_V08", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
		}
		if (Operators.CompareString(Mediatek.Platform, "MT6572", TextCompare: false) == 0)
		{
			gui.Richlog("MTK_BLOADER_INFO_V10", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
		}
		if (Operators.CompareString(Mediatek.Platform, "MT6582", TextCompare: false) == 0)
		{
			gui.Richlog("MTK_BLOADER_INFO_V11", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
		}
		if ((Operators.CompareString(Mediatek.Platform, "MT6592", TextCompare: false) == 0) | (Operators.CompareString(Mediatek.Platform, "MT8127", TextCompare: false) == 0))
		{
			gui.Richlog("MTK_BLOADER_INFO_V12", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
		}
		if (Operators.CompareString(Mediatek.Platform, "MT8127", TextCompare: false) == 0)
		{
			gui.Richlog("MTK_BLOADER_INFO_V13", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
		}
		if (Operators.CompareString(Mediatek.Platform, "MT6580", TextCompare: false) == 0)
		{
			gui.Richlog("MTK_BLOADER_INFO_V20", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
		}
		if (Operators.CompareString(Mediatek.Platform, "MT6755", TextCompare: false) == 0)
		{
			gui.Richlog("MTK_BLOADER_INFO_V21", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
		}
		if (Operators.CompareString(Mediatek.Platform, "MT6757", TextCompare: false) == 0)
		{
			gui.Richlog("MTK_BLOADER_INFO_V22", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
		}
		if (Operators.CompareString(Mediatek.Platform, "MT6570", TextCompare: false) == 0)
		{
			gui.Richlog("MTK_BLOADER_INFO_V25", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
		}
		if (Operators.CompareString(Mediatek.Platform, "MT8167", TextCompare: false) == 0)
		{
			gui.Richlog("MTK_BLOADER_INFO_V27", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
		}
		if (Operators.CompareString(Mediatek.Platform, "MT6763", TextCompare: false) == 0)
		{
			gui.Richlog("MTK_BLOADER_INFO_V28", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
		}
		if (Operators.CompareString(Mediatek.Platform, "MT6758", TextCompare: false) == 0)
		{
			gui.Richlog("MTK_BLOADER_INFO_V30", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
		}
		if (Operators.CompareString(Mediatek.Platform, "MT6739", TextCompare: false) == 0)
		{
			gui.Richlog("MTK_BLOADER_INFO_V31", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
		}
		if (Operators.CompareString(Mediatek.Platform, "MT6765", TextCompare: false) == 0)
		{
			gui.Richlog("MTK_BLOADER_INFO_V32", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
		}
		if (Operators.CompareString(Mediatek.Platform, "MT6771", TextCompare: false) == 0)
		{
			gui.Richlog("MTK_BLOADER_INFO_V35", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
		}
		if (Operators.CompareString(Mediatek.Platform, "MT6761", TextCompare: false) == 0)
		{
			gui.Richlog("MTK_BLOADER_INFO_V36", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
		}
		if (Operators.CompareString(Mediatek.Platform, "MT6779", TextCompare: false) == 0)
		{
			gui.Richlog("MTK_BLOADER_INFO_V38", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
		}
		if (Operators.CompareString(Mediatek.Platform, "MT6768", TextCompare: false) == 0)
		{
			gui.Richlog("MTK_BLOADER_INFO_V40", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
		}
		if ((Operators.CompareString(Mediatek.Platform, "MT6883", TextCompare: false) == 0) | (Operators.CompareString(Mediatek.Platform, "MT6885", TextCompare: false) == 0) | (Operators.CompareString(Mediatek.Platform, "MT6889", TextCompare: false) == 0) | (Operators.CompareString(Mediatek.Platform, "MT6785", TextCompare: false) == 0))
		{
			gui.Richlog("MTK_BLOADER_INFO_V45", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
		}
		if ((Operators.CompareString(Mediatek.Platform, "MT6873", TextCompare: false) == 0) | (Operators.CompareString(Mediatek.Platform, "MT6875", TextCompare: false) == 0))
		{
			gui.Richlog("MTK_BLOADER_INFO_V46", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
		}
		if (Operators.CompareString(Mediatek.Platform, "MT6853", TextCompare: false) == 0)
		{
			gui.Richlog("MTK_BLOADER_INFO_V47", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
		}
		if (Operators.CompareString(Mediatek.Platform, "MT6893", TextCompare: false) == 0)
		{
			gui.Richlog("MTK_BLOADER_INFO_V49", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
		}
		if (Operators.CompareString(Mediatek.Platform, "MT6833", TextCompare: false) == 0)
		{
			gui.Richlog("MTK_BLOADER_INFO_V51", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
		}
		if (Operators.CompareString(Mediatek.Platform, "MT6877", TextCompare: false) == 0)
		{
			gui.Richlog("MTK_BLOADER_INFO_V52", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
		}
		object result = default(object);
		return result;
	}

	public static async Task InitAsync(CancellationToken cancelToken)
	{
		cancelToken.ThrowIfCancellationRequested();
		Crashing = "";
		Check_Preloader = "";
		CHECK = "";
		gui.Richlog("OK", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
		gui.Richlog("> Power Off Then Connect Usb", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
		gui.Richlog("> Some Device Need To Press Volume (-) And (+)", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
		gui.Richlog("- Waiting For Mtk Usb Device : ", Color.Black);
		Form1.SharedUI.ProgressBar1.Text = "Search...";
		MtkDaxUploadBootService.rebootto = false;
		MtkDeviceWaiterService.reconnect = false;
		mtkWaitResult = await MtkDeviceWaiterService.WaitSerialAsync(doHandshake: true, cancelToken);
    
        if (Operators.CompareString(CHECK, "no", TextCompare: false) == 0)
		{
			return;
		}
		if (Operators.CompareString(CHECK, "not", TextCompare: false) == 0)
		{
			CHECK = "no";
			gui.Richlog("- This Security Not Supported", Color.Red);
			return;
		}
		try
		{
			if (mtkWaitResult.IsBootloader)
			{
				gui.Richlog("- Crashing To Brom Mode : ", Color.Black);
				Form1.SharedUI.ProgressBar1.Text = "Crashing...";
				await MtkBootloaderCrashService.CrashAsync(mtkWaitResult.Device, cancelToken);
				gui.Richlog("OK", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
				mtkWaitResult.Device.Dispose();
				mtkWaitResult = null;
				gui.Richlog("- Waiting for Usb Brom : ", Color.Black);
				Form1.SharedUI.ProgressBar1.Text = "Search...";
				Crashing = "OK";
				mtkWaitResult = await MtkDeviceWaiterService.WaitSerialAsync(doHandshake: true, cancelToken);
				if (mtkWaitResult.IsBootloader)
				{
					CHECK = "no";
					gui.Richlog("Failed", Color.Red, isBold: false, NextLine: true);
					gui.Richlog("- This Security Not Supported", Color.Red);
					return;
				}
				gui.Richlog("OK", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
			}
			gui.Richlog("- Brom Security : [", Color.Black);
			if (SBC & SLA & SDA)
			{
				gui.Richlog("SBC", Color.Green);
				gui.Richlog("-SLA", Color.Green);
				gui.Richlog("-SDA", Color.Green);
				gui.Richlog("]", Color.Black, isBold: false, NextLine: true);
			}
			else if (SBC & SLA)
			{
				gui.Richlog("SBC", Color.Green);
				gui.Richlog("-SLA", Color.Green);
				gui.Richlog("]", Color.Black, isBold: false, NextLine: true);
			}
			else if (SLA & SDA)
			{
				gui.Richlog("SLA", Color.Green);
				gui.Richlog("-SDA", Color.Green);
				gui.Richlog("]", Color.Black, isBold: false, NextLine: true);
			}
			else if (SBC & SDA)
			{
				gui.Richlog("SBC", Color.Green);
				gui.Richlog("-SDA", Color.Green);
				gui.Richlog("]", Color.Black, isBold: false, NextLine: true);
			}
			else if (SBC)
			{
				gui.Richlog("SBC", Color.Green);
				gui.Richlog("]", Color.Black, isBold: false, NextLine: true);
			}
			else if (SLA)
			{
				gui.Richlog("SLA", Color.Green);
				gui.Richlog("]", Color.Black, isBold: false, NextLine: true);
			}
			else if (SDA)
			{
				gui.Richlog("SDA", Color.Green);
				gui.Richlog("]", Color.Black, isBold: false, NextLine: true);
			}
			else
			{
				gui.Richlog("Nothing", Color.FromArgb(0, 85, 207));
				gui.Richlog("]", Color.Black, isBold: false, NextLine: true);
			}
			Check_BLOADER();
			await MtkWatchdogService.DisableAsync(mtkWaitResult.Device, mtkWaitResult.DeviceInfo.ChipConfig, cancelToken);
			if (Operators.CompareString(CHECK, "no", TextCompare: false) == 0)
			{
				return;
			}
			if (mtkWaitResult.DeviceInfo.IsSecure)
			{
				mtkWaitResult.Device.Dispose();
				MtkDeviceInfo deviceInfo = mtkWaitResult.DeviceInfo;
				mtkWaitResult = null;
				Form1.SharedUI.ProgressBar1.Text = "Search...";
				try
				{
					mtkWaitResult = await MtkDeviceWaiterService.WaitUsbAsync(doHandshake: false, cancelToken);
					await MtkAuthExploitService.ExploitAsync((IMtkUsbDevice)mtkWaitResult.Device, deviceInfo.ChipConfig, cancelToken);
					Form1.SharedUI.ProgressBar1.Text = "Search....";
					mtkWaitResult.Device.Dispose();
					mtkWaitResult = null;
					mtkWaitResult = await MtkDeviceWaiterService.WaitSerialAsync(doHandshake: true, cancelToken);
					if (mtkWaitResult.DeviceInfo.IsSecure)
					{
						CHECK = "no";
						gui.Richlog("Failed", Color.Red, isBold: false, NextLine: true);
						gui.Richlog("- This Security Not Supported", Color.Red);
						return;
					}
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					CHECK = "no";
					ProjectData.ClearProjectError();
				}
			}
			if (Operators.CompareString(CHECK, "no", TextCompare: false) == 0)
			{
				CHECK = "no";
				return;
			}
			if (Mediatek.Platform.Contains("MT6853"))
			{
				Mediatek.Preloader = Application.StartupPath + "\\mtk\\ronix_emi\\preloader_a326u.bin";
			}
			if (Operators.CompareString(Form1.SharedUI.TxtEMI.Text, "", TextCompare: false) == 0)
			{
				if (Operators.CompareString(Mediatek.Preloader, null, TextCompare: false) == 0)
				{
					Mediatek.Preloader = null;
					string text = Application.StartupPath + "\\mtk\\ronix_emi";
					if (!Directory.Exists(text))
					{
						Directory.CreateDirectory(text);
					}
					gui.Richlog("OK", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
					gui.Richlog("- Sending EMI Data : ", Color.Black);
					Form1.SharedUI.ProgressBar1.Text = "Sending...";
					Crashing = "";
					preloader = await MtkPreloaderService.DumpAsynctest(mtkWaitResult.Device, mtkWaitResult.DeviceInfo.ChipConfig, cancelToken);
					if (preloader == null)
					{
						gui.Richlog("Sending Failed", Color.Red, isBold: false, NextLine: true);
						gui.Richlog("1- Go To Tool Settings", Color.Red, isBold: false, NextLine: true);
						gui.Richlog("2- Using Custom Preloader", Color.Red);
						CHECK = "no";
						return;
					}
					Mediatek.Preloader = Application.StartupPath + "\\mtk\\ronix_emi\\" + preloader.Name;
					if (!File.Exists(text + "\\" + preloader.Name))
					{
						File.WriteAllBytes(text + "\\" + preloader.Name, preloader.Data);
					}
				}
				else if (File.Exists(Mediatek.Preloader))
				{
					Check_Preloader = "OK";
					FileStream fileStream = new FileStream(Mediatek.Preloader, FileMode.Open, FileAccess.Read);
					preloader = await MtkPreloaderService.LoadAsync(fileStream, mtkWaitResult.DeviceInfo.ChipConfig, cancelToken);
					fileStream.Close();
				}
				else
				{
					string text2 = Application.StartupPath + "\\mtk\\ronix_emi";
					if (!Directory.Exists(text2))
					{
						Directory.CreateDirectory(text2);
					}
					gui.Richlog("OK", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
					gui.Richlog("- Sending EMI Data : ", Color.Black);
					Form1.SharedUI.ProgressBar1.Text = "Sending...";
					Crashing = "";
					preloader = await MtkPreloaderService.DumpAsynctest(mtkWaitResult.Device, mtkWaitResult.DeviceInfo.ChipConfig, cancelToken);
					if (preloader == null)
					{
						gui.Richlog("Sending Failed", Color.Red, isBold: false, NextLine: true);
						gui.Richlog("1- Go To Tool Settings", Color.Red, isBold: false, NextLine: true);
						gui.Richlog("2- Using Custom Preloader", Color.Red);
						CHECK = "no";
						return;
					}
					Mediatek.Preloader = Application.StartupPath + "\\mtk\\ronix_emi\\" + preloader.Name;
					if (!File.Exists(text2 + "\\" + preloader.Name))
					{
						File.WriteAllBytes(text2 + "\\" + preloader.Name, preloader.Data);
					}
				}
			}
			else if (File.Exists(Mediatek.Preloader))
			{
				Check_Preloader = "OK";
				FileStream fileStream2 = new FileStream(Mediatek.Preloader, FileMode.Open, FileAccess.Read);
				preloader = await MtkPreloaderService.LoadAsync(fileStream2, mtkWaitResult.DeviceInfo.ChipConfig, cancelToken);
				fileStream2.Close();
			}
			else
			{
				string text3 = Application.StartupPath + "\\mtk\\ronix_emi";
				if (!Directory.Exists(text3))
				{
					Directory.CreateDirectory(text3);
				}
				gui.Richlog("OK", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
				gui.Richlog("- Sending EMI Data : ", Color.Black);
				Form1.SharedUI.ProgressBar1.Text = "Sending...";
				Crashing = "";
				preloader = await MtkPreloaderService.DumpAsynctest(mtkWaitResult.Device, mtkWaitResult.DeviceInfo.ChipConfig, cancelToken);
				Mediatek.Preloader = Application.StartupPath + "\\mtk\\ronix_emi\\" + preloader.Name;
		
				if (!File.Exists(text3 + "\\" + preloader.Name))
				{
					File.WriteAllBytes(text3 + "\\" + preloader.Name, preloader.Data);
				}
			}
			uploadResult = await MtkDaxUploadService.UploadAsync1((MtkSerialDevice)(IMtkSerialDevice)mtkWaitResult.Device, mtkWaitResult.DeviceInfo.ChipConfig, preloader.Emi, cancelToken);
			Mediatek.PreloaderName = preloader.Name;
			Mediatek.PreloaderEmi = preloader.Data;
		}
		catch (OperationCanceledException ex)
		{
			ProjectData.SetProjectError(ex);
			OperationCanceledException ex2 = ex;
			Console.WriteLine(ex2.Message.ToString());
			ProjectData.ClearProjectError();
		}
		finally
		{
			mtkWaitResult?.Device.Dispose();
		}
		if (Operators.CompareString(Form1.SharedUI.TxtEMI.Text, "", TextCompare: false) == 0)
		{
			Mediatek.Preloader = null;
		}
		if (Operators.CompareString(CHECK, "no", TextCompare: false) == 0)
		{
			CHECK = "no";
			return;
		}
		if (Operators.CompareString(Check_Preloader, "OK", TextCompare: false) != 0)
		{
			await Task.Delay(TimeSpan.FromSeconds(2.0));
		}
		else
		{
			await Task.Delay(TimeSpan.FromSeconds(4.0));
		}
		Form1.SharedUI.ProgressBar1.Text = "Analyzeing...";
		if (Form1.SharedUI.CkAutoSwitchHighSpeedUSB.Checked)
		{
			gui.Richlog("Mediatek DA USB VCOM (" + MtkDeviceWaiterService.com + ")", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
		}
		else
		{
			gui.Richlog("OK", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
			gui.Richlog("- BootMode : ", Color.Black);
			gui.Richlog("BootROM [" + MtkDeviceWaiterService.com + "]", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
		}
		if (Form1.SharedUI.CkReadAndroidInfo.Checked && Operators.CompareString(Mhetod, "1", TextCompare: false) == 0)
		{
			if (Operators.CompareString(device_info.Brand, "", TextCompare: false) != 0)
			{
				gui.Richlog("- Manufacturer : ", Color.Black);
				gui.Richlog(device_info.Brand, Color.Green, isBold: false, NextLine: true);
			}
			if (Operators.CompareString(device_info.model, "", TextCompare: false) != 0)
			{
				gui.Richlog("- Phone Model : ", Color.Black);
				gui.Richlog(device_info.model, Color.Green, isBold: false, NextLine: true);
			}
			if (Operators.CompareString(device_info.Android, "", TextCompare: false) != 0)
			{
				gui.Richlog("- Android Version : ", Color.Black);
				gui.Richlog(AndroidCommands.AndroidName(device_info.Android), Color.Green, isBold: false, NextLine: true);
			}
			if (Operators.CompareString(device_info.Build_id, "", TextCompare: false) != 0)
			{
				gui.Richlog("- Build id : ", Color.Black);
				gui.Richlog(device_info.Build_id, Color.Green, isBold: false, NextLine: true);
			}
			if (Operators.CompareString(device_info.security_patch, "", TextCompare: false) != 0)
			{
				gui.Richlog("- Security Patch : ", Color.Black);
				gui.Richlog(device_info.security_patch, Color.Green, isBold: false, NextLine: true);
			}
			if (Operators.CompareString(device_info.Region, "", TextCompare: false) != 0)
			{
				gui.Richlog("- Region : ", Color.Black);
				gui.Richlog(device_info.Region.ToUpper(), Color.Green, isBold: false, NextLine: true);
			}
			if (Operators.CompareString(device_info.cpu_abi, "", TextCompare: false) != 0)
			{
				gui.Richlog("- Cpu Abi Type : ", Color.Black);
				gui.Richlog(device_info.cpu_abi.ToUpper(), Color.Green, isBold: false, NextLine: true);
			}
			if (Operators.CompareString(device_info.Software_Version, "", TextCompare: false) != 0)
			{
				gui.Richlog("- Software Version : ", Color.Black);
				gui.Richlog(device_info.Software_Version, Color.Green, isBold: false, NextLine: true);
			}
		}
	}

	public static async Task InitAsync1(CancellationToken cancelToken)
	{
		cancelToken.ThrowIfCancellationRequested();
		Crashing = "";
		CHECK = "";
		gui.Richlog("OK", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
		gui.Richlog("- Waiting For Mtk Usb Device : ", Color.Black);
		Form1.SharedUI.ProgressBar1.Text = "Search...";
		MtkDaxUploadBootService.rebootto = false;
		MtkDeviceWaiterService.reconnect = false;
		mtkWaitResult = await MtkDeviceWaiterService.WaitSerialAsync3(doHandshake: true, cancelToken);
		if (Operators.CompareString(CHECK, "no", TextCompare: false) == 0)
		{
			return;
		}
		if (Operators.CompareString(CHECK, "not", TextCompare: false) == 0)
		{
			CHECK = "no";
			gui.Richlog("- This Security Not Supported", Color.Red);
			return;
		}
		try
		{
			if (mtkWaitResult.IsBootloader)
			{
				gui.Richlog("- Crashing To Brom Mode : ", Color.Black);
				Form1.SharedUI.ProgressBar1.Text = "Crashing...";
				await MtkBootloaderCrashService.CrashAsync(mtkWaitResult.Device, cancelToken);
				gui.Richlog("OK", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
				mtkWaitResult.Device.Dispose();
				mtkWaitResult = null;
				gui.Richlog("- Waiting for Usb Brom : ", Color.Black);
				Form1.SharedUI.ProgressBar1.Text = "Search...";
				Crashing = "OK";
				mtkWaitResult = await MtkDeviceWaiterService.WaitSerialAsync3(doHandshake: true, cancelToken);
				if (mtkWaitResult.IsBootloader)
				{
					CHECK = "no";
					gui.Richlog("Failed", Color.Red, isBold: false, NextLine: true);
					gui.Richlog("- This Security Not Supported", Color.Red);
					return;
				}
				gui.Richlog("OK", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
			}
			gui.Richlog("- Brom Security : [", Color.Black);
			if (SBC & SLA & SDA)
			{
				gui.Richlog("SBC", Color.Green);
				gui.Richlog("-SLA", Color.Green);
				gui.Richlog("-SDA", Color.Green);
				gui.Richlog("]", Color.Black, isBold: false, NextLine: true);
			}
			else if (SBC & SLA)
			{
				gui.Richlog("SBC", Color.Green);
				gui.Richlog("-SLA", Color.Green);
				gui.Richlog("]", Color.Black, isBold: false, NextLine: true);
			}
			else if (SLA & SDA)
			{
				gui.Richlog("SLA", Color.Green);
				gui.Richlog("-SDA", Color.Green);
				gui.Richlog("]", Color.Black, isBold: false, NextLine: true);
			}
			else if (SBC & SDA)
			{
				gui.Richlog("SBC", Color.Green);
				gui.Richlog("-SDA", Color.Green);
				gui.Richlog("]", Color.Black, isBold: false, NextLine: true);
			}
			else if (SBC)
			{
				gui.Richlog("SBC", Color.Green);
				gui.Richlog("]", Color.Black, isBold: false, NextLine: true);
			}
			else if (SLA)
			{
				gui.Richlog("SLA", Color.Green);
				gui.Richlog("]", Color.Black, isBold: false, NextLine: true);
			}
			else if (SDA)
			{
				gui.Richlog("SDA", Color.Green);
				gui.Richlog("]", Color.Black, isBold: false, NextLine: true);
			}
			else
			{
				gui.Richlog("Nothing", Color.Red);
				gui.Richlog("]", Color.Black, isBold: false, NextLine: true);
			}
			Check_BLOADER();
			await MtkWatchdogService.DisableAsync(mtkWaitResult.Device, mtkWaitResult.DeviceInfo.ChipConfig, cancelToken);
			if (mtkWaitResult.DeviceInfo.IsSecure)
			{
				mtkWaitResult.Device.Dispose();
				MtkDeviceInfo deviceInfo = mtkWaitResult.DeviceInfo;
				mtkWaitResult = null;
				Form1.SharedUI.ProgressBar1.Text = "Search...";
				try
				{
					mtkWaitResult = await MtkDeviceWaiterService.WaitUsbAsync(doHandshake: false, cancelToken);
					await MtkAuthExploitService.ExploitAsync((IMtkUsbDevice)mtkWaitResult.Device, deviceInfo.ChipConfig, cancelToken);
					mtkWaitResult.Device.Dispose();
					mtkWaitResult = null;
					mtkWaitResult = await MtkDeviceWaiterService.WaitSerialAsync3(doHandshake: true, cancelToken);
					if (mtkWaitResult.DeviceInfo.IsSecure)
					{
						CHECK = "no";
						gui.Richlog("Failed", Color.Red, isBold: false, NextLine: true);
						gui.Richlog("- This Security Not Supported", Color.Red);
						return;
					}
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					CHECK = "no";
					ProjectData.ClearProjectError();
				}
			}
			if (Operators.CompareString(CHECK, "no", TextCompare: false) == 0)
			{
				CHECK = "no";
				return;
			}
			string text = Application.StartupPath + "\\mtk\\ronix_emi";
			if (!Directory.Exists(text))
			{
				Directory.CreateDirectory(text);
			}
			gui.Richlog("OK", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
			gui.Richlog("- Sending EMI Data : ", Color.Black);
			Form1.SharedUI.ProgressBar1.Text = "Sending...";
			Crashing = "";
			preloader = await MtkPreloaderService.DumpAsynctest(mtkWaitResult.Device, mtkWaitResult.DeviceInfo.ChipConfig, cancelToken);
			Mediatek.Preloader = Application.StartupPath + "\\mtk\\ronix_emi\\" + preloader.Name;
			if (!File.Exists(text + "\\" + preloader.Name))
			{
				File.WriteAllBytes(text + "\\" + preloader.Name, preloader.Data);
			}
			uploadResult = await MtkDaxUploadService.UploadAsync3((MtkSerialDevice)(IMtkSerialDevice)mtkWaitResult.Device, mtkWaitResult.DeviceInfo.ChipConfig, preloader.Emi, cancelToken);
			Mediatek.PreloaderName = preloader.Name;
			Mediatek.PreloaderEmi = preloader.Data;
		}
		catch (OperationCanceledException ex)
		{
			ProjectData.SetProjectError(ex);
			OperationCanceledException ex2 = ex;
			Console.WriteLine(ex2.Message.ToString());
			ProjectData.ClearProjectError();
		}
		finally
		{
			mtkWaitResult?.Device.Dispose();
		}
		if (Operators.CompareString(CHECK, "no", TextCompare: false) != 0)
		{
			Form1.SharedUI.ProgressBar1.Text = "Analyzeing..";
			await Task.Delay(TimeSpan.FromSeconds(2.0));
			if (Form1.SharedUI.CkAutoSwitchHighSpeedUSB.Checked)
			{
				gui.Richlog("Mediatek DA USB VCOM (" + MtkDeviceWaiterService.com + ")", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
			}
			else
			{
				gui.Richlog("- BootMode : ", Color.Black);
				gui.Richlog("BootROM [" + MtkDeviceWaiterService.com + "]", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
			}
			if (Operators.CompareString(device_info.Brand, "", TextCompare: false) != 0)
			{
				gui.Richlog("- Manufacturer : ", Color.Black);
				gui.Richlog(device_info.Brand, Color.Green, isBold: false, NextLine: true);
			}
			if (Operators.CompareString(device_info.model, "", TextCompare: false) != 0)
			{
				gui.Richlog("- Phone Model : ", Color.Black);
				gui.Richlog(device_info.model, Color.Green, isBold: false, NextLine: true);
			}
			if (Operators.CompareString(device_info.Android, "", TextCompare: false) != 0)
			{
				gui.Richlog("- Android Version : ", Color.Black);
				gui.Richlog(AndroidCommands.AndroidName(device_info.Android), Color.Green, isBold: false, NextLine: true);
			}
			if (Operators.CompareString(device_info.Build_id, "", TextCompare: false) != 0)
			{
				gui.Richlog("- Build id : ", Color.Black);
				gui.Richlog(device_info.Build_id, Color.Green, isBold: false, NextLine: true);
			}
			if (Operators.CompareString(device_info.security_patch, "", TextCompare: false) != 0)
			{
				gui.Richlog("- Security Patch : ", Color.Black);
				gui.Richlog(device_info.security_patch, Color.Green, isBold: false, NextLine: true);
			}
			if (Operators.CompareString(device_info.Region, "", TextCompare: false) != 0)
			{
				gui.Richlog("- Region : ", Color.Black);
				gui.Richlog(device_info.Region.ToUpper(), Color.Green, isBold: false, NextLine: true);
			}
			if (Operators.CompareString(device_info.cpu_abi, "", TextCompare: false) != 0)
			{
				gui.Richlog("- Cpu Abi Type : ", Color.Black);
				gui.Richlog(device_info.cpu_abi.ToUpper(), Color.Green, isBold: false, NextLine: true);
			}
			if (Operators.CompareString(device_info.Software_Version, "", TextCompare: false) != 0)
			{
				gui.Richlog("- Software Version : ", Color.Black);
				gui.Richlog(device_info.Software_Version, Color.Green, isBold: false, NextLine: true);
			}
		}
	}

	public static async Task InitAsync2(CancellationToken cancelToken)
	{
		cancelToken.ThrowIfCancellationRequested();
		Crashing = "";
		CHECK = "";
		gui.Richlog("OK", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
		gui.Richlog("> Power Off Then Connect Usb", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
		gui.Richlog("> Some Device Need To Press Volume (-) And (+)", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
		gui.Richlog("- Waiting For Mtk Usb Device : ", Color.Black);
		Form1.SharedUI.ProgressBar1.Text = "Search...";
		MtkDaxUploadBootService.rebootto = false;
		MtkDeviceWaiterService.reconnect = false;
		Form1.SharedUI.ProgressBar4.Text = "0%";
		Form1.SharedUI.ProgressBar4.Value = 0;
		SerialCOM.MSL = "ENREAD";
		mtkWaitResult = await MtkDeviceWaiterService.WaitSerialAsync6(doHandshake: true, cancelToken);
		if (!Timeout)
		{
			SerialCOM.MSL = "Cen";
			CHECK = "no";
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.Red;
			Form1.SharedUI.RichTextBox1.AppendText("Not Found");
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
			Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + "- TimeOut, Check The Cable And Try Again");
			return;
		}
		if (Operators.CompareString(CHECK, "no", TextCompare: false) == 0)
		{
			SerialCOM.MSL = "Cen";
			return;
		}
		if (Operators.CompareString(CHECK, "not", TextCompare: false) == 0)
		{
			CHECK = "no";
			gui.Richlog("- This Security Not Supported", Color.Red);
			return;
		}
		try
		{
			if (mtkWaitResult.IsBootloader)
			{
				gui.Richlog("- Crashing To Brom Mode : ", Color.Black);
				Form1.SharedUI.ProgressBar1.Text = "Crashing...";
				await MtkBootloaderCrashService.CrashAsync(mtkWaitResult.Device, cancelToken);
				gui.Richlog("OK", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
				mtkWaitResult.Device.Dispose();
				mtkWaitResult = null;
				gui.Richlog("- Waiting for Usb Brom : ", Color.Black);
				Form1.SharedUI.ProgressBar1.Text = "Search...";
				Crashing = "OK";
				mtkWaitResult = await MtkDeviceWaiterService.WaitSerialAsync(doHandshake: true, cancelToken);
				if (mtkWaitResult.IsBootloader)
				{
					CHECK = "no";
					gui.Richlog("Failed", Color.Red, isBold: false, NextLine: true);
					gui.Richlog("- This Security Not Supported", Color.Red);
					return;
				}
				gui.Richlog("OK", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
			}
			Check_BLOADER();
			await MtkWatchdogService.DisableAsync(mtkWaitResult.Device, mtkWaitResult.DeviceInfo.ChipConfig, cancelToken);
			hwcrypto_sej.sej_base = Convert.ToString(mtkWaitResult.DeviceInfo.ChipConfig.SejBase);
			if (mtkWaitResult.DeviceInfo.IsSecure)
			{
				mtkWaitResult.Device.Dispose();
				MtkDeviceInfo deviceInfo = mtkWaitResult.DeviceInfo;
				mtkWaitResult = null;
				Form1.SharedUI.ProgressBar1.Text = "Search...";
				try
				{
					mtkWaitResult = await MtkDeviceWaiterService.WaitUsbAsync(doHandshake: false, cancelToken);
					Form1.SharedUI.ProgressBar1.Text = "Exploit...";
					await MtkAuthExploitService.ExploitAsync((IMtkUsbDevice)mtkWaitResult.Device, deviceInfo.ChipConfig, cancelToken);
					mtkWaitResult.Device.Dispose();
					mtkWaitResult = null;
					mtkWaitResult = await MtkDeviceWaiterService.WaitSerialAsync6(doHandshake: true, cancelToken);
					if (mtkWaitResult.DeviceInfo.IsSecure)
					{
						CHECK = "no";
						gui.Richlog("Failed", Color.Red, isBold: false, NextLine: true);
						gui.Richlog("- This Security Not Supported", Color.Red);
						return;
					}
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					CHECK = "no";
					ProjectData.ClearProjectError();
				}
			}
			if (Operators.CompareString(CHECK, "no", TextCompare: false) == 0)
			{
				CHECK = "no";
				return;
			}
			if (Mediatek.Platform.Contains("MT6853"))
			{
				Mediatek.Preloader = Application.StartupPath + "\\mtk\\ronix_emi\\preloader_a326u.bin";
			}
			if (File.Exists(Mediatek.Preloader2))
			{
				FileStream fileStream = new FileStream(Mediatek.Preloader2, FileMode.Open, FileAccess.Read);
				preloader = await MtkPreloaderService.LoadAsync(fileStream, mtkWaitResult.DeviceInfo.ChipConfig, cancelToken);
				fileStream.Close();
			}
			else
			{
				string text = Application.StartupPath + "\\mtk\\ronix_emi";
				if (!Directory.Exists(text))
				{
					Directory.CreateDirectory(text);
				}
				gui.Richlog("OK", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
				gui.Richlog("- Sending Emi Data : ", Color.Black);
				Crashing = "";
				preloader = await MtkPreloaderService.DumpAsynctest(mtkWaitResult.Device, mtkWaitResult.DeviceInfo.ChipConfig, cancelToken);
				if (preloader == null)
				{
					gui.Richlog("Sending Failed", Color.Red, isBold: false, NextLine: true);
					gui.Richlog("> Using Custom Preloader", Color.Red);
					CHECK = "no";
					return;
				}
				if (!File.Exists(text + "\\" + preloader.Name))
				{
					File.WriteAllBytes(text + "\\" + preloader.Name, preloader.Data);
				}
			}
			uploadResult = await MtkDaxUploadService.UploadAsync4((MtkSerialDevice)(IMtkSerialDevice)mtkWaitResult.Device, mtkWaitResult.DeviceInfo.ChipConfig, preloader.Emi, cancelToken);
			Mediatek.PreloaderName = preloader.Name;
			Mediatek.PreloaderEmi = preloader.Data;
			Protocol_MTK_By_Devronix.SharedUI.CkBromReady.Invoke((Action)([SpecialName] () =>
			{
				Protocol_MTK_By_Devronix.SharedUI.CkBromReady.Checked = true;
			}));
		}
		catch (OperationCanceledException projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			Protocol_MTK_By_Devronix.SharedUI.CkBromReady.Invoke((Action)([SpecialName] () =>
			{
				Protocol_MTK_By_Devronix.SharedUI.CkBromReady.Checked = false;
			}));
			ProjectData.ClearProjectError();
		}
		finally
		{
			mtkWaitResult?.Device.Dispose();
		}
		if (Operators.CompareString(CHECK, "no", TextCompare: false) == 0)
		{
			CHECK = "no";
			return;
		}
		Form1.SharedUI.ProgressBar1.Text = "Analyzeing...";
		await Task.Delay(TimeSpan.FromSeconds(2.0));
		if (Form1.SharedUI.CkAutoSwitchHighSpeedUSB.Checked)
		{
			gui.Richlog("OK", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
			gui.Richlog("- BootMode : ", Color.Black);
			gui.Richlog("MTK DA VCOM [" + MtkDeviceWaiterService.com + "]", Color.FromArgb(0, 85, 207));
		}
		else
		{
			gui.Richlog("OK", Color.FromArgb(0, 85, 207));
		}
	}

	public static async Task InitDump(CancellationToken cancelToken)
	{
		cancelToken.ThrowIfCancellationRequested();
		Crashing = "";
		CHECK = "";
		gui.Richlog("OK", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
		gui.Richlog("> Power Off Then Connect Usb", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
		gui.Richlog("> Some Device Need To Press Volume (-) And (+)", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
		gui.Richlog("- Waiting For Mtk Serial Device : ", Color.Black);
		Form1.SharedUI.ProgressBar1.Text = "Search...";
		MtkDaxUploadBootService.rebootto = false;
		MtkDeviceWaiterService.reconnect = false;
		mtkWaitResult = await MtkDeviceWaiterService.WaitSerialAsync5(doHandshake: true, cancelToken);
		if (Operators.CompareString(CHECK, "no", TextCompare: false) == 0)
		{
			return;
		}
		if (Operators.CompareString(CHECK, "not", TextCompare: false) == 0)
		{
			CHECK = "no";
			gui.Richlog("- This Security Not Supported", Color.Red);
			return;
		}
		try
		{
			if (mtkWaitResult.IsBootloader)
			{
				gui.Richlog("- Crashing To Brom Mode : ", Color.Black);
				Form1.SharedUI.ProgressBar1.Text = "Crashing...";
				await MtkBootloaderCrashService.CrashAsync(mtkWaitResult.Device, cancelToken);
				gui.Richlog("OK", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
				mtkWaitResult.Device.Dispose();
				mtkWaitResult = null;
				gui.Richlog("- Waiting for Usb Brom : ", Color.Black);
				Form1.SharedUI.ProgressBar1.Text = "Search...";
				Crashing = "OK";
				mtkWaitResult = await MtkDeviceWaiterService.WaitSerialAsync5(doHandshake: true, cancelToken);
				if (mtkWaitResult.IsBootloader)
				{
					CHECK = "no";
					gui.Richlog("Failed", Color.Red, isBold: false, NextLine: true);
					gui.Richlog("- This Security Not Supported", Color.Red);
					return;
				}
				gui.Richlog("OK", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
			}
			Check_BLOADER();
			await MtkWatchdogService.DisableAsync(mtkWaitResult.Device, mtkWaitResult.DeviceInfo.ChipConfig, cancelToken);
			if (mtkWaitResult.DeviceInfo.IsSecure)
			{
				mtkWaitResult.Device.Dispose();
				MtkDeviceInfo deviceInfo = mtkWaitResult.DeviceInfo;
				mtkWaitResult = null;
				Form1.SharedUI.ProgressBar1.Text = "Search...";
				try
				{
					mtkWaitResult = await MtkDeviceWaiterService.WaitUsbAsync(doHandshake: false, cancelToken);
					await MtkAuthExploitService.ExploitAsync((IMtkUsbDevice)mtkWaitResult.Device, deviceInfo.ChipConfig, cancelToken);
					mtkWaitResult.Device.Dispose();
					mtkWaitResult = null;
					mtkWaitResult = await MtkDeviceWaiterService.WaitSerialAsync5(doHandshake: true, cancelToken);
					if (mtkWaitResult.DeviceInfo.IsSecure)
					{
						CHECK = "no";
						gui.Richlog("Failed", Color.Red, isBold: false, NextLine: true);
						gui.Richlog("- This Security Not Supported", Color.Red);
						return;
					}
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					CHECK = "no";
					ProjectData.ClearProjectError();
				}
			}
			if (Operators.CompareString(CHECK, "no", TextCompare: false) == 0)
			{
				CHECK = "no";
				return;
			}
			string startupPath = Application.StartupPath;
			gui.Richlog("OK", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
			Form1.SharedUI.ProgressBar4.Text = "0%";
			Form1.SharedUI.ProgressBar4.Value = 0;
			SerialCOM.MSL = "ENREAD";
			gui.Richlog("- Dumping Preloader File : ", Color.Black);
			Crashing = "";
			preloader = await MtkPreloaderService.DumpAsynctest(mtkWaitResult.Device, mtkWaitResult.DeviceInfo.ChipConfig, cancelToken);
			if (preloader == null)
			{
				gui.Richlog("Dumping Failed", Color.Red, isBold: false, NextLine: true);
				CHECK = "no";
				return;
			}
			if (!File.Exists(startupPath + "\\" + preloader.Name))
			{
				File.WriteAllBytes(startupPath + "\\" + preloader.Name, preloader.Data);
			}
			pre_dump = startupPath + "\\" + preloader.Name;
			Form1.SharedUI.ProgressBar4.Value = 100;
			SerialCOM.MSL = "DISREAD";
			Form1.SharedUI.ProgressBar4.Text = "0%";
			Form1.SharedUI.ProgressBar4.Value = 0;
			gui.Richlog("OK", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
			mtkWaitResult?.Device.Dispose();
		}
		catch (OperationCanceledException projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			mtkWaitResult?.Device.Dispose();
			ProjectData.ClearProjectError();
		}
		finally
		{
			mtkWaitResult?.Device.Dispose();
		}
	}

	public static async Task Reboot(CancellationToken cancelToken = default(CancellationToken))
	{
		gui.Richlog("- Reboot Device : ", Color.Black);
		try
		{
			await MtkDaxUploadBootService.RebootAsync(uploadResult.Device, cancelToken);
			gui.Richlog("OK", Color.FromArgb(0, 85, 207));
			Protocol_MTK_By_Devronix.SharedUI.CkBromReady.Invoke((Action)([SpecialName] () =>
			{
				Protocol_MTK_By_Devronix.SharedUI.CkBromReady.Checked = false;
			}));
			closingport2();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			gui.Richlog("Failed", Color.Red);
			Protocol_MTK_By_Devronix.SharedUI.CkBromReady.Invoke((Action)([SpecialName] () =>
			{
				Protocol_MTK_By_Devronix.SharedUI.CkBromReady.Checked = false;
			}));
			closingport();
			ProjectData.ClearProjectError();
		}
	}

	public static async Task Read2(string folder, CancellationToken cancelToken = default(CancellationToken))
	{
		try
		{
			if (Operators.CompareString(CHECK, "no", TextCompare: false) == 0)
			{
				return;
			}
			try
			{
				cancelToken.ThrowIfCancellationRequested();
				Form1.SharedUI.ProgressBar4.Text = "0%";
				Form1.SharedUI.ProgressBar4.Value = 0;
				SerialCOM.MSL = "ENREAD";
				await ReadGPT(cancelToken, showlist: false);
				foreach (DataGridViewRow item in (IEnumerable)Protocol_MTK_By_Devronix.SharedUI.DataViewmtk.Rows)
				{
					if (Convert.ToBoolean(RuntimeHelpers.GetObjectValue(item.Cells[0].Value)))
					{
						gui.Richlog("- Reading ", Color.Black);
						string text = item.Cells[4].Value.ToString();
						gui.Richlog(item.Cells[2].Value.ToString(), Color.LightGreen);
						gui.Richlog(" [" + utils.GetFileSize(utils.HexToLong(text.Replace(" ", "").Replace("0x", ""))), Color.Black);
						gui.Richlog("] : ", Color.Black);
						await ReadPartition2(item.Cells[2].Value.ToString(), folder, utils.HexToLong(item.Cells[3].Value.ToString().Replace(" ", "").Replace("0x", "")), utils.HexToLong(item.Cells[4].Value.ToString().Replace(" ", "").Replace("0x", "")), cancelToken);
						gui.Richlog("OK", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
					}
				}
			}
			finally
			{
				try
				{
					Form1.SharedUI.ProgressBar4.Value = 100;
					SerialCOM.MSL = "DISREAD";
					Form1.SharedUI.ProgressBar4.Text = "0%";
					Form1.SharedUI.ProgressBar4.Value = 0;
					string path = folder + "/" + Mediatek.Platform + "_Android_Scatter.txt";
					if (File.Exists(path))
					{
						File.Delete(path);
					}
					gui.Richlog("- Scatter File Created : ", Color.Black);
					gui.Richlog(Mediatek.Platform + "_Android_Scatter.txt", Color.FromArgb(21, 87, 255));
					File.WriteAllText(path, MtkScatter.ScatterBuilder());
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
			}
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			gui.Richlog("Failed", Color.Red);
			Protocol_MTK_By_Devronix.SharedUI.CkBromReady.Invoke((Action)([SpecialName] () =>
			{
				Protocol_MTK_By_Devronix.SharedUI.CkBromReady.Checked = false;
			}));
			closingport();
			ProjectData.ClearProjectError();
		}
	}

	public static async Task ReadPartition2(string partition, string foldersave, long address, long size, CancellationToken cancelToken = default(CancellationToken))
	{
		cancelToken.ThrowIfCancellationRequested();
		if (Operators.CompareString(partition, "preloader", TextCompare: false) == 0)
		{
			if (File.Exists(foldersave + "\\" + Mediatek.PreloaderName))
			{
				File.Delete(foldersave + "\\" + Mediatek.PreloaderName);
			}
			File.WriteAllBytes(foldersave + "\\" + Mediatek.PreloaderName, Mediatek.PreloaderEmi);
			return;
		}
		string text = foldersave + "//" + partition + ".img";
		if (File.Exists(text))
		{
			File.Delete(text);
		}
		await MtkDaxPartitionService.ReadSaveAsync(uploadResult.Device, uploadResult.FlashInfo, address, size, text, cancelToken);
	}

	public static async Task Erase(CancellationToken cancelToken = default(CancellationToken))
	{
		try
		{
			cancelToken.ThrowIfCancellationRequested();
			foreach (DataGridViewRow item in (IEnumerable)Protocol_MTK_By_Devronix.SharedUI.DataViewmtk.Rows)
			{
				if (Convert.ToBoolean(RuntimeHelpers.GetObjectValue(item.Cells[0].Value)))
				{
					if (Operators.CompareString(item.Cells[2].Value.ToString(), "preloader", TextCompare: false) == 0)
					{
						gui.Richlog("- Erasing Preloader : ", Color.Black);
						await MtkCustomWrite.ForMatBoot(uploadResult.Device, "0", Mediatek.BootSize.ToString(), cancelToken);
						Thread.Sleep(1000);
						gui.Richlog("OK", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
					}
					else
					{
						gui.Richlog("- Erasing Partition ", Color.Black);
						string text = item.Cells[4].Value.ToString();
						gui.Richlog(item.Cells[2].Value.ToString(), Color.LightGreen);
						gui.Richlog(" [" + utils.GetFileSize(utils.HexToLong(text.Replace(" ", "").Replace("0x", ""))), Color.Black);
						gui.Richlog("] : ", Color.Black);
						await FormatPartition(utils.HexToLong(item.Cells[3].Value.ToString().Replace(" ", "").Replace("0x", "")), utils.HexToLong(item.Cells[4].Value.ToString().Replace(" ", "").Replace("0x", "")), cancelToken);
						gui.Richlog("OK", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
					}
				}
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			gui.Richlog("Failed", Color.Red);
			Protocol_MTK_By_Devronix.SharedUI.CkBromReady.Invoke((Action)([SpecialName] () =>
			{
				Protocol_MTK_By_Devronix.SharedUI.CkBromReady.Checked = false;
			}));
			closingport();
			ProjectData.ClearProjectError();
		}
	}

	public static async Task InitCrashing(CancellationToken cancelToken)
	{
		cancelToken.ThrowIfCancellationRequested();
		gui.Richlog("OK", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
		gui.Richlog("> Power Off Then Connect Usb", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
		gui.Richlog("> Some Device Need To Press Volume (-) And (+)", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
		gui.Richlog("- Waiting For Mtk Serial Device : ", Color.Black);
		MtkDaxUploadBootService.rebootto = false;
		MtkDeviceWaiterService.reconnect = false;
		mtkWaitResult = await MtkDeviceWaiterService.WaitSerialAsync5(doHandshake: true, cancelToken);
		if (Operators.CompareString(CHECK, "no", TextCompare: false) == 0)
		{
			return;
		}
		if (Operators.CompareString(CHECK, "not", TextCompare: false) == 0)
		{
			CHECK = "no";
			gui.Richlog("- This Security Not Supported", Color.Red);
			return;
		}
		try
		{
			if (mtkWaitResult.IsBootloader)
			{
				gui.Richlog("- Crashing To Brom Mode : ", Color.Black);
				await MtkBootloaderCrashService.CrashAsync(mtkWaitResult.Device, cancelToken);
				gui.Richlog("OK", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
				mtkWaitResult.Device.Dispose();
				mtkWaitResult = null;
			}
			else
			{
				mtkWaitResult.Device.Dispose();
				mtkWaitResult = null;
			}
		}
		catch (OperationCanceledException ex)
		{
			ProjectData.SetProjectError(ex);
			OperationCanceledException ex2 = ex;
			Console.WriteLine(ex2.Message.ToString());
			Protocol_MTK_By_Devronix.SharedUI.CkBromReady.Invoke((Action)([SpecialName] () =>
			{
				Protocol_MTK_By_Devronix.SharedUI.CkBromReady.Checked = false;
			}));
			ProjectData.ClearProjectError();
		}
		finally
		{
			mtkWaitResult?.Device.Dispose();
		}
	}

	public static async Task WriteNV2(string folder, CancellationToken cancelToken = default(CancellationToken))
	{
		try
		{
			if (Operators.CompareString(CHECK, "no", TextCompare: false) == 0)
			{
				return;
			}
			cancelToken.ThrowIfCancellationRequested();
			Form1.SharedUI.ProgressBar4.Text = "0%";
			Form1.SharedUI.ProgressBar4.Value = 0;
			SerialCOM.MSL = "ENREAD";
			await ReadGPT(cancelToken, showlist: false);
			try
			{
				int num;
				//_ = num - 2;
				foreach (DataGridViewRow item in (IEnumerable)Protocol_MTK_By_Devronix.SharedUI.DataGridView1.Rows)
				{
					if (File.Exists(item.Cells[1].Value.ToString()))
					{
						gui.Richlog("- Writing ", Color.Black);
						string text = item.Cells[2].Value.ToString();
						gui.Richlog(item.Cells[0].Value.ToString(), Color.LightGreen);
						gui.Richlog(" [" + utils.GetFileSize(Conversions.ToLong(text.Replace(" ", "").Replace("0x", ""))), Color.Black);
						gui.Richlog("] : ", Color.Black);
						if (gpt.Partitions.Length > 0)
						{
							MtkGptPartition[] partitions = gpt.Partitions;
							foreach (MtkGptPartition mtkGptPartition in partitions)
							{
								if (Operators.CompareString(mtkGptPartition.Name, item.Cells[0].Value.ToString(), TextCompare: false) == 0)
								{
									await checked(WritePartition(item.Cells[1].Value.ToString(), mtkGptPartition.FirstLba * MtkSparse.sectsize, mtkGptPartition.SectorCount * MtkSparse.sectsize, cancelToken));
									break;
								}
							}
						}
						gui.Richlog("OK", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
					}
					else
					{
						gui.Richlog("- Writing : ", Color.Black);
						gui.Richlog("Fail", Color.Red, isBold: false, NextLine: true);
					}
				}
			}
			finally
			{
				Form1.SharedUI.ProgressBar4.Value = 100;
				SerialCOM.MSL = "DISREAD";
				Form1.SharedUI.ProgressBar4.Text = "0%";
				Form1.SharedUI.ProgressBar4.Value = 0;
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			gui.Richlog("Failed", Color.Red);
			Protocol_MTK_By_Devronix.SharedUI.CkBromReady.Invoke((Action)([SpecialName] () =>
			{
				Protocol_MTK_By_Devronix.SharedUI.CkBromReady.Checked = false;
			}));
			closingport();
			ProjectData.ClearProjectError();
		}
	}

	public static async Task Flash(CancellationToken cancelToken = default(CancellationToken))
	{
		try
		{
			if (Operators.CompareString(CHECK, "no", TextCompare: false) == 0)
			{
				return;
			}
			cancelToken.ThrowIfCancellationRequested();
			Form1.SharedUI.ProgressBar4.Text = "0%";
			Form1.SharedUI.ProgressBar4.Value = 0;
			SerialCOM.MSL = "ENREAD";
			try
			{
				foreach (DataGridViewRow item in (IEnumerable)Protocol_MTK_By_Devronix.SharedUI.DataViewmtk.Rows)
				{
					if (!Convert.ToBoolean(RuntimeHelpers.GetObjectValue(item.Cells[0].Value)))
					{
						continue;
					}
					if (File.Exists(item.Cells[6].Value.ToString()))
					{
						if (Operators.CompareString(item.Cells[2].Value.ToString(), "preloader", TextCompare: false) == 0)
						{
							byte[] v = File.ReadAllBytes(item.Cells[6].Value.ToString());
							gui.Richlog("- Analyze Device Security : ", Color.Black);
							await MtkCustomWrite.writeBoot(uploadResult.Device, uploadResult.FlashInfo, "preloader", v, cancelToken);
							await MtkCustomWrite.writeBoot(uploadResult.Device, uploadResult.FlashInfo, "preloader_backup", v, cancelToken);
							gui.Richlog("OK", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
							continue;
						}
						if (MtkSparse.CekSparse(item.Cells[6].Value.ToString()))
						{
							await FormatPartition(utils.HexToLong(item.Cells[3].Value.ToString().Replace(" ", "").Replace("0x", "")), utils.HexToLong(item.Cells[4].Value.ToString().Replace(" ", "").Replace("0x", "")), cancelToken);
							Thread.Sleep(1000);
						}
						gui.Richlog("- Writing ", Color.Black);
						string text = item.Cells[4].Value.ToString();
						gui.Richlog(item.Cells[2].Value.ToString(), Color.LightGreen);
						gui.Richlog(" [" + utils.GetFileSize(utils.HexToLong(text.Replace(" ", "").Replace("0x", ""))), Color.Black);
						gui.Richlog("] : ", Color.Black);
						await WritePartition(item.Cells[6].Value.ToString(), utils.HexToLong(item.Cells[3].Value.ToString().Replace(" ", "").Replace("0x", "")), utils.HexToLong(item.Cells[4].Value.ToString().Replace(" ", "").Replace("0x", "")), cancelToken);
						gui.Richlog("OK", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
					}
					else
					{
						gui.Richlog("- Writing ", Color.Black);
						string text2 = item.Cells[4].Value.ToString();
						gui.Richlog(item.Cells[2].Value.ToString(), Color.LightGreen);
						gui.Richlog(" [" + utils.GetFileSize(utils.HexToLong(text2.Replace(" ", "").Replace("0x", ""))), Color.Black);
						gui.Richlog("] : ", Color.Black);
						gui.Richlog("Failed", Color.Red, isBold: false, NextLine: true);
					}
				}
			}
			finally
			{
				Form1.SharedUI.ProgressBar4.Value = 100;
				SerialCOM.MSL = "DISREAD";
				Form1.SharedUI.ProgressBar4.Text = "0%";
				Form1.SharedUI.ProgressBar4.Value = 0;
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			gui.Richlog("Failed", Color.Red);
			Protocol_MTK_By_Devronix.SharedUI.CkBromReady.Invoke((Action)([SpecialName] () =>
			{
				Protocol_MTK_By_Devronix.SharedUI.CkBromReady.Checked = false;
			}));
			closingport();
			ProjectData.ClearProjectError();
		}
	}

	public static async Task Flash2(CancellationToken cancelToken = default(CancellationToken))
	{
		checked
		{
			try
			{
				if (Operators.CompareString(CHECK, "no", TextCompare: false) == 0)
				{
					return;
				}
				cancelToken.ThrowIfCancellationRequested();
				Form1.SharedUI.ProgressBar4.Text = "0%";
				Form1.SharedUI.ProgressBar4.Value = 0;
				SerialCOM.MSL = "ENREAD";
				foreach (DataGridViewRow item in (IEnumerable)Protocol_MTK_By_Devronix.SharedUI.DataGridFlash.Rows)
				{
					if (!Convert.ToBoolean(RuntimeHelpers.GetObjectValue(item.Cells[0].Value)))
					{
						continue;
					}
					if (File.Exists(item.Cells[6].Value.ToString()))
					{
						if (Operators.CompareString(item.Cells[2].Value.ToString(), "preloader", TextCompare: false) == 0)
						{
							byte[] v = File.ReadAllBytes(item.Cells[6].Value.ToString());
							gui.Richlog("- Analyze Device Security : ", Color.Black);
							await MtkCustomWrite.writeBoot(uploadResult.Device, uploadResult.FlashInfo, "preloader", v, cancelToken);
							await MtkCustomWrite.writeBoot(uploadResult.Device, uploadResult.FlashInfo, "preloader_backup", v, cancelToken);
							gui.Richlog("OK", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
							continue;
						}
						if (MtkSparse.CekSparse(item.Cells[6].Value.ToString()))
						{
							await FormatPartition(utils.HexToLong(item.Cells[3].Value.ToString().Replace(" ", "").Replace("0x", "")), utils.HexToLong(item.Cells[4].Value.ToString().Replace(" ", "").Replace("0x", "")), cancelToken);
							Thread.Sleep(1000);
						}
						gui.Richlog("- Writing ", Color.Black);
						string text = item.Cells[4].Value.ToString();
						gui.Richlog(item.Cells[2].Value.ToString(), Color.LightGreen);
						gui.Richlog(" [" + utils.GetFileSize(utils.HexToLong(text.Replace(" ", "").Replace("0x", ""))), Color.Black);
						gui.Richlog("] : ", Color.Black);
						await WritePartition(item.Cells[6].Value.ToString(), utils.HexToLong(item.Cells[3].Value.ToString().Replace(" ", "").Replace("0x", "")), utils.HexToLong(item.Cells[4].Value.ToString().Replace(" ", "").Replace("0x", "")), cancelToken);
						gui.Richlog("OK", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
					}
					else
					{
						gui.Richlog("- Writing ", Color.Black);
						string text2 = item.Cells[4].Value.ToString();
						gui.Richlog(item.Cells[2].Value.ToString(), Color.LightGreen);
						gui.Richlog(" [" + utils.GetFileSize(utils.HexToLong(text2.Replace(" ", "").Replace("0x", ""))), Color.Black);
						gui.Richlog("] : ", Color.Black);
						gui.Richlog("Failed", Color.Red, isBold: false, NextLine: true);
					}
				}
				Form1.SharedUI.ProgressBar4.Value = 100;
				SerialCOM.MSL = "DISREAD";
				Form1.SharedUI.ProgressBar4.Text = "0%";
				Form1.SharedUI.ProgressBar4.Value = 0;
				if (Protocol_MTK_By_Devronix.SharedUI.Guna2CheckBox4.Checked | Protocol_MTK_By_Devronix.SharedUI.Guna2CheckBox5.Checked)
				{
					gui.Richlog("- Read GPT Partitons : ", Color.Black);
					await ReadGPT(cancelToken, showlist: false);
					if (gpt.Partitions.Length > 0)
					{
						gui.Richlog("OK", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
						if (Protocol_MTK_By_Devronix.SharedUI.Guna2CheckBox4.Checked)
						{
							gui.Richlog("- Erasing Userdata : ", Color.Black);
							Form1.SharedUI.ProgressBar1.Text = "Erasing...";
							MtkGptPartition[] partitions = gpt.Partitions;
							foreach (MtkGptPartition mtkGptPartition in partitions)
							{
								if (Operators.CompareString(mtkGptPartition.Name, "userdata", TextCompare: false) == 0)
								{
									string text3 = utils.LongToHex(mtkGptPartition.FirstLba * MtkSparse.sectsize);
									await FormatPartition(size: utils.HexToLong(utils.LongToHex(mtkGptPartition.SectorCount * MtkSparse.sectsize).Replace(" ", "").Replace("0x", "")), address: utils.HexToLong(text3.Replace(" ", "").Replace("0x", "")), cancelToken: cancelToken);
								}
							}
							gui.Richlog("OK", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
						}
						if (Protocol_MTK_By_Devronix.SharedUI.Guna2CheckBox5.Checked)
						{
							gui.Richlog("- Erasing FRP Data : ", Color.Black);
							MtkGptPartition[] partitions2 = gpt.Partitions;
							foreach (MtkGptPartition mtkGptPartition2 in partitions2)
							{
								if (Operators.CompareString(mtkGptPartition2.Name, "frp", TextCompare: false) == 0)
								{
									string text4 = utils.LongToHex(mtkGptPartition2.FirstLba * MtkSparse.sectsize);
									await FormatPartition(size: utils.HexToLong(utils.LongToHex(mtkGptPartition2.SectorCount * MtkSparse.sectsize).Replace(" ", "").Replace("0x", "")), address: utils.HexToLong(text4.Replace(" ", "").Replace("0x", "")), cancelToken: cancelToken);
								}
								if (Operators.CompareString(mtkGptPartition2.Name, "persistent", TextCompare: false) == 0)
								{
									string text5 = utils.LongToHex(mtkGptPartition2.FirstLba * MtkSparse.sectsize);
									await FormatPartition(size: utils.HexToLong(utils.LongToHex(mtkGptPartition2.SectorCount * MtkSparse.sectsize).Replace(" ", "").Replace("0x", "")), address: utils.HexToLong(text5.Replace(" ", "").Replace("0x", "")), cancelToken: cancelToken);
								}
							}
							gui.Richlog("OK", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
						}
					}
					else
					{
						gui.Richlog("Failed", Color.Red);
					}
				}
				if (!Protocol_MTK_By_Devronix.SharedUI.Guna2CheckBox6.Checked)
				{
					return;
				}
				gui.Richlog("- Reboot Device : ", Color.Black);
				Form1.SharedUI.ProgressBar1.Text = "Rebooting...";
				try
				{
					await MtkDaxUploadBootService.RebootAsync(uploadResult.Device, cancelToken);
					gui.Richlog("OK", Color.FromArgb(0, 85, 207));
					Protocol_MTK_By_Devronix.SharedUI.CkBromReady.Invoke((Action)([SpecialName] () =>
					{
						Protocol_MTK_By_Devronix.SharedUI.CkBromReady.Checked = false;
					}));
					closingport2();
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					gui.Richlog("Failed", Color.Red);
					Protocol_MTK_By_Devronix.SharedUI.CkBromReady.Invoke((Action)([SpecialName] () =>
					{
						Protocol_MTK_By_Devronix.SharedUI.CkBromReady.Checked = false;
					}));
					closingport();
					ProjectData.ClearProjectError();
				}
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				gui.Richlog("Failed", Color.Red);
				Protocol_MTK_By_Devronix.SharedUI.CkBromReady.Invoke((Action)([SpecialName] () =>
				{
					Protocol_MTK_By_Devronix.SharedUI.CkBromReady.Checked = false;
				}));
				closingport();
				ProjectData.ClearProjectError();
			}
		}
	}

	public static async Task EXITTODONLOD(CancellationToken cancelToken = default(CancellationToken))
	{
		try
		{
			if (Operators.CompareString(CHECK, "no", TextCompare: false) != 0)
			{
				byte[] v = File.ReadAllBytes(Mediatek.Preloader);
				gui.Richlog("- Analyze Device Security : ", Color.Black);
				await MtkCustomWrite.writeBoot(uploadResult.Device, uploadResult.FlashInfo, "preloader", v, cancelToken);
				await MtkCustomWrite.writeBoot(uploadResult.Device, uploadResult.FlashInfo, "preloader_backup", v, cancelToken);
				gui.Richlog("OK", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			gui.Richlog("Failed", Color.Red);
			closingport();
			ProjectData.ClearProjectError();
		}
	}

	public static async Task ReadGPT2(CancellationToken cancelToken = default(CancellationToken), bool showlist = true)
	{
		checked
		{
			try
			{
				_Closure_0024__55_002D1 arg = default( _Closure_0024__55_002D1);
				cancelToken.ThrowIfCancellationRequested();
				gpt = new MtkGpt();
				gpt = await MtkDaxGptService.ReadAsync(uploadResult.Device, uploadResult.FlashInfo, cancelToken);
				MtkSparse.sectsize = 512;
				string text = "EMMC";
				storagetype = "emmc";
				if (uploadResult.FlashInfo.Type == MtkDaxFlashInfoType.UFS)
				{
					MtkSparse.sectsize = 4096;
					storagetype = "ufs";
					text = "UFS";
				}
				if (Operators.CompareString(text, "UFS", TextCompare: false) == 0)
				{
					arg._0024VB_0024Local_regionBOOT = text + "_LU0_LU1";
					arg._0024VB_0024Local_region = text + "_LU2";
				}
				else
				{
					arg._0024VB_0024Local_regionBOOT = text + "_BOOT1";
					arg._0024VB_0024Local_region = text + "_USER";
				}
				MtkGpt mtkGpt = gpt;
				if ((object)mtkGpt != null && mtkGpt.Partitions.Length > 0)
				{
					if (showlist)
					{
						_Closure_0024__55_002D0 arg2 = default(_Closure_0024__55_002D0);
						_Closure_0024__55_002D0 CS_0024_003C_003E8__locals1 = new _Closure_0024__55_002D0(arg2);
						CS_0024_003C_003E8__locals1._0024VB_0024NonLocal__0024VB_0024Closure_2 = arg;
						string text2 = utils.LongToHex(Mediatek.BootSize);
						CS_0024_003C_003E8__locals1._0024VB_0024Local_sizeboot = utils.GetFileSize(utils.HexToLong(text2.Replace(" ", "").Replace("0x", "")));
						Protocol_MTK_By_Devronix.SharedUI.DataViewmtk.Invoke((Action)([SpecialName] () =>
						{
							Protocol_MTK_By_Devronix.SharedUI.DataViewmtk.Rows.Add(false, "boot", "preloader", "0x0", utils.LongToHex(Mediatek.BootSize), CS_0024_003C_003E8__locals1._0024VB_0024Local_sizeboot, "", CS_0024_003C_003E8__locals1._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_regionBOOT);
						}));
						Protocol_MTK_By_Devronix.SharedUI.DataViewmtk.Invoke((Action)([SpecialName] () =>
						{
							Protocol_MTK_By_Devronix.SharedUI.DataViewmtk.Rows.Add(false, "userarea", "PGPT", "0x0", "0x8000", "32.00 KB", "", CS_0024_003C_003E8__locals1._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_region);
						}));
						MtkGptPartition[] partitions = gpt.Partitions;
						_Closure_0024__55_002D2 closure_0024__55_002D = default(_Closure_0024__55_002D2);
						_Closure_0024__55_002D3 closure_0024__55_002D2 = default(_Closure_0024__55_002D3);
						for (int i = 0; i < partitions.Length; i++)
						{
							closure_0024__55_002D = new _Closure_0024__55_002D2(closure_0024__55_002D);
							closure_0024__55_002D._0024VB_0024NonLocal__0024VB_0024Closure_3 = CS_0024_003C_003E8__locals1;
							closure_0024__55_002D._0024VB_0024Local_sourceItem = partitions[i];
							closure_0024__55_002D2 = new _Closure_0024__55_002D3(closure_0024__55_002D2);
							closure_0024__55_002D2._0024VB_0024NonLocal__0024VB_0024Closure_4 = closure_0024__55_002D;
							closure_0024__55_002D2._0024VB_0024Local_hh2 = utils.LongToHex(closure_0024__55_002D2._0024VB_0024NonLocal__0024VB_0024Closure_4._0024VB_0024Local_sourceItem.SectorCount * MtkSparse.sectsize);
							closure_0024__55_002D2._0024VB_0024Local_hh1 = utils.LongToHex(closure_0024__55_002D2._0024VB_0024NonLocal__0024VB_0024Closure_4._0024VB_0024Local_sourceItem.FirstLba * MtkSparse.sectsize);
							closure_0024__55_002D2._0024VB_0024Local_size = utils.GetFileSize(utils.HexToLong(closure_0024__55_002D2._0024VB_0024Local_hh2.Replace(" ", "").Replace("0x", "")));
							Protocol_MTK_By_Devronix.SharedUI.DataViewmtk.Invoke(new Action(closure_0024__55_002D2._Lambda_0024__2));
						}
					}
					return;
				}
				using MemoryStream memoryStream = new MemoryStream();
				await MtkDaxPartitionService.ReadPartitionByNameAsync(uploadResult.Device, "sgpt", memoryStream, cancelToken);
				memoryStream.Seek(0L, SeekOrigin.Begin);
				byte[] buffer = MtkGptRepairService.Fix(memoryStream.ToArray(), uploadResult.FlashInfo.PageSize);
				gui.Richlog("- Repairing Boot : ", Color.Black);
				if (File.Exists(Application.StartupPath + "//repaired.pgpt.bin"))
				{
					File.Delete(Application.StartupPath + "//repaired.pgpt.bin");
				}
				File.WriteAllBytes(Application.StartupPath + "//repaired.pgpt.bin", buffer);
				await MtkCustomWrite.writeByPartitionName(uploadResult.Device, uploadResult.FlashInfo, "pgpt", Application.StartupPath + "//repaired.pgpt.bin", cancelToken);
				if (File.Exists(Application.StartupPath + "//repaired.pgpt.bin"))
				{
					File.Delete(Application.StartupPath + "//repaired.pgpt.bin");
				}
				gui.Richlog("OK", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
				using (MemoryStream memoryStream2 = new MemoryStream(buffer))
				{
					gpt = await MtkDaxGptService.ReadAsync(memoryStream2, uploadResult.FlashInfo.PageSize, cancelToken);
				}
				if (showlist)
				{
					_Closure_0024__55_002D4 arg3 = default(_Closure_0024__55_002D4);
					_Closure_0024__55_002D4 CS_0024_003C_003E8__locals0 = new _Closure_0024__55_002D4(arg3);
					CS_0024_003C_003E8__locals0._0024VB_0024NonLocal__0024VB_0024Closure_5 = arg;
					string text3 = utils.LongToHex(Mediatek.BootSize);
					CS_0024_003C_003E8__locals0._0024VB_0024Local_sizeboot = utils.GetFileSize(utils.HexToLong(text3.Replace(" ", "").Replace("0x", "")));
					Protocol_MTK_By_Devronix.SharedUI.DataViewmtk.Invoke((Action)([SpecialName] () =>
					{
						Protocol_MTK_By_Devronix.SharedUI.DataViewmtk.Rows.Add(false, "boot", "preloader", "0x0", utils.LongToHex(Mediatek.BootSize), CS_0024_003C_003E8__locals0._0024VB_0024Local_sizeboot, "", CS_0024_003C_003E8__locals0._0024VB_0024NonLocal__0024VB_0024Closure_5._0024VB_0024Local_regionBOOT);
					}));
					Protocol_MTK_By_Devronix.SharedUI.DataViewmtk.Invoke((Action)([SpecialName] () =>
					{
						Protocol_MTK_By_Devronix.SharedUI.DataViewmtk.Rows.Add(false, "userarea", "PGPT", "0x0", "0x8000", "512 KB", "", CS_0024_003C_003E8__locals0._0024VB_0024NonLocal__0024VB_0024Closure_5._0024VB_0024Local_region);
					}));
					MtkGptPartition[] partitions2 = gpt.Partitions;
					_Closure_0024__55_002D5 closure_0024__55_002D3 = default(_Closure_0024__55_002D5);
					_Closure_0024__55_002D6 closure_0024__55_002D4 = default(_Closure_0024__55_002D6);
					for (int j = 0; j < partitions2.Length; j++)
					{
						closure_0024__55_002D3 = new _Closure_0024__55_002D5(closure_0024__55_002D3);
						closure_0024__55_002D3._0024VB_0024NonLocal__0024VB_0024Closure_6 = CS_0024_003C_003E8__locals0;
						closure_0024__55_002D3._0024VB_0024Local_sourceItem = partitions2[j];
						closure_0024__55_002D4 = new _Closure_0024__55_002D6(closure_0024__55_002D4);
						closure_0024__55_002D4._0024VB_0024NonLocal__0024VB_0024Closure_7 = closure_0024__55_002D3;
						closure_0024__55_002D4._0024VB_0024Local_hh2 = utils.LongToHex(closure_0024__55_002D4._0024VB_0024NonLocal__0024VB_0024Closure_7._0024VB_0024Local_sourceItem.SectorCount * MtkSparse.sectsize);
						closure_0024__55_002D4._0024VB_0024Local_hh1 = utils.LongToHex(closure_0024__55_002D4._0024VB_0024NonLocal__0024VB_0024Closure_7._0024VB_0024Local_sourceItem.FirstLba * MtkSparse.sectsize);
						closure_0024__55_002D4._0024VB_0024Local_size = utils.GetFileSize(utils.HexToLong(closure_0024__55_002D4._0024VB_0024Local_hh2.Replace(" ", "").Replace("0x", "")));
						Protocol_MTK_By_Devronix.SharedUI.DataViewmtk.Invoke(new Action(closure_0024__55_002D4._Lambda_0024__5));
					}
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
	}

	public static async Task ReadGPT(CancellationToken cancelToken = default(CancellationToken), bool showlist = true)
	{
		try
		{
			cancelToken.ThrowIfCancellationRequested();
			gpt = new MtkGpt();
			gpt = await MtkDaxGptService.ReadAsync(uploadResult.Device, uploadResult.FlashInfo, cancelToken);
			MtkSparse.sectsize = 512;
			storagetype = "emmc";
			if (uploadResult.FlashInfo.Type == MtkDaxFlashInfoType.UFS)
			{
				MtkSparse.sectsize = 4096;
				storagetype = "ufs";
			}
			MtkGpt mtkGpt = gpt;
			if ((object)mtkGpt != null && mtkGpt.Partitions.Length > 0)
			{
				return;
			}
			using MemoryStream memoryStream = new MemoryStream();
			await MtkDaxPartitionService.ReadPartitionByNameAsync(uploadResult.Device, "sgpt", memoryStream, cancelToken);
			memoryStream.Seek(0L, SeekOrigin.Begin);
			byte[] buffer = MtkGptRepairService.Fix(memoryStream.ToArray(), uploadResult.FlashInfo.PageSize);
			gui.Richlog("- Repairing Boot : ", Color.Black);
			Form1.SharedUI.ProgressBar1.Text = "Repairing...";
			if (File.Exists(Application.StartupPath + "//repaired.pgpt.bin"))
			{
				File.Delete(Application.StartupPath + "//repaired.pgpt.bin");
			}
			File.WriteAllBytes(Application.StartupPath + "//repaired.pgpt.bin", buffer);
			await MtkCustomWrite.writeByPartitionName(uploadResult.Device, uploadResult.FlashInfo, "pgpt", Application.StartupPath + "//repaired.pgpt.bin", cancelToken);
			if (File.Exists(Application.StartupPath + "//repaired.pgpt.bin"))
			{
				File.Delete(Application.StartupPath + "//repaired.pgpt.bin");
			}
			gui.Richlog("OK", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
			using MemoryStream memoryStream2 = new MemoryStream(buffer);
			gpt = await MtkDaxGptService.ReadAsync(memoryStream2, uploadResult.FlashInfo.PageSize, cancelToken);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public static async Task ReadPartition(string partition, string foldersave, string partitionsave, long address, long size, CancellationToken cancelToken = default(CancellationToken))
	{
		cancelToken.ThrowIfCancellationRequested();
		if (Operators.CompareString(partitionsave, "preloader", TextCompare: false) == 0)
		{
			if (File.Exists(foldersave + "\\" + Mediatek.PreloaderName))
			{
				File.Delete(foldersave + "\\" + Mediatek.PreloaderName);
			}
			File.WriteAllBytes(foldersave + "\\" + Mediatek.PreloaderName, Mediatek.PreloaderEmi);
		}
		else if (Operators.CompareString(READ, "ok", TextCompare: false) == 0)
		{
			READ = "";
			string text = foldersave + "//" + partitionsave + ".img";
			if (File.Exists(text))
			{
				File.Delete(text);
			}
			await MtkDaxPartitionService.ReadSaveAsync(uploadResult.Device, uploadResult.FlashInfo, address, size, text, cancelToken);
		}
		else
		{
			string text = foldersave + "//" + partitionsave;
			if (File.Exists(text))
			{
				File.Delete(text);
			}
			await MtkDaxPartitionService.ReadSaveAsync(uploadResult.Device, uploadResult.FlashInfo, address, size, text, cancelToken);
		}
	}

	public static async Task WritePartition(string files, long address, long len, CancellationToken cancelToken = default(CancellationToken))
	{
		await MtkDaxPartitionService.WriteAsync(uploadResult.Device, uploadResult.FlashInfo, address, len, files, cancelToken);
	}

	public static async Task WritePartition(Stream bytee, long address, long len, CancellationToken cancelToken = default(CancellationToken))
	{
		await MtkDaxPartitionService.WriteAsync(uploadResult.Device, uploadResult.FlashInfo, address, len, bytee, cancelToken);
	}

	public static async Task FormatPartition(long address, long size, CancellationToken cancelToken = default(CancellationToken))
	{
		await MtkDaxPartitionService.FormatAsync(uploadResult.Device, uploadResult.FlashInfo, address, size, cancelToken);
	}

	public static async Task BackupNV(string folderBA, CancellationToken cancelToken = default(CancellationToken))
	{
		checked
		{
			try
			{
				if (Operators.CompareString(CHECK, "no", TextCompare: false) == 0)
				{
					return;
				}
				cancelToken.ThrowIfCancellationRequested();
				Form1.SharedUI.ProgressBar4.Text = "0%";
				Form1.SharedUI.ProgressBar4.Value = 0;
				SerialCOM.MSL = "ENREAD";
				await ReadGPT(cancelToken, showlist: false);
				if (gpt.Partitions.Length > 0)
				{
					MtkGptPartition[] partitions = gpt.Partitions;
					foreach (MtkGptPartition mtkGptPartition in partitions)
					{
						if (Operators.CompareString(mtkGptPartition.Name, "nvdata", TextCompare: false) == 0)
						{
							gui.Richlog("- Reading ", Color.Black);
							string text = utils.LongToHex(mtkGptPartition.SectorCount * MtkSparse.sectsize);
							gui.Richlog(mtkGptPartition.Name, Color.LightGreen);
							gui.Richlog(" [" + utils.GetFileSize(utils.HexToLong(text.Replace(" ", "").Replace("0x", ""))), Color.Black);
							gui.Richlog("] : ", Color.Black);
							await ReadPartition2(mtkGptPartition.Name, folderBA, mtkGptPartition.FirstLba * MtkSparse.sectsize, mtkGptPartition.SectorCount * MtkSparse.sectsize, cancelToken);
							break;
						}
					}
					MtkGptPartition[] partitions2 = gpt.Partitions;
					foreach (MtkGptPartition mtkGptPartition2 in partitions2)
					{
						if (Operators.CompareString(mtkGptPartition2.Name, "nvram", TextCompare: false) == 0)
						{
							gui.Richlog("OK", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
							gui.Richlog("- Reading ", Color.Black);
							string text2 = utils.LongToHex(mtkGptPartition2.SectorCount * MtkSparse.sectsize);
							gui.Richlog(mtkGptPartition2.Name, Color.LightGreen);
							gui.Richlog(" [" + utils.GetFileSize(utils.HexToLong(text2.Replace(" ", "").Replace("0x", ""))), Color.Black);
							gui.Richlog("] : ", Color.Black);
							await ReadPartition2(mtkGptPartition2.Name, folderBA, mtkGptPartition2.FirstLba * MtkSparse.sectsize, mtkGptPartition2.SectorCount * MtkSparse.sectsize, cancelToken);
							break;
						}
					}
					MtkGptPartition[] partitions3 = gpt.Partitions;
					foreach (MtkGptPartition mtkGptPartition3 in partitions3)
					{
						if (Operators.CompareString(mtkGptPartition3.Name, "protect1", TextCompare: false) == 0)
						{
							gui.Richlog("OK", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
							gui.Richlog("- Reading ", Color.Black);
							string text3 = utils.LongToHex(mtkGptPartition3.SectorCount * MtkSparse.sectsize);
							gui.Richlog(mtkGptPartition3.Name, Color.LightGreen);
							gui.Richlog(" [" + utils.GetFileSize(utils.HexToLong(text3.Replace(" ", "").Replace("0x", ""))), Color.Black);
							gui.Richlog("] : ", Color.Black);
							await ReadPartition2(mtkGptPartition3.Name, folderBA, mtkGptPartition3.FirstLba * MtkSparse.sectsize, mtkGptPartition3.SectorCount * MtkSparse.sectsize, cancelToken);
							break;
						}
					}
					MtkGptPartition[] partitions4 = gpt.Partitions;
					foreach (MtkGptPartition mtkGptPartition4 in partitions4)
					{
						if (Operators.CompareString(mtkGptPartition4.Name, "protect2", TextCompare: false) == 0)
						{
							gui.Richlog("OK", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
							gui.Richlog("- Reading ", Color.Black);
							utils.LongToHex(mtkGptPartition4.FirstLba * MtkSparse.sectsize);
							string text4 = utils.LongToHex(mtkGptPartition4.SectorCount * MtkSparse.sectsize);
							gui.Richlog(mtkGptPartition4.Name, Color.LightGreen);
							gui.Richlog(" [" + utils.GetFileSize(utils.HexToLong(text4.Replace(" ", "").Replace("0x", ""))), Color.Black);
							gui.Richlog("] : ", Color.Black);
							await ReadPartition2(mtkGptPartition4.Name, folderBA, mtkGptPartition4.FirstLba * MtkSparse.sectsize, mtkGptPartition4.SectorCount * MtkSparse.sectsize, cancelToken);
							break;
						}
					}
					gui.Richlog("OK", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
					Form1.SharedUI.ProgressBar4.Value = 100;
					SerialCOM.MSL = "DISREAD";
					Form1.SharedUI.ProgressBar4.Text = "0%";
					Form1.SharedUI.ProgressBar4.Value = 0;
				}
				else
				{
					gui.Richlog("Failed", Color.Red);
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				gui.Richlog("Failed", Color.Red);
				Protocol_MTK_By_Devronix.SharedUI.CkBromReady.Invoke((Action)([SpecialName] () =>
				{
					Protocol_MTK_By_Devronix.SharedUI.CkBromReady.Checked = false;
				}));
				closingport();
				ProjectData.ClearProjectError();
			}
		}
	}

	public static async Task EraseNV(CancellationToken cancelToken = default(CancellationToken))
	{
		checked
		{
			try
			{
				if (Operators.CompareString(CHECK, "no", TextCompare: false) == 0)
				{
					return;
				}
				cancelToken.ThrowIfCancellationRequested();
				await ReadGPT(cancelToken, showlist: false);
				if (gpt.Partitions.Length > 0)
				{
					MtkGptPartition[] partitions = gpt.Partitions;
					foreach (MtkGptPartition mtkGptPartition in partitions)
					{
						if (Operators.CompareString(mtkGptPartition.Name, "nvram", TextCompare: false) == 0)
						{
							await FormatPartition(mtkGptPartition.FirstLba * MtkSparse.sectsize, mtkGptPartition.SectorCount * MtkSparse.sectsize, cancelToken);
						}
						if (Operators.CompareString(mtkGptPartition.Name, "nvdata", TextCompare: false) == 0)
						{
							await FormatPartition(mtkGptPartition.FirstLba * MtkSparse.sectsize, mtkGptPartition.SectorCount * MtkSparse.sectsize, cancelToken);
						}
						if (Operators.CompareString(mtkGptPartition.Name, "protect1", TextCompare: false) == 0)
						{
							await FormatPartition(mtkGptPartition.FirstLba * MtkSparse.sectsize, mtkGptPartition.SectorCount * MtkSparse.sectsize, cancelToken);
						}
						if (Operators.CompareString(mtkGptPartition.Name, "protect2", TextCompare: false) == 0)
						{
							await FormatPartition(mtkGptPartition.FirstLba * MtkSparse.sectsize, mtkGptPartition.SectorCount * MtkSparse.sectsize, cancelToken);
						}
					}
					gui.Richlog("OK", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
				}
				else
				{
					gui.Richlog("Failed", Color.Red, isBold: false, NextLine: true);
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				gui.Richlog("Failed", Color.Red);
				Protocol_MTK_By_Devronix.SharedUI.CkBromReady.Invoke((Action)([SpecialName] () =>
				{
					Protocol_MTK_By_Devronix.SharedUI.CkBromReady.Checked = false;
				}));
				closingport();
				ProjectData.ClearProjectError();
			}
		}
	}

	public static async Task Remove_MDM(string folderwrite, string Brand, CancellationToken cancelToken = default(CancellationToken))
	{
		checked
		{
			try
			{
				if (Operators.CompareString(CHECK, "no", TextCompare: false) == 0)
				{
					return;
				}
				cancelToken.ThrowIfCancellationRequested();
				await ReadGPT(cancelToken, showlist: false);
				if (Operators.CompareString(Brand, "Samsung", TextCompare: false) == 0)
				{
					if (gpt.Partitions.Length > 0)
					{
						MtkGptPartition[] partitions = gpt.Partitions;
						foreach (MtkGptPartition mtkGptPartition in partitions)
						{
							if (Operators.CompareString(mtkGptPartition.Name, "userdata", TextCompare: false) == 0)
							{
								string text = utils.LongToHex(mtkGptPartition.FirstLba * MtkSparse.sectsize);
								await FormatPartition(size: utils.HexToLong(utils.LongToHex(mtkGptPartition.SectorCount * MtkSparse.sectsize).Replace(" ", "").Replace("0x", "")), address: utils.HexToLong(text.Replace(" ", "").Replace("0x", "")), cancelToken: cancelToken);
							}
						}
						gui.Richlog("OK", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
						gui.Richlog("- Erasing FRP : ", Color.Black);
						MtkGptPartition[] partitions2 = gpt.Partitions;
						foreach (MtkGptPartition mtkGptPartition2 in partitions2)
						{
							if (Operators.CompareString(mtkGptPartition2.Name, "persistent", TextCompare: false) == 0)
							{
								string text2 = utils.LongToHex(mtkGptPartition2.FirstLba * MtkSparse.sectsize);
								await FormatPartition(size: utils.HexToLong(utils.LongToHex(mtkGptPartition2.SectorCount * MtkSparse.sectsize).Replace(" ", "").Replace("0x", "")), address: utils.HexToLong(text2.Replace(" ", "").Replace("0x", "")), cancelToken: cancelToken);
							}
						}
						gui.Richlog("OK", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
						gui.Richlog("- Reboot Device : ", Color.Black);
						Form1.SharedUI.ProgressBar1.Text = "Rebooting...";
						await MtkDaxUploadBootService.RebootAsync(uploadResult.Device, cancelToken);
						gui.Richlog("OK", Color.FromArgb(0, 85, 207));
						closingport2();
					}
					else
					{
						gui.Richlog("Failed", Color.Red);
					}
				}
				else if (gpt.Partitions.Length > 0)
				{
					MtkGptPartition[] partitions3 = gpt.Partitions;
					foreach (MtkGptPartition mtkGptPartition3 in partitions3)
					{
						if (Operators.CompareString(mtkGptPartition3.Name, "frp", TextCompare: false) == 0)
						{
							string text3 = utils.LongToHex(mtkGptPartition3.FirstLba * MtkSparse.sectsize);
							await FormatPartition(size: utils.HexToLong(utils.LongToHex(mtkGptPartition3.SectorCount * MtkSparse.sectsize).Replace(" ", "").Replace("0x", "")), address: utils.HexToLong(text3.Replace(" ", "").Replace("0x", "")), cancelToken: cancelToken);
						}
					}
					gui.Richlog("OK", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
					gui.Richlog("- Erasing FRP : ", Color.Black);
					MtkGptPartition[] partitions4 = gpt.Partitions;
					foreach (MtkGptPartition mtkGptPartition4 in partitions4)
					{
						if (Operators.CompareString(mtkGptPartition4.Name, "proinfo", TextCompare: false) == 0)
						{
							await WritePartition(folderwrite + "SEC1", mtkGptPartition4.FirstLba * MtkSparse.sectsize, mtkGptPartition4.SectorCount * MtkSparse.sectsize, cancelToken);
							break;
						}
					}
					gui.Richlog("OK", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
					gui.Richlog("- Reboot Device : ", Color.Black);
					Form1.SharedUI.ProgressBar1.Text = "Rebooting...";
					await MtkDaxUploadBootService.RebootAsync(uploadResult.Device, cancelToken);
					gui.Richlog("OK", Color.FromArgb(0, 85, 207));
					closingport2();
				}
				else
				{
					gui.Richlog("Failed", Color.Red);
				}
				gui.Richlog("- Erasing MDM : ", Color.Black);
				Form1.SharedUI.ProgressBar1.Text = "Erasing...";
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				gui.Richlog("Failed", Color.Red);
				closingport();
				ProjectData.ClearProjectError();
			}
		}
	}

	public static async Task FormatUserdataFRP(CancellationToken cancelToken = default(CancellationToken))
	{
		checked
		{
			try
			{
				if (Operators.CompareString(CHECK, "no", TextCompare: false) == 0)
				{
					return;
				}
				cancelToken.ThrowIfCancellationRequested();
				await ReadGPT(cancelToken, showlist: false);
				gui.Richlog("- Erasing Userdata : ", Color.Black);
				Form1.SharedUI.ProgressBar1.Text = "Erasing...";
				if (gpt.Partitions.Length > 0)
				{
					MtkGptPartition[] partitions = gpt.Partitions;
					foreach (MtkGptPartition mtkGptPartition in partitions)
					{
						if (Operators.CompareString(mtkGptPartition.Name, "userdata", TextCompare: false) == 0)
						{
							string text = utils.LongToHex(mtkGptPartition.FirstLba * MtkSparse.sectsize);
							await FormatPartition(size: utils.HexToLong(utils.LongToHex(mtkGptPartition.SectorCount * MtkSparse.sectsize).Replace(" ", "").Replace("0x", "")), address: utils.HexToLong(text.Replace(" ", "").Replace("0x", "")), cancelToken: cancelToken);
						}
					}
					gui.Richlog("OK", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
					gui.Richlog("- Erasing FRP Data : ", Color.Black);
					MtkGptPartition[] partitions2 = gpt.Partitions;
					foreach (MtkGptPartition mtkGptPartition2 in partitions2)
					{
						if (Operators.CompareString(mtkGptPartition2.Name, "frp", TextCompare: false) == 0)
						{
							string text2 = utils.LongToHex(mtkGptPartition2.FirstLba * MtkSparse.sectsize);
							await FormatPartition(size: utils.HexToLong(utils.LongToHex(mtkGptPartition2.SectorCount * MtkSparse.sectsize).Replace(" ", "").Replace("0x", "")), address: utils.HexToLong(text2.Replace(" ", "").Replace("0x", "")), cancelToken: cancelToken);
						}
						if (Operators.CompareString(mtkGptPartition2.Name, "persistent", TextCompare: false) == 0)
						{
							string text3 = utils.LongToHex(mtkGptPartition2.FirstLba * MtkSparse.sectsize);
							await FormatPartition(size: utils.HexToLong(utils.LongToHex(mtkGptPartition2.SectorCount * MtkSparse.sectsize).Replace(" ", "").Replace("0x", "")), address: utils.HexToLong(text3.Replace(" ", "").Replace("0x", "")), cancelToken: cancelToken);
						}
					}
					gui.Richlog("OK", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
					gui.Richlog("- Reboot Device : ", Color.Black);
					Form1.SharedUI.ProgressBar1.Text = "Rebooting...";
					await MtkDaxUploadBootService.RebootAsync(uploadResult.Device, cancelToken);
					gui.Richlog("OK", Color.FromArgb(0, 85, 207));
					closingport2();
				}
				else
				{
					gui.Richlog("Failed", Color.Red);
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				gui.Richlog("Failed", Color.Red);
				closingport();
				ProjectData.ClearProjectError();
			}
		}
	}

	public static async Task Formatseva(string folderwrite, CancellationToken cancelToken = default(CancellationToken))
	{
		checked
		{
			try
			{
				if (Operators.CompareString(CHECK, "no", TextCompare: false) == 0)
				{
					return;
				}
				cancelToken.ThrowIfCancellationRequested();
				await ReadGPT(cancelToken, showlist: false);
				gui.Richlog("- Wipe Data [Safe] : ", Color.Black);
				Form1.SharedUI.ProgressBar1.Text = "Erasing...";
				if (gpt.Partitions.Length > 0)
				{
					if (Operators.CompareString(storagetype, "ufs", TextCompare: false) == 0)
					{
						MtkGptPartition[] partitions = gpt.Partitions;
						foreach (MtkGptPartition mtkGptPartition in partitions)
						{
							if (Operators.CompareString(mtkGptPartition.Name, "para", TextCompare: false) == 0)
							{
								await WritePartition(folderwrite + "SECUFS", mtkGptPartition.FirstLba * MtkSparse.sectsize, mtkGptPartition.SectorCount * MtkSparse.sectsize, cancelToken);
								break;
							}
						}
					}
					else
					{
						MtkGptPartition[] partitions2 = gpt.Partitions;
						foreach (MtkGptPartition mtkGptPartition2 in partitions2)
						{
							if (Operators.CompareString(mtkGptPartition2.Name, "para", TextCompare: false) == 0)
							{
								await WritePartition(folderwrite + "SECEMMC", mtkGptPartition2.FirstLba * MtkSparse.sectsize, mtkGptPartition2.SectorCount * MtkSparse.sectsize, cancelToken);
								break;
							}
						}
					}
					gui.Richlog("OK", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
					gui.Richlog("- Erasing FRP Data : ", Color.Black);
					MtkGptPartition[] partitions3 = gpt.Partitions;
					foreach (MtkGptPartition mtkGptPartition3 in partitions3)
					{
						if (Operators.CompareString(mtkGptPartition3.Name, "frp", TextCompare: false) == 0)
						{
							string text = utils.LongToHex(mtkGptPartition3.FirstLba * MtkSparse.sectsize);
							await FormatPartition(size: utils.HexToLong(utils.LongToHex(mtkGptPartition3.SectorCount * MtkSparse.sectsize).Replace(" ", "").Replace("0x", "")), address: utils.HexToLong(text.Replace(" ", "").Replace("0x", "")), cancelToken: cancelToken);
						}
						if (Operators.CompareString(mtkGptPartition3.Name, "persistent", TextCompare: false) == 0)
						{
							string text2 = utils.LongToHex(mtkGptPartition3.FirstLba * MtkSparse.sectsize);
							await FormatPartition(size: utils.HexToLong(utils.LongToHex(mtkGptPartition3.SectorCount * MtkSparse.sectsize).Replace(" ", "").Replace("0x", "")), address: utils.HexToLong(text2.Replace(" ", "").Replace("0x", "")), cancelToken: cancelToken);
						}
					}
					gui.Richlog("OK", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
					gui.Richlog("- Reboot Device : ", Color.Black);
					Form1.SharedUI.ProgressBar1.Text = "Rebooting...";
					await MtkDaxUploadBootService.RebootAsync(uploadResult.Device, cancelToken);
					gui.Richlog("OK", Color.FromArgb(0, 85, 207));
					closingport2();
				}
				else
				{
					gui.Richlog("Failed", Color.Red);
					gui.Richlog("- Reboot Device : ", Color.Black);
					Form1.SharedUI.ProgressBar1.Text = "Rebooting...";
					await MtkDaxUploadBootService.RebootAsync(uploadResult.Device, cancelToken);
					gui.Richlog("OK", Color.FromArgb(0, 85, 207));
					closingport2();
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				gui.Richlog("Failed", Color.Red);
				closingport();
				ProjectData.ClearProjectError();
			}
		}
	}

	public static async Task EraseFRP(CancellationToken cancelToken = default(CancellationToken))
	{
		checked
		{
			try
			{
				if (Operators.CompareString(CHECK, "no", TextCompare: false) == 0)
				{
					return;
				}
				cancelToken.ThrowIfCancellationRequested();
				await ReadGPT(cancelToken, showlist: false);
				gui.Richlog("- Remove FRP : ", Color.Black);
				Form1.SharedUI.ProgressBar1.Text = "Erasing...";
				if (gpt.Partitions.Length > 0)
				{
					MtkGptPartition[] partitions = gpt.Partitions;
					foreach (MtkGptPartition mtkGptPartition in partitions)
					{
						if (Operators.CompareString(mtkGptPartition.Name, "frp", TextCompare: false) == 0)
						{
							string text = utils.LongToHex(mtkGptPartition.FirstLba * MtkSparse.sectsize);
							await FormatPartition(size: utils.HexToLong(utils.LongToHex(mtkGptPartition.SectorCount * MtkSparse.sectsize).Replace(" ", "").Replace("0x", "")), address: utils.HexToLong(text.Replace(" ", "").Replace("0x", "")), cancelToken: cancelToken);
						}
						if (Operators.CompareString(mtkGptPartition.Name, "persistent", TextCompare: false) == 0)
						{
							string text2 = utils.LongToHex(mtkGptPartition.FirstLba * MtkSparse.sectsize);
							await FormatPartition(size: utils.HexToLong(utils.LongToHex(mtkGptPartition.SectorCount * MtkSparse.sectsize).Replace(" ", "").Replace("0x", "")), address: utils.HexToLong(text2.Replace(" ", "").Replace("0x", "")), cancelToken: cancelToken);
						}
					}
					MtkGptPartition[] partitions2 = gpt.Partitions;
					foreach (MtkGptPartition mtkGptPartition2 in partitions2)
					{
						if (Operators.CompareString(mtkGptPartition2.Name, "persistent", TextCompare: false) == 0)
						{
							string text3 = utils.LongToHex(mtkGptPartition2.FirstLba * MtkSparse.sectsize);
							await FormatPartition(size: utils.HexToLong(utils.LongToHex(mtkGptPartition2.SectorCount * MtkSparse.sectsize).Replace(" ", "").Replace("0x", "")), address: utils.HexToLong(text3.Replace(" ", "").Replace("0x", "")), cancelToken: cancelToken);
						}
					}
					MtkGptPartition[] partitions3 = gpt.Partitions;
					foreach (MtkGptPartition mtkGptPartition3 in partitions3)
					{
						if (Operators.CompareString(mtkGptPartition3.Name, "persistent", TextCompare: false) == 0)
						{
							string text4 = utils.LongToHex(mtkGptPartition3.FirstLba * MtkSparse.sectsize);
							await FormatPartition(size: utils.HexToLong(utils.LongToHex(mtkGptPartition3.SectorCount * MtkSparse.sectsize).Replace(" ", "").Replace("0x", "")), address: utils.HexToLong(text4.Replace(" ", "").Replace("0x", "")), cancelToken: cancelToken);
						}
					}
					MtkGptPartition[] partitions4 = gpt.Partitions;
					foreach (MtkGptPartition mtkGptPartition4 in partitions4)
					{
						if (Operators.CompareString(mtkGptPartition4.Name, "persistent", TextCompare: false) == 0)
						{
							string text5 = utils.LongToHex(mtkGptPartition4.FirstLba * MtkSparse.sectsize);
							await FormatPartition(size: utils.HexToLong(utils.LongToHex(mtkGptPartition4.SectorCount * MtkSparse.sectsize).Replace(" ", "").Replace("0x", "")), address: utils.HexToLong(text5.Replace(" ", "").Replace("0x", "")), cancelToken: cancelToken);
						}
					}
					MtkGptPartition[] partitions5 = gpt.Partitions;
					foreach (MtkGptPartition mtkGptPartition5 in partitions5)
					{
						if (Operators.CompareString(mtkGptPartition5.Name, "persistent", TextCompare: false) == 0)
						{
							string text6 = utils.LongToHex(mtkGptPartition5.FirstLba * MtkSparse.sectsize);
							await FormatPartition(size: utils.HexToLong(utils.LongToHex(mtkGptPartition5.SectorCount * MtkSparse.sectsize).Replace(" ", "").Replace("0x", "")), address: utils.HexToLong(text6.Replace(" ", "").Replace("0x", "")), cancelToken: cancelToken);
						}
					}
					gui.Richlog("OK", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
					gui.Richlog("- Reboot Device : ", Color.Black);
					Form1.SharedUI.ProgressBar1.Text = "Rebooting...";
					await MtkDaxUploadBootService.RebootAsync(uploadResult.Device, cancelToken);
					gui.Richlog("OK", Color.FromArgb(0, 85, 207));
					closingport2();
				}
				else
				{
					gui.Richlog("Failed", Color.Red);
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				gui.Richlog("Failed", Color.Red);
				closingport();
				ProjectData.ClearProjectError();
			}
		}
	}

	public static async Task Erasekenox(CancellationToken cancelToken = default(CancellationToken))
	{
		checked
		{
			try
			{
				if (Operators.CompareString(CHECK, "no", TextCompare: false) == 0)
				{
					return;
				}
				cancelToken.ThrowIfCancellationRequested();
				await ReadGPT(cancelToken, showlist: false);
				gui.Richlog("- Remove KG/Knox Data Lock : ", Color.Black);
				Form1.SharedUI.ProgressBar1.Text = "Removing...";
				if (gpt.Partitions.Length > 0)
				{
					MtkGptPartition[] partitions = gpt.Partitions;
					foreach (MtkGptPartition mtkGptPartition in partitions)
					{
						if (Operators.CompareString(mtkGptPartition.Name, "sec_efs", TextCompare: false) == 0)
						{
							string text = utils.LongToHex(mtkGptPartition.FirstLba * MtkSparse.sectsize);
							await FormatPartition(size: utils.HexToLong(utils.LongToHex(mtkGptPartition.SectorCount * MtkSparse.sectsize).Replace(" ", "").Replace("0x", "")), address: utils.HexToLong(text.Replace(" ", "").Replace("0x", "")), cancelToken: cancelToken);
						}
						if (Operators.CompareString(mtkGptPartition.Name, "sec_efs", TextCompare: false) == 0)
						{
							string text2 = utils.LongToHex(mtkGptPartition.FirstLba * MtkSparse.sectsize);
							await FormatPartition(size: utils.HexToLong(utils.LongToHex(mtkGptPartition.SectorCount * MtkSparse.sectsize).Replace(" ", "").Replace("0x", "")), address: utils.HexToLong(text2.Replace(" ", "").Replace("0x", "")), cancelToken: cancelToken);
						}
					}
					MtkGptPartition[] partitions2 = gpt.Partitions;
					foreach (MtkGptPartition mtkGptPartition2 in partitions2)
					{
						if (Operators.CompareString(mtkGptPartition2.Name, "sec_efs", TextCompare: false) == 0)
						{
							string text3 = utils.LongToHex(mtkGptPartition2.FirstLba * MtkSparse.sectsize);
							await FormatPartition(size: utils.HexToLong(utils.LongToHex(mtkGptPartition2.SectorCount * MtkSparse.sectsize).Replace(" ", "").Replace("0x", "")), address: utils.HexToLong(text3.Replace(" ", "").Replace("0x", "")), cancelToken: cancelToken);
						}
					}
					MtkGptPartition[] partitions3 = gpt.Partitions;
					foreach (MtkGptPartition mtkGptPartition3 in partitions3)
					{
						if (Operators.CompareString(mtkGptPartition3.Name, "sec_efs", TextCompare: false) == 0)
						{
							string text4 = utils.LongToHex(mtkGptPartition3.FirstLba * MtkSparse.sectsize);
							await FormatPartition(size: utils.HexToLong(utils.LongToHex(mtkGptPartition3.SectorCount * MtkSparse.sectsize).Replace(" ", "").Replace("0x", "")), address: utils.HexToLong(text4.Replace(" ", "").Replace("0x", "")), cancelToken: cancelToken);
						}
					}
					MtkGptPartition[] partitions4 = gpt.Partitions;
					foreach (MtkGptPartition mtkGptPartition4 in partitions4)
					{
						if (Operators.CompareString(mtkGptPartition4.Name, "sec_efs", TextCompare: false) == 0)
						{
							string text5 = utils.LongToHex(mtkGptPartition4.FirstLba * MtkSparse.sectsize);
							await FormatPartition(size: utils.HexToLong(utils.LongToHex(mtkGptPartition4.SectorCount * MtkSparse.sectsize).Replace(" ", "").Replace("0x", "")), address: utils.HexToLong(text5.Replace(" ", "").Replace("0x", "")), cancelToken: cancelToken);
						}
					}
					gui.Richlog("OK", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
					gui.Richlog("- Reboot Device : ", Color.Black);
					Form1.SharedUI.ProgressBar1.Text = "Rebooting...";
					await MtkDaxUploadBootService.RebootAsync(uploadResult.Device, cancelToken);
					gui.Richlog("OK", Color.FromArgb(0, 85, 207));
					closingport2();
				}
				else
				{
					gui.Richlog("Failed", Color.Red);
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				gui.Richlog("Failed", Color.Red);
				closingport();
				ProjectData.ClearProjectError();
			}
		}
	}

	public static async Task EraseMI(CancellationToken cancelToken = default(CancellationToken))
	{
		checked
		{
			try
			{
				if (Operators.CompareString(CHECK, "no", TextCompare: false) == 0)
				{
					return;
				}
				cancelToken.ThrowIfCancellationRequested();
				await ReadGPT(cancelToken, showlist: false);
				gui.Richlog("- Remove Mi Acouunt : ", Color.Black);
				Form1.SharedUI.ProgressBar1.Text = "Erasing...";
				if (gpt.Partitions.Length > 0)
				{
					MtkGptPartition[] partitions = gpt.Partitions;
					foreach (MtkGptPartition mtkGptPartition in partitions)
					{
						if (Operators.CompareString(mtkGptPartition.Name, "persist", TextCompare: false) == 0)
						{
							string text = utils.LongToHex(mtkGptPartition.FirstLba * MtkSparse.sectsize);
							await FormatPartition(size: utils.HexToLong(utils.LongToHex(mtkGptPartition.SectorCount * MtkSparse.sectsize).Replace(" ", "").Replace("0x", "")), address: utils.HexToLong(text.Replace(" ", "").Replace("0x", "")), cancelToken: cancelToken);
						}
					}
					gui.Richlog("OK", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
					gui.Richlog("- Reboot Device : ", Color.Black);
					Form1.SharedUI.ProgressBar1.Text = "Rebooting...";
					await MtkDaxUploadBootService.RebootAsync(uploadResult.Device, cancelToken);
					gui.Richlog("OK", Color.FromArgb(0, 85, 207));
					closingport2();
				}
				else
				{
					gui.Richlog("Failed", Color.Red);
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				gui.Richlog("Failed", Color.Red);
				closingport();
				ProjectData.ClearProjectError();
			}
		}
	}

	public static async Task EraseDEMO(CancellationToken cancelToken = default(CancellationToken))
	{
		checked
		{
			try
			{
				if (Operators.CompareString(CHECK, "no", TextCompare: false) == 0)
				{
					return;
				}
				cancelToken.ThrowIfCancellationRequested();
				await ReadGPT(cancelToken, showlist: false);
				gui.Richlog("- Remove Demo : ", Color.Black);
				Form1.SharedUI.ProgressBar1.Text = "Erasing...";
				if (gpt.Partitions.Length > 0)
				{
					MtkGptPartition[] partitions = gpt.Partitions;
					foreach (MtkGptPartition mtkGptPartition in partitions)
					{
						if (Operators.CompareString(mtkGptPartition.Name, "backup", TextCompare: false) == 0)
						{
							string text = utils.LongToHex(mtkGptPartition.FirstLba * MtkSparse.sectsize);
							await FormatPartition(size: utils.HexToLong(utils.LongToHex(mtkGptPartition.SectorCount * MtkSparse.sectsize).Replace(" ", "").Replace("0x", "")), address: utils.HexToLong(text.Replace(" ", "").Replace("0x", "")), cancelToken: cancelToken);
						}
						if (Operators.CompareString(mtkGptPartition.Name, "ADF", TextCompare: false) == 0)
						{
							string text2 = utils.LongToHex(mtkGptPartition.FirstLba * MtkSparse.sectsize);
							await FormatPartition(size: utils.HexToLong(utils.LongToHex(mtkGptPartition.SectorCount * MtkSparse.sectsize).Replace(" ", "").Replace("0x", "")), address: utils.HexToLong(text2.Replace(" ", "").Replace("0x", "")), cancelToken: cancelToken);
						}
					}
					gui.Richlog("OK", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
					gui.Richlog("- Reboot Device : ", Color.Black);
					Form1.SharedUI.ProgressBar1.Text = "Rebooting...";
					await MtkDaxUploadBootService.RebootAsync(uploadResult.Device, cancelToken);
					gui.Richlog("OK", Color.FromArgb(0, 85, 207));
					closingport2();
				}
				else
				{
					gui.Richlog("Failed", Color.Red);
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				gui.Richlog("Failed", Color.Red);
				closingport();
				ProjectData.ClearProjectError();
			}
		}
	}

	public static async Task EraseID(CancellationToken cancelToken = default(CancellationToken))
	{
		checked
		{
			try
			{
				if (Operators.CompareString(CHECK, "no", TextCompare: false) == 0)
				{
					return;
				}
				cancelToken.ThrowIfCancellationRequested();
				await ReadGPT(cancelToken, showlist: false);
				gui.Richlog("- Remove ID : ", Color.Black);
				Form1.SharedUI.ProgressBar1.Text = "Erasing...";
				if (gpt.Partitions.Length > 0)
				{
					MtkGptPartition[] partitions = gpt.Partitions;
					foreach (MtkGptPartition mtkGptPartition in partitions)
					{
						if (Operators.CompareString(mtkGptPartition.Name, "oeminfo", TextCompare: false) == 0)
						{
							string text = utils.LongToHex(mtkGptPartition.FirstLba * MtkSparse.sectsize);
							await FormatPartition(size: utils.HexToLong(utils.LongToHex(mtkGptPartition.SectorCount * MtkSparse.sectsize).Replace(" ", "").Replace("0x", "")), address: utils.HexToLong(text.Replace(" ", "").Replace("0x", "")), cancelToken: cancelToken);
						}
					}
					gui.Richlog("OK", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
					gui.Richlog("- Reboot Device : ", Color.Black);
					Form1.SharedUI.ProgressBar1.Text = "Rebooting...";
					await MtkDaxUploadBootService.RebootAsync(uploadResult.Device, cancelToken);
					gui.Richlog("OK", Color.FromArgb(0, 85, 207));
					closingport2();
				}
				else
				{
					gui.Richlog("Failed", Color.Red);
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				gui.Richlog("Failed", Color.Red);
				closingport();
				ProjectData.ClearProjectError();
			}
		}
	}

	public static async Task Check_Show_Change_Log_1(string folder, CancellationToken cancelToken = default(CancellationToken))
	{
		checked
		{
			try
			{
				if (Operators.CompareString(CHECK, "no", TextCompare: false) == 0)
				{
					return;
				}
				cancelToken.ThrowIfCancellationRequested();
				await ReadGPT(cancelToken, showlist: false);
				Form1.SharedUI.ProgressBar4.Text = "0%";
				Form1.SharedUI.ProgressBar4.Value = 0;
				SerialCOM.MSL = "ENREAD";
				gui.Richlog("- Reading Security : ", Color.Black);
				if (gpt.Partitions.Length > 0)
				{
					MtkGptPartition[] partitions = gpt.Partitions;
					foreach (MtkGptPartition mtkGptPartition in partitions)
					{
						if (Operators.CompareString(mtkGptPartition.Name, "nvram", TextCompare: false) == 0)
						{
							await WritePartition(folder + "SEC5", mtkGptPartition.FirstLba * MtkSparse.sectsize, mtkGptPartition.SectorCount * MtkSparse.sectsize, cancelToken);
							break;
						}
					}
					MtkGptPartition[] partitions2 = gpt.Partitions;
					foreach (MtkGptPartition mtkGptPartition2 in partitions2)
					{
						if (Operators.CompareString(mtkGptPartition2.Name, "nvdata", TextCompare: false) == 0)
						{
							await WritePartition(folder + "SEC4", mtkGptPartition2.FirstLba * MtkSparse.sectsize, mtkGptPartition2.SectorCount * MtkSparse.sectsize, cancelToken);
							break;
						}
					}
					MtkGptPartition[] partitions3 = gpt.Partitions;
					foreach (MtkGptPartition mtkGptPartition3 in partitions3)
					{
						if (Operators.CompareString(mtkGptPartition3.Name, "md1img_a", TextCompare: false) == 0)
						{
							await WritePartition(folder + "SEC2", mtkGptPartition3.FirstLba * MtkSparse.sectsize, mtkGptPartition3.SectorCount * MtkSparse.sectsize, cancelToken);
							break;
						}
					}
					MtkGptPartition[] partitions4 = gpt.Partitions;
					foreach (MtkGptPartition mtkGptPartition4 in partitions4)
					{
						if (Operators.CompareString(mtkGptPartition4.Name, "md1img_b", TextCompare: false) == 0)
						{
							await WritePartition(folder + "SEC3", mtkGptPartition4.FirstLba * MtkSparse.sectsize, mtkGptPartition4.SectorCount * MtkSparse.sectsize, cancelToken);
							break;
						}
					}
					MtkGptPartition[] partitions5 = gpt.Partitions;
					foreach (MtkGptPartition mtkGptPartition5 in partitions5)
					{
						if (Operators.CompareString(mtkGptPartition5.Name, "carrier", TextCompare: false) == 0)
						{
							await WritePartition(folder + "SEC1", mtkGptPartition5.FirstLba * MtkSparse.sectsize, mtkGptPartition5.SectorCount * MtkSparse.sectsize, cancelToken);
							break;
						}
					}
				}
				Form1.SharedUI.ProgressBar4.Value = 100;
				SerialCOM.MSL = "DISREAD";
				Form1.SharedUI.ProgressBar4.Text = "0%";
				Form1.SharedUI.ProgressBar4.Value = 0;
				gui.Richlog("OK", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
				gui.Richlog("- Calculate Security : ", Color.Black);
				Form1.SharedUI.ProgressBar1.Text = "Calculateing..";
				gui.Richlog("OK", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
				gui.Richlog("- Unlock Network : ", Color.Black);
				gui.Richlog("OK", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
				gui.Richlog("- Verfing SimLock : ", Color.Black);
				Form1.SharedUI.ProgressBar1.Text = "Verfing...";
				gui.Richlog("Unlocked", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
				gui.Richlog("- Reboot Device : ", Color.Black);
				Form1.SharedUI.ProgressBar1.Text = "Rebooting...";
				await MtkDaxUploadBootService.RebootAsync(uploadResult.Device, cancelToken);
				gui.Richlog("OK", Color.FromArgb(0, 85, 207));
				closingport2();
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				gui.Richlog("Failed", Color.Red);
				closingport();
				ProjectData.ClearProjectError();
			}
		}
	}

	public static async Task Data_Update(string folder, CancellationToken cancelToken = default(CancellationToken))
	{
		try
		{
			if (Operators.CompareString(CHECK, "no", TextCompare: false) != 0)
			{
				cancelToken.ThrowIfCancellationRequested();
				await ReadGPT(cancelToken, showlist: false);
				Form1.SharedUI.ProgressBar4.Text = "0%";
				Form1.SharedUI.ProgressBar4.Value = 0;
				SerialCOM.MSL = "ENREAD";
				gui.Richlog("- Write CSC File : ", Color.Black);
				await MtkCustomWrite.writeByPartitionName(uploadResult.Device, uploadResult.FlashInfo, "ftm", folder + "SEC1", cancelToken);
				await MtkCustomWrite.writeByPartitionName(uploadResult.Device, uploadResult.FlashInfo, "misc2", folder + "SEC2", cancelToken);
				Form1.SharedUI.ProgressBar4.Value = 100;
				SerialCOM.MSL = "DISREAD";
				Form1.SharedUI.ProgressBar4.Text = "0%";
				Form1.SharedUI.ProgressBar4.Value = 0;
				gui.Richlog("OK", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
				gui.Richlog("- Reboot Device : ", Color.Black);
				Form1.SharedUI.ProgressBar1.Text = "Rebooting...";
				await MtkDaxUploadBootService.RebootAsync(uploadResult.Device, cancelToken);
				gui.Richlog("OK", Color.FromArgb(0, 85, 207));
				closingport2();
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			gui.Richlog("Failed", Color.Red);
			closingport();
			ProjectData.ClearProjectError();
		}
	}

	public static async Task Data_Update_ChangLog(string folderBA, CancellationToken cancelToken = default(CancellationToken))
	{
		checked
		{
			try
			{
				if (Operators.CompareString(CHECK, "no", TextCompare: false) == 0)
				{
					return;
				}
				cancelToken.ThrowIfCancellationRequested();
				await ReadGPT(cancelToken, showlist: false);
				Form1.SharedUI.ProgressBar4.Text = "0%";
				Form1.SharedUI.ProgressBar4.Value = 0;
				SerialCOM.MSL = "ENREAD";
				if (!File.Exists(folderBA + "SEC1"))
				{
					gui.Richlog("- Reading Security : ", Color.Black);
					if (gpt.Partitions.Length > 0)
					{
						MtkGptPartition[] partitions = gpt.Partitions;
						foreach (MtkGptPartition mtkGptPartition in partitions)
						{
							if (Operators.CompareString(mtkGptPartition.Name, "nvdata", TextCompare: false) == 0)
							{
								string text = utils.LongToHex(mtkGptPartition.FirstLba * MtkSparse.sectsize);
								string text2 = utils.LongToHex(mtkGptPartition.SectorCount * MtkSparse.sectsize);
								await ReadPartition(mtkGptPartition.Name, folderBA, "SEC1", utils.HexToLong(text.Replace(" ", "").Replace("0x", "")), utils.HexToLong(text2.Replace(" ", "").Replace("0x", "")), cancelToken);
								break;
							}
						}
						MtkGptPartition[] partitions2 = gpt.Partitions;
						foreach (MtkGptPartition mtkGptPartition2 in partitions2)
						{
							if (Operators.CompareString(mtkGptPartition2.Name, "nvram", TextCompare: false) == 0)
							{
								string text3 = utils.LongToHex(mtkGptPartition2.FirstLba * MtkSparse.sectsize);
								string text4 = utils.LongToHex(mtkGptPartition2.SectorCount * MtkSparse.sectsize);
								await ReadPartition(mtkGptPartition2.Name, folderBA, "SEC2", utils.HexToLong(text3.Replace(" ", "").Replace("0x", "")), utils.HexToLong(text4.Replace(" ", "").Replace("0x", "")), cancelToken);
								break;
							}
						}
						MtkGptPartition[] partitions3 = gpt.Partitions;
						foreach (MtkGptPartition mtkGptPartition3 in partitions3)
						{
							if (Operators.CompareString(mtkGptPartition3.Name, "protect1", TextCompare: false) == 0)
							{
								string text5 = utils.LongToHex(mtkGptPartition3.FirstLba * MtkSparse.sectsize);
								string text6 = utils.LongToHex(mtkGptPartition3.SectorCount * MtkSparse.sectsize);
								await ReadPartition(mtkGptPartition3.Name, folderBA, "SEC3", utils.HexToLong(text5.Replace(" ", "").Replace("0x", "")), utils.HexToLong(text6.Replace(" ", "").Replace("0x", "")), cancelToken);
								break;
							}
						}
						MtkGptPartition[] partitions4 = gpt.Partitions;
						foreach (MtkGptPartition mtkGptPartition4 in partitions4)
						{
							if (Operators.CompareString(mtkGptPartition4.Name, "protect2", TextCompare: false) == 0)
							{
								string text7 = utils.LongToHex(mtkGptPartition4.FirstLba * MtkSparse.sectsize);
								string text8 = utils.LongToHex(mtkGptPartition4.SectorCount * MtkSparse.sectsize);
								await ReadPartition(mtkGptPartition4.Name, folderBA, "SEC4", utils.HexToLong(text7.Replace(" ", "").Replace("0x", "")), utils.HexToLong(text8.Replace(" ", "").Replace("0x", "")), cancelToken);
								break;
							}
						}
					}
					await Task.Delay(TimeSpan.FromSeconds(1.0));
					gui.Richlog("OK", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
				}
				gui.Richlog("- Unlock Network : ", Color.Black);
				if (gpt.Partitions.Length > 0)
				{
					MtkGptPartition[] partitions5 = gpt.Partitions;
					foreach (MtkGptPartition mtkGptPartition5 in partitions5)
					{
						if (Operators.CompareString(mtkGptPartition5.Name, "nvdata", TextCompare: false) == 0)
						{
							string text9 = utils.LongToHex(mtkGptPartition5.FirstLba * MtkSparse.sectsize);
							await FormatPartition(size: utils.HexToLong(utils.LongToHex(mtkGptPartition5.SectorCount * MtkSparse.sectsize).Replace(" ", "").Replace("0x", "")), address: utils.HexToLong(text9.Replace(" ", "").Replace("0x", "")), cancelToken: cancelToken);
						}
						if (Operators.CompareString(mtkGptPartition5.Name, "nvram", TextCompare: false) == 0)
						{
							string text10 = utils.LongToHex(mtkGptPartition5.FirstLba * MtkSparse.sectsize);
							await FormatPartition(size: utils.HexToLong(utils.LongToHex(mtkGptPartition5.SectorCount * MtkSparse.sectsize).Replace(" ", "").Replace("0x", "")), address: utils.HexToLong(text10.Replace(" ", "").Replace("0x", "")), cancelToken: cancelToken);
						}
						if (Operators.CompareString(mtkGptPartition5.Name, "protect1", TextCompare: false) == 0)
						{
							string text11 = utils.LongToHex(mtkGptPartition5.FirstLba * MtkSparse.sectsize);
							await FormatPartition(size: utils.HexToLong(utils.LongToHex(mtkGptPartition5.SectorCount * MtkSparse.sectsize).Replace(" ", "").Replace("0x", "")), address: utils.HexToLong(text11.Replace(" ", "").Replace("0x", "")), cancelToken: cancelToken);
						}
						if (Operators.CompareString(mtkGptPartition5.Name, "protect2", TextCompare: false) == 0)
						{
							string text12 = utils.LongToHex(mtkGptPartition5.FirstLba * MtkSparse.sectsize);
							await FormatPartition(size: utils.HexToLong(utils.LongToHex(mtkGptPartition5.SectorCount * MtkSparse.sectsize).Replace(" ", "").Replace("0x", "")), address: utils.HexToLong(text12.Replace(" ", "").Replace("0x", "")), cancelToken: cancelToken);
						}
					}
				}
				Form1.SharedUI.ProgressBar4.Value = 100;
				SerialCOM.MSL = "DISREAD";
				Form1.SharedUI.ProgressBar4.Text = "0%";
				Form1.SharedUI.ProgressBar4.Value = 0;
				gui.Richlog("OK", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
				gui.Richlog("- Verfing SimLock : ", Color.Black);
				Form1.SharedUI.ProgressBar1.Text = "Verfing...";
				gui.Richlog("Unlocked", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
				gui.Richlog("- Reboot Device : ", Color.Black);
				Form1.SharedUI.ProgressBar1.Text = "Rebooting...";
				await MtkDaxUploadBootService.RebootAsync(uploadResult.Device, cancelToken);
				gui.Richlog("OK", Color.FromArgb(0, 85, 207));
				closingport2();
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				gui.Richlog("Failed", Color.Red);
				closingport();
				ProjectData.ClearProjectError();
			}
		}
	}

	public static async Task portNameSettings(string folderwrite, CancellationToken cancelToken = default(CancellationToken))
	{
		checked
		{
			try
			{
				if (Operators.CompareString(CHECK, "no", TextCompare: false) == 0)
				{
					return;
				}
				cancelToken.ThrowIfCancellationRequested();
				await ReadGPT(cancelToken, showlist: false);
				Form1.SharedUI.ProgressBar4.Text = "0%";
				Form1.SharedUI.ProgressBar4.Value = 0;
				SerialCOM.MSL = "ENREAD";
				gui.Richlog("- Writing Security : ", Color.Black);
				if (gpt.Partitions.Length > 0)
				{
					MtkGptPartition[] partitions = gpt.Partitions;
					foreach (MtkGptPartition mtkGptPartition in partitions)
					{
						if (Operators.CompareString(mtkGptPartition.Name, "nvdata", TextCompare: false) == 0)
						{
							await WritePartition(folderwrite + "SEC1", mtkGptPartition.FirstLba * MtkSparse.sectsize, mtkGptPartition.SectorCount * MtkSparse.sectsize, cancelToken);
							break;
						}
					}
					MtkGptPartition[] partitions2 = gpt.Partitions;
					foreach (MtkGptPartition mtkGptPartition2 in partitions2)
					{
						if (Operators.CompareString(mtkGptPartition2.Name, "nvram", TextCompare: false) == 0)
						{
							await WritePartition(folderwrite + "SEC2", mtkGptPartition2.FirstLba * MtkSparse.sectsize, mtkGptPartition2.SectorCount * MtkSparse.sectsize, cancelToken);
							break;
						}
					}
					MtkGptPartition[] partitions3 = gpt.Partitions;
					foreach (MtkGptPartition mtkGptPartition3 in partitions3)
					{
						if (Operators.CompareString(mtkGptPartition3.Name, "protect1", TextCompare: false) == 0)
						{
							await WritePartition(folderwrite + "SEC3", mtkGptPartition3.FirstLba * MtkSparse.sectsize, mtkGptPartition3.SectorCount * MtkSparse.sectsize, cancelToken);
							break;
						}
					}
					MtkGptPartition[] partitions4 = gpt.Partitions;
					foreach (MtkGptPartition mtkGptPartition4 in partitions4)
					{
						if (Operators.CompareString(mtkGptPartition4.Name, "protect2", TextCompare: false) == 0)
						{
							await WritePartition(folderwrite + "SEC4", mtkGptPartition4.FirstLba * MtkSparse.sectsize, mtkGptPartition4.SectorCount * MtkSparse.sectsize, cancelToken);
							break;
						}
					}
				}
				Form1.SharedUI.ProgressBar4.Value = 100;
				SerialCOM.MSL = "DISREAD";
				Form1.SharedUI.ProgressBar4.Text = "0%";
				Form1.SharedUI.ProgressBar4.Value = 0;
				gui.Richlog("OK", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
				gui.Richlog("- Reboot Device : ", Color.Black);
				Form1.SharedUI.ProgressBar1.Text = "Rebooting...";
				await MtkDaxUploadBootService.RebootAsync(uploadResult.Device, cancelToken);
				gui.Richlog("OK", Color.FromArgb(0, 85, 207));
				closingport2();
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				gui.Richlog("Failed", Color.Red);
				closingport();
				ProjectData.ClearProjectError();
			}
		}
	}

	public static async Task MethodD_5(string folderbackup, string folderwrite, CancellationToken cancelToken = default(CancellationToken))
	{
		checked
		{
			try
			{
				if (Operators.CompareString(CHECK, "no", TextCompare: false) == 0)
				{
					return;
				}
				cancelToken.ThrowIfCancellationRequested();
				await ReadGPT(cancelToken, showlist: false);
				Form1.SharedUI.ProgressBar4.Text = "0%";
				Form1.SharedUI.ProgressBar4.Value = 0;
				SerialCOM.MSL = "ENREAD";
				if (!File.Exists(folderbackup + "SEC3"))
				{
					gui.Richlog("- Reading Security : ", Color.Black);
					if (gpt.Partitions.Length > 0)
					{
						MtkGptPartition[] partitions = gpt.Partitions;
						foreach (MtkGptPartition mtkGptPartition in partitions)
						{
							if (Operators.CompareString(mtkGptPartition.Name, "efs", TextCompare: false) == 0)
							{
								string text = utils.LongToHex(mtkGptPartition.FirstLba * MtkSparse.sectsize);
								string text2 = utils.LongToHex(mtkGptPartition.SectorCount * MtkSparse.sectsize);
								await ReadPartition(mtkGptPartition.Name, folderbackup, "SEC1", utils.HexToLong(text.Replace(" ", "").Replace("0x", "")), utils.HexToLong(text2.Replace(" ", "").Replace("0x", "")), cancelToken);
								break;
							}
						}
						MtkGptPartition[] partitions2 = gpt.Partitions;
						foreach (MtkGptPartition mtkGptPartition2 in partitions2)
						{
							if (Operators.CompareString(mtkGptPartition2.Name, "param", TextCompare: false) == 0)
							{
								string text3 = utils.LongToHex(mtkGptPartition2.FirstLba * MtkSparse.sectsize);
								string text4 = utils.LongToHex(mtkGptPartition2.SectorCount * MtkSparse.sectsize);
								await ReadPartition(mtkGptPartition2.Name, folderbackup, "SEC2", utils.HexToLong(text3.Replace(" ", "").Replace("0x", "")), utils.HexToLong(text4.Replace(" ", "").Replace("0x", "")), cancelToken);
								break;
							}
						}
						MtkGptPartition[] partitions3 = gpt.Partitions;
						foreach (MtkGptPartition mtkGptPartition3 in partitions3)
						{
							if (Operators.CompareString(mtkGptPartition3.Name, "sec_efs", TextCompare: false) == 0)
							{
								string text5 = utils.LongToHex(mtkGptPartition3.FirstLba * MtkSparse.sectsize);
								string text6 = utils.LongToHex(mtkGptPartition3.SectorCount * MtkSparse.sectsize);
								await ReadPartition(mtkGptPartition3.Name, folderbackup, "SEC3", utils.HexToLong(text5.Replace(" ", "").Replace("0x", "")), utils.HexToLong(text6.Replace(" ", "").Replace("0x", "")), cancelToken);
								break;
							}
						}
					}
					gui.Richlog("OK", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
				}
				gui.Richlog("- Unlock Network : ", Color.Black);
				Form1.SharedUI.ProgressBar4.Text = "Calculating..";
				if (gpt.Partitions.Length > 0)
				{
					MtkGptPartition[] partitions4 = gpt.Partitions;
					foreach (MtkGptPartition mtkGptPartition4 in partitions4)
					{
						if (Operators.CompareString(mtkGptPartition4.Name, "param", TextCompare: false) == 0)
						{
							await WritePartition(folderwrite + "SEC1", mtkGptPartition4.FirstLba * MtkSparse.sectsize, mtkGptPartition4.SectorCount * MtkSparse.sectsize, cancelToken);
							break;
						}
					}
				}
				Form1.SharedUI.ProgressBar4.Value = 100;
				SerialCOM.MSL = "DISREAD";
				Form1.SharedUI.ProgressBar4.Text = "0%";
				Form1.SharedUI.ProgressBar4.Value = 0;
				gui.Richlog("OK", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
				gui.Richlog("- Verfing SimLock : ", Color.Black);
				Form1.SharedUI.ProgressBar1.Text = "Verfing...";
				gui.Richlog("Unlocked", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
				gui.Richlog("- Reboot Device : ", Color.Black);
				Form1.SharedUI.ProgressBar1.Text = "Rebooting...";
				await MtkDaxUploadBootService.RebootAsync(uploadResult.Device, cancelToken);
				gui.Richlog("OK", Color.FromArgb(0, 85, 207));
				closingport2();
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				gui.Richlog("Failed", Color.Red);
				closingport();
				ProjectData.ClearProjectError();
			}
		}
	}

	public static async Task MethodD_6(string folderbackup, CancellationToken cancelToken = default(CancellationToken))
	{
		checked
		{
			try
			{
				if (Operators.CompareString(CHECK, "no", TextCompare: false) == 0)
				{
					return;
				}
				cancelToken.ThrowIfCancellationRequested();
				await ReadGPT(cancelToken, showlist: false);
				Form1.SharedUI.ProgressBar4.Text = "0%";
				Form1.SharedUI.ProgressBar4.Value = 0;
				SerialCOM.MSL = "ENREAD";
				gui.Richlog("- Writing Security : ", Color.Black);
				if (gpt.Partitions.Length > 0)
				{
					MtkGptPartition[] partitions = gpt.Partitions;
					foreach (MtkGptPartition mtkGptPartition in partitions)
					{
						if (Operators.CompareString(mtkGptPartition.Name, "efs", TextCompare: false) == 0)
						{
							await WritePartition(folderbackup + "SEC1", mtkGptPartition.FirstLba * MtkSparse.sectsize, mtkGptPartition.SectorCount * MtkSparse.sectsize, cancelToken);
							break;
						}
					}
					MtkGptPartition[] partitions2 = gpt.Partitions;
					foreach (MtkGptPartition mtkGptPartition2 in partitions2)
					{
						if (Operators.CompareString(mtkGptPartition2.Name, "param", TextCompare: false) == 0)
						{
							await WritePartition(folderbackup + "SEC2", mtkGptPartition2.FirstLba * MtkSparse.sectsize, mtkGptPartition2.SectorCount * MtkSparse.sectsize, cancelToken);
							break;
						}
					}
					MtkGptPartition[] partitions3 = gpt.Partitions;
					foreach (MtkGptPartition mtkGptPartition3 in partitions3)
					{
						if (Operators.CompareString(mtkGptPartition3.Name, "sec_efs", TextCompare: false) == 0)
						{
							await WritePartition(folderbackup + "SEC3", mtkGptPartition3.FirstLba * MtkSparse.sectsize, mtkGptPartition3.SectorCount * MtkSparse.sectsize, cancelToken);
							break;
						}
					}
				}
				Form1.SharedUI.ProgressBar4.Value = 100;
				SerialCOM.MSL = "DISREAD";
				Form1.SharedUI.ProgressBar4.Text = "0%";
				Form1.SharedUI.ProgressBar4.Value = 0;
				gui.Richlog("OK", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
				gui.Richlog("- Reboot Device : ", Color.Black);
				Form1.SharedUI.ProgressBar1.Text = "Rebooting...";
				await MtkDaxUploadBootService.RebootAsync(uploadResult.Device, cancelToken);
				gui.Richlog("OK", Color.FromArgb(0, 85, 207));
				closingport2();
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				gui.Richlog("Failed", Color.Red);
				closingport();
				ProjectData.ClearProjectError();
			}
		}
	}

	public static async Task MethodD_7(string folderbackup, string folderwrite, CancellationToken cancelToken = default(CancellationToken))
	{
		checked
		{
			try
			{
				if (Operators.CompareString(CHECK, "no", TextCompare: false) == 0)
				{
					return;
				}
				cancelToken.ThrowIfCancellationRequested();
				await ReadGPT(cancelToken, showlist: false);
				if (!File.Exists(folderbackup + "SEC2"))
				{
					Form1.SharedUI.ProgressBar4.Text = "0%";
					Form1.SharedUI.ProgressBar4.Value = 0;
					SerialCOM.MSL = "ENREAD";
					gui.Richlog("- Reading Security : ", Color.Black);
					if (gpt.Partitions.Length > 0)
					{
						MtkGptPartition[] partitions = gpt.Partitions;
						foreach (MtkGptPartition mtkGptPartition in partitions)
						{
							if (Operators.CompareString(mtkGptPartition.Name, "protect1", TextCompare: false) == 0)
							{
								string text = utils.LongToHex(mtkGptPartition.FirstLba * MtkSparse.sectsize);
								string text2 = utils.LongToHex(mtkGptPartition.SectorCount * MtkSparse.sectsize);
								await ReadPartition(mtkGptPartition.Name, folderbackup, "SEC1", utils.HexToLong(text.Replace(" ", "").Replace("0x", "")), utils.HexToLong(text2.Replace(" ", "").Replace("0x", "")), cancelToken);
								break;
							}
						}
						MtkGptPartition[] partitions2 = gpt.Partitions;
						foreach (MtkGptPartition mtkGptPartition2 in partitions2)
						{
							if (Operators.CompareString(mtkGptPartition2.Name, "protect2", TextCompare: false) == 0)
							{
								string text3 = utils.LongToHex(mtkGptPartition2.FirstLba * MtkSparse.sectsize);
								string text4 = utils.LongToHex(mtkGptPartition2.SectorCount * MtkSparse.sectsize);
								await ReadPartition(mtkGptPartition2.Name, folderbackup, "SEC2", utils.HexToLong(text3.Replace(" ", "").Replace("0x", "")), utils.HexToLong(text4.Replace(" ", "").Replace("0x", "")), cancelToken);
								break;
							}
						}
					}
					Form1.SharedUI.ProgressBar4.Value = 100;
					SerialCOM.MSL = "DISREAD";
					Form1.SharedUI.ProgressBar4.Text = "0%";
					Form1.SharedUI.ProgressBar4.Value = 0;
					gui.Richlog("OK", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
				}
				gui.Richlog("- Unlock Network : ", Color.Black);
				Form1.SharedUI.ProgressBar1.Text = "Calculating..OK";
				if (gpt.Partitions.Length > 0)
				{
					MtkGptPartition[] partitions3 = gpt.Partitions;
					foreach (MtkGptPartition mtkGptPartition3 in partitions3)
					{
						if (Operators.CompareString(mtkGptPartition3.Name, "protect1", TextCompare: false) == 0)
						{
							await WritePartition(folderwrite + "SEC1", mtkGptPartition3.FirstLba * MtkSparse.sectsize, mtkGptPartition3.SectorCount * MtkSparse.sectsize, cancelToken);
							break;
						}
					}
					MtkGptPartition[] partitions4 = gpt.Partitions;
					foreach (MtkGptPartition mtkGptPartition4 in partitions4)
					{
						if (Operators.CompareString(mtkGptPartition4.Name, "protect2", TextCompare: false) == 0)
						{
							await WritePartition(folderwrite + "SEC2", mtkGptPartition4.FirstLba * MtkSparse.sectsize, mtkGptPartition4.SectorCount * MtkSparse.sectsize, cancelToken);
							break;
						}
					}
				}
				Form1.SharedUI.ProgressBar1.Text = "Calculating..OK";
				gui.Richlog("OK", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
				gui.Richlog("- Verfing SimLock : ", Color.Black);
				Form1.SharedUI.ProgressBar1.Text = "Verfing...";
				gui.Richlog("Unlocked", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
				gui.Richlog("- Reboot Device : ", Color.Black);
				Form1.SharedUI.ProgressBar1.Text = "Rebooting...";
				await MtkDaxUploadBootService.RebootAsync(uploadResult.Device, cancelToken);
				gui.Richlog("OK", Color.FromArgb(0, 85, 207));
				closingport2();
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				gui.Richlog("Failed", Color.Red);
				closingport();
				ProjectData.ClearProjectError();
			}
		}
	}

	public static async Task MethodD_8(string folderbackup, string folderwrite, bool restor, CancellationToken cancelToken = default(CancellationToken))
	{
		checked
		{
			try
			{
				if (Operators.CompareString(CHECK, "no", TextCompare: false) == 0)
				{
					return;
				}
				cancelToken.ThrowIfCancellationRequested();
				await ReadGPT(cancelToken, showlist: false);
				if (restor)
				{
					Form1.SharedUI.ProgressBar4.Text = "0%";
					Form1.SharedUI.ProgressBar4.Value = 0;
					SerialCOM.MSL = "ENREAD";
					gui.Richlog("- Writing Security : ", Color.Black);
					if (gpt.Partitions.Length > 0)
					{
						MtkGptPartition[] partitions = gpt.Partitions;
						foreach (MtkGptPartition mtkGptPartition in partitions)
						{
							if (Operators.CompareString(mtkGptPartition.Name, "otp", TextCompare: false) == 0)
							{
								await WritePartition(folderbackup + "SEC1", mtkGptPartition.FirstLba * MtkSparse.sectsize, mtkGptPartition.SectorCount * MtkSparse.sectsize, cancelToken);
								break;
							}
						}
						MtkGptPartition[] partitions2 = gpt.Partitions;
						foreach (MtkGptPartition mtkGptPartition2 in partitions2)
						{
							if (Operators.CompareString(mtkGptPartition2.Name, "protect1", TextCompare: false) == 0)
							{
								await WritePartition(folderbackup + "SEC2", mtkGptPartition2.FirstLba * MtkSparse.sectsize, mtkGptPartition2.SectorCount * MtkSparse.sectsize, cancelToken);
								break;
							}
						}
					}
					Form1.SharedUI.ProgressBar4.Value = 0;
					gui.Richlog("OK", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
					Form1.SharedUI.ProgressBar4.Value = 100;
					SerialCOM.MSL = "DISREAD";
					Form1.SharedUI.ProgressBar4.Text = "0%";
					Form1.SharedUI.ProgressBar4.Value = 0;
					gui.Richlog("- Reboot Device : ", Color.Black);
					Form1.SharedUI.ProgressBar1.Text = "Rebooting...";
					await MtkDaxUploadBootService.RebootAsync(uploadResult.Device, cancelToken);
					gui.Richlog("OK", Color.FromArgb(0, 85, 207));
					closingport2();
					return;
				}
				if (!File.Exists(folderbackup + "SEC2"))
				{
					Form1.SharedUI.ProgressBar4.Text = "0%";
					Form1.SharedUI.ProgressBar4.Value = 0;
					SerialCOM.MSL = "ENREAD";
					gui.Richlog("- Reading Security : ", Color.Black);
					if (gpt.Partitions.Length > 0)
					{
						MtkGptPartition[] partitions3 = gpt.Partitions;
						foreach (MtkGptPartition mtkGptPartition3 in partitions3)
						{
							if (Operators.CompareString(mtkGptPartition3.Name, "otp", TextCompare: false) == 0)
							{
								string text = utils.LongToHex(mtkGptPartition3.FirstLba * MtkSparse.sectsize);
								string text2 = utils.LongToHex(mtkGptPartition3.SectorCount * MtkSparse.sectsize);
								await ReadPartition(mtkGptPartition3.Name, folderbackup, "SEC1", utils.HexToLong(text.Replace(" ", "").Replace("0x", "")), utils.HexToLong(text2.Replace(" ", "").Replace("0x", "")), cancelToken);
								break;
							}
						}
						MtkGptPartition[] partitions4 = gpt.Partitions;
						foreach (MtkGptPartition mtkGptPartition4 in partitions4)
						{
							if (Operators.CompareString(mtkGptPartition4.Name, "protect1", TextCompare: false) == 0)
							{
								string text3 = utils.LongToHex(mtkGptPartition4.FirstLba * MtkSparse.sectsize);
								string text4 = utils.LongToHex(mtkGptPartition4.SectorCount * MtkSparse.sectsize);
								await ReadPartition(mtkGptPartition4.Name, folderbackup, "SEC2", utils.HexToLong(text3.Replace(" ", "").Replace("0x", "")), utils.HexToLong(text4.Replace(" ", "").Replace("0x", "")), cancelToken);
								break;
							}
						}
					}
					Form1.SharedUI.ProgressBar4.Value = 0;
					gui.Richlog("OK", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
					Form1.SharedUI.ProgressBar4.Value = 100;
					SerialCOM.MSL = "DISREAD";
					Form1.SharedUI.ProgressBar4.Text = "0%";
					Form1.SharedUI.ProgressBar4.Value = 0;
				}
				gui.Richlog("- Calculate Security : ", Color.Black);
				Form1.SharedUI.ProgressBar1.Text = "Calculateing..";
				Form1.SharedUI.ProgressBar4.Text = "0%";
				Form1.SharedUI.ProgressBar4.Value = 0;
				SerialCOM.MSL = "ENREAD";
				if (gpt.Partitions.Length > 0)
				{
					MtkGptPartition[] partitions5 = gpt.Partitions;
					foreach (MtkGptPartition mtkGptPartition5 in partitions5)
					{
						if (Operators.CompareString(mtkGptPartition5.Name, "otp", TextCompare: false) == 0)
						{
							await WritePartition(folderwrite + "SEC1", mtkGptPartition5.FirstLba * MtkSparse.sectsize, mtkGptPartition5.SectorCount * MtkSparse.sectsize, cancelToken);
							break;
						}
					}
					MtkGptPartition[] partitions6 = gpt.Partitions;
					foreach (MtkGptPartition mtkGptPartition6 in partitions6)
					{
						if (Operators.CompareString(mtkGptPartition6.Name, "protect1", TextCompare: false) == 0)
						{
							await WritePartition(folderwrite + "SEC2", mtkGptPartition6.FirstLba * MtkSparse.sectsize, mtkGptPartition6.SectorCount * MtkSparse.sectsize, cancelToken);
							break;
						}
					}
				}
				Form1.SharedUI.ProgressBar4.Value = 100;
				SerialCOM.MSL = "DISREAD";
				Form1.SharedUI.ProgressBar4.Text = "0%";
				Form1.SharedUI.ProgressBar4.Value = 0;
				gui.Richlog("OK", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
				gui.Richlog("- Unlock Network : ", Color.Black);
				Form1.SharedUI.ProgressBar1.Text = "Calculateing..OK";
				gui.Richlog("OK", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
				gui.Richlog("- Verfing SimLock : ", Color.Black);
				Form1.SharedUI.ProgressBar1.Text = "Verfing...";
				gui.Richlog("Unlocked", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
				gui.Richlog("- Reboot Device : ", Color.Black);
				Form1.SharedUI.ProgressBar1.Text = "Rebooting...";
				await MtkDaxUploadBootService.RebootAsync(uploadResult.Device, cancelToken);
				gui.Richlog("OK", Color.FromArgb(0, 85, 207));
				closingport2();
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				gui.Richlog("Failed", Color.Red);
				closingport();
				ProjectData.ClearProjectError();
			}
		}
	}

	public static async Task MethodD_9(string folderbackup, string folderwrite, bool restor, CancellationToken cancelToken = default(CancellationToken))
	{
		checked
		{
			try
			{
				if (Operators.CompareString(CHECK, "no", TextCompare: false) == 0)
				{
					return;
				}
				cancelToken.ThrowIfCancellationRequested();
				await ReadGPT(cancelToken, showlist: false);
				if (restor)
				{
					Form1.SharedUI.ProgressBar4.Text = "0%";
					Form1.SharedUI.ProgressBar4.Value = 0;
					SerialCOM.MSL = "ENREAD";
					gui.Richlog("- Writing Security : ", Color.Black);
					if (gpt.Partitions.Length > 0)
					{
						MtkGptPartition[] partitions = gpt.Partitions;
						foreach (MtkGptPartition mtkGptPartition in partitions)
						{
							if (Operators.CompareString(mtkGptPartition.Name, "md1img", TextCompare: false) == 0)
							{
								await WritePartition(folderbackup + "SEC1", mtkGptPartition.FirstLba * MtkSparse.sectsize, mtkGptPartition.SectorCount * MtkSparse.sectsize, cancelToken);
								break;
							}
						}
					}
					Form1.SharedUI.ProgressBar4.Value = 0;
					gui.Richlog("OK", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
					Form1.SharedUI.ProgressBar4.Value = 100;
					SerialCOM.MSL = "DISREAD";
					Form1.SharedUI.ProgressBar4.Text = "0%";
					Form1.SharedUI.ProgressBar4.Value = 0;
					gui.Richlog("- Reboot Device : ", Color.Black);
					Form1.SharedUI.ProgressBar1.Text = "Rebooting...";
					await MtkDaxUploadBootService.RebootAsync(uploadResult.Device, cancelToken);
					gui.Richlog("OK", Color.FromArgb(0, 85, 207));
					closingport2();
					return;
				}
				if (!File.Exists(folderbackup + "SEC1"))
				{
					Form1.SharedUI.ProgressBar4.Text = "0%";
					Form1.SharedUI.ProgressBar4.Value = 0;
					SerialCOM.MSL = "ENREAD";
					gui.Richlog("- Reading Security : ", Color.Black);
					if (gpt.Partitions.Length > 0)
					{
						MtkGptPartition[] partitions2 = gpt.Partitions;
						foreach (MtkGptPartition mtkGptPartition2 in partitions2)
						{
							if (Operators.CompareString(mtkGptPartition2.Name, "md1img", TextCompare: false) == 0)
							{
								string text = utils.LongToHex(mtkGptPartition2.FirstLba * MtkSparse.sectsize);
								string text2 = utils.LongToHex(mtkGptPartition2.SectorCount * MtkSparse.sectsize);
								await ReadPartition(mtkGptPartition2.Name, folderbackup, "SEC1", utils.HexToLong(text.Replace(" ", "").Replace("0x", "")), utils.HexToLong(text2.Replace(" ", "").Replace("0x", "")), cancelToken);
								break;
							}
						}
					}
					Form1.SharedUI.ProgressBar4.Value = 0;
					gui.Richlog("OK", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
					Form1.SharedUI.ProgressBar4.Value = 100;
					SerialCOM.MSL = "DISREAD";
					Form1.SharedUI.ProgressBar4.Text = "0%";
					Form1.SharedUI.ProgressBar4.Value = 0;
				}
				gui.Richlog("- Calculate Security : ", Color.Black);
				Form1.SharedUI.ProgressBar1.Text = "Calculating..";
				Form1.SharedUI.ProgressBar4.Text = "0%";
				Form1.SharedUI.ProgressBar4.Value = 0;
				SerialCOM.MSL = "ENREAD";
				if (gpt.Partitions.Length > 0)
				{
					MtkGptPartition[] partitions3 = gpt.Partitions;
					foreach (MtkGptPartition mtkGptPartition3 in partitions3)
					{
						if (Operators.CompareString(mtkGptPartition3.Name, "md1img", TextCompare: false) == 0)
						{
							await WritePartition(folderwrite + "SEC1", mtkGptPartition3.FirstLba * MtkSparse.sectsize, mtkGptPartition3.SectorCount * MtkSparse.sectsize, cancelToken);
							break;
						}
					}
				}
				Form1.SharedUI.ProgressBar4.Value = 100;
				SerialCOM.MSL = "DISREAD";
				Form1.SharedUI.ProgressBar4.Text = "0%";
				Form1.SharedUI.ProgressBar4.Value = 0;
				gui.Richlog("OK", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
				gui.Richlog("- Unlock Network : ", Color.Black);
				Form1.SharedUI.ProgressBar1.Text = "Calculating..OK";
				gui.Richlog("OK", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
				gui.Richlog("- Verfing SimLock : ", Color.Black);
				Form1.SharedUI.ProgressBar1.Text = "Verfing...";
				gui.Richlog("Unlocked", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
				gui.Richlog("- Reboot Device : ", Color.Black);
				Form1.SharedUI.ProgressBar1.Text = "Rebooting...";
				await MtkDaxUploadBootService.RebootAsync(uploadResult.Device, cancelToken);
				gui.Richlog("OK", Color.FromArgb(0, 85, 207));
				closingport2();
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				gui.Richlog("Failed", Color.Red);
				closingport();
				ProjectData.ClearProjectError();
			}
		}
	}

	public static async Task MethodD_10(string folderbackup, string folderwrite, bool restor, CancellationToken cancelToken = default(CancellationToken))
	{
		checked
		{
			try
			{
				if (Operators.CompareString(CHECK, "no", TextCompare: false) == 0)
				{
					return;
				}
				cancelToken.ThrowIfCancellationRequested();
				await ReadGPT(cancelToken, showlist: false);
				if (restor)
				{
					Form1.SharedUI.ProgressBar4.Text = "0%";
					Form1.SharedUI.ProgressBar4.Value = 0;
					SerialCOM.MSL = "ENREAD";
					gui.Richlog("- Writing Security : ", Color.Black);
					if (gpt.Partitions.Length > 0)
					{
						MtkGptPartition[] partitions = gpt.Partitions;
						foreach (MtkGptPartition mtkGptPartition in partitions)
						{
							if (Operators.CompareString(mtkGptPartition.Name, "md1img", TextCompare: false) == 0)
							{
								await WritePartition(folderbackup + "SEC1", mtkGptPartition.FirstLba * MtkSparse.sectsize, mtkGptPartition.SectorCount * MtkSparse.sectsize, cancelToken);
								break;
							}
						}
						MtkGptPartition[] partitions2 = gpt.Partitions;
						foreach (MtkGptPartition mtkGptPartition2 in partitions2)
						{
							if (Operators.CompareString(mtkGptPartition2.Name, "nvdata", TextCompare: false) == 0)
							{
								await WritePartition(folderbackup + "SEC2", mtkGptPartition2.FirstLba * MtkSparse.sectsize, mtkGptPartition2.SectorCount * MtkSparse.sectsize, cancelToken);
								break;
							}
						}
						MtkGptPartition[] partitions3 = gpt.Partitions;
						foreach (MtkGptPartition mtkGptPartition3 in partitions3)
						{
							if (Operators.CompareString(mtkGptPartition3.Name, "protect1", TextCompare: false) == 0)
							{
								await WritePartition(folderbackup + "SEC4", mtkGptPartition3.FirstLba * MtkSparse.sectsize, mtkGptPartition3.SectorCount * MtkSparse.sectsize, cancelToken);
								break;
							}
						}
						MtkGptPartition[] partitions4 = gpt.Partitions;
						foreach (MtkGptPartition mtkGptPartition4 in partitions4)
						{
							if (Operators.CompareString(mtkGptPartition4.Name, "protect2", TextCompare: false) == 0)
							{
								await WritePartition(folderbackup + "SEC3", mtkGptPartition4.FirstLba * MtkSparse.sectsize, mtkGptPartition4.SectorCount * MtkSparse.sectsize, cancelToken);
								break;
							}
						}
						MtkGptPartition[] partitions5 = gpt.Partitions;
						foreach (MtkGptPartition mtkGptPartition5 in partitions5)
						{
							if (Operators.CompareString(mtkGptPartition5.Name, "nvram", TextCompare: false) == 0)
							{
								await WritePartition(folderbackup + "SEC5", mtkGptPartition5.FirstLba * MtkSparse.sectsize, mtkGptPartition5.SectorCount * MtkSparse.sectsize, cancelToken);
								break;
							}
						}
					}
					Form1.SharedUI.ProgressBar4.Value = 0;
					gui.Richlog("OK", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
					Form1.SharedUI.ProgressBar4.Value = 100;
					SerialCOM.MSL = "DISREAD";
					Form1.SharedUI.ProgressBar4.Text = "0%";
					Form1.SharedUI.ProgressBar4.Value = 0;
					gui.Richlog("- Reboot Device : ", Color.Black);
					Form1.SharedUI.ProgressBar1.Text = "Rebooting...";
					await MtkDaxUploadBootService.RebootAsync(uploadResult.Device, cancelToken);
					gui.Richlog("OK", Color.FromArgb(0, 85, 207));
					closingport2();
					return;
				}
				if (!File.Exists(folderbackup + "SEC5"))
				{
					Form1.SharedUI.ProgressBar4.Text = "0%";
					Form1.SharedUI.ProgressBar4.Value = 0;
					SerialCOM.MSL = "ENREAD";
					gui.Richlog("- Reading Security : ", Color.Black);
					if (gpt.Partitions.Length > 0)
					{
						MtkGptPartition[] partitions6 = gpt.Partitions;
						foreach (MtkGptPartition mtkGptPartition6 in partitions6)
						{
							if (Operators.CompareString(mtkGptPartition6.Name, "md1img", TextCompare: false) == 0)
							{
								string text = utils.LongToHex(mtkGptPartition6.FirstLba * MtkSparse.sectsize);
								string text2 = utils.LongToHex(mtkGptPartition6.SectorCount * MtkSparse.sectsize);
								await ReadPartition(mtkGptPartition6.Name, folderbackup, "SEC1", utils.HexToLong(text.Replace(" ", "").Replace("0x", "")), utils.HexToLong(text2.Replace(" ", "").Replace("0x", "")), cancelToken);
								break;
							}
						}
						MtkGptPartition[] partitions7 = gpt.Partitions;
						foreach (MtkGptPartition mtkGptPartition7 in partitions7)
						{
							if (Operators.CompareString(mtkGptPartition7.Name, "nvdata", TextCompare: false) == 0)
							{
								string text3 = utils.LongToHex(mtkGptPartition7.FirstLba * MtkSparse.sectsize);
								string text4 = utils.LongToHex(mtkGptPartition7.SectorCount * MtkSparse.sectsize);
								await ReadPartition(mtkGptPartition7.Name, folderbackup, "SEC2", utils.HexToLong(text3.Replace(" ", "").Replace("0x", "")), utils.HexToLong(text4.Replace(" ", "").Replace("0x", "")), cancelToken);
								break;
							}
						}
						MtkGptPartition[] partitions8 = gpt.Partitions;
						foreach (MtkGptPartition mtkGptPartition8 in partitions8)
						{
							if (Operators.CompareString(mtkGptPartition8.Name, "protect2", TextCompare: false) == 0)
							{
								string text5 = utils.LongToHex(mtkGptPartition8.FirstLba * MtkSparse.sectsize);
								string text6 = utils.LongToHex(mtkGptPartition8.SectorCount * MtkSparse.sectsize);
								await ReadPartition(mtkGptPartition8.Name, folderbackup, "SEC3", utils.HexToLong(text5.Replace(" ", "").Replace("0x", "")), utils.HexToLong(text6.Replace(" ", "").Replace("0x", "")), cancelToken);
								break;
							}
						}
						MtkGptPartition[] partitions9 = gpt.Partitions;
						foreach (MtkGptPartition mtkGptPartition9 in partitions9)
						{
							if (Operators.CompareString(mtkGptPartition9.Name, "protect1", TextCompare: false) == 0)
							{
								string text7 = utils.LongToHex(mtkGptPartition9.FirstLba * MtkSparse.sectsize);
								string text8 = utils.LongToHex(mtkGptPartition9.SectorCount * MtkSparse.sectsize);
								await ReadPartition(mtkGptPartition9.Name, folderbackup, "SEC4", utils.HexToLong(text7.Replace(" ", "").Replace("0x", "")), utils.HexToLong(text8.Replace(" ", "").Replace("0x", "")), cancelToken);
								break;
							}
						}
						MtkGptPartition[] partitions10 = gpt.Partitions;
						foreach (MtkGptPartition mtkGptPartition10 in partitions10)
						{
							if (Operators.CompareString(mtkGptPartition10.Name, "nvram", TextCompare: false) == 0)
							{
								string text9 = utils.LongToHex(mtkGptPartition10.FirstLba * MtkSparse.sectsize);
								string text10 = utils.LongToHex(mtkGptPartition10.SectorCount * MtkSparse.sectsize);
								await ReadPartition(mtkGptPartition10.Name, folderbackup, "SEC5", utils.HexToLong(text9.Replace(" ", "").Replace("0x", "")), utils.HexToLong(text10.Replace(" ", "").Replace("0x", "")), cancelToken);
								break;
							}
						}
					}
					Form1.SharedUI.ProgressBar4.Value = 0;
					gui.Richlog("OK", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
					Form1.SharedUI.ProgressBar4.Value = 100;
					SerialCOM.MSL = "DISREAD";
					Form1.SharedUI.ProgressBar4.Text = "0%";
					Form1.SharedUI.ProgressBar4.Value = 0;
				}
				gui.Richlog("- Calculate Security : ", Color.Black);
				Form1.SharedUI.ProgressBar1.Text = "Calculateing..";
				Form1.SharedUI.ProgressBar4.Text = "0%";
				Form1.SharedUI.ProgressBar4.Value = 0;
				SerialCOM.MSL = "ENREAD";
				if (gpt.Partitions.Length > 0)
				{
					MtkGptPartition[] partitions11 = gpt.Partitions;
					foreach (MtkGptPartition mtkGptPartition11 in partitions11)
					{
						if (Operators.CompareString(mtkGptPartition11.Name, "md1img", TextCompare: false) == 0)
						{
							await WritePartition(folderwrite + "SEC1", mtkGptPartition11.FirstLba * MtkSparse.sectsize, mtkGptPartition11.SectorCount * MtkSparse.sectsize, cancelToken);
							break;
						}
					}
					MtkGptPartition[] partitions12 = gpt.Partitions;
					foreach (MtkGptPartition mtkGptPartition12 in partitions12)
					{
						if (Operators.CompareString(mtkGptPartition12.Name, "nvdata", TextCompare: false) == 0)
						{
							await WritePartition(folderwrite + "SEC2", mtkGptPartition12.FirstLba * MtkSparse.sectsize, mtkGptPartition12.SectorCount * MtkSparse.sectsize, cancelToken);
							break;
						}
					}
					MtkGptPartition[] partitions13 = gpt.Partitions;
					foreach (MtkGptPartition mtkGptPartition13 in partitions13)
					{
						if (Operators.CompareString(mtkGptPartition13.Name, "protect1", TextCompare: false) == 0)
						{
							await WritePartition(folderwrite + "SEC4", mtkGptPartition13.FirstLba * MtkSparse.sectsize, mtkGptPartition13.SectorCount * MtkSparse.sectsize, cancelToken);
							break;
						}
					}
					MtkGptPartition[] partitions14 = gpt.Partitions;
					foreach (MtkGptPartition mtkGptPartition14 in partitions14)
					{
						if (Operators.CompareString(mtkGptPartition14.Name, "protect2", TextCompare: false) == 0)
						{
							await WritePartition(folderwrite + "SEC3", mtkGptPartition14.FirstLba * MtkSparse.sectsize, mtkGptPartition14.SectorCount * MtkSparse.sectsize, cancelToken);
							break;
						}
					}
					MtkGptPartition[] partitions15 = gpt.Partitions;
					foreach (MtkGptPartition mtkGptPartition15 in partitions15)
					{
						if (Operators.CompareString(mtkGptPartition15.Name, "nvram", TextCompare: false) == 0)
						{
							await WritePartition(folderwrite + "SEC5", mtkGptPartition15.FirstLba * MtkSparse.sectsize, mtkGptPartition15.SectorCount * MtkSparse.sectsize, cancelToken);
							break;
						}
					}
				}
				Form1.SharedUI.ProgressBar4.Value = 100;
				SerialCOM.MSL = "DISREAD";
				Form1.SharedUI.ProgressBar4.Text = "0%";
				Form1.SharedUI.ProgressBar4.Value = 0;
				gui.Richlog("OK", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
				gui.Richlog("- Unlock Network : ", Color.Black);
				Form1.SharedUI.ProgressBar1.Text = "Calculateing..OK";
				gui.Richlog("OK", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
				gui.Richlog("- Verfing SimLock : ", Color.Black);
				Form1.SharedUI.ProgressBar1.Text = "Verfing...";
				gui.Richlog("Unlocked", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
				gui.Richlog("- Reboot Device : ", Color.Black);
				Form1.SharedUI.ProgressBar1.Text = "Rebooting...";
				await MtkDaxUploadBootService.RebootAsync(uploadResult.Device, cancelToken);
				gui.Richlog("OK", Color.FromArgb(0, 85, 207));
				closingport2();
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				gui.Richlog("Failed", Color.Red);
				closingport();
				ProjectData.ClearProjectError();
			}
		}
	}

	public static async Task MethodD_11(string folderbackup, string folderwrite, bool restor, CancellationToken cancelToken = default(CancellationToken))
	{
		checked
		{
			try
			{
				if (Operators.CompareString(CHECK, "no", TextCompare: false) == 0)
				{
					return;
				}
				cancelToken.ThrowIfCancellationRequested();
				await ReadGPT(cancelToken, showlist: false);
				if (restor)
				{
					Form1.SharedUI.ProgressBar4.Text = "0%";
					Form1.SharedUI.ProgressBar4.Value = 0;
					SerialCOM.MSL = "ENREAD";
					gui.Richlog("- Writing Security : ", Color.Black);
					if (gpt.Partitions.Length > 0)
					{
						MtkGptPartition[] partitions = gpt.Partitions;
						foreach (MtkGptPartition mtkGptPartition in partitions)
						{
							if (Operators.CompareString(mtkGptPartition.Name, "md1img", TextCompare: false) == 0)
							{
								await WritePartition(folderbackup + "SEC1", mtkGptPartition.FirstLba * MtkSparse.sectsize, mtkGptPartition.SectorCount * MtkSparse.sectsize, cancelToken);
								break;
							}
						}
						MtkGptPartition[] partitions2 = gpt.Partitions;
						foreach (MtkGptPartition mtkGptPartition2 in partitions2)
						{
							if (Operators.CompareString(mtkGptPartition2.Name, "carrier", TextCompare: false) == 0)
							{
								await WritePartition(folderbackup + "SEC2", mtkGptPartition2.FirstLba * MtkSparse.sectsize, mtkGptPartition2.SectorCount * MtkSparse.sectsize, cancelToken);
								break;
							}
						}
						MtkGptPartition[] partitions3 = gpt.Partitions;
						foreach (MtkGptPartition mtkGptPartition3 in partitions3)
						{
							if (Operators.CompareString(mtkGptPartition3.Name, "nvdata", TextCompare: false) == 0)
							{
								await WritePartition(folderbackup + "SEC3", mtkGptPartition3.FirstLba * MtkSparse.sectsize, mtkGptPartition3.SectorCount * MtkSparse.sectsize, cancelToken);
								break;
							}
						}
						MtkGptPartition[] partitions4 = gpt.Partitions;
						foreach (MtkGptPartition mtkGptPartition4 in partitions4)
						{
							if (Operators.CompareString(mtkGptPartition4.Name, "md1dsp", TextCompare: false) == 0)
							{
								await WritePartition(folderbackup + "SEC4", mtkGptPartition4.FirstLba * MtkSparse.sectsize, mtkGptPartition4.SectorCount * MtkSparse.sectsize, cancelToken);
								break;
							}
						}
					}
					Form1.SharedUI.ProgressBar4.Value = 0;
					gui.Richlog("OK", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
					Form1.SharedUI.ProgressBar4.Value = 100;
					SerialCOM.MSL = "DISREAD";
					Form1.SharedUI.ProgressBar4.Text = "0%";
					Form1.SharedUI.ProgressBar4.Value = 0;
					gui.Richlog("- Reboot Device : ", Color.Black);
					Form1.SharedUI.ProgressBar1.Text = "Rebooting...";
					await MtkDaxUploadBootService.RebootAsync(uploadResult.Device, cancelToken);
					gui.Richlog("OK", Color.FromArgb(0, 85, 207));
					closingport2();
					return;
				}
				if (!File.Exists(folderbackup + "SEC4"))
				{
					Form1.SharedUI.ProgressBar4.Text = "0%";
					Form1.SharedUI.ProgressBar4.Value = 0;
					SerialCOM.MSL = "ENREAD";
					gui.Richlog("- Reading Security : ", Color.Black);
					if (gpt.Partitions.Length > 0)
					{
						MtkGptPartition[] partitions5 = gpt.Partitions;
						foreach (MtkGptPartition mtkGptPartition5 in partitions5)
						{
							if (Operators.CompareString(mtkGptPartition5.Name, "md1img", TextCompare: false) == 0)
							{
								string text = utils.LongToHex(mtkGptPartition5.FirstLba * MtkSparse.sectsize);
								string text2 = utils.LongToHex(mtkGptPartition5.SectorCount * MtkSparse.sectsize);
								await ReadPartition(mtkGptPartition5.Name, folderbackup, "SEC1", utils.HexToLong(text.Replace(" ", "").Replace("0x", "")), utils.HexToLong(text2.Replace(" ", "").Replace("0x", "")), cancelToken);
								break;
							}
						}
						MtkGptPartition[] partitions6 = gpt.Partitions;
						foreach (MtkGptPartition mtkGptPartition6 in partitions6)
						{
							if (Operators.CompareString(mtkGptPartition6.Name, "carrier", TextCompare: false) == 0)
							{
								string text3 = utils.LongToHex(mtkGptPartition6.FirstLba * MtkSparse.sectsize);
								string text4 = utils.LongToHex(mtkGptPartition6.SectorCount * MtkSparse.sectsize);
								await ReadPartition(mtkGptPartition6.Name, folderbackup, "SEC2", utils.HexToLong(text3.Replace(" ", "").Replace("0x", "")), utils.HexToLong(text4.Replace(" ", "").Replace("0x", "")), cancelToken);
								break;
							}
						}
						MtkGptPartition[] partitions7 = gpt.Partitions;
						foreach (MtkGptPartition mtkGptPartition7 in partitions7)
						{
							if (Operators.CompareString(mtkGptPartition7.Name, "nvdata", TextCompare: false) == 0)
							{
								string text5 = utils.LongToHex(mtkGptPartition7.FirstLba * MtkSparse.sectsize);
								string text6 = utils.LongToHex(mtkGptPartition7.SectorCount * MtkSparse.sectsize);
								await ReadPartition(mtkGptPartition7.Name, folderbackup, "SEC3", utils.HexToLong(text5.Replace(" ", "").Replace("0x", "")), utils.HexToLong(text6.Replace(" ", "").Replace("0x", "")), cancelToken);
								break;
							}
						}
						MtkGptPartition[] partitions8 = gpt.Partitions;
						foreach (MtkGptPartition mtkGptPartition8 in partitions8)
						{
							if (Operators.CompareString(mtkGptPartition8.Name, "md1dsp", TextCompare: false) == 0)
							{
								string text7 = utils.LongToHex(mtkGptPartition8.FirstLba * MtkSparse.sectsize);
								string text8 = utils.LongToHex(mtkGptPartition8.SectorCount * MtkSparse.sectsize);
								await ReadPartition(mtkGptPartition8.Name, folderbackup, "SEC4", utils.HexToLong(text7.Replace(" ", "").Replace("0x", "")), utils.HexToLong(text8.Replace(" ", "").Replace("0x", "")), cancelToken);
								break;
							}
						}
					}
					Form1.SharedUI.ProgressBar4.Value = 0;
					gui.Richlog("OK", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
					Form1.SharedUI.ProgressBar4.Value = 100;
					SerialCOM.MSL = "DISREAD";
					Form1.SharedUI.ProgressBar4.Text = "0%";
					Form1.SharedUI.ProgressBar4.Value = 0;
				}
				gui.Richlog("- Calculate Security : ", Color.Black);
				Form1.SharedUI.ProgressBar1.Text = "Calculateing..";
				Form1.SharedUI.ProgressBar4.Text = "0%";
				Form1.SharedUI.ProgressBar4.Value = 0;
				SerialCOM.MSL = "ENREAD";
				if (gpt.Partitions.Length > 0)
				{
					MtkGptPartition[] partitions9 = gpt.Partitions;
					foreach (MtkGptPartition mtkGptPartition9 in partitions9)
					{
						if (Operators.CompareString(mtkGptPartition9.Name, "md1img", TextCompare: false) == 0)
						{
							await WritePartition(folderwrite + "SEC1", mtkGptPartition9.FirstLba * MtkSparse.sectsize, mtkGptPartition9.SectorCount * MtkSparse.sectsize, cancelToken);
							break;
						}
					}
					MtkGptPartition[] partitions10 = gpt.Partitions;
					foreach (MtkGptPartition mtkGptPartition10 in partitions10)
					{
						if (Operators.CompareString(mtkGptPartition10.Name, "carrier", TextCompare: false) == 0)
						{
							await WritePartition(folderwrite + "SEC2", mtkGptPartition10.FirstLba * MtkSparse.sectsize, mtkGptPartition10.SectorCount * MtkSparse.sectsize, cancelToken);
							break;
						}
					}
					MtkGptPartition[] partitions11 = gpt.Partitions;
					foreach (MtkGptPartition mtkGptPartition11 in partitions11)
					{
						if (Operators.CompareString(mtkGptPartition11.Name, "nvdata", TextCompare: false) == 0)
						{
							await WritePartition(folderwrite + "SEC3", mtkGptPartition11.FirstLba * MtkSparse.sectsize, mtkGptPartition11.SectorCount * MtkSparse.sectsize, cancelToken);
							break;
						}
					}
					MtkGptPartition[] partitions12 = gpt.Partitions;
					foreach (MtkGptPartition mtkGptPartition12 in partitions12)
					{
						if (Operators.CompareString(mtkGptPartition12.Name, "md1dsp", TextCompare: false) == 0)
						{
							await WritePartition(folderwrite + "SEC4", mtkGptPartition12.FirstLba * MtkSparse.sectsize, mtkGptPartition12.SectorCount * MtkSparse.sectsize, cancelToken);
							break;
						}
					}
				}
				Form1.SharedUI.ProgressBar4.Value = 100;
				SerialCOM.MSL = "DISREAD";
				Form1.SharedUI.ProgressBar4.Text = "0%";
				Form1.SharedUI.ProgressBar4.Value = 0;
				gui.Richlog("OK", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
				gui.Richlog("- Unlock Network : ", Color.Black);
				Form1.SharedUI.ProgressBar1.Text = "Calculateing..OK";
				gui.Richlog("OK", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
				gui.Richlog("- Verfing SimLock : ", Color.Black);
				Form1.SharedUI.ProgressBar1.Text = "Verfing...";
				gui.Richlog("Unlocked", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
				gui.Richlog("- Reboot Device : ", Color.Black);
				Form1.SharedUI.ProgressBar1.Text = "Rebooting...";
				await MtkDaxUploadBootService.RebootAsync(uploadResult.Device, cancelToken);
				gui.Richlog("OK", Color.FromArgb(0, 85, 207));
				closingport2();
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				gui.Richlog("Failed", Color.Red);
				closingport();
				ProjectData.ClearProjectError();
			}
		}
	}

	public static async Task MethodD_12(string folderbackup, string folderwrite, CancellationToken cancelToken = default(CancellationToken))
	{
		checked
		{
			try
			{
				if (Operators.CompareString(CHECK, "no", TextCompare: false) == 0)
				{
					return;
				}
				cancelToken.ThrowIfCancellationRequested();
				await ReadGPT(cancelToken, showlist: false);
				if (!File.Exists(folderbackup + "SEC1"))
				{
					Form1.SharedUI.ProgressBar4.Text = "0%";
					Form1.SharedUI.ProgressBar4.Value = 0;
					SerialCOM.MSL = "ENREAD";
					gui.Richlog("- Reading Security : ", Color.Black);
					if (gpt.Partitions.Length > 0)
					{
						MtkGptPartition[] partitions = gpt.Partitions;
						foreach (MtkGptPartition mtkGptPartition in partitions)
						{
							if (Operators.CompareString(mtkGptPartition.Name, "md1img", TextCompare: false) == 0)
							{
								string text = utils.LongToHex(mtkGptPartition.FirstLba * MtkSparse.sectsize);
								string text2 = utils.LongToHex(mtkGptPartition.SectorCount * MtkSparse.sectsize);
								await ReadPartition(mtkGptPartition.Name, folderbackup, "SEC1", utils.HexToLong(text.Replace(" ", "").Replace("0x", "")), utils.HexToLong(text2.Replace(" ", "").Replace("0x", "")), cancelToken);
								break;
							}
						}
						MtkGptPartition[] partitions2 = gpt.Partitions;
						foreach (MtkGptPartition mtkGptPartition2 in partitions2)
						{
							if (Operators.CompareString(mtkGptPartition2.Name, "md1img_a", TextCompare: false) == 0)
							{
								string text3 = utils.LongToHex(mtkGptPartition2.FirstLba * MtkSparse.sectsize);
								string text4 = utils.LongToHex(mtkGptPartition2.SectorCount * MtkSparse.sectsize);
								await ReadPartition(mtkGptPartition2.Name, folderbackup, "SEC1", utils.HexToLong(text3.Replace(" ", "").Replace("0x", "")), utils.HexToLong(text4.Replace(" ", "").Replace("0x", "")), cancelToken);
								break;
							}
						}
						MtkGptPartition[] partitions3 = gpt.Partitions;
						foreach (MtkGptPartition mtkGptPartition3 in partitions3)
						{
							if (Operators.CompareString(mtkGptPartition3.Name, "md1img_b", TextCompare: false) == 0)
							{
								string text5 = utils.LongToHex(mtkGptPartition3.FirstLba * MtkSparse.sectsize);
								string text6 = utils.LongToHex(mtkGptPartition3.SectorCount * MtkSparse.sectsize);
								await ReadPartition(mtkGptPartition3.Name, folderbackup, "SEC2", utils.HexToLong(text5.Replace(" ", "").Replace("0x", "")), utils.HexToLong(text6.Replace(" ", "").Replace("0x", "")), cancelToken);
								break;
							}
						}
					}
					gui.Richlog("OK", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
					Form1.SharedUI.ProgressBar4.Value = 100;
					SerialCOM.MSL = "DISREAD";
					Form1.SharedUI.ProgressBar4.Text = "0%";
					Form1.SharedUI.ProgressBar4.Value = 0;
				}
				gui.Richlog("- Unlock Network : ", Color.Black);
				Form1.SharedUI.ProgressBar1.Text = "Calculating..";
				if (gpt.Partitions.Length > 0)
				{
					MtkGptPartition[] partitions4 = gpt.Partitions;
					foreach (MtkGptPartition mtkGptPartition4 in partitions4)
					{
						if (Operators.CompareString(mtkGptPartition4.Name, "md1img", TextCompare: false) == 0)
						{
							await WritePartition(folderwrite + "SEC1", mtkGptPartition4.FirstLba * MtkSparse.sectsize, mtkGptPartition4.SectorCount * MtkSparse.sectsize, cancelToken);
							break;
						}
					}
					MtkGptPartition[] partitions5 = gpt.Partitions;
					foreach (MtkGptPartition mtkGptPartition5 in partitions5)
					{
						if (Operators.CompareString(mtkGptPartition5.Name, "md1img_a", TextCompare: false) == 0)
						{
							await WritePartition(folderwrite + "SEC1", mtkGptPartition5.FirstLba * MtkSparse.sectsize, mtkGptPartition5.SectorCount * MtkSparse.sectsize, cancelToken);
							break;
						}
					}
					MtkGptPartition[] partitions6 = gpt.Partitions;
					foreach (MtkGptPartition mtkGptPartition6 in partitions6)
					{
						if (Operators.CompareString(mtkGptPartition6.Name, "md1img_b", TextCompare: false) == 0)
						{
							await WritePartition(folderwrite + "SEC1", mtkGptPartition6.FirstLba * MtkSparse.sectsize, mtkGptPartition6.SectorCount * MtkSparse.sectsize, cancelToken);
							break;
						}
					}
				}
				Form1.SharedUI.ProgressBar1.Text = "Calculating..OK";
				gui.Richlog("OK", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
				gui.Richlog("- Verfing SimLock : ", Color.Black);
				Form1.SharedUI.ProgressBar1.Text = "Verfing...";
				gui.Richlog("Unlocked", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
				gui.Richlog("- Reboot Device : ", Color.Black);
				Form1.SharedUI.ProgressBar1.Text = "Rebooting...";
				await MtkDaxUploadBootService.RebootAsync(uploadResult.Device, cancelToken);
				gui.Richlog("OK", Color.FromArgb(0, 85, 207));
				closingport2();
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				gui.Richlog("Failed", Color.Red);
				closingport();
				ProjectData.ClearProjectError();
			}
		}
	}

	public static async Task MethodD_13(string folderbackup, string folderwrite, CancellationToken cancelToken = default(CancellationToken))
	{
		checked
		{
			try
			{
				if (Operators.CompareString(CHECK, "no", TextCompare: false) == 0)
				{
					return;
				}
				cancelToken.ThrowIfCancellationRequested();
				await ReadGPT(cancelToken, showlist: false);
				if (!File.Exists(folderbackup + "SEC1"))
				{
					Form1.SharedUI.ProgressBar4.Text = "0%";
					Form1.SharedUI.ProgressBar4.Value = 0;
					SerialCOM.MSL = "ENREAD";
					gui.Richlog("- Reading Security : ", Color.Black);
					if (gpt.Partitions.Length > 0)
					{
						MtkGptPartition[] partitions = gpt.Partitions;
						foreach (MtkGptPartition mtkGptPartition in partitions)
						{
							if (Operators.CompareString(mtkGptPartition.Name, "proinfo", TextCompare: false) == 0)
							{
								string text = utils.LongToHex(mtkGptPartition.FirstLba * MtkSparse.sectsize);
								string text2 = utils.LongToHex(mtkGptPartition.SectorCount * MtkSparse.sectsize);
								await ReadPartition(mtkGptPartition.Name, folderbackup, "SEC1", utils.HexToLong(text.Replace(" ", "").Replace("0x", "")), utils.HexToLong(text2.Replace(" ", "").Replace("0x", "")), cancelToken);
								break;
							}
						}
					}
					Form1.SharedUI.ProgressBar4.Value = 100;
					SerialCOM.MSL = "DISREAD";
					Form1.SharedUI.ProgressBar4.Text = "0%";
					Form1.SharedUI.ProgressBar4.Value = 0;
					gui.Richlog("OK", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
				}
				gui.Richlog("- Unlock Network : ", Color.Black);
				Form1.SharedUI.ProgressBar1.Text = "Calculating..";
				if (gpt.Partitions.Length > 0)
				{
					MtkGptPartition[] partitions2 = gpt.Partitions;
					foreach (MtkGptPartition mtkGptPartition2 in partitions2)
					{
						if (Operators.CompareString(mtkGptPartition2.Name, "proinfo", TextCompare: false) == 0)
						{
							await WritePartition(folderwrite + "proinfo", mtkGptPartition2.FirstLba * MtkSparse.sectsize, mtkGptPartition2.SectorCount * MtkSparse.sectsize, cancelToken);
							break;
						}
					}
				}
				Form1.SharedUI.ProgressBar1.Text = "Calculating..OK";
				gui.Richlog("OK", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
				gui.Richlog("- Verfing SimLock : ", Color.Black);
				Form1.SharedUI.ProgressBar1.Text = "Verfing...";
				gui.Richlog("Unlocked", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
				gui.Richlog("- Reboot Device : ", Color.Black);
				Form1.SharedUI.ProgressBar1.Text = "Rebooting...";
				await MtkDaxUploadBootService.RebootAsync(uploadResult.Device, cancelToken);
				gui.Richlog("OK", Color.FromArgb(0, 85, 207));
				closingport2();
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				gui.Richlog("Failed", Color.Red);
				closingport();
				ProjectData.ClearProjectError();
			}
		}
	}

	public static async Task MethodD_14(CancellationToken cancelToken = default(CancellationToken))
	{
		checked
		{
			try
			{
				if (Operators.CompareString(CHECK, "no", TextCompare: false) == 0)
				{
					return;
				}
				await ReadGPT(cancelToken, showlist: false);
				gui.Richlog("- Reading Security : ", Color.Black);
				if (gpt.Partitions.Length > 0)
				{
					MtkGptPartition[] partitions = gpt.Partitions;
					foreach (MtkGptPartition mtkGptPartition in partitions)
					{
						if (Operators.CompareString(mtkGptPartition.Name, "nvram", TextCompare: false) == 0)
						{
							await FormatPartition(mtkGptPartition.FirstLba * MtkSparse.sectsize, mtkGptPartition.SectorCount * MtkSparse.sectsize, cancelToken);
						}
						if (Operators.CompareString(mtkGptPartition.Name, "nvdata", TextCompare: false) == 0)
						{
							await FormatPartition(mtkGptPartition.FirstLba * MtkSparse.sectsize, mtkGptPartition.SectorCount * MtkSparse.sectsize, cancelToken);
						}
						if (Operators.CompareString(mtkGptPartition.Name, "protect1", TextCompare: false) == 0)
						{
							await FormatPartition(mtkGptPartition.FirstLba * MtkSparse.sectsize, mtkGptPartition.SectorCount * MtkSparse.sectsize, cancelToken);
						}
						if (Operators.CompareString(mtkGptPartition.Name, "protect2", TextCompare: false) == 0)
						{
							await FormatPartition(mtkGptPartition.FirstLba * MtkSparse.sectsize, mtkGptPartition.SectorCount * MtkSparse.sectsize, cancelToken);
						}
					}
					gui.Richlog("OK", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
					gui.Richlog("- Reboot Device To Normal Mode : ", Color.Black);
					Form1.SharedUI.ProgressBar1.Text = "Rebooting...";
					await MtkDaxUploadBootService.RebootAsync(uploadResult.Device, cancelToken);
					gui.Richlog("OK", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
					gui.Richlog("- Wait For ADB Connection : ", Color.Black);
					Form1.SharedUI.ProgressBar1.Text = "Waiting...";
				}
				else
				{
					gui.Richlog("Failed", Color.Red, isBold: false, NextLine: true);
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				gui.Richlog("Failed", Color.Red);
				closingport();
				ProjectData.ClearProjectError();
			}
		}
	}

	public static async Task MethodD_15(string folderbackup, CancellationToken cancelToken = default(CancellationToken))
	{
		checked
		{
			try
			{
				if (Operators.CompareString(CHECK, "no", TextCompare: false) == 0)
				{
					return;
				}
				cancelToken.ThrowIfCancellationRequested();
				await ReadGPT(cancelToken, showlist: false);
				Form1.SharedUI.ProgressBar4.Text = "0%";
				Form1.SharedUI.ProgressBar4.Value = 0;
				SerialCOM.MSL = "ENREAD";
				if (!File.Exists(folderbackup + "SEC2"))
				{
					gui.Richlog("- Reading Security : ", Color.Black);
					if (gpt.Partitions.Length > 0)
					{
						MtkGptPartition[] partitions = gpt.Partitions;
						foreach (MtkGptPartition mtkGptPartition in partitions)
						{
							if (Operators.CompareString(mtkGptPartition.Name, "protect1", TextCompare: false) == 0)
							{
								string text = utils.LongToHex(mtkGptPartition.FirstLba * MtkSparse.sectsize);
								string text2 = utils.LongToHex(mtkGptPartition.SectorCount * MtkSparse.sectsize);
								await ReadPartition(mtkGptPartition.Name, folderbackup, "SEC1", utils.HexToLong(text.Replace(" ", "").Replace("0x", "")), utils.HexToLong(text2.Replace(" ", "").Replace("0x", "")), cancelToken);
								break;
							}
						}
						MtkGptPartition[] partitions2 = gpt.Partitions;
						foreach (MtkGptPartition mtkGptPartition2 in partitions2)
						{
							if (Operators.CompareString(mtkGptPartition2.Name, "protect2", TextCompare: false) == 0)
							{
								string text3 = utils.LongToHex(mtkGptPartition2.FirstLba * MtkSparse.sectsize);
								string text4 = utils.LongToHex(mtkGptPartition2.SectorCount * MtkSparse.sectsize);
								await ReadPartition(mtkGptPartition2.Name, folderbackup, "SEC2", utils.HexToLong(text3.Replace(" ", "").Replace("0x", "")), utils.HexToLong(text4.Replace(" ", "").Replace("0x", "")), cancelToken);
								break;
							}
						}
					}
					gui.Richlog("OK", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
				}
				Form1.SharedUI.ProgressBar4.Value = 100;
				SerialCOM.MSL = "DISREAD";
				Form1.SharedUI.ProgressBar4.Text = "0%";
				Form1.SharedUI.ProgressBar4.Value = 0;
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				gui.Richlog("Failed", Color.Red);
				closingport();
				ProjectData.ClearProjectError();
			}
		}
	}

	public static async Task MethodD_16(string folderwrite, CancellationToken cancelToken = default(CancellationToken))
	{
		try
		{
			gui.Richlog("OK", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
			gui.Richlog("- Unlock Network : ", Color.Black);
			Form1.SharedUI.ProgressBar1.Text = "Unlocking...";
			if (gpt.Partitions.Length > 0)
			{
				MtkGptPartition[] partitions = gpt.Partitions;
				foreach (MtkGptPartition mtkGptPartition in partitions)
				{
					if (Operators.CompareString(mtkGptPartition.Name, "protect1", TextCompare: false) == 0)
					{
						await checked(WritePartition(inputStream, mtkGptPartition.FirstLba * MtkSparse.sectsize, mtkGptPartition.SectorCount * MtkSparse.sectsize, cancelToken));
						break;
					}
				}
			}
			gui.Richlog("OK", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
			gui.Richlog("- Verfing SimLock : ", Color.Black);
			Form1.SharedUI.ProgressBar1.Text = "Verfing...";
			gui.Richlog("Unlocked", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
			gui.Richlog("- Reboot Device : ", Color.Black);
			Form1.SharedUI.ProgressBar1.Text = "Rebooting...";
			await MtkDaxUploadBootService.RebootAsync(uploadResult.Device, cancelToken);
			gui.Richlog("OK", Color.FromArgb(0, 85, 207));
			closingport2();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			gui.Richlog("Failed", Color.Red);
			closingport();
			ProjectData.ClearProjectError();
		}
	}

	public static async Task MethodD_17(CancellationToken cancelToken = default(CancellationToken), string encSecCfg = "unlock")
	{
		checked
		{
			try
			{
				if (Operators.CompareString(CHECK, "no", TextCompare: false) == 0)
				{
					return;
				}
				gui.Richlog("- Bootloader States : ", Color.Black);
				await ReadGPT(cancelToken, showlist: false);
				Form1.SharedUI.ProgressBar4.Text = "0%";
				Form1.SharedUI.ProgressBar4.Value = 0;
				SerialCOM.MSL = "ENREAD";
				if (File.Exists(Application.StartupPath + "\\tmp\\seccfg.img"))
				{
					File.Delete(Application.StartupPath + "\\tmp\\seccfg.img");
				}
				if (gpt.Partitions.Length > 0)
				{
					string foldersave = Application.StartupPath + "\\tmp\\";
					MtkGptPartition[] partitions = gpt.Partitions;
					foreach (MtkGptPartition mtkGptPartition in partitions)
					{
						if (Operators.CompareString(mtkGptPartition.Name, "seccfg", TextCompare: false) == 0)
						{
							await ReadPartition2("seccfg", foldersave, mtkGptPartition.FirstLba * MtkSparse.sectsize, mtkGptPartition.SectorCount * MtkSparse.sectsize, cancelToken);
							break;
						}
					}
				}
				Form1.SharedUI.ProgressBar4.Value = 100;
				Form1.SharedUI.ProgressBar4.Text = "0%";
				Form1.SharedUI.ProgressBar4.Value = 0;
				SerialCOM.MSL = "DISREAD";
				if (!File.Exists(Application.StartupPath + "\\tmp\\seccfg.img"))
				{
					return;
				}
				byte[] source = File.ReadAllBytes(Application.StartupPath + "\\tmp\\seccfg.img");
				int num = 0;
				string text = utils.BytesToHextring(source.Take(28).ToArray());
				string left = utils.HexToDec(utils.applyshiftKiri2(utils.BytesToHextring(source.Skip(12).Take(4).ToArray())));
				string text2 = utils.BytesToHextring(source.Skip(28).Take(32).ToArray());
				if (Operators.CompareString(text.Replace(" ", string.Empty).Substring(0, 8).ToUpper(), "4D4D4D4D", TextCompare: false) == 0 && Operators.CompareString(text.Replace(" ", string.Empty).Substring(text.Length - 8, 8).ToUpper(), "45454545", TextCompare: false) == 0)
				{
					num = 4;
				}
				if (Operators.CompareString(text.Replace(" ", string.Empty).Substring(0, 24).ToUpper(), utils.BytesToHextring(Encoding.UTF8.GetBytes("AND_SECCFG_V")), TextCompare: false) == 0)
				{
					gui.Richlog("Not Implemented", Color.Red);
					return;
				}
				if (num == 4)
				{
					string text3 = hwcrypto.hashlibsha256(text);
					string text4 = utils.BytesToHextring(await hwcrypto_sej.sej_sec_cfg_sw(utils.HexStringToBytes(text2), encrtpt: false));
					if (Operators.CompareString(text4.ToLower(), text3.ToLower(), TextCompare: false) == 0)
					{
						if (Operators.CompareString(encSecCfg, "unlock", TextCompare: false) == 0 && Operators.CompareString(left, "3", TextCompare: false) == 0)
						{
							gui.Richlog("Unlocked", Color.FromArgb(21, 87, 255), isBold: false, NextLine: true);
							return;
						}
						if (Operators.CompareString(encSecCfg, "lock", TextCompare: false) == 0 && Operators.CompareString(left, "1", TextCompare: false) == 0)
						{
							gui.Richlog("Locked", Color.FromArgb(21, 87, 255), isBold: false, NextLine: true);
							return;
						}
						if (Operators.CompareString(encSecCfg, "lock", TextCompare: false) == 0)
						{
							gui.Richlog("Unlocked", Color.FromArgb(21, 87, 255), isBold: false, NextLine: true);
							gui.Richlog("- Relocking Bootloader : ", Color.Black);
							Form1.SharedUI.ProgressBar1.Text = "Relocking...";
						}
						if (Operators.CompareString(encSecCfg, "unlock", TextCompare: false) == 0)
						{
							gui.Richlog("Locked", Color.FromArgb(21, 87, 255), isBold: false, NextLine: true);
							gui.Richlog("- Unlocking Bootloader : ", Color.Black);
							Form1.SharedUI.ProgressBar1.Text = "Unlocking...";
						}
						text = seccfg.CreateSeccfg(encSecCfg, crtical: true);
						text4 = hwcrypto.hashlibsha256(text);
						string text5 = utils.BytesToHextring(await hwcrypto_sej.sej_sec_cfg_sw(utils.HexStringToBytes(text4), encrtpt: false));
						text += text5;
						byte[] array = utils.HexStringToBytes(text);
						FileStream fileStream = new FileStream(Application.StartupPath + "\\tmp\\seccfg.img", FileMode.OpenOrCreate, FileAccess.ReadWrite);
						await fileStream.WriteAsync(array, 0, array.Length);
						fileStream.Close();
						await MtkCustomWrite.writeByPartitionName(uploadResult.Device, uploadResult.FlashInfo, "seccfg", Application.StartupPath + "\\tmp\\seccfg.img", cancelToken);
						gui.Richlog("OK", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
					}
					else
					{
						if (Operators.CompareString(encSecCfg, "unlock", TextCompare: false) == 0 && Operators.CompareString(left, "3", TextCompare: false) == 0)
						{
							gui.Richlog("Unlocked", Color.FromArgb(21, 87, 255), isBold: false, NextLine: true);
							return;
						}
						if (Operators.CompareString(encSecCfg, "lock", TextCompare: false) == 0 && Operators.CompareString(left, "1", TextCompare: false) == 0)
						{
							gui.Richlog("Locked", Color.FromArgb(21, 87, 255), isBold: false, NextLine: true);
							return;
						}
						if (Operators.CompareString(encSecCfg, "lock", TextCompare: false) == 0)
						{
							gui.Richlog("Unlocked", Color.FromArgb(21, 87, 255), isBold: false, NextLine: true);
							gui.Richlog("- Relocking Bootloader : ", Color.Black);
							Form1.SharedUI.ProgressBar1.Text = "Relocking...";
						}
						if (Operators.CompareString(encSecCfg, "unlock", TextCompare: false) == 0)
						{
							gui.Richlog("Locked", Color.FromArgb(21, 87, 255), isBold: false, NextLine: true);
							gui.Richlog("- Unlocking Bootloader : ", Color.Black);
							Form1.SharedUI.ProgressBar1.Text = "Unlocking...";
						}
						if (Operators.CompareString((await hwcrypto_sej.sej_sec_cfg_hw(uploadResult.Device, cancelToken, text2, encrypt: false)).ToLower().Replace(" ", string.Empty), text3.ToLower().Replace(" ", string.Empty), TextCompare: false) != 0)
						{
							gui.Richlog("Unknown", Color.Red, isBold: false, NextLine: true);
							return;
						}
						num = 4;
						text = seccfg.CreateSeccfg(encSecCfg, crtical: true);
						text4 = hwcrypto.hashlibsha256(text);
						text += await hwcrypto_sej.sej_sec_cfg_hw(uploadResult.Device, cancelToken, text4, encrypt: true);
						byte[] array2 = utils.HexStringToBytes(text);
						FileStream fileStream2 = new FileStream(Application.StartupPath + "\\tmp\\seccfg.img", FileMode.OpenOrCreate, FileAccess.ReadWrite);
						await fileStream2.WriteAsync(array2, 0, array2.Length);
						fileStream2.Close();
						await MtkCustomWrite.writeByPartitionName(uploadResult.Device, uploadResult.FlashInfo, "seccfg", Application.StartupPath + "\\tmp\\seccfg.img", cancelToken);
						await utils.send00000(uploadResult.Device, cancelToken, Convert.ToInt32("16"), "anuuuuuuu", string.Empty, "100");
						gui.Richlog("OK", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
					}
				}
				_ = num;
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				gui.Richlog("Failed", Color.Red);
				closingport();
				ProjectData.ClearProjectError();
			}
		}
	}

	public static async Task MethodD_18(string folderwrite, CancellationToken cancelToken = default(CancellationToken))
	{
		checked
		{
			try
			{
				if (Operators.CompareString(CHECK, "no", TextCompare: false) == 0)
				{
					return;
				}
				cancelToken.ThrowIfCancellationRequested();
				gui.Richlog("- Calculate Security : ", Color.Black);
				Form1.SharedUI.ProgressBar1.Text = "Calculateing..";
				Form1.SharedUI.ProgressBar4.Text = "0%";
				Form1.SharedUI.ProgressBar4.Value = 0;
				SerialCOM.MSL = "ENREAD";
				if (gpt.Partitions.Length > 0)
				{
					MtkGptPartition[] partitions = gpt.Partitions;
					foreach (MtkGptPartition mtkGptPartition in partitions)
					{
						if (Operators.CompareString(mtkGptPartition.Name, "md1img_a", TextCompare: false) == 0)
						{
							await WritePartition(folderwrite + "SEC1", mtkGptPartition.FirstLba * MtkSparse.sectsize, mtkGptPartition.SectorCount * MtkSparse.sectsize, cancelToken);
							break;
						}
					}
					MtkGptPartition[] partitions2 = gpt.Partitions;
					foreach (MtkGptPartition mtkGptPartition2 in partitions2)
					{
						if (Operators.CompareString(mtkGptPartition2.Name, "md1img_b", TextCompare: false) == 0)
						{
							await WritePartition(folderwrite + "SEC2", mtkGptPartition2.FirstLba * MtkSparse.sectsize, mtkGptPartition2.SectorCount * MtkSparse.sectsize, cancelToken);
							break;
						}
					}
				}
				gui.Richlog("OK", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
				Form1.SharedUI.ProgressBar4.Value = 100;
				SerialCOM.MSL = "DISREAD";
				Form1.SharedUI.ProgressBar4.Text = "0%";
				Form1.SharedUI.ProgressBar4.Value = 0;
				gui.Richlog("- Unlcok Network : ", Color.Black);
				Form1.SharedUI.ProgressBar1.Text = "Unlocking...";
				if (gpt.Partitions.Length > 0)
				{
					MtkGptPartition[] partitions3 = gpt.Partitions;
					foreach (MtkGptPartition mtkGptPartition3 in partitions3)
					{
						if (Operators.CompareString(mtkGptPartition3.Name, "nvdata", TextCompare: false) == 0)
						{
							string text = utils.LongToHex(mtkGptPartition3.FirstLba * MtkSparse.sectsize);
							await FormatPartition(size: utils.HexToLong(utils.LongToHex(mtkGptPartition3.SectorCount * MtkSparse.sectsize).Replace(" ", "").Replace("0x", "")), address: utils.HexToLong(text.Replace(" ", "").Replace("0x", "")), cancelToken: cancelToken);
						}
						if (Operators.CompareString(mtkGptPartition3.Name, "nvram", TextCompare: false) == 0)
						{
							string text2 = utils.LongToHex(mtkGptPartition3.FirstLba * MtkSparse.sectsize);
							await FormatPartition(size: utils.HexToLong(utils.LongToHex(mtkGptPartition3.SectorCount * MtkSparse.sectsize).Replace(" ", "").Replace("0x", "")), address: utils.HexToLong(text2.Replace(" ", "").Replace("0x", "")), cancelToken: cancelToken);
						}
						if (Operators.CompareString(mtkGptPartition3.Name, "protect1", TextCompare: false) == 0)
						{
							string text3 = utils.LongToHex(mtkGptPartition3.FirstLba * MtkSparse.sectsize);
							await FormatPartition(size: utils.HexToLong(utils.LongToHex(mtkGptPartition3.SectorCount * MtkSparse.sectsize).Replace(" ", "").Replace("0x", "")), address: utils.HexToLong(text3.Replace(" ", "").Replace("0x", "")), cancelToken: cancelToken);
						}
						if (Operators.CompareString(mtkGptPartition3.Name, "frp", TextCompare: false) == 0)
						{
							string text4 = utils.LongToHex(mtkGptPartition3.FirstLba * MtkSparse.sectsize);
							await FormatPartition(size: utils.HexToLong(utils.LongToHex(mtkGptPartition3.SectorCount * MtkSparse.sectsize).Replace(" ", "").Replace("0x", "")), address: utils.HexToLong(text4.Replace(" ", "").Replace("0x", "")), cancelToken: cancelToken);
						}
						if (Operators.CompareString(mtkGptPartition3.Name, "protect2", TextCompare: false) == 0)
						{
							string text5 = utils.LongToHex(mtkGptPartition3.FirstLba * MtkSparse.sectsize);
							await FormatPartition(size: utils.HexToLong(utils.LongToHex(mtkGptPartition3.SectorCount * MtkSparse.sectsize).Replace(" ", "").Replace("0x", "")), address: utils.HexToLong(text5.Replace(" ", "").Replace("0x", "")), cancelToken: cancelToken);
						}
					}
				}
				gui.Richlog("OK", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
				gui.Richlog("- Verfing SimLock : ", Color.Black);
				Form1.SharedUI.ProgressBar1.Text = "Verfing...";
				gui.Richlog("Unlocked", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
				gui.Richlog("- Reboot Device : ", Color.Black);
				Form1.SharedUI.ProgressBar1.Text = "Rebooting...";
				await MtkDaxUploadBootService.RebootAsync(uploadResult.Device, cancelToken);
				gui.Richlog("OK", Color.FromArgb(0, 85, 207));
				closingport2();
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				gui.Richlog("Failed", Color.Red);
				closingport();
				ProjectData.ClearProjectError();
			}
		}
	}

	public static async Task MethodD_19(string folderwrite, CancellationToken cancelToken = default(CancellationToken))
	{
		checked
		{
			try
			{
				if (Operators.CompareString(CHECK, "no", TextCompare: false) == 0)
				{
					return;
				}
				cancelToken.ThrowIfCancellationRequested();
				gui.Richlog("OK", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
				await ReadGPT(cancelToken, showlist: false);
				Form1.SharedUI.ProgressBar4.Text = "0%";
				Form1.SharedUI.ProgressBar4.Value = 0;
				SerialCOM.MSL = "ENREAD";
				Form1.SharedUI.ProgressBar4.Text = "Calculating..";
				if (gpt.Partitions.Length > 0)
				{
					MtkGptPartition[] partitions = gpt.Partitions;
					foreach (MtkGptPartition mtkGptPartition in partitions)
					{
						if (Operators.CompareString(mtkGptPartition.Name, "steady", TextCompare: false) == 0)
						{
							string text = utils.LongToHex(mtkGptPartition.FirstLba * MtkSparse.sectsize);
							await FormatPartition(size: utils.HexToLong(utils.LongToHex(mtkGptPartition.SectorCount * MtkSparse.sectsize).Replace(" ", "").Replace("0x", "")), address: utils.HexToLong(text.Replace(" ", "").Replace("0x", "")), cancelToken: cancelToken);
						}
					}
				}
				gui.Richlog("- Write EMToken : ", Color.Black);
				await MtkCustomWrite.writeByPartitionName(uploadResult.Device, uploadResult.FlashInfo, "steady", folderwrite + "SEC1", cancelToken);
				Form1.SharedUI.ProgressBar4.Value = 100;
				SerialCOM.MSL = "DISREAD";
				Form1.SharedUI.ProgressBar4.Text = "0%";
				Form1.SharedUI.ProgressBar4.Value = 0;
				gui.Richlog("OK", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
				gui.Richlog("- Reboot Device : ", Color.Black);
				Form1.SharedUI.ProgressBar1.Text = "Rebooting...";
				await MtkDaxUploadBootService.RebootAsync(uploadResult.Device, cancelToken);
				gui.Richlog("OK", Color.FromArgb(0, 85, 207));
				closingport2();
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				gui.Richlog("Failed", Color.Red);
				closingport();
				ProjectData.ClearProjectError();
			}
		}
	}

	public static async Task MethodD_20(string folderbackup, string folderwrite, CancellationToken cancelToken = default(CancellationToken))
	{
		checked
		{
			try
			{
				if (Operators.CompareString(CHECK, "no", TextCompare: false) == 0)
				{
					return;
				}
				cancelToken.ThrowIfCancellationRequested();
				await ReadGPT(cancelToken, showlist: false);
				Form1.SharedUI.ProgressBar4.Text = "0%";
				Form1.SharedUI.ProgressBar4.Value = 0;
				SerialCOM.MSL = "ENREAD";
				if (!File.Exists(folderbackup + "SEC2"))
				{
					gui.Richlog("- Reading Security : ", Color.Black);
					if (gpt.Partitions.Length > 0)
					{
						MtkGptPartition[] partitions = gpt.Partitions;
						foreach (MtkGptPartition mtkGptPartition in partitions)
						{
							if (Operators.CompareString(mtkGptPartition.Name, "md1img", TextCompare: false) == 0)
							{
								string text = utils.LongToHex(mtkGptPartition.FirstLba * MtkSparse.sectsize);
								string text2 = utils.LongToHex(mtkGptPartition.SectorCount * MtkSparse.sectsize);
								await ReadPartition(mtkGptPartition.Name, folderbackup, "SEC1", utils.HexToLong(text.Replace(" ", "").Replace("0x", "")), utils.HexToLong(text2.Replace(" ", "").Replace("0x", "")), cancelToken);
								break;
							}
						}
						MtkGptPartition[] partitions2 = gpt.Partitions;
						foreach (MtkGptPartition mtkGptPartition2 in partitions2)
						{
							if (Operators.CompareString(mtkGptPartition2.Name, "proinfo", TextCompare: false) == 0)
							{
								string text3 = utils.LongToHex(mtkGptPartition2.FirstLba * MtkSparse.sectsize);
								string text4 = utils.LongToHex(mtkGptPartition2.SectorCount * MtkSparse.sectsize);
								await ReadPartition(mtkGptPartition2.Name, folderbackup, "SEC2", utils.HexToLong(text3.Replace(" ", "").Replace("0x", "")), utils.HexToLong(text4.Replace(" ", "").Replace("0x", "")), cancelToken);
								break;
							}
						}
					}
					Form1.SharedUI.ProgressBar4.Value = 100;
					SerialCOM.MSL = "DISREAD";
					Form1.SharedUI.ProgressBar4.Text = "0%";
					Form1.SharedUI.ProgressBar4.Value = 0;
					gui.Richlog("OK", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
				}
				gui.Richlog("- Unlock Network : ", Color.Black);
				Form1.SharedUI.ProgressBar1.Text = "Calculating..";
				if (gpt.Partitions.Length > 0)
				{
					MtkGptPartition[] partitions3 = gpt.Partitions;
					foreach (MtkGptPartition mtkGptPartition3 in partitions3)
					{
						if (Operators.CompareString(mtkGptPartition3.Name, "md1img", TextCompare: false) == 0)
						{
							await WritePartition(folderwrite + "SEC1", mtkGptPartition3.FirstLba * MtkSparse.sectsize, mtkGptPartition3.SectorCount * MtkSparse.sectsize, cancelToken);
							break;
						}
					}
					MtkGptPartition[] partitions4 = gpt.Partitions;
					foreach (MtkGptPartition mtkGptPartition4 in partitions4)
					{
						if (Operators.CompareString(mtkGptPartition4.Name, "proinfo", TextCompare: false) == 0)
						{
							await WritePartition(folderwrite + "SEC2", mtkGptPartition4.FirstLba * MtkSparse.sectsize, mtkGptPartition4.SectorCount * MtkSparse.sectsize, cancelToken);
							break;
						}
					}
				}
				Form1.SharedUI.ProgressBar1.Text = "Calculating..OK";
				gui.Richlog("OK", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
				gui.Richlog("- Verfing SimLock : ", Color.Black);
				Form1.SharedUI.ProgressBar1.Text = "Verfing...";
				gui.Richlog("Unlocked", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
				gui.Richlog("- Reboot Device : ", Color.Black);
				Form1.SharedUI.ProgressBar1.Text = "Rebooting...";
				await MtkDaxUploadBootService.RebootAsync(uploadResult.Device, cancelToken);
				gui.Richlog("OK", Color.FromArgb(0, 85, 207));
				closingport2();
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				gui.Richlog("Failed", Color.Red);
				closingport();
				ProjectData.ClearProjectError();
			}
		}
	}

	public static async Task MethodD_21(string folderbackup, CancellationToken cancelToken = default(CancellationToken))
	{
		checked
		{
			try
			{
				if (Operators.CompareString(CHECK, "no", TextCompare: false) == 0)
				{
					return;
				}
				cancelToken.ThrowIfCancellationRequested();
				await ReadGPT(cancelToken, showlist: false);
				if (File.Exists(folderbackup + "SEC4"))
				{
					return;
				}
				Form1.SharedUI.ProgressBar4.Text = "0%";
				Form1.SharedUI.ProgressBar4.Value = 0;
				SerialCOM.MSL = "ENREAD";
				gui.Richlog("- Reading Security : ", Color.Black);
				if (gpt.Partitions.Length > 0)
				{
					MtkGptPartition[] partitions = gpt.Partitions;
					foreach (MtkGptPartition mtkGptPartition in partitions)
					{
						if (Operators.CompareString(mtkGptPartition.Name, "nvdata", TextCompare: false) == 0)
						{
							await ReadPartition(mtkGptPartition.Name, folderbackup, "SEC1", mtkGptPartition.FirstLba * MtkSparse.sectsize, mtkGptPartition.SectorCount * MtkSparse.sectsize, cancelToken);
							break;
						}
					}
					MtkGptPartition[] partitions2 = gpt.Partitions;
					foreach (MtkGptPartition mtkGptPartition2 in partitions2)
					{
						if (Operators.CompareString(mtkGptPartition2.Name, "nvram", TextCompare: false) == 0)
						{
							await ReadPartition(mtkGptPartition2.Name, folderbackup, "SEC2", mtkGptPartition2.FirstLba * MtkSparse.sectsize, mtkGptPartition2.SectorCount * MtkSparse.sectsize, cancelToken);
							break;
						}
					}
					MtkGptPartition[] partitions3 = gpt.Partitions;
					foreach (MtkGptPartition mtkGptPartition3 in partitions3)
					{
						if (Operators.CompareString(mtkGptPartition3.Name, "protect1", TextCompare: false) == 0)
						{
							await ReadPartition(mtkGptPartition3.Name, folderbackup, "SEC3", mtkGptPartition3.FirstLba * MtkSparse.sectsize, mtkGptPartition3.SectorCount * MtkSparse.sectsize, cancelToken);
							break;
						}
					}
					MtkGptPartition[] partitions4 = gpt.Partitions;
					foreach (MtkGptPartition mtkGptPartition4 in partitions4)
					{
						if (Operators.CompareString(mtkGptPartition4.Name, "protect2", TextCompare: false) == 0)
						{
							await ReadPartition(mtkGptPartition4.Name, folderbackup, "SEC4", mtkGptPartition4.FirstLba * MtkSparse.sectsize, mtkGptPartition4.SectorCount * MtkSparse.sectsize, cancelToken);
							break;
						}
					}
				}
				gui.Richlog("OK", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
				Form1.SharedUI.ProgressBar4.Value = 100;
				Form1.SharedUI.ProgressBar4.Text = "0%";
				Form1.SharedUI.ProgressBar4.Value = 0;
				SerialCOM.MSL = "DISREAD";
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				gui.Richlog("Failed", Color.Red);
				closingport();
				ProjectData.ClearProjectError();
			}
		}
	}

	public static async Task MethodD_22(CancellationToken cancelToken = default(CancellationToken), string encSecCfg = "unlock")
	{
		checked
		{
			try
			{
				if (Operators.CompareString(CHECK, "no", TextCompare: false) == 0)
				{
					return;
				}
				gui.Richlog("- Calculate Security : ", Color.Black);
				Form1.SharedUI.ProgressBar1.Text = "Calculateing...";
				if (File.Exists(Application.StartupPath + "\\tmp\\seccfg.img"))
				{
					File.Delete(Application.StartupPath + "\\tmp\\seccfg.img");
				}
				if (gpt.Partitions.Length > 0)
				{
					string foldersave = Application.StartupPath + "\\tmp\\";
					MtkGptPartition[] partitions = gpt.Partitions;
					foreach (MtkGptPartition mtkGptPartition in partitions)
					{
						if (Operators.CompareString(mtkGptPartition.Name, "seccfg", TextCompare: false) == 0)
						{
							await ReadPartition2("seccfg", foldersave, mtkGptPartition.FirstLba * MtkSparse.sectsize, mtkGptPartition.SectorCount * MtkSparse.sectsize, cancelToken);
							break;
						}
					}
				}
				if (!File.Exists(Application.StartupPath + "\\tmp\\seccfg.img"))
				{
					return;
				}
				byte[] source = File.ReadAllBytes(Application.StartupPath + "\\tmp\\seccfg.img");
				int num = 0;
				string text = utils.BytesToHextring(source.Take(28).ToArray());
				string left = utils.HexToDec(utils.applyshiftKiri2(utils.BytesToHextring(source.Skip(12).Take(4).ToArray())));
				string text2 = utils.BytesToHextring(source.Skip(28).Take(32).ToArray());
				if (Operators.CompareString(text.Replace(" ", string.Empty).Substring(0, 8).ToUpper(), "4D4D4D4D", TextCompare: false) == 0 && Operators.CompareString(text.Replace(" ", string.Empty).Substring(text.Length - 8, 8).ToUpper(), "45454545", TextCompare: false) == 0)
				{
					num = 4;
				}
				if (Operators.CompareString(text.Replace(" ", string.Empty).Substring(0, 24).ToUpper(), utils.BytesToHextring(Encoding.UTF8.GetBytes("AND_SECCFG_V")), TextCompare: false) == 0)
				{
					gui.Richlog("Not Implemented", Color.Red);
					return;
				}
				if (num == 4)
				{
					string text3 = hwcrypto.hashlibsha256(text);
					string text4 = utils.BytesToHextring(await hwcrypto_sej.sej_sec_cfg_sw(utils.HexStringToBytes(text2), encrtpt: false));
					if (Operators.CompareString(text4.ToLower(), text3.ToLower(), TextCompare: false) == 0)
					{
						gui.Richlog("OK", Color.FromArgb(21, 87, 255), isBold: false, NextLine: true);
						gui.Richlog("- Generation Unlock : ", Color.Black);
						Form1.SharedUI.ProgressBar1.Text = "Generation...";
						if (Operators.CompareString(encSecCfg, "unlock", TextCompare: false) == 0 && Operators.CompareString(left, "3", TextCompare: false) == 0)
						{
							return;
						}
						text = seccfg.CreateSeccfg(encSecCfg, crtical: true);
						text4 = hwcrypto.hashlibsha256(text);
						string text5 = utils.BytesToHextring(await hwcrypto_sej.sej_sec_cfg_sw(utils.HexStringToBytes(text4), encrtpt: false));
						text += text5;
						byte[] array = utils.HexStringToBytes(text);
						FileStream fileStream = new FileStream(Application.StartupPath + "\\tmp\\seccfg.img", FileMode.OpenOrCreate, FileAccess.ReadWrite);
						await fileStream.WriteAsync(array, 0, array.Length);
						fileStream.Close();
						await MtkCustomWrite.writeByPartitionName(uploadResult.Device, uploadResult.FlashInfo, "seccfg", Application.StartupPath + "\\tmp\\seccfg.img", cancelToken);
					}
					else
					{
						gui.Richlog("OK", Color.FromArgb(21, 87, 255), isBold: false, NextLine: true);
						gui.Richlog("- Generation Unlock : ", Color.Black);
						Form1.SharedUI.ProgressBar1.Text = "Generation...";
						if (Operators.CompareString(encSecCfg, "unlock", TextCompare: false) == 0 && Operators.CompareString(left, "3", TextCompare: false) == 0)
						{
							return;
						}
						if (Operators.CompareString((await hwcrypto_sej.sej_sec_cfg_hw(uploadResult.Device, cancelToken, text2, encrypt: false)).ToLower().Replace(" ", string.Empty), text3.ToLower().Replace(" ", string.Empty), TextCompare: false) != 0)
						{
							gui.Richlog("Unknown", Color.Red, isBold: false, NextLine: true);
							return;
						}
						num = 4;
						text = seccfg.CreateSeccfg(encSecCfg, crtical: true);
						text4 = hwcrypto.hashlibsha256(text);
						text += await hwcrypto_sej.sej_sec_cfg_hw(uploadResult.Device, cancelToken, text4, encrypt: true);
						byte[] array2 = utils.HexStringToBytes(text);
						FileStream fileStream2 = new FileStream(Application.StartupPath + "\\tmp\\seccfg.img", FileMode.OpenOrCreate, FileAccess.ReadWrite);
						await fileStream2.WriteAsync(array2, 0, array2.Length);
						fileStream2.Close();
						await MtkCustomWrite.writeByPartitionName(uploadResult.Device, uploadResult.FlashInfo, "seccfg", Application.StartupPath + "\\tmp\\seccfg.img", cancelToken);
						await utils.send00000(uploadResult.Device, cancelToken, Convert.ToInt32("16"), "anuuuuuuu", string.Empty, "100");
					}
				}
				_ = num;
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				gui.Richlog("Failed", Color.Red);
				closingport();
				ProjectData.ClearProjectError();
			}
		}
	}

	public static async Task MethodD_23(CancellationToken cancelToken = default(CancellationToken))
	{
		checked
		{
			try
			{
				if (Operators.CompareString(CHECK, "no", TextCompare: false) == 0)
				{
					return;
				}
				cancelToken.ThrowIfCancellationRequested();
				gui.Richlog("OK", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
				gui.Richlog("- Unlock Network : ", Color.Black);
				Form1.SharedUI.ProgressBar1.Text = "Unlocking...";
				if (gpt.Partitions.Length > 0)
				{
					MtkGptPartition[] partitions = gpt.Partitions;
					foreach (MtkGptPartition mtkGptPartition in partitions)
					{
						if (Operators.CompareString(mtkGptPartition.Name, "nvdata", TextCompare: false) == 0)
						{
							string text = utils.LongToHex(mtkGptPartition.FirstLba * MtkSparse.sectsize);
							await FormatPartition(size: utils.HexToLong(utils.LongToHex(mtkGptPartition.SectorCount * MtkSparse.sectsize).Replace(" ", "").Replace("0x", "")), address: utils.HexToLong(text.Replace(" ", "").Replace("0x", "")), cancelToken: cancelToken);
						}
						if (Operators.CompareString(mtkGptPartition.Name, "nvram", TextCompare: false) == 0)
						{
							string text2 = utils.LongToHex(mtkGptPartition.FirstLba * MtkSparse.sectsize);
							await FormatPartition(size: utils.HexToLong(utils.LongToHex(mtkGptPartition.SectorCount * MtkSparse.sectsize).Replace(" ", "").Replace("0x", "")), address: utils.HexToLong(text2.Replace(" ", "").Replace("0x", "")), cancelToken: cancelToken);
						}
						if (Operators.CompareString(mtkGptPartition.Name, "userdata", TextCompare: false) == 0)
						{
							string text3 = utils.LongToHex(mtkGptPartition.FirstLba * MtkSparse.sectsize);
							await FormatPartition(size: utils.HexToLong(utils.LongToHex(mtkGptPartition.SectorCount * MtkSparse.sectsize).Replace(" ", "").Replace("0x", "")), address: utils.HexToLong(text3.Replace(" ", "").Replace("0x", "")), cancelToken: cancelToken);
						}
						if (Operators.CompareString(mtkGptPartition.Name, "frp", TextCompare: false) == 0)
						{
							string text4 = utils.LongToHex(mtkGptPartition.FirstLba * MtkSparse.sectsize);
							await FormatPartition(size: utils.HexToLong(utils.LongToHex(mtkGptPartition.SectorCount * MtkSparse.sectsize).Replace(" ", "").Replace("0x", "")), address: utils.HexToLong(text4.Replace(" ", "").Replace("0x", "")), cancelToken: cancelToken);
						}
						if (Operators.CompareString(mtkGptPartition.Name, "simlock", TextCompare: false) == 0)
						{
							string text5 = utils.LongToHex(mtkGptPartition.FirstLba * MtkSparse.sectsize);
							await FormatPartition(size: utils.HexToLong(utils.LongToHex(mtkGptPartition.SectorCount * MtkSparse.sectsize).Replace(" ", "").Replace("0x", "")), address: utils.HexToLong(text5.Replace(" ", "").Replace("0x", "")), cancelToken: cancelToken);
						}
						if (Operators.CompareString(mtkGptPartition.Name, "metadata", TextCompare: false) == 0)
						{
							string text6 = utils.LongToHex(mtkGptPartition.FirstLba * MtkSparse.sectsize);
							await FormatPartition(size: utils.HexToLong(utils.LongToHex(mtkGptPartition.SectorCount * MtkSparse.sectsize).Replace(" ", "").Replace("0x", "")), address: utils.HexToLong(text6.Replace(" ", "").Replace("0x", "")), cancelToken: cancelToken);
						}
						if (Operators.CompareString(mtkGptPartition.Name, "cache", TextCompare: false) == 0)
						{
							string text7 = utils.LongToHex(mtkGptPartition.FirstLba * MtkSparse.sectsize);
							await FormatPartition(size: utils.HexToLong(utils.LongToHex(mtkGptPartition.SectorCount * MtkSparse.sectsize).Replace(" ", "").Replace("0x", "")), address: utils.HexToLong(text7.Replace(" ", "").Replace("0x", "")), cancelToken: cancelToken);
						}
					}
				}
				gui.Richlog("OK", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
				gui.Richlog("- Verfing SimLock : ", Color.Black);
				Form1.SharedUI.ProgressBar1.Text = "Verfing...";
				gui.Richlog("Unlocked", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
				gui.Richlog("- Reboot Device : ", Color.Black);
				Form1.SharedUI.ProgressBar1.Text = "Rebooting...";
				await MtkDaxUploadBootService.RebootAsync(uploadResult.Device, cancelToken);
				gui.Richlog("OK", Color.FromArgb(0, 85, 207));
				closingport2();
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				gui.Richlog("Failed", Color.Red);
				closingport();
				ProjectData.ClearProjectError();
			}
		}
	}

	public static async Task Unlock_Code_1(string folderbackup, string folderwrite, CancellationToken cancelToken = default(CancellationToken))
	{
		checked
		{
			try
			{
				if (Operators.CompareString(CHECK, "no", TextCompare: false) == 0)
				{
					return;
				}
				cancelToken.ThrowIfCancellationRequested();
				await ReadGPT(cancelToken, showlist: false);
				if (!File.Exists(folderbackup + "SEC4"))
				{
					Form1.SharedUI.ProgressBar4.Text = "0%";
					Form1.SharedUI.ProgressBar4.Value = 0;
					SerialCOM.MSL = "ENREAD";
					gui.Richlog("- Reading Security : ", Color.Black);
					if (gpt.Partitions.Length > 0)
					{
						MtkGptPartition[] partitions = gpt.Partitions;
						foreach (MtkGptPartition mtkGptPartition in partitions)
						{
							if (Operators.CompareString(mtkGptPartition.Name, "nvdata", TextCompare: false) == 0)
							{
								string text = utils.LongToHex(mtkGptPartition.FirstLba * MtkSparse.sectsize);
								string text2 = utils.LongToHex(mtkGptPartition.SectorCount * MtkSparse.sectsize);
								await ReadPartition(mtkGptPartition.Name, folderbackup, "SEC1", utils.HexToLong(text.Replace(" ", "").Replace("0x", "")), utils.HexToLong(text2.Replace(" ", "").Replace("0x", "")), cancelToken);
								break;
							}
						}
						MtkGptPartition[] partitions2 = gpt.Partitions;
						foreach (MtkGptPartition mtkGptPartition2 in partitions2)
						{
							if (Operators.CompareString(mtkGptPartition2.Name, "nvram", TextCompare: false) == 0)
							{
								string text3 = utils.LongToHex(mtkGptPartition2.FirstLba * MtkSparse.sectsize);
								string text4 = utils.LongToHex(mtkGptPartition2.SectorCount * MtkSparse.sectsize);
								await ReadPartition(mtkGptPartition2.Name, folderbackup, "SEC2", utils.HexToLong(text3.Replace(" ", "").Replace("0x", "")), utils.HexToLong(text4.Replace(" ", "").Replace("0x", "")), cancelToken);
								break;
							}
						}
						MtkGptPartition[] partitions3 = gpt.Partitions;
						foreach (MtkGptPartition mtkGptPartition3 in partitions3)
						{
							if (Operators.CompareString(mtkGptPartition3.Name, "protect1", TextCompare: false) == 0)
							{
								string text5 = utils.LongToHex(mtkGptPartition3.FirstLba * MtkSparse.sectsize);
								string text6 = utils.LongToHex(mtkGptPartition3.SectorCount * MtkSparse.sectsize);
								await ReadPartition(mtkGptPartition3.Name, folderbackup, "SEC3", utils.HexToLong(text5.Replace(" ", "").Replace("0x", "")), utils.HexToLong(text6.Replace(" ", "").Replace("0x", "")), cancelToken);
								break;
							}
						}
						MtkGptPartition[] partitions4 = gpt.Partitions;
						foreach (MtkGptPartition mtkGptPartition4 in partitions4)
						{
							if (Operators.CompareString(mtkGptPartition4.Name, "protect2", TextCompare: false) == 0)
							{
								string text7 = utils.LongToHex(mtkGptPartition4.FirstLba * MtkSparse.sectsize);
								string text8 = utils.LongToHex(mtkGptPartition4.SectorCount * MtkSparse.sectsize);
								await ReadPartition(mtkGptPartition4.Name, folderbackup, "SEC4", utils.HexToLong(text7.Replace(" ", "").Replace("0x", "")), utils.HexToLong(text8.Replace(" ", "").Replace("0x", "")), cancelToken);
								break;
							}
						}
					}
					Form1.SharedUI.ProgressBar4.Value = 100;
					SerialCOM.MSL = "DISREAD";
					Form1.SharedUI.ProgressBar4.Text = "0%";
					Form1.SharedUI.ProgressBar4.Value = 0;
					gui.Richlog("OK", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
				}
				states_lock = "";
				gui.Richlog("- Calculate Security : ", Color.Black);
				Form1.SharedUI.ProgressBar1.Text = "Calculateing...";
				if (Conversions.ToBoolean(RuntimeHelpers.GetObjectValue(Calculating_simlock(folderbackup + "SEC3"))))
				{
					states_lock = "lock";
					if (gpt.Partitions.Length > 0)
					{
						MtkGptPartition[] partitions5 = gpt.Partitions;
						foreach (MtkGptPartition mtkGptPartition5 in partitions5)
						{
							if (Operators.CompareString(mtkGptPartition5.Name, "nvdata", TextCompare: false) == 0)
							{
								string text9 = utils.LongToHex(mtkGptPartition5.FirstLba * MtkSparse.sectsize);
								await FormatPartition(size: utils.HexToLong(utils.LongToHex(mtkGptPartition5.SectorCount * MtkSparse.sectsize).Replace(" ", "").Replace("0x", "")), address: utils.HexToLong(text9.Replace(" ", "").Replace("0x", "")), cancelToken: cancelToken);
							}
							if (Operators.CompareString(mtkGptPartition5.Name, "nvram", TextCompare: false) == 0)
							{
								string text10 = utils.LongToHex(mtkGptPartition5.FirstLba * MtkSparse.sectsize);
								await FormatPartition(size: utils.HexToLong(utils.LongToHex(mtkGptPartition5.SectorCount * MtkSparse.sectsize).Replace(" ", "").Replace("0x", "")), address: utils.HexToLong(text10.Replace(" ", "").Replace("0x", "")), cancelToken: cancelToken);
							}
							if (Operators.CompareString(mtkGptPartition5.Name, "protect1", TextCompare: false) == 0)
							{
								string text11 = utils.LongToHex(mtkGptPartition5.FirstLba * MtkSparse.sectsize);
								await FormatPartition(size: utils.HexToLong(utils.LongToHex(mtkGptPartition5.SectorCount * MtkSparse.sectsize).Replace(" ", "").Replace("0x", "")), address: utils.HexToLong(text11.Replace(" ", "").Replace("0x", "")), cancelToken: cancelToken);
							}
							if (Operators.CompareString(mtkGptPartition5.Name, "protect2", TextCompare: false) == 0)
							{
								string text12 = utils.LongToHex(mtkGptPartition5.FirstLba * MtkSparse.sectsize);
								await FormatPartition(size: utils.HexToLong(utils.LongToHex(mtkGptPartition5.SectorCount * MtkSparse.sectsize).Replace(" ", "").Replace("0x", "")), address: utils.HexToLong(text12.Replace(" ", "").Replace("0x", "")), cancelToken: cancelToken);
							}
						}
					}
					gui.Richlog("OK", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
					gui.Richlog("- Reboot Device To Normal Mode : ", Color.Black);
					Form1.SharedUI.ProgressBar1.Text = "Rebooting...";
					await MtkDaxUploadBootService.RebootAsync(uploadResult.Device, cancelToken);
					gui.Richlog("OK", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
					gui.Richlog("- Wait For ADB Connection : ", Color.Black);
					Form1.SharedUI.ProgressBar1.Text = "Waiting...";
					closingport2();
				}
				else
				{
					states_lock = "Unlock";
					gui.Richlog("OK", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
					gui.Richlog("- SimLock States : ", Color.Black);
					Form1.SharedUI.ProgressBar1.Text = "Verfing...";
					gui.Richlog("Unlocked", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
					gui.Richlog("- Reboot Device : ", Color.Black);
					Form1.SharedUI.ProgressBar1.Text = "Rebooting...";
					await MtkDaxUploadBootService.RebootAsync(uploadResult.Device, cancelToken);
					gui.Richlog("OK", Color.FromArgb(0, 85, 207));
					closingport2();
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				gui.Richlog("Failed", Color.Red);
				closingport();
				ProjectData.ClearProjectError();
			}
		}
	}

	public static async Task Unlock_Code_2(string folderbackup, string folderwrite, CancellationToken cancelToken = default(CancellationToken))
	{
		checked
		{
			try
			{
				if (Operators.CompareString(CHECK, "no", TextCompare: false) == 0)
				{
					return;
				}
				cancelToken.ThrowIfCancellationRequested();
				await ReadGPT(cancelToken, showlist: false);
				gui.Richlog("- Generation Unlock : ", Color.Black);
				Form1.SharedUI.ProgressBar1.Text = "Generation..";
				if (Conversions.ToBoolean(RuntimeHelpers.GetObjectValue(Calculating_simlock(folderwrite + "SEC3"))))
				{
					inputStream = ByteArrayToStream();
				}
				Form1.SharedUI.ProgressBar4.Text = "0%";
				Form1.SharedUI.ProgressBar4.Value = 0;
				SerialCOM.MSL = "ENREAD";
				if (gpt.Partitions.Length > 0)
				{
					MtkGptPartition[] partitions = gpt.Partitions;
					foreach (MtkGptPartition mtkGptPartition in partitions)
					{
						if (Operators.CompareString(mtkGptPartition.Name, "nvdata", TextCompare: false) == 0)
						{
							await WritePartition(folderwrite + "SEC1", mtkGptPartition.FirstLba * MtkSparse.sectsize, mtkGptPartition.SectorCount * MtkSparse.sectsize, cancelToken);
							break;
						}
					}
					MtkGptPartition[] partitions2 = gpt.Partitions;
					foreach (MtkGptPartition mtkGptPartition2 in partitions2)
					{
						if (Operators.CompareString(mtkGptPartition2.Name, "nvram", TextCompare: false) == 0)
						{
							await WritePartition(folderwrite + "SEC2", mtkGptPartition2.FirstLba * MtkSparse.sectsize, mtkGptPartition2.SectorCount * MtkSparse.sectsize, cancelToken);
							break;
						}
					}
					MtkGptPartition[] partitions3 = gpt.Partitions;
					foreach (MtkGptPartition mtkGptPartition3 in partitions3)
					{
						if (Operators.CompareString(mtkGptPartition3.Name, "protect1", TextCompare: false) == 0)
						{
							await WritePartition(inputStream, mtkGptPartition3.FirstLba * MtkSparse.sectsize, mtkGptPartition3.SectorCount * MtkSparse.sectsize, cancelToken);
							break;
						}
					}
				}
				Form1.SharedUI.ProgressBar4.Value = 100;
				Form1.SharedUI.ProgressBar4.Text = "0%";
				Form1.SharedUI.ProgressBar4.Value = 0;
				SerialCOM.MSL = "DISREAD";
				gui.Richlog("OK", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
				gui.Richlog("- Unlock Network : ", Color.Black);
				Form1.SharedUI.ProgressBar1.Text = "Unlocking..";
				gui.Richlog("OK", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
				gui.Richlog("- Verfing SimLock : ", Color.Black);
				Form1.SharedUI.ProgressBar1.Text = "Verfing...";
				gui.Richlog("Unlocked", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
				gui.Richlog("- Reboot Device : ", Color.Black);
				Form1.SharedUI.ProgressBar1.Text = "Rebooting...";
				await MtkDaxUploadBootService.RebootAsync(uploadResult.Device, cancelToken);
				gui.Richlog("OK", Color.FromArgb(0, 85, 207));
				closingport2();
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				gui.Richlog("Failed", Color.Red);
				closingport();
				ProjectData.ClearProjectError();
			}
		}
	}

	public static async Task Unlock_a125u_1(string folderbackup, string folderwrite, CancellationToken cancelToken = default(CancellationToken))
	{
		checked
		{
			try
			{
				if (Operators.CompareString(CHECK, "no", TextCompare: false) == 0)
				{
					return;
				}
				await ReadGPT(cancelToken, showlist: false);
				Form1.SharedUI.ProgressBar4.Text = "0%";
				Form1.SharedUI.ProgressBar4.Value = 0;
				SerialCOM.MSL = "ENREAD";
				gui.Richlog("- Reading Security : ", Color.Black);
				if (gpt.Partitions.Length > 0)
				{
					MtkGptPartition[] partitions = gpt.Partitions;
					foreach (MtkGptPartition mtkGptPartition in partitions)
					{
						if (Operators.CompareString(mtkGptPartition.Name, "nvdata", TextCompare: false) == 0)
						{
							string text = utils.LongToHex(mtkGptPartition.FirstLba * MtkSparse.sectsize);
							string text2 = utils.LongToHex(mtkGptPartition.SectorCount * MtkSparse.sectsize);
							await ReadPartition(mtkGptPartition.Name, folderbackup, "SEC1", utils.HexToLong(text.Replace(" ", "").Replace("0x", "")), utils.HexToLong(text2.Replace(" ", "").Replace("0x", "")), cancelToken);
							break;
						}
					}
					MtkGptPartition[] partitions2 = gpt.Partitions;
					foreach (MtkGptPartition mtkGptPartition2 in partitions2)
					{
						if (Operators.CompareString(mtkGptPartition2.Name, "nvram", TextCompare: false) == 0)
						{
							string text3 = utils.LongToHex(mtkGptPartition2.FirstLba * MtkSparse.sectsize);
							string text4 = utils.LongToHex(mtkGptPartition2.SectorCount * MtkSparse.sectsize);
							await ReadPartition(mtkGptPartition2.Name, folderbackup, "SEC2", utils.HexToLong(text3.Replace(" ", "").Replace("0x", "")), utils.HexToLong(text4.Replace(" ", "").Replace("0x", "")), cancelToken);
							break;
						}
					}
					MtkGptPartition[] partitions3 = gpt.Partitions;
					foreach (MtkGptPartition mtkGptPartition3 in partitions3)
					{
						if (Operators.CompareString(mtkGptPartition3.Name, "protect1", TextCompare: false) == 0)
						{
							string text5 = utils.LongToHex(mtkGptPartition3.FirstLba * MtkSparse.sectsize);
							string text6 = utils.LongToHex(mtkGptPartition3.SectorCount * MtkSparse.sectsize);
							await ReadPartition(mtkGptPartition3.Name, folderbackup, "SEC3", utils.HexToLong(text5.Replace(" ", "").Replace("0x", "")), utils.HexToLong(text6.Replace(" ", "").Replace("0x", "")), cancelToken);
							break;
						}
					}
					MtkGptPartition[] partitions4 = gpt.Partitions;
					foreach (MtkGptPartition mtkGptPartition4 in partitions4)
					{
						if (Operators.CompareString(mtkGptPartition4.Name, "protect2", TextCompare: false) == 0)
						{
							string text7 = utils.LongToHex(mtkGptPartition4.FirstLba * MtkSparse.sectsize);
							string text8 = utils.LongToHex(mtkGptPartition4.SectorCount * MtkSparse.sectsize);
							await ReadPartition(mtkGptPartition4.Name, folderbackup, "SEC4", utils.HexToLong(text7.Replace(" ", "").Replace("0x", "")), utils.HexToLong(text8.Replace(" ", "").Replace("0x", "")), cancelToken);
							break;
						}
					}
				}
				Form1.SharedUI.ProgressBar4.Value = 100;
				SerialCOM.MSL = "DISREAD";
				Form1.SharedUI.ProgressBar4.Text = "0%";
				Form1.SharedUI.ProgressBar4.Value = 0;
				gui.Richlog("OK", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
				gui.Richlog("- Calculate Security : ", Color.Black);
				Form1.SharedUI.ProgressBar1.Text = "Calculateing...";
				if (gpt.Partitions.Length > 0)
				{
					MtkGptPartition[] partitions5 = gpt.Partitions;
					foreach (MtkGptPartition mtkGptPartition5 in partitions5)
					{
						if (Operators.CompareString(mtkGptPartition5.Name, "nvdata", TextCompare: false) == 0)
						{
							string text9 = utils.LongToHex(mtkGptPartition5.FirstLba * MtkSparse.sectsize);
							await FormatPartition(size: utils.HexToLong(utils.LongToHex(mtkGptPartition5.SectorCount * MtkSparse.sectsize).Replace(" ", "").Replace("0x", "")), address: utils.HexToLong(text9.Replace(" ", "").Replace("0x", "")), cancelToken: cancelToken);
						}
						if (Operators.CompareString(mtkGptPartition5.Name, "nvram", TextCompare: false) == 0)
						{
							string text10 = utils.LongToHex(mtkGptPartition5.FirstLba * MtkSparse.sectsize);
							await FormatPartition(size: utils.HexToLong(utils.LongToHex(mtkGptPartition5.SectorCount * MtkSparse.sectsize).Replace(" ", "").Replace("0x", "")), address: utils.HexToLong(text10.Replace(" ", "").Replace("0x", "")), cancelToken: cancelToken);
						}
						if (Operators.CompareString(mtkGptPartition5.Name, "protect1", TextCompare: false) == 0)
						{
							string text11 = utils.LongToHex(mtkGptPartition5.FirstLba * MtkSparse.sectsize);
							await FormatPartition(size: utils.HexToLong(utils.LongToHex(mtkGptPartition5.SectorCount * MtkSparse.sectsize).Replace(" ", "").Replace("0x", "")), address: utils.HexToLong(text11.Replace(" ", "").Replace("0x", "")), cancelToken: cancelToken);
						}
						if (Operators.CompareString(mtkGptPartition5.Name, "protect2", TextCompare: false) == 0)
						{
							string text12 = utils.LongToHex(mtkGptPartition5.FirstLba * MtkSparse.sectsize);
							await FormatPartition(size: utils.HexToLong(utils.LongToHex(mtkGptPartition5.SectorCount * MtkSparse.sectsize).Replace(" ", "").Replace("0x", "")), address: utils.HexToLong(text12.Replace(" ", "").Replace("0x", "")), cancelToken: cancelToken);
						}
						if (Operators.CompareString(mtkGptPartition5.Name, "frp", TextCompare: false) == 0)
						{
							string text13 = utils.LongToHex(mtkGptPartition5.FirstLba * MtkSparse.sectsize);
							await FormatPartition(size: utils.HexToLong(utils.LongToHex(mtkGptPartition5.SectorCount * MtkSparse.sectsize).Replace(" ", "").Replace("0x", "")), address: utils.HexToLong(text13.Replace(" ", "").Replace("0x", "")), cancelToken: cancelToken);
						}
						if (Operators.CompareString(mtkGptPartition5.Name, "persistent", TextCompare: false) == 0)
						{
							string text14 = utils.LongToHex(mtkGptPartition5.FirstLba * MtkSparse.sectsize);
							await FormatPartition(size: utils.HexToLong(utils.LongToHex(mtkGptPartition5.SectorCount * MtkSparse.sectsize).Replace(" ", "").Replace("0x", "")), address: utils.HexToLong(text14.Replace(" ", "").Replace("0x", "")), cancelToken: cancelToken);
						}
					}
				}
				gui.Richlog("OK", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
				gui.Richlog("- Reboot Device To Normal Mode : ", Color.Black);
				Form1.SharedUI.ProgressBar1.Text = "Rebooting...";
				await MtkDaxUploadBootService.RebootAsync(uploadResult.Device, cancelToken);
				gui.Richlog("OK", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
				gui.Richlog("- Wait For ADB Connection : ", Color.Black);
				Form1.SharedUI.ProgressBar1.Text = "Wait For Device..(" + device_info.serialno + ")";
				closingport2();
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				gui.Richlog("Failed", Color.Red);
				closingport();
				ProjectData.ClearProjectError();
			}
		}
	}

	public static async Task Unlock_a125u_2(string folderwrite, CancellationToken cancelToken = default(CancellationToken))
	{
		checked
		{
			try
			{
				if (Operators.CompareString(CHECK, "no", TextCompare: false) == 0)
				{
					return;
				}
				await ReadGPT(cancelToken, showlist: false);
				Form1.SharedUI.ProgressBar4.Text = "0%";
				Form1.SharedUI.ProgressBar4.Value = 0;
				SerialCOM.MSL = "ENREAD";
				gui.Richlog("- Generation Unlock : ", Color.Black);
				Form1.SharedUI.ProgressBar1.Text = "Generation..";
				if (gpt.Partitions.Length > 0)
				{
					MtkGptPartition[] partitions = gpt.Partitions;
					foreach (MtkGptPartition mtkGptPartition in partitions)
					{
						if (Operators.CompareString(mtkGptPartition.Name, "nvdata", TextCompare: false) == 0)
						{
							await WritePartition(folderwrite + "SEC1", mtkGptPartition.FirstLba * MtkSparse.sectsize, mtkGptPartition.SectorCount * MtkSparse.sectsize, cancelToken);
							break;
						}
					}
					MtkGptPartition[] partitions2 = gpt.Partitions;
					foreach (MtkGptPartition mtkGptPartition2 in partitions2)
					{
						if (Operators.CompareString(mtkGptPartition2.Name, "nvram", TextCompare: false) == 0)
						{
							await WritePartition(folderwrite + "SEC2", mtkGptPartition2.FirstLba * MtkSparse.sectsize, mtkGptPartition2.SectorCount * MtkSparse.sectsize, cancelToken);
							break;
						}
					}
					MtkGptPartition[] partitions3 = gpt.Partitions;
					foreach (MtkGptPartition mtkGptPartition3 in partitions3)
					{
						if (Operators.CompareString(mtkGptPartition3.Name, "protect1", TextCompare: false) == 0)
						{
							await WritePartition(folderwrite + "SEC4", mtkGptPartition3.FirstLba * MtkSparse.sectsize, mtkGptPartition3.SectorCount * MtkSparse.sectsize, cancelToken);
							break;
						}
					}
				}
				Form1.SharedUI.ProgressBar4.Value = 100;
				SerialCOM.MSL = "DISREAD";
				Form1.SharedUI.ProgressBar4.Text = "0%";
				Form1.SharedUI.ProgressBar4.Value = 0;
				gui.Richlog("OK", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
				gui.Richlog("- Unlocking Network : ", Color.Black);
				Form1.SharedUI.ProgressBar1.Text = "Unlocking..";
				gui.Richlog("OK", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
				gui.Richlog("- Verfing SimLock : ", Color.Black);
				Form1.SharedUI.ProgressBar1.Text = "Verfing...";
				gui.Richlog("Unlocked", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
				gui.Richlog("- Reboot Device : ", Color.Black);
				Form1.SharedUI.ProgressBar1.Text = "Rebooting...";
				await MtkDaxUploadBootService.RebootAsync(uploadResult.Device, cancelToken);
				gui.Richlog("OK", Color.FromArgb(0, 85, 207));
				closingport2();
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				gui.Richlog("Failed", Color.Red);
				closingport();
				ProjectData.ClearProjectError();
			}
		}
	}

	public static async Task Unlock_a125u_3_eres(CancellationToken cancelToken = default(CancellationToken))
	{
		checked
		{
			try
			{
				if (Operators.CompareString(CHECK, "no", TextCompare: false) == 0)
				{
					return;
				}
				await ReadGPT(cancelToken, showlist: false);
				gui.Richlog("- Calculate Security : ", Color.Black);
				Form1.SharedUI.ProgressBar1.Text = "Calculateing...";
				if (gpt.Partitions.Length > 0)
				{
					MtkGptPartition[] partitions = gpt.Partitions;
					foreach (MtkGptPartition mtkGptPartition in partitions)
					{
						if (Operators.CompareString(mtkGptPartition.Name, "nvdata", TextCompare: false) == 0)
						{
							string text = utils.LongToHex(mtkGptPartition.FirstLba * MtkSparse.sectsize);
							await FormatPartition(size: utils.HexToLong(utils.LongToHex(mtkGptPartition.SectorCount * MtkSparse.sectsize).Replace(" ", "").Replace("0x", "")), address: utils.HexToLong(text.Replace(" ", "").Replace("0x", "")), cancelToken: cancelToken);
						}
						if (Operators.CompareString(mtkGptPartition.Name, "nvram", TextCompare: false) == 0)
						{
							string text2 = utils.LongToHex(mtkGptPartition.FirstLba * MtkSparse.sectsize);
							await FormatPartition(size: utils.HexToLong(utils.LongToHex(mtkGptPartition.SectorCount * MtkSparse.sectsize).Replace(" ", "").Replace("0x", "")), address: utils.HexToLong(text2.Replace(" ", "").Replace("0x", "")), cancelToken: cancelToken);
						}
						if (Operators.CompareString(mtkGptPartition.Name, "protect1", TextCompare: false) == 0)
						{
							string text3 = utils.LongToHex(mtkGptPartition.FirstLba * MtkSparse.sectsize);
							await FormatPartition(size: utils.HexToLong(utils.LongToHex(mtkGptPartition.SectorCount * MtkSparse.sectsize).Replace(" ", "").Replace("0x", "")), address: utils.HexToLong(text3.Replace(" ", "").Replace("0x", "")), cancelToken: cancelToken);
						}
						if (Operators.CompareString(mtkGptPartition.Name, "protect2", TextCompare: false) == 0)
						{
							string text4 = utils.LongToHex(mtkGptPartition.FirstLba * MtkSparse.sectsize);
							await FormatPartition(size: utils.HexToLong(utils.LongToHex(mtkGptPartition.SectorCount * MtkSparse.sectsize).Replace(" ", "").Replace("0x", "")), address: utils.HexToLong(text4.Replace(" ", "").Replace("0x", "")), cancelToken: cancelToken);
						}
					}
				}
				gui.Richlog("OK", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
				gui.Richlog("- Reboot Device To Normal Mode : ", Color.Black);
				Form1.SharedUI.ProgressBar1.Text = "Rebooting...";
				await MtkDaxUploadBootService.RebootAsync(uploadResult.Device, cancelToken);
				gui.Richlog("OK", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
				gui.Richlog("- Wait For ADB Connection : ", Color.Black);
				Form1.SharedUI.ProgressBar1.Text = "Waiting...";
				closingport2();
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				gui.Richlog("Failed", Color.Red);
				closingport();
				ProjectData.ClearProjectError();
			}
		}
	}

	public static async Task Unlock_a125u_restor(string folderwrite, CancellationToken cancelToken = default(CancellationToken))
	{
		checked
		{
			try
			{
				if (Operators.CompareString(CHECK, "no", TextCompare: false) == 0)
				{
					return;
				}
				cancelToken.ThrowIfCancellationRequested();
				await ReadGPT(cancelToken, showlist: false);
				Form1.SharedUI.ProgressBar4.Text = "0%";
				Form1.SharedUI.ProgressBar4.Value = 0;
				SerialCOM.MSL = "ENREAD";
				gui.Richlog("- Writing Security : ", Color.Black);
				if (gpt.Partitions.Length > 0)
				{
					MtkGptPartition[] partitions = gpt.Partitions;
					foreach (MtkGptPartition mtkGptPartition in partitions)
					{
						if (Operators.CompareString(mtkGptPartition.Name, "nvdata", TextCompare: false) == 0)
						{
							await WritePartition(folderwrite + "SEC1", mtkGptPartition.FirstLba * MtkSparse.sectsize, mtkGptPartition.SectorCount * MtkSparse.sectsize, cancelToken);
							break;
						}
					}
					MtkGptPartition[] partitions2 = gpt.Partitions;
					foreach (MtkGptPartition mtkGptPartition2 in partitions2)
					{
						if (Operators.CompareString(mtkGptPartition2.Name, "nvram", TextCompare: false) == 0)
						{
							await WritePartition(folderwrite + "SEC2", mtkGptPartition2.FirstLba * MtkSparse.sectsize, mtkGptPartition2.SectorCount * MtkSparse.sectsize, cancelToken);
							break;
						}
					}
					MtkGptPartition[] partitions3 = gpt.Partitions;
					foreach (MtkGptPartition mtkGptPartition3 in partitions3)
					{
						if (Operators.CompareString(mtkGptPartition3.Name, "protect1", TextCompare: false) == 0)
						{
							await WritePartition(folderwrite + "SEC3", mtkGptPartition3.FirstLba * MtkSparse.sectsize, mtkGptPartition3.SectorCount * MtkSparse.sectsize, cancelToken);
							break;
						}
					}
					MtkGptPartition[] partitions4 = gpt.Partitions;
					foreach (MtkGptPartition mtkGptPartition4 in partitions4)
					{
						if (Operators.CompareString(mtkGptPartition4.Name, "protect2", TextCompare: false) == 0)
						{
							await WritePartition(folderwrite + "SEC4", mtkGptPartition4.FirstLba * MtkSparse.sectsize, mtkGptPartition4.SectorCount * MtkSparse.sectsize, cancelToken);
							break;
						}
					}
				}
				Form1.SharedUI.ProgressBar4.Value = 100;
				SerialCOM.MSL = "DISREAD";
				Form1.SharedUI.ProgressBar4.Text = "0%";
				Form1.SharedUI.ProgressBar4.Value = 0;
				gui.Richlog("OK", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
				gui.Richlog("- Reboot Device : ", Color.Black);
				Form1.SharedUI.ProgressBar1.Text = "Rebooting...";
				await MtkDaxUploadBootService.RebootAsync(uploadResult.Device, cancelToken);
				gui.Richlog("OK", Color.FromArgb(0, 85, 207));
				closingport2();
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				gui.Richlog("Failed", Color.Red);
				closingport();
				ProjectData.ClearProjectError();
			}
		}
	}

	public static async Task Unlock_brom_1(string folderbackup, string folderwrite, CancellationToken cancelToken = default(CancellationToken))
	{
		checked
		{
			try
			{
				if (Operators.CompareString(CHECK, "no", TextCompare: false) == 0)
				{
					return;
				}
				cancelToken.ThrowIfCancellationRequested();
				await ReadGPT(cancelToken, showlist: false);
				if (!File.Exists(folderbackup + "SEC4"))
				{
					Form1.SharedUI.ProgressBar4.Text = "0%";
					Form1.SharedUI.ProgressBar4.Value = 0;
					SerialCOM.MSL = "ENREAD";
					gui.Richlog("- Reading Security : ", Color.Black);
					if (gpt.Partitions.Length > 0)
					{
						MtkGptPartition[] partitions = gpt.Partitions;
						foreach (MtkGptPartition mtkGptPartition in partitions)
						{
							if (Operators.CompareString(mtkGptPartition.Name, "nvdata", TextCompare: false) == 0)
							{
								string text = utils.LongToHex(mtkGptPartition.FirstLba * MtkSparse.sectsize);
								string text2 = utils.LongToHex(mtkGptPartition.SectorCount * MtkSparse.sectsize);
								await ReadPartition(mtkGptPartition.Name, folderbackup, "SEC1", utils.HexToLong(text.Replace(" ", "").Replace("0x", "")), utils.HexToLong(text2.Replace(" ", "").Replace("0x", "")), cancelToken);
								break;
							}
						}
						MtkGptPartition[] partitions2 = gpt.Partitions;
						foreach (MtkGptPartition mtkGptPartition2 in partitions2)
						{
							if (Operators.CompareString(mtkGptPartition2.Name, "nvram", TextCompare: false) == 0)
							{
								string text3 = utils.LongToHex(mtkGptPartition2.FirstLba * MtkSparse.sectsize);
								string text4 = utils.LongToHex(mtkGptPartition2.SectorCount * MtkSparse.sectsize);
								await ReadPartition(mtkGptPartition2.Name, folderbackup, "SEC2", utils.HexToLong(text3.Replace(" ", "").Replace("0x", "")), utils.HexToLong(text4.Replace(" ", "").Replace("0x", "")), cancelToken);
								break;
							}
						}
						MtkGptPartition[] partitions3 = gpt.Partitions;
						foreach (MtkGptPartition mtkGptPartition3 in partitions3)
						{
							if (Operators.CompareString(mtkGptPartition3.Name, "protect1", TextCompare: false) == 0)
							{
								string text5 = utils.LongToHex(mtkGptPartition3.FirstLba * MtkSparse.sectsize);
								string text6 = utils.LongToHex(mtkGptPartition3.SectorCount * MtkSparse.sectsize);
								await ReadPartition(mtkGptPartition3.Name, folderbackup, "SEC3", utils.HexToLong(text5.Replace(" ", "").Replace("0x", "")), utils.HexToLong(text6.Replace(" ", "").Replace("0x", "")), cancelToken);
								break;
							}
						}
						MtkGptPartition[] partitions4 = gpt.Partitions;
						foreach (MtkGptPartition mtkGptPartition4 in partitions4)
						{
							if (Operators.CompareString(mtkGptPartition4.Name, "protect2", TextCompare: false) == 0)
							{
								string text7 = utils.LongToHex(mtkGptPartition4.FirstLba * MtkSparse.sectsize);
								string text8 = utils.LongToHex(mtkGptPartition4.SectorCount * MtkSparse.sectsize);
								await ReadPartition(mtkGptPartition4.Name, folderbackup, "SEC4", utils.HexToLong(text7.Replace(" ", "").Replace("0x", "")), utils.HexToLong(text8.Replace(" ", "").Replace("0x", "")), cancelToken);
								break;
							}
						}
					}
					Form1.SharedUI.ProgressBar4.Value = 100;
					Form1.SharedUI.ProgressBar4.Text = "0%";
					Form1.SharedUI.ProgressBar4.Value = 0;
					SerialCOM.MSL = "DISREAD";
					gui.Richlog("OK", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
				}
				gui.Richlog("- Calculate Security : ", Color.Black);
				Form1.SharedUI.ProgressBar1.Text = "Calculateing...";
				if (gpt.Partitions.Length > 0)
				{
					MtkGptPartition[] partitions5 = gpt.Partitions;
					foreach (MtkGptPartition mtkGptPartition5 in partitions5)
					{
						if (Operators.CompareString(mtkGptPartition5.Name, "nvdata", TextCompare: false) == 0)
						{
							string text9 = utils.LongToHex(mtkGptPartition5.FirstLba * MtkSparse.sectsize);
							await FormatPartition(size: utils.HexToLong(utils.LongToHex(mtkGptPartition5.SectorCount * MtkSparse.sectsize).Replace(" ", "").Replace("0x", "")), address: utils.HexToLong(text9.Replace(" ", "").Replace("0x", "")), cancelToken: cancelToken);
						}
						if (Operators.CompareString(mtkGptPartition5.Name, "nvram", TextCompare: false) == 0)
						{
							string text10 = utils.LongToHex(mtkGptPartition5.FirstLba * MtkSparse.sectsize);
							await FormatPartition(size: utils.HexToLong(utils.LongToHex(mtkGptPartition5.SectorCount * MtkSparse.sectsize).Replace(" ", "").Replace("0x", "")), address: utils.HexToLong(text10.Replace(" ", "").Replace("0x", "")), cancelToken: cancelToken);
						}
						if (Operators.CompareString(mtkGptPartition5.Name, "protect1", TextCompare: false) == 0)
						{
							string text11 = utils.LongToHex(mtkGptPartition5.FirstLba * MtkSparse.sectsize);
							await FormatPartition(size: utils.HexToLong(utils.LongToHex(mtkGptPartition5.SectorCount * MtkSparse.sectsize).Replace(" ", "").Replace("0x", "")), address: utils.HexToLong(text11.Replace(" ", "").Replace("0x", "")), cancelToken: cancelToken);
						}
						if (Operators.CompareString(mtkGptPartition5.Name, "protect2", TextCompare: false) == 0)
						{
							string text12 = utils.LongToHex(mtkGptPartition5.FirstLba * MtkSparse.sectsize);
							await FormatPartition(size: utils.HexToLong(utils.LongToHex(mtkGptPartition5.SectorCount * MtkSparse.sectsize).Replace(" ", "").Replace("0x", "")), address: utils.HexToLong(text12.Replace(" ", "").Replace("0x", "")), cancelToken: cancelToken);
						}
					}
				}
				gui.Richlog("OK", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
				gui.Richlog("- Reboot Device To Normal Mode : ", Color.Black);
				Form1.SharedUI.ProgressBar1.Text = "Rebooting...";
				await MtkDaxUploadBootService.RebootAsync(uploadResult.Device, cancelToken);
				gui.Richlog("OK", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
				gui.Richlog("- Wait For ADB Connection : ", Color.Black);
				Form1.SharedUI.ProgressBar1.Text = "Waiting...";
				closingport2();
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				gui.Richlog("Failed", Color.Red);
				closingport();
				ProjectData.ClearProjectError();
			}
		}
	}

	public static async Task Unlock_brom_2(string folderwrite, CancellationToken cancelToken = default(CancellationToken))
	{
		checked
		{
			try
			{
				if (Operators.CompareString(CHECK, "no", TextCompare: false) == 0)
				{
					return;
				}
				cancelToken.ThrowIfCancellationRequested();
				await ReadGPT(cancelToken, showlist: false);
				Form1.SharedUI.ProgressBar4.Text = "0%";
				Form1.SharedUI.ProgressBar4.Value = 0;
				SerialCOM.MSL = "ENREAD";
				gui.Richlog("- Generation Unlock : ", Color.Black);
				if (gpt.Partitions.Length > 0)
				{
					MtkGptPartition[] partitions = gpt.Partitions;
					foreach (MtkGptPartition mtkGptPartition in partitions)
					{
						if (Operators.CompareString(mtkGptPartition.Name, "nvdata", TextCompare: false) == 0)
						{
							await WritePartition(folderwrite + "SEC1", mtkGptPartition.FirstLba * MtkSparse.sectsize, mtkGptPartition.SectorCount * MtkSparse.sectsize, cancelToken);
							break;
						}
					}
					MtkGptPartition[] partitions2 = gpt.Partitions;
					foreach (MtkGptPartition mtkGptPartition2 in partitions2)
					{
						if (Operators.CompareString(mtkGptPartition2.Name, "nvram", TextCompare: false) == 0)
						{
							await WritePartition(folderwrite + "SEC2", mtkGptPartition2.FirstLba * MtkSparse.sectsize, mtkGptPartition2.SectorCount * MtkSparse.sectsize, cancelToken);
							break;
						}
					}
				}
				Form1.SharedUI.ProgressBar4.Value = 100;
				Form1.SharedUI.ProgressBar4.Text = "0%";
				Form1.SharedUI.ProgressBar4.Value = 0;
				SerialCOM.MSL = "DISREAD";
				gui.Richlog("OK", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
				gui.Richlog("- Unlock Network : ", Color.Black);
				Form1.SharedUI.ProgressBar1.Text = "Unlocking..";
				gui.Richlog("OK", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
				gui.Richlog("- Verfing SimLock : ", Color.Black);
				Form1.SharedUI.ProgressBar1.Text = "Verfing...";
				gui.Richlog("Unlocked", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
				gui.Richlog("- Reboot Device : ", Color.Black);
				Form1.SharedUI.ProgressBar1.Text = "Rebooting...";
				await MtkDaxUploadBootService.RebootAsync(uploadResult.Device, cancelToken);
				gui.Richlog("OK", Color.FromArgb(0, 85, 207));
				closingport2();
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				gui.Richlog("Failed", Color.Red);
				closingport();
				ProjectData.ClearProjectError();
			}
		}
	}

	public static async Task Unlock_brom_3_eres(CancellationToken cancelToken = default(CancellationToken))
	{
		checked
		{
			try
			{
				if (Operators.CompareString(CHECK, "no", TextCompare: false) == 0)
				{
					return;
				}
				await ReadGPT(cancelToken, showlist: false);
				gui.Richlog("- Calculate Security : ", Color.Black);
				Form1.SharedUI.ProgressBar1.Text = "Calculateing...";
				if (gpt.Partitions.Length > 0)
				{
					MtkGptPartition[] partitions = gpt.Partitions;
					foreach (MtkGptPartition mtkGptPartition in partitions)
					{
						if (Operators.CompareString(mtkGptPartition.Name, "nvdata", TextCompare: false) == 0)
						{
							string text = utils.LongToHex(mtkGptPartition.FirstLba * MtkSparse.sectsize);
							await FormatPartition(size: utils.HexToLong(utils.LongToHex(mtkGptPartition.SectorCount * MtkSparse.sectsize).Replace(" ", "").Replace("0x", "")), address: utils.HexToLong(text.Replace(" ", "").Replace("0x", "")), cancelToken: cancelToken);
						}
						if (Operators.CompareString(mtkGptPartition.Name, "nvram", TextCompare: false) == 0)
						{
							string text2 = utils.LongToHex(mtkGptPartition.FirstLba * MtkSparse.sectsize);
							await FormatPartition(size: utils.HexToLong(utils.LongToHex(mtkGptPartition.SectorCount * MtkSparse.sectsize).Replace(" ", "").Replace("0x", "")), address: utils.HexToLong(text2.Replace(" ", "").Replace("0x", "")), cancelToken: cancelToken);
						}
						if (Operators.CompareString(mtkGptPartition.Name, "protect1", TextCompare: false) == 0)
						{
							string text3 = utils.LongToHex(mtkGptPartition.FirstLba * MtkSparse.sectsize);
							await FormatPartition(size: utils.HexToLong(utils.LongToHex(mtkGptPartition.SectorCount * MtkSparse.sectsize).Replace(" ", "").Replace("0x", "")), address: utils.HexToLong(text3.Replace(" ", "").Replace("0x", "")), cancelToken: cancelToken);
						}
						if (Operators.CompareString(mtkGptPartition.Name, "protect2", TextCompare: false) == 0)
						{
							string text4 = utils.LongToHex(mtkGptPartition.FirstLba * MtkSparse.sectsize);
							await FormatPartition(size: utils.HexToLong(utils.LongToHex(mtkGptPartition.SectorCount * MtkSparse.sectsize).Replace(" ", "").Replace("0x", "")), address: utils.HexToLong(text4.Replace(" ", "").Replace("0x", "")), cancelToken: cancelToken);
						}
					}
				}
				gui.Richlog("OK", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
				gui.Richlog("- Reboot Device To Normal Mode : ", Color.Black);
				Form1.SharedUI.ProgressBar1.Text = "Rebooting...";
				await MtkDaxUploadBootService.RebootAsync(uploadResult.Device, cancelToken);
				gui.Richlog("OK", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
				gui.Richlog("- Wait For ADB Connection : ", Color.Black);
				Form1.SharedUI.ProgressBar1.Text = "Waiting...";
				closingport2();
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				gui.Richlog("Failed", Color.Red);
				closingport();
				ProjectData.ClearProjectError();
			}
		}
	}

	public static async Task Unlock_brom_restor(string folderwrite, CancellationToken cancelToken = default(CancellationToken))
	{
		checked
		{
			try
			{
				if (Operators.CompareString(CHECK, "no", TextCompare: false) == 0)
				{
					return;
				}
				cancelToken.ThrowIfCancellationRequested();
				await ReadGPT(cancelToken, showlist: false);
				Form1.SharedUI.ProgressBar4.Text = "0%";
				Form1.SharedUI.ProgressBar4.Value = 0;
				SerialCOM.MSL = "ENREAD";
				gui.Richlog("- Writing Security : ", Color.Black);
				if (gpt.Partitions.Length > 0)
				{
					MtkGptPartition[] partitions = gpt.Partitions;
					foreach (MtkGptPartition mtkGptPartition in partitions)
					{
						if (Operators.CompareString(mtkGptPartition.Name, "nvdata", TextCompare: false) == 0)
						{
							await WritePartition(folderwrite + "SEC1", mtkGptPartition.FirstLba * MtkSparse.sectsize, mtkGptPartition.SectorCount * MtkSparse.sectsize, cancelToken);
							break;
						}
					}
					MtkGptPartition[] partitions2 = gpt.Partitions;
					foreach (MtkGptPartition mtkGptPartition2 in partitions2)
					{
						if (Operators.CompareString(mtkGptPartition2.Name, "nvram", TextCompare: false) == 0)
						{
							await WritePartition(folderwrite + "SEC2", mtkGptPartition2.FirstLba * MtkSparse.sectsize, mtkGptPartition2.SectorCount * MtkSparse.sectsize, cancelToken);
							break;
						}
					}
					MtkGptPartition[] partitions3 = gpt.Partitions;
					foreach (MtkGptPartition mtkGptPartition3 in partitions3)
					{
						if (Operators.CompareString(mtkGptPartition3.Name, "protect1", TextCompare: false) == 0)
						{
							await WritePartition(folderwrite + "SEC3", mtkGptPartition3.FirstLba * MtkSparse.sectsize, mtkGptPartition3.SectorCount * MtkSparse.sectsize, cancelToken);
							break;
						}
					}
					MtkGptPartition[] partitions4 = gpt.Partitions;
					foreach (MtkGptPartition mtkGptPartition4 in partitions4)
					{
						if (Operators.CompareString(mtkGptPartition4.Name, "protect2", TextCompare: false) == 0)
						{
							await WritePartition(folderwrite + "SEC4", mtkGptPartition4.FirstLba * MtkSparse.sectsize, mtkGptPartition4.SectorCount * MtkSparse.sectsize, cancelToken);
							break;
						}
					}
				}
				Form1.SharedUI.ProgressBar4.Value = 100;
				SerialCOM.MSL = "DISREAD";
				Form1.SharedUI.ProgressBar4.Text = "0%";
				Form1.SharedUI.ProgressBar4.Value = 0;
				gui.Richlog("OK", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
				gui.Richlog("- Reboot Device : ", Color.Black);
				Form1.SharedUI.ProgressBar1.Text = "Rebooting...";
				await MtkDaxUploadBootService.RebootAsync(uploadResult.Device, cancelToken);
				gui.Richlog("OK", Color.FromArgb(0, 85, 207));
				closingport2();
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				gui.Richlog("Failed", Color.Red);
				closingport();
				ProjectData.ClearProjectError();
			}
		}
	}

	public static async Task Repairing_PGPT(CancellationToken cancelToken = default(CancellationToken))
	{
		try
		{
			if (Operators.CompareString(CHECK, "no", TextCompare: false) != 0)
			{
				cancelToken.ThrowIfCancellationRequested();
				await ReadGPT(cancelToken, showlist: false);
				gui.Richlog("- Reboot Device : ", Color.Black);
				Form1.SharedUI.ProgressBar1.Text = "Rebooting...";
				await MtkDaxUploadBootService.RebootAsync(uploadResult.Device, cancelToken);
				gui.Richlog("OK", Color.FromArgb(0, 85, 207));
				closingport2();
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			gui.Richlog("Failed", Color.Red);
			closingport();
			ProjectData.ClearProjectError();
		}
	}

	public static async Task Repairing_PMT(CancellationToken cancelToken = default(CancellationToken))
	{
		try
		{
			if (Operators.CompareString(CHECK, "no", TextCompare: false) != 0)
			{
				cancelToken.ThrowIfCancellationRequested();
				await ReadGPT(cancelToken, showlist: false);
				Form1.SharedUI.ProgressBar4.Text = "0%";
				Form1.SharedUI.ProgressBar4.Value = 0;
				SerialCOM.MSL = "ENREAD";
				await EXITTODONLOD(cancelToken);
				Form1.SharedUI.ProgressBar4.Value = 100;
				SerialCOM.MSL = "DISREAD";
				Form1.SharedUI.ProgressBar4.Text = "0%";
				Form1.SharedUI.ProgressBar4.Value = 0;
				gui.Richlog("- Reboot Device : ", Color.Black);
				Form1.SharedUI.ProgressBar1.Text = "Rebooting...";
				await MtkDaxUploadBootService.RebootAsync(uploadResult.Device, cancelToken);
				closingport2();
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			gui.Richlog("Failed", Color.Red);
			closingport();
			ProjectData.ClearProjectError();
		}
	}

	public static async Task Remove_KG(string folderbackup, CancellationToken cancelToken = default(CancellationToken))
	{
		checked
		{
			try
			{
				if (Operators.CompareString(CHECK, "no", TextCompare: false) == 0)
				{
					return;
				}
				cancelToken.ThrowIfCancellationRequested();
				await ReadGPT(cancelToken, showlist: false);
				states_lock = "";
				try
				{
					File.Delete(folderbackup + "SEC1");
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
				gui.Richlog("- Read Build Prop Info : ", Color.Black);
				Form1.SharedUI.ProgressBar1.Text = "Reading...";
				if (gpt.Partitions.Length > 0)
				{
					MtkGptPartition[] partitions = gpt.Partitions;
					foreach (MtkGptPartition mtkGptPartition in partitions)
					{
						if (Operators.CompareString(mtkGptPartition.Name, "sec_efs", TextCompare: false) == 0)
						{
							string text = utils.LongToHex(mtkGptPartition.FirstLba * MtkSparse.sectsize);
							string text2 = utils.LongToHex(mtkGptPartition.SectorCount * MtkSparse.sectsize);
							await ReadPartition(mtkGptPartition.Name, folderbackup, "SEC1", utils.HexToLong(text.Replace(" ", "").Replace("0x", "")), utils.HexToLong(text2.Replace(" ", "").Replace("0x", "")), cancelToken);
							break;
						}
					}
				}
				device_info.Brand = "samsung";
				device_info.Region = "EN-GB";
				device_info.Android = "12";
				bytes = File.ReadAllBytes(folderbackup + "SEC1");
				Hexx = ByteArrayToString(bytes);
				Stringg = HexToString(Hexx);
				try
				{
					device_info.model = ExtractFirstModel(Stringg);
					device_info.security_patch = ExtractDateFromText(Stringg);
					device_info.Software_Version = ExtractFirstSoftware_Version(Stringg);
					device_info.Software_Version = device_info.Software_Version.Substring(0, 12);
				}
				catch (Exception projectError2)
				{
					ProjectData.SetProjectError(projectError2);
					ProjectData.ClearProjectError();
				}
				Stringg = null;
				Hexx = null;
				bytes = null;
				if (Operators.CompareString(device_info.Brand, "", TextCompare: false) != 0)
				{
					gui.Richlog("OK", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
					gui.Richlog("- Manufacturer : ", Color.Black);
					gui.Richlog(device_info.Brand, Color.Green, isBold: false, NextLine: true);
				}
				if (Operators.CompareString(device_info.model, "", TextCompare: false) != 0)
				{
					gui.Richlog("- Phone Model : ", Color.Black);
					gui.Richlog(device_info.model, Color.Green, isBold: false, NextLine: true);
				}
				if (Operators.CompareString(device_info.Android, "", TextCompare: false) != 0)
				{
					gui.Richlog("- Android Version : ", Color.Black);
					gui.Richlog(AndroidCommands.AndroidName(device_info.Android), Color.Green, isBold: false, NextLine: true);
				}
				if (Operators.CompareString(device_info.Build_id, "", TextCompare: false) != 0)
				{
					gui.Richlog("- Build id : ", Color.Black);
					gui.Richlog(device_info.Build_id, Color.Green, isBold: false, NextLine: true);
				}
				if (Operators.CompareString(device_info.security_patch, "", TextCompare: false) != 0)
				{
					gui.Richlog("- Security Patch : ", Color.Black);
					gui.Richlog(device_info.security_patch, Color.Green, isBold: false, NextLine: true);
				}
				if (Operators.CompareString(device_info.Region, "", TextCompare: false) != 0)
				{
					gui.Richlog("- Region : ", Color.Black);
					gui.Richlog(device_info.Region.ToUpper(), Color.Green, isBold: false, NextLine: true);
				}
				if (Operators.CompareString(device_info.cpu_abi, "", TextCompare: false) != 0)
				{
					gui.Richlog("- Cpu Abi Type : ", Color.Black);
					gui.Richlog(device_info.cpu_abi.ToUpper(), Color.Green, isBold: false, NextLine: true);
				}
				if (Operators.CompareString(device_info.Software_Version, "", TextCompare: false) != 0)
				{
					gui.Richlog("- Software Version : ", Color.Black);
					gui.Richlog(device_info.Software_Version, Color.Green, isBold: false, NextLine: true);
				}
				gui.Richlog("- Check Model If Supported : ", Color.Black);
				if ((Operators.CompareString(Mediatek.Platform, "MT6833", TextCompare: false) != 0) | !device_info.model.Contains("SM-A326U"))
				{
					gui.Richlog("OK", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
					gui.Richlog("- Analyzing Data Server : ", Color.Black);
					Form1.SharedUI.ProgressBar1.Text = "Analyzing Server...";
					gui.Richlog("OK", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
					gui.Richlog("- Reading KG/Knox Data : ", Color.Black);
					gui.Richlog("OK", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
					gui.Richlog("- Calculate Target Data : ", Color.Black);
					Form1.SharedUI.ProgressBar1.Text = "Calculating...";
					states_lock = Calculating_KG(folderbackup + "SEC1");
					try
					{
						File.Delete(folderbackup + "SEC1");
					}
					catch (Exception projectError3)
					{
						ProjectData.SetProjectError(projectError3);
						ProjectData.ClearProjectError();
					}
					if (Operators.CompareString(states_lock, "unlock", TextCompare: false) == 0)
					{
						inputStream = ByteArrayToStream();
						gui.Richlog("OK", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
						gui.Richlog("- Remove KG/Knox Data Lock : ", Color.Black);
						Form1.SharedUI.ProgressBar1.Text = "Removeing...";
						Form1.SharedUI.ProgressBar4.Text = "0%";
						Form1.SharedUI.ProgressBar4.Value = 0;
						SerialCOM.MSL = "ENREAD";
						if (gpt.Partitions.Length > 0)
						{
							MtkGptPartition[] partitions2 = gpt.Partitions;
							foreach (MtkGptPartition mtkGptPartition2 in partitions2)
							{
								if (Operators.CompareString(mtkGptPartition2.Name, "sec_efs", TextCompare: false) == 0)
								{
									await WritePartition(inputStream, mtkGptPartition2.FirstLba * MtkSparse.sectsize, mtkGptPartition2.SectorCount * MtkSparse.sectsize, cancelToken);
									break;
								}
							}
						}
						Form1.SharedUI.ProgressBar4.Value = 100;
						Form1.SharedUI.ProgressBar4.Text = "0%";
						Form1.SharedUI.ProgressBar4.Value = 0;
						SerialCOM.MSL = "DISREAD";
						gui.Richlog("OK", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
						gui.Richlog("- Verfing KG/Knox States : ", Color.Black);
						Form1.SharedUI.ProgressBar1.Text = "Verfing...";
						gui.Richlog("Unlocked", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
						gui.Richlog("- Reboot Device : ", Color.Black);
						Form1.SharedUI.ProgressBar1.Text = "Rebooting...";
						await MtkDaxUploadBootService.RebootAsync(uploadResult.Device, cancelToken);
						gui.Richlog("OK", Color.FromArgb(0, 85, 207));
						closingport2();
					}
					else if (Operators.CompareString(states_lock, "done", TextCompare: false) == 0)
					{
						gui.Richlog("OK", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
						gui.Richlog("- Writing Data To Target : ", Color.Black);
						Form1.SharedUI.ProgressBar1.Text = "Writing...";
						gui.Richlog("OK", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
						gui.Richlog("- Remove KG/Knox Data Lock : ", Color.Black);
						Form1.SharedUI.ProgressBar1.Text = "Removeing...";
						gui.Richlog("OK", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
						gui.Richlog("- Verfing KG/Knox States : ", Color.Black);
						Form1.SharedUI.ProgressBar1.Text = "Verfing...";
						gui.Richlog("Unlocked", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
						gui.Richlog("- Reboot Device : ", Color.Black);
						Form1.SharedUI.ProgressBar1.Text = "Rebooting...";
						await MtkDaxUploadBootService.RebootAsync(uploadResult.Device, cancelToken);
						gui.Richlog("OK", Color.FromArgb(0, 85, 207));
						closingport2();
					}
					else
					{
						gui.Richlog("Failed", Color.Red, isBold: false, NextLine: true);
						gui.Richlog("- Verfing KG/Knox States : ", Color.Black);
						Form1.SharedUI.ProgressBar1.Text = "Verfing...";
						gui.Richlog("Locked", Color.Red, isBold: false, NextLine: true);
						gui.Richlog("- Reboot Device : ", Color.Black);
						Form1.SharedUI.ProgressBar1.Text = "Rebooting...";
						await MtkDaxUploadBootService.RebootAsync(uploadResult.Device, cancelToken);
						gui.Richlog("OK", Color.FromArgb(0, 85, 207));
					}
				}
				else
				{
					CHECK = "no";
					gui.Richlog("This Model Not Supported", Color.Red, isBold: false, NextLine: true);
					gui.Richlog("- Reboot Device : ", Color.Black);
					Form1.SharedUI.ProgressBar1.Text = "Rebooting...";
					await MtkDaxUploadBootService.RebootAsync(uploadResult.Device, cancelToken);
					gui.Richlog("OK", Color.FromArgb(0, 85, 207));
				}
			}
			catch (Exception projectError4)
			{
				ProjectData.SetProjectError(projectError4);
				gui.Richlog("Failed", Color.Red);
				closingport();
				ProjectData.ClearProjectError();
			}
		}
	}

	public static async Task DoUBL(CancellationToken cancelToken = default(CancellationToken), string encSecCfg = "unlock")
	{
		checked
		{
			try
			{
				gui.Richlog("- Bootloader States : ", Color.Black);
				Form1.SharedUI.ProgressBar4.Text = "0%";
				Form1.SharedUI.ProgressBar4.Value = 0;
				SerialCOM.MSL = "ENREAD";
				if (File.Exists(Application.StartupPath + "\\tmp\\seccfg.img"))
				{
					File.Delete(Application.StartupPath + "\\tmp\\seccfg.img");
				}
				await ReadGPT(cancelToken, showlist: false);
				if (gpt.Partitions.Length > 0)
				{
					string foldersave = Application.StartupPath + "\\tmp\\";
					MtkGptPartition[] partitions = gpt.Partitions;
					foreach (MtkGptPartition mtkGptPartition in partitions)
					{
						if (Operators.CompareString(mtkGptPartition.Name, "seccfg", TextCompare: false) == 0)
						{
							await ReadPartition2("seccfg", foldersave, mtkGptPartition.FirstLba * MtkSparse.sectsize, mtkGptPartition.SectorCount * MtkSparse.sectsize, cancelToken);
							break;
						}
					}
				}
				Form1.SharedUI.ProgressBar4.Value = 100;
				Form1.SharedUI.ProgressBar4.Text = "0%";
				Form1.SharedUI.ProgressBar4.Value = 0;
				SerialCOM.MSL = "DISREAD";
				if (!File.Exists(Application.StartupPath + "\\tmp\\seccfg.img"))
				{
					return;
				}
				byte[] source = File.ReadAllBytes(Application.StartupPath + "\\tmp\\seccfg.img");
				int num = 0;
				string text = utils.BytesToHextring(source.Take(28).ToArray());
				string left = utils.HexToDec(utils.applyshiftKiri2(utils.BytesToHextring(source.Skip(12).Take(4).ToArray())));
				string text2 = utils.BytesToHextring(source.Skip(28).Take(32).ToArray());
				if (Operators.CompareString(text.Replace(" ", string.Empty).Substring(0, 8).ToUpper(), "4D4D4D4D", TextCompare: false) == 0 && Operators.CompareString(text.Replace(" ", string.Empty).Substring(text.Length - 8, 8).ToUpper(), "45454545", TextCompare: false) == 0)
				{
					num = 4;
				}
				if (Operators.CompareString(text.Replace(" ", string.Empty).Substring(0, 24).ToUpper(), utils.BytesToHextring(Encoding.UTF8.GetBytes("AND_SECCFG_V")), TextCompare: false) == 0)
				{
					gui.Richlog("Not Implemented", Color.Red);
					return;
				}
				if (num == 4)
				{
					string text3 = hwcrypto.hashlibsha256(text);
					string text4 = utils.BytesToHextring(await hwcrypto_sej.sej_sec_cfg_sw(utils.HexStringToBytes(text2), encrtpt: false));
					if (Operators.CompareString(text4.ToLower(), text3.ToLower(), TextCompare: false) == 0)
					{
						if (Operators.CompareString(encSecCfg, "unlock", TextCompare: false) == 0 && Operators.CompareString(left, "3", TextCompare: false) == 0)
						{
							gui.Richlog("Unlocked", Color.FromArgb(21, 87, 255), isBold: false, NextLine: true);
							gui.Richlog("> Bootloader Allready Unlocked", Color.FromArgb(21, 87, 255));
							return;
						}
						if (Operators.CompareString(encSecCfg, "lock", TextCompare: false) == 0 && Operators.CompareString(left, "1", TextCompare: false) == 0)
						{
							gui.Richlog("Locked", Color.FromArgb(21, 87, 255), isBold: false, NextLine: true);
							gui.Richlog("> Bootloader Allready Locked", Color.FromArgb(21, 87, 255));
							return;
						}
						if (Operators.CompareString(encSecCfg, "lock", TextCompare: false) == 0)
						{
							gui.Richlog("Unlocked", Color.FromArgb(21, 87, 255), isBold: false, NextLine: true);
							gui.Richlog("- Relocking Bootloader : ", Color.Black);
							Form1.SharedUI.ProgressBar1.Text = "Relocking...";
						}
						if (Operators.CompareString(encSecCfg, "unlock", TextCompare: false) == 0)
						{
							gui.Richlog("Locked", Color.FromArgb(21, 87, 255), isBold: false, NextLine: true);
							gui.Richlog("- Unlocking Bootloader : ", Color.Black);
							Form1.SharedUI.ProgressBar1.Text = "Unlocking...";
						}
						text = seccfg.CreateSeccfg(encSecCfg, crtical: true);
						text4 = hwcrypto.hashlibsha256(text);
						string text5 = utils.BytesToHextring(await hwcrypto_sej.sej_sec_cfg_sw(utils.HexStringToBytes(text4), encrtpt: false));
						text += text5;
						byte[] array = utils.HexStringToBytes(text);
						FileStream fileStream = new FileStream(Application.StartupPath + "\\tmp\\seccfg.img", FileMode.OpenOrCreate, FileAccess.ReadWrite);
						await fileStream.WriteAsync(array, 0, array.Length);
						fileStream.Close();
						await MtkCustomWrite.writeByPartitionName(uploadResult.Device, uploadResult.FlashInfo, "seccfg", Application.StartupPath + "\\tmp\\seccfg.img", cancelToken);
					}
					else
					{
						if (Operators.CompareString(encSecCfg, "unlock", TextCompare: false) == 0 && Operators.CompareString(left, "3", TextCompare: false) == 0)
						{
							gui.Richlog("Unlocked", Color.FromArgb(21, 87, 255), isBold: false, NextLine: true);
							gui.Richlog("> Bootloader Allready Unlocked", Color.FromArgb(21, 87, 255));
							return;
						}
						if (Operators.CompareString(encSecCfg, "lock", TextCompare: false) == 0 && Operators.CompareString(left, "1", TextCompare: false) == 0)
						{
							gui.Richlog("Locked", Color.FromArgb(21, 87, 255), isBold: false, NextLine: true);
							gui.Richlog("> Bootloader Allready Locked", Color.FromArgb(21, 87, 255));
							return;
						}
						if (Operators.CompareString(encSecCfg, "lock", TextCompare: false) == 0)
						{
							gui.Richlog("Unlocked", Color.FromArgb(21, 87, 255), isBold: false, NextLine: true);
							gui.Richlog("- Relocking Bootloader : ", Color.Black);
							Form1.SharedUI.ProgressBar1.Text = "Relocking...";
						}
						if (Operators.CompareString(encSecCfg, "unlock", TextCompare: false) == 0)
						{
							gui.Richlog("Locked", Color.FromArgb(21, 87, 255), isBold: false, NextLine: true);
							gui.Richlog("- Unlocking Bootloader : ", Color.Black);
							Form1.SharedUI.ProgressBar1.Text = "Unlocking...";
						}
						if (Operators.CompareString((await hwcrypto_sej.sej_sec_cfg_hw(uploadResult.Device, cancelToken, text2, encrypt: false)).ToLower().Replace(" ", string.Empty), text3.ToLower().Replace(" ", string.Empty), TextCompare: false) != 0)
						{
							gui.Richlog("Unknown", Color.Red);
							return;
						}
						num = 4;
						text = seccfg.CreateSeccfg(encSecCfg, crtical: true);
						text4 = hwcrypto.hashlibsha256(text);
						text += await hwcrypto_sej.sej_sec_cfg_hw(uploadResult.Device, cancelToken, text4, encrypt: true);
						byte[] array2 = utils.HexStringToBytes(text);
						FileStream fileStream2 = new FileStream(Application.StartupPath + "\\tmp\\seccfg.img", FileMode.OpenOrCreate, FileAccess.ReadWrite);
						await fileStream2.WriteAsync(array2, 0, array2.Length);
						fileStream2.Close();
						await MtkCustomWrite.writeByPartitionName(uploadResult.Device, uploadResult.FlashInfo, "seccfg", Application.StartupPath + "\\tmp\\seccfg.img", cancelToken);
						gui.Richlog("OK", Color.FromArgb(21, 87, 255));
						await utils.send00000(uploadResult.Device, cancelToken, Convert.ToInt32("16"), "anuuuuuuu", string.Empty, "100");
					}
				}
				await MtkDaxUploadBootService.RebootAsync(uploadResult.Device, cancelToken);
				_ = num;
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				gui.Richlog("Failed", Color.Red);
				Protocol_MTK_By_Devronix.SharedUI.CkBromReady.Invoke((Action)([SpecialName] () =>
				{
					Protocol_MTK_By_Devronix.SharedUI.CkBromReady.Checked = false;
				}));
				closingport();
				ProjectData.ClearProjectError();
			}
		}
	}

	public static async Task String_Temp(string folderbackup, CancellationToken cancelToken = default(CancellationToken))
	{
		checked
		{
			try
			{
				if (Operators.CompareString(CHECK, "no", TextCompare: false) == 0)
				{
					return;
				}
				cancelToken.ThrowIfCancellationRequested();
				await ReadGPT(cancelToken, showlist: false);
				Form1.SharedUI.ProgressBar4.Text = "0%";
				Form1.SharedUI.ProgressBar4.Value = 0;
				SerialCOM.MSL = "ENREAD";
				gui.Richlog("- Writing Security : ", Color.Black);
				if (gpt.Partitions.Length > 0)
				{
					MtkGptPartition[] partitions = gpt.Partitions;
					foreach (MtkGptPartition mtkGptPartition in partitions)
					{
						if (Operators.CompareString(mtkGptPartition.Name, "protect1", TextCompare: false) == 0)
						{
							await WritePartition(folderbackup + "SEC1", mtkGptPartition.FirstLba * MtkSparse.sectsize, mtkGptPartition.SectorCount * MtkSparse.sectsize, cancelToken);
							break;
						}
					}
					MtkGptPartition[] partitions2 = gpt.Partitions;
					foreach (MtkGptPartition mtkGptPartition2 in partitions2)
					{
						if (Operators.CompareString(mtkGptPartition2.Name, "protect2", TextCompare: false) == 0)
						{
							await WritePartition(folderbackup + "SEC2", mtkGptPartition2.FirstLba * MtkSparse.sectsize, mtkGptPartition2.SectorCount * MtkSparse.sectsize, cancelToken);
							break;
						}
					}
				}
				Form1.SharedUI.ProgressBar4.Value = 100;
				SerialCOM.MSL = "DISREAD";
				Form1.SharedUI.ProgressBar4.Text = "0%";
				Form1.SharedUI.ProgressBar4.Value = 0;
				gui.Richlog("OK", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
				gui.Richlog("- Reboot Device : ", Color.Black);
				Form1.SharedUI.ProgressBar1.Text = "Rebooting...";
				await MtkDaxUploadBootService.RebootAsync(uploadResult.Device, cancelToken);
				gui.Richlog("OK", Color.FromArgb(0, 85, 207));
				closingport2();
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				gui.Richlog("Failed", Color.Red);
				closingport();
				ProjectData.ClearProjectError();
			}
		}
	}

	public static async Task Login_Register_Read(string folderbackup, CancellationToken cancelToken = default(CancellationToken))
	{
		checked
		{
			try
			{
				if (Operators.CompareString(CHECK, "no", TextCompare: false) == 0)
				{
					return;
				}
				cancelToken.ThrowIfCancellationRequested();
				await ReadGPT(cancelToken, showlist: false);
				Form1.SharedUI.ProgressBar4.Text = "0%";
				Form1.SharedUI.ProgressBar4.Value = 0;
				SerialCOM.MSL = "ENREAD";
				gui.Richlog("- Writing Security : ", Color.Black);
				if (gpt.Partitions.Length > 0)
				{
					MtkGptPartition[] partitions = gpt.Partitions;
					foreach (MtkGptPartition mtkGptPartition in partitions)
					{
						if (Operators.CompareString(mtkGptPartition.Name, "md1img", TextCompare: false) == 0)
						{
							await WritePartition(folderbackup + "SEC1", mtkGptPartition.FirstLba * MtkSparse.sectsize, mtkGptPartition.SectorCount * MtkSparse.sectsize, cancelToken);
							break;
						}
					}
					MtkGptPartition[] partitions2 = gpt.Partitions;
					foreach (MtkGptPartition mtkGptPartition2 in partitions2)
					{
						if (Operators.CompareString(mtkGptPartition2.Name, "md1img_a", TextCompare: false) == 0)
						{
							await WritePartition(folderbackup + "SEC1", mtkGptPartition2.FirstLba * MtkSparse.sectsize, mtkGptPartition2.SectorCount * MtkSparse.sectsize, cancelToken);
							break;
						}
					}
					MtkGptPartition[] partitions3 = gpt.Partitions;
					foreach (MtkGptPartition mtkGptPartition3 in partitions3)
					{
						if (Operators.CompareString(mtkGptPartition3.Name, "md1img_b", TextCompare: false) == 0)
						{
							await WritePartition(folderbackup + "SEC2", mtkGptPartition3.FirstLba * MtkSparse.sectsize, mtkGptPartition3.SectorCount * MtkSparse.sectsize, cancelToken);
							break;
						}
					}
				}
				Form1.SharedUI.ProgressBar4.Value = 100;
				SerialCOM.MSL = "DISREAD";
				Form1.SharedUI.ProgressBar4.Text = "0%";
				Form1.SharedUI.ProgressBar4.Value = 0;
				gui.Richlog("OK", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
				gui.Richlog("- Reboot Device : ", Color.Black);
				Form1.SharedUI.ProgressBar1.Text = "Rebooting...";
				await MtkDaxUploadBootService.RebootAsync(uploadResult.Device, cancelToken);
				gui.Richlog("OK", Color.FromArgb(0, 85, 207));
				closingport2();
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				gui.Richlog("Failed", Color.Red);
				closingport();
				ProjectData.ClearProjectError();
			}
		}
	}

	public static async Task UserName_1(string folderbackup, CancellationToken cancelToken = default(CancellationToken))
	{
		try
		{
			if (Operators.CompareString(CHECK, "no", TextCompare: false) == 0)
			{
				return;
			}
			cancelToken.ThrowIfCancellationRequested();
			await ReadGPT(cancelToken, showlist: false);
			Form1.SharedUI.ProgressBar4.Text = "0%";
			Form1.SharedUI.ProgressBar4.Value = 0;
			SerialCOM.MSL = "ENREAD";
			gui.Richlog("- Writing Security : ", Color.Black);
			if (gpt.Partitions.Length > 0)
			{
				MtkGptPartition[] partitions = gpt.Partitions;
				foreach (MtkGptPartition mtkGptPartition in partitions)
				{
					if (Operators.CompareString(mtkGptPartition.Name, "proinfo", TextCompare: false) == 0)
					{
						await checked(WritePartition(folderbackup + "SEC1", mtkGptPartition.FirstLba * MtkSparse.sectsize, mtkGptPartition.SectorCount * MtkSparse.sectsize, cancelToken));
						break;
					}
				}
			}
			Form1.SharedUI.ProgressBar4.Value = 100;
			SerialCOM.MSL = "DISREAD";
			Form1.SharedUI.ProgressBar4.Text = "0%";
			Form1.SharedUI.ProgressBar4.Value = 0;
			gui.Richlog("OK", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
			gui.Richlog("- Reboot Device : ", Color.Black);
			Form1.SharedUI.ProgressBar1.Text = "Rebooting...";
			await MtkDaxUploadBootService.RebootAsync(uploadResult.Device, cancelToken);
			gui.Richlog("OK", Color.FromArgb(0, 85, 207));
			closingport2();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			gui.Richlog("Failed", Color.Red);
			closingport();
			ProjectData.ClearProjectError();
		}
	}

	public static async Task Password_1(string folderbackup, CancellationToken cancelToken = default(CancellationToken))
	{
		checked
		{
			try
			{
				if (Operators.CompareString(CHECK, "no", TextCompare: false) == 0)
				{
					return;
				}
				cancelToken.ThrowIfCancellationRequested();
				await ReadGPT(cancelToken, showlist: false);
				Form1.SharedUI.ProgressBar4.Text = "0%";
				Form1.SharedUI.ProgressBar4.Value = 0;
				SerialCOM.MSL = "ENREAD";
				gui.Richlog("- Writing Security : ", Color.Black);
				if (gpt.Partitions.Length > 0)
				{
					MtkGptPartition[] partitions = gpt.Partitions;
					foreach (MtkGptPartition mtkGptPartition in partitions)
					{
						if (Operators.CompareString(mtkGptPartition.Name, "md1img", TextCompare: false) == 0)
						{
							await WritePartition(folderbackup + "SEC1", mtkGptPartition.FirstLba * MtkSparse.sectsize, mtkGptPartition.SectorCount * MtkSparse.sectsize, cancelToken);
							break;
						}
					}
					MtkGptPartition[] partitions2 = gpt.Partitions;
					foreach (MtkGptPartition mtkGptPartition2 in partitions2)
					{
						if (Operators.CompareString(mtkGptPartition2.Name, "proinfo", TextCompare: false) == 0)
						{
							await WritePartition(folderbackup + "SEC2", mtkGptPartition2.FirstLba * MtkSparse.sectsize, mtkGptPartition2.SectorCount * MtkSparse.sectsize, cancelToken);
							break;
						}
					}
				}
				Form1.SharedUI.ProgressBar4.Value = 100;
				SerialCOM.MSL = "DISREAD";
				Form1.SharedUI.ProgressBar4.Text = "0%";
				Form1.SharedUI.ProgressBar4.Value = 0;
				gui.Richlog("OK", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
				gui.Richlog("- Reboot Device : ", Color.Black);
				Form1.SharedUI.ProgressBar1.Text = "Rebooting...";
				await MtkDaxUploadBootService.RebootAsync(uploadResult.Device, cancelToken);
				gui.Richlog("OK", Color.FromArgb(0, 85, 207));
				closingport2();
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				gui.Richlog("Failed", Color.Red);
				closingport();
				ProjectData.ClearProjectError();
			}
		}
	}

	public static async Task String_Temp_1(string folderwrite, CancellationToken cancelToken = default(CancellationToken))
	{
		checked
		{
			try
			{
				if (Operators.CompareString(CHECK, "no", TextCompare: false) == 0)
				{
					return;
				}
				cancelToken.ThrowIfCancellationRequested();
				await ReadGPT(cancelToken, showlist: false);
				Form1.SharedUI.ProgressBar4.Text = "0%";
				Form1.SharedUI.ProgressBar4.Value = 0;
				SerialCOM.MSL = "ENREAD";
				gui.Richlog("- Writeing Modems : ", Color.Black);
				Form1.SharedUI.ProgressBar4.Text = "Calculating..";
				if (gpt.Partitions.Length > 0)
				{
					MtkGptPartition[] partitions = gpt.Partitions;
					foreach (MtkGptPartition mtkGptPartition in partitions)
					{
						if (Operators.CompareString(mtkGptPartition.Name, "md1dsp", TextCompare: false) == 0)
						{
							await WritePartition(folderwrite + "dsp1", mtkGptPartition.FirstLba * MtkSparse.sectsize, mtkGptPartition.SectorCount * MtkSparse.sectsize, cancelToken);
							break;
						}
					}
					MtkGptPartition[] partitions2 = gpt.Partitions;
					foreach (MtkGptPartition mtkGptPartition2 in partitions2)
					{
						if (Operators.CompareString(mtkGptPartition2.Name, "md1img", TextCompare: false) == 0)
						{
							await WritePartition(folderwrite + "dsp2", mtkGptPartition2.FirstLba * MtkSparse.sectsize, mtkGptPartition2.SectorCount * MtkSparse.sectsize, cancelToken);
							break;
						}
					}
				}
				Form1.SharedUI.ProgressBar4.Value = 100;
				SerialCOM.MSL = "DISREAD";
				Form1.SharedUI.ProgressBar4.Text = "0%";
				Form1.SharedUI.ProgressBar4.Value = 0;
				gui.Richlog("OK", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
				gui.Richlog("- Reboot Device To Normal Mode : ", Color.Black);
				Form1.SharedUI.ProgressBar1.Text = "Rebooting...";
				await MtkDaxUploadBootService.RebootAsync(uploadResult.Device, cancelToken);
				gui.Richlog("OK", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
				gui.Richlog("- Wait For ADB Connection : ", Color.Black);
				Form1.SharedUI.ProgressBar1.Text = "Wait For Device..(" + device_info.serialno + ")";
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				gui.Richlog("Failed", Color.Red);
				closingport();
				ProjectData.ClearProjectError();
			}
		}
	}

	public static async Task Integer_Temp_1(string folderwrite, CancellationToken cancelToken = default(CancellationToken))
	{
		try
		{
			if (Operators.CompareString(CHECK, "no", TextCompare: false) == 0)
			{
				return;
			}
			cancelToken.ThrowIfCancellationRequested();
			await ReadGPT(cancelToken, showlist: false);
			Form1.SharedUI.ProgressBar4.Text = "0%";
			Form1.SharedUI.ProgressBar4.Value = 0;
			SerialCOM.MSL = "ENREAD";
			gui.Richlog("- Writeing Modem : ", Color.Black);
			Form1.SharedUI.ProgressBar4.Text = "Calculating..";
			if (gpt.Partitions.Length > 0)
			{
				MtkGptPartition[] partitions = gpt.Partitions;
				foreach (MtkGptPartition mtkGptPartition in partitions)
				{
					if (Operators.CompareString(mtkGptPartition.Name, "md1img", TextCompare: false) == 0)
					{
						await checked(WritePartition(folderwrite + "MD1", mtkGptPartition.FirstLba * MtkSparse.sectsize, mtkGptPartition.SectorCount * MtkSparse.sectsize, cancelToken));
						break;
					}
				}
			}
			Form1.SharedUI.ProgressBar4.Value = 100;
			SerialCOM.MSL = "DISREAD";
			Form1.SharedUI.ProgressBar4.Text = "0%";
			Form1.SharedUI.ProgressBar4.Value = 0;
			gui.Richlog("OK", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
			gui.Richlog("- Reboot Device To Normal Mode : ", Color.Black);
			Form1.SharedUI.ProgressBar1.Text = "Rebooting...";
			await MtkDaxUploadBootService.RebootAsync(uploadResult.Device, cancelToken);
			gui.Richlog("OK", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
			gui.Richlog("- Wait For ADB Connection : ", Color.Black);
			Form1.SharedUI.ProgressBar1.Text = "Wait For Device..(" + device_info.serialno + ")";
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			gui.Richlog("Failed", Color.Red);
			closingport();
			ProjectData.ClearProjectError();
		}
	}

	public static byte[] HexStringToByteArray(string hex)
	{
		checked
		{
			byte[] array = new byte[unchecked(hex.Length / 2) - 1 + 1];
			int num = hex.Length - 1;
			for (int i = 0; i <= num; i += 2)
			{
				array[unchecked(i / 2)] = Convert.ToByte(hex.Substring(i, 2), 16);
			}
			return array;
		}
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

	public static string StringToHex(string inputString)
	{
		StringBuilder stringBuilder = new StringBuilder();
		foreach (char value in inputString)
		{
			stringBuilder.Append(Convert.ToInt32(value).ToString("X2"));
		}
		return stringBuilder.ToString();
	}

	public static string ExtractFirstSerialNumber(string inputText)
	{
		int num = inputText.IndexOf("\"serialNumber\":\"");
		if (num == -1)
		{
			return string.Empty;
		}
		checked
		{
			num += "\"serialNumber\":\"".Length;
			int num2 = inputText.IndexOf("\"", num);
			if (num2 == -1)
			{
				return string.Empty;
			}
			return inputText.Substring(num, num2 - num);
		}
	}

	public static string ExtractFirstSoftware_Version(string inputText)
	{
		int num = inputText.IndexOf("\"fwVersion\":\"");
		if (num == -1)
		{
			return string.Empty;
		}
		checked
		{
			num += "\"fwVersion\":\"".Length;
			int num2 = inputText.IndexOf("\"", num);
			if (num2 == -1)
			{
				return string.Empty;
			}
			return inputText.Substring(num, num2 - num);
		}
	}

	public static string ExtractFirstModel(string inputText)
	{
		int num = inputText.IndexOf("\"deviceModelName\":\"");
		if (num == -1)
		{
			return string.Empty;
		}
		checked
		{
			num += "\"deviceModelName\":\"".Length;
			int num2 = inputText.IndexOf("\"", num);
			if (num2 == -1)
			{
				return string.Empty;
			}
			return inputText.Substring(num, num2 - num);
		}
	}

	public static string ExtractDateFromText(string input)
	{
		string pattern = "\\d{4}-\\d{2}-\\d{2}";
		Match match = Regex.Match(input, pattern);
		if (match.Success)
		{
			return match.Value;
		}
		return null;
	}

	public static string ByteArrayToString(byte[] ba)
	{
		StringBuilder stringBuilder = new StringBuilder(checked(ba.Length * 2));
		foreach (byte b in ba)
		{
			stringBuilder.AppendFormat("{0:x2}", b);
		}
		return stringBuilder.ToString();
	}

	public static Stream ByteArrayToStream()
	{
		checked
		{
			byte[] array = new byte[unchecked(Hex_New.Length / 2) - 1 + 1];
			int num = array.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				array[i] = Convert.ToByte(Hex_New.Substring(i * 2, 2), 16);
			}
			return new MemoryStream(array);
		}
	}

	public static object Calculating_simlock(string folderbackup)
	{
		Hexx = ByteArrayToString(File.ReadAllBytes(folderbackup));
		if (Hexx.Contains("535433385f30303030") | Hexx.Contains("5354333341303030") | Hexx.Contains("5354333441303030"))
		{
			if (Hexx.Contains("535433385f30303030"))
			{
				return false;
			}
			if (Hexx.Contains("5354333341303030") & Hexx.Contains("5354333441303030"))
			{
				return false;
			}
		}
		if (Hexx.Contains("535433385f30303830"))
		{
			Hex_New = Hexx.Replace("535433385f30303830", "535433385f30303030");
			return true;
		}
		if (Hexx.Contains("535433385f303038"))
		{
			Hex_New = Hexx.Replace("535433385f303038", "535433385f303030");
			return true;
		}
		if (Hexx.Contains("535433385f303039"))
		{
			Hex_New = Hexx.Replace("535433385f303039", "535433385f303030");
			return true;
		}
		if (Hexx.Contains("535433385f30303833"))
		{
			Hex_New = Hexx.Replace("535433385f30303833", "535433385f30303030");
			return true;
		}
		if (Hexx.Contains("5354333341303039"))
		{
			Hex_New = Hexx.Replace("5354333341303039", "5354333341303030");
			return true;
		}
		if (Hexx.Contains("5354333441303031"))
		{
			Hex_New = Hexx.Replace("5354333441303031", "5354333441303030");
			return true;
		}
		object result = default(object);
		return result;
	}

	public static string Calculating_KG(string folderbackup)
	{
		bytes = null;
		bytes = File.ReadAllBytes(folderbackup);
		Hexx = ByteArrayToString(bytes);
		Stringg = HexToString(Hexx);
		checked
		{
			if (Stringg.Contains("serialNumber"))
			{
				if (Stringg.Contains("XDATAUTEAMX"))
				{
					return "done";
				}
				serialNumber = StringToHex(ExtractFirstSerialNumber(Stringg));
				if (Hexx.Contains(serialNumber))
				{
					Hex_New = Hexx.Replace(serialNumber, "5844415441555445414d58");
					Stringg = HexToString(Hex_New);
					if (Stringg.Contains("XDATAUTEAMX"))
					{
						gui.Richlog("OK", Color.Lime, isBold: true, NextLine: true);
						gui.Richlog("- Writing Data To Target : ", Color.Black);
						Form1.SharedUI.ProgressBar1.Text = "Writing...";
						return "unlock";
					}
				}
				else
				{
					byte[] array = HexStringToByteArray(serialNumber);
					byte[] array2 = new byte[11]
					{
						88, 68, 65, 84, 65, 85, 84, 69, 65, 77,
						88
					};
					byte[] array3 = File.ReadAllBytes(folderbackup);
					int num = array.Length;
					gui.Richlog("OK", Color.Lime, isBold: true, NextLine: true);
					gui.Richlog("- Writing Data To Target : ", Color.Black);
					Form1.SharedUI.ProgressBar1.Text = "Writing...";
					int num2 = array3.Length - num;
					for (int i = 0; i <= num2; i++)
					{
						bool flag = true;
						int num3 = num - 1;
						for (int j = 0; j <= num3; j++)
						{
							if (array3[i + j] != array[j])
							{
								flag = false;
								break;
							}
						}
						if (flag)
						{
							Array.Copy(array2, 0, array3, i, array2.Length);
							i += array2.Length - 1;
						}
					}
					File.WriteAllBytes(folderbackup, array3);
					bytes = File.ReadAllBytes(folderbackup);
					Hexx = ByteArrayToString(bytes);
					Stringg = HexToString(Hexx);
					if (Stringg.Contains("XDATAUTEAMX"))
					{
						Hex_New = Hexx;
						return "unlock";
					}
				}
				string result = default(string);
				return result;
			}
			return "not_Fuond";
		}
	}

	public static void closingport()
	{
		CHECK = "no";
		uploadResult?.Device?.Dispose();
		mtkWaitResult?.Device?.Dispose();
	}

	public static void closingport2()
	{
		uploadResult?.Device?.Dispose();
		mtkWaitResult?.Device?.Dispose();
	}
}
