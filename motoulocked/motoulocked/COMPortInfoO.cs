using System.Collections.Generic;
using System.Management;
using System.Runtime.CompilerServices;

namespace motoulocked.motoulocked;

public class COMPortInfoO
{
	public string Description { get; set; }

	public string Name { get; set; }

	public static List<COMPortInfoO> GetCOMPortsInfoO()
	{
		List<COMPortInfoO> list = new List<COMPortInfoO>();
		ObjectQuery query = new ObjectQuery("SELECT * FROM WIN32_SerialPort");
		ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher(query);
		using (managementObjectSearcher)
		{
			foreach (ManagementObject item in managementObjectSearcher.Get())
			{
				if (item == null)
				{
					continue;
				}
				object objectValue = RuntimeHelpers.GetObjectValue(item["Caption"]);
				if (objectValue != null)
				{
					string text = objectValue.ToString();
					if (text.Contains("(COM"))
					{
						list.Add(new COMPortInfoO
						{
							Name = text.Substring(text.LastIndexOf("(COM")).Replace("(", string.Empty).Replace(")", ""),
							Description = text
						});
					}
				}
			}
			return list;
		}
	}

	public static List<COMPortInfoO> GetCOMPortsInfolg()
	{
		List<COMPortInfoO> list = new List<COMPortInfoO>();
		ObjectQuery query = new ObjectQuery("SELECT * FROM Win32_PnPEntity WHERE Caption like '%(COM%'");
		ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher(query);
		using (managementObjectSearcher)
		{
			foreach (ManagementObject item in managementObjectSearcher.Get())
			{
				if (item == null)
				{
					continue;
				}
				object objectValue = RuntimeHelpers.GetObjectValue(item["Caption"]);
				if (objectValue != null)
				{
					string text = objectValue.ToString();
					if (text.Contains("(COM"))
					{
						list.Add(new COMPortInfoO
						{
							Name = text.Substring(text.LastIndexOf("(COM")).Replace("(", string.Empty).Replace(")", ""),
							Description = text
						});
					}
				}
			}
			return list;
		}
	}

	public static List<COMPortInfoO> GetCOMPortsInfoOO()
	{
		List<COMPortInfoO> list = new List<COMPortInfoO>();
		ObjectQuery query = new ObjectQuery("SELECT * FROM Win32_POTSModem");
		ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher(query);
		using (managementObjectSearcher)
		{
			foreach (ManagementObject item in managementObjectSearcher.Get())
			{
				if (item == null)
				{
					continue;
				}
				object objectValue = RuntimeHelpers.GetObjectValue(item["Caption"]);
				if (objectValue != null)
				{
					string text = objectValue.ToString();
					if (text.Contains("(COM"))
					{
						list.Add(new COMPortInfoO
						{
							Name = text.Substring(text.LastIndexOf("(COM")).Replace("(", string.Empty).Replace(")", ""),
							Description = text
						});
					}
				}
			}
			return list;
		}
	}
}
