namespace SessionManagement
{
	// Token: 0x02000008 RID: 8
	public partial class frmOptions : global::System.Windows.Forms.Form
	{
		// Token: 0x060000A2 RID: 162 RVA: 0x000092B4 File Offset: 0x000074B4
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x000092EC File Offset: 0x000074EC
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::SessionManagement.frmOptions));
			this.tabMain = new global::System.Windows.Forms.TabControl();
			this.tabpageGeneral = new global::System.Windows.Forms.TabPage();
			this.groupSessionManagerPosition = new global::System.Windows.Forms.GroupBox();
			this.radRight = new global::System.Windows.Forms.RadioButton();
			this.radLeft = new global::System.Windows.Forms.RadioButton();
			this.groupWinSCP = new global::System.Windows.Forms.GroupBox();
			this.label5 = new global::System.Windows.Forms.Label();
			this.btWinSCPBrowser = new global::System.Windows.Forms.Button();
			this.txtWinSCPLocation = new global::System.Windows.Forms.TextBox();
			this.label6 = new global::System.Windows.Forms.Label();
			this.groupPutty = new global::System.Windows.Forms.GroupBox();
			this.label3 = new global::System.Windows.Forms.Label();
			this.btPuttyBrowser = new global::System.Windows.Forms.Button();
			this.txtPuttyLocation = new global::System.Windows.Forms.TextBox();
			this.label4 = new global::System.Windows.Forms.Label();
			this.groupDatabase = new global::System.Windows.Forms.GroupBox();
			this.label2 = new global::System.Windows.Forms.Label();
			this.btDatabaseBrowser = new global::System.Windows.Forms.Button();
			this.txtDatabaseLocation = new global::System.Windows.Forms.TextBox();
			this.label1 = new global::System.Windows.Forms.Label();
			this.btOK = new global::System.Windows.Forms.Button();
			this.btCancel = new global::System.Windows.Forms.Button();
			this.tabMain.SuspendLayout();
			this.tabpageGeneral.SuspendLayout();
			this.groupSessionManagerPosition.SuspendLayout();
			this.groupWinSCP.SuspendLayout();
			this.groupPutty.SuspendLayout();
			this.groupDatabase.SuspendLayout();
			base.SuspendLayout();
			this.tabMain.Controls.Add(this.tabpageGeneral);
			this.tabMain.Font = new global::System.Drawing.Font("Segoe UI", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.tabMain.Location = new global::System.Drawing.Point(3, 0);
			this.tabMain.Margin = new global::System.Windows.Forms.Padding(4);
			this.tabMain.Name = "tabMain";
			this.tabMain.SelectedIndex = 0;
			this.tabMain.Size = new global::System.Drawing.Size(547, 409);
			this.tabMain.TabIndex = 0;
			this.tabpageGeneral.Controls.Add(this.groupSessionManagerPosition);
			this.tabpageGeneral.Controls.Add(this.groupWinSCP);
			this.tabpageGeneral.Controls.Add(this.groupPutty);
			this.tabpageGeneral.Controls.Add(this.groupDatabase);
			this.tabpageGeneral.Location = new global::System.Drawing.Point(4, 26);
			this.tabpageGeneral.Margin = new global::System.Windows.Forms.Padding(4);
			this.tabpageGeneral.Name = "tabpageGeneral";
			this.tabpageGeneral.Padding = new global::System.Windows.Forms.Padding(4);
			this.tabpageGeneral.Size = new global::System.Drawing.Size(539, 379);
			this.tabpageGeneral.TabIndex = 0;
			this.tabpageGeneral.Text = "General";
			this.tabpageGeneral.UseVisualStyleBackColor = true;
			this.groupSessionManagerPosition.Controls.Add(this.radRight);
			this.groupSessionManagerPosition.Controls.Add(this.radLeft);
			this.groupSessionManagerPosition.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.groupSessionManagerPosition.Location = new global::System.Drawing.Point(17, 293);
			this.groupSessionManagerPosition.Margin = new global::System.Windows.Forms.Padding(4);
			this.groupSessionManagerPosition.Name = "groupSessionManagerPosition";
			this.groupSessionManagerPosition.Padding = new global::System.Windows.Forms.Padding(4);
			this.groupSessionManagerPosition.Size = new global::System.Drawing.Size(505, 64);
			this.groupSessionManagerPosition.TabIndex = 3;
			this.groupSessionManagerPosition.TabStop = false;
			this.groupSessionManagerPosition.Text = "Sessions Manager Position";
			this.radRight.AutoSize = true;
			this.radRight.Location = new global::System.Drawing.Point(363, 27);
			this.radRight.Name = "radRight";
			this.radRight.Size = new global::System.Drawing.Size(78, 19);
			this.radRight.TabIndex = 1;
			this.radRight.TabStop = true;
			this.radRight.Text = "Right Side";
			this.radRight.UseVisualStyleBackColor = true;
			this.radLeft.AutoSize = true;
			this.radLeft.Location = new global::System.Drawing.Point(81, 27);
			this.radLeft.Name = "radLeft";
			this.radLeft.Size = new global::System.Drawing.Size(70, 19);
			this.radLeft.TabIndex = 0;
			this.radLeft.TabStop = true;
			this.radLeft.Text = "Left Side";
			this.radLeft.UseVisualStyleBackColor = true;
			this.groupWinSCP.Controls.Add(this.label5);
			this.groupWinSCP.Controls.Add(this.btWinSCPBrowser);
			this.groupWinSCP.Controls.Add(this.txtWinSCPLocation);
			this.groupWinSCP.Controls.Add(this.label6);
			this.groupWinSCP.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.groupWinSCP.Location = new global::System.Drawing.Point(17, 199);
			this.groupWinSCP.Margin = new global::System.Windows.Forms.Padding(4);
			this.groupWinSCP.Name = "groupWinSCP";
			this.groupWinSCP.Padding = new global::System.Windows.Forms.Padding(4);
			this.groupWinSCP.Size = new global::System.Drawing.Size(505, 79);
			this.groupWinSCP.TabIndex = 2;
			this.groupWinSCP.TabStop = false;
			this.groupWinSCP.Text = "WinSCP";
			this.label5.AutoSize = true;
			this.label5.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label5.Location = new global::System.Drawing.Point(78, 55);
			this.label5.Name = "label5";
			this.label5.Size = new global::System.Drawing.Size(210, 15);
			this.label5.TabIndex = 3;
			this.label5.Text = "(For example: C:\\WinSCP\\WinSCP.exe)";
			this.btWinSCPBrowser.BackgroundImage = (global::System.Drawing.Image)componentResourceManager.GetObject("btWinSCPBrowser.BackgroundImage");
			this.btWinSCPBrowser.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Stretch;
			this.btWinSCPBrowser.Location = new global::System.Drawing.Point(468, 25);
			this.btWinSCPBrowser.Name = "btWinSCPBrowser";
			this.btWinSCPBrowser.Size = new global::System.Drawing.Size(26, 26);
			this.btWinSCPBrowser.TabIndex = 2;
			this.btWinSCPBrowser.UseVisualStyleBackColor = true;
			this.btWinSCPBrowser.Click += new global::System.EventHandler(this.btWinSCPBrowser_Click);
			this.txtWinSCPLocation.Location = new global::System.Drawing.Point(81, 25);
			this.txtWinSCPLocation.Name = "txtWinSCPLocation";
			this.txtWinSCPLocation.Size = new global::System.Drawing.Size(381, 23);
			this.txtWinSCPLocation.TabIndex = 1;
			this.label6.AutoSize = true;
			this.label6.Location = new global::System.Drawing.Point(7, 28);
			this.label6.Name = "label6";
			this.label6.Size = new global::System.Drawing.Size(53, 15);
			this.label6.TabIndex = 0;
			this.label6.Text = "Location";
			this.groupPutty.Controls.Add(this.label3);
			this.groupPutty.Controls.Add(this.btPuttyBrowser);
			this.groupPutty.Controls.Add(this.txtPuttyLocation);
			this.groupPutty.Controls.Add(this.label4);
			this.groupPutty.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.groupPutty.Location = new global::System.Drawing.Point(17, 101);
			this.groupPutty.Margin = new global::System.Windows.Forms.Padding(4);
			this.groupPutty.Name = "groupPutty";
			this.groupPutty.Padding = new global::System.Windows.Forms.Padding(4);
			this.groupPutty.Size = new global::System.Drawing.Size(505, 83);
			this.groupPutty.TabIndex = 1;
			this.groupPutty.TabStop = false;
			this.groupPutty.Text = "PuTTY";
			this.label3.AutoSize = true;
			this.label3.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label3.Location = new global::System.Drawing.Point(78, 55);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(182, 15);
			this.label3.TabIndex = 3;
			this.label3.Text = "(For example: C:\\Putty\\Putty.exe)";
			this.btPuttyBrowser.BackgroundImage = (global::System.Drawing.Image)componentResourceManager.GetObject("btPuttyBrowser.BackgroundImage");
			this.btPuttyBrowser.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Stretch;
			this.btPuttyBrowser.Location = new global::System.Drawing.Point(468, 25);
			this.btPuttyBrowser.Name = "btPuttyBrowser";
			this.btPuttyBrowser.Size = new global::System.Drawing.Size(26, 26);
			this.btPuttyBrowser.TabIndex = 2;
			this.btPuttyBrowser.UseVisualStyleBackColor = true;
			this.btPuttyBrowser.Click += new global::System.EventHandler(this.btPuttyBrowser_Click);
			this.txtPuttyLocation.Location = new global::System.Drawing.Point(81, 25);
			this.txtPuttyLocation.Name = "txtPuttyLocation";
			this.txtPuttyLocation.Size = new global::System.Drawing.Size(381, 23);
			this.txtPuttyLocation.TabIndex = 1;
			this.label4.AutoSize = true;
			this.label4.Location = new global::System.Drawing.Point(7, 28);
			this.label4.Name = "label4";
			this.label4.Size = new global::System.Drawing.Size(53, 15);
			this.label4.TabIndex = 0;
			this.label4.Text = "Location";
			this.groupDatabase.Controls.Add(this.label2);
			this.groupDatabase.Controls.Add(this.btDatabaseBrowser);
			this.groupDatabase.Controls.Add(this.txtDatabaseLocation);
			this.groupDatabase.Controls.Add(this.label1);
			this.groupDatabase.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.groupDatabase.Location = new global::System.Drawing.Point(18, 11);
			this.groupDatabase.Margin = new global::System.Windows.Forms.Padding(4);
			this.groupDatabase.Name = "groupDatabase";
			this.groupDatabase.Padding = new global::System.Windows.Forms.Padding(4);
			this.groupDatabase.Size = new global::System.Drawing.Size(505, 75);
			this.groupDatabase.TabIndex = 0;
			this.groupDatabase.TabStop = false;
			this.groupDatabase.Text = "Default database";
			this.label2.AutoSize = true;
			this.label2.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label2.Location = new global::System.Drawing.Point(78, 53);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(169, 15);
			this.label2.TabIndex = 3;
			this.label2.Text = "(For example: C:\\Database.dat)";
			this.btDatabaseBrowser.BackgroundImage = global::SessionManagement.Properties.Resources.OpenFile;
			this.btDatabaseBrowser.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Stretch;
			this.btDatabaseBrowser.Location = new global::System.Drawing.Point(468, 23);
			this.btDatabaseBrowser.Name = "btDatabaseBrowser";
			this.btDatabaseBrowser.Size = new global::System.Drawing.Size(26, 26);
			this.btDatabaseBrowser.TabIndex = 2;
			this.btDatabaseBrowser.UseVisualStyleBackColor = true;
			this.btDatabaseBrowser.Click += new global::System.EventHandler(this.btDatabaseBrowser_Click);
			this.txtDatabaseLocation.Location = new global::System.Drawing.Point(81, 23);
			this.txtDatabaseLocation.Name = "txtDatabaseLocation";
			this.txtDatabaseLocation.Size = new global::System.Drawing.Size(381, 23);
			this.txtDatabaseLocation.TabIndex = 1;
			this.label1.AutoSize = true;
			this.label1.Location = new global::System.Drawing.Point(7, 26);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(53, 15);
			this.label1.TabIndex = 0;
			this.label1.Text = "Location";
			this.btOK.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.btOK.Location = new global::System.Drawing.Point(364, 414);
			this.btOK.Name = "btOK";
			this.btOK.Size = new global::System.Drawing.Size(88, 27);
			this.btOK.TabIndex = 1;
			this.btOK.Text = "OK";
			this.btOK.UseVisualStyleBackColor = true;
			this.btOK.Click += new global::System.EventHandler(this.btOK_Click);
			this.btCancel.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.btCancel.Location = new global::System.Drawing.Point(458, 414);
			this.btCancel.Name = "btCancel";
			this.btCancel.Size = new global::System.Drawing.Size(88, 27);
			this.btCancel.TabIndex = 2;
			this.btCancel.Text = "Cancel";
			this.btCancel.UseVisualStyleBackColor = true;
			this.btCancel.Click += new global::System.EventHandler(this.btCancel_Click);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(9f, 18f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(551, 447);
			base.Controls.Add(this.btCancel);
			base.Controls.Add(this.btOK);
			base.Controls.Add(this.tabMain);
			this.Font = new global::System.Drawing.Font("Century Schoolbook", 11.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedSingle;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Margin = new global::System.Windows.Forms.Padding(4);
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "frmOptions";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Options...";
			base.Load += new global::System.EventHandler(this.frmOptions_Load);
			this.tabMain.ResumeLayout(false);
			this.tabpageGeneral.ResumeLayout(false);
			this.groupSessionManagerPosition.ResumeLayout(false);
			this.groupSessionManagerPosition.PerformLayout();
			this.groupWinSCP.ResumeLayout(false);
			this.groupWinSCP.PerformLayout();
			this.groupPutty.ResumeLayout(false);
			this.groupPutty.PerformLayout();
			this.groupDatabase.ResumeLayout(false);
			this.groupDatabase.PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x0400008B RID: 139
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x0400008C RID: 140
		private global::System.Windows.Forms.TabControl tabMain;

		// Token: 0x0400008D RID: 141
		private global::System.Windows.Forms.TabPage tabpageGeneral;

		// Token: 0x0400008E RID: 142
		private global::System.Windows.Forms.GroupBox groupDatabase;

		// Token: 0x0400008F RID: 143
		private global::System.Windows.Forms.Button btDatabaseBrowser;

		// Token: 0x04000090 RID: 144
		private global::System.Windows.Forms.TextBox txtDatabaseLocation;

		// Token: 0x04000091 RID: 145
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000092 RID: 146
		private global::System.Windows.Forms.GroupBox groupWinSCP;

		// Token: 0x04000093 RID: 147
		private global::System.Windows.Forms.Label label5;

		// Token: 0x04000094 RID: 148
		private global::System.Windows.Forms.Button btWinSCPBrowser;

		// Token: 0x04000095 RID: 149
		private global::System.Windows.Forms.TextBox txtWinSCPLocation;

		// Token: 0x04000096 RID: 150
		private global::System.Windows.Forms.Label label6;

		// Token: 0x04000097 RID: 151
		private global::System.Windows.Forms.GroupBox groupPutty;

		// Token: 0x04000098 RID: 152
		private global::System.Windows.Forms.Label label3;

		// Token: 0x04000099 RID: 153
		private global::System.Windows.Forms.Button btPuttyBrowser;

		// Token: 0x0400009A RID: 154
		private global::System.Windows.Forms.TextBox txtPuttyLocation;

		// Token: 0x0400009B RID: 155
		private global::System.Windows.Forms.Label label4;

		// Token: 0x0400009C RID: 156
		private global::System.Windows.Forms.Label label2;

		// Token: 0x0400009D RID: 157
		private global::System.Windows.Forms.Button btOK;

		// Token: 0x0400009E RID: 158
		private global::System.Windows.Forms.Button btCancel;

		// Token: 0x0400009F RID: 159
		private global::System.Windows.Forms.GroupBox groupSessionManagerPosition;

		// Token: 0x040000A0 RID: 160
		private global::System.Windows.Forms.RadioButton radRight;

		// Token: 0x040000A1 RID: 161
		private global::System.Windows.Forms.RadioButton radLeft;
	}
}
