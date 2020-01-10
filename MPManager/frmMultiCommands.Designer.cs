namespace SessionManagement
{
	// Token: 0x02000006 RID: 6
	public partial class frmMultiCommands : global::System.Windows.Forms.Form
	{
		// Token: 0x06000095 RID: 149 RVA: 0x00008454 File Offset: 0x00006654
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000096 RID: 150 RVA: 0x0000848C File Offset: 0x0000668C
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::SessionManagement.frmMultiCommands));
			this.groupBox1 = new global::System.Windows.Forms.GroupBox();
			this.label1 = new global::System.Windows.Forms.Label();
			this.txtFileName = new global::System.Windows.Forms.TextBox();
			this.btFileBrowser = new global::System.Windows.Forms.Button();
			this.contextForDataGridCommands = new global::System.Windows.Forms.ContextMenuStrip(this.components);
			this.contextDeleteRow = new global::System.Windows.Forms.ToolStripMenuItem();
			this.contextInsertRow = new global::System.Windows.Forms.ToolStripMenuItem();
			this.btCancel = new global::System.Windows.Forms.Button();
			this.btOK = new global::System.Windows.Forms.Button();
			this.groupBox2 = new global::System.Windows.Forms.GroupBox();
			this.btSaveFileAs = new global::System.Windows.Forms.Button();
			this.btSaveFile = new global::System.Windows.Forms.Button();
			this.btNewFile = new global::System.Windows.Forms.Button();
			this.dataGridCommands = new global::System.Windows.Forms.DataGridView();
			this.colCommand = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colTimeout = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.groupBox1.SuspendLayout();
			this.contextForDataGridCommands.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dataGridCommands).BeginInit();
			base.SuspendLayout();
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.txtFileName);
			this.groupBox1.Controls.Add(this.btFileBrowser);
			this.groupBox1.Location = new global::System.Drawing.Point(8, -1);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new global::System.Drawing.Size(572, 48);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.label1.AutoSize = true;
			this.label1.Location = new global::System.Drawing.Point(4, 19);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(97, 17);
			this.label1.TabIndex = 5;
			this.label1.Text = "Commands File";
			this.txtFileName.Location = new global::System.Drawing.Point(104, 16);
			this.txtFileName.Name = "txtFileName";
			this.txtFileName.ReadOnly = true;
			this.txtFileName.Size = new global::System.Drawing.Size(374, 25);
			this.txtFileName.TabIndex = 4;
			this.btFileBrowser.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Stretch;
			this.btFileBrowser.Location = new global::System.Drawing.Point(484, 16);
			this.btFileBrowser.Name = "btFileBrowser";
			this.btFileBrowser.Size = new global::System.Drawing.Size(80, 25);
			this.btFileBrowser.TabIndex = 3;
			this.btFileBrowser.Text = "Open";
			this.btFileBrowser.UseVisualStyleBackColor = true;
			this.btFileBrowser.Click += new global::System.EventHandler(this.btFileBrowser_Click);
			this.contextForDataGridCommands.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.contextDeleteRow,
				this.contextInsertRow
			});
			this.contextForDataGridCommands.Name = "contextForDataGridCommands";
			this.contextForDataGridCommands.Size = new global::System.Drawing.Size(134, 48);
			this.contextForDataGridCommands.Opening += new global::System.ComponentModel.CancelEventHandler(this.contextForDataGridCommands_Opening);
			this.contextDeleteRow.Name = "contextDeleteRow";
			this.contextDeleteRow.Size = new global::System.Drawing.Size(133, 22);
			this.contextDeleteRow.Text = "Delete Row";
			this.contextDeleteRow.Click += new global::System.EventHandler(this.contextDeleteRow_Click);
			this.contextInsertRow.Name = "contextInsertRow";
			this.contextInsertRow.Size = new global::System.Drawing.Size(133, 22);
			this.contextInsertRow.Text = "Insert Row";
			this.contextInsertRow.Click += new global::System.EventHandler(this.contextInsertRow_Click);
			this.btCancel.Font = new global::System.Drawing.Font("Segoe UI", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.btCancel.Location = new global::System.Drawing.Point(492, 387);
			this.btCancel.Name = "btCancel";
			this.btCancel.Size = new global::System.Drawing.Size(88, 27);
			this.btCancel.TabIndex = 4;
			this.btCancel.Text = "Cancel";
			this.btCancel.UseVisualStyleBackColor = true;
			this.btCancel.Click += new global::System.EventHandler(this.btCancel_Click);
			this.btOK.Font = new global::System.Drawing.Font("Segoe UI", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.btOK.Location = new global::System.Drawing.Point(398, 387);
			this.btOK.Name = "btOK";
			this.btOK.Size = new global::System.Drawing.Size(88, 27);
			this.btOK.TabIndex = 3;
			this.btOK.Text = "Run";
			this.btOK.UseVisualStyleBackColor = true;
			this.btOK.Click += new global::System.EventHandler(this.btOK_Click);
			this.groupBox2.Controls.Add(this.btSaveFileAs);
			this.groupBox2.Controls.Add(this.btSaveFile);
			this.groupBox2.Controls.Add(this.btNewFile);
			this.groupBox2.Controls.Add(this.dataGridCommands);
			this.groupBox2.Location = new global::System.Drawing.Point(8, 49);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new global::System.Drawing.Size(572, 333);
			this.groupBox2.TabIndex = 5;
			this.groupBox2.TabStop = false;
			this.btSaveFileAs.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Stretch;
			this.btSaveFileAs.Location = new global::System.Drawing.Point(168, 302);
			this.btSaveFileAs.Name = "btSaveFileAs";
			this.btSaveFileAs.Size = new global::System.Drawing.Size(80, 25);
			this.btSaveFileAs.TabIndex = 4;
			this.btSaveFileAs.Text = "Save As";
			this.btSaveFileAs.UseVisualStyleBackColor = true;
			this.btSaveFileAs.Click += new global::System.EventHandler(this.btSaveFileAs_Click);
			this.btSaveFile.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Stretch;
			this.btSaveFile.Location = new global::System.Drawing.Point(87, 302);
			this.btSaveFile.Name = "btSaveFile";
			this.btSaveFile.Size = new global::System.Drawing.Size(80, 25);
			this.btSaveFile.TabIndex = 4;
			this.btSaveFile.Text = "Save";
			this.btSaveFile.UseVisualStyleBackColor = true;
			this.btSaveFile.Click += new global::System.EventHandler(this.btSaveFile_Click);
			this.btNewFile.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Stretch;
			this.btNewFile.Location = new global::System.Drawing.Point(6, 302);
			this.btNewFile.Name = "btNewFile";
			this.btNewFile.Size = new global::System.Drawing.Size(80, 25);
			this.btNewFile.TabIndex = 4;
			this.btNewFile.Text = "New";
			this.btNewFile.UseVisualStyleBackColor = true;
			this.btNewFile.Click += new global::System.EventHandler(this.btNewFile_Click);
			this.dataGridCommands.AllowUserToResizeRows = false;
			dataGridViewCellStyle.Alignment = global::System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle.BackColor = global::System.Drawing.Color.FromArgb(224, 224, 224);
			dataGridViewCellStyle.Font = new global::System.Drawing.Font("Segoe UI", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			dataGridViewCellStyle.ForeColor = global::System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle.SelectionBackColor = global::System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle.SelectionForeColor = global::System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle.WrapMode = global::System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridCommands.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle;
			this.dataGridCommands.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridCommands.Columns.AddRange(new global::System.Windows.Forms.DataGridViewColumn[]
			{
				this.colCommand,
				this.colTimeout
			});
			this.dataGridCommands.EditMode = global::System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
			this.dataGridCommands.EnableHeadersVisualStyles = false;
			this.dataGridCommands.Location = new global::System.Drawing.Point(4, 15);
			this.dataGridCommands.MultiSelect = false;
			this.dataGridCommands.Name = "dataGridCommands";
			this.dataGridCommands.RowHeadersBorderStyle = global::System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			this.dataGridCommands.RowHeadersWidth = 30;
			this.dataGridCommands.Size = new global::System.Drawing.Size(562, 281);
			this.dataGridCommands.TabIndex = 2;
			this.dataGridCommands.CellEnter += new global::System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridCommands_CellEnter);
			this.dataGridCommands.RowHeaderMouseClick += new global::System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridCommands_RowHeaderMouseClick);
			this.dataGridCommands.RowsAdded += new global::System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridCommands_RowsAdded);
			this.colCommand.Frozen = true;
			this.colCommand.HeaderText = "Command";
			this.colCommand.Name = "colCommand";
			this.colCommand.SortMode = global::System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.colCommand.Width = 430;
			this.colTimeout.HeaderText = "Timeout (ms)";
			this.colTimeout.Name = "colTimeout";
			this.colTimeout.SortMode = global::System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(7f, 17f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(592, 420);
			base.Controls.Add(this.groupBox2);
			base.Controls.Add(this.btCancel);
			base.Controls.Add(this.btOK);
			base.Controls.Add(this.groupBox1);
			this.Font = new global::System.Drawing.Font("Segoe UI", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedSingle;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "frmMultiCommands";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Multi Commands";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.contextForDataGridCommands.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.dataGridCommands).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x04000078 RID: 120
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000079 RID: 121
		private global::System.Windows.Forms.GroupBox groupBox1;

		// Token: 0x0400007A RID: 122
		private global::System.Windows.Forms.Button btFileBrowser;

		// Token: 0x0400007B RID: 123
		private global::System.Windows.Forms.TextBox txtFileName;

		// Token: 0x0400007C RID: 124
		private global::System.Windows.Forms.Button btCancel;

		// Token: 0x0400007D RID: 125
		private global::System.Windows.Forms.Button btOK;

		// Token: 0x0400007E RID: 126
		private global::System.Windows.Forms.ContextMenuStrip contextForDataGridCommands;

		// Token: 0x0400007F RID: 127
		private global::System.Windows.Forms.ToolStripMenuItem contextDeleteRow;

		// Token: 0x04000080 RID: 128
		private global::System.Windows.Forms.ToolStripMenuItem contextInsertRow;

		// Token: 0x04000081 RID: 129
		private global::System.Windows.Forms.GroupBox groupBox2;

		// Token: 0x04000082 RID: 130
		private global::System.Windows.Forms.DataGridView dataGridCommands;

		// Token: 0x04000083 RID: 131
		private global::System.Windows.Forms.Button btSaveFile;

		// Token: 0x04000084 RID: 132
		private global::System.Windows.Forms.Button btNewFile;

		// Token: 0x04000085 RID: 133
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000086 RID: 134
		private global::System.Windows.Forms.Button btSaveFileAs;

		// Token: 0x04000087 RID: 135
		private global::System.Windows.Forms.DataGridViewTextBoxColumn colCommand;

		// Token: 0x04000088 RID: 136
		private global::System.Windows.Forms.DataGridViewTextBoxColumn colTimeout;
	}
}
