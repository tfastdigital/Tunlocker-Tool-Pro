using System;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using motoulocked.core;
using Newtonsoft.Json;

namespace motoulocked;

public class Send_Log
{
	public static async Task<string> sndlogm(OperationToolapi ggg)
	{
		string clss = JsonConvert.SerializeObject((object)ggg);
		string text = await Api_Core.TryRequestAsync("Optionapi/", clss);
		if (text.Contains("Operation added successfully Operation ID :"))
		{
			return text.Replace("Operation added successfully Operation ID : ", "");
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
			return "error";
		}
		if (text.Contains("Error Token has expired"))
		{
			Api_Core.MethodD_9();
			Interaction.Beep();
			return "error";
		}
		return text;
	}
}
