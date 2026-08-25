using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.FileIO;
using motoulocked.My;

namespace motoulocked.motoulocked;

public class Android_Qualcomm
{
	public static void Android_Info_Init()
	{
		AndroidKill();
		Task.Run([SpecialName] () =>
		{
			ProcessStartInfo startInfo = new ProcessStartInfo
			{
				FileName = Form1.String_9 + "bin\\Tunlocker Tool.exe",
				Arguments = "/c \"" + sourcefile.clean + "\"",
				RedirectStandardOutput = true,
				RedirectStandardError = true,
				UseShellExecute = false,
				CreateNoWindow = true
			};
			Process process = new Process();
			process.StartInfo = startInfo;
			process.Start();
			process.StandardOutput.ReadToEnd();
			process.StandardError.ReadToEnd();
			process.WaitForExit();
			if (Directory.Exists(sourcefile.Andoidpath + "\\ramdisk"))
			{
				DirectoryInfo directoryInfo = new DirectoryInfo(sourcefile.Andoidpath + "\\ramdisk");
				foreach (FileInfo item in directoryInfo.EnumerateFiles())
				{
					item.Delete();
				}
				foreach (DirectoryInfo item2 in directoryInfo.EnumerateDirectories())
				{
					item2.Delete(recursive: true);
				}
				directoryInfo.Delete(recursive: true);
			}
			if (Directory.Exists(sourcefile.Andoidpath + "\\split_img"))
			{
				DirectoryInfo directoryInfo2 = new DirectoryInfo(sourcefile.Andoidpath + "\\split_img");
				foreach (FileInfo item3 in directoryInfo2.EnumerateFiles())
				{
					item3.Delete();
				}
				foreach (DirectoryInfo item4 in directoryInfo2.EnumerateDirectories())
				{
					item4.Delete(recursive: true);
				}
				directoryInfo2.Delete(recursive: true);
			}
		});
	}

	public static void Prepare_ReadInfoIMG()
	{
		AndroidKill();
		if (File.Exists(sourcefile.Andoidpath))
		{
			Android_Info_Init();
			if (File.Exists(sourcefile.Dumped))
			{
				File.Delete(sourcefile.Dumped);
			}
		}
	}

