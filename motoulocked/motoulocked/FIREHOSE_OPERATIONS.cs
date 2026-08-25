using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.FileIO;
using motoulocked.My;
using Properties;

namespace motoulocked.motoulocked;

[StandardModule]
internal sealed class FIREHOSE_OPERATIONS
{
	public enum MenuEksekusi
	{
		manual = 101,
		oneclick
	}

	public enum MenuManual
	{
		readgpt_flash,
		readgpt_read,
		readgpt_readinfo,
		readgpt_erase,
		readgpt_erase_patch,
		readgpt_clean_mi,
		readgpt_patch_mi,
		ident,
		flash,
		read,
		erase,
		patch,
		reboot,
		readgpt_erase_id,
		readgpt_erase_user,
		readgpt_patch_kg
	}

	public static string Hexx;

	public static string states_lock;

	public static string Stringg;

	public static string serialNumber;

	public static string Hex_New;

	public static string StringXmlNEW;

	public static MenuEksekusi MenuEx { get; set; } = default(MenuEksekusi);


	public static MenuManual MenuMan { get; set; } = default(MenuManual);


	public static void Prepare_Oneclick()
	{
		if (MenuEx != MenuEksekusi.oneclick)
		{
			return;
		}
		XmlTextReader xmlTextReader = new XmlTextReader(new StringReader(FIREHOSE_MANAGER.StringXml));
		while (true)
		{
			if (xmlTextReader.Read())
			{
				if (Operators.CompareString(EDL.cancel, "Cancel", TextCompare: false) == 0)
				{
					break;
				}
				if ((xmlTextReader.NodeType != XmlNodeType.Element || Operators.CompareString(xmlTextReader.Name.ToLower(), "program", TextCompare: false) != 0) && Operators.CompareString(xmlTextReader.Name.ToLower(), "erase", TextCompare: false) != 0 && Operators.CompareString(xmlTextReader.Name.ToLower(), "patch", TextCompare: false) != 0)
				{
					continue;
				}
				FIREHOSE_MANAGER.SECTOR_SIZE_IN_BYTES = xmlTextReader.GetAttribute("SECTOR_SIZE_IN_BYTES");
			}
			if (Operators.CompareString(FIREHOSE_MANAGER.SECTOR_SIZE_IN_BYTES, "512", TextCompare: false) == 0)
			{
				FIREHOSE_MANAGER.TypeMemory = "emmc";
				UiManager.ComboTypeMemory();
			}
			else if (Operators.CompareString(FIREHOSE_MANAGER.SECTOR_SIZE_IN_BYTES, "4096", TextCompare: false) == 0)
			{
				FIREHOSE_MANAGER.TypeMemory = "ufs";
				UiManager.ComboTypeMemory();
			}
			else
			{
				UiManager.Richlogs("Failed Get Sector Size From Data", Color.Red, isBold: true, NextLine: true);
			}
			break;
		}
	}

	public static void MethodD_144(string Commands)
	{
		Process process = new Process();
		process.StartInfo.FileName = Application.StartupPath + "\\bin\\Tunlocker Tool.exe";
		process.StartInfo.Arguments = "/c " + Commands;
		process.StartInfo.CreateNoWindow = true;
		process.StartInfo.UseShellExecute = false;
		process.StartInfo.RedirectStandardOutput = true;
		process.StartInfo.RedirectStandardError = true;
		process.Start();
		process.WaitForExit();
	}

