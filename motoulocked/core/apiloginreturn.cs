using System;

namespace motoulocked.core;

public class apiloginreturn
{
	public bool Blocked { get; set; }

	public string Types { get; set; }

	public DateTime StartDate { get; set; }

	public DateTime EndTime { get; set; }

	public decimal Credit { get; set; }

	public string Hwid { get; set; }

	public string Name { get; set; }

	public bool Activate { get; set; }

	public string token { get; set; }

	public string username { get; set; }

	public string email { get; set; }

	public string Restricted_modle { get; set; }

	public string Restricted_func { get; set; }

	public string tok2 { get; set; }
}
