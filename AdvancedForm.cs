using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaserParamsConverter
{
	public partial class AdvancedForm : Form
	{
		public AdvancedForm()
		{
			InitializeComponent();
			Init();
		}

		private void Init()
		{
			chkPulseWidth.Checked = Settings.advSetPulseWidth;
			tbPulseWidth.Text = Settings.advPulseWidth.ToString();
		}

		private void tbPulseWidth_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
			{
				e.Handled = true;
			}
		}

		private void btnOk_Click(object sender, EventArgs e)
		{
			Settings.advSetPulseWidth = chkPulseWidth.Checked;
			Settings.advPulseWidth = int.Parse(tbPulseWidth.Text);
		}
	}
}
