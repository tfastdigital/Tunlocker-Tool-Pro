using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.VisualBasic.CompilerServices;
using Properties;

namespace motoulocked.mtkclient2;

public class android
{
	private class CSharpImpl
	{
		[Obsolete("Please refactor calling code to use normal Visual Basic assignment")]
		public static T Assign<T>(ref T target, T value)
		{
			target = value;
			return value;
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__4_002D0
	{
		public CancellationToken _0024VB_0024Local_cancelToken;

		public string _0024VB_0024Local_path;

		public string _0024VB_0024Local_FilePath;

		public bool _0024VB_0024Local_flag;

		public string _0024VB_0024Local_array2;

		public string _0024VB_0024Local_array5;

		public string _0024VB_0024Local_array4;

		public string _0024VB_0024Local_array6;

		public string _0024VB_0024Local_array8;

		public string _0024VB_0024Local_array7;

		public string _0024VB_0024Local_array11;

		public string _0024VB_0024Local_array12;

		public string _0024VB_0024Local_array10;

		public string _0024VB_0024Local_array;

		public string _0024VB_0024Local_array1;

		public string _0024VB_0024Local_array9;

		public _Closure_0024__4_002D0(_Closure_0024__4_002D0 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024Local_cancelToken = arg0._0024VB_0024Local_cancelToken;
				_0024VB_0024Local_path = arg0._0024VB_0024Local_path;
				_0024VB_0024Local_FilePath = arg0._0024VB_0024Local_FilePath;
				_0024VB_0024Local_flag = arg0._0024VB_0024Local_flag;
				_0024VB_0024Local_array2 = arg0._0024VB_0024Local_array2;
				_0024VB_0024Local_array5 = arg0._0024VB_0024Local_array5;
				_0024VB_0024Local_array4 = arg0._0024VB_0024Local_array4;
				_0024VB_0024Local_array6 = arg0._0024VB_0024Local_array6;
				_0024VB_0024Local_array8 = arg0._0024VB_0024Local_array8;
				_0024VB_0024Local_array7 = arg0._0024VB_0024Local_array7;
				_0024VB_0024Local_array11 = arg0._0024VB_0024Local_array11;
				_0024VB_0024Local_array12 = arg0._0024VB_0024Local_array12;
				_0024VB_0024Local_array10 = arg0._0024VB_0024Local_array10;
				_0024VB_0024Local_array = arg0._0024VB_0024Local_array;
				_0024VB_0024Local_array1 = arg0._0024VB_0024Local_array1;
				_0024VB_0024Local_array9 = arg0._0024VB_0024Local_array9;
			}
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__4_002D1
	{
		public long _0024VB_0024Local_t;

		public long _0024VB_0024Local_n;

		public _Closure_0024__4_002D0 _0024VB_0024NonLocal__0024VB_0024Closure_2;

		public _Closure_0024__4_002D1(_Closure_0024__4_002D1 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024Local_t = arg0._0024VB_0024Local_t;
				_0024VB_0024Local_n = arg0._0024VB_0024Local_n;
			}
		}

		[SpecialName]
		internal void _Lambda_0024__0(object sender, DataReceivedEventArgs e)
		{
			_0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_cancelToken.ThrowIfCancellationRequested();
			checked
			{
				if (File.Exists(_0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_path + "\\system\\build.prop"))
				{
					_0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_FilePath = _0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_path + "\\system\\build.prop";
					string[] array = File.ReadAllLines(_0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_FilePath);
					_0024VB_0024Local_t = array.Length;
					int num = array.Length - 1;
					for (int i = 0; i <= num; i++)
					{
						if (array[i].Contains("manufacturer="))
						{
							_0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_flag = true;
							break;
						}
					}
				}
				else if (File.Exists(_0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_path + "\\vendor\\build.prop"))
				{
					_0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_FilePath = _0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_path + "\\vendor\\build.prop";
					string[] array2 = File.ReadAllLines(_0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_FilePath);
					_0024VB_0024Local_t = array2.Length;
					int num2 = array2.Length - 1;
					for (int j = 0; j <= num2; j++)
					{
						if (array2[j].Contains("manufacturer="))
						{
							_0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_flag = true;
							break;
						}
					}
				}
				else if (File.Exists(_0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_path + "prop.default"))
				{
					_0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_FilePath = _0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_path + "prop.default";
					string[] array3 = File.ReadAllLines(_0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_FilePath);
					_0024VB_0024Local_t = array3.Length;
					int num3 = array3.Length - 1;
					for (int k = 0; k <= num3; k++)
					{
						if (array3[k].Contains("manufacturer="))
						{
							_0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_flag = true;
							break;
						}
					}
				}
				else if (File.Exists(_0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_path + "default.prop"))
				{
					_0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_FilePath = _0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_path + "default.prop";
					string[] array4 = File.ReadAllLines(_0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_FilePath);
					_0024VB_0024Local_t = array4.Length;
					int num4 = array4.Length - 1;
					for (int l = 0; l <= num4; l++)
					{
						if (array4[l].Contains("manufacturer="))
						{
							_0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_flag = true;
							break;
						}
					}
				}
				if (!_0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_flag)
				{
					return;
				}
				using StreamReader streamReader = new StreamReader(_0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_FilePath);
				string target = null;
				while (CSharpImpl.Assign(ref target, streamReader.ReadLine()) != null)
				{
					if (target.Contains("ro.product.manufacturer="))
					{
						_0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_array2 = target.Substring(target.IndexOf("=") + 1);
					}
					else if (target.Contains("ro.dolby.manufacturer="))
					{
						_0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_array2 = target.Substring(target.IndexOf("=") + 1);
					}
					else if (target.Contains("ro.product.vendor.manufacturer="))
					{
						_0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_array2 = target.Substring(target.IndexOf("=") + 1);
					}
					if (target.Contains("ro.product.brand="))
					{
						_0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_array5 = target.Substring(target.IndexOf("=") + 1);
					}
					else if (target.Contains("ro.dolby.brand="))
					{
						_0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_array5 = target.Substring(target.IndexOf("=") + 1);
					}
					else if (target.Contains("ro.product.vendor.brand="))
					{
						_0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_array5 = target.Substring(target.IndexOf("=") + 1);
					}
					if (target.Contains("ro.product.name="))
					{
						_0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_array4 = target.Substring(target.IndexOf("=") + 1);
					}
					else if (target.Contains("ro.product.vendor.name="))
					{
						_0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_array4 = target.Substring(target.IndexOf("=") + 1);
					}
					else if (target.Contains("ro.dolby.name="))
					{
						_0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_array4 = target.Substring(target.IndexOf("=") + 1);
					}
					if (target.Contains("ro.product.model="))
					{
						_0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_array6 = target.Substring(target.IndexOf("=") + 1);
					}
					else if (target.Contains("ro.product.vendor.model="))
					{
						_0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_array6 = target.Substring(target.IndexOf("=") + 1);
					}
					else if (target.Contains("ro.product.system.model="))
					{
						_0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_array6 = target.Substring(target.IndexOf("=") + 1);
					}
					if (target.Contains("ro.build.version.release=") | target.Contains("ro.vendor.build.version.release=") | target.Contains("ro.system.build.version.release="))
					{
						_0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_array8 = AndroidCommands.AndroidName(target.Replace("ro.build.version.release=", "").Replace("ro.vendor.build.version.release=", "").Replace("ro.system.build.version.release=", ""));
					}
					if (target.Contains("ro.build.id="))
					{
						_0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_array7 = target.Replace("ro.build.id=", "");
					}
					else if (target.Contains("ro.vendor.build.id="))
					{
						_0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_array7 = target.Replace("ro.vendor.build.id=", "");
					}
					if (target.Contains("ro.build.version.security_patch="))
					{
						_0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_array11 = target.Replace("ro.build.version.security_patch=", "");
					}
					else if (target.Contains("ro.vendor.build.security_patch="))
					{
						_0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_array11 = target.Replace("ro.vendor.build.security_patch=", "");
					}
					if (target.Contains("build.description="))
					{
						_0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_array12 = target.Substring(target.IndexOf("=") + 1).Replace("release-keys", "");
					}
					if (target.Contains("build.date="))
					{
						_0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_array10 = target.Substring(target.IndexOf("=") + 1);
					}
					else if (target.Contains("ro.build.date="))
					{
						_0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_array10 = target.Substring(target.IndexOf("=") + 1);
					}
					else if (target.Contains("ro.vendor.build.date="))
					{
						_0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_array10 = target.Substring(target.IndexOf("=") + 1);
					}
					if (target.Contains("ro.mediatek.platform=") | target.Contains("ro.vendor.mediatek.platform="))
					{
						_0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_array = target.Replace("ro.mediatek.platform=", "").Replace("release-keys", "").Replace("ro.vendor.mediatek.platform=", "");
						string text = _0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_array.ToLower();
						_0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_array = text.Replace("qcom", "Qualcomm SnapDragon( QLM ) ").Replace("mt", "MT").Replace("sc", "SpreadTrum( SPD ) SP")
							.Replace("sp", "SpreadTrum( SPD ) SP")
							.Replace("samsungexynos", "Samsung Exynos ")
							.Replace("hi", "( HiSilicon Kirin ) ")
							.Replace("m7cdug", "Qualcomm SnapDragon( QLM )");
					}
					if (target.Contains("ro.product.cpu.abi="))
					{
						_0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_array1 = target.Substring(target.IndexOf("=") + 1);
					}
					_0024VB_0024Local_n++;
					Form1.ProcessBar(_0024VB_0024Local_n, _0024VB_0024Local_t);
					target = streamReader.ReadLine();
				}
				gui.Richlog("OK", Color.Lime, isBold: false, NextLine: true);
				gui.Richlog("- Read Build Prop Info : ", Color.Black);
				gui.Richlog("OK", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
				if (Operators.CompareString(_0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_array2, "", TextCompare: false) != 0)
				{
					gui.Richlog("- Manufacturer : ", Color.Black);
					gui.Richlog(_0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_array2, Color.Green, isBold: false, NextLine: true);
				}
				if (Operators.CompareString(_0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_array5, "", TextCompare: false) != 0)
				{
					gui.Richlog("- Brand : ", Color.Black);
					gui.Richlog(_0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_array5, Color.Green, isBold: false, NextLine: true);
				}
				if (Operators.CompareString(_0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_array6, "", TextCompare: false) != 0)
				{
					gui.Richlog("- Phone Model : ", Color.Black);
					gui.Richlog(_0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_array6, Color.Green, isBold: false, NextLine: true);
				}
				if (Operators.CompareString(_0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_array8, "", TextCompare: false) != 0)
				{
					gui.Richlog("- Android Version : ", Color.Black);
					gui.Richlog(_0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_array8, Color.Green, isBold: false, NextLine: true);
				}
				if (Operators.CompareString(_0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_array7, "", TextCompare: false) != 0)
				{
					gui.Richlog("- Build id : ", Color.Black);
					gui.Richlog(_0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_array7, Color.Green, isBold: false, NextLine: true);
				}
				if (Operators.CompareString(_0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_array11, "", TextCompare: false) != 0)
				{
					gui.Richlog("- Security Patch : ", Color.Black);
					gui.Richlog(_0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_array11, Color.Green, isBold: false, NextLine: true);
				}
				if (Operators.CompareString(_0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_array9, "", TextCompare: false) != 0)
				{
					gui.Richlog("- Build Number : ", Color.Black);
					gui.Richlog(_0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_array9, Color.Green, isBold: false, NextLine: true);
				}
				if (Operators.CompareString(_0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_array10, "", TextCompare: false) != 0)
				{
					gui.Richlog("- Build Date : ", Color.Black);
					gui.Richlog(_0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_array10, Color.Green, isBold: false, NextLine: true);
				}
				if (Operators.CompareString(_0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_array12, "", TextCompare: false) != 0)
				{
					gui.Richlog("- Description : ", Color.Black);
					gui.Richlog(_0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_array12, Color.Green, isBold: false, NextLine: true);
				}
			}
		}
	}

	public static Task Prepare_ReadInfoIMG(CancellationToken cancelToken)
	{
		cancelToken.ThrowIfCancellationRequested();
		if (!File.Exists(sourcefile.AndroidPath))
		{
			Directory.CreateDirectory(Path.GetDirectoryName(sourcefile.AndroidPath));
			File.WriteAllBytes(sourcefile.AndroidPath, Resources.C4);
		}
		if (File.Exists(sourcefile.Dumped))
		{
			File.Delete(sourcefile.Dumped);
		}
		return Task.CompletedTask;
	}

	public static async Task ReadInfoIMG(CancellationToken cancelToken)
	{
		cancelToken.ThrowIfCancellationRequested();
		if (!File.Exists(sourcefile.Directorypath + "/boot.img"))
		{
			return;
		}
		await AndroidUnpack(Path.GetFileName(sourcefile.Dumped), Path.GetDirectoryName(sourcefile.AndroidPath) + "\\initrd\\", cancelToken);
		DirectoryInfo directoryInfo = new DirectoryInfo(Path.GetDirectoryName(sourcefile.AndroidPath));
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

	public static async Task AndroidUnpack(string path, string filepath, CancellationToken cancelToken)
	{
		await ImageUnpackInfo(string.Concat(new string[3] { "--unpack-bootimg", " ", path }), filepath, cancelToken);
	}

	public static Task ImageUnpackInfo(string cmd, string path, CancellationToken cancelToken)
	{
		_Closure_0024__4_002D0 arg = default(_Closure_0024__4_002D0);
		arg._0024VB_0024Local_path = path;
		arg._0024VB_0024Local_cancelToken = cancelToken;
		arg._0024VB_0024Local_cancelToken.ThrowIfCancellationRequested();
		arg._0024VB_0024Local_flag = false;
		arg._0024VB_0024Local_array = "";
		arg._0024VB_0024Local_array1 = "";
		arg._0024VB_0024Local_array2 = "";
		arg._0024VB_0024Local_array4 = "";
		arg._0024VB_0024Local_array5 = "";
		arg._0024VB_0024Local_array6 = "";
		arg._0024VB_0024Local_array7 = "";
		arg._0024VB_0024Local_array8 = "";
		arg._0024VB_0024Local_array9 = "";
		arg._0024VB_0024Local_array10 = "";
		arg._0024VB_0024Local_array11 = "";
		arg._0024VB_0024Local_array12 = "";
		arg._0024VB_0024Local_FilePath = string.Empty;
		using (Process process = Process.Start(new ProcessStartInfo(sourcefile.AndroidPath, cmd)
		{
			CreateNoWindow = true,
			WindowStyle = ProcessWindowStyle.Hidden,
			UseShellExecute = false,
			Verb = "runas",
			WorkingDirectory = Path.GetDirectoryName(sourcefile.AndroidPath),
			RedirectStandardError = true,
			RedirectStandardOutput = true
		}))
		{
			_Closure_0024__4_002D1 arg2 = default(_Closure_0024__4_002D1);
			_Closure_0024__4_002D1 CS_0024_003C_003E8__locals0 = new _Closure_0024__4_002D1(arg2);
			CS_0024_003C_003E8__locals0._0024VB_0024NonLocal__0024VB_0024Closure_2 = arg;
			Console.WriteLine(cmd);
			process.BeginOutputReadLine();
			process.BeginErrorReadLine();
			CS_0024_003C_003E8__locals0._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_cancelToken.ThrowIfCancellationRequested();
			CS_0024_003C_003E8__locals0._0024VB_0024Local_n = 0L;
			CS_0024_003C_003E8__locals0._0024VB_0024Local_t = 0L;
			process.OutputDataReceived += checked([SpecialName] (object sender, DataReceivedEventArgs e) =>
			{
				CS_0024_003C_003E8__locals0._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_cancelToken.ThrowIfCancellationRequested();
				if (File.Exists(CS_0024_003C_003E8__locals0._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_path + "\\system\\build.prop"))
				{
					CS_0024_003C_003E8__locals0._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_FilePath = CS_0024_003C_003E8__locals0._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_path + "\\system\\build.prop";
					string[] array = File.ReadAllLines(CS_0024_003C_003E8__locals0._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_FilePath);
					CS_0024_003C_003E8__locals0._0024VB_0024Local_t = array.Length;
					int num = array.Length - 1;
					for (int i = 0; i <= num; i++)
					{
						if (array[i].Contains("manufacturer="))
						{
							CS_0024_003C_003E8__locals0._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_flag = true;
							break;
						}
					}
				}
				else if (File.Exists(CS_0024_003C_003E8__locals0._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_path + "\\vendor\\build.prop"))
				{
					CS_0024_003C_003E8__locals0._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_FilePath = CS_0024_003C_003E8__locals0._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_path + "\\vendor\\build.prop";
					string[] array2 = File.ReadAllLines(CS_0024_003C_003E8__locals0._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_FilePath);
					CS_0024_003C_003E8__locals0._0024VB_0024Local_t = array2.Length;
					int num2 = array2.Length - 1;
					for (int j = 0; j <= num2; j++)
					{
						if (array2[j].Contains("manufacturer="))
						{
							CS_0024_003C_003E8__locals0._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_flag = true;
							break;
						}
					}
				}
				else if (File.Exists(CS_0024_003C_003E8__locals0._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_path + "prop.default"))
				{
					CS_0024_003C_003E8__locals0._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_FilePath = CS_0024_003C_003E8__locals0._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_path + "prop.default";
					string[] array3 = File.ReadAllLines(CS_0024_003C_003E8__locals0._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_FilePath);
					CS_0024_003C_003E8__locals0._0024VB_0024Local_t = array3.Length;
					int num3 = array3.Length - 1;
					for (int k = 0; k <= num3; k++)
					{
						if (array3[k].Contains("manufacturer="))
						{
							CS_0024_003C_003E8__locals0._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_flag = true;
							break;
						}
					}
				}
				else if (File.Exists(CS_0024_003C_003E8__locals0._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_path + "default.prop"))
				{
					CS_0024_003C_003E8__locals0._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_FilePath = CS_0024_003C_003E8__locals0._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_path + "default.prop";
					string[] array4 = File.ReadAllLines(CS_0024_003C_003E8__locals0._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_FilePath);
					CS_0024_003C_003E8__locals0._0024VB_0024Local_t = array4.Length;
					int num4 = array4.Length - 1;
					for (int l = 0; l <= num4; l++)
					{
						if (array4[l].Contains("manufacturer="))
						{
							CS_0024_003C_003E8__locals0._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_flag = true;
							break;
						}
					}
				}
				if (CS_0024_003C_003E8__locals0._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_flag)
				{
					using (StreamReader streamReader = new StreamReader(CS_0024_003C_003E8__locals0._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_FilePath))
					{
						string target = null;
						while (CSharpImpl.Assign(ref target, streamReader.ReadLine()) != null)
						{
							if (target.Contains("ro.product.manufacturer="))
							{
								CS_0024_003C_003E8__locals0._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_array2 = target.Substring(target.IndexOf("=") + 1);
							}
							else if (target.Contains("ro.dolby.manufacturer="))
							{
								CS_0024_003C_003E8__locals0._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_array2 = target.Substring(target.IndexOf("=") + 1);
							}
							else if (target.Contains("ro.product.vendor.manufacturer="))
							{
								CS_0024_003C_003E8__locals0._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_array2 = target.Substring(target.IndexOf("=") + 1);
							}
							if (target.Contains("ro.product.brand="))
							{
								CS_0024_003C_003E8__locals0._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_array5 = target.Substring(target.IndexOf("=") + 1);
							}
							else if (target.Contains("ro.dolby.brand="))
							{
								CS_0024_003C_003E8__locals0._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_array5 = target.Substring(target.IndexOf("=") + 1);
							}
							else if (target.Contains("ro.product.vendor.brand="))
							{
								CS_0024_003C_003E8__locals0._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_array5 = target.Substring(target.IndexOf("=") + 1);
							}
							if (target.Contains("ro.product.name="))
							{
								CS_0024_003C_003E8__locals0._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_array4 = target.Substring(target.IndexOf("=") + 1);
							}
							else if (target.Contains("ro.product.vendor.name="))
							{
								CS_0024_003C_003E8__locals0._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_array4 = target.Substring(target.IndexOf("=") + 1);
							}
							else if (target.Contains("ro.dolby.name="))
							{
								CS_0024_003C_003E8__locals0._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_array4 = target.Substring(target.IndexOf("=") + 1);
							}
							if (target.Contains("ro.product.model="))
							{
								CS_0024_003C_003E8__locals0._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_array6 = target.Substring(target.IndexOf("=") + 1);
							}
							else if (target.Contains("ro.product.vendor.model="))
							{
								CS_0024_003C_003E8__locals0._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_array6 = target.Substring(target.IndexOf("=") + 1);
							}
							else if (target.Contains("ro.product.system.model="))
							{
								CS_0024_003C_003E8__locals0._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_array6 = target.Substring(target.IndexOf("=") + 1);
							}
							if (target.Contains("ro.build.version.release=") | target.Contains("ro.vendor.build.version.release=") | target.Contains("ro.system.build.version.release="))
							{
								CS_0024_003C_003E8__locals0._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_array8 = AndroidCommands.AndroidName(target.Replace("ro.build.version.release=", "").Replace("ro.vendor.build.version.release=", "").Replace("ro.system.build.version.release=", ""));
							}
							if (target.Contains("ro.build.id="))
							{
								CS_0024_003C_003E8__locals0._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_array7 = target.Replace("ro.build.id=", "");
							}
							else if (target.Contains("ro.vendor.build.id="))
							{
								CS_0024_003C_003E8__locals0._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_array7 = target.Replace("ro.vendor.build.id=", "");
							}
							if (target.Contains("ro.build.version.security_patch="))
							{
								CS_0024_003C_003E8__locals0._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_array11 = target.Replace("ro.build.version.security_patch=", "");
							}
							else if (target.Contains("ro.vendor.build.security_patch="))
							{
								CS_0024_003C_003E8__locals0._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_array11 = target.Replace("ro.vendor.build.security_patch=", "");
							}
							if (target.Contains("build.description="))
							{
								CS_0024_003C_003E8__locals0._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_array12 = target.Substring(target.IndexOf("=") + 1).Replace("release-keys", "");
							}
							if (target.Contains("build.date="))
							{
								CS_0024_003C_003E8__locals0._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_array10 = target.Substring(target.IndexOf("=") + 1);
							}
							else if (target.Contains("ro.build.date="))
							{
								CS_0024_003C_003E8__locals0._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_array10 = target.Substring(target.IndexOf("=") + 1);
							}
							else if (target.Contains("ro.vendor.build.date="))
							{
								CS_0024_003C_003E8__locals0._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_array10 = target.Substring(target.IndexOf("=") + 1);
							}
							if (target.Contains("ro.mediatek.platform=") | target.Contains("ro.vendor.mediatek.platform="))
							{
								CS_0024_003C_003E8__locals0._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_array = target.Replace("ro.mediatek.platform=", "").Replace("release-keys", "").Replace("ro.vendor.mediatek.platform=", "");
								string text = CS_0024_003C_003E8__locals0._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_array.ToLower();
								CS_0024_003C_003E8__locals0._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_array = text.Replace("qcom", "Qualcomm SnapDragon( QLM ) ").Replace("mt", "MT").Replace("sc", "SpreadTrum( SPD ) SP")
									.Replace("sp", "SpreadTrum( SPD ) SP")
									.Replace("samsungexynos", "Samsung Exynos ")
									.Replace("hi", "( HiSilicon Kirin ) ")
									.Replace("m7cdug", "Qualcomm SnapDragon( QLM )");
							}
							if (target.Contains("ro.product.cpu.abi="))
							{
								CS_0024_003C_003E8__locals0._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_array1 = target.Substring(target.IndexOf("=") + 1);
							}
							CS_0024_003C_003E8__locals0._0024VB_0024Local_n++;
							Form1.ProcessBar(CS_0024_003C_003E8__locals0._0024VB_0024Local_n, CS_0024_003C_003E8__locals0._0024VB_0024Local_t);
							target = streamReader.ReadLine();
						}
						gui.Richlog("OK", Color.Lime, isBold: false, NextLine: true);
						gui.Richlog("- Read Build Prop Info : ", Color.Black);
						gui.Richlog("OK", Color.FromArgb(0, 85, 207), isBold: false, NextLine: true);
						if (Operators.CompareString(CS_0024_003C_003E8__locals0._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_array2, "", TextCompare: false) != 0)
						{
							gui.Richlog("- Manufacturer : ", Color.Black);
							gui.Richlog(CS_0024_003C_003E8__locals0._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_array2, Color.Green, isBold: false, NextLine: true);
						}
						if (Operators.CompareString(CS_0024_003C_003E8__locals0._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_array5, "", TextCompare: false) != 0)
						{
							gui.Richlog("- Brand : ", Color.Black);
							gui.Richlog(CS_0024_003C_003E8__locals0._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_array5, Color.Green, isBold: false, NextLine: true);
						}
						if (Operators.CompareString(CS_0024_003C_003E8__locals0._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_array6, "", TextCompare: false) != 0)
						{
							gui.Richlog("- Phone Model : ", Color.Black);
							gui.Richlog(CS_0024_003C_003E8__locals0._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_array6, Color.Green, isBold: false, NextLine: true);
						}
						if (Operators.CompareString(CS_0024_003C_003E8__locals0._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_array8, "", TextCompare: false) != 0)
						{
							gui.Richlog("- Android Version : ", Color.Black);
							gui.Richlog(CS_0024_003C_003E8__locals0._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_array8, Color.Green, isBold: false, NextLine: true);
						}
						if (Operators.CompareString(CS_0024_003C_003E8__locals0._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_array7, "", TextCompare: false) != 0)
						{
							gui.Richlog("- Build id : ", Color.Black);
							gui.Richlog(CS_0024_003C_003E8__locals0._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_array7, Color.Green, isBold: false, NextLine: true);
						}
						if (Operators.CompareString(CS_0024_003C_003E8__locals0._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_array11, "", TextCompare: false) != 0)
						{
							gui.Richlog("- Security Patch : ", Color.Black);
							gui.Richlog(CS_0024_003C_003E8__locals0._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_array11, Color.Green, isBold: false, NextLine: true);
						}
						if (Operators.CompareString(CS_0024_003C_003E8__locals0._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_array9, "", TextCompare: false) != 0)
						{
							gui.Richlog("- Build Number : ", Color.Black);
							gui.Richlog(CS_0024_003C_003E8__locals0._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_array9, Color.Green, isBold: false, NextLine: true);
						}
						if (Operators.CompareString(CS_0024_003C_003E8__locals0._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_array10, "", TextCompare: false) != 0)
						{
							gui.Richlog("- Build Date : ", Color.Black);
							gui.Richlog(CS_0024_003C_003E8__locals0._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_array10, Color.Green, isBold: false, NextLine: true);
						}
						if (Operators.CompareString(CS_0024_003C_003E8__locals0._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_array12, "", TextCompare: false) != 0)
						{
							gui.Richlog("- Description : ", Color.Black);
							gui.Richlog(CS_0024_003C_003E8__locals0._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_array12, Color.Green, isBold: false, NextLine: true);
						}
					}
				}
			});
			process.WaitForExit();
		}
		return Task.CompletedTask;
	}
}
