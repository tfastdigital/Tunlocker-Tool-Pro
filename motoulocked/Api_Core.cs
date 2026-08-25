using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.FileIO;
using motoulocked.core;
using motoulocked.motoulocked;
using motoulocked.My;
using Newtonsoft.Json;

namespace motoulocked;

public class Api_Core
{
	public static WebResponse responsexx;

	public static string serverhost = "https://api.tfastdigital.com/api/server";

	public static string FromBase64(string base64Input)
	{
		byte[] bytes = Convert.FromBase64String(base64Input);
		return Encoding.UTF8.GetString(bytes);
	}

	public static async Task<string> TryRequestAsync(string link, string clss)
	{
		string plainText = tmpcrpt.EncryptString(JsonConvert.SerializeObject((object)new ggfnew
		{
			dataapi = encryptor.ENC(clss),
			Forward = link
		}), tmpcrpt.keyQTx());
		string text = tmpcrpt.CalculateMD5Hash(DateTime.Now.Ticks.ToString());
		string arg = SymbolEnc.EncryptText(text);
		string text2 = JsonConvert.SerializeObject((object)new tokdata
		{
			data = tmpcrpt.EncryptString(plainText, text)
		});
		HttpClient val = new HttpClient();
		HttpRequestMessage val2 = new HttpRequestMessage(HttpMethod.Post, serverhost + $"/{arg}");
		StringContent content = new StringContent(text2, (Encoding)null, "application/json");
		val2.Content = (HttpContent)(object)content;
		try
		{
			HttpResponseMessage val3 = await val.SendAsync(val2);
			if (val3.IsSuccessStatusCode)
			{
				string text3 = await val3.Content.ReadAsStringAsync();
				try
				{
					string text4 = tmpcrpt.DecryptString(text3, text);
					if (text4.Contains("data"))
					{
						return tmpcrpt.DecryptString(JsonConvert.DeserializeObject<tokdata>(text4).data, tmpcrpt.keyQTx());
					}
					if (Operators.CompareString(text4, "null", TextCompare: false) == 0)
					{
						string text5 = tmpcrpt.DecryptString(text3, tmpcrpt.keyQTx());
						if (Operators.CompareString(text5, "null", TextCompare: false) == 0)
						{
							return text3;
						}
						return text5;
					}
					return text4;
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					string result = text3;
					ProjectData.ClearProjectError();
					return result;
				}
			}
			return "ERROR: " + val3.StatusCode;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			string result = "ERROR SERVER: " + ex2.Message;
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public static string CalculateMD5Hash(string input)
	{
		checked
		{
			using MD5 mD = MD5.Create();
			byte[] bytes = Encoding.UTF8.GetBytes(input);
			byte[] array = mD.ComputeHash(bytes);
			StringBuilder stringBuilder = new StringBuilder();
			int num = array.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				stringBuilder.Append(array[i].ToString("x2"));
			}
			return stringBuilder.ToString().ToUpper();
		}
	}

	public static object MethodD_5(string input, Color CALA)
	{
		Form1.SharedUI.GroupBox_ProgressBar.Invoke((Action)([SpecialName] () =>
		{
			Form1.SharedUI.GroupBox_ProgressBar.Visible = false;
		}));
		Form1.SharedUI.RichTextBox8.Invoke((Action)([SpecialName] () =>
		{
			Form1.SharedUI.RichTextBox8.Visible = true;
		}));
		Form1.SharedUI.RichTextBox8.SelectionColor = CALA;
		Form1.SharedUI.RichTextBox8.AppendText(Environment.NewLine + input);
		Form1.SharedUI.Panel1.Invoke((Action)([SpecialName] () =>
		{
			Form1.SharedUI.Panel1.Enabled = true;
		}));
		Form1.SharedUI.Label27.Text = "100%";
		Form1.SharedUI.Guna2TaskBarProgress1.State = Guna2TaskBarProgress.TaskbarStates.Normal;
		Form1.SharedUI.Guna2TaskBarProgress1.Value = 0;
		object result = default(object);
		return result;
	}

	public static object MethodD_8(string input, Color CALA)
	{
		Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
		Form1.SharedUI.RichTextBox1.AppendText(ClassDevronix.StringO);
		Form1.SharedUI.RichTextBox1.Update();
		Form1.SharedUI.RichTextBox1.SelectionColor = CALA;
		Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + input);
		Form1.SharedUI.ProgressBar1.Roll = false;
		Form1.SharedUI.ProgressBar1.Text = "100%";
		if (Operators.CompareString(Form1.String_15, null, TextCompare: false) != 0)
		{
			string directory = ClassDevronix.CWQ + Form1.String_15;
			try
			{
				MyProject.Computer.FileSystem.DeleteDirectory(directory, DeleteDirectoryOption.DeleteAllContents);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}
		Form1.SharedUI.Guna2TaskBarProgress1.State = Guna2TaskBarProgress.TaskbarStates.Error;
		Form1.SharedUI.Guna2TaskBarProgress1.Value = 0;
		object result = default(object);
		return result;
	}

	public static string ExtractFirstAddText(string inputText)
	{
		string text = "● [Add] :-";
		string value = "▪\ufe0f▪\ufe0f▪\ufe0f▪\ufe0f▪\ufe0f▪\ufe0f▪\ufe0f▪\ufe0f▪\ufe0f▪\ufe0f[";
		int num = inputText.IndexOf(text);
		checked
		{
			if (num != -1)
			{
				num += text.Length;
				int num2 = inputText.IndexOf(value, num);
				if (num2 != -1)
				{
					return inputText.Substring(num, num2 - num).Trim();
				}
			}
			return string.Empty;
		}
	}

	public static object MethodD_6()
	{
		Newupdate newupdate = JsonConvert.DeserializeObject<Newupdate>(toolparam.uptool);
		string inputText = FromBase64(newupdate.ChangeLog);
		SevaClass.log = newupdate.ChangeLog;
		Form1.SharedUI.RichTextBox_log_Update.Text = ExtractFirstAddText(inputText);
		Form1.SharedUI.GroupBoxUpdate1.Text = "Last Updated (" + newupdate.varizon + ")";
		Form1.String_18 = newupdate.link;
		try
		{
			File.Delete(Form1.String_73 + "adb.exe");
			File.Delete(Form1.String_73 + "AdbWinApi.dll");
			File.Delete(Form1.String_73 + "AdbWinUsbApi.dll");
			File.Delete(Form1.String_73 + "fastboot.exe");
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
		Form1.SharedUI.Panel3.Invoke((Action)([SpecialName] () =>
		{
			Form1.SharedUI.Panel3.Visible = true;
		}));
		Form1.SharedUI.Panel1.Invoke((Action)([SpecialName] () =>
		{
			Form1.SharedUI.Panel1.Enabled = true;
		}));
		Form1.SharedUI.GroupBox_ProgressBar.Invoke((Action)([SpecialName] () =>
		{
			Form1.SharedUI.GroupBox_ProgressBar.Visible = false;
		}));
		Form1.SharedUI.Label27.Text = "100%";
		Form1.SharedUI.Guna2TaskBarProgress1.State = Guna2TaskBarProgress.TaskbarStates.Normal;
		Form1.SharedUI.Guna2TaskBarProgress1.Value = 0;
		Form1.SharedUI.Guna2Transition1.ShowSync(Form1.SharedUI.Panel4);
		Form1.SharedUI.ProgressBar2.Text = "0%";
		lass0.Check_Show_Change_Log_1();
		Interaction.Beep();
		object result = default(object);
		return result;
	}

	public static object portNameSettings(double dblSecs)
	{
		DateAndTime.Now.AddSeconds(1.1574074074074073E-05);
		DateTime t = DateAndTime.Now.AddSeconds(1.1574074074074073E-05).AddSeconds(dblSecs);
		while (DateTime.Compare(DateAndTime.Now, t) <= 0)
		{
			Application.DoEvents();
		}
		object result = default(object);
		return result;
	}

	public static object MethodD_7()
	{
		Newupdate newupdate = JsonConvert.DeserializeObject<Newupdate>(toolparam.uptool);
		string text = FromBase64(newupdate.ChangeLog);
		SevaClass.log = newupdate.ChangeLog;
		Form1.SharedUI.RichTextBox_log_Update.Text = text;
		Form1.SharedUI.GroupBoxUpdate1.Text = "Last Updated (" + newupdate.varizon + ")";
		Form1.String_18 = newupdate.link;
		try
		{
			File.Delete(Form1.String_73 + "adb.exe");
			File.Delete(Form1.String_73 + "AdbWinApi.dll");
			File.Delete(Form1.String_73 + "AdbWinUsbApi.dll");
			File.Delete(Form1.String_73 + "fastboot.exe");
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
		Form1.SharedUI.Panel3.Invoke((Action)([SpecialName] () =>
		{
			Form1.SharedUI.Panel3.Visible = true;
		}));
		Form1.SharedUI.GroupBox_ProgressBar.Invoke((Action)([SpecialName] () =>
		{
			Form1.SharedUI.GroupBox_ProgressBar.Visible = false;
		}));
		Form1.SharedUI.Guna2TaskBarProgress1.State = Guna2TaskBarProgress.TaskbarStates.Normal;
		Form1.SharedUI.Guna2TaskBarProgress1.Value = 0;
		Form1.SharedUI.Guna2Transition1.ShowSync(Form1.SharedUI.Panel4);
		Form1.SharedUI.ProgressBar2.Text = "0%";
		lass0.Check_Show_Change_Log_1();
		Interaction.Beep();
		object result = default(object);
		return result;
	}

	public static object MethodD_9()
	{
		checked
		{
			try
			{
				try
				{
					Form1.TextBox41 = "Cancel";
					SerialCOM.process.Kill();
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception projectError = ex;
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
					ProjectData.ClearProjectError();
				}
				try
				{
					Process[] processesByName = Process.GetProcessesByName("7z");
					int num = 0;
					do
					{
						processesByName[num].Kill();
						num++;
					}
					while (num < processesByName.Length);
				}
				catch (Exception ex2)
				{
					ProjectData.SetProjectError(ex2);
					Exception projectError2 = ex2;
					ProjectData.SetProjectError(projectError2);
					ProjectData.ClearProjectError();
					ProjectData.ClearProjectError();
				}
				try
				{
					Process[] processesByName2 = Process.GetProcessesByName("adb");
					int num2 = 0;
					do
					{
						processesByName2[num2].Kill();
						num2++;
					}
					while (num2 < processesByName2.Length);
				}
				catch (Exception ex3)
				{
					ProjectData.SetProjectError(ex3);
					Exception projectError3 = ex3;
					ProjectData.SetProjectError(projectError3);
					ProjectData.ClearProjectError();
					ProjectData.ClearProjectError();
				}
				try
				{
					Process[] processesByName3 = Process.GetProcessesByName("emmcdl");
					int num3 = 0;
					do
					{
						processesByName3[num3].Kill();
						num3++;
					}
					while (num3 < processesByName3.Length);
				}
				catch (Exception ex4)
				{
					ProjectData.SetProjectError(ex4);
					Exception projectError4 = ex4;
					ProjectData.SetProjectError(projectError4);
					ProjectData.ClearProjectError();
					ProjectData.ClearProjectError();
				}
				try
				{
					File.Delete(Form1.String_73 + "adb.exe");
					File.Delete(Form1.String_73 + "AdbWinApi.dll");
					File.Delete(Form1.String_73 + "AdbWinUsbApi.dll");
					File.Delete(Form1.String_73 + "fastboot.exe");
				}
				catch (Exception ex5)
				{
					ProjectData.SetProjectError(ex5);
					Exception ex6 = ex5;
					ProjectData.ClearProjectError();
				}
				Form1.SharedUI.MaterialCard5.Invoke((Action)([SpecialName] () =>
				{
					Form1.SharedUI.MaterialCard5.Enabled = false;
				}));
				Form1.SharedUI.MaterialCard3.Invoke((Action)([SpecialName] () =>
				{
					Form1.SharedUI.MaterialCard3.Enabled = false;
				}));
				Form1.SharedUI.Panel3.Invoke((Action)([SpecialName] () =>
				{
					Form1.SharedUI.Panel3.Visible = true;
				}));
				Form1.SharedUI.CheckBox2.Invoke((Action)([SpecialName] () =>
				{
					Form1.SharedUI.CheckBox2.Checked = false;
				}));
				lass0.UserName_Password();
				Form1.SharedUI.GroupBox_ProgressBar.Invoke((Action)([SpecialName] () =>
				{
					Form1.SharedUI.GroupBox_ProgressBar.Visible = false;
				}));
				Form1.SharedUI.Guna2TaskBarProgress1.State = Guna2TaskBarProgress.TaskbarStates.Normal;
				Form1.SharedUI.Guna2TaskBarProgress1.Value = 0;
				Form1.SharedUI.ProgressBar1.Roll = false;
				Form1.SharedUI.ProgressBar1.Text = "100%";
			}
			catch (Exception ex7)
			{
				ProjectData.SetProjectError(ex7);
				Exception ex8 = ex7;
				ProjectData.ClearProjectError();
			}
			object result = default(object);
			return result;
		}
	}
}
