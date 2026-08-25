using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Xml;
using Microsoft.VisualBasic.CompilerServices;

namespace motoulocked.HuaweiUnlocker.DIAGNOS;

public class Bootloader
{
	public class Image
	{
		private bool? valid;

		private int? sizee;

		public string Path { get; }

		public string Role { get; }

		public uint Address { get; }

		private string Hash { get; }

		public bool IsValid => valid ?? Validate();

		public int Size => sizee ?? GetSize();

		private bool Validate()
		{
			if (Hash == null)
			{
				return true;
			}
			using (FileStream fileStream = File.OpenRead(Path))
			{
				using SHA1 sHA = SHA1.Create();
				fileStream.Position = 0L;
				byte[] array = sHA.ComputeHash(fileStream);
				fileStream.Close();
				valid = Operators.CompareString(BitConverter.ToString(array).Replace("-", "").ToLower(), Hash, TextCompare: false) == 0;
			}
			return valid.Value;
		}

		private int GetSize()
		{
			sizee = checked((int)new FileInfo(Path).Length);
			return sizee.Value;
		}

		public Image(string path, string role, uint address, string hash = null)
		{
			Path = path;
			Role = role;
			Address = address;
			Hash = hash;
		}
	}

	private static string[] requiredStrings = new string[4] { "path", "role", "hash", "address" };

	public Image[] Images { get; }

	public string Title { get; }

	public string Name { get; }

	public Bootloader(string name, string title, Image[] images)
	{
		Title = title;
		Name = name;
		Images = images;
	}

	private static uint ParseAddress(string str)
	{
		return Convert.ToUInt32(str, str.StartsWith("0x") ? 16 : 10);
	}

	private static XmlElement GetRootFromFile(string filename)
	{
		XmlDocument xmlDocument = new XmlDocument();
		xmlDocument.Load(filename);
		XmlElement documentElement = xmlDocument.DocumentElement;
		if (Operators.CompareString(documentElement.Name, "bootloader", TextCompare: false) != 0)
		{
			throw new Exception("XML root name is invalid.");
		}
		return documentElement;
	}

	public static Bootloader ParseBootloader(string filename)
	{
		XmlElement rootFromFile = GetRootFromFile(filename);
		string directoryName = Path.GetDirectoryName(filename);
		string text = rootFromFile.GetAttribute("name");
		if (string.IsNullOrEmpty(text))
		{
			text = "Unknown bootloader";
		}
		List<Image> list = new List<Image>();
		foreach (object item in rootFromFile)
		{
			XmlNode xmlNode = (XmlNode)RuntimeHelpers.GetObjectValue(item);
			bool flag = Operators.CompareString(xmlNode.Name, "image", TextCompare: false) != 0;
			string[] array = requiredStrings;
			foreach (string name in array)
			{
				XmlNode namedItem = xmlNode.Attributes.GetNamedItem(name);
				flag = flag || namedItem == null || string.IsNullOrWhiteSpace(namedItem.Value);
			}
			if (flag)
			{
				throw new Exception("Failed to parse image");
			}
			list.Add(new Image(Path.Combine(directoryName, xmlNode.Attributes.GetNamedItem("path").Value), xmlNode.Attributes.GetNamedItem("role").Value, ParseAddress(xmlNode.Attributes.GetNamedItem("address").Value), xmlNode.Attributes.GetNamedItem("hash").Value));
		}
		return new Bootloader(Path.GetFileName(directoryName), text, list.ToArray());
	}

	public static Bootloader[] GetBootloaders()
	{
		List<Bootloader> list = new List<Bootloader>();
		string path = Path.Combine(Environment.CurrentDirectory, "bootloaders");
		if (!Directory.Exists(path))
		{
			return new Bootloader[0];
		}
		string[] directories = Directory.GetDirectories(path);
		for (int i = 0; i < directories.Length; i = checked(i + 1))
		{
			string text = Path.Combine(directories[i], "manifest.xml");
			if (File.Exists(text))
			{
				list.Add(ParseBootloader(text));
			}
		}
		return list.ToArray();
	}
}
