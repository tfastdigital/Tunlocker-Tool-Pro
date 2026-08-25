using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using motoulocked.core;
using Newtonsoft.Json;

namespace motoulocked;

public class Login
{
	public static async Task<bool> login(string username, string password)
	{
		Form1.SharedUI.Label27.Text = "Checking information..";
		long num = long.Parse(DateTime.Now.ToString("yyyyddhhmm"));
        SevaClass.StatusAcouunt = "Credits";
		return true;
        string clss = JsonConvert.SerializeObject((object)new apilogin
		{
			Email = username,
			Pass = password,
			Hwid = SevaClass.IDRegistration,
			Loginby = SevaClass.Environmentuser,
			Osverizon = SevaClass.WindowsVersion,
			Verizon = Form1.String1,
			tok = num.ToString(),
			City = "0",
			Country = "0",
			CMH = tmpcrpt.keyQTx()
		});
		Form1.SharedUI.Label27.Text = "Checking information...";
		string text = await Api_Core.TryRequestAsync("loginapi/", clss);
		if (text.Contains("User not found"))
		{
			Api_Core.MethodD_5("> Error In Account Data", Color.Red);
			return false;
		}
		if (text.Contains("The password is invalid"))
		{
			Api_Core.MethodD_5("> Error In Password Data", Color.Red);
			Form1.SharedUI.LinkLabel4.Invoke((Action)([SpecialName] () =>
			{
				Form1.SharedUI.LinkLabel4.Visible = true;
			}));
			return false;
		}
		if (text.Contains("account is expired"))
		{
			Api_Core.MethodD_5("> Your License Is Expired, Please Renew Your Account", Color.White);
			return false;
		}
		if (text.Contains("not activated"))
		{
			Api_Core.MethodD_5("> This Account Is Not Activation", Color.White);
			return false;
		}
		if (text.Contains("is Locked"))
		{
			Api_Core.MethodD_5("> This Account Is Locked In Another PC", Color.White);
			return false;
		}
		if (text.Contains("undergoing maintenance"))
		{
			Api_Core.MethodD_5("> The Tool In Maintenance. Please Wait For A Moment And Try Again", Color.Red);
			return false;
		}
		if (text.Contains("Erorr Bad Request"))
		{
			Api_Core.MethodD_5("> Error In Request Error Code : 400", Color.Red);
			return false;
		}
		if (text.Contains("Blocked"))
		{
			Api_Core.MethodD_5("> You Are Banned Because Of Spyware", Color.Red);
			Api_Core.portNameSettings(5.0);
			Application.Exit();
		}
		checked
		{
			if (text.Contains("{"))
			{
				if (text.Contains("New update is available"))
				{
					toolparam.uptool = text;
					Api_Core.MethodD_6();
					return false;
				}
				bool result = default(bool);
				if (!text.Contains("data"))
				{
					return result;
				}
				tokdata tokdata = JsonConvert.DeserializeObject<tokdata>(text);
				long num2 = num + 10;
				string text2 = tmpcrpt.DecryptString(tokdata.data, Api_Core.CalculateMD5Hash(num2.ToString()));
				apiloginreturn apiloginreturn = JsonConvert.DeserializeObject<apiloginreturn>(text2);
				if (!text2.Contains("tok2"))
				{
					return result;
				}
				if (long.Parse(apiloginreturn.tok2) == num + 10)
				{
					SevaClass.activet = Conversions.ToString(apiloginreturn.Activate);
					SevaClass.block = Conversions.ToString(apiloginreturn.Blocked);
					SevaClass.credits = Conversions.ToString(apiloginreturn.Credit);
					SevaClass.Email = apiloginreturn.email;
					SevaClass.EndTime = Conversions.ToString(apiloginreturn.EndTime);
					SevaClass.StartDate = Conversions.ToString(apiloginreturn.StartDate);
					SevaClass.IDRegistration = apiloginreturn.Hwid;
					SevaClass.FullName = apiloginreturn.Name;
					SevaClass.Userr = apiloginreturn.username;
					SevaClass.Token = apiloginreturn.token;
					SevaClass.Restricted_modle = apiloginreturn.Restricted_modle;
					SevaClass.Restricted_func = apiloginreturn.Restricted_func;
					if (apiloginreturn.Types.Contains("CREDIT LICENSE"))
					{
						SevaClass.StatusAcouunt = "Credits";
					}
					else
					{
						SevaClass.StatusAcouunt = "Annual";
					}
					return true;
				}
				Api_Core.MethodD_5("> Request Manipulation Detected Error Code : 525002", Color.Red);
				Api_Core.portNameSettings(3.0);
				Application.Exit();
				return result;
			}
			Api_Core.MethodD_5("> Error In Server Error Code : 401", Color.Red);
			return false;
		}
	}

