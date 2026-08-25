using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using Microsoft.VisualBasic.CompilerServices;
using motoulocked.HuaweiUnlocker.DIAGNOS;

namespace motoulocked.HuaweiUnlocker.TOOLS;

public class HISI
{
	[CompilerGenerated]
	internal sealed class _Closure_0024__3_002D0
	{
		public int _0024VB_0024Local_size;

		public _Closure_0024__3_002D0(_Closure_0024__3_002D0 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024Local_size = arg0._0024VB_0024Local_size;
			}
		}

		[SpecialName]
		internal void _Lambda_0024__0(int x)
		{
			Form1.ProcessBar(x, _0024VB_0024Local_size);
		}
	}

	public static Fastboot fb = new Fastboot();

	public static string BSN = "NaN";

	public static string BNUM = "NaN";

	public static string AVER = "NaN";

	public static string MODEL = "NaN";

	public static string BLKEY = "NaN";

	public static string FBLOCKSTATE = "NaN";

	public static bool FBLOCK = false;

	public static void Disconnect()
	{
		fb.Disconnect();
	}

	public static void FlashBootloader(Bootloader bootloader, string port)
	{
		ImageFlasher imageFlasher = new ImageFlasher();
		int num = 0;
		Bootloader.Image[] images = bootloader.Images;
		checked
		{
			foreach (Bootloader.Image image in images)
			{
				if (!image.IsValid)
				{
					throw new Exception("Image `" + image.Role + "` is not valid!");
				}
				num += image.Size;
			}
			imageFlasher.Open(port);
			Bootloader.Image[] images2 = bootloader.Images;
			int num2 = images2.Length - 1;
			_Closure_0024__3_002D0 closure_0024__3_002D = default(_Closure_0024__3_002D0);
			for (int j = 0; j <= num2; j++)
			{
				closure_0024__3_002D = new _Closure_0024__3_002D0(closure_0024__3_002D);
				Bootloader.Image image2 = images2[j];
				closure_0024__3_002D._0024VB_0024Local_size = image2.Size;
				imageFlasher.Write(image2.Path, (int)image2.Address, closure_0024__3_002D._Lambda_0024__0);
			}
			imageFlasher.Close();
		}
	}

	public static bool ReadInfo()
	{
		if (!IsDeviceConnected(5))
		{
			return false;
		}
		GetASerial();
		GetModelProduct();
		GetModelBSN();
		GetBuildID();
		return GetFBLockState();
	}

	public static string GetASerial()
	{
		return AVER = fb.GetSerialNumber();
	}

	public static string GetModelBSN()
	{
		Fastboot.Response response = fb.Command("oem read_bsn");
		if (response.Status == Fastboot.FastbootStatus.Ok)
		{
			BSN = response.Payload;
		}
		return BSN;
	}

	public static string GetModelProduct()
	{
		if (!IsDeviceConnected())
		{
			return "";
		}
		return MODEL = fb.Command("oem get-product-model").Payload;
	}

	public static string GetBuildID()
	{
		if (!IsDeviceConnected())
		{
			return "";
		}
		return BNUM = fb.Command("oem get-build-number").Payload.Replace(":", "");
	}

	public static bool GetFBLockState()
	{
		if (!IsDeviceConnected())
		{
			return true;
		}
		bool flag = Regex.IsMatch(fb.Command("oem lock-state info").Payload, "FB[\\w: ]{1,}UNLOCKED");
		if (!flag)
		{
			flag = Regex.IsMatch(fb.Command("oem backdoor info").Payload, "FB[\\w: ]{1,}UNLOCKED");
		}
		FBLOCKSTATE = ((FBLOCK = flag) ? "UNLOCKED" : "LOCKED");
		return FBLOCK;
	}

	public static void UnlockFRP()
	{
		if (IsDeviceConnected())
		{
			fb.Command("oem erase frp");
			fb.Command("oem erase-frp");
			fb.Command("oem unlock-frp");
			fb.Command("oem frp-erase");
			fb.Command("oem frp-unlock");
			fb.Command("oem format cache");
			fb.UploadData("Tools\\frpUnlocked.img", "devinfo");
			fb.UploadData("Tools\\frpPartition.img", "frp");
		}
	}

	public static void SetNVMEProp(string prop, byte[] value)
	{
		List<byte> list = new List<byte>();
		list.AddRange(Encoding.ASCII.GetBytes("getvar:nve:" + prop + "@"));
		list.AddRange(value);
		Fastboot.Response response = fb.Command(list.ToArray());
		if (!response.Payload.Contains("set nv ok"))
		{
			throw new Exception("Failed to set: " + response.Payload);
		}
	}

	public static byte[] GetSHA256(string str)
	{
		return SHA256.Create().ComputeHash(Encoding.ASCII.GetBytes(str));
	}

	public static void SetHWDogState(byte state)
	{
		if (!IsDeviceConnected())
		{
			return;
		}
		string[] array = new string[2] { "hwdog certify set", "backdoor set" };
		foreach (string arg in array)
		{
			Fastboot.Response response = fb.Command($"oem {arg} {state}");
			if (response.Status == Fastboot.FastbootStatus.Ok || response.Payload.Contains("equal"))
			{
				break;
			}
		}
	}

	public static void ReadAllMethods()
	{
		if (IsDeviceConnected())
		{
			_ = (BLKEY = ReadFactoryKey()).Length;
			_ = 8;
			_ = (BLKEY = ReadFactoryKeyMethod2()).Length;
			_ = 8;
			_ = (BLKEY = ReadIndentifier()).Length;
			_ = 8;
		}
	}

	public static string ReadFactoryKey()
	{
		if (!IsDeviceConnected())
		{
			return "NaN";
		}
		Match match = Regex.Match(fb.Command("getvar:nve:WVLOCK").Payload, "[\\w\\d]{16}");
		if (!match.Success)
		{
			return "NaN";
		}
		return match.Value;
	}

	public static string ReadFactoryKeyMethod2()
	{
		if (!IsDeviceConnected())
		{
			return "NaN";
		}
		return BytesToHexString(fb.Command("getvar:nve:USRKEY").RawData);
	}

	public static string BytesToHexString(byte[] bytes)
	{
		StringBuilder stringBuilder = new StringBuilder(checked(bytes.Length * 2));
		foreach (byte b in bytes)
		{
			stringBuilder.AppendFormat("{0:X2}", b);
		}
		return stringBuilder.ToString();
	}

	public static string ReadIndentifier()
	{
		if (!IsDeviceConnected())
		{
			return "NaN";
		}
		Match match = Regex.Match(fb.Command("oem get_identifier_token").Payload, "[\\w\\d]{16}");
		if (!match.Success)
		{
			return "NaN";
		}
		return match.Value;
	}

	public static void UnlockFBLOCK()
	{
		byte b = 1;
		try
		{
			SetNVMEProp("FBLOCK", new byte[1] { b });
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			SetHWDogState(b);
			ProjectData.ClearProjectError();
		}
	}

	public static void LockFBLOCK()
	{
		byte b = 0;
		try
		{
			SetNVMEProp("FBLOCK", new byte[1] { b });
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			SetHWDogState(b);
			ProjectData.ClearProjectError();
		}
	}

	public static string WriteKEY(string key)
	{
		try
		{
			SetNVMEProp("WVLOCK", Encoding.ASCII.GetBytes(key));
			SetNVMEProp("USRKEY", GetSHA256(key));
			return key;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
		return "NaN";
	}

	public static bool IsDeviceConnected(int time = 10)
	{
		fb.Connect(time);
		bool result = default(bool);
		return result;
	}

	public static string Reboot(string state = "")
	{
		if (!IsDeviceConnected())
		{
			return "NaN";
		}
		return fb.Command("reboot" + state).Payload;
	}

	public static void StartUnlockPRCS(bool frp, bool rb, string key, Bootloader d, string port)
	{
		try
		{
			FlashBootloader(d, port);
			if (fb.Connect())
			{
				if (!frp)
				{
					UnlockFBLOCK();
					ReadInfo();
					BLKEY = WriteKEY(key);
				}
				else
				{
					UnlockFRP();
				}
				if (rb)
				{
					Reboot();
				}
				fb.Disconnect();
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	public static bool TryUnlock(string cpupth)
	{
		if (!IsDeviceConnected())
		{
			return false;
		}
		fb.UploadData(cpupth, "fastboot");
		return false;
	}

	public static string GetPartitionList()
	{
		return fb.Command("getvar:ptable").Payload;
	}
}