	public static void Prepare_Manual()
	{
		try
		{
			if (!FIREHOSE_MANAGER.isFirehoseReady || MenuEx != MenuEksekusi.manual || (MenuMan != 0 && MenuMan != MenuManual.readgpt_erase_user && MenuMan != MenuManual.readgpt_erase_id && MenuMan != MenuManual.readgpt_erase && MenuMan != MenuManual.readgpt_erase_patch && MenuMan != MenuManual.readgpt_read && MenuMan != MenuManual.readgpt_readinfo && MenuMan != MenuManual.readgpt_clean_mi && MenuMan != MenuManual.readgpt_patch_kg && MenuMan != MenuManual.readgpt_patch_mi))
			{
				return;
			}
			if (Form1.SharedUI.CkReadAndroidInfo.Checked)
			{
				try
				{
					MyProject.Computer.FileSystem.DeleteDirectory(sourcefile.Directoryfile, DeleteDirectoryOption.DeleteAllContents);
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ProjectData.ClearProjectError();
				}
				try
				{
					MyProject.Computer.FileSystem.DeleteDirectory(sourcefile.Directoryfile, DeleteDirectoryOption.DeleteAllContents);
				}
				catch (Exception ex3)
				{
					ProjectData.SetProjectError(ex3);
					Exception ex4 = ex3;
					ProjectData.ClearProjectError();
				}
				try
				{
					MyProject.Computer.FileSystem.DeleteDirectory(sourcefile.Directoryfile, DeleteDirectoryOption.DeleteAllContents);
				}
				catch (Exception ex5)
				{
					ProjectData.SetProjectError(ex5);
					Exception ex6 = ex5;
					ProjectData.ClearProjectError();
				}
				try
				{
					MyProject.Computer.FileSystem.DeleteDirectory(sourcefile.Directoryfile, DeleteDirectoryOption.DeleteAllContents);
				}
				catch (Exception ex7)
				{
					ProjectData.SetProjectError(ex7);
					Exception ex8 = ex7;
					ProjectData.ClearProjectError();
				}
				string text = "tmp\\temp";
				try
				{
					File.Delete(text + ".zip");
				}
				catch (Exception ex9)
				{
					ProjectData.SetProjectError(ex9);
					Exception ex10 = ex9;
					ProjectData.ClearProjectError();
				}
				File.WriteAllBytes(text + ".zip", Resources.unpack);
				MethodD_144("bin\\7z.exe x " + text + ".zip -p773989 -o" + text);
				try
				{
					File.Delete(text + ".zip");
				}
				catch (Exception ex11)
				{
					ProjectData.SetProjectError(ex11);
					Exception ex12 = ex11;
					ProjectData.ClearProjectError();
				}
			}
			FIREHOSE_GPT.Clear_GPT();
			FIREHOSE_MANAGER.isShowListGPT = false;
			if (FIREHOSE_GPT.GPT_Reader())
			{
				if (MenuMan == MenuManual.readgpt_flash)
				{
					MenuMan = MenuManual.flash;
					string foldersave = FIREHOSE_MANAGER.foldersave;
					FIREHOSE_MANAGER.foldersave = Path.GetDirectoryName(sourcefile.Dumped);
					string partition_Name = FIREHOSE_MANAGER.Partition_Name;
					if (Form1.SharedUI.CkReadAndroidInfo.Checked)
					{
						FIREHOSE_MANAGER.Partition_Name = "readinfo";
						FIREHOSE_GPT.Create_XML_ReadPartition();
						if (!FIREHOSE_DEVICEINFO.Read_Device_Info("boot"))
						{
							FIREHOSE_MANAGER.Partition_Name = "readinfo2";
							FIREHOSE_GPT.Create_XML_ReadPartition();
							if (!FIREHOSE_DEVICEINFO.Read_Device_Info("recovery"))
							{
								UiManager.Richlogs("OK", Color.Lime, isBold: true, NextLine: true);
							}
						}
					}
					else
					{
						UiManager.Richlogs("OK", Color.Lime, isBold: true, NextLine: true);
					}
					FIREHOSE_MANAGER.Partition_Name = partition_Name;
					FIREHOSE_MANAGER.foldersave = foldersave;
					FIREHOSE_GPT.Create_XML_FlashPart();
				}
				if (MenuMan == MenuManual.readgpt_erase)
				{
					string foldersave2 = FIREHOSE_MANAGER.foldersave;
					FIREHOSE_MANAGER.foldersave = Path.GetDirectoryName(sourcefile.Dumped);
					string partition_Name2 = FIREHOSE_MANAGER.Partition_Name;
					if (Form1.SharedUI.CkReadAndroidInfo.Checked)
					{
						FIREHOSE_MANAGER.Partition_Name = "readinfo";
						FIREHOSE_GPT.Create_XML_ReadPartition();
						if (!FIREHOSE_DEVICEINFO.Read_Device_Info("boot"))
						{
							FIREHOSE_MANAGER.Partition_Name = "readinfo2";
							FIREHOSE_GPT.Create_XML_ReadPartition();
							if (!FIREHOSE_DEVICEINFO.Read_Device_Info("recovery"))
							{
								UiManager.Richlogs("OK", Color.Lime, isBold: true, NextLine: true);
							}
						}
					}
					else
					{
						UiManager.Richlogs("OK", Color.Lime, isBold: true, NextLine: true);
					}
					FIREHOSE_MANAGER.Partition_Name = partition_Name2;
					FIREHOSE_MANAGER.foldersave = foldersave2;
					FIREHOSE_GPT.Create_XML_ErasePart();
					if (Operators.CompareString(FIREHOSE_MANAGER.Partition_Name, "frp", TextCompare: false) == 0 && !FIREHOSE_GPT.Check_Partition_FRP())
					{
						UiManager.Richlogs("FRP Partition not found!", Color.Red, isBold: false, NextLine: true);
						FIREHOSE_MANAGER.StringXml = "";
						FIREHOSE_MANAGER.StringXml += "<?xml version=\"1.0\" ?>\r\n";
						FIREHOSE_MANAGER.StringXml += "<data>\r\n";
						FIREHOSE_MANAGER.StringXml += "</data>";
					}
					else
					{
						Process_Erase();
						Process_Reboot();
						FIREHOSE_MANAGER.StringXml = "";
						FIREHOSE_MANAGER.StringXml += "<?xml version=\"1.0\" ?>\r\n";
						FIREHOSE_MANAGER.StringXml += "<data>\r\n";
						FIREHOSE_MANAGER.StringXml += "</data>";
					}
				}
				else if (MenuMan == MenuManual.readgpt_read)
				{
					string foldersave3 = FIREHOSE_MANAGER.foldersave;
					FIREHOSE_MANAGER.foldersave = Path.GetDirectoryName(sourcefile.Dumped);
					string partition_Name3 = FIREHOSE_MANAGER.Partition_Name;
					if (Form1.SharedUI.CkReadAndroidInfo.Checked)
					{
						FIREHOSE_MANAGER.Partition_Name = "readinfo";
						FIREHOSE_GPT.Create_XML_ReadPartition();
						if (!FIREHOSE_DEVICEINFO.Read_Device_Info("boot"))
						{
							FIREHOSE_MANAGER.Partition_Name = "readinfo2";
							FIREHOSE_GPT.Create_XML_ReadPartition();
							if (!FIREHOSE_DEVICEINFO.Read_Device_Info("recovery"))
							{
								UiManager.Richlogs("OK", Color.Lime, isBold: true, NextLine: true);
							}
						}
					}
					else
					{
						UiManager.Richlogs("OK", Color.Lime, isBold: true, NextLine: true);
					}
					FIREHOSE_MANAGER.Partition_Name = partition_Name3;
					FIREHOSE_MANAGER.foldersave = foldersave3;
					FIREHOSE_GPT.Create_XML_ReadPartition();
					Process_Read();
					Process_Reboot();
					FIREHOSE_MANAGER.StringXml = "";
					FIREHOSE_MANAGER.StringXml += "<?xml version=\"1.0\" ?>\r\n";
					FIREHOSE_MANAGER.StringXml += "<data>\r\n";
					FIREHOSE_MANAGER.StringXml += "</data>";
				}
				else if (MenuMan == MenuManual.readgpt_erase_patch)
				{
					string foldersave4 = FIREHOSE_MANAGER.foldersave;
					FIREHOSE_MANAGER.foldersave = Path.GetDirectoryName(sourcefile.Dumped);
					string partition_Name4 = FIREHOSE_MANAGER.Partition_Name;
					if (Form1.SharedUI.CkReadAndroidInfo.Checked)
					{
						FIREHOSE_MANAGER.Partition_Name = "readinfo";
						FIREHOSE_GPT.Create_XML_ReadPartition();
						if (!FIREHOSE_DEVICEINFO.Read_Device_Info("boot"))
						{
							FIREHOSE_MANAGER.Partition_Name = "readinfo2";
							FIREHOSE_GPT.Create_XML_ReadPartition();
							if (!FIREHOSE_DEVICEINFO.Read_Device_Info("recovery"))
							{
								UiManager.Richlogs("OK", Color.Lime, isBold: true, NextLine: true);
							}
						}
					}
					else
					{
						UiManager.Richlogs("OK", Color.Lime, isBold: true, NextLine: true);
					}
					FIREHOSE_MANAGER.Partition_Name = partition_Name4;
					FIREHOSE_MANAGER.foldersave = foldersave4;
					FIREHOSE_GPT.Create_XML_ErasePart();
					if (Operators.CompareString(FIREHOSE_MANAGER.Partition_Name, "frp", TextCompare: false) == 0 && !FIREHOSE_GPT.Check_Partition_FRP())
					{
						UiManager.Richlogs("FRP Partition not found!", Color.Red, isBold: false, NextLine: true);
						FIREHOSE_MANAGER.StringXml = "";
						FIREHOSE_MANAGER.StringXml += "<?xml version=\"1.0\" ?>\r\n";
						FIREHOSE_MANAGER.StringXml += "<data>\r\n";
						FIREHOSE_MANAGER.StringXml += "</data>";
					}
					else
					{
						Process_Erase_Patch();
						Process_Reboot();
						FIREHOSE_MANAGER.StringXml = "";
						FIREHOSE_MANAGER.StringXml += "<?xml version=\"1.0\" ?>\r\n";
						FIREHOSE_MANAGER.StringXml += "<data>\r\n";
						FIREHOSE_MANAGER.StringXml += "</data>";
					}
				}
				else if (MenuMan == MenuManual.readgpt_erase_user)
				{
					string foldersave5 = FIREHOSE_MANAGER.foldersave;
					FIREHOSE_MANAGER.foldersave = Path.GetDirectoryName(sourcefile.Dumped);
					string partition_Name5 = FIREHOSE_MANAGER.Partition_Name;
					if (Form1.SharedUI.CkReadAndroidInfo.Checked)
					{
						FIREHOSE_MANAGER.Partition_Name = "readinfo";
						FIREHOSE_GPT.Create_XML_ReadPartition();
						if (!FIREHOSE_DEVICEINFO.Read_Device_Info("boot"))
						{
							FIREHOSE_MANAGER.Partition_Name = "readinfo2";
							FIREHOSE_GPT.Create_XML_ReadPartition();
							if (!FIREHOSE_DEVICEINFO.Read_Device_Info("recovery"))
							{
								UiManager.Richlogs("OK", Color.Lime, isBold: true, NextLine: true);
							}
						}
					}
					else
					{
						UiManager.Richlogs("OK", Color.Lime, isBold: true, NextLine: true);
					}
					UiManager.Richlogs("- Checking Filesystem : ", Color.Black, isBold: false);
					Form1.SharedUI.ProgressBar1.Text = "Checking...";
					FIREHOSE_MANAGER.Partition_Name = partition_Name5;
					FIREHOSE_MANAGER.foldersave = foldersave5;
					string path = Application.StartupPath + "\\tmp\\0.bin";
					try
					{
						File.Delete(path);
					}
					catch (Exception ex13)
					{
						ProjectData.SetProjectError(ex13);
						Exception ex14 = ex13;
						ProjectData.ClearProjectError();
					}
					if (Operators.CompareString(FIREHOSE_MANAGER.TypeMemory, "emmc", TextCompare: false) == 0)
					{
						File.WriteAllBytes(path, Resources.misc_emmc);
					}
					else
					{
						File.WriteAllBytes(path, Resources.misc_ufs);
					}
					FIREHOSE_GPT.Create_XML_FlashPart();
					if (!Process_Wipe_Userdata())
					{
						UiManager.Richlogs("Failed", Color.Red);
						return;
					}
					if (File.Exists(path))
					{
						File.Delete(path);
					}
					FIREHOSE_MANAGER.Partition_Name = "frp";
					FIREHOSE_MANAGER.StringXml = "";
					FIREHOSE_GPT.Create_XML_ErasePart();
					if (Operators.CompareString(FIREHOSE_MANAGER.Partition_Name, "frp", TextCompare: false) == 0 && !FIREHOSE_GPT.Check_Partition_FRP())
					{
						UiManager.Richlogs("FRP Partition not found!", Color.Red, isBold: false, NextLine: true);
						FIREHOSE_MANAGER.StringXml = "";
						FIREHOSE_MANAGER.StringXml += "<?xml version=\"1.0\" ?>\r\n";
						FIREHOSE_MANAGER.StringXml += "<data>\r\n";
						FIREHOSE_MANAGER.StringXml += "</data>";
					}
					else
					{
						UiManager.Richlogs("OK", Color.Lime, isBold: true, NextLine: true);
						Process_Erase_Patch();
						Process_Reboot();
						FIREHOSE_MANAGER.StringXml = "";
						FIREHOSE_MANAGER.StringXml += "<?xml version=\"1.0\" ?>\r\n";
						FIREHOSE_MANAGER.StringXml += "<data>\r\n";
						FIREHOSE_MANAGER.StringXml += "</data>";
					}
				}
				else if (MenuMan == MenuManual.readgpt_clean_mi)
				{
					MenuMan = MenuManual.flash;
					string foldersave6 = FIREHOSE_MANAGER.foldersave;
					FIREHOSE_MANAGER.foldersave = Path.GetDirectoryName(sourcefile.Dumped);
					string partition_Name6 = FIREHOSE_MANAGER.Partition_Name;
					if (Form1.SharedUI.CkReadAndroidInfo.Checked)
					{
						FIREHOSE_MANAGER.Partition_Name = "readinfo";
						FIREHOSE_GPT.Create_XML_ReadPartition();
						if (!FIREHOSE_DEVICEINFO.Read_Device_Info("boot"))
						{
							FIREHOSE_MANAGER.Partition_Name = "readinfo2";
							FIREHOSE_GPT.Create_XML_ReadPartition();
							if (!FIREHOSE_DEVICEINFO.Read_Device_Info("recovery"))
							{
								UiManager.Richlogs("OK", Color.Lime, isBold: true, NextLine: true);
							}
						}
					}
					else
					{
						UiManager.Richlogs("OK", Color.Lime, isBold: true, NextLine: true);
					}
					FIREHOSE_MANAGER.Partition_Name = partition_Name6;
					FIREHOSE_MANAGER.foldersave = foldersave6;
					FIREHOSE_GPT.Create_XML_ReadPartition();
					Process_Mi();
					Process_Reboot();
					FIREHOSE_MANAGER.StringXml = "";
					FIREHOSE_MANAGER.StringXml += "<?xml version=\"1.0\" ?>\r\n";
					FIREHOSE_MANAGER.StringXml += "<data>\r\n";
					FIREHOSE_MANAGER.StringXml += "</data>";
				}
				else if (MenuMan == MenuManual.readgpt_patch_mi)
				{
					MenuMan = MenuManual.flash;
					string foldersave7 = FIREHOSE_MANAGER.foldersave;
					FIREHOSE_MANAGER.foldersave = Path.GetDirectoryName(sourcefile.Dumped);
					string partition_Name7 = FIREHOSE_MANAGER.Partition_Name;
					if (Form1.SharedUI.CkReadAndroidInfo.Checked)
					{
						FIREHOSE_MANAGER.Partition_Name = "readinfo";
						FIREHOSE_GPT.Create_XML_ReadPartition();
						if (!FIREHOSE_DEVICEINFO.Read_Device_Info("boot"))
						{
							FIREHOSE_MANAGER.Partition_Name = "readinfo2";
							FIREHOSE_GPT.Create_XML_ReadPartition();
							if (!FIREHOSE_DEVICEINFO.Read_Device_Info("recovery"))
							{
								UiManager.Richlogs("OK", Color.Lime, isBold: true, NextLine: true);
							}
						}
					}
					else
					{
						UiManager.Richlogs("OK", Color.Lime, isBold: true, NextLine: true);
					}
					FIREHOSE_MANAGER.Partition_Name = partition_Name7;
					FIREHOSE_MANAGER.foldersave = foldersave7;
					FIREHOSE_GPT.Create_XML_ReadPartition();
					Process_Mi();
					Process_Reboot();
					FIREHOSE_MANAGER.StringXml = "";
					FIREHOSE_MANAGER.StringXml += "<?xml version=\"1.0\" ?>\r\n";
					FIREHOSE_MANAGER.StringXml += "<data>\r\n";
					FIREHOSE_MANAGER.StringXml += "</data>";
				}
				else
				{
					if (MenuMan != MenuManual.readgpt_patch_kg)
					{
						return;
					}
					FIREHOSE_MANAGER.foldersave = Path.GetDirectoryName(sourcefile.Dumped);
					if (Form1.SharedUI.CkReadAndroidInfo.Checked)
					{
						FIREHOSE_MANAGER.Partition_Name = "readinfo";
						FIREHOSE_GPT.Create_XML_ReadPartition();
						if (!FIREHOSE_DEVICEINFO.Read_Device_Info("boot"))
						{
							FIREHOSE_MANAGER.Partition_Name = "readinfo2";
							FIREHOSE_GPT.Create_XML_ReadPartition();
							if (!FIREHOSE_DEVICEINFO.Read_Device_Info("recovery"))
							{
								UiManager.Richlogs("OK", Color.Lime, isBold: true, NextLine: true);
							}
						}
					}
					else
					{
						UiManager.Richlogs("OK", Color.Lime, isBold: true, NextLine: true);
					}
					FIREHOSE_MANAGER.Partition_Name = "clean_kg";
					FIREHOSE_MANAGER.StringXml = "";
					FIREHOSE_GPT.Create_XML_ReadPartition();
					if (!FIREHOSE_DEVICEINFO.Read_Knox_Data("sec_efs"))
					{
						UiManager.Richlogs("Failed", Color.Red);
						return;
					}
					string text2 = Application.StartupPath + "\\tmp\\sec_efs.bin";
					if (File.Exists(text2))
					{
						UiManager.Richlogs("OK", Color.Lime, isBold: true, NextLine: true);
						UiManager.Richlogs("- Calculate Target Data : ", Color.Black, isBold: false);
						Form1.SharedUI.ProgressBar1.Text = "Calculating...";
						states_lock = Calculating_KG(text2);
						if (Operators.CompareString(states_lock, "unlock", TextCompare: false) == 0)
						{
							FIREHOSE_GPT.Create_XML_FlashPart();
							if (!write_Knox_Data())
							{
								UiManager.Richlogs("Failed", Color.Red);
								return;
							}
							if (File.Exists(text2))
							{
								File.Delete(text2);
							}
							UiManager.Richlogs("OK", Color.Lime, isBold: true, NextLine: true);
							UiManager.Richlogs("- Verfing KG/Knox States : ", Color.Black, isBold: false);
							Form1.SharedUI.ProgressBar1.Text = "Verfing...";
							UiManager.Richlogs("Unlocked", Color.Lime, isBold: true, NextLine: true);
							Process_Reboot();
						}
						else
						{
							try
							{
								File.Delete(text2);
							}
							catch (Exception ex15)
							{
								ProjectData.SetProjectError(ex15);
								Exception ex16 = ex15;
								ProjectData.ClearProjectError();
							}
							if (Operators.CompareString(states_lock, "done", TextCompare: false) == 0)
							{
								UiManager.Richlogs("OK", Color.Lime, isBold: true, NextLine: true);
								UiManager.Richlogs("- Writing Data To Target : ", Color.Black, isBold: false);
								Form1.SharedUI.ProgressBar1.Text = "Writing...";
								UiManager.Richlogs("OK", Color.Lime, isBold: true, NextLine: true);
								UiManager.Richlogs("- Remove KG/Knox Data Lock : ", Color.Black, isBold: false);
								Form1.SharedUI.ProgressBar1.Text = "Removing...";
								UiManager.Richlogs("OK", Color.Lime, isBold: true, NextLine: true);
								UiManager.Richlogs("- Verfing KG/Knox States : ", Color.Black, isBold: false);
								Form1.SharedUI.ProgressBar1.Text = "Verfing...";
								UiManager.Richlogs("Unlocked", Color.Lime, isBold: true, NextLine: true);
								Process_Reboot();
							}
							else
							{
								UiManager.Richlogs("Failed", Color.Red, isBold: true, NextLine: true);
								UiManager.Richlogs("- Verfing KG/Knox States : ", Color.Black, isBold: false);
								Form1.SharedUI.ProgressBar1.Text = "Verfing...";
								UiManager.Richlogs("Locked", Color.Red, isBold: true, NextLine: true);
								Process_Reboot();
							}
						}
					}
					FIREHOSE_MANAGER.StringXml = "";
					FIREHOSE_MANAGER.StringXml += "<?xml version=\"1.0\" ?>\r\n";
					FIREHOSE_MANAGER.StringXml += "<data>\r\n";
					FIREHOSE_MANAGER.StringXml += "</data>";
				}
			}
			else
			{
				UiManager.Richlogs("Partition Not Found!", Color.Red, isBold: false);
				FIREHOSE_MANAGER.StringXml = "";
				FIREHOSE_MANAGER.StringXml += "<?xml version=\"1.0\" ?>\r\n";
				FIREHOSE_MANAGER.StringXml += "<data>\r\n";
				FIREHOSE_MANAGER.StringXml += "</data>";
			}
		}
		catch (Exception ex17)
		{
			ProjectData.SetProjectError(ex17);
			Exception ex18 = ex17;
			ProjectData.ClearProjectError();
		}
	}

