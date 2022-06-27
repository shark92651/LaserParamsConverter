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

namespace LaserParamsConverter
{
	static class Settings
	{
		public static int IdxFormat
		{
			get { return Properties.Settings.Default.idxFormat; }
			set { Properties.Settings.Default.idxFormat = value; }
		}

		public static int IdxLaser
		{
			get { return Properties.Settings.Default.idxLaser; }
			set { Properties.Settings.Default.idxLaser = value; }
		}

		public static int MaxPowerFiber
		{
			get { return Properties.Settings.Default.maxPowerFiber; }
			set { Properties.Settings.Default.maxPowerFiber = value; }
		}

		public static int MaxPowerCO2
		{
			get { return Properties.Settings.Default.maxPowerCO2; }
			set { Properties.Settings.Default.maxPowerCO2 = value; }
		}

		public static int InLensFiber
		{
			get { return Properties.Settings.Default.inLensFiber; }
			set { Properties.Settings.Default.inLensFiber = value; }
		}

		public static int InWattsFiber
		{
			get { return Properties.Settings.Default.inWattsFiber; }
			set { Properties.Settings.Default.inWattsFiber = value; }
		}

		public static int OutLensFiber
		{
			get { return Properties.Settings.Default.outLensFiber; }
			set { Properties.Settings.Default.outLensFiber = value; }
		}

		public static int OutWattsFiber
		{
			get { return Properties.Settings.Default.outWattsFiber; }
			set { Properties.Settings.Default.outWattsFiber = value; }
		}

		public static int InWattsCO2
		{
			get { return Properties.Settings.Default.inWattsCO2; }
			set { Properties.Settings.Default.inWattsCO2 = value; }
		}

		public static int OutWattsCO2
		{
			get { return Properties.Settings.Default.outWattsCO2; }
			set { Properties.Settings.Default.outWattsCO2 = value; }
		}

		public static void Save()
		{ 
			Properties.Settings.Default.Save();
		}

	}
}
