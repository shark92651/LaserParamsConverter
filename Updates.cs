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
using System.Diagnostics;
using System.Threading;
using Octokit;

namespace LaserParamsConverter
{
	static class Updates
	{

		public static async void CheckForUpdate()
		{

			Task<Version> checkUpdateTask = GitHubLatestRelease();

			Version latestVersion = await checkUpdateTask;
			Version localVersion = typeof(Updates).Assembly.GetName().Version;

			int versionComparison = localVersion.CompareTo(latestVersion);
			if (versionComparison < 0)
			{
				string msg = string.Format("Version {0}.{1}.{2} has been released\n\nWould you like to download?",
																	latestVersion.Major, latestVersion.Minor, latestVersion.Build);

				if (MessageBox.Show(msg, "New Version Available!", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
				{
					string releaseURL = string.Format(@"https://github.com/shark92651/LaserParamsConverter/releases/tag/v{0}.{1}.{2}",
																								latestVersion.Major, latestVersion.Minor, latestVersion.Build);

					ProcessStartInfo sInfo = new ProcessStartInfo(releaseURL);
					sInfo.UseShellExecute = true;
					Process.Start(sInfo);
				}
			}
		}


		static async Task<Version> GitHubLatestRelease()
		{
			GitHubClient client = new GitHubClient(new ProductHeaderValue("LaserParamsConverter"));
			IReadOnlyList<Release> releases = await client.Repository.Release.GetAll("shark92651", "LaserParamsConverter");

			Version latestVersion = new Version(releases[0].TagName.Replace("v", ""));
			return latestVersion;
		}


	}
}