	public static bool Process_kg_new()
	{
		string text = Application.StartupPath + "\\tmp\\SEC1";
		string text2 = Application.StartupPath + "\\tmp\\Data";
		if (File.Exists(text))
		{
			UiManager.Richlogs("OK", Color.Lime, isBold: true, NextLine: true);
			UiManager.Richlogs("- Calculate Target Data : ", Color.Black, isBold: false);
			Form1.SharedUI.ProgressBar1.Text = "Calculating...";
			states_lock = Calculating_KG(text);
			if (Operators.CompareString(states_lock, "lock", TextCompare: false) == 0)
			{
				try
				{
					File.Delete(text);
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ProjectData.ClearProjectError();
				}
				UiManager.Richlogs("OK", Color.Lime, isBold: true, NextLine: true);
				UiManager.Richlogs("- Writing Data To Target : ", Color.Black, isBold: false);
				Form1.SharedUI.ProgressBar1.Text = "Writing...";
				Write(text2);
				UiManager.Richlogs("OK", Color.Lime, isBold: true, NextLine: true);
				Form1.SharedUI.ProgressBar1.Text = "Removing...";
				if (!write_Knox_Data())
				{
					UiManager.Richlogs("Failed", Color.Red);
					return false;
				}
				UiManager.Richlogs("OK", Color.Lime, isBold: true, NextLine: true);
				if (File.Exists(text2))
				{
					File.Delete(text2);
				}
			}
			else
			{
				try
				{
					File.Delete(text);
				}
				catch (Exception ex3)
				{
					ProjectData.SetProjectError(ex3);
					Exception ex4 = ex3;
					ProjectData.ClearProjectError();
				}
				if (Operators.CompareString(states_lock, "unlock", TextCompare: false) == 0)
				{
					UiManager.Richlogs("OK", Color.Lime, isBold: true, NextLine: true);
					UiManager.Richlogs("- Writing Data To Target : ", Color.Black, isBold: false);
					Form1.SharedUI.ProgressBar1.Text = "Writing...";
					UiManager.Richlogs("OK", Color.Lime, isBold: true, NextLine: true);
					UiManager.Richlogs("- Remove KG/Knox Data Lock : ", Color.Black, isBold: false);
					Form1.SharedUI.ProgressBar1.Text = "Removing...";
					UiManager.Richlogs("OK", Color.Lime, isBold: true, NextLine: true);
					UiManager.Richlogs("- KG/Knox States : ", Color.Black, isBold: false);
					Form1.SharedUI.ProgressBar1.Text = "Verfing...";
					UiManager.Richlogs("Unlocked", Color.Lime, isBold: true, NextLine: true);
				}
				else
				{
					UiManager.Richlogs("Failed", Color.Red, isBold: true, NextLine: true);
					UiManager.Richlogs("- KG/Knox States : ", Color.Black, isBold: false);
					Form1.SharedUI.ProgressBar1.Text = "Verfing...";
					UiManager.Richlogs("Locked", Color.Red, isBold: true, NextLine: true);
				}
			}
		}
		else
		{
			Form1.SharedUI.ProgressBar4.Value = 100;
			Form1.SharedUI.ProgressBar4.Text = "";
			Form1.SharedUI.ProgressBar4.Value = 0;
			SerialCOM.MSL = "DISREAD";
			UiManager.Richlogs("Failed", Color.Red);
		}
		return true;
	}

	public static bool write_Knox_Data()
	{
		if (!string.IsNullOrEmpty(FIREHOSE_MANAGER.StringXml))
		{
			XmlTextReader xmlTextReader = new XmlTextReader(new StringReader(FIREHOSE_MANAGER.StringXml));
			SerialCOM.MSL = "ENREAD";
			UiManager.ProcessBar2(0L, 100L);
			while (true)
			{
				if (xmlTextReader.Read())
				{
					if (Operators.CompareString(EDL.cancel, "Cancel", TextCompare: false) == 0)
					{
						break;
					}
					if (xmlTextReader.NodeType == XmlNodeType.Element && Operators.CompareString(xmlTextReader.Name, "program", TextCompare: false) == 0)
					{
						FIREHOSE_MANAGER.SECTOR_SIZE_IN_BYTES = xmlTextReader.GetAttribute("SECTOR_SIZE_IN_BYTES");
						string attribute = xmlTextReader.GetAttribute("num_partition_sectors");
						string label = xmlTextReader.GetAttribute("label");
						xmlTextReader.GetAttribute("filename");
						string filename = Application.StartupPath + "\\tmp\\sec_efs.bin";
						string attribute2 = xmlTextReader.GetAttribute("physical_partition_number");
						string attribute3 = xmlTextReader.GetAttribute("start_sector");
						if (!FIREHOSE_PARTITIONS.Write_kg_data(FIREHOSE_MANAGER.SECTOR_SIZE_IN_BYTES, attribute, attribute2, attribute3, ref label, filename))
						{
							return false;
						}
					}
					continue;
				}
				UiManager.ProcessBar2(0L, 100L);
				SerialCOM.MSL = "DISREAD";
				return true;
			}
		}
		bool result = default(bool);
		return result;
	}

	public static bool Process_kg()
	{
		string text = Application.StartupPath + "\\tmp\\sec_efs.bin";
		string text2 = Application.StartupPath + "\\tmp\\data";
		if (File.Exists(text))
		{
			FIREHOSE_MANAGER.StringXml = StringXmlNEW;
			UiManager.Richlogs("- Calculate Target Data : ", Color.Black, isBold: false);
			Form1.SharedUI.ProgressBar1.Text = "Calculating...";
			states_lock = Calculating_KG(text);
			if (Operators.CompareString(states_lock, "lock", TextCompare: false) == 0)
			{
				try
				{
					File.Delete(text);
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ProjectData.ClearProjectError();
				}
				UiManager.Richlogs("OK", Color.Lime, isBold: true, NextLine: true);
				UiManager.Richlogs("- Writing Data To Target : ", Color.Black, isBold: false);
				Form1.SharedUI.ProgressBar1.Text = "Writing...";
				Write(text2);
				UiManager.Richlogs("OK", Color.Lime, isBold: true, NextLine: true);
				Form1.SharedUI.ProgressBar1.Text = "Removing...";
				if (!write_Knox_Data())
				{
					UiManager.Richlogs("Failed", Color.Red);
					return false;
				}
				UiManager.Richlogs("OK", Color.Lime, isBold: true, NextLine: true);
				if (File.Exists(text2))
				{
					File.Delete(text2);
				}
			}
			else
			{
				try
				{
					File.Delete(text + "SEC1");
				}
				catch (Exception ex3)
				{
					ProjectData.SetProjectError(ex3);
					Exception ex4 = ex3;
					ProjectData.ClearProjectError();
				}
				if (Operators.CompareString(states_lock, "unlock", TextCompare: false) == 0)
				{
					UiManager.Richlogs("OK", Color.Lime, isBold: true, NextLine: true);
					UiManager.Richlogs("- Writing Data To Target : ", Color.Black, isBold: false);
					Form1.SharedUI.ProgressBar1.Text = "Writing...";
					UiManager.Richlogs("OK", Color.Lime, isBold: true, NextLine: true);
					UiManager.Richlogs("- Remove KG/Knox Data Lock : ", Color.Black, isBold: false);
					Form1.SharedUI.ProgressBar1.Text = "Removing...";
					UiManager.Richlogs("OK", Color.Lime, isBold: true, NextLine: true);
					UiManager.Richlogs("- KG/Knox States : ", Color.Black, isBold: false);
					Form1.SharedUI.ProgressBar1.Text = "Verfing...";
					UiManager.Richlogs("Unlocked", Color.Lime, isBold: true, NextLine: true);
				}
				else
				{
					UiManager.Richlogs("Failed", Color.Red, isBold: true, NextLine: true);
					UiManager.Richlogs("- KG/Knox States : ", Color.Black, isBold: false);
					Form1.SharedUI.ProgressBar1.Text = "Verfing...";
					UiManager.Richlogs("Locked", Color.Red, isBold: true, NextLine: true);
				}
			}
		}
		else
		{
			Form1.SharedUI.ProgressBar4.Value = 100;
			Form1.SharedUI.ProgressBar4.Text = "";
			Form1.SharedUI.ProgressBar4.Value = 0;
			SerialCOM.MSL = "DISREAD";
			UiManager.Richlogs("Failed", Color.Red);
		}
		return true;
	}

