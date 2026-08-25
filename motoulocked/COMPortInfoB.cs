using System;
using System.Collections.Generic;
using System.Management;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace motoulocked;

public class COMPortInfoB
{
	private string _comPort;

	private string _deviceName;

	public string COMPort => _comPort;

	public string DeviceName => _deviceName;

	public COMPortInfoB(string deviceName, string comPort)
	{
		_deviceName = deviceName;
		_comPort = comPort;
	}

	public static List<COMPortInfoB> GetCOMPortsInfo()
	{
		List<COMPortInfoB> list = new List<COMPortInfoB>();
		ConnectionOptions options = ProcessConnection.ProcessConnectionOptions();
		ManagementScope scope = ProcessConnection.ConnectionScope(Environment.MachineName, options, "\\root\\CIMV2");
		ObjectQuery query = new ObjectQuery("Select * from Win32_PnPEntity WHERE ConfigManagerErrorCode = 0");
		ObjectQuery query2 = new ObjectQuery("Select * from Win32_POTSModem WHERE ConfigManagerErrorCode = 0");
		ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher(scope, query);
		ManagementObjectSearcher managementObjectSearcher2 = new ManagementObjectSearcher(scope, query2);
		List<COMPortInfoB> result;
		try
		{
			using (managementObjectSearcher)
			{
				ManagementObjectCollection.ManagementObjectEnumerator enumerator = default(ManagementObjectCollection.ManagementObjectEnumerator);
				try
				{
					enumerator = managementObjectSearcher.Get().GetEnumerator();
					while (enumerator.MoveNext())
					{
						ManagementObject managementObject = (ManagementObject)enumerator.Current;
						if (managementObject != null)
						{
							string text = Conversions.ToString(RuntimeHelpers.GetObjectValue(managementObject["Name"]));
							string empty = string.Empty;
							if (!string.IsNullOrEmpty(text) && text.Contains("(COM"))
							{
								empty = text.Substring(text.LastIndexOf("(COM")).Replace("(", "").Replace(")", "");
								list.Add(new COMPortInfoB(text, empty));
							}
						}
					}
				}
				finally
				{
					enumerator?.Dispose();
				}
			}
			using (managementObjectSearcher2)
			{
				ManagementObjectCollection.ManagementObjectEnumerator enumerator2 = default(ManagementObjectCollection.ManagementObjectEnumerator);
				try
				{
					enumerator2 = managementObjectSearcher2.Get().GetEnumerator();
					while (enumerator2.MoveNext())
					{
						ManagementObject managementObject2 = (ManagementObject)enumerator2.Current;
						if (managementObject2 != null)
						{
							string text2 = Conversions.ToString(RuntimeHelpers.GetObjectValue(managementObject2["Name"]));
							string text3 = Conversions.ToString(RuntimeHelpers.GetObjectValue(managementObject2["AttachedTo"]));
							if (!string.IsNullOrEmpty(text2) && !string.IsNullOrEmpty(text3))
							{
								list.Add(new COMPortInfoB(text2 + " (" + text3 + ")", text3));
							}
						}
					}
				}
				finally
				{
					enumerator2?.Dispose();
				}
			}
			result = list;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception projectError = ex;
			ProjectData.SetProjectError(projectError);
			Interaction.MsgBox("Unable to enumerate COM ports!", MsgBoxStyle.Critical);
			result = null;
			ProjectData.ClearProjectError();
			ProjectData.ClearProjectError();
		}
		return result;
	}
}
