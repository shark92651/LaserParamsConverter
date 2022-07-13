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

using System.IO;
using System.Globalization;
using System.Reflection;
using System.Web;
using System.Xml;
using System.Diagnostics;


namespace LaserParamsConverter
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			string version = Assembly.GetEntryAssembly().GetName().Version.ToString(3);
			this.Text = string.Format("Laser Parameters Converter {0}", version);

			LoadSettings();
			CheckForUpdates();
		}

		private LibraryType Format
		{
			get { return (LibraryType)cbFormat.SelectedIndex; }
			set { cbFormat.SelectedIndex = (int)value; }
		}

		private LibraryType CombineFormat
		{
			get { return (LibraryType)cbCombineFormat.SelectedIndex; }
			set { cbCombineFormat.SelectedIndex = (int)value; }
		}

		private LaserType Laser
		{
			get { return (LaserType)cbLaser.SelectedIndex; }
			set { cbLaser.SelectedIndex = (int)value; }
		}

		private int MaxPower
		{
			get { return int.Parse(tbMaxPower.Text, NumberFormatInfo.InvariantInfo); }
			set { tbMaxPower.Text = value.ToString(); }
		}

		private int InLens
		{
			get
			{
				if (tbInLens.Text == "NA")
					return 1;
				else
					return int.Parse(tbInLens.Text, NumberFormatInfo.InvariantInfo);
			}

			set
			{
				if (value == 1)
				{
					tbInLens.Text = "NA";
					tbInLens.Enabled = false;
				}
				else
				{
					tbInLens.Text = value.ToString();
					tbInLens.Enabled = true;
				}
			}
		}

		private int InWatts
		{
			get { return int.Parse(tbInWatts.Text, NumberFormatInfo.InvariantInfo); }
			set { tbInWatts.Text = value.ToString(); }
		}

		private int OutLens
		{
			get
			{
				if (tbOutLens.Text == "NA")
					return 1;
				else
					return int.Parse(tbOutLens.Text, NumberFormatInfo.InvariantInfo);
			}

			set
			{
				if (value == 1)
				{
					tbOutLens.Text = "NA";
					tbOutLens.Enabled = false;
				}
				else
				{
					tbOutLens.Text = value.ToString();
					tbOutLens.Enabled = true;
				}
			}
		}

		private int OutWatts
		{
			get { return int.Parse(tbOutWatts.Text, NumberFormatInfo.InvariantInfo); }
			set { tbOutWatts.Text = value.ToString(); }
		}

		const int maxPowerDefault = 100;

		int prevLaserIndex = -1;
		private bool initializing = false;

		private void LoadSettings()
		{
			initializing = true;
			try
			{
				cbCheckForUpdates.Checked = Settings.ChkForUpdates;
				cbFormat.SelectedIndex = Settings.IdxFormat;
				cbCombineFormat.SelectedIndex = Settings.IdxFormat;

				prevLaserIndex = Settings.IdxLaser;
				cbLaser.SelectedIndex = Settings.IdxLaser;
				LoadLaserSettings((LaserType)Settings.IdxLaser);
			}
			finally
			{
				initializing = false;
			}
		}

		private void LoadLaserSettings(LaserType laser)
		{
			switch (laser)
			{
				case LaserType.CO2:
					MaxPower = Settings.MaxPowerCO2;
					InLens = 1;
					OutLens = 1;
					InWatts = Settings.InWattsCO2;
					OutWatts = Settings.OutWattsCO2;
					break;
				case LaserType.Fiber:
					MaxPower = Settings.MaxPowerFiber;
					InLens = Settings.InLensFiber;
					OutLens = Settings.OutLensFiber;
					InWatts = Settings.InWattsFiber;
					OutWatts = Settings.OutWattsFiber;
					break;
				default:
					break;
			}
		}

		private void SaveLaserSettings(LaserType laser)
		{
			switch (laser)
			{
				case LaserType.CO2:
					Settings.MaxPowerCO2 = MaxPower;
					Settings.InWattsCO2 = InWatts;
					Settings.OutWattsCO2 = OutWatts;
					break;
				case LaserType.Fiber:
					Settings.MaxPowerFiber = MaxPower;
					Settings.InLensFiber = InLens;
					Settings.OutLensFiber = OutLens;
					Settings.InWattsFiber = InWatts;
					Settings.OutWattsFiber = OutWatts;
					break;
				default:
					break;
			}
		}

		private void CheckForUpdates()
		{
			if (Settings.ChkForUpdates)
				Updates.CheckForUpdate();
		}

		private void cbCheckForUpdates_CheckedChanged(object sender, EventArgs e)
		{
			if (!initializing)
			{
				Settings.ChkForUpdates = cbCheckForUpdates.Checked;
				CheckForUpdates();
			}
		}


		private void tbInputLens_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
			{
				e.Handled = true;
			}
		}

		LaserLibrary inputLib;

		private void btnInputFile_Click(object sender, EventArgs e)
		{
			SetInputFileFilter((LibraryType)cbFormat.SelectedIndex);

			if (dlgInputFile.ShowDialog() == DialogResult.OK)
			{
				tbInputFile.Text = dlgInputFile.FileName;

				inputLib = new LaserLibrary(Format, Laser, MaxPower, InLens, InWatts);
				inputLib.LoadLibrary(dlgInputFile.FileName);

				DisplayLibrary(inputLib, lvInputPower);

				btnConvert.Enabled = true;
			}
		}

		private void DisplayLibrary(LaserLibrary lib, ListView lv)
		{
			string pName;
			string eName;
			int power;
			int speed;

			lv.Items.Clear();

			string cutSettingPath;
			string powerPath;
			string speedPath;
			NumberStyles numStyles;

			switch (lib.Format)
			{
				case LibraryType.EZCAD2:
				case LibraryType.EZCAD3:
					cutSettingPath = "//EZCADLibrary/Material/Entry/CutSetting";
					powerPath = ".//POWERRATIO";
					speedPath = ".//MARKSPEED";
					numStyles = NumberStyles.AllowExponent | NumberStyles.AllowDecimalPoint;
					break;
				default: // LibraryType.LightBurn
					cutSettingPath = "//LightBurnLibrary/Material/Entry/CutSetting";
					powerPath = ".//maxPower";
					speedPath = ".//speed";
					numStyles = NumberStyles.Integer;
					break;
			}

			foreach (XmlNode node in lib.XmlDoc.SelectNodes(cutSettingPath))
			{
				XmlNode powerNode = node.SelectSingleNode(powerPath);
				XmlNode speedNode = node.SelectSingleNode(speedPath);

				if (powerNode == null || speedNode == null)
					continue;

				power = LaserHelper.ParseToInt(powerNode.Attributes[0].Value, numStyles, NumberFormatInfo.InvariantInfo);
				speed = LaserHelper.ParseToInt(speedNode.Attributes[0].Value, numStyles, NumberFormatInfo.InvariantInfo);

				pName = HttpUtility.HtmlDecode(node.ParentNode.ParentNode.Attributes["name"].Value);

				if (lib.Format == LibraryType.LightBurn)
					eName = HttpUtility.HtmlDecode(node.ParentNode.Attributes["Desc"].Value);
				else
					eName = "";

				lv.Items.Add(new ListViewItem(new string[] { string.Format("{0} {1}", pName, eName), power.ToString(), speed.ToString() }));
			}
		}

		LaserLibrary outputLib;

		private void btnConvert_Click(object sender, EventArgs e)
		{
			SaveLaserSettings(Laser);

			inputLib.Lens = InLens;
			inputLib.Wattage = InWatts;

			outputLib = inputLib.Convert(Format, Laser, MaxPower, OutLens, OutWatts);
			DisplayLibrary(outputLib, lvOutputPower);

			btnSaveParams.Enabled = true;
		}

		private void btnSaveParams_Click(object sender, EventArgs e)
		{
			if (sender == btnSaveParams)
				SaveLibrary(outputLib);
			else
				SaveLibrary(combinedLib);
		}

		private void SaveLibrary(LaserLibrary lib)
		{
			if (lib == null)
				return;

			dlgSaveFile.FilterIndex = (int)lib.Format + 1;

			switch (lib.Format)
			{
				case LibraryType.EZCAD2:
					dlgSaveFile.DefaultExt = "lib";
					dlgSaveFile.FileName = "MarkParam.lib";
					break;
				case LibraryType.EZCAD3:
					dlgSaveFile.DefaultExt = "ini";
					dlgSaveFile.FileName = "MarkParamLib.ini";
					break;
				case LibraryType.LightBurn:
					dlgSaveFile.DefaultExt = "clb";
					dlgSaveFile.FileName = "library.clb";
					break;
				default:
					break;
			}

			if (dlgSaveFile.ShowDialog() == DialogResult.OK)
			{
				LibraryType saveType = (LibraryType)dlgSaveFile.FilterIndex - 1;

				if (lib.Format == LibraryType.LightBurn && saveType < LibraryType.LightBurn)
				{
					MessageBox.Show("Converting from LightBurn to EZCAD formats is not supported", "Information", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					return;
				}

				bool save = true;
				if (File.Exists(dlgSaveFile.FileName))
				{
					save = (MessageBox.Show("Are you sure you want to overwrite the existing file?",
						"Overwrite Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Hand) == DialogResult.OK);
				}

				if (save)
				{
					bool convertToLightBurn = (lib.Format < LibraryType.LightBurn && saveType == LibraryType.LightBurn);
					bool convertEZFormat = (lib.Format == LibraryType.EZCAD2 && saveType == LibraryType.EZCAD3) ||
																 (lib.Format == LibraryType.EZCAD3 && saveType == LibraryType.EZCAD2);
					bool convertToCSV = (saveType == LibraryType.CSV);

					if (convertToLightBurn)
						lib.SaveAsLightBurn(dlgSaveFile.FileName);
					else if (convertEZFormat)
						lib.SaveEZCAD(saveType, dlgSaveFile.FileName);
					else if (convertToCSV)
						lib.SaveAsCSV(dlgSaveFile.FileName);
					else
						lib.Save(dlgSaveFile.FileName);

					MessageBox.Show("Library File Saved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}
		}

		private void SetInputFileFilter(LibraryType format)
		{
			FileDialog dlg = dlgInputFile;

			switch (format)
			{
				case LibraryType.EZCAD2:
					dlg.Filter = "EZCAD2 Param Library (*.lib)|*.lib|All Files (*.*)|*.*";
					dlg.DefaultExt = "lib";
					dlg.FileName = "MarkParam.lib";
					break;
				case LibraryType.EZCAD3:
					dlg.Filter = "EZCAD3 Param Library (*.ini)|*.ini|All Files (*.*)|*.*";
					dlg.DefaultExt = "ini";
					dlg.FileName = "MarkParamlib.ini";
					break;
				case LibraryType.LightBurn:
					dlg.Filter = "LightBurn Cut Library (*.clb)|*.clb|All Files (*.*)|*.*";
					dlg.DefaultExt = "clb";
					dlg.FileName = "library.clb";
					break;
				default:
					break;
			}
		}

		private void cbLaser_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (initializing)
				return;

			SaveLaserSettings((LaserType)prevLaserIndex);
			LoadLaserSettings((LaserType)cbLaser.SelectedIndex);

			prevLaserIndex = cbLaser.SelectedIndex;
		}

		private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			Settings.IdxFormat = cbFormat.SelectedIndex;
			Settings.IdxLaser = cbLaser.SelectedIndex;
			SaveLaserSettings((LaserType)cbLaser.SelectedIndex);
			Settings.Save();
		}

		private void btnConvertOne_Click(object sender, EventArgs e)
		{
			int inPower = 0;
			int inSpeed = 0;

			if (lvInputPower.SelectedItems.Count > 0)
			{
				inPower = LaserHelper.ParseToInt(lvInputPower.SelectedItems[0].SubItems[1].Text, NumberFormatInfo.InvariantInfo);
				inSpeed = LaserHelper.ParseToInt(lvInputPower.SelectedItems[0].SubItems[2].Text, NumberFormatInfo.InvariantInfo);
			}

			ConvertOneForm dlg = new ConvertOneForm(Laser, MaxPower, InLens, InWatts, inPower, inSpeed, OutLens, OutWatts);
			dlg.ShowDialog();
		}

		private void llGitHub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			ProcessStartInfo sInfo = new ProcessStartInfo("https://github.com/shark92651/LaserParamsConverter");
			sInfo.UseShellExecute = true;
			Process.Start(sInfo);
		}


		LaserLibrary combineLib1;
		LaserLibrary combineLib2;
		LaserLibrary combinedLib;

		private void btnCombine1_Click(object sender, EventArgs e)
		{
			SetInputFileFilter((LibraryType)cbCombineFormat.SelectedIndex);

			if (dlgInputFile.ShowDialog() == DialogResult.OK)
			{
				cbCombineFormat.Enabled = false;
				if (sender == btnCombine1)
				{
					tbCombine1.Text = dlgInputFile.FileName;
					combineLib1 = new LaserLibrary(CombineFormat);
					combineLib1.LoadLibrary(dlgInputFile.FileName);
					DisplayLibrary(combineLib1, tvCombine1);
				}
				else
				{
					tbCombine2.Text = dlgInputFile.FileName;
					combineLib2 = new LaserLibrary(CombineFormat);
					combineLib2.LoadLibrary(dlgInputFile.FileName);
					DisplayLibrary(combineLib2, tvCombine2);
				}
			}
		}


		private void DisplayLibrary(LaserLibrary lib, TreeView tv)
		{
			string mName;
			string desc;
			string title;

			tv.BeginUpdate();
			tv.Nodes.Clear();

			foreach (XmlNode node in lib.XmlDoc.SelectNodes(lib.MaterialPath))
			{
				mName = HttpUtility.HtmlDecode(node.Attributes["name"].Value);

				TreeNode matTreeNode = tv.Nodes.Add(mName);
				matTreeNode.Tag = node;

				// Force EZ2 "LASERMODE" node to be checked
				if (lib.Format == LibraryType.EZCAD2 && mName == "LASERMODE")
					matTreeNode.Checked = true;

				if (lib.Format == LibraryType.LightBurn)
				{
					foreach (XmlNode eNode in node.ChildNodes)
					{
						desc = HttpUtility.HtmlDecode(lib.GetAttributeValue(eNode, "Desc", ""));
						title = HttpUtility.HtmlDecode(lib.GetAttributeValue(eNode, "NoThickTitle", lib.GetAttributeValue(eNode, "Thickness", "")));
						if (title == "-1.0000")
							title = "(no thickness)";

						TreeNode entTreeNode = matTreeNode.Nodes.Add(String.Format("{0} {1}", title, desc));
						entTreeNode.Tag = eNode;
					}
				}

				tv.ExpandAll();
				if (tv.Nodes.Count > 0)
					tv.Nodes[0].EnsureVisible();

				tv.EndUpdate();
			}
		}

		private void btnCopyNodes1_Click(object sender, EventArgs e)
		{
			if (sender == btnCopyNodes1)
				CopyCheckedNodes(tvCombine1);
			else
				CopyCheckedNodes(tvCombine2);
		}

		private void CopyCheckedNodes(TreeView tv)
		{
			if (combinedLib == null)
				combinedLib = new LaserLibrary(CombineFormat);

			foreach (TreeNode matTreeNode in tv.Nodes)
			{
				XmlNode parentNode;

				if (matTreeNode.Checked || CheckedChildNodeCount(matTreeNode) > 0)
				{
					// Find the parent Material node
					parentNode = combinedLib.XmlDoc.SelectSingleNode(string.Format("{0}[@name='{1}']", combinedLib.MaterialPath, matTreeNode.Text));

					if (parentNode == null)
					{
						XmlNode rootNode = combinedLib.XmlDoc.SelectSingleNode(combinedLib.RootPath);

						// Need deep copy for EZ2 or EZ3 to get all settings
						bool deep = (CombineFormat != LibraryType.LightBurn);

						parentNode = combinedLib.XmlDoc.ImportNode((matTreeNode.Tag as XmlNode), deep);
						rootNode.AppendChild(parentNode);
					}

					foreach (TreeNode entTreeNode in matTreeNode.Nodes)
					{
						if (entTreeNode.Checked)
						{
							XmlNode childNode = combinedLib.XmlDoc.ImportNode((entTreeNode.Tag as XmlNode), true);
							parentNode.AppendChild(childNode);
						}
					}
				}

			}
						
			DisplayLibrary(combinedLib, tvCombined);
			btnSaveCombined.Enabled = tvCombined.Nodes.Count > 0;
		}


		private int CheckedChildNodeCount(TreeNode node)
		{
			int cnt = 0;
			foreach (TreeNode n in node.Nodes)
			{
				if (n.Checked)
					cnt++;
			}
			return cnt;
		}


		private TreeView GetContextTreeView(object sender)
		{
			ToolStripItem menuItem = sender as ToolStripItem;
			if (menuItem != null)
			{
				ContextMenuStrip owner = menuItem.Owner as ContextMenuStrip;
				if (owner != null)
				{
					return (TreeView)owner.SourceControl;
				}
			}
			return null;
		}

		private void miExpandAll_Click(object sender, EventArgs e)
		{
			TreeView tv = GetContextTreeView(sender);
			if (tv != null)
				tv.ExpandAll();
		}

		private void miCollapseAll_Click(object sender, EventArgs e)
		{
			TreeView tv = GetContextTreeView(sender);
			if (tv != null)
				tv.CollapseAll();

		}

		bool checkingAll = false;

		private void miSelectAll_Click(object sender, EventArgs e)
		{
			checkingAll = true;
			try
			{
				TreeView tv = GetContextTreeView(sender);
				if (tv != null)
					CheckAllTree(tv, true);
			}
			finally
			{
				checkingAll = false;
			}
		}

		private void miUnselectAll_Click(object sender, EventArgs e)
		{
			checkingAll = true;
			try
			{
				TreeView tv = GetContextTreeView(sender);
			if (tv != null)
				CheckAllTree(tv, false);
			}
			finally
			{
				checkingAll = false;
			}
		}

		private void CheckAllTree(TreeView tv, bool v)
		{
			foreach (TreeNode node in tv.Nodes)
			{
				node.Checked = v;
				CheckAllTreeNodes(node, v);
			}
		}

		private void CheckAllTreeNodes(TreeNode node, bool v)
		{
			foreach (TreeNode n in node.Nodes)
			{
				n.Checked = v;
			}
		}

		private void tvCombine1_AfterCheck(object sender, TreeViewEventArgs e)
		{
			if (!checkingAll)
				CheckAllTreeNodes(e.Node, e.Node.Checked);

			if (CombineFormat == LibraryType.EZCAD2 && e.Node.Text == "LASERMODE" && e.Node.Checked == false)
				e.Node.Checked = true;

		}

		private void btnCombineReset_Click(object sender, EventArgs e)
		{
			Reset();
		}

		private void Reset()
		{
			combineLib1 = null;
			combineLib2 = null;
			combinedLib = null;
			tvCombine1.Nodes.Clear();
			tvCombine2.Nodes.Clear();
			tvCombined.Nodes.Clear();
			tbCombine1.Text = "Select library file 1";
			tbCombine2.Text = "Select library file 2";
			cbCombineFormat.Enabled = true;
			btnSaveCombined.Enabled = false;
		}
	}
}