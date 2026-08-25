using System;
using System.Threading.Tasks;
using Microsoft.VisualBasic.CompilerServices;
using motoulocked.core;
using Newtonsoft.Json;

namespace motoulocked;

public class Balancepdate
{
	public static async Task<Balancepdatetregg> cost(Balancepdateclass ggg)
	{
		long.Parse(DateTime.Now.ToString("yyyyddhhmm"));
		string clss = JsonConvert.SerializeObject((object)ggg);
		Balancepdatetregg balancepdatetregg = new Balancepdatetregg
		{
			Notes = "error"
		};
		string text = await Api_Core.TryRequestAsync("Balancepdate/", clss);
		Balancepdatetregg result = default(Balancepdatetregg);
		if (text.Contains("Balance updated successfully") || text.Contains("The task Credit") || text.Contains("No discount"))
		{
			try
			{
				balancepdatetregg = JsonConvert.DeserializeObject<Balancepdatetregg>(text);
				return balancepdatetregg;
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				result = balancepdatetregg;
				ProjectData.ClearProjectError();
				return result;
			}
		}
		return result;
	}
}
