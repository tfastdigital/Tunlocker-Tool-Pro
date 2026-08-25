using System;
using System.Management;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using Microsoft.VisualBasic.CompilerServices;
using motoulocked.motoulocked;
using motoulocked.SPD.Worker;

namespace motoulocked.MyUI;

[StandardModule]
internal sealed class MyDisplay
{
	private enum EXECUTION_STATE : uint
	{
		ES_SYSTEM_REQUIRED = 1u,
		ES_DISPLAY_REQUIRED = 2u,
		ES_CONTINUOUS = 0x80000000u
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__6_002D0
	{
		public string _0024VB_0024Local_str;

		public _Closure_0024__6_002D0(_Closure_0024__6_002D0 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024Local_str = arg0._0024VB_0024Local_str;
			}
		}

		[SpecialName]
		internal void _Lambda_0024__0()
		{
			Form1.SharedUI.ComboPort.Text = _0024VB_0024Local_str;
		}
	}

	public static string MyOperation = string.Empty;

	[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern EXECUTION_STATE SetThreadExecutionState(EXECUTION_STATE esFlags);

	public static void PreventSleep()
	{
		SetThreadExecutionState((EXECUTION_STATE)2147483651u);
	}

	public static void AllowSleep()
	{
		SetThreadExecutionState(EXECUTION_STATE.ES_CONTINUOUS);
	}

	public static bool CariPorts()
	{
		ManagementObjectCollection.ManagementObjectEnumerator managementObjectEnumerator = null;
		using (ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher("root\\cimv2", "SELECT * FROM Win32_PnPEntity  WHERE Name LIKE '%SPRD%'  "))
		{
			managementObjectEnumerator = managementObjectSearcher.Get().GetEnumerator();
			if (managementObjectEnumerator.MoveNext())
			{
				_Closure_0024__6_002D0 arg = default(_Closure_0024__6_002D0);
				_Closure_0024__6_002D0 CS_0024_003C_003E8__locals0 = new _Closure_0024__6_002D0(arg);
				ManagementObject managementObject = (ManagementObject)managementObjectEnumerator.Current;
				CS_0024_003C_003E8__locals0._0024VB_0024Local_str = managementObject["Name"].ToString();
				Form1.SharedUI.ComboPort.Invoke((Action)([SpecialName] () =>
				{
					Form1.SharedUI.ComboPort.Text = CS_0024_003C_003E8__locals0._0024VB_0024Local_str;
				}));
				Match match = Regex.Match(CS_0024_003C_003E8__locals0._0024VB_0024Local_str, "\\((COM\\d+)\\)");
				if (match.Success)
				{
					WorkerDownload.PortCom = Conversions.ToString(Convert.ToInt32(match.Groups[1].Value.Replace("COM", string.Empty)));
					return true;
				}
				return false;
			}
		}
		return false;
	}

	public static string USBSearchPort()
	{
		SPDR.WaktuCari = 0;
		Form1.SharedUI.ProgressBar4.Text = "";
		Form1.SharedUI.ProgressBar4.Value = 0;
		SerialCOM.MSL = "ENREAD";
		string text = "";
		checked
		{
			while (true)
			{
				SPDR.WaktuCari++;
				if (SPDR.WaktuCari != 100)
				{
					Form1.SharedUI.ProgressBar4.Increment(1);
					Form1.String_30 = Conversions.ToString(Form1.SharedUI.ProgressBar4.Value);
					Form1.SharedUI.ProgressBar4.Text = "Wait For Device.." + Form1.String_30 + "%";
					if (Operators.CompareString(SPDR.cancel, "Cancel", TextCompare: false) == 0)
					{
						text = "Cancel";
						break;
					}
					if (CariPorts())
					{
						text = "Connected";
						UiManager.Hh = "ok";
						break;
					}
					UiManager.Delay(0.7);
					continue;
				}
				Form1.SharedUI.ProgressBar4.Value = 100;
				text = "NotFound";
				break;
			}
			return text;
		}
	}
}
