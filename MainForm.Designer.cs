namespace LaserParamsConverter
{
	partial class MainForm
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.cbFormat = new System.Windows.Forms.ComboBox();
			this.tbInputFile = new System.Windows.Forms.TextBox();
			this.btnInputFile = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.tbInLens = new System.Windows.Forms.TextBox();
			this.tbInWatts = new System.Windows.Forms.TextBox();
			this.lvInputPower = new System.Windows.Forms.ListView();
			this.chInName = new System.Windows.Forms.ColumnHeader();
			this.chInPower = new System.Windows.Forms.ColumnHeader();
			this.chInSpeed = new System.Windows.Forms.ColumnHeader();
			this.dlgInputFile = new System.Windows.Forms.OpenFileDialog();
			this.tbOutWatts = new System.Windows.Forms.TextBox();
			this.tbOutLens = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.lvOutputPower = new System.Windows.Forms.ListView();
			this.chOutName = new System.Windows.Forms.ColumnHeader();
			this.chOutPower = new System.Windows.Forms.ColumnHeader();
			this.chOutSpeed = new System.Windows.Forms.ColumnHeader();
			this.btnConvert = new System.Windows.Forms.Button();
			this.btnSaveParams = new System.Windows.Forms.Button();
			this.dlgSaveFile = new System.Windows.Forms.SaveFileDialog();
			this.cbLaser = new System.Windows.Forms.ComboBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.tbMaxPower = new System.Windows.Forms.TextBox();
			this.btnConvertOne = new System.Windows.Forms.Button();
			this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
			this.pnlInput = new System.Windows.Forms.Panel();
			this.pnlOutput = new System.Windows.Forms.Panel();
			this.llGitHub = new System.Windows.Forms.LinkLabel();
			this.cbCheckForUpdates = new System.Windows.Forms.CheckBox();
			this.tcMain = new System.Windows.Forms.TabControl();
			this.tpConvert = new System.Windows.Forms.TabPage();
			this.tpCombine = new System.Windows.Forms.TabPage();
			this.tlpCombine = new System.Windows.Forms.TableLayoutPanel();
			this.pnlLib1 = new System.Windows.Forms.Panel();
			this.btnCopyNodes1 = new System.Windows.Forms.Button();
			this.il16 = new System.Windows.Forms.ImageList(this.components);
			this.btnCombine1 = new System.Windows.Forms.Button();
			this.tbCombine1 = new System.Windows.Forms.TextBox();
			this.tvCombine1 = new System.Windows.Forms.TreeView();
			this.mnuTreeView = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.miExpandAll = new System.Windows.Forms.ToolStripMenuItem();
			this.miCollapseAll = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.miSelectAll = new System.Windows.Forms.ToolStripMenuItem();
			this.miUnselectAll = new System.Windows.Forms.ToolStripMenuItem();
			this.pnlCombine = new System.Windows.Forms.Panel();
			this.btnCombineReset = new System.Windows.Forms.Button();
			this.btnSaveCombined = new System.Windows.Forms.Button();
			this.label11 = new System.Windows.Forms.Label();
			this.cbCombineFormat = new System.Windows.Forms.ComboBox();
			this.tvCombined = new System.Windows.Forms.TreeView();
			this.pnlLib2 = new System.Windows.Forms.Panel();
			this.btnCopyNodes2 = new System.Windows.Forms.Button();
			this.btnCombine2 = new System.Windows.Forms.Button();
			this.tbCombine2 = new System.Windows.Forms.TextBox();
			this.tvCombine2 = new System.Windows.Forms.TreeView();
			this.tlpMain.SuspendLayout();
			this.pnlInput.SuspendLayout();
			this.pnlOutput.SuspendLayout();
			this.tcMain.SuspendLayout();
			this.tpConvert.SuspendLayout();
			this.tpCombine.SuspendLayout();
			this.tlpCombine.SuspendLayout();
			this.pnlLib1.SuspendLayout();
			this.mnuTreeView.SuspendLayout();
			this.pnlCombine.SuspendLayout();
			this.pnlLib2.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label1.Location = new System.Drawing.Point(6, 7);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(37, 15);
			this.label1.TabIndex = 0;
			this.label1.Text = "Input";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label2.Location = new System.Drawing.Point(11, 7);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(47, 15);
			this.label2.TabIndex = 1;
			this.label2.Text = "Output";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(4, 15);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(45, 15);
			this.label3.TabIndex = 2;
			this.label3.Text = "Format";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(4, 74);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(25, 15);
			this.label4.TabIndex = 3;
			this.label4.Text = "File";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(6, 42);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(31, 15);
			this.label5.TabIndex = 4;
			this.label5.Text = "Lens";
			// 
			// cbFormat
			// 
			this.cbFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbFormat.Items.AddRange(new object[] {
            "EZCAD2",
            "EZCAD3",
            "LightBurn"});
			this.cbFormat.Location = new System.Drawing.Point(55, 12);
			this.cbFormat.Name = "cbFormat";
			this.cbFormat.Size = new System.Drawing.Size(121, 23);
			this.cbFormat.TabIndex = 5;
			// 
			// tbInputFile
			// 
			this.tbInputFile.Location = new System.Drawing.Point(55, 70);
			this.tbInputFile.Name = "tbInputFile";
			this.tbInputFile.ReadOnly = true;
			this.tbInputFile.Size = new System.Drawing.Size(238, 23);
			this.tbInputFile.TabIndex = 6;
			// 
			// btnInputFile
			// 
			this.btnInputFile.BackColor = System.Drawing.SystemColors.Control;
			this.btnInputFile.ImageIndex = 0;
			this.btnInputFile.Location = new System.Drawing.Point(299, 69);
			this.btnInputFile.Name = "btnInputFile";
			this.btnInputFile.Size = new System.Drawing.Size(25, 25);
			this.btnInputFile.TabIndex = 7;
			this.btnInputFile.Text = "...";
			this.btnInputFile.UseVisualStyleBackColor = false;
			this.btnInputFile.Click += new System.EventHandler(this.btnInputFile_Click);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(100, 42);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(51, 15);
			this.label6.TabIndex = 8;
			this.label6.Text = "Wattage";
			// 
			// tbInLens
			// 
			this.tbInLens.Location = new System.Drawing.Point(43, 37);
			this.tbInLens.Name = "tbInLens";
			this.tbInLens.Size = new System.Drawing.Size(50, 23);
			this.tbInLens.TabIndex = 9;
			this.tbInLens.Text = "110";
			this.tbInLens.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbInputLens_KeyPress);
			// 
			// tbInWatts
			// 
			this.tbInWatts.Location = new System.Drawing.Point(157, 37);
			this.tbInWatts.Name = "tbInWatts";
			this.tbInWatts.Size = new System.Drawing.Size(50, 23);
			this.tbInWatts.TabIndex = 10;
			this.tbInWatts.Text = "30";
			this.tbInWatts.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbInputLens_KeyPress);
			// 
			// lvInputPower
			// 
			this.lvInputPower.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lvInputPower.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chInName,
            this.chInPower,
            this.chInSpeed});
			this.lvInputPower.FullRowSelect = true;
			this.lvInputPower.Location = new System.Drawing.Point(6, 68);
			this.lvInputPower.MultiSelect = false;
			this.lvInputPower.Name = "lvInputPower";
			this.lvInputPower.Size = new System.Drawing.Size(304, 274);
			this.lvInputPower.TabIndex = 11;
			this.lvInputPower.UseCompatibleStateImageBehavior = false;
			this.lvInputPower.View = System.Windows.Forms.View.Details;
			// 
			// chInName
			// 
			this.chInName.Text = "Name";
			this.chInName.Width = 200;
			// 
			// chInPower
			// 
			this.chInPower.Text = "Power";
			this.chInPower.Width = 50;
			// 
			// chInSpeed
			// 
			this.chInSpeed.Text = "Speed";
			this.chInSpeed.Width = 50;
			// 
			// dlgInputFile
			// 
			this.dlgInputFile.DefaultExt = "lib";
			this.dlgInputFile.Filter = "EZCAD2 Param Library (*.lib) |*.lib";
			this.dlgInputFile.FilterIndex = 0;
			// 
			// tbOutWatts
			// 
			this.tbOutWatts.Location = new System.Drawing.Point(162, 39);
			this.tbOutWatts.Name = "tbOutWatts";
			this.tbOutWatts.Size = new System.Drawing.Size(50, 23);
			this.tbOutWatts.TabIndex = 19;
			this.tbOutWatts.Text = "50";
			this.tbOutWatts.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbInputLens_KeyPress);
			// 
			// tbOutLens
			// 
			this.tbOutLens.Location = new System.Drawing.Point(48, 39);
			this.tbOutLens.Name = "tbOutLens";
			this.tbOutLens.Size = new System.Drawing.Size(50, 23);
			this.tbOutLens.TabIndex = 18;
			this.tbOutLens.Text = "150";
			this.tbOutLens.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbInputLens_KeyPress);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(105, 42);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(51, 15);
			this.label7.TabIndex = 17;
			this.label7.Text = "Wattage";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(11, 42);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(31, 15);
			this.label8.TabIndex = 16;
			this.label8.Text = "Lens";
			// 
			// lvOutputPower
			// 
			this.lvOutputPower.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lvOutputPower.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chOutName,
            this.chOutPower,
            this.chOutSpeed});
			this.lvOutputPower.FullRowSelect = true;
			this.lvOutputPower.Location = new System.Drawing.Point(11, 68);
			this.lvOutputPower.MultiSelect = false;
			this.lvOutputPower.Name = "lvOutputPower";
			this.lvOutputPower.Size = new System.Drawing.Size(302, 273);
			this.lvOutputPower.TabIndex = 20;
			this.lvOutputPower.UseCompatibleStateImageBehavior = false;
			this.lvOutputPower.View = System.Windows.Forms.View.Details;
			// 
			// chOutName
			// 
			this.chOutName.Text = "Name";
			this.chOutName.Width = 200;
			// 
			// chOutPower
			// 
			this.chOutPower.Text = "Power";
			this.chOutPower.Width = 50;
			// 
			// chOutSpeed
			// 
			this.chOutSpeed.Text = "Speed";
			this.chOutSpeed.Width = 50;
			// 
			// btnConvert
			// 
			this.btnConvert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnConvert.Enabled = false;
			this.btnConvert.Location = new System.Drawing.Point(215, 39);
			this.btnConvert.Name = "btnConvert";
			this.btnConvert.Size = new System.Drawing.Size(98, 23);
			this.btnConvert.TabIndex = 21;
			this.btnConvert.Text = "Convert All";
			this.btnConvert.UseVisualStyleBackColor = true;
			this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
			// 
			// btnSaveParams
			// 
			this.btnSaveParams.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSaveParams.Enabled = false;
			this.btnSaveParams.Location = new System.Drawing.Point(501, 477);
			this.btnSaveParams.Name = "btnSaveParams";
			this.btnSaveParams.Size = new System.Drawing.Size(150, 23);
			this.btnSaveParams.TabIndex = 22;
			this.btnSaveParams.Text = "Save Library File";
			this.btnSaveParams.UseVisualStyleBackColor = true;
			this.btnSaveParams.Click += new System.EventHandler(this.btnSaveParams_Click);
			// 
			// dlgSaveFile
			// 
			this.dlgSaveFile.DefaultExt = "lib";
			this.dlgSaveFile.FileName = "MarkParam.lib";
			this.dlgSaveFile.Filter = "EZCAD2 Param Library (*.lib)|*.lib|EZCAD3 Param Library (*.ini)|*.ini|LightBurn C" +
    "ut Library (*.clb)|*.clb|Excel CSV File (*.csv)|*.csv|All files (*.*)|*.*";
			this.dlgSaveFile.FilterIndex = 0;
			this.dlgSaveFile.OverwritePrompt = false;
			// 
			// cbLaser
			// 
			this.cbLaser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbLaser.Items.AddRange(new object[] {
            "CO2 Gantry",
            "Fiber Laser"});
			this.cbLaser.Location = new System.Drawing.Point(55, 41);
			this.cbLaser.Name = "cbLaser";
			this.cbLaser.Size = new System.Drawing.Size(121, 23);
			this.cbLaser.TabIndex = 24;
			this.cbLaser.SelectedIndexChanged += new System.EventHandler(this.cbLaser_SelectedIndexChanged);
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(4, 44);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(34, 15);
			this.label9.TabIndex = 23;
			this.label9.Text = "Laser";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(198, 44);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(66, 15);
			this.label10.TabIndex = 25;
			this.label10.Text = "Max Power";
			// 
			// tbMaxPower
			// 
			this.tbMaxPower.Location = new System.Drawing.Point(274, 41);
			this.tbMaxPower.Name = "tbMaxPower";
			this.tbMaxPower.Size = new System.Drawing.Size(50, 23);
			this.tbMaxPower.TabIndex = 26;
			this.tbMaxPower.Text = "100";
			this.tbMaxPower.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbInputLens_KeyPress);
			// 
			// btnConvertOne
			// 
			this.btnConvertOne.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnConvertOne.Location = new System.Drawing.Point(212, 38);
			this.btnConvertOne.Name = "btnConvertOne";
			this.btnConvertOne.Size = new System.Drawing.Size(98, 23);
			this.btnConvertOne.TabIndex = 27;
			this.btnConvertOne.Text = "Convert One";
			this.btnConvertOne.UseVisualStyleBackColor = true;
			this.btnConvertOne.Click += new System.EventHandler(this.btnConvertOne_Click);
			// 
			// tlpMain
			// 
			this.tlpMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tlpMain.ColumnCount = 2;
			this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tlpMain.Controls.Add(this.pnlInput, 0, 0);
			this.tlpMain.Controls.Add(this.pnlOutput, 1, 0);
			this.tlpMain.Location = new System.Drawing.Point(4, 116);
			this.tlpMain.Name = "tlpMain";
			this.tlpMain.RowCount = 1;
			this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tlpMain.Size = new System.Drawing.Size(663, 350);
			this.tlpMain.TabIndex = 28;
			// 
			// pnlInput
			// 
			this.pnlInput.Controls.Add(this.lvInputPower);
			this.pnlInput.Controls.Add(this.btnConvertOne);
			this.pnlInput.Controls.Add(this.label1);
			this.pnlInput.Controls.Add(this.label5);
			this.pnlInput.Controls.Add(this.label6);
			this.pnlInput.Controls.Add(this.tbInLens);
			this.pnlInput.Controls.Add(this.tbInWatts);
			this.pnlInput.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlInput.Location = new System.Drawing.Point(3, 3);
			this.pnlInput.Name = "pnlInput";
			this.pnlInput.Size = new System.Drawing.Size(325, 344);
			this.pnlInput.TabIndex = 0;
			// 
			// pnlOutput
			// 
			this.pnlOutput.Controls.Add(this.lvOutputPower);
			this.pnlOutput.Controls.Add(this.label2);
			this.pnlOutput.Controls.Add(this.label8);
			this.pnlOutput.Controls.Add(this.label7);
			this.pnlOutput.Controls.Add(this.tbOutLens);
			this.pnlOutput.Controls.Add(this.tbOutWatts);
			this.pnlOutput.Controls.Add(this.btnConvert);
			this.pnlOutput.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlOutput.Location = new System.Drawing.Point(334, 3);
			this.pnlOutput.Name = "pnlOutput";
			this.pnlOutput.Size = new System.Drawing.Size(326, 344);
			this.pnlOutput.TabIndex = 1;
			// 
			// llGitHub
			// 
			this.llGitHub.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.llGitHub.AutoSize = true;
			this.llGitHub.Location = new System.Drawing.Point(463, 12);
			this.llGitHub.Name = "llGitHub";
			this.llGitHub.Size = new System.Drawing.Size(188, 15);
			this.llGitHub.TabIndex = 29;
			this.llGitHub.TabStop = true;
			this.llGitHub.Text = "LaserParamsConverter GitHub Site";
			this.llGitHub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llGitHub_LinkClicked);
			// 
			// cbCheckForUpdates
			// 
			this.cbCheckForUpdates.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cbCheckForUpdates.AutoSize = true;
			this.cbCheckForUpdates.Checked = true;
			this.cbCheckForUpdates.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cbCheckForUpdates.Location = new System.Drawing.Point(471, 40);
			this.cbCheckForUpdates.Name = "cbCheckForUpdates";
			this.cbCheckForUpdates.Size = new System.Drawing.Size(180, 19);
			this.cbCheckForUpdates.TabIndex = 30;
			this.cbCheckForUpdates.Text = "Check for updates on Startup";
			this.cbCheckForUpdates.UseVisualStyleBackColor = true;
			this.cbCheckForUpdates.CheckedChanged += new System.EventHandler(this.cbCheckForUpdates_CheckedChanged);
			// 
			// tcMain
			// 
			this.tcMain.Controls.Add(this.tpConvert);
			this.tcMain.Controls.Add(this.tpCombine);
			this.tcMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tcMain.Location = new System.Drawing.Point(0, 0);
			this.tcMain.Name = "tcMain";
			this.tcMain.SelectedIndex = 0;
			this.tcMain.Size = new System.Drawing.Size(680, 540);
			this.tcMain.TabIndex = 31;
			// 
			// tpConvert
			// 
			this.tpConvert.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.tpConvert.Controls.Add(this.tlpMain);
			this.tpConvert.Controls.Add(this.cbCheckForUpdates);
			this.tpConvert.Controls.Add(this.btnSaveParams);
			this.tpConvert.Controls.Add(this.llGitHub);
			this.tpConvert.Controls.Add(this.cbFormat);
			this.tpConvert.Controls.Add(this.tbMaxPower);
			this.tpConvert.Controls.Add(this.label3);
			this.tpConvert.Controls.Add(this.label10);
			this.tpConvert.Controls.Add(this.label4);
			this.tpConvert.Controls.Add(this.cbLaser);
			this.tpConvert.Controls.Add(this.tbInputFile);
			this.tpConvert.Controls.Add(this.label9);
			this.tpConvert.Controls.Add(this.btnInputFile);
			this.tpConvert.Location = new System.Drawing.Point(4, 24);
			this.tpConvert.Name = "tpConvert";
			this.tpConvert.Padding = new System.Windows.Forms.Padding(3);
			this.tpConvert.Size = new System.Drawing.Size(672, 512);
			this.tpConvert.TabIndex = 0;
			this.tpConvert.Text = "Convert";
			// 
			// tpCombine
			// 
			this.tpCombine.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.tpCombine.Controls.Add(this.tlpCombine);
			this.tpCombine.Location = new System.Drawing.Point(4, 24);
			this.tpCombine.Name = "tpCombine";
			this.tpCombine.Padding = new System.Windows.Forms.Padding(3);
			this.tpCombine.Size = new System.Drawing.Size(672, 512);
			this.tpCombine.TabIndex = 1;
			this.tpCombine.Text = "Combine";
			// 
			// tlpCombine
			// 
			this.tlpCombine.ColumnCount = 3;
			this.tlpCombine.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tlpCombine.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tlpCombine.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tlpCombine.Controls.Add(this.pnlLib1, 0, 0);
			this.tlpCombine.Controls.Add(this.pnlCombine, 1, 0);
			this.tlpCombine.Controls.Add(this.pnlLib2, 2, 0);
			this.tlpCombine.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tlpCombine.Location = new System.Drawing.Point(3, 3);
			this.tlpCombine.Name = "tlpCombine";
			this.tlpCombine.RowCount = 1;
			this.tlpCombine.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tlpCombine.Size = new System.Drawing.Size(666, 506);
			this.tlpCombine.TabIndex = 0;
			// 
			// pnlLib1
			// 
			this.pnlLib1.Controls.Add(this.btnCopyNodes1);
			this.pnlLib1.Controls.Add(this.btnCombine1);
			this.pnlLib1.Controls.Add(this.tbCombine1);
			this.pnlLib1.Controls.Add(this.tvCombine1);
			this.pnlLib1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlLib1.Location = new System.Drawing.Point(3, 3);
			this.pnlLib1.Name = "pnlLib1";
			this.pnlLib1.Size = new System.Drawing.Size(216, 500);
			this.pnlLib1.TabIndex = 0;
			// 
			// btnCopyNodes1
			// 
			this.btnCopyNodes1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCopyNodes1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnCopyNodes1.ImageIndex = 1;
			this.btnCopyNodes1.ImageList = this.il16;
			this.btnCopyNodes1.Location = new System.Drawing.Point(92, 31);
			this.btnCopyNodes1.Name = "btnCopyNodes1";
			this.btnCopyNodes1.Size = new System.Drawing.Size(124, 23);
			this.btnCopyNodes1.TabIndex = 28;
			this.btnCopyNodes1.Text = "Copy Selected";
			this.btnCopyNodes1.UseVisualStyleBackColor = true;
			this.btnCopyNodes1.Click += new System.EventHandler(this.btnCopyNodes1_Click);
			// 
			// il16
			// 
			this.il16.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
			this.il16.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("il16.ImageStream")));
			this.il16.TransparentColor = System.Drawing.Color.Transparent;
			this.il16.Images.SetKeyName(0, "LeftArrow.png");
			this.il16.Images.SetKeyName(1, "RightArrow.png");
			// 
			// btnCombine1
			// 
			this.btnCombine1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCombine1.BackColor = System.Drawing.SystemColors.Control;
			this.btnCombine1.ImageIndex = 0;
			this.btnCombine1.Location = new System.Drawing.Point(191, 0);
			this.btnCombine1.Name = "btnCombine1";
			this.btnCombine1.Size = new System.Drawing.Size(25, 25);
			this.btnCombine1.TabIndex = 10;
			this.btnCombine1.Text = "...";
			this.btnCombine1.UseVisualStyleBackColor = false;
			this.btnCombine1.Click += new System.EventHandler(this.btnCombine1_Click);
			// 
			// tbCombine1
			// 
			this.tbCombine1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbCombine1.Location = new System.Drawing.Point(0, 0);
			this.tbCombine1.Name = "tbCombine1";
			this.tbCombine1.ReadOnly = true;
			this.tbCombine1.Size = new System.Drawing.Size(185, 23);
			this.tbCombine1.TabIndex = 9;
			this.tbCombine1.Text = "Select library file 1";
			// 
			// tvCombine1
			// 
			this.tvCombine1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tvCombine1.CheckBoxes = true;
			this.tvCombine1.ContextMenuStrip = this.mnuTreeView;
			this.tvCombine1.Location = new System.Drawing.Point(0, 60);
			this.tvCombine1.Name = "tvCombine1";
			this.tvCombine1.Size = new System.Drawing.Size(216, 397);
			this.tvCombine1.TabIndex = 0;
			this.tvCombine1.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.tvCombine1_AfterCheck);
			// 
			// mnuTreeView
			// 
			this.mnuTreeView.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miExpandAll,
            this.miCollapseAll,
            this.toolStripSeparator1,
            this.miSelectAll,
            this.miUnselectAll});
			this.mnuTreeView.Name = "mnuTreeView";
			this.mnuTreeView.Size = new System.Drawing.Size(137, 98);
			// 
			// miExpandAll
			// 
			this.miExpandAll.Name = "miExpandAll";
			this.miExpandAll.ShortcutKeyDisplayString = "";
			this.miExpandAll.Size = new System.Drawing.Size(136, 22);
			this.miExpandAll.Text = "Expand All";
			this.miExpandAll.Click += new System.EventHandler(this.miExpandAll_Click);
			// 
			// miCollapseAll
			// 
			this.miCollapseAll.Name = "miCollapseAll";
			this.miCollapseAll.ShortcutKeyDisplayString = "";
			this.miCollapseAll.Size = new System.Drawing.Size(136, 22);
			this.miCollapseAll.Text = "Collapse All";
			this.miCollapseAll.Click += new System.EventHandler(this.miCollapseAll_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(133, 6);
			// 
			// miSelectAll
			// 
			this.miSelectAll.Name = "miSelectAll";
			this.miSelectAll.ShortcutKeyDisplayString = "";
			this.miSelectAll.Size = new System.Drawing.Size(136, 22);
			this.miSelectAll.Text = "Select All";
			this.miSelectAll.Click += new System.EventHandler(this.miSelectAll_Click);
			// 
			// miUnselectAll
			// 
			this.miUnselectAll.Name = "miUnselectAll";
			this.miUnselectAll.ShortcutKeyDisplayString = "";
			this.miUnselectAll.Size = new System.Drawing.Size(136, 22);
			this.miUnselectAll.Text = "Unselect All";
			this.miUnselectAll.Click += new System.EventHandler(this.miUnselectAll_Click);
			// 
			// pnlCombine
			// 
			this.pnlCombine.Controls.Add(this.btnCombineReset);
			this.pnlCombine.Controls.Add(this.btnSaveCombined);
			this.pnlCombine.Controls.Add(this.label11);
			this.pnlCombine.Controls.Add(this.cbCombineFormat);
			this.pnlCombine.Controls.Add(this.tvCombined);
			this.pnlCombine.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlCombine.Location = new System.Drawing.Point(225, 3);
			this.pnlCombine.Name = "pnlCombine";
			this.pnlCombine.Size = new System.Drawing.Size(216, 500);
			this.pnlCombine.TabIndex = 1;
			// 
			// btnCombineReset
			// 
			this.btnCombineReset.Location = new System.Drawing.Point(54, 28);
			this.btnCombineReset.Name = "btnCombineReset";
			this.btnCombineReset.Size = new System.Drawing.Size(121, 23);
			this.btnCombineReset.TabIndex = 30;
			this.btnCombineReset.Text = "Reset";
			this.btnCombineReset.UseVisualStyleBackColor = true;
			this.btnCombineReset.Click += new System.EventHandler(this.btnCombineReset_Click);
			// 
			// btnSaveCombined
			// 
			this.btnSaveCombined.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSaveCombined.Enabled = false;
			this.btnSaveCombined.Location = new System.Drawing.Point(66, 474);
			this.btnSaveCombined.Name = "btnSaveCombined";
			this.btnSaveCombined.Size = new System.Drawing.Size(150, 23);
			this.btnSaveCombined.TabIndex = 29;
			this.btnSaveCombined.Text = "Save Library File";
			this.btnSaveCombined.UseVisualStyleBackColor = true;
			this.btnSaveCombined.Click += new System.EventHandler(this.btnSaveParams_Click);
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(3, 5);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(45, 15);
			this.label11.TabIndex = 6;
			this.label11.Text = "Format";
			// 
			// cbCombineFormat
			// 
			this.cbCombineFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbCombineFormat.Items.AddRange(new object[] {
            "EZCAD2",
            "EZCAD3",
            "LightBurn"});
			this.cbCombineFormat.Location = new System.Drawing.Point(54, 0);
			this.cbCombineFormat.Name = "cbCombineFormat";
			this.cbCombineFormat.Size = new System.Drawing.Size(121, 23);
			this.cbCombineFormat.TabIndex = 7;
			// 
			// tvCombined
			// 
			this.tvCombined.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tvCombined.ContextMenuStrip = this.mnuTreeView;
			this.tvCombined.Location = new System.Drawing.Point(0, 60);
			this.tvCombined.Name = "tvCombined";
			this.tvCombined.Size = new System.Drawing.Size(216, 397);
			this.tvCombined.TabIndex = 0;
			this.tvCombined.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.tvCombine1_AfterCheck);
			// 
			// pnlLib2
			// 
			this.pnlLib2.Controls.Add(this.btnCopyNodes2);
			this.pnlLib2.Controls.Add(this.btnCombine2);
			this.pnlLib2.Controls.Add(this.tbCombine2);
			this.pnlLib2.Controls.Add(this.tvCombine2);
			this.pnlLib2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlLib2.Location = new System.Drawing.Point(447, 3);
			this.pnlLib2.Name = "pnlLib2";
			this.pnlLib2.Size = new System.Drawing.Size(216, 500);
			this.pnlLib2.TabIndex = 2;
			// 
			// btnCopyNodes2
			// 
			this.btnCopyNodes2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCopyNodes2.ImageIndex = 0;
			this.btnCopyNodes2.ImageList = this.il16;
			this.btnCopyNodes2.Location = new System.Drawing.Point(3, 29);
			this.btnCopyNodes2.Name = "btnCopyNodes2";
			this.btnCopyNodes2.Size = new System.Drawing.Size(124, 23);
			this.btnCopyNodes2.TabIndex = 29;
			this.btnCopyNodes2.Text = "Copy Selected";
			this.btnCopyNodes2.UseVisualStyleBackColor = true;
			this.btnCopyNodes2.Click += new System.EventHandler(this.btnCopyNodes1_Click);
			// 
			// btnCombine2
			// 
			this.btnCombine2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCombine2.BackColor = System.Drawing.SystemColors.Control;
			this.btnCombine2.ImageIndex = 0;
			this.btnCombine2.Location = new System.Drawing.Point(191, 0);
			this.btnCombine2.Name = "btnCombine2";
			this.btnCombine2.Size = new System.Drawing.Size(25, 25);
			this.btnCombine2.TabIndex = 13;
			this.btnCombine2.Text = "...";
			this.btnCombine2.UseVisualStyleBackColor = false;
			this.btnCombine2.Click += new System.EventHandler(this.btnCombine1_Click);
			// 
			// tbCombine2
			// 
			this.tbCombine2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbCombine2.Location = new System.Drawing.Point(0, 0);
			this.tbCombine2.Name = "tbCombine2";
			this.tbCombine2.ReadOnly = true;
			this.tbCombine2.Size = new System.Drawing.Size(185, 23);
			this.tbCombine2.TabIndex = 12;
			this.tbCombine2.Text = "Select library file 2";
			// 
			// tvCombine2
			// 
			this.tvCombine2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tvCombine2.CheckBoxes = true;
			this.tvCombine2.ContextMenuStrip = this.mnuTreeView;
			this.tvCombine2.Location = new System.Drawing.Point(0, 60);
			this.tvCombine2.Name = "tvCombine2";
			this.tvCombine2.Size = new System.Drawing.Size(216, 397);
			this.tvCombine2.TabIndex = 0;
			this.tvCombine2.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.tvCombine1_AfterCheck);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(680, 540);
			this.Controls.Add(this.tcMain);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MinimumSize = new System.Drawing.Size(696, 512);
			this.Name = "MainForm";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Laser Parameters Converter";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.tlpMain.ResumeLayout(false);
			this.pnlInput.ResumeLayout(false);
			this.pnlInput.PerformLayout();
			this.pnlOutput.ResumeLayout(false);
			this.pnlOutput.PerformLayout();
			this.tcMain.ResumeLayout(false);
			this.tpConvert.ResumeLayout(false);
			this.tpConvert.PerformLayout();
			this.tpCombine.ResumeLayout(false);
			this.tlpCombine.ResumeLayout(false);
			this.pnlLib1.ResumeLayout(false);
			this.pnlLib1.PerformLayout();
			this.mnuTreeView.ResumeLayout(false);
			this.pnlCombine.ResumeLayout(false);
			this.pnlCombine.PerformLayout();
			this.pnlLib2.ResumeLayout(false);
			this.pnlLib2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private Label label1;
		private Label label2;
		private Label label3;
		private Label label4;
		private Label label5;
		private ComboBox cbFormat;
		private TextBox tbInputFile;
		private Button btnInputFile;
		private Label label6;
		private TextBox tbInLens;
		private TextBox tbInWatts;
		private ListView lvInputPower;
		private ColumnHeader chInName;
		private ColumnHeader chInPower;
		private OpenFileDialog dlgInputFile;
		private TextBox tbOutWatts;
		private TextBox tbOutLens;
		private Label label7;
		private Label label8;
		private ListView lvOutputPower;
		private ColumnHeader chOutName;
		private ColumnHeader chOutPower;
		private Button btnConvert;
		private Button btnSaveParams;
		private SaveFileDialog dlgSaveFile;
		private ColumnHeader chInSpeed;
		private ColumnHeader chOutSpeed;
		private ComboBox cbLaser;
		private Label label9;
		private Label label10;
		private TextBox tbMaxPower;
		private Button btnConvertOne;
		private TableLayoutPanel tlpMain;
		private Panel pnlInput;
		private Panel pnlOutput;
		private LinkLabel llGitHub;
		private CheckBox cbCheckForUpdates;
		private TabControl tcMain;
		private TabPage tpConvert;
		private TabPage tpCombine;
		private TableLayoutPanel tlpCombine;
		private Panel pnlLib1;
		private Panel pnlCombine;
		private Panel pnlLib2;
		private TreeView tvCombine1;
		private TreeView tvCombined;
		private TreeView tvCombine2;
		private Button btnCombine1;
		private TextBox tbCombine1;
		private Button btnCombine2;
		private TextBox tbCombine2;
		private ComboBox cbCombineFormat;
		private Label label11;
		private Button btnCopyNodes1;
		private Button btnCopyNodes2;
		private Button btnSaveCombined;
		private ContextMenuStrip mnuTreeView;
		private ToolStripMenuItem miExpandAll;
		private ToolStripMenuItem miCollapseAll;
		private ToolStripSeparator toolStripSeparator1;
		private ToolStripMenuItem miSelectAll;
		private ToolStripMenuItem miUnselectAll;
		private Button btnCombineReset;
		private ImageList il16;
	}
}