	public static bool Process_Identify()
	{
		FIREHOSE_MANAGER.isShowListGPT = true;
		UiManager.DGVClear();
		FIREHOSE_GPT.Clear_GPT();
		if (!FIREHOSE_GPT.GPT_Reader())
		{
			return false;
		}
		EDL.SharedEDL.Guna2RadioButton6.Invoke((Action)([SpecialName] () =>
		{
			EDL.SharedEDL.Guna2RadioButton6.Enabled = true;
		}));
		EDL.SharedEDL.buttonerase.Invoke((Action)([SpecialName] () =>
		{
			EDL.SharedEDL.buttonerase.Enabled = true;
		}));
		EDL.SharedEDL.Guna2RadioButton7.Invoke((Action)([SpecialName] () =>
		{
			EDL.SharedEDL.Guna2RadioButton7.Enabled = true;
		}));
		EDL.SharedEDL.Guna2RadioButton8.Invoke((Action)([SpecialName] () =>
		{
			EDL.SharedEDL.Guna2RadioButton8.Enabled = true;
		}));
		EDL.SharedEDL.BtnIdentify.Invoke((Action)([SpecialName] () =>
		{
			EDL.SharedEDL.BtnIdentify.Enabled = false;
		}));
		return true;
	}

	public static bool Process_Flash()
	{
		if (!string.IsNullOrEmpty(FIREHOSE_MANAGER.StringXml))
		{
			XmlTextReader xmlTextReader = new XmlTextReader(new StringReader(FIREHOSE_MANAGER.StringXml));
			SerialCOM.MSL = "ENREAD";
			UiManager.ProcessBar2(0L, 100L);
			while (xmlTextReader.Read())
			{
				if (Operators.CompareString(EDL.cancel, "Cancel", TextCompare: false) != 0)
				{
					if (xmlTextReader.NodeType != XmlNodeType.Element || Operators.CompareString(xmlTextReader.Name, "program", TextCompare: false) != 0)
					{
						continue;
					}
					FIREHOSE_MANAGER.SECTOR_SIZE_IN_BYTES = xmlTextReader.GetAttribute("SECTOR_SIZE_IN_BYTES");
					string attribute = xmlTextReader.GetAttribute("num_partition_sectors");
					string label = xmlTextReader.GetAttribute("label");
					string attribute2 = xmlTextReader.GetAttribute("filename");
					string attribute3 = xmlTextReader.GetAttribute("physical_partition_number");
					string attribute4 = xmlTextReader.GetAttribute("start_sector");
					if (string.IsNullOrEmpty(attribute2))
					{
						continue;
					}
					if (File.Exists(attribute2))
					{
						if (!FIREHOSE_PARTITIONS.WritePartition(FIREHOSE_MANAGER.SECTOR_SIZE_IN_BYTES, attribute, attribute3, attribute4, ref label, attribute2))
						{
							UiManager.Richlogs("Failed", Color.Red, isBold: true, NextLine: true);
						}
						else
						{
							UiManager.Richlogs("OK", Color.Lime, isBold: true, NextLine: true);
						}
					}
					else
					{
						UiManager.Richlogs("Skiping", Color.FromArgb(21, 87, 255), isBold: true, NextLine: true);
					}
					continue;
				}
				goto IL_0308;
			}
			UiManager.ProcessBar2(0L, 100L);
			SerialCOM.MSL = "DISREAD";
		}
		checked
		{
			if (!string.IsNullOrEmpty(EDL.SharedEDL.txtrawxml.Text))
			{
				string[] array = FIREHOSE_MANAGER.PatchString.Split(',');
				int num = array.Length - 2;
				for (int i = 0; i <= num; i++)
				{
					string text = array[i];
					if (string.IsNullOrEmpty(text))
					{
						break;
					}
					UiManager.Richlogs("- Applying Patch : ", Color.Black, isBold: false);
					XmlTextReader xmlTextReader = new XmlTextReader(new StringReader(File.ReadAllText(EDL.LoadFolderXml + "\\" + text)));
					while (xmlTextReader.Read())
					{
						if (Operators.CompareString(EDL.cancel, "Cancel", TextCompare: false) != 0)
						{
							if (xmlTextReader.NodeType != XmlNodeType.Element || Operators.CompareString(xmlTextReader.Name, "patch", TextCompare: false) != 0)
							{
								continue;
							}
							string attribute5 = xmlTextReader.GetAttribute("SECTOR_SIZE_IN_BYTES");
							string attribute6 = xmlTextReader.GetAttribute("byte_offset");
							string attribute7 = xmlTextReader.GetAttribute("filename");
							string attribute8 = xmlTextReader.GetAttribute("physical_partition_number");
							string attribute9 = xmlTextReader.GetAttribute("size_in_bytes");
							string attribute10 = xmlTextReader.GetAttribute("start_sector");
							string attribute11 = xmlTextReader.GetAttribute("value");
							string attribute12 = xmlTextReader.GetAttribute("what");
							if (attribute7.ToUpper().Contains("DISK"))
							{
								FIREHOSE_PACKET.SendXml(FIREHOSE.pkt_patch(attribute5, attribute6, attribute7, attribute8, attribute9, attribute10, attribute11, attribute12));
								if (FIREHOSE_RESPONSE.IsAck(silent: true))
								{
									UiManager.Richlogs(attribute12, Color.Blue, isBold: true, NextLine: true);
								}
							}
							continue;
						}
						goto IL_0308;
					}
					UiManager.Richlogs("- Patch Applied : ", Color.Black, isBold: false);
					UiManager.Richlogs("Done", Color.Lime, isBold: true, NextLine: true);
					FIREHOSE_MANAGER.RefreshDisk();
				}
			}
			if (FIREHOSE_MANAGER.SetBoot)
			{
				FIREHOSE_PACKET.SendXml(FIREHOSE.BootConf());
				if (!FIREHOSE_RESPONSE.IsAck(silent: true))
				{
					return false;
				}
			}
			return true;
		}
		IL_0308:
		bool result = default(bool);
		return result;
	}

	public static bool Process_Erase()
	{
		_ = FIREHOSE_MANAGER.totalchecked;
		int num = 0;
		Console.WriteLine(FIREHOSE_MANAGER.StringXml);
		XmlTextReader xmlTextReader = new XmlTextReader(new StringReader(FIREHOSE_MANAGER.StringXml));
		while (true)
		{
			if (xmlTextReader.Read())
			{
				if (Operators.CompareString(EDL.cancel, "Cancel", TextCompare: false) == 0)
				{
					break;
				}
				if ((xmlTextReader.NodeType == XmlNodeType.Element && Operators.CompareString(xmlTextReader.Name, "program", TextCompare: false) == 0) || (xmlTextReader.NodeType == XmlNodeType.Element && Operators.CompareString(xmlTextReader.Name, "erase", TextCompare: false) == 0))
				{
					FIREHOSE_MANAGER.SECTOR_SIZE_IN_BYTES = xmlTextReader.GetAttribute("SECTOR_SIZE_IN_BYTES");
					string attribute = xmlTextReader.GetAttribute("num_partition_sectors");
					string label = xmlTextReader.GetAttribute("label");
					xmlTextReader.GetAttribute("filename");
					string attribute2 = xmlTextReader.GetAttribute("physical_partition_number");
					string attribute3 = xmlTextReader.GetAttribute("start_sector");
					num = checked(num + 1);
					if (Operators.CompareString(FIREHOSE_MANAGER.Partition_Name, "frp", TextCompare: false) == 0)
					{
						UiManager.Richlogs("- Remove Frp Lock #Block " + num + " : ", Color.Black, isBold: false);
						Form1.SharedUI.ProgressBar1.Text = "Remove Frp...";
					}
					else if (Operators.CompareString(FIREHOSE_MANAGER.Partition_Name, "ID", TextCompare: false) == 0)
					{
						UiManager.Richlogs("- Remove ID #Block " + num + " : ", Color.Black, isBold: false);
						Form1.SharedUI.ProgressBar1.Text = "Remove ID..";
					}
					else if (Operators.CompareString(FIREHOSE_MANAGER.Partition_Name, "modems", TextCompare: false) == 0)
					{
						UiManager.Richlogs("- Reset Modems #Block " + num + " : ", Color.Black, isBold: false);
						Form1.SharedUI.ProgressBar1.Text = "Reseting..";
					}
					else if (Operators.CompareString(FIREHOSE_MANAGER.Partition_Name, "knox", TextCompare: false) == 0)
					{
						UiManager.Richlogs("- Remove Knox Lock #Block " + num + " : ", Color.Black, isBold: false);
						Form1.SharedUI.ProgressBar1.Text = "Removeing..";
					}
					else
					{
						UiManager.Richlogs("- Wieping EFS #Block " + num + " : ", Color.Black, isBold: false);
						Form1.SharedUI.ProgressBar1.Text = "Wieping..";
					}
					if (!FIREHOSE_PARTITIONS.ErasePartition(FIREHOSE_MANAGER.SECTOR_SIZE_IN_BYTES, attribute, attribute2, attribute3, ref label))
					{
						UiManager.Richlogs("Failed", Color.Red, isBold: true, NextLine: true);
					}
					else
					{
						UiManager.Richlogs("OK", Color.Lime, isBold: true, NextLine: true);
					}
				}
				continue;
			}
			return true;
		}
		bool result = default(bool);
		return result;
	}

	public static bool Process_Erase_PART()
	{
		_ = FIREHOSE_MANAGER.totalchecked;
		int num = 0;
		Console.WriteLine(FIREHOSE_MANAGER.StringXml);
		XmlTextReader xmlTextReader = new XmlTextReader(new StringReader(FIREHOSE_MANAGER.StringXml));
		while (true)
		{
			if (xmlTextReader.Read())
			{
				if (Operators.CompareString(EDL.cancel, "Cancel", TextCompare: false) == 0)
				{
					break;
				}
				if ((xmlTextReader.NodeType == XmlNodeType.Element && Operators.CompareString(xmlTextReader.Name, "program", TextCompare: false) == 0) || (xmlTextReader.NodeType == XmlNodeType.Element && Operators.CompareString(xmlTextReader.Name, "erase", TextCompare: false) == 0))
				{
					FIREHOSE_MANAGER.SECTOR_SIZE_IN_BYTES = xmlTextReader.GetAttribute("SECTOR_SIZE_IN_BYTES");
					string attribute = xmlTextReader.GetAttribute("num_partition_sectors");
					string label = xmlTextReader.GetAttribute("label");
					xmlTextReader.GetAttribute("filename");
					string attribute2 = xmlTextReader.GetAttribute("physical_partition_number");
					string attribute3 = xmlTextReader.GetAttribute("start_sector");
					num = checked(num + 1);
					UiManager.Richlogs("- Erase Partition ", Color.Black, isBold: false);
					UiManager.Richlogs(label, Color.Lime);
					UiManager.Richlogs(" : ", Color.Black, isBold: false);
					if (!FIREHOSE_PARTITIONS.ErasePartition(FIREHOSE_MANAGER.SECTOR_SIZE_IN_BYTES, attribute, attribute2, attribute3, ref label))
					{
						UiManager.Richlogs("Failed", Color.Red, isBold: true, NextLine: true);
					}
					else
					{
						UiManager.Richlogs("OK", Color.Lime, isBold: true, NextLine: true);
					}
				}
				continue;
			}
			return true;
		}
		bool result = default(bool);
		return result;
	}

