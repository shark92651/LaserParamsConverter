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
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using static LaserParamsConverter.LaserLibrary;


namespace LaserParamsConverter
{
	public partial class ConvertOneForm : Form
	{
		private LaserType laser;

		public ConvertOneForm()
		{
			InitializeComponent();
		}

		public ConvertOneForm(LaserType laser, int maxPower, int inLens, int inWatts, int inPower, int inSpeed, int outLens, int outWatts)
		{
			InitializeComponent();

			this.laser = laser;
			if (laser == LaserType.CO2)
			{
				tbInLens.Enabled = false;
				tbOutLens.Enabled = false;
				tbInLens.Text = "NA";
				tbOutLens.Text = "NA";
			}
			else
			{
				tbInLens.Text = inLens.ToString();
				tbOutLens.Text = outLens.ToString();
			}

			lblLaser.Text = laser.GetDescription();
			tbMaxPower.Text = maxPower.ToString();
			tbInWatts.Text = inWatts.ToString();
			tbInPower.Text = inPower.ToString();
			tbInSpeed.Text = inSpeed.ToString();
			tbOutWatts.Text = outWatts.ToString();

			Convert();
		}

		private void Convert()
		{
			try
			{
				int maxPower = int.Parse(tbMaxPower.Text, NumberFormatInfo.InvariantInfo);
				int inLens;
				int inWatts = int.Parse(tbInWatts.Text, NumberFormatInfo.InvariantInfo);
				int inPower = int.Parse(tbInPower.Text, NumberFormatInfo.InvariantInfo);
				int inSpeed = int.Parse(tbInSpeed.Text, NumberFormatInfo.InvariantInfo);
				int outLens;
				int outWatts = int.Parse(tbOutWatts.Text, NumberFormatInfo.InvariantInfo);

				if (laser == LaserType.CO2)
				{
					inLens = 1;
					outLens = 1;
				}
				else
				{
					inLens = int.Parse(tbInLens.Text, NumberFormatInfo.InvariantInfo);
					outLens = int.Parse(tbOutLens.Text, NumberFormatInfo.InvariantInfo);
				}

				LaserParam param = new LaserParam(inSpeed, inPower);
				param.Convert(laser, maxPower, inLens, inWatts, outLens, outWatts);

				tbOutPower.Text = param.Power.ToString();
				tbOutSpeed.Text = param.Speed.ToString();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void tbMaxPower_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
			{
				e.Handled = true;
			}
		}

		private void btnConvert_Click(object sender, EventArgs e)
		{
			Convert();
		}
	}
}
