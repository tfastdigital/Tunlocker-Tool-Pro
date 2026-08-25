using System;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace motoulocked.mtkclient2.MTK.Client;

internal class hwcrypto_sej
{
	public static string sej_base;

	private static int HACC_AES_RDY = 32768;

	private static int HACC_ACON = 4;

	private static int HACC_ACON2 = 8;

	private static int HACC_ACONK = 12;

	private static int HACC_AKEY0 = 32;

	private static int HACC_AKEY1 = 36;

	private static int HACC_AKEY2 = 40;

	private static int HACC_AKEY3 = 44;

	private static int HACC_AKEY4 = 48;

	private static int HACC_AKEY5 = 52;

	private static int HACC_AKEY6 = 56;

	private static int HACC_AKEY7 = 60;

	private static int HACC_ACFG0 = 64;

	private static int HACC_ACFG1 = 68;

	private static int HACC_ACFG2 = 72;

	private static int HACC_ACFG3 = 76;

	private static int HACC_AOUT0 = 80;

	private static int HACC_AOUT1 = 84;

	private static int HACC_AOUT2 = 88;

	private static int HACC_AOUT3 = 92;

	private static int HACC_UNK = 188;

	private static int HACC_AES_CLR = 2;

	private static int HACC_AES_BK2C = 16;

	private static int HACC_AES_R2K = 256;

	private static int HACC_AES_START = 1;

	private static int HACC_ASRC0 = 16;

	private static int HACC_ASRC1 = 20;

	private static int HACC_ASRC2 = 24;

	private static int HACC_ASRC3 = 28;

	private static int HACC_AES_CHG_BO_OFF = 0;

	private static int HACC_AES_128 = 0;

	private static int HACC_AES_CBC = 2;

	private static int HACC_AES_ENC = 1;

	private static int HACC_AES_DEC = 0;

	private static string[] g_HACC_CFG_1 = new string[8] { "9E D4 04 00", "00 E8 84 A1", "E3 F0 83 BD", "2F 4E 6D 8A", "FF 83 8E 5C", "E9 40 A0 E3", "8D 4D EC C6", "45 FC 09 89" };

	private static string[] g_CFG_RANDOM_PATTERN = new string[12]
	{
		Conversion.Hex(759479152),
		Conversion.Hex(Convert.ToInt64(-1488661977)),
		Conversion.Hex(Convert.ToInt64(-794196405)),
		Conversion.Hex(Convert.ToInt64(-2080390588)),
		Conversion.Hex(2127046251),
		Conversion.Hex(1139281842),
		Conversion.Hex(27669642),
		Conversion.Hex(543685024),
		Conversion.Hex(1414751237),
		Conversion.Hex(Convert.ToInt64(-716790095)),
		Conversion.Hex(482602042),
		Conversion.Hex(Convert.ToInt64(-566789501))
	};

	public static async Task<string> sej_sec_cfg_hw(IMtkDevice device, CancellationToken cancellationToken, string hexstring, bool encrypt)
	{
		if (encrypt)
		{
			hexstring = xor_data(hexstring);
		}
		await SEJ_V3_Init(device, cancellationToken, encrypt, g_HACC_CFG_1, legacy: true);
		string text = await sej_run(device, cancellationToken, hexstring);
		await SEJ_Terminate(device, cancellationToken);
		return encrypt ? text : xor_data(text);
	}

	public static async Task SEJ_Terminate(IMtkDevice device, CancellationToken cancellationToken)
	{
		await DoRegWrite(device, cancellationToken, Convert.ToString(HACC_ACON2), Convert.ToString(HACC_AES_CLR));
		await DoRegWrite(device, cancellationToken, HACC_AKEY0.ToString(), "0");
		await DoRegWrite(device, cancellationToken, HACC_AKEY1.ToString(), "0");
		await DoRegWrite(device, cancellationToken, HACC_AKEY2.ToString(), "0");
		await DoRegWrite(device, cancellationToken, HACC_AKEY3.ToString(), "0");
		await DoRegWrite(device, cancellationToken, HACC_AKEY4.ToString(), "0");
		await DoRegWrite(device, cancellationToken, HACC_AKEY5.ToString(), "0");
		await DoRegWrite(device, cancellationToken, HACC_AKEY6.ToString(), "0");
		await DoRegWrite(device, cancellationToken, HACC_AKEY7.ToString(), "0");
	}

