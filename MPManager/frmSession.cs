using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using SessionManagement.Properties;

namespace SessionManagement
{
	// Token: 0x0200000E RID: 14
	public partial class frmSession : Form
	{
		// Token: 0x060000D2 RID: 210 RVA: 0x0000B33C File Offset: 0x0000953C
		public frmSession()
		{
			this.InitializeComponent();
			this.createPostLoginCommandTextBox();
			this.disableAllCommands();
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x0000B364 File Offset: 0x00009564
		private void cmbProtocol_TextChanged(object sender, EventArgs e)
		{
			if (this.cmbProtocol.Text == "SSH")
			{
				this.numPort.Value = 22m;
			}
			if (this.cmbProtocol.Text == "Telnet")
			{
				this.numPort.Value = 23m;
			}
			if (this.cmbProtocol.Text == "RLogin")
			{
				this.numPort.Value = 513m;
			}
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x0000B404 File Offset: 0x00009604
		private void btOK_Click(object sender, EventArgs e)
		{
			try
			{
				if (this.sess == null)
				{
					this.sess = new Session();
					if (Global.arrAvailableSessions == null)
					{
						this.sess.sessionID = 1;
					}
					else
					{
						this.sess.sessionID = Global.arrAvailableSessions.Count + 1;
					}
				}
				this.sess.sessionName = this.txtName.Text;
				this.sess.sessionHost = this.txtHost.Text;
				this.sess.sessionProtocol = this.cmbProtocol.Text;
				this.sess.sessionPort = int.Parse(this.numPort.Value.ToString());
				this.sess.sessionConfig = this.cmbPuttySession.Text;
				this.sess.sessionDescription = this.richDescription.Text;
				this.sess.sessionUserName = this.txtSessionUserName.Text;
				this.sess.sessionPassword = this.txtSessionPassword.Text;
				this.sess.ftpUserName = this.txtFTPUserName.Text;
				this.sess.ftpPassword = this.txtFTPPassword.Text;
				this.sess.sftpUserName = this.txtSFTPUserName.Text;
				this.sess.sftpPassword = this.txtSFTPPassword.Text;
				this.sess.postLogin = this.checkPostLogin.Checked;
				this.sess.connectionTimeout = int.Parse(this.numConnectionTimeout.Value.ToString());
				this.sess.usernameTimeout = int.Parse(this.numUsernameTimeout.Value.ToString());
				this.sess.passwordTimeout = int.Parse(this.numPasswordTimeout.Value.ToString());
				this.sess.commandTimeout = int.Parse(this.numCommandTimeout.Value.ToString());
				this.sess.postLoginCommands = this.getPostLoginCommands();
				if (this.cmbPuttySession.Text != Global.strCreatePuttySetting)
				{
					Global.strCreatePuttySetting = this.cmbPuttySession.Text;
					Global.saveLatestCreatePuttySettingToRegistry();
				}
				this.createOrUpdateSession(this.sess);
				base.Close();
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x0000B6B4 File Offset: 0x000098B4
		public void loadExistingSession(Session sess)
		{
			if (sess != null)
			{
				this.sess = sess;
			}
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x0000B6D8 File Offset: 0x000098D8
		public void displayExistingValues()
		{
			this.txtName.Text = this.sess.sessionName;
			this.txtHost.Text = this.sess.sessionHost;
			this.cmbProtocol.Text = this.sess.sessionProtocol;
			this.numPort.Value = this.sess.sessionPort;
			this.cmbPuttySession.Text = this.sess.sessionConfig;
			this.richDescription.Text = this.sess.sessionDescription;
			this.txtSessionUserName.Text = this.sess.sessionUserName;
			this.txtSessionPassword.Text = this.sess.sessionPassword;
			this.txtFTPUserName.Text = this.sess.ftpUserName;
			this.txtFTPPassword.Text = this.sess.ftpPassword;
			this.txtSFTPUserName.Text = this.sess.sftpUserName;
			this.txtSFTPPassword.Text = this.sess.sftpPassword;
			this.numConnectionTimeout.Value = this.sess.connectionTimeout;
			this.numUsernameTimeout.Value = this.sess.usernameTimeout;
			this.numPasswordTimeout.Value = this.sess.passwordTimeout;
			this.numCommandTimeout.Value = this.sess.commandTimeout;
			this.checkPostLogin.Checked = this.sess.postLogin;
			if (this.checkPostLogin.Checked)
			{
				this.enableAllCommands();
			}
			else
			{
				this.disableAllCommands();
			}
			int count = this.sess.postLoginCommands.Count;
			for (int i = 0; i < count; i++)
			{
				this.txtCommands[i].Text = this.sess.postLoginCommands[i].ToString();
			}
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x0000B8F0 File Offset: 0x00009AF0
		private void frmSession_Load(object sender, EventArgs e)
		{
			try
			{
				Global.readPuttySessionFromRegistry();
				for (int i = 0; i < Global.arrPuttySessionsList.Count; i++)
				{
					PuttySession puttySession = Global.arrPuttySessionsList[i] as PuttySession;
					if (puttySession.sessionHost == "")
					{
						this.cmbPuttySession.Items.Add(puttySession.sessionName);
					}
				}
				this.cmbProtocol.Text = "SSH";
				this.cmbPuttySession.Text = Global.strCreatePuttySetting;
				if (this.sess != null)
				{
					this.displayExistingValues();
				}
				if (this.txtName.Text.Trim() == "" || this.txtHost.Text.Trim() == "")
				{
					this.btOK.Enabled = false;
				}
				this.txtHost.Focus();
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x0000BA0C File Offset: 0x00009C0C
		public void createPostLoginCommandTextBox()
		{
			this.txtCommands = new TextBox[5];
			int x = 116;
			int num = 54;
			for (int i = 0; i < 5; i++)
			{
				this.txtCommands[i] = new TextBox();
				this.txtCommands[i].Location = new Point(x, num);
				this.txtCommands[i].Size = new Size(272, 25);
				this.txtCommands[i].TabIndex = 14 + i;
				this.groupPostLoginCommand.Controls.Add(this.txtCommands[i]);
				num += 30;
			}
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x0000BAAA File Offset: 0x00009CAA
		private void btCancel_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x060000DA RID: 218 RVA: 0x0000BAB4 File Offset: 0x00009CB4
		public void enableAllCommands()
		{
			for (int i = 0; i < this.txtCommands.Count<TextBox>(); i++)
			{
				this.txtCommands[i].Enabled = true;
			}
			this.txtCommands[0].Focus();
		}

		// Token: 0x060000DB RID: 219 RVA: 0x0000BAFC File Offset: 0x00009CFC
		public void disableAllCommands()
		{
			for (int i = 0; i < this.txtCommands.Count<TextBox>(); i++)
			{
				this.txtCommands[i].Enabled = false;
			}
		}

		// Token: 0x060000DC RID: 220 RVA: 0x0000BB34 File Offset: 0x00009D34
		private void checkPostLogin_CheckedChanged(object sender, EventArgs e)
		{
			if (this.checkPostLogin.Checked)
			{
				this.enableAllCommands();
			}
			else
			{
				this.disableAllCommands();
			}
		}

		// Token: 0x060000DD RID: 221 RVA: 0x0000BB64 File Offset: 0x00009D64
		private void txtName_TextChanged(object sender, EventArgs e)
		{
			if (this.txtName.Text.Trim() == "")
			{
				this.btOK.Enabled = false;
			}
			else if (this.txtHost.Text.Trim() != "")
			{
				this.btOK.Enabled = true;
			}
		}

		// Token: 0x060000DE RID: 222 RVA: 0x0000BBD4 File Offset: 0x00009DD4
		private void txtHost_TextChanged(object sender, EventArgs e)
		{
			if (this.txtHost.Text.Trim() == "")
			{
				this.btOK.Enabled = false;
			}
			else if (this.txtName.Text.Trim() != "")
			{
				this.btOK.Enabled = true;
			}
		}

		// Token: 0x060000DF RID: 223 RVA: 0x0000BC44 File Offset: 0x00009E44
		public ArrayList getPostLoginCommands()
		{
			ArrayList arrayList = new ArrayList();
			for (int i = 0; i < this.txtCommands.Count<TextBox>(); i++)
			{
				if (this.txtCommands[i].Text != "")
				{
					arrayList.Add(this.txtCommands[i].Text);
				}
			}
			return arrayList;
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x0000BCAC File Offset: 0x00009EAC
		private void tabpageExtraConnect_Enter(object sender, EventArgs e)
		{
			if (this.sess == null)
			{
				if (this.txtFTPUserName.Text == "")
				{
					this.txtFTPUserName.Text = this.txtSessionUserName.Text;
				}
				if (this.txtFTPPassword.Text == "")
				{
					this.txtFTPPassword.Text = this.txtSessionPassword.Text;
				}
				if (this.txtSFTPUserName.Text == "")
				{
					this.txtSFTPUserName.Text = this.txtSessionUserName.Text;
				}
				if (this.txtSFTPPassword.Text == "")
				{
					this.txtSFTPPassword.Text = this.txtSessionPassword.Text;
				}
			}
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x0000BD98 File Offset: 0x00009F98
		private void txtSessionUserName_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x0000BD9C File Offset: 0x00009F9C
		private void btShowFTPPassword_Click(object sender, EventArgs e)
		{
			if (this.txtFTPPassword.PasswordChar == '*')
			{
				this.txtFTPPassword.PasswordChar = '\0';
			}
			else
			{
				this.txtFTPPassword.PasswordChar = '*';
			}
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x0000BDE0 File Offset: 0x00009FE0
		private void btShowSFTPPassword_Click(object sender, EventArgs e)
		{
			if (this.txtSFTPPassword.PasswordChar == '*')
			{
				this.txtSFTPPassword.PasswordChar = '\0';
			}
			else
			{
				this.txtSFTPPassword.PasswordChar = '*';
			}
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x0000BE24 File Offset: 0x0000A024
		private void cmbProtocol_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.cmbProtocol.Text == "SSH")
			{
				this.numPort.Value = 22m;
			}
			if (this.cmbProtocol.Text == "Telnet")
			{
				this.numPort.Value = 23m;
			}
			if (this.cmbProtocol.Text == "RLogin")
			{
				this.numPort.Value = 513m;
			}
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x0000BEC4 File Offset: 0x0000A0C4
		private void btShowSessionPassword_Click(object sender, EventArgs e)
		{
			if (this.txtSessionPassword.PasswordChar == '*')
			{
				this.txtSessionPassword.PasswordChar = '\0';
			}
			else
			{
				this.txtSessionPassword.PasswordChar = '*';
			}
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x0000BF08 File Offset: 0x0000A108
		private void txtName_Enter(object sender, EventArgs e)
		{
			if (this.txtHost.Text.Trim() != "" && this.txtName.Text.Trim() == "")
			{
				this.txtName.Text = this.txtHost.Text;
			}
		}

		// Token: 0x040000B4 RID: 180
		public Session sess;

		// Token: 0x040000B5 RID: 181
		public TextBox[] txtCommands;

		// Token: 0x040000B6 RID: 182
		public frmSession.CreateOrUpdateSession createOrUpdateSession;

		// Token: 0x0200000F RID: 15
		// (Invoke) Token: 0x060000EA RID: 234
		public delegate void CreateOrUpdateSession(Session sess);
	}
}
