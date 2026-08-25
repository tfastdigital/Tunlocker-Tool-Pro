using System;
using System.Drawing;
using Microsoft.VisualBasic.CompilerServices;
using motoulocked.mtkclient2.MTK.Client.Scatter;
using motoulocked.mtkclient2.Tasks;

namespace motoulocked.motoulocked;

public class TEST
{
	public static object Method23()
	{
		if ("SL112A-SL112C-SL004T-SL219A-SL219C-SL100EA-U380AA-U380AC-SL101AE-SN304AE-U680AC".Contains(device_info.model))
		{
			Form1.String_14 = "ACTE.zip";
			Form1.String_15 = "ACTE";
		}
		if ("SM-A136U-SM-A136U1".Contains(device_info.model))
		{
			Form1.String_14 = "B80.zip";
			Form1.String_15 = "B80";
		}
		if ("Typhoon_C6".Contains(device_info.model))
		{
			Form1.String_14 = "C6.zip";
			Form1.String_15 = "C6";
			Mediatek.Preloader = Form1.String_9 + "mtk\\ronix_emi\\preloader_a5_typhoon_c6.bin";
		}
		if (device_info.model.Contains("CP3669A"))
		{
			Form1.String_14 = "CP36.zip";
			Form1.String_15 = "CP36";
		}
		if (device_info.model.Contains("T767W"))
		{
			Form1.String_14 = "T767.zip";
			Form1.String_15 = "T767";
		}
		if (device_info.model.Contains("S6303L"))
		{
			Form1.String_14 = "A9L.zip";
			Form1.String_15 = "A9L";
			Mediatek.Preloader = Form1.String_9 + "mtk\\ronix_emi\\preloader_a9l.bin";
		}
		if (device_info.model.Contains("SP320"))
		{
			Form1.String_14 = "SP320.zip";
			Form1.String_15 = "SP320";
		}
		if (device_info.model.Contains("SP200"))
		{
			Form1.String_14 = "SP200.zip";
			Form1.String_15 = "SP200";
		}
		if ("LGL355DL".Contains(device_info.model))
		{
			Form1.String_14 = "DL1.zip";
			Form1.String_15 = "DL1";
		}
		if ("LGL455DL".Contains(device_info.model))
		{
			Form1.String_14 = "DL2.zip";
			Form1.String_15 = "DL2";
		}
		if ("LGL555DL".Contains(device_info.model))
		{
			Form1.String_14 = "DL3.zip";
			Form1.String_15 = "DL3";
		}
		if ("LG-H631-LG-H443-LG-H324-LG-H320-LG-H340Y-LG-H340N-LG-H345-LG-MS345-LG-MS631-LG-K540".Contains(device_info.model))
		{
			Form1.String_14 = "q70.zip";
			Form1.String_15 = "q70";
		}
		if ("LM-Q710AL-LM-Q710P-Q710(FGN)-LG-Q710-LG-Q710AL-LG-Q710P-LG-Q710PL-LM-Q710PL".Contains(device_info.model))
		{
			Form1.String_14 = "L7102020.zip";
			Form1.String_15 = "L7102020";
		}
		if ("5087Z".Contains(device_info.model))
		{
			Form1.String_14 = "5087Z.zip";
			Form1.String_15 = "5087Z";
		}
		if ("SM-T227U-SM-T227U1".Contains(device_info.model))
		{
			Form1.String_14 = "B82.zip";
			Form1.String_15 = "B82";
		}
		if ("SM-A037U-SM-A037U1".Contains(device_info.model))
		{
			Form1.String_14 = "B81.zip";
			Form1.String_15 = "B81";
		}
		if ("SM-A326U-SM-A326U1".Contains(device_info.model))
		{
			Form1.String_14 = "B83.zip";
			Form1.String_15 = "B83";
		}
		if (device_info.model.Contains("5085C"))
		{
			Form1.String_14 = "85C.zip";
			Form1.String_15 = "85C";
		}
		if (device_info.model.Contains("U616"))
		{
			Form1.String_14 = "U616A.zip";
			Form1.String_15 = "U616A";
			Mediatek.Preloader = Form1.String_9 + "mtk\\ronix_emi\\preloader_u616as.bin";
		}
		if (device_info.model.Contains("U614"))
		{
			Form1.String_14 = "U614A.zip";
			Form1.String_15 = "U614";
			Mediatek.Preloader = Form1.String_9 + "mtk\\ronix_emi\\preloader_u614as.bin";
		}
		if (device_info.model.Contains("U307"))
		{
			Form1.String_14 = "U307.zip";
			Form1.String_15 = "U307";
			Mediatek.Preloader = Form1.String_9 + "mtk\\ronix_emi\\preloader_u307.bin";
		}
		if (device_info.model.Contains("U300"))
		{
			Form1.String_14 = "U300.zip";
			Form1.String_15 = "U300";
			Mediatek.Preloader = Form1.String_9 + "mtk\\ronix_emi\\preloader_u300.bin";
		}
		if (device_info.model.Contains("U520"))
		{
			Form1.String_14 = "U520.zip";
			Form1.String_15 = "U520";
			Mediatek.Preloader = Form1.String_9 + "mtk\\ronix_emi\\preloader_u300.bin";
		}
		if (device_info.model.Contains("C210"))
		{
			Form1.String_14 = "C210.zip";
			Form1.String_15 = "C210";
			Mediatek.Preloader = Form1.String_9 + "mtk\\ronix_emi\\preloader_c210.bin";
		}
		if (device_info.model.Contains("U202AA"))
		{
			Form1.String_12 = "https://firebasestorage.googleapis.com/v0/b/motounlock-7d7d0.appspot.com/o/Modem_Fro_Unlock_Tinno%2FU202AA.zip?alt=media&token=277186ed-4597-4d20-9232-9232c0d010c0";
			Form1.String_14 = "U202AA.zip";
			Form1.String_15 = "U202AA";
			Mediatek.Preloader = Form1.String_9 + "mtk\\ronix_emi\\preloader_u202.bin";
		}
		if (device_info.model.Contains("U304A"))
		{
			Form1.String_12 = "https://firebasestorage.googleapis.com/v0/b/motounlock-7d7d0.appspot.com/o/Modem_Fro_Unlock_Tinno%2FU304AA.zip?alt=media&token=2d6bda32-98f0-4d1e-8f0b-00658943676f";
			Form1.String_14 = "U304AA.zip";
			Form1.String_15 = "U304AA";
			Mediatek.Preloader = Form1.String_9 + "mtk\\ronix_emi\\preloader_u304.bin";
		}
		if (device_info.model.Contains("U318AA"))
		{
			Form1.String_12 = "https://firebasestorage.googleapis.com/v0/b/motounlock-7d7d0.appspot.com/o/Modem_Fro_Unlock_Tinno%2FU318AA.zip?alt=media&token=ae33c278-1537-4cfb-9906-dfede74ac563";
			Form1.String_14 = "U318AA.zip";
			Form1.String_15 = "U318AA";
			Mediatek.Preloader = Form1.String_9 + "mtk\\ronix_emi\\preloader_u318.bin";
		}
		if (device_info.model.Contains("U325AC"))
		{
			Form1.String_12 = "https://firebasestorage.googleapis.com/v0/b/motounlock-7d7d0.appspot.com/o/Modem_Fro_Unlock_Tinno%2FU325AC.zip?alt=media&token=fe773824-be12-49f2-b7e4-672bb8fc7556";
			Form1.String_14 = "U325AC.zip";
			Form1.String_15 = "U325AC";
		}
		if (device_info.model.Contains("U705AC"))
		{
			Form1.String_12 = "https://firebasestorage.googleapis.com/v0/b/motounlock-7d7d0.appspot.com/o/Modem_Fro_Unlock_Tinno%2FU705AC.zip?alt=media&token=db7de488-c659-4897-8db9-380efce4a6f8";
			Form1.String_14 = "U705AC.zip";
			Form1.String_15 = "U705AC";
		}
		if ("Alcatel_5005C-Alcatel_5005R".Contains(device_info.model))
		{
			Form1.String_12 = "https://firebasestorage.googleapis.com/v0/b/motounlock-7d7d0.appspot.com/o/Modem_Fro_Unlock_Tinno%2F5005R.zip?alt=media&token=0f1fb279-220d-409f-a3ad-6c538c23d96a";
			Form1.String_14 = "5005R.zip";
			Form1.String_15 = "5005R";
		}
		if ("Alcatel_5002C-Alcatel_5002R".Contains(device_info.model))
		{
			Form1.String_12 = "https://firebasestorage.googleapis.com/v0/b/motounlock-7d7d0.appspot.com/o/Modem_Fro_Unlock_Tinno%2F5002CR.zip?alt=media&token=f7d8bfb4-5bac-461f-a415-56c454b11515";
			Form1.String_14 = "5002CR.zip";
			Form1.String_15 = "5002CR";
		}
		if ("Alcatel_5004C-Alcatel_5004R".Contains(device_info.model))
		{
			Form1.String_12 = "https://firebasestorage.googleapis.com/v0/b/motounlock-7d7d0.appspot.com/o/Modem_Fro_Unlock_Tinno%2F5004CR.zip?alt=media&token=7b4d6c79-45c4-4df5-b71a-b4fbe43d7b3b";
			Form1.String_14 = "5004CR.zip";
			Form1.String_15 = "5004CR";
		}
		if ("4188C-4188R".Contains(device_info.model))
		{
			Form1.String_14 = "T41.zip";
			Form1.String_15 = "T41";
		}
		if ("ZTAB10".Contains(device_info.model))
		{
			Form1.String_14 = "O52.zip";
			Form1.String_15 = "O52";
		}
		if (device_info.model.Contains("6125F"))
		{
			Form1.String_14 = "61.zip";
			Form1.String_15 = "61";
		}
		if (device_info.model.Contains("T676J"))
		{
			Form1.String_14 = "T67.zip";
			Form1.String_15 = "T67";
		}
		if (device_info.model.Contains("T766"))
		{
			Form1.String_14 = "T7.zip";
			Form1.String_15 = "T7";
		}
		if ("VORTEX CM62".Contains(device_info.model))
		{
			Mediatek.Preloader = Form1.String_9 + "mtk\\ronix_emi\\preloader_CM62.bin";
			Form1.String_14 = "O53.zip";
			Form1.String_15 = "O53";
		}
		if ("CG65".Contains(device_info.model))
		{
			Mediatek.Preloader = Form1.String_9 + "mtk\\ronix_emi\\preloader_CG65.bin";
			Form1.String_14 = "O70.zip";
			Form1.String_15 = "O70";
		}
		if ("Stratus_C5_Elite-Stratus_C5".Contains(device_info.model))
		{
			if ("Stratus_C5_Elite".Contains(device_info.model))
			{
				Mediatek.Preloader = Form1.String_9 + "mtk\\ronix_emi\\preloader_a16s_stratus_c5.bin";
			}
			else
			{
				Mediatek.Preloader = Form1.String_9 + "mtk\\ronix_emi\\preloader_a16_stratus_c5.bin";
			}
			Form1.String_14 = "O71.zip";
			Form1.String_15 = "O71";
		}
		if ("Stratus_C7-Stratus_C7_Elite".Contains(device_info.model))
		{
			Mediatek.Preloader = Form1.String_9 + "mtk\\ronix_emi\\preloader_c7.bin";
			Form1.String_14 = "O72.zip";
			Form1.String_15 = "O72";
		}
		if ("DL4-DL4s-Plus-DL4 Plus-DL4".Contains(device_info.model))
		{
			Form1.String_14 = "O73.zip";
			Form1.String_15 = "O73";
		}
		if ("CMG101".Contains(device_info.model))
		{
			Form1.String_14 = "O54.zip";
			Form1.String_15 = "O54";
		}
		if ("HD65-HD55".Contains(device_info.model))
		{
			Mediatek.Preloader = Form1.String_9 + "mtk\\ronix_emi\\preloader_HD65.bin";
			Form1.String_14 = "O58.zip";
			Form1.String_15 = "O58";
		}
		if ("HD65_PLUS".Contains(device_info.model))
		{
			Mediatek.Preloader = Form1.String_9 + "mtk\\ronix_emi\\preloader_HD65_PLUS.bin";
			Form1.String_14 = "O56.zip";
			Form1.String_15 = "O56";
		}
		if ("Cyclone_C4-N5502LA-A10LP-A10L-A10LP_R".Contains(device_info.model))
		{
			if ("Cyclone_C4".Contains(device_info.model))
			{
				Mediatek.Preloader = Form1.String_9 + "mtk\\ronix_emi\\preloader_c4.bin";
				Form1.String_14 = "C4.zip";
				Form1.String_15 = "C4";
			}
			else
			{
				Mediatek.Preloader = Form1.String_9 + "mtk\\ronix_emi\\preloader_N5502LA.bin";
				Form1.String_14 = "A10L.zip";
				Form1.String_15 = "A10L";
			}
		}
		if ("HD65_Select-HD65_Ultra".Contains(device_info.model))
		{
			if ("HD65_Ultra".Contains(device_info.model))
			{
				Mediatek.Preloader = Form1.String_9 + "mtk\\ronix_emi\\preloader_HD65_Ultar.bin";
			}
			else
			{
				Mediatek.Preloader = Form1.String_9 + "mtk\\ronix_emi\\preloader_HD65_Select.bin";
			}
			Form1.String_14 = "O58.zip";
			Form1.String_15 = "O58";
		}
		if ("VORTEX HD65 Choice".Contains(device_info.model))
		{
			Mediatek.Preloader = Form1.String_9 + "mtk\\ronix_emi\\preloader_HD65_C.bin";
			Form1.String_14 = "O67.zip";
			Form1.String_15 = "O67";
		}
		if ("ZG65-ZG65H".Contains(device_info.model))
		{
			if ("ZG65".Contains(device_info.model))
			{
				Mediatek.Preloader = Form1.String_9 + "mtk\\ronix_emi\\preloader_ZG65.bin";
				Form1.String_14 = "O65.zip";
				Form1.String_15 = "O65";
			}
			else
			{
				Mediatek.Preloader = Form1.String_9 + "mtk\\ronix_emi\\preloader_ZG65.bin";
				Form1.String_14 = "O55.zip";
				Form1.String_15 = "O55";
			}
		}
		if ("ZG55".Contains(device_info.model))
		{
			Mediatek.Preloader = Form1.String_9 + "mtk\\ronix_emi\\preloader_zg55.bin";
			Form1.String_14 = "O68.zip";
			Form1.String_15 = "O68";
		}
		if ("ZG65 Pro".Contains(device_info.model))
		{
			Mediatek.Preloader = Form1.String_9 + "mtk\\ronix_emi\\preloader_zg65_pro.bin";
			Form1.String_14 = "O69.zip";
			Form1.String_15 = "O69";
		}
		if ("V22".Contains(device_info.model))
		{
			Mediatek.Preloader = Form1.String_9 + "mtk\\ronix_emi\\preloader_V22.bin";
			Form1.String_14 = "O50.zip";
			Form1.String_15 = "O50";
		}
		if ("V22S".Contains(device_info.model))
		{
			Mediatek.Preloader = Form1.String_9 + "mtk\\ronix_emi\\preloader_V22.bin";
			Form1.String_14 = "O57.zip";
			Form1.String_15 = "O57";
		}
		if ("Z22".Contains(device_info.model))
		{
			Mediatek.Preloader = Form1.String_9 + "mtk\\ronix_emi\\preloader_Z22.bin";
			Form1.String_14 = "O51.zip";
			Form1.String_15 = "O51";
		}
		if ("V23".Contains(device_info.model))
		{
			Mediatek.Preloader = Form1.String_9 + "mtk\\ronix_emi\\preloader_V23.bin";
			Form1.String_14 = "O66.zip";
			Form1.String_15 = "O66";
		}
		if ("Z23".Contains(device_info.model))
		{
			Mediatek.Preloader = Form1.String_9 + "mtk\\ronix_emi\\preloader_Z23.bin";
			Form1.String_14 = "O64.zip";
			Form1.String_15 = "O64";
		}
		if ("HD60".Contains(device_info.model))
		{
			Form1.String_14 = "O59.zip";
			Form1.String_15 = "O59";
		}
		if ("HD60i".Contains(device_info.model))
		{
			Form1.String_14 = "O60.zip";
			Form1.String_15 = "O60";
		}
		if ("HD60l".Contains(device_info.model))
		{
			Form1.String_14 = "O61.zip";
			Form1.String_15 = "O61";
		}
		if ("HD62".Contains(device_info.model))
		{
			Form1.String_14 = "O62.zip";
			Form1.String_15 = "O62";
		}
		if ("T10M".Contains(device_info.model))
		{
			Form1.String_14 = "O63.zip";
			Form1.String_15 = "O63";
		}
		if ("T10M_Pro-T10M Pro".Contains(device_info.model))
		{
			Form1.String_14 = "O63.zip";
			Form1.String_15 = "O63";
		}
		if ("T10M_Pro_Plus-T10M Pro Plus-BTAB10-BTAB0".Contains(device_info.model))
		{
			Form1.String_14 = "O63.zip";
			Form1.String_15 = "O63";
		}
		if ("Altice_S11-S11-Altice S11".Contains(device_info.model))
		{
			Form1.String_14 = "S11.zip";
			Form1.String_15 = "S11";
		}
		if ("Altice_S24-S24-Altice S24".Contains(device_info.model))
		{
			Form1.String_14 = "S24.zip";
			Form1.String_15 = "S24";
		}
		if ("Altice_S25-S25-Altice S25".Contains(device_info.model))
		{
			Form1.String_14 = "S25.zip";
			Form1.String_15 = "S25";
		}
		if ("S32-S32 Plus-S32+".Contains(device_info.model))
		{
			Form1.String_14 = "S32.zip";
			Form1.String_15 = "S32";
		}
		if ("Altice_S34-S34-Altice S34".Contains(device_info.model))
		{
			Form1.String_14 = "S34.zip";
			Form1.String_15 = "S34";
		}
		if ("Altice_S64-S64-Altice S64".Contains(device_info.model))
		{
			Form1.String_14 = "S64.zip";
			Form1.String_15 = "S64";
		}
		if ("Altice_S35-S35-Altice S35".Contains(device_info.model))
		{
			Form1.String_14 = "S35.zip";
			Form1.String_15 = "S35";
		}
		object result = default(object);
		return result;
	}

	public static object Method22()
	{
		MtkTask.Mhetod = "1";
		Form1.SharedUI.ProgressBar1.Text = "Check Model From Server...";
		if (!UiManager.IsOnline())
		{
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.Red;
			Form1.SharedUI.RichTextBox1.AppendText("Failed");
			Form1.SharedUI.RichTextBox1.Update();
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.Lime;
			Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " + Check The Internet Connection");
			Form1.SharedUI.MaterialButton8.Enabled = false;
			Form1.SharedUI.MaterialButton1.Enabled = false;
			Form1.SharedUI.MaterialButton2.Enabled = false;
			Form1.SharedUI.MaterialButton16.Enabled = true;
			Form1.SharedUI.RichTextBox1.Update();
			Form1.SharedUI.ProgressBar1.Roll = false;
			Form1.SharedUI.ProgressBar1.Text = "100%";
			Form1.SharedUI.MaterialCard3.Enabled = false;
			Form1.SharedUI.MaterialCard5.Enabled = false;
		}
		else
		{
			Form1.SharedUI.ProgressBar1.Text = "Waiting..";
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
			Form1.SharedUI.RichTextBox1.AppendText("OK");
			Form1.SharedUI.RichTextBox1.Update();
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.Lime;
			Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " + Supported Operations :-");
			if ("TMAF035G-SL104D-REVVL V+ 5G-TMRVL4G-WTCELERO5G-Z6250CC-Z5156CC-Z5156C-STTM21VAPP-HPPL60A-EABF22206A-22041219NY-M2101K7BG-M2006C3MG-M2004J19C-M2003J15SC-M2006C3LG-M2101K7BI-M2101K7BL-M2101K7BI-21061119AL-Z5158-EA211005-REVVL 6 5G-REVVL 6 PRO 5G-TMAF025G-Z3153V-Z5157V-M2101K7BL-21061119AL-Z6250CC-TMRVL4-EC211003-EC211001-EC211004-EA211001-EA211002-EC211002-EC1002-EA1002".Contains(device_info.model))
			{
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Operation >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("Direct Unlock");
				Form1.SharedUI.MaterialButton2.Enabled = true;
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Carrier >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("All");
				MtkTask.Mhetod = "2";
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Operation Cost >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("2 Credits");
				Form1.String_75 = Conversions.ToString(2);
				Form1.String_74 = "2 Credits";
				if (device_info.Brand.Contains("FIH"))
				{
					Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
					Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Note >> ");
					Form1.SharedUI.RichTextBox1.SelectionColor = Color.Lime;
					Form1.SharedUI.RichTextBox1.AppendText("This Model Is LTE ONLY , Bands (2,4,5,12,14,30)");
				}
			}
			else if ("Typhoon_C6-Stratus_C5_Elite-Stratus_C5-Stratus_C7-Stratus_C7_Elite-DL4-DL4s".Contains(device_info.model))
			{
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Operation >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("Direct Unlock");
				Form1.SharedUI.MaterialButton2.Enabled = true;
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Carrier >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("All");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Operation Cost >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("2 Credits");
				Form1.String_75 = Conversions.ToString(2);
				Form1.String_74 = "2 Credits";
			}
			else if ("SL112A-SL112C-SL004T-SL219A-SL219C-SL100EA-U380AA-U380AC-SL101AE-SN304AE-U680AC".Contains(device_info.model))
			{
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Operation >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("Direct Unlock");
				Form1.SharedUI.MaterialButton2.Enabled = true;
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Carrier >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("All");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Operation Cost >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("4 Credits");
				Form1.String_75 = Conversions.ToString(4);
				Form1.String_74 = "4 Credits";
			}
			else if ("4188C-4188R-T10M-V22-Z22-V22S-ZTAB10-VORTEX CM62-CG65-CMG101-HD65-HD55-HD65_PLUS-HD65_Select-HD65_Ultra-VORTEX HD65 Choice-HD60-HD60i-HD60l-HD62-T10M_Pro-T10M_Pro_Plus-T10M Pro-T10M Pro Plus-Z23-V23-ZG65-ZG65H-ZG65 Pro-ZG55-BTAB10-BTAB0".Contains(device_info.model))
			{
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Operation >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("Direct Unlock");
				Form1.SharedUI.MaterialButton2.Enabled = true;
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Carrier >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("All");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Operation Cost >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("3 Credits");
				Form1.String_75 = Conversions.ToString(3);
				Form1.String_74 = "3 Credits";
			}
			else if ("CP3669AS-CP3669A".Contains(device_info.model))
			{
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Operation >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("Direct Unlock");
				Form1.SharedUI.MaterialButton2.Enabled = true;
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Carrier >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("All");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Operation Cost >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("2 Credits");
				Form1.String_75 = Conversions.ToString(2);
				Form1.String_74 = "2 Credits";
			}
			else if ("Cyclone_C4-N5502LA-A10LP-A10L-A10LP_R".Contains(device_info.model))
			{
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Operation >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("Direct Unlock");
				Form1.SharedUI.MaterialButton2.Enabled = true;
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Carrier >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("All");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Operation Cost >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("2 Credits");
				Form1.String_75 = Conversions.ToString(2);
				Form1.String_74 = "2 Credits";
			}
			else if ("S11-S24-S25-S35-S32 Plus-S34-S64".Contains(device_info.model))
			{
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Operation >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("Direct Unlock");
				Form1.SharedUI.MaterialButton2.Enabled = true;
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Carrier >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("All");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Operation Cost >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("2 Credits");
				Form1.String_75 = Conversions.ToString(2);
				Form1.String_74 = "2 Credits";
			}
			else if ("5087Z".Contains(device_info.model))
			{
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Operation >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("Direct Unlock");
				Form1.SharedUI.MaterialButton2.Enabled = true;
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Carrier >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("Boost,Sprint");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Required >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("Downgrade");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Operation Cost >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("2 Credits");
				Form1.String_75 = Conversions.ToString(2);
				Form1.String_74 = "2 Credits";
			}
			else
			{
				if (!"SM-A136U-SM-A136U1".Contains(device_info.model))
				{
					goto IL_1126;
				}
				if (device_info.Carrier.Contains("TMB") | device_info.Carrier.Contains("TMK") | device_info.Carrier.Contains("DSH") | device_info.Carrier.Contains("APP") | device_info.Carrier.Contains("AIO") | device_info.Carrier.Contains("XAA") | device_info.Carrier.Contains("XAU") | device_info.Carrier.Contains("VZW") | device_info.Carrier.Contains("USC"))
				{
					if (!(device_info.secunumber.Contains("1") | device_info.secunumber.Contains("2")))
					{
						goto IL_1126;
					}
					Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
					Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Operation >> ");
					Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
					Form1.SharedUI.RichTextBox1.AppendText("Direct Unlock");
					Form1.SharedUI.MaterialButton2.Enabled = true;
					Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
					Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Carrier >> ");
					Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
					Form1.SharedUI.RichTextBox1.AppendText("TMB,TMK,APP,AIO,XAU,XAA,VZW,DSH,USC");
					Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
					Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Binary >> ");
					Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
					Form1.SharedUI.RichTextBox1.AppendText("1,2");
					Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
					Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Operation Cost >> ");
					if (Operators.CompareString(SevaClass.StatusAcouunt, "Credits", TextCompare: false) == 0)
					{
						Form1.String_75 = Conversions.ToString(2);
						Form1.String_74 = "2 Credits";
						Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
						Form1.SharedUI.RichTextBox1.AppendText("2 Credits");
					}
					else
					{
						Form1.String_75 = Conversions.ToString(0);
						Form1.String_74 = "Free";
						Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
						Form1.SharedUI.RichTextBox1.AppendText("Annual Free");
					}
				}
				else
				{
					Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
					Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Operation >> ");
					Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
					Form1.SharedUI.RichTextBox1.AppendText("Direct Unlock");
					Form1.SharedUI.MaterialButton2.Enabled = true;
					Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
					Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Carrier >> ");
					Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
					Form1.SharedUI.RichTextBox1.AppendText("ATT,CHA");
					Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
					Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Binary >> ");
					Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
					Form1.SharedUI.RichTextBox1.AppendText("All");
					Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
					Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Operation Cost >> ");
					Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
					Form1.SharedUI.RichTextBox1.AppendText("4 Credits");
					Form1.String_75 = Conversions.ToString(4);
					MtkTask.Mhetod = "2";
					Form1.String_74 = "4 Credits";
				}
			}
		}
		goto IL_11717;
		IL_1126:
		if (!"SM-A326U-SM-A326U1".Contains(device_info.model))
		{
			goto IL_15d4;
		}
		if (device_info.Carrier.Contains("TMB") | device_info.Carrier.Contains("TMK") | device_info.Carrier.Contains("DSH") | device_info.Carrier.Contains("APP") | device_info.Carrier.Contains("AIO") | device_info.Carrier.Contains("XAA") | device_info.Carrier.Contains("XAU") | device_info.Carrier.Contains("VZW") | device_info.Carrier.Contains("USC"))
		{
			if (!(device_info.secunumber.Contains("1") | device_info.secunumber.Contains("2") | device_info.secunumber.Contains("3") | device_info.secunumber.Contains("4") | device_info.secunumber.Contains("5") | device_info.secunumber.Contains("6") | device_info.secunumber.Contains("7") | device_info.secunumber.Contains("8")))
			{
				goto IL_15d4;
			}
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
			Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Operation >> ");
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
			Form1.SharedUI.RichTextBox1.AppendText("Direct Unlock");
			Form1.SharedUI.MaterialButton2.Enabled = true;
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
			Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Carrier >> ");
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
			Form1.SharedUI.RichTextBox1.AppendText("TMB,TMK,APP,AIO,XAU,XAA,VZW,DSH,USC");
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
			Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Binary >> ");
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
			Form1.SharedUI.RichTextBox1.AppendText("1,2,3,4,5,6,7,8");
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
			Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Operation Cost >> ");
			if (Operators.CompareString(SevaClass.StatusAcouunt, "Credits", TextCompare: false) == 0)
			{
				Form1.String_75 = Conversions.ToString(2);
				Form1.String_74 = "2 Credits";
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("2 Credits");
			}
			else
			{
				Form1.String_75 = Conversions.ToString(0);
				Form1.String_74 = "Free";
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("Annual Free");
			}
		}
		else
		{
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
			Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Operation >> ");
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
			Form1.SharedUI.RichTextBox1.AppendText("Direct Unlock");
			Form1.SharedUI.MaterialButton2.Enabled = true;
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
			Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Carrier >> ");
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
			Form1.SharedUI.RichTextBox1.AppendText("ATT,CHA");
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
			Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Binary >> ");
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
			Form1.SharedUI.RichTextBox1.AppendText("All");
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
			Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Operation Cost >> ");
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
			Form1.SharedUI.RichTextBox1.AppendText("4 Credits");
			Form1.String_75 = Conversions.ToString(4);
			MtkTask.Mhetod = "2";
			Form1.String_74 = "4 Credits";
		}
		goto IL_11717;
		IL_15d4:
		if (!"SM-T227U-SM-T227U1".Contains(device_info.model))
		{
			goto IL_1ab6;
		}
		if (device_info.Carrier.Contains("TMB") | device_info.Carrier.Contains("TMK") | device_info.Carrier.Contains("DSH") | device_info.Carrier.Contains("APP") | device_info.Carrier.Contains("AIO") | device_info.Carrier.Contains("XAA") | device_info.Carrier.Contains("XAU") | device_info.Carrier.Contains("VZW") | device_info.Carrier.Contains("USC"))
		{
			if (!(device_info.secunumber.Contains("1") | device_info.secunumber.Contains("2")))
			{
				goto IL_1ab6;
			}
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
			Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Operation >> ");
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
			Form1.SharedUI.RichTextBox1.AppendText("Direct Unlock");
			Form1.SharedUI.MaterialButton2.Enabled = true;
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
			Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Carrier >> ");
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
			Form1.SharedUI.RichTextBox1.AppendText("TMB,TMK,APP,AIO,XAU,XAA,VZW,DSH,USC");
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
			Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Binary >> ");
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
			Form1.SharedUI.RichTextBox1.AppendText("1,2");
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
			Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Operation Cost >> ");
			if (Operators.CompareString(SevaClass.StatusAcouunt, "Credits", TextCompare: false) == 0)
			{
				Form1.String_75 = Conversions.ToString(2);
				Form1.String_74 = "2 Credits";
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("2 Credits");
			}
			else
			{
				Form1.String_75 = Conversions.ToString(0);
				Form1.String_74 = "Free";
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("Annual Free");
			}
		}
		else
		{
			if (!(device_info.secunumber.Contains("1") | device_info.secunumber.Contains("2") | device_info.secunumber.Contains("3") | device_info.secunumber.Contains("4") | device_info.secunumber.Contains("5") | device_info.secunumber.Contains("6") | device_info.secunumber.Contains("7") | device_info.secunumber.Contains("8") | device_info.secunumber.Contains("9")))
			{
				goto IL_1ab6;
			}
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
			Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Operation >> ");
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
			Form1.SharedUI.RichTextBox1.AppendText("Direct Unlock");
			Form1.SharedUI.MaterialButton2.Enabled = true;
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
			Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Carrier >> ");
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
			Form1.SharedUI.RichTextBox1.AppendText("ATT,CHA");
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
			Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Binary >> ");
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
			Form1.SharedUI.RichTextBox1.AppendText("1,2,3,4,5,6,7,8,9");
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
			Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Operation Cost >> ");
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
			Form1.SharedUI.RichTextBox1.AppendText("4 Credits");
			Form1.String_75 = Conversions.ToString(4);
			MtkTask.Mhetod = "2";
			Form1.String_74 = "4 Credits";
		}
		goto IL_11717;
		IL_1fa8:
		if ("SM-E426B-SM-A325F-SM-A325M-SM-A325N-SM-A315G-SM-A315F".Contains(device_info.model))
		{
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
			Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Operation >> ");
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
			Form1.SharedUI.RichTextBox1.AppendText("Direct Unlock");
			Form1.SharedUI.MaterialButton2.Enabled = true;
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
			Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Carrier >> ");
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
			Form1.SharedUI.RichTextBox1.AppendText("All");
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
			Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Binary >> ");
			if ("SM-A325F-SM-A325M".Contains(device_info.model))
			{
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("1,2,3,4,5,6,7,8");
			}
			else
			{
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("1,2,3,4,5,6,7");
			}
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
			Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Operation Cost >> ");
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
			Form1.SharedUI.RichTextBox1.AppendText("4 Credits");
			Form1.String_75 = Conversions.ToString(4);
			MtkTask.Mhetod = "2";
			Form1.String_74 = "4 Credits";
		}
		else if ("SM-A136W-SM-A136S-SM-A136M-SM-A136B-SM-A225F-SM-A225M".Contains(device_info.model))
		{
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
			Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Operation >> ");
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
			Form1.SharedUI.RichTextBox1.AppendText("Direct Unlock");
			Form1.SharedUI.MaterialButton2.Enabled = true;
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
			Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Carrier >> ");
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
			Form1.SharedUI.RichTextBox1.AppendText("All");
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
			Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Binary >> ");
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
			Form1.SharedUI.RichTextBox1.AppendText("1,2,3,4,5,6,7,8,9");
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
			Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Operation Cost >> ");
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
			Form1.SharedUI.RichTextBox1.AppendText("4 Credits");
			Form1.String_75 = Conversions.ToString(4);
			MtkTask.Mhetod = "2";
			Form1.String_74 = "4 Credits";
		}
		else if ("LM-Q710AL-LM-Q710P-Q710(FGN)-LG-Q710-LG-Q710AL-LG-Q710P-LG-Q710PL-LM-Q710PL".Contains(device_info.model))
		{
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
			Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Operation >> ");
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
			Form1.SharedUI.RichTextBox1.AppendText("Direct Unlock");
			Form1.SharedUI.MaterialButton2.Enabled = true;
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
			Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Carrier >> ");
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
			Form1.SharedUI.RichTextBox1.AppendText("Boost,Sprint");
			Form1.SharedUI.MaterialButton2.Enabled = true;
			if (device_info.security_patch.Contains("2020"))
			{
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Operation Cost >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("2 Credits");
				Form1.String_75 = Conversions.ToString(2);
				Form1.String_74 = "2 Credits";
			}
			else
			{
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Operation Cost >> ");
				if (Operators.CompareString(SevaClass.StatusAcouunt, "Credits", TextCompare: false) == 0)
				{
					Form1.String_75 = Conversions.ToString(1);
					Form1.String_74 = "1 Credits";
					Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
					Form1.SharedUI.RichTextBox1.AppendText("1 Credits");
				}
				else
				{
					Form1.String_75 = Conversions.ToString(0);
					Form1.String_74 = "Free";
					Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
					Form1.SharedUI.RichTextBox1.AppendText("Annual Free");
				}
			}
		}
		else if ("LG-SP320-LG-SP200".Contains(device_info.model))
		{
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
			Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Operation >> ");
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
			Form1.SharedUI.RichTextBox1.AppendText("Direct Unlock");
			Form1.SharedUI.MaterialButton2.Enabled = true;
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
			Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Carrier >> ");
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
			Form1.SharedUI.RichTextBox1.AppendText("Boost,Sprint");
			Form1.SharedUI.MaterialButton2.Enabled = true;
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
			Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Operation Cost >> ");
			if (Operators.CompareString(SevaClass.StatusAcouunt, "Credits", TextCompare: false) == 0)
			{
				Form1.String_75 = Conversions.ToString(1);
				Form1.String_74 = "1 Credits";
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("1 Credits");
			}
			else
			{
				Form1.String_75 = Conversions.ToString(0);
				Form1.String_74 = "Free";
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("Annual Free");
			}
		}
		else if ("XT2215-1-XT2213-3-XT2211-2-XT2165-5-XT2163-4-XT2141-6-XT2141-4-XT2131-1-XT1921-2-XT2115-4-XT2113-2-XT2093-4-XT2052-1-XT2005-5-XT2201-5-XT2215-4-XT2128-1-XT2095-1-XT2159-2-XT2095-3-XT2155-5-XT2055-1-XT1921-1-XT2029-1-XT2055-2-XT2015-2-XT1965-2-XT2025-1-XT2041-3-XT1922-4-XT2205-2-XT2091-4-XT2052-5-XT2041-6-XT2097-1-XT1920-1-XT2053-2-XT2019-2-XT2335-1-XT2055-4-XT2255-3-XT2345-2-XT2239-1-XT2245-1-XT1941-5-XT2233-1-XT2241-1-XT2255-2-XT2175-1-XT2251-1-XT2223-2-XT2139-1-XT2133-2-XT2139-2-XT2052-2-XT2081-2-XT2113-3-XT2041-4-XT1955-5-XT2201-3-XT2169-1-XT2117-2-XT2231-5-XT2171-1-XT2159-1-XT2133-1-XT1970-2-XT1944-3-XT2227-1-XT2271-5-XT2331-1-XT2239-1-XT1920-1-XT2083-1-XT2173-1-XT2129-1-XT2149-1-XT2025-2-XT2221-2-XT2029-2-XT2075-3-XT2052-3-XT1635-02-XT1775-XT2255-XT2241-XT1680-XT1687-XT1609-XT1675-XT1524-XT1572-XT1754-XT1767-XT1527-XT1641".Contains(device_info.model))
		{
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
			Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Operation >> ");
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
			Form1.SharedUI.RichTextBox1.AppendText("Read Code");
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
			Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Not Supported Carrier >> ");
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
			Form1.SharedUI.RichTextBox1.AppendText("AIO,AT&T,TMK,TMB,VZW And Any Other App Carriers Are Not Supported.");
			if (Operators.CompareString(SevaClass.ReadCode, "True", TextCompare: false) == 0)
			{
				Form1.SharedUI.MaterialButton1.Enabled = true;
				Form1.SharedUI.Guna2Button21.Enabled = true;
			}
			else
			{
				Form1.SharedUI.MaterialButton1.Enabled = false;
				Form1.SharedUI.Guna2Button21.Enabled = false;
			}
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
			Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Operation Cost >> ");
			Form1.String_75 = Conversions.ToString(1);
			Form1.String_74 = "1 Credits";
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
			Form1.SharedUI.RichTextBox1.AppendText("1 Credits");
		}
		else if ("LM-Q720PS".Contains(device_info.model))
		{
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
			Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Operation >> ");
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
			Form1.SharedUI.RichTextBox1.AppendText("Direct Unlock");
			Form1.SharedUI.MaterialButton2.Enabled = true;
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
			Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Carrier >> ");
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
			Form1.SharedUI.RichTextBox1.AppendText("Boost,Sprint");
			Form1.SharedUI.MaterialButton2.Enabled = true;
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
			Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Operation Cost >> ");
			if (Operators.CompareString(SevaClass.StatusAcouunt, "Credits", TextCompare: false) == 0)
			{
				Form1.String_75 = Conversions.ToString(2);
				Form1.String_74 = "2 Credits";
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("2 Credits");
			}
			else
			{
				Form1.String_75 = Conversions.ToString(0);
				Form1.String_74 = "Free";
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("Annual Free");
			}
		}
		else if (device_info.model.Contains("LM-X320PM") | device_info.model.Contains("CP3648A") | device_info.model.Contains("LG-LK460") | device_info.model.Contains("LM-X220PM") | device_info.model.Contains("LM-X410PM"))
		{
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
			Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Operation >> ");
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
			Form1.SharedUI.RichTextBox1.AppendText("Direct Unlock");
			Form1.SharedUI.MaterialButton2.Enabled = true;
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
			Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Carrier >> ");
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
			Form1.SharedUI.RichTextBox1.AppendText("Boost,Sprint");
			Form1.SharedUI.MaterialButton2.Enabled = true;
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
			Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Operation Cost >> ");
			if (Operators.CompareString(SevaClass.StatusAcouunt, "Credits", TextCompare: false) == 0)
			{
				Form1.String_75 = Conversions.ToString(2);
				Form1.String_74 = "2 Credits";
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("2 Credits");
			}
			else
			{
				Form1.String_75 = Conversions.ToString(0);
				Form1.String_74 = "Free";
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("Annual Free");
			}
		}
		else if ("LM-Q730-LM-Q730AM-LM-Q730AM4-LM-K300AM-LM-K400AM-LM-X420AS8-LM-G900TM-LM-G900UM-LM-X420AS-LM-X420CS-U202AA-U202AC-U304AA-U304AC-U318AA-U318AC-U325AA-U325AC-U326AA-U326AC-U705AA-U705AC-Nokia C2 Tennen-Nokia C2 Tava-Nokia C2-Nokia C5 Endi-Nokia C5-Nokia 2.3-Alcatel_5004R-Alcatel_5004C-Alcatel_5002C-Alcatel_5002R-Alcatel_5008R-Alcatel_5005R-Alcatel_5008C-5049W-5049Z-6062W-6062Z".Contains(device_info.model))
		{
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
			Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Operation >> ");
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
			Form1.SharedUI.RichTextBox1.AppendText("Direct Unlock");
			Form1.SharedUI.MaterialButton2.Enabled = true;
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
			Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Carrier >> ");
			if ("LM-G900TM-LM-G900UM".Contains(device_info.model))
			{
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("T-Mobile");
				if (!(device_info.security_patch.Contains("2019") | device_info.security_patch.Contains("2020") | device_info.security_patch.Contains("2021-01") | device_info.security_patch.Contains("2021-02") | device_info.security_patch.Contains("2021-03") | device_info.security_patch.Contains("2021-04") | device_info.security_patch.Contains("2021-05") | device_info.security_patch.Contains("2021-06") | device_info.security_patch.Contains("2021-07")))
				{
					Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
					Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Required >> ");
					Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
					Form1.SharedUI.RichTextBox1.AppendText("Downgrade");
				}
			}
			else
			{
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("Cricket,AT&T");
				if ("U202AA-U304AA-U318AA-U325AC-U705AC-Alcatel_5004R-Alcatel_5004C-Alcatel_5002C-Alcatel_5002R-Alcatel_5005R".Contains(device_info.model) && !(device_info.security_patch.Contains("2018") | device_info.security_patch.Contains("2019") | device_info.security_patch.Contains("2020") | device_info.security_patch.Contains("2021-01") | device_info.security_patch.Contains("2021-02") | device_info.security_patch.Contains("2021-03") | device_info.security_patch.Contains("2021-04")))
				{
					Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
					Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Required >> ");
					Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
					Form1.SharedUI.RichTextBox1.AppendText("Downgrade Modem");
					Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
					Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Advantages >> ");
					Form1.SharedUI.RichTextBox1.SelectionColor = Color.Lime;
					Form1.SharedUI.RichTextBox1.AppendText("The Modem Will Be Downgrade Automatically");
				}
			}
			if ("LM-K300AM-LM-K400AM".Contains(device_info.model))
			{
				if (device_info.security_patch.Contains("2021-01") | device_info.security_patch.Contains("2021-02") | device_info.security_patch.Contains("2021-03") | device_info.security_patch.Contains("2021-04") | device_info.security_patch.Contains("2021-05") | device_info.security_patch.Contains("2021-06") | device_info.security_patch.Contains("2021-07"))
				{
					Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
					Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Operation Cost >> ");
					Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
					Form1.SharedUI.RichTextBox1.AppendText("3 Credits");
					Form1.String_75 = Conversions.ToString(3);
					Form1.String_74 = "3 Credits";
				}
				else
				{
					Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
					Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Operation Cost >> ");
					Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
					Form1.SharedUI.RichTextBox1.AppendText("1 Credits");
					Form1.String_75 = Conversions.ToString(1);
					Form1.String_74 = "1 Credits";
				}
			}
			else
			{
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Operation Cost >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("2 Credits");
				Form1.String_75 = Conversions.ToString(2);
				Form1.String_74 = "2 Credits";
			}
		}
		else if ("LG-LS777-LG-LS992-LG-LS994-LGLS996-LG-LS998-LG-LS991-LM-V450-LM-G820-LM-G850-LM-V350".Contains(device_info.model))
		{
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
			Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Operation >> ");
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
			Form1.SharedUI.RichTextBox1.AppendText("Direct Unlock");
			Form1.SharedUI.MaterialButton2.Enabled = true;
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
			Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Carrier >> ");
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
			Form1.SharedUI.RichTextBox1.AppendText("Boost,Sprint");
			Form1.SharedUI.MaterialButton2.Enabled = true;
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
			Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Operation Cost >> ");
			if (Operators.CompareString(SevaClass.StatusAcouunt, "Credits", TextCompare: false) == 0)
			{
				Form1.String_75 = Conversions.ToString(2);
				Form1.String_74 = "2 Credits";
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("2 Credits");
			}
			else
			{
				Form1.String_75 = Conversions.ToString(0);
				Form1.String_74 = "Free";
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("Annual Free");
			}
		}
		else if ("LG-H631-LG-H443-LG-H324-LG-H320-LG-H340Y-LG-H340N-LG-H345-LG-MS345-LG-MS631-LG-K540".Contains(device_info.model))
		{
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
			Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Operation >> ");
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
			Form1.SharedUI.RichTextBox1.AppendText("Direct Unlock");
			Form1.SharedUI.MaterialButton2.Enabled = true;
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
			Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Carrier >> ");
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
			Form1.SharedUI.RichTextBox1.AppendText("T-Mobile,Metropc");
			Form1.SharedUI.MaterialButton2.Enabled = true;
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
			Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Operation Cost >> ");
			if (Operators.CompareString(SevaClass.StatusAcouunt, "Credits", TextCompare: false) == 0)
			{
				Form1.String_75 = Conversions.ToString(1);
				Form1.String_74 = "1 Credits";
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("2 Credits");
			}
			else
			{
				Form1.String_75 = Conversions.ToString(0);
				Form1.String_74 = "Free";
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("Annual Free");
			}
		}
		else if (device_info.model.Contains("LM-G810") | device_info.model.Contains("LM-G820") | device_info.model.Contains("LM-G850"))
		{
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
			Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Operation >> ");
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
			Form1.SharedUI.RichTextBox1.AppendText("Direct Unlock");
			Form1.SharedUI.MaterialButton2.Enabled = true;
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
			Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Carrier >> ");
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
			Form1.SharedUI.RichTextBox1.AppendText("All");
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
			Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Binary >> ");
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
			Form1.SharedUI.RichTextBox1.AppendText("All");
			Form1.SharedUI.MaterialButton2.Enabled = true;
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
			Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Operation Cost >> ");
			if (Operators.CompareString(SevaClass.StatusAcouunt, "Credits", TextCompare: false) == 0)
			{
				Form1.String_75 = Conversions.ToString(2);
				Form1.String_74 = "2 Credits";
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("2 Credits");
			}
			else
			{
				Form1.String_75 = Conversions.ToString(0);
				Form1.String_74 = "Free";
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("Annual Free");
			}
		}
		else if (device_info.model.Contains("C210") | device_info.model.Contains("U614") | device_info.model.Contains("U616") | device_info.model.Contains("U300") | device_info.model.Contains("U520") | device_info.model.Contains("U307") | device_info.model.Contains("5085C"))
		{
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
			Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Operation >> ");
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
			Form1.SharedUI.RichTextBox1.AppendText("Direct Unlock");
			Form1.SharedUI.MaterialButton2.Enabled = true;
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
			Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Carrier >> ");
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
			Form1.SharedUI.RichTextBox1.AppendText("Boost,Sprint");
			Form1.SharedUI.MaterialButton2.Enabled = true;
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
			Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Operation Cost >> ");
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
			Form1.SharedUI.RichTextBox1.AppendText("2 Credits");
			Form1.String_75 = Conversions.ToString(2);
			Form1.String_74 = "2 Credits";
			Method23();
		}
		else if ("5007Z-5007W".Contains(device_info.model))
		{
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
			Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Operation >> ");
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
			Form1.SharedUI.RichTextBox1.AppendText("Direct Unlock");
			Form1.SharedUI.MaterialButton2.Enabled = true;
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
			Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Carrier >> ");
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
			Form1.SharedUI.RichTextBox1.AppendText("T-Mobile,Metropc");
			Form1.SharedUI.MaterialButton2.Enabled = true;
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
			Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Operation Cost >> ");
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
			Form1.SharedUI.RichTextBox1.AppendText("2 Credits");
			Form1.String_75 = Conversions.ToString(2);
			Form1.String_74 = "2 Credits";
		}
		else if ("Pixel 3 XL-Pixel 3-Pixel3-Pixel 3-Pixel 4-Pixel 4 XL-Pixel 3 A-Pixel 3A-Pixel 6-Pixel 6 XL-Pixel 5-Pixel 4a XL (5G)-Pixel 4a XL-Pixel XL-Pixel 3a XL-Pixel 2-Pixel 2 XL-Pixel 1-Pixel 1 XL".Contains(device_info.model))
		{
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
			Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Operation >> ");
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
			Form1.SharedUI.RichTextBox1.AppendText("Direct Unlock");
			Form1.SharedUI.MaterialButton2.Enabled = true;
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
			Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Operation Cost >> ");
			if (Operators.CompareString(SevaClass.StatusAcouunt, "Credits", TextCompare: false) == 0)
			{
				Form1.String_75 = Conversions.ToString(2);
				Form1.String_74 = "2 Credits";
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("2 Credits");
			}
			else
			{
				Form1.String_75 = Conversions.ToString(0);
				Form1.String_74 = "Free";
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("Annual Free");
			}
		}
		else if ("6125F-T676J-T766".Contains(device_info.model))
		{
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
			Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Operation >> ");
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
			Form1.SharedUI.RichTextBox1.AppendText("Direct Unlock");
			Form1.SharedUI.MaterialButton2.Enabled = true;
			if ("T676J".Contains(device_info.model))
			{
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Carrier >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("Metropc");
			}
			Form1.SharedUI.MaterialButton2.Enabled = true;
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
			Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Operation Cost >> ");
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
			Form1.SharedUI.RichTextBox1.AppendText("3 Credits");
			Form1.String_75 = Conversions.ToString(3);
			Form1.String_74 = "3 Credits";
		}
		else if (device_info.model.Contains("T767") | device_info.model.Contains("S6303L"))
		{
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
			Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Operation >> ");
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
			Form1.SharedUI.RichTextBox1.AppendText("Direct Unlock");
			Form1.SharedUI.MaterialButton2.Enabled = true;
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
			Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Carrier >> ");
			if (device_info.model.Contains("S6303L"))
			{
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("All");
			}
			else
			{
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("Boost,Sprint");
			}
			Form1.SharedUI.MaterialButton2.Enabled = true;
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
			Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Operation Cost >> ");
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
			Form1.SharedUI.RichTextBox1.AppendText("3 Credits");
			Form1.String_75 = Conversions.ToString(3);
			Form1.String_74 = "3 Credits";
		}
		else if ("LM-Q730QN-LM-Q730QM-LM-Q730QM6-LM-Q730QN6-LM-Q730TM-LM-Q730MM-LM-K500QM6-LM-K500UM-LM-K500MM-LM-K510EMW-LM-X430HM-LM-K410HM-LM-K300QM6-LM-K300QM-LM-K300QM3-LM-K300QM2-LM-K300QM1-LM-K300QM4-LM-K300QM5-LM-K300TM-LM-K300MM-LM-K300UM-LM-K400AKR".Contains(device_info.model))
		{
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
			Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Operation >> ");
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
			Form1.SharedUI.RichTextBox1.AppendText("Direct Unlock");
			Form1.SharedUI.MaterialButton2.Enabled = true;
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
			Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Carrier >> ");
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
			Form1.SharedUI.RichTextBox1.AppendText("Sprint,Boost,T-Mobile,Metropc,AT&T,Spectrum,Xfinity");
			if (device_info.security_patch.Contains("2023") | device_info.security_patch.Contains("2022"))
			{
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Required >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("Downgrade");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Operation Cost >> ");
				if (Operators.CompareString(SevaClass.StatusAcouunt, "Credits", TextCompare: false) == 0)
				{
					Form1.String_75 = Conversions.ToString(2);
					Form1.String_74 = "2 Credits";
					Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
					Form1.SharedUI.RichTextBox1.AppendText("2 Credits");
				}
				else
				{
					Form1.String_75 = Conversions.ToString(0);
					Form1.String_74 = "Free";
					Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
					Form1.SharedUI.RichTextBox1.AppendText("Annual Free");
				}
			}
			if (device_info.security_patch.Contains("2020") | device_info.security_patch.Contains("2021"))
			{
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Operation Cost >> ");
				if (Operators.CompareString(SevaClass.StatusAcouunt, "Credits", TextCompare: false) == 0)
				{
					Form1.String_75 = Conversions.ToString(2);
					Form1.String_74 = "2 Credits";
					Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
					Form1.SharedUI.RichTextBox1.AppendText("2 Credits");
				}
				else
				{
					Form1.String_75 = Conversions.ToString(0);
					Form1.String_74 = "Free";
					Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
					Form1.SharedUI.RichTextBox1.AppendText("Annual Free");
				}
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + Environment.NewLine + " -- Supported Operation >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("Convert CSC");
				Form1.SharedUI.MaterialButton16.Enabled = true;
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Carrier >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("Sprint,Boost,T-Mobile,Metropc,AT&T,Spectrum,Xfinity");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Operation Cost >> ");
				if (Operators.CompareString(SevaClass.StatusAcouunt, "Credits", TextCompare: false) == 0)
				{
					Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
					Form1.SharedUI.RichTextBox1.AppendText("1 Credits");
				}
				else
				{
					Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
					Form1.SharedUI.RichTextBox1.AppendText("Annual Free");
				}
			}
		}
		else if ("LGL355DL-LGL455DL-LGL555DL".Contains(device_info.model))
		{
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
			Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Operation >> ");
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
			Form1.SharedUI.RichTextBox1.AppendText("Direct Unlock");
			Form1.SharedUI.MaterialButton2.Enabled = true;
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
			Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Carrier >> ");
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
			Form1.SharedUI.RichTextBox1.AppendText("Tracfone");
			if (device_info.security_patch.Contains("2023") | device_info.security_patch.Contains("2022"))
			{
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Required >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("Test Point");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Operation Cost >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("3 Credits");
				Form1.String_75 = Conversions.ToString(3);
				Form1.String_74 = "3 Credits";
			}
			if (device_info.security_patch.Contains("2020") | device_info.security_patch.Contains("2021"))
			{
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Operation Cost >> ");
				if (Operators.CompareString(SevaClass.StatusAcouunt, "Credits", TextCompare: false) == 0)
				{
					Form1.String_75 = Conversions.ToString(2);
					Form1.String_74 = "2 Credits";
					Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
					Form1.SharedUI.RichTextBox1.AppendText("2 Credits");
				}
				else
				{
					Form1.String_75 = Conversions.ToString(0);
					Form1.String_74 = "Free";
					Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
					Form1.SharedUI.RichTextBox1.AppendText("Annual Free");
				}
			}
		}
		else if ("GT-I9305-GT-I9305T-GT-I9305N-SGH-I747-SGH-I747M-SGH-T999-SGH-T999L-SGH-T999N-SGH-T999V-SM-G730A-SM-G730W8-GT-I9300I-GT-I9301I-GT-I9301Q-GT-I9195-GT-I9195L-GT-I9195T-GT-I9195H-GT-I9190-GT-I9192-GT-I9197-SGH-I257-SGH-I257M-SHV-E370K-SM-S890L-GT-I9515-GT-I9515L-GT-I9505-GT-I9505G-GT-I9506-GT-I9507-GT-I9508V-GT-I9295-SGH-I537-SHV-E470S-GT-I9508-SGH-I337-SGH-I337M-SGH-I337Z-SGH-M919-SGH-M919V-SGH-M919N-SGH-S970G-SM-S975L-SC-04E-SHV-E300L-SHV-E330K-SHV-E330L-SHV-E330S-SM-C105-SM-G900F-SM-G900A-SM-G900I-SM-G900K-SM-G900L-SM-G900T-SM-G900T1-SM-G900M-SM-G900MD-SM-G900AZ-SM-G900FD-SM-G900FQ-SM-G900W8-SC-04F-SM-G870A-SM-G870W-SM-G800H-SM-G800HQ-SM-G9006V-SM-G9008V-SM-G901F-SM-P605L-SM-P605-SM-P605M-SM-P607T-SM-P905-SM-P905M-SM-P907A-GT-N5120-GT-N8020-SGH-T889-SGH-T889V-SGH-I317-SGH-I317M-SHV-E250S-SHV-E250K-SHV-E250L-GT-N7105T-GT-N7105-SC-02E-SM-N7506V-SM-N7502-SM-N9005-SM-N9006-SM-N900A-SM-N900K-SM-N900L-SM-N900T-SM-N900W8-SM-N9002-SM-N9009-SM-N9008-SM-N9008S-SM-N9008V-SM-N900S-SC-01F-SM-N9100-SM-N910A-SM-N910T-SM-N9108V-SM-G386T1-SM-G386W-SM-G850A-SM-G850W-SM-G3139D-SM-G357FZ-SM-G7508Q-SM-T325-SM-T331-SM-T335-SM-T337A-SM-T337T-SM-T525-SM-T531-SM-T535-SM-T537A-SM-G530BT-SM-G530H-SM-G710-SM-G7105-SM-G7105L-SM-G7105H-SM-G7102-SM-G7102T-SM-G7106-SM-G7108-SM-G710K-SM-G710L-SM-G350L-SM-G350M-SM-G3586V-SM-G3588V-SM-G3502C-SM-G3502I-SM-G3502L-SM-G3502T-SM-G3508J-SM-G3815-SM-T215-SC-02F-GT-S7275R-GT-S7275B-GT-S7275T-GT-S7275Y-GT-S7272C-GT-I9152P-SGH-T699-SGH-T779-GT-I8730-GT-I8730T-SC-06D-SGH-I437-SGH-I437P-SGH-I437Z-SGH-I467-SGH-I467M-SGH-I547-SGH-I547C-GT-I8580-GT-I9128E-GT-I9158-GT-I9200-GT-I9208-SGH-I527-SGH-I527M-SGH-M819N-SM-T217A-SM-T217T-SM-T315-SHV-E400S-SC-03E-SM-S780L".Contains(device_info.model))
		{
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
			Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Operation >> ");
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
			Form1.SharedUI.RichTextBox1.AppendText("Direct Unlock");
			Form1.SharedUI.MaterialButton2.Enabled = true;
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
			Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Carrier >> ");
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
			Form1.SharedUI.RichTextBox1.AppendText("All");
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
			Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Operation Cost >> ");
			if (Operators.CompareString(SevaClass.StatusAcouunt, "Credits", TextCompare: false) == 0)
			{
				Form1.String_75 = Conversions.ToString(1);
				Form1.String_74 = "1 Credits";
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("1 Credits");
			}
			else
			{
				Form1.String_75 = Conversions.ToString(0);
				Form1.String_74 = "Free";
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("Annual Free");
			}
		}
		else if ("SM-S134DL-SM-S111DL-SM-S115DL-SM-S215DL-SM-S124DL".Contains(device_info.model))
		{
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
			Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Operation >> ");
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
			Form1.SharedUI.RichTextBox1.AppendText("Direct Unlock");
			Form1.SharedUI.MaterialButton2.Enabled = true;
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
			Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Carrier >> ");
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
			Form1.SharedUI.RichTextBox1.AppendText("TFN");
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
			Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Binary >> ");
			if ("SM-S134DL".Contains(device_info.model))
			{
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("1,2,3,4,5,6");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Operation Cost >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("2 Credits");
				Form1.String_75 = Conversions.ToString(2);
				Form1.String_74 = "2 Credits";
			}
			else
			{
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("All");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Operation Cost >> ");
				if (Operators.CompareString(SevaClass.StatusAcouunt, "Credits", TextCompare: false) == 0)
				{
					Form1.String_75 = Conversions.ToString(2);
					Form1.String_74 = "2 Credits";
					Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
					Form1.SharedUI.RichTextBox1.AppendText("2 Credits");
				}
				else
				{
					Form1.String_75 = Conversions.ToString(0);
					Form1.String_74 = "Free";
					Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
					Form1.SharedUI.RichTextBox1.AppendText("Annual Free");
				}
			}
		}
		else if ("SM-G970U-SM-G973U-SM-G975U-SM-G970U1-SM-G973U1-SM-G975U1".Contains(device_info.model))
		{
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
			Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Operation >> ");
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
			Form1.SharedUI.RichTextBox1.AppendText("Direct Unlock");
			Form1.SharedUI.MaterialButton2.Enabled = true;
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
			Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Carrier >> ");
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
			Form1.SharedUI.RichTextBox1.AppendText("ATT,CCT,CHA,AIO");
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
			Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Binary >> ");
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
			Form1.SharedUI.RichTextBox1.AppendText("1,2,3,4,5,6,7");
			if (!(device_info.security_patch.Contains("2019") | device_info.security_patch.Contains("2020")))
			{
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Required >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("Combination");
			}
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
			Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Operation Cost >> ");
			if (Operators.CompareString(SevaClass.StatusAcouunt, "Credits", TextCompare: false) == 0)
			{
				Form1.String_75 = Conversions.ToString(2);
				Form1.String_74 = "2 Credits";
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("2 Credits");
			}
			else
			{
				Form1.String_75 = Conversions.ToString(0);
				Form1.String_74 = "Free";
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("Annual Free");
			}
		}
		else
		{
			if (!"SM-A045M-SM-A207M-SM-A207F-SM-A146B-SM-A037M-SM-A037F-SM-A115M-SM-A115F-SM-A025M-SM-A025F-SM-A045F-SM-A013M-SM-A013F-SM-A013G-SM-A015M-SM-A015F-SM-A025M-SM-A025F-SM-A025G-SM-A032M-SM-A032F-SM-A032G-SM-A035M-SM-A035F-SM-A035G-SM-A037F-SM-A037M-SM-A047F-SM-A047M-SM-A045F-SM-A045M-SM-A115M-SM-A115F-SM-A226B-SM-A226BR-SM-A107F-SM-A107M-SM-A207F-SM-A207M-SM-M013F-SM-M015F-SM-M015G-SM-M017F-SM-M022F-SM-A115U-SM-M022M-SM-M022G-SM-M025F-SM-M115F-SM-M115M-SM-A115A-SM-A037U-SM-A015A-SM-A015U-SM-A037U1-SM-A215U-SM-A215U1-SM-A146U-SM-A146U1-SM-A025V-SM-A025A".Contains(device_info.model))
			{
				goto IL_502a;
			}
			if ("SM-A115A-SM-A115U-SM-A037U-SM-A015A-SM-A015U-SM-A037U1-SM-A146U-SM-A215U-SM-A215U1-SM-A146U1-SM-A025V-SM-A025A".Contains(device_info.model))
			{
				if (!(device_info.Carrier.Contains("ATT") | device_info.Carrier.Contains("CHA") | device_info.Carrier.Contains("CCT") | device_info.Carrier.Contains("LLA") | device_info.Carrier.Contains("PCT")))
				{
					goto IL_502a;
				}
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Operation >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("Direct Unlock");
				Form1.SharedUI.MaterialButton2.Enabled = true;
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Carrier >> ");
				if ("SM-A146U".Contains(device_info.model))
				{
					Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
					Form1.SharedUI.RichTextBox1.AppendText("ATT,LLA,PCT");
				}
				else
				{
					Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
					Form1.SharedUI.RichTextBox1.AppendText("ATT,CCT,CHA,LLA,PCT");
				}
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Binary >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("All");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Operation Cost >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("3 Credits");
				Form1.String_75 = Conversions.ToString(3);
				Form1.String_74 = "3 Credits";
			}
			else
			{
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Operation >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("Direct Unlock");
				Form1.SharedUI.MaterialButton2.Enabled = true;
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Carrier >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("All");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Binary >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("All");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Operation Cost >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("4 Credits");
				Form1.String_75 = Conversions.ToString(4);
				Form1.String_74 = "4 Credits";
			}
		}
		goto IL_11717;
		IL_108e2:
		if ("SM-N960U-SM-G960U-SM-G965U-SM-A025U-SM-N960U1-SM-G960U1-SM-G965U1-SM-A025U1".Contains(device_info.model) && (device_info.Carrier.Contains("SPR") | device_info.Carrier.Contains("BST") | device_info.Carrier.Contains("DSH")))
		{
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
			Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Operation >> ");
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
			Form1.SharedUI.RichTextBox1.AppendText("Direct Unlock");
			Form1.SharedUI.MaterialButton2.Enabled = true;
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
			Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Carrier >> ");
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
			Form1.SharedUI.RichTextBox1.AppendText("SPR,BST,VMU");
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
			Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Binary >> ");
			if ("SM-A025U-SM-A025U1".Contains(device_info.model))
			{
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("1,2,3,4");
			}
			else
			{
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("1,2,3,4,5,6,7,8,9");
			}
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
			Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Operation Cost >> ");
			if (Operators.CompareString(SevaClass.StatusAcouunt, "Credits", TextCompare: false) == 0)
			{
				Form1.String_75 = Conversions.ToString(2);
				Form1.String_74 = "2 Credits";
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("2 Credits");
			}
			else
			{
				Form1.String_75 = Conversions.ToString(0);
				Form1.String_74 = "Free";
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("Annual Free");
			}
		}
		else if ("SM-A125U-SM-A125U1-SM-S127DL-SM-A125M-SM-A125F".Contains(device_info.model))
		{
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
			Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Operation >> ");
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
			Form1.SharedUI.RichTextBox1.AppendText("Direct Unlock");
			Form1.SharedUI.MaterialButton2.Enabled = true;
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
			Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Carrier >> ");
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
			Form1.SharedUI.RichTextBox1.AppendText("All");
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
			Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Binary >> ");
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
			Form1.SharedUI.RichTextBox1.AppendText("All");
			MtkTask.Mhetod = "2";
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
			Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Operation Cost >> ");
			if ((Operators.CompareString(SevaClass.IDRegistration, "13E8F68F620484E7F155A3BEC8D42EF7", TextCompare: false) == 0) | (Operators.CompareString(SevaClass.IDRegistration, "3C412AF011B2D4A436AC56E4C28414CB", TextCompare: false) == 0))
			{
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("0 Credits");
				Form1.String_75 = Conversions.ToString(0);
				Form1.String_74 = "0 Credits";
			}
			else
			{
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("4 Credits");
				Form1.String_75 = Conversions.ToString(4);
				Form1.String_74 = "4 Credits";
			}
		}
		else if ("SM-A102U-SM-A205U-SM-A505U-SM-A102U1-SM-A205U1-SM-A505U1".Contains(device_info.model) && (device_info.Carrier.Contains("SPR") | device_info.Carrier.Contains("BST")) && (device_info.secunumber.Contains("1") | device_info.secunumber.Contains("2") | device_info.secunumber.Contains("3") | device_info.secunumber.Contains("4") | device_info.secunumber.Contains("5")))
		{
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
			Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Operation >> ");
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
			Form1.SharedUI.RichTextBox1.AppendText("Direct Unlock");
			Form1.SharedUI.MaterialButton2.Enabled = true;
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
			Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Carrier >> ");
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
			Form1.SharedUI.RichTextBox1.AppendText("SPR,BST");
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
			Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Binary >> ");
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
			Form1.SharedUI.RichTextBox1.AppendText("1,2,3,4,5");
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
			Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Operation Cost >> ");
			if (Operators.CompareString(SevaClass.StatusAcouunt, "Credits", TextCompare: false) == 0)
			{
				Form1.String_75 = Conversions.ToString(2);
				Form1.String_74 = "2 Credits";
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("2 Credits");
			}
			else
			{
				Form1.String_75 = Conversions.ToString(0);
				Form1.String_74 = "Free";
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("Annual Free");
			}
		}
		else if ("SM-N920P-SM-N920T-SM-N920T1-SM-G920T-SM-G920T1-SM-G925T-SM-G925T1-SM-G928T-SM-G928T1-SM-J700T-SM-J700T1-SM-G550T-SM-G550T1-SM-G530T-SM-G360T-SM-G530T1-SM-G360T1".Contains(device_info.model))
		{
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
			Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Operation >> ");
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
			Form1.SharedUI.RichTextBox1.AppendText("Direct Unlock");
			Form1.SharedUI.MaterialButton2.Enabled = true;
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
			Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Carrier >> ");
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
			Form1.SharedUI.RichTextBox1.AppendText("Metropc,T-Mobile,Sprint");
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
			Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Binary >> ");
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
			Form1.SharedUI.RichTextBox1.AppendText("1,2,3,4,5,6,7");
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
			Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Required >> ");
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
			Form1.SharedUI.RichTextBox1.AppendText("Engroot");
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
			Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Advantages >> ");
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.Lime;
			Form1.SharedUI.RichTextBox1.AppendText("The Root Will Be Installed Automatically");
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
			Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Operation Cost >> ");
			if (Operators.CompareString(SevaClass.StatusAcouunt, "Credits", TextCompare: false) == 0)
			{
				Form1.String_75 = Conversions.ToString(1);
				Form1.String_74 = "1 Credits";
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("1 Credits");
			}
			else
			{
				Form1.String_75 = Conversions.ToString(0);
				Form1.String_74 = "Free";
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("Annual Free");
			}
		}
		else if ("SM-J727V-SM-J727VPP-SM-J727P-SM-J327V-SM-G930VL-SM-J327VPP-SM-S120VL-SM-S320VL-SM-N930A-SM-N930T-SM-N930P-SM-N930V-SM-N930A-SM-N930R4-SM-N930R6-SM-N930W8-SM-N930T1-SM-G891A-SM-G891V-SM-G891U-SM-G892A-SM-G892V-SM-G892U-SM-G950U-SM-N950U1-SM-N950U-SM-G930V-SM-G930U-SM-G930T1-SM-G930R4-SM-G930R6-SM-G930A-SM-G930P-SM-G950U-SM-N950U1-SM-G955U1-SM-G950U1-SM-G950W-SM-G950D-SM-N950U-SC-01K-SC-02K-SC-03K-SM-G955U-SM-G955W-SC-03J-SM-N9500-SM-N950W-SC-02H-SC-02J-SCV33-SCV34-SCV35-SCV36-SCV35-SCV37-SCV38-SCV39-SC-02K-SC-03K-SM-G935V-SM-G935T-SM-G935A-SM-G935P-SM-G935U-SM-G9350-SM-G930V-SM-G930U-SM-G930T1-SM-G930R4-SM-G930R6-SM-G930A-SM-G930P-SM-G950U-SM-G955U1-SM-G950U1-SM-G950W-SM-G950D-SM-N950U-SM-G955U-SM-G955W-SM-G935V-SM-G935T-SM-G935A-SM-G935P-SM-G935U-SM-N950U1-SM-G930V-SM-G930U-SM-G930T1-SM-G930R4-SM-G930R6-SM-G930A-SM-G930P-SM-G950U-SM-N950U1-SM-G955U1-SM-G950U1-SM-G950W-SM-G950D-SM-N950U-SM-G955U-SM-G955W-N9500-SM-N950W-SM-G935V-SM-G935T-SM-G935A-SM-G935P-SM-G935U-SM-G9350-SM-J510F-SM-J510FN-SM-J510GN-SM-J510FQ-SM-J500F-SM-J500FN-SM-J500G-SM-J500H-SM-J500M-SM-J410F-SM-J410FN-SM-J410G-SM-J415F-SM-J415FN-SM-J415G-SM-J415GN-SM-J610F-SM-J610FN-SM-J610G-SM-J610GN-SM-A605F-SM-A605FD-SM-A605FN-SM-A605G-SM-A605GN-SM-J250F-SM-J250G-SM-J250M-SM-J250Y-SM-J250N-SM-T818A-SM-G9300-SM-G9500-SM-G9550-SM-N9500".Contains(device_info.model))
		{
			Method24();
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
			Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Operation >> ");
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
			Form1.SharedUI.RichTextBox1.AppendText("Direct Unlock");
			Form1.SharedUI.MaterialButton2.Enabled = true;
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
			Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Carrier >> ");
			if ("SM-S120VL-SM-S320VL".Contains(device_info.model))
			{
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("TFN");
			}
			else
			{
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("All");
			}
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
			Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Binary >> ");
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
			Form1.SharedUI.RichTextBox1.AppendText("All");
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
			Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Operation Cost >> ");
			if (Operators.CompareString(SevaClass.StatusAcouunt, "Credits", TextCompare: false) == 0)
			{
				Form1.String_75 = Conversions.ToString(1);
				Form1.String_74 = "1 Credits";
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("1 Credits");
			}
			else
			{
				Form1.String_75 = Conversions.ToString(0);
				Form1.String_74 = "Free";
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("Annual Free");
			}
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
			Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + Environment.NewLine + " -- Supported Operation >> ");
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
			Form1.SharedUI.RichTextBox1.AppendText("Cert Services");
			Form1.SharedUI.MaterialButton20.Enabled = true;
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
			Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Read Cert Cost >> ");
			if (Operators.CompareString(SevaClass.StatusAcouunt, "Credits", TextCompare: false) == 0)
			{
				Form1.String_75 = Conversions.ToString(1);
				Form1.String_74 = "1 Credits";
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("1 Credits");
			}
			else
			{
				Form1.String_75 = Conversions.ToString(0);
				Form1.String_74 = "Free";
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("Annual Free");
			}
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
			Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Write Cert Cost >> ");
			if (Operators.CompareString(SevaClass.StatusAcouunt, "Credits", TextCompare: false) == 0)
			{
				Form1.String_75 = Conversions.ToString(1);
				Form1.String_74 = "1 Credits";
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("1 Credits");
			}
			else
			{
				Form1.String_75 = Conversions.ToString(0);
				Form1.String_74 = "Free";
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("Annual Free");
			}
		}
		else
		{
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
			Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Not Supported Operation >> ");
			Form1.SharedUI.MaterialButton2.Enabled = false;
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.Red;
			Form1.SharedUI.RichTextBox1.AppendText("Direct Unlock");
		}
		goto IL_11717;
		IL_11717:
		object result = default(object);
		return result;
		IL_502a:
		if ("SM-A115U-SM-A215U-SM-A115U1-SM-A215U1".Contains(device_info.model))
		{
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
			Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Operation >> ");
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
			Form1.SharedUI.RichTextBox1.AppendText("Direct Unlock");
			Form1.SharedUI.MaterialButton2.Enabled = true;
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
			Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Carrier >> ");
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
			if ("SM-A215U-SM-A215U1".Contains(device_info.model))
			{
				Form1.SharedUI.RichTextBox1.AppendText("TMB,TMK");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Binary >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("1,2,3,4,5,6,7,8");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Operation Cost >> ");
				if (device_info.secunumber.Contains("7") | device_info.secunumber.Contains("8"))
				{
					if (Operators.CompareString(SevaClass.StatusAcouunt, "Credits", TextCompare: false) == 0)
					{
						Form1.String_75 = Conversions.ToString(3);
						Form1.String_74 = "3 Credits";
						Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
						Form1.SharedUI.RichTextBox1.AppendText("3 Credits");
					}
					else
					{
						Form1.String_75 = Conversions.ToString(0);
						Form1.String_74 = "Free";
						Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
						Form1.SharedUI.RichTextBox1.AppendText("Annual Free");
					}
				}
				else if (Operators.CompareString(SevaClass.StatusAcouunt, "Credits", TextCompare: false) == 0)
				{
					Form1.String_75 = Conversions.ToString(1);
					Form1.String_74 = "1 Credits";
					Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
					Form1.SharedUI.RichTextBox1.AppendText("1 Credits");
				}
				else
				{
					Form1.String_75 = Conversions.ToString(0);
					Form1.String_74 = "Free";
					Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
					Form1.SharedUI.RichTextBox1.AppendText("Annual Free");
				}
			}
			else
			{
				Form1.SharedUI.RichTextBox1.AppendText("SPR,DSH,BTS,TMB,TMK");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Binary >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("1,2,3,4,5,6,7,8,9");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Operation Cost >> ");
				if (device_info.secunumber.Contains("7") | device_info.secunumber.Contains("8") | device_info.secunumber.Contains("9"))
				{
					Form1.String_75 = Conversions.ToString(2);
					Form1.String_74 = "2 Credits";
					Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
					Form1.SharedUI.RichTextBox1.AppendText("2 Credits");
				}
				else if (Operators.CompareString(SevaClass.StatusAcouunt, "Credits", TextCompare: false) == 0)
				{
					Form1.String_75 = Conversions.ToString(1);
					Form1.String_74 = "1 Credits";
					Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
					Form1.SharedUI.RichTextBox1.AppendText("1 Credits");
				}
				else
				{
					Form1.String_75 = Conversions.ToString(0);
					Form1.String_74 = "Free";
					Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
					Form1.SharedUI.RichTextBox1.AppendText("Annual Free");
				}
			}
		}
		else if ("LGLS775-LGLS665-LGLS676-LGLS675-LGLS770".Contains(device_info.model))
		{
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
			Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Operation >> ");
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
			Form1.SharedUI.RichTextBox1.AppendText("Direct Unlock");
			Form1.SharedUI.MaterialButton2.Enabled = true;
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
			Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Carrier >> ");
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
			Form1.SharedUI.RichTextBox1.AppendText("Sprint,Boost");
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
			Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Operation Cost >> ");
			if (Operators.CompareString(SevaClass.StatusAcouunt, "Credits", TextCompare: false) == 0)
			{
				Form1.String_75 = Conversions.ToString(1);
				Form1.String_74 = "1 Credits";
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("1 Credits");
			}
			else
			{
				Form1.String_75 = Conversions.ToString(0);
				Form1.String_74 = "Free";
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("Annual Free");
			}
		}
		else if ("LG-LS777-LG-LS992-LG-LS994-LG-LS996-LG-LS998-LG-LS991-LM-V450-LM-G820-LM-G850-LM-V350".Contains(device_info.model))
		{
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
			Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Operation >> ");
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
			Form1.SharedUI.RichTextBox1.AppendText("Direct Unlock");
			Form1.SharedUI.MaterialButton2.Enabled = true;
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
			Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Carrier >> ");
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
			Form1.SharedUI.RichTextBox1.AppendText("Sprint,Boost");
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
			Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Operation Cost >> ");
			if (Operators.CompareString(SevaClass.StatusAcouunt, "Credits", TextCompare: false) == 0)
			{
				Form1.String_75 = Conversions.ToString(2);
				Form1.String_74 = "2 Credits";
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("2 Credits");
			}
			else
			{
				Form1.String_75 = Conversions.ToString(0);
				Form1.String_74 = "Free";
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("Annual Free");
			}
		}
		else if ("LG-LS997-LG-LS755-LM-LS755-LG-LS993".Contains(device_info.model))
		{
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
			Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Operation >> ");
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
			Form1.SharedUI.RichTextBox1.AppendText("Direct Unlock");
			Form1.SharedUI.MaterialButton2.Enabled = true;
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
			Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Carrier >> ");
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
			Form1.SharedUI.RichTextBox1.AppendText("Sprint,Boost");
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
			Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Operation Cost >> ");
			Form1.String_75 = Conversions.ToString(2);
			Form1.String_74 = "2 Credits";
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
			Form1.SharedUI.RichTextBox1.AppendText("2 Credits");
		}
		else if ("SM-J320A-SM-J320AZ-SM-G920A-SM-G920AZ".Contains(device_info.model))
		{
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
			Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Operation >> ");
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
			Form1.SharedUI.RichTextBox1.AppendText("Direct Unlock");
			Form1.SharedUI.MaterialButton2.Enabled = true;
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
			Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Carrier >> ");
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
			Form1.SharedUI.RichTextBox1.AppendText("ATT,AIO");
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
			Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Binary >> ");
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
			if ("SM-G920A-SM-G920AZ".Contains(device_info.model))
			{
				Form1.SharedUI.RichTextBox1.AppendText("1,2,3,4,5,6,7");
			}
			else
			{
				Form1.SharedUI.RichTextBox1.AppendText("1,2,3");
			}
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
			Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Operation Cost >> ");
			if (Operators.CompareString(SevaClass.StatusAcouunt, "Credits", TextCompare: false) == 0)
			{
				Form1.String_75 = Conversions.ToString(1);
				Form1.String_74 = "1 Credits";
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("1 Credits");
			}
			else
			{
				Form1.String_75 = Conversions.ToString(0);
				Form1.String_74 = "Free";
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("Annual Free");
			}
		}
		else if ("SM-J327T-SM-J327T1".Contains(device_info.model))
		{
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
			Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Operation >> ");
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
			Form1.SharedUI.RichTextBox1.AppendText("Direct Unlock");
			Form1.SharedUI.MaterialButton2.Enabled = true;
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
			Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Carrier >> ");
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
			Form1.SharedUI.RichTextBox1.AppendText("TMB,TMK");
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
			Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Required >> ");
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
			Form1.SharedUI.RichTextBox1.AppendText("Eng Boot");
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
			Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Operation Cost >> ");
			if (Operators.CompareString(SevaClass.StatusAcouunt, "Credits", TextCompare: false) == 0)
			{
				Form1.String_75 = Conversions.ToString(1);
				Form1.String_74 = "1 Credits";
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("1 Credits");
			}
			else
			{
				Form1.String_75 = Conversions.ToString(0);
				Form1.String_74 = "Free";
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("Annual Free");
			}
		}
		else if ("SM-G360T-SM-G360T1-SM-G530T-SM-G530T1".Contains(device_info.model))
		{
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
			Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Operation >> ");
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
			Form1.SharedUI.RichTextBox1.AppendText("Direct Unlock");
			Form1.SharedUI.MaterialButton2.Enabled = true;
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
			Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Carrier >> ");
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
			Form1.SharedUI.RichTextBox1.AppendText("TMB,TMK");
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
			Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Operation Cost >> ");
			if (Operators.CompareString(SevaClass.StatusAcouunt, "Credits", TextCompare: false) == 0)
			{
				Form1.String_75 = Conversions.ToString(1);
				Form1.String_74 = "1 Credits";
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("1 Credits");
			}
			else
			{
				Form1.String_75 = Conversions.ToString(0);
				Form1.String_74 = "Free";
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("Annual Free");
			}
		}
		else if ("SM-J320P".Contains(device_info.model))
		{
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
			Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Operation >> ");
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
			Form1.SharedUI.RichTextBox1.AppendText("Direct Unlock");
			Form1.SharedUI.MaterialButton2.Enabled = true;
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
			Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Carrier >> ");
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
			Form1.SharedUI.RichTextBox1.AppendText("SPR,BST,VMU");
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
			Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Operation Cost >> ");
			if (Operators.CompareString(SevaClass.StatusAcouunt, "Credits", TextCompare: false) == 0)
			{
				Form1.String_75 = Conversions.ToString(1);
				Form1.String_74 = "1 Credits";
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("1 Credits");
			}
			else
			{
				Form1.String_75 = Conversions.ToString(0);
				Form1.String_74 = "Free";
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("Annual Free");
			}
		}
		else
		{
			if (!"SM-A105F-SM-A202F-SM-A205F-SM-A205Y-SM-A260F-SM-A260G-SM-A305G-SM-A505F-SM-A515F-SM-A515U-SM-A530F-SM-A600AZ-SM-A600A-SM-A600FN-SM-A750FN-SM-A750G-SM-G950F-SM-G955F-SM-G960F-SM-G965F-SM-G973F-SM-G975F-SM-G977B-SM-G980F-SM-G981B-SM-G985F-SM-G986B-SM-G988B-SM-J260G-SM-J260M-SM-J400M-SM-J600F-SM-J600G-SM-J730G-SM-J737A-SM-M105G-SM-N950F-SM-N960F-SM-N970F-SM-N975F-SM-J737VPP-SM-J337VPP-SM-A105G-SM-A105M-SM-A205F-SM-J337V-SM-J737V-SM-A307G-SM-A320F-SM-A505G-SM-A507F-SM-A515F-SM-A520F-SM-A520W-SM-A600G-SM-A720F-SM-A730F-SM-G390F-SM-G570M-SM-G930F-SM-G935F-SM-G950N-SM-G960N-SM-G965N-SM-J327A-SM-J327AZ-SM-J330F-SM-J337T-SM-J337T1-SM-J400F-SM-J701F-SM-J701M-SM-J710M-SM-J727AZ-SM-J727A-SM-J727T-SM-J727T1-SM-J737U-SM-M105F-SM-M205F-SM-M205G-SM-M315F-SM-N770F-SM-N950N-SM-N960N-SM-A102U-SM-S102DL-SM-S367VL-SM-S767VL-SM-A205G-SM-A505U1-SM-A600T1-SM-A600T-SM-G970F-SM-J260A-SM-J260T1-SM-J737T1-SM-J737T-SM-N976B-SM-S260DL-SM-S357BL-SM-S506DL-SM-S737TL-SM-S757BL-SM-S205DL-SM-J337A-SM-J337AZ".Contains(device_info.model))
			{
				goto IL_108e2;
			}
			if ("SM-A515U".Contains(device_info.model) && (device_info.Carrier.Contains("CCT") | device_info.Carrier.Contains("ATT") | device_info.Carrier.Contains("CHA")) && (device_info.secunumber.Contains("1") | device_info.secunumber.Contains("2")))
			{
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Operation >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("Direct Unlock");
				Form1.SharedUI.MaterialButton2.Enabled = true;
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Carrier >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("CCT,ATT,CHA");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Binary >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("1,2");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Operation Cost >> ");
				Form1.String_75 = Conversions.ToString(2);
				Form1.String_74 = "2 Credits";
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("2 Credits");
			}
			else if ("SM-A102U".Contains(device_info.model) && (device_info.Carrier.Contains("CCT") | device_info.Carrier.Contains("AIO") | device_info.Carrier.Contains("ATT") | device_info.Carrier.Contains("CHA")) && (device_info.secunumber.Contains("1") | device_info.secunumber.Contains("2") | device_info.secunumber.Contains("3") | device_info.secunumber.Contains("4") | device_info.secunumber.Contains("5") | device_info.secunumber.Contains("6")))
			{
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Operation >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("Direct Unlock");
				Form1.SharedUI.MaterialButton2.Enabled = true;
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Carrier >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("CCT,AIO,ATT,CHA");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Binary >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("1,2,3,4,5,6");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Operation Cost >> ");
				Form1.String_75 = Conversions.ToString(2);
				Form1.String_74 = "2 Credits";
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("2 Credits");
			}
			else if ("SM-A505U1-SM-A505U".Contains(device_info.model) && (device_info.Carrier.Contains("CCT") | device_info.Carrier.Contains("ATT") | device_info.Carrier.Contains("CHA")) && (device_info.secunumber.Contains("1") | device_info.secunumber.Contains("2") | device_info.secunumber.Contains("3") | device_info.secunumber.Contains("4") | device_info.secunumber.Contains("5") | device_info.secunumber.Contains("6") | device_info.secunumber.Contains("7")))
			{
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Operation >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("Direct Unlock");
				Form1.SharedUI.MaterialButton2.Enabled = true;
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Carrier >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("CCT,ATT,CHA");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Binary >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("1,2,3,4,5,6,7");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Operation Cost >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("2 Credits");
				Form1.String_75 = Conversions.ToString(2);
				Form1.String_74 = "2 Credits";
			}
			else if ("SM-J737U".Contains(device_info.model) && (device_info.secunumber.Contains("1") | device_info.secunumber.Contains("2") | device_info.secunumber.Contains("3")))
			{
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Operation >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("Direct Unlock");
				Form1.SharedUI.MaterialButton2.Enabled = true;
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Carrier >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("XAA");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Binary >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("1,2,3");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Operation Cost >> ");
				if (Operators.CompareString(SevaClass.StatusAcouunt, "Credits", TextCompare: false) == 0)
				{
					Form1.String_75 = Conversions.ToString(2);
					Form1.String_74 = "2 Credits";
					Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
					Form1.SharedUI.RichTextBox1.AppendText("2 Credits");
				}
				else
				{
					Form1.String_75 = Conversions.ToString(0);
					Form1.String_74 = "Free";
					Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
					Form1.SharedUI.RichTextBox1.AppendText("Annual Free");
				}
			}
			else if ("SM-A105F".Contains(device_info.model) && (device_info.secunumber.Contains("1") | device_info.secunumber.Contains("2") | device_info.secunumber.Contains("3") | device_info.secunumber.Contains("4")))
			{
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Operation >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("Direct Unlock");
				Form1.SharedUI.MaterialButton2.Enabled = true;
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Binary >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("1,2,3,4");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Operation Cost >> ");
				Form1.String_75 = Conversions.ToString(2);
				Form1.String_74 = "2 Credits";
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("2 Credits");
			}
			else if ("SM-A202F".Contains(device_info.model) && (device_info.secunumber.Contains("1") | device_info.secunumber.Contains("2") | device_info.secunumber.Contains("3")))
			{
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Operation >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("Direct Unlock");
				Form1.SharedUI.MaterialButton2.Enabled = true;
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Binary >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("1,2,3");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Operation Cost >> ");
				Form1.String_75 = Conversions.ToString(2);
				Form1.String_74 = "2 Credits";
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("2 Credits");
			}
			else if ("SM-A205F".Contains(device_info.model) && (device_info.secunumber.Contains("1") | device_info.secunumber.Contains("2") | device_info.secunumber.Contains("3") | device_info.secunumber.Contains("4") | device_info.secunumber.Contains("5") | device_info.secunumber.Contains("6") | device_info.secunumber.Contains("7") | device_info.secunumber.Contains("8")))
			{
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Operation >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("Direct Unlock");
				Form1.SharedUI.MaterialButton2.Enabled = true;
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Binary >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("1,2,3,4,5,6,7,8");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Operation Cost >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("3 Credits");
				Form1.String_75 = Conversions.ToString(3);
				Form1.String_74 = "3 Credits";
			}
			else if ("SM-A205Y".Contains(device_info.model) && (device_info.secunumber.Contains("1") | device_info.secunumber.Contains("2") | device_info.secunumber.Contains("3") | device_info.secunumber.Contains("4") | device_info.secunumber.Contains("5")))
			{
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Operation >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("Direct Unlock");
				Form1.SharedUI.MaterialButton2.Enabled = true;
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Binary >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("1,2,3,4,5");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Operation Cost >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("2 Credits");
				Form1.String_75 = Conversions.ToString(2);
				Form1.String_74 = "2 Credits";
			}
			else if ("SM-A260F".Contains(device_info.model) && (device_info.secunumber.Contains("1") | device_info.secunumber.Contains("2") | device_info.secunumber.Contains("3") | device_info.secunumber.Contains("4") | device_info.secunumber.Contains("5") | device_info.secunumber.Contains("6")))
			{
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Operation >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("Direct Unlock");
				Form1.SharedUI.MaterialButton2.Enabled = true;
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Binary >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("1,2,3,4,5,6");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Operation Cost >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("2 Credits");
				Form1.String_75 = Conversions.ToString(2);
				Form1.String_74 = "2 Credits";
			}
			else if ("SM-A260G".Contains(device_info.model) && (device_info.secunumber.Contains("1") | device_info.secunumber.Contains("2") | device_info.secunumber.Contains("3") | device_info.secunumber.Contains("4") | device_info.secunumber.Contains("5") | device_info.secunumber.Contains("6")))
			{
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Operation >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("Direct Unlock");
				Form1.SharedUI.MaterialButton2.Enabled = true;
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Binary >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("1,2,3,4,5,6");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Operation Cost >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("2 Credits");
				Form1.String_75 = Conversions.ToString(2);
				Form1.String_74 = "2 Credits";
			}
			else if ("SM-A305G".Contains(device_info.model) && (device_info.secunumber.Contains("1") | device_info.secunumber.Contains("2") | device_info.secunumber.Contains("3") | device_info.secunumber.Contains("4") | device_info.secunumber.Contains("5") | device_info.secunumber.Contains("6")))
			{
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Operation >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("Direct Unlock");
				Form1.SharedUI.MaterialButton2.Enabled = true;
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Binary >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("1,2,3,4,5,6");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Operation Cost >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("2 Credits");
				Form1.String_75 = Conversions.ToString(2);
				Form1.String_74 = "2 Credits";
			}
			else if ("SM-A505F".Contains(device_info.model) && (device_info.secunumber.Contains("1") | device_info.secunumber.Contains("2") | device_info.secunumber.Contains("3") | device_info.secunumber.Contains("4") | device_info.secunumber.Contains("5")))
			{
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Operation >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("Direct Unlock");
				Form1.SharedUI.MaterialButton2.Enabled = true;
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Binary >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("1,2,3,4,5");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Operation Cost >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("2 Credits");
				Form1.String_75 = Conversions.ToString(2);
				Form1.String_74 = "2 Credits";
			}
			else if ("SM-A515F".Contains(device_info.model) && (device_info.secunumber.Contains("1") | device_info.secunumber.Contains("2") | device_info.secunumber.Contains("3")))
			{
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Operation >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("Direct Unlock");
				Form1.SharedUI.MaterialButton2.Enabled = true;
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Binary >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("1,2,3");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Operation Cost >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("2 Credits");
				Form1.String_75 = Conversions.ToString(2);
				Form1.String_74 = "2 Credits";
			}
			else if ("SM-A530F".Contains(device_info.model) && (device_info.secunumber.Contains("1") | device_info.secunumber.Contains("2") | device_info.secunumber.Contains("3") | device_info.secunumber.Contains("4") | device_info.secunumber.Contains("5") | device_info.secunumber.Contains("6") | device_info.secunumber.Contains("7") | device_info.secunumber.Contains("8") | device_info.secunumber.Contains("9") | device_info.secunumber.Contains("SA") | device_info.secunumber.Contains("SB") | device_info.secunumber.Contains("SC") | device_info.secunumber.Contains("SD")))
			{
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Operation >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("Direct Unlock");
				Form1.SharedUI.MaterialButton2.Enabled = true;
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Binary >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("1,2,3,4,5,6,7,8,9,A,B,C,D");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Operation Cost >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("4 Credits");
				Form1.String_75 = Conversions.ToString(4);
				Form1.String_74 = "4 Credits";
			}
			else if ("SM-A600AZ-SM-A600A".Contains(device_info.model) && (device_info.secunumber.Contains("1") | device_info.secunumber.Contains("2") | device_info.secunumber.Contains("3") | device_info.secunumber.Contains("4") | device_info.secunumber.Contains("5") | device_info.secunumber.Contains("6") | device_info.secunumber.Contains("7") | device_info.secunumber.Contains("8")))
			{
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Operation >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("Direct Unlock");
				Form1.SharedUI.MaterialButton2.Enabled = true;
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Binary >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("1,2,3,4,5,6,7,8");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Operation Cost >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("3 Credits");
				Form1.String_75 = Conversions.ToString(3);
				Form1.String_74 = "3 Credits";
			}
			else if ("SM-A600FN".Contains(device_info.model) && (device_info.secunumber.Contains("1") | device_info.secunumber.Contains("2") | device_info.secunumber.Contains("3") | device_info.secunumber.Contains("4") | device_info.secunumber.Contains("5") | device_info.secunumber.Contains("6")))
			{
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Operation >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("Direct Unlock");
				Form1.SharedUI.MaterialButton2.Enabled = true;
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Binary >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("1,2,3,4,5,6");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Operation Cost >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("2 Credits");
				Form1.String_75 = Conversions.ToString(2);
				Form1.String_74 = "2 Credits";
			}
			else if ("SM-A750FN".Contains(device_info.model) && (device_info.secunumber.Contains("1") | device_info.secunumber.Contains("2") | device_info.secunumber.Contains("3") | device_info.secunumber.Contains("4")))
			{
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Operation >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("Direct Unlock");
				Form1.SharedUI.MaterialButton2.Enabled = true;
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Binary >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("1,2,3,4");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Operation Cost >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("2 Credits");
				Form1.String_75 = Conversions.ToString(2);
				Form1.String_74 = "2 Credits";
			}
			else if ("SM-A750G".Contains(device_info.model) && (device_info.secunumber.Contains("1") | device_info.secunumber.Contains("2") | device_info.secunumber.Contains("3") | device_info.secunumber.Contains("4") | device_info.secunumber.Contains("5") | device_info.secunumber.Contains("6")))
			{
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Operation >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("Direct Unlock");
				Form1.SharedUI.MaterialButton2.Enabled = true;
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Binary >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("1,2,3,4,5,6");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Operation Cost >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("2 Credits");
				Form1.String_75 = Conversions.ToString(2);
				Form1.String_74 = "2 Credits";
			}
			else if ("SM-G950F".Contains(device_info.model) && (device_info.secunumber.Contains("1") | device_info.secunumber.Contains("2") | device_info.secunumber.Contains("3") | device_info.secunumber.Contains("4") | device_info.secunumber.Contains("5") | device_info.secunumber.Contains("6") | device_info.secunumber.Contains("7") | device_info.secunumber.Contains("8") | device_info.secunumber.Contains("9")))
			{
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Operation >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("Direct Unlock");
				Form1.SharedUI.MaterialButton2.Enabled = true;
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Binary >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("1,2,3,4,5,6,7,8,9");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Operation Cost >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("4 Credits");
				Form1.String_75 = Conversions.ToString(4);
				Form1.String_74 = "4 Credits";
			}
			else if ("SM-G955F".Contains(device_info.model) && (device_info.secunumber.Contains("1") | device_info.secunumber.Contains("2") | device_info.secunumber.Contains("3") | device_info.secunumber.Contains("4") | device_info.secunumber.Contains("5") | device_info.secunumber.Contains("6") | device_info.secunumber.Contains("7") | device_info.secunumber.Contains("8") | device_info.secunumber.Contains("9")))
			{
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Operation >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("Direct Unlock");
				Form1.SharedUI.MaterialButton2.Enabled = true;
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Binary >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("1,2,3,4,5,6,7,8,9");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Operation Cost >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("4 Credits");
				Form1.String_75 = Conversions.ToString(4);
				Form1.String_74 = "4 Credits";
			}
			else if ("SM-G960F".Contains(device_info.model) && (device_info.secunumber.Contains("1") | device_info.secunumber.Contains("2") | device_info.secunumber.Contains("3") | device_info.secunumber.Contains("4") | device_info.secunumber.Contains("5") | device_info.secunumber.Contains("6") | device_info.secunumber.Contains("7") | device_info.secunumber.Contains("8") | device_info.secunumber.Contains("9") | device_info.secunumber.Contains("UA")))
			{
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Operation >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("Direct Unlock");
				Form1.SharedUI.MaterialButton2.Enabled = true;
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Binary >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("1,2,3,4,5,6,7,8,9,A");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Operation Cost >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("4 Credits");
				Form1.String_75 = Conversions.ToString(4);
				Form1.String_74 = "4 Credits";
			}
			else if ("SM-G965F".Contains(device_info.model) && (device_info.secunumber.Contains("1") | device_info.secunumber.Contains("2") | device_info.secunumber.Contains("3") | device_info.secunumber.Contains("4") | device_info.secunumber.Contains("5") | device_info.secunumber.Contains("6") | device_info.secunumber.Contains("7") | device_info.secunumber.Contains("8") | device_info.secunumber.Contains("9") | device_info.secunumber.Contains("UA")))
			{
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Operation >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("Direct Unlock");
				Form1.SharedUI.MaterialButton2.Enabled = true;
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Binary >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("1,2,3,4,5,6,7,8,9,A");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Operation Cost >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("4 Credits");
				Form1.String_75 = Conversions.ToString(4);
				Form1.String_74 = "4 Credits";
			}
			else if ("SM-G973F".Contains(device_info.model) && (device_info.secunumber.Contains("1") | device_info.secunumber.Contains("2") | device_info.secunumber.Contains("3") | device_info.secunumber.Contains("4") | device_info.secunumber.Contains("5") | device_info.secunumber.Contains("6") | device_info.secunumber.Contains("7")))
			{
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Operation >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("Direct Unlock");
				Form1.SharedUI.MaterialButton2.Enabled = true;
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Binary >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("1,2,3,4,5,6,7");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Operation Cost >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("3 Credits");
				Form1.String_75 = Conversions.ToString(3);
				Form1.String_74 = "3 Credits";
			}
			else if ("SM-G975F".Contains(device_info.model) && (device_info.secunumber.Contains("1") | device_info.secunumber.Contains("2") | device_info.secunumber.Contains("3") | device_info.secunumber.Contains("4") | device_info.secunumber.Contains("5") | device_info.secunumber.Contains("6") | device_info.secunumber.Contains("7")))
			{
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Operation >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("Direct Unlock");
				Form1.SharedUI.MaterialButton2.Enabled = true;
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Binary >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("1,2,3,4,5,6,7");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Operation Cost >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("3 Credits");
				Form1.String_75 = Conversions.ToString(3);
				Form1.String_74 = "3 Credits";
			}
			else if ("SM-G977B".Contains(device_info.model) && (device_info.secunumber.Contains("1") | device_info.secunumber.Contains("2") | device_info.secunumber.Contains("3") | device_info.secunumber.Contains("4")))
			{
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Operation >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("Direct Unlock");
				Form1.SharedUI.MaterialButton2.Enabled = true;
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Binary >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("1,2,3,4");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Operation Cost >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("3 Credits");
				Form1.String_75 = Conversions.ToString(3);
				Form1.String_74 = "3 Credits";
			}
			else if ("SM-G977B".Contains(device_info.model) && (device_info.secunumber.Contains("1") | device_info.secunumber.Contains("2") | device_info.secunumber.Contains("3")))
			{
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Operation >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("Direct Unlock");
				Form1.SharedUI.MaterialButton2.Enabled = true;
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Binary >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("1,2,3");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Operation Cost >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("2 Credits");
				Form1.String_75 = Conversions.ToString(2);
				Form1.String_74 = "2 Credits";
			}
			else if ("SM-G981B".Contains(device_info.model) && (device_info.secunumber.Contains("1") | device_info.secunumber.Contains("2") | device_info.secunumber.Contains("3")))
			{
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Operation >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("Direct Unlock");
				Form1.SharedUI.MaterialButton2.Enabled = true;
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Binary >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("1,2,3");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Operation Cost >> ");
				Form1.String_75 = Conversions.ToString(2);
				Form1.String_74 = "2 Credits";
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("2 Credits");
			}
			else if ("SM-G985F".Contains(device_info.model) && (device_info.secunumber.Contains("1") | device_info.secunumber.Contains("2") | device_info.secunumber.Contains("3")))
			{
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Operation >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("Direct Unlock");
				Form1.SharedUI.MaterialButton2.Enabled = true;
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Binary >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("1,2,3");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Operation Cost >> ");
				Form1.String_75 = Conversions.ToString(2);
				Form1.String_74 = "2 Credits";
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("2 Credits");
			}
			else if ("SM-G986B".Contains(device_info.model) && (device_info.secunumber.Contains("1") | device_info.secunumber.Contains("2") | device_info.secunumber.Contains("3")))
			{
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Operation >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("Direct Unlock");
				Form1.SharedUI.MaterialButton2.Enabled = true;
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Binary >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("1,2,3");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Operation Cost >> ");
				Form1.String_75 = Conversions.ToString(2);
				Form1.String_74 = "2 Credits";
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("2 Credits");
			}
			else if ("SM-G988B".Contains(device_info.model) && (device_info.secunumber.Contains("1") | device_info.secunumber.Contains("2") | device_info.secunumber.Contains("3")))
			{
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Operation >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("Direct Unlock");
				Form1.SharedUI.MaterialButton2.Enabled = true;
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Binary >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("1,2,3");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Operation Cost >> ");
				Form1.String_75 = Conversions.ToString(2);
				Form1.String_74 = "2 Credits";
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("2 Credits");
			}
			else if ("SM-J260G".Contains(device_info.model) && (device_info.secunumber.Contains("1") | device_info.secunumber.Contains("2") | device_info.secunumber.Contains("3") | device_info.secunumber.Contains("4") | device_info.secunumber.Contains("5") | device_info.secunumber.Contains("6")))
			{
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Operation >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("Direct Unlock");
				Form1.SharedUI.MaterialButton2.Enabled = true;
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Binary >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("1,2,3,4,5,6");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Operation Cost >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("3 Credits");
				Form1.String_75 = Conversions.ToString(3);
				Form1.String_74 = "3 Credits";
			}
			else if ("SM-J260M".Contains(device_info.model) && (device_info.secunumber.Contains("1") | device_info.secunumber.Contains("2") | device_info.secunumber.Contains("3") | device_info.secunumber.Contains("4") | device_info.secunumber.Contains("5") | device_info.secunumber.Contains("6") | device_info.secunumber.Contains("7") | device_info.secunumber.Contains("8") | device_info.secunumber.Contains("9") | device_info.secunumber.Contains("SA") | device_info.secunumber.Contains("SB")))
			{
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Operation >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("Direct Unlock");
				Form1.SharedUI.MaterialButton2.Enabled = true;
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Binary >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("1,2,3,4,5,6,7,8,9,A,B");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Operation Cost >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("4 Credits");
				Form1.String_75 = Conversions.ToString(4);
				Form1.String_74 = "4 Credits";
			}
			else if ("SM-J400M".Contains(device_info.model) && (device_info.secunumber.Contains("1") | device_info.secunumber.Contains("2") | device_info.secunumber.Contains("3") | device_info.secunumber.Contains("4") | device_info.secunumber.Contains("5") | device_info.secunumber.Contains("6") | device_info.secunumber.Contains("7") | device_info.secunumber.Contains("8") | device_info.secunumber.Contains("9")))
			{
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Operation >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("Direct Unlock");
				Form1.SharedUI.MaterialButton2.Enabled = true;
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Binary >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("1,2,3,4,5,6,7,8,9");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Operation Cost >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("4 Credits");
				Form1.String_75 = Conversions.ToString(4);
				Form1.String_74 = "4 Credits";
			}
			else if ("SM-J600F".Contains(device_info.model) && (device_info.secunumber.Contains("1") | device_info.secunumber.Contains("2") | device_info.secunumber.Contains("3") | device_info.secunumber.Contains("4") | device_info.secunumber.Contains("5") | device_info.secunumber.Contains("6") | device_info.secunumber.Contains("7") | device_info.secunumber.Contains("8")))
			{
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Operation >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("Direct Unlock");
				Form1.SharedUI.MaterialButton2.Enabled = true;
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Binary >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("1,2,3,4,5,6,7,8");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Operation Cost >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("3 Credits");
				Form1.String_75 = Conversions.ToString(3);
				Form1.String_74 = "3 Credits";
			}
			else if ("SM-J600G".Contains(device_info.model) && (device_info.secunumber.Contains("1") | device_info.secunumber.Contains("2") | device_info.secunumber.Contains("3") | device_info.secunumber.Contains("4") | device_info.secunumber.Contains("5") | device_info.secunumber.Contains("6") | device_info.secunumber.Contains("7")))
			{
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Operation >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("Direct Unlock");
				Form1.SharedUI.MaterialButton2.Enabled = true;
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Binary >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("1,2,3,4,5,6,7");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Operation Cost >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("3 Credits");
				Form1.String_75 = Conversions.ToString(3);
				Form1.String_74 = "3 Credits";
			}
			else if ("SM-J730G".Contains(device_info.model) && (device_info.secunumber.Contains("1") | device_info.secunumber.Contains("2") | device_info.secunumber.Contains("3") | device_info.secunumber.Contains("4") | device_info.secunumber.Contains("5") | device_info.secunumber.Contains("6") | device_info.secunumber.Contains("7") | device_info.secunumber.Contains("8") | device_info.secunumber.Contains("9") | device_info.secunumber.Contains("SA") | device_info.secunumber.Contains("SB") | device_info.secunumber.Contains("SC")))
			{
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Operation >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("Direct Unlock");
				Form1.SharedUI.MaterialButton2.Enabled = true;
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Binary >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("1,2,3,4,5,6,7,8,9,A,B,C");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Operation Cost >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("4 Credits");
				Form1.String_75 = Conversions.ToString(4);
				Form1.String_74 = "4 Credits";
			}
			else if ("SM-J737A".Contains(device_info.model) && (device_info.secunumber.Contains("1") | device_info.secunumber.Contains("2") | device_info.secunumber.Contains("3") | device_info.secunumber.Contains("4") | device_info.secunumber.Contains("5") | device_info.secunumber.Contains("6") | device_info.secunumber.Contains("7")))
			{
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Operation >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("Direct Unlock");
				Form1.SharedUI.MaterialButton2.Enabled = true;
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Binary >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("1,2,3,4,5,6,7");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Operation Cost >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("2 Credits");
				Form1.String_75 = Conversions.ToString(2);
				Form1.String_74 = "2 Credits";
			}
			else if ("SM-M105G".Contains(device_info.model) && (device_info.secunumber.Contains("1") | device_info.secunumber.Contains("2") | device_info.secunumber.Contains("3") | device_info.secunumber.Contains("4") | device_info.secunumber.Contains("5")))
			{
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Operation >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("Direct Unlock");
				Form1.SharedUI.MaterialButton2.Enabled = true;
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Binary >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("1,2,3,4,5");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Operation Cost >> ");
				Form1.String_75 = Conversions.ToString(2);
				Form1.String_74 = "2 Credits";
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("2 Credits");
			}
			else if ("SM-N950F".Contains(device_info.model) && (device_info.secunumber.Contains("1") | device_info.secunumber.Contains("2") | device_info.secunumber.Contains("3") | device_info.secunumber.Contains("4") | device_info.secunumber.Contains("5") | device_info.secunumber.Contains("6") | device_info.secunumber.Contains("7") | device_info.secunumber.Contains("8") | device_info.secunumber.Contains("9") | device_info.secunumber.Contains("SA") | device_info.secunumber.Contains("SB") | device_info.secunumber.Contains("SC") | device_info.secunumber.Contains("SD")))
			{
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Operation >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("Direct Unlock");
				Form1.SharedUI.MaterialButton2.Enabled = true;
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Binary >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("1,2,3,4,5,6,7,8,9,A,B,C,D");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Operation Cost >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("4 Credits");
				Form1.String_75 = Conversions.ToString(4);
				Form1.String_74 = "4 Credits";
			}
			else if ("SM-N960F".Contains(device_info.model) && (device_info.secunumber.Contains("1") | device_info.secunumber.Contains("2") | device_info.secunumber.Contains("3") | device_info.secunumber.Contains("4") | device_info.secunumber.Contains("5") | device_info.secunumber.Contains("6")))
			{
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Operation >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("Direct Unlock");
				Form1.SharedUI.MaterialButton2.Enabled = true;
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Binary >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("1,2,3,4,5,6");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Operation Cost >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("3 Credits");
				Form1.String_75 = Conversions.ToString(3);
				Form1.String_74 = "3 Credits";
			}
			else if ("SM-N970F".Contains(device_info.model) && (device_info.secunumber.Contains("1") | device_info.secunumber.Contains("2") | device_info.secunumber.Contains("3") | device_info.secunumber.Contains("4") | device_info.secunumber.Contains("5")))
			{
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Operation >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("Direct Unlock");
				Form1.SharedUI.MaterialButton2.Enabled = true;
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Binary >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("1,2,3,4,5");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Operation Cost >> ");
				Form1.String_75 = Conversions.ToString(2);
				Form1.String_74 = "2 Credits";
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("2 Credits");
			}
			else if ("SM-N975F".Contains(device_info.model) && (device_info.secunumber.Contains("1") | device_info.secunumber.Contains("2") | device_info.secunumber.Contains("3") | device_info.secunumber.Contains("4") | device_info.secunumber.Contains("5")))
			{
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Operation >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("Direct Unlock");
				Form1.SharedUI.MaterialButton2.Enabled = true;
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Binary >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("1,2,3,4,5");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Operation Cost >> ");
				Form1.String_75 = Conversions.ToString(2);
				Form1.String_74 = "2 Credits";
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("2 Credits");
			}
			else if ("SM-J337V".Contains(device_info.model) && (device_info.secunumber.Contains("1") | device_info.secunumber.Contains("2") | device_info.secunumber.Contains("3") | device_info.secunumber.Contains("4") | device_info.secunumber.Contains("5") | device_info.secunumber.Contains("6")))
			{
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Operation >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("Direct Unlock");
				Form1.SharedUI.MaterialButton2.Enabled = true;
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Binary >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("1,2,3,4,5,6");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Operation Cost >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("2 Credits");
				Form1.String_75 = Conversions.ToString(2);
				Form1.String_74 = "2 Credits";
			}
			else if ("SM-J737V".Contains(device_info.model) && (device_info.secunumber.Contains("1") | device_info.secunumber.Contains("2") | device_info.secunumber.Contains("3") | device_info.secunumber.Contains("4") | device_info.secunumber.Contains("5") | device_info.secunumber.Contains("6")))
			{
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Operation >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("Direct Unlock");
				Form1.SharedUI.MaterialButton2.Enabled = true;
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Binary >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("1,2,3,4,5,6");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Operation Cost >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("2 Credits");
				Form1.String_75 = Conversions.ToString(2);
				Form1.String_74 = "2 Credits";
			}
			else if ("SM-J737VPP".Contains(device_info.model) && (device_info.secunumber.Contains("1") | device_info.secunumber.Contains("2") | device_info.secunumber.Contains("3") | device_info.secunumber.Contains("4") | device_info.secunumber.Contains("5") | device_info.secunumber.Contains("6") | device_info.secunumber.Contains("7")))
			{
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Operation >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("Direct Unlock");
				Form1.SharedUI.MaterialButton2.Enabled = true;
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Binary >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("1,2,3,4,5,6,7");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Operation Cost >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("2 Credits");
				Form1.String_75 = Conversions.ToString(2);
				Form1.String_74 = "2 Credits";
			}
			else if ("SM-J337VPP".Contains(device_info.model) && (device_info.secunumber.Contains("1") | device_info.secunumber.Contains("2") | device_info.secunumber.Contains("3") | device_info.secunumber.Contains("4") | device_info.secunumber.Contains("5") | device_info.secunumber.Contains("6") | device_info.secunumber.Contains("7")))
			{
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Operation >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("Direct Unlock");
				Form1.SharedUI.MaterialButton2.Enabled = true;
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Binary >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("1,2,3,4,5,6,7");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Operation Cost >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("2 Credits");
				Form1.String_75 = Conversions.ToString(2);
				Form1.String_74 = "2 Credits";
			}
			else if ("SM-A105G".Contains(device_info.model) && (device_info.secunumber.Contains("1") | device_info.secunumber.Contains("2") | device_info.secunumber.Contains("3") | device_info.secunumber.Contains("4") | device_info.secunumber.Contains("5") | device_info.secunumber.Contains("6") | device_info.secunumber.Contains("7")))
			{
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Operation >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("Direct Unlock");
				Form1.SharedUI.MaterialButton2.Enabled = true;
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Binary >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("1,2,3,4,5,6,7");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Operation Cost >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("3 Credits");
				Form1.String_75 = Conversions.ToString(3);
				Form1.String_74 = "3 Credits";
			}
			else if ("SM-A105M".Contains(device_info.model) && (device_info.secunumber.Contains("1") | device_info.secunumber.Contains("2") | device_info.secunumber.Contains("3") | device_info.secunumber.Contains("4")))
			{
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Operation >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("Direct Unlock");
				Form1.SharedUI.MaterialButton2.Enabled = true;
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Binary >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("1,2,3,4");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Operation Cost >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("2 Credits");
				Form1.String_75 = Conversions.ToString(2);
				Form1.String_74 = "2 Credits";
			}
			else if ("SM-A205F".Contains(device_info.model) && (device_info.secunumber.Contains("1") | device_info.secunumber.Contains("2") | device_info.secunumber.Contains("3") | device_info.secunumber.Contains("4") | device_info.secunumber.Contains("5") | device_info.secunumber.Contains("6") | device_info.secunumber.Contains("7") | device_info.secunumber.Contains("8")))
			{
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Operation >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("Direct Unlock");
				Form1.SharedUI.MaterialButton2.Enabled = true;
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Binary >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("1,2,3,4,5,6,7,8");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Operation Cost >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("3 Credits");
				Form1.String_75 = Conversions.ToString(3);
				Form1.String_74 = "3 Credits";
			}
			else if ("SM-A307G".Contains(device_info.model) && (device_info.secunumber.Contains("1") | device_info.secunumber.Contains("2") | device_info.secunumber.Contains("3") | device_info.secunumber.Contains("4")))
			{
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Operation >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("Direct Unlock");
				Form1.SharedUI.MaterialButton2.Enabled = true;
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Binary >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("1,2,3,4");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Operation Cost >> ");
				Form1.String_75 = Conversions.ToString(2);
				Form1.String_74 = "2 Credits";
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("2 Credits");
			}
			else if ("SM-A320F".Contains(device_info.model) && (device_info.secunumber.Contains("1") | device_info.secunumber.Contains("2") | device_info.secunumber.Contains("3") | device_info.secunumber.Contains("4") | device_info.secunumber.Contains("5") | device_info.secunumber.Contains("6") | device_info.secunumber.Contains("7")))
			{
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Operation >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("Direct Unlock");
				Form1.SharedUI.MaterialButton2.Enabled = true;
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Binary >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("1,2,3,4,5,6,7");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Operation Cost >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("3 Credits");
				Form1.String_75 = Conversions.ToString(3);
				Form1.String_74 = "3 Credits";
			}
			else if ("SM-A505G".Contains(device_info.model) && (device_info.secunumber.Contains("1") | device_info.secunumber.Contains("2") | device_info.secunumber.Contains("3") | device_info.secunumber.Contains("4") | device_info.secunumber.Contains("5")))
			{
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Operation >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("Direct Unlock");
				Form1.SharedUI.MaterialButton2.Enabled = true;
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Binary >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("1,2,3,4,5");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Operation Cost >> ");
				Form1.String_75 = Conversions.ToString(2);
				Form1.String_74 = "2 Credits";
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("2 Credits");
			}
			else if ("SM-A507F".Contains(device_info.model) && (device_info.secunumber.Contains("1") | device_info.secunumber.Contains("2") | device_info.secunumber.Contains("3") | device_info.secunumber.Contains("4")))
			{
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Operation >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("Direct Unlock");
				Form1.SharedUI.MaterialButton2.Enabled = true;
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Binary >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("1,2,3,4");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Operation Cost >> ");
				Form1.String_75 = Conversions.ToString(2);
				Form1.String_74 = "2 Credits";
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("2 Credits");
			}
			else if ("SM-A520F".Contains(device_info.model) && (device_info.secunumber.Contains("1") | device_info.secunumber.Contains("2") | device_info.secunumber.Contains("3") | device_info.secunumber.Contains("4") | device_info.secunumber.Contains("5") | device_info.secunumber.Contains("6") | device_info.secunumber.Contains("7") | device_info.secunumber.Contains("8") | device_info.secunumber.Contains("9") | device_info.secunumber.Contains("SA")))
			{
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Operation >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("Direct Unlock");
				Form1.SharedUI.MaterialButton2.Enabled = true;
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Binary >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("1,2,3,4,5,6,7,8,9,A");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Operation Cost >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("4 Credits");
				Form1.String_75 = Conversions.ToString(4);
				Form1.String_74 = "4 Credits";
			}
			else if ("SM-A520W".Contains(device_info.model) && (device_info.secunumber.Contains("1") | device_info.secunumber.Contains("2") | device_info.secunumber.Contains("3") | device_info.secunumber.Contains("4") | device_info.secunumber.Contains("5") | device_info.secunumber.Contains("6") | device_info.secunumber.Contains("7") | device_info.secunumber.Contains("8") | device_info.secunumber.Contains("9") | device_info.secunumber.Contains("SA") | device_info.secunumber.Contains("SB")))
			{
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Operation >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("Direct Unlock");
				Form1.SharedUI.MaterialButton2.Enabled = true;
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Binary >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("1,2,3,4,5,6,7,8,9,A");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Operation Cost >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("4 Credits");
				Form1.String_75 = Conversions.ToString(4);
				Form1.String_74 = "4 Credits";
			}
			else if ("SM-A600G".Contains(device_info.model) && (device_info.secunumber.Contains("1") | device_info.secunumber.Contains("2") | device_info.secunumber.Contains("3") | device_info.secunumber.Contains("4") | device_info.secunumber.Contains("5")))
			{
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Operation >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("Direct Unlock");
				Form1.SharedUI.MaterialButton2.Enabled = true;
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Binary >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("1,2,3,4,5");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Operation Cost >> ");
				Form1.String_75 = Conversions.ToString(2);
				Form1.String_74 = "2 Credits";
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("2 Credits");
			}
			else if ("SM-A720F".Contains(device_info.model) && (device_info.secunumber.Contains("1") | device_info.secunumber.Contains("2") | device_info.secunumber.Contains("3") | device_info.secunumber.Contains("4") | device_info.secunumber.Contains("5") | device_info.secunumber.Contains("6") | device_info.secunumber.Contains("7")))
			{
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Operation >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("Direct Unlock");
				Form1.SharedUI.MaterialButton2.Enabled = true;
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Binary >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("1,2,3,4,5,6,7");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Operation Cost >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("3 Credits");
				Form1.String_75 = Conversions.ToString(3);
				Form1.String_74 = "3 Credits";
			}
			else if ("SM-A730F".Contains(device_info.model) && (device_info.secunumber.Contains("1") | device_info.secunumber.Contains("2") | device_info.secunumber.Contains("3") | device_info.secunumber.Contains("4") | device_info.secunumber.Contains("5")))
			{
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Operation >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("Direct Unlock");
				Form1.SharedUI.MaterialButton2.Enabled = true;
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Binary >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("1,2,3,4,5");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Operation Cost >> ");
				Form1.String_75 = Conversions.ToString(2);
				Form1.String_74 = "2 Credits";
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("2 Credits");
			}
			else if ("SM-G390F".Contains(device_info.model) && (device_info.secunumber.Contains("1") | device_info.secunumber.Contains("2") | device_info.secunumber.Contains("3") | device_info.secunumber.Contains("4") | device_info.secunumber.Contains("5")))
			{
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Operation >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("Direct Unlock");
				Form1.SharedUI.MaterialButton2.Enabled = true;
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Binary >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("1,2,3,4,5");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Operation Cost >> ");
				Form1.String_75 = Conversions.ToString(2);
				Form1.String_74 = "2 Credits";
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("2 Credits");
			}
			else if ("SM-G570M".Contains(device_info.model) && (device_info.secunumber.Contains("1") | device_info.secunumber.Contains("2") | device_info.secunumber.Contains("3") | device_info.secunumber.Contains("4") | device_info.secunumber.Contains("5") | device_info.secunumber.Contains("6") | device_info.secunumber.Contains("7") | device_info.secunumber.Contains("8")))
			{
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Operation >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("Direct Unlock");
				Form1.SharedUI.MaterialButton2.Enabled = true;
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Binary >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("1,2,3,4,5,6,7,8");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Operation Cost >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("3 Credits");
				Form1.String_75 = Conversions.ToString(3);
				Form1.String_74 = "3 Credits";
			}
			else if ("SM-G930F".Contains(device_info.model) && (device_info.secunumber.Contains("1") | device_info.secunumber.Contains("2") | device_info.secunumber.Contains("3") | device_info.secunumber.Contains("4") | device_info.secunumber.Contains("5") | device_info.secunumber.Contains("6") | device_info.secunumber.Contains("7") | device_info.secunumber.Contains("8")))
			{
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Operation >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("Direct Unlock");
				Form1.SharedUI.MaterialButton2.Enabled = true;
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Binary >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("1,2,3,4,5,6,7,8");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Operation Cost >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("3 Credits");
				Form1.String_75 = Conversions.ToString(3);
				Form1.String_74 = "3 Credits";
			}
			else if ("SM-G935F".Contains(device_info.model) && (device_info.secunumber.Contains("1") | device_info.secunumber.Contains("2") | device_info.secunumber.Contains("3") | device_info.secunumber.Contains("4") | device_info.secunumber.Contains("5") | device_info.secunumber.Contains("6") | device_info.secunumber.Contains("7") | device_info.secunumber.Contains("8")))
			{
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Operation >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("Direct Unlock");
				Form1.SharedUI.MaterialButton2.Enabled = true;
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Binary >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("1,2,3,4,5,6,7,8");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Operation Cost >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("3 Credits");
				Form1.String_75 = Conversions.ToString(3);
				Form1.String_74 = "3 Credits";
			}
			else if ("SM-G960N".Contains(device_info.model) && device_info.secunumber.Contains("1"))
			{
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Operation >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("Direct Unlock");
				Form1.SharedUI.MaterialButton2.Enabled = true;
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Binary >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("1");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Operation Cost >> ");
				Form1.String_75 = Conversions.ToString(1);
				Form1.String_74 = "1 Credits";
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("1 Credits");
			}
			else if ("SM-G965N".Contains(device_info.model) && device_info.secunumber.Contains("1"))
			{
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Operation >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("Direct Unlock");
				Form1.SharedUI.MaterialButton2.Enabled = true;
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Binary >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("1");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Operation Cost >> ");
				Form1.String_75 = Conversions.ToString(1);
				Form1.String_74 = "1 Credits";
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("1 Credits");
			}
			else if ("SM-J327A-SM-J327AZ".Contains(device_info.model) && (device_info.secunumber.Contains("1") | device_info.secunumber.Contains("2") | device_info.secunumber.Contains("3") | device_info.secunumber.Contains("4")))
			{
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Operation >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("Direct Unlock");
				Form1.SharedUI.MaterialButton2.Enabled = true;
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Binary >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("1,2,3,4");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Operation Cost >> ");
				if (Operators.CompareString(SevaClass.StatusAcouunt, "Credits", TextCompare: false) == 0)
				{
					Form1.String_75 = Conversions.ToString(2);
					Form1.String_74 = "2 Credits";
					Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
					Form1.SharedUI.RichTextBox1.AppendText("2 Credits");
				}
				else
				{
					Form1.String_75 = Conversions.ToString(0);
					Form1.String_74 = "Free";
					Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
					Form1.SharedUI.RichTextBox1.AppendText("Annual Free");
				}
			}
			else if ("SM-J330F".Contains(device_info.model) && (device_info.secunumber.Contains("1") | device_info.secunumber.Contains("2") | device_info.secunumber.Contains("3")))
			{
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Operation >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("Direct Unlock");
				Form1.SharedUI.MaterialButton2.Enabled = true;
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Binary >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("1,2,3");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Operation Cost >> ");
				Form1.String_75 = Conversions.ToString(2);
				Form1.String_74 = "2 Credits";
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("2 Credits");
			}
			else if ("SM-J337T-SM-J337T1".Contains(device_info.model) && (device_info.secunumber.Contains("1") | device_info.secunumber.Contains("2") | device_info.secunumber.Contains("3") | device_info.secunumber.Contains("4") | device_info.secunumber.Contains("5") | device_info.secunumber.Contains("6") | device_info.secunumber.Contains("7") | device_info.secunumber.Contains("8")))
			{
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Operation >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("Direct Unlock");
				Form1.SharedUI.MaterialButton2.Enabled = true;
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Binary >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("1,2,3,4,5,6,7,8");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Operation Cost >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("3 Credits");
				Form1.String_75 = Conversions.ToString(3);
				Form1.String_74 = "3 Credits";
			}
			else if ("SM-J400F".Contains(device_info.model) && (device_info.secunumber.Contains("1") | device_info.secunumber.Contains("2") | device_info.secunumber.Contains("3")))
			{
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Operation >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("Direct Unlock");
				Form1.SharedUI.MaterialButton2.Enabled = true;
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Binary >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("1,2,3");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Operation Cost >> ");
				Form1.String_75 = Conversions.ToString(2);
				Form1.String_74 = "2 Credits";
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("2 Credits");
			}
			else if ("SM-J701F".Contains(device_info.model) && (device_info.secunumber.Contains("1") | device_info.secunumber.Contains("2") | device_info.secunumber.Contains("3") | device_info.secunumber.Contains("4") | device_info.secunumber.Contains("5") | device_info.secunumber.Contains("6") | device_info.secunumber.Contains("7") | device_info.secunumber.Contains("8")))
			{
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Operation >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("Direct Unlock");
				Form1.SharedUI.MaterialButton2.Enabled = true;
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Binary >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("1,2,3,4,5,6,7,8");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Operation Cost >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("3 Credits");
				Form1.String_75 = Conversions.ToString(3);
				Form1.String_74 = "3 Credits";
			}
			else if ("SM-J701M".Contains(device_info.model) && (device_info.secunumber.Contains("1") | device_info.secunumber.Contains("2") | device_info.secunumber.Contains("3") | device_info.secunumber.Contains("4") | device_info.secunumber.Contains("5") | device_info.secunumber.Contains("6") | device_info.secunumber.Contains("7") | device_info.secunumber.Contains("8")))
			{
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Operation >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("Direct Unlock");
				Form1.SharedUI.MaterialButton2.Enabled = true;
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Binary >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("1,2,3,4,5,6,7,8");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Operation Cost >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("3 Credits");
				Form1.String_75 = Conversions.ToString(3);
				Form1.String_74 = "3 Credits";
			}
			else if ("SM-J710M".Contains(device_info.model) && (device_info.secunumber.Contains("1") | device_info.secunumber.Contains("2") | device_info.secunumber.Contains("3") | device_info.secunumber.Contains("4")))
			{
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Operation >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("Direct Unlock");
				Form1.SharedUI.MaterialButton2.Enabled = true;
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Binary >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("1,2,3,4");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Operation Cost >> ");
				Form1.String_75 = Conversions.ToString(2);
				Form1.String_74 = "2 Credits";
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("2 Credits");
			}
			else if ("SM-J727AZ-SM-J727A".Contains(device_info.model) && (device_info.secunumber.Contains("1") | device_info.secunumber.Contains("2") | device_info.secunumber.Contains("3") | device_info.secunumber.Contains("4") | device_info.secunumber.Contains("5") | device_info.secunumber.Contains("6") | device_info.secunumber.Contains("7")))
			{
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Operation >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("Direct Unlock");
				Form1.SharedUI.MaterialButton2.Enabled = true;
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Binary >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("1,2,3,4,5,6,7");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Operation Cost >> ");
				Form1.String_75 = Conversions.ToString(2);
				Form1.String_74 = "2 Credits";
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("2 Credits");
			}
			else if ("SM-J727T-SM-J727T1".Contains(device_info.model) && (device_info.secunumber.Contains("1") | device_info.secunumber.Contains("2") | device_info.secunumber.Contains("3") | device_info.secunumber.Contains("4") | device_info.secunumber.Contains("5") | device_info.secunumber.Contains("6") | device_info.secunumber.Contains("7")))
			{
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Operation >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("Direct Unlock");
				Form1.SharedUI.MaterialButton2.Enabled = true;
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Binary >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("1,2,3,4,5,6,7");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Operation Cost >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("2 Credits");
				Form1.String_75 = Conversions.ToString(2);
				Form1.String_74 = "2 Credits";
			}
			else if ("SM-M105F".Contains(device_info.model) && (device_info.secunumber.Contains("1") | device_info.secunumber.Contains("2") | device_info.secunumber.Contains("3")))
			{
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Operation >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("Direct Unlock");
				Form1.SharedUI.MaterialButton2.Enabled = true;
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Binary >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("1,2,3");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Operation Cost >> ");
				Form1.String_75 = Conversions.ToString(2);
				Form1.String_74 = "2 Credits";
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("2 Credits");
			}
			else if ("SM-M205F".Contains(device_info.model) && (device_info.secunumber.Contains("1") | device_info.secunumber.Contains("2") | device_info.secunumber.Contains("3") | device_info.secunumber.Contains("4")))
			{
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Operation >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("Direct Unlock");
				Form1.SharedUI.MaterialButton2.Enabled = true;
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Binary >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("1,2,3,4");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Operation Cost >> ");
				Form1.String_75 = Conversions.ToString(2);
				Form1.String_74 = "2 Credits";
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("2 Credits");
			}
			else if ("SM-M205G".Contains(device_info.model) && device_info.secunumber.Contains("1"))
			{
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Operation >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("Direct Unlock");
				Form1.SharedUI.MaterialButton2.Enabled = true;
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Binary >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("1");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Operation Cost >> ");
				Form1.String_75 = Conversions.ToString(1);
				Form1.String_74 = "1 Credits";
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("1 Credits");
			}
			else if ("SM-M315F".Contains(device_info.model) && device_info.secunumber.Contains("1"))
			{
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Operation >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("Direct Unlock");
				Form1.SharedUI.MaterialButton2.Enabled = true;
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Binary >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("1");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Operation Cost >> ");
				Form1.String_75 = Conversions.ToString(1);
				Form1.String_74 = "1 Credits";
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("1 Credits");
			}
			else if ("SM-N770F".Contains(device_info.model) && (device_info.secunumber.Contains("1") | device_info.secunumber.Contains("2")))
			{
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Operation >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("Direct Unlock");
				Form1.SharedUI.MaterialButton2.Enabled = true;
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Binary >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("1,2");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Operation Cost >> ");
				Form1.String_75 = Conversions.ToString(1);
				Form1.String_74 = "1 Credits";
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("1 Credits");
			}
			else if ("SM-N950N".Contains(device_info.model) && (device_info.secunumber.Contains("1") | device_info.secunumber.Contains("2") | device_info.secunumber.Contains("3") | device_info.secunumber.Contains("4") | device_info.secunumber.Contains("5")))
			{
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Operation >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("Direct Unlock");
				Form1.SharedUI.MaterialButton2.Enabled = true;
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Binary >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("1,2,3,4,5");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Operation Cost >> ");
				Form1.String_75 = Conversions.ToString(2);
				Form1.String_74 = "2 Credits";
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("2 Credits");
			}
			else if ("SM-N960N".Contains(device_info.model) && (device_info.secunumber.Contains("1") | device_info.secunumber.Contains("2") | device_info.secunumber.Contains("3")))
			{
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Operation >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("Direct Unlock");
				Form1.SharedUI.MaterialButton2.Enabled = true;
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Binary >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("1,2,3");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Operation Cost >> ");
				Form1.String_75 = Conversions.ToString(2);
				Form1.String_74 = "2 Credits";
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("2 Credits");
			}
			else if ("SM-S102DL".Contains(device_info.model) && (device_info.secunumber.Contains("1") | device_info.secunumber.Contains("2") | device_info.secunumber.Contains("3") | device_info.secunumber.Contains("4") | device_info.secunumber.Contains("5")))
			{
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Operation >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("Direct Unlock");
				Form1.SharedUI.MaterialButton2.Enabled = true;
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Binary >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("1,2,3,4,5");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Operation Cost >> ");
				if (Operators.CompareString(SevaClass.StatusAcouunt, "Credits", TextCompare: false) == 0)
				{
					Form1.String_75 = Conversions.ToString(1);
					Form1.String_74 = "1 Credits";
					Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
					Form1.SharedUI.RichTextBox1.AppendText("1 Credits");
				}
				else
				{
					Form1.String_75 = Conversions.ToString(0);
					Form1.String_74 = "Free";
					Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
					Form1.SharedUI.RichTextBox1.AppendText("Annual Free");
				}
			}
			else if ("SM-S367VL".Contains(device_info.model) && (device_info.secunumber.Contains("1") | device_info.secunumber.Contains("2") | device_info.secunumber.Contains("3") | device_info.secunumber.Contains("4") | device_info.secunumber.Contains("5") | device_info.secunumber.Contains("6")))
			{
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Operation >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("Direct Unlock");
				Form1.SharedUI.MaterialButton2.Enabled = true;
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Binary >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("1,2,3,4,5,6");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Operation Cost >> ");
				if (Operators.CompareString(SevaClass.StatusAcouunt, "Credits", TextCompare: false) == 0)
				{
					Form1.String_75 = Conversions.ToString(1);
					Form1.String_74 = "1 Credits";
					Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
					Form1.SharedUI.RichTextBox1.AppendText("1 Credits");
				}
				else
				{
					Form1.String_75 = Conversions.ToString(0);
					Form1.String_74 = "Free";
					Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
					Form1.SharedUI.RichTextBox1.AppendText("Annual Free");
				}
			}
			else if ("SM-S767VL".Contains(device_info.model) && (device_info.secunumber.Contains("1") | device_info.secunumber.Contains("2") | device_info.secunumber.Contains("3") | device_info.secunumber.Contains("4") | device_info.secunumber.Contains("5") | device_info.secunumber.Contains("6") | device_info.secunumber.Contains("7")))
			{
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Operation >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("Direct Unlock");
				Form1.SharedUI.MaterialButton2.Enabled = true;
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Binary >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("1,2,3,4,5,6,7");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Operation Cost >> ");
				if (Operators.CompareString(SevaClass.StatusAcouunt, "Credits", TextCompare: false) == 0)
				{
					Form1.String_75 = Conversions.ToString(1);
					Form1.String_74 = "1 Credits";
					Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
					Form1.SharedUI.RichTextBox1.AppendText("1 Credits");
				}
				else
				{
					Form1.String_75 = Conversions.ToString(0);
					Form1.String_74 = "Free";
					Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
					Form1.SharedUI.RichTextBox1.AppendText("Annual Free");
				}
			}
			else if ("SM-A205G".Contains(device_info.model) && (device_info.secunumber.Contains("1") | device_info.secunumber.Contains("2") | device_info.secunumber.Contains("3") | device_info.secunumber.Contains("4") | device_info.secunumber.Contains("5") | device_info.secunumber.Contains("6")))
			{
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Operation >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("Direct Unlock");
				Form1.SharedUI.MaterialButton2.Enabled = true;
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Binary >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("1,2,3,4,5,6");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Operation Cost >> ");
				Form1.String_75 = Conversions.ToString(2);
				Form1.String_74 = "2 Credits";
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("2 Credits");
			}
			else if ("SM-A600T1-SM-A600T".Contains(device_info.model) && (device_info.secunumber.Contains("1") | device_info.secunumber.Contains("2") | device_info.secunumber.Contains("3") | device_info.secunumber.Contains("4") | device_info.secunumber.Contains("5")))
			{
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Operation >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("Direct Unlock");
				Form1.SharedUI.MaterialButton2.Enabled = true;
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Binary >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("1,2,3,4,5");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Operation Cost >> ");
				Form1.String_75 = Conversions.ToString(2);
				Form1.String_74 = "2 Credits";
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("2 Credits");
			}
			else if ("SM-G970F".Contains(device_info.model) && (device_info.secunumber.Contains("1") | device_info.secunumber.Contains("2") | device_info.secunumber.Contains("3") | device_info.secunumber.Contains("4") | device_info.secunumber.Contains("5") | device_info.secunumber.Contains("6") | device_info.secunumber.Contains("7")))
			{
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Operation >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("Direct Unlock");
				Form1.SharedUI.MaterialButton2.Enabled = true;
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Binary >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("1,2,3,4,5,6,7");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Operation Cost >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("3 Credits");
				Form1.String_75 = Conversions.ToString(3);
				Form1.String_74 = "3 Credits";
			}
			else if ("SM-J260A".Contains(device_info.model) && (device_info.secunumber.Contains("1") | device_info.secunumber.Contains("2") | device_info.secunumber.Contains("3") | device_info.secunumber.Contains("4") | device_info.secunumber.Contains("5") | device_info.secunumber.Contains("6") | device_info.secunumber.Contains("7") | device_info.secunumber.Contains("8") | device_info.secunumber.Contains("9")))
			{
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Operation >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("Direct Unlock");
				Form1.SharedUI.MaterialButton2.Enabled = true;
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Binary >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("1,2,3,4,5,6,7,8,9");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Operation Cost >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("3 Credits");
				Form1.String_75 = Conversions.ToString(3);
				Form1.String_74 = "3 Credits";
			}
			else if ("SM-J260T1-SM-J260T".Contains(device_info.model) && (device_info.secunumber.Contains("1") | device_info.secunumber.Contains("2") | device_info.secunumber.Contains("3") | device_info.secunumber.Contains("4") | device_info.secunumber.Contains("5")))
			{
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Operation >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("Direct Unlock");
				Form1.SharedUI.MaterialButton2.Enabled = true;
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Binary >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("1,2,3,4,5");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Operation Cost >> ");
				Form1.String_75 = Conversions.ToString(2);
				Form1.String_74 = "2 Credits";
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("2 Credits");
			}
			else if ("SM-J737T1-SM-J737T".Contains(device_info.model) && (device_info.secunumber.Contains("1") | device_info.secunumber.Contains("2") | device_info.secunumber.Contains("3") | device_info.secunumber.Contains("4") | device_info.secunumber.Contains("5") | device_info.secunumber.Contains("6") | device_info.secunumber.Contains("7") | device_info.secunumber.Contains("8")))
			{
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Operation >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("Direct Unlock");
				Form1.SharedUI.MaterialButton2.Enabled = true;
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Binary >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("1,2,3,4,5,6,7,8");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Operation Cost >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("2 Credits");
				Form1.String_75 = Conversions.ToString(2);
				Form1.String_74 = "2 Credits";
			}
			else if ("SM-N976B".Contains(device_info.model) && (device_info.secunumber.Contains("1") | device_info.secunumber.Contains("2") | device_info.secunumber.Contains("3") | device_info.secunumber.Contains("4") | device_info.secunumber.Contains("5")))
			{
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Operation >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("Direct Unlock");
				Form1.SharedUI.MaterialButton2.Enabled = true;
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Binary >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("1,2,3,4,5");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Operation Cost >> ");
				Form1.String_75 = Conversions.ToString(2);
				Form1.String_74 = "2 Credits";
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("2 Credits");
			}
			else if ("SM-S260DL".Contains(device_info.model) && (device_info.secunumber.Contains("1") | device_info.secunumber.Contains("2") | device_info.secunumber.Contains("3") | device_info.secunumber.Contains("4") | device_info.secunumber.Contains("5") | device_info.secunumber.Contains("6")))
			{
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Operation >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("Direct Unlock");
				Form1.SharedUI.MaterialButton2.Enabled = true;
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Binary >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("1,2,3,4,5,6");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Operation Cost >> ");
				if (Operators.CompareString(SevaClass.StatusAcouunt, "Credits", TextCompare: false) == 0)
				{
					Form1.String_75 = Conversions.ToString(1);
					Form1.String_74 = "1 Credits";
					Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
					Form1.SharedUI.RichTextBox1.AppendText("1 Credits");
				}
				else
				{
					Form1.String_75 = Conversions.ToString(0);
					Form1.String_74 = "Free";
					Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
					Form1.SharedUI.RichTextBox1.AppendText("Annual Free");
				}
			}
			else if ("SM-S357BL".Contains(device_info.model) && (device_info.secunumber.Contains("1") | device_info.secunumber.Contains("2") | device_info.secunumber.Contains("3") | device_info.secunumber.Contains("4") | device_info.secunumber.Contains("5") | device_info.secunumber.Contains("6")))
			{
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Operation >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("Direct Unlock");
				Form1.SharedUI.MaterialButton2.Enabled = true;
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Binary >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("1,2,3,4,5,6");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Operation Cost >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("2 Credits");
				Form1.String_75 = Conversions.ToString(2);
				Form1.String_74 = "2 Credits";
			}
			else if ("SM-S506DL".Contains(device_info.model) && (device_info.secunumber.Contains("1") | device_info.secunumber.Contains("2") | device_info.secunumber.Contains("3") | device_info.secunumber.Contains("4") | device_info.secunumber.Contains("5") | device_info.secunumber.Contains("6")))
			{
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Operation >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("Direct Unlock");
				Form1.SharedUI.MaterialButton2.Enabled = true;
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Binary >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("1,2,3,4,5,6");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Operation Cost >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("2 Credits");
				Form1.String_75 = Conversions.ToString(2);
				Form1.String_74 = "2 Credits";
			}
			else if ("SM-S737TL".Contains(device_info.model) && (device_info.secunumber.Contains("1") | device_info.secunumber.Contains("2") | device_info.secunumber.Contains("3") | device_info.secunumber.Contains("4") | device_info.secunumber.Contains("5") | device_info.secunumber.Contains("6") | device_info.secunumber.Contains("7") | device_info.secunumber.Contains("8")))
			{
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Operation >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("Direct Unlock");
				Form1.SharedUI.MaterialButton2.Enabled = true;
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Binary >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("1,2,3,4,5,6,7,8");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Operation Cost >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("3 Credits");
				Form1.String_75 = Conversions.ToString(3);
				Form1.String_74 = "3 Credits";
			}
			else if ("SM-S757BL".Contains(device_info.model) && (device_info.secunumber.Contains("1") | device_info.secunumber.Contains("2") | device_info.secunumber.Contains("3") | device_info.secunumber.Contains("4") | device_info.secunumber.Contains("5") | device_info.secunumber.Contains("6")))
			{
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Operation >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("Direct Unlock");
				Form1.SharedUI.MaterialButton2.Enabled = true;
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Binary >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("1,2,3,4,5,6");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Operation Cost >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("2 Credits");
				Form1.String_75 = Conversions.ToString(2);
				Form1.String_74 = "2 Credits";
			}
			else if ("SM-S205DL".Contains(device_info.model) && (device_info.secunumber.Contains("1") | device_info.secunumber.Contains("2") | device_info.secunumber.Contains("3") | device_info.secunumber.Contains("4") | device_info.secunumber.Contains("5")))
			{
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Operation >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("Direct Unlock");
				Form1.SharedUI.MaterialButton2.Enabled = true;
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Binary >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("1,2,3,4,5");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Operation Cost >> ");
				if (Operators.CompareString(SevaClass.StatusAcouunt, "Credits", TextCompare: false) == 0)
				{
					Form1.String_75 = Conversions.ToString(1);
					Form1.String_74 = "1 Credits";
					Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
					Form1.SharedUI.RichTextBox1.AppendText("1 Credits");
				}
				else
				{
					Form1.String_75 = Conversions.ToString(0);
					Form1.String_74 = "Free";
					Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
					Form1.SharedUI.RichTextBox1.AppendText("Annual Free");
				}
			}
			else
			{
				if (!"SM-J337A-SM-J337AZ".Contains(device_info.model) || !(device_info.secunumber.Contains("1") | device_info.secunumber.Contains("2") | device_info.secunumber.Contains("3") | device_info.secunumber.Contains("4") | device_info.secunumber.Contains("5") | device_info.secunumber.Contains("6") | device_info.secunumber.Contains("7") | device_info.secunumber.Contains("8") | device_info.secunumber.Contains("9") | device_info.secunumber.Contains("SA") | device_info.secunumber.Contains("UA")))
				{
					goto IL_108e2;
				}
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Operation >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("Direct Unlock");
				Form1.SharedUI.MaterialButton2.Enabled = true;
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Binary >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("1,2,3,4,5,6,7,8,9,A");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
				Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Operation Cost >> ");
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("3 Credits");
				Form1.String_75 = Conversions.ToString(3);
				Form1.String_74 = "3 Credits";
			}
		}
		goto IL_11717;
		IL_1ab6:
		if (!"SM-A037U-SM-A037U1".Contains(device_info.model))
		{
			goto IL_1fa8;
		}
		if (device_info.Carrier.Contains("TMB") | device_info.Carrier.Contains("TMK") | device_info.Carrier.Contains("DSH") | device_info.Carrier.Contains("APP") | device_info.Carrier.Contains("AIO") | device_info.Carrier.Contains("XAA") | device_info.Carrier.Contains("XAU") | device_info.Carrier.Contains("VZW") | device_info.Carrier.Contains("USC"))
		{
			if (!(device_info.secunumber.Contains("1") | device_info.secunumber.Contains("2")))
			{
				goto IL_1fa8;
			}
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
			Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Operation >> ");
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
			Form1.SharedUI.RichTextBox1.AppendText("Direct Unlock");
			Form1.SharedUI.MaterialButton2.Enabled = true;
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
			Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Carrier >> ");
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
			Form1.SharedUI.RichTextBox1.AppendText("TMB,TMK,APP,AIO,XAU,XAA,VZW,DSH,USC");
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
			Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Binary >> ");
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
			Form1.SharedUI.RichTextBox1.AppendText("1,2");
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
			Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Operation Cost >> ");
			if (Operators.CompareString(SevaClass.StatusAcouunt, "Credits", TextCompare: false) == 0)
			{
				Form1.String_75 = Conversions.ToString(2);
				Form1.String_74 = "2 Credits";
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("2 Credits");
			}
			else
			{
				Form1.String_75 = Conversions.ToString(0);
				Form1.String_74 = "Free";
				Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
				Form1.SharedUI.RichTextBox1.AppendText("Annual Free");
			}
		}
		else
		{
			if (device_info.security_patch.Contains("2019") | device_info.security_patch.Contains("2020") | device_info.security_patch.Contains("2021") | device_info.security_patch.Contains("2022") | device_info.security_patch.Contains("2023") | device_info.security_patch.Contains("2023-01") | device_info.security_patch.Contains("2023-02") | device_info.security_patch.Contains("2023-03") | device_info.security_patch.Contains("2023-04") | device_info.security_patch.Contains("2023-05"))
			{
				goto IL_1fa8;
			}
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
			Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Operation >> ");
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
			Form1.SharedUI.RichTextBox1.AppendText("Direct Unlock");
			Form1.SharedUI.MaterialButton2.Enabled = true;
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
			Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Carrier >> ");
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
			Form1.SharedUI.RichTextBox1.AppendText("ATT,CHA,BAA,LLA");
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
			Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Supported Binary >> ");
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
			Form1.SharedUI.RichTextBox1.AppendText("All");
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.White;
			Form1.SharedUI.RichTextBox1.AppendText(Environment.NewLine + " -- Operation Cost >> ");
			Form1.SharedUI.RichTextBox1.SelectionColor = Color.FromArgb(21, 87, 255);
			Form1.SharedUI.RichTextBox1.AppendText("4 Credits");
			Form1.String_75 = Conversions.ToString(4);
			MtkTask.Mhetod = "2";
			Form1.String_74 = "4 Credits";
		}
		goto IL_11717;
	}

	public static object Method21()
	{
		Form1.String_75 = Conversions.ToString(0);
		Form1.String_74 = "";
		MtkTask.Mhetod = "1";
		Form1.SharedUI.ProgressBar1.Text = "Check Model From Server...";
		if ("TMAF035G-SL104D-REVVL V+ 5G-TMRVL4G-WTCELERO5G-Z6250CC-Z5156CC-Z5156C-STTM21VAPP-HPPL60A-EABF22206A-22041219NY-M2101K7BG-M2006C3MG-M2004J19C-M2003J15SC-M2006C3LG-M2101K7BI-M2101K7BL-M2101K7BI-21061119AL-Z5158-EA211005-REVVL 6 5G-REVVL 6 PRO 5G-TMAF025G-Z3153V-Z5157V-M2101K7BL-21061119AL-Z6250CC-TMRVL4-EC211003-EC211001-EC211004-EA211001-EA211002-EC211002-EC1002-EA1002".Contains(device_info.model))
		{
			MtkTask.Mhetod = "2";
			Form1.String_75 = Conversions.ToString(2);
			Form1.String_74 = "2 Credits";
		}
		else if ("Typhoon_C6-Stratus_C5_Elite-Stratus_C5-Stratus_C7-Stratus_C7_Elite-DL4-DL4s".Contains(device_info.model))
		{
			Method23();
			Form1.String_75 = Conversions.ToString(2);
			Form1.String_74 = "2 Credits";
		}
		else if ("SL112A-SL112C-SL004T-SL219A-SL219C-SL100EA-U380AA-U380AC-SL101AE-SN304AE-U680AC".Contains(device_info.model))
		{
			Method23();
			Form1.String_75 = Conversions.ToString(4);
			Form1.String_74 = "4 Credits";
		}
		else if ("4188C-4188R-T10M-V22-Z22-V22S-ZTAB10-VORTEX CM62-CG65-CMG101-HD65-HD55-HD65_PLUS-HD65_Select-HD65_Ultra-VORTEX HD65 Choice-HD60-HD60i-HD60l-HD62-T10M_Pro-T10M_Pro_Plus-T10M Pro-T10M Pro Plus-Z23-V23-ZG65-ZG65H-ZG65 Pro-ZG55-BTAB10-BTAB0".Contains(device_info.model))
		{
			Method23();
			Form1.String_75 = Conversions.ToString(3);
			Form1.String_74 = "3 Credits";
		}
		else if ("CP3669AS-CP3669A".Contains(device_info.model))
		{
			Method23();
			Form1.String_75 = Conversions.ToString(2);
			Form1.String_74 = "2 Credits";
		}
		else if ("S11-S24-S25-S35-S32 Plus-S34-S64".Contains(device_info.model))
		{
			Method23();
			Form1.String_75 = Conversions.ToString(2);
			Form1.String_74 = "2 Credits";
		}
		else if ("Cyclone_C4-N5502LA-A10LP-A10L-A10LP_R".Contains(device_info.model))
		{
			Method23();
			Form1.String_75 = Conversions.ToString(2);
			Form1.String_74 = "2 Credits";
		}
		else if ("5087Z".Contains(device_info.model))
		{
			Method23();
			Form1.String_75 = Conversions.ToString(2);
			Form1.String_74 = "2 Credits";
		}
		else
		{
			if (!"SM-A136U-SM-A136U1".Contains(device_info.model))
			{
				goto IL_032b;
			}
			if (device_info.Carrier.Contains("TMB") | device_info.Carrier.Contains("TMK") | device_info.Carrier.Contains("DSH") | device_info.Carrier.Contains("APP") | device_info.Carrier.Contains("AIO") | device_info.Carrier.Contains("XAA") | device_info.Carrier.Contains("XAU") | device_info.Carrier.Contains("VZW") | device_info.Carrier.Contains("USC"))
			{
				if (!(device_info.secunumber.Contains("1") | device_info.secunumber.Contains("2")))
				{
					goto IL_032b;
				}
				if (Operators.CompareString(SevaClass.StatusAcouunt, "Credits", TextCompare: false) == 0)
				{
					Form1.String_75 = Conversions.ToString(2);
					Form1.String_74 = "2 Credits";
				}
				else
				{
					Form1.String_75 = Conversions.ToString(0);
					Form1.String_74 = "Free";
				}
				Method23();
			}
			else if (Operators.CompareString(SevaClass.IDRegistration, "20FE3617DFDB889949D92DA42956B357", TextCompare: false) == 0)
			{
				Form1.String_75 = Conversions.ToString(0);
				MtkTask.Mhetod = "2";
				Form1.String_74 = "0 Credits";
			}
			else
			{
				Form1.String_75 = Conversions.ToString(4);
				MtkTask.Mhetod = "2";
				Form1.String_74 = "4 Credits";
			}
		}
		goto IL_4f69;
		IL_4f69:
		object result = default(object);
		return result;
		IL_4cd4:
		if ("SM-N960U-SM-G960U-SM-G965U-SM-A025U-SM-N960U1-SM-G960U1-SM-G965U1-SM-A025U1".Contains(device_info.model) && (device_info.Carrier.Contains("SPR") | device_info.Carrier.Contains("BST") | device_info.Carrier.Contains("DSH")))
		{
			if (Operators.CompareString(SevaClass.StatusAcouunt, "Credits", TextCompare: false) == 0)
			{
				Form1.String_75 = Conversions.ToString(2);
				Form1.String_74 = "2 Credits";
			}
			else
			{
				Form1.String_75 = Conversions.ToString(0);
				Form1.String_74 = "Free";
			}
		}
		else if ("SM-A125U-SM-A125U1-SM-S127DL-SM-A125M-SM-A125F".Contains(device_info.model))
		{
			MtkTask.Mhetod = "2";
			if ((Operators.CompareString(SevaClass.IDRegistration, "13E8F68F620484E7F155A3BEC8D42EF7", TextCompare: false) == 0) | (Operators.CompareString(SevaClass.IDRegistration, "3C412AF011B2D4A436AC56E4C28414CB", TextCompare: false) == 0) | (Operators.CompareString(SevaClass.IDRegistration, "20FE3617DFDB889949D92DA42956B357", TextCompare: false) == 0))
			{
				Form1.String_75 = Conversions.ToString(0);
				Form1.String_74 = "0 Credits";
			}
			else
			{
				Form1.String_75 = Conversions.ToString(4);
				Form1.String_74 = "4 Credits";
			}
		}
		else if ("SM-A102U-SM-A205U-SM-A505U-SM-A102U1-SM-A205U1-SM-A505U1".Contains(device_info.model) && (device_info.Carrier.Contains("SPR") | device_info.Carrier.Contains("BST")) && (device_info.secunumber.Contains("1") | device_info.secunumber.Contains("2") | device_info.secunumber.Contains("3") | device_info.secunumber.Contains("4") | device_info.secunumber.Contains("5")))
		{
			if (Operators.CompareString(SevaClass.StatusAcouunt, "Credits", TextCompare: false) == 0)
			{
				Form1.String_75 = Conversions.ToString(2);
				Form1.String_74 = "2 Credits";
			}
			else
			{
				Form1.String_75 = Conversions.ToString(0);
				Form1.String_74 = "Free";
			}
		}
		else if ("SM-N920P-SM-N920T-SM-N920T1-SM-G920T-SM-G920T1-SM-G925T-SM-G925T1-SM-G928T-SM-G928T1-SM-J700T-SM-J700T1-SM-G550T-SM-G550T1-SM-G530T-SM-G360T-SM-G530T1-SM-G360T1".Contains(device_info.model))
		{
			if (Operators.CompareString(SevaClass.StatusAcouunt, "Credits", TextCompare: false) == 0)
			{
				Form1.String_75 = Conversions.ToString(1);
				Form1.String_74 = "1 Credits";
			}
			else
			{
				Form1.String_75 = Conversions.ToString(0);
				Form1.String_74 = "Free";
			}
		}
		else if ("SM-J727V-SM-J727VPP-SM-J727P-SM-J327V-SM-G930VL-SM-J327VPP-SM-S120VL-SM-S320VL-SM-N930A-SM-N930T-SM-N930P-SM-N930V-SM-N930A-SM-N930R4-SM-N930R6-SM-N930W8-SM-N930T1-SM-G891A-SM-G891V-SM-G891U-SM-G892A-SM-G892V-SM-G892U-SM-G950U-SM-N950U1-SM-N950U-SM-G930V-SM-G930U-SM-G930T1-SM-G930R4-SM-G930R6-SM-G930A-SM-G930P-SM-G950U-SM-N950U1-SM-G955U1-SM-G950U1-SM-G950W-SM-G950D-SM-N950U-SC-01K-SC-02K-SC-03K-SM-G955U-SM-G955W-SC-03J-SM-N9500-SM-N950W-SC-02H-SC-02J-SCV33-SCV34-SCV35-SCV36-SCV35-SCV37-SCV38-SCV39-SC-02K-SC-03K-SM-G935V-SM-G935T-SM-G935A-SM-G935P-SM-G935U-SM-G9350-SM-G930V-SM-G930U-SM-G930T1-SM-G930R4-SM-G930R6-SM-G930A-SM-G930P-SM-G950U-SM-G955U1-SM-G950U1-SM-G950W-SM-G950D-SM-N950U-SM-G955U-SM-G955W-SM-G935V-SM-G935T-SM-G935A-SM-G935P-SM-G935U-SM-N950U1-SM-G930V-SM-G930U-SM-G930T1-SM-G930R4-SM-G930R6-SM-G930A-SM-G930P-SM-G950U-SM-N950U1-SM-G955U1-SM-G950U1-SM-G950W-SM-G950D-SM-N950U-SM-G955U-SM-G955W-N9500-SM-N950W-SM-G935V-SM-G935T-SM-G935A-SM-G935P-SM-G935U-SM-G9350-SM-J510F-SM-J510FN-SM-J510GN-SM-J510FQ-SM-J500F-SM-J500FN-SM-J500G-SM-J500H-SM-J500M-SM-J410F-SM-J410FN-SM-J410G-SM-J415F-SM-J415FN-SM-J415G-SM-J415GN-SM-J610F-SM-J610FN-SM-J610G-SM-J610GN-SM-A605F-SM-A605FD-SM-A605FN-SM-A605G-SM-A605GN-SM-J250F-SM-J250G-SM-J250M-SM-J250Y-SM-J250N-SM-T818A-SM-G9300-SM-G9500-SM-G9550-SM-N9500".Contains(device_info.model))
		{
			Method24();
			if (Operators.CompareString(SevaClass.StatusAcouunt, "Credits", TextCompare: false) == 0)
			{
				Form1.String_75 = Conversions.ToString(1);
				Form1.String_74 = "1 Credits";
			}
			else
			{
				Form1.String_75 = Conversions.ToString(0);
				Form1.String_74 = "Free";
			}
		}
		else
		{
			Form1.String_74 = "";
		}
		goto IL_4f69;
		IL_06c1:
		if (!"SM-A037U-SM-A037U1".Contains(device_info.model))
		{
			goto IL_0898;
		}
		if (device_info.Carrier.Contains("TMB") | device_info.Carrier.Contains("TMK") | device_info.Carrier.Contains("DSH") | device_info.Carrier.Contains("APP") | device_info.Carrier.Contains("AIO") | device_info.Carrier.Contains("XAA") | device_info.Carrier.Contains("XAU") | device_info.Carrier.Contains("VZW") | device_info.Carrier.Contains("USC"))
		{
			if (!(device_info.secunumber.Contains("1") | device_info.secunumber.Contains("2")))
			{
				goto IL_0898;
			}
			if (Operators.CompareString(SevaClass.StatusAcouunt, "Credits", TextCompare: false) == 0)
			{
				Form1.String_75 = Conversions.ToString(2);
				Form1.String_74 = "2 Credits";
			}
			else
			{
				Form1.String_75 = Conversions.ToString(0);
				Form1.String_74 = "Free";
			}
			Method23();
		}
		else
		{
			if (device_info.security_patch.Contains("2019") | device_info.security_patch.Contains("2020") | device_info.security_patch.Contains("2021") | device_info.security_patch.Contains("2022") | device_info.security_patch.Contains("2023") | device_info.security_patch.Contains("2023-01") | device_info.security_patch.Contains("2023-02") | device_info.security_patch.Contains("2023-03") | device_info.security_patch.Contains("2023-04") | device_info.security_patch.Contains("2023-05"))
			{
				goto IL_0898;
			}
			Form1.String_75 = Conversions.ToString(4);
			MtkTask.Mhetod = "2";
			Form1.String_74 = "4 Credits";
		}
		goto IL_4f69;
		IL_032b:
		if (!"SM-A326U-SM-A326U1".Contains(device_info.model))
		{
			goto IL_04fa;
		}
		if (device_info.Carrier.Contains("TMB") | device_info.Carrier.Contains("TMK") | device_info.Carrier.Contains("DSH") | device_info.Carrier.Contains("APP") | device_info.Carrier.Contains("AIO") | device_info.Carrier.Contains("XAA") | device_info.Carrier.Contains("XAU") | device_info.Carrier.Contains("VZW") | device_info.Carrier.Contains("USC"))
		{
			if (!(device_info.secunumber.Contains("1") | device_info.secunumber.Contains("2") | device_info.secunumber.Contains("3") | device_info.secunumber.Contains("4") | device_info.secunumber.Contains("5") | device_info.secunumber.Contains("6") | device_info.secunumber.Contains("7") | device_info.secunumber.Contains("8")))
			{
				goto IL_04fa;
			}
			if (Operators.CompareString(SevaClass.StatusAcouunt, "Credits", TextCompare: false) == 0)
			{
				Form1.String_75 = Conversions.ToString(2);
				Form1.String_74 = "2 Credits";
			}
			else
			{
				Form1.String_75 = Conversions.ToString(0);
				Form1.String_74 = "Free";
			}
			Method23();
		}
		else if (Operators.CompareString(SevaClass.IDRegistration, "20FE3617DFDB889949D92DA42956B357", TextCompare: false) == 0)
		{
			Form1.String_75 = Conversions.ToString(0);
			MtkTask.Mhetod = "2";
			Form1.String_74 = "0 Credits";
		}
		else
		{
			Form1.String_75 = Conversions.ToString(4);
			MtkTask.Mhetod = "2";
			Form1.String_74 = "4 Credits";
		}
		goto IL_4f69;
		IL_0898:
		if ("SM-E426B-SM-A325F-SM-A325M-SM-A325N-SM-A315G-SM-A315F".Contains(device_info.model))
		{
			Form1.String_75 = Conversions.ToString(4);
			MtkTask.Mhetod = "2";
			Form1.String_74 = "4 Credits";
		}
		else if ("SM-A136W-SM-A136S-SM-A136M-SM-A136B-SM-A225F-SM-A225M".Contains(device_info.model))
		{
			Form1.String_75 = Conversions.ToString(4);
			MtkTask.Mhetod = "2";
			Form1.String_74 = "4 Credits";
		}
		else if ("LM-Q710AL-LM-Q710P-Q710(FGN)-LG-Q710-LG-Q710AL-LG-Q710P-LG-Q710PL-LM-Q710PL".Contains(device_info.model))
		{
			Method23();
			if (device_info.security_patch.Contains("2020"))
			{
				Form1.String_75 = Conversions.ToString(2);
				Form1.String_74 = "2 Credits";
			}
			else if (Operators.CompareString(SevaClass.StatusAcouunt, "Credits", TextCompare: false) == 0)
			{
				Form1.String_75 = Conversions.ToString(1);
				Form1.String_74 = "1 Credits";
			}
			else
			{
				Form1.String_75 = Conversions.ToString(0);
				Form1.String_74 = "Free";
			}
		}
		else if ("LG-SP320-LG-SP200".Contains(device_info.model))
		{
			Method23();
			if (Operators.CompareString(SevaClass.StatusAcouunt, "Credits", TextCompare: false) == 0)
			{
				Form1.String_75 = Conversions.ToString(1);
				Form1.String_74 = "1 Credits";
			}
			else
			{
				Form1.String_75 = Conversions.ToString(0);
				Form1.String_74 = "Free";
			}
		}
		else if ("LM-Q720PS".Contains(device_info.model))
		{
			if (Operators.CompareString(SevaClass.StatusAcouunt, "Credits", TextCompare: false) == 0)
			{
				Form1.String_75 = Conversions.ToString(2);
				Form1.String_74 = "2 Credits";
			}
			else
			{
				Form1.String_75 = Conversions.ToString(0);
				Form1.String_74 = "Free";
			}
		}
		else if (device_info.model.Contains("LM-G810") | device_info.model.Contains("LM-G820") | device_info.model.Contains("LM-G850"))
		{
			if (Operators.CompareString(SevaClass.StatusAcouunt, "Credits", TextCompare: false) == 0)
			{
				Form1.String_75 = Conversions.ToString(2);
				Form1.String_74 = "2 Credits";
			}
			else
			{
				Form1.String_75 = Conversions.ToString(0);
				Form1.String_74 = "Free";
			}
		}
		else if (device_info.model.Contains("LM-X320PM") | device_info.model.Contains("CP3648A") | device_info.model.Contains("LG-LK460") | device_info.model.Contains("LM-X220PM") | device_info.model.Contains("LM-X410PM"))
		{
			if (Operators.CompareString(SevaClass.StatusAcouunt, "Credits", TextCompare: false) == 0)
			{
				Form1.String_75 = Conversions.ToString(2);
				Form1.String_74 = "2 Credits";
			}
			else
			{
				Form1.String_75 = Conversions.ToString(0);
				Form1.String_74 = "Free";
			}
		}
		else if ("LM-Q730-LM-Q730AM-LM-Q730AM4-LM-K300AM-LM-K400AM-LM-X420AS8-LM-G900TM-LM-G900UM-LM-X420AS-LM-X420CS-U202AA-U202AC-U304AA-U304AC-U318AA-U318AC-U325AA-U325AC-U326AA-U326AC-U705AA-U705AC-Nokia C2 Tennen-Nokia C2 Tava-Nokia C2-Nokia C5 Endi-Nokia C5-Nokia 2.3-Alcatel_5004R-Alcatel_5004C-Alcatel_5002C-Alcatel_5002R-Alcatel_5008R-Alcatel_5005R-Alcatel_5008C-5049W-5049Z-6062W-6062Z".Contains(device_info.model))
		{
			if ("LM-K300AM-LM-K400AM".Contains(device_info.model))
			{
				if (device_info.security_patch.Contains("2021-01") | device_info.security_patch.Contains("2021-02") | device_info.security_patch.Contains("2021-03") | device_info.security_patch.Contains("2021-04") | device_info.security_patch.Contains("2021-05") | device_info.security_patch.Contains("2021-06") | device_info.security_patch.Contains("2021-07"))
				{
					Form1.String_75 = Conversions.ToString(2);
					Form1.String_74 = "2 Credits";
				}
				else
				{
					Form1.String_75 = Conversions.ToString(1);
					Form1.String_74 = "1 Credits";
				}
			}
			else
			{
				Method23();
				Form1.String_75 = Conversions.ToString(2);
				Form1.String_74 = "2 Credits";
			}
		}
		else if ("LG-LS777-LG-LS992-LG-LS994-LGLS996-LG-LS998-LG-LS991-LM-V450-LM-G820-LM-G850-LM-V350".Contains(device_info.model))
		{
			if (Operators.CompareString(SevaClass.StatusAcouunt, "Credits", TextCompare: false) == 0)
			{
				Form1.String_75 = Conversions.ToString(2);
				Form1.String_74 = "2 Credits";
			}
			else
			{
				Form1.String_75 = Conversions.ToString(0);
				Form1.String_74 = "Free";
			}
		}
		else if ("LG-H631-LG-H443-LG-H324-LG-H320-LG-H340Y-LG-H340N-LG-H345-LG-MS345-LG-MS631-LG-K540".Contains(device_info.model))
		{
			Method23();
			if (Operators.CompareString(SevaClass.StatusAcouunt, "Credits", TextCompare: false) == 0)
			{
				Form1.String_75 = Conversions.ToString(1);
				Form1.String_74 = "1 Credits";
			}
			else
			{
				Form1.String_75 = Conversions.ToString(0);
				Form1.String_74 = "Free";
			}
		}
		else if (device_info.model.Contains("C210") | device_info.model.Contains("U614") | device_info.model.Contains("U616") | device_info.model.Contains("U300") | device_info.model.Contains("U520") | device_info.model.Contains("U307") | device_info.model.Contains("5085C"))
		{
			Method23();
			Form1.String_75 = Conversions.ToString(2);
			Form1.String_74 = "2 Credits";
		}
		else if ("5007Z-5007W".Contains(device_info.model))
		{
			Form1.String_75 = Conversions.ToString(2);
			Form1.String_74 = "2 Credits";
		}
		else if ("Pixel 3 XL-Pixel 3-Pixel3-Pixel 3-Pixel 4-Pixel 4 XL-Pixel 3 A-Pixel 3A-Pixel 6-Pixel 6 XL-Pixel 5-Pixel 4a XL (5G)-Pixel 4a XL-Pixel XL-Pixel 3a XL-Pixel 2-Pixel 2 XL-Pixel 1-Pixel 1 XL".Contains(device_info.model))
		{
			if (Operators.CompareString(SevaClass.StatusAcouunt, "Credits", TextCompare: false) == 0)
			{
				Form1.String_75 = Conversions.ToString(2);
				Form1.String_74 = "2 Credits";
			}
			else
			{
				Form1.String_75 = Conversions.ToString(0);
				Form1.String_74 = "Free";
			}
		}
		else if ("6125F-T676J-T766".Contains(device_info.model))
		{
			Method23();
			Form1.String_75 = Conversions.ToString(3);
			Form1.String_74 = "3 Credits";
		}
		else if (device_info.model.Contains("T767") | device_info.model.Contains("S6303L"))
		{
			Method23();
			Form1.String_75 = Conversions.ToString(3);
			Form1.String_74 = "3 Credits";
		}
		else if ("LM-Q730QN-LM-Q730QM-LM-Q730QM6-LM-Q730QN6-LM-Q730TM-LM-Q730MM-LM-K500QM6-LM-K500UM-LM-K500MM-LM-K510EMW-LM-X430HM-LM-K410HM-LM-K300QM6-LM-K300QM-LM-K300QM3-LM-K300QM2-LM-K300QM1-LM-K300QM4-LM-K300QM5-LM-K300TM-LM-K300MM-LM-K300UM-LM-K400AKR".Contains(device_info.model))
		{
			if (device_info.security_patch.Contains("2023") | device_info.security_patch.Contains("2022"))
			{
				if (Operators.CompareString(SevaClass.StatusAcouunt, "Credits", TextCompare: false) == 0)
				{
					Form1.String_75 = Conversions.ToString(2);
					Form1.String_74 = "2 Credits";
				}
				else
				{
					Form1.String_75 = Conversions.ToString(0);
					Form1.String_74 = "Free";
				}
			}
			if (device_info.security_patch.Contains("2020") | device_info.security_patch.Contains("2021"))
			{
				if (Operators.CompareString(SevaClass.StatusAcouunt, "Credits", TextCompare: false) == 0)
				{
					Form1.String_75 = Conversions.ToString(2);
					Form1.String_74 = "2 Credits";
				}
				else
				{
					Form1.String_75 = Conversions.ToString(0);
					Form1.String_74 = "Free";
				}
			}
		}
		else if ("LGL355DL-LGL455DL-LGL555DL".Contains(device_info.model))
		{
			Method23();
			if (device_info.security_patch.Contains("2023") | device_info.security_patch.Contains("2022"))
			{
				Form1.String_75 = Conversions.ToString(3);
				Form1.String_74 = "3 Credits";
			}
			if (device_info.security_patch.Contains("2020") | device_info.security_patch.Contains("2021"))
			{
				if (Operators.CompareString(SevaClass.StatusAcouunt, "Credits", TextCompare: false) == 0)
				{
					Form1.String_75 = Conversions.ToString(2);
					Form1.String_74 = "2 Credits";
				}
				else
				{
					Form1.String_75 = Conversions.ToString(0);
					Form1.String_74 = "Free";
				}
			}
		}
		else if ("GT-I9305-GT-I9305T-GT-I9305N-SGH-I747-SGH-I747M-SGH-T999-SGH-T999L-SGH-T999N-SGH-T999V-SM-G730A-SM-G730W8-GT-I9300I-GT-I9301I-GT-I9301Q-GT-I9195-GT-I9195L-GT-I9195T-GT-I9195H-GT-I9190-GT-I9192-GT-I9197-SGH-I257-SGH-I257M-SHV-E370K-SM-S890L-GT-I9515-GT-I9515L-GT-I9505-GT-I9505G-GT-I9506-GT-I9507-GT-I9508V-GT-I9295-SGH-I537-SHV-E470S-GT-I9508-SGH-I337-SGH-I337M-SGH-I337Z-SGH-M919-SGH-M919V-SGH-M919N-SGH-S970G-SM-S975L-SC-04E-SHV-E300L-SHV-E330K-SHV-E330L-SHV-E330S-SM-C105-SM-G900F-SM-G900A-SM-G900I-SM-G900K-SM-G900L-SM-G900T-SM-G900T1-SM-G900M-SM-G900MD-SM-G900AZ-SM-G900FD-SM-G900FQ-SM-G900W8-SC-04F-SM-G870A-SM-G870W-SM-G800H-SM-G800HQ-SM-G9006V-SM-G9008V-SM-G901F-SM-P605L-SM-P605-SM-P605M-SM-P607T-SM-P905-SM-P905M-SM-P907A-GT-N5120-GT-N8020-SGH-T889-SGH-T889V-SGH-I317-SGH-I317M-SHV-E250S-SHV-E250K-SHV-E250L-GT-N7105T-GT-N7105-SC-02E-SM-N7506V-SM-N7502-SM-N9005-SM-N9006-SM-N900A-SM-N900K-SM-N900L-SM-N900T-SM-N900W8-SM-N9002-SM-N9009-SM-N9008-SM-N9008S-SM-N9008V-SM-N900S-SC-01F-SM-N9100-SM-N910A-SM-N910T-SM-N9108V-SM-G386T1-SM-G386W-SM-G850A-SM-G850W-SM-G3139D-SM-G357FZ-SM-G7508Q-SM-T325-SM-T331-SM-T335-SM-T337A-SM-T337T-SM-T525-SM-T531-SM-T535-SM-T537A-SM-G530BT-SM-G530H-SM-G710-SM-G7105-SM-G7105L-SM-G7105H-SM-G7102-SM-G7102T-SM-G7106-SM-G7108-SM-G710K-SM-G710L-SM-G350L-SM-G350M-SM-G3586V-SM-G3588V-SM-G3502C-SM-G3502I-SM-G3502L-SM-G3502T-SM-G3508J-SM-G3815-SM-T215-SC-02F-GT-S7275R-GT-S7275B-GT-S7275T-GT-S7275Y-GT-S7272C-GT-I9152P-SGH-T699-SGH-T779-GT-I8730-GT-I8730T-SC-06D-SGH-I437-SGH-I437P-SGH-I437Z-SGH-I467-SGH-I467M-SGH-I547-SGH-I547C-GT-I8580-GT-I9128E-GT-I9158-GT-I9200-GT-I9208-SGH-I527-SGH-I527M-SGH-M819N-SM-T217A-SM-T217T-SM-T315-SHV-E400S-SC-03E-SM-S780L".Contains(device_info.model))
		{
			if (Operators.CompareString(SevaClass.StatusAcouunt, "Credits", TextCompare: false) == 0)
			{
				Form1.String_75 = Conversions.ToString(1);
				Form1.String_74 = "1 Credits";
			}
			else
			{
				Form1.String_75 = Conversions.ToString(0);
				Form1.String_74 = "Free";
			}
		}
		else if ("SM-S134DL-SM-S111DL-SM-S115DL-SM-S215DL-SM-S124DL".Contains(device_info.model))
		{
			if (Operators.CompareString(SevaClass.StatusAcouunt, "Credits", TextCompare: false) == 0)
			{
				Form1.String_75 = Conversions.ToString(2);
				Form1.String_74 = "2 Credits";
			}
			else
			{
				Form1.String_75 = Conversions.ToString(0);
				Form1.String_74 = "Free";
			}
		}
		else if ("SM-G970U-SM-G973U-SM-G975U-SM-G970U1-SM-G973U1-SM-G975U1".Contains(device_info.model))
		{
			if (Operators.CompareString(SevaClass.StatusAcouunt, "Credits", TextCompare: false) == 0)
			{
				Form1.String_75 = Conversions.ToString(2);
				Form1.String_74 = "2 Credits";
			}
			else
			{
				Form1.String_75 = Conversions.ToString(0);
				Form1.String_74 = "Free";
			}
		}
		else
		{
			if (!"SM-A045M-SM-A207M-SM-A207F-SM-A146B-SM-A037M-SM-A037F-SM-A115M-SM-A115F-SM-A025M-SM-A025F-SM-A045F-SM-A013M-SM-A013F-SM-A013G-SM-A015M-SM-A015F-SM-A025M-SM-A025F-SM-A025G-SM-A032M-SM-A032F-SM-A032G-SM-A035M-SM-A035F-SM-A035G-SM-A037F-SM-A037M-SM-A047F-SM-A047M-SM-A045F-SM-A045M-SM-A115M-SM-A115F-SM-A226B-SM-A226BR-SM-A107F-SM-A107M-SM-A207F-SM-A207M-SM-M013F-SM-M015F-SM-M015G-SM-M017F-SM-M022F-SM-A115U-SM-M022M-SM-M022G-SM-M025F-SM-M115F-SM-M115M-SM-A115A-SM-A037U-SM-A015A-SM-A015U-SM-A037U1-SM-A215U-SM-A215U1-SM-A146U-SM-A146U1-SM-A025V-SM-A025A".Contains(device_info.model))
			{
				goto IL_11b8;
			}
			if ("SM-A115A-SM-A115U-SM-A037U-SM-A015A-SM-A015U-SM-A037U1-SM-A146U-SM-A215U-SM-A215U1-SM-A146U1-SM-A025V-SM-A025A".Contains(device_info.model))
			{
				if (!(device_info.Carrier.Contains("ATT") | device_info.Carrier.Contains("CHA") | device_info.Carrier.Contains("CCT") | device_info.Carrier.Contains("LLA") | device_info.Carrier.Contains("PCT")))
				{
					goto IL_11b8;
				}
				Form1.String_75 = Conversions.ToString(3);
				Form1.String_74 = "3 Credits";
			}
			else
			{
				Form1.String_75 = Conversions.ToString(4);
				Form1.String_74 = "4 Credits";
			}
		}
		goto IL_4f69;
		IL_11b8:
		if ("SM-A115U-SM-A215U-SM-A115U1-SM-A215U1".Contains(device_info.model))
		{
			if ("SM-A215U-SM-A215U1".Contains(device_info.model))
			{
				if (device_info.secunumber.Contains("7") | device_info.secunumber.Contains("8"))
				{
					if (Operators.CompareString(SevaClass.StatusAcouunt, "Credits", TextCompare: false) == 0)
					{
						Form1.String_75 = Conversions.ToString(3);
						Form1.String_74 = "3 Credits";
					}
					else
					{
						Form1.String_75 = Conversions.ToString(0);
						Form1.String_74 = "Free";
					}
				}
				else if (Operators.CompareString(SevaClass.StatusAcouunt, "Credits", TextCompare: false) == 0)
				{
					Form1.String_75 = Conversions.ToString(1);
					Form1.String_74 = "1 Credits";
				}
				else
				{
					Form1.String_75 = Conversions.ToString(0);
					Form1.String_74 = "Free";
				}
			}
			else if (device_info.secunumber.Contains("7") | device_info.secunumber.Contains("8") | device_info.secunumber.Contains("9"))
			{
				Form1.String_75 = Conversions.ToString(2);
				Form1.String_74 = "2 Credits";
			}
			else if (Operators.CompareString(SevaClass.StatusAcouunt, "Credits", TextCompare: false) == 0)
			{
				Form1.String_75 = Conversions.ToString(1);
				Form1.String_74 = "1 Credits";
			}
			else
			{
				Form1.String_75 = Conversions.ToString(0);
				Form1.String_74 = "Free";
			}
		}
		else if ("LGLS775-LGLS665-LGLS676-LGLS675-LGLS770".Contains(device_info.model))
		{
			if (Operators.CompareString(SevaClass.StatusAcouunt, "Credits", TextCompare: false) == 0)
			{
				Form1.String_75 = Conversions.ToString(1);
				Form1.String_74 = "1 Credits";
			}
			else
			{
				Form1.String_75 = Conversions.ToString(0);
				Form1.String_74 = "Free";
			}
		}
		else if ("LG-LS777-LG-LS992-LG-LS994-LG-LS996-LG-LS998-LG-LS991-LM-V450-LM-G820-LM-G850-LM-V350".Contains(device_info.model))
		{
			if (Operators.CompareString(SevaClass.StatusAcouunt, "Credits", TextCompare: false) == 0)
			{
				Form1.String_75 = Conversions.ToString(2);
				Form1.String_74 = "2 Credits";
			}
			else
			{
				Form1.String_75 = Conversions.ToString(0);
				Form1.String_74 = "Free";
			}
		}
		else if ("LG-LS997-LG-LS755-LM-LS755-LG-LS993".Contains(device_info.model))
		{
			Form1.String_75 = Conversions.ToString(2);
			Form1.String_74 = "2 Credits";
		}
		else if ("SM-J320A-SM-J320AZ-SM-G920A-SM-G920AZ".Contains(device_info.model))
		{
			if (Operators.CompareString(SevaClass.StatusAcouunt, "Credits", TextCompare: false) == 0)
			{
				Form1.String_75 = Conversions.ToString(1);
				Form1.String_74 = "1 Credits";
			}
			else
			{
				Form1.String_75 = Conversions.ToString(0);
				Form1.String_74 = "Free";
			}
		}
		else if ("SM-J327T-SM-J327T1".Contains(device_info.model))
		{
			if (Operators.CompareString(SevaClass.StatusAcouunt, "Credits", TextCompare: false) == 0)
			{
				Form1.String_75 = Conversions.ToString(1);
				Form1.String_74 = "1 Credits";
			}
			else
			{
				Form1.String_75 = Conversions.ToString(0);
				Form1.String_74 = "Free";
			}
		}
		else if ("SM-G360T-SM-G360T1-SM-G530T-SM-G530T1".Contains(device_info.model))
		{
			if (Operators.CompareString(SevaClass.StatusAcouunt, "Credits", TextCompare: false) == 0)
			{
				Form1.String_75 = Conversions.ToString(1);
				Form1.String_74 = "1 Credits";
			}
			else
			{
				Form1.String_75 = Conversions.ToString(0);
				Form1.String_74 = "Free";
			}
		}
		else if ("SM-J320P".Contains(device_info.model))
		{
			if (Operators.CompareString(SevaClass.StatusAcouunt, "Credits", TextCompare: false) == 0)
			{
				Form1.String_75 = Conversions.ToString(1);
				Form1.String_74 = "1 Credits";
			}
			else
			{
				Form1.String_75 = Conversions.ToString(0);
				Form1.String_74 = "Free";
			}
		}
		else
		{
			if (!"SM-A105F-SM-A202F-SM-A205F-SM-A205Y-SM-A260F-SM-A260G-SM-A305G-SM-A505F-SM-A515F-SM-A515U-SM-A530F-SM-A600AZ-SM-A600A-SM-A600FN-SM-A750FN-SM-A750G-SM-G950F-SM-G955F-SM-G960F-SM-G965F-SM-G973F-SM-G975F-SM-G977B-SM-G980F-SM-G981B-SM-G985F-SM-G986B-SM-G988B-SM-J260G-SM-J260M-SM-J400M-SM-J600F-SM-J600G-SM-J730G-SM-J737A-SM-M105G-SM-N950F-SM-N960F-SM-N970F-SM-N975F-SM-J737VPP-SM-J337VPP-SM-A105G-SM-A105M-SM-A205F-SM-J337V-SM-J737V-SM-A307G-SM-A320F-SM-A505G-SM-A507F-SM-A515F-SM-A520F-SM-A520W-SM-A600G-SM-A720F-SM-A730F-SM-G390F-SM-G570M-SM-G930F-SM-G935F-SM-G950N-SM-G960N-SM-G965N-SM-J327A-SM-J327AZ-SM-J330F-SM-J337T-SM-J337T1-SM-J400F-SM-J701F-SM-J701M-SM-J710M-SM-J727AZ-SM-J727A-SM-J727T-SM-J727T1-SM-J737U-SM-M105F-SM-M205F-SM-M205G-SM-M315F-SM-N770F-SM-N950N-SM-N960N-SM-A102U-SM-S102DL-SM-S367VL-SM-S767VL-SM-A205G-SM-A505U1-SM-A600T1-SM-A600T-SM-G970F-SM-J260A-SM-J260T1-SM-J737T1-SM-J737T-SM-N976B-SM-S260DL-SM-S357BL-SM-S506DL-SM-S737TL-SM-S757BL-SM-S205DL-SM-J337A-SM-J337AZ".Contains(device_info.model))
			{
				goto IL_4cd4;
			}
			if ("SM-A515U".Contains(device_info.model) && (device_info.Carrier.Contains("CCT") | device_info.Carrier.Contains("ATT") | device_info.Carrier.Contains("CHA")) && (device_info.secunumber.Contains("1") | device_info.secunumber.Contains("2")))
			{
				Form1.String_75 = Conversions.ToString(2);
				Form1.String_74 = "2 Credits";
			}
			else if ("SM-A102U".Contains(device_info.model) && (device_info.Carrier.Contains("CCT") | device_info.Carrier.Contains("AIO") | device_info.Carrier.Contains("ATT") | device_info.Carrier.Contains("CHA")) && (device_info.secunumber.Contains("1") | device_info.secunumber.Contains("2") | device_info.secunumber.Contains("3") | device_info.secunumber.Contains("4") | device_info.secunumber.Contains("5") | device_info.secunumber.Contains("6")))
			{
				Form1.String_75 = Conversions.ToString(2);
				Form1.String_74 = "2 Credits";
			}
			else if ("SM-A505U1-SM-A505U".Contains(device_info.model) && (device_info.Carrier.Contains("CCT") | device_info.Carrier.Contains("ATT") | device_info.Carrier.Contains("CHA")) && (device_info.secunumber.Contains("1") | device_info.secunumber.Contains("2") | device_info.secunumber.Contains("3") | device_info.secunumber.Contains("4") | device_info.secunumber.Contains("5") | device_info.secunumber.Contains("6") | device_info.secunumber.Contains("7")))
			{
				Form1.String_75 = Conversions.ToString(2);
				Form1.String_74 = "2 Credits";
			}
			else if ("SM-J737U".Contains(device_info.model) && (device_info.secunumber.Contains("1") | device_info.secunumber.Contains("2") | device_info.secunumber.Contains("3")))
			{
				if (Operators.CompareString(SevaClass.StatusAcouunt, "Credits", TextCompare: false) == 0)
				{
					Form1.String_75 = Conversions.ToString(2);
					Form1.String_74 = "2 Credits";
				}
				else
				{
					Form1.String_75 = Conversions.ToString(0);
					Form1.String_74 = "Free";
				}
			}
			else if ("SM-A105F".Contains(device_info.model) && (device_info.secunumber.Contains("1") | device_info.secunumber.Contains("2") | device_info.secunumber.Contains("3") | device_info.secunumber.Contains("4")))
			{
				Form1.String_75 = Conversions.ToString(2);
				Form1.String_74 = "2 Credits";
			}
			else if ("SM-A202F".Contains(device_info.model) && (device_info.secunumber.Contains("1") | device_info.secunumber.Contains("2") | device_info.secunumber.Contains("3")))
			{
				Form1.String_75 = Conversions.ToString(2);
				Form1.String_74 = "2 Credits";
			}
			else if ("SM-A205F".Contains(device_info.model) && (device_info.secunumber.Contains("1") | device_info.secunumber.Contains("2") | device_info.secunumber.Contains("3") | device_info.secunumber.Contains("4") | device_info.secunumber.Contains("5") | device_info.secunumber.Contains("6") | device_info.secunumber.Contains("7") | device_info.secunumber.Contains("8")))
			{
				Form1.String_75 = Conversions.ToString(3);
				Form1.String_74 = "3 Credits";
			}
			else if ("SM-A205Y".Contains(device_info.model) && (device_info.secunumber.Contains("1") | device_info.secunumber.Contains("2") | device_info.secunumber.Contains("3") | device_info.secunumber.Contains("4") | device_info.secunumber.Contains("5")))
			{
				Form1.String_75 = Conversions.ToString(2);
				Form1.String_74 = "2 Credits";
			}
			else if ("SM-A260F".Contains(device_info.model) && (device_info.secunumber.Contains("1") | device_info.secunumber.Contains("2") | device_info.secunumber.Contains("3") | device_info.secunumber.Contains("4") | device_info.secunumber.Contains("5") | device_info.secunumber.Contains("6")))
			{
				Form1.String_75 = Conversions.ToString(2);
				Form1.String_74 = "2 Credits";
			}
			else if ("SM-A260G".Contains(device_info.model) && (device_info.secunumber.Contains("1") | device_info.secunumber.Contains("2") | device_info.secunumber.Contains("3") | device_info.secunumber.Contains("4") | device_info.secunumber.Contains("5") | device_info.secunumber.Contains("6")))
			{
				Form1.String_75 = Conversions.ToString(2);
				Form1.String_74 = "2 Credits";
			}
			else if ("SM-A305G".Contains(device_info.model) && (device_info.secunumber.Contains("1") | device_info.secunumber.Contains("2") | device_info.secunumber.Contains("3") | device_info.secunumber.Contains("4") | device_info.secunumber.Contains("5") | device_info.secunumber.Contains("6")))
			{
				Form1.String_75 = Conversions.ToString(2);
				Form1.String_74 = "2 Credits";
			}
			else if ("SM-A505F".Contains(device_info.model) && (device_info.secunumber.Contains("1") | device_info.secunumber.Contains("2") | device_info.secunumber.Contains("3") | device_info.secunumber.Contains("4") | device_info.secunumber.Contains("5")))
			{
				Form1.String_75 = Conversions.ToString(2);
				Form1.String_74 = "2 Credits";
			}
			else if ("SM-A515F".Contains(device_info.model) && (device_info.secunumber.Contains("1") | device_info.secunumber.Contains("2") | device_info.secunumber.Contains("3")))
			{
				Form1.String_75 = Conversions.ToString(2);
				Form1.String_74 = "2 Credits";
			}
			else if ("SM-A530F".Contains(device_info.model) && (device_info.secunumber.Contains("1") | device_info.secunumber.Contains("2") | device_info.secunumber.Contains("3") | device_info.secunumber.Contains("4") | device_info.secunumber.Contains("5") | device_info.secunumber.Contains("6") | device_info.secunumber.Contains("7") | device_info.secunumber.Contains("8") | device_info.secunumber.Contains("9") | device_info.secunumber.Contains("SA") | device_info.secunumber.Contains("SB") | device_info.secunumber.Contains("SC") | device_info.secunumber.Contains("SD")))
			{
				Form1.String_75 = Conversions.ToString(4);
				Form1.String_74 = "4 Credits";
			}
			else if ("SM-A600AZ-SM-A600A".Contains(device_info.model) && (device_info.secunumber.Contains("1") | device_info.secunumber.Contains("2") | device_info.secunumber.Contains("3") | device_info.secunumber.Contains("4") | device_info.secunumber.Contains("5") | device_info.secunumber.Contains("6") | device_info.secunumber.Contains("7") | device_info.secunumber.Contains("8")))
			{
				Form1.String_75 = Conversions.ToString(3);
				Form1.String_74 = "3 Credits";
			}
			else if ("SM-A600FN".Contains(device_info.model) && (device_info.secunumber.Contains("1") | device_info.secunumber.Contains("2") | device_info.secunumber.Contains("3") | device_info.secunumber.Contains("4") | device_info.secunumber.Contains("5") | device_info.secunumber.Contains("6")))
			{
				Form1.String_75 = Conversions.ToString(2);
				Form1.String_74 = "2 Credits";
			}
			else if ("SM-A750FN".Contains(device_info.model) && (device_info.secunumber.Contains("1") | device_info.secunumber.Contains("2") | device_info.secunumber.Contains("3") | device_info.secunumber.Contains("4")))
			{
				Form1.String_75 = Conversions.ToString(2);
				Form1.String_74 = "2 Credits";
			}
			else if ("SM-A750G".Contains(device_info.model) && (device_info.secunumber.Contains("1") | device_info.secunumber.Contains("2") | device_info.secunumber.Contains("3") | device_info.secunumber.Contains("4") | device_info.secunumber.Contains("5") | device_info.secunumber.Contains("6")))
			{
				Form1.String_75 = Conversions.ToString(2);
				Form1.String_74 = "2 Credits";
			}
			else if ("SM-G950F".Contains(device_info.model) && (device_info.secunumber.Contains("1") | device_info.secunumber.Contains("2") | device_info.secunumber.Contains("3") | device_info.secunumber.Contains("4") | device_info.secunumber.Contains("5") | device_info.secunumber.Contains("6") | device_info.secunumber.Contains("7") | device_info.secunumber.Contains("8") | device_info.secunumber.Contains("9")))
			{
				Form1.String_75 = Conversions.ToString(4);
				Form1.String_74 = "4 Credits";
			}
			else if ("SM-G955F".Contains(device_info.model) && (device_info.secunumber.Contains("1") | device_info.secunumber.Contains("2") | device_info.secunumber.Contains("3") | device_info.secunumber.Contains("4") | device_info.secunumber.Contains("5") | device_info.secunumber.Contains("6") | device_info.secunumber.Contains("7") | device_info.secunumber.Contains("8") | device_info.secunumber.Contains("9")))
			{
				Form1.String_75 = Conversions.ToString(4);
				Form1.String_74 = "4 Credits";
			}
			else if ("SM-G960F".Contains(device_info.model) && (device_info.secunumber.Contains("1") | device_info.secunumber.Contains("2") | device_info.secunumber.Contains("3") | device_info.secunumber.Contains("4") | device_info.secunumber.Contains("5") | device_info.secunumber.Contains("6") | device_info.secunumber.Contains("7") | device_info.secunumber.Contains("8") | device_info.secunumber.Contains("9") | device_info.secunumber.Contains("UA")))
			{
				Form1.String_75 = Conversions.ToString(4);
				Form1.String_74 = "4 Credits";
			}
			else if ("SM-G965F".Contains(device_info.model) && (device_info.secunumber.Contains("1") | device_info.secunumber.Contains("2") | device_info.secunumber.Contains("3") | device_info.secunumber.Contains("4") | device_info.secunumber.Contains("5") | device_info.secunumber.Contains("6") | device_info.secunumber.Contains("7") | device_info.secunumber.Contains("8") | device_info.secunumber.Contains("9") | device_info.secunumber.Contains("UA")))
			{
				Form1.String_75 = Conversions.ToString(4);
				Form1.String_74 = "4 Credits";
			}
			else if ("SM-G973F".Contains(device_info.model) && (device_info.secunumber.Contains("1") | device_info.secunumber.Contains("2") | device_info.secunumber.Contains("3") | device_info.secunumber.Contains("4") | device_info.secunumber.Contains("5") | device_info.secunumber.Contains("6") | device_info.secunumber.Contains("7")))
			{
				Form1.String_75 = Conversions.ToString(3);
				Form1.String_74 = "3 Credits";
			}
			else if ("SM-G975F".Contains(device_info.model) && (device_info.secunumber.Contains("1") | device_info.secunumber.Contains("2") | device_info.secunumber.Contains("3") | device_info.secunumber.Contains("4") | device_info.secunumber.Contains("5") | device_info.secunumber.Contains("6") | device_info.secunumber.Contains("7")))
			{
				Form1.String_75 = Conversions.ToString(3);
				Form1.String_74 = "3 Credits";
			}
			else if ("SM-G977B".Contains(device_info.model) && (device_info.secunumber.Contains("1") | device_info.secunumber.Contains("2") | device_info.secunumber.Contains("3") | device_info.secunumber.Contains("4")))
			{
				Form1.String_75 = Conversions.ToString(3);
				Form1.String_74 = "3 Credits";
			}
			else if ("SM-G977B".Contains(device_info.model) && (device_info.secunumber.Contains("1") | device_info.secunumber.Contains("2") | device_info.secunumber.Contains("3")))
			{
				Form1.String_75 = Conversions.ToString(2);
				Form1.String_74 = "2 Credits";
			}
			else if ("SM-G981B".Contains(device_info.model) && (device_info.secunumber.Contains("1") | device_info.secunumber.Contains("2") | device_info.secunumber.Contains("3")))
			{
				Form1.String_75 = Conversions.ToString(2);
				Form1.String_74 = "2 Credits";
			}
			else if ("SM-G985F".Contains(device_info.model) && (device_info.secunumber.Contains("1") | device_info.secunumber.Contains("2") | device_info.secunumber.Contains("3")))
			{
				Form1.String_75 = Conversions.ToString(2);
				Form1.String_74 = "2 Credits";
			}
			else if ("SM-G986B".Contains(device_info.model) && (device_info.secunumber.Contains("1") | device_info.secunumber.Contains("2") | device_info.secunumber.Contains("3")))
			{
				Form1.String_75 = Conversions.ToString(2);
				Form1.String_74 = "2 Credits";
			}
			else if ("SM-G988B".Contains(device_info.model) && (device_info.secunumber.Contains("1") | device_info.secunumber.Contains("2") | device_info.secunumber.Contains("3")))
			{
				Form1.String_75 = Conversions.ToString(2);
				Form1.String_74 = "2 Credits";
			}
			else if ("SM-J260G".Contains(device_info.model) && (device_info.secunumber.Contains("1") | device_info.secunumber.Contains("2") | device_info.secunumber.Contains("3") | device_info.secunumber.Contains("4") | device_info.secunumber.Contains("5") | device_info.secunumber.Contains("6")))
			{
				Form1.String_75 = Conversions.ToString(3);
				Form1.String_74 = "3 Credits";
			}
			else if ("SM-J260M".Contains(device_info.model) && (device_info.secunumber.Contains("1") | device_info.secunumber.Contains("2") | device_info.secunumber.Contains("3") | device_info.secunumber.Contains("4") | device_info.secunumber.Contains("5") | device_info.secunumber.Contains("6") | device_info.secunumber.Contains("7") | device_info.secunumber.Contains("8") | device_info.secunumber.Contains("9") | device_info.secunumber.Contains("SA") | device_info.secunumber.Contains("SB")))
			{
				Form1.String_75 = Conversions.ToString(4);
				Form1.String_74 = "4 Credits";
			}
			else if ("SM-J400M".Contains(device_info.model) && (device_info.secunumber.Contains("1") | device_info.secunumber.Contains("2") | device_info.secunumber.Contains("3") | device_info.secunumber.Contains("4") | device_info.secunumber.Contains("5") | device_info.secunumber.Contains("6") | device_info.secunumber.Contains("7") | device_info.secunumber.Contains("8") | device_info.secunumber.Contains("9")))
			{
				Form1.String_75 = Conversions.ToString(4);
				Form1.String_74 = "4 Credits";
			}
			else if ("SM-J600F".Contains(device_info.model) && (device_info.secunumber.Contains("1") | device_info.secunumber.Contains("2") | device_info.secunumber.Contains("3") | device_info.secunumber.Contains("4") | device_info.secunumber.Contains("5") | device_info.secunumber.Contains("6") | device_info.secunumber.Contains("7") | device_info.secunumber.Contains("8")))
			{
				Form1.String_75 = Conversions.ToString(3);
				Form1.String_74 = "3 Credits";
			}
			else if ("SM-J600G".Contains(device_info.model) && (device_info.secunumber.Contains("1") | device_info.secunumber.Contains("2") | device_info.secunumber.Contains("3") | device_info.secunumber.Contains("4") | device_info.secunumber.Contains("5") | device_info.secunumber.Contains("6") | device_info.secunumber.Contains("7")))
			{
				Form1.String_75 = Conversions.ToString(3);
				Form1.String_74 = "3 Credits";
			}
			else if ("SM-J730G".Contains(device_info.model) && (device_info.secunumber.Contains("1") | device_info.secunumber.Contains("2") | device_info.secunumber.Contains("3") | device_info.secunumber.Contains("4") | device_info.secunumber.Contains("5") | device_info.secunumber.Contains("6") | device_info.secunumber.Contains("7") | device_info.secunumber.Contains("8") | device_info.secunumber.Contains("9") | device_info.secunumber.Contains("SA") | device_info.secunumber.Contains("SB") | device_info.secunumber.Contains("SC")))
			{
				Form1.String_75 = Conversions.ToString(4);
				Form1.String_74 = "4 Credits";
			}
			else if ("SM-J737A".Contains(device_info.model) && (device_info.secunumber.Contains("1") | device_info.secunumber.Contains("2") | device_info.secunumber.Contains("3") | device_info.secunumber.Contains("4") | device_info.secunumber.Contains("5") | device_info.secunumber.Contains("6") | device_info.secunumber.Contains("7")))
			{
				Form1.String_75 = Conversions.ToString(2);
				Form1.String_74 = "2 Credits";
			}
			else if ("SM-M105G".Contains(device_info.model) && (device_info.secunumber.Contains("1") | device_info.secunumber.Contains("2") | device_info.secunumber.Contains("3") | device_info.secunumber.Contains("4") | device_info.secunumber.Contains("5")))
			{
				Form1.String_75 = Conversions.ToString(2);
				Form1.String_74 = "2 Credits";
			}
			else if ("SM-N950F".Contains(device_info.model) && (device_info.secunumber.Contains("1") | device_info.secunumber.Contains("2") | device_info.secunumber.Contains("3") | device_info.secunumber.Contains("4") | device_info.secunumber.Contains("5") | device_info.secunumber.Contains("6") | device_info.secunumber.Contains("7") | device_info.secunumber.Contains("8") | device_info.secunumber.Contains("9") | device_info.secunumber.Contains("SA") | device_info.secunumber.Contains("SB") | device_info.secunumber.Contains("SC") | device_info.secunumber.Contains("SD")))
			{
				Form1.String_75 = Conversions.ToString(4);
				Form1.String_74 = "4 Credits";
			}
			else if ("SM-N960F".Contains(device_info.model) && (device_info.secunumber.Contains("1") | device_info.secunumber.Contains("2") | device_info.secunumber.Contains("3") | device_info.secunumber.Contains("4") | device_info.secunumber.Contains("5") | device_info.secunumber.Contains("6")))
			{
				Form1.String_75 = Conversions.ToString(3);
				Form1.String_74 = "3 Credits";
			}
			else if ("SM-N970F".Contains(device_info.model) && (device_info.secunumber.Contains("1") | device_info.secunumber.Contains("2") | device_info.secunumber.Contains("3") | device_info.secunumber.Contains("4") | device_info.secunumber.Contains("5")))
			{
				Form1.String_75 = Conversions.ToString(2);
				Form1.String_74 = "2 Credits";
			}
			else if ("SM-N975F".Contains(device_info.model) && (device_info.secunumber.Contains("1") | device_info.secunumber.Contains("2") | device_info.secunumber.Contains("3") | device_info.secunumber.Contains("4") | device_info.secunumber.Contains("5")))
			{
				Form1.String_75 = Conversions.ToString(2);
				Form1.String_74 = "2 Credits";
			}
			else if ("SM-J337V".Contains(device_info.model) && (device_info.secunumber.Contains("1") | device_info.secunumber.Contains("2") | device_info.secunumber.Contains("3") | device_info.secunumber.Contains("4") | device_info.secunumber.Contains("5") | device_info.secunumber.Contains("6")))
			{
				Form1.String_75 = Conversions.ToString(2);
				Form1.String_74 = "2 Credits";
			}
			else if ("SM-J737V".Contains(device_info.model) && (device_info.secunumber.Contains("1") | device_info.secunumber.Contains("2") | device_info.secunumber.Contains("3") | device_info.secunumber.Contains("4") | device_info.secunumber.Contains("5") | device_info.secunumber.Contains("6")))
			{
				Form1.String_75 = Conversions.ToString(2);
				Form1.String_74 = "2 Credits";
			}
			else if ("SM-J737VPP".Contains(device_info.model) && (device_info.secunumber.Contains("1") | device_info.secunumber.Contains("2") | device_info.secunumber.Contains("3") | device_info.secunumber.Contains("4") | device_info.secunumber.Contains("5") | device_info.secunumber.Contains("6") | device_info.secunumber.Contains("7")))
			{
				Form1.String_75 = Conversions.ToString(2);
				Form1.String_74 = "2 Credits";
			}
			else if ("SM-J337VPP".Contains(device_info.model) && (device_info.secunumber.Contains("1") | device_info.secunumber.Contains("2") | device_info.secunumber.Contains("3") | device_info.secunumber.Contains("4") | device_info.secunumber.Contains("5") | device_info.secunumber.Contains("6") | device_info.secunumber.Contains("7")))
			{
				Form1.String_75 = Conversions.ToString(2);
				Form1.String_74 = "2 Credits";
			}
			else if ("SM-A105G".Contains(device_info.model) && (device_info.secunumber.Contains("1") | device_info.secunumber.Contains("2") | device_info.secunumber.Contains("3") | device_info.secunumber.Contains("4") | device_info.secunumber.Contains("5") | device_info.secunumber.Contains("6") | device_info.secunumber.Contains("7")))
			{
				Form1.String_75 = Conversions.ToString(3);
				Form1.String_74 = "3 Credits";
			}
			else if ("SM-A105M".Contains(device_info.model) && (device_info.secunumber.Contains("1") | device_info.secunumber.Contains("2") | device_info.secunumber.Contains("3") | device_info.secunumber.Contains("4")))
			{
				Form1.String_75 = Conversions.ToString(2);
				Form1.String_74 = "2 Credits";
			}
			else if ("SM-A205F".Contains(device_info.model) && (device_info.secunumber.Contains("1") | device_info.secunumber.Contains("2") | device_info.secunumber.Contains("3") | device_info.secunumber.Contains("4") | device_info.secunumber.Contains("5") | device_info.secunumber.Contains("6") | device_info.secunumber.Contains("7") | device_info.secunumber.Contains("8")))
			{
				Form1.String_75 = Conversions.ToString(3);
				Form1.String_74 = "3 Credits";
			}
			else if ("SM-A307G".Contains(device_info.model) && (device_info.secunumber.Contains("1") | device_info.secunumber.Contains("2") | device_info.secunumber.Contains("3") | device_info.secunumber.Contains("4")))
			{
				Form1.String_75 = Conversions.ToString(2);
				Form1.String_74 = "2 Credits";
			}
			else if ("SM-A320F".Contains(device_info.model) && (device_info.secunumber.Contains("1") | device_info.secunumber.Contains("2") | device_info.secunumber.Contains("3") | device_info.secunumber.Contains("4") | device_info.secunumber.Contains("5") | device_info.secunumber.Contains("6") | device_info.secunumber.Contains("7")))
			{
				Form1.String_75 = Conversions.ToString(3);
				Form1.String_74 = "3 Credits";
			}
			else if ("SM-A505G".Contains(device_info.model) && (device_info.secunumber.Contains("1") | device_info.secunumber.Contains("2") | device_info.secunumber.Contains("3") | device_info.secunumber.Contains("4") | device_info.secunumber.Contains("5")))
			{
				Form1.String_75 = Conversions.ToString(2);
				Form1.String_74 = "2 Credits";
			}
			else if ("SM-A507F".Contains(device_info.model) && (device_info.secunumber.Contains("1") | device_info.secunumber.Contains("2") | device_info.secunumber.Contains("3") | device_info.secunumber.Contains("4")))
			{
				Form1.String_75 = Conversions.ToString(2);
				Form1.String_74 = "2 Credits";
			}
			else if ("SM-A520F".Contains(device_info.model) && (device_info.secunumber.Contains("1") | device_info.secunumber.Contains("2") | device_info.secunumber.Contains("3") | device_info.secunumber.Contains("4") | device_info.secunumber.Contains("5") | device_info.secunumber.Contains("6") | device_info.secunumber.Contains("7") | device_info.secunumber.Contains("8") | device_info.secunumber.Contains("9") | device_info.secunumber.Contains("SA")))
			{
				Form1.String_75 = Conversions.ToString(4);
				Form1.String_74 = "4 Credits";
			}
			else if ("SM-A520W".Contains(device_info.model) && (device_info.secunumber.Contains("1") | device_info.secunumber.Contains("2") | device_info.secunumber.Contains("3") | device_info.secunumber.Contains("4") | device_info.secunumber.Contains("5") | device_info.secunumber.Contains("6") | device_info.secunumber.Contains("7") | device_info.secunumber.Contains("8") | device_info.secunumber.Contains("9") | device_info.secunumber.Contains("SA") | device_info.secunumber.Contains("SB")))
			{
				Form1.String_75 = Conversions.ToString(4);
				Form1.String_74 = "4 Credits";
			}
			else if ("SM-A600G".Contains(device_info.model) && (device_info.secunumber.Contains("1") | device_info.secunumber.Contains("2") | device_info.secunumber.Contains("3") | device_info.secunumber.Contains("4") | device_info.secunumber.Contains("5")))
			{
				Form1.String_75 = Conversions.ToString(2);
				Form1.String_74 = "2 Credits";
			}
			else if ("SM-A720F".Contains(device_info.model) && (device_info.secunumber.Contains("1") | device_info.secunumber.Contains("2") | device_info.secunumber.Contains("3") | device_info.secunumber.Contains("4") | device_info.secunumber.Contains("5") | device_info.secunumber.Contains("6") | device_info.secunumber.Contains("7")))
			{
				Form1.String_75 = Conversions.ToString(3);
				Form1.String_74 = "3 Credits";
			}
			else if ("SM-A730F".Contains(device_info.model) && (device_info.secunumber.Contains("1") | device_info.secunumber.Contains("2") | device_info.secunumber.Contains("3") | device_info.secunumber.Contains("4") | device_info.secunumber.Contains("5")))
			{
				Form1.String_75 = Conversions.ToString(2);
				Form1.String_74 = "2 Credits";
			}
			else if ("SM-G390F".Contains(device_info.model) && (device_info.secunumber.Contains("1") | device_info.secunumber.Contains("2") | device_info.secunumber.Contains("3") | device_info.secunumber.Contains("4") | device_info.secunumber.Contains("5")))
			{
				Form1.String_75 = Conversions.ToString(2);
				Form1.String_74 = "2 Credits";
			}
			else if ("SM-G570M".Contains(device_info.model) && (device_info.secunumber.Contains("1") | device_info.secunumber.Contains("2") | device_info.secunumber.Contains("3") | device_info.secunumber.Contains("4") | device_info.secunumber.Contains("5") | device_info.secunumber.Contains("6") | device_info.secunumber.Contains("7") | device_info.secunumber.Contains("8")))
			{
				Form1.String_75 = Conversions.ToString(3);
				Form1.String_74 = "3 Credits";
			}
			else if ("SM-G930F".Contains(device_info.model) && (device_info.secunumber.Contains("1") | device_info.secunumber.Contains("2") | device_info.secunumber.Contains("3") | device_info.secunumber.Contains("4") | device_info.secunumber.Contains("5") | device_info.secunumber.Contains("6") | device_info.secunumber.Contains("7") | device_info.secunumber.Contains("8")))
			{
				Form1.String_75 = Conversions.ToString(3);
				Form1.String_74 = "3 Credits";
			}
			else if ("SM-G935F".Contains(device_info.model) && (device_info.secunumber.Contains("1") | device_info.secunumber.Contains("2") | device_info.secunumber.Contains("3") | device_info.secunumber.Contains("4") | device_info.secunumber.Contains("5") | device_info.secunumber.Contains("6") | device_info.secunumber.Contains("7") | device_info.secunumber.Contains("8")))
			{
				Form1.String_75 = Conversions.ToString(3);
				Form1.String_74 = "3 Credits";
			}
			else if ("SM-G960N".Contains(device_info.model) && device_info.secunumber.Contains("1"))
			{
				Form1.String_75 = Conversions.ToString(1);
				Form1.String_74 = "1 Credits";
			}
			else if ("SM-G965N".Contains(device_info.model) && device_info.secunumber.Contains("1"))
			{
				Form1.String_75 = Conversions.ToString(1);
				Form1.String_74 = "1 Credits";
			}
			else if ("SM-J327A-SM-J327AZ".Contains(device_info.model) && (device_info.secunumber.Contains("1") | device_info.secunumber.Contains("2") | device_info.secunumber.Contains("3") | device_info.secunumber.Contains("4")))
			{
				if (Operators.CompareString(SevaClass.StatusAcouunt, "Credits", TextCompare: false) == 0)
				{
					Form1.String_75 = Conversions.ToString(2);
					Form1.String_74 = "2 Credits";
				}
				else
				{
					Form1.String_75 = Conversions.ToString(0);
					Form1.String_74 = "Free";
				}
			}
			else if ("SM-J330F".Contains(device_info.model) && (device_info.secunumber.Contains("1") | device_info.secunumber.Contains("2") | device_info.secunumber.Contains("3")))
			{
				Form1.String_75 = Conversions.ToString(2);
				Form1.String_74 = "2 Credits";
			}
			else if ("SM-J337T-SM-J337T1".Contains(device_info.model) && (device_info.secunumber.Contains("1") | device_info.secunumber.Contains("2") | device_info.secunumber.Contains("3") | device_info.secunumber.Contains("4") | device_info.secunumber.Contains("5") | device_info.secunumber.Contains("6") | device_info.secunumber.Contains("7") | device_info.secunumber.Contains("8")))
			{
				Form1.String_75 = Conversions.ToString(3);
				Form1.String_74 = "3 Credits";
			}
			else if ("SM-J400F".Contains(device_info.model) && (device_info.secunumber.Contains("1") | device_info.secunumber.Contains("2") | device_info.secunumber.Contains("3")))
			{
				Form1.String_75 = Conversions.ToString(2);
				Form1.String_74 = "2 Credits";
			}
			else if ("SM-J701F".Contains(device_info.model) && (device_info.secunumber.Contains("1") | device_info.secunumber.Contains("2") | device_info.secunumber.Contains("3") | device_info.secunumber.Contains("4") | device_info.secunumber.Contains("5") | device_info.secunumber.Contains("6") | device_info.secunumber.Contains("7") | device_info.secunumber.Contains("8")))
			{
				Form1.String_75 = Conversions.ToString(3);
				Form1.String_74 = "3 Credits";
			}
			else if ("SM-J701M".Contains(device_info.model) && (device_info.secunumber.Contains("1") | device_info.secunumber.Contains("2") | device_info.secunumber.Contains("3") | device_info.secunumber.Contains("4") | device_info.secunumber.Contains("5") | device_info.secunumber.Contains("6") | device_info.secunumber.Contains("7") | device_info.secunumber.Contains("8")))
			{
				Form1.String_75 = Conversions.ToString(3);
				Form1.String_74 = "3 Credits";
			}
			else if ("SM-J710M".Contains(device_info.model) && (device_info.secunumber.Contains("1") | device_info.secunumber.Contains("2") | device_info.secunumber.Contains("3") | device_info.secunumber.Contains("4")))
			{
				Form1.String_75 = Conversions.ToString(2);
				Form1.String_74 = "2 Credits";
			}
			else if ("SM-J727AZ-SM-J727A".Contains(device_info.model) && (device_info.secunumber.Contains("1") | device_info.secunumber.Contains("2") | device_info.secunumber.Contains("3") | device_info.secunumber.Contains("4") | device_info.secunumber.Contains("5") | device_info.secunumber.Contains("6") | device_info.secunumber.Contains("7")))
			{
				Form1.String_75 = Conversions.ToString(2);
				Form1.String_74 = "2 Credits";
			}
			else if ("SM-J727T-SM-J727T1".Contains(device_info.model) && (device_info.secunumber.Contains("1") | device_info.secunumber.Contains("2") | device_info.secunumber.Contains("3") | device_info.secunumber.Contains("4") | device_info.secunumber.Contains("5") | device_info.secunumber.Contains("6") | device_info.secunumber.Contains("7")))
			{
				Form1.String_75 = Conversions.ToString(2);
				Form1.String_74 = "2 Credits";
			}
			else if ("SM-M105F".Contains(device_info.model) && (device_info.secunumber.Contains("1") | device_info.secunumber.Contains("2") | device_info.secunumber.Contains("3")))
			{
				Form1.String_75 = Conversions.ToString(2);
				Form1.String_74 = "2 Credits";
			}
			else if ("SM-M205F".Contains(device_info.model) && (device_info.secunumber.Contains("1") | device_info.secunumber.Contains("2") | device_info.secunumber.Contains("3") | device_info.secunumber.Contains("4")))
			{
				Form1.String_75 = Conversions.ToString(2);
				Form1.String_74 = "2 Credits";
			}
			else if ("SM-M205G".Contains(device_info.model) && device_info.secunumber.Contains("1"))
			{
				Form1.String_75 = Conversions.ToString(1);
				Form1.String_74 = "1 Credits";
			}
			else if ("SM-M315F".Contains(device_info.model) && device_info.secunumber.Contains("1"))
			{
				Form1.String_75 = Conversions.ToString(1);
				Form1.String_74 = "1 Credits";
			}
			else if ("SM-N770F".Contains(device_info.model) && (device_info.secunumber.Contains("1") | device_info.secunumber.Contains("2")))
			{
				Form1.String_75 = Conversions.ToString(1);
				Form1.String_74 = "1 Credits";
			}
			else if ("SM-N950N".Contains(device_info.model) && (device_info.secunumber.Contains("1") | device_info.secunumber.Contains("2") | device_info.secunumber.Contains("3") | device_info.secunumber.Contains("4") | device_info.secunumber.Contains("5")))
			{
				Form1.String_75 = Conversions.ToString(2);
				Form1.String_74 = "2 Credits";
			}
			else if ("SM-N960N".Contains(device_info.model) && (device_info.secunumber.Contains("1") | device_info.secunumber.Contains("2") | device_info.secunumber.Contains("3")))
			{
				Form1.String_75 = Conversions.ToString(2);
				Form1.String_74 = "2 Credits";
			}
			else if ("SM-S102DL".Contains(device_info.model) && (device_info.secunumber.Contains("1") | device_info.secunumber.Contains("2") | device_info.secunumber.Contains("3") | device_info.secunumber.Contains("4") | device_info.secunumber.Contains("5")))
			{
				if (Operators.CompareString(SevaClass.StatusAcouunt, "Credits", TextCompare: false) == 0)
				{
					Form1.String_75 = Conversions.ToString(1);
					Form1.String_74 = "1 Credits";
				}
				else
				{
					Form1.String_75 = Conversions.ToString(0);
					Form1.String_74 = "Free";
				}
			}
			else if ("SM-S367VL".Contains(device_info.model) && (device_info.secunumber.Contains("1") | device_info.secunumber.Contains("2") | device_info.secunumber.Contains("3") | device_info.secunumber.Contains("4") | device_info.secunumber.Contains("5") | device_info.secunumber.Contains("6")))
			{
				if (Operators.CompareString(SevaClass.StatusAcouunt, "Credits", TextCompare: false) == 0)
				{
					Form1.String_75 = Conversions.ToString(1);
					Form1.String_74 = "1 Credits";
				}
				else
				{
					Form1.String_75 = Conversions.ToString(0);
					Form1.String_74 = "Free";
				}
			}
			else if ("SM-S767VL".Contains(device_info.model) && (device_info.secunumber.Contains("1") | device_info.secunumber.Contains("2") | device_info.secunumber.Contains("3") | device_info.secunumber.Contains("4") | device_info.secunumber.Contains("5") | device_info.secunumber.Contains("6") | device_info.secunumber.Contains("7")))
			{
				if (Operators.CompareString(SevaClass.StatusAcouunt, "Credits", TextCompare: false) == 0)
				{
					Form1.String_75 = Conversions.ToString(1);
					Form1.String_74 = "1 Credits";
				}
				else
				{
					Form1.String_75 = Conversions.ToString(0);
					Form1.String_74 = "Free";
				}
			}
			else if ("SM-A205G".Contains(device_info.model) && (device_info.secunumber.Contains("1") | device_info.secunumber.Contains("2") | device_info.secunumber.Contains("3") | device_info.secunumber.Contains("4") | device_info.secunumber.Contains("5") | device_info.secunumber.Contains("6")))
			{
				Form1.String_75 = Conversions.ToString(2);
				Form1.String_74 = "2 Credits";
			}
			else if ("SM-A600T1-SM-A600T".Contains(device_info.model) && (device_info.secunumber.Contains("1") | device_info.secunumber.Contains("2") | device_info.secunumber.Contains("3") | device_info.secunumber.Contains("4") | device_info.secunumber.Contains("5")))
			{
				Form1.String_75 = Conversions.ToString(2);
				Form1.String_74 = "2 Credits";
			}
			else if ("SM-G970F".Contains(device_info.model) && (device_info.secunumber.Contains("1") | device_info.secunumber.Contains("2") | device_info.secunumber.Contains("3") | device_info.secunumber.Contains("4") | device_info.secunumber.Contains("5") | device_info.secunumber.Contains("6") | device_info.secunumber.Contains("7")))
			{
				Form1.String_75 = Conversions.ToString(3);
				Form1.String_74 = "3 Credits";
			}
			else if ("SM-J260A".Contains(device_info.model) && (device_info.secunumber.Contains("1") | device_info.secunumber.Contains("2") | device_info.secunumber.Contains("3") | device_info.secunumber.Contains("4") | device_info.secunumber.Contains("5") | device_info.secunumber.Contains("6") | device_info.secunumber.Contains("7") | device_info.secunumber.Contains("8") | device_info.secunumber.Contains("9")))
			{
				Form1.String_75 = Conversions.ToString(3);
				Form1.String_74 = "3 Credits";
			}
			else if ("SM-J260T1-SM-J260T".Contains(device_info.model) && (device_info.secunumber.Contains("1") | device_info.secunumber.Contains("2") | device_info.secunumber.Contains("3") | device_info.secunumber.Contains("4") | device_info.secunumber.Contains("5")))
			{
				Form1.String_75 = Conversions.ToString(2);
				Form1.String_74 = "2 Credits";
			}
			else if ("SM-J737T1-SM-J737T".Contains(device_info.model) && (device_info.secunumber.Contains("1") | device_info.secunumber.Contains("2") | device_info.secunumber.Contains("3") | device_info.secunumber.Contains("4") | device_info.secunumber.Contains("5") | device_info.secunumber.Contains("6") | device_info.secunumber.Contains("7") | device_info.secunumber.Contains("8")))
			{
				Form1.String_75 = Conversions.ToString(2);
				Form1.String_74 = "2 Credits";
			}
			else if ("SM-N976B".Contains(device_info.model) && (device_info.secunumber.Contains("1") | device_info.secunumber.Contains("2") | device_info.secunumber.Contains("3") | device_info.secunumber.Contains("4") | device_info.secunumber.Contains("5")))
			{
				Form1.String_75 = Conversions.ToString(2);
				Form1.String_74 = "2 Credits";
			}
			else if ("SM-S260DL".Contains(device_info.model) && (device_info.secunumber.Contains("1") | device_info.secunumber.Contains("2") | device_info.secunumber.Contains("3") | device_info.secunumber.Contains("4") | device_info.secunumber.Contains("5") | device_info.secunumber.Contains("6")))
			{
				if (Operators.CompareString(SevaClass.StatusAcouunt, "Credits", TextCompare: false) == 0)
				{
					Form1.String_75 = Conversions.ToString(1);
					Form1.String_74 = "1 Credits";
				}
				else
				{
					Form1.String_75 = Conversions.ToString(0);
					Form1.String_74 = "Free";
				}
			}
			else if ("SM-S357BL".Contains(device_info.model) && (device_info.secunumber.Contains("1") | device_info.secunumber.Contains("2") | device_info.secunumber.Contains("3") | device_info.secunumber.Contains("4") | device_info.secunumber.Contains("5") | device_info.secunumber.Contains("6")))
			{
				Form1.String_75 = Conversions.ToString(2);
				Form1.String_74 = "2 Credits";
			}
			else if ("SM-S506DL".Contains(device_info.model) && (device_info.secunumber.Contains("1") | device_info.secunumber.Contains("2") | device_info.secunumber.Contains("3") | device_info.secunumber.Contains("4") | device_info.secunumber.Contains("5") | device_info.secunumber.Contains("6")))
			{
				Form1.String_75 = Conversions.ToString(2);
				Form1.String_74 = "2 Credits";
			}
			else if ("SM-S737TL".Contains(device_info.model) && (device_info.secunumber.Contains("1") | device_info.secunumber.Contains("2") | device_info.secunumber.Contains("3") | device_info.secunumber.Contains("4") | device_info.secunumber.Contains("5") | device_info.secunumber.Contains("6") | device_info.secunumber.Contains("7") | device_info.secunumber.Contains("8")))
			{
				Form1.String_75 = Conversions.ToString(3);
				Form1.String_74 = "3 Credits";
			}
			else if ("SM-S757BL".Contains(device_info.model) && (device_info.secunumber.Contains("1") | device_info.secunumber.Contains("2") | device_info.secunumber.Contains("3") | device_info.secunumber.Contains("4") | device_info.secunumber.Contains("5") | device_info.secunumber.Contains("6")))
			{
				Form1.String_75 = Conversions.ToString(2);
				Form1.String_74 = "2 Credits";
			}
			else if ("SM-S205DL".Contains(device_info.model) && (device_info.secunumber.Contains("1") | device_info.secunumber.Contains("2") | device_info.secunumber.Contains("3") | device_info.secunumber.Contains("4") | device_info.secunumber.Contains("5")))
			{
				if (Operators.CompareString(SevaClass.StatusAcouunt, "Credits", TextCompare: false) == 0)
				{
					Form1.String_75 = Conversions.ToString(1);
					Form1.String_74 = "1 Credits";
				}
				else
				{
					Form1.String_75 = Conversions.ToString(0);
					Form1.String_74 = "Free";
				}
			}
			else
			{
				if (!"SM-J337A-SM-J337AZ".Contains(device_info.model) || !(device_info.secunumber.Contains("1") | device_info.secunumber.Contains("2") | device_info.secunumber.Contains("3") | device_info.secunumber.Contains("4") | device_info.secunumber.Contains("5") | device_info.secunumber.Contains("6") | device_info.secunumber.Contains("7") | device_info.secunumber.Contains("8") | device_info.secunumber.Contains("9") | device_info.secunumber.Contains("SA") | device_info.secunumber.Contains("UA")))
				{
					goto IL_4cd4;
				}
				Form1.String_75 = Conversions.ToString(3);
				Form1.String_74 = "3 Credits";
			}
		}
		goto IL_4f69;
		IL_04fa:
		if (!"SM-T227U-SM-T227U1".Contains(device_info.model))
		{
			goto IL_06c1;
		}
		if (device_info.Carrier.Contains("TMB") | device_info.Carrier.Contains("TMK") | device_info.Carrier.Contains("DSH") | device_info.Carrier.Contains("APP") | device_info.Carrier.Contains("AIO") | device_info.Carrier.Contains("XAA") | device_info.Carrier.Contains("XAU") | device_info.Carrier.Contains("VZW") | device_info.Carrier.Contains("USC"))
		{
			if (!(device_info.secunumber.Contains("1") | device_info.secunumber.Contains("2")))
			{
				goto IL_06c1;
			}
			if (Operators.CompareString(SevaClass.StatusAcouunt, "Credits", TextCompare: false) == 0)
			{
				Form1.String_75 = Conversions.ToString(2);
				Form1.String_74 = "2 Credits";
			}
			else
			{
				Form1.String_75 = Conversions.ToString(0);
				Form1.String_74 = "Free";
			}
			Method23();
		}
		else
		{
			if (!(device_info.secunumber.Contains("1") | device_info.secunumber.Contains("2") | device_info.secunumber.Contains("3") | device_info.secunumber.Contains("4") | device_info.secunumber.Contains("5") | device_info.secunumber.Contains("6") | device_info.secunumber.Contains("7") | device_info.secunumber.Contains("8") | device_info.secunumber.Contains("9")))
			{
				goto IL_06c1;
			}
			Form1.String_75 = Conversions.ToString(4);
			MtkTask.Mhetod = "2";
			Form1.String_74 = "4 Credits";
		}
		goto IL_4f69;
	}

	public static object Method24()
	{
		Form1.imeSIGN_COUNT62 = null;
		Form1.PUBKEYSIGN_COUNT = null;
		Form1.PUBKEY_COUNT = null;
		Form1.PUBKEYSIGN = null;
		Form1.PUBKEY = null;
		if (device_info.model.Contains("SM-G960"))
		{
			Form1.imeSIGN_COUNT62 = "91DCED80";
			Form1.PUBKEYSIGN_COUNT = "151AA1F82E80CF0";
			Form1.PUBKEY_COUNT = "40000000AD04A018DB000C7";
			Form1.PUBKEYSIGN = "151AA1F82E80CF08C15402F44036BAB145C67AB1220B8ECB404A357A9ABA4C1CCABFC9902EEC9F52A322CFB5BF3A40E3A4CDB5C615F4A4BB0FC20861A187C2440280C707025C5DE32E470DC7C7F3C5E73C39D0948BC543CEFA514E91A2D25170D8CE73611A38F792E11AD7D18B4B5D97BEA52DC2389AC697C444F626A448751A3631C451B289F64342939C7D9096E1853D23636AC5694044F39A3EB93E1119285F64C1254B5956E1617303A1327CB8861F20D21DAA5704260F1A9F979CCD4E9EC9AA99A06086BEA831786C13C66A7C6A43893BCE4B6605B9148149128174D599002619A6D209B5BA7A9C1BC4E868842962DC488FFA27AB1C267846E843881C3B";
			Form1.PUBKEY = "40000000AD04A018DB000C736B9B0287795A00D10EBF51044B5782C7020A9B3EB11B2131FD10D24DF48B860E884C47C97BC0B5F61F6C94E372D81FBD92EB4E436AD6C870F7C458079A1C202855B8A215426984398162A6D4EA4D0250471CB3A3139FBCDFB8CBCD03D4A32720AAF04A8FF8586D77D5C0A1DB7ACC7E7DD2BA1668E4A14065B924AA998D8E8448FF4A6DA21673216B8BB6D3F1C01D18F9C41D3BDA75094725FE9CBF8D5D3A1377EEC24E49F9BA0820DCF0E0F4C973B40E09B0FD1DF82BD7AC1BC4A39763B4DE42051E0E0BD7E325F1D8CFFFB33749973393A6A9A50DF57B478ACD919B0F3039B6CB1D88DD2C1F8401E6713FB36AA30627594957EB373A48E25E2C4FDB4B21290DCEEA31122429EAFAE8F3105407D52C5F56BD6514D27A793A2501EE8DADBF9AEF9C6B3635C80DE52A666D99A5BBCAC02B2950B5CEE35D2F177AEB1F9C717C2C0804A9B0686369685CD43619BD449C70D20A3257FC0C23BB5A19638E790F7D498F63377A6BC72CC7ED18CBFF90D0103BD1BD6872D33F9855849730AECFAD7237DE0094D00E90BA39BEB74EF033D1FC6C6C3D6827233CDB9F9723A6487F33944B65092A764B23CB4D895D045BDFC6A8DCAD1CB91C902785732A31B8BC311DFF0DD5CE329880906D365F39D03B489AD09DB0C4F862234851516460851D43006EA7B861259669381843958ECFFF5DE7004C10254865E003F943566B8E6545";
		}
		if (device_info.model.Contains("SM-N930"))
		{
			Form1.imeSIGN_COUNT62 = "8BC00000";
			Form1.PUBKEYSIGN_COUNT = "52E0A4AEE786914";
			Form1.PUBKEY_COUNT = "400000006D7BF67B9B39681";
			Form1.PUBKEYSIGN = "52E0A4AEE786914EC34614A5A3494C32006B24B18E638AB7C579DB8B6BB27BE0168BFADD07EAD18E9F27542C55965200021E216D766B72A30EE510C615C1DB517838FA044A208720B39C5793795C3B1DA4528ECF82945365CB208C63EAF7F60DB0B153620C10F0337E7A5CF96369AD6695289DDCC4C206D45FAC3C17A7DE540AA59067600062108BF1B52CDE443F777B6BD112640458B50A71B2B6B2818FC0A115391201869E0D25FE052F700C31210C7F1E663D83A2BA7E841CAA9756866A6BC7F0A2DCEE8E8914EBCB13674C1BE30BC52CF5E253F3AAF7AD584C31BD397BB9CE828C2D1A56EE95715FB2D23C06BDB65437F9AC0A93C9BB5E9F96DA255E8A1C";
			Form1.PUBKEY = "400000006D7BF67B9B39681C46A9AF61050BAA529C471D0D058C7B03409249D82279F075E6048F232DC730DBC150A1A62B1DEE23893535E9C9D55DFD1721C9D3A1CDAF7DD116F56DEA88B3E664E9C840E757D422183138BFACC952DC46A91880617E38CC2740126CE338439BF6ADB345E7A4DECD440293C74EB849696F5DFE59F90474C782FFE39F2C1284A0923648721CAF2AF34E4557E3A30565CAF50DE4B5D08E2CE66921C25D60CB1FE9475D22E1AB24E3D36E5D5AAC675113D4AB2FB8845535665215348B744D8415C9295161CB63918429A3A446BE8830803B103A33ACC9E2C405AB5C3E211F68901131A2909FAC1884AB60ED4097004F4159F26E8AC614D8B3388B55BFBED206997A40E636A0C947D54B1BFC2BFA8F34C202D306533BF5C435FC2C1281BDF0C6BA64A7EE1015DD03306C6F61593AEE400D0A3A1315802F199815F6886F5DC5FB502B9CDCC96699A32BB21936FC3F6D6B2FEF7488D8E4A56CBAB2DB5EFF78CC2ED3D867238567947FE9F8957ECD9DCDFD7BACD85AC9B04582AC7917AAEA4B5CE793D729DE271914D48DA3B4F8EED172810BECE19BE497F585FAE554D4B373DDB85F1B3C57C10E130E82503450E9079693DFA9A6EEB60CA71558B75C1267ED755EA67122B3C242AA195AE0EE865DD33A4A48807AC756A36AF93508016CFF5B5E1A5788295BA5250C606D330FD5D3107FED6EE4B498253410EA0A4DF2626B57";
		}
		if (device_info.model.Contains("SCV34"))
		{
			Form1.imeSIGN_COUNT62 = "8BC00000";
			Form1.PUBKEYSIGN_COUNT = "52E0A4AEE786914";
			Form1.PUBKEY_COUNT = "400000006D7BF67B9B39681";
			Form1.PUBKEYSIGN = "52E0A4AEE786914EC34614A5A3494C32006B24B18E638AB7C579DB8B6BB27BE0168BFADD07EAD18E9F27542C55965200021E216D766B72A30EE510C615C1DB517838FA044A208720B39C5793795C3B1DA4528ECF82945365CB208C63EAF7F60DB0B153620C10F0337E7A5CF96369AD6695289DDCC4C206D45FAC3C17A7DE540AA59067600062108BF1B52CDE443F777B6BD112640458B50A71B2B6B2818FC0A115391201869E0D25FE052F700C31210C7F1E663D83A2BA7E841CAA9756866A6BC7F0A2DCEE8E8914EBCB13674C1BE30BC52CF5E253F3AAF7AD584C31BD397BB9CE828C2D1A56EE95715FB2D23C06BDB65437F9AC0A93C9BB5E9F96DA255E8A1C";
			Form1.PUBKEY = "400000006D7BF67B9B39681C46A9AF61050BAA529C471D0D058C7B03409249D82279F075E6048F232DC730DBC150A1A62B1DEE23893535E9C9D55DFD1721C9D3A1CDAF7DD116F56DEA88B3E664E9C840E757D422183138BFACC952DC46A91880617E38CC2740126CE338439BF6ADB345E7A4DECD440293C74EB849696F5DFE59F90474C782FFE39F2C1284A0923648721CAF2AF34E4557E3A30565CAF50DE4B5D08E2CE66921C25D60CB1FE9475D22E1AB24E3D36E5D5AAC675113D4AB2FB8845535665215348B744D8415C9295161CB63918429A3A446BE8830803B103A33ACC9E2C405AB5C3E211F68901131A2909FAC1884AB60ED4097004F4159F26E8AC614D8B3388B55BFBED206997A40E636A0C947D54B1BFC2BFA8F34C202D306533BF5C435FC2C1281BDF0C6BA64A7EE1015DD03306C6F61593AEE400D0A3A1315802F199815F6886F5DC5FB502B9CDCC96699A32BB21936FC3F6D6B2FEF7488D8E4A56CBAB2DB5EFF78CC2ED3D867238567947FE9F8957ECD9DCDFD7BACD85AC9B04582AC7917AAEA4B5CE793D729DE271914D48DA3B4F8EED172810BECE19BE497F585FAE554D4B373DDB85F1B3C57C10E130E82503450E9079693DFA9A6EEB60CA71558B75C1267ED755EA67122B3C242AA195AE0EE865DD33A4A48807AC756A36AF93508016CFF5B5E1A5788295BA5250C606D330FD5D3107FED6EE4B498253410EA0A4DF2626B57";
		}
		if (device_info.model.Contains("SM-G930"))
		{
			Form1.imeSIGN_COUNT62 = "8BC00000";
			Form1.PUBKEYSIGN_COUNT = "2CD19D5B16B932";
			Form1.PUBKEY_COUNT = "40000000171C79FB592";
			Form1.PUBKEYSIGN = "2CD19D5B16B9321E0E6B504E99F90D19A71C024C14C53C0355EC27BD5765AE1C87EF0D6333AA12F3C031C9823DD8434C871A7431B9496FEDA63FE18C43D1E392F7DB92C3D0430C23D33C28F3CAE2C66CE57631FFE44BE332FD07CF577DC1BCB7E7A9F876BC4611D846105633CD4C011E9F6B694950117EE106C8C2B7EE5B628E3350FE14304F972008897E8E27B92889F678A6F8EFBEAF68048888BFD7CCD9EC9C0E0008F8CB82BBB4B4CDEB9030184B8C1DA327DEA219D9090A79DA402891A58BBC091C86E9F285400C9B1B22D18681296D870538F5F21D2E259AC8D5F488F67B4E0A5AE5F297BFB859CFED14E65C830BCCE7D4CB1A65DEA8384511D8AD358C";
			Form1.PUBKEY = "40000000171C79FB5924DEA9D06D9DA83EE72D7445EB1FF7A9136FDCEB8582C88A54B5899A37937D01F26CFE299C5C5994DF1F7E9276BAAB982383B7E7C869B2D9226D986520CC0A586BD9E693291AD89788197E119BED70D9086568E2CDFFC6934C3C1345A5947D415F2B1F389C729648FFA42DFF580635A80D040CEE513E09AAA79720FE9AF5879F865297B999FE1528C51BDE5610CBDD913C8753AF73560EBEF45471F5AE633C69B87E62FDCE0A57C6C05B05C0429E0BE9592472336FD56FCF570C35A93440669B1FFF90A64D152DFA859A170262CA6376BC4DC84F9E0199221BD56B16655C3F505A3818A349BB638C9FD8F0CDA4FC4F57A08B3DF85C64CAB2D9378569140E9FD60C680F2CE3AA57407B3F4EBA3E2370AF509606480147FE90B8175A387EA9866D397313E0859E3BE1B315A2CD11F8FF3CB078BD44070015A9F437459972A0B72568D43BCAF48428885C0C21B19DC0E024CD65509D753FE9F7AD8A935CE8DB90F749C1CA8483DFA8CFA8A3F7F30F778A612FE0C27C0C862BC7FAE152F570E21A4E83ED655247287D794EB1FB124B1E6DE02652089B0BC266B7136CF83CF531C98CC846FA25452721E0648FD97C6AE823EC388418A87B5A50CE46E42EDC74BE2014A571E8565B82DB57D5AF9EF669C120AF386A494484BE252FDB6CAA4458948FC1EFA483C216D8D1B0947CDD2BC7DF9963CDEA706B44E1C5E77C2F6E30500955";
		}
		if (device_info.model.Contains("SM-G935"))
		{
			Form1.imeSIGN_COUNT62 = "8BE50000";
			Form1.PUBKEYSIGN_COUNT = "CB22214B8CEBB7";
			Form1.PUBKEY_COUNT = "400000002534A6915";
			Form1.PUBKEYSIGN = "CB22214B8CEBB75EBE09511E39DA3A65DF7A8DEC7C60C0D275625EDE23815CFD59A6958F1B7B3A124D778EAA53B0AB87F0C8A3273C723CE15E3E25C5FF3E0A7747C60B2E19025F175C67EE403CDFE675C3F53C00ACE9080C8E1DF8BAB49B5A8B1BF78A69AAE3E35D8A2FC5AB58C8824B062FC16F83F65935EFB19FB79F65FE7D81C8CA46A8AECB3315A34854CCD6442053C7CAE5C0D79EBBDC9952E3660FCC0CA5C976DEAD498B0E21C2928DC4378E0979DAA644DEF4D2928E24612F5A2C3FC217F45E71028B9A507304A0A35F2A48486E4140A8E8ADC15E0319181DF2A9D347BA4E51BA00EE4EFA70AA8638EC4C5D3585F7895AD6E5CD963D1C172772F1C408";
			Form1.PUBKEY = "400000002534A6915338517C7CF7304AA300F7FD988C0CBF89F3CD97B99AD8199D6F6590DB55F511D262CA164D464ABCD09EE97D8042784C20117D8DB4CB6D4FE456DA1A31964AF92735F26003D15BDE84C816788CEAA2328ED429716BFD8ED7093C38F43EF008700E381A85645F8C8A6008799ED4D8E896F89AE646CE4CC1256762AE33762E79BDFA17C4321E102EE253E8176905C974A2D006892603FA5D88F772C67E325D24235670273DE05FF4CF2E824536465557ECC9783F3B176D109150E32991698D60F52C2C38D85D36988F17304F42354C4D6C9558179BC0B215BD0B37334431440A4E047C0C194A9ABC9C01A85E551977D5818D40F363C52A16515C873DC5AEBA59D3AEB0EFECAFE1390850D7AAE6195BE2A117DDF4685C516E2E228DEEB8EB562ECD142777D4365DA3C1524426CDA72F1F8DFC6F9E3CF909230852AF830BAF5DB24E97B862F77A51D531AE86CEC220E0EED5B895E90A2218B8FAA46C1CF1A10F6C1CBDFA6CB3422EA909003F7F4E860A707D7D7AF50574C84354F270ED58EB334BFE513F3B942513CB78CBD10025622A88339767F402AB5107195D512002CDE294C568DD2E0E894985B4BFB0CABBCE0B3DF094476F72A423BF3CC62BDAB774D3534F49C088DD4CBE9C5CF01D1DF122CF396B419C64D5DEC4CCEE654CCE86DF77385C38CBAF7873771333221E65883A1F7599AA1489E3BC8EF266FA55AFCC3AF9BD28";
		}
		if (device_info.model.Contains("SC-02H"))
		{
			Form1.PUBKEYSIGN_COUNT = "C1918938E27FE";
			Form1.PUBKEY_COUNT = "400000008B420748D";
			Form1.imeSIGN_COUNT62 = "8BA00000";
			Form1.PUBKEYSIGN = "C1918938E27FE199AD087B5361128B5CD3F7C31FAF638E984242267B9F9E060CCF4678E2CD4D37A17D8FA49F3B5F8C111043C2391DF664290359BD4F37AB2E6382DF74DC141B3789C653F6492C41DD23D3EA7764F89CF8CE42ABD3E3167336AA6B6C86C0A74A8DCE855A88632F5553109F193A90B74F0800139F2EC2EB6481B1761A082E0A31BB422FC57B508E9898C65DCECC911954684CA4E15BBF452179E6F33F98223F1FD022F5126FA1CFF957314D98C854A2B255B9B85B8E70B06BC9467514161448802A84BD55652931930302FE5401E42EBA98D22B2B9A77CA5480340DB6758A7501D358B3F568187B67570627521C1FF4187F7077CAACA68CA675A9";
			Form1.PUBKEY = "400000008B420748DD6A4A3C9929B193F5051FD826B694DF06EAE1EC0AFEBEE13B9D7C7AEACE0B5CCF9A6F03D8244155E189C424E5ECE72C7CEECDFE6764DD915714A6ABABDAE192E4E9F9891E85019FB5E62545FF92F2EDA12508B8225B95F7DDEA02F3A29FC01046AFC4FFE723377AE5F0798D22C093F5F98B1EE770AB771E1D5FA053AA052D898FFF92CDA7A5C9EDA5F17B26B9362EC3A1E002309972EF7AB9A217541405856392021F283416AB5A0E8461CEA8CADEA8047C09EE268268F3070941E017293087884A7E149D6A4A966589468E6560A74B70E3A34A717D968CB382E3B392E2022A4DF2E0E8B48773C1646A358B12D713E3CE0E6AB32A7CA70F9EA255AD493D2CCE0B66F180AFD7319FFC5F7B02EB3877A4349031DA46DA9163C658BF51C0612214B408E60F4683892DB2B974694C8A20992632D613447AA5EADA6A11E045254B5BA676F3DC517130AAC9BC2F51194D7790098E6A2784A5C843E91B37FF870B2AA4593102D3C0119571F045B25E0B2BFFB98071034ECD577ED9C927F5D4BACA545D8DD937DED119D7D37133883DAA9E401A2C703F15938EBE5435D175779815B2313D021A8DB3B779A910C52BD0E5590E3396AC8331CB6E83ACAFAD4FB103A45F43DD579661F263ADC1E73C0F3AC732EF96B37010298F782569373D602FA9DC3A4A157C252AEA8CFED6BE038E028D0700EF97CDF4FB9AD9A6A76198A3758E215533";
		}
		if (device_info.model.Contains("SCV33"))
		{
			Form1.PUBKEYSIGN_COUNT = "C1918938E27FE";
			Form1.PUBKEY_COUNT = "400000008B420748D";
			Form1.imeSIGN_COUNT62 = "8BA00000";
			Form1.PUBKEYSIGN = "C1918938E27FE199AD087B5361128B5CD3F7C31FAF638E984242267B9F9E060CCF4678E2CD4D37A17D8FA49F3B5F8C111043C2391DF664290359BD4F37AB2E6382DF74DC141B3789C653F6492C41DD23D3EA7764F89CF8CE42ABD3E3167336AA6B6C86C0A74A8DCE855A88632F5553109F193A90B74F0800139F2EC2EB6481B1761A082E0A31BB422FC57B508E9898C65DCECC911954684CA4E15BBF452179E6F33F98223F1FD022F5126FA1CFF957314D98C854A2B255B9B85B8E70B06BC9467514161448802A84BD55652931930302FE5401E42EBA98D22B2B9A77CA5480340DB6758A7501D358B3F568187B67570627521C1FF4187F7077CAACA68CA675A9";
			Form1.PUBKEY = "400000008B420748DD6A4A3C9929B193F5051FD826B694DF06EAE1EC0AFEBEE13B9D7C7AEACE0B5CCF9A6F03D8244155E189C424E5ECE72C7CEECDFE6764DD915714A6ABABDAE192E4E9F9891E85019FB5E62545FF92F2EDA12508B8225B95F7DDEA02F3A29FC01046AFC4FFE723377AE5F0798D22C093F5F98B1EE770AB771E1D5FA053AA052D898FFF92CDA7A5C9EDA5F17B26B9362EC3A1E002309972EF7AB9A217541405856392021F283416AB5A0E8461CEA8CADEA8047C09EE268268F3070941E017293087884A7E149D6A4A966589468E6560A74B70E3A34A717D968CB382E3B392E2022A4DF2E0E8B48773C1646A358B12D713E3CE0E6AB32A7CA70F9EA255AD493D2CCE0B66F180AFD7319FFC5F7B02EB3877A4349031DA46DA9163C658BF51C0612214B408E60F4683892DB2B974694C8A20992632D613447AA5EADA6A11E045254B5BA676F3DC517130AAC9BC2F51194D7790098E6A2784A5C843E91B37FF870B2AA4593102D3C0119571F045B25E0B2BFFB98071034ECD577ED9C927F5D4BACA545D8DD937DED119D7D37133883DAA9E401A2C703F15938EBE5435D175779815B2313D021A8DB3B779A910C52BD0E5590E3396AC8331CB6E83ACAFAD4FB103A45F43DD579661F263ADC1E73C0F3AC732EF96B37010298F782569373D602FA9DC3A4A157C252AEA8CFED6BE038E028D0700EF97CDF4FB9AD9A6A76198A3758E215533";
		}
		if (device_info.model.Contains("SM-G891"))
		{
			Form1.imeSIGN_COUNT62 = "8C000000";
			Form1.PUBKEYSIGN_COUNT = "A48DCC2E3989BF";
			Form1.PUBKEY_COUNT = "400000002FF2C789";
			Form1.PUBKEYSIGN = "A48DCC2E3989BFF18045312FBA93F029EBD187BDF0EF8AA5354EC4F63F2A774F2043BB07A338C2AA9764A437736ADAFDCE85CF4762FCF5F188C3EEA7F1496EA32C186B9B7E810801710CC58B2232DBA02D21776127951BFFA19D6D48E67D198DBE4D478AEAAA7A323F0979B2CA0AEBAB3EC48E34D092844FD7AB575A5E521D392986C8DFE8EB93809340BA6AF4534EC6D9915B445BF566D3B80C55F9837C7C803F166BC1E34C7CBA37397C81A201A57BCE39FD29AD2CFEF3DB97AFEE55E56917F454C09FC82CB03CD42DD893779557186B3E5F305EABEE2242F7EC5C89A87900B4422CF0B0A356CB13955D3F2EAF37B74B3918412126DC83B0DEC0D273F6EA2F";
			Form1.PUBKEY = "400000002FF2C789316B4F4EEE839233261433A25B60F4537ACEC28B14F71313D03A5AE038E9AEECBF2774072ED14EEE029F6C825E9A42F879E6651FA953651F09A3E349C509F4C0651A063BCBF59EADCFE7412A6B385D05D343D707D9B5D4489C478F784A23A5559C15B3E88E47E4B0B8BE4DC26696E122DA6D2F45C152BAE77D094CE4D1DB04C47A22810D6F4C9B46C3788CA4EC297DC73D29D6BB7956EE32BF5809D2917B2500BB78C08F1416B07578EB9CA417DA749457873228C208EC6DB96A8105CF0DB5634C72F22F8E1F83F6C4615837EF2ABF9B4FD11C4365BE61C128DBFBC3CAB675EC2F132E33E9A82495D962931C495DBB35C3BD0F7CACB6E74E42BD54A9F3E326B0F52246DCCE675C5480F616EE41A7C5FA19F152869A839F034D2CA23D988BE4C93C69F46483C0D96D0DF43CBD4D666C220CE5F214B17C2D8B6B6856489572F4006783DC185661481D0DC28FD91E8A303AF9109405BDFE7D16B59279F913A422196B731350532CF1228C8D4A03727881D16B8D075E78D02417D6BB629CCB26D8F04C5AAD1873DDC673CF6A99B278D92507368C93C1EA175AC275862DF50F826FB7B06DBF787604D5355E9A34F11BBFF0739F5BCD00B0DF11870A19EF177B9910B1ACA3DD3F89613EDC7CBE9A7D4BAEF52C764C9D5E52E192D7A647FDD6FF66F5D7E8E16A056B7A5D203A79D291FA08F0331C8783C8EA7149C94B3FC2A30E23EC8F";
		}
		if (device_info.model.Contains("SM-G892"))
		{
			Form1.PUBKEYSIGN_COUNT = "66AD929F2A38D";
			Form1.imeSIGN_COUNT62 = "8F000000";
			Form1.PUBKEY_COUNT = "40000000EBD591403D5";
			Form1.PUBKEYSIGN = "66AD929F2A38DBF1FE5D03CFB52FC9FEC5DDC7A1FA748023D77E2577E031A7F9FEC2F4D4BAFB316C067738307C0DC8938F2396C2BCCD8CB77CBC066329B2365235AB3DDC1D39B4C22D1F95B3C2DDC8464A19C9B5DB29106038FD66DB118B80D4F3741E7B78761D9A1E533D59EC0CD733F84BBCE17A0F062A33D464F5BF7FF20741992ABC9087F6EDA9EA41EF2C7579949804331AA9BCE54729E8694A84C0199EEBB0B1359760C5347AA9D4C5895DCCFFB3C139059B7F97D7E30C2CF728B2A4E3FA6B6AA13B4E8F03754C1D227936A84B70BAA1182180B4104B67A389F56E937C5EEE0067CD5A7FC63C833F57C4B17CE3ED6A440DF1FFBA30F48F91287FF136DB";
			Form1.PUBKEY = "40000000EBD591403D556B585576029F8B79DA7F7F2D1955603EF66511B73717D56CA601758D78C63B9279B6DAE9BE34EEA02762FF042704124B020B67AFCD98E192B6407101367C35EF9CFE6E1B51B1A884BA995E98A18AF7ED7958B1BCE70735A9E51DA4842E2F75396C15E7F5419DA5D4E0D71F691506C4199403023FF4241F9736655D977A1AE329A250D32D54F0A1D76BF28304A03EE34DEA78B0C86394807EFA8D08C436E474149C0B1CE4908220561019833C6FD88ABCB9E7F70FAEE2F95C8296F6B452C4B68051CF368A15BE5330C414424BE5D9D93C7F128856BB4862F9AC57CAA707E261BE76AB4A48B17EFD5440F70D7C56745D78920BD8ABB6F76140ADAEEE6EB594B1FA5221C536B7F17B4D39033936C966C1813B546859F7BB1A696E103C11E94FEEB2FCD1934BCADDDD8ED9899147285114F180B31FCD7E556192FB93382DB175CBF607C623520583E94167DB395C4DB04EC62B1065AE67FD9296D0704A57E95B1D3CDAF563F8082F5ECAD6B941134257511E0F966911AE9D6CF1479530C77FC01C8FC16327B97E62ADE68A602B67AFC84FAC3FDB7C83FDE0F2A68AFBC8BA748F471AE7C94EFF6E047A908E7F1137FA1E5EDF645A94CE387D5755B52B369516F7F54D6432A8B7895A0900678F1BD8B0F6D0FF005C05C8B4F23945B1F6D678EB935A22429551443413567BB1A9F65012FD8C3DED62CD8DB1C527A92A31BB422B67";
		}
		if (device_info.model.Contains("SM-G950"))
		{
			Form1.imeSIGN_COUNT62 = "8F000000";
			Form1.PUBKEYSIGN_COUNT = "106539FD61AF6";
			Form1.PUBKEY_COUNT = "40000000A950718E67ACD";
			Form1.PUBKEYSIGN = "106539FD61AF6A02F9A31AB4F3BEA62636638846E1F30C9D8D8FDC0BEE66A512D1FEC798F1EF61353E6B3A7D0F553F7224B16999BBEA161FF9EE02C66A1BADCC62311C66DA0354970807F25A03DB89B762FD4AE0DC12AD57C43BB1B35A40D8117BA8E97FC902F22794029D3DEF97157807560FDE7E3DEA2074AEF39428771AD6F2BF64F24889334593393DF5B4F080637BCA996B3EA5BC3986832F174095D70712E5A553C46ED7BFD9CD8FAB14595740E1FB64E6F12E1A3C0167326FF50ADB3AC5BBB9BB91655FC96CB6C064314DDFBC10924B56E2FE679EDA6ADF81BC800AE2076B3A8EB62A0EF0C2180637B9C79A9BB2BD799E3D40F4FF719D7B0BFD76B44D";
			Form1.PUBKEY = "40000000A950718E67ACDFD3B16A5020C7C42F40092EC31498BF6F5C376C635C7F39C21301AC4B76A5380CFF57544FC5290C4C3667131A991FF9B9C4A0B321E90A455BD155924AE6372E7C3B6375DD6F27377433E957C009CED8AC7B795827FFEDBDE2F104D3DD5119C1D14CC8C4EC760180A0E8638A4168E9A44F33D948F4F53F3D73F55705FBC99E85B1ABCF37CD326169236D086A3ADCE55FF20B920C75BED7FC79658FE5B5E67801919A92C176E955C9376DC14A130B3BDE0557AC45A03B97ABA137DCCB7BF8F692A502A75B31D905E0C2B60D935DE12A23ABDE500E8770BB7F68F021CD6BC591335D48F846C25F737BF46B813C0C2DCE38138B2C2C6E02C4851061D5A335E28AB6535D290DE20EE80EBA305D7B5AD52638D58CBFB35EF31BAC8A1A951897E92F80EACEAC53FC8B6AB9FF28708785BD39430E0AA254414B241DCF391CB81CE49FB1A985EC606B50B3505C4D4E95078E7E91ABBF9F9A7C9B2EFA1F5146732F7D9A031226D1C14902AE8056C87849C831B55FDE8BA92AB9A592CC912948423451FB009BF86D2D72B7DF120C4B2C7C49AD70F97F799AFF76C3D019AF9FE79C2E0141963698366FF0368AA177DE0709FC7F821DC06F74492C80B4B0C1C7FD3B0954FA0FE90F4E0C31FD78CB0511BFB1A16FBD31CC4CDDF9853F72EA400E5D3E9BD334BA614CD180873A65130668FFB0D1EB06D1AF7502CED3D5C29EA02DA4446FA4";
		}
		if (device_info.model.Contains("SC-02J"))
		{
			Form1.imeSIGN_COUNT62 = "8F000000";
			Form1.PUBKEYSIGN_COUNT = "106539FD61AF6";
			Form1.PUBKEY_COUNT = "40000000A950718E67ACD";
			Form1.PUBKEYSIGN = "106539FD61AF6A02F9A31AB4F3BEA62636638846E1F30C9D8D8FDC0BEE66A512D1FEC798F1EF61353E6B3A7D0F553F7224B16999BBEA161FF9EE02C66A1BADCC62311C66DA0354970807F25A03DB89B762FD4AE0DC12AD57C43BB1B35A40D8117BA8E97FC902F22794029D3DEF97157807560FDE7E3DEA2074AEF39428771AD6F2BF64F24889334593393DF5B4F080637BCA996B3EA5BC3986832F174095D70712E5A553C46ED7BFD9CD8FAB14595740E1FB64E6F12E1A3C0167326FF50ADB3AC5BBB9BB91655FC96CB6C064314DDFBC10924B56E2FE679EDA6ADF81BC800AE2076B3A8EB62A0EF0C2180637B9C79A9BB2BD799E3D40F4FF719D7B0BFD76B44D";
			Form1.PUBKEY = "40000000A950718E67ACDFD3B16A5020C7C42F40092EC31498BF6F5C376C635C7F39C21301AC4B76A5380CFF57544FC5290C4C3667131A991FF9B9C4A0B321E90A455BD155924AE6372E7C3B6375DD6F27377433E957C009CED8AC7B795827FFEDBDE2F104D3DD5119C1D14CC8C4EC760180A0E8638A4168E9A44F33D948F4F53F3D73F55705FBC99E85B1ABCF37CD326169236D086A3ADCE55FF20B920C75BED7FC79658FE5B5E67801919A92C176E955C9376DC14A130B3BDE0557AC45A03B97ABA137DCCB7BF8F692A502A75B31D905E0C2B60D935DE12A23ABDE500E8770BB7F68F021CD6BC591335D48F846C25F737BF46B813C0C2DCE38138B2C2C6E02C4851061D5A335E28AB6535D290DE20EE80EBA305D7B5AD52638D58CBFB35EF31BAC8A1A951897E92F80EACEAC53FC8B6AB9FF28708785BD39430E0AA254414B241DCF391CB81CE49FB1A985EC606B50B3505C4D4E95078E7E91ABBF9F9A7C9B2EFA1F5146732F7D9A031226D1C14902AE8056C87849C831B55FDE8BA92AB9A592CC912948423451FB009BF86D2D72B7DF120C4B2C7C49AD70F97F799AFF76C3D019AF9FE79C2E0141963698366FF0368AA177DE0709FC7F821DC06F74492C80B4B0C1C7FD3B0954FA0FE90F4E0C31FD78CB0511BFB1A16FBD31CC4CDDF9853F72EA400E5D3E9BD334BA614CD180873A65130668FFB0D1EB06D1AF7502CED3D5C29EA02DA4446FA4";
		}
		if (device_info.model.Contains("SCV36"))
		{
			Form1.imeSIGN_COUNT62 = "8F000000";
			Form1.PUBKEYSIGN_COUNT = "106539FD61AF6";
			Form1.PUBKEY_COUNT = "40000000A950718E67ACD";
			Form1.PUBKEYSIGN = "106539FD61AF6A02F9A31AB4F3BEA62636638846E1F30C9D8D8FDC0BEE66A512D1FEC798F1EF61353E6B3A7D0F553F7224B16999BBEA161FF9EE02C66A1BADCC62311C66DA0354970807F25A03DB89B762FD4AE0DC12AD57C43BB1B35A40D8117BA8E97FC902F22794029D3DEF97157807560FDE7E3DEA2074AEF39428771AD6F2BF64F24889334593393DF5B4F080637BCA996B3EA5BC3986832F174095D70712E5A553C46ED7BFD9CD8FAB14595740E1FB64E6F12E1A3C0167326FF50ADB3AC5BBB9BB91655FC96CB6C064314DDFBC10924B56E2FE679EDA6ADF81BC800AE2076B3A8EB62A0EF0C2180637B9C79A9BB2BD799E3D40F4FF719D7B0BFD76B44D";
			Form1.PUBKEY = "40000000A950718E67ACDFD3B16A5020C7C42F40092EC31498BF6F5C376C635C7F39C21301AC4B76A5380CFF57544FC5290C4C3667131A991FF9B9C4A0B321E90A455BD155924AE6372E7C3B6375DD6F27377433E957C009CED8AC7B795827FFEDBDE2F104D3DD5119C1D14CC8C4EC760180A0E8638A4168E9A44F33D948F4F53F3D73F55705FBC99E85B1ABCF37CD326169236D086A3ADCE55FF20B920C75BED7FC79658FE5B5E67801919A92C176E955C9376DC14A130B3BDE0557AC45A03B97ABA137DCCB7BF8F692A502A75B31D905E0C2B60D935DE12A23ABDE500E8770BB7F68F021CD6BC591335D48F846C25F737BF46B813C0C2DCE38138B2C2C6E02C4851061D5A335E28AB6535D290DE20EE80EBA305D7B5AD52638D58CBFB35EF31BAC8A1A951897E92F80EACEAC53FC8B6AB9FF28708785BD39430E0AA254414B241DCF391CB81CE49FB1A985EC606B50B3505C4D4E95078E7E91ABBF9F9A7C9B2EFA1F5146732F7D9A031226D1C14902AE8056C87849C831B55FDE8BA92AB9A592CC912948423451FB009BF86D2D72B7DF120C4B2C7C49AD70F97F799AFF76C3D019AF9FE79C2E0141963698366FF0368AA177DE0709FC7F821DC06F74492C80B4B0C1C7FD3B0954FA0FE90F4E0C31FD78CB0511BFB1A16FBD31CC4CDDF9853F72EA400E5D3E9BD334BA614CD180873A65130668FFB0D1EB06D1AF7502CED3D5C29EA02DA4446FA4";
		}
		if (device_info.model.Contains("SM-G955"))
		{
			Form1.imeSIGN_COUNT62 = "8F000000";
			Form1.PUBKEYSIGN_COUNT = "4C39C8A75E6";
			Form1.PUBKEY_COUNT = "40000000C7A134FB09";
			Form1.PUBKEYSIGN = "4C39C8A75E6AE235F35F86B914603F0B8FB1F3A03739D09FB0E96E4B79842AA8CCF702CA057065FF447B49968DE8F9BD188D62365E5B5EC880F080F136275076E757B7B92EC74C49FDE2F4D3ED60BF231DAF8EFC040755E510F039F1F5148CE6632F2CD57AC3C99EA1DE719493483960162732133EB74DAC98E8A15F90E8CEDA91EE66A6F00000135108C6CD312DE0D95450C8AA990C5C07E485EFCB0608A4F8A31A5312B17A91E725E2DB5DFDBB577A3EF83EB857960DDD89EAFE073DC5A8E8FD84364C8E909F74419F66ED0A5788D1092D052BC7C6FB96EE7703FE203A9D12239A556155FA302B5DE6C3C0493B3EC41212E58036067BB3849BA6F694E67E43";
			Form1.PUBKEY = "40000000C7A134FB0930A71C68BCE5BD698AC8D09F2D4B3CC505074BE3814D1487DFF92410781FBDADF3F1F761D135FE50AF247EC8C0B167E7D8420AA56F852E07E8CFF516C64141E095F63DD7BBF83B257439A9AE76B6B2A06C6B334BDA4DE396043E9272BB00BF53D57765661A0278ACC6DECF1AD69C896A1F4A800769BB48F398E97A3AA90211B7F8B152B6D67E05899658FEE3419A9C920E16BD0B139FD4A2B2938296B86ED26E5A0769F9E7AB0A42D7884E13240A3BEB0891E41A04CA734C13B131A37899EF4A39ADC091710DFFD3D6C99A4852EB6C6B0023F7CD52E0DDFFC9131E6D13C90A2AF3EF5EEE20F2C323FEC974D342FE49ACEFEB9C127BB5AA09D5552F101D989C8AE29105B6B9FCB8E632DD96AA579AFA7AD0725FA136AA2CDD41B6229A5FE01AD93656A7BAF52A93E3006BCC51DB59CF2461A05F87418D1A80207D24294F5A374CBD2E930F6EC0FF20CD0EB7842CBC57F8CC456525206077FE07DDB43BBB84ECE2BB7BAD1C4B29F8CA1ABE7FB93A0C141F72EF9BF31996CFF8A8E68F8BB1233BAC81DA3A177A6A1DB9243AC9FCB4C733DFD4C54282F702808DD688EF8BDFAFCE587C314E59D28ED72610BC98153683AC857B32E7CD3AF554EFCC55A941DF12AB250B499E1537C59DC8DFECE22077A718F5D98CAEAFDAA3E48C7BE0F952FD8F6AD851A922E5CD3082A47F9E94F5AE02468DAA9642F2D2998B791776331CD2012E";
		}
		if (device_info.model.Contains("SC-03J"))
		{
			Form1.imeSIGN_COUNT62 = "8F000000";
			Form1.PUBKEYSIGN_COUNT = "4C39C8A75E6";
			Form1.PUBKEY_COUNT = "40000000C7A134FB09";
			Form1.PUBKEYSIGN = "4C39C8A75E6AE235F35F86B914603F0B8FB1F3A03739D09FB0E96E4B79842AA8CCF702CA057065FF447B49968DE8F9BD188D62365E5B5EC880F080F136275076E757B7B92EC74C49FDE2F4D3ED60BF231DAF8EFC040755E510F039F1F5148CE6632F2CD57AC3C99EA1DE719493483960162732133EB74DAC98E8A15F90E8CEDA91EE66A6F00000135108C6CD312DE0D95450C8AA990C5C07E485EFCB0608A4F8A31A5312B17A91E725E2DB5DFDBB577A3EF83EB857960DDD89EAFE073DC5A8E8FD84364C8E909F74419F66ED0A5788D1092D052BC7C6FB96EE7703FE203A9D12239A556155FA302B5DE6C3C0493B3EC41212E58036067BB3849BA6F694E67E43";
			Form1.PUBKEY = "40000000C7A134FB0930A71C68BCE5BD698AC8D09F2D4B3CC505074BE3814D1487DFF92410781FBDADF3F1F761D135FE50AF247EC8C0B167E7D8420AA56F852E07E8CFF516C64141E095F63DD7BBF83B257439A9AE76B6B2A06C6B334BDA4DE396043E9272BB00BF53D57765661A0278ACC6DECF1AD69C896A1F4A800769BB48F398E97A3AA90211B7F8B152B6D67E05899658FEE3419A9C920E16BD0B139FD4A2B2938296B86ED26E5A0769F9E7AB0A42D7884E13240A3BEB0891E41A04CA734C13B131A37899EF4A39ADC091710DFFD3D6C99A4852EB6C6B0023F7CD52E0DDFFC9131E6D13C90A2AF3EF5EEE20F2C323FEC974D342FE49ACEFEB9C127BB5AA09D5552F101D989C8AE29105B6B9FCB8E632DD96AA579AFA7AD0725FA136AA2CDD41B6229A5FE01AD93656A7BAF52A93E3006BCC51DB59CF2461A05F87418D1A80207D24294F5A374CBD2E930F6EC0FF20CD0EB7842CBC57F8CC456525206077FE07DDB43BBB84ECE2BB7BAD1C4B29F8CA1ABE7FB93A0C141F72EF9BF31996CFF8A8E68F8BB1233BAC81DA3A177A6A1DB9243AC9FCB4C733DFD4C54282F702808DD688EF8BDFAFCE587C314E59D28ED72610BC98153683AC857B32E7CD3AF554EFCC55A941DF12AB250B499E1537C59DC8DFECE22077A718F5D98CAEAFDAA3E48C7BE0F952FD8F6AD851A922E5CD3082A47F9E94F5AE02468DAA9642F2D2998B791776331CD2012E";
		}
		if (device_info.model.Contains("SCV35"))
		{
			Form1.imeSIGN_COUNT62 = "8F000000";
			Form1.PUBKEYSIGN_COUNT = "4C39C8A75E6A";
			Form1.PUBKEY_COUNT = "40000000C7A134FB0";
			Form1.PUBKEYSIGN = "4C39C8A75E6AE235F35F86B914603F0B8FB1F3A03739D09FB0E96E4B79842AA8CCF702CA057065FF447B49968DE8F9BD188D62365E5B5EC880F080F136275076E757B7B92EC74C49FDE2F4D3ED60BF231DAF8EFC040755E510F039F1F5148CE6632F2CD57AC3C99EA1DE719493483960162732133EB74DAC98E8A15F90E8CEDA91EE66A6F00000135108C6CD312DE0D95450C8AA990C5C07E485EFCB0608A4F8A31A5312B17A91E725E2DB5DFDBB577A3EF83EB857960DDD89EAFE073DC5A8E8FD84364C8E909F74419F66ED0A5788D1092D052BC7C6FB96EE7703FE203A9D12239A556155FA302B5DE6C3C0493B3EC41212E58036067BB3849BA6F694E67E43";
			Form1.PUBKEY = "40000000C7A134FB0930A71C68BCE5BD698AC8D09F2D4B3CC505074BE3814D1487DFF92410781FBDADF3F1F761D135FE50AF247EC8C0B167E7D8420AA56F852E07E8CFF516C64141E095F63DD7BBF83B257439A9AE76B6B2A06C6B334BDA4DE396043E9272BB00BF53D57765661A0278ACC6DECF1AD69C896A1F4A800769BB48F398E97A3AA90211B7F8B152B6D67E05899658FEE3419A9C920E16BD0B139FD4A2B2938296B86ED26E5A0769F9E7AB0A42D7884E13240A3BEB0891E41A04CA734C13B131A37899EF4A39ADC091710DFFD3D6C99A4852EB6C6B0023F7CD52E0DDFFC9131E6D13C90A2AF3EF5EEE20F2C323FEC974D342FE49ACEFEB9C127BB5AA09D5552F101D989C8AE29105B6B9FCB8E632DD96AA579AFA7AD0725FA136AA2CDD41B6229A5FE01AD93656A7BAF52A93E3006BCC51DB59CF2461A05F87418D1A80207D24294F5A374CBD2E930F6EC0FF20CD0EB7842CBC57F8CC456525206077FE07DDB43BBB84ECE2BB7BAD1C4B29F8CA1ABE7FB93A0C141F72EF9BF31996CFF8A8E68F8BB1233BAC81DA3A177A6A1DB9243AC9FCB4C733DFD4C54282F702808DD688EF8BDFAFCE587C314E59D28ED72610BC98153683AC857B32E7CD3AF554EFCC55A941DF12AB250B499E1537C59DC8DFECE22077A718F5D98CAEAFDAA3E48C7BE0F952FD8F6AD851A922E5CD3082A47F9E94F5AE02468DAA9642F2D2998B791776331CD2012E";
		}
		if (device_info.model.Contains("SM-N950"))
		{
			Form1.imeSIGN_COUNT62 = "8F000000";
			Form1.PUBKEYSIGN_COUNT = "2B6E3E8A44A57";
			Form1.PUBKEY_COUNT = "400000009FC56C65A";
			Form1.PUBKEYSIGN = "2B6E3E8A44A57AA350F00914A59263FF498A73DB2D0374D38AAB74291F849B167CB6168000EDEB70813E4BA27C7CDF88283873D97988B0DDBA7746400618E6A887E5E9FE2CD932036E317D65C1BA2286F96645E3AC5D037A7B815C24A4C1F7620174FBDA9E072D2FBA55FCFC7F678DEF67EEEA37F009D94E7CD7CB30B0219040C196EFFD39049ABCD7DF54D1D815BE762E916DA2FC0C18F052B41B3F4BC38385E43E20AA489EC483782B77BD10D7248412287A28F044958D513971BDFCD291212CEEB38204D4FCD0EE74603D5E51F2DE221A4B77AAD060F8BD232D1666A3ED5B0C7C9AA1624EE70A17088A85E7CDFC6B04A05ADE59CD14F7959ADBF98DD7F954";
			Form1.PUBKEY = "400000009FC56C65A1E9064B6248F1CAEE0FB07A234D29BB05136D1CE3D71D2C86300CE2568C846BABBC6F4CFEBB65AAF99068E6BB4F6F5143B2EE9530345F025CF65B00E7EEF92453D4B0EBF2FC59533345BC876DCA5A1025F98B7EF581F64E127020CF004B4F5F16ACF4E60B344DB359B689EA4027C9E759B3117CE28629DE2C916251DB4DFA09CE4661E9B4B43136A5B5C3597479E439C60ADF10C95B03FCC00C6AD151E7E651A050B4BE81D1CBFD401B6BFB4A08741C180D3CB59D55FFA0D7D9CF7296B0D5D06AF1D5480DEB4E8D07F02C995CED108B6C960CAA6C3DD7899F9FA5F1768FE977FDC2BBB4D90C74C3018FCF062A25E8A2CB750C9711030E98A02A34CD3D963DE9D26566047AE7923034823FE111AC024071196F04A440F9C064069FD3643CF446725C5C28041BD3A1711448B245C6BD74B47555F4EBCA41873014FD4BCBE31AF3E6931A11AEB8D31C97A7B75A4EA6056623192A5D86B71A7DB165BB6B5BA54C3E90D35C42EAE8E65D7E3BFA2DF58EAE51B9E5B17E73A1B05765C9C7493B167A07AD87A40E32580EEDE9A5BF1F9BD84C0262B264996377079549D1A75DEE8964C5FFE6D937FB0AABFC43DDF846B32A44990D409DF70D6172F30081D03702DCD826B3BDBC1DCF95BA671F7B333ACE70637595B212EE86973D24F7A82651701433B821D93EA5AF29A6A8EE92B8ADCD2B8414CCF88126769F75F1FD030E66B775F43C";
		}
		if (device_info.model.Contains("SC-01K"))
		{
			Form1.imeSIGN_COUNT62 = "8F000000";
			Form1.PUBKEYSIGN_COUNT = "2B6E3E8A44A57";
			Form1.PUBKEY_COUNT = "400000009FC56C65A";
			Form1.PUBKEYSIGN = "2B6E3E8A44A57AA350F00914A59263FF498A73DB2D0374D38AAB74291F849B167CB6168000EDEB70813E4BA27C7CDF88283873D97988B0DDBA7746400618E6A887E5E9FE2CD932036E317D65C1BA2286F96645E3AC5D037A7B815C24A4C1F7620174FBDA9E072D2FBA55FCFC7F678DEF67EEEA37F009D94E7CD7CB30B0219040C196EFFD39049ABCD7DF54D1D815BE762E916DA2FC0C18F052B41B3F4BC38385E43E20AA489EC483782B77BD10D7248412287A28F044958D513971BDFCD291212CEEB38204D4FCD0EE74603D5E51F2DE221A4B77AAD060F8BD232D1666A3ED5B0C7C9AA1624EE70A17088A85E7CDFC6B04A05ADE59CD14F7959ADBF98DD7F954";
			Form1.PUBKEY = "400000009FC56C65A1E9064B6248F1CAEE0FB07A234D29BB05136D1CE3D71D2C86300CE2568C846BABBC6F4CFEBB65AAF99068E6BB4F6F5143B2EE9530345F025CF65B00E7EEF92453D4B0EBF2FC59533345BC876DCA5A1025F98B7EF581F64E127020CF004B4F5F16ACF4E60B344DB359B689EA4027C9E759B3117CE28629DE2C916251DB4DFA09CE4661E9B4B43136A5B5C3597479E439C60ADF10C95B03FCC00C6AD151E7E651A050B4BE81D1CBFD401B6BFB4A08741C180D3CB59D55FFA0D7D9CF7296B0D5D06AF1D5480DEB4E8D07F02C995CED108B6C960CAA6C3DD7899F9FA5F1768FE977FDC2BBB4D90C74C3018FCF062A25E8A2CB750C9711030E98A02A34CD3D963DE9D26566047AE7923034823FE111AC024071196F04A440F9C064069FD3643CF446725C5C28041BD3A1711448B245C6BD74B47555F4EBCA41873014FD4BCBE31AF3E6931A11AEB8D31C97A7B75A4EA6056623192A5D86B71A7DB165BB6B5BA54C3E90D35C42EAE8E65D7E3BFA2DF58EAE51B9E5B17E73A1B05765C9C7493B167A07AD87A40E32580EEDE9A5BF1F9BD84C0262B264996377079549D1A75DEE8964C5FFE6D937FB0AABFC43DDF846B32A44990D409DF70D6172F30081D03702DCD826B3BDBC1DCF95BA671F7B333ACE70637595B212EE86973D24F7A82651701433B821D93EA5AF29A6A8EE92B8ADCD2B8414CCF88126769F75F1FD030E66B775F43C";
		}
		if (device_info.model.Contains("SCV37"))
		{
			Form1.imeSIGN_COUNT62 = "8F000000";
			Form1.PUBKEYSIGN_COUNT = "2B6E3E8A44A57";
			Form1.PUBKEY_COUNT = "400000009FC56C65A";
			Form1.PUBKEYSIGN = "2B6E3E8A44A57AA350F00914A59263FF498A73DB2D0374D38AAB74291F849B167CB6168000EDEB70813E4BA27C7CDF88283873D97988B0DDBA7746400618E6A887E5E9FE2CD932036E317D65C1BA2286F96645E3AC5D037A7B815C24A4C1F7620174FBDA9E072D2FBA55FCFC7F678DEF67EEEA37F009D94E7CD7CB30B0219040C196EFFD39049ABCD7DF54D1D815BE762E916DA2FC0C18F052B41B3F4BC38385E43E20AA489EC483782B77BD10D7248412287A28F044958D513971BDFCD291212CEEB38204D4FCD0EE74603D5E51F2DE221A4B77AAD060F8BD232D1666A3ED5B0C7C9AA1624EE70A17088A85E7CDFC6B04A05ADE59CD14F7959ADBF98DD7F954";
			Form1.PUBKEY = "400000009FC56C65A1E9064B6248F1CAEE0FB07A234D29BB05136D1CE3D71D2C86300CE2568C846BABBC6F4CFEBB65AAF99068E6BB4F6F5143B2EE9530345F025CF65B00E7EEF92453D4B0EBF2FC59533345BC876DCA5A1025F98B7EF581F64E127020CF004B4F5F16ACF4E60B344DB359B689EA4027C9E759B3117CE28629DE2C916251DB4DFA09CE4661E9B4B43136A5B5C3597479E439C60ADF10C95B03FCC00C6AD151E7E651A050B4BE81D1CBFD401B6BFB4A08741C180D3CB59D55FFA0D7D9CF7296B0D5D06AF1D5480DEB4E8D07F02C995CED108B6C960CAA6C3DD7899F9FA5F1768FE977FDC2BBB4D90C74C3018FCF062A25E8A2CB750C9711030E98A02A34CD3D963DE9D26566047AE7923034823FE111AC024071196F04A440F9C064069FD3643CF446725C5C28041BD3A1711448B245C6BD74B47555F4EBCA41873014FD4BCBE31AF3E6931A11AEB8D31C97A7B75A4EA6056623192A5D86B71A7DB165BB6B5BA54C3E90D35C42EAE8E65D7E3BFA2DF58EAE51B9E5B17E73A1B05765C9C7493B167A07AD87A40E32580EEDE9A5BF1F9BD84C0262B264996377079549D1A75DEE8964C5FFE6D937FB0AABFC43DDF846B32A44990D409DF70D6172F30081D03702DCD826B3BDBC1DCF95BA671F7B333ACE70637595B212EE86973D24F7A82651701433B821D93EA5AF29A6A8EE92B8ADCD2B8414CCF88126769F75F1FD030E66B775F43C";
		}
		if (device_info.model.Contains("S120VL"))
		{
			Form1.imeSIGN_COUNT62 = "86000000";
			Form1.PUBKEYSIGN_COUNT = "73498EAE326B6";
			Form1.PUBKEY_COUNT = "4000000077F77E74B";
			Form1.PUBKEYSIGN = "73498EAE326B621A6357D5069B671FF476EB0DBAC566F9B7F03C6D2F60C4488BA1E3067B5B84FA7B8B98EA4A5A60B0B5C11400B3C5DFA85D1D9FE27283BB2135A60B35C179A3131D60A42BCE544A79390487D3F8F1206C33DEF03C8D9C86801A430CFC8535C884A1BD08FF507347C680B7B36D1526FBE48E7620BC61861CD254A6EDAFD670B3989B66E3A9CF364536A113337E5C3D6837FD3EB41D650BCFF13DA49EE9C4CD894750612497D65FB5CFA9E6ABD055D7D79DB3814CD432E9073C3A18BC6AE5787CC4934B80C2EDC74E31A97BF199D6AECE3897A295121FFC7A27CFAFBE3D34951DE7402A2A9D1B2F80C465742CDF45C0DD45F878ED7284B7ED7E45";
			Form1.PUBKEY = "4000000077F77E74B9ED8AD9029EE2B1C815C5EE7C9C1322E04F41C25FCFE95A691E07AB6AC90F6E754484BD5BA26BF64FC5CC5E2428271808129C46537A431DB051BC90C77EF9FC7D2D45DB13F5AB8DFE12453DD57206D49E508BC23F983A78121F9E9A254D55A5E7CB7D8986D292DA16139C99DCF80F745E3176956831937A7C56CF4B08552FA0647ADB74F965BF402455CC67EEBCE348F4FFEAC6AE196D32EDB704DA5D6EE66766BF34C57AC58563BBC1A0063BE928CDFB0C9D68122827146080BA7F11BCF121DBB1D13FED1B09EFC519259F58C3A67FDC01703C27F9F6BF60C5E4B24F3ECDEEDF9F285DAB12C8A67BBA42EA375C20B68C85ED90685C10456336C50A40D61ED155BE2D4929405A01A87D3A797C940ACE713FF23F5E36D71CFFCA662FDD61B4D06594AF6C4356037E0A843264794148328B14F9BD2A97EB10BDEABC18B2A4FA40C9AB85BBB54470C88071A4061AEB942CF54ED15CB5D450616BDB418D316A5E0B7BFB37A0C99622D7A920D3B9AF9E81B681018DC2E6B6669F4E6A4B43038AD87A12450881D73D71606A671AEC16FC0446D88A05B29D33BEF23FCA2F3672BCAC02953829636DDAAD51B9CCA6ECE43EC9BDA8205EFE549E4662BF62A9969C5F5F78781AB1AF2AC1A5AC0343A0DB09C2BA93A1D4C6C19617BE1773FBCEB58F752EE545943F9B4DFCCCDF8FA98D66D779BF41861853C39E13638FB797941F65D367A6";
		}
		if (device_info.model.Contains("S903VL"))
		{
			Form1.imeSIGN_COUNT62 = "86000000";
			Form1.PUBKEYSIGN_COUNT = "73498EAE326B6";
			Form1.PUBKEY_COUNT = "4000000077F77E74B";
			Form1.PUBKEYSIGN = "73498EAE326B621A6357D5069B671FF476EB0DBAC566F9B7F03C6D2F60C4488BA1E3067B5B84FA7B8B98EA4A5A60B0B5C11400B3C5DFA85D1D9FE27283BB2135A60B35C179A3131D60A42BCE544A79390487D3F8F1206C33DEF03C8D9C86801A430CFC8535C884A1BD08FF507347C680B7B36D1526FBE48E7620BC61861CD254A6EDAFD670B3989B66E3A9CF364536A113337E5C3D6837FD3EB41D650BCFF13DA49EE9C4CD894750612497D65FB5CFA9E6ABD055D7D79DB3814CD432E9073C3A18BC6AE5787CC4934B80C2EDC74E31A97BF199D6AECE3897A295121FFC7A27CFAFBE3D34951DE7402A2A9D1B2F80C465742CDF45C0DD45F878ED7284B7ED7E45";
			Form1.PUBKEY = "4000000077F77E74B9ED8AD9029EE2B1C815C5EE7C9C1322E04F41C25FCFE95A691E07AB6AC90F6E754484BD5BA26BF64FC5CC5E2428271808129C46537A431DB051BC90C77EF9FC7D2D45DB13F5AB8DFE12453DD57206D49E508BC23F983A78121F9E9A254D55A5E7CB7D8986D292DA16139C99DCF80F745E3176956831937A7C56CF4B08552FA0647ADB74F965BF402455CC67EEBCE348F4FFEAC6AE196D32EDB704DA5D6EE66766BF34C57AC58563BBC1A0063BE928CDFB0C9D68122827146080BA7F11BCF121DBB1D13FED1B09EFC519259F58C3A67FDC01703C27F9F6BF60C5E4B24F3ECDEEDF9F285DAB12C8A67BBA42EA375C20B68C85ED90685C10456336C50A40D61ED155BE2D4929405A01A87D3A797C940ACE713FF23F5E36D71CFFCA662FDD61B4D06594AF6C4356037E0A843264794148328B14F9BD2A97EB10BDEABC18B2A4FA40C9AB85BBB54470C88071A4061AEB942CF54ED15CB5D450616BDB418D316A5E0B7BFB37A0C99622D7A920D3B9AF9E81B681018DC2E6B6669F4E6A4B43038AD87A12450881D73D71606A671AEC16FC0446D88A05B29D33BEF23FCA2F3672BCAC02953829636DDAAD51B9CCA6ECE43EC9BDA8205EFE549E4662BF62A9969C5F5F78781AB1AF2AC1A5AC0343A0DB09C2BA93A1D4C6C19617BE1773FBCEB58F752EE545943F9B4DFCCCDF8FA98D66D779BF41861853C39E13638FB797941F65D367A6";
		}
		if (device_info.model.Contains("S320VL"))
		{
			Form1.imeSIGN_COUNT62 = "88F00000";
			Form1.PUBKEYSIGN_COUNT = "53D758AD17A29";
			Form1.PUBKEY_COUNT = "400000001199EC680";
			Form1.PUBKEYSIGN = "53D758AD17A29F27A6658ECC0DE4C362C977C3F6CD796AF3A24D92126C2CCDA94A2ACDE3CCA9DD405EBD7EF16AE76835FA4A0623676845F0387F315E9909CF667D26486FE84264655C10FB536E5DD06CF835A7FC84471DC64E6BC61CF8C09CAE0EEF071E914AAC29D7A3933C5BB9BFEEB2D41E1B115089182470F7DB922DDE51C898FE99737B4C1D5F9EDB013ABC5CFCAEB535847B93BC73BF49DF0A21DA9ECAD135982CD4E76440549220E4BDC6FA125290B35DEAD54BE2DBEA8C060803FC810784C2F9157DBBEC003930604B50DA42841D653888B3DEBE732FD62145409D2514054C7A9DBE0AEA061C547DA3A3FAAA22DFAE0C26D63DA39BE69A21D12893CC";
			Form1.PUBKEY = "400000001199EC680F88B20B58F29A92BB026ACEF0D5FFB88BE92AC9F0C2159F61F4E1820BCC69E5931B31447E9B7D165FDDA6CD80107548CCD695188B3859624B6FB102996CA238DF5C14FB53AF0CF199E96A8F0DE0EDFEF4CF32F026EAC14F820899BBDA9D2B1F1E0E2B87C5FABB348FFD9224D8D0CCB569109F7ACEE7778F06C5675FE6FE44445B29A64320FE5050D7B021E377C68746DFACD91E6DAE8F74D972970D63572F56F298F1A9DCD878B6A5EBD79A2675AAA4070B6DB3142857A965A760090CD143B77570AA0167554C6114D3462A8FDDA1AAC4DFD13B693CAC6D0B0A22BEDBCD30CD299EA055EEA9FF9DAE5AF4166311BC5F8770BEF1D5CACBD252FEF4A2235A8AA00924CB9E9B04B80612B5149FAB600D33BAC189F7DDEFD8B8A7E37A08E43191CC765FD4D9FC75488DDEBAF48A9C01970C4C4AC8821178AD73AAE79256143813818CA0E06806942F748A0F53C31A92EC7D028C0F544F0A957110F72785B1C3F66080490EA95612ADA131AE2D4A56C43044F8A91E3323F227A297F960C11831B5332159427A188369440D48C79DAE4952966100FD42B8B065436512FB08039F1D7C7B50F28AEC6E77AD28A7031E8F5B4D32BD18DE2CA8CEC1B887F686AD8DC4AA6AE2DBE31700410A3FB09D3B29938AE5FF78D4910C4DDF9F87494B7AFF14247F17CB3EA5D1B292ADB4769D9B170AB54974664C3F50D043191EAD9E172D87604A62";
		}
		if (device_info.model.Contains("J250"))
		{
			Form1.imeSIGN_COUNT62 = "88C00000";
			Form1.PUBKEYSIGN_COUNT = "8C47BF465678EA4";
			Form1.PUBKEY_COUNT = "400000000B6AAB255";
			Form1.PUBKEYSIGN = "8C47BF465678EA49025116BC97546D812AAE5ECCFA0917E8ACB3D71E1019C6E4D36BB069BE5F824894809AF4C80C45F6AD2A0184B89DA7F32275430F5B7D11A5A247CA11FAE3D4B607C1068C0103C25BB4819EAA89ECCFD31B84DFB3EB860E3B841F306AFF53352892FC0721F6343B767666CE8AB905872D98BC7A48B9D8BB6DC45611E9FAC979F398514F307BD00ADF5DAFF246E8BBBBDA90648A5ED4FCD0A8F563C1955EC274EC0F389A3512DE0BD62E7FEAE8AF3AF72DC01A1ABCB35E37467AA29C9207CAB19E07C2565D4DEC4C82A70CEB5F5A05F4A5C4D2E92846EAADD4B796F78EF30AD6AF6F08146974CA360F3766FEB9DAB936F78A7DD6E9DC80841B";
			Form1.PUBKEY = "400000000B6AAB255DAE556B10C536BD771D748AF15F1208AF122C8B01B2871A11369D8A9DB7BC209CD4125239EDD36299439CFA48CECD1E6FABF682FB62B0DD18C9DE0277A1C538ECF20F55D65B4DDE6BC9C0553C2F25189E35DC933FEF9E5CDFF1F05433C2B767C552E2C1214A321B9663A16D4BC33242DD2F3E2ED4F420B4065880ABB50665873B7BEEE0E690CA6933DC50D0E8F8A0617A7080DD9955DD11FFCE28E8E388048809432BCFE7D463FE152D56149E38BF6FA1C8D463F240BA13521B951F41C83026527DFFEA7D0227F5DE929AFD9C3487FA38B0687F63A28C0DC12567D8C72106F66605D7D30763E07980E69C7CAF65A707BC8A956070EA846777D4FFBDF09CB3DFB8F88816B29C15CF4B75BF621623F528C2116632DAAC564D6FB831FBC5F26AEA26A9544A9D7C16786218714DF7B50449CF503AF7E60D770809C4FF3F2EC51B9871B9D98FF6F32D5DE521D7367DC0D0F20A3CC01232E75604299D29F786E9E7202DF12F0683E208785D3313FB6A0A3E3A72A735434F654FBB95C7F03A118A0C0C9E8AAD86FE82FD59ADCAE1EEB1410FA43613195A415BA6A6FB5DE95FB7A9CE6E151B9AEA33CB6537281073094BFC595FB39A6FD6D539CA98BE18A8097EB1A2D9ABB958E3E2DDB08BB16286F8194548AB6953CE761B46375FA7FA207A57E0CCFF7A902BA2EF63CF226FA704206980CA3648D184F38484BAA35DD4D996C9C5E267";
		}
		if (device_info.model.Contains("J415"))
		{
			Form1.PUBKEYSIGN_COUNT = "8C47BF465678EA";
			Form1.imeSIGN_COUNT62 = "88F50000";
			Form1.PUBKEY_COUNT = "400000000B6AAB255";
			Form1.PUBKEYSIGN = "8C47BF465678EA49025116BC97546D812AAE5ECCFA0917E8ACB3D71E1019C6E4D36BB069BE5F824894809AF4C80C45F6AD2A0184B89DA7F32275430F5B7D11A5A247CA11FAE3D4B607C1068C0103C25BB4819EAA89ECCFD31B84DFB3EB860E3B841F306AFF53352892FC0721F6343B767666CE8AB905872D98BC7A48B9D8BB6DC45611E9FAC979F398514F307BD00ADF5DAFF246E8BBBBDA90648A5ED4FCD0A8F563C1955EC274EC0F389A3512DE0BD62E7FEAE8AF3AF72DC01A1ABCB35E37467AA29C9207CAB19E07C2565D4DEC4C82A70CEB5F5A05F4A5C4D2E92846EAADD4B796F78EF30AD6AF6F08146974CA360F3766FEB9DAB936F78A7DD6E9DC80841B";
			Form1.PUBKEY = "400000000B6AAB255DAE556B10C536BD771D748AF15F1208AF122C8B01B2871A11369D8A9DB7BC209CD4125239EDD36299439CFA48CECD1E6FABF682FB62B0DD18C9DE0277A1C538ECF20F55D65B4DDE6BC9C0553C2F25189E35DC933FEF9E5CDFF1F05433C2B767C552E2C1214A321B9663A16D4BC33242DD2F3E2ED4F420B4065880ABB50665873B7BEEE0E690CA6933DC50D0E8F8A0617A7080DD9955DD11FFCE28E8E388048809432BCFE7D463FE152D56149E38BF6FA1C8D463F240BA13521B951F41C83026527DFFEA7D0227F5DE929AFD9C3487FA38B0687F63A28C0DC12567D8C72106F66605D7D30763E07980E69C7CAF65A707BC8A956070EA846777D4FFBDF09CB3DFB8F88816B29C15CF4B75BF621623F528C2116632DAAC564D6FB831FBC5F26AEA26A9544A9D7C16786218714DF7B50449CF503AF7E60D770809C4FF3F2EC51B9871B9D98FF6F32D5DE521D7367DC0D0F20A3CC01232E75604299D29F786E9E7202DF12F0683E208785D3313FB6A0A3E3A72A735434F654FBB95C7F03A118A0C0C9E8AAD86FE82FD59ADCAE1EEB1410FA43613195A415BA6A6FB5DE95FB7A9CE6E151B9AEA33CB6537281073094BFC595FB39A6FD6D539CA98BE18A8097EB1A2D9ABB958E3E2DDB08BB16286F8194548AB6953CE761B46375FA7FA207A57E0CCFF7A902BA2EF63CF226FA704206980CA3648D184F38484BAA35DD4D996C9C5E267";
		}
		if (device_info.model.Contains("J410"))
		{
			Form1.imeSIGN_COUNT62 = "88000000";
			Form1.PUBKEYSIGN_COUNT = "8C47BF465678EA";
			Form1.PUBKEY_COUNT = "400000000B6AAB255";
			Form1.PUBKEYSIGN = "8C47BF465678EA49025116BC97546D812AAE5ECCFA0917E8ACB3D71E1019C6E4D36BB069BE5F824894809AF4C80C45F6AD2A0184B89DA7F32275430F5B7D11A5A247CA11FAE3D4B607C1068C0103C25BB4819EAA89ECCFD31B84DFB3EB860E3B841F306AFF53352892FC0721F6343B767666CE8AB905872D98BC7A48B9D8BB6DC45611E9FAC979F398514F307BD00ADF5DAFF246E8BBBBDA90648A5ED4FCD0A8F563C1955EC274EC0F389A3512DE0BD62E7FEAE8AF3AF72DC01A1ABCB35E37467AA29C9207CAB19E07C2565D4DEC4C82A70CEB5F5A05F4A5C4D2E92846EAADD4B796F78EF30AD6AF6F08146974CA360F3766FEB9DAB936F78A7DD6E9DC80841B";
			Form1.PUBKEY = "400000000B6AAB255DAE556B10C536BD771D748AF15F1208AF122C8B01B2871A11369D8A9DB7BC209CD4125239EDD36299439CFA48CECD1E6FABF682FB62B0DD18C9DE0277A1C538ECF20F55D65B4DDE6BC9C0553C2F25189E35DC933FEF9E5CDFF1F05433C2B767C552E2C1214A321B9663A16D4BC33242DD2F3E2ED4F420B4065880ABB50665873B7BEEE0E690CA6933DC50D0E8F8A0617A7080DD9955DD11FFCE28E8E388048809432BCFE7D463FE152D56149E38BF6FA1C8D463F240BA13521B951F41C83026527DFFEA7D0227F5DE929AFD9C3487FA38B0687F63A28C0DC12567D8C72106F66605D7D30763E07980E69C7CAF65A707BC8A956070EA846777D4FFBDF09CB3DFB8F88816B29C15CF4B75BF621623F528C2116632DAAC564D6FB831FBC5F26AEA26A9544A9D7C16786218714DF7B50449CF503AF7E60D770809C4FF3F2EC51B9871B9D98FF6F32D5DE521D7367DC0D0F20A3CC01232E75604299D29F786E9E7202DF12F0683E208785D3313FB6A0A3E3A72A735434F654FBB95C7F03A118A0C0C9E8AAD86FE82FD59ADCAE1EEB1410FA43613195A415BA6A6FB5DE95FB7A9CE6E151B9AEA33CB6537281073094BFC595FB39A6FD6D539CA98BE18A8097EB1A2D9ABB958E3E2DDB08BB16286F8194548AB6953CE761B46375FA7FA207A57E0CCFF7A902BA2EF63CF226FA704206980CA3648D184F38484BAA35DD4D996C9C5E267";
		}
		if (device_info.model.Contains("J610"))
		{
			Form1.imeSIGN_COUNT62 = "88F50000";
			Form1.PUBKEYSIGN_COUNT = "8C47BF465678EA";
			Form1.PUBKEY_COUNT = "400000000B6AAB255";
			Form1.PUBKEYSIGN = "8C47BF465678EA49025116BC97546D812AAE5ECCFA0917E8ACB3D71E1019C6E4D36BB069BE5F824894809AF4C80C45F6AD2A0184B89DA7F32275430F5B7D11A5A247CA11FAE3D4B607C1068C0103C25BB4819EAA89ECCFD31B84DFB3EB860E3B841F306AFF53352892FC0721F6343B767666CE8AB905872D98BC7A48B9D8BB6DC45611E9FAC979F398514F307BD00ADF5DAFF246E8BBBBDA90648A5ED4FCD0A8F563C1955EC274EC0F389A3512DE0BD62E7FEAE8AF3AF72DC01A1ABCB35E37467AA29C9207CAB19E07C2565D4DEC4C82A70CEB5F5A05F4A5C4D2E92846EAADD4B796F78EF30AD6AF6F08146974CA360F3766FEB9DAB936F78A7DD6E9DC80841B";
			Form1.PUBKEY = "400000000B6AAB255DAE556B10C536BD771D748AF15F1208AF122C8B01B2871A11369D8A9DB7BC209CD4125239EDD36299439CFA48CECD1E6FABF682FB62B0DD18C9DE0277A1C538ECF20F55D65B4DDE6BC9C0553C2F25189E35DC933FEF9E5CDFF1F05433C2B767C552E2C1214A321B9663A16D4BC33242DD2F3E2ED4F420B4065880ABB50665873B7BEEE0E690CA6933DC50D0E8F8A0617A7080DD9955DD11FFCE28E8E388048809432BCFE7D463FE152D56149E38BF6FA1C8D463F240BA13521B951F41C83026527DFFEA7D0227F5DE929AFD9C3487FA38B0687F63A28C0DC12567D8C72106F66605D7D30763E07980E69C7CAF65A707BC8A956070EA846777D4FFBDF09CB3DFB8F88816B29C15CF4B75BF621623F528C2116632DAAC564D6FB831FBC5F26AEA26A9544A9D7C16786218714DF7B50449CF503AF7E60D770809C4FF3F2EC51B9871B9D98FF6F32D5DE521D7367DC0D0F20A3CC01232E75604299D29F786E9E7202DF12F0683E208785D3313FB6A0A3E3A72A735434F654FBB95C7F03A118A0C0C9E8AAD86FE82FD59ADCAE1EEB1410FA43613195A415BA6A6FB5DE95FB7A9CE6E151B9AEA33CB6537281073094BFC595FB39A6FD6D539CA98BE18A8097EB1A2D9ABB958E3E2DDB08BB16286F8194548AB6953CE761B46375FA7FA207A57E0CCFF7A902BA2EF63CF226FA704206980CA3648D184F38484BAA35DD4D996C9C5E267";
		}
		if (device_info.model.Contains("J510"))
		{
			Form1.imeSIGN_COUNT62 = "89390000";
			Form1.PUBKEYSIGN_COUNT = "BB246BA4C8F83";
			Form1.PUBKEY_COUNT = "400000005F904BAB61";
			Form1.PUBKEYSIGN = "BB246BA4C8F83451CD722A06DB6CAD64C8E94E1B94890BF2B35C0DBF3CEEC0847C6415BAF4BE843D08669A1FD15C676DD349317EBA170951837D7138007AFB20E2E99B93A273E09E92A260DC6EC2A0CD76645C1AFD122283D6900DDBAFDCE5EEA0581DB472134CCA5C0CBE856C6FFB5F9CE285E4F3CD34015747639FB072AE8C74AA178CB66A99550550B9CE7D4743CF8EDF22F3A9FB8BB1107EF44742306C47E4D7423A50C0B57F9648B9245DAB257C6DC320CC766E16876E64A01780C7D2CEC53D020A1D41CA71CD1F16298E558EDCF778BF8E520F2CACF4BC9C9EBEC6000882AD1DC137CC640D00F56F6DAAB664F0A4276FFF6F30C8FFF75A442F16A3DBDA";
			Form1.PUBKEY = "400000005F904BAB6134D56042B45B36991C1F8B950A4A451CC56C7277BFA265E3133DB8F5902E945FD70C2602C8FF4C489589717654F09ABA02F9B896FD05CED76BCBE0F4366FBAE8039323BF85A8A1BBA254CE4E20820AEF12A60278A51573EC15F29CF8BDBB64517BFAE354E797F5CA6C027DF59975E7F064AFE05C348F93E137842A5530872F286CE5374B9C3DD8DFCC524ADE2CB2B116B3FEB71CACFC9C321C9BBCDFEAE58DC77F7BE7C87B5D14A63D0C307386A46CD0AF7EB92434694514114FCFAEC005BAA83D3E426EC8ECE88CB6CD6DC46938D1CD8606FB5C8541D37BD2654DE608033AF3498137D7534BE5D100DE6D616D0842209934678E65A79B3BA94D250903CED3D77343C668B65A4E55D7A111639168ADB301AD5215BEE97CE09699F0BC374DAC298F49F1FD9078220B01268A9E5161306EA4C590D5A4D62ACE28B5472387E2DC7FEA4D9DEB20E77C12F9446316DCF723E108F5FA74EE568B77AB5511A3D8C5BE1FF61D63A85DAEBAA659B2807B2C64309DDC2335433DDE21C65E517BED330338171FFE9D1FFE8D879AB1829C7539DF4A5A106DD6603A4B4AF2470EAC9CA51CAADA6E3E833F3C955AA6770CA00AAD524100BB07A4A4D85806126D8A855D4BB970E98E8D10121CF90B2ED99200DAFEF40D894DC744E7784A574B93702ADA8496A27646F6FA8435CF3945380FD45CAFDFE71E44C0043FB2E5766D3FA0AA3D36F03B";
		}
		if (device_info.model.Contains("J500"))
		{
			Form1.PUBKEYSIGN_COUNT = "BB246BA4C8F83";
			Form1.imeSIGN_COUNT62 = "88000000";
			Form1.PUBKEY_COUNT = "400000005F904BAB61";
			Form1.PUBKEYSIGN = "BB246BA4C8F83451CD722A06DB6CAD64C8E94E1B94890BF2B35C0DBF3CEEC0847C6415BAF4BE843D08669A1FD15C676DD349317EBA170951837D7138007AFB20E2E99B93A273E09E92A260DC6EC2A0CD76645C1AFD122283D6900DDBAFDCE5EEA0581DB472134CCA5C0CBE856C6FFB5F9CE285E4F3CD34015747639FB072AE8C74AA178CB66A99550550B9CE7D4743CF8EDF22F3A9FB8BB1107EF44742306C47E4D7423A50C0B57F9648B9245DAB257C6DC320CC766E16876E64A01780C7D2CEC53D020A1D41CA71CD1F16298E558EDCF778BF8E520F2CACF4BC9C9EBEC6000882AD1DC137CC640D00F56F6DAAB664F0A4276FFF6F30C8FFF75A442F16A3DBDA";
			Form1.PUBKEY = "400000005F904BAB6134D56042B45B36991C1F8B950A4A451CC56C7277BFA265E3133DB8F5902E945FD70C2602C8FF4C489589717654F09ABA02F9B896FD05CED76BCBE0F4366FBAE8039323BF85A8A1BBA254CE4E20820AEF12A60278A51573EC15F29CF8BDBB64517BFAE354E797F5CA6C027DF59975E7F064AFE05C348F93E137842A5530872F286CE5374B9C3DD8DFCC524ADE2CB2B116B3FEB71CACFC9C321C9BBCDFEAE58DC77F7BE7C87B5D14A63D0C307386A46CD0AF7EB92434694514114FCFAEC005BAA83D3E426EC8ECE88CB6CD6DC46938D1CD8606FB5C8541D37BD2654DE608033AF3498137D7534BE5D100DE6D616D0842209934678E65A79B3BA94D250903CED3D77343C668B65A4E55D7A111639168ADB301AD5215BEE97CE09699F0BC374DAC298F49F1FD9078220B01268A9E5161306EA4C590D5A4D62ACE28B5472387E2DC7FEA4D9DEB20E77C12F9446316DCF723E108F5FA74EE568B77AB5511A3D8C5BE1FF61D63A85DAEBAA659B2807B2C64309DDC2335433DDE21C65E517BED330338171FFE9D1FFE8D879AB1829C7539DF4A5A106DD6603A4B4AF2470EAC9CA51CAADA6E3E833F3C955AA6770CA00AAD524100BB07A4A4D85806126D8A855D4BB970E98E8D10121CF90B2ED99200DAFEF40D894DC744E7784A574B93702ADA8496A27646F6FA8435CF3945380FD45CAFDFE71E44C0043FB2E5766D3FA0AA3D36F03B";
		}
		if (device_info.model.Contains("J727P"))
		{
			Form1.imeSIGN_COUNT62 = "89890000";
			Form1.PUBKEYSIGN_COUNT = "C8CA090D55165";
			Form1.PUBKEY_COUNT = "40000000EF83F280F";
			Form1.PUBKEYSIGN = "C8CA090D551658909C7C20971F67D91968D728E51D3BD7EDBB8A145C8E72A89D0A4D125CC0FC933FE95E0C6985F31DDB3F6F73228C9855B6911B3774CCFC0CC45EE585C7A313421582A19CC6B9D89231773C38C8EF86424F3EFA41FF1D8825878AD50819BB7FBD284B8CEE24D53AA2A138DDABB3B6FDFF45BCA8B219CA7FEE73E1ACD7214FF9DF5FC7272279F7E35AFE7FAA1D03969742F3BDDE73FFC2873E39B2B09D643EDBD945101DCF78C59E95BFC92994094106549412CB5B30F1AED84C6F2032F685072A8132608E3603020C601EEBE81DED5BA8BD463E9EADF29DF7D3BB00341CFCB20AF85185D981A4FED6DF0DABC81380826C7B111185F1FCBD7684";
			Form1.PUBKEY = "40000000EF83F280F1F42E4F87334B6931B4FF646CD4CAC3411A21B236D22D11F5BE74C5A82BD5555BD5EB51E9D703349080A8A9FE2C001756133FABB47FED5B5120E0E1D2B22D80B09F1B1CE210B5E983BDD95F266CB75ECFE7BE45A3E35CF88D82EF1E6D58569D3EF46B6B18901C9CE65FBAFD1DD5C830CDE9F476294F84C811F1FBF620DFD84D7996F873EA3FDC37D83D7F05EE83178D674A4BE8CB86B71220F9878EA9A10B8216D78D8E867CBED8265C5316BC15F3AEB54CDD662EB35DA981346BC7914595E16891D0299FA9D2C23266698160D23750DB1A9B27D7DAC4EE67D6D136CAF8060AA73EE6EBE0B720EE007928417D9A21C9B4923E76AC67F9E73F08B62FE1E2F1E8E8E7705AE82FA2EB1CAEB859E52844D2C7C7287E1446C303FA1522D917B8087E83DFD1D4A02024CAE7262A409C27F0C7FBD85D6EAD0B36C926F0CF4C36968148CCD34BDEB3C56C02F00A3AE4DE0CE0F868C273A6A661EAAAAFFA09CECD63DFC49FD1DC51FFD19EF458216065B0F01672E9FE4D3E0F495E58E3960A9B5E0DA4CD9AC02B6F592BF977D011024B04FE0C677BC1FF44DDAF082D2BFE504F91E2F4598E9AB1776B39875F5F6AE6A2EFDAB77A67CF95153B685B86B6BCA99014B6CDE663CAA1CA79DB462929422D59E3469414FC7ADF8078A634C6966A21E9E019C2FC659B22A327A13C530D722F22242433BE2DD7F67B0C8334B9EB92E5FAF84E827D";
		}
		if (device_info.model.Contains("SM-J727V"))
		{
			Form1.imeSIGN_COUNT62 = "88F00000";
			Form1.PUBKEYSIGN_COUNT = "C8CA090D55165";
			Form1.PUBKEY_COUNT = "40000000EF83F280F";
			Form1.PUBKEYSIGN = "C8CA090D551658909C7C20971F67D91968D728E51D3BD7EDBB8A145C8E72A89D0A4D125CC0FC933FE95E0C6985F31DDB3F6F73228C9855B6911B3774CCFC0CC45EE585C7A313421582A19CC6B9D89231773C38C8EF86424F3EFA41FF1D8825878AD50819BB7FBD284B8CEE24D53AA2A138DDABB3B6FDFF45BCA8B219CA7FEE73E1ACD7214FF9DF5FC7272279F7E35AFE7FAA1D03969742F3BDDE73FFC2873E39B2B09D643EDBD945101DCF78C59E95BFC92994094106549412CB5B30F1AED84C6F2032F685072A8132608E3603020C601EEBE81DED5BA8BD463E9EADF29DF7D3BB00341CFCB20AF85185D981A4FED6DF0DABC81380826C7B111185F1FCBD7684";
			Form1.PUBKEY = "40000000EF83F280F1F42E4F87334B6931B4FF646CD4CAC3411A21B236D22D11F5BE74C5A82BD5555BD5EB51E9D703349080A8A9FE2C001756133FABB47FED5B5120E0E1D2B22D80B09F1B1CE210B5E983BDD95F266CB75ECFE7BE45A3E35CF88D82EF1E6D58569D3EF46B6B18901C9CE65FBAFD1DD5C830CDE9F476294F84C811F1FBF620DFD84D7996F873EA3FDC37D83D7F05EE83178D674A4BE8CB86B71220F9878EA9A10B8216D78D8E867CBED8265C5316BC15F3AEB54CDD662EB35DA981346BC7914595E16891D0299FA9D2C23266698160D23750DB1A9B27D7DAC4EE67D6D136CAF8060AA73EE6EBE0B720EE007928417D9A21C9B4923E76AC67F9E73F08B62FE1E2F1E8E8E7705AE82FA2EB1CAEB859E52844D2C7C7287E1446C303FA1522D917B8087E83DFD1D4A02024CAE7262A409C27F0C7FBD85D6EAD0B36C926F0CF4C36968148CCD34BDEB3C56C02F00A3AE4DE0CE0F868C273A6A661EAAAAFFA09CECD63DFC49FD1DC51FFD19EF458216065B0F01672E9FE4D3E0F495E58E3960A9B5E0DA4CD9AC02B6F592BF977D011024B04FE0C677BC1FF44DDAF082D2BFE504F91E2F4598E9AB1776B39875F5F6AE6A2EFDAB77A67CF95153B685B86B6BCA99014B6CDE663CAA1CA79DB462929422D59E3469414FC7ADF8078A634C6966A21E9E019C2FC659B22A327A13C530D722F22242433BE2DD7F67B0C8334B9EB92E5FAF84E827D";
		}
		if (device_info.model.Contains("SM-J327VPP"))
		{
			Form1.imeSIGN_COUNT62 = "88F00000";
			Form1.PUBKEY_COUNT = "400000000B6AAB255D";
			Form1.PUBKEYSIGN_COUNT = "8C47BF465678E";
			Form1.PUBKEYSIGN = "8C47BF465678EA49025116BC97546D812AAE5ECCFA0917E8ACB3D71E1019C6E4D36BB069BE5F824894809AF4C80C45F6AD2A0184B89DA7F32275430F5B7D11A5A247CA11FAE3D4B607C1068C0103C25BB4819EAA89ECCFD31B84DFB3EB860E3B841F306AFF53352892FC0721F6343B767666CE8AB905872D98BC7A48B9D8BB6DC45611E9FAC979F398514F307BD00ADF5DAFF246E8BBBBDA90648A5ED4FCD0A8F563C1955EC274EC0F389A3512DE0BD62E7FEAE8AF3AF72DC01A1ABCB35E37467AA29C9207CAB19E07C2565D4DEC4C82A70CEB5F5A05F4A5C4D2E92846EAADD4B796F78EF30AD6AF6F08146974CA360F3766FEB9DAB936F78A7DD6E9DC80841B";
			Form1.PUBKEY = "400000000B6AAB255DAE556B10C536BD771D748AF15F1208AF122C8B01B2871A11369D8A9DB7BC209CD4125239EDD36299439CFA48CECD1E6FABF682FB62B0DD18C9DE0277A1C538ECF20F55D65B4DDE6BC9C0553C2F25189E35DC933FEF9E5CDFF1F05433C2B767C552E2C1214A321B9663A16D4BC33242DD2F3E2ED4F420B4065880ABB50665873B7BEEE0E690CA6933DC50D0E8F8A0617A7080DD9955DD11FFCE28E8E388048809432BCFE7D463FE152D56149E38BF6FA1C8D463F240BA13521B951F41C83026527DFFEA7D0227F5DE929AFD9C3487FA38B0687F63A28C0DC12567D8C72106F66605D7D30763E07980E69C7CAF65A707BC8A956070EA846777D4FFBDF09CB3DFB8F88816B29C15CF4B75BF621623F528C2116632DAAC564D6FB831FBC5F26AEA26A9544A9D7C16786218714DF7B50449CF503AF7E60D770809C4FF3F2EC51B9871B9D98FF6F32D5DE521D7367DC0D0F20A3CC01232E75604299D29F786E9E7202DF12F0683E208785D3313FB6A0A3E3A72A735434F654FBB95C7F03A118A0C0C9E8AAD86FE82FD59ADCAE1EEB1410FA43613195A415BA6A6FB5DE95FB7A9CE6E151B9AEA33CB6537281073094BFC595FB39A6FD6D539CA98BE18A8097EB1A2D9ABB958E3E2DDB08BB16286F8194548AB6953CE761B46375FA7FA207A57E0CCFF7A902BA2EF63CF226FA704206980CA3648D184F38484BAA35DD4D996C9C5E267";
		}
		if (device_info.model.Contains("SM-J327V"))
		{
			Form1.imeSIGN_COUNT62 = "88F00000";
			Form1.PUBKEY_COUNT = "400000000B6AAB255D";
			Form1.PUBKEYSIGN_COUNT = "8C47BF465678E";
			Form1.PUBKEYSIGN = "8C47BF465678EA49025116BC97546D812AAE5ECCFA0917E8ACB3D71E1019C6E4D36BB069BE5F824894809AF4C80C45F6AD2A0184B89DA7F32275430F5B7D11A5A247CA11FAE3D4B607C1068C0103C25BB4819EAA89ECCFD31B84DFB3EB860E3B841F306AFF53352892FC0721F6343B767666CE8AB905872D98BC7A48B9D8BB6DC45611E9FAC979F398514F307BD00ADF5DAFF246E8BBBBDA90648A5ED4FCD0A8F563C1955EC274EC0F389A3512DE0BD62E7FEAE8AF3AF72DC01A1ABCB35E37467AA29C9207CAB19E07C2565D4DEC4C82A70CEB5F5A05F4A5C4D2E92846EAADD4B796F78EF30AD6AF6F08146974CA360F3766FEB9DAB936F78A7DD6E9DC80841B";
			Form1.PUBKEY = "400000000B6AAB255DAE556B10C536BD771D748AF15F1208AF122C8B01B2871A11369D8A9DB7BC209CD4125239EDD36299439CFA48CECD1E6FABF682FB62B0DD18C9DE0277A1C538ECF20F55D65B4DDE6BC9C0553C2F25189E35DC933FEF9E5CDFF1F05433C2B767C552E2C1214A321B9663A16D4BC33242DD2F3E2ED4F420B4065880ABB50665873B7BEEE0E690CA6933DC50D0E8F8A0617A7080DD9955DD11FFCE28E8E388048809432BCFE7D463FE152D56149E38BF6FA1C8D463F240BA13521B951F41C83026527DFFEA7D0227F5DE929AFD9C3487FA38B0687F63A28C0DC12567D8C72106F66605D7D30763E07980E69C7CAF65A707BC8A956070EA846777D4FFBDF09CB3DFB8F88816B29C15CF4B75BF621623F528C2116632DAAC564D6FB831FBC5F26AEA26A9544A9D7C16786218714DF7B50449CF503AF7E60D770809C4FF3F2EC51B9871B9D98FF6F32D5DE521D7367DC0D0F20A3CC01232E75604299D29F786E9E7202DF12F0683E208785D3313FB6A0A3E3A72A735434F654FBB95C7F03A118A0C0C9E8AAD86FE82FD59ADCAE1EEB1410FA43613195A415BA6A6FB5DE95FB7A9CE6E151B9AEA33CB6537281073094BFC595FB39A6FD6D539CA98BE18A8097EB1A2D9ABB958E3E2DDB08BB16286F8194548AB6953CE761B46375FA7FA207A57E0CCFF7A902BA2EF63CF226FA704206980CA3648D184F38484BAA35DD4D996C9C5E267";
		}
		if (device_info.model.Contains("J327P"))
		{
			Form1.imeSIGN_COUNT62 = "88F00000";
			Form1.PUBKEYSIGN_COUNT = "8C47BF465678E";
			Form1.PUBKEY_COUNT = "400000000B6AAB255D";
			Form1.PUBKEYSIGN = "8C47BF465678EA49025116BC97546D812AAE5ECCFA0917E8ACB3D71E1019C6E4D36BB069BE5F824894809AF4C80C45F6AD2A0184B89DA7F32275430F5B7D11A5A247CA11FAE3D4B607C1068C0103C25BB4819EAA89ECCFD31B84DFB3EB860E3B841F306AFF53352892FC0721F6343B767666CE8AB905872D98BC7A48B9D8BB6DC45611E9FAC979F398514F307BD00ADF5DAFF246E8BBBBDA90648A5ED4FCD0A8F563C1955EC274EC0F389A3512DE0BD62E7FEAE8AF3AF72DC01A1ABCB35E37467AA29C9207CAB19E07C2565D4DEC4C82A70CEB5F5A05F4A5C4D2E92846EAADD4B796F78EF30AD6AF6F08146974CA360F3766FEB9DAB936F78A7DD6E9DC80841B";
			Form1.PUBKEY = "400000000B6AAB255DAE556B10C536BD771D748AF15F1208AF122C8B01B2871A11369D8A9DB7BC209CD4125239EDD36299439CFA48CECD1E6FABF682FB62B0DD18C9DE0277A1C538ECF20F55D65B4DDE6BC9C0553C2F25189E35DC933FEF9E5CDFF1F05433C2B767C552E2C1214A321B9663A16D4BC33242DD2F3E2ED4F420B4065880ABB50665873B7BEEE0E690CA6933DC50D0E8F8A0617A7080DD9955DD11FFCE28E8E388048809432BCFE7D463FE152D56149E38BF6FA1C8D463F240BA13521B951F41C83026527DFFEA7D0227F5DE929AFD9C3487FA38B0687F63A28C0DC12567D8C72106F66605D7D30763E07980E69C7CAF65A707BC8A956070EA846777D4FFBDF09CB3DFB8F88816B29C15CF4B75BF621623F528C2116632DAAC564D6FB831FBC5F26AEA26A9544A9D7C16786218714DF7B50449CF503AF7E60D770809C4FF3F2EC51B9871B9D98FF6F32D5DE521D7367DC0D0F20A3CC01232E75604299D29F786E9E7202DF12F0683E208785D3313FB6A0A3E3A72A735434F654FBB95C7F03A118A0C0C9E8AAD86FE82FD59ADCAE1EEB1410FA43613195A415BA6A6FB5DE95FB7A9CE6E151B9AEA33CB6537281073094BFC595FB39A6FD6D539CA98BE18A8097EB1A2D9ABB958E3E2DDB08BB16286F8194548AB6953CE761B46375FA7FA207A57E0CCFF7A902BA2EF63CF226FA704206980CA3648D184F38484BAA35DD4D996C9C5E267";
		}
		if (device_info.model.Contains("J810"))
		{
			Form1.imeSIGN_COUNT62 = "8C000000";
			Form1.PUBKEYSIGN_COUNT = "201229DAA29D7E0";
			Form1.PUBKEY_COUNT = "400000004B7EB8649D";
			Form1.PUBKEYSIGN = "201229DAA29D7E0DA2D73136624B9CCAF07988E51A9D2A6E89F1C9B0E3F27BD0CCAB5953B3A2D6E05F1D3FBB6A4CB789853689566DEBF224EA2011B9E5D72D1A83CDF710A7CDC698C93272EFD488BCB5351F36EF71C80A291106A8F9BEDADC761B4FF4922C817999C9B5AC0E1D8C60FA73F073377876AC579F099B304989BCEC4A25CB28773A36A1D7AE80901A172C50686822E4C9B0866F37F693386BCC091E9BFC5E562EC38855D1F260CBB1CF0FCA96E3D14271EDBC986DC0B719AB150F431E53B070EBDA13412D9D83434DA52DD1749023681700811255BA48F104708C912E3B32B0C2A41D64393C402491FB8596ADB2F7BD4D73E382632E16A9EE81ED4A";
			Form1.PUBKEY = "400000004B7EB8649D2448CCF3AB675BED1B36B6B848FEE40401A41D4151D8BC89F3A40179E7505F54051C4F0C898F3D93B3F16FC4ABA11772736E429B0C8EFCF0E83CD20C3FBF9650F943D4F55CE7BE631FA9FEB4E0D6D00970F8792ABB51F9B37689AF348B0A3A9B55304CCBE0C70464C95FEB3C092499EB2002C649BF98D503090A59AFF23FBA75C9E87135FF29506DB02C4225AD6A528799D0F1C7A2C19D395B714BBEA19E2BF495E11500428A25BD3FB9B572EDCE1613B582B4288B161208FA2C78265CBA7B199E4A6F1D1D73FC18F4BC4CD810452D4AF0AA68CE794E54BFD6421CCE26BCF77A2C589754BB95C97B475461F49E11B8F3247AC892DB8E119716C79FD3259BCC69FA6737A827593060BC70D1DF897708CB93CA1D9529C2E06AD629A62515AA97DFE21D95951B91EB1560047179413EF246DED4047EEE5835DDE1B78BCFC65F27EDE275BECDF1D223453FE202F18F71B03B7A3A08608EE3B74C19C359CE62BC379DC176DB919967C501E7D0E50B1CC17796A797F13DBD59CADC16E54FABBFF18D5705A9663F3B959AE45843BD85F06113935E8EB007FDB76DEFAB1ABB6CBF4FB5FCE9839FA4DA655E9E6D048CB5F57F3B4A66AB75514B522E8B11AE78C4B9F155C6B040EEE827FC41BC513B48BF52C1F216E81DF3BE776FC0CFE139BA103EFB34EF50740FBC88C7BC534878619D731C76B773A6A4E0BBE9CF7BD0B9E7E0A6A4C3";
		}
		if (device_info.model.Contains("A605"))
		{
			Form1.imeSIGN_COUNT62 = "89890000";
			Form1.PUBKEYSIGN_COUNT = "B8E995DAB020CE";
			Form1.PUBKEY_COUNT = "40000000C35C41D11";
			Form1.PUBKEYSIGN = "B8E995DAB020CE6A3C37DDA56612854D8D6F533CD750167FBDD643E9FDB86305AE0EF5CE61910B2BB9E486690F61BFD89A360F34A73AE6B0672F7CAE2315D8F1CD859F1E90FA5C2A9AF5D8965ECAECDBB6D9E66783AA70A4182DC0A89B0E7E9E339B08F89E3EDBEB12EC18FDE152027A6423E0A3C6E78CB3E547B564FB5E713F2454E6DE0C32AA305FD944A8DDE7A1BFA09DC999E9F3C8874F96D12E07B2B933A0D741F408475C7F0AEC200A113722188A0442E59CC52046162DE9781CCBE94B4973962BAAD7111451902ADB62A462F9B579D245BE76295416588054DF3B09398C192277C231EFF7C61F11D88668D47B937AA35DA42243AFE8D6A52AE1AD4862";
			Form1.PUBKEY = "40000000C35C41D115CCE8A5E7B6C22566DD941103BEE2E3A2054EBC5E882FA40EE1D3252B543CCACF6AD9AF58A4E3E10EB6885DC1FCE35795CCE0754C20FD99D15B3A45770F5782995926A8F18F2E30E56995B62A1A65B1264C288003B60B912F9CDE5E45F55EE76D447B0F2081D6195525C9D5F730B751796ADBCF4D943A0513736300F967C94AF9488E0C1AC5E430DF23C9D8B97DF0EF1AA9CF27458EC7BCA253461B46211B523ADDBF6987D3A0A0A1ABE7C1D69E56B7FC07CD7D84F0605DBFA5DEE684A660038965782856E054A66513BF5AD46C9EF984EBBB3F0D66C6613E11F2C65FA0562A6C38ADF788640D364EEF5FBD072B16EFD0C91A888F7C859309DE63FAC5BCE29F8BF59535D2638296A29F1BF6DA75702DBD298A244BA6D41B924DBF777F110FFA848666BB9003813EF50DE732C96FC836254FC0436A06F86FC9AC4DDAD2391AACFB6FDD9A1FD995EC20B6DB21E9471B1C7CF230E277FD909686C01D5A5A40F2A2950A92A84ABB9C9CB55FF4418547FF2CBE5784633B9325E51083CB23E58E7ABB9983BF1BC86D2225CA53306AC66B1A543DE0587AF22478D523EE0D7CA3AC7145969C8B86182412D927E0147AFBAA0E4F05E5A28EB0CA1FC33CA145A0F5B21626CE4F68A05C3C885126FBD733F5E3949C9F1D75512E454762673C6CB1CECDFCAF0702F37406115F44B38D4AA40787DCD44BB008E279979E7DBCA3F5FB9DF44B66";
		}
		if (device_info.model.Contains("SC-03K"))
		{
			Form1.imeSIGN_COUNT62 = "91D00000";
			Form1.PUBKEYSIGN_COUNT = "151AA1F82E80";
			Form1.PUBKEY_COUNT = "40000000AD04A018D";
			Form1.PUBKEYSIGN = "151AA1F82E80CF08C15402F44036BAB145C67AB1220B8ECB404A357A9ABA4C1CCABFC9902EEC9F52A322CFB5BF3A40E3A4CDB5C615F4A4BB0FC20861A187C2440280C707025C5DE32E470DC7C7F3C5E73C39D0948BC543CEFA514E91A2D25170D8CE73611A38F792E11AD7D18B4B5D97BEA52DC2389AC697C444F626A448751A3631C451B289F64342939C7D9096E1853D23636AC5694044F39A3EB93E1119285F64C1254B5956E1617303A1327CB8861F20D21DAA5704260F1A9F979CCD4E9EC9AA99A06086BEA831786C13C66A7C6A43893BCE4B6605B9148149128174D599002619A6D209B5BA7A9C1BC4E868842962DC488FFA27AB1C267846E843881C3B";
			Form1.PUBKEY = "40000000AD04A018DB000C736B9B0287795A00D10EBF51044B5782C7020A9B3EB11B2131FD10D24DF48B860E884C47C97BC0B5F61F6C94E372D81FBD92EB4E436AD6C870F7C458079A1C202855B8A215426984398162A6D4EA4D0250471CB3A3139FBCDFB8CBCD03D4A32720AAF04A8FF8586D77D5C0A1DB7ACC7E7DD2BA1668E4A14065B924AA998D8E8448FF4A6DA21673216B8BB6D3F1C01D18F9C41D3BDA75094725FE9CBF8D5D3A1377EEC24E49F9BA0820DCF0E0F4C973B40E09B0FD1DF82BD7AC1BC4A39763B4DE42051E0E0BD7E325F1D8CFFFB33749973393A6A9A50DF57B478ACD919B0F3039B6CB1D88DD2C1F8401E6713FB36AA30627594957EB373A48E25E2C4FDB4B21290DCEEA31122429EAFAE8F3105407D52C5F56BD6514D27A793A2501EE8DADBF9AEF9C6B3635C80DE52A666D99A5BBCAC02B2950B5CEE35D2F177AEB1F9C717C2C0804A9B0686369685CD43619BD449C70D20A3257FC0C23BB5A19638E790F7D498F63377A6BC72CC7ED18CBFF90D0103BD1BD6872D33F9855849730AECFAD7237DE0094D00E90BA39BEB74EF033D1FC6C6C3D6827233CDB9F9723A6487F33944B65092A764B23CB4D895D045BDFC6A8DCAD1CB91C902785732A31B8BC311DFF0DD5CE329880906D365F39D03B489AD09DB0C4F862234851516460851D43006EA7B861259669381843958ECFFF5DE7004C10254865E003F943566B8E6545";
		}
		if (device_info.model.Contains("SC-02K"))
		{
			Form1.imeSIGN_COUNT62 = "91D00000";
			Form1.PUBKEYSIGN_COUNT = "151AA1F82E80";
			Form1.PUBKEY_COUNT = "40000000AD04A018D";
			Form1.PUBKEYSIGN = "151AA1F82E80CF08C15402F44036BAB145C67AB1220B8ECB404A357A9ABA4C1CCABFC9902EEC9F52A322CFB5BF3A40E3A4CDB5C615F4A4BB0FC20861A187C2440280C707025C5DE32E470DC7C7F3C5E73C39D0948BC543CEFA514E91A2D25170D8CE73611A38F792E11AD7D18B4B5D97BEA52DC2389AC697C444F626A448751A3631C451B289F64342939C7D9096E1853D23636AC5694044F39A3EB93E1119285F64C1254B5956E1617303A1327CB8861F20D21DAA5704260F1A9F979CCD4E9EC9AA99A06086BEA831786C13C66A7C6A43893BCE4B6605B9148149128174D599002619A6D209B5BA7A9C1BC4E868842962DC488FFA27AB1C267846E843881C3B";
			Form1.PUBKEY = "40000000AD04A018DB000C736B9B0287795A00D10EBF51044B5782C7020A9B3EB11B2131FD10D24DF48B860E884C47C97BC0B5F61F6C94E372D81FBD92EB4E436AD6C870F7C458079A1C202855B8A215426984398162A6D4EA4D0250471CB3A3139FBCDFB8CBCD03D4A32720AAF04A8FF8586D77D5C0A1DB7ACC7E7DD2BA1668E4A14065B924AA998D8E8448FF4A6DA21673216B8BB6D3F1C01D18F9C41D3BDA75094725FE9CBF8D5D3A1377EEC24E49F9BA0820DCF0E0F4C973B40E09B0FD1DF82BD7AC1BC4A39763B4DE42051E0E0BD7E325F1D8CFFFB33749973393A6A9A50DF57B478ACD919B0F3039B6CB1D88DD2C1F8401E6713FB36AA30627594957EB373A48E25E2C4FDB4B21290DCEEA31122429EAFAE8F3105407D52C5F56BD6514D27A793A2501EE8DADBF9AEF9C6B3635C80DE52A666D99A5BBCAC02B2950B5CEE35D2F177AEB1F9C717C2C0804A9B0686369685CD43619BD449C70D20A3257FC0C23BB5A19638E790F7D498F63377A6BC72CC7ED18CBFF90D0103BD1BD6872D33F9855849730AECFAD7237DE0094D00E90BA39BEB74EF033D1FC6C6C3D6827233CDB9F9723A6487F33944B65092A764B23CB4D895D045BDFC6A8DCAD1CB91C902785732A31B8BC311DFF0DD5CE329880906D365F39D03B489AD09DB0C4F862234851516460851D43006EA7B861259669381843958ECFFF5DE7004C10254865E003F943566B8E6545";
		}
		if (device_info.model.Contains("SCV38"))
		{
			Form1.imeSIGN_COUNT62 = "91D00000";
			Form1.PUBKEYSIGN_COUNT = "151AA1F82E80";
			Form1.PUBKEY_COUNT = "40000000AD04A018D";
			Form1.PUBKEYSIGN = "151AA1F82E80CF08C15402F44036BAB145C67AB1220B8ECB404A357A9ABA4C1CCABFC9902EEC9F52A322CFB5BF3A40E3A4CDB5C615F4A4BB0FC20861A187C2440280C707025C5DE32E470DC7C7F3C5E73C39D0948BC543CEFA514E91A2D25170D8CE73611A38F792E11AD7D18B4B5D97BEA52DC2389AC697C444F626A448751A3631C451B289F64342939C7D9096E1853D23636AC5694044F39A3EB93E1119285F64C1254B5956E1617303A1327CB8861F20D21DAA5704260F1A9F979CCD4E9EC9AA99A06086BEA831786C13C66A7C6A43893BCE4B6605B9148149128174D599002619A6D209B5BA7A9C1BC4E868842962DC488FFA27AB1C267846E843881C3B";
			Form1.PUBKEY = "40000000AD04A018DB000C736B9B0287795A00D10EBF51044B5782C7020A9B3EB11B2131FD10D24DF48B860E884C47C97BC0B5F61F6C94E372D81FBD92EB4E436AD6C870F7C458079A1C202855B8A215426984398162A6D4EA4D0250471CB3A3139FBCDFB8CBCD03D4A32720AAF04A8FF8586D77D5C0A1DB7ACC7E7DD2BA1668E4A14065B924AA998D8E8448FF4A6DA21673216B8BB6D3F1C01D18F9C41D3BDA75094725FE9CBF8D5D3A1377EEC24E49F9BA0820DCF0E0F4C973B40E09B0FD1DF82BD7AC1BC4A39763B4DE42051E0E0BD7E325F1D8CFFFB33749973393A6A9A50DF57B478ACD919B0F3039B6CB1D88DD2C1F8401E6713FB36AA30627594957EB373A48E25E2C4FDB4B21290DCEEA31122429EAFAE8F3105407D52C5F56BD6514D27A793A2501EE8DADBF9AEF9C6B3635C80DE52A666D99A5BBCAC02B2950B5CEE35D2F177AEB1F9C717C2C0804A9B0686369685CD43619BD449C70D20A3257FC0C23BB5A19638E790F7D498F63377A6BC72CC7ED18CBFF90D0103BD1BD6872D33F9855849730AECFAD7237DE0094D00E90BA39BEB74EF033D1FC6C6C3D6827233CDB9F9723A6487F33944B65092A764B23CB4D895D045BDFC6A8DCAD1CB91C902785732A31B8BC311DFF0DD5CE329880906D365F39D03B489AD09DB0C4F862234851516460851D43006EA7B861259669381843958ECFFF5DE7004C10254865E003F943566B8E6545";
		}
		if (device_info.model.Contains("SCV39"))
		{
			Form1.imeSIGN_COUNT62 = "91D00000";
			Form1.PUBKEYSIGN_COUNT = "151AA1F82E80";
			Form1.PUBKEY_COUNT = "40000000AD04A018D";
			Form1.PUBKEYSIGN = "151AA1F82E80CF08C15402F44036BAB145C67AB1220B8ECB404A357A9ABA4C1CCABFC9902EEC9F52A322CFB5BF3A40E3A4CDB5C615F4A4BB0FC20861A187C2440280C707025C5DE32E470DC7C7F3C5E73C39D0948BC543CEFA514E91A2D25170D8CE73611A38F792E11AD7D18B4B5D97BEA52DC2389AC697C444F626A448751A3631C451B289F64342939C7D9096E1853D23636AC5694044F39A3EB93E1119285F64C1254B5956E1617303A1327CB8861F20D21DAA5704260F1A9F979CCD4E9EC9AA99A06086BEA831786C13C66A7C6A43893BCE4B6605B9148149128174D599002619A6D209B5BA7A9C1BC4E868842962DC488FFA27AB1C267846E843881C3B";
			Form1.PUBKEY = "40000000AD04A018DB000C736B9B0287795A00D10EBF51044B5782C7020A9B3EB11B2131FD10D24DF48B860E884C47C97BC0B5F61F6C94E372D81FBD92EB4E436AD6C870F7C458079A1C202855B8A215426984398162A6D4EA4D0250471CB3A3139FBCDFB8CBCD03D4A32720AAF04A8FF8586D77D5C0A1DB7ACC7E7DD2BA1668E4A14065B924AA998D8E8448FF4A6DA21673216B8BB6D3F1C01D18F9C41D3BDA75094725FE9CBF8D5D3A1377EEC24E49F9BA0820DCF0E0F4C973B40E09B0FD1DF82BD7AC1BC4A39763B4DE42051E0E0BD7E325F1D8CFFFB33749973393A6A9A50DF57B478ACD919B0F3039B6CB1D88DD2C1F8401E6713FB36AA30627594957EB373A48E25E2C4FDB4B21290DCEEA31122429EAFAE8F3105407D52C5F56BD6514D27A793A2501EE8DADBF9AEF9C6B3635C80DE52A666D99A5BBCAC02B2950B5CEE35D2F177AEB1F9C717C2C0804A9B0686369685CD43619BD449C70D20A3257FC0C23BB5A19638E790F7D498F63377A6BC72CC7ED18CBFF90D0103BD1BD6872D33F9855849730AECFAD7237DE0094D00E90BA39BEB74EF033D1FC6C6C3D6827233CDB9F9723A6487F33944B65092A764B23CB4D895D045BDFC6A8DCAD1CB91C902785732A31B8BC311DFF0DD5CE329880906D365F39D03B489AD09DB0C4F862234851516460851D43006EA7B861259669381843958ECFFF5DE7004C10254865E003F943566B8E6545";
		}
		if (device_info.model.Contains("T818A"))
		{
			Form1.imeSIGN_COUNT62 = "86000000";
			Form1.PUBKEYSIGN_COUNT = "2CD19D5B16B932";
			Form1.PUBKEY_COUNT = "400000009F928D4AA1";
			Form1.PUBKEYSIGN = "D0B8714253AD0407616829A9B40688F0F6543D944100D760AC8421CE1282920D279C59CB3B508514AE50AB59ECF34AAA2CEACA24914D3EF42F0239F1B05139587181D933207E0FDE61F9D1D1A721A4E37A5F4D62C20E5A784553F958725FA7970126A8A101C147452AF6B344D0C853683C70DDA5639837DB3678A1204F9458612132778E484BEE3EC1A4B49EA49E7CA7EC6F69C246D494BD2616E4CBA6FE80671D325E45AF4E477FA17DD20FF4F72B222368997A21C9B39A2D3893A3836BA50EE70617AE05CE0EF91C5FD9C95F8A6B664B499CB46DCB2ECEEDDE31D7B7BCEFF3A3F9BDE7F9351331FD9ECA26352FA68E428E8EFE3DBBED5E8F569252C4D1090C";
			Form1.PUBKEY = "400000009F928D4AA1F6AE566DAFA5F56D84580B5E208C6E05F6524182F48813BE055DE2A4B61A1153E7F100A940185AEEC899304FD8F74DCEEBA0344C89DE2028D85619A3639258291E2570CFD7E2CD315481A9D8AE5A8650CF1E6992E9EDE2AE0C76C078AF5308DC8B12F7F5F5DE676F958D8D6DA0C0821EF9D62181A6DE13AA4928E3135FCD62F1DB45DCD8B43E1BD80791BBC67BACF2BE7E9C88288D6CC9360142D99E69C72B1924C5A18AEAD12B7DDC6443EC297C5117F415B6A47F62DD2DD51A631BF3FD8ABE70AFCD6F0CD4AF46B55D757465856ABA9B800BD82DD681665A81EBF00090E6AF98760CBD499E8E268B213E1837379333CDE6E86FA677AB312052A3F86DECA804C570FF72DFF41E2E3E8EB2FA5D6131D3D731B876C8D8B290B4DDF9B520C025A1305C4EF3CE09B4275026E17747D5DB745BA04D623A0B4C7DC2399C3AC4F9C1558FA4C3E84F3AF3A451678CD2584D5B2D08D861D9D7CC4F117B1E69848942C5E6464957106BCE8052615883BE574E02A5D8652FB86A52627D28EAF6A8D93F0A6BD3549966ABD9355DF2F065FF671A5C672940BF9170723FE2F8079B20E29A364F07F74C382F267D1836699AD118FDA7D3E166D88F5B8A7E0E3B5BD1EBEF378C810DC195063D26F681F2985E7C3A91B4E970FF909E68DBF0C95F20FC3CDA028328F659A62A1D3F17315C8D7C69229094F24F7AD1ABBA140AA8C034CE4621080E";
		}
		if (device_info.model.Contains("N97"))
		{
			Form1.imeSIGN_COUNT62 = "91D00000";
			Form1.PUBKEYSIGN_COUNT = "44B08A0A346F63";
			Form1.PUBKEY_COUNT = "4000000031C88C242F6F7A58281338F25B";
			Form1.PUBKEYSIGN = "44B08A0A346F6393D0D1EEF120C39D1CE9A9476837D0B1F369AB922D70C33D376CB6090FD9570CFF0F128AE83DF5CC7D1B73CA3668D7E9C37556AF3B7F364B805ACE7CBF7C9671FD10C9713F723940653A4EED5E9D6CCB19E0965B03F468D48447BE21939D3817C94F66FD41ADF08190F1A29CFA51FB06F17FE00D11AB85E93A8372D89A1AF57DF7B1B4E400EF59855592B2446095CC677B4DFC645533B990012315009DD566EE2229D988DB2A203236ABD820678410344D2665ED52F31F503FA8A4F0F47B3341CC84BA11844AFA559EF25F4697FBAD32F2FD95DFD733870DBC38FCE6CCD97F3E96C8AAA04B5E8CB805E765948B7FC09373CCF4001E1F2576A7";
			Form1.PUBKEY = "4000000037655E70799F23F4148946955A1A06A522F1C9D46F92C7078806F3868580AEEE43980F854778C5B6C3E7C326A7D8A4D2E59DDA91884525E90FBBF7D3C07C2244F20F9A489BDD51EA848B81A15B6D57C7C4728436272561341C73FE7634E26777EB51899F2707E6CDC6F0AF748B2D54A37195B26E54ECB36FD6B51AB92DA415A7A905AFA1A58FFAAC8471AF4F65FB712452107895F3AED6B5CAC9E89D65F0C8D6EA2576600566201557D6E59102342AEED56E0BB1E3BDD3C3C4C78E4F31273BB945C1B554EEA23669B685DA1F2A40EF716259EF45ED1974C06788689378C9EAD71F037D9837AB58C5D77A0F5B5CE4764C2AE098E136574DB11CDB73D34EE3DEC4B80B72E6FB05C1AC43B6088F3BDAC9EF2338DA2BB1BB1ADBE235FD872BFCA3A3702DEFCCF32FFAD31088AE5A29173A5862C84B67C3B0D56E67C18F32AEE8980B969F50EC39F1C87C1A592A25C301F71C772D18E5D9EE1E61BF3D80801D1ED5AFACD5B446532EACC8495D7B3FAC0B2271E58FC83AB9834C45659FF9E0C377EE71AFA6D490050C5A594A2EB6AF162781581458B89F0D769C9822CE006DDE1F8BEECD86C18D5574EC2D1DBC270FBBB8DDD4BB4690D75B22B852154CAB2608A446AAC2149BBC5D60882D1FE36786553ACBAF03553B17AD09C38D63E028E6DD40154CC06E1FF0A580385F2F2E1CEB768723BD5054082A122606C86FC784C5734AABA556298DDB";
		}
		if (device_info.model.Contains("SC-01M"))
		{
			Form1.imeSIGN_COUNT62 = "91D00000";
			Form1.PUBKEYSIGN_COUNT = "44B08A0A346F63";
			Form1.PUBKEY_COUNT = "4000000031C88C242F6F7A58281338F25B";
			Form1.PUBKEYSIGN = "44B08A0A346F6393D0D1EEF120C39D1CE9A9476837D0B1F369AB922D70C33D376CB6090FD9570CFF0F128AE83DF5CC7D1B73CA3668D7E9C37556AF3B7F364B805ACE7CBF7C9671FD10C9713F723940653A4EED5E9D6CCB19E0965B03F468D48447BE21939D3817C94F66FD41ADF08190F1A29CFA51FB06F17FE00D11AB85E93A8372D89A1AF57DF7B1B4E400EF59855592B2446095CC677B4DFC645533B990012315009DD566EE2229D988DB2A203236ABD820678410344D2665ED52F31F503FA8A4F0F47B3341CC84BA11844AFA559EF25F4697FBAD32F2FD95DFD733870DBC38FCE6CCD97F3E96C8AAA04B5E8CB805E765948B7FC09373CCF4001E1F2576A7";
			Form1.PUBKEY = "4000000037655E70799F23F4148946955A1A06A522F1C9D46F92C7078806F3868580AEEE43980F854778C5B6C3E7C326A7D8A4D2E59DDA91884525E90FBBF7D3C07C2244F20F9A489BDD51EA848B81A15B6D57C7C4728436272561341C73FE7634E26777EB51899F2707E6CDC6F0AF748B2D54A37195B26E54ECB36FD6B51AB92DA415A7A905AFA1A58FFAAC8471AF4F65FB712452107895F3AED6B5CAC9E89D65F0C8D6EA2576600566201557D6E59102342AEED56E0BB1E3BDD3C3C4C78E4F31273BB945C1B554EEA23669B685DA1F2A40EF716259EF45ED1974C06788689378C9EAD71F037D9837AB58C5D77A0F5B5CE4764C2AE098E136574DB11CDB73D34EE3DEC4B80B72E6FB05C1AC43B6088F3BDAC9EF2338DA2BB1BB1ADBE235FD872BFCA3A3702DEFCCF32FFAD31088AE5A29173A5862C84B67C3B0D56E67C18F32AEE8980B969F50EC39F1C87C1A592A25C301F71C772D18E5D9EE1E61BF3D80801D1ED5AFACD5B446532EACC8495D7B3FAC0B2271E58FC83AB9834C45659FF9E0C377EE71AFA6D490050C5A594A2EB6AF162781581458B89F0D769C9822CE006DDE1F8BEECD86C18D5574EC2D1DBC270FBBB8DDD4BB4690D75B22B852154CAB2608A446AAC2149BBC5D60882D1FE36786553ACBAF03553B17AD09C38D63E028E6DD40154CC06E1FF0A580385F2F2E1CEB768723BD5054082A122606C86FC784C5734AABA556298DDB";
		}
		if (device_info.model.Contains("G97"))
		{
			Form1.imeSIGN_COUNT62 = "91D00000";
			Form1.PUBKEYSIGN_COUNT = "44B08A0A346F63";
			Form1.PUBKEY_COUNT = "4000000037655E70799F23F41489";
			Form1.PUBKEYSIGN = "44B08A0A346F6393D0D1EEF120C39D1CE9A9476837D0B1F369AB922D70C33D376CB6090FD9570CFF0F128AE83DF5CC7D1B73CA3668D7E9C37556AF3B7F364B805ACE7CBF7C9671FD10C9713F723940653A4EED5E9D6CCB19E0965B03F468D48447BE21939D3817C94F66FD41ADF08190F1A29CFA51FB06F17FE00D11AB85E93A8372D89A1AF57DF7B1B4E400EF59855592B2446095CC677B4DFC645533B990012315009DD566EE2229D988DB2A203236ABD820678410344D2665ED52F31F503FA8A4F0F47B3341CC84BA11844AFA559EF25F4697FBAD32F2FD95DFD733870DBC38FCE6CCD97F3E96C8AAA04B5E8CB805E765948B7FC09373CCF4001E1F2576A7";
			Form1.PUBKEY = "4000000037655E70799F23F4148946955A1A06A522F1C9D46F92C7078806F3868580AEEE43980F854778C5B6C3E7C326A7D8A4D2E59DDA91884525E90FBBF7D3C07C2244F20F9A489BDD51EA848B81A15B6D57C7C4728436272561341C73FE7634E26777EB51899F2707E6CDC6F0AF748B2D54A37195B26E54ECB36FD6B51AB92DA415A7A905AFA1A58FFAAC8471AF4F65FB712452107895F3AED6B5CAC9E89D65F0C8D6EA2576600566201557D6E59102342AEED56E0BB1E3BDD3C3C4C78E4F31273BB945C1B554EEA23669B685DA1F2A40EF716259EF45ED1974C06788689378C9EAD71F037D9837AB58C5D77A0F5B5CE4764C2AE098E136574DB11CDB73D34EE3DEC4B80B72E6FB05C1AC43B6088F3BDAC9EF2338DA2BB1BB1ADBE235FD872BFCA3A3702DEFCCF32FFAD31088AE5A29173A5862C84B67C3B0D56E67C18F32AEE8980B969F50EC39F1C87C1A592A25C301F71C772D18E5D9EE1E61BF3D80801D1ED5AFACD5B446532EACC8495D7B3FAC0B2271E58FC83AB9834C45659FF9E0C377EE71AFA6D490050C5A594A2EB6AF162781581458B89F0D769C9822CE006DDE1F8BEECD86C18D5574EC2D1DBC270FBBB8DDD4BB4690D75B22B852154CAB2608A446AAC2149BBC5D60882D1FE36786553ACBAF03553B17AD09C38D63E028E6DD40154CC06E1FF0A580385F2F2E1CEB768723BD5054082A122606C86FC784C5734AABA556298DDB";
		}
		if (device_info.model.Contains("03L"))
		{
			Form1.imeSIGN_COUNT62 = "91D00000";
			Form1.PUBKEYSIGN_COUNT = "44B08A0A346F63";
			Form1.PUBKEY_COUNT = "4000000037655E70799F23F41489";
			Form1.PUBKEYSIGN = "44B08A0A346F6393D0D1EEF120C39D1CE9A9476837D0B1F369AB922D70C33D376CB6090FD9570CFF0F128AE83DF5CC7D1B73CA3668D7E9C37556AF3B7F364B805ACE7CBF7C9671FD10C9713F723940653A4EED5E9D6CCB19E0965B03F468D48447BE21939D3817C94F66FD41ADF08190F1A29CFA51FB06F17FE00D11AB85E93A8372D89A1AF57DF7B1B4E400EF59855592B2446095CC677B4DFC645533B990012315009DD566EE2229D988DB2A203236ABD820678410344D2665ED52F31F503FA8A4F0F47B3341CC84BA11844AFA559EF25F4697FBAD32F2FD95DFD733870DBC38FCE6CCD97F3E96C8AAA04B5E8CB805E765948B7FC09373CCF4001E1F2576A7";
			Form1.PUBKEY = "4000000037655E70799F23F4148946955A1A06A522F1C9D46F92C7078806F3868580AEEE43980F854778C5B6C3E7C326A7D8A4D2E59DDA91884525E90FBBF7D3C07C2244F20F9A489BDD51EA848B81A15B6D57C7C4728436272561341C73FE7634E26777EB51899F2707E6CDC6F0AF748B2D54A37195B26E54ECB36FD6B51AB92DA415A7A905AFA1A58FFAAC8471AF4F65FB712452107895F3AED6B5CAC9E89D65F0C8D6EA2576600566201557D6E59102342AEED56E0BB1E3BDD3C3C4C78E4F31273BB945C1B554EEA23669B685DA1F2A40EF716259EF45ED1974C06788689378C9EAD71F037D9837AB58C5D77A0F5B5CE4764C2AE098E136574DB11CDB73D34EE3DEC4B80B72E6FB05C1AC43B6088F3BDAC9EF2338DA2BB1BB1ADBE235FD872BFCA3A3702DEFCCF32FFAD31088AE5A29173A5862C84B67C3B0D56E67C18F32AEE8980B969F50EC39F1C87C1A592A25C301F71C772D18E5D9EE1E61BF3D80801D1ED5AFACD5B446532EACC8495D7B3FAC0B2271E58FC83AB9834C45659FF9E0C377EE71AFA6D490050C5A594A2EB6AF162781581458B89F0D769C9822CE006DDE1F8BEECD86C18D5574EC2D1DBC270FBBB8DDD4BB4690D75B22B852154CAB2608A446AAC2149BBC5D60882D1FE36786553ACBAF03553B17AD09C38D63E028E6DD40154CC06E1FF0A580385F2F2E1CEB768723BD5054082A122606C86FC784C5734AABA556298DDB";
		}
		if (device_info.model.Contains("04L"))
		{
			Form1.imeSIGN_COUNT62 = "91D00000";
			Form1.PUBKEYSIGN_COUNT = "44B08A0A346F63";
			Form1.PUBKEY_COUNT = "4000000037655E70799F23F41489";
			Form1.PUBKEYSIGN = "44B08A0A346F6393D0D1EEF120C39D1CE9A9476837D0B1F369AB922D70C33D376CB6090FD9570CFF0F128AE83DF5CC7D1B73CA3668D7E9C37556AF3B7F364B805ACE7CBF7C9671FD10C9713F723940653A4EED5E9D6CCB19E0965B03F468D48447BE21939D3817C94F66FD41ADF08190F1A29CFA51FB06F17FE00D11AB85E93A8372D89A1AF57DF7B1B4E400EF59855592B2446095CC677B4DFC645533B990012315009DD566EE2229D988DB2A203236ABD820678410344D2665ED52F31F503FA8A4F0F47B3341CC84BA11844AFA559EF25F4697FBAD32F2FD95DFD733870DBC38FCE6CCD97F3E96C8AAA04B5E8CB805E765948B7FC09373CCF4001E1F2576A7";
			Form1.PUBKEY = "4000000037655E70799F23F4148946955A1A06A522F1C9D46F92C7078806F3868580AEEE43980F854778C5B6C3E7C326A7D8A4D2E59DDA91884525E90FBBF7D3C07C2244F20F9A489BDD51EA848B81A15B6D57C7C4728436272561341C73FE7634E26777EB51899F2707E6CDC6F0AF748B2D54A37195B26E54ECB36FD6B51AB92DA415A7A905AFA1A58FFAAC8471AF4F65FB712452107895F3AED6B5CAC9E89D65F0C8D6EA2576600566201557D6E59102342AEED56E0BB1E3BDD3C3C4C78E4F31273BB945C1B554EEA23669B685DA1F2A40EF716259EF45ED1974C06788689378C9EAD71F037D9837AB58C5D77A0F5B5CE4764C2AE098E136574DB11CDB73D34EE3DEC4B80B72E6FB05C1AC43B6088F3BDAC9EF2338DA2BB1BB1ADBE235FD872BFCA3A3702DEFCCF32FFAD31088AE5A29173A5862C84B67C3B0D56E67C18F32AEE8980B969F50EC39F1C87C1A592A25C301F71C772D18E5D9EE1E61BF3D80801D1ED5AFACD5B446532EACC8495D7B3FAC0B2271E58FC83AB9834C45659FF9E0C377EE71AFA6D490050C5A594A2EB6AF162781581458B89F0D769C9822CE006DDE1F8BEECD86C18D5574EC2D1DBC270FBBB8DDD4BB4690D75B22B852154CAB2608A446AAC2149BBC5D60882D1FE36786553ACBAF03553B17AD09C38D63E028E6DD40154CC06E1FF0A580385F2F2E1CEB768723BD5054082A122606C86FC784C5734AABA556298DDB";
		}
		if (device_info.model.Contains("05L"))
		{
			Form1.imeSIGN_COUNT62 = "91D00000";
			Form1.PUBKEYSIGN_COUNT = "44B08A0A346F63";
			Form1.PUBKEY_COUNT = "4000000037655E70799F23F41489";
			Form1.PUBKEYSIGN = "44B08A0A346F6393D0D1EEF120C39D1CE9A9476837D0B1F369AB922D70C33D376CB6090FD9570CFF0F128AE83DF5CC7D1B73CA3668D7E9C37556AF3B7F364B805ACE7CBF7C9671FD10C9713F723940653A4EED5E9D6CCB19E0965B03F468D48447BE21939D3817C94F66FD41ADF08190F1A29CFA51FB06F17FE00D11AB85E93A8372D89A1AF57DF7B1B4E400EF59855592B2446095CC677B4DFC645533B990012315009DD566EE2229D988DB2A203236ABD820678410344D2665ED52F31F503FA8A4F0F47B3341CC84BA11844AFA559EF25F4697FBAD32F2FD95DFD733870DBC38FCE6CCD97F3E96C8AAA04B5E8CB805E765948B7FC09373CCF4001E1F2576A7";
			Form1.PUBKEY = "4000000037655E70799F23F4148946955A1A06A522F1C9D46F92C7078806F3868580AEEE43980F854778C5B6C3E7C326A7D8A4D2E59DDA91884525E90FBBF7D3C07C2244F20F9A489BDD51EA848B81A15B6D57C7C4728436272561341C73FE7634E26777EB51899F2707E6CDC6F0AF748B2D54A37195B26E54ECB36FD6B51AB92DA415A7A905AFA1A58FFAAC8471AF4F65FB712452107895F3AED6B5CAC9E89D65F0C8D6EA2576600566201557D6E59102342AEED56E0BB1E3BDD3C3C4C78E4F31273BB945C1B554EEA23669B685DA1F2A40EF716259EF45ED1974C06788689378C9EAD71F037D9837AB58C5D77A0F5B5CE4764C2AE098E136574DB11CDB73D34EE3DEC4B80B72E6FB05C1AC43B6088F3BDAC9EF2338DA2BB1BB1ADBE235FD872BFCA3A3702DEFCCF32FFAD31088AE5A29173A5862C84B67C3B0D56E67C18F32AEE8980B969F50EC39F1C87C1A592A25C301F71C772D18E5D9EE1E61BF3D80801D1ED5AFACD5B446532EACC8495D7B3FAC0B2271E58FC83AB9834C45659FF9E0C377EE71AFA6D490050C5A594A2EB6AF162781581458B89F0D769C9822CE006DDE1F8BEECD86C18D5574EC2D1DBC270FBBB8DDD4BB4690D75B22B852154CAB2608A446AAC2149BBC5D60882D1FE36786553ACBAF03553B17AD09C38D63E028E6DD40154CC06E1FF0A580385F2F2E1CEB768723BD5054082A122606C86FC784C5734AABA556298DDB";
		}
		object result = default(object);
		return result;
	}
}