	public static async Task<string> sej_run(IMtkDevice device, CancellationToken cancellationToken, string hexstring)
	{
		byte[] array = utils.HexStringToBytes(hexstring);
		string text = string.Empty;
		int num = 0;
		double num2 = (double)array.Length / 16.0 - 1.0;
		checked
		{
			TaskAwaiter<string> taskAwaiter2 = default(TaskAwaiter<string>);
			for (double num3 = 0.0; num3 <= num2; num3 += 1.0)
			{
				await DoRegWrite(device, cancellationToken, Convert.ToString(HACC_ASRC0), BitConverter.ToUInt32(array.Skip(num).Take(4).ToArray(), 0).ToString());
				num += 4;
				await DoRegWrite(device, cancellationToken, Convert.ToString(HACC_ASRC1), BitConverter.ToUInt32(array.Skip(num).Take(4).ToArray(), 0).ToString());
				num += 4;
				await DoRegWrite(device, cancellationToken, Convert.ToString(HACC_ASRC2), BitConverter.ToUInt32(array.Skip(num).Take(4).ToArray(), 0).ToString());
				num += 4;
				await DoRegWrite(device, cancellationToken, Convert.ToString(HACC_ASRC3), BitConverter.ToUInt32(array.Skip(num).Take(4).ToArray(), 0).ToString());
				num += 4;
				await DoRegWrite(device, cancellationToken, Convert.ToString(HACC_ACON2), Convert.ToString(HACC_AES_START));
				int num4 = 0;
				while (num4 < 20 && (Convert.ToInt64(utils.HexToDec(await DoregRead(device, cancellationToken, Convert.ToString(HACC_ACON2), kanjut: false))) & HACC_AES_RDY) == 0L)
				{
					num4++;
					await Task.Delay(15);
				}
				string text2 = text;
				TaskAwaiter<string> taskAwaiter = DoregRead(device, cancellationToken, Convert.ToString(HACC_AOUT0), kanjut: false).GetAwaiter();
				if (!taskAwaiter.IsCompleted)
				{
					//await taskAwaiter;
					taskAwaiter = taskAwaiter2;
					taskAwaiter2 = default(TaskAwaiter<string>);
				}
				text = text2 + utils.applyshiftKiri2(taskAwaiter.GetResult());
				text2 = text;
				TaskAwaiter<string> taskAwaiter3 = DoregRead(device, cancellationToken, Convert.ToString(HACC_AOUT1), kanjut: false).GetAwaiter();
				if (!taskAwaiter3.IsCompleted)
				{
					//await taskAwaiter3;
					taskAwaiter3 = taskAwaiter2;
					taskAwaiter2 = default(TaskAwaiter<string>);
				}
				text = text2 + utils.applyshiftKiri2(taskAwaiter3.GetResult());
				text2 = text;
				TaskAwaiter<string> taskAwaiter4 = DoregRead(device, cancellationToken, Convert.ToString(HACC_AOUT2), kanjut: false).GetAwaiter();
				if (!taskAwaiter4.IsCompleted)
				{
					//await taskAwaiter4;
					taskAwaiter4 = taskAwaiter2;
					taskAwaiter2 = default(TaskAwaiter<string>);
				}
				text = text2 + utils.applyshiftKiri2(taskAwaiter4.GetResult());
				text2 = text;
				TaskAwaiter<string> taskAwaiter5 = DoregRead(device, cancellationToken, Convert.ToString(HACC_AOUT3), kanjut: false).GetAwaiter();
				if (!taskAwaiter5.IsCompleted)
				{
					//await taskAwaiter5;
					taskAwaiter5 = taskAwaiter2;
					taskAwaiter2 = default(TaskAwaiter<string>);
				}
				text = text2 + utils.applyshiftKiri2(taskAwaiter5.GetResult());
				await Task.Delay(15);
			}
			return text;
		}
	}

