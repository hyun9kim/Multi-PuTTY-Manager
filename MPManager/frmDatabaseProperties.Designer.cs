namespace SessionManagement
{
	// Token: 0x02000003 RID: 3
	public partial class frmDatabaseProperties : global::System.Windows.Forms.Form
	{
		// Token: 0x0600007A RID: 122 RVA: 0x000070C0 File Offset: 0x000052C0
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600007B RID: 123 RVA: 0x000070F8 File Offset: 0x000052F8
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::SessionManagement.frmDatabaseProperties));
			this.label1 = new global::System.Windows.Forms.Label();
			this.label2 = new global::System.Windows.Forms.Label();
			this.groupBox1 = new global::System.Windows.Forms.GroupBox();
			this.lbLocation = new global::System.Windows.Forms.Label();
			this.btRename = new global::System.Windows.Forms.Button();
			this.txtDatabaseName = new global::System.Windows.Forms.TextBox();
			this.btCancel = new global::System.Windows.Forms.Button();
			this.btOK = new global::System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			base.SuspendLayout();
			this.label1.AutoSize = true;
			this.label1.Location = new global::System.Drawing.Point(19, 34);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(43, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "Name";
			this.label2.AutoSize = true;
			this.label2.Location = new global::System.Drawing.Point(19, 73);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(57, 17);
			this.label2.TabIndex = 0;
			this.label2.Text = "Location";
			this.groupBox1.Controls.Add(this.lbLocation);
			this.groupBox1.Controls.Add(this.btRename);
			this.groupBox1.Controls.Add(this.txtDatabaseName);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new global::System.Drawing.Point(12, 0);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new global::System.Drawing.Size(490, 135);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.lbLocation.AutoSize = true;
			this.lbLocation.Location = new global::System.Drawing.Point(102, 73);
			this.lbLocation.MaximumSize = new global::System.Drawing.Size(355, 50);
			this.lbLocation.Name = "lbLocation";
			this.lbLocation.Size = new global::System.Drawing.Size(68, 17);
			this.lbLocation.TabIndex = 3;
			this.lbLocation.Text = "lbLocation";
			this.btRename.Location = new global::System.Drawing.Point(386, 30);
			this.btRename.Name = "btRename";
			this.btRename.Size = new global::System.Drawing.Size(68, 27);
			this.btRename.TabIndex = 2;
			this.btRename.Text = "Rename";
			this.btRename.UseVisualStyleBackColor = true;
			this.btRename.Click += new global::System.EventHandler(this.btRename_Click);
			this.txtDatabaseName.Location = new global::System.Drawing.Point(105, 31);
			this.txtDatabaseName.Name = "txtDatabaseName";
			this.txtDatabaseName.Size = new global::System.Drawing.Size(275, 25);
			this.txtDatabaseName.TabIndex = 1;
			this.txtDatabaseName.TextChanged += new global::System.EventHandler(this.txtDatabaseName_TextChanged);
			this.txtDatabaseName.KeyPress += new global::System.Windows.Forms.KeyPressEventHandler(this.txtDatabaseName_KeyPress);
			this.btCancel.Location = new global::System.Drawing.Point(412, 143);
			this.btCancel.Name = "btCancel";
			this.btCancel.Size = new global::System.Drawing.Size(89, 27);
			this.btCancel.TabIndex = 2;
			this.btCancel.Text = "Cancel";
			this.btCancel.UseVisualStyleBackColor = true;
			this.btCancel.Click += new global::System.EventHandler(this.btCancel_Click);
			this.btOK.Location = new global::System.Drawing.Point(316, 143);
			this.btOK.Name = "btOK";
			this.btOK.Size = new global::System.Drawing.Size(89, 27);
			this.btOK.TabIndex = 2;
			this.btOK.Text = "OK";
			this.btOK.UseVisualStyleBackColor = true;
			this.btOK.Click += new global::System.EventHandler(this.btOK_Click);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(7f, 17f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(513, 179);
			base.Controls.Add(this.btOK);
			base.Controls.Add(this.btCancel);
			base.Controls.Add(this.groupBox1);
			this.Font = new global::System.Drawing.Font("Segoe UI", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedSingle;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "frmDatabaseProperties";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Database Properties";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x04000065 RID: 101
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000066 RID: 102
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000067 RID: 103
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000068 RID: 104
		private global::System.Windows.Forms.GroupBox groupBox1;

		// Token: 0x04000069 RID: 105
		private global::System.Windows.Forms.TextBox txtDatabaseName;

		// Token: 0x0400006A RID: 106
		private global::System.Windows.Forms.Button btCancel;

		// Token: 0x0400006B RID: 107
		private global::System.Windows.Forms.Button btOK;

		// Token: 0x0400006C RID: 108
		private global::System.Windows.Forms.Button btRename;

		// Token: 0x0400006D RID: 109
		private global::System.Windows.Forms.Label lbLocation;
	}
}
