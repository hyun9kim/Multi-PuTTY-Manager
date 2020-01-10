using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace SessionManagement
{
	// Token: 0x02000006 RID: 6
	public partial class frmMultiCommands : Form
	{
		// Token: 0x06000084 RID: 132 RVA: 0x00007ACD File Offset: 0x00005CCD
		public frmMultiCommands()
		{
			this.InitializeComponent();
			this.loadCommand = false;
			this.defaultTimeout = 500;
		}

		// Token: 0x06000085 RID: 133 RVA: 0x00007B00 File Offset: 0x00005D00
		public ArrayList readTextFile(string filename)
		{
			ArrayList arrayList = new ArrayList();
			ArrayList result;
			try
			{
				StreamReader streamReader = new StreamReader(filename);
				for (string text = streamReader.ReadLine(); text != null; text = streamReader.ReadLine())
				{
					arrayList.Add(text);
				}
				streamReader.Close();
				result = arrayList;
			}
			catch (Exception ex)
			{
				result = null;
			}
			return result;
		}

		// Token: 0x06000086 RID: 134 RVA: 0x00007B6C File Offset: 0x00005D6C
		public void WriteFile(string filename, ArrayList commandList)
		{
			try
			{
				StreamWriter streamWriter = new StreamWriter(filename);
				for (int i = 0; i < commandList.Count - 1; i++)
				{
					streamWriter.WriteLine(commandList[i].ToString());
				}
				streamWriter.Write(commandList[commandList.Count - 1].ToString());
				streamWriter.Close();
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06000087 RID: 135 RVA: 0x00007BE8 File Offset: 0x00005DE8
		private void btCancel_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000088 RID: 136 RVA: 0x00007BF4 File Offset: 0x00005DF4
		private void btFileBrowser_Click(object sender, EventArgs e)
		{
			try
			{
				OpenFileDialog openFileDialog = new OpenFileDialog();
				openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
				openFileDialog.FilterIndex = 0;
				openFileDialog.RestoreDirectory = true;
				if (openFileDialog.ShowDialog() == DialogResult.OK)
				{
					string fileName = openFileDialog.FileName;
					this.txtFileName.Text = fileName;
					this.arrCommands = this.readTextFile(fileName);
					this.loadCommandsToDataGridView(this.arrCommands);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("btFileBrowser_Click\n" + ex.ToString());
			}
		}

		// Token: 0x06000089 RID: 137 RVA: 0x00007C9C File Offset: 0x00005E9C
		public void loadCommandsToDataGridView(ArrayList commandList)
		{
			if (commandList != null)
			{
				try
				{
					this.loadCommand = true;
					string[] array = new string[0];
					this.dataGridCommands.Rows.Clear();
					for (int i = 0; i < commandList.Count; i++)
					{
						array = commandList[i].ToString().Split(new char[]
						{
							';'
						});
						this.dataGridCommands.Rows.Add(new object[]
						{
							array[0],
							array[1]
						});
					}
					this.loadCommand = false;
				}
				catch (Exception ex)
				{
					this.loadCommand = false;
				}
			}
		}

		// Token: 0x0600008A RID: 138 RVA: 0x00007D64 File Offset: 0x00005F64
		public ArrayList getCommandsFromDataGridView()
		{
			ArrayList arrayList = new ArrayList();
			int num = 100;
			ArrayList result;
			try
			{
				for (int i = 0; i < this.dataGridCommands.Rows.Count - 1; i++)
				{
					if (this.dataGridCommands.Rows[i].Cells[1].Value == null)
					{
						MessageBox.Show("The timout of command #" + (i + 1).ToString() + " should be an interger!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
						return null;
					}
					if (!int.TryParse(this.dataGridCommands.Rows[i].Cells[1].Value.ToString(), out num))
					{
						MessageBox.Show("The timout of command #" + (i + 1).ToString() + " should be an interger!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
						return null;
					}
					if (int.Parse(this.dataGridCommands.Rows[i].Cells[1].Value.ToString()) < 0)
					{
						MessageBox.Show("The timout of command #" + (i + 1).ToString() + " should be a positive interger!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
						return null;
					}
					string value = this.dataGridCommands.Rows[i].Cells[0].Value + ";" + this.dataGridCommands.Rows[i].Cells[1].Value;
					arrayList.Add(value);
				}
				result = arrayList;
			}
			catch (Exception ex)
			{
				result = null;
			}
			return result;
		}

		// Token: 0x0600008B RID: 139 RVA: 0x00007F5C File Offset: 0x0000615C
		private void btOK_Click(object sender, EventArgs e)
		{
			try
			{
				ArrayList commandsFromDataGridView = this.getCommandsFromDataGridView();
				if (commandsFromDataGridView != null)
				{
					if (commandsFromDataGridView.Count > 0)
					{
						this.runMultiCommands(commandsFromDataGridView);
						base.Close();
					}
					else
					{
						MessageBox.Show("No command found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					}
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x0600008C RID: 140 RVA: 0x00007FD4 File Offset: 0x000061D4
		private void contextDeleteRow_Click(object sender, EventArgs e)
		{
			if (this.dataGridCommands.SelectedRows.Count > 0)
			{
				try
				{
					this.dataGridCommands.Rows.Remove(this.dataGridCommands.SelectedRows[0]);
				}
				catch (Exception ex)
				{
				}
			}
		}

		// Token: 0x0600008D RID: 141 RVA: 0x00008038 File Offset: 0x00006238
		private void contextForDataGridCommands_Opening(object sender, CancelEventArgs e)
		{
		}

		// Token: 0x0600008E RID: 142 RVA: 0x0000803C File Offset: 0x0000623C
		private void dataGridCommands_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			this.dataGridCommands.Rows[e.RowIndex].Selected = true;
			int num = this.dataGridCommands.Rows[0].Height * (e.RowIndex + 1);
			if (e.Button == MouseButtons.Right)
			{
				this.contextForDataGridCommands.Show(this.dataGridCommands, e.X, e.Y + num);
			}
		}

		// Token: 0x0600008F RID: 143 RVA: 0x000080BC File Offset: 0x000062BC
		private void contextInsertRow_Click(object sender, EventArgs e)
		{
			if (this.dataGridCommands.SelectedRows.Count > 0)
			{
				try
				{
					this.dataGridCommands.Rows.Insert(this.dataGridCommands.SelectedRows[0].Index, 1);
				}
				catch (Exception ex)
				{
				}
			}
		}

		// Token: 0x06000090 RID: 144 RVA: 0x00008128 File Offset: 0x00006328
		private void dataGridCommands_CellEnter(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				if (e.ColumnIndex == 1 && e.RowIndex < this.dataGridCommands.Rows.Count - 1 && this.dataGridCommands.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == null)
				{
					this.dataGridCommands.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = this.defaultTimeout;
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06000091 RID: 145 RVA: 0x000081E4 File Offset: 0x000063E4
		private void btNewFile_Click(object sender, EventArgs e)
		{
			try
			{
				while (this.dataGridCommands.Rows.Count > 1)
				{
					this.dataGridCommands.Rows.RemoveAt(0);
				}
			}
			catch (Exception ex)
			{
			}
			this.loadCommand = false;
			this.txtFileName.Text = "";
			this.dataGridCommands.Focus();
		}

		// Token: 0x06000092 RID: 146 RVA: 0x0000825C File Offset: 0x0000645C
		private void btSaveFile_Click(object sender, EventArgs e)
		{
			try
			{
				ArrayList commandsFromDataGridView = this.getCommandsFromDataGridView();
				if (commandsFromDataGridView != null)
				{
					if (!File.Exists(this.txtFileName.Text))
					{
						SaveFileDialog saveFileDialog = new SaveFileDialog();
						saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
						saveFileDialog.FilterIndex = 1;
						saveFileDialog.RestoreDirectory = true;
						if (saveFileDialog.ShowDialog() == DialogResult.OK)
						{
							this.txtFileName.Text = saveFileDialog.FileName;
						}
					}
					this.WriteFile(this.txtFileName.Text, commandsFromDataGridView);
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06000093 RID: 147 RVA: 0x00008308 File Offset: 0x00006508
		private void btSaveFileAs_Click(object sender, EventArgs e)
		{
			try
			{
				ArrayList commandsFromDataGridView = this.getCommandsFromDataGridView();
				if (commandsFromDataGridView != null)
				{
					SaveFileDialog saveFileDialog = new SaveFileDialog();
					saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
					saveFileDialog.FilterIndex = 1;
					saveFileDialog.RestoreDirectory = true;
					if (saveFileDialog.ShowDialog() == DialogResult.OK)
					{
						this.txtFileName.Text = saveFileDialog.FileName;
					}
					this.WriteFile(this.txtFileName.Text, commandsFromDataGridView);
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06000094 RID: 148 RVA: 0x0000839C File Offset: 0x0000659C
		private void dataGridCommands_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
		{
			if (!this.loadCommand)
			{
				if (this.dataGridCommands.Rows[e.RowIndex].Cells[1].Value == null)
				{
					if (this.dataGridCommands.Rows[e.RowIndex - 1].Cells[1].Value == null)
					{
						this.dataGridCommands.Rows[e.RowIndex - 1].Cells[1].Value = this.defaultTimeout;
					}
				}
			}
		}

		// Token: 0x04000074 RID: 116
		private ArrayList arrCommands = null;

		// Token: 0x04000075 RID: 117
		public frmMultiCommands.RunMultiCommands runMultiCommands;

		// Token: 0x04000076 RID: 118
		private bool loadCommand;

		// Token: 0x04000077 RID: 119
		private int defaultTimeout;

		// Token: 0x02000007 RID: 7
		// (Invoke) Token: 0x06000098 RID: 152
		public delegate void RunMultiCommands(ArrayList arrCommands);
	}
}
