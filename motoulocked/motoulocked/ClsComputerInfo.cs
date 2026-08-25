using System;
using System.Management;
using System.Runtime.CompilerServices;

namespace motoulocked.motoulocked;

public class ClsComputerInfo
{
	internal string GetProcessorId()
	{
		ManagementObjectCollection.ManagementObjectEnumerator managementObjectEnumerator = null;
		string result = string.Empty;
		using ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher(new SelectQuery("Win32_processor"));
		managementObjectEnumerator = managementObjectSearcher.Get().GetEnumerator();
		while (managementObjectEnumerator.MoveNext())
		{
			result = ((ManagementObject)managementObjectEnumerator.Current)["processorId"].ToString();
		}
		return result;
	}

	internal string GetMACAddress()
	{
		ManagementObjectCollection instances = new ManagementClass("Win32_NetworkAdapterConfiguration").GetInstances();
		string text = string.Empty;
		try
		{
			foreach (ManagementObject item in instances)
			{
				if (text.Equals(string.Empty))
				{
					if (Convert.ToBoolean(RuntimeHelpers.GetObjectValue(item["IPEnabled"])))
					{
						text = item["MacAddress"].ToString();
					}
					item.Dispose();
				}
				text = text.Replace(":", string.Empty);
			}
			return text;
		}
		finally
		{
			((IDisposable)null)?.Dispose();
		}
	}

	internal string GetMotherBoardID()
	{
		ManagementObjectCollection.ManagementObjectEnumerator managementObjectEnumerator = null;
		string result = string.Empty;
		using ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher(new SelectQuery("Win32_BaseBoard"));
		managementObjectEnumerator = managementObjectSearcher.Get().GetEnumerator();
		while (managementObjectEnumerator.MoveNext())
		{
			result = ((ManagementObject)managementObjectEnumerator.Current)["SerialNumber"].ToString();
		}
		return result;
	}
}