	public static bool Process_Read()
	{
		_ = FIREHOSE_MANAGER.totalchecked;
		string left = "";
		XmlTextReader xmlTextReader = new XmlTextReader(new StringReader(FIREHOSE_MANAGER.StringXml));
		SerialCOM.MSL = "ENREAD";
		UiManager.ProcessBar2(0L, 100L);
		while (true)
		{
			if (xmlTextReader.Read())
			{
				if (Operators.CompareString(EDL.cancel, "Cancel", TextCompare: false) == 0)
				{
					break;
				}
				if (xmlTextReader.NodeType != XmlNodeType.Element || Operators.CompareString(xmlTextReader.Name, "read", TextCompare: false) != 0)
				{
					continue;
				}
				string attribute = xmlTextReader.GetAttribute("SECTOR_SIZE_IN_BYTES");
				string attribute2 = xmlTextReader.GetAttribute("num_partition_sectors");
				string label = xmlTextReader.GetAttribute("label");
				string attribute3 = xmlTextReader.GetAttribute("physical_partition_number");
				string attribute4 = xmlTextReader.GetAttribute("start_sector");
				UiManager.Richlogs("- Reading Partition [", Color.Black, isBold: false);
				UiManager.Richlogs(label, Color.Lime);
				UiManager.Richlogs("] -> [", Color.Black, isBold: false);
				UiManager.Richlogs(FIREHOSE_PARTITIONS.Get_Partition_Filenames(label), Color.Lime);
				UiManager.Richlogs("] : ", Color.Black, isBold: false);
				if (FIREHOSE_PARTITIONS.ReadPartition(attribute4, attribute2, attribute, attribute3, ref label))
				{
					if (Operators.CompareString(left, attribute3, TextCompare: false) != 0)
					{
						Process_Create_RawProgrammerXML(attribute3);
					}
					UiManager.Richlogs("OK", Color.LimeGreen, isBold: true, NextLine: true);
					left = attribute3;
				}
				else
				{
					UiManager.Richlogs("Failed", Color.Red);
				}
				continue;
			}
			UiManager.ProcessBar2(0L, 100L);
			SerialCOM.MSL = "DISREAD";
			return true;
		}
		bool result = default(bool);
		return result;
	}

	public static void Process_Create_RawProgrammerXML(string lun = "0")
	{
		string path = FIREHOSE_MANAGER.foldersave + "\\rawprogram" + lun + ".xml";
		if (File.Exists(path))
		{
			File.Delete(path);
		}
		StreamWriter streamWriter = new StreamWriter(path, append: true, Encoding.UTF8);
		streamWriter.WriteLine("<?xml version=\"1.0\" ?>");
		streamWriter.WriteLine("<data>");
		streamWriter.WriteLine("<!--NOTE: Genererated By Tunlocker Tool @TfastDigital **-->");
		XmlTextReader xmlTextReader = new XmlTextReader(new StringReader(FIREHOSE_MANAGER.StringXml));
		while (true)
		{
			if (xmlTextReader.Read())
			{
				if (Operators.CompareString(EDL.cancel, "Cancel", TextCompare: false) == 0)
				{
					break;
				}
				if (xmlTextReader.NodeType == XmlNodeType.Element && Operators.CompareString(xmlTextReader.Name, "read", TextCompare: false) == 0)
				{
					string attribute = xmlTextReader.GetAttribute("SECTOR_SIZE_IN_BYTES");
					string attribute2 = xmlTextReader.GetAttribute("num_partition_sectors");
					string attribute3 = xmlTextReader.GetAttribute("label");
					string attribute4 = xmlTextReader.GetAttribute("physical_partition_number");
					string attribute5 = xmlTextReader.GetAttribute("start_sector");
					if (Operators.CompareString(lun, attribute4, TextCompare: false) == 0)
					{
						streamWriter.WriteLine("<program SECTOR_SIZE_IN_BYTES=\"" + attribute + "\" file_sector_offset=\"0\" filename=\"" + FIREHOSE_PARTITIONS.Get_Partition_Filenames(attribute3) + "\" label=\"" + attribute3 + "\" num_partition_sectors=\"" + attribute2 + "\" physical_partition_number=\"" + attribute4 + "\" start_sector=\"" + attribute5 + "\" />");
					}
				}
				continue;
			}
			streamWriter.WriteLine("</data>");
			streamWriter.Flush();
			streamWriter.Close();
			break;
		}
	}

	public static bool Process_Reboot()
	{
		UiManager.Richlogs("- Reboot Device : ", Color.Black, isBold: false);
		Form1.SharedUI.ProgressBar1.Text = "Rebooting...";
		FIREHOSE_PACKET.SendXml(FIREHOSE.pkt_sendReset());
		if (FIREHOSE_RESPONSE.IsAck(silent: true))
		{
			EDL.SharedEDL.Guna2RadioButton6.Invoke((Action)([SpecialName] () =>
			{
				EDL.SharedEDL.Guna2RadioButton6.Enabled = false;
			}));
			EDL.SharedEDL.buttonerase.Invoke((Action)([SpecialName] () =>
			{
				EDL.SharedEDL.buttonerase.Enabled = false;
			}));
			EDL.SharedEDL.Guna2RadioButton7.Invoke((Action)([SpecialName] () =>
			{
				EDL.SharedEDL.Guna2RadioButton7.Enabled = false;
			}));
			EDL.SharedEDL.Guna2RadioButton8.Invoke((Action)([SpecialName] () =>
			{
				EDL.SharedEDL.Guna2RadioButton8.Enabled = false;
			}));
			EDL.SharedEDL.BtnIdentify.Invoke((Action)([SpecialName] () =>
			{
				EDL.SharedEDL.BtnIdentify.Enabled = true;
			}));
			UiManager.Richlogs("Done", Color.DarkOrange, isBold: true, NextLine: true);
			return true;
		}
		UiManager.Richlogs("Failed", Color.Red);
		return false;
	}

	public static bool Process_Mi()
	{
		XmlTextReader xmlTextReader = new XmlTextReader(new StringReader(FIREHOSE_MANAGER.StringXml));
		while (true)
		{
			if (xmlTextReader.Read())
			{
				if (Operators.CompareString(EDL.cancel, "Cancel", TextCompare: false) == 0)
				{
					break;
				}
				if (xmlTextReader.NodeType != XmlNodeType.Element || Operators.CompareString(xmlTextReader.Name, "read", TextCompare: false) != 0)
				{
					continue;
				}
				string attribute = xmlTextReader.GetAttribute("SECTOR_SIZE_IN_BYTES");
				string attribute2 = xmlTextReader.GetAttribute("num_partition_sectors");
				xmlTextReader.GetAttribute("filename");
				string attribute3 = xmlTextReader.GetAttribute("physical_partition_number");
				string label = xmlTextReader.GetAttribute("label");
				string attribute4 = xmlTextReader.GetAttribute("start_sector");
				string text = FIREHOSE_MANAGER.foldersave + "\\" + FIREHOSE_PARTITIONS.Get_Partition_Filenames(label);
				if (label.Contains("modem"))
				{
					if (File.Exists(text))
					{
						File.Delete(text);
					}
					UiManager.Richlogs("- Checking Filesystem : ", Color.Black, isBold: false);
					if (!FIREHOSE_PARTITIONS.ReadPartition(attribute4, attribute2, attribute, attribute3, ref label))
					{
						UiManager.Richlogs("Failed", Color.Red);
						return false;
					}
					if (File.Exists(text))
					{
						UiManager.Richlogs("OK", Color.Lime, isBold: true, NextLine: true);
						UiManager.Richlogs("- Patching Mi Account Data : ", Color.Black, isBold: false);
						string str_pattern = "CARDAPP";
						string text2 = "SLOTAPP";
						long num = HexEditor.FindOffsetInFile_String_Pattern(text, str_pattern);
						long end = 0L;
						long len = Encoding.Default.GetBytes(text2).Length;
						if (num <= 0)
						{
							UiManager.Richlogs("Not Found Security", Color.Red);
							continue;
						}
						HexEditor.PatchFile_String_Pattern(text, str_pattern, text2, num, end, len, fillzero: false, silent: true);
						UiManager.Richlogs("OK", Color.Lime, isBold: true, NextLine: true);
						if (!FIREHOSE_PARTITIONS.Write_mi_data(attribute, attribute2, attribute3, attribute4, ref label, text))
						{
							UiManager.Richlogs("Failed", Color.Red);
							return false;
						}
						if (File.Exists(text))
						{
							File.Delete(text);
						}
						UiManager.Richlogs("OK", Color.Lime, isBold: true, NextLine: true);
					}
					else
					{
						UiManager.Richlogs("Failed", Color.Red);
					}
				}
				if (label.Contains("modem_a"))
				{
					if (File.Exists(text))
					{
						File.Delete(text);
					}
					UiManager.Richlogs("- Checking Filesystem : ", Color.Black, isBold: false);
					if (!FIREHOSE_PARTITIONS.ReadPartition(attribute4, attribute2, attribute, attribute3, ref label))
					{
						UiManager.Richlogs("Failed", Color.Red);
						return false;
					}
					if (File.Exists(text))
					{
						UiManager.Richlogs("OK", Color.Lime, isBold: true, NextLine: true);
						UiManager.Richlogs("- Patching Mi Account Data : ", Color.Black, isBold: false);
						string str_pattern2 = "CARDAPP";
						string text3 = "SLOTAPP";
						long num2 = HexEditor.FindOffsetInFile_String_Pattern(text, str_pattern2);
						long end2 = 0L;
						long len2 = Encoding.Default.GetBytes(text3).Length;
						if (num2 <= 0)
						{
							UiManager.Richlogs("Not Found Security", Color.Red);
							continue;
						}
						HexEditor.PatchFile_String_Pattern(text, str_pattern2, text3, num2, end2, len2, fillzero: false, silent: true);
						UiManager.Richlogs("OK", Color.Lime, isBold: true, NextLine: true);
						if (!FIREHOSE_PARTITIONS.Write_mi_data(attribute, attribute2, attribute3, attribute4, ref label, text))
						{
							UiManager.Richlogs("Failed", Color.Red);
							return false;
						}
						if (File.Exists(text))
						{
							File.Delete(text);
						}
						UiManager.Richlogs("OK", Color.Lime, isBold: true, NextLine: true);
					}
					else
					{
						UiManager.Richlogs("Failed", Color.Red);
					}
				}
				if (label.Contains("modem_b"))
				{
					if (File.Exists(text))
					{
						File.Delete(text);
					}
					UiManager.Richlogs("- Checking Filesystem : ", Color.Black, isBold: false);
					if (!FIREHOSE_PARTITIONS.ReadPartition(attribute4, attribute2, attribute, attribute3, ref label))
					{
						UiManager.Richlogs("Failed", Color.Red);
						return false;
					}
					if (File.Exists(text))
					{
						UiManager.Richlogs("OK", Color.Lime, isBold: true, NextLine: true);
						UiManager.Richlogs("- Patching Mi Account Data : ", Color.Black, isBold: false);
						string str_pattern3 = "CARDAPP";
						string text4 = "SLOTAPP";
						long num3 = HexEditor.FindOffsetInFile_String_Pattern(text, str_pattern3);
						long end3 = 0L;
						long len3 = Encoding.Default.GetBytes(text4).Length;
						if (num3 <= 0)
						{
							UiManager.Richlogs("Not Found Security", Color.Red);
							continue;
						}
						HexEditor.PatchFile_String_Pattern(text, str_pattern3, text4, num3, end3, len3, fillzero: false, silent: true);
						UiManager.Richlogs("OK", Color.Lime, isBold: true, NextLine: true);
						if (!FIREHOSE_PARTITIONS.Write_mi_data(attribute, attribute2, attribute3, attribute4, ref label, text))
						{
							UiManager.Richlogs("Failed", Color.Red);
							return false;
						}
						if (File.Exists(text))
						{
							File.Delete(text);
						}
						UiManager.Richlogs("OK", Color.Lime, isBold: true, NextLine: true);
					}
					else
					{
						UiManager.Richlogs("Failed", Color.Red);
					}
				}
				if (Operators.CompareString(label, "persist", TextCompare: false) != 0)
				{
					continue;
				}
				UiManager.Richlogs("- Reseting Mi Acoount INFO : ", Color.Black, isBold: false);
				if (!FIREHOSE_PARTITIONS.ReadPartition(attribute4, attribute2, attribute, attribute3, ref label))
				{
					UiManager.Richlogs("Failed", Color.Red);
					return false;
				}
				if (File.Exists(text))
				{
					string str_pattern4 = "fdsd";
					string text5 = "ftst";
					long num4 = HexEditor.FindOffsetInFile_String_Pattern(text, str_pattern4);
					long end4 = 0L;
					long len4 = Encoding.Default.GetBytes(text5).Length;
					if (num4 > 0)
					{
						HexEditor.PatchFile_String_Pattern(text, str_pattern4, text5, num4, end4, len4, fillzero: false, silent: true);
						if (!FIREHOSE_PARTITIONS.Write_mi_data(attribute, attribute2, attribute3, attribute4, ref label, text))
						{
							UiManager.Richlogs("Failed", Color.Red);
							return false;
						}
						UiManager.Richlogs("OK", Color.Lime, isBold: true, NextLine: true);
						if (File.Exists(text))
						{
							File.Delete(text);
						}
					}
					else
					{
						UiManager.Richlogs("Not Found Security", Color.Red);
					}
				}
				else
				{
					UiManager.Richlogs("Failed", Color.Red);
				}
				continue;
			}
			return true;
		}
		bool result = default(bool);
		return result;
	}

