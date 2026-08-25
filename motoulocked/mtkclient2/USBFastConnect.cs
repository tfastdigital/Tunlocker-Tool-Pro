using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Management;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace motoulocked.mtkclient2;

public class USBFastConnect
{
	public class comInfo
	{
		public string name { get; set; }

		public string hwid { get; set; }

		public string comport { get; set; }

		public int type { get; set; }
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__9_002D0
	{
		public List<comInfo> _0024VB_0024Local_list;

		public string _0024VB_0024Local_regex;

		public _Closure_0024__9_002D0(_Closure_0024__9_002D0 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024Local_list = arg0._0024VB_0024Local_list;
				_0024VB_0024Local_regex = arg0._0024VB_0024Local_regex;
			}
		}

		[SpecialName]
		internal void _Lambda_0024__0()
		{
			if (_0024VB_0024Local_list.Count < Form1.SharedUI.ComboPort.Items.Count)
			{
				Form1.SharedUI.ComboPort.Text = null;
				Form1.SharedUI.ComboPort.AllowDrop = false;
			}
			Form1.SharedUI.ComboPort.Items.Clear();
			foreach (comInfo item2 in _0024VB_0024Local_list)
			{
				string text = "";
				if (item2.type == 1)
				{
					text = "[MTP] ";
				}
				else if (item2.type == 2)
				{
					text = "[DLM] ";
				}
				else if (item2.type == 3)
				{
					text = "[DIAG] ";
				}
				string item = text + item2.name;
				Form1.SharedUI.ComboPort.Items.Add(item);
				if (item2.name.Contains("SAMSUNG") && string.IsNullOrEmpty(_0024VB_0024Local_regex))
				{
					_0024VB_0024Local_regex = item;
				}
			}
			if (!string.IsNullOrEmpty(_0024VB_0024Local_regex))
			{
				Form1.SharedUI.ComboPort.SelectedItem = _0024VB_0024Local_regex;
			}
			else if (_0024VB_0024Local_list.Count > 0)
			{
				Form1.SharedUI.ComboPort.SelectedIndex = 0;
			}
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__12_002D0
	{
		public List<comInfo> _0024VB_0024Local_oldDevices;

		public Func<comInfo, bool> _0024I0;

		public _Closure_0024__12_002D0(_Closure_0024__12_002D0 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024Local_oldDevices = arg0._0024VB_0024Local_oldDevices;
			}
		}

		[SpecialName]
		internal bool _Lambda_0024__0(comInfo device)
		{
			_Closure_0024__12_002D1 arg = default(_Closure_0024__12_002D1);
			_Closure_0024__12_002D1 CS_0024_003C_003E8__locals0 = new _Closure_0024__12_002D1(arg)
			{
				_0024VB_0024Local_device = device
			};
			return _0024VB_0024Local_oldDevices.All([SpecialName] (comInfo oldDevice) => Operators.CompareString(oldDevice.comport, CS_0024_003C_003E8__locals0._0024VB_0024Local_device.comport, TextCompare: false) != 0);
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__12_002D1
	{
		public comInfo _0024VB_0024Local_device;

		public _Closure_0024__12_002D1(_Closure_0024__12_002D1 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024Local_device = arg0._0024VB_0024Local_device;
			}
		}

		[SpecialName]
		internal bool _Lambda_0024__1(comInfo oldDevice)
		{
			return Operators.CompareString(oldDevice.comport, _0024VB_0024Local_device.comport, TextCompare: false) != 0;
		}
	}

	public static List<comInfo> listDevices = new List<comInfo>();

	public static readonly Stopwatch watch = new Stopwatch();

	public static long delta = 0L;

	public static void getcomInfo()
	{
		ManagementEventWatcher managementEventWatcher = null;
		watch.Start();
		Task.Run([SpecialName] () =>
		{
			try
			{
				WqlEventQuery query = new WqlEventQuery("SELECT * FROM Win32_DeviceChangeEvent WHERE EventType = 2 OR EventType = 3");
				managementEventWatcher = new ManagementEventWatcher(query);
				managementEventWatcher.EventArrived += DeviceEventArrived;
				managementEventWatcher.Start();
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		});
	}

	public static void DeviceEventArrived(object sender, EventArrivedEventArgs e)
	{
		if (checked(watch.ElapsedMilliseconds - delta) >= 100)
		{
			delta = watch.ElapsedMilliseconds;
			UpdateList();
		}
	}

	public static void UpdateList()
	{
		Task.Run([SpecialName] () =>
		{
			List<comInfo> list = new List<comInfo>();
			try
			{
				ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher("SELECT * FROM Win32_PnPEntity Where Status=\"OK\"");
				try
				{
					foreach (ManagementObject item in managementObjectSearcher.Get())
					{
						if (item["Caption"] != null)
						{
							string text = item[Convert.ToString("Name")].ToString();
							if ((text.Contains("Serial Port") || text.ToUpper().Contains("PRELOADER") || text.ToUpper().Contains("MEDIATEK") || text.Contains("LGE") || text.Contains("1.0")) && text.Contains("(COM"))
							{
								string text2 = item[Convert.ToString("DeviceID")].ToString();
								string[] array = (string[])item["HardwareID"];
								comInfo comInfo = new comInfo
								{
									name = item[Convert.ToString("Name")].ToString(),
									hwid = ((array.Length == 0) ? null : array[0]),
									comport = betweenStrings(item[Convert.ToString("Name")].ToString(), "(COM", ")")
								};
								if (text2.ToLower().Contains("diagserd") && text2.ToLower().Contains("0002"))
								{
									comInfo.type = 3;
								}
								list.Add(comInfo);
							}
						}
					}
					managementObjectSearcher.Dispose();
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
				if (list.Count != listDevices.Count)
				{
					listDevices = list;
					try
					{
						UpdatecomboPort(listDevices);
						return;
					}
					catch (Exception projectError2)
					{
						ProjectData.SetProjectError(projectError2);
						ProjectData.ClearProjectError();
						return;
					}
				}
			}
			catch (Exception projectError3)
			{
				ProjectData.SetProjectError(projectError3);
				ProjectData.ClearProjectError();
			}
		});
	}

	public static void UpdatecomboPort(List<comInfo> list)
	{
		_Closure_0024__9_002D0 arg = default(_Closure_0024__9_002D0);
		_Closure_0024__9_002D0 CS_0024_003C_003E8__locals0 = new _Closure_0024__9_002D0(arg);
		CS_0024_003C_003E8__locals0._0024VB_0024Local_list = list;
		CS_0024_003C_003E8__locals0._0024VB_0024Local_regex = string.Empty;
		if (Form1.SharedUI.ComboPort.InvokeRequired)
		{
			Form1.SharedUI.ComboPort.Invoke((MethodInvoker)([SpecialName] () =>
			{
				if (CS_0024_003C_003E8__locals0._0024VB_0024Local_list.Count < Form1.SharedUI.ComboPort.Items.Count)
				{
					Form1.SharedUI.ComboPort.Text = null;
					Form1.SharedUI.ComboPort.AllowDrop = false;
				}
				Form1.SharedUI.ComboPort.Items.Clear();
				foreach (comInfo item in CS_0024_003C_003E8__locals0._0024VB_0024Local_list)
				{
					string text = "";
					if (item.type == 1)
					{
						text = "[MTP] ";
					}
					else if (item.type == 2)
					{
						text = "[DLM] ";
					}
					else if (item.type == 3)
					{
						text = "[DIAG] ";
					}
					string text2 = text + item.name;
					Form1.SharedUI.ComboPort.Items.Add(text2);
					if (item.name.Contains("SAMSUNG") && string.IsNullOrEmpty(CS_0024_003C_003E8__locals0._0024VB_0024Local_regex))
					{
						CS_0024_003C_003E8__locals0._0024VB_0024Local_regex = text2;
					}
				}
				if (!string.IsNullOrEmpty(CS_0024_003C_003E8__locals0._0024VB_0024Local_regex))
				{
					Form1.SharedUI.ComboPort.SelectedItem = CS_0024_003C_003E8__locals0._0024VB_0024Local_regex;
				}
				else if (CS_0024_003C_003E8__locals0._0024VB_0024Local_list.Count > 0)
				{
					Form1.SharedUI.ComboPort.SelectedIndex = 0;
				}
			}));
			return;
		}
		if (CS_0024_003C_003E8__locals0._0024VB_0024Local_list.Count < Form1.SharedUI.ComboPort.Items.Count)
		{
			Form1.SharedUI.ComboPort.Text = "";
			Form1.SharedUI.ComboPort.AllowDrop = false;
		}
		Form1.SharedUI.ComboPort.Items.Clear();
		foreach (comInfo item2 in CS_0024_003C_003E8__locals0._0024VB_0024Local_list)
		{
			Console.WriteLine(item2.name);
			Form1.SharedUI.ComboPort.Items.Add(item2.name + " (COM" + item2.comport + ")");
			if (item2.name.Contains("SAMSUNG") && string.IsNullOrEmpty(CS_0024_003C_003E8__locals0._0024VB_0024Local_regex))
			{
				CS_0024_003C_003E8__locals0._0024VB_0024Local_regex = item2.name + " (COM" + item2.comport + ")";
			}
		}
		Form1.SharedUI.ComboPort.SelectedItem = CS_0024_003C_003E8__locals0._0024VB_0024Local_regex;
	}

	public static string betweenStrings(string text, string start, string end)
	{
		checked
		{
			int num = text.IndexOf(start) + start.Length;
			int num2 = text.IndexOf(end, num);
			if (object.Equals(end, ""))
			{
				return text.Substring(num);
			}
			return text.Substring(num, num2 - num);
		}
	}

	public static string[] VID(string stream)
	{
		string[] array = new string[2];
		int num = stream.IndexOf("VID_");
		checked
		{
			string text = stream.Substring(num + 4);
			array[0] = text.Substring(0, 4);
			int num2 = stream.IndexOf("PID_");
			string text2 = stream.Substring(num2 + 4);
			array[1] = text2.Substring(0, 4);
			return array;
		}
	}

	public static comInfo FindNewDevice(List<comInfo> oldDevices)
	{
		_Closure_0024__12_002D0 arg = default(_Closure_0024__12_002D0);
		_Closure_0024__12_002D0 CS_0024_003C_003E8__locals0 = new _Closure_0024__12_002D0(arg);
		CS_0024_003C_003E8__locals0._0024VB_0024Local_oldDevices = oldDevices;
		comInfo result;
		try
		{
			Stopwatch stopwatch = new Stopwatch();
			stopwatch.Start();
			List<comInfo> list = new List<comInfo>();
			while (true)
			{
				if (stopwatch.ElapsedMilliseconds <= 30000)
				{
					if (listDevices.Count == 0 || listDevices == CS_0024_003C_003E8__locals0._0024VB_0024Local_oldDevices)
					{
						continue;
					}
					list = listDevices.Where([SpecialName] (comInfo device) =>
					{
						_Closure_0024__12_002D1 arg2 = default(_Closure_0024__12_002D1);
						_Closure_0024__12_002D1 CS_0024_003C_003E8__locals1 = new _Closure_0024__12_002D1(arg2);
						CS_0024_003C_003E8__locals1._0024VB_0024Local_device = device;
						return CS_0024_003C_003E8__locals0._0024VB_0024Local_oldDevices.All([SpecialName] (comInfo oldDevice) => Operators.CompareString(oldDevice.comport, CS_0024_003C_003E8__locals1._0024VB_0024Local_device.comport, TextCompare: false) != 0);
					}).ToList();
					if (list.Count <= 0)
					{
						continue;
					}
					foreach (comInfo item in list)
					{
						if (!item.name.ToUpper().Contains("MEDIATEK"))
						{
							continue;
						}
						goto IL_00d3;
					}
					continue;
				}
				result = null;
				break;
				IL_00d3:
				result = list[0];
				break;
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			result = null;
			ProjectData.ClearProjectError();
		}
		return result;
	}
}