	public static bool ReadInfoIMG()
	{
		if (File.Exists(sourcefile.Dumped))
		{
			if (ImageUnpackInfo(Path.GetFileName(sourcefile.Dumped), Path.GetDirectoryName(sourcefile.Andoidpath) + "\\initrd\\"))
			{
				AndroidKill();
				Android_Info_Init();
				if (File.Exists(sourcefile.Dumped))
				{
					File.Delete(sourcefile.Dumped);
				}
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
				return true;
			}
			AndroidKill();
			Android_Info_Init();
			if (File.Exists(sourcefile.Dumped))
			{
				File.Delete(sourcefile.Dumped);
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
			return false;
		}
		bool result = default(bool);
		return result;
	}

	private static bool ImageUnpackInfo(string cmd, string path)
	{
		bool flag = false;
		string empty = string.Empty;
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.FileName = Form1.String_9 + "bin\\Tunlocker Tool.exe";
		processStartInfo.Arguments = "/c \"" + sourcefile.Andoidpath + "\"";
		processStartInfo.RedirectStandardOutput = true;
		processStartInfo.RedirectStandardError = true;
		processStartInfo.UseShellExecute = false;
		processStartInfo.CreateNoWindow = true;
		Process process = new Process();
		process.StartInfo = processStartInfo;
		process.Start();
		process.StandardOutput.ReadToEnd();
		process.StandardError.ReadToEnd();
		process.WaitForExit();
		path = sourcefile.Directorypath + "\\ramdisk";
		string text = string.Empty;
		checked
		{
			if (File.Exists(path + "\\system\\build.prop"))
			{
				empty = path + "\\system\\build.prop";
				string[] array = File.ReadAllLines(empty);
				int num = array.Length - 1;
				for (int i = 0; i <= num; i++)
				{
					if (array[i].Contains("#"))
					{
						text += File.ReadAllText(empty);
						flag = true;
						break;
					}
				}
			}
			if (File.Exists(path + "\\vendor\\build.prop"))
			{
				empty = path + "\\vendor\\build.prop";
				string[] array2 = File.ReadAllLines(empty);
				int num2 = array2.Length - 1;
				for (int j = 0; j <= num2; j++)
				{
					if (array2[j].Contains("#"))
					{
						text += File.ReadAllText(empty);
						flag = true;
						break;
					}
				}
			}
			if (File.Exists(path + "\\prop.default"))
			{
				empty = path + "\\prop.default";
				string[] array3 = File.ReadAllLines(empty);
				int num3 = array3.Length - 1;
				for (int k = 0; k <= num3; k++)
				{
					if (array3[k].Contains("#"))
					{
						text += File.ReadAllText(empty);
						flag = true;
						break;
					}
				}
			}
			if (File.Exists(path + "\\default.prop"))
			{
				empty = path + "\\default.prop";
				string[] array4 = File.ReadAllLines(empty);
				int num4 = array4.Length - 1;
				for (int l = 0; l <= num4; l++)
				{
					if (array4[l].Contains("#"))
					{
						text += File.ReadAllText(empty);
						flag = true;
						break;
					}
				}
			}
			File.WriteAllText(Application.StartupPath + "\\tmp\\temp\\logs.txt", text);
			empty = Application.StartupPath + "\\tmp\\temp\\logs.txt";
			if (flag)
			{
				if (ParseProps(File.ReadAllBytes(empty)))
				{
					if (File.Exists(empty))
					{
						File.Delete(empty);
					}
					Android_Info_Init();
					return true;
				}
				if (File.Exists(empty))
				{
					File.Delete(empty);
				}
				Android_Info_Init();
				return false;
			}
			if (File.Exists(empty))
			{
				File.Delete(empty);
			}
			Android_Info_Init();
			return false;
		}
	}

	public static bool ParseProps(byte[] data)
	{
		bool result = false;
		string text = string.Empty;
		_ = string.Empty;
		string text2 = string.Empty;
		_ = string.Empty;
		_ = string.Empty;
		string text3 = string.Empty;
		string text4 = string.Empty;
		string text5 = string.Empty;
		string text6 = string.Empty;
		string text7 = string.Empty;
		string text8 = string.Empty;
		string text9 = string.Empty;
		string text10 = string.Empty;
		UiManager.Richlogs("OK", Color.Lime, isBold: true, NextLine: true);
		UiManager.Richlogs("- Read Build Prop Info : ", Color.Black, isBold: false);
		checked
		{
			using (MemoryStream stream = new MemoryStream(data))
			{
				using StreamReader streamReader = new StreamReader(stream);
				string text11 = null;
				while (streamReader.Peek() >= 0)
				{
					text11 = streamReader.ReadLine();
					if (text11.Contains("ro.product.manufacturer="))
					{
						text2 = text11.Substring(text11.IndexOf("=") + 1);
					}
					if (text11.Contains("ro.dolby.manufacturer="))
					{
						text2 = text11.Substring(text11.IndexOf("=") + 1);
					}
					if (text11.Contains("ro.product.vendor.manufacturer="))
					{
						text2 = text11.Substring(text11.IndexOf("=") + 1);
					}
					if (text11.Contains("ro.product.brand="))
					{
						text3 = text11.Substring(text11.IndexOf("=") + 1);
					}
					if (text11.Contains("ro.dolby.brand="))
					{
						text3 = text11.Substring(text11.IndexOf("=") + 1);
					}
					if (text11.Contains("ro.product.vendor.brand="))
					{
						text3 = text11.Substring(text11.IndexOf("=") + 1);
					}
					if (text11.Contains("ro.product.name="))
					{
						text11.Substring(text11.IndexOf("=") + 1);
					}
					if (text11.Contains("ro.product.vendor.name="))
					{
						text11.Substring(text11.IndexOf("=") + 1);
					}
					if (text11.Contains("ro.dolby.name="))
					{
						text11.Substring(text11.IndexOf("=") + 1);
					}
					if (text11.Contains("ro.product.model="))
					{
						text4 = text11.Substring(text11.IndexOf("=") + 1);
					}
					if (text11.Contains("ro.product.vendor.model="))
					{
						text4 = text11.Substring(text11.IndexOf("=") + 1);
					}
					if (text11.Contains("ro.dolby.model="))
					{
						text4 = text11.Substring(text11.IndexOf("=") + 1).Replace("effectmodel", string.Empty);
					}
					if (text11.Contains("ro.build.version.release=") | text11.Contains("ro.vendor.build.version.release="))
					{
						text6 = AndroidCommands.AndroidName(text11.Replace("ro.build.version.release=", string.Empty).Replace("ro.vendor.build.version.release=", string.Empty));
					}
					if (text11.Contains("ro.mediatek.version.release="))
					{
						text7 = text11.Substring(text11.IndexOf("=") + 1);
					}
					if (text11.Contains("ro.build.id=") | text11.Contains("ro.vendor.build.id="))
					{
						text5 = text11.Replace("ro.build.id=", string.Empty).Replace("ro.vendor.build.id=", string.Empty);
					}
					if (text11.Contains("ro.build.version.security_patch=") | text11.Contains("ro.vendor.build.security_patch="))
					{
						text9 = text11.Replace("ro.build.version.security_patch=", string.Empty).Replace("ro.vendor.build.security_patch=", string.Empty);
					}
					if (text11.Contains("ro.product.board="))
					{
						text11.Substring(text11.IndexOf("=") + 1);
					}
					if (text11.Contains("ro.build.description="))
					{
						text10 = text11.Substring(text11.IndexOf("=") + 1).Replace("release-keys", string.Empty);
					}
					if (text11.Contains("ro.bootimage.build.date=") | text11.Contains("ro.build.date="))
					{
						text8 = text11.Substring(text11.IndexOf("=") + 1);
					}
					text11.Contains("ro.oppo.market.name=");
					if (text11.Contains("ro.mediatek.platform=") | text11.Contains("ro.vendor.mediatek.platform="))
					{
						text = text11.Replace("ro.mediatek.platform=", string.Empty).Replace("release-keys", string.Empty).Replace("ro.vendor.mediatek.platform=", string.Empty);
						text = text.ToLower().Replace("qcom", "Qualcomm SnapDragon( QLM ) ").Replace("mt", "MT")
							.Replace("sc", "SpreadTrum( SPD ) SP")
							.Replace("sp", "SpreadTrum( SPD ) SP")
							.Replace("samsungexynos", "Samsung Exynos ")
							.Replace("hi", "( HiSilicon Kirin ) ")
							.Replace("m7cdug", "Qualcomm SnapDragon( QLM )");
					}
					if (text11.Contains("ro.product.cpu.abi="))
					{
						text11.Substring(text11.IndexOf("=") + 1);
					}
				}
				UiManager.Richlogs("OK", Color.FromArgb(21, 87, 255), isBold: true, NextLine: true);
				if (!string.IsNullOrEmpty(text))
				{
					UiManager.Richlogs("- Platform : ", Color.Black, isBold: false);
					UiManager.Richlogs(text.ToUpper(), Color.Lime, isBold: true, NextLine: true);
					result = true;
				}
				if (!string.IsNullOrEmpty(text2))
				{
					UiManager.Richlogs("- Manufacturer : ", Color.Black, isBold: false);
					if (text2.ToLower().Contains("unknown"))
					{
						if (Encoding.UTF8.GetString(data).ToLower().Contains("huawei"))
						{
							text2 = "Huawei";
						}
						if (Encoding.UTF8.GetString(data).ToLower().Contains("samsung"))
						{
							text2 = "Samsung";
						}
						if (Encoding.UTF8.GetString(data).ToLower().Contains("xiaomi"))
						{
							text2 = "Xiaomi";
						}
						if (Encoding.UTF8.GetString(data).ToLower().Contains("zte"))
						{
							text2 = "ZTE";
						}
					}
					UiManager.Richlogs(text2.ToUpper(), Color.Lime, isBold: true, NextLine: true);
					device_info.Brand = text2;
					result = true;
				}
				if (!string.IsNullOrEmpty(text3))
				{
					UiManager.Richlogs("- Brand : ", Color.Black, isBold: false);
					UiManager.Richlogs(text3, Color.Lime, isBold: true, NextLine: true);
					device_info.Brand = text3;
					result = true;
				}
				if (!string.IsNullOrEmpty(text4))
				{
					UiManager.Richlogs("- Phone Model : ", Color.Black, isBold: false);
					UiManager.Richlogs(text4, Color.Lime, isBold: true, NextLine: true);
					device_info.model = text4;
					result = true;
				}
				if (!string.IsNullOrEmpty(text5))
				{
					UiManager.Richlogs("- Build ID : ", Color.Black, isBold: false);
					UiManager.Richlogs(text5, Color.Lime, isBold: true, NextLine: true);
					device_info.secunumber = text5;
					result = true;
				}
				if (!string.IsNullOrEmpty(text6))
				{
					UiManager.Richlogs("- Android Version : ", Color.Black, isBold: false);
					UiManager.Richlogs(text6, Color.Lime, isBold: true, NextLine: true);
					device_info.Android = text6;
					result = true;
				}
				if (!string.IsNullOrEmpty(text7))
				{
					UiManager.Richlogs("- Build Number : ", Color.Black, isBold: false);
					UiManager.Richlogs(text7, Color.Lime, isBold: true, NextLine: true);
					result = true;
				}
				if (!string.IsNullOrEmpty(text8))
				{
					UiManager.Richlogs("- Build Date : ", Color.Black, isBold: false);
					UiManager.Richlogs(text8, Color.Lime, isBold: true, NextLine: true);
					result = true;
				}
				if (Operators.CompareString(text9, "", TextCompare: false) != 0)
				{
					UiManager.Richlogs("- Security Patch : ", Color.Black, isBold: false);
					UiManager.Richlogs(text9, Color.Lime, isBold: true, NextLine: true);
					device_info.security_patch = text9;
					result = true;
				}
				if (!string.IsNullOrEmpty(text10))
				{
					UiManager.Richlogs("- Description : ", Color.Black, isBold: false);
					if (text10.Length > 44)
					{
						UiManager.Richlogs(text10.Substring(0, 43), Color.Lime, isBold: true, NextLine: true);
					}
					else
					{
						UiManager.Richlogs(text10, Color.Lime, isBold: true, NextLine: true);
					}
					result = true;
				}
			}
			return result;
		}
	}

	public static void AndroidKill(bool silent = true)
	{
		string[] array = new string[34]
		{
			"blobpack.exe", "blobunpack.exe", "bzip2.exe", "cat.exe", "chmod.exe", "cpio.exe", "cut.exe", "dd.exe", "dhtbsign.exe", "dumpimage.exe",
			"elftool.exe", "files.exe", "find.exe", "futility.exe", "gzip.exe", "hexdump.exe", "loki_tool.exe", "lz4.exe", "lzop.exe", "mboot.exe",
			"mkbootimg.exe", "mkimage.exe", "mkmtkhdr.exe", "printf.exe", "pxa-mkbootimg.exe", "pxa-unpackbootimg.exe", "rkcrc.exe", "sony_dump.exe", "sudo.exe", "tail.exe",
			"truncate.exe", "unpackbootimg.exe", "unpackelf.exe", "xz.exe"
		};
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