	public static string Calculating_KG(string folderbackup)
	{
		Hexx = ByteArrayToString(File.ReadAllBytes(folderbackup));
		Stringg = HexToString(Hexx);
		checked
		{
			if (Stringg.Contains("serialNumber"))
			{
				if (Stringg.Contains("XDATAUTEAMX"))
				{
					return "done";
				}
				serialNumber = StringToHex(ExtractFirstSerialNumber(Stringg));
				if (Hexx.Contains(serialNumber))
				{
					Hex_New = Hexx.Replace(serialNumber, "5844415441555445414d58");
					Stringg = HexToString(Hex_New);
					if (Stringg.Contains("XDATAUTEAMX"))
					{
						UiManager.Richlogs("OK", Color.Lime, isBold: true, NextLine: true);
						UiManager.Richlogs("- Writing Data To Target : ", Color.Black, isBold: false);
						Form1.SharedUI.ProgressBar1.Text = "Writing...";
						Write(folderbackup);
						return "unlock";
					}
					string result = default(string);
					return result;
				}
				byte[] array = HexStringToByteArray(serialNumber);
				byte[] array2 = new byte[11]
				{
					88, 68, 65, 84, 65, 85, 84, 69, 65, 77,
					88
				};
				byte[] array3 = File.ReadAllBytes(folderbackup);
				int num = array.Length;
				UiManager.Richlogs("OK", Color.Lime, isBold: true, NextLine: true);
				UiManager.Richlogs("- Writing Data To Target : ", Color.Black, isBold: false);
				Form1.SharedUI.ProgressBar1.Text = "Writing...";
				int num2 = array3.Length - num;
				for (int i = 0; i <= num2; i++)
				{
					bool flag = true;
					int num3 = num - 1;
					for (int j = 0; j <= num3; j++)
					{
						if (array3[i + j] != array[j])
						{
							flag = false;
							break;
						}
					}
					if (flag)
					{
						Array.Copy(array2, 0, array3, i, array2.Length);
						i += array2.Length - 1;
					}
				}
				File.WriteAllBytes(folderbackup, array3);
				return "unlock";
			}
			return "not_Fuond";
		}
	}

	public static byte[] HexStringToByteArray(string hex)
	{
		checked
		{
			byte[] array = new byte[unchecked(hex.Length / 2) - 1 + 1];
			int num = hex.Length - 1;
			for (int i = 0; i <= num; i += 2)
			{
				array[unchecked(i / 2)] = Convert.ToByte(hex.Substring(i, 2), 16);
			}
			return array;
		}
	}

	public static string HexToString(string hexString)
	{
		StringBuilder stringBuilder = new StringBuilder();
		checked
		{
			int num = hexString.Length - 1;
			for (int i = 0; i <= num; i += 2)
			{
				int charCode = Convert.ToInt32(hexString.Substring(i, 2), 16);
				stringBuilder.Append(Strings.Chr(charCode));
			}
			return stringBuilder.ToString();
		}
	}

	public static string StringToHex(string inputString)
	{
		StringBuilder stringBuilder = new StringBuilder();
		foreach (char value in inputString)
		{
			stringBuilder.Append(Convert.ToInt32(value).ToString("X2"));
		}
		return stringBuilder.ToString();
	}

	public static string ExtractFirstSerialNumber(string inputText)
	{
		int num = inputText.IndexOf("\"serialNumber\":\"");
		if (num == -1)
		{
			return string.Empty;
		}
		checked
		{
			num += "\"serialNumber\":\"".Length;
			int num2 = inputText.IndexOf("\"", num);
			if (num2 == -1)
			{
				return string.Empty;
			}
			return inputText.Substring(num, num2 - num);
		}
	}

	public static string ByteArrayToString(byte[] ba)
	{
		StringBuilder stringBuilder = new StringBuilder(checked(ba.Length * 2));
		foreach (byte b in ba)
		{
			stringBuilder.AppendFormat("{0:x2}", b);
		}
		return stringBuilder.ToString();
	}

	public static object Write(string theEncryptedFile)
	{
		checked
		{
			byte[] array = new byte[unchecked(Hex_New.Length / 2) - 1 + 1];
			int num = array.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				array[i] = Convert.ToByte(Hex_New.Substring(i * 2, 2), 16);
			}
			try
			{
				File.Delete(theEncryptedFile);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
			using (StreamWriter streamWriter = File.AppendText(theEncryptedFile))
			{
				streamWriter.Write("");
				streamWriter.Flush();
				streamWriter.Close();
			}
			File.WriteAllBytes(theEncryptedFile, array);
			object result = default(object);
			return result;
		}
	}

	public static bool Process_Erase_Patch()
	{
		int num = 0;
		XmlTextReader xmlTextReader = new XmlTextReader(new StringReader(FIREHOSE_MANAGER.StringXml));
		SerialCOM.MSL = "ENREAD";
		UiManager.ProcessBar2(0L, 100L);
		while (true)
		{
			if (xmlTextReader.Read())
			{
				if (Operators.CompareString(EDL.cancel, "Cancel", TextCompare: false) == 0)
				{
					break;
				}
				if (xmlTextReader.NodeType == XmlNodeType.Element && Operators.CompareString(xmlTextReader.Name, "program", TextCompare: false) == 0)
				{
					string attribute = xmlTextReader.GetAttribute("SECTOR_SIZE_IN_BYTES");
					string attribute2 = xmlTextReader.GetAttribute("num_partition_sectors");
					xmlTextReader.GetAttribute("filename");
					string attribute3 = xmlTextReader.GetAttribute("physical_partition_number");
					string label = xmlTextReader.GetAttribute("label");
					string attribute4 = xmlTextReader.GetAttribute("start_sector");
					num = checked(num + 1);
					if (Operators.CompareString(FIREHOSE_MANAGER.Partition_Name, "frp", TextCompare: false) == 0)
					{
						UiManager.Richlogs("- Remove Frp Lock #Block " + num + " : ", Color.Black, isBold: false);
						Form1.SharedUI.ProgressBar1.Text = "Remove Frp...";
					}
					else if (Operators.CompareString(FIREHOSE_MANAGER.Partition_Name, "ID", TextCompare: false) == 0)
					{
						UiManager.Richlogs("- Remove ID #Block " + num + " : ", Color.Black, isBold: false);
						Form1.SharedUI.ProgressBar1.Text = "Remove ID..";
					}
					else if (Operators.CompareString(FIREHOSE_MANAGER.Partition_Name, "modems", TextCompare: false) == 0)
					{
						UiManager.Richlogs("- Reset Modems #Block " + num + " : ", Color.Black, isBold: false);
						Form1.SharedUI.ProgressBar1.Text = "Reseting..";
					}
					else if (Operators.CompareString(FIREHOSE_MANAGER.Partition_Name, "knox", TextCompare: false) == 0)
					{
						UiManager.Richlogs("- Remove Knox Lock #Block " + num + " : ", Color.Black, isBold: false);
						Form1.SharedUI.ProgressBar1.Text = "Removeing..";
					}
					else
					{
						UiManager.Richlogs("- Wieping EFS #Block " + num + " : ", Color.Black, isBold: false);
						Form1.SharedUI.ProgressBar1.Text = "Wieping..";
					}
					if (!FIREHOSE_PARTITIONS.EraseByPatch(attribute, attribute2, attribute3, attribute4, ref label))
					{
						UiManager.Richlogs("Failed", Color.Red, isBold: true, NextLine: true);
					}
					else
					{
						UiManager.Richlogs("OK", Color.FromArgb(21, 87, 255), isBold: true, NextLine: true);
					}
				}
				continue;
			}
			UiManager.ProcessBar2(0L, 100L);
			SerialCOM.MSL = "DISREAD";
			return false;
		}
		bool result = default(bool);
		return result;
	}