	public static async Task DoRegWrite(IMtkDevice device, CancellationToken cancellationToken, string regval, string value)
	{
		if (sej_base == null)
		{
			sej_base = Convert.ToString(268476416);
		}
		await utils.send00000(device, cancellationToken, 16, "doregread", "09000100", "100");
		await utils.send00000(device, cancellationToken, 16, "doregread 2", "04000f00", "100");
		await utils.xsend(device, cancellationToken, utils.HexStringToBytes(utils.applyshiftKiri2(utils.DecimalToHexadecimal(checked(Convert.ToInt64(sej_base) + Convert.ToInt64(regval))))));
		string s = ((Operators.CompareString(value, "0", TextCompare: false) != 0) ? utils.penggenapan4belakang(utils.applyshiftKiri2(utils.DecimalToHexadecimal(Convert.ToInt64(value)))) : "00000000");
		await Task.Delay(10);
		await utils.xsend(device, cancellationToken, utils.HexStringToBytes(s));
		await Task.Delay(10);
		await utils.readmtk(device, cancellationToken, "16");
	}

	public static async Task<string> SEJ_V3_Init(IMtkDevice device, CancellationToken cancellationToken, bool ben, string[] iv, bool legacy)
	{
		int num = HACC_AES_CHG_BO_OFF | HACC_AES_128;
		if (iv != null)
		{
			num |= HACC_AES_CBC;
		}
		num = ((!ben) ? (num | HACC_AES_DEC) : (num | HACC_AES_ENC));
		await DoRegWrite(device, cancellationToken, HACC_AKEY0.ToString(), "0");
		await DoRegWrite(device, cancellationToken, HACC_AKEY1.ToString(), "0");
		await DoRegWrite(device, cancellationToken, HACC_AKEY2.ToString(), "0");
		await DoRegWrite(device, cancellationToken, HACC_AKEY3.ToString(), "0");
		await DoRegWrite(device, cancellationToken, HACC_AKEY4.ToString(), "0");
		await DoRegWrite(device, cancellationToken, HACC_AKEY5.ToString(), "0");
		await DoRegWrite(device, cancellationToken, HACC_AKEY6.ToString(), "0");
		await DoRegWrite(device, cancellationToken, HACC_AKEY7.ToString(), "0");
		await DoRegWrite(device, cancellationToken, Convert.ToString(HACC_ACON), Convert.ToString(HACC_AES_CHG_BO_OFF | HACC_AES_CBC | HACC_AES_128 | HACC_AES_DEC));
		await DoRegWrite(device, cancellationToken, Convert.ToString(HACC_ACONK), Convert.ToString(HACC_AES_BK2C | HACC_AES_R2K));
		await DoRegWrite(device, cancellationToken, Convert.ToString(HACC_ACON2), Convert.ToString(HACC_AES_CLR));
		await DoRegWrite(device, cancellationToken, Convert.ToString(HACC_ACFG0), utils.HexToDec(iv[0].Replace(" ", string.Empty)));
		await DoRegWrite(device, cancellationToken, Convert.ToString(HACC_ACFG1), utils.HexToDec(iv[1].Replace(" ", string.Empty)));
		await DoRegWrite(device, cancellationToken, Convert.ToString(HACC_ACFG2), utils.HexToDec(iv[2].Replace(" ", string.Empty)));
		await DoRegWrite(device, cancellationToken, Convert.ToString(HACC_ACFG3), utils.HexToDec(iv[3].Replace(" ", string.Empty)));
		checked
		{
			if (legacy)
			{
				await DoregRead(device, cancellationToken, Convert.ToString(HACC_UNK), kanjut: true);
				await DoRegWrite(device, cancellationToken, Convert.ToString(HACC_ACON2), Convert.ToString(0x40000000 | HACC_AES_CLR));
				int num2 = 0;
				while (num2 < 20 && Convert.ToUInt32(utils.HexToDec(await DoregRead(device, cancellationToken, Convert.ToString(HACC_ACON2), kanjut: false))) <= 2147483648u)
				{
					num2++;
					await Task.Delay(15);
				}
				await DoregRead(device, cancellationToken, Convert.ToString(HACC_UNK & -2), kanjut: true);
				await DoRegWrite(device, cancellationToken, Convert.ToString(HACC_ACONK), Convert.ToString(HACC_AES_BK2C));
				await DoRegWrite(device, cancellationToken, Convert.ToString(HACC_ACON), Convert.ToString(num));
			}
			else
			{
				await DoRegWrite(device, cancellationToken, HACC_UNK.ToString(), "1");
				int num3 = 0;
				int num4 = 0;
				do
				{
					await DoRegWrite(device, cancellationToken, Convert.ToString(HACC_ASRC0), utils.HexToDec(g_CFG_RANDOM_PATTERN[num3]));
					num3++;
					await DoRegWrite(device, cancellationToken, Convert.ToString(HACC_ASRC1), utils.HexToDec(g_CFG_RANDOM_PATTERN[num3]));
					num3++;
					await DoRegWrite(device, cancellationToken, Convert.ToString(HACC_ASRC2), utils.HexToDec(g_CFG_RANDOM_PATTERN[num3]));
					num3++;
					await DoRegWrite(device, cancellationToken, Convert.ToString(HACC_ASRC3), utils.HexToDec(g_CFG_RANDOM_PATTERN[num3]));
					num3++;
					await DoRegWrite(device, cancellationToken, Convert.ToString(HACC_ACON2), Convert.ToString(HACC_AES_START));
					for (int i = 0; i < 20; i++)
					{
						if ((Convert.ToInt64(utils.HexToDec(await DoregRead(device, cancellationToken, Convert.ToString(HACC_ACON2), kanjut: false))) & HACC_AES_RDY) != 0L)
						{
							break;
						}
						await Task.Delay(15);
					}
					num4++;
				}
				while (num4 <= 2);
				await DoRegWrite(device, cancellationToken, Convert.ToString(HACC_ACON2), Convert.ToString(HACC_AES_CLR));
				await DoRegWrite(device, cancellationToken, Convert.ToString(HACC_ACFG0), utils.HexToDec(iv[0].Replace(" ", string.Empty)));
				await DoRegWrite(device, cancellationToken, Convert.ToString(HACC_ACFG1), utils.HexToDec(iv[1].Replace(" ", string.Empty)));
				await DoRegWrite(device, cancellationToken, Convert.ToString(HACC_ACFG2), utils.HexToDec(iv[2].Replace(" ", string.Empty)));
				await DoRegWrite(device, cancellationToken, Convert.ToString(HACC_ACFG3), utils.HexToDec(iv[3].Replace(" ", string.Empty)));
				await DoRegWrite(device, cancellationToken, Convert.ToString(HACC_ACON), Convert.ToString(num));
				await DoRegWrite(device, cancellationToken, Convert.ToString(HACC_ACONK), "0");
			}
			return Convert.ToString(num);
		}
	}

