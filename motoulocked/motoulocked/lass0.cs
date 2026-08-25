using System;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;

namespace motoulocked.motoulocked;

public class lass0
{
	public static object Check_Show_Change_Log_1()
	{
		bool flag = true;
		string log = SevaClass.log;
		RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE", writable: true);
		registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Tunlocker Tool", writable: true);
		registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Tunlocker Tool\\Update", writable: true);
		if (registryKey == null)
		{
			registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE", writable: true);
			registryKey.CreateSubKey("Tunlocker Tool");
			registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Tunlocker Tool", writable: true);
			registryKey.CreateSubKey("Update");
			registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Tunlocker Tool\\Update", writable: true);
			registryKey.SetValue("Check_Show", flag);
			registryKey.SetValue("Change_Log", log);
			registryKey.Close();
		}
		else
		{
			registryKey.SetValue("Check_Show", flag);
			registryKey.SetValue("Change_Log", log);
			registryKey.Close();
		}
		object result = default(object);
		return result;
	}

	public static bool Data_Update()
	{
		bool result;
		try
		{
			result = Conversions.ToBoolean(Conversions.ToString(Registry.LocalMachine.OpenSubKey("SOFTWARE\\Tunlocker Tool\\Update", writable: true).GetValue("Check_Show")));
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			result = false;
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public static string Data_Update_ChangLog()
	{
		string result;
		try
		{
			result = Conversions.ToString(Registry.LocalMachine.OpenSubKey("SOFTWARE\\Tunlocker Tool\\Update", writable: true).GetValue("Change_Log"));
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			result = "null";
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public static object Remeber_Me_AutoLogIn()
	{
		bool @checked = Form1.SharedUI.CheckBox1.Checked;
		bool checked2 = Form1.SharedUI.CheckBox2.Checked;
		RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE", writable: true);
		registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Tunlocker Tool", writable: true);
		registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Tunlocker Tool\\FileUser", writable: true);
		if (registryKey == null)
		{
			registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE", writable: true);
			registryKey.CreateSubKey("Tunlocker Tool");
			registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Tunlocker Tool", writable: true);
			registryKey.CreateSubKey("FileUser");
			registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Tunlocker Tool\\FileUser", writable: true);
			registryKey.SetValue("Read_me", @checked);
			registryKey.SetValue("Auto_Login", checked2);
			registryKey.Close();
		}
		else
		{
			registryKey.SetValue("Read_me", @checked);
			registryKey.SetValue("Auto_Login", checked2);
			registryKey.Close();
		}
		object result = default(object);
		return result;
	}

	public static object PortShow()
	{
		int num = Conversions.ToInteger(Form1.SharedUI.Temp_Credits.Text);
		Registry.LocalMachine.OpenSubKey("SOFTWARE", writable: true);
		Registry.LocalMachine.OpenSubKey("SOFTWARE\\Tunlocker Tool", writable: true);
		if (Registry.LocalMachine.OpenSubKey("SOFTWARE\\Tunlocker Tool\\FileUser", writable: true) == null)
		{
			Registry.LocalMachine.OpenSubKey("SOFTWARE", writable: true).CreateSubKey("Tunlocker Tool");
			Registry.LocalMachine.OpenSubKey("SOFTWARE\\Tunlocker Tool", writable: true).CreateSubKey("FileUser");
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Tunlocker Tool\\FileUser", writable: true);
			registryKey.SetValue("Integer_Temp", num);
			registryKey.Close();
		}
		else
		{
			Registry.LocalMachine.OpenSubKey("SOFTWARE", writable: true);
			Registry.LocalMachine.OpenSubKey("SOFTWARE\\Tunlocker Tool", writable: true);
			RegistryKey registryKey2 = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Tunlocker Tool\\FileUser", writable: true);
			registryKey2.SetValue("Integer_Temp", num);
			registryKey2.Close();
		}
		object result = default(object);
		return result;
	}

	public static object Integer_Temp()
	{
		int num = 100;
		Form1.SharedUI.Temp_Credits.Text = "100";
		Registry.LocalMachine.OpenSubKey("SOFTWARE", writable: true);
		Registry.LocalMachine.OpenSubKey("SOFTWARE\\Tunlocker Tool", writable: true);
		if (Registry.LocalMachine.OpenSubKey("SOFTWARE\\Tunlocker Tool\\FileUser", writable: true) == null)
		{
			Registry.LocalMachine.OpenSubKey("SOFTWARE", writable: true).CreateSubKey("Tunlocker Tool");
			Registry.LocalMachine.OpenSubKey("SOFTWARE\\Tunlocker Tool", writable: true).CreateSubKey("FileUser");
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Tunlocker Tool\\FileUser", writable: true);
			registryKey.SetValue("Integer_Temp", num);
			registryKey.Close();
		}
		else
		{
			Registry.LocalMachine.OpenSubKey("SOFTWARE", writable: true);
			Registry.LocalMachine.OpenSubKey("SOFTWARE\\Tunlocker Tool", writable: true);
			RegistryKey registryKey2 = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Tunlocker Tool\\FileUser", writable: true);
			registryKey2.SetValue("Integer_Temp", num);
			registryKey2.Close();
		}
		object result = default(object);
		return result;
	}

	public static object Check_Show_Change_Log()
	{
		bool flag = false;
		string value = "null";
		RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE", writable: true);
		registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Tunlocker Tool", writable: true);
		registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Tunlocker Tool\\Update", writable: true);
		if (registryKey == null)
		{
			registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE", writable: true);
			registryKey.CreateSubKey("Tunlocker Tool");
			registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Tunlocker Tool", writable: true);
			registryKey.CreateSubKey("Update");
			registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Tunlocker Tool\\Update", writable: true);
			registryKey.SetValue("Check_Show", flag);
			registryKey.SetValue("Change_Log", value);
			registryKey.Close();
		}
		else
		{
			registryKey.SetValue("Check_Show", flag);
			registryKey.SetValue("Change_Log", value);
			registryKey.Close();
		}
		object result = default(object);
		return result;
	}

	public static object String_Temp()
	{
		Registry.LocalMachine.OpenSubKey("SOFTWARE", writable: true);
		Registry.LocalMachine.OpenSubKey("SOFTWARE\\Tunlocker Tool", writable: true);
		if (Registry.LocalMachine.OpenSubKey("SOFTWARE\\Tunlocker Tool\\FileUser", writable: true) == null)
		{
			Registry.LocalMachine.OpenSubKey("SOFTWARE", writable: true).CreateSubKey("Tunlocker Tool");
			Registry.LocalMachine.OpenSubKey("SOFTWARE\\Tunlocker Tool", writable: true).CreateSubKey("FileUser");
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Tunlocker Tool\\FileUser", writable: true);
			registryKey.SetValue("String_Temp", "0");
			registryKey.Close();
		}
		else
		{
			Registry.LocalMachine.OpenSubKey("SOFTWARE", writable: true);
			Registry.LocalMachine.OpenSubKey("SOFTWARE\\Tunlocker Tool", writable: true);
			RegistryKey registryKey2 = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Tunlocker Tool\\FileUser", writable: true);
			registryKey2.SetValue("String_Temp", "0");
			registryKey2.Close();
		}
		object result = default(object);
		return result;
	}

	public static object Login_Register_Read()
	{
		bool @checked = Form1.SharedUI.CheckBox1.Checked;
		bool checked2 = Form1.SharedUI.CheckBox2.Checked;
		string text = Form1.SharedUI.Guna2TextBox3.Text;
		string text2 = Form1.SharedUI.Guna2TextBox4.Text;
		//int num = Integer_Temp_1();
		int num = Integer_Temp_1();
		//string value = String_Temp_1();
		string value = String_Temp_1();
		Registry.LocalMachine.OpenSubKey("SOFTWARE", writable: true);
		Registry.LocalMachine.OpenSubKey("SOFTWARE\\Tunlocker Tool", writable: true);
		if (Registry.LocalMachine.OpenSubKey("SOFTWARE\\Tunlocker Tool\\FileUser", writable: true) == null)
		{
			Registry.LocalMachine.OpenSubKey("SOFTWARE", writable: true).CreateSubKey("Tunlocker Tool");
			Registry.LocalMachine.OpenSubKey("SOFTWARE\\Tunlocker Tool", writable: true).CreateSubKey("FileUser");
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Tunlocker Tool\\FileUser", writable: true);
			registryKey.SetValue("UserName", text);
			registryKey.SetValue("Password", text2);
			registryKey.SetValue("Integer_Temp", num);
			registryKey.SetValue("String_Temp", value);
			registryKey.SetValue("Read_me", @checked);
			registryKey.SetValue("Auto_Login", checked2);
			registryKey.Close();
		}
		else
		{
			Registry.LocalMachine.OpenSubKey("SOFTWARE", writable: true);
			Registry.LocalMachine.OpenSubKey("SOFTWARE\\Tunlocker Tool", writable: true);
			RegistryKey registryKey2 = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Tunlocker Tool\\FileUser", writable: true);
			registryKey2.SetValue("UserName", text);
			registryKey2.SetValue("Password", text2);
			registryKey2.SetValue("Integer_Temp", num);
			registryKey2.SetValue("String_Temp", value);
			registryKey2.SetValue("Read_me", @checked);
			registryKey2.SetValue("Auto_Login", checked2);
			registryKey2.Close();
		}
		object result = default(object);
		return result;
	}

	public static object Login_Register_Read2()
	{
		bool @checked = Form1.SharedUI.CheckBox1.Checked;
		bool checked2 = Form1.SharedUI.CheckBox2.Checked;
		string text = Form1.SharedUI.Guna2TextBox3.Text;
		string text2 = Form1.SharedUI.Guna2TextBox4.Text;
		int num = 0;
		string value = "0";
		Registry.LocalMachine.OpenSubKey("SOFTWARE", writable: true);
		Registry.LocalMachine.OpenSubKey("SOFTWARE\\Tunlocker Tool", writable: true);
		if (Registry.LocalMachine.OpenSubKey("SOFTWARE\\Tunlocker Tool\\FileUser", writable: true) == null)
		{
			Registry.LocalMachine.OpenSubKey("SOFTWARE", writable: true).CreateSubKey("Tunlocker Tool");
			Registry.LocalMachine.OpenSubKey("SOFTWARE\\Tunlocker Tool", writable: true).CreateSubKey("FileUser");
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Tunlocker Tool\\FileUser", writable: true);
			registryKey.SetValue("UserName", text);
			registryKey.SetValue("Password", text2);
			registryKey.SetValue("Integer_Temp", num);
			registryKey.SetValue("String_Temp", value);
			registryKey.SetValue("Read_me", @checked);
			registryKey.SetValue("Auto_Login", checked2);
			registryKey.Close();
		}
		else
		{
			Registry.LocalMachine.OpenSubKey("SOFTWARE", writable: true);
			Registry.LocalMachine.OpenSubKey("SOFTWARE\\Tunlocker Tool", writable: true);
			RegistryKey registryKey2 = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Tunlocker Tool\\FileUser", writable: true);
			registryKey2.SetValue("UserName", text);
			registryKey2.SetValue("Password", text2);
			registryKey2.SetValue("Integer_Temp", num);
			registryKey2.SetValue("String_Temp", value);
			registryKey2.SetValue("Read_me", @checked);
			registryKey2.SetValue("Auto_Login", checked2);
			registryKey2.Close();
		}
		object result = default(object);
		return result;
	}

	public static object UserName_Password()
	{
		bool @checked = Form1.SharedUI.CheckBox1.Checked;
		bool checked2 = Form1.SharedUI.CheckBox2.Checked;
		string text = Form1.SharedUI.Guna2TextBox3.Text;
		string text2 = Form1.SharedUI.Guna2TextBox4.Text;
		Registry.LocalMachine.OpenSubKey("SOFTWARE", writable: true);
		Registry.LocalMachine.OpenSubKey("SOFTWARE\\Tunlocker Tool", writable: true);
		if (Registry.LocalMachine.OpenSubKey("SOFTWARE\\Tunlocker Tool\\FileUser", writable: true) == null)
		{
			Registry.LocalMachine.OpenSubKey("SOFTWARE", writable: true).CreateSubKey("Tunlocker Tool");
			Registry.LocalMachine.OpenSubKey("SOFTWARE\\Tunlocker Tool", writable: true).CreateSubKey("FileUser");
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Tunlocker Tool\\FileUser", writable: true);
			registryKey.SetValue("UserName", text);
			registryKey.SetValue("Password", text2);
			registryKey.SetValue("Read_me", @checked);
			registryKey.SetValue("Auto_Login", checked2);
			registryKey.Close();
		}
		else
		{
			Registry.LocalMachine.OpenSubKey("SOFTWARE", writable: true);
			Registry.LocalMachine.OpenSubKey("SOFTWARE\\Tunlocker Tool", writable: true);
			RegistryKey registryKey2 = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Tunlocker Tool\\FileUser", writable: true);
			registryKey2.SetValue("UserName", text);
			registryKey2.SetValue("Password", text2);
			registryKey2.SetValue("Read_me", @checked);
			registryKey2.SetValue("Auto_Login", checked2);
			registryKey2.Close();
		}
		object result = default(object);
		return result;
	}

	public static string UserName_1()
	{
		string result;
		try
		{
			result = Conversions.ToString(Registry.LocalMachine.OpenSubKey("SOFTWARE\\Tunlocker Tool\\FileUser", writable: true).GetValue("UserName"));
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			result = "";
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public static string Password_1()
	{
		string result;
		try
		{
			result = Conversions.ToString(Registry.LocalMachine.OpenSubKey("SOFTWARE\\Tunlocker Tool\\FileUser", writable: true).GetValue("Password"));
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			result = "";
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public static string String_Temp_1()
	{
		string result = "100";
		try
		{
			//result = Conversions.ToString(Registry.LocalMachine.OpenSubKey("SOFTWARE\\Tunlocker Tool\\FileUser", writable: true).GetValue("String_Temp"));
		}
		catch (Exception ex)
		{
		//	ProjectData.SetProjectError(ex);
		//	Exception ex2 = ex;
		//	result = "0";
			//ProjectData.ClearProjectError();
		}
		return result;
	}

	public static int Integer_Temp_1()
	{
		int result = 100;
		try
		{
		//	result = Conversions.ToInteger(Registry.LocalMachine.OpenSubKey("SOFTWARE\\Tunlocker Tool\\FileUser", writable: true).GetValue("Integer_Temp"));
		}
		catch (Exception ex)
		{
		//	ProjectData.SetProjectError(ex);
		//	Exception ex2 = ex;
		//	result = 0;
			//ProjectData.ClearProjectError();
		}
		return result;
	}

	public static bool Read_me_1()
	{
		bool result;
		try
		{
			result = Conversions.ToBoolean(Registry.LocalMachine.OpenSubKey("SOFTWARE\\Tunlocker Tool\\FileUser", writable: true).GetValue("Read_me"));
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			result = false;
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public static bool Auto_Login_1()
	{
		bool result;
		try
		{
			result = Conversions.ToBoolean(Registry.LocalMachine.OpenSubKey("SOFTWARE\\Tunlocker Tool\\FileUser", writable: true).GetValue("Auto_Login"));
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			result = false;
			ProjectData.ClearProjectError();
		}
		return result;
	}
}
