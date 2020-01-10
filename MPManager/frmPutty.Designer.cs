namespace SessionManagement
{
	// Token: 0x0200000A RID: 10
	public partial class frmPutty : global::WeifenLuo.WinFormsUI.Docking.DockContent
	{
		// Token: 0x060000C1 RID: 193 RVA: 0x0000AB7C File Offset: 0x00008D7C
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x0000ABB4 File Offset: 0x00008DB4
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::SessionManagement.frmPutty));
			this.pnMain = new global::System.Windows.Forms.Panel();
			this.tmCheckProcess = new global::System.Windows.Forms.Timer(this.components);
			base.SuspendLayout();
			this.pnMain.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.pnMain.Location = new global::System.Drawing.Point(0, 0);
			this.pnMain.Name = "pnMain";
			this.pnMain.Size = new global::System.Drawing.Size(433, 415);
			this.pnMain.TabIndex = 0;
			this.tmCheckProcess.Tick += new global::System.EventHandler(this.tmCheckProcess_Tick);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(433, 415);
			base.Controls.Add(this.pnMain);
			base.DockAreas = global::WeifenLuo.WinFormsUI.Docking.DockAreas.Document;
			this.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "frmPutty";
			this.Text = "frmPutty";
			base.WindowState = global::System.Windows.Forms.FormWindowState.Maximized;
			base.FormClosing += new global::System.Windows.Forms.FormClosingEventHandler(this.frmPutty_FormClosing);
			base.FormClosed += new global::System.Windows.Forms.FormClosedEventHandler(this.frmPutty_FormClosed);
			base.Load += new global::System.EventHandler(this.frmPutty_Load);
			base.Resize += new global::System.EventHandler(this.frmPutty_Resize);
			base.ResumeLayout(false);
		}

		// Token: 0x040000A9 RID: 169
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x040000AA RID: 170
		private global::System.Windows.Forms.Panel pnMain;

		// Token: 0x040000AB RID: 171
		private global::System.Windows.Forms.Timer tmCheckProcess;
	}
}
