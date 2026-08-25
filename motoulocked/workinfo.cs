using System;
using System.Collections.Generic;
using Microsoft.VisualBasic.CompilerServices;
using Newtonsoft.Json;

namespace motoulocked;

public class workinfo
{
	public class getdata
	{
		public string groupinfo { get; set; }

		public string data { get; set; }

		public string numb { get; set; }
	}

	public static string getfromstringserver(string key, string group)
	{
		string result;
		try
		{
			result = JsonConvert.DeserializeObject<Dictionary<string, object>>(group)[key].ToString();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			result = "ERROR " + ex2.Message;
			ProjectData.ClearProjectError();
		}
		return result;
	}
}