	public static async Task<string> DoregRead(IMtkDevice device, CancellationToken cancellationToken, string regval, bool kanjut)
	{
		checked
		{
			long dec = Convert.ToInt64(regval) + Convert.ToInt64(sej_base);
			string s = utils.applyshiftKiri2(utils.DecimalToHexadecimal(dec));
			await utils.send00000(device, cancellationToken, 16, "doregread 1", "09000100", "100");
			await utils.send00000(device, cancellationToken, 16, "doregread 2", "02000f00", "100");
			await utils.xsend4(device, cancellationToken, utils.HexStringToBytes(s));
			await Task.Delay(15);
			string text = utils.BytesToHextring(await utils.readmtk(device, cancellationToken, "16"));
			string text2 = utils.applyshiftKiri2(text.Substring(text.Length - 8));
			utils.BytesToHextring(await utils.readmtk(device, cancellationToken, "16"));
			if (kanjut)
			{
				await Task.Delay(15);
				await DoRegWrite(device, cancellationToken, regval, utils.HexToDec(text2));
			}
			return text2;
		}
	}

	public static async Task<byte[]> sej_sec_cfg_sw(byte[] cipherText, bool encrtpt)
	{
		byte[] bytes = Encoding.UTF8.GetBytes("25A1763A21BC854CD569DC23B4782B63");
		byte[] iV = utils.HexStringToBytes("57325A5A125497661254976657325A5A");
		try
		{
			RijndaelManaged rijndaelManaged = (RijndaelManaged)Rijndael.Create();
			rijndaelManaged.BlockSize = 128;
			rijndaelManaged.FeedbackSize = 128;
			rijndaelManaged.KeySize = 128;
			rijndaelManaged.Mode = CipherMode.CBC;
			rijndaelManaged.IV = iV;
			rijndaelManaged.Key = bytes;
			rijndaelManaged.Padding = PaddingMode.None;
			byte[] array = new byte[checked(cipherText.Length - 1 + 1)];
			MemoryStream stream = new MemoryStream(array);
			ICryptoTransform cryptoTransform = ((!encrtpt) ? rijndaelManaged.CreateDecryptor() : rijndaelManaged.CreateEncryptor());
			using (ICryptoTransform transform = cryptoTransform)
			{
				using MemoryStream memoryStream = new MemoryStream(cipherText);
				using CryptoStream cryptoStream = new CryptoStream(stream, transform, CryptoStreamMode.Write);
				byte[] buffer = new byte[129];
				while (true)
				{
					int num = await memoryStream.ReadAsync(buffer, 0, 128);
					cryptoStream.Write(buffer, 0, num);
					if (num == 0)
					{
						break;
					}
					await Task.Delay(10);
				}
			}
			return array;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			MessageBox.Show(ex2.ToString());
			ProjectData.ClearProjectError();
		}
		return new byte[0];
	}

