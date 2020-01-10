using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace SessionManagement
{
	// Token: 0x0200000C RID: 12
	public partial class frmPuttySessions : Form
	{
		// Token: 0x060000C8 RID: 200 RVA: 0x0000AD64 File Offset: 0x00008F64
		public frmPuttySessions()
		{
			this.InitializeComponent();
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x0000AD7D File Offset: 0x00008F7D
		private void btCancel_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x060000CA RID: 202 RVA: 0x0000AD88 File Offset: 0x00008F88
		private void frmPuttySessions_Load(object sender, EventArgs e)
		{
			try
			{
				Global.readPuttySessionFromRegistry();
				for (int i = 0; i < Global.arrPuttySessionsList.Count; i++)
				{
					PuttySession puttySession = Global.arrPuttySessionsList[i] as PuttySession;
					if (puttySession.sessionHost != "")
					{
						this.dataGridPuttySession.Rows.Add(new object[]
						{
							puttySession.sessionName,
							puttySession.sessionHost
						});
					}
				}
				if (this.dataGridPuttySession.Rows.Count > 1)
				{
					this.btCreateDatabase.Enabled = true;
				}
				else
				{
					this.btCreateDatabase.Enabled = false;
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x060000CB RID: 203 RVA: 0x0000AE60 File Offset: 0x00009060
		private void btCreateDatabase_Click(object sender, EventArgs e)
		{
			try
			{
				this.createDatabaseFromPuttySessions();
				base.Close();
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x040000AC RID: 172
		public frmPuttySessions.CreateDatabaseFromPuttySessions createDatabaseFromPuttySessions;

		// Token: 0x0200000D RID: 13
		// (Invoke) Token: 0x060000CF RID: 207
		public delegate void CreateDatabaseFromPuttySessions();
	}
}
