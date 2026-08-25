using System;
using System.Diagnostics;
using System.Management;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace motoulocked.motoulocked;

public class SerialCOM
{
	public class ConversionUtils
	{
		[Serializable]
		[CompilerGenerated]
		private class Class52
		{
			public static Class52 x = new Class52();

			public static Func<int, bool> x__17_0;

			internal bool method_0(int int_0)
			{
				return int_0 % 2 == 0;
			}
		}

		internal static ManagementObjectSearcher MgmtSearch;

		public static string BytesToHexString(byte[] byte_0)
		{
			string text = "";
			string text2 = "";
			checked
			{
				try
				{
					int num = byte_0.Length - 1;
					for (int i = 0; i <= num; i++)
					{
						byte b = byte_0[i];
						text += Conversions.ToString(Strings.Chr(b));
						text2 += Conversion.Hex(b).PadLeft(2, '0');
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception projectError = ex;
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
					ProjectData.ClearProjectError();
				}
				return text2;
			}
		}

		public static byte[] HexStringToBytes(string string_0)
		{
			checked
			{
				byte[] result;
				try
				{
					int num = 0;
					int num2 = 0;
					byte[] array = new byte[(int)Math.Round(Math.Round((double)string_0.Length / 2.0 - 1.0)) + 1 - 1 + 1 - 1 + 1];
					while (string_0.Length > num + 1)
					{
						long value = Convert.ToInt64(string_0.Substring(num, 2), 16);
						array[num2] = Convert.ToByte(value);
						num += 2;
						num2++;
					}
					result = array;
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception projectError = ex;
					ProjectData.SetProjectError(projectError);
					Interaction.MsgBox("Hex String To Byte Array Conversion Error!", MsgBoxStyle.Critical);
					result = null;
					ProjectData.ClearProjectError();
					ProjectData.ClearProjectError();
				}
				return result;
			}
		}
	}

	public static string MSL { get; set; }

	public static Process process { get; set; } = new Process();

}
