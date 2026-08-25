using System;
using System.Collections.Generic;
using System.Management;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;

namespace motoulocked;

public class GClass0
{
	private static string string_0 = string.Empty;

	private static readonly List<string> list_1 = new List<string> { "Manufacturer", "SerialNumber" };

	public static string Environmentuser => $"{Environment.MachineName} - {Environment.UserName}";

	public static string smethod_0()
	{
		if (string.IsNullOrEmpty(string_0))
		{
			string arg = smethod_4();
			string_0 = smethod_1($"BIOS:{arg}");
		}
		return string_0;
	}

	private static string smethod_1(string string_1)
	{
		string result;
		try
		{
			using MD5 mD = MD5.Create();
			StringBuilder stringBuilder = new StringBuilder();
			byte[] array = mD.ComputeHash(Encoding.UTF8.GetBytes(string_1));
			foreach (byte b in array)
			{
				stringBuilder.Append(b.ToString("x2").ToLower());
			}
			result = stringBuilder.ToString().ToUpperInvariant();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			result = ex2.Message;
			ProjectData.ClearProjectError();
		}
		return result;
	}

	private static string smethod_2(string string_1, List<string> list_6)
	{
		string text = string.Empty;
		try
		{
			foreach (ManagementObject instance in new ManagementClass(string_1).GetInstances())
			{
				foreach (string item in list_6)
				{
					try
					{
						if (Operators.CompareString(item, "MACAddress", TextCompare: false) != 0)
						{
							goto IL_007b;
						}
						if (!string.IsNullOrWhiteSpace(text))
						{
							return text;
						}
						if (Operators.CompareString(instance["IPEnabled"].ToString(), "True", TextCompare: false) == 0)
						{
							goto IL_007b;
						}
						goto end_IL_003e;
						IL_007b:
						object objectValue = RuntimeHelpers.GetObjectValue(instance[item]);
						if (objectValue != null)
						{
							string text2 = objectValue.ToString();
							if (!string.IsNullOrWhiteSpace(text2))
							{
								text = text + text2 + "; ";
							}
						}
						end_IL_003e:;
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						ProjectData.ClearProjectError();
					}
				}
			}
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
		return text.TrimEnd(' ', ';');
	}

	private static string smethod_4()
	{
		return smethod_2("Win32_BIOS", list_1);
	}

	public static string GetWindowsVersion()
	{
		try
		{
			using RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion");
			if (registryKey != null)
			{
				string text = registryKey.GetValue("ProductName") as string;
				string text2 = registryKey.GetValue("CurrentVersion") as string;
				if (!string.IsNullOrEmpty(text) && !string.IsNullOrEmpty(text2))
				{
					return $"{text} {text2}";
				}
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Console.WriteLine($"Error: {ex2.Message}");
			ProjectData.ClearProjectError();
		}
		return "Unable to determine Windows version";
	}
}