	public static bool Process_OneClick()
	{
		long num = 0L;
		long num2 = 0L;
		checked
		{
			if (FIREHOSE_MANAGER.StringXml.ToLower().Contains("patch"))
			{
				XmlTextReader xmlTextReader = new XmlTextReader(new StringReader(FIREHOSE_MANAGER.StringXml));
				while (xmlTextReader.Read())
				{
					if (Operators.CompareString(EDL.cancel, "Cancel", TextCompare: false) != 0)
					{
						if (xmlTextReader.NodeType == XmlNodeType.Element && Operators.CompareString(xmlTextReader.Name, "patch", TextCompare: false) == 0 && xmlTextReader.GetAttribute("filename").ToLower().Contains("disk"))
						{
							num++;
						}
						continue;
					}
					goto IL_0b24;
				}
			}
			XmlTextReader xmlTextReader2 = new XmlTextReader(new StringReader(FIREHOSE_MANAGER.StringXml));
			while (true)
			{
				if (xmlTextReader2.Read())
				{
					if (Operators.CompareString(EDL.cancel, "Cancel", TextCompare: false) == 0)
					{
						break;
					}
					if (xmlTextReader2.NodeType == XmlNodeType.Element && Operators.CompareString(xmlTextReader2.Name, "patch", TextCompare: false) == 0)
					{
						string attribute = xmlTextReader2.GetAttribute("SECTOR_SIZE_IN_BYTES");
						string attribute2 = xmlTextReader2.GetAttribute("byte_offset");
						string attribute3 = xmlTextReader2.GetAttribute("filename");
						string attribute4 = xmlTextReader2.GetAttribute("physical_partition_number");
						string attribute5 = xmlTextReader2.GetAttribute("size_in_bytes");
						string attribute6 = xmlTextReader2.GetAttribute("start_sector");
						string attribute7 = xmlTextReader2.GetAttribute("value");
						string attribute8 = xmlTextReader2.GetAttribute("what");
						if (attribute3.ToLower().Contains("disk"))
						{
							string xml = FIREHOSE.pkt_patch(attribute, attribute2, attribute3, attribute4, attribute5, attribute6, attribute7, attribute8);
							num2++;
							if (num2 == 1)
							{
								UiManager.Richlogs("Patch Partition Data : ", Color.Black, isBold: false);
								FIREHOSE_PACKET.SendXml(xml);
								if (!FIREHOSE_RESPONSE.IsAck(silent: true))
								{
									FIREHOSE_MANAGER.RefreshDisk();
									return false;
								}
								FIREHOSE_MANAGER.RefreshDisk();
								UiManager.ProcessBar1(num2, num);
							}
							else
							{
								FIREHOSE_PACKET.SendXml(xml);
								if (!FIREHOSE_RESPONSE.IsAck(silent: true))
								{
									UiManager.Richlogs("Failed", Color.Red);
									FIREHOSE_MANAGER.RefreshDisk();
									return false;
								}
								FIREHOSE_MANAGER.RefreshDisk();
							}
							if (num2 == num)
							{
								UiManager.ProcessBar1(num, num);
								UiManager.Richlogs("Done ", Color.DarkOrange, isBold: false, NextLine: true);
							}
						}
					}
					if (xmlTextReader2.NodeType == XmlNodeType.Element && Operators.CompareString(xmlTextReader2.Name, "erase", TextCompare: false) == 0)
					{
						string attribute9 = xmlTextReader2.GetAttribute("SECTOR_SIZE_IN_BYTES");
						string attribute10 = xmlTextReader2.GetAttribute("num_partition_sectors");
						string attribute11 = xmlTextReader2.GetAttribute("physical_partition_number");
						string attribute12 = xmlTextReader2.GetAttribute("start_sector");
						string label = xmlTextReader2.GetAttribute("label");
						if (!FIREHOSE_PARTITIONS.ErasePartition(attribute9, attribute10, attribute11, attribute12, ref label))
						{
							UiManager.Richlogs("Failed", Color.Red);
						}
						else
						{
							UiManager.Richlogs("OK", Color.Lime, isBold: true, NextLine: true);
						}
					}
					if (xmlTextReader2.NodeType != XmlNodeType.Element || Operators.CompareString(xmlTextReader2.Name, "program", TextCompare: false) != 0)
					{
						continue;
					}
					string attribute13 = xmlTextReader2.GetAttribute("SECTOR_SIZE_IN_BYTES");
					string attribute14 = xmlTextReader2.GetAttribute("num_partition_sectors");
					string attribute15 = xmlTextReader2.GetAttribute("filename");
					string attribute16 = xmlTextReader2.GetAttribute("physical_partition_number");
					string label2 = xmlTextReader2.GetAttribute("label");
					string attribute17 = xmlTextReader2.GetAttribute("start_sector");
					if (string.IsNullOrEmpty(attribute15))
					{
						if (!FIREHOSE_PARTITIONS.ErasePartition(attribute13, attribute14, attribute16, attribute17, ref label2))
						{
							UiManager.Richlogs("Failed", Color.Red);
						}
						else
						{
							UiManager.Richlogs("OK", Color.Lime, isBold: true, NextLine: true);
						}
						continue;
					}
					if (!string.IsNullOrEmpty(FIREHOSE_MANAGER.SelectedExecution) && FIREHOSE_MANAGER.SelectedExecution.ToLower().Contains("xiaomi"))
					{
						if (label2.Contains("modem") || label2.Contains("modem_a") || label2.Contains("modem_b") || label2.Contains("persist"))
						{
							FIREHOSE_MANAGER.foldersave = Application.StartupPath + "\\temp";
							string text = FIREHOSE_MANAGER.foldersave + "\\" + FIREHOSE_PARTITIONS.Get_Partition_Filenames(label2);
							if (label2.Contains("modem"))
							{
								if (File.Exists(text))
								{
									File.Delete(text);
								}
								UiManager.Richlogs("- Checking Filesystem : ", Color.Black, isBold: false);
								if (!FIREHOSE_PARTITIONS.ReadPartition(attribute17, attribute14, attribute13, attribute16, ref label2))
								{
									UiManager.Richlogs("Failed", Color.Red);
									FIREHOSE_MANAGER.SelectedExecution = "";
									return false;
								}
								UiManager.Richlogs("Done", Color.Lime, isBold: false, NextLine: true);
								if (File.Exists(text))
								{
									UiManager.Richlogs("Patching Data : ...", Color.Black, isBold: false, NextLine: true);
									string str_pattern = "CARDAPP";
									string text2 = "SLOTAPP";
									long num3 = HexEditor.FindOffsetInFile_String_Pattern(text, str_pattern);
									long end = 0L;
									long len = Encoding.Default.GetBytes(text2).Length;
									if (num3 <= 0)
									{
										UiManager.Richlogs("Not Found Security", Color.Red);
										continue;
									}
									HexEditor.PatchFile_String_Pattern(text, str_pattern, text2, num3, end, len, fillzero: false, silent: true);
									FIREHOSE_MANAGER.FilesOneClick = File.ReadAllBytes(text);
									UiManager.Richlogs("OK", Color.Lime, isBold: true, NextLine: true);
									if (!FIREHOSE_PARTITIONS.WritePartition(attribute13, attribute14, attribute16, attribute17, ref label2, attribute15))
									{
										UiManager.Richlogs("Failed", Color.Red);
										FIREHOSE_MANAGER.SelectedExecution = "";
										return false;
									}
									UiManager.Richlogs("OK", Color.Lime, isBold: true, NextLine: true);
									if (File.Exists(text))
									{
										File.Delete(text);
									}
								}
								else
								{
									UiManager.Richlogs("Failed", Color.Red);
								}
							}
							if (label2.Contains("modem_a"))
							{
								if (File.Exists(text))
								{
									File.Delete(text);
								}
								UiManager.Richlogs("- Checking Filesystem : ", Color.Black, isBold: false);
								if (!FIREHOSE_PARTITIONS.ReadPartition(attribute17, attribute14, attribute13, attribute16, ref label2))
								{
									UiManager.Richlogs("Failed", Color.Red);
									FIREHOSE_MANAGER.SelectedExecution = "";
									return false;
								}
								UiManager.Richlogs("Done", Color.Lime, isBold: false, NextLine: true);
								if (File.Exists(text))
								{
									UiManager.Richlogs("Patching Data : ...", Color.Black, isBold: false, NextLine: true);
									string str_pattern2 = "CARDAPP";
									string text3 = "SLOTAPP";
									long num4 = HexEditor.FindOffsetInFile_String_Pattern(text, str_pattern2);
									long end2 = 0L;
									long len2 = Encoding.Default.GetBytes(text3).Length;
									if (num4 <= 0)
									{
										UiManager.Richlogs("Not Found Security", Color.Red);
										continue;
									}
									HexEditor.PatchFile_String_Pattern(text, str_pattern2, text3, num4, end2, len2, fillzero: false, silent: true);
									FIREHOSE_MANAGER.FilesOneClick = File.ReadAllBytes(text);
									UiManager.Richlogs("OK", Color.Lime, isBold: true, NextLine: true);
									if (!FIREHOSE_PARTITIONS.WritePartition(attribute13, attribute14, attribute16, attribute17, ref label2, attribute15))
									{
										UiManager.Richlogs("Failed", Color.Red);
										FIREHOSE_MANAGER.SelectedExecution = "";
										return false;
									}
									UiManager.Richlogs("OK", Color.Lime, isBold: true, NextLine: true);
									if (File.Exists(text))
									{
										File.Delete(text);
									}
								}
								else
								{
									UiManager.Richlogs("Failed", Color.Red);
								}
							}
							if (label2.Contains("modem_b"))
							{
								if (File.Exists(text))
								{
									File.Delete(text);
								}
								UiManager.Richlogs("- Checking Filesystem : ", Color.Black, isBold: false);
								if (!FIREHOSE_PARTITIONS.ReadPartition(attribute17, attribute14, attribute13, attribute16, ref label2))
								{
									UiManager.Richlogs("Failed", Color.Red);
									FIREHOSE_MANAGER.SelectedExecution = "";
									return false;
								}
								UiManager.Richlogs("Done", Color.Lime, isBold: false, NextLine: true);
								if (File.Exists(text))
								{
									UiManager.Richlogs("Patching Data : ...", Color.Black, isBold: false, NextLine: true);
									string str_pattern3 = "CARDAPP";
									string text4 = "SLOTAPP";
									long num5 = HexEditor.FindOffsetInFile_String_Pattern(text, str_pattern3);
									long end3 = 0L;
									long len3 = Encoding.Default.GetBytes(text4).Length;
									if (num5 <= 0)
									{
										UiManager.Richlogs("Not Found Security", Color.Red);
										continue;
									}
									HexEditor.PatchFile_String_Pattern(text, str_pattern3, text4, num5, end3, len3, fillzero: false, silent: true);
									FIREHOSE_MANAGER.FilesOneClick = File.ReadAllBytes(text);
									UiManager.Richlogs("OK", Color.Lime, isBold: true, NextLine: true);
									if (!FIREHOSE_PARTITIONS.WritePartition(attribute13, attribute14, attribute16, attribute17, ref label2, attribute15))
									{
										UiManager.Richlogs("Failed", Color.Red);
										FIREHOSE_MANAGER.SelectedExecution = "";
										return false;
									}
									UiManager.Richlogs("OK", Color.Lime, isBold: true, NextLine: true);
									if (File.Exists(text))
									{
										File.Delete(text);
									}
								}
								else
								{
									UiManager.Richlogs("Failed", Color.Red);
								}
							}
							if (Operators.CompareString(label2, "persist", TextCompare: false) == 0)
							{
								if (File.Exists(text))
								{
									File.Delete(text);
								}
								UiManager.Richlogs("- Checking Filesystem : ", Color.Black, isBold: false);
								if (!FIREHOSE_PARTITIONS.ReadPartition(attribute17, attribute14, attribute13, attribute16, ref label2))
								{
									UiManager.Richlogs("Failed", Color.Red);
									FIREHOSE_MANAGER.SelectedExecution = "";
									return false;
								}
								UiManager.Richlogs("Done", Color.Lime, isBold: false, NextLine: true);
								if (File.Exists(text))
								{
									UiManager.Richlogs("Patching Data : ", Color.Black, isBold: false);
									string str_pattern4 = "fdsd";
									string text5 = "ftst";
									long num6 = HexEditor.FindOffsetInFile_String_Pattern(text, str_pattern4);
									long end4 = 0L;
									long len4 = Encoding.Default.GetBytes(text5).Length;
									if (num6 <= 0)
									{
										UiManager.Richlogs("Not Found Security", Color.Red);
										continue;
									}
									HexEditor.PatchFile_String_Pattern(text, str_pattern4, text5, num6, end4, len4, fillzero: false, silent: true);
									FIREHOSE_MANAGER.FilesOneClick = File.ReadAllBytes(text);
									UiManager.Richlogs("OK", Color.Lime, isBold: true, NextLine: true);
									if (!FIREHOSE_PARTITIONS.WritePartition(attribute13, attribute14, attribute16, attribute17, ref label2, attribute15))
									{
										UiManager.Richlogs("Failed", Color.Red);
										FIREHOSE_MANAGER.SelectedExecution = "";
										return false;
									}
									UiManager.Richlogs("OK", Color.Lime, isBold: true, NextLine: true);
									if (File.Exists(text))
									{
										File.Delete(text);
									}
								}
								else
								{
									UiManager.Richlogs("Failed", Color.Red);
								}
							}
						}
						else
						{
							FIREHOSE_MANAGER.EncryptedDownloadData = FIREHOSE_MANAGER.getfile(attribute15, pbar: true);
							if (FIREHOSE_MANAGER.EncryptedDownloadData.Length > 0)
							{
								UiManager.Richlogs("Downloading data : ", Color.Black, isBold: false);
								UiManager.Richlogs("Initialized Data " + UiManager.GetFileSizes(FIREHOSE_MANAGER.EncryptedDownloadData.Length) + " ", Color.MediumSlateBlue, isBold: false);
								UiManager.Richlogs("OK\n", Color.DarkOrange, isBold: false, NextLine: true);
								if (!FIREHOSE_PARTITIONS.WritePartition(attribute13, attribute14, attribute16, attribute17, ref label2, attribute15))
								{
									UiManager.Richlogs("Failed", Color.Red);
									return false;
								}
								UiManager.Richlogs("OK", Color.Lime, isBold: true, NextLine: true);
							}
						}
						FIREHOSE_MANAGER.SelectedExecution = "";
						continue;
					}
					FIREHOSE_MANAGER.EncryptedDownloadData = FIREHOSE_MANAGER.getfile(attribute15, pbar: true);
					if (FIREHOSE_MANAGER.EncryptedDownloadData.Length > 0)
					{
						UiManager.Richlogs("Downloading data : ", Color.Black, isBold: false);
						UiManager.Richlogs("Initialized Data " + UiManager.GetFileSizes(FIREHOSE_MANAGER.EncryptedDownloadData.Length) + " ", Color.MediumSlateBlue, isBold: false);
						UiManager.Richlogs("OK\n", Color.DarkOrange, isBold: false, NextLine: true);
						if (!FIREHOSE_PARTITIONS.WritePartition(attribute13, attribute14, attribute16, attribute17, ref label2, attribute15))
						{
							UiManager.Richlogs("Failed", Color.Red);
							return false;
						}
						UiManager.Richlogs("OK", Color.Lime, isBold: true, NextLine: true);
					}
					continue;
				}
				return true;
			}
			goto IL_0b24;
		}
		IL_0b24:
		bool result = default(bool);
		return result;
	}

