/* 
 * This file is part of the LaserParamsConverter distribution (https://github.com/shark92651/LaserParamsConverter).
 * Copyright (c) 2022 David Christian.
 * 
 * This program is free software: you can redistribute it and/or modify  
 * it under the terms of the GNU General Public License as published by  
 * the Free Software Foundation, version 3.
 *
 * This program is distributed in the hope that it will be useful, but 
 * WITHOUT ANY WARRANTY; without even the implied warranty of 
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the GNU 
 * General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License 
 * along with this program. If not, see <http://www.gnu.org/licenses/>.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Globalization;
using System.Reflection;
using System.ComponentModel;
using System.IO;

namespace LaserParamsConverter
{
	public enum LaserType 
	{
		[Description("CO2 Gantry")]
		CO2,
		[Description("Fiber Laser")]
		Fiber 
	};

	public enum LibraryType { EZCAD2, EZCAD3, LightBurn };


	static class LaserHelper
	{
		public static string GetDescription(this Enum value)
		{
			Type type = value.GetType();
			string name = Enum.GetName(type, value);
			if (name != null)
			{
				FieldInfo field = type.GetField(name);
				if (field != null)
				{
					DescriptionAttribute attr =
								 Attribute.GetCustomAttribute(field,
									 typeof(DescriptionAttribute)) as DescriptionAttribute;
					if (attr != null)
					{
						return attr.Description;
					}
				}
			}
			return value.ToString();
		}
	}


	public class LaserLibrary
	{
		private LaserType laser;
		public LaserType Laser { get => laser; set => laser = value; }

		private string fileName = "";
		public string FileName { get => fileName; set => fileName = value; }

		private LibraryType format;
		public LibraryType Format { get => format; set => format = value; }

		private int maxPower;
		public int MaxPower { get => maxPower; set => maxPower = value; }

		private int lens;
		public int Lens { get => lens; set => lens = value; }

		private int wattage;
		public int Wattage { get => wattage; set => wattage = value; }

		private XmlDocument doc = new XmlDocument();

		public XmlDocument XmlDoc { get => doc;}

		public LaserLibrary(LibraryType format, LaserType laser, int maxPower, int lens, int wattage)
		{
			Format = format;
			Laser = laser;
			MaxPower = maxPower;
			Lens = lens;
			Wattage = wattage;
		}

		public void LoadLibrary(string fileName)
		{
			FileName = fileName;

			switch (Format)
			{
				case LibraryType.EZCAD2:
				case LibraryType.EZCAD3:
					LoadEZCAD(format, fileName);
					break;
				case LibraryType.LightBurn:
					LoadLightBurn(fileName);
					break;

				default:
					break;
			}
		}

		private void LoadLightBurn(string fileName)
		{
			doc = new XmlDocument();
			doc.Load(fileName);
		}

		private void LoadEZCAD(LibraryType lib, string fileName)
		{
			doc = new XmlDocument();
			XmlDeclaration xmlDeclaration = doc.CreateXmlDeclaration("1.0", "UTF-8", null);
			XmlElement root = doc.DocumentElement;
			doc.InsertBefore(xmlDeclaration, root);

			string rootName = "EZCADLibrary";

			XmlElement body = doc.CreateElement(string.Empty, rootName, string.Empty);
			doc.AppendChild(body);

			string s;
			string materialName;
			XmlElement material;

			XmlElement entry;
			XmlElement cutSetting = doc.CreateElement(string.Empty, "CutSetting", string.Empty);
			bool materialFound = false;

			foreach (string line in File.ReadLines(fileName))
			{
				s = line.Trim();
				if (s.Length > 0)
				{
					if (s.StartsWith("["))
					{
						materialFound = true;
						materialName = s.Replace("[", "").Replace("]", "");
						material = doc.CreateElement(string.Empty, "Material", string.Empty);
						material.SetAttribute("name", materialName);
						body.AppendChild(material);

						entry = doc.CreateElement(string.Empty, "Entry", string.Empty);
						entry.SetAttribute("Thickness", "-1.0000");
						entry.SetAttribute("Desc", "Description");
						entry.SetAttribute("NoThickTitle", "Title");
						material.AppendChild(entry);

						cutSetting = doc.CreateElement(string.Empty, "CutSetting", string.Empty);
						cutSetting.SetAttribute("type", "Scan");
						entry.AppendChild(cutSetting);
					}
					else if (materialFound)
					{
						AppendCutSetting(cutSetting, s);
					}
				}
			}
		}

		public void Save(string fileName)
		{
			switch (Format)
			{
				case LibraryType.EZCAD2:
				case LibraryType.EZCAD3:
					SaveEZCAD(/*format,*/ Format, fileName);
					break;
				case LibraryType.LightBurn:
					SaveLightBurn(fileName);
					break;
				default:
					break;
			}
		}

		private void SaveLightBurn(string fileName)
		{
			doc.Save(fileName);
		}
				
		public void SaveAsLightBurn(string fileName)
		{
			if (Format == LibraryType.LightBurn)
			{
				SaveLightBurn(fileName);
				return;
			}

			XmlDocument xdoc = new XmlDocument();
			XmlDeclaration xmlDeclaration = xdoc.CreateXmlDeclaration("1.0", "UTF-8", null);
			XmlElement root = xdoc.DocumentElement;
			xdoc.InsertBefore(xmlDeclaration, root);

			XmlElement body = xdoc.CreateElement(string.Empty, "LightBurnLibrary", string.Empty);
			xdoc.AppendChild(body);

			string materialPath = "//EZCADLibrary/Material";
			string freqPath = (Format == LibraryType.EZCAD2) ? ".//FREQ" : "//FREQF";

			foreach (XmlNode node in doc.SelectNodes(materialPath))
			{
				if (node.Attributes["name"].Value == "LASERMODE")
					continue;

				XmlNode imported = xdoc.ImportNode(node, true);
				body.AppendChild(imported);
			}

			int loop;
			int speed;
			int power;
			int freq;

			foreach (XmlNode node in xdoc.SelectNodes("//LightBurnLibrary/Material/Entry/CutSetting"))
			{
				loop = int.Parse(node.SelectSingleNode(".//LOOP").Attributes[0].Value, NumberFormatInfo.InvariantInfo);
				speed = int.Parse(node.SelectSingleNode(".//MARKSPEED").Attributes[0].Value, NumberStyles.AllowExponent | NumberStyles.AllowDecimalPoint, NumberFormatInfo.InvariantInfo);
				power = int.Parse(node.SelectSingleNode(".//POWERRATIO").Attributes[0].Value, NumberStyles.AllowExponent | NumberStyles.AllowDecimalPoint, NumberFormatInfo.InvariantInfo);
				freq = int.Parse(node.SelectSingleNode(freqPath).Attributes[0].Value, NumberStyles.AllowExponent | NumberStyles.AllowDecimalPoint, NumberFormatInfo.InvariantInfo);

				RemoveAllChildren(node);
				AddChildWithValue(xdoc, node, "index", "0");
				AddChildWithValue(xdoc, node, "name", "");
				AddChildWithValue(xdoc, node, "minPower", power.ToString(NumberFormatInfo.InvariantInfo));
				AddChildWithValue(xdoc, node, "maxPower", power.ToString(NumberFormatInfo.InvariantInfo));
				AddChildWithValue(xdoc, node, "minPower2", "10");
				AddChildWithValue(xdoc, node, "maxPower2", "20");
				AddChildWithValue(xdoc, node, "speed", speed.ToString(NumberFormatInfo.InvariantInfo));
				AddChildWithValue(xdoc, node, "priority", "0");
				AddChildWithValue(xdoc, node, "frequency", freq.ToString(NumberFormatInfo.InvariantInfo));
				AddChildWithValue(xdoc, node, "PPI", "0");
				AddChildWithValue(xdoc, node, "JumpSpeed", "4000");
				if (loop > 1)
					AddChildWithValue(xdoc, node, "numPasses", loop.ToString(NumberFormatInfo.InvariantInfo));
				AddChildWithValue(xdoc, node, "perfLen", "0.01");
				AddChildWithValue(xdoc, node, "perfSkip", "0.01");
				AddChildWithValue(xdoc, node, "dotTime", "1");
				AddChildWithValue(xdoc, node, "dotSpacing", "0.1");
				AddChildWithValue(xdoc, node, "bidir", "0");
				AddChildWithValue(xdoc, node, "crossHatch", "1");
				AddChildWithValue(xdoc, node, "overscan", "0");
				AddChildWithValue(xdoc, node, "interval", "0.025");
				AddChildWithValue(xdoc, node, "angle", "45");
			}

			xdoc.Save(fileName);
		}

		private void AddChildWithValue(XmlDocument doc, XmlNode parent, string name, string value)
		{
			XmlElement child = doc.CreateElement(String.Empty, name, String.Empty);
			child.SetAttribute("Value", value);
			parent.AppendChild(child);
		}

		private void RemoveAllChildren(XmlNode node)
		{
			List<XmlNode> children = new List<XmlNode>();
			foreach (XmlNode child in node.ChildNodes)
			{
				children.Add(child);
			}

			foreach (XmlNode child in children)
			{
				node.RemoveChild(child);
			}
		}

		public void SaveEZCAD(LibraryType outLib, string fileName)
		{
			// Saving from LightBurn to EZ is not supported
			if (Format == LibraryType.LightBurn)
				return;

			StringBuilder sb = new StringBuilder();

			string materialPath = "//EZCADLibrary/Material";

			foreach (XmlNode node in doc.SelectNodes(materialPath))
			{
				sb.AppendLine(string.Format("[{0}]", node.Attributes["name"].Value));

				XmlNode cutSettingNode = node.SelectSingleNode(".//CutSetting");
				foreach (XmlNode childNode in cutSettingNode.ChildNodes)
				{
					string nodeName = childNode.Name;

					// Only requirement to save between EZ2 and EZ3 is Frequency name
					if (outLib == LibraryType.EZCAD2 && nodeName == "FREQF")
						nodeName = "FREQ";
					else if (outLib == LibraryType.EZCAD3 && nodeName == "FREQ")
						nodeName = "FREQF";

					sb.AppendLine(string.Format("{0}={1}", nodeName, childNode.Attributes["Value"].Value));
				}
				sb.AppendLine();
			}

			File.WriteAllText(fileName, sb.ToString());
		}

		private void AppendCutSetting(XmlElement cutSetting, string s)
		{
			string name = s.Substring(0, s.IndexOf("="));
			string value = s.Substring(s.IndexOf("=") + 1);

			XmlElement param = doc.CreateElement(string.Empty, name, string.Empty);
			param.SetAttribute("Value", value);
			cutSetting.AppendChild(param);
		}

		public LaserLibrary Convert(LibraryType outFormat, LaserType outLaser, int outMaxPower, int outLens, int outWattage)
		{
			LaserLibrary outLib = new LaserLibrary(outFormat, outLaser, outMaxPower, outLens, outWattage);
			outLib.doc = (XmlDocument)doc.Clone();

			switch (outFormat)
			{
				case LibraryType.EZCAD2:
				case LibraryType.EZCAD3:
					ConvertEZCAD(outFormat, outLib);
					break;
				case LibraryType.LightBurn:
					ConvertLightBurn(outLib);
					break;
				default:
					break;
			}

			return outLib;
		}

		private void ConvertLightBurn(LaserLibrary outLib)
		{
			string cutSettingPath = "//LightBurnLibrary/Material/Entry";

			foreach (XmlNode node in outLib.doc.SelectNodes(cutSettingPath))
			{
				XmlNode speedNode = node.SelectSingleNode(".//speed");
				XmlNode minPowerNode = node.SelectSingleNode(".//minPower");
				XmlNode maxPowerNode = node.SelectSingleNode(".//maxPower");

				if (speedNode != null && minPowerNode != null && maxPowerNode != null)
				{
					int speed = int.Parse(speedNode.Attributes[0].Value, NumberFormatInfo.InvariantInfo);
					int power = int.Parse(maxPowerNode.Attributes[0].Value, NumberFormatInfo.InvariantInfo);

					LaserParam param = new LaserParam(speed, power);
					param.Convert(outLib.Laser, outLib.MaxPower, this.Lens, this.Wattage, outLib.Lens, outLib.Wattage);

					speedNode.Attributes[0].Value = param.Speed.ToString(NumberFormatInfo.InvariantInfo);
					minPowerNode.Attributes[0].Value = param.Power.ToString(NumberFormatInfo.InvariantInfo);
					maxPowerNode.Attributes[0].Value = param.Power.ToString(NumberFormatInfo.InvariantInfo);
				}
			}
		}

		private void ConvertEZCAD(LibraryType lib, LaserLibrary outLib)
		{
			string cutSettingPath = "//EZCADLibrary/Material/Entry";

			foreach (XmlNode node in outLib.doc.SelectNodes(cutSettingPath))
			{
				XmlNode speedNode = node.SelectSingleNode(".//MARKSPEED");
				XmlNode powerNode = node.SelectSingleNode(".//POWERRATIO");

				if (speedNode != null && powerNode != null)
				{
					int speed = int.Parse(speedNode.Attributes[0].Value, NumberStyles.AllowExponent | NumberStyles.AllowDecimalPoint, NumberFormatInfo.InvariantInfo);
					int power = int.Parse(powerNode.Attributes[0].Value, NumberStyles.AllowExponent | NumberStyles.AllowDecimalPoint, NumberFormatInfo.InvariantInfo);

					LaserParam param = new LaserParam(speed, power);
					param.Convert(outLib.Laser, outLib.MaxPower, this.Lens, this.Wattage, outLib.Lens, outLib.Wattage);

					if (lib == LibraryType.EZCAD2)
					{
						speedNode.Attributes[0].Value = param.Speed.ToString("E6", NumberFormatInfo.InvariantInfo).ToLower();
						powerNode.Attributes[0].Value = param.Power.ToString("E6", NumberFormatInfo.InvariantInfo).ToLower();
					}
					else
					{
						speedNode.Attributes[0].Value = param.Speed.ToString("0.000000", NumberFormatInfo.InvariantInfo);
						powerNode.Attributes[0].Value = param.Power.ToString("0.000000", NumberFormatInfo.InvariantInfo);
					}

				}
			}
		}

		public class LaserParam
		{
			public int Speed { get; set; }
			public int Power { get; set; }

			public LaserParam(int speed, int power)
			{
				Speed = speed;
				Power = power;
			}

			public void Convert(LaserType laser, int maxPower, int inLens, int inWatts, int outLens, int outWatts)
			{
				Decimal powerMod;   // modifier = (power * outputLens) / inputLens
				Decimal speedMod;   // speedMod = power / outPower
				int outPower;       // outPower = (inputWattage * modifier) / outputWattage
				int outSpeed;       // if (outPower > maxPower) (inSpeed * speedMod)

				if (laser == LaserType.CO2)
				{
					inLens = 1;
					outLens = 1;
				}

				powerMod = ((Decimal)Power * (Decimal)outLens) / (Decimal)inLens;
				outPower = Decimal.ToInt32((inWatts * powerMod) / (Decimal)outWatts);
				outSpeed = Speed;

				if (outPower > maxPower)
				{
					speedMod = (Decimal)Power / (Decimal)outPower;
					outSpeed = Decimal.ToInt32(Speed * speedMod);
					outPower = maxPower;
				}

				Speed = outSpeed;
				Power = outPower;
			}
		}

	}
}
