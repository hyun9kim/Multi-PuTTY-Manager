namespace SessionManagement
{
	// Token: 0x0200000E RID: 14
	public partial class frmSession : global::System.Windows.Forms.Form
	{
		// Token: 0x060000E7 RID: 231 RVA: 0x0000BF70 File Offset: 0x0000A170
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x0000BFA8 File Offset: 0x0000A1A8
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::SessionManagement.frmSession));
			this.btOK = new global::System.Windows.Forms.Button();
			this.tabMain = new global::System.Windows.Forms.TabControl();
			this.tabpageSession = new global::System.Windows.Forms.TabPage();
			this.groupBox1 = new global::System.Windows.Forms.GroupBox();
			this.groupBox2 = new global::System.Windows.Forms.GroupBox();
			this.btShowSessionPassword = new global::System.Windows.Forms.Button();
			this.txtSessionPassword = new global::System.Windows.Forms.TextBox();
			this.label6 = new global::System.Windows.Forms.Label();
			this.txtSessionUserName = new global::System.Windows.Forms.TextBox();
			this.label5 = new global::System.Windows.Forms.Label();
			this.label7 = new global::System.Windows.Forms.Label();
			this.richDescription = new global::System.Windows.Forms.RichTextBox();
			this.numPort = new global::System.Windows.Forms.NumericUpDown();
			this.cmbPuttySession = new global::System.Windows.Forms.ComboBox();
			this.cmbProtocol = new global::System.Windows.Forms.ComboBox();
			this.txtHost = new global::System.Windows.Forms.TextBox();
			this.txtName = new global::System.Windows.Forms.TextBox();
			this.label21 = new global::System.Windows.Forms.Label();
			this.label4 = new global::System.Windows.Forms.Label();
			this.label3 = new global::System.Windows.Forms.Label();
			this.label2 = new global::System.Windows.Forms.Label();
			this.label1 = new global::System.Windows.Forms.Label();
			this.tabpageAdvancedSession = new global::System.Windows.Forms.TabPage();
			this.groupBox6 = new global::System.Windows.Forms.GroupBox();
			this.label19 = new global::System.Windows.Forms.Label();
			this.label18 = new global::System.Windows.Forms.Label();
			this.numPasswordTimeout = new global::System.Windows.Forms.NumericUpDown();
			this.numConnectionTimeout = new global::System.Windows.Forms.NumericUpDown();
			this.label20 = new global::System.Windows.Forms.Label();
			this.numUsernameTimeout = new global::System.Windows.Forms.NumericUpDown();
			this.label17 = new global::System.Windows.Forms.Label();
			this.numCommandTimeout = new global::System.Windows.Forms.NumericUpDown();
			this.groupPostLoginCommand = new global::System.Windows.Forms.GroupBox();
			this.label12 = new global::System.Windows.Forms.Label();
			this.label11 = new global::System.Windows.Forms.Label();
			this.label10 = new global::System.Windows.Forms.Label();
			this.label9 = new global::System.Windows.Forms.Label();
			this.label8 = new global::System.Windows.Forms.Label();
			this.checkPostLogin = new global::System.Windows.Forms.CheckBox();
			this.tabpageExtraConnect = new global::System.Windows.Forms.TabPage();
			this.groupBox5 = new global::System.Windows.Forms.GroupBox();
			this.btShowSFTPPassword = new global::System.Windows.Forms.Button();
			this.txtSFTPPassword = new global::System.Windows.Forms.TextBox();
			this.label15 = new global::System.Windows.Forms.Label();
			this.txtSFTPUserName = new global::System.Windows.Forms.TextBox();
			this.label16 = new global::System.Windows.Forms.Label();
			this.groupBox4 = new global::System.Windows.Forms.GroupBox();
			this.btShowFTPPassword = new global::System.Windows.Forms.Button();
			this.txtFTPPassword = new global::System.Windows.Forms.TextBox();
			this.label13 = new global::System.Windows.Forms.Label();
			this.txtFTPUserName = new global::System.Windows.Forms.TextBox();
			this.label14 = new global::System.Windows.Forms.Label();
			this.btCancel = new global::System.Windows.Forms.Button();
			this.tabMain.SuspendLayout();
			this.tabpageSession.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.numPort).BeginInit();
			this.tabpageAdvancedSession.SuspendLayout();
			this.groupBox6.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.numPasswordTimeout).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.numConnectionTimeout).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.numUsernameTimeout).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.numCommandTimeout).BeginInit();
			this.groupPostLoginCommand.SuspendLayout();
			this.tabpageExtraConnect.SuspendLayout();
			this.groupBox5.SuspendLayout();
			this.groupBox4.SuspendLayout();
			base.SuspendLayout();
			this.btOK.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.btOK.Location = new global::System.Drawing.Point(307, 406);
			this.btOK.Name = "btOK";
			this.btOK.Size = new global::System.Drawing.Size(89, 27);
			this.btOK.TabIndex = 19;
			this.btOK.Text = "OK";
			this.btOK.UseVisualStyleBackColor = true;
			this.btOK.Click += new global::System.EventHandler(this.btOK_Click);
			this.tabMain.Controls.Add(this.tabpageSession);
			this.tabMain.Controls.Add(this.tabpageAdvancedSession);
			this.tabMain.Controls.Add(this.tabpageExtraConnect);
			this.tabMain.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.tabMain.Location = new global::System.Drawing.Point(1, 6);
			this.tabMain.Name = "tabMain";
			this.tabMain.SelectedIndex = 0;
			this.tabMain.Size = new global::System.Drawing.Size(494, 394);
			this.tabMain.TabIndex = 2;
			this.tabpageSession.Controls.Add(this.groupBox1);
			this.tabpageSession.Location = new global::System.Drawing.Point(4, 24);
			this.tabpageSession.Name = "tabpageSession";
			this.tabpageSession.Padding = new global::System.Windows.Forms.Padding(3);
			this.tabpageSession.Size = new global::System.Drawing.Size(486, 366);
			this.tabpageSession.TabIndex = 0;
			this.tabpageSession.Text = "Session";
			this.tabpageSession.UseVisualStyleBackColor = true;
			this.groupBox1.Controls.Add(this.groupBox2);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.richDescription);
			this.groupBox1.Controls.Add(this.numPort);
			this.groupBox1.Controls.Add(this.cmbPuttySession);
			this.groupBox1.Controls.Add(this.cmbProtocol);
			this.groupBox1.Controls.Add(this.txtHost);
			this.groupBox1.Controls.Add(this.txtName);
			this.groupBox1.Controls.Add(this.label21);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.groupBox1.Location = new global::System.Drawing.Point(33, 5);
			this.groupBox1.Margin = new global::System.Windows.Forms.Padding(4);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new global::System.Windows.Forms.Padding(4);
			this.groupBox1.Size = new global::System.Drawing.Size(420, 352);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox2.Controls.Add(this.btShowSessionPassword);
			this.groupBox2.Controls.Add(this.txtSessionPassword);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Controls.Add(this.txtSessionUserName);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Location = new global::System.Drawing.Point(30, 245);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new global::System.Drawing.Size(350, 95);
			this.groupBox2.TabIndex = 13;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Auto-login credentials";
			this.btShowSessionPassword.BackgroundImage = global::SessionManagement.Properties.Resources.ShowPassword;
			this.btShowSessionPassword.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Center;
			this.btShowSessionPassword.Location = new global::System.Drawing.Point(301, 59);
			this.btShowSessionPassword.Name = "btShowSessionPassword";
			this.btShowSessionPassword.Size = new global::System.Drawing.Size(26, 26);
			this.btShowSessionPassword.TabIndex = 16;
			this.btShowSessionPassword.UseVisualStyleBackColor = true;
			this.btShowSessionPassword.Click += new global::System.EventHandler(this.btShowSessionPassword_Click);
			this.txtSessionPassword.Font = new global::System.Drawing.Font("Century Schoolbook", 11.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.txtSessionPassword.Location = new global::System.Drawing.Point(103, 59);
			this.txtSessionPassword.Name = "txtSessionPassword";
			this.txtSessionPassword.PasswordChar = '*';
			this.txtSessionPassword.Size = new global::System.Drawing.Size(194, 26);
			this.txtSessionPassword.TabIndex = 15;
			this.label6.AutoSize = true;
			this.label6.Location = new global::System.Drawing.Point(19, 63);
			this.label6.Name = "label6";
			this.label6.Size = new global::System.Drawing.Size(57, 15);
			this.label6.TabIndex = 14;
			this.label6.Text = "Password";
			this.txtSessionUserName.Location = new global::System.Drawing.Point(103, 29);
			this.txtSessionUserName.Name = "txtSessionUserName";
			this.txtSessionUserName.Size = new global::System.Drawing.Size(194, 23);
			this.txtSessionUserName.TabIndex = 13;
			this.label5.AutoSize = true;
			this.label5.Location = new global::System.Drawing.Point(19, 32);
			this.label5.Name = "label5";
			this.label5.Size = new global::System.Drawing.Size(63, 15);
			this.label5.TabIndex = 12;
			this.label5.Text = "User name";
			this.label7.AutoSize = true;
			this.label7.Location = new global::System.Drawing.Point(29, 178);
			this.label7.Name = "label7";
			this.label7.Size = new global::System.Drawing.Size(67, 15);
			this.label7.TabIndex = 5;
			this.label7.Text = "Description";
			this.richDescription.Location = new global::System.Drawing.Point(138, 173);
			this.richDescription.Name = "richDescription";
			this.richDescription.Size = new global::System.Drawing.Size(242, 53);
			this.richDescription.TabIndex = 5;
			this.richDescription.Text = "";
			this.numPort.Location = new global::System.Drawing.Point(138, 113);
			global::System.Windows.Forms.NumericUpDown numericUpDown = this.numPort;
			int[] array = new int[4];
			array[0] = 32000;
			numericUpDown.Maximum = new decimal(array);
			this.numPort.Name = "numPort";
			this.numPort.Size = new global::System.Drawing.Size(83, 23);
			this.numPort.TabIndex = 3;
			global::System.Windows.Forms.NumericUpDown numericUpDown2 = this.numPort;
			array = new int[4];
			array[0] = 22;
			numericUpDown2.Value = new decimal(array);
			this.cmbPuttySession.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbPuttySession.FormattingEnabled = true;
			this.cmbPuttySession.Items.AddRange(new object[]
			{
				"Default Settings"
			});
			this.cmbPuttySession.Location = new global::System.Drawing.Point(138, 143);
			this.cmbPuttySession.MaxDropDownItems = 100;
			this.cmbPuttySession.Name = "cmbPuttySession";
			this.cmbPuttySession.Size = new global::System.Drawing.Size(192, 23);
			this.cmbPuttySession.TabIndex = 4;
			this.cmbProtocol.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbProtocol.FormattingEnabled = true;
			this.cmbProtocol.Items.AddRange(new object[]
			{
				"Telnet",
				"SSH",
				"Raw",
				"RLogin"
			});
			this.cmbProtocol.Location = new global::System.Drawing.Point(138, 82);
			this.cmbProtocol.Name = "cmbProtocol";
			this.cmbProtocol.Size = new global::System.Drawing.Size(83, 23);
			this.cmbProtocol.TabIndex = 2;
			this.cmbProtocol.SelectedIndexChanged += new global::System.EventHandler(this.cmbProtocol_SelectedIndexChanged);
			this.txtHost.Location = new global::System.Drawing.Point(138, 18);
			this.txtHost.Name = "txtHost";
			this.txtHost.Size = new global::System.Drawing.Size(242, 23);
			this.txtHost.TabIndex = 0;
			this.txtHost.TextChanged += new global::System.EventHandler(this.txtHost_TextChanged);
			this.txtName.Location = new global::System.Drawing.Point(138, 50);
			this.txtName.Name = "txtName";
			this.txtName.Size = new global::System.Drawing.Size(242, 23);
			this.txtName.TabIndex = 1;
			this.txtName.TextChanged += new global::System.EventHandler(this.txtName_TextChanged);
			this.txtName.Enter += new global::System.EventHandler(this.txtName_Enter);
			this.label21.AutoSize = true;
			this.label21.Location = new global::System.Drawing.Point(29, 147);
			this.label21.Name = "label21";
			this.label21.Size = new global::System.Drawing.Size(81, 15);
			this.label21.TabIndex = 0;
			this.label21.Text = "PuTTY setting";
			this.label4.AutoSize = true;
			this.label4.Location = new global::System.Drawing.Point(29, 116);
			this.label4.Name = "label4";
			this.label4.Size = new global::System.Drawing.Size(29, 15);
			this.label4.TabIndex = 0;
			this.label4.Text = "Port";
			this.label3.AutoSize = true;
			this.label3.Location = new global::System.Drawing.Point(29, 86);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(52, 15);
			this.label3.TabIndex = 0;
			this.label3.Text = "Protocol";
			this.label2.AutoSize = true;
			this.label2.Location = new global::System.Drawing.Point(29, 24);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(92, 15);
			this.label2.TabIndex = 0;
			this.label2.Text = "Host/IP Address";
			this.label1.AutoSize = true;
			this.label1.Location = new global::System.Drawing.Point(29, 54);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(39, 15);
			this.label1.TabIndex = 0;
			this.label1.Text = "Name";
			this.tabpageAdvancedSession.Controls.Add(this.groupBox6);
			this.tabpageAdvancedSession.Controls.Add(this.groupPostLoginCommand);
			this.tabpageAdvancedSession.Location = new global::System.Drawing.Point(4, 24);
			this.tabpageAdvancedSession.Name = "tabpageAdvancedSession";
			this.tabpageAdvancedSession.Padding = new global::System.Windows.Forms.Padding(3);
			this.tabpageAdvancedSession.Size = new global::System.Drawing.Size(486, 366);
			this.tabpageAdvancedSession.TabIndex = 1;
			this.tabpageAdvancedSession.Text = "Advanced Session";
			this.tabpageAdvancedSession.UseVisualStyleBackColor = true;
			this.groupBox6.Controls.Add(this.label19);
			this.groupBox6.Controls.Add(this.label18);
			this.groupBox6.Controls.Add(this.numPasswordTimeout);
			this.groupBox6.Controls.Add(this.numConnectionTimeout);
			this.groupBox6.Controls.Add(this.label20);
			this.groupBox6.Controls.Add(this.numUsernameTimeout);
			this.groupBox6.Controls.Add(this.label17);
			this.groupBox6.Controls.Add(this.numCommandTimeout);
			this.groupBox6.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.groupBox6.Location = new global::System.Drawing.Point(39, 20);
			this.groupBox6.Name = "groupBox6";
			this.groupBox6.Size = new global::System.Drawing.Size(404, 100);
			this.groupBox6.TabIndex = 14;
			this.groupBox6.TabStop = false;
			this.groupBox6.Text = "Timeout (ms)";
			this.label19.AutoSize = true;
			this.label19.Location = new global::System.Drawing.Point(231, 30);
			this.label19.Name = "label19";
			this.label19.Size = new global::System.Drawing.Size(57, 15);
			this.label19.TabIndex = 25;
			this.label19.Text = "Password";
			this.label18.AutoSize = true;
			this.label18.Location = new global::System.Drawing.Point(17, 30);
			this.label18.Name = "label18";
			this.label18.Size = new global::System.Drawing.Size(69, 15);
			this.label18.TabIndex = 25;
			this.label18.Text = "Connection";
			global::System.Windows.Forms.NumericUpDown numericUpDown3 = this.numPasswordTimeout;
			array = new int[4];
			array[0] = 100;
			numericUpDown3.Increment = new decimal(array);
			this.numPasswordTimeout.Location = new global::System.Drawing.Point(321, 28);
			global::System.Windows.Forms.NumericUpDown numericUpDown4 = this.numPasswordTimeout;
			array = new int[4];
			array[0] = 30000;
			numericUpDown4.Maximum = new decimal(array);
			global::System.Windows.Forms.NumericUpDown numericUpDown5 = this.numPasswordTimeout;
			array = new int[4];
			array[0] = 500;
			numericUpDown5.Minimum = new decimal(array);
			this.numPasswordTimeout.Name = "numPasswordTimeout";
			this.numPasswordTimeout.Size = new global::System.Drawing.Size(67, 23);
			this.numPasswordTimeout.TabIndex = 11;
			global::System.Windows.Forms.NumericUpDown numericUpDown6 = this.numPasswordTimeout;
			array = new int[4];
			array[0] = 1000;
			numericUpDown6.Value = new decimal(array);
			global::System.Windows.Forms.NumericUpDown numericUpDown7 = this.numConnectionTimeout;
			array = new int[4];
			array[0] = 100;
			numericUpDown7.Increment = new decimal(array);
			this.numConnectionTimeout.Location = new global::System.Drawing.Point(107, 28);
			global::System.Windows.Forms.NumericUpDown numericUpDown8 = this.numConnectionTimeout;
			array = new int[4];
			array[0] = 30000;
			numericUpDown8.Maximum = new decimal(array);
			global::System.Windows.Forms.NumericUpDown numericUpDown9 = this.numConnectionTimeout;
			array = new int[4];
			array[0] = 500;
			numericUpDown9.Minimum = new decimal(array);
			this.numConnectionTimeout.Name = "numConnectionTimeout";
			this.numConnectionTimeout.Size = new global::System.Drawing.Size(67, 23);
			this.numConnectionTimeout.TabIndex = 9;
			global::System.Windows.Forms.NumericUpDown numericUpDown10 = this.numConnectionTimeout;
			array = new int[4];
			array[0] = 1500;
			numericUpDown10.Value = new decimal(array);
			this.label20.AutoSize = true;
			this.label20.Location = new global::System.Drawing.Point(17, 63);
			this.label20.Name = "label20";
			this.label20.Size = new global::System.Drawing.Size(63, 15);
			this.label20.TabIndex = 25;
			this.label20.Text = "User name";
			global::System.Windows.Forms.NumericUpDown numericUpDown11 = this.numUsernameTimeout;
			array = new int[4];
			array[0] = 100;
			numericUpDown11.Increment = new decimal(array);
			this.numUsernameTimeout.Location = new global::System.Drawing.Point(107, 61);
			global::System.Windows.Forms.NumericUpDown numericUpDown12 = this.numUsernameTimeout;
			array = new int[4];
			array[0] = 30000;
			numericUpDown12.Maximum = new decimal(array);
			global::System.Windows.Forms.NumericUpDown numericUpDown13 = this.numUsernameTimeout;
			array = new int[4];
			array[0] = 500;
			numericUpDown13.Minimum = new decimal(array);
			this.numUsernameTimeout.Name = "numUsernameTimeout";
			this.numUsernameTimeout.Size = new global::System.Drawing.Size(67, 23);
			this.numUsernameTimeout.TabIndex = 10;
			global::System.Windows.Forms.NumericUpDown numericUpDown14 = this.numUsernameTimeout;
			array = new int[4];
			array[0] = 1000;
			numericUpDown14.Value = new decimal(array);
			this.label17.AutoSize = true;
			this.label17.Location = new global::System.Drawing.Point(231, 65);
			this.label17.Name = "label17";
			this.label17.Size = new global::System.Drawing.Size(64, 15);
			this.label17.TabIndex = 25;
			this.label17.Text = "Command";
			global::System.Windows.Forms.NumericUpDown numericUpDown15 = this.numCommandTimeout;
			array = new int[4];
			array[0] = 100;
			numericUpDown15.Increment = new decimal(array);
			this.numCommandTimeout.Location = new global::System.Drawing.Point(321, 63);
			global::System.Windows.Forms.NumericUpDown numericUpDown16 = this.numCommandTimeout;
			array = new int[4];
			array[0] = 30000;
			numericUpDown16.Maximum = new decimal(array);
			global::System.Windows.Forms.NumericUpDown numericUpDown17 = this.numCommandTimeout;
			array = new int[4];
			array[0] = 500;
			numericUpDown17.Minimum = new decimal(array);
			this.numCommandTimeout.Name = "numCommandTimeout";
			this.numCommandTimeout.Size = new global::System.Drawing.Size(67, 23);
			this.numCommandTimeout.TabIndex = 12;
			global::System.Windows.Forms.NumericUpDown numericUpDown18 = this.numCommandTimeout;
			array = new int[4];
			array[0] = 1000;
			numericUpDown18.Value = new decimal(array);
			this.groupPostLoginCommand.Controls.Add(this.label12);
			this.groupPostLoginCommand.Controls.Add(this.label11);
			this.groupPostLoginCommand.Controls.Add(this.label10);
			this.groupPostLoginCommand.Controls.Add(this.label9);
			this.groupPostLoginCommand.Controls.Add(this.label8);
			this.groupPostLoginCommand.Controls.Add(this.checkPostLogin);
			this.groupPostLoginCommand.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.groupPostLoginCommand.Location = new global::System.Drawing.Point(39, 134);
			this.groupPostLoginCommand.Name = "groupPostLoginCommand";
			this.groupPostLoginCommand.Size = new global::System.Drawing.Size(404, 204);
			this.groupPostLoginCommand.TabIndex = 13;
			this.groupPostLoginCommand.TabStop = false;
			this.groupPostLoginCommand.Text = "Post-login commands";
			this.label12.AutoSize = true;
			this.label12.Location = new global::System.Drawing.Point(21, 177);
			this.label12.Name = "label12";
			this.label12.Size = new global::System.Drawing.Size(73, 15);
			this.label12.TabIndex = 23;
			this.label12.Text = "Command 5";
			this.label11.AutoSize = true;
			this.label11.Location = new global::System.Drawing.Point(22, 147);
			this.label11.Name = "label11";
			this.label11.Size = new global::System.Drawing.Size(73, 15);
			this.label11.TabIndex = 22;
			this.label11.Text = "Command 4";
			this.label10.AutoSize = true;
			this.label10.Location = new global::System.Drawing.Point(22, 117);
			this.label10.Name = "label10";
			this.label10.Size = new global::System.Drawing.Size(73, 15);
			this.label10.TabIndex = 21;
			this.label10.Text = "Command 3";
			this.label9.AutoSize = true;
			this.label9.Location = new global::System.Drawing.Point(22, 87);
			this.label9.Name = "label9";
			this.label9.Size = new global::System.Drawing.Size(73, 15);
			this.label9.TabIndex = 20;
			this.label9.Text = "Command 2";
			this.label8.AutoSize = true;
			this.label8.Location = new global::System.Drawing.Point(22, 57);
			this.label8.Name = "label8";
			this.label8.Size = new global::System.Drawing.Size(73, 15);
			this.label8.TabIndex = 19;
			this.label8.Text = "Command 1";
			this.checkPostLogin.AutoSize = true;
			this.checkPostLogin.ImageAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.checkPostLogin.Location = new global::System.Drawing.Point(116, 27);
			this.checkPostLogin.Name = "checkPostLogin";
			this.checkPostLogin.Size = new global::System.Drawing.Size(61, 19);
			this.checkPostLogin.TabIndex = 13;
			this.checkPostLogin.Text = "Enable";
			this.checkPostLogin.UseVisualStyleBackColor = true;
			this.checkPostLogin.CheckedChanged += new global::System.EventHandler(this.checkPostLogin_CheckedChanged);
			this.tabpageExtraConnect.Controls.Add(this.groupBox5);
			this.tabpageExtraConnect.Controls.Add(this.groupBox4);
			this.tabpageExtraConnect.Location = new global::System.Drawing.Point(4, 24);
			this.tabpageExtraConnect.Name = "tabpageExtraConnect";
			this.tabpageExtraConnect.Padding = new global::System.Windows.Forms.Padding(3);
			this.tabpageExtraConnect.Size = new global::System.Drawing.Size(486, 366);
			this.tabpageExtraConnect.TabIndex = 2;
			this.tabpageExtraConnect.Text = "Extra Connection";
			this.tabpageExtraConnect.UseVisualStyleBackColor = true;
			this.tabpageExtraConnect.Enter += new global::System.EventHandler(this.tabpageExtraConnect_Enter);
			this.groupBox5.Controls.Add(this.btShowSFTPPassword);
			this.groupBox5.Controls.Add(this.txtSFTPPassword);
			this.groupBox5.Controls.Add(this.label15);
			this.groupBox5.Controls.Add(this.txtSFTPUserName);
			this.groupBox5.Controls.Add(this.label16);
			this.groupBox5.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.groupBox5.Location = new global::System.Drawing.Point(58, 202);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Size = new global::System.Drawing.Size(370, 109);
			this.groupBox5.TabIndex = 1;
			this.groupBox5.TabStop = false;
			this.groupBox5.Text = "SFTP";
			this.btShowSFTPPassword.BackgroundImage = global::SessionManagement.Properties.Resources.ShowPassword;
			this.btShowSFTPPassword.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Center;
			this.btShowSFTPPassword.Location = new global::System.Drawing.Point(308, 61);
			this.btShowSFTPPassword.Name = "btShowSFTPPassword";
			this.btShowSFTPPassword.Size = new global::System.Drawing.Size(26, 26);
			this.btShowSFTPPassword.TabIndex = 22;
			this.btShowSFTPPassword.UseVisualStyleBackColor = true;
			this.btShowSFTPPassword.Click += new global::System.EventHandler(this.btShowSFTPPassword_Click);
			this.txtSFTPPassword.Location = new global::System.Drawing.Point(110, 61);
			this.txtSFTPPassword.Name = "txtSFTPPassword";
			this.txtSFTPPassword.PasswordChar = '*';
			this.txtSFTPPassword.Size = new global::System.Drawing.Size(192, 23);
			this.txtSFTPPassword.TabIndex = 19;
			this.label15.AutoSize = true;
			this.label15.Location = new global::System.Drawing.Point(22, 64);
			this.label15.Name = "label15";
			this.label15.Size = new global::System.Drawing.Size(57, 15);
			this.label15.TabIndex = 18;
			this.label15.Text = "Password";
			this.txtSFTPUserName.Location = new global::System.Drawing.Point(110, 29);
			this.txtSFTPUserName.Name = "txtSFTPUserName";
			this.txtSFTPUserName.Size = new global::System.Drawing.Size(192, 23);
			this.txtSFTPUserName.TabIndex = 17;
			this.label16.AutoSize = true;
			this.label16.Location = new global::System.Drawing.Point(22, 33);
			this.label16.Name = "label16";
			this.label16.Size = new global::System.Drawing.Size(63, 15);
			this.label16.TabIndex = 16;
			this.label16.Text = "User name";
			this.groupBox4.Controls.Add(this.btShowFTPPassword);
			this.groupBox4.Controls.Add(this.txtFTPPassword);
			this.groupBox4.Controls.Add(this.label13);
			this.groupBox4.Controls.Add(this.txtFTPUserName);
			this.groupBox4.Controls.Add(this.label14);
			this.groupBox4.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.groupBox4.Location = new global::System.Drawing.Point(58, 42);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new global::System.Drawing.Size(370, 109);
			this.groupBox4.TabIndex = 0;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "FTP";
			this.btShowFTPPassword.BackgroundImage = global::SessionManagement.Properties.Resources.ShowPassword;
			this.btShowFTPPassword.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Center;
			this.btShowFTPPassword.Location = new global::System.Drawing.Point(308, 62);
			this.btShowFTPPassword.Name = "btShowFTPPassword";
			this.btShowFTPPassword.Size = new global::System.Drawing.Size(26, 26);
			this.btShowFTPPassword.TabIndex = 21;
			this.btShowFTPPassword.UseVisualStyleBackColor = true;
			this.btShowFTPPassword.Click += new global::System.EventHandler(this.btShowFTPPassword_Click);
			this.txtFTPPassword.Location = new global::System.Drawing.Point(110, 62);
			this.txtFTPPassword.Name = "txtFTPPassword";
			this.txtFTPPassword.PasswordChar = '*';
			this.txtFTPPassword.Size = new global::System.Drawing.Size(192, 23);
			this.txtFTPPassword.TabIndex = 19;
			this.label13.AutoSize = true;
			this.label13.Location = new global::System.Drawing.Point(22, 65);
			this.label13.Name = "label13";
			this.label13.Size = new global::System.Drawing.Size(57, 15);
			this.label13.TabIndex = 18;
			this.label13.Text = "Password";
			this.txtFTPUserName.Location = new global::System.Drawing.Point(110, 29);
			this.txtFTPUserName.Name = "txtFTPUserName";
			this.txtFTPUserName.Size = new global::System.Drawing.Size(192, 23);
			this.txtFTPUserName.TabIndex = 17;
			this.label14.AutoSize = true;
			this.label14.Location = new global::System.Drawing.Point(22, 34);
			this.label14.Name = "label14";
			this.label14.Size = new global::System.Drawing.Size(63, 15);
			this.label14.TabIndex = 16;
			this.label14.Text = "User name";
			this.btCancel.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.btCancel.Location = new global::System.Drawing.Point(402, 406);
			this.btCancel.Name = "btCancel";
			this.btCancel.Size = new global::System.Drawing.Size(89, 27);
			this.btCancel.TabIndex = 20;
			this.btCancel.Text = "Cancel";
			this.btCancel.UseVisualStyleBackColor = true;
			this.btCancel.Click += new global::System.EventHandler(this.btCancel_Click);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(9f, 18f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(495, 445);
			base.Controls.Add(this.btCancel);
			base.Controls.Add(this.tabMain);
			base.Controls.Add(this.btOK);
			this.Font = new global::System.Drawing.Font("Century Schoolbook", 11.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedSingle;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Margin = new global::System.Windows.Forms.Padding(4);
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "frmSession";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Session....";
			base.Load += new global::System.EventHandler(this.frmSession_Load);
			this.tabMain.ResumeLayout(false);
			this.tabpageSession.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.numPort).EndInit();
			this.tabpageAdvancedSession.ResumeLayout(false);
			this.groupBox6.ResumeLayout(false);
			this.groupBox6.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.numPasswordTimeout).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.numConnectionTimeout).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.numUsernameTimeout).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.numCommandTimeout).EndInit();
			this.groupPostLoginCommand.ResumeLayout(false);
			this.groupPostLoginCommand.PerformLayout();
			this.tabpageExtraConnect.ResumeLayout(false);
			this.groupBox5.ResumeLayout(false);
			this.groupBox5.PerformLayout();
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x040000B7 RID: 183
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x040000B8 RID: 184
		private global::System.Windows.Forms.Button btOK;

		// Token: 0x040000B9 RID: 185
		private global::System.Windows.Forms.TabControl tabMain;

		// Token: 0x040000BA RID: 186
		private global::System.Windows.Forms.TabPage tabpageSession;

		// Token: 0x040000BB RID: 187
		private global::System.Windows.Forms.GroupBox groupBox1;

		// Token: 0x040000BC RID: 188
		private global::System.Windows.Forms.NumericUpDown numPort;

		// Token: 0x040000BD RID: 189
		private global::System.Windows.Forms.ComboBox cmbProtocol;

		// Token: 0x040000BE RID: 190
		private global::System.Windows.Forms.TextBox txtHost;

		// Token: 0x040000BF RID: 191
		private global::System.Windows.Forms.TextBox txtName;

		// Token: 0x040000C0 RID: 192
		private global::System.Windows.Forms.Label label4;

		// Token: 0x040000C1 RID: 193
		private global::System.Windows.Forms.Label label3;

		// Token: 0x040000C2 RID: 194
		private global::System.Windows.Forms.Label label2;

		// Token: 0x040000C3 RID: 195
		private global::System.Windows.Forms.Label label1;

		// Token: 0x040000C4 RID: 196
		private global::System.Windows.Forms.TabPage tabpageAdvancedSession;

		// Token: 0x040000C5 RID: 197
		private global::System.Windows.Forms.Label label7;

		// Token: 0x040000C6 RID: 198
		private global::System.Windows.Forms.RichTextBox richDescription;

		// Token: 0x040000C7 RID: 199
		private global::System.Windows.Forms.GroupBox groupPostLoginCommand;

		// Token: 0x040000C8 RID: 200
		private global::System.Windows.Forms.Label label12;

		// Token: 0x040000C9 RID: 201
		private global::System.Windows.Forms.Label label11;

		// Token: 0x040000CA RID: 202
		private global::System.Windows.Forms.Label label10;

		// Token: 0x040000CB RID: 203
		private global::System.Windows.Forms.Label label9;

		// Token: 0x040000CC RID: 204
		private global::System.Windows.Forms.Label label8;

		// Token: 0x040000CD RID: 205
		private global::System.Windows.Forms.CheckBox checkPostLogin;

		// Token: 0x040000CE RID: 206
		private global::System.Windows.Forms.Button btCancel;

		// Token: 0x040000CF RID: 207
		private global::System.Windows.Forms.Label label17;

		// Token: 0x040000D0 RID: 208
		private global::System.Windows.Forms.NumericUpDown numCommandTimeout;

		// Token: 0x040000D1 RID: 209
		private global::System.Windows.Forms.TabPage tabpageExtraConnect;

		// Token: 0x040000D2 RID: 210
		private global::System.Windows.Forms.GroupBox groupBox5;

		// Token: 0x040000D3 RID: 211
		private global::System.Windows.Forms.Button btShowSFTPPassword;

		// Token: 0x040000D4 RID: 212
		private global::System.Windows.Forms.TextBox txtSFTPPassword;

		// Token: 0x040000D5 RID: 213
		private global::System.Windows.Forms.Label label15;

		// Token: 0x040000D6 RID: 214
		private global::System.Windows.Forms.TextBox txtSFTPUserName;

		// Token: 0x040000D7 RID: 215
		private global::System.Windows.Forms.Label label16;

		// Token: 0x040000D8 RID: 216
		private global::System.Windows.Forms.GroupBox groupBox4;

		// Token: 0x040000D9 RID: 217
		private global::System.Windows.Forms.Button btShowFTPPassword;

		// Token: 0x040000DA RID: 218
		private global::System.Windows.Forms.TextBox txtFTPPassword;

		// Token: 0x040000DB RID: 219
		private global::System.Windows.Forms.Label label13;

		// Token: 0x040000DC RID: 220
		private global::System.Windows.Forms.TextBox txtFTPUserName;

		// Token: 0x040000DD RID: 221
		private global::System.Windows.Forms.Label label14;

		// Token: 0x040000DE RID: 222
		private global::System.Windows.Forms.GroupBox groupBox2;

		// Token: 0x040000DF RID: 223
		private global::System.Windows.Forms.Button btShowSessionPassword;

		// Token: 0x040000E0 RID: 224
		private global::System.Windows.Forms.TextBox txtSessionPassword;

		// Token: 0x040000E1 RID: 225
		private global::System.Windows.Forms.Label label6;

		// Token: 0x040000E2 RID: 226
		private global::System.Windows.Forms.TextBox txtSessionUserName;

		// Token: 0x040000E3 RID: 227
		private global::System.Windows.Forms.Label label5;

		// Token: 0x040000E4 RID: 228
		private global::System.Windows.Forms.GroupBox groupBox6;

		// Token: 0x040000E5 RID: 229
		private global::System.Windows.Forms.Label label19;

		// Token: 0x040000E6 RID: 230
		private global::System.Windows.Forms.Label label18;

		// Token: 0x040000E7 RID: 231
		private global::System.Windows.Forms.NumericUpDown numPasswordTimeout;

		// Token: 0x040000E8 RID: 232
		private global::System.Windows.Forms.NumericUpDown numConnectionTimeout;

		// Token: 0x040000E9 RID: 233
		private global::System.Windows.Forms.Label label20;

		// Token: 0x040000EA RID: 234
		private global::System.Windows.Forms.NumericUpDown numUsernameTimeout;

		// Token: 0x040000EB RID: 235
		private global::System.Windows.Forms.ComboBox cmbPuttySession;

		// Token: 0x040000EC RID: 236
		private global::System.Windows.Forms.Label label21;
	}
}