	public static bool Process_Patch(string patch, ref string label)
	{
		if (!patch.Contains("<?xml version = \"1.0\"?>"))
		{
			patch = $"<?xml version = \"1.0\"?><data>{patch}</data>";
		}
		long num = 0L;
		long num2 = 0L;
		checked
		{
			XmlTextReader xmlTextReader;
			if (patch.ToLower().Contains("patch"))
			{
				xmlTextReader = new XmlTextReader(new StringReader(patch));
				while (xmlTextReader.Read())
				{
					if (Operators.CompareString(EDL.cancel, "Cancel", TextCompare: false) != 0)
					{
						if (xmlTextReader.NodeType == XmlNodeType.Element && Operators.CompareString(xmlTextReader.Name, "patch", TextCompare: false) == 0 && xmlTextReader.GetAttribute("filename").ToLower().Contains("disk"))
						{
							num++;
						}
						continue;
					}
					goto IL_01a4;
				}
			}
			xmlTextReader = new XmlTextReader(new StringReader(patch));
			while (true)
			{
				if (xmlTextReader.Read())
				{
					if (Operators.CompareString(EDL.cancel, "Cancel", TextCompare: false) == 0)
					{
						break;
					}
					if (xmlTextReader.NodeType != XmlNodeType.Element || Operators.CompareString(xmlTextReader.Name, "patch", TextCompare: false) != 0)
					{
						continue;
					}
					string attribute = xmlTextReader.GetAttribute("SECTOR_SIZE_IN_BYTES");
					string attribute2 = xmlTextReader.GetAttribute("byte_offset");
					string attribute3 = xmlTextReader.GetAttribute("filename");
					string attribute4 = xmlTextReader.GetAttribute("physical_partition_number");
					string attribute5 = xmlTextReader.GetAttribute("size_in_bytes");
					string attribute6 = xmlTextReader.GetAttribute("start_sector");
					string attribute7 = xmlTextReader.GetAttribute("value");
					string attribute8 = xmlTextReader.GetAttribute("what");
					if (attribute3.ToLower().Contains("disk"))
					{
						string xml = FIREHOSE.pkt_patch(attribute, attribute2, attribute3, attribute4, attribute5, attribute6, attribute7, attribute8);
						num2++;
						FIREHOSE_PACKET.SendXmlFast(xml);
						UiManager.ProcessBar1(num2, num);
						if (num2 == num)
						{
							UiManager.ProcessBar1(num, num);
							FIREHOSE_MANAGER.RefreshDisk();
							return true;
						}
					}
					continue;
				}
				return false;
			}
			goto IL_01a4;
		}
		IL_01a4:
		bool result = default(bool);
		return result;
	}

	public static bool Process_Wipe_Userdata()
	{
		if (!string.IsNullOrEmpty(FIREHOSE_MANAGER.StringXml))
		{
			XmlTextReader xmlTextReader = new XmlTextReader(new StringReader(FIREHOSE_MANAGER.StringXml));
			SerialCOM.MSL = "ENREAD";
			UiManager.ProcessBar2(0L, 100L);
			while (true)
			{
				if (xmlTextReader.Read())
				{
					if (Operators.CompareString(EDL.cancel, "Cancel", TextCompare: false) == 0)
					{
						break;
					}
					if (xmlTextReader.NodeType == XmlNodeType.Element && Operators.CompareString(xmlTextReader.Name, "program", TextCompare: false) == 0)
					{
						FIREHOSE_MANAGER.SECTOR_SIZE_IN_BYTES = xmlTextReader.GetAttribute("SECTOR_SIZE_IN_BYTES");
						string attribute = xmlTextReader.GetAttribute("num_partition_sectors");
						string label = xmlTextReader.GetAttribute("label");
						xmlTextReader.GetAttribute("filename");
						string filename = Application.StartupPath + "\\tmp\\0.bin";
						string attribute2 = xmlTextReader.GetAttribute("physical_partition_number");
						string attribute3 = xmlTextReader.GetAttribute("start_sector");
						if (!FIREHOSE_PARTITIONS.Write_misc(FIREHOSE_MANAGER.SECTOR_SIZE_IN_BYTES, attribute, attribute2, attribute3, ref label, filename))
						{
							return false;
						}
					}
					continue;
				}
				UiManager.ProcessBar2(0L, 100L);
				SerialCOM.MSL = "DISREAD";
				return true;
			}
		}
		bool result = default(bool);
		return result;
	}

	public static bool Process_Erase_FRP()
	{
		bool flag = false;
		if (FIREHOSE_GPT.GPT_PartitionName.Items.Count > 0)
		{
			flag = true;
		}
		else
		{
			FIREHOSE_GPT.Clear_GPT();
			flag = FIREHOSE_GPT.GPT_Reader(silent: true);
		}
		checked
		{
			if (flag)
			{
				bool flag2 = false;
				string num_partition_sector = "";
				string physical_partition_number = "";
				string start_sector = "";
				string label = "";
				string filename = "";
				bool flag3 = false;
				string num_partition_sector2 = "";
				string physical_partition_number2 = "";
				string start_sector2 = "";
				string label2 = "";
				string filename2 = "";
				bool flag4 = false;
				string num_partition_sector3 = "";
				string physical_partition_number3 = "";
				string start_sector3 = "";
				string label3 = "";
				string filename3 = "";
				int num = FIREHOSE_GPT.GPT_PartitionName.Items.Count - 1;
				for (int i = 0; i <= num; i++)
				{
					if (Operators.CompareString(FIREHOSE_GPT.GPT_PartitionName.Items[i].ToString(), "frp", TextCompare: false) == 0)
					{
						num_partition_sector = (long.Parse(FIREHOSE_GPT.GPT_LastSector.Items[i].ToString()) - long.Parse(FIREHOSE_GPT.GPT_StartSector.Items[i].ToString()) + 1).ToString();
						physical_partition_number = FIREHOSE_GPT.GPT_PhysicalPartition.Items[i].ToString();
						start_sector = FIREHOSE_GPT.GPT_StartSector.Items[i].ToString();
						label = FIREHOSE_GPT.GPT_PartitionName.Items[i].ToString();
						filename = Application.StartupPath + "\\Data\\Reset\\frp.bin";
					}
					if (Operators.CompareString(FIREHOSE_GPT.GPT_PartitionName.Items[i].ToString(), "config", TextCompare: false) == 0)
					{
						num_partition_sector2 = (long.Parse(FIREHOSE_GPT.GPT_LastSector.Items[i].ToString()) - long.Parse(FIREHOSE_GPT.GPT_StartSector.Items[i].ToString()) + 1).ToString();
						physical_partition_number2 = FIREHOSE_GPT.GPT_PhysicalPartition.Items[i].ToString();
						start_sector2 = FIREHOSE_GPT.GPT_StartSector.Items[i].ToString();
						label2 = FIREHOSE_GPT.GPT_PartitionName.Items[i].ToString();
						filename2 = Application.StartupPath + "\\Data\\Reset\\frp.bin";
					}
					if (Operators.CompareString(FIREHOSE_GPT.GPT_PartitionName.Items[i].ToString(), "persistent", TextCompare: false) == 0)
					{
						num_partition_sector3 = (long.Parse(FIREHOSE_GPT.GPT_LastSector.Items[i].ToString()) - long.Parse(FIREHOSE_GPT.GPT_StartSector.Items[i].ToString()) + 1).ToString();
						physical_partition_number3 = FIREHOSE_GPT.GPT_PhysicalPartition.Items[i].ToString();
						start_sector3 = FIREHOSE_GPT.GPT_StartSector.Items[i].ToString();
						label3 = FIREHOSE_GPT.GPT_PartitionName.Items[i].ToString();
						filename3 = Application.StartupPath + "\\Data\\Reset\\persistent.bin";
					}
				}
				if (flag2)
				{
					return FIREHOSE_PARTITIONS.WritePartition(FIREHOSE_MANAGER.SECTOR_SIZE_IN_BYTES, num_partition_sector, physical_partition_number, start_sector, ref label, filename, silent: true);
				}
				if (flag3)
				{
					return FIREHOSE_PARTITIONS.WritePartition(FIREHOSE_MANAGER.SECTOR_SIZE_IN_BYTES, num_partition_sector2, physical_partition_number2, start_sector2, ref label2, filename2, silent: true);
				}
				if (flag4)
				{
					return FIREHOSE_PARTITIONS.WritePartition(FIREHOSE_MANAGER.SECTOR_SIZE_IN_BYTES, num_partition_sector3, physical_partition_number3, start_sector3, ref label3, filename3, silent: true);
				}
				return false;
			}
			return false;
		}
	}
}
