using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace SessionManagement
{
	// Token: 0x02000003 RID: 3
	public partial class frmDatabaseProperties : Form
	{
		// Token: 0x06000073 RID: 115 RVA: 0x00006ED6 File Offset: 0x000050D6
		public frmDatabaseProperties()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000074 RID: 116 RVA: 0x00006F08 File Offset: 0x00005108
		public frmDatabaseProperties(string databaseID, string databaseName, string location)
		{
			this.InitializeComponent();
			this.txtDatabaseName.Enabled = false;
			this.btOK.Enabled = false;
			this.databaseID = databaseID;
			this.orginalDatabaseName = databaseName;
			this.txtDatabaseName.Text = databaseName;
			this.lbLocation.Text = location;
		}

		// Token: 0x06000075 RID: 117 RVA: 0x00006F84 File Offset: 0x00005184
		private void btCancel_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000076 RID: 118 RVA: 0x00006F8E File Offset: 0x0000518E
		private void btRename_Click(object sender, EventArgs e)
		{
			this.txtDatabaseName.Enabled = true;
			this.txtDatabaseName.Focus();
		}

		// Token: 0x06000077 RID: 119 RVA: 0x00006FAC File Offset: 0x000051AC
		private void txtDatabaseName_TextChanged(object sender, EventArgs e)
		{
			if (this.txtDatabaseName.Text != this.orginalDatabaseName && this.txtDatabaseName.Text.Trim() != "")
			{
				this.btOK.Enabled = true;
			}
			else
			{
				this.btOK.Enabled = false;
			}
		}

		// Token: 0x06000078 RID: 120 RVA: 0x00007013 File Offset: 0x00005213
		private void btOK_Click(object sender, EventArgs e)
		{
			this.renameDatabase(this.databaseID, this.txtDatabaseName.Text);
			base.Close();
		}

		// Token: 0x06000079 RID: 121 RVA: 0x0000703C File Offset: 0x0000523C
		private void txtDatabaseName_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == '\r')
			{
				if (this.txtDatabaseName.Text != this.orginalDatabaseName && this.txtDatabaseName.Text.Trim() != "")
				{
					this.renameDatabase(this.databaseID, this.txtDatabaseName.Text);
					base.Close();
				}
			}
		}

		// Token: 0x04000062 RID: 98
		private string orginalDatabaseName = "";

		// Token: 0x04000063 RID: 99
		private string databaseID = "";

		// Token: 0x04000064 RID: 100
		public frmDatabaseProperties.RenameDatabase renameDatabase;

		// Token: 0x02000004 RID: 4
		// (Invoke) Token: 0x0600007D RID: 125
		public delegate void RenameDatabase(string databaseID, string databaseName);
	}
}
