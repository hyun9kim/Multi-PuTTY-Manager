using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using SessionManagement.Properties;

namespace SessionManagement
{
	// Token: 0x02000008 RID: 8
	public partial class frmOptions : Form
	{
		// Token: 0x0600009B RID: 155 RVA: 0x00008F7D File Offset: 0x0000717D
		public frmOptions()
		{
			this.InitializeComponent();
		}

		// Token: 0x0600009C RID: 156 RVA: 0x00008F98 File Offset: 0x00007198
		private void btOK_Click(object sender, EventArgs e)
		{
			if (!File.Exists(this.txtPuttyLocation.Text))
			{
				MessageBox.Show("PuTTY file does not exist!");
			}
			else
			{
				try
				{
					Global.strDefaultDatabaseLocation = this.txtDatabaseLocation.Text;
					Global.strPuttyLocation = this.txtPuttyLocation.Text;
					Global.strWinSCPLocation = this.txtWinSCPLocation.Text;
					if (this.radLeft.Checked)
					{
						Global.strSessionManagerPosition = "Left";
					}
					else
					{
						Global.strSessionManagerPosition = "Right";
					}
					Global.writeInfoToWindowRegistry();
					if (this.strCurrentSessionManagerPosition != Global.strSessionManagerPosition)
					{
						this.displaySessionManager();
					}
					base.Close();
				}
				catch (Exception ex)
				{
				}
			}
		}

		// Token: 0x0600009D RID: 157 RVA: 0x00009070 File Offset: 0x00007270
		private void frmOptions_Load(object sender, EventArgs e)
		{
			this.txtDatabaseLocation.Text = Global.strDefaultDatabaseLocation;
			this.txtPuttyLocation.Text = Global.strPuttyLocation;
			this.txtWinSCPLocation.Text = Global.strWinSCPLocation;
			if (Global.strSessionManagerPosition == "Left")
			{
				this.radLeft.Checked = true;
			}
			else
			{
				this.radRight.Checked = true;
			}
			this.strCurrentSessionManagerPosition = Global.strSessionManagerPosition;
		}

		// Token: 0x0600009E RID: 158 RVA: 0x000090EE File Offset: 0x000072EE
		private void btCancel_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x0600009F RID: 159 RVA: 0x000090F8 File Offset: 0x000072F8
		private void btDatabaseBrowser_Click(object sender, EventArgs e)
		{
			try
			{
				OpenFileDialog openFileDialog = new OpenFileDialog();
				openFileDialog.Filter = "Database Files (*.dat)|*.dat";
				openFileDialog.InitialDirectory = Directory.GetCurrentDirectory() + "\\Databases";
				openFileDialog.FilterIndex = 0;
				openFileDialog.RestoreDirectory = true;
				if (openFileDialog.ShowDialog() == DialogResult.OK)
				{
					string fileName = openFileDialog.FileName;
					this.txtDatabaseLocation.Text = fileName;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("btDatabaseBrowser_Click\n" + ex.ToString());
			}
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x0000919C File Offset: 0x0000739C
		private void btPuttyBrowser_Click(object sender, EventArgs e)
		{
			try
			{
				OpenFileDialog openFileDialog = new OpenFileDialog();
				openFileDialog.Filter = "Putty (putty.exe)|putty.exe|Binaries Files (*.exe)|*.exe|All Files (*.*)|*.*";
				openFileDialog.FilterIndex = 0;
				openFileDialog.RestoreDirectory = true;
				if (openFileDialog.ShowDialog() == DialogResult.OK)
				{
					string fileName = openFileDialog.FileName;
					this.txtPuttyLocation.Text = fileName;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("btPuttyBrowser_Click\n" + ex.ToString());
			}
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x00009228 File Offset: 0x00007428
		private void btWinSCPBrowser_Click(object sender, EventArgs e)
		{
			try
			{
				OpenFileDialog openFileDialog = new OpenFileDialog();
				openFileDialog.Filter = "WinSCP (winscp.exe)|winscp.exe|Binaries Files (*.exe)|*.exe|All Files (*.*)|*.*";
				openFileDialog.FilterIndex = 0;
				openFileDialog.RestoreDirectory = true;
				if (openFileDialog.ShowDialog() == DialogResult.OK)
				{
					string fileName = openFileDialog.FileName;
					this.txtWinSCPLocation.Text = fileName;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("btWinSCPBrowser_Click\n" + ex.ToString());
			}
		}

		// Token: 0x04000089 RID: 137
		public frmOptions.DisplaySessionManager displaySessionManager;

		// Token: 0x0400008A RID: 138
		private string strCurrentSessionManagerPosition;

		// Token: 0x02000009 RID: 9
		// (Invoke) Token: 0x060000A5 RID: 165
		public delegate void DisplaySessionManager();
	}
}
