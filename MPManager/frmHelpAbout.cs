using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace SessionManagement
{
	// Token: 0x02000005 RID: 5
	public partial class frmHelpAbout : Form
	{
		// Token: 0x06000080 RID: 128 RVA: 0x0000768F File Offset: 0x0000588F
		public frmHelpAbout()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000081 RID: 129 RVA: 0x000076A8 File Offset: 0x000058A8
		private void btOK_Click(object sender, EventArgs e)
		{
			base.Close();
		}
	}
}
