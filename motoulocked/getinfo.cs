using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using motoulocked.core;
using motoulocked.motoulocked;
using Newtonsoft.Json;

namespace motoulocked;

public class getinfo
{
	public static async Task<bool> getinfopro(string group)
	{
		long num = long.Parse(DateTime.Now.ToString("yyyyddhhmm"));
		string clss = JsonConvert.SerializeObject((object)new GetInfoSend
		{
			NameKey = group,
			Username = SevaClass.Userr,
			Token = SevaClass.Token,
			Tok = num.ToString()
		});
		string text = await Api_Core.TryRequestAsync("info2/", clss);
		checked
		{
			if (text.Contains("{"))
			{
				tokdata2 tokdata = JsonConvert.DeserializeObject<tokdata2>(text);
				if (long.Parse(tokdata.tok) == num + 10)
				{
					long num2 = num + 10;
					string group2 = tmpcrpt.DecryptString(tokdata.data, Api_Core.CalculateMD5Hash(num2.ToString()));
					paraminfotool.info1 = workinfo.getfromstringserver("info1", group2);
					paraminfotool.info2 = workinfo.getfromstringserver("info2", group2);
					paraminfotool.info3 = workinfo.getfromstringserver("info3", group2);
					return true;
				}
				Application.Exit();
				return false;
			}
			if (text.Contains("Error invalid Token"))
			{
				MessageBox.Show("التوكن غلط");
			}
			else if (text.Contains("Error Token has expired"))
			{
				MessageBox.Show("التوكن منتهي");
			}
			else if (text.Contains("Erorr Bad Request"))
			{
				MessageBox.Show("في خطاء في الطلب للسيرفر");
			}
			return false;
		}
	}

	public static async Task<string> getinfo1val(string nameval)
	{
		long num = long.Parse(DateTime.Now.ToString("yyyyddhhmm"));
		string clss = JsonConvert.SerializeObject((object)new GetInfoSend
		{
			NameKey = nameval,
			Username = SevaClass.Userr,
			Token = SevaClass.Token,
			Tok = num.ToString()
		});
		string text = await Api_Core.TryRequestAsync("info1val2/", clss);
		checked
		{
			if (text.Contains("{"))
			{
				tokdata2 tokdata = JsonConvert.DeserializeObject<tokdata2>(text);
				if (long.Parse(tokdata.tok) == num + 10)
				{
					_ = num + 10;
					return encryptor.DEC(tokdata.data);
				}
				Application.Exit();
				string result = default(string);
				return result;
			}
			if (text.Contains("Error invalid Token"))
			{
				MessageBox.Show("التوكن غلط");
			}
			else if (text.Contains("Error Token has expired"))
			{
				MessageBox.Show("التوكن منتهي");
			}
			else if (text.Contains("Erorr Bad Request"))
			{
				MessageBox.Show("في خطاء في الطلب للسيرفر");
			}
			MessageBox.Show("خطاء");
			return "خطاء";
		}
	}

	public static async Task<bool> getinfo2(string group)
	{
		long num = long.Parse(DateTime.Now.ToString("yyyyddhhmm"));
		string clss = JsonConvert.SerializeObject((object)new GetInfoSend
		{
			NameKey = group,
			Username = SevaClass.Userr,
			Token = SevaClass.Token,
			Tok = num.ToString()
		});
		string text = await Api_Core.TryRequestAsync("info2/", clss);
		checked
		{
			if (text.Contains("{"))
			{
				tokdata2 tokdata = JsonConvert.DeserializeObject<tokdata2>(text);
				if (long.Parse(tokdata.tok) == num + 10)
				{
					long num2 = num + 10;
					string text2 = tmpcrpt.DecryptString(tokdata.data, Api_Core.CalculateMD5Hash(num2.ToString()));
					new workinfo.getdata
					{
						groupinfo = group,
						numb = tokdata.numb,
						data = tmpcrpt.EncryptString(text2, tmpcrpt.keyQTx())
					};
					SevaClass.ReadCode = workinfo.getfromstringserver("But_Read_Code", text2);
					SevaClass.Mediatek = workinfo.getfromstringserver("But_Mediatek", text2);
					SevaClass.flashh = workinfo.getfromstringserver("But_Flash", text2);
					SevaClass.edll = workinfo.getfromstringserver("But_Qualcomm", text2);
					SevaClass.spd = workinfo.getfromstringserver("But_Unisoc", text2);
					SevaClass.Other_Service = workinfo.getfromstringserver("But_Services", text2);
					SevaClass.String1 = workinfo.getfromstringserver("String1", text2);
					SevaClass.String2 = workinfo.getfromstringserver("String2", text2);
					SevaClass.String3 = workinfo.getfromstringserver("String3", text2);
					Form1.String_7 = encr.Decrypt(SevaClass.String1, Form1.String_72) + encr.Decrypt(SevaClass.String2, Form1.String_72) + encr.Decrypt(SevaClass.String3, Form1.String_72);
					return true;
				}
				//Application.Exit();
				return false;
			}
			if (text.Contains("Error invalid Token"))
			{
				MessageBox.Show("Error invalid Token");
			}
			else if (text.Contains("Error Token has expired"))
			{
				MessageBox.Show("Error Token has expired");
			}
			else if (text.Contains("Erorr Bad Request"))
			{
				MessageBox.Show("Erorr Bad Request");
			}
			return false;
		}
	}

	public static async Task<int> getnumbinfo(string group)
	{
		long num = long.Parse(DateTime.Now.ToString("yyyyddhhmm"));
		string clss = JsonConvert.SerializeObject((object)new GetInfoSend
		{
			NameKey = group,
			Username = SevaClass.Userr,
			Token = SevaClass.Token,
			Tok = num.ToString()
		});
		string text = await Api_Core.TryRequestAsync("infovar2/", clss);
		checked
		{
			if (text.Contains("{"))
			{
				tokdata2 tokdata = JsonConvert.DeserializeObject<tokdata2>(text);
				if (long.Parse(tokdata.tok) == num + 10)
				{
					long num2 = num + 10;
					return int.Parse(tmpcrpt.DecryptString(tokdata.data, Api_Core.CalculateMD5Hash(num2.ToString())));
				}
				Application.Exit();
				return 0;
			}
			if (text.Contains("Error invalid Token"))
			{
				MessageBox.Show("التوكن غلط");
			}
			else if (text.Contains("Error Token has expired"))
			{
				MessageBox.Show("التوكن منتهي");
			}
			else if (text.Contains("Erorr Bad Request"))
			{
				MessageBox.Show("في خطاء في الطلب للسيرفر");
			}
			return 0;
		}
	}
}