	public static string xor_data(string bytehex)
	{
		bytehex = bytehex.Replace(" ", string.Empty);
		int num = 0;
		string text = string.Empty;
		checked
		{
			int num2 = g_HACC_CFG_1.Count() - 1;
			for (int i = 0; i <= num2; i++)
			{
				string empty = string.Empty;
				string[] array = g_HACC_CFG_1[i].Split(' ');
				string text2 = bytehex.Substring(num, 8);
				long num3 = Convert.ToInt64(utils.HexToDec(array[3]));
				long num4 = Convert.ToInt64(utils.HexToDec(text2.Substring(0, 2)));
				long dec = num3 ^ num4;
				empty += utils.penggenapan2(utils.DecimalToHexadecimal(dec));
				long num5 = Convert.ToInt64(utils.HexToDec(array[2]));
				num4 = Convert.ToInt64(utils.HexToDec(text2.Substring(2, 2)));
				dec = num5 ^ num4;
				empty += utils.penggenapan2(utils.DecimalToHexadecimal(dec));
				long num6 = Convert.ToInt64(utils.HexToDec(array[1]));
				num4 = Convert.ToInt64(utils.HexToDec(text2.Substring(4, 2)));
				dec = num6 ^ num4;
				empty += utils.penggenapan2(utils.DecimalToHexadecimal(dec));
				long num7 = Convert.ToInt64(utils.HexToDec(array[0]));
				num4 = Convert.ToInt64(utils.HexToDec(text2.Substring(6, 2)));
				dec = num7 ^ num4;
				empty += utils.penggenapan2(utils.DecimalToHexadecimal(dec));
				text += empty;
				num += 8;
				if (num == 32)
				{
					return text + bytehex.Substring(text.Length);
				}
			}
			return text;
		}
	}
}
