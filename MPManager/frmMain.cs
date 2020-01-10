using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using SessionManagement.Properties;
using WeifenLuo.WinFormsUI.Docking;

namespace SessionManagement
{
	// Token: 0x02000002 RID: 2
	public partial class frmMain : Form
	{
		// Token: 0x06000001 RID: 1
		[DllImport("User32.dll")]
		private static extern int SetForegroundWindow(IntPtr point);

		// Token: 0x06000002 RID: 2
		[DllImport("user32.dll")]
		private static extern IntPtr GetForegroundWindow();

		// Token: 0x06000003 RID: 3
		[DllImport("user32.dll")]
		private static extern void mouse_event(int dwFlags, int dx, int dy, int dwData, int dwExtraInfo);

		// Token: 0x06000004 RID: 4
		[DllImport("user32.dll", CharSet = CharSet.Auto)]
		private static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr wParam, int lParam);

		// Token: 0x06000005 RID: 5
		[DllImport("user32.dll")]
		public static extern bool RemoveMenu(IntPtr hMenu, int wPosition, int wFlags);

		// Token: 0x06000006 RID: 6
		[DllImport("user32.dll")]
		private static extern uint TrackPopupMenuEx(IntPtr hmenu, uint fuFlags, int x, int y, IntPtr hwnd, IntPtr lptpm);

		// Token: 0x06000007 RID: 7
		[DllImport("user32.dll", SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		private static extern bool PostMessage(IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam);

		// Token: 0x06000008 RID: 8
		[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		private static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);

		// Token: 0x06000009 RID: 9 RVA: 0x00002050 File Offset: 0x00000250
		public frmMain()
		{
			this.InitializeComponent();
		}

		// Token: 0x0600000A RID: 10 RVA: 0x0000207C File Offset: 0x0000027C
		private void frmMain_Load(object sender, EventArgs e)
		{
			Global.arrPuttySessionsList = new ArrayList();
			Global.arrAvailableSessions = new ArrayList();
			try
			{
				Global.createNewParametersInRegistry();
				Global.readInfoFromWindowRegistry();
				this.fmSessionManager = new frmSessionManager();
				this.fmSessionManager.openSession = new frmSessionManager.OpenSession(this.openSession);
				this.fmSessionManager.hideSessionManager = new frmSessionManager.HideSessionManager(this.hideSessionManager);
				this.fmSessionManager.openExtraSession = new frmSessionManager.OpenExtraSession(this.openExtraSession);
				this.fmSessionManager.displayStatus = new frmSessionManager.DisplayStatus(this.displayStatus);
				this.displaySessionManager();
				this.toolStripQuickConnectPassword.TextBox.PasswordChar = '*';
				this.checkItemsStatusAndDisplay();
				for (int i = 0; i < Global.arrPuttySessionsList.Count; i++)
				{
					PuttySession puttySession = Global.arrPuttySessionsList[i] as PuttySession;
					if (puttySession.sessionHost == "")
					{
						this.toolStripQuickConnecSessionConfig.Items.Add(puttySession.sessionName);
					}
				}
				if (Global.strQuickPuttySetting.Trim() != "")
				{
					this.toolStripQuickConnecSessionConfig.Text = Global.strQuickPuttySetting;
				}
				else
				{
					this.toolStripQuickConnecSessionConfig.Text = "Default Settings";
				}
				if (Global.strQuickPuttyProtocol.Trim() != "")
				{
					this.toolStripQuickConnectProtocol.Text = Global.strQuickPuttyProtocol;
				}
				else
				{
					this.toolStripQuickConnectProtocol.Text = "SSH";
				}
				this.toolStripGlobalCommandStatus.Text = "";
				this.disableWhenNoActiveSession();
				this.hook.KeyPressed += this.hook_KeyPressed;
				this.hook.RegisterHotKey(SessionManagement.ModifierKeys.Control, Keys.Tab);
				this.hook.RegisterHotKey(SessionManagement.ModifierKeys.Control | SessionManagement.ModifierKeys.Shift, Keys.Tab);
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00002280 File Offset: 0x00000480
		private void frmMain_Activated(object sender, EventArgs e)
		{
			try
			{
				int num = this.indexOfActiveTab();
				if (!this.formActivate && num != -1)
				{
					this.switchBackPreviousTab(num);
					this.switchToNextTab(num - 1);
				}
				this.formActivate = true;
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x0600000C RID: 12 RVA: 0x000022E0 File Offset: 0x000004E0
		private void frmMain_Deactivate(object sender, EventArgs e)
		{
			this.formActivate = false;
			base.Focus();
		}

		// Token: 0x0600000D RID: 13 RVA: 0x000022F4 File Offset: 0x000004F4
		private void switchToNextTab(int currentIndex)
		{
			int num = this.dockPanelMain.Documents.Count<IDockContent>();
			if (num > 1)
			{
				int num2 = currentIndex + 1;
				if (num2 >= num)
				{
					num2 = 0;
				}
				try
				{
					frmPutty frmPutty = this.dockPanelMain.Documents.ElementAt(num2) as frmPutty;
					frmPutty.Show(this.dockPanelMain, DockState.Document);
				}
				catch (Exception ex)
				{
				}
			}
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00002370 File Offset: 0x00000570
		private void switchBackPreviousTab(int currentIndex)
		{
			int num = this.dockPanelMain.Documents.Count<IDockContent>();
			if (num > 1)
			{
				int num2 = currentIndex - 1;
				if (num2 < 0)
				{
					num2 = num - 1;
				}
				try
				{
					frmPutty frmPutty = this.dockPanelMain.Documents.ElementAt(num2) as frmPutty;
					frmPutty.Show(this.dockPanelMain, DockState.Document);
				}
				catch (Exception ex)
				{
				}
			}
		}

		// Token: 0x0600000F RID: 15 RVA: 0x000023F0 File Offset: 0x000005F0
		private int indexOfActiveTab()
		{
			int result;
			try
			{
				int num = this.dockPanelMain.Documents.Count<IDockContent>();
				if (num == 0)
				{
					result = -1;
				}
				else
				{
					for (int i = 0; i < num; i++)
					{
						if (this.dockPanelMain.Documents.ElementAt(i) == this.dockPanelMain.ActiveDocument)
						{
							return i;
						}
					}
					result = -1;
				}
			}
			catch (Exception ex)
			{
				result = -1;
			}
			return result;
		}

		// Token: 0x06000010 RID: 16 RVA: 0x0000247C File Offset: 0x0000067C
		private void hook_KeyPressed(object sender, KeyPressedEventArgs e)
		{
			try
			{
				if (this.dockPanelMain.Documents.Count<IDockContent>() > 1)
				{
					if (!this.formActivate)
					{
						frmPutty frmPutty = this.dockPanelMain.ActiveDocument as frmPutty;
						if (frmPutty != null)
						{
							IntPtr foregroundWindow = frmMain.GetForegroundWindow();
							if (frmPutty.proc.MainWindowHandle == foregroundWindow)
							{
								this.formActivate = true;
							}
						}
					}
					if (this.formActivate)
					{
						int currentIndex = this.indexOfActiveTab();
						if (e.Modifier == SessionManagement.ModifierKeys.Control && e.Key == Keys.Tab)
						{
							this.switchToNextTab(currentIndex);
						}
						else if (e.Modifier == (SessionManagement.ModifierKeys.Control | SessionManagement.ModifierKeys.Shift) && e.Key == Keys.Tab)
						{
							this.switchBackPreviousTab(currentIndex);
						}
					}
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00002580 File Offset: 0x00000780
		public void displayStatus(string status)
		{
			this.statusBarStatus.Text = status;
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00002590 File Offset: 0x00000790
		public void hideSessionManager()
		{
			this.mnuViewSessionManager.Checked = false;
		}

		// Token: 0x06000013 RID: 19 RVA: 0x000025A0 File Offset: 0x000007A0
		public void closeSession(Session sess, string puttyName)
		{
			try
			{
				this.removePuttySessionFromGlobalCommandSessions(puttyName);
				this.displayStatusOfGlobalCommandSessions();
				if (this.dockPanelMain.DocumentsCount <= 1)
				{
					this.dockPanelMain.ContextMenuStrip = null;
					this.disableWhenNoActiveSession();
				}
				else
				{
					int num = this.indexOfActiveTab();
					if (num < this.dockPanelMain.DocumentsCount - 1)
					{
						this.switchToNextTab(num);
					}
					else
					{
						this.switchBackPreviousTab(num);
					}
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00002634 File Offset: 0x00000834
		private void contextRenameForDocPanel_Click(object sender, EventArgs e)
		{
			frmPutty frmPutty = this.dockPanelMain.ActiveDocument as frmPutty;
			if (frmPutty != null)
			{
				string text = frmPutty.Text;
				if (Global.InputBox("Rename Tab", "New name", ref text) == DialogResult.OK)
				{
					if (text != "")
					{
						frmPutty.Text = text;
						this.toolStripGlobalCommandSession.DropDownItems[frmPutty.Handle.ToString()].Text = text;
					}
				}
			}
		}

		// Token: 0x06000015 RID: 21 RVA: 0x000026CC File Offset: 0x000008CC
		private void contextSFTPExternal_Click(object sender, EventArgs e)
		{
			frmPutty frmPutty = this.dockPanelMain.ActiveDocument as frmPutty;
			this.openExtraSession(frmPutty.session, "sftp");
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00002700 File Offset: 0x00000900
		public void openExtraSession(Session sess, string type)
		{
			try
			{
				if (!File.Exists(Global.strWinSCPLocation))
				{
					MessageBox.Show("WinScP.exe file does not exist.  Go to Tools -> Options... to configure WinSCP file");
				}
				else
				{
					Process process = Process.Start(new ProcessStartInfo(Global.strWinSCPLocation)
					{
						Arguments = string.Concat(new string[]
						{
							type,
							"://",
							sess.sftpUserName,
							":",
							sess.sftpPassword,
							"@",
							sess.sessionHost
						}),
						UseShellExecute = false,
						CreateNoWindow = true,
						RedirectStandardInput = true,
						RedirectStandardOutput = true,
						RedirectStandardError = true
					});
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06000017 RID: 23 RVA: 0x000027DC File Offset: 0x000009DC
		private void contextFTPExternal_Click(object sender, EventArgs e)
		{
			frmPutty frmPutty = this.dockPanelMain.ActiveDocument as frmPutty;
			this.openExtraSession(frmPutty.session, "ftp");
		}

		// Token: 0x06000018 RID: 24 RVA: 0x0000280D File Offset: 0x00000A0D
		private void contextDuplicateSession_Click(object sender, EventArgs e)
		{
			this.duplicateActiveSession();
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00002818 File Offset: 0x00000A18
		public void duplicateActiveSession()
		{
			try
			{
				frmPutty frmPutty = new frmPutty();
				frmPutty.closeSession = new frmPutty.CloseSession(this.closeSession);
				frmPutty frmPutty2 = this.dockPanelMain.ActiveDocument as frmPutty;
				frmPutty.session.copySession(frmPutty2.session);
				frmPutty.openConnection();
				frmPutty.Show(this.dockPanelMain, DockState.Document);
				if (this.dockPanelMain.DocumentsCount > 0)
				{
					this.dockPanelMain.ContextMenuStrip = this.contextForDocPanel;
					this.enableWhenHavingActiveSession();
					this.addPuttySessionToGlobalCommandSessions(frmPutty);
				}
				frmPutty.autoLoginAndRunCommands();
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x0600001A RID: 26 RVA: 0x000028D0 File Offset: 0x00000AD0
		private void mnuHelpAbout_Click(object sender, EventArgs e)
		{
			frmHelpAbout frmHelpAbout = new frmHelpAbout();
			frmHelpAbout.ShowDialog();
		}

		// Token: 0x0600001B RID: 27 RVA: 0x000028EC File Offset: 0x00000AEC
		private void mnuHelpHelp_Click(object sender, EventArgs e)
		{
			if (File.Exists(Directory.GetCurrentDirectory() + "\\MPManager Quick Start.pdf"))
			{
				try
				{
					Process.Start(Directory.GetCurrentDirectory() + "\\MPManager Quick Start.pdf");
				}
				catch (Exception ex)
				{
				}
			}
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00002948 File Offset: 0x00000B48
		private void mnuHelpHomepage_Click(object sender, EventArgs e)
		{
			try
			{
				Process.Start("http://sourceforge.net/projects/multiputtymanager/");
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x0600001D RID: 29 RVA: 0x0000297C File Offset: 0x00000B7C
		public void openSession(Session sess)
		{
			if (!File.Exists(Global.strPuttyLocation))
			{
				MessageBox.Show("PuTTY.exe file does not exist. Go to Tools -> Options... to configure PuTTY file");
			}
			else
			{
				try
				{
					frmPutty frmPutty = new frmPutty(sess);
					frmPutty.openConnection();
					frmPutty.closeSession = new frmPutty.CloseSession(this.closeSession);
					frmPutty.Show(this.dockPanelMain, DockState.Document);
					if (this.dockPanelMain.DocumentsCount > 0)
					{
						this.dockPanelMain.ContextMenuStrip = this.contextForDocPanel;
						this.enableWhenHavingActiveSession();
						this.addPuttySessionToGlobalCommandSessions(frmPutty);
					}
					frmPutty.autoLoginAndRunCommands();
				}
				catch (Exception ex)
				{
				}
			}
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00002A30 File Offset: 0x00000C30
		private void toolStripQuickConnectConnect_Click(object sender, EventArgs e)
		{
			if (this.toolStripQuickConnectHost.Text != "")
			{
				this.openQuickConnection();
			}
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00002A64 File Offset: 0x00000C64
		public void openQuickConnection()
		{
			if (!File.Exists(Global.strPuttyLocation))
			{
				MessageBox.Show("PuTTY.exe file does not exist. Go to Tools -> Options... to configure PuTTY file");
			}
			else
			{
				try
				{
					if (!(this.toolStripQuickConnectHost.Text == ""))
					{
						Session session = new Session();
						session.sessionProtocol = this.toolStripQuickConnectProtocol.Text;
						session.sessionHost = this.toolStripQuickConnectHost.Text;
						session.sessionUserName = this.toolStripQuickConnetUserName.Text;
						session.sessionPassword = this.toolStripQuickConnectPassword.Text;
						session.sessionConfig = this.toolStripQuickConnecSessionConfig.Text;
						session.sessionName = session.sessionHost;
						frmPutty frmPutty = new frmPutty(session);
						frmPutty.closeSession = new frmPutty.CloseSession(this.closeSession);
						frmPutty.openConnection();
						frmPutty.Show(this.dockPanelMain, DockState.Document);
						if (this.dockPanelMain.DocumentsCount > 0)
						{
							this.dockPanelMain.ContextMenuStrip = this.contextForDocPanel;
							this.enableWhenHavingActiveSession();
							this.addPuttySessionToGlobalCommandSessions(frmPutty);
						}
						this.addHistoryQuickConnectHost();
						frmPutty.autoLoginAndRunCommands();
					}
				}
				catch (Exception ex)
				{
				}
			}
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00002BBC File Offset: 0x00000DBC
		public void addHistoryQuickConnectHost()
		{
			try
			{
				string text = this.toolStripQuickConnectHost.Text;
				int num = this.isTextInItemsList(this.toolStripQuickConnectHost);
				if (num != -1)
				{
					this.toolStripQuickConnectHost.Items.RemoveAt(num);
				}
				this.toolStripQuickConnectHost.Items.Insert(0, text);
				if (this.toolStripQuickConnectHost.Items.Count > 5)
				{
					this.toolStripQuickConnectHost.Items.RemoveAt(5);
				}
				this.toolStripQuickConnectHost.Text = text;
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00002C64 File Offset: 0x00000E64
		public int isTextInItemsList(ToolStripComboBox comboBox)
		{
			for (int i = 0; i < comboBox.Items.Count; i++)
			{
				if (comboBox.Items[i].Equals(comboBox.Text))
				{
					return i;
				}
			}
			return -1;
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00002CB4 File Offset: 0x00000EB4
		public void addPuttySessionToGlobalCommandSessions(frmPutty fmPutty)
		{
			ToolStripMenuItem toolStripMenuItem = new ToolStripMenuItem(fmPutty.Text);
			toolStripMenuItem.Name = fmPutty.Handle.ToString();
			toolStripMenuItem.Click += this.item_Click;
			toolStripMenuItem.Checked = true;
			toolStripMenuItem.CheckOnClick = true;
			toolStripMenuItem.CheckState = CheckState.Unchecked;
			this.toolStripGlobalCommandSession.DropDownItems.Add(toolStripMenuItem);
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00002D26 File Offset: 0x00000F26
		private void item_Click(object sender, EventArgs e)
		{
			this.displayStatusOfGlobalCommandSessions();
			this.toolStripGlobalCommandSession.ShowDropDown();
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00002D3C File Offset: 0x00000F3C
		public void removePuttySessionFromGlobalCommandSessions(string puttyName)
		{
			try
			{
				for (int i = 3; i < this.toolStripGlobalCommandSession.DropDownItems.Count; i++)
				{
					if (((ToolStripMenuItem)this.toolStripGlobalCommandSession.DropDownItems[i]).Name == puttyName)
					{
						this.toolStripGlobalCommandSession.DropDownItems.RemoveAt(i);
						break;
					}
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00002DC4 File Offset: 0x00000FC4
		private void toolStripQuickConnectHost_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!(this.toolStripQuickConnectHost.Text == ""))
			{
				if (e.KeyChar == '\r')
				{
					this.openQuickConnection();
				}
			}
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00002E08 File Offset: 0x00001008
		private void toolStripQuickConnectHost_MouseEnter(object sender, EventArgs e)
		{
			this.toolStripQuickConnect.Focus();
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00002E18 File Offset: 0x00001018
		private void toolStripQuickConnetUserName_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == '\r')
			{
				this.openQuickConnection();
			}
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00002E40 File Offset: 0x00001040
		private void toolStripQuickConnectPassword_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == '\r')
			{
				this.openQuickConnection();
			}
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00002E66 File Offset: 0x00001066
		private void dockPanelMain_MouseClick(object sender, MouseEventArgs e)
		{
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00002E69 File Offset: 0x00001069
		private void toolStripMenuPuttySystemMenu_MouseEnter(object sender, EventArgs e)
		{
			base.Focus();
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00002E73 File Offset: 0x00001073
		private void toolStripGlobalCommandSession_ButtonClick(object sender, EventArgs e)
		{
			this.toolStripGlobalCommandSession.ShowDropDown();
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00002E82 File Offset: 0x00001082
		private void toolStripGlobalCommandSession_MouseEnter(object sender, EventArgs e)
		{
			this.toolStripGlobalCommand.Focus();
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00002E91 File Offset: 0x00001091
		private void toolStripGlobalCommandCommand_MouseEnter(object sender, EventArgs e)
		{
			this.toolStripGlobalCommand.Focus();
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00002EA0 File Offset: 0x000010A0
		private void toolStripQuickConnectConnect_MouseEnter(object sender, EventArgs e)
		{
			base.Focus();
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00002EAA File Offset: 0x000010AA
		private void toolStripGlobalCommandRun_MouseEnter(object sender, EventArgs e)
		{
			base.Focus();
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00002EB4 File Offset: 0x000010B4
		private void toolStripGlobalCommandStopMultiCommands_Click(object sender, EventArgs e)
		{
			try
			{
				for (int i = 0; i < this.dockPanelMain.Documents.Count<IDockContent>(); i++)
				{
					frmPutty frmPutty = this.dockPanelMain.Documents.ElementAt(i) as frmPutty;
					frmPutty.stopRunningMultiCommands();
				}
				this.toolStripGlobalCommandStopMultiCommands.Visible = false;
			}
			catch (Exception ex)
			{
				this.toolStripGlobalCommandStopMultiCommands.Visible = false;
			}
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00002F38 File Offset: 0x00001138
		private void toolStripGlobalCommandStopMultiCommands_MouseEnter(object sender, EventArgs e)
		{
			this.toolStripGlobalCommand.Focus();
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00002F48 File Offset: 0x00001148
		public void displayStatusOfGlobalCommandSessions()
		{
			try
			{
				int count = this.toolStripGlobalCommandSession.DropDownItems.Count;
				this.toolStripSeparatorStatus.Visible = true;
				if (count == 3)
				{
					this.toolStripGlobalCommandStatus.Text = "No session accepts command";
					this.toolStripGlobalCommandCommand.Enabled = false;
					this.toolStripGlobalCommandRun.Enabled = false;
				}
				else
				{
					int num = 0;
					for (int i = 3; i < count; i++)
					{
						if (((ToolStripMenuItem)this.toolStripGlobalCommandSession.DropDownItems[i]).CheckState == CheckState.Checked)
						{
							num++;
						}
					}
					if (num == 0)
					{
						this.toolStripGlobalCommandStatus.Text = "No session accepts command";
						this.toolStripGlobalCommandCommand.Enabled = false;
						this.toolStripGlobalCommandRun.Enabled = false;
					}
					else if (num == 1)
					{
						this.toolStripGlobalCommandStatus.Text = num.ToString() + "/" + (count - 3).ToString() + " session accepts command";
						this.toolStripGlobalCommandCommand.Enabled = true;
						this.toolStripGlobalCommandRun.Enabled = true;
					}
					else
					{
						this.toolStripGlobalCommandStatus.Text = num.ToString() + "/" + (count - 3).ToString() + " sessions accept command";
						this.toolStripGlobalCommandCommand.Enabled = true;
						this.toolStripGlobalCommandRun.Enabled = true;
					}
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00003100 File Offset: 0x00001300
		private void toolStripCheckAll_Click(object sender, EventArgs e)
		{
			for (int i = 3; i < this.toolStripGlobalCommandSession.DropDownItems.Count; i++)
			{
				((ToolStripMenuItem)this.toolStripGlobalCommandSession.DropDownItems[i]).CheckState = CheckState.Checked;
			}
			this.displayStatusOfGlobalCommandSessions();
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00003154 File Offset: 0x00001354
		private void toolStripUncheckAll_Click(object sender, EventArgs e)
		{
			for (int i = 3; i < this.toolStripGlobalCommandSession.DropDownItems.Count; i++)
			{
				((ToolStripMenuItem)this.toolStripGlobalCommandSession.DropDownItems[i]).CheckState = CheckState.Unchecked;
			}
			this.displayStatusOfGlobalCommandSessions();
		}

		// Token: 0x06000035 RID: 53 RVA: 0x000031A8 File Offset: 0x000013A8
		public void stopMultiCommandsThread(ArrayList arrCommands)
		{
			try
			{
				string[] array = new string[0];
				for (int i = 0; i < arrCommands.Count; i++)
				{
					if (!this.multiCommandsThread.IsAlive)
					{
						break;
					}
					array = arrCommands[i].ToString().Split(new char[]
					{
						';'
					});
					Thread.Sleep(int.Parse(array[1]));
				}
				this.toolStripGlobalCommandStopMultiCommands.Visible = false;
				this.multiCommandsThread.Abort();
			}
			catch (Exception ex)
			{
				this.toolStripGlobalCommandStopMultiCommands.Visible = false;
				this.multiCommandsThread.Abort();
			}
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00003284 File Offset: 0x00001484
		public void startMultiCommandsThread(ArrayList arrCommands)
		{
			try
			{
				this.toolStripGlobalCommandStopMultiCommands.Visible = true;
				this.multiCommandsThread = null;
				this.multiCommandsThread = new Thread(delegate()
				{
					this.stopMultiCommandsThread(arrCommands);
				});
				this.multiCommandsThread.Start();
			}
			catch (Exception ex)
			{
				this.toolStripGlobalCommandStopMultiCommands.Visible = false;
				this.multiCommandsThread = null;
			}
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00003318 File Offset: 0x00001518
		public void runMultiCommandsOnActiveSession(ArrayList arrCommands)
		{
			try
			{
				frmPutty frmPutty = this.dockPanelMain.ActiveDocument as frmPutty;
				frmPutty.runMultiCommands(arrCommands);
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06000038 RID: 56 RVA: 0x0000335C File Offset: 0x0000155C
		public void runMultiCommandsOnMultiSessions(ArrayList arrCommands)
		{
			int count = this.toolStripGlobalCommandSession.DropDownItems.Count;
			try
			{
				if (count > 3)
				{
					for (int i = 3; i < count; i++)
					{
						if (((ToolStripMenuItem)this.toolStripGlobalCommandSession.DropDownItems[i]).CheckState == CheckState.Checked)
						{
							int num = int.Parse(((ToolStripMenuItem)this.toolStripGlobalCommandSession.DropDownItems[i]).Name);
							for (int j = 0; j < this.dockPanelMain.Documents.Count<IDockContent>(); j++)
							{
								frmPutty frmPutty = this.dockPanelMain.Documents.ElementAt(j) as frmPutty;
								if (num == int.Parse(frmPutty.Handle.ToString()))
								{
									frmPutty.runMultiCommands(arrCommands);
									break;
								}
							}
						}
					}
					this.startMultiCommandsThread(arrCommands);
				}
			}
			catch (Exception ex)
			{
			}
			this.toolStripGlobalCommandCommand.Text = "";
		}

		// Token: 0x06000039 RID: 57 RVA: 0x0000349C File Offset: 0x0000169C
		private void toolStripGlobalCommandRun_Click(object sender, EventArgs e)
		{
			try
			{
				if (!(this.toolStripGlobalCommandCommand.Text.Trim() == ""))
				{
					if (this.toolStripGlobalCommandCommand.Text.Trim() == "_mc")
					{
						new frmMultiCommands
						{
							runMultiCommands = new frmMultiCommands.RunMultiCommands(this.runMultiCommandsOnMultiSessions)
						}.ShowDialog();
					}
					else
					{
						this.runCommandOnMultiSessions(this.toolStripGlobalCommandCommand.Text);
						this.addHistoryGlobalCommand();
					}
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00003548 File Offset: 0x00001748
		public void runCommandOnMultiSessions(string command)
		{
			int count = this.toolStripGlobalCommandSession.DropDownItems.Count;
			try
			{
				if (count > 3)
				{
					for (int i = 3; i < count; i++)
					{
						if (((ToolStripMenuItem)this.toolStripGlobalCommandSession.DropDownItems[i]).CheckState == CheckState.Checked)
						{
							int num = int.Parse(((ToolStripMenuItem)this.toolStripGlobalCommandSession.DropDownItems[i]).Name);
							for (int j = 0; j < this.dockPanelMain.Documents.Count<IDockContent>(); j++)
							{
								frmPutty frmPutty = this.dockPanelMain.Documents.ElementAt(j) as frmPutty;
								if (num == int.Parse(frmPutty.Handle.ToString()))
								{
									this.runCommand(command, frmPutty.proc);
									break;
								}
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00003678 File Offset: 0x00001878
		public void runCommand(string command, Process proc)
		{
			try
			{
				if (proc != null && proc.Responding)
				{
					Global.sendString(proc.MainWindowHandle, command);
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x0600003C RID: 60 RVA: 0x000036C4 File Offset: 0x000018C4
		public void addHistoryGlobalCommand()
		{
			int num = this.isTextInItemsList(this.toolStripGlobalCommandCommand);
			if (num != -1)
			{
				this.toolStripGlobalCommandCommand.Items.RemoveAt(num);
			}
			this.toolStripGlobalCommandCommand.Items.Insert(0, this.toolStripGlobalCommandCommand.Text);
			if (this.toolStripGlobalCommandCommand.Items.Count > 10)
			{
				this.toolStripGlobalCommandCommand.Items.RemoveAt(10);
			}
			this.toolStripGlobalCommandCommand.Text = "";
			frmMain.SetForegroundWindow(base.Handle);
			this.toolStripGlobalCommandCommand.Focus();
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00003770 File Offset: 0x00001970
		public void getAndSaveDisplayedItems()
		{
			if (this.mnuViewToolbarsStandard.Checked)
			{
				Global.strViewToolbarsStandard = "Yes";
			}
			else
			{
				Global.strViewToolbarsStandard = "No";
			}
			if (this.mnuViewToolbarsMSC.Checked)
			{
				Global.strViewToolbarsMSC = "Yes";
			}
			else
			{
				Global.strViewToolbarsMSC = "No";
			}
			if (this.mnuViewToolbarsQuickConnection.Checked)
			{
				Global.strViewToolbarsQuickSession = "Yes";
			}
			else
			{
				Global.strViewToolbarsQuickSession = "No";
			}
			if (this.mnuViewSessionManager.Checked)
			{
				Global.strViewSessionManager = "Yes";
			}
			else
			{
				Global.strViewSessionManager = "No";
			}
			if (Global.strSessionManagerPosition == "Left")
			{
				Global.iSessionManagerWidth = (int)(this.dockPanelMain.DockLeftPortion * 100.0);
			}
			else
			{
				Global.iSessionManagerWidth = (int)(this.dockPanelMain.DockRightPortion * 100.0);
			}
			Global.saveLatestDisplayedMainItems();
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00003874 File Offset: 0x00001A74
		public void checkItemsStatusAndDisplay()
		{
			if (Global.strViewToolbarsStandard == "Yes")
			{
				this.toolStripMenu.Show();
				this.mnuViewToolbarsStandard.Checked = true;
			}
			else
			{
				this.toolStripMenu.Hide();
				this.mnuViewToolbarsStandard.Checked = false;
			}
			if (Global.strViewToolbarsQuickSession == "Yes")
			{
				this.toolStripQuickConnect.Show();
				this.mnuViewToolbarsQuickConnection.Checked = true;
			}
			else
			{
				this.toolStripQuickConnect.Hide();
				this.mnuViewToolbarsQuickConnection.Checked = false;
			}
			if (Global.strViewToolbarsMSC == "Yes")
			{
				this.toolStripGlobalCommand.Show();
				this.mnuViewToolbarsMSC.Checked = true;
			}
			else
			{
				this.toolStripGlobalCommand.Hide();
				this.mnuViewToolbarsMSC.Checked = false;
			}
			if (Global.strViewSessionManager == "Yes")
			{
				this.fmSessionManager.Show();
				this.mnuViewSessionManager.Checked = true;
			}
			else
			{
				this.fmSessionManager.Hide();
				this.mnuViewSessionManager.Checked = false;
			}
			this.dockPanelMain.DockRightPortion = (double)Global.iSessionManagerWidth / 100.0;
			this.dockPanelMain.DockLeftPortion = this.dockPanelMain.DockRightPortion;
		}

		// Token: 0x0600003F RID: 63 RVA: 0x000039F0 File Offset: 0x00001BF0
		private void mnuViewSessionManager_Click(object sender, EventArgs e)
		{
			if (this.mnuViewSessionManager.Checked)
			{
				this.fmSessionManager.Show();
			}
			else
			{
				this.fmSessionManager.Hide();
			}
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00003A2C File Offset: 0x00001C2C
		private void mnuToolPuttyConfiguration_Click(object sender, EventArgs e)
		{
			if (!File.Exists(Global.strPuttyLocation))
			{
				MessageBox.Show("PuTTY.exe file does not exist. Go to Tools -> Options... to configure PuTTY file");
			}
			else
			{
				try
				{
					Process process = Process.Start(new ProcessStartInfo(Global.strPuttyLocation)
					{
						UseShellExecute = false,
						CreateNoWindow = true,
						RedirectStandardInput = true,
						RedirectStandardOutput = true,
						RedirectStandardError = true
					});
				}
				catch (Exception ex)
				{
				}
			}
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00003AB0 File Offset: 0x00001CB0
		private void mnuToolsOption_Click(object sender, EventArgs e)
		{
			new frmOptions
			{
				displaySessionManager = new frmOptions.DisplaySessionManager(this.displaySessionManager)
			}.ShowDialog();
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00003AE0 File Offset: 0x00001CE0
		public void displaySessionManager()
		{
			if (Global.strSessionManagerPosition == "Left")
			{
				this.dockPanelMain.DockLeftPortion = this.dockPanelMain.DockRightPortion;
				this.fmSessionManager.Hide();
				this.fmSessionManager.DockAreas = DockAreas.DockLeft;
				this.fmSessionManager.Show(this.dockPanelMain, DockState.DockLeft);
			}
			else
			{
				this.dockPanelMain.DockRightPortion = this.dockPanelMain.DockLeftPortion;
				this.fmSessionManager.Hide();
				this.fmSessionManager.DockAreas = DockAreas.DockRight;
				this.fmSessionManager.Show(this.dockPanelMain, DockState.DockRight);
			}
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00003B94 File Offset: 0x00001D94
		public void disableWhenNoActiveSession()
		{
			this.toolStripMenuDisconnect.Enabled = false;
			this.toolStripGlobalCommand.Enabled = false;
			this.mnuFileCloseAllSessions.Enabled = false;
			this.toolStripGlobalCommandStatus.Text = "";
			this.toolStripSeparatorStatus.Visible = false;
			this.statusBarStatus.Text = "";
			this.toolStripGlobalCommandStopMultiCommands.Visible = false;
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00003C05 File Offset: 0x00001E05
		public void enableWhenHavingActiveSession()
		{
			this.toolStripMenuDisconnect.Enabled = true;
			this.toolStripGlobalCommand.Enabled = true;
			this.mnuFileCloseAllSessions.Enabled = true;
			this.displayStatusOfGlobalCommandSessions();
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00003C36 File Offset: 0x00001E36
		private void toolStripMenu_MouseEnter(object sender, EventArgs e)
		{
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00003C3C File Offset: 0x00001E3C
		private void dockPanelMain_ActiveDocumentChanged(object sender, EventArgs e)
		{
			try
			{
				frmPutty frmPutty = this.dockPanelMain.ActiveDocument as frmPutty;
				if (frmPutty != null)
				{
					this.displayStatus(frmPutty.getPuttyWindowTitle());
					frmMain.SetForegroundWindow(frmPutty.proc.MainWindowHandle);
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00003CA0 File Offset: 0x00001EA0
		private void mnuViewToolbarsStandard_Click(object sender, EventArgs e)
		{
			if (this.mnuViewToolbarsStandard.Checked)
			{
				this.toolStripMenu.Show();
			}
			else
			{
				this.toolStripMenu.Hide();
			}
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00003CDC File Offset: 0x00001EDC
		private void mnuViewToolbarsQuickConnection_Click(object sender, EventArgs e)
		{
			if (this.mnuViewToolbarsQuickConnection.Checked)
			{
				this.toolStripQuickConnect.Show();
			}
			else
			{
				this.toolStripQuickConnect.Hide();
			}
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00003D18 File Offset: 0x00001F18
		private void mnuViewToolbarsMSC_Click(object sender, EventArgs e)
		{
			if (this.mnuViewToolbarsMSC.Checked)
			{
				this.toolStripGlobalCommand.Show();
			}
			else
			{
				this.toolStripGlobalCommand.Hide();
			}
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00003D54 File Offset: 0x00001F54
		private void mnuViewToolbarsStatus_Click(object sender, EventArgs e)
		{
			if (this.mnuViewToolbarsStatus.Checked)
			{
				this.statusBar.Show();
			}
			else
			{
				this.statusBar.Hide();
			}
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00003D90 File Offset: 0x00001F90
		public void closeAllSessions()
		{
			DialogResult dialogResult = MessageBox.Show("Do you really want to close all sessions?", "Close all sessions", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (dialogResult == DialogResult.Yes)
			{
				try
				{
					while (this.dockPanelMain.Documents.Count<IDockContent>() > 0)
					{
						frmPutty frmPutty = this.dockPanelMain.Documents.ElementAt(0) as frmPutty;
						if (frmPutty != null)
						{
							frmPutty.Close();
						}
					}
				}
				catch (Exception ex)
				{
				}
			}
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00003E1C File Offset: 0x0000201C
		private void toolStripMenuDisconnect_Click(object sender, EventArgs e)
		{
			this.closeAllSessions();
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00003E28 File Offset: 0x00002028
		public void closeActiveSession()
		{
			frmPutty frmPutty = this.dockPanelMain.ActiveDocument as frmPutty;
			if (frmPutty != null)
			{
				frmPutty.Close();
			}
		}

		// Token: 0x0600004E RID: 78 RVA: 0x00003E58 File Offset: 0x00002058
		private void toolStripGlobalCommandCommand_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!(this.toolStripGlobalCommandCommand.Text.Trim() == ""))
			{
				if (e.KeyChar == '\r')
				{
					if (this.toolStripGlobalCommandCommand.Text.Trim() == "_mc")
					{
						new frmMultiCommands
						{
							runMultiCommands = new frmMultiCommands.RunMultiCommands(this.runMultiCommandsOnMultiSessions)
						}.ShowDialog();
					}
					else
					{
						this.runCommandOnMultiSessions(this.toolStripGlobalCommandCommand.Text);
						this.addHistoryGlobalCommand();
					}
				}
			}
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00003EFB File Offset: 0x000020FB
		private void contextCloseSession_Click(object sender, EventArgs e)
		{
			this.closeActiveSession();
		}

		// Token: 0x06000050 RID: 80 RVA: 0x00003F05 File Offset: 0x00002105
		private void mnuFileExit_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00003F10 File Offset: 0x00002110
		public void sendCommandFromPuttySystemMenu(uint command)
		{
			try
			{
				frmPutty frmPutty = this.dockPanelMain.ActiveDocument as frmPutty;
				if (frmPutty != null)
				{
					frmMain.PostMessage(frmPutty.proc.MainWindowHandle, 274u, new IntPtr((long)((ulong)command)), IntPtr.Zero);
					frmMain.SetForegroundWindow(frmPutty.proc.MainWindowHandle);
					if (command == 64u)
					{
						frmPutty.autoLoginAndRunCommands();
					}
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06000052 RID: 82 RVA: 0x00003F9C File Offset: 0x0000219C
		private void contextRestartSession_Click(object sender, EventArgs e)
		{
			this.sendCommandFromPuttySystemMenu(64u);
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00003FA8 File Offset: 0x000021A8
		private void contextChangeSettings_Click(object sender, EventArgs e)
		{
			this.sendCommandFromPuttySystemMenu(80u);
		}

		// Token: 0x06000054 RID: 84 RVA: 0x00003FB4 File Offset: 0x000021B4
		private void contextEventLog_Click(object sender, EventArgs e)
		{
			this.sendCommandFromPuttySystemMenu(16u);
		}

		// Token: 0x06000055 RID: 85 RVA: 0x00003FC0 File Offset: 0x000021C0
		private void contextCopyClipboard_Click(object sender, EventArgs e)
		{
			this.sendCommandFromPuttySystemMenu(368u);
		}

		// Token: 0x06000056 RID: 86 RVA: 0x00003FCF File Offset: 0x000021CF
		private void contextClearScollback_Click(object sender, EventArgs e)
		{
			this.sendCommandFromPuttySystemMenu(96u);
		}

		// Token: 0x06000057 RID: 87 RVA: 0x00003FDB File Offset: 0x000021DB
		private void contextResetTerminal_Click(object sender, EventArgs e)
		{
			this.sendCommandFromPuttySystemMenu(112u);
		}

		// Token: 0x06000058 RID: 88 RVA: 0x00003FE7 File Offset: 0x000021E7
		private void contextResetAndClear_Click(object sender, EventArgs e)
		{
			this.sendCommandFromPuttySystemMenu(112u);
			this.sendCommandFromPuttySystemMenu(96u);
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00003FFC File Offset: 0x000021FC
		private void toolStripMenuSaveDatabase_Click(object sender, EventArgs e)
		{
			this.fmSessionManager.saveAllDatabases();
		}

		// Token: 0x0600005A RID: 90 RVA: 0x0000400B File Offset: 0x0000220B
		private void mnuHelp_MouseEnter(object sender, EventArgs e)
		{
			this.mnuMain.Focus();
		}

		// Token: 0x0600005B RID: 91 RVA: 0x0000401A File Offset: 0x0000221A
		private void toolsToolStripMenuItem_MouseEnter(object sender, EventArgs e)
		{
			this.mnuMain.Focus();
		}

		// Token: 0x0600005C RID: 92 RVA: 0x00004029 File Offset: 0x00002229
		private void viewToolStripMenuItem_MouseEnter(object sender, EventArgs e)
		{
			this.mnuMain.Focus();
		}

		// Token: 0x0600005D RID: 93 RVA: 0x00004038 File Offset: 0x00002238
		private void fileToolStripMenuItem_MouseEnter(object sender, EventArgs e)
		{
			this.mnuMain.Focus();
		}

		// Token: 0x0600005E RID: 94 RVA: 0x00004048 File Offset: 0x00002248
		private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
		{
			Global.strQuickPuttyProtocol = this.toolStripQuickConnectProtocol.Text;
			if (this.toolStripQuickConnecSessionConfig.Text != Global.strQuickPuttySetting)
			{
				Global.strQuickPuttySetting = this.toolStripQuickConnecSessionConfig.Text;
			}
			Global.saveLatestQuickPuttySettingsToRegistry();
			this.getAndSaveDisplayedItems();
			this.fmSessionManager.Close();
		}

		// Token: 0x0600005F RID: 95 RVA: 0x000040AB File Offset: 0x000022AB
		private void toolStripMenuDisconnect_MouseEnter(object sender, EventArgs e)
		{
			this.toolStripMenu.Focus();
		}

		// Token: 0x06000060 RID: 96 RVA: 0x000040BA File Offset: 0x000022BA
		private void toolStripMenuNewDatabase_Click(object sender, EventArgs e)
		{
			this.fmSessionManager.createNewDatabase();
		}

		// Token: 0x06000061 RID: 97 RVA: 0x000040C9 File Offset: 0x000022C9
		private void toolStripMenuOpenDatabase_Click(object sender, EventArgs e)
		{
			this.fmSessionManager.openDatabase("dat");
		}

		// Token: 0x06000062 RID: 98 RVA: 0x000040DD File Offset: 0x000022DD
		private void toolStripMenuSaveDatabase_MouseEnter(object sender, EventArgs e)
		{
			this.toolStripMenu.Focus();
		}

		// Token: 0x06000063 RID: 99 RVA: 0x000040EC File Offset: 0x000022EC
		private void toolStripMenuOpenDatabase_MouseEnter(object sender, EventArgs e)
		{
			this.toolStripMenu.Focus();
		}

		// Token: 0x06000064 RID: 100 RVA: 0x000040FB File Offset: 0x000022FB
		private void toolStripMenuNewDatabase_MouseEnter(object sender, EventArgs e)
		{
			this.toolStripMenu.Focus();
		}

		// Token: 0x06000065 RID: 101 RVA: 0x0000410A File Offset: 0x0000230A
		private void mnuFileCloseAllSessions_Click(object sender, EventArgs e)
		{
			this.closeAllSessions();
		}

		// Token: 0x06000066 RID: 102 RVA: 0x00004114 File Offset: 0x00002314
		private void mnuFileNewDatabase_Click(object sender, EventArgs e)
		{
			this.fmSessionManager.createNewDatabase();
		}

		// Token: 0x06000067 RID: 103 RVA: 0x00004123 File Offset: 0x00002323
		private void mnuFileOpenDatabase_Click(object sender, EventArgs e)
		{
			this.fmSessionManager.openDatabase("dat");
		}

		// Token: 0x06000068 RID: 104 RVA: 0x00004137 File Offset: 0x00002337
		private void mnuSaveAllDatabases_Click(object sender, EventArgs e)
		{
			this.fmSessionManager.saveAllDatabases();
		}

		// Token: 0x06000069 RID: 105 RVA: 0x00004146 File Offset: 0x00002346
		private void mnufileImportDatabase_Click(object sender, EventArgs e)
		{
			this.fmSessionManager.openDatabase("xml");
		}

		// Token: 0x0600006A RID: 106 RVA: 0x0000415A File Offset: 0x0000235A
		private void toolStripMenuImportDatabase_Click(object sender, EventArgs e)
		{
			this.fmSessionManager.openDatabase("xml");
		}

		// Token: 0x0600006B RID: 107 RVA: 0x0000416E File Offset: 0x0000236E
		public void createDatabaseFromPuttySessions()
		{
			this.fmSessionManager.createDatabaseFromPuttySessions();
		}

		// Token: 0x0600006C RID: 108 RVA: 0x00004180 File Offset: 0x00002380
		private void mnuToolsPuTTYSessions_Click(object sender, EventArgs e)
		{
			new frmPuttySessions
			{
				createDatabaseFromPuttySessions = new frmPuttySessions.CreateDatabaseFromPuttySessions(this.createDatabaseFromPuttySessions)
			}.ShowDialog();
		}

		// Token: 0x0600006D RID: 109 RVA: 0x000041AD File Offset: 0x000023AD
		private void toolStripMenuImportDatabase_MouseEnter(object sender, EventArgs e)
		{
			this.toolStripMenu.Focus();
		}

		// Token: 0x0600006E RID: 110 RVA: 0x000041BC File Offset: 0x000023BC
		private void contextForDocPanel_Opening(object sender, CancelEventArgs e)
		{
			try
			{
				frmPutty frmPutty = this.dockPanelMain.ActiveDocument as frmPutty;
				if (frmPutty != null)
				{
					System.Threading.ThreadState multiCommandsThreadState = frmPutty.getMultiCommandsThreadState();
					if (multiCommandsThreadState == System.Threading.ThreadState.Stopped || multiCommandsThreadState == System.Threading.ThreadState.Aborted)
					{
						this.contextRunMultiCommands.Text = "Run Multi Commands";
					}
					else
					{
						this.contextRunMultiCommands.Text = "Stop Running Multi Commands";
					}
					if (frmPutty.getPuttyWindowTitle().Contains("(inactive"))
					{
						this.contextRestartSession.Visible = true;
					}
					else
					{
						this.contextRestartSession.Visible = false;
					}
					for (int i = 3; i < this.toolStripGlobalCommandSession.DropDownItems.Count; i++)
					{
						if (((ToolStripMenuItem)this.toolStripGlobalCommandSession.DropDownItems[i]).Name == frmPutty.Handle.ToString())
						{
							if (((ToolStripMenuItem)this.toolStripGlobalCommandSession.DropDownItems[i]).CheckState == CheckState.Checked)
							{
								this.contextAcceptGlobalCommand.Checked = true;
							}
							else
							{
								this.contextAcceptGlobalCommand.Checked = false;
							}
							break;
						}
					}
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x0600006F RID: 111 RVA: 0x00004338 File Offset: 0x00002538
		private void contextAcceptGlobalCommand_Click(object sender, EventArgs e)
		{
			try
			{
				frmPutty frmPutty = this.dockPanelMain.ActiveDocument as frmPutty;
				if (frmPutty != null)
				{
					for (int i = 3; i < this.toolStripGlobalCommandSession.DropDownItems.Count; i++)
					{
						if (((ToolStripMenuItem)this.toolStripGlobalCommandSession.DropDownItems[i]).Name == frmPutty.Handle.ToString())
						{
							if (this.contextAcceptGlobalCommand.Checked)
							{
								((ToolStripMenuItem)this.toolStripGlobalCommandSession.DropDownItems[i]).CheckState = CheckState.Checked;
							}
							else
							{
								((ToolStripMenuItem)this.toolStripGlobalCommandSession.DropDownItems[i]).CheckState = CheckState.Unchecked;
							}
							this.displayStatusOfGlobalCommandSessions();
							break;
						}
					}
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06000070 RID: 112 RVA: 0x0000443C File Offset: 0x0000263C
		private void contextRunMultiCommands_Click(object sender, EventArgs e)
		{
			try
			{
				if (this.contextRunMultiCommands.Text == "Run Multi Commands")
				{
					new frmMultiCommands
					{
						runMultiCommands = new frmMultiCommands.RunMultiCommands(this.runMultiCommandsOnActiveSession)
					}.ShowDialog();
				}
				else
				{
					frmPutty frmPutty = this.dockPanelMain.ActiveDocument as frmPutty;
					frmPutty.stopRunningMultiCommands();
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x04000001 RID: 1
		private const int MOUSEEVENTF_RIGHTDOWN = 8;

		// Token: 0x04000002 RID: 2
		private const int MOUSEEVENTF_RIGHTUP = 16;

		// Token: 0x04000003 RID: 3
		private const uint TPM_LEFTBUTTON = 0u;

		// Token: 0x04000004 RID: 4
		private const uint TPM_RETURNCMD = 256u;

		// Token: 0x04000005 RID: 5
		private const uint WM_SYSCOMMAND = 274u;

		// Token: 0x04000006 RID: 6
		private const uint PY_RESTARTSESSION = 64u;

		// Token: 0x04000007 RID: 7
		private const uint PY_EVENTLOG = 16u;

		// Token: 0x04000008 RID: 8
		private const uint PY_CHANGESETTING = 80u;

		// Token: 0x04000009 RID: 9
		private const uint PY_COPYCLIPBOARD = 368u;

		// Token: 0x0400000A RID: 10
		private const uint PY_CLEARSCROLLBACK = 96u;

		// Token: 0x0400000B RID: 11
		private const uint PY_RESETTERMINAL = 112u;

		// Token: 0x0400000C RID: 12
		private frmSessionManager fmSessionManager;

		// Token: 0x0400000D RID: 13
		private Thread multiCommandsThread;

		// Token: 0x0400000E RID: 14
		private KeyboardHook hook = new KeyboardHook();

		// Token: 0x0400000F RID: 15
		private bool formActivate = true;
	}
}
