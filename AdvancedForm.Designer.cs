namespace LaserParamsConverter
{
	partial class AdvancedForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
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
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdvancedForm));
			this.gbGlocal = new System.Windows.Forms.GroupBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.tbPulseWidth = new System.Windows.Forms.TextBox();
			this.chkPulseWidth = new System.Windows.Forms.CheckBox();
			this.btnOk = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.gbGlocal.SuspendLayout();
			this.SuspendLayout();
			// 
			// gbGlocal
			// 
			this.gbGlocal.Controls.Add(this.label2);
			this.gbGlocal.Controls.Add(this.label1);
			this.gbGlocal.Controls.Add(this.tbPulseWidth);
			this.gbGlocal.Controls.Add(this.chkPulseWidth);
			this.gbGlocal.Location = new System.Drawing.Point(12, 12);
			this.gbGlocal.Name = "gbGlocal";
			this.gbGlocal.Size = new System.Drawing.Size(330, 93);
			this.gbGlocal.TabIndex = 0;
			this.gbGlocal.TabStop = false;
			this.gbGlocal.Text = "Fixed Conversions";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(15, 19);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(281, 15);
			this.label2.TabIndex = 0;
			this.label2.Text = "* All entries in library will be set to these fixed values";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(139, 53);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(19, 15);
			this.label1.TabIndex = 3;
			this.label1.Text = "ns";
			// 
			// tbPulseWidth
			// 
			this.tbPulseWidth.Location = new System.Drawing.Point(102, 50);
			this.tbPulseWidth.Name = "tbPulseWidth";
			this.tbPulseWidth.Size = new System.Drawing.Size(33, 23);
			this.tbPulseWidth.TabIndex = 2;
			this.tbPulseWidth.Text = "200";
			this.tbPulseWidth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPulseWidth_KeyPress);
			// 
			// chkPulseWidth
			// 
			this.chkPulseWidth.AutoSize = true;
			this.chkPulseWidth.Location = new System.Drawing.Point(6, 52);
			this.chkPulseWidth.Name = "chkPulseWidth";
			this.chkPulseWidth.Size = new System.Drawing.Size(89, 19);
			this.chkPulseWidth.TabIndex = 1;
			this.chkPulseWidth.Text = "Pulse Width";
			this.chkPulseWidth.UseVisualStyleBackColor = true;
			// 
			// btnOk
			// 
			this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnOk.Location = new System.Drawing.Point(189, 124);
			this.btnOk.Name = "btnOk";
			this.btnOk.Size = new System.Drawing.Size(75, 23);
			this.btnOk.TabIndex = 1;
			this.btnOk.Text = "OK";
			this.btnOk.UseVisualStyleBackColor = true;
			this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(270, 124);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 2;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			// 
			// AdvancedForm
			// 
			this.AcceptButton = this.btnOk;
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(357, 159);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnOk);
			this.Controls.Add(this.gbGlocal);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "AdvancedForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Advanced Options";
			this.gbGlocal.ResumeLayout(false);
			this.gbGlocal.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private GroupBox gbGlocal;
		private TextBox tbPulseWidth;
		private CheckBox chkPulseWidth;
		private Label label2;
		private Label label1;
		private Button btnOk;
		private Button btnCancel;
	}
}