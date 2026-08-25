using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace motoulocked.motoulocked;

[StandardModule]
public sealed class FIREHOSE_MANAGER
{
	public static DiskWriter diskWriter { get; set; }

	public static string PatchString { get; set; }

	public static string SelectedExecution { get; set; } = "";


	public static string StringXml { get; set; }

	public static string SECTOR_SIZE_IN_BYTES { get; set; } = "512";


	public static string TypeMemory { get; set; } = "auto";


	public static string typeterpilih { get; set; } = "";


	public static string modelterpilih { get; set; } = "";


	public static ComboBox gettypehpnya { get; set; }

	public static byte[] EncryptedDownloadData { get; set; }

	public static string foldersave { get; set; } = "";


	public static int totalchecked { get; set; }

	public static byte[] FilesOneClick { get; set; }

	public static string MerkTerpilih { get; set; }

	public static byte[] OutDecripted { get; set; }

	public static Button BtnMerk { get; set; } = new Button();


	public static Button buttontype { get; set; }

	public static Button buttontypehp { get; set; }

	public static Button eksekusiButton { get; set; }

	public static string Namafilenya { get; set; }

	public static bool isFirehoseReady { get; set; } = false;


	public static bool isFirehoseHasDoAuth { get; set; } = false;


	public static string Partition_Name { get; set; }

	public static bool SetBoot { get; set; } = false;


	public static bool isShowListGPT { get; set; } = true;


	public static int LogLevel { get; set; } = 1;


	public static string MaxPayloadSizeToTargetInBytes { get; set; } = "8192";


	public static string maxPayloadSizeFromTargetInBytes { get; set; } = "2048";


	public static bool isEDLUnlockAutoReboot { get; set; } = false;


	public static bool isNewUFS { get; set; }

	public static BackgroundWorker FirehoseWorker { get; set; } = new BackgroundWorker
	{
		WorkerSupportsCancellation = true,
		WorkerReportsProgress = true
	};


	public static void RefreshDisk()
	{
		if (Operators.CompareString(EDL.cancel, "Cancel", TextCompare: false) != 0)
		{
			Thread.Sleep(100);
			DiskWriter.Closeport();
			Thread.Sleep(100);
			if (!DiskWriter.Openport("\\\\.\\COM" + Conversions.ToString(PortIOMe.PortCOM)))
			{
				UiManager.Richlogs("Failed USB Read Write", Color.Red, isBold: true, NextLine: true);
			}
		}
	}

	public static bool ConnectToFlashLoader()
	{
		bool result = default(bool);
		try
		{
			if (Form1.SharedUI.RichTextBox1.Text.Contains("Cencel By User") | Form1.SharedUI.RichTextBox1.Text.Contains("error["))
			{
				result = false;
			}
			else if (!DiskWriter.Openport("\\\\.\\COM" + Conversions.ToString(PortIOMe.PortCOM)))
			{
				UiManager.Richlogs("Failed", Color.Red, isBold: true, NextLine: true);
				result = false;
			}
			else
			{
				UiManager.Richlogs("- Analyzing Data Device : ", Color.Black, isBold: false);
				Form1.SharedUI.ProgressBar1.Text = "Analyzing...";
				FIREHOSE_CONFIG.sending_config();
				if (Operators.CompareString(EDL.cancel, "Cancel", TextCompare: false) == 0)
				{
					result = false;
				}
				else if (!isFirehoseReady)
				{
					if (!isFirehoseHasDoAuth)
					{
						UiManager.Richlogs("Failed", Color.Red, isBold: false);
						result = false;
					}
					else
					{
						UiManager.Richlogs("Failed", Color.Red, isBold: false);
						result = false;
					}
				}
				else
				{
					FIREHOSE_CONFIG.Storage_Configuration();
					if (Operators.CompareString(EDL.cancel, "Cancel", TextCompare: false) == 0)
					{
						result = false;
					}
					else
					{
						FIREHOSE_OPERATIONS.Prepare_Manual();
						if (FIREHOSE_OPERATIONS.MenuMan == FIREHOSE_OPERATIONS.MenuManual.readgpt_flash || FIREHOSE_OPERATIONS.MenuMan == FIREHOSE_OPERATIONS.MenuManual.readgpt_erase_user || FIREHOSE_OPERATIONS.MenuMan == FIREHOSE_OPERATIONS.MenuManual.readgpt_erase_id || FIREHOSE_OPERATIONS.MenuMan == FIREHOSE_OPERATIONS.MenuManual.readgpt_erase || FIREHOSE_OPERATIONS.MenuMan == FIREHOSE_OPERATIONS.MenuManual.readgpt_erase_patch || FIREHOSE_OPERATIONS.MenuMan == FIREHOSE_OPERATIONS.MenuManual.readgpt_read || FIREHOSE_OPERATIONS.MenuMan == FIREHOSE_OPERATIONS.MenuManual.readgpt_readinfo || FIREHOSE_OPERATIONS.MenuMan == FIREHOSE_OPERATIONS.MenuManual.readgpt_clean_mi || FIREHOSE_OPERATIONS.MenuMan == FIREHOSE_OPERATIONS.MenuManual.readgpt_patch_kg || FIREHOSE_OPERATIONS.MenuMan == FIREHOSE_OPERATIONS.MenuManual.readgpt_patch_mi)
						{
							result = true;
						}
						else if (Operators.CompareString(EDL.cancel, "Cancel", TextCompare: false) == 0)
						{
							result = false;
						}
						else if (!isFirehoseReady)
						{
							UiManager.Richlogs("Failed", Color.Red, isBold: false);
							result = false;
						}
						else if (FIREHOSE_OPERATIONS.MenuEx == FIREHOSE_OPERATIONS.MenuEksekusi.manual)
						{
							if (FIREHOSE_OPERATIONS.MenuMan == FIREHOSE_OPERATIONS.MenuManual.ident)
							{
								FIREHOSE_OPERATIONS.Process_Identify();
								result = true;
							}
							else if (FIREHOSE_OPERATIONS.MenuMan == FIREHOSE_OPERATIONS.MenuManual.flash)
							{
								FIREHOSE_OPERATIONS.Process_Flash();
								if (EDL.SharedEDL.cbreboot.Checked)
								{
									FIREHOSE_OPERATIONS.Process_Reboot();
								}
								result = true;
							}
							else if (FIREHOSE_OPERATIONS.MenuMan == FIREHOSE_OPERATIONS.MenuManual.read)
							{
								FIREHOSE_OPERATIONS.Process_Read();
								if (EDL.SharedEDL.cbreboot.Checked)
								{
									FIREHOSE_OPERATIONS.Process_Reboot();
								}
								result = true;
							}
							else if (FIREHOSE_OPERATIONS.MenuMan == FIREHOSE_OPERATIONS.MenuManual.erase)
							{
								FIREHOSE_OPERATIONS.Process_Erase_PART();
								if (EDL.SharedEDL.cbreboot.Checked)
								{
									FIREHOSE_OPERATIONS.Process_Reboot();
								}
								result = true;
							}
							else if (FIREHOSE_OPERATIONS.MenuMan == FIREHOSE_OPERATIONS.MenuManual.patch)
							{
								if (EDL.SharedEDL.cbreboot.Checked)
								{
									FIREHOSE_OPERATIONS.Process_Reboot();
								}
								result = true;
							}
						}
						else if (FIREHOSE_OPERATIONS.MenuEx == FIREHOSE_OPERATIONS.MenuEksekusi.oneclick)
						{
							FIREHOSE_OPERATIONS.Process_OneClick();
							if (EDL.SharedEDL.cbreboot.Checked)
							{
								FIREHOSE_OPERATIONS.Process_Reboot();
							}
							result = true;
						}
					}
				}
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			UiManager.Richlogs("Failed", Color.Red, isBold: false);
			result = false;
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public static void Identify(object sender, DoWorkEventArgs e)
	{
		if (FirehoseWorker.CancellationPending)
		{
			e.Cancel = true;
			return;
		}
		try
		{
			if (!isFirehoseReady)
			{
				UiManager.Richlogs("Failed", Color.Red, isBold: false);
			}
			else if (FIREHOSE_OPERATIONS.MenuEx == FIREHOSE_OPERATIONS.MenuEksekusi.manual)
			{
				if (FIREHOSE_OPERATIONS.MenuMan == FIREHOSE_OPERATIONS.MenuManual.ident)
				{
					FIREHOSE_OPERATIONS.Process_Identify();
				}
				else if (FIREHOSE_OPERATIONS.MenuMan == FIREHOSE_OPERATIONS.MenuManual.flash)
				{
					FIREHOSE_OPERATIONS.Process_Flash();
					if (EDL.SharedEDL.cbreboot.Checked)
					{
						FIREHOSE_OPERATIONS.Process_Reboot();
					}
				}
				else if (FIREHOSE_OPERATIONS.MenuMan == FIREHOSE_OPERATIONS.MenuManual.read)
				{
					FIREHOSE_OPERATIONS.Process_Read();
					if (EDL.SharedEDL.cbreboot.Checked)
					{
						FIREHOSE_OPERATIONS.Process_Reboot();
					}
				}
				else if (FIREHOSE_OPERATIONS.MenuMan == FIREHOSE_OPERATIONS.MenuManual.erase)
				{
					FIREHOSE_OPERATIONS.Process_Erase();
					if (isEDLUnlockAutoReboot)
					{
						FIREHOSE_OPERATIONS.Process_Reboot();
					}
				}
				else if (FIREHOSE_OPERATIONS.MenuMan == FIREHOSE_OPERATIONS.MenuManual.patch)
				{
					if (isEDLUnlockAutoReboot)
					{
						FIREHOSE_OPERATIONS.Process_Reboot();
					}
				}
				else if (FIREHOSE_OPERATIONS.MenuMan == FIREHOSE_OPERATIONS.MenuManual.reboot)
				{
					FIREHOSE_OPERATIONS.Process_Reboot();
				}
			}
			else if (FIREHOSE_OPERATIONS.MenuEx == FIREHOSE_OPERATIONS.MenuEksekusi.oneclick)
			{
				FIREHOSE_OPERATIONS.Process_OneClick();
				if (EDL.SharedEDL.cbreboot.Checked)
				{
					FIREHOSE_OPERATIONS.Process_Reboot();
				}
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			if (EDL.SharedEDL.cbreboot.Checked)
			{
				FIREHOSE_OPERATIONS.Process_Reboot();
			}
			UiManager.Richlogs("Failed", Color.Red, isBold: false);
			e.Cancel = true;
			ProjectData.ClearProjectError();
		}
	}

	public static byte[] getfile(string namafile, bool pbar)
	{
		byte[] array = null;
		Namafilenya = namafile;
		string text = Path.Combine(Application.StartupPath + "\\Data\\Devices\\" + MerkTerpilih + "\\" + typeterpilih + "\\" + namafile);
		Console.WriteLine(text);
		if (Namafilenya.Contains("loader"))
		{
			if (File.Exists(text))
			{
				SAHARA_MANAGER.Loader = File.ReadAllBytes(text);
				array = File.ReadAllBytes(text);
				SAHARA_MANAGER.IsAutoLoader = false;
			}
			else
			{
				SAHARA_MANAGER.Loader = new byte[0];
				array = new byte[0];
				SAHARA_MANAGER.IsAutoLoader = true;
			}
		}
		else if (Namafilenya.Contains(".xml") || Namafilenya.Contains(".XML"))
		{
			if (File.Exists(text))
			{
				StringXml = File.ReadAllText(text);
				array = Encoding.UTF8.GetBytes(StringXml);
			}
			else
			{
				StringXml += "<?xml version=\"1.0\" ?>\r\n";
				StringXml += "<data>\r\n";
				StringXml += "</data>";
				array = Encoding.UTF8.GetBytes(StringXml);
			}
		}
		else if (File.Exists(text))
		{
			FilesOneClick = File.ReadAllBytes(text);
			array = File.ReadAllBytes(text);
		}
		else
		{
			FilesOneClick = new byte[0];
			array = new byte[0];
		}
		return array;
	}

	public static bool RunFHCmd(string sector_size, string num_partition_sector, string physical_partition_number, string start_sector, ref string label, string filename, bool read = false)
	{
		UiManager.hide_writen_transfer();
		DiskWriter.Closeport();
		checked
		{
			if (FIREHOSE_OPERATIONS.MenuEx == FIREHOSE_OPERATIONS.MenuEksekusi.manual)
			{
				if (!read && !File.Exists(filename))
				{
					return false;
				}
				UiManager.label_totalsize(long.Parse(num_partition_sector) * long.Parse(sector_size));
			}
			else if (FIREHOSE_OPERATIONS.MenuEx == FIREHOSE_OPERATIONS.MenuEksekusi.oneclick)
			{
				filename = Application.StartupPath + "\\temp\\tmp.img";
				File.WriteAllBytes(filename, FilesOneClick);
				UiManager.label_totalsize(FilesOneClick.Length);
			}
			string text = "";
			string workingDirectory = "";
			if (read)
			{
				string text2 = $"--port=\\\\.\\COM{PortIOMe.PortCOM}" + " --convertprogram2read" + $" --search_path=\"{foldersave}\"" + $" --sendimage=\"{FIREHOSE_PARTITIONS.Get_Partition_Filenames(label)}\"" + $" --start_sector={start_sector}" + $" --lun={physical_partition_number}" + $" --num_sectors={num_partition_sector}" + " --noprompt --showpercentagecomplete --zlpawarehost=1" + $" --memoryname={TypeMemory}" + " --loglevel=2";
				text = text2;
				workingDirectory = foldersave;
			}
			else
			{
				UiManager.Richlogs("[" + physical_partition_number + "] Writing " + label + " -> " + Path.GetFileName(filename) + " [data]: ", Color.Black, isBold: false);
				string text3 = $"--port=\\\\.\\COM{PortIOMe.PortCOM}" + $" --search_path=\"{Path.GetDirectoryName(filename).TrimEnd('\\')}\"" + $" --sendimage=\"{filename}\"" + $" --start_sector={start_sector}" + $" --lun={physical_partition_number}" + $" --num_sectors={num_partition_sector}" + " --noprompt --showpercentagecomplete --zlpawarehost=1" + $" --memoryname={TypeMemory}" + " --loglevel=2";
				text = text3;
				workingDirectory = Path.GetDirectoryName(filename);
			}
			bool result = false;
			Task.Run([SpecialName] () =>
			{
				ProgressBar progressBar = new ProgressBar
				{
					Minimum = 0,
					Maximum = 100
				};
				int num = 0;
				int num2 = 0;
				int num3 = 0;
				using Process process = Process.Start(new ProcessStartInfo(Path.Combine(Application.StartupPath + "\\Data\\Process\fh_loader.exe"), text)
				{
					CreateNoWindow = true,
					WindowStyle = ProcessWindowStyle.Hidden,
					UseShellExecute = false,
					Verb = "runas",
					WorkingDirectory = workingDirectory,
					RedirectStandardError = true,
					RedirectStandardOutput = true
				});
				Console.WriteLine(text);
				process.BeginOutputReadLine();
				process.BeginErrorReadLine();
				int num4 = 0;
				long num5 = 0L;
				long num6 = 0L;
				process.OutputDataReceived += [SpecialName] (object sender, DataReceivedEventArgs e) =>
				{
					string text4 = e.Data ?? string.Empty;
					Console.WriteLine(text4);
					if (!string.IsNullOrEmpty(text4))
					{
						if (text4.Contains("FileSizeNumSectorsLeft"))
						{
							string pattern = "[^0-9]";
							string s = Regex.Replace(text4.Substring(text4.LastIndexOf(":")), pattern, string.Empty);
							num5 = (long)Math.Round((double)num5 + double.Parse(s));
							if (num4 == 0)
							{
								num6 = num5;
							}
							if (num5 > 0)
							{
								progressBar.Maximum = (int)num5;
								progressBar.Value = Convert.ToInt32(Math.Round((double)(num5 * 100) / (double)(long.Parse(num_partition_sector) * long.Parse(sector_size))));
							}
							else
							{
								progressBar.Maximum = 100;
								progressBar.Value = 0;
							}
							num2 = progressBar.Value;
							if (progressBar.Value > 0 && num < 99)
							{
								if (num2 < num3)
								{
									num++;
									Console.WriteLine(num);
									UiManager.ProcessBar1(num, 100L);
								}
								else if (num2 > num3)
								{
									num++;
									Console.WriteLine(num);
									UiManager.ProcessBar1(num, 100L);
								}
							}
							num3 = progressBar.Value;
							num4++;
						}
						else if (text4.Contains("percent files transferred"))
						{
							UiManager.ProcessBar1(int.Parse(text4.Replace("percent files transferred", "|").Split('|')[1].Trim().Split('.')[0].Trim()));
							Application.DoEvents();
						}
						else if (text4.Contains("{All Finished Successfully}"))
						{
							UiManager.ProcessBar1(100);
							result = true;
						}
					}
				};
				process.WaitForExit();
			}).Wait();
			DiskWriter.Openport("\\\\.\\COM" + Conversions.ToString(PortIOMe.PortCOM));
			return result;
		}
	}

	public static void FirehoseKill(bool silent = true)
	{
		if (!silent)
		{
			Console.WriteLine("");
			Console.WriteLine("Firehose Kill Called...");
			Console.WriteLine("");
		}
		string[] array = new string[2] { "fh_loader", "fh_loader.exe" };
		foreach (string text in array)
		{
			Process[] processes = Process.GetProcesses();
			foreach (Process process in processes)
			{
				if (Operators.CompareString(process.ProcessName.ToLower() ?? "", text.ToLower() ?? "", TextCompare: false) == 0)
				{
					process.Kill();
					process.WaitForExit();
					process.Dispose();
				}
			}
		}
	}
}
