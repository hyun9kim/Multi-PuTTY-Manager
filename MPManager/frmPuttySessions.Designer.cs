namespace SessionManagement
{
	// Token: 0x0200000C RID: 12
	public partial class frmPuttySessions : global::System.Windows.Forms.Form
	{
		// Token: 0x060000CC RID: 204 RVA: 0x0000AE9C File Offset: 0x0000909C
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060000CD RID: 205 RVA: 0x0000AED4 File Offset: 0x000090D4
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::SessionManagement.frmPuttySessions));
			this.btCancel = new global::System.Windows.Forms.Button();
			this.btCreateDatabase = new global::System.Windows.Forms.Button();
			this.dataGridPuttySession = new global::System.Windows.Forms.DataGridView();
			this.colName = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colHost = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.label1 = new global::System.Windows.Forms.Label();
			((global::System.ComponentModel.ISupportInitialize)this.dataGridPuttySession).BeginInit();
			base.SuspendLayout();
			this.btCancel.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.btCancel.Location = new global::System.Drawing.Point(344, 295);
			this.btCancel.Name = "btCancel";
			this.btCancel.Size = new global::System.Drawing.Size(104, 26);
			this.btCancel.TabIndex = 22;
			this.btCancel.Text = "Cancel";
			this.btCancel.UseVisualStyleBackColor = true;
			this.btCancel.Click += new global::System.EventHandler(this.btCancel_Click);
			this.btCreateDatabase.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.btCreateDatabase.Location = new global::System.Drawing.Point(224, 295);
			this.btCreateDatabase.Name = "btCreateDatabase";
			this.btCreateDatabase.Size = new global::System.Drawing.Size(116, 26);
			this.btCreateDatabase.TabIndex = 21;
			this.btCreateDatabase.Text = "Create Database";
			this.btCreateDatabase.UseVisualStyleBackColor = true;
			this.btCreateDatabase.Click += new global::System.EventHandler(this.btCreateDatabase_Click);
			this.dataGridPuttySession.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridPuttySession.Columns.AddRange(new global::System.Windows.Forms.DataGridViewColumn[]
			{
				this.colName,
				this.colHost
			});
			this.dataGridPuttySession.Location = new global::System.Drawing.Point(5, 38);
			this.dataGridPuttySession.Name = "dataGridPuttySession";
			this.dataGridPuttySession.ReadOnly = true;
			this.dataGridPuttySession.Size = new global::System.Drawing.Size(443, 251);
			this.dataGridPuttySession.TabIndex = 23;
			this.colName.HeaderText = "Session Name";
			this.colName.Name = "colName";
			this.colName.ReadOnly = true;
			this.colName.Width = 200;
			this.colHost.HeaderText = "Session Host/IP Address";
			this.colHost.Name = "colHost";
			this.colHost.ReadOnly = true;
			this.colHost.Width = 200;
			this.label1.AutoSize = true;
			this.label1.Font = new global::System.Drawing.Font("Segoe UI Symbol", 14.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label1.Location = new global::System.Drawing.Point(159, 4);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(141, 25);
			this.label1.TabIndex = 24;
			this.label1.Text = "PuTTY Sessions";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(7f, 15f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(453, 326);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.dataGridPuttySession);
			base.Controls.Add(this.btCancel);
			base.Controls.Add(this.btCreateDatabase);
			this.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedSingle;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "frmPuttySessions";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "PuTTY Sessions";
			base.Load += new global::System.EventHandler(this.frmPuttySessions_Load);
			((global::System.ComponentModel.ISupportInitialize)this.dataGridPuttySession).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x040000AD RID: 173
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x040000AE RID: 174
		private global::System.Windows.Forms.Button btCancel;

		// Token: 0x040000AF RID: 175
		private global::System.Windows.Forms.Button btCreateDatabase;

		// Token: 0x040000B0 RID: 176
		private global::System.Windows.Forms.DataGridView dataGridPuttySession;

		// Token: 0x040000B1 RID: 177
		private global::System.Windows.Forms.Label label1;

		// Token: 0x040000B2 RID: 178
		private global::System.Windows.Forms.DataGridViewTextBoxColumn colName;

		// Token: 0x040000B3 RID: 179
		private global::System.Windows.Forms.DataGridViewTextBoxColumn colHost;
	}
}
