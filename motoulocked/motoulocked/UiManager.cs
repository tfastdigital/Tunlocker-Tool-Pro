using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Management;
using System.Media;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Properties;
using motoulocked.SPD;

namespace motoulocked.motoulocked;

[StandardModule]
public sealed class UiManager
{
	[CompilerGenerated]
	internal sealed class _Closure_0024__46_002D0
	{
		public string _0024VB_0024Local_str;

		public _Closure_0024__46_002D0(_Closure_0024__46_002D0 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024Local_str = arg0._0024VB_0024Local_str;
			}
		}

		[SpecialName]
		internal void _Lambda_0024__0()
		{
			EDL.SharedEDL.ComboBoxUSB.Text = _0024VB_0024Local_str;
		}
	}

	public static Stopwatch Watch = new Stopwatch();

	public static string MSL;

	public static bool check = false;

	public static string Hh = "";

	public static string String_30;

	public static string String_31;

	private static double DoubleBytes;

	public static bool IsBusy { get; set; } = false;


	private static int current_progbar1 { get; set; }

	private static int current_progbar2 { get; set; }

	public static string Selected_Folder { get; set; }

	public static bool IsOnline()
	{
		bool result;
		try
		{
			using WebClient webClient = new WebClient();
			using (webClient.OpenRead("https://google.com/"))
			{
				result = true;
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			//result = false;
			result = true;
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public static object wesreampung_wav()
	{
		File.WriteAllBytes(Application.StartupPath + "/tmp/wesreampung.wav", Resources.wesreampung);
		SoundPlayer soundPlayer = new SoundPlayer();
		soundPlayer.SoundLocation = "tmp\\wesreampung.wav";
		soundPlayer.Load();
		soundPlayer.Play();
		object result = default(object);
		return result;
	}

	public static object wronganswer()
	{
		try
		{
			File.WriteAllBytes(Application.StartupPath + "/tmp/wronganswer.wav", Resources.wronganswer);
			SoundPlayer soundPlayer = new SoundPlayer();
			soundPlayer.SoundLocation = "tmp\\wronganswer.wav";
			soundPlayer.Load();
			soundPlayer.Play();
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

	public static object ScanTemWav()
	{
		try
		{
			File.WriteAllBytes(Application.StartupPath + "/tmp/scan.wav", Resources.scan);
			SoundPlayer soundPlayer = new SoundPlayer();
			soundPlayer.SoundLocation = "tmp\\scan.wav";
			soundPlayer.Load();
			soundPlayer.Play();
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

	public static object method_24()
	{
		try
		{
			File.WriteAllBytes(Application.StartupPath + "/tmp/notification.wav", Resources.notification);
			SoundPlayer soundPlayer = new SoundPlayer();
			soundPlayer.SoundLocation = "tmp\\notification.wav";
			soundPlayer.Load();
			soundPlayer.Play();
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

	public static object MethodD_165()
	{
		try
		{
			Form1.SharedUI.Panel3.Visible = true;
			Form1.SharedUI.MaterialCard5.Enabled = false;
			Form1.SharedUI.MaterialCard3.Enabled = false;
			Form1.SharedUI.CheckBox2.Checked = false;
			lass0.UserName_Password();
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

	[STAThread]
	public static void Richlogs(string msg, Color colour, bool isBold = true, bool NextLine = false)
	{
		if (colour == Color.Black)
		{
			colour = Color.White;
		}
		if (colour == Color.Green)
		{
			colour = Color.LightGreen;
		}
		if (colour == Color.FromArgb(0, 85, 207))
		{
			colour = Color.FromArgb(21, 87, 255);
		}
		if ((Operators.CompareString(msg, "OK", TextCompare: false) == 0) | (Operators.CompareString(msg, "Done", TextCompare: false) == 0))
		{
			colour = Color.FromArgb(21, 87, 255);
		}
		if (Form1.SharedUI.RichTextBox1.InvokeRequired)
		{
			Form1.SharedUI.RichTextBox1.Invoke((Action)([SpecialName] () =>
			{
				Color selectionColor2 = Form1.SharedUI.RichTextBox1.SelectionColor;
				if (isBold)
				{
					Form1.SharedUI.RichTextBox1.SelectionFont = new Font(Form1.SharedUI.RichTextBox1.Font, FontStyle.Bold);
				}
				else
				{
					Form1.SharedUI.RichTextBox1.SelectionFont = new Font(Form1.SharedUI.RichTextBox1.Font, FontStyle.Regular);
				}
				Form1.SharedUI.RichTextBox1.SelectionColor = colour;
				Form1.SharedUI.RichTextBox1.AppendText(msg);
				Form1.SharedUI.RichTextBox1.SelectionColor = selectionColor2;
				if (NextLine && Form1.SharedUI.RichTextBox1.TextLength > 0)
				{
					Form1.SharedUI.RichTextBox1.AppendText("\r\n");
				}
			}));
		}
		else
		{
			Color selectionColor = Form1.SharedUI.RichTextBox1.SelectionColor;
			if (isBold)
			{
				Form1.SharedUI.RichTextBox1.SelectionFont = new Font(Form1.SharedUI.RichTextBox1.Font, FontStyle.Bold);
			}
			else
			{
				Form1.SharedUI.RichTextBox1.SelectionFont = new Font(Form1.SharedUI.RichTextBox1.Font, FontStyle.Regular);
			}
			Form1.SharedUI.RichTextBox1.SelectionColor = colour;
			Form1.SharedUI.RichTextBox1.AppendText(msg);
			Form1.SharedUI.RichTextBox1.SelectionColor = selectionColor;
			if (NextLine && Form1.SharedUI.RichTextBox1.TextLength > 0)
			{
				Form1.SharedUI.RichTextBox1.AppendText("\r\n");
			}
		}
		Form1.SharedUI.RichTextBox1.Update();
	}

	public static void ComboTypeMemory()
	{
		if (EDL.SharedEDL.cbstorage.InvokeRequired)
		{
			EDL.SharedEDL.cbstorage.Invoke((Action)([SpecialName] () =>
			{
				if (Operators.CompareString(FIREHOSE_MANAGER.TypeMemory, "auto", TextCompare: false) == 0)
				{
					EDL.SharedEDL.cbstorage.SelectedIndex = 0;
				}
				else if (Operators.CompareString(FIREHOSE_MANAGER.TypeMemory, "emmc", TextCompare: false) == 0)
				{
					EDL.SharedEDL.cbstorage.SelectedIndex = 1;
				}
				else if (Operators.CompareString(FIREHOSE_MANAGER.TypeMemory, "ufs", TextCompare: false) == 0)
				{
					EDL.SharedEDL.cbstorage.SelectedIndex = 2;
				}
			}));
		}
		else if (Operators.CompareString(FIREHOSE_MANAGER.TypeMemory, "auto", TextCompare: false) == 0)
		{
			EDL.SharedEDL.cbstorage.SelectedIndex = 0;
		}
		else if (Operators.CompareString(FIREHOSE_MANAGER.TypeMemory, "emmc", TextCompare: false) == 0)
		{
			EDL.SharedEDL.cbstorage.SelectedIndex = 1;
		}
		else if (Operators.CompareString(FIREHOSE_MANAGER.TypeMemory, "ufs", TextCompare: false) == 0)
		{
			EDL.SharedEDL.cbstorage.SelectedIndex = 2;
		}
	}

	public static void DGVClear()
	{
		EDL.SharedEDL.DataView.Invoke((Action)([SpecialName] () =>
		{
			EDL.SharedEDL.DataView.Rows.Clear();
		}));
	}

	public static void ProcessBar1(int val)
	{
		if (current_progbar1 != val)
		{
			Form1.SharedUI.ProgressBar4.Invoke((Action)([SpecialName] () =>
			{
				Form1.SharedUI.ProgressBar4.Value = val;
			}));
		}
		current_progbar1 = val;
	}

	public static void ProcessBar1n(long Process)
	{
		if (Process > 99)
		{
			Process = 100L;
		}
		Form1.SharedUI.ProgressBar4.Invoke((Action)([SpecialName] () =>
		{
			Form1.SharedUI.ProgressBar4.Value = checked((int)Process);
		}));
		Form1.String_30 = Conversions.ToString(Form1.SharedUI.ProgressBar4.Value);
		Form1.SharedUI.ProgressBar4.Text = uni.Name + Form1.String_30 + "%)";
	}

	public static void ProcessBar1n(long Process, long total)
	{
		int num = Convert.ToInt32(Math.Round((double)checked(Process * 100) / (double)total));
		if (num > 99)
		{
			num = 100;
		}
		Form1.SharedUI.ProgressBar4.Invoke((Action)([SpecialName] () =>
		{
			Form1.SharedUI.ProgressBar4.Value = num;
		}));
	}

	public static void ProcessBar2(long Process)
	{
		if (Process > 99)
		{
			Process = 100L;
		}
		Form1.SharedUI.ProgressBar4.Invoke((Action)([SpecialName] () =>
		{
			Form1.SharedUI.ProgressBar4.Value = checked((int)Process);
		}));
		Form1.String_30 = Conversions.ToString(Form1.SharedUI.ProgressBar4.Value);
		Form1.SharedUI.ProgressBar4.Text = uni.Name + Form1.String_30 + "%)";
	}

	public static void ProcessBar1(long Process, long total)
	{
		int num = Convert.ToInt32(Math.Round((double)checked(Process * 100) / (double)total));
		if ((FIREHOSE_OPERATIONS.MenuMan == FIREHOSE_OPERATIONS.MenuManual.readgpt_erase_patch) | (FIREHOSE_OPERATIONS.MenuMan == FIREHOSE_OPERATIONS.MenuManual.readgpt_erase_user))
		{
			String_31 = "Patching Data...(";
		}
		if ((FIREHOSE_OPERATIONS.MenuMan == FIREHOSE_OPERATIONS.MenuManual.flash) | (FIREHOSE_OPERATIONS.MenuMan == FIREHOSE_OPERATIONS.MenuManual.readgpt_patch_kg))
		{
			String_31 = "Writing Data...(";
		}
		if (FIREHOSE_OPERATIONS.MenuMan == FIREHOSE_OPERATIONS.MenuManual.read)
		{
			String_31 = "Reading Data...(";
		}
		if (FIREHOSE_OPERATIONS.MenuMan == FIREHOSE_OPERATIONS.MenuManual.readgpt_read)
		{
			String_31 = "Reading Data...(";
		}
		if (current_progbar2 != num)
		{
			Form1.SharedUI.ProgressBar4.Invoke((Action)([SpecialName] () =>
			{
				Form1.SharedUI.ProgressBar4.Value = num;
			}));
		}
		String_30 = Conversions.ToString(Form1.SharedUI.ProgressBar4.Value);
		Form1.SharedUI.ProgressBar4.Text = String_31 + String_30 + "%)";
		current_progbar2 = num;
	}

	public static void ProcessBar2(long Process, long total)
	{
		int num = Convert.ToInt32(Math.Round((double)checked(Process * 100) / (double)total));
		if ((FIREHOSE_OPERATIONS.MenuMan == FIREHOSE_OPERATIONS.MenuManual.readgpt_erase_patch) | (FIREHOSE_OPERATIONS.MenuMan == FIREHOSE_OPERATIONS.MenuManual.readgpt_erase_user))
		{
			String_31 = "Patching Data...(";
		}
		if ((FIREHOSE_OPERATIONS.MenuMan == FIREHOSE_OPERATIONS.MenuManual.flash) | (FIREHOSE_OPERATIONS.MenuMan == FIREHOSE_OPERATIONS.MenuManual.readgpt_patch_kg))
		{
			String_31 = "Writing Data...(";
		}
		if (FIREHOSE_OPERATIONS.MenuMan == FIREHOSE_OPERATIONS.MenuManual.read)
		{
			String_31 = "Reading Data...(";
		}
		if (FIREHOSE_OPERATIONS.MenuMan == FIREHOSE_OPERATIONS.MenuManual.readgpt_read)
		{
			String_31 = "Reading Data...(";
		}
		if (current_progbar2 != num)
		{
			Form1.SharedUI.ProgressBar4.Invoke((Action)([SpecialName] () =>
			{
				Form1.SharedUI.ProgressBar4.Value = num;
			}));
		}
		String_30 = Conversions.ToString(Form1.SharedUI.ProgressBar4.Value);
		Form1.SharedUI.ProgressBar4.Text = String_31 + String_30 + "%)";
		current_progbar2 = num;
	}

	public static void ProcessBar3(long Process, long total)
	{
		int num = Convert.ToInt32(Math.Round((double)checked(Process * 100) / (double)total));
		if (current_progbar2 != num)
		{
			Form1.SharedUI.ProgressBar4.Invoke((Action)([SpecialName] () =>
			{
				Form1.SharedUI.ProgressBar4.Value = num;
			}));
		}
		String_31 = "Sending Config...(";
		String_30 = Conversions.ToString(Form1.SharedUI.ProgressBar4.Value);
		Form1.SharedUI.ProgressBar4.Text = String_31 + String_30 + "%)";
		current_progbar2 = num;
	}

	public static void ProcessBar_Sending_EMI(long Process, long total)
	{
		int num = Convert.ToInt32(Math.Round((double)checked(Process * 100) / (double)total));
		if (current_progbar2 != num)
		{
			Form1.SharedUI.ProgressBar4.Invoke((Action)([SpecialName] () =>
			{
				Form1.SharedUI.ProgressBar4.Value = num;
			}));
		}
		String_31 = "Sending EMI Data...(";
		String_30 = Conversions.ToString(Form1.SharedUI.ProgressBar4.Value);
		Form1.SharedUI.ProgressBar4.Text = String_31 + String_30 + "%)";
		current_progbar2 = num;
	}

	public static void label_totalsize(long val)
	{
		Form1.SharedUI.label_totalsize.Invoke((Action)([SpecialName] () =>
		{
			Form1.SharedUI.label_totalsize.Text = GetFileSizes(val);
		}));
	}

	public static void label_writensize(long val)
	{
		Form1.SharedUI.label_writensize.Invoke((Action)([SpecialName] () =>
		{
			Form1.SharedUI.label_writensize.Text = GetFileSizes(val);
		}));
	}

	private static long Bulat(double number)
	{
		return Convert.ToInt64(Math.Round(0.0 - Math.Floor(0.0 - number)));
	}

	public static void label_transferrate(double val)
	{
		Form1.SharedUI.label_transferrate.Invoke((Action)([SpecialName] () =>
		{
			Form1.SharedUI.label_transferrate.Text = GetFileSizes(Bulat(val)) + " /s";
		}));
	}

	public static void CariPortQcom_Tick()
	{
		Richlogs("- Waiting For USB Devices : ", Color.White, isBold: false);
		EDL.WaktuCari = 0;
		Form1.SharedUI.ProgressBar4.Text = "";
		Form1.SharedUI.ProgressBar4.Value = 0;
		SerialCOM.MSL = "ENREAD";
		Hh = "";
		check = false;
		checked
		{
			while (true)
			{
				EDL.WaktuCari++;
				if (EDL.WaktuCari != 100)
				{
					Form1.SharedUI.ProgressBar4.Increment(1);
					Form1.String_30 = Conversions.ToString(Form1.SharedUI.ProgressBar4.Value);
					Form1.SharedUI.ProgressBar4.Text = "Wait For Device.." + Form1.String_30 + "%";
					if (Operators.CompareString(EDL.cancel, "Cancel", TextCompare: false) == 0)
					{
						Hh = "no";
						break;
					}
					if (CariPorts())
					{
						Hh = "ok";
						break;
					}
					Delay(0.7);
					continue;
				}
				Form1.SharedUI.ProgressBar4.Value = 100;
				check = true;
				break;
			}
			if (Operators.CompareString(Hh, "ok", TextCompare: false) == 0)
			{
				SerialCOM.MSL = "DISREAD";
				Form1.SharedUI.ProgressBar4.Text = "";
				Form1.SharedUI.ProgressBar4.Value = 0;
				if (!SAHARA_MANAGER.SaharaConnect())
				{
					try
					{
						if (PortIOMe.Ports.IsOpen)
						{
							PortIOMe.Ports.Close();
							PortIOMe.Ports.Dispose();
							PortIOMe.Ports = null;
						}
						return;
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						ProjectData.ClearProjectError();
						return;
					}
				}
				if (PortIOMe.Ports.IsOpen)
				{
					PortIOMe.Ports.Close();
					PortIOMe.Ports.Dispose();
					PortIOMe.Ports = null;
				}
				if (!(Form1.SharedUI.RichTextBox1.Text.Contains("Cencel By User") | Form1.SharedUI.RichTextBox1.Text.Contains("error[")))
				{
					FIREHOSE_MANAGER.ConnectToFlashLoader();
					try
					{
						DiskWriter.Closeport();
					}
					catch (Exception projectError2)
					{
						ProjectData.SetProjectError(projectError2);
						ProjectData.ClearProjectError();
					}
				}
			}
			else
			{
				Form1.SharedUI.ProgressBar4.Text = "";
				Form1.SharedUI.ProgressBar4.Value = 0;
				if (Operators.CompareString(Hh, "no", TextCompare: false) != 0 && check)
				{
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
				}
			}
		}
	}

	public static bool CariPorts()
	{
		ManagementObjectCollection.ManagementObjectEnumerator managementObjectEnumerator = null;
		using (ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher("root\\cimv2", "SELECT * FROM Win32_PnPEntity  WHERE Name LIKE '%9008%'  "))
		{
			managementObjectEnumerator = managementObjectSearcher.Get().GetEnumerator();
			if (managementObjectEnumerator.MoveNext())
			{
				_Closure_0024__46_002D0 arg = default(_Closure_0024__46_002D0);
				_Closure_0024__46_002D0 CS_0024_003C_003E8__locals0 = new _Closure_0024__46_002D0(arg);
				ManagementObject managementObject = (ManagementObject)managementObjectEnumerator.Current;
				CS_0024_003C_003E8__locals0._0024VB_0024Local_str = managementObject["Name"].ToString();
				EDL.SharedEDL.ComboBoxUSB.Invoke((Action)([SpecialName] () =>
				{
					EDL.SharedEDL.ComboBoxUSB.Text = CS_0024_003C_003E8__locals0._0024VB_0024Local_str;
				}));
				Match match = Regex.Match(CS_0024_003C_003E8__locals0._0024VB_0024Local_str, "\\((COM\\d+)\\)");
				if (match.Success)
				{
					PortIOMe.PortCOM = Convert.ToInt32(match.Groups[1].Value.Replace("COM", string.Empty));
					return true;
				}
				return false;
			}
		}
		return false;
	}

	public static string GetFileSizes(long TheSize)
	{
		string text = null;
		if (TheSize >= 1099511627776L)
		{
			double num = (double)TheSize / 1099511627776.0;
			return $"{num:N2} TB";
		}
		if (TheSize >= 1073741824 && TheSize <= 1099511627775L)
		{
			double num2 = (double)TheSize / 1073741824.0;
			return $"{num2:N2} GB";
		}
		if (TheSize >= 1048576 && TheSize <= 1073741823)
		{
			double num3 = (double)TheSize / 1048576.0;
			return $"{num3:N2} MB";
		}
		if (TheSize >= 1024 && TheSize <= 1048575)
		{
			double num4 = (double)TheSize / 1024.0;
			return $"{num4:N2} KB";
		}
		if (TheSize < 0 || TheSize > 1023)
		{
			return "";
		}
		double num5 = TheSize;
		return $"{num5:N2} bytes";
	}

	public static string GetFileSizess(long TheSize)
	{
		string result = string.Empty;
		try
		{
			if (TheSize >= 1099511627776L)
			{
				DoubleBytes = (double)TheSize / 1099511627776.0;
				result = Strings.FormatNumber(DoubleBytes, 2) + " TB";
			}
			else if (TheSize >= 1073741824 && TheSize <= 1099511627775L)
			{
				DoubleBytes = (double)TheSize / 1073741824.0;
				result = Strings.FormatNumber(DoubleBytes, 2) + " GB";
			}
			else if (TheSize >= 1048576 && TheSize <= 1073741823)
			{
				DoubleBytes = (double)TheSize / 1048576.0;
				result = Strings.FormatNumber(DoubleBytes, 2) + " MB";
			}
			else if (TheSize >= 1024 && TheSize <= 1048575)
			{
				DoubleBytes = (double)TheSize / 1024.0;
				result = Strings.FormatNumber(DoubleBytes, 2) + " KB";
			}
			else if (TheSize < 0 || TheSize > 1023)
			{
				result = string.Empty;
			}
			else
			{
				DoubleBytes = TheSize;
				result = Strings.FormatNumber(DoubleBytes, 2) + " bytes";
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Console.WriteLine(ex2.ToString());
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public static string GetFileCalculator(double byteCount)
	{
		string result = "0 Bytes";
		if (byteCount >= 1099511627776.0)
		{
			result = $"{byteCount / 1099511627776.0:##.##}" + " TB";
		}
		else if (byteCount >= 1073741824.0)
		{
			result = $"{byteCount / 1073741824.0:##.##}" + " GB";
		}
		else if (byteCount >= 1048576.0)
		{
			result = $"{byteCount / 1048576.0:##.##}" + " MB";
		}
		else if (byteCount >= 1024.0)
		{
			result = $"{byteCount / 1024.0:##.##}" + " KB";
		}
		else if (byteCount > 0.0)
		{
			result = $"{byteCount:##.##}" + " Bytes";
		}
		return result;
	}

	public static void hide_writen_transfer(bool hidden = true)
	{
		Form1.SharedUI.label_writensize.Invoke((Action)([SpecialName] () =>
		{
			Form1.SharedUI.label_writensize.Visible = !hidden;
		}));
		Form1.SharedUI.label_transferrate.Invoke((Action)([SpecialName] () =>
		{
			Form1.SharedUI.label_transferrate.Visible = !hidden;
		}));
		Form1.SharedUI.label_writensize.Invoke((Action)([SpecialName] () =>
		{
			Form1.SharedUI.label_writensize.Visible = !hidden;
		}));
		Form1.SharedUI.label_transferrate.Invoke((Action)([SpecialName] () =>
		{
			Form1.SharedUI.label_transferrate.Visible = !hidden;
		}));
	}

	public static void Delay(double dblSecs)
	{
		DateAndTime.Now.AddSeconds(1.15740740740741E-05);
		DateTime t = DateTime.Now.AddSeconds(1.15740740740741E-05).AddSeconds(dblSecs);
		while (DateTime.Compare(DateTime.Now, t) <= 0)
		{
			Application.DoEvents();
		}
	}

	public static void AllDone()
	{
		Form1.SharedUI.ProgressBar4.Invoke((Action)([SpecialName] () =>
		{
			Form1.SharedUI.ProgressBar4.Value = 100;
		}));
		IsBusy = false;
	}
}
