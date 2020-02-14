using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Deployment.Application;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PtsClickOnce
{
    public partial class frmUpdate : Form
    {
		public frmUpdate()
		{
			InitializeComponent();
		}

		[Conditional("DEBUG")]
		private static void DebugPrt(string msg)
		{
			MessageBox.Show(msg);
		}

		private void StartProgram()
		{
			Process.Start("Pts.exe");
		}

		private void frmUpdate_Load(object sender, EventArgs e)
		{
			if (Program.IsDeployClickOnce)
			{
				GoCheckUpdate();
			}
		}

		private void GoCheckUpdate()
		{
			if (NetworkInfo.IsConnectionExist(Program.ClickOnceUpdateDN))
			{
				UpdateProgram();
				return;
			}
			StartProgram();
			Close();
		}

		private void UpdateProgram()
		{
			bool flag = false;
			try
			{
				ApplicationDeployment currentDeployment = ApplicationDeployment.CurrentDeployment;
				if (ApplicationDeployment.CurrentDeployment.CheckForUpdate())
				{
					Program.Counter++;
					currentDeployment.UpdateProgressChanged += obj_UpdateProgressChanged;
					currentDeployment.UpdateCompleted += obj_UpdateCompleted;
					currentDeployment.UpdateAsync();
					flag = true;
				}
			}
			catch (Exception)
			{
				Close();
			}
			if (!flag)
			{
				StartProgram();
				Close();
			}
		}

		private void obj_UpdateProgressChanged(object sender, DeploymentProgressChangedEventArgs e)
		{
			Program.Counter++;
			pbStatus.Value = e.ProgressPercentage;
			Application.DoEvents();
		}

		private void obj_UpdateCompleted(object sender, AsyncCompletedEventArgs e)
		{
			MessageBox.Show("更新完成，重新啟動程式。");
			Program.Upgraded = true;
			Close();
		}

	

	}
}
