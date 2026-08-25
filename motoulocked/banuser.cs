using System;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using motoulocked.core;
using Newtonsoft.Json;

namespace motoulocked;

public class banuser
{
	public static async Task<bool> ban(banclass ggg)
	{
		long.Parse(DateTime.Now.ToString("yyyyddhhmm"));
		string clss = JsonConvert.SerializeObject((object)ggg);
		string text = await Api_Core.TryRequestAsync("ban/", clss);
		if (text.Contains("ban ok"))
		{
			return true;
		}
		if (text.Contains("New update is available"))
		{
			try
			{
				toolparam.uptool = text;
				Api_Core.MethodD_7();
				Interaction.Beep();
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
			return false;
		}
		Api_Core.MethodD_9();
		return false;
	}
}
