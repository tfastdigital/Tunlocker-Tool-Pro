using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Xml;
using Microsoft.VisualBasic.CompilerServices;

namespace motoulocked.motoulocked;

[StandardModule]
internal sealed class FIREHOSE_DEVICEINFO
{
	public static bool Read_Device_Info(string label)
	{
		if (FIREHOSE_MANAGER.StringXml.Contains("label"))
		{
			Android_Qualcomm.Prepare_ReadInfoIMG();
			Form1.SharedUI.ProgressBar1.Text = "Reading Data..";
			XmlTextReader xmlTextReader = new XmlTextReader(new StringReader(FIREHOSE_MANAGER.StringXml));
			while (xmlTextReader.Read())
			{
				if (xmlTextReader.NodeType != XmlNodeType.Element || Operators.CompareString(xmlTextReader.Name, "read", TextCompare: false) != 0)
				{
					continue;
				}
				string attribute = xmlTextReader.GetAttribute("SECTOR_SIZE_IN_BYTES");
				string attribute2 = xmlTextReader.GetAttribute("num_partition_sectors");
				string attribute3 = xmlTextReader.GetAttribute("physical_partition_number");
				if (FIREHOSE_PARTITIONS.ReadPartition(xmlTextReader.GetAttribute("start_sector"), attribute2, attribute, attribute3, ref label))
				{
					if (File.Exists(sourcefile.Dumped))
					{
						if (Android_Qualcomm.ReadInfoIMG())
						{
							return true;
						}
						return false;
					}
					continue;
				}
				return false;
			}
		}
		bool result = default(bool);
		return result;
	}

	public static bool Read_Knox_Data(string label)
	{
		if (FIREHOSE_MANAGER.StringXml.Contains("label"))
		{
			UiManager.Richlogs("- Reading KG/Knox Data : ", Color.Black, isBold: false);
			Form1.SharedUI.ProgressBar1.Text = "Reading KG/Knox Data..";
			XmlTextReader xmlTextReader = new XmlTextReader(new StringReader(FIREHOSE_MANAGER.StringXml));
			FIREHOSE_MANAGER.foldersave = Application.StartupPath + "\\tmp";
			while (xmlTextReader.Read())
			{
				if (xmlTextReader.NodeType == XmlNodeType.Element && Operators.CompareString(xmlTextReader.Name, "read", TextCompare: false) == 0)
				{
					object attribute = xmlTextReader.GetAttribute("SECTOR_SIZE_IN_BYTES");
					object attribute2 = xmlTextReader.GetAttribute("num_partition_sectors");
					object attribute3 = xmlTextReader.GetAttribute("physical_partition_number");
					if (!FIREHOSE_PARTITIONS.ReadPartition(Conversions.ToString(xmlTextReader.GetAttribute("start_sector")), Conversions.ToString(attribute2), Conversions.ToString(attribute), Conversions.ToString(attribute3), ref label))
					{
						return false;
					}
				}
			}
			return true;
		}
		bool result = default(bool);
		return result;
	}
}