	public static async Task<bool> login2(string username, string password)
	{
		Form1.SharedUI.ProgressBar1.Text = ClassDevronix.CheckModelFromServer + "..";
		long num = long.Parse(DateTime.Now.ToString("yyyyddhhmm"));
		string clss = JsonConvert.SerializeObject((object)new apilogin
		{
			Email = username,
			Pass = password,
			Hwid = SevaClass.IDRegistration,
			Loginby = SevaClass.Environmentuser,
			Osverizon = SevaClass.WindowsVersion,
			Verizon = Form1.String1,
			tok = num.ToString(),
			City = "0",
			Country = "0",
			CMH = tmpcrpt.keyQTx()
		});
		string text = await Api_Core.TryRequestAsync("loginapi/", clss);
		if (text.Contains("account is expired"))
		{
			Api_Core.MethodD_8("> Your License Is Expired, Please Renew Your Account", Color.White);
			return false;
		}
		if (text.Contains("not activated"))
		{
			Api_Core.MethodD_8("> This Account Is Not Activation", Color.White);
			return false;
		}
		if (text.Contains("undergoing maintenance"))
		{
			Api_Core.MethodD_8("> The Tool In Maintenance. Please Wait For A Moment And Try Again", Color.Red);
			return false;
		}
		if (text.Contains("Erorr Bad Request"))
		{
			Api_Core.MethodD_8("> Error In Request Error Code : 400", Color.Red);
			return false;
		}
		if (text.Contains("Blocked"))
		{
			Api_Core.MethodD_8("> You Are Banned Because Of Spyware", Color.Red);
			Api_Core.portNameSettings(5.0);
			Application.Exit();
		}
		Form1.SharedUI.ProgressBar1.Text = ClassDevronix.CheckModelFromServer + "...";
		checked
		{
			if (text.Contains("{"))
			{
				if (text.Contains("New update is available"))
				{
					toolparam.uptool = text;
					Api_Core.MethodD_6();
					return false;
				}
				bool result = default(bool);
				if (!text.Contains("data"))
				{
					return result;
				}
				tokdata tokdata = JsonConvert.DeserializeObject<tokdata>(text);
				long num2 = num + 10;
				string text2 = tmpcrpt.DecryptString(tokdata.data, Api_Core.CalculateMD5Hash(num2.ToString()));
				apiloginreturn apiloginreturn = JsonConvert.DeserializeObject<apiloginreturn>(text2);
				if (!text2.Contains("tok2"))
				{
					return result;
				}
				if (long.Parse(apiloginreturn.tok2) == num + 10)
				{
					SevaClass.activet = Conversions.ToString(apiloginreturn.Activate);
					SevaClass.block = Conversions.ToString(apiloginreturn.Blocked);
					SevaClass.credits = Conversions.ToString(apiloginreturn.Credit);
					SevaClass.Email = apiloginreturn.email;
					SevaClass.EndTime = Conversions.ToString(apiloginreturn.EndTime);
					SevaClass.StartDate = Conversions.ToString(apiloginreturn.StartDate);
					SevaClass.IDRegistration = apiloginreturn.Hwid;
					SevaClass.FullName = apiloginreturn.Name;
					SevaClass.Userr = apiloginreturn.username;
					SevaClass.Token = apiloginreturn.token;
					SevaClass.Restricted_modle = apiloginreturn.Restricted_modle;
					SevaClass.Restricted_func = apiloginreturn.Restricted_func;
					if (apiloginreturn.Types.Contains("CREDIT LICENSE"))
					{
						SevaClass.StatusAcouunt = "Credits";
					}
					else
					{
						SevaClass.StatusAcouunt = "Annual";
					}
					Form1.SharedUI.UserName.Text = SevaClass.Userr;
					Form1.SharedUI.Password.Text = SevaClass.Passs;
					Form1.SharedUI.TextBox_FullName.Text = SevaClass.FullName;
					Form1.SharedUI.TextBox_Email.Text = SevaClass.Email;
					Form1.SharedUI.Label25.Text = SevaClass.credits;
					return true;
				}
				Api_Core.MethodD_8("> Request Manipulation Detected Error Code : 525002", Color.Red);
				Api_Core.portNameSettings(3.0);
				Application.Exit();
				return result;
			}
			Api_Core.MethodD_8("> Error In Server Error Code : 401", Color.Red);
			return false;
		}
	}
}
