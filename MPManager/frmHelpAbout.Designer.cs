namespace SessionManagement
{
	// Token: 0x02000005 RID: 5
	public partial class frmHelpAbout : global::System.Windows.Forms.Form
	{
		// Token: 0x06000082 RID: 130 RVA: 0x000076B4 File Offset: 0x000058B4
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000083 RID: 131 RVA: 0x000076EC File Offset: 0x000058EC
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::SessionManagement.frmHelpAbout));
			this.btOK = new global::System.Windows.Forms.Button();
			this.label1 = new global::System.Windows.Forms.Label();
			this.label2 = new global::System.Windows.Forms.Label();
			this.richTextBox1 = new global::System.Windows.Forms.RichTextBox();
			this.label3 = new global::System.Windows.Forms.Label();
			base.SuspendLayout();
			this.btOK.Font = new global::System.Drawing.Font("Segoe UI", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.btOK.Location = new global::System.Drawing.Point(379, 253);
			this.btOK.Name = "btOK";
			this.btOK.Size = new global::System.Drawing.Size(80, 25);
			this.btOK.TabIndex = 0;
			this.btOK.Text = "OK";
			this.btOK.UseVisualStyleBackColor = true;
			this.btOK.Click += new global::System.EventHandler(this.btOK_Click);
			this.label1.AutoSize = true;
			this.label1.Font = new global::System.Drawing.Font("Segoe UI Symbol", 14.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label1.Location = new global::System.Drawing.Point(130, 9);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(195, 25);
			this.label1.TabIndex = 1;
			this.label1.Text = "Multi PuTTY Manager";
			this.label2.AutoSize = true;
			this.label2.Location = new global::System.Drawing.Point(12, 259);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(160, 15);
			this.label2.TabIndex = 2;
			this.label2.Text = "Copyright © 2015 Hoan Tran";
			this.richTextBox1.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.richTextBox1.Location = new global::System.Drawing.Point(12, 74);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.ReadOnly = true;
			this.richTextBox1.Size = new global::System.Drawing.Size(447, 173);
			this.richTextBox1.TabIndex = 3;
			this.richTextBox1.Text = componentResourceManager.GetString("richTextBox1.Text");
			this.label3.AutoSize = true;
			this.label3.Location = new global::System.Drawing.Point(174, 40);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(91, 15);
			this.label3.TabIndex = 2;
			this.label3.Text = "Version 1.2.1109";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(7f, 15f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(471, 285);
			base.Controls.Add(this.richTextBox1);
			base.Controls.Add(this.label3);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.btOK);
			this.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedSingle;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "frmHelpAbout";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "About...";
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0400006E RID: 110
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x0400006F RID: 111
		private global::System.Windows.Forms.Button btOK;

		// Token: 0x04000070 RID: 112
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000071 RID: 113
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000072 RID: 114
		private global::System.Windows.Forms.RichTextBox richTextBox1;

		// Token: 0x04000073 RID: 115
		private global::System.Windows.Forms.Label label3;
	}
}
