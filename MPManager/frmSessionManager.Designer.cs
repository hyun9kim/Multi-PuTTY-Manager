namespace SessionManagement
{
	// Token: 0x02000010 RID: 16
	public partial class frmSessionManager : global::WeifenLuo.WinFormsUI.Docking.DockContent
	{
		// Token: 0x06000136 RID: 310 RVA: 0x000113BC File Offset: 0x0000F5BC
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000137 RID: 311 RVA: 0x000113F4 File Offset: 0x0000F5F4
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::SessionManagement.frmSessionManager));
			this.contextForDatabase = new global::System.Windows.Forms.ContextMenuStrip(this.components);
			this.contextNewForDatabase = new global::System.Windows.Forms.ToolStripMenuItem();
			this.contextSessionForDatabase = new global::System.Windows.Forms.ToolStripMenuItem();
			this.contextFolderForDatabase = new global::System.Windows.Forms.ToolStripMenuItem();
			this.contextPasteForDatabase = new global::System.Windows.Forms.ToolStripMenuItem();
			this.contextSaveForDatabase = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator5 = new global::System.Windows.Forms.ToolStripSeparator();
			this.contextSetDefaultForDatabase = new global::System.Windows.Forms.ToolStripMenuItem();
			this.contextPropertiesForDatabase = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator3 = new global::System.Windows.Forms.ToolStripSeparator();
			this.contextCloseDatabaseForDatabase = new global::System.Windows.Forms.ToolStripMenuItem();
			this.treeSessions = new global::System.Windows.Forms.TreeView();
			this.contextForTreeSession = new global::System.Windows.Forms.ContextMenuStrip(this.components);
			this.contextCreateDatabase = new global::System.Windows.Forms.ToolStripMenuItem();
			this.contextOpenDatabase = new global::System.Windows.Forms.ToolStripMenuItem();
			this.imageListSessionManager = new global::System.Windows.Forms.ImageList(this.components);
			this.contextForFolder = new global::System.Windows.Forms.ContextMenuStrip(this.components);
			this.contextNewForFolder = new global::System.Windows.Forms.ToolStripMenuItem();
			this.contextSessionForFolder = new global::System.Windows.Forms.ToolStripMenuItem();
			this.contextFolderForFolder = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator6 = new global::System.Windows.Forms.ToolStripSeparator();
			this.contextConnectAllForFolder = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator4 = new global::System.Windows.Forms.ToolStripSeparator();
			this.contextCutForFolder = new global::System.Windows.Forms.ToolStripMenuItem();
			this.contextCopyForFolder = new global::System.Windows.Forms.ToolStripMenuItem();
			this.contextPasteForFolder = new global::System.Windows.Forms.ToolStripMenuItem();
			this.contextDeleteForFolder = new global::System.Windows.Forms.ToolStripMenuItem();
			this.contextRenameForFolder = new global::System.Windows.Forms.ToolStripMenuItem();
			this.contextForSession = new global::System.Windows.Forms.ContextMenuStrip(this.components);
			this.contextConnect = new global::System.Windows.Forms.ToolStripMenuItem();
			this.contextConnectExternal = new global::System.Windows.Forms.ToolStripMenuItem();
			this.contextFTPExternal = new global::System.Windows.Forms.ToolStripMenuItem();
			this.contextSFTPExternal = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new global::System.Windows.Forms.ToolStripSeparator();
			this.contextCutForSession = new global::System.Windows.Forms.ToolStripMenuItem();
			this.contextCopyForSession = new global::System.Windows.Forms.ToolStripMenuItem();
			this.contextDeleteForSession = new global::System.Windows.Forms.ToolStripMenuItem();
			this.contextRenameForSession = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new global::System.Windows.Forms.ToolStripSeparator();
			this.contextConfigForSession = new global::System.Windows.Forms.ToolStripMenuItem();
			this.contextForDatabase.SuspendLayout();
			this.contextForTreeSession.SuspendLayout();
			this.contextForFolder.SuspendLayout();
			this.contextForSession.SuspendLayout();
			base.SuspendLayout();
			this.contextForDatabase.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.contextForDatabase.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.contextNewForDatabase,
				this.contextPasteForDatabase,
				this.contextSaveForDatabase,
				this.toolStripSeparator5,
				this.contextSetDefaultForDatabase,
				this.contextPropertiesForDatabase,
				this.toolStripSeparator3,
				this.contextCloseDatabaseForDatabase
			});
			this.contextForDatabase.Name = "contextForDatabase";
			this.contextForDatabase.Size = new global::System.Drawing.Size(195, 148);
			this.contextForDatabase.Opening += new global::System.ComponentModel.CancelEventHandler(this.contextForDatabase_Opening);
			this.contextNewForDatabase.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.contextSessionForDatabase,
				this.contextFolderForDatabase
			});
			this.contextNewForDatabase.Name = "contextNewForDatabase";
			this.contextNewForDatabase.Size = new global::System.Drawing.Size(194, 22);
			this.contextNewForDatabase.Text = "New";
			this.contextSessionForDatabase.Name = "contextSessionForDatabase";
			this.contextSessionForDatabase.Size = new global::System.Drawing.Size(113, 22);
			this.contextSessionForDatabase.Text = "Session";
			this.contextSessionForDatabase.Click += new global::System.EventHandler(this.contextSessionForDatabase_Click);
			this.contextFolderForDatabase.Name = "contextFolderForDatabase";
			this.contextFolderForDatabase.Size = new global::System.Drawing.Size(113, 22);
			this.contextFolderForDatabase.Text = "Folder";
			this.contextFolderForDatabase.Click += new global::System.EventHandler(this.contextFolderForDatabase_Click);
			this.contextPasteForDatabase.Name = "contextPasteForDatabase";
			this.contextPasteForDatabase.Size = new global::System.Drawing.Size(194, 22);
			this.contextPasteForDatabase.Text = "Paste";
			this.contextPasteForDatabase.Click += new global::System.EventHandler(this.contextPasteForDatabase_Click);
			this.contextSaveForDatabase.Name = "contextSaveForDatabase";
			this.contextSaveForDatabase.Size = new global::System.Drawing.Size(194, 22);
			this.contextSaveForDatabase.Text = "Save";
			this.contextSaveForDatabase.Click += new global::System.EventHandler(this.contextSaveForDatabase_Click);
			this.toolStripSeparator5.Name = "toolStripSeparator5";
			this.toolStripSeparator5.Size = new global::System.Drawing.Size(191, 6);
			this.contextSetDefaultForDatabase.Name = "contextSetDefaultForDatabase";
			this.contextSetDefaultForDatabase.Size = new global::System.Drawing.Size(194, 22);
			this.contextSetDefaultForDatabase.Text = "Set as default database";
			this.contextSetDefaultForDatabase.Click += new global::System.EventHandler(this.contextSetDefaultForDatabase_Click);
			this.contextPropertiesForDatabase.Name = "contextPropertiesForDatabase";
			this.contextPropertiesForDatabase.Size = new global::System.Drawing.Size(194, 22);
			this.contextPropertiesForDatabase.Text = "Properties";
			this.contextPropertiesForDatabase.Click += new global::System.EventHandler(this.contextPropertiesForDatabase_Click);
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new global::System.Drawing.Size(191, 6);
			this.contextCloseDatabaseForDatabase.Name = "contextCloseDatabaseForDatabase";
			this.contextCloseDatabaseForDatabase.Size = new global::System.Drawing.Size(194, 22);
			this.contextCloseDatabaseForDatabase.Text = "Close database";
			this.contextCloseDatabaseForDatabase.Click += new global::System.EventHandler(this.contextCloseDatabaseForDatabase_Click);
			this.treeSessions.BackColor = global::System.Drawing.SystemColors.Window;
			this.treeSessions.ContextMenuStrip = this.contextForTreeSession;
			this.treeSessions.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.treeSessions.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.treeSessions.ImageIndex = 0;
			this.treeSessions.ImageList = this.imageListSessionManager;
			this.treeSessions.LabelEdit = true;
			this.treeSessions.Location = new global::System.Drawing.Point(0, 0);
			this.treeSessions.Name = "treeSessions";
			this.treeSessions.SelectedImageIndex = 0;
			this.treeSessions.ShowNodeToolTips = true;
			this.treeSessions.Size = new global::System.Drawing.Size(255, 398);
			this.treeSessions.TabIndex = 0;
			this.treeSessions.AfterLabelEdit += new global::System.Windows.Forms.NodeLabelEditEventHandler(this.treeSessions_AfterLabelEdit);
			this.treeSessions.AfterSelect += new global::System.Windows.Forms.TreeViewEventHandler(this.treeSessions_AfterSelect);
			this.treeSessions.NodeMouseClick += new global::System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeSessions_NodeMouseClick);
			this.treeSessions.NodeMouseDoubleClick += new global::System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeSessions_NodeMouseDoubleClick);
			this.treeSessions.KeyDown += new global::System.Windows.Forms.KeyEventHandler(this.treeSessions_KeyDown);
			this.treeSessions.KeyPress += new global::System.Windows.Forms.KeyPressEventHandler(this.treeSessions_KeyPress);
			this.contextForTreeSession.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.contextForTreeSession.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.contextCreateDatabase,
				this.contextOpenDatabase
			});
			this.contextForTreeSession.Name = "contextForTreeSession";
			this.contextForTreeSession.Size = new global::System.Drawing.Size(159, 48);
			this.contextCreateDatabase.Name = "contextCreateDatabase";
			this.contextCreateDatabase.Size = new global::System.Drawing.Size(158, 22);
			this.contextCreateDatabase.Text = "Create database";
			this.contextCreateDatabase.Click += new global::System.EventHandler(this.contextCreateDatabase_Click);
			this.contextOpenDatabase.Name = "contextOpenDatabase";
			this.contextOpenDatabase.Size = new global::System.Drawing.Size(158, 22);
			this.contextOpenDatabase.Text = "Open database";
			this.contextOpenDatabase.Click += new global::System.EventHandler(this.contextOpenDatabase_Click);
			this.imageListSessionManager.ImageStream = (global::System.Windows.Forms.ImageListStreamer)componentResourceManager.GetObject("imageListSessionManager.ImageStream");
			this.imageListSessionManager.TransparentColor = global::System.Drawing.Color.Transparent;
			this.imageListSessionManager.Images.SetKeyName(0, "Database.png");
			this.imageListSessionManager.Images.SetKeyName(1, "Folder3.png");
			this.imageListSessionManager.Images.SetKeyName(2, "Session.png");
			this.imageListSessionManager.Images.SetKeyName(3, "Session_cut.png");
			this.imageListSessionManager.Images.SetKeyName(4, "Folder_cut.png");
			this.contextForFolder.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.contextForFolder.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.contextNewForFolder,
				this.toolStripSeparator6,
				this.contextConnectAllForFolder,
				this.toolStripSeparator4,
				this.contextCutForFolder,
				this.contextCopyForFolder,
				this.contextPasteForFolder,
				this.contextDeleteForFolder,
				this.contextRenameForFolder
			});
			this.contextForFolder.Name = "contextForFolder";
			this.contextForFolder.Size = new global::System.Drawing.Size(168, 170);
			this.contextForFolder.Opening += new global::System.ComponentModel.CancelEventHandler(this.contextForFolder_Opening);
			this.contextNewForFolder.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.contextSessionForFolder,
				this.contextFolderForFolder
			});
			this.contextNewForFolder.Name = "contextNewForFolder";
			this.contextNewForFolder.Size = new global::System.Drawing.Size(167, 22);
			this.contextNewForFolder.Text = "New";
			this.contextSessionForFolder.Name = "contextSessionForFolder";
			this.contextSessionForFolder.Size = new global::System.Drawing.Size(113, 22);
			this.contextSessionForFolder.Text = "Session";
			this.contextSessionForFolder.Click += new global::System.EventHandler(this.contextSessionForFolder_Click);
			this.contextFolderForFolder.Name = "contextFolderForFolder";
			this.contextFolderForFolder.Size = new global::System.Drawing.Size(113, 22);
			this.contextFolderForFolder.Text = "Folder";
			this.contextFolderForFolder.Click += new global::System.EventHandler(this.contextFolderForFolder_Click);
			this.toolStripSeparator6.Name = "toolStripSeparator6";
			this.toolStripSeparator6.Size = new global::System.Drawing.Size(164, 6);
			this.contextConnectAllForFolder.Name = "contextConnectAllForFolder";
			this.contextConnectAllForFolder.Size = new global::System.Drawing.Size(167, 22);
			this.contextConnectAllForFolder.Text = "Open All Sessions";
			this.contextConnectAllForFolder.Click += new global::System.EventHandler(this.contextConnectAllForFolder_Click);
			this.toolStripSeparator4.Name = "toolStripSeparator4";
			this.toolStripSeparator4.Size = new global::System.Drawing.Size(164, 6);
			this.contextCutForFolder.Name = "contextCutForFolder";
			this.contextCutForFolder.Size = new global::System.Drawing.Size(167, 22);
			this.contextCutForFolder.Text = "Cut";
			this.contextCutForFolder.Click += new global::System.EventHandler(this.contextCutForFolder_Click);
			this.contextCopyForFolder.Name = "contextCopyForFolder";
			this.contextCopyForFolder.Size = new global::System.Drawing.Size(167, 22);
			this.contextCopyForFolder.Text = "Copy";
			this.contextCopyForFolder.Click += new global::System.EventHandler(this.contextCopyForFolder_Click);
			this.contextPasteForFolder.Name = "contextPasteForFolder";
			this.contextPasteForFolder.Size = new global::System.Drawing.Size(167, 22);
			this.contextPasteForFolder.Text = "Paste";
			this.contextPasteForFolder.Click += new global::System.EventHandler(this.contextPasteForFolder_Click);
			this.contextDeleteForFolder.Name = "contextDeleteForFolder";
			this.contextDeleteForFolder.Size = new global::System.Drawing.Size(167, 22);
			this.contextDeleteForFolder.Text = "Delete";
			this.contextDeleteForFolder.Click += new global::System.EventHandler(this.contextDeleteForFolder_Click);
			this.contextRenameForFolder.Name = "contextRenameForFolder";
			this.contextRenameForFolder.Size = new global::System.Drawing.Size(167, 22);
			this.contextRenameForFolder.Text = "Rename";
			this.contextRenameForFolder.Click += new global::System.EventHandler(this.contextRenameForFolder_Click);
			this.contextForSession.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.contextForSession.ImageScalingSize = new global::System.Drawing.Size(18, 18);
			this.contextForSession.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.contextConnect,
				this.contextConnectExternal,
				this.contextFTPExternal,
				this.contextSFTPExternal,
				this.toolStripSeparator1,
				this.contextCutForSession,
				this.contextCopyForSession,
				this.contextDeleteForSession,
				this.contextRenameForSession,
				this.toolStripSeparator2,
				this.contextConfigForSession
			});
			this.contextForSession.Name = "contextForSession";
			this.contextForSession.Size = new global::System.Drawing.Size(192, 232);
			this.contextConnect.Name = "contextConnect";
			this.contextConnect.Size = new global::System.Drawing.Size(191, 24);
			this.contextConnect.Text = "Open Session";
			this.contextConnect.Click += new global::System.EventHandler(this.contextConnect_Click);
			this.contextConnectExternal.Name = "contextConnectExternal";
			this.contextConnectExternal.Size = new global::System.Drawing.Size(191, 24);
			this.contextConnectExternal.Text = "Open Session External";
			this.contextConnectExternal.Click += new global::System.EventHandler(this.contextConnectExternal_Click);
			this.contextFTPExternal.Name = "contextFTPExternal";
			this.contextFTPExternal.Size = new global::System.Drawing.Size(191, 24);
			this.contextFTPExternal.Text = "FTP Using WinSCP";
			this.contextFTPExternal.Click += new global::System.EventHandler(this.contextFTPExternal_Click);
			this.contextSFTPExternal.Name = "contextSFTPExternal";
			this.contextSFTPExternal.Size = new global::System.Drawing.Size(191, 24);
			this.contextSFTPExternal.Text = "SFTP Using WinSCP";
			this.contextSFTPExternal.Click += new global::System.EventHandler(this.contextSFTPExternal_Click);
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new global::System.Drawing.Size(188, 6);
			this.contextCutForSession.Name = "contextCutForSession";
			this.contextCutForSession.Size = new global::System.Drawing.Size(191, 24);
			this.contextCutForSession.Text = "Cut";
			this.contextCutForSession.Click += new global::System.EventHandler(this.contextCutForSession_Click);
			this.contextCopyForSession.Name = "contextCopyForSession";
			this.contextCopyForSession.Size = new global::System.Drawing.Size(191, 24);
			this.contextCopyForSession.Text = "Copy";
			this.contextCopyForSession.Click += new global::System.EventHandler(this.contextCopyForSession_Click);
			this.contextDeleteForSession.Name = "contextDeleteForSession";
			this.contextDeleteForSession.Size = new global::System.Drawing.Size(191, 24);
			this.contextDeleteForSession.Text = "Delete";
			this.contextDeleteForSession.Click += new global::System.EventHandler(this.contextDeleteForSession_Click);
			this.contextRenameForSession.Name = "contextRenameForSession";
			this.contextRenameForSession.Size = new global::System.Drawing.Size(191, 24);
			this.contextRenameForSession.Text = "Rename";
			this.contextRenameForSession.Click += new global::System.EventHandler(this.contextRenameForSession_Click);
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new global::System.Drawing.Size(188, 6);
			this.contextConfigForSession.Image = global::SessionManagement.Properties.Resources.SessionConfig1;
			this.contextConfigForSession.Name = "contextConfigForSession";
			this.contextConfigForSession.Size = new global::System.Drawing.Size(191, 24);
			this.contextConfigForSession.Text = "Configuration";
			this.contextConfigForSession.Click += new global::System.EventHandler(this.contextConfigForSession_Click);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.SystemColors.GradientActiveCaption;
			base.ClientSize = new global::System.Drawing.Size(255, 398);
			base.Controls.Add(this.treeSessions);
			base.DockAreas = global::WeifenLuo.WinFormsUI.Docking.DockAreas.DockLeft;
			this.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "frmSessionManager";
			this.Text = "Sessions Manager";
			base.FormClosing += new global::System.Windows.Forms.FormClosingEventHandler(this.frmSessionManager_FormClosing);
			base.Load += new global::System.EventHandler(this.frmSessionManager_Load);
			this.contextForDatabase.ResumeLayout(false);
			this.contextForTreeSession.ResumeLayout(false);
			this.contextForFolder.ResumeLayout(false);
			this.contextForSession.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		// Token: 0x040000FC RID: 252
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x040000FD RID: 253
		private global::System.Windows.Forms.TreeView treeSessions;

		// Token: 0x040000FE RID: 254
		private global::System.Windows.Forms.ContextMenuStrip contextForDatabase;

		// Token: 0x040000FF RID: 255
		private global::System.Windows.Forms.ToolStripMenuItem contextNewForDatabase;

		// Token: 0x04000100 RID: 256
		private global::System.Windows.Forms.ToolStripMenuItem contextSessionForDatabase;

		// Token: 0x04000101 RID: 257
		private global::System.Windows.Forms.ToolStripMenuItem contextFolderForDatabase;

		// Token: 0x04000102 RID: 258
		private global::System.Windows.Forms.ToolStripMenuItem contextPropertiesForDatabase;

		// Token: 0x04000103 RID: 259
		private global::System.Windows.Forms.ToolStripMenuItem contextCloseDatabaseForDatabase;

		// Token: 0x04000104 RID: 260
		private global::System.Windows.Forms.ContextMenuStrip contextForFolder;

		// Token: 0x04000105 RID: 261
		private global::System.Windows.Forms.ToolStripMenuItem contextNewForFolder;

		// Token: 0x04000106 RID: 262
		private global::System.Windows.Forms.ToolStripMenuItem contextSessionForFolder;

		// Token: 0x04000107 RID: 263
		private global::System.Windows.Forms.ToolStripMenuItem contextFolderForFolder;

		// Token: 0x04000108 RID: 264
		private global::System.Windows.Forms.ToolStripMenuItem contextRenameForFolder;

		// Token: 0x04000109 RID: 265
		private global::System.Windows.Forms.ContextMenuStrip contextForSession;

		// Token: 0x0400010A RID: 266
		private global::System.Windows.Forms.ToolStripMenuItem contextConnect;

		// Token: 0x0400010B RID: 267
		private global::System.Windows.Forms.ToolStripMenuItem contextConnectExternal;

		// Token: 0x0400010C RID: 268
		private global::System.Windows.Forms.ToolStripMenuItem contextFTPExternal;

		// Token: 0x0400010D RID: 269
		private global::System.Windows.Forms.ToolStripMenuItem contextSFTPExternal;

		// Token: 0x0400010E RID: 270
		private global::System.Windows.Forms.ToolStripMenuItem contextRenameForSession;

		// Token: 0x0400010F RID: 271
		private global::System.Windows.Forms.ContextMenuStrip contextForTreeSession;

		// Token: 0x04000110 RID: 272
		private global::System.Windows.Forms.ToolStripMenuItem contextOpenDatabase;

		// Token: 0x04000111 RID: 273
		private global::System.Windows.Forms.ToolStripMenuItem contextConfigForSession;

		// Token: 0x04000112 RID: 274
		private global::System.Windows.Forms.ImageList imageListSessionManager;

		// Token: 0x04000113 RID: 275
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator1;

		// Token: 0x04000114 RID: 276
		private global::System.Windows.Forms.ToolStripMenuItem contextCreateDatabase;

		// Token: 0x04000115 RID: 277
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator3;

		// Token: 0x04000116 RID: 278
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator4;

		// Token: 0x04000117 RID: 279
		private global::System.Windows.Forms.ToolStripMenuItem contextCutForFolder;

		// Token: 0x04000118 RID: 280
		private global::System.Windows.Forms.ToolStripMenuItem contextCopyForFolder;

		// Token: 0x04000119 RID: 281
		private global::System.Windows.Forms.ToolStripMenuItem contextDeleteForFolder;

		// Token: 0x0400011A RID: 282
		private global::System.Windows.Forms.ToolStripMenuItem contextCutForSession;

		// Token: 0x0400011B RID: 283
		private global::System.Windows.Forms.ToolStripMenuItem contextCopyForSession;

		// Token: 0x0400011C RID: 284
		private global::System.Windows.Forms.ToolStripMenuItem contextDeleteForSession;

		// Token: 0x0400011D RID: 285
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator2;

		// Token: 0x0400011E RID: 286
		private global::System.Windows.Forms.ToolStripMenuItem contextPasteForFolder;

		// Token: 0x0400011F RID: 287
		private global::System.Windows.Forms.ToolStripMenuItem contextPasteForDatabase;

		// Token: 0x04000120 RID: 288
		private global::System.Windows.Forms.ToolStripMenuItem contextSaveForDatabase;

		// Token: 0x04000121 RID: 289
		private global::System.Windows.Forms.ToolStripMenuItem contextSetDefaultForDatabase;

		// Token: 0x04000122 RID: 290
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator5;

		// Token: 0x04000123 RID: 291
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator6;

		// Token: 0x04000124 RID: 292
		private global::System.Windows.Forms.ToolStripMenuItem contextConnectAllForFolder;
	}
}
