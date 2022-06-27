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
			this.tlpMain.SuspendLayout();
			this.pnlInput.SuspendLayout();
			this.pnlOutput.SuspendLayout();
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
			this.label3.Location = new System.Drawing.Point(9, 15);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(45, 15);
			this.label3.TabIndex = 2;
			this.label3.Text = "Format";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(9, 74);
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
			this.cbFormat.Location = new System.Drawing.Point(60, 12);
			this.cbFormat.Name = "cbFormat";
			this.cbFormat.Size = new System.Drawing.Size(121, 23);
			this.cbFormat.TabIndex = 5;
			// 
			// tbInputFile
			// 
			this.tbInputFile.Location = new System.Drawing.Point(60, 70);
			this.tbInputFile.Name = "tbInputFile";
			this.tbInputFile.ReadOnly = true;
			this.tbInputFile.Size = new System.Drawing.Size(238, 23);
			this.tbInputFile.TabIndex = 6;
			// 
			// btnInputFile
			// 
			this.btnInputFile.BackColor = System.Drawing.SystemColors.Control;
			this.btnInputFile.ImageIndex = 0;
			this.btnInputFile.Location = new System.Drawing.Point(304, 69);
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
			this.lvInputPower.Size = new System.Drawing.Size(313, 244);
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
			this.lvOutputPower.Size = new System.Drawing.Size(310, 243);
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
			this.btnConvert.Location = new System.Drawing.Point(223, 39);
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
			this.btnSaveParams.Location = new System.Drawing.Point(515, 438);
			this.btnSaveParams.Name = "btnSaveParams";
			this.btnSaveParams.Size = new System.Drawing.Size(150, 23);
			this.btnSaveParams.TabIndex = 22;
			this.btnSaveParams.Text = "Save Parameters File";
			this.btnSaveParams.UseVisualStyleBackColor = true;
			this.btnSaveParams.Click += new System.EventHandler(this.btnSaveParams_Click);
			// 
			// dlgSaveFile
			// 
			this.dlgSaveFile.DefaultExt = "lib";
			this.dlgSaveFile.FileName = "MarkParam.lib";
			this.dlgSaveFile.Filter = "EZCAD2 Param Library (*.lib)|*.lib|EZCAD3 Param Library (*.ini)|*.ini|LightBurn C" +
    "ut Library (*.clb)|*.clb|All files (*.*)|*.*";
			this.dlgSaveFile.FilterIndex = 0;
			this.dlgSaveFile.OverwritePrompt = false;
			// 
			// cbLaser
			// 
			this.cbLaser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbLaser.Items.AddRange(new object[] {
            "CO2 Gantry",
            "Fiber Laser"});
			this.cbLaser.Location = new System.Drawing.Point(60, 41);
			this.cbLaser.Name = "cbLaser";
			this.cbLaser.Size = new System.Drawing.Size(121, 23);
			this.cbLaser.TabIndex = 24;
			this.cbLaser.SelectedIndexChanged += new System.EventHandler(this.cbLaser_SelectedIndexChanged);
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(9, 44);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(34, 15);
			this.label9.TabIndex = 23;
			this.label9.Text = "Laser";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(203, 44);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(66, 15);
			this.label10.TabIndex = 25;
			this.label10.Text = "Max Power";
			// 
			// tbMaxPower
			// 
			this.tbMaxPower.Location = new System.Drawing.Point(279, 41);
			this.tbMaxPower.Name = "tbMaxPower";
			this.tbMaxPower.Size = new System.Drawing.Size(50, 23);
			this.tbMaxPower.TabIndex = 26;
			this.tbMaxPower.Text = "100";
			this.tbMaxPower.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbInputLens_KeyPress);
			// 
			// btnConvertOne
			// 
			this.btnConvertOne.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnConvertOne.Location = new System.Drawing.Point(221, 38);
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
			this.tlpMain.Location = new System.Drawing.Point(0, 109);
			this.tlpMain.Name = "tlpMain";
			this.tlpMain.RowCount = 1;
			this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tlpMain.Size = new System.Drawing.Size(680, 320);
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
			this.pnlInput.Size = new System.Drawing.Size(334, 314);
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
			this.pnlOutput.Location = new System.Drawing.Point(343, 3);
			this.pnlOutput.Name = "pnlOutput";
			this.pnlOutput.Size = new System.Drawing.Size(334, 314);
			this.pnlOutput.TabIndex = 1;
			// 
			// llGitHub
			// 
			this.llGitHub.AutoSize = true;
			this.llGitHub.Location = new System.Drawing.Point(476, 15);
			this.llGitHub.Name = "llGitHub";
			this.llGitHub.Size = new System.Drawing.Size(188, 15);
			this.llGitHub.TabIndex = 29;
			this.llGitHub.TabStop = true;
			this.llGitHub.Text = "LaserParamsConverter GitHub Site";
			this.llGitHub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llGitHub_LinkClicked);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(680, 473);
			this.Controls.Add(this.llGitHub);
			this.Controls.Add(this.tlpMain);
			this.Controls.Add(this.tbMaxPower);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.cbLaser);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.btnSaveParams);
			this.Controls.Add(this.btnInputFile);
			this.Controls.Add(this.tbInputFile);
			this.Controls.Add(this.cbFormat);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
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
			this.ResumeLayout(false);
			this.PerformLayout();

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
	}
}