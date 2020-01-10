namespace SessionManagement
{
	// Token: 0x02000002 RID: 2
	public partial class frmMain : global::System.Windows.Forms.Form
	{
		// Token: 0x06000071 RID: 113 RVA: 0x000044C0 File Offset: 0x000026C0
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000072 RID: 114 RVA: 0x000044F8 File Offset: 0x000026F8
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::SessionManagement.frmMain));
			global::WeifenLuo.WinFormsUI.Docking.DockPanelSkin dockPanelSkin = new global::WeifenLuo.WinFormsUI.Docking.DockPanelSkin();
			global::WeifenLuo.WinFormsUI.Docking.AutoHideStripSkin autoHideStripSkin = new global::WeifenLuo.WinFormsUI.Docking.AutoHideStripSkin();
			global::WeifenLuo.WinFormsUI.Docking.DockPanelGradient dockPanelGradient = new global::WeifenLuo.WinFormsUI.Docking.DockPanelGradient();
			global::WeifenLuo.WinFormsUI.Docking.TabGradient tabGradient = new global::WeifenLuo.WinFormsUI.Docking.TabGradient();
			global::WeifenLuo.WinFormsUI.Docking.DockPaneStripSkin dockPaneStripSkin = new global::WeifenLuo.WinFormsUI.Docking.DockPaneStripSkin();
			global::WeifenLuo.WinFormsUI.Docking.DockPaneStripGradient dockPaneStripGradient = new global::WeifenLuo.WinFormsUI.Docking.DockPaneStripGradient();
			global::WeifenLuo.WinFormsUI.Docking.TabGradient tabGradient2 = new global::WeifenLuo.WinFormsUI.Docking.TabGradient();
			global::WeifenLuo.WinFormsUI.Docking.DockPanelGradient dockPanelGradient2 = new global::WeifenLuo.WinFormsUI.Docking.DockPanelGradient();
			global::WeifenLuo.WinFormsUI.Docking.TabGradient tabGradient3 = new global::WeifenLuo.WinFormsUI.Docking.TabGradient();
			global::WeifenLuo.WinFormsUI.Docking.DockPaneStripToolWindowGradient dockPaneStripToolWindowGradient = new global::WeifenLuo.WinFormsUI.Docking.DockPaneStripToolWindowGradient();
			global::WeifenLuo.WinFormsUI.Docking.TabGradient tabGradient4 = new global::WeifenLuo.WinFormsUI.Docking.TabGradient();
			global::WeifenLuo.WinFormsUI.Docking.TabGradient tabGradient5 = new global::WeifenLuo.WinFormsUI.Docking.TabGradient();
			global::WeifenLuo.WinFormsUI.Docking.DockPanelGradient dockPanelGradient3 = new global::WeifenLuo.WinFormsUI.Docking.DockPanelGradient();
			global::WeifenLuo.WinFormsUI.Docking.TabGradient tabGradient6 = new global::WeifenLuo.WinFormsUI.Docking.TabGradient();
			global::WeifenLuo.WinFormsUI.Docking.TabGradient tabGradient7 = new global::WeifenLuo.WinFormsUI.Docking.TabGradient();
			this.contextForDocPanel = new global::System.Windows.Forms.ContextMenuStrip(this.components);
			this.contextDuplicateSession = new global::System.Windows.Forms.ToolStripMenuItem();
			this.contextRestartSession = new global::System.Windows.Forms.ToolStripMenuItem();
			this.contextRenameForDocPanel = new global::System.Windows.Forms.ToolStripMenuItem();
			this.contextChangeSettings = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator3 = new global::System.Windows.Forms.ToolStripSeparator();
			this.contextRunMultiCommands = new global::System.Windows.Forms.ToolStripMenuItem();
			this.contextAcceptGlobalCommand = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator9 = new global::System.Windows.Forms.ToolStripSeparator();
			this.contextEventLog = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator6 = new global::System.Windows.Forms.ToolStripSeparator();
			this.contextFTPExternal = new global::System.Windows.Forms.ToolStripMenuItem();
			this.contextSFTPExternal = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator7 = new global::System.Windows.Forms.ToolStripSeparator();
			this.contextCopyClipboard = new global::System.Windows.Forms.ToolStripMenuItem();
			this.contextClearScollback = new global::System.Windows.Forms.ToolStripMenuItem();
			this.contextResetTerminal = new global::System.Windows.Forms.ToolStripMenuItem();
			this.contextResetAndClear = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator8 = new global::System.Windows.Forms.ToolStripSeparator();
			this.contextCloseSession = new global::System.Windows.Forms.ToolStripMenuItem();
			this.mnuMain = new global::System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.mnuFileNewDatabase = new global::System.Windows.Forms.ToolStripMenuItem();
			this.mnuFileOpenDatabase = new global::System.Windows.Forms.ToolStripMenuItem();
			this.mnuSaveAllDatabases = new global::System.Windows.Forms.ToolStripMenuItem();
			this.mnufileImportDatabase = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator11 = new global::System.Windows.Forms.ToolStripSeparator();
			this.mnuFileCloseAllSessions = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator10 = new global::System.Windows.Forms.ToolStripSeparator();
			this.mnuFileExit = new global::System.Windows.Forms.ToolStripMenuItem();
			this.viewToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.mnuViewToolbars = new global::System.Windows.Forms.ToolStripMenuItem();
			this.mnuViewToolbarsStandard = new global::System.Windows.Forms.ToolStripMenuItem();
			this.mnuViewToolbarsQuickConnection = new global::System.Windows.Forms.ToolStripMenuItem();
			this.mnuViewToolbarsMSC = new global::System.Windows.Forms.ToolStripMenuItem();
			this.mnuViewToolbarsStatus = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator5 = new global::System.Windows.Forms.ToolStripSeparator();
			this.mnuViewSessionManager = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolsToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.mnuToolsPuTTYSessions = new global::System.Windows.Forms.ToolStripMenuItem();
			this.mnuToolsPuttyConfiguration = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new global::System.Windows.Forms.ToolStripSeparator();
			this.mnuToolsOption = new global::System.Windows.Forms.ToolStripMenuItem();
			this.mnuHelp = new global::System.Windows.Forms.ToolStripMenuItem();
			this.mnuHelpHelp = new global::System.Windows.Forms.ToolStripMenuItem();
			this.mnuHelpHomepage = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator4 = new global::System.Windows.Forms.ToolStripSeparator();
			this.mnuHelpAbout = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripGlobalCommand = new global::System.Windows.Forms.ToolStrip();
			this.toolStripLabel7 = new global::System.Windows.Forms.ToolStripLabel();
			this.toolStripGlobalCommandCommand = new global::System.Windows.Forms.ToolStripComboBox();
			this.toolStripGlobalCommandSession = new global::System.Windows.Forms.ToolStripSplitButton();
			this.toolStripCheckAll = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripUncheckAll = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new global::System.Windows.Forms.ToolStripSeparator();
			this.toolStripGlobalCommandRun = new global::System.Windows.Forms.ToolStripButton();
			this.toolStripSeparatorStatus = new global::System.Windows.Forms.ToolStripSeparator();
			this.toolStripGlobalCommandStatus = new global::System.Windows.Forms.ToolStripLabel();
			this.toolStripGlobalCommandStopMultiCommands = new global::System.Windows.Forms.ToolStripButton();
			this.toolStripQuickConnect = new global::System.Windows.Forms.ToolStrip();
			this.toolStripLabel2 = new global::System.Windows.Forms.ToolStripLabel();
			this.toolStripQuickConnectProtocol = new global::System.Windows.Forms.ToolStripComboBox();
			this.toolStripLabel3 = new global::System.Windows.Forms.ToolStripLabel();
			this.toolStripQuickConnectHost = new global::System.Windows.Forms.ToolStripComboBox();
			this.toolStripLabel4 = new global::System.Windows.Forms.ToolStripLabel();
			this.toolStripQuickConnetUserName = new global::System.Windows.Forms.ToolStripTextBox();
			this.toolStripLabel5 = new global::System.Windows.Forms.ToolStripLabel();
			this.toolStripQuickConnectPassword = new global::System.Windows.Forms.ToolStripTextBox();
			this.toolStripLabel6 = new global::System.Windows.Forms.ToolStripLabel();
			this.toolStripQuickConnecSessionConfig = new global::System.Windows.Forms.ToolStripComboBox();
			this.toolStripQuickConnectConnect = new global::System.Windows.Forms.ToolStripButton();
			this.toolStripMenu = new global::System.Windows.Forms.ToolStrip();
			this.toolStripMenuNewDatabase = new global::System.Windows.Forms.ToolStripButton();
			this.toolStripMenuOpenDatabase = new global::System.Windows.Forms.ToolStripButton();
			this.toolStripMenuSaveDatabase = new global::System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator = new global::System.Windows.Forms.ToolStripSeparator();
			this.toolStripMenuImportDatabase = new global::System.Windows.Forms.ToolStripButton();
			this.toolStripMenuDisconnect = new global::System.Windows.Forms.ToolStripButton();
			this.statusBar = new global::System.Windows.Forms.StatusStrip();
			this.statusBarStatus = new global::System.Windows.Forms.ToolStripStatusLabel();
			this.dockPanelMain = new global::WeifenLuo.WinFormsUI.Docking.DockPanel();
			this.contextForDocPanel.SuspendLayout();
			this.mnuMain.SuspendLayout();
			this.toolStripGlobalCommand.SuspendLayout();
			this.toolStripQuickConnect.SuspendLayout();
			this.toolStripMenu.SuspendLayout();
			this.statusBar.SuspendLayout();
			base.SuspendLayout();
			this.contextForDocPanel.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.contextForDocPanel.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.contextDuplicateSession,
				this.contextRestartSession,
				this.contextRenameForDocPanel,
				this.contextChangeSettings,
				this.toolStripSeparator3,
				this.contextRunMultiCommands,
				this.contextAcceptGlobalCommand,
				this.toolStripSeparator9,
				this.contextEventLog,
				this.toolStripSeparator6,
				this.contextFTPExternal,
				this.contextSFTPExternal,
				this.toolStripSeparator7,
				this.contextCopyClipboard,
				this.contextClearScollback,
				this.contextResetTerminal,
				this.contextResetAndClear,
				this.toolStripSeparator8,
				this.contextCloseSession
			});
			this.contextForDocPanel.Name = "contextForDocPanel";
			this.contextForDocPanel.Size = new global::System.Drawing.Size(263, 342);
			this.contextForDocPanel.Opening += new global::System.ComponentModel.CancelEventHandler(this.contextForDocPanel_Opening);
			this.contextDuplicateSession.Name = "contextDuplicateSession";
			this.contextDuplicateSession.Size = new global::System.Drawing.Size(262, 22);
			this.contextDuplicateSession.Text = "Clone Session";
			this.contextDuplicateSession.Click += new global::System.EventHandler(this.contextDuplicateSession_Click);
			this.contextRestartSession.Name = "contextRestartSession";
			this.contextRestartSession.Size = new global::System.Drawing.Size(262, 22);
			this.contextRestartSession.Text = "Restart Session";
			this.contextRestartSession.Click += new global::System.EventHandler(this.contextRestartSession_Click);
			this.contextRenameForDocPanel.Name = "contextRenameForDocPanel";
			this.contextRenameForDocPanel.Size = new global::System.Drawing.Size(262, 22);
			this.contextRenameForDocPanel.Text = "Rename Tab";
			this.contextRenameForDocPanel.Click += new global::System.EventHandler(this.contextRenameForDocPanel_Click);
			this.contextChangeSettings.Name = "contextChangeSettings";
			this.contextChangeSettings.Size = new global::System.Drawing.Size(262, 22);
			this.contextChangeSettings.Text = "Change Settings...";
			this.contextChangeSettings.Click += new global::System.EventHandler(this.contextChangeSettings_Click);
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new global::System.Drawing.Size(259, 6);
			this.contextRunMultiCommands.Name = "contextRunMultiCommands";
			this.contextRunMultiCommands.Size = new global::System.Drawing.Size(262, 22);
			this.contextRunMultiCommands.Text = "Run Multi Commands";
			this.contextRunMultiCommands.Click += new global::System.EventHandler(this.contextRunMultiCommands_Click);
			this.contextAcceptGlobalCommand.CheckOnClick = true;
			this.contextAcceptGlobalCommand.Name = "contextAcceptGlobalCommand";
			this.contextAcceptGlobalCommand.Size = new global::System.Drawing.Size(262, 22);
			this.contextAcceptGlobalCommand.Text = "Accept Multi Sessions Command";
			this.contextAcceptGlobalCommand.Click += new global::System.EventHandler(this.contextAcceptGlobalCommand_Click);
			this.toolStripSeparator9.Name = "toolStripSeparator9";
			this.toolStripSeparator9.Size = new global::System.Drawing.Size(259, 6);
			this.contextEventLog.Name = "contextEventLog";
			this.contextEventLog.Size = new global::System.Drawing.Size(262, 22);
			this.contextEventLog.Text = "PuTTY Event Log";
			this.contextEventLog.Click += new global::System.EventHandler(this.contextEventLog_Click);
			this.toolStripSeparator6.Name = "toolStripSeparator6";
			this.toolStripSeparator6.Size = new global::System.Drawing.Size(259, 6);
			this.contextFTPExternal.Name = "contextFTPExternal";
			this.contextFTPExternal.Size = new global::System.Drawing.Size(262, 22);
			this.contextFTPExternal.Text = "FTP Using WinSCP";
			this.contextFTPExternal.Click += new global::System.EventHandler(this.contextFTPExternal_Click);
			this.contextSFTPExternal.Name = "contextSFTPExternal";
			this.contextSFTPExternal.Size = new global::System.Drawing.Size(262, 22);
			this.contextSFTPExternal.Text = "SFTP Using WinSCP";
			this.contextSFTPExternal.Click += new global::System.EventHandler(this.contextSFTPExternal_Click);
			this.toolStripSeparator7.Name = "toolStripSeparator7";
			this.toolStripSeparator7.Size = new global::System.Drawing.Size(259, 6);
			this.contextCopyClipboard.Name = "contextCopyClipboard";
			this.contextCopyClipboard.Size = new global::System.Drawing.Size(262, 22);
			this.contextCopyClipboard.Text = "Copy All to Clipboard";
			this.contextCopyClipboard.Click += new global::System.EventHandler(this.contextCopyClipboard_Click);
			this.contextClearScollback.Name = "contextClearScollback";
			this.contextClearScollback.Size = new global::System.Drawing.Size(262, 22);
			this.contextClearScollback.Text = "Clear Scrollback";
			this.contextClearScollback.Click += new global::System.EventHandler(this.contextClearScollback_Click);
			this.contextResetTerminal.Name = "contextResetTerminal";
			this.contextResetTerminal.Size = new global::System.Drawing.Size(262, 22);
			this.contextResetTerminal.Text = "Reset Terminal";
			this.contextResetTerminal.Click += new global::System.EventHandler(this.contextResetTerminal_Click);
			this.contextResetAndClear.Name = "contextResetAndClear";
			this.contextResetAndClear.Size = new global::System.Drawing.Size(262, 22);
			this.contextResetAndClear.Text = "Reset Terminal and Clear Scrollback";
			this.contextResetAndClear.Click += new global::System.EventHandler(this.contextResetAndClear_Click);
			this.toolStripSeparator8.Name = "toolStripSeparator8";
			this.toolStripSeparator8.Size = new global::System.Drawing.Size(259, 6);
			this.contextCloseSession.Name = "contextCloseSession";
			this.contextCloseSession.Size = new global::System.Drawing.Size(262, 22);
			this.contextCloseSession.Text = "&Close";
			this.contextCloseSession.Click += new global::System.EventHandler(this.contextCloseSession_Click);
			this.mnuMain.BackColor = global::System.Drawing.SystemColors.Control;
			this.mnuMain.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.mnuMain.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.fileToolStripMenuItem,
				this.viewToolStripMenuItem,
				this.toolsToolStripMenuItem,
				this.mnuHelp
			});
			this.mnuMain.Location = new global::System.Drawing.Point(0, 0);
			this.mnuMain.Name = "mnuMain";
			this.mnuMain.Padding = new global::System.Windows.Forms.Padding(9, 3, 0, 3);
			this.mnuMain.Size = new global::System.Drawing.Size(967, 25);
			this.mnuMain.TabIndex = 7;
			this.fileToolStripMenuItem.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.mnuFileNewDatabase,
				this.mnuFileOpenDatabase,
				this.mnuSaveAllDatabases,
				this.mnufileImportDatabase,
				this.toolStripSeparator11,
				this.mnuFileCloseAllSessions,
				this.toolStripSeparator10,
				this.mnuFileExit
			});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new global::System.Drawing.Size(37, 19);
			this.fileToolStripMenuItem.Text = "File";
			this.fileToolStripMenuItem.MouseEnter += new global::System.EventHandler(this.fileToolStripMenuItem_MouseEnter);
			this.mnuFileNewDatabase.Name = "mnuFileNewDatabase";
			this.mnuFileNewDatabase.Size = new global::System.Drawing.Size(235, 22);
			this.mnuFileNewDatabase.Text = "New database";
			this.mnuFileNewDatabase.Click += new global::System.EventHandler(this.mnuFileNewDatabase_Click);
			this.mnuFileOpenDatabase.Name = "mnuFileOpenDatabase";
			this.mnuFileOpenDatabase.Size = new global::System.Drawing.Size(235, 22);
			this.mnuFileOpenDatabase.Text = "Open database";
			this.mnuFileOpenDatabase.Click += new global::System.EventHandler(this.mnuFileOpenDatabase_Click);
			this.mnuSaveAllDatabases.Name = "mnuSaveAllDatabases";
			this.mnuSaveAllDatabases.Size = new global::System.Drawing.Size(235, 22);
			this.mnuSaveAllDatabases.Text = "Save all databases";
			this.mnuSaveAllDatabases.Click += new global::System.EventHandler(this.mnuSaveAllDatabases_Click);
			this.mnufileImportDatabase.Name = "mnufileImportDatabase";
			this.mnufileImportDatabase.Size = new global::System.Drawing.Size(235, 22);
			this.mnufileImportDatabase.Text = "Import database from XML file";
			this.mnufileImportDatabase.Click += new global::System.EventHandler(this.mnufileImportDatabase_Click);
			this.toolStripSeparator11.Name = "toolStripSeparator11";
			this.toolStripSeparator11.Size = new global::System.Drawing.Size(232, 6);
			this.mnuFileCloseAllSessions.Name = "mnuFileCloseAllSessions";
			this.mnuFileCloseAllSessions.Size = new global::System.Drawing.Size(235, 22);
			this.mnuFileCloseAllSessions.Text = "Close all sessions";
			this.mnuFileCloseAllSessions.Click += new global::System.EventHandler(this.mnuFileCloseAllSessions_Click);
			this.toolStripSeparator10.Name = "toolStripSeparator10";
			this.toolStripSeparator10.Size = new global::System.Drawing.Size(232, 6);
			this.mnuFileExit.Name = "mnuFileExit";
			this.mnuFileExit.Size = new global::System.Drawing.Size(235, 22);
			this.mnuFileExit.Text = "Exit";
			this.mnuFileExit.Click += new global::System.EventHandler(this.mnuFileExit_Click);
			this.viewToolStripMenuItem.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.mnuViewToolbars,
				this.toolStripSeparator5,
				this.mnuViewSessionManager
			});
			this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
			this.viewToolStripMenuItem.Size = new global::System.Drawing.Size(44, 19);
			this.viewToolStripMenuItem.Text = "View";
			this.viewToolStripMenuItem.MouseEnter += new global::System.EventHandler(this.viewToolStripMenuItem_MouseEnter);
			this.mnuViewToolbars.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.mnuViewToolbarsStandard,
				this.mnuViewToolbarsQuickConnection,
				this.mnuViewToolbarsMSC,
				this.mnuViewToolbarsStatus
			});
			this.mnuViewToolbars.Name = "mnuViewToolbars";
			this.mnuViewToolbars.Size = new global::System.Drawing.Size(168, 22);
			this.mnuViewToolbars.Text = "Toolbars";
			this.mnuViewToolbarsStandard.Checked = true;
			this.mnuViewToolbarsStandard.CheckOnClick = true;
			this.mnuViewToolbarsStandard.CheckState = global::System.Windows.Forms.CheckState.Checked;
			this.mnuViewToolbarsStandard.Name = "mnuViewToolbarsStandard";
			this.mnuViewToolbarsStandard.Size = new global::System.Drawing.Size(209, 22);
			this.mnuViewToolbarsStandard.Text = "Standard";
			this.mnuViewToolbarsStandard.Click += new global::System.EventHandler(this.mnuViewToolbarsStandard_Click);
			this.mnuViewToolbarsQuickConnection.Checked = true;
			this.mnuViewToolbarsQuickConnection.CheckOnClick = true;
			this.mnuViewToolbarsQuickConnection.CheckState = global::System.Windows.Forms.CheckState.Checked;
			this.mnuViewToolbarsQuickConnection.Name = "mnuViewToolbarsQuickConnection";
			this.mnuViewToolbarsQuickConnection.Size = new global::System.Drawing.Size(209, 22);
			this.mnuViewToolbarsQuickConnection.Text = "Quick Session";
			this.mnuViewToolbarsQuickConnection.Click += new global::System.EventHandler(this.mnuViewToolbarsQuickConnection_Click);
			this.mnuViewToolbarsMSC.Checked = true;
			this.mnuViewToolbarsMSC.CheckOnClick = true;
			this.mnuViewToolbarsMSC.CheckState = global::System.Windows.Forms.CheckState.Checked;
			this.mnuViewToolbarsMSC.Name = "mnuViewToolbarsMSC";
			this.mnuViewToolbarsMSC.Size = new global::System.Drawing.Size(209, 22);
			this.mnuViewToolbarsMSC.Text = "Multi Sessions Command";
			this.mnuViewToolbarsMSC.Click += new global::System.EventHandler(this.mnuViewToolbarsMSC_Click);
			this.mnuViewToolbarsStatus.Checked = true;
			this.mnuViewToolbarsStatus.CheckOnClick = true;
			this.mnuViewToolbarsStatus.CheckState = global::System.Windows.Forms.CheckState.Checked;
			this.mnuViewToolbarsStatus.Name = "mnuViewToolbarsStatus";
			this.mnuViewToolbarsStatus.Size = new global::System.Drawing.Size(209, 22);
			this.mnuViewToolbarsStatus.Text = "Status";
			this.mnuViewToolbarsStatus.Visible = false;
			this.mnuViewToolbarsStatus.Click += new global::System.EventHandler(this.mnuViewToolbarsStatus_Click);
			this.toolStripSeparator5.Name = "toolStripSeparator5";
			this.toolStripSeparator5.Size = new global::System.Drawing.Size(165, 6);
			this.mnuViewSessionManager.Checked = true;
			this.mnuViewSessionManager.CheckOnClick = true;
			this.mnuViewSessionManager.CheckState = global::System.Windows.Forms.CheckState.Checked;
			this.mnuViewSessionManager.Name = "mnuViewSessionManager";
			this.mnuViewSessionManager.Size = new global::System.Drawing.Size(168, 22);
			this.mnuViewSessionManager.Text = "Sessions Manager";
			this.mnuViewSessionManager.Click += new global::System.EventHandler(this.mnuViewSessionManager_Click);
			this.toolsToolStripMenuItem.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.mnuToolsPuTTYSessions,
				this.mnuToolsPuttyConfiguration,
				this.toolStripSeparator1,
				this.mnuToolsOption
			});
			this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
			this.toolsToolStripMenuItem.Size = new global::System.Drawing.Size(48, 19);
			this.toolsToolStripMenuItem.Text = "Tools";
			this.toolsToolStripMenuItem.MouseEnter += new global::System.EventHandler(this.toolsToolStripMenuItem_MouseEnter);
			this.mnuToolsPuTTYSessions.Name = "mnuToolsPuTTYSessions";
			this.mnuToolsPuTTYSessions.Size = new global::System.Drawing.Size(186, 22);
			this.mnuToolsPuTTYSessions.Text = "PuTTY Sessions";
			this.mnuToolsPuTTYSessions.Click += new global::System.EventHandler(this.mnuToolsPuTTYSessions_Click);
			this.mnuToolsPuttyConfiguration.Name = "mnuToolsPuttyConfiguration";
			this.mnuToolsPuttyConfiguration.Size = new global::System.Drawing.Size(186, 22);
			this.mnuToolsPuttyConfiguration.Text = "PuTTY Configuration";
			this.mnuToolsPuttyConfiguration.Click += new global::System.EventHandler(this.mnuToolPuttyConfiguration_Click);
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new global::System.Drawing.Size(183, 6);
			this.mnuToolsOption.Name = "mnuToolsOption";
			this.mnuToolsOption.Size = new global::System.Drawing.Size(186, 22);
			this.mnuToolsOption.Text = "Options...";
			this.mnuToolsOption.Click += new global::System.EventHandler(this.mnuToolsOption_Click);
			this.mnuHelp.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.mnuHelpHelp,
				this.mnuHelpHomepage,
				this.toolStripSeparator4,
				this.mnuHelpAbout
			});
			this.mnuHelp.Name = "mnuHelp";
			this.mnuHelp.Size = new global::System.Drawing.Size(44, 19);
			this.mnuHelp.Text = "Help";
			this.mnuHelp.MouseEnter += new global::System.EventHandler(this.mnuHelp_MouseEnter);
			this.mnuHelpHelp.Name = "mnuHelpHelp";
			this.mnuHelpHelp.Size = new global::System.Drawing.Size(133, 22);
			this.mnuHelpHelp.Text = "Help";
			this.mnuHelpHelp.Click += new global::System.EventHandler(this.mnuHelpHelp_Click);
			this.mnuHelpHomepage.Name = "mnuHelpHomepage";
			this.mnuHelpHomepage.Size = new global::System.Drawing.Size(133, 22);
			this.mnuHelpHomepage.Text = "Homepage";
			this.mnuHelpHomepage.Click += new global::System.EventHandler(this.mnuHelpHomepage_Click);
			this.toolStripSeparator4.Name = "toolStripSeparator4";
			this.toolStripSeparator4.Size = new global::System.Drawing.Size(130, 6);
			this.mnuHelpAbout.Name = "mnuHelpAbout";
			this.mnuHelpAbout.Size = new global::System.Drawing.Size(133, 22);
			this.mnuHelpAbout.Text = "About...";
			this.mnuHelpAbout.Click += new global::System.EventHandler(this.mnuHelpAbout_Click);
			this.toolStripGlobalCommand.BackColor = global::System.Drawing.SystemColors.Control;
			this.toolStripGlobalCommand.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.toolStripGlobalCommand.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.toolStripLabel7,
				this.toolStripGlobalCommandCommand,
				this.toolStripGlobalCommandSession,
				this.toolStripGlobalCommandRun,
				this.toolStripSeparatorStatus,
				this.toolStripGlobalCommandStatus,
				this.toolStripGlobalCommandStopMultiCommands
			});
			this.toolStripGlobalCommand.Location = new global::System.Drawing.Point(0, 79);
			this.toolStripGlobalCommand.Name = "toolStripGlobalCommand";
			this.toolStripGlobalCommand.Size = new global::System.Drawing.Size(967, 29);
			this.toolStripGlobalCommand.TabIndex = 16;
			this.toolStripGlobalCommand.Text = "toolStrip1";
			this.toolStripLabel7.Name = "toolStripLabel7";
			this.toolStripLabel7.Size = new global::System.Drawing.Size(142, 26);
			this.toolStripLabel7.Text = "Multi Sessions Command";
			this.toolStripGlobalCommandCommand.Name = "toolStripGlobalCommandCommand";
			this.toolStripGlobalCommandCommand.Size = new global::System.Drawing.Size(400, 29);
			this.toolStripGlobalCommandCommand.KeyPress += new global::System.Windows.Forms.KeyPressEventHandler(this.toolStripGlobalCommandCommand_KeyPress);
			this.toolStripGlobalCommandCommand.MouseEnter += new global::System.EventHandler(this.toolStripGlobalCommandCommand_MouseEnter);
			this.toolStripGlobalCommandSession.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.None;
			this.toolStripGlobalCommandSession.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.toolStripCheckAll,
				this.toolStripUncheckAll,
				this.toolStripSeparator2
			});
			this.toolStripGlobalCommandSession.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.toolStripGlobalCommandSession.Name = "toolStripGlobalCommandSession";
			this.toolStripGlobalCommandSession.Size = new global::System.Drawing.Size(67, 26);
			this.toolStripGlobalCommandSession.Text = "Sessions";
			this.toolStripGlobalCommandSession.ButtonClick += new global::System.EventHandler(this.toolStripGlobalCommandSession_ButtonClick);
			this.toolStripGlobalCommandSession.MouseEnter += new global::System.EventHandler(this.toolStripGlobalCommandSession_MouseEnter);
			this.toolStripCheckAll.Name = "toolStripCheckAll";
			this.toolStripCheckAll.Size = new global::System.Drawing.Size(135, 22);
			this.toolStripCheckAll.Text = "All Sessions";
			this.toolStripCheckAll.Click += new global::System.EventHandler(this.toolStripCheckAll_Click);
			this.toolStripUncheckAll.Name = "toolStripUncheckAll";
			this.toolStripUncheckAll.Size = new global::System.Drawing.Size(135, 22);
			this.toolStripUncheckAll.Text = "None";
			this.toolStripUncheckAll.Click += new global::System.EventHandler(this.toolStripUncheckAll_Click);
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new global::System.Drawing.Size(132, 6);
			this.toolStripGlobalCommandRun.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripGlobalCommandRun.Image = global::SessionManagement.Properties.Resources.Go1;
			this.toolStripGlobalCommandRun.ImageScaling = global::System.Windows.Forms.ToolStripItemImageScaling.None;
			this.toolStripGlobalCommandRun.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.toolStripGlobalCommandRun.Name = "toolStripGlobalCommandRun";
			this.toolStripGlobalCommandRun.Size = new global::System.Drawing.Size(27, 26);
			this.toolStripGlobalCommandRun.ToolTipText = "Run Command";
			this.toolStripGlobalCommandRun.Click += new global::System.EventHandler(this.toolStripGlobalCommandRun_Click);
			this.toolStripGlobalCommandRun.MouseEnter += new global::System.EventHandler(this.toolStripGlobalCommandRun_MouseEnter);
			this.toolStripSeparatorStatus.Name = "toolStripSeparatorStatus";
			this.toolStripSeparatorStatus.Size = new global::System.Drawing.Size(6, 29);
			this.toolStripGlobalCommandStatus.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.toolStripGlobalCommandStatus.Name = "toolStripGlobalCommandStatus";
			this.toolStripGlobalCommandStatus.Size = new global::System.Drawing.Size(39, 26);
			this.toolStripGlobalCommandStatus.Text = "Status";
			this.toolStripGlobalCommandStopMultiCommands.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("toolStripGlobalCommandStopMultiCommands.Image");
			this.toolStripGlobalCommandStopMultiCommands.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.toolStripGlobalCommandStopMultiCommands.Name = "toolStripGlobalCommandStopMultiCommands";
			this.toolStripGlobalCommandStopMultiCommands.Size = new global::System.Drawing.Size(147, 26);
			this.toolStripGlobalCommandStopMultiCommands.Text = "Stop Multi Commands";
			this.toolStripGlobalCommandStopMultiCommands.Click += new global::System.EventHandler(this.toolStripGlobalCommandStopMultiCommands_Click);
			this.toolStripGlobalCommandStopMultiCommands.MouseEnter += new global::System.EventHandler(this.toolStripGlobalCommandStopMultiCommands_MouseEnter);
			this.toolStripQuickConnect.BackColor = global::System.Drawing.SystemColors.Control;
			this.toolStripQuickConnect.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.toolStripQuickConnect.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.toolStripLabel2,
				this.toolStripQuickConnectProtocol,
				this.toolStripLabel3,
				this.toolStripQuickConnectHost,
				this.toolStripLabel4,
				this.toolStripQuickConnetUserName,
				this.toolStripLabel5,
				this.toolStripQuickConnectPassword,
				this.toolStripLabel6,
				this.toolStripQuickConnecSessionConfig,
				this.toolStripQuickConnectConnect
			});
			this.toolStripQuickConnect.LayoutStyle = global::System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
			this.toolStripQuickConnect.Location = new global::System.Drawing.Point(0, 50);
			this.toolStripQuickConnect.Name = "toolStripQuickConnect";
			this.toolStripQuickConnect.Size = new global::System.Drawing.Size(967, 29);
			this.toolStripQuickConnect.TabIndex = 15;
			this.toolStripQuickConnect.Text = "toolStrip1";
			this.toolStripLabel2.Name = "toolStripLabel2";
			this.toolStripLabel2.Size = new global::System.Drawing.Size(52, 26);
			this.toolStripLabel2.Text = "Protocol";
			this.toolStripQuickConnectProtocol.BackColor = global::System.Drawing.SystemColors.Window;
			this.toolStripQuickConnectProtocol.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.toolStripQuickConnectProtocol.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.toolStripQuickConnectProtocol.Items.AddRange(new object[]
			{
				"Telnet",
				"SSH",
				"Raw",
				"RLogin"
			});
			this.toolStripQuickConnectProtocol.Name = "toolStripQuickConnectProtocol";
			this.toolStripQuickConnectProtocol.Size = new global::System.Drawing.Size(80, 29);
			this.toolStripLabel3.Name = "toolStripLabel3";
			this.toolStripLabel3.Size = new global::System.Drawing.Size(32, 26);
			this.toolStripLabel3.Text = "Host";
			this.toolStripQuickConnectHost.Name = "toolStripQuickConnectHost";
			this.toolStripQuickConnectHost.Size = new global::System.Drawing.Size(140, 29);
			this.toolStripQuickConnectHost.KeyPress += new global::System.Windows.Forms.KeyPressEventHandler(this.toolStripQuickConnectHost_KeyPress);
			this.toolStripQuickConnectHost.MouseEnter += new global::System.EventHandler(this.toolStripQuickConnectHost_MouseEnter);
			this.toolStripLabel4.Name = "toolStripLabel4";
			this.toolStripLabel4.Size = new global::System.Drawing.Size(51, 26);
			this.toolStripLabel4.Text = "Login as";
			this.toolStripQuickConnetUserName.BackColor = global::System.Drawing.SystemColors.Window;
			this.toolStripQuickConnetUserName.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.toolStripQuickConnetUserName.Name = "toolStripQuickConnetUserName";
			this.toolStripQuickConnetUserName.Size = new global::System.Drawing.Size(100, 29);
			this.toolStripQuickConnetUserName.KeyPress += new global::System.Windows.Forms.KeyPressEventHandler(this.toolStripQuickConnetUserName_KeyPress);
			this.toolStripLabel5.Name = "toolStripLabel5";
			this.toolStripLabel5.Size = new global::System.Drawing.Size(57, 26);
			this.toolStripLabel5.Text = "Password";
			this.toolStripQuickConnectPassword.BackColor = global::System.Drawing.SystemColors.Window;
			this.toolStripQuickConnectPassword.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.toolStripQuickConnectPassword.Name = "toolStripQuickConnectPassword";
			this.toolStripQuickConnectPassword.Size = new global::System.Drawing.Size(100, 29);
			this.toolStripQuickConnectPassword.KeyPress += new global::System.Windows.Forms.KeyPressEventHandler(this.toolStripQuickConnectPassword_KeyPress);
			this.toolStripLabel6.Name = "toolStripLabel6";
			this.toolStripLabel6.Size = new global::System.Drawing.Size(82, 26);
			this.toolStripLabel6.Text = "PuTTY Setting";
			this.toolStripQuickConnecSessionConfig.BackColor = global::System.Drawing.SystemColors.Window;
			this.toolStripQuickConnecSessionConfig.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.toolStripQuickConnecSessionConfig.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.toolStripQuickConnecSessionConfig.Items.AddRange(new object[]
			{
				"Default Settings"
			});
			this.toolStripQuickConnecSessionConfig.MaxDropDownItems = 100;
			this.toolStripQuickConnecSessionConfig.Name = "toolStripQuickConnecSessionConfig";
			this.toolStripQuickConnecSessionConfig.Size = new global::System.Drawing.Size(121, 29);
			this.toolStripQuickConnectConnect.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripQuickConnectConnect.Image = global::SessionManagement.Properties.Resources.Go1;
			this.toolStripQuickConnectConnect.ImageScaling = global::System.Windows.Forms.ToolStripItemImageScaling.None;
			this.toolStripQuickConnectConnect.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.toolStripQuickConnectConnect.Name = "toolStripQuickConnectConnect";
			this.toolStripQuickConnectConnect.Size = new global::System.Drawing.Size(27, 26);
			this.toolStripQuickConnectConnect.ToolTipText = "Open Session";
			this.toolStripQuickConnectConnect.Click += new global::System.EventHandler(this.toolStripQuickConnectConnect_Click);
			this.toolStripQuickConnectConnect.MouseEnter += new global::System.EventHandler(this.toolStripQuickConnectConnect_MouseEnter);
			this.toolStripMenu.BackColor = global::System.Drawing.SystemColors.Control;
			this.toolStripMenu.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.toolStripMenu.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.toolStripMenuNewDatabase,
				this.toolStripMenuOpenDatabase,
				this.toolStripMenuSaveDatabase,
				this.toolStripSeparator,
				this.toolStripMenuImportDatabase,
				this.toolStripMenuDisconnect
			});
			this.toolStripMenu.Location = new global::System.Drawing.Point(0, 25);
			this.toolStripMenu.Name = "toolStripMenu";
			this.toolStripMenu.Size = new global::System.Drawing.Size(967, 25);
			this.toolStripMenu.TabIndex = 14;
			this.toolStripMenu.Text = "Standard";
			this.toolStripMenu.MouseEnter += new global::System.EventHandler(this.toolStripMenu_MouseEnter);
			this.toolStripMenuNewDatabase.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripMenuNewDatabase.Image = global::SessionManagement.Properties.Resources.Database;
			this.toolStripMenuNewDatabase.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.toolStripMenuNewDatabase.Name = "toolStripMenuNewDatabase";
			this.toolStripMenuNewDatabase.Size = new global::System.Drawing.Size(23, 22);
			this.toolStripMenuNewDatabase.Text = "&New";
			this.toolStripMenuNewDatabase.ToolTipText = "Create new database";
			this.toolStripMenuNewDatabase.Click += new global::System.EventHandler(this.toolStripMenuNewDatabase_Click);
			this.toolStripMenuNewDatabase.MouseEnter += new global::System.EventHandler(this.toolStripMenuNewDatabase_MouseEnter);
			this.toolStripMenuOpenDatabase.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripMenuOpenDatabase.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("toolStripMenuOpenDatabase.Image");
			this.toolStripMenuOpenDatabase.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.toolStripMenuOpenDatabase.Name = "toolStripMenuOpenDatabase";
			this.toolStripMenuOpenDatabase.Size = new global::System.Drawing.Size(23, 22);
			this.toolStripMenuOpenDatabase.Text = "&Open";
			this.toolStripMenuOpenDatabase.ToolTipText = "Open database";
			this.toolStripMenuOpenDatabase.Click += new global::System.EventHandler(this.toolStripMenuOpenDatabase_Click);
			this.toolStripMenuOpenDatabase.MouseEnter += new global::System.EventHandler(this.toolStripMenuOpenDatabase_MouseEnter);
			this.toolStripMenuSaveDatabase.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripMenuSaveDatabase.Image = global::SessionManagement.Properties.Resources.save_all;
			this.toolStripMenuSaveDatabase.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.toolStripMenuSaveDatabase.Name = "toolStripMenuSaveDatabase";
			this.toolStripMenuSaveDatabase.Size = new global::System.Drawing.Size(23, 22);
			this.toolStripMenuSaveDatabase.Text = "&Save";
			this.toolStripMenuSaveDatabase.ToolTipText = "Save all databases";
			this.toolStripMenuSaveDatabase.Click += new global::System.EventHandler(this.toolStripMenuSaveDatabase_Click);
			this.toolStripMenuSaveDatabase.MouseEnter += new global::System.EventHandler(this.toolStripMenuSaveDatabase_MouseEnter);
			this.toolStripSeparator.Name = "toolStripSeparator";
			this.toolStripSeparator.Size = new global::System.Drawing.Size(6, 25);
			this.toolStripMenuImportDatabase.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Stretch;
			this.toolStripMenuImportDatabase.Image = global::SessionManagement.Properties.Resources.XML_Import;
			this.toolStripMenuImportDatabase.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.toolStripMenuImportDatabase.Name = "toolStripMenuImportDatabase";
			this.toolStripMenuImportDatabase.Size = new global::System.Drawing.Size(114, 22);
			this.toolStripMenuImportDatabase.Text = "Import Database";
			this.toolStripMenuImportDatabase.ToolTipText = "Import database from XML file";
			this.toolStripMenuImportDatabase.Click += new global::System.EventHandler(this.toolStripMenuImportDatabase_Click);
			this.toolStripMenuImportDatabase.MouseEnter += new global::System.EventHandler(this.toolStripMenuImportDatabase_MouseEnter);
			this.toolStripMenuDisconnect.Image = global::SessionManagement.Properties.Resources.Disconnect;
			this.toolStripMenuDisconnect.ImageAlign = global::System.Drawing.ContentAlignment.BottomCenter;
			this.toolStripMenuDisconnect.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.toolStripMenuDisconnect.Name = "toolStripMenuDisconnect";
			this.toolStripMenuDisconnect.Size = new global::System.Drawing.Size(120, 22);
			this.toolStripMenuDisconnect.Text = "Close All Sessions";
			this.toolStripMenuDisconnect.ToolTipText = "Close all sessions";
			this.toolStripMenuDisconnect.Click += new global::System.EventHandler(this.toolStripMenuDisconnect_Click);
			this.toolStripMenuDisconnect.MouseEnter += new global::System.EventHandler(this.toolStripMenuDisconnect_MouseEnter);
			this.statusBar.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.statusBarStatus
			});
			this.statusBar.Location = new global::System.Drawing.Point(0, 529);
			this.statusBar.Name = "statusBar";
			this.statusBar.Size = new global::System.Drawing.Size(967, 22);
			this.statusBar.TabIndex = 20;
			this.statusBar.Text = "statusStrip1";
			this.statusBarStatus.Name = "statusBarStatus";
			this.statusBarStatus.Size = new global::System.Drawing.Size(39, 17);
			this.statusBarStatus.Text = "Status";
			this.dockPanelMain.BackColor = global::System.Drawing.Color.Lavender;
			this.dockPanelMain.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.dockPanelMain.DockBackColor = global::System.Drawing.SystemColors.ControlLight;
			this.dockPanelMain.DockLeftPortion = 0.22;
			this.dockPanelMain.DockRightPortion = 0.22;
			this.dockPanelMain.DocumentStyle = global::WeifenLuo.WinFormsUI.Docking.DocumentStyle.DockingWindow;
			this.dockPanelMain.Location = new global::System.Drawing.Point(0, 108);
			this.dockPanelMain.Margin = new global::System.Windows.Forms.Padding(4);
			this.dockPanelMain.Name = "dockPanelMain";
			this.dockPanelMain.Size = new global::System.Drawing.Size(967, 421);
			dockPanelGradient.EndColor = global::System.Drawing.SystemColors.ControlLight;
			dockPanelGradient.StartColor = global::System.Drawing.SystemColors.ControlLight;
			autoHideStripSkin.DockStripGradient = dockPanelGradient;
			tabGradient.EndColor = global::System.Drawing.SystemColors.Control;
			tabGradient.StartColor = global::System.Drawing.SystemColors.Control;
			tabGradient.TextColor = global::System.Drawing.SystemColors.ControlDarkDark;
			autoHideStripSkin.TabGradient = tabGradient;
			autoHideStripSkin.TextFont = new global::System.Drawing.Font("Segoe UI", 9f);
			dockPanelSkin.AutoHideStripSkin = autoHideStripSkin;
			tabGradient2.EndColor = global::System.Drawing.SystemColors.ControlLightLight;
			tabGradient2.StartColor = global::System.Drawing.SystemColors.ControlLightLight;
			tabGradient2.TextColor = global::System.Drawing.SystemColors.ControlText;
			dockPaneStripGradient.ActiveTabGradient = tabGradient2;
			dockPanelGradient2.EndColor = global::System.Drawing.SystemColors.Control;
			dockPanelGradient2.StartColor = global::System.Drawing.SystemColors.Control;
			dockPaneStripGradient.DockStripGradient = dockPanelGradient2;
			tabGradient3.EndColor = global::System.Drawing.SystemColors.ControlLight;
			tabGradient3.StartColor = global::System.Drawing.SystemColors.ControlLight;
			tabGradient3.TextColor = global::System.Drawing.SystemColors.ControlText;
			dockPaneStripGradient.InactiveTabGradient = tabGradient3;
			dockPaneStripSkin.DocumentGradient = dockPaneStripGradient;
			dockPaneStripSkin.TextFont = new global::System.Drawing.Font("Segoe UI", 9f);
			tabGradient4.EndColor = global::System.Drawing.SystemColors.ActiveCaption;
			tabGradient4.LinearGradientMode = global::System.Drawing.Drawing2D.LinearGradientMode.Vertical;
			tabGradient4.StartColor = global::System.Drawing.SystemColors.GradientActiveCaption;
			tabGradient4.TextColor = global::System.Drawing.SystemColors.ActiveCaptionText;
			dockPaneStripToolWindowGradient.ActiveCaptionGradient = tabGradient4;
			tabGradient5.EndColor = global::System.Drawing.SystemColors.Control;
			tabGradient5.StartColor = global::System.Drawing.SystemColors.Control;
			tabGradient5.TextColor = global::System.Drawing.SystemColors.ControlText;
			dockPaneStripToolWindowGradient.ActiveTabGradient = tabGradient5;
			dockPanelGradient3.EndColor = global::System.Drawing.SystemColors.ControlLight;
			dockPanelGradient3.StartColor = global::System.Drawing.SystemColors.ControlLight;
			dockPaneStripToolWindowGradient.DockStripGradient = dockPanelGradient3;
			tabGradient6.EndColor = global::System.Drawing.SystemColors.InactiveCaption;
			tabGradient6.LinearGradientMode = global::System.Drawing.Drawing2D.LinearGradientMode.Vertical;
			tabGradient6.StartColor = global::System.Drawing.SystemColors.GradientInactiveCaption;
			tabGradient6.TextColor = global::System.Drawing.SystemColors.InactiveCaptionText;
			dockPaneStripToolWindowGradient.InactiveCaptionGradient = tabGradient6;
			tabGradient7.EndColor = global::System.Drawing.Color.Transparent;
			tabGradient7.StartColor = global::System.Drawing.Color.Transparent;
			tabGradient7.TextColor = global::System.Drawing.SystemColors.ControlDarkDark;
			dockPaneStripToolWindowGradient.InactiveTabGradient = tabGradient7;
			dockPaneStripSkin.ToolWindowGradient = dockPaneStripToolWindowGradient;
			dockPanelSkin.DockPaneStripSkin = dockPaneStripSkin;
			this.dockPanelMain.Skin = dockPanelSkin;
			this.dockPanelMain.TabIndex = 21;
			this.dockPanelMain.ActiveDocumentChanged += new global::System.EventHandler(this.dockPanelMain_ActiveDocumentChanged);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(9f, 18f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.SystemColors.Control;
			base.ClientSize = new global::System.Drawing.Size(967, 551);
			base.Controls.Add(this.dockPanelMain);
			base.Controls.Add(this.statusBar);
			base.Controls.Add(this.toolStripGlobalCommand);
			base.Controls.Add(this.toolStripQuickConnect);
			base.Controls.Add(this.toolStripMenu);
			base.Controls.Add(this.mnuMain);
			this.Font = new global::System.Drawing.Font("Century Schoolbook", 11.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.IsMdiContainer = true;
			base.MainMenuStrip = this.mnuMain;
			base.Margin = new global::System.Windows.Forms.Padding(4);
			base.Name = "frmMain";
			this.Text = "Multi PuTTY Manager";
			base.WindowState = global::System.Windows.Forms.FormWindowState.Maximized;
			base.Activated += new global::System.EventHandler(this.frmMain_Activated);
			base.Deactivate += new global::System.EventHandler(this.frmMain_Deactivate);
			base.FormClosing += new global::System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
			base.Load += new global::System.EventHandler(this.frmMain_Load);
			this.contextForDocPanel.ResumeLayout(false);
			this.mnuMain.ResumeLayout(false);
			this.mnuMain.PerformLayout();
			this.toolStripGlobalCommand.ResumeLayout(false);
			this.toolStripGlobalCommand.PerformLayout();
			this.toolStripQuickConnect.ResumeLayout(false);
			this.toolStripQuickConnect.PerformLayout();
			this.toolStripMenu.ResumeLayout(false);
			this.toolStripMenu.PerformLayout();
			this.statusBar.ResumeLayout(false);
			this.statusBar.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000010 RID: 16
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000011 RID: 17
		private global::System.Windows.Forms.MenuStrip mnuMain;

		// Token: 0x04000012 RID: 18
		private global::System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;

		// Token: 0x04000013 RID: 19
		private global::System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;

		// Token: 0x04000014 RID: 20
		private global::System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;

		// Token: 0x04000015 RID: 21
		private global::System.Windows.Forms.ToolStripMenuItem mnuHelp;

		// Token: 0x04000016 RID: 22
		private global::System.Windows.Forms.ContextMenuStrip contextForDocPanel;

		// Token: 0x04000017 RID: 23
		private global::System.Windows.Forms.ToolStripMenuItem contextRenameForDocPanel;

		// Token: 0x04000018 RID: 24
		private global::System.Windows.Forms.ToolStripMenuItem contextSFTPExternal;

		// Token: 0x04000019 RID: 25
		private global::System.Windows.Forms.ToolStripMenuItem contextFTPExternal;

		// Token: 0x0400001A RID: 26
		private global::System.Windows.Forms.ToolStripMenuItem contextDuplicateSession;

		// Token: 0x0400001B RID: 27
		private global::System.Windows.Forms.ToolStrip toolStripGlobalCommand;

		// Token: 0x0400001C RID: 28
		private global::System.Windows.Forms.ToolStrip toolStripMenu;

		// Token: 0x0400001D RID: 29
		private global::System.Windows.Forms.ToolStripLabel toolStripLabel2;

		// Token: 0x0400001E RID: 30
		private global::System.Windows.Forms.ToolStripComboBox toolStripQuickConnectProtocol;

		// Token: 0x0400001F RID: 31
		private global::System.Windows.Forms.ToolStripLabel toolStripLabel3;

		// Token: 0x04000020 RID: 32
		private global::System.Windows.Forms.ToolStripLabel toolStripLabel4;

		// Token: 0x04000021 RID: 33
		private global::System.Windows.Forms.ToolStripTextBox toolStripQuickConnetUserName;

		// Token: 0x04000022 RID: 34
		private global::System.Windows.Forms.ToolStripLabel toolStripLabel5;

		// Token: 0x04000023 RID: 35
		private global::System.Windows.Forms.ToolStripTextBox toolStripQuickConnectPassword;

		// Token: 0x04000024 RID: 36
		private global::System.Windows.Forms.ToolStripLabel toolStripLabel6;

		// Token: 0x04000025 RID: 37
		private global::System.Windows.Forms.ToolStripComboBox toolStripQuickConnecSessionConfig;

		// Token: 0x04000026 RID: 38
		private global::System.Windows.Forms.ToolStripButton toolStripQuickConnectConnect;

		// Token: 0x04000027 RID: 39
		private global::System.Windows.Forms.ToolStripLabel toolStripLabel7;

		// Token: 0x04000028 RID: 40
		private global::System.Windows.Forms.ToolStripButton toolStripGlobalCommandRun;

		// Token: 0x04000029 RID: 41
		private global::System.Windows.Forms.ToolStripButton toolStripMenuNewDatabase;

		// Token: 0x0400002A RID: 42
		private global::System.Windows.Forms.ToolStripButton toolStripMenuOpenDatabase;

		// Token: 0x0400002B RID: 43
		private global::System.Windows.Forms.ToolStripButton toolStripMenuSaveDatabase;

		// Token: 0x0400002C RID: 44
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator;

		// Token: 0x0400002D RID: 45
		private global::System.Windows.Forms.ToolStripMenuItem mnuHelpAbout;

		// Token: 0x0400002E RID: 46
		private global::System.Windows.Forms.ToolStrip toolStripQuickConnect;

		// Token: 0x0400002F RID: 47
		private global::System.Windows.Forms.ToolStripMenuItem contextCloseSession;

		// Token: 0x04000030 RID: 48
		private global::System.Windows.Forms.ToolStripSplitButton toolStripGlobalCommandSession;

		// Token: 0x04000031 RID: 49
		private global::System.Windows.Forms.ToolStripMenuItem toolStripCheckAll;

		// Token: 0x04000032 RID: 50
		private global::System.Windows.Forms.ToolStripMenuItem toolStripUncheckAll;

		// Token: 0x04000033 RID: 51
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator2;

		// Token: 0x04000034 RID: 52
		private global::System.Windows.Forms.ToolStripMenuItem mnuViewSessionManager;

		// Token: 0x04000035 RID: 53
		private global::System.Windows.Forms.ToolStripButton toolStripMenuDisconnect;

		// Token: 0x04000036 RID: 54
		private global::System.Windows.Forms.ToolStripMenuItem mnuToolsPuttyConfiguration;

		// Token: 0x04000037 RID: 55
		private global::System.Windows.Forms.ToolStripMenuItem mnuToolsOption;

		// Token: 0x04000038 RID: 56
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator1;

		// Token: 0x04000039 RID: 57
		private global::System.Windows.Forms.StatusStrip statusBar;

		// Token: 0x0400003A RID: 58
		private global::System.Windows.Forms.ToolStripStatusLabel statusBarStatus;

		// Token: 0x0400003B RID: 59
		private global::WeifenLuo.WinFormsUI.Docking.DockPanel dockPanelMain;

		// Token: 0x0400003C RID: 60
		private global::System.Windows.Forms.ToolStripMenuItem mnuViewToolbars;

		// Token: 0x0400003D RID: 61
		private global::System.Windows.Forms.ToolStripMenuItem mnuViewToolbarsStandard;

		// Token: 0x0400003E RID: 62
		private global::System.Windows.Forms.ToolStripMenuItem mnuViewToolbarsQuickConnection;

		// Token: 0x0400003F RID: 63
		private global::System.Windows.Forms.ToolStripMenuItem mnuViewToolbarsMSC;

		// Token: 0x04000040 RID: 64
		private global::System.Windows.Forms.ToolStripMenuItem mnuViewToolbarsStatus;

		// Token: 0x04000041 RID: 65
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator5;

		// Token: 0x04000042 RID: 66
		private global::System.Windows.Forms.ToolStripComboBox toolStripGlobalCommandCommand;

		// Token: 0x04000043 RID: 67
		private global::System.Windows.Forms.ToolStripComboBox toolStripQuickConnectHost;

		// Token: 0x04000044 RID: 68
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator6;

		// Token: 0x04000045 RID: 69
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator7;

		// Token: 0x04000046 RID: 70
		private global::System.Windows.Forms.ToolStripMenuItem mnuFileExit;

		// Token: 0x04000047 RID: 71
		private global::System.Windows.Forms.ToolStripMenuItem contextChangeSettings;

		// Token: 0x04000048 RID: 72
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator9;

		// Token: 0x04000049 RID: 73
		private global::System.Windows.Forms.ToolStripMenuItem contextEventLog;

		// Token: 0x0400004A RID: 74
		private global::System.Windows.Forms.ToolStripMenuItem contextCopyClipboard;

		// Token: 0x0400004B RID: 75
		private global::System.Windows.Forms.ToolStripMenuItem contextClearScollback;

		// Token: 0x0400004C RID: 76
		private global::System.Windows.Forms.ToolStripMenuItem contextResetTerminal;

		// Token: 0x0400004D RID: 77
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator8;

		// Token: 0x0400004E RID: 78
		private global::System.Windows.Forms.ToolStripMenuItem contextResetAndClear;

		// Token: 0x0400004F RID: 79
		private global::System.Windows.Forms.ToolStripMenuItem mnuFileNewDatabase;

		// Token: 0x04000050 RID: 80
		private global::System.Windows.Forms.ToolStripMenuItem mnuFileOpenDatabase;

		// Token: 0x04000051 RID: 81
		private global::System.Windows.Forms.ToolStripMenuItem mnuSaveAllDatabases;

		// Token: 0x04000052 RID: 82
		private global::System.Windows.Forms.ToolStripMenuItem mnufileImportDatabase;

		// Token: 0x04000053 RID: 83
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator11;

		// Token: 0x04000054 RID: 84
		private global::System.Windows.Forms.ToolStripMenuItem mnuFileCloseAllSessions;

		// Token: 0x04000055 RID: 85
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator10;

		// Token: 0x04000056 RID: 86
		private global::System.Windows.Forms.ToolStripButton toolStripMenuImportDatabase;

		// Token: 0x04000057 RID: 87
		private global::System.Windows.Forms.ToolStripMenuItem mnuToolsPuTTYSessions;

		// Token: 0x04000058 RID: 88
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparatorStatus;

		// Token: 0x04000059 RID: 89
		private global::System.Windows.Forms.ToolStripLabel toolStripGlobalCommandStatus;

		// Token: 0x0400005A RID: 90
		private global::System.Windows.Forms.ToolStripMenuItem contextAcceptGlobalCommand;

		// Token: 0x0400005B RID: 91
		private global::System.Windows.Forms.ToolStripButton toolStripGlobalCommandStopMultiCommands;

		// Token: 0x0400005C RID: 92
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator3;

		// Token: 0x0400005D RID: 93
		private global::System.Windows.Forms.ToolStripMenuItem contextRunMultiCommands;

		// Token: 0x0400005E RID: 94
		private global::System.Windows.Forms.ToolStripMenuItem mnuHelpHelp;

		// Token: 0x0400005F RID: 95
		private global::System.Windows.Forms.ToolStripMenuItem mnuHelpHomepage;

		// Token: 0x04000060 RID: 96
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator4;

		// Token: 0x04000061 RID: 97
		private global::System.Windows.Forms.ToolStripMenuItem contextRestartSession;
	}
}
