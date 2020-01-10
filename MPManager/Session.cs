using System;
using System.Collections;

namespace SessionManagement
{
	// Token: 0x0200001E RID: 30
	public class Session
	{
		// Token: 0x06000185 RID: 389 RVA: 0x00013904 File Offset: 0x00011B04
		public Session()
		{
			this.port = -1;
			this.postlogin = false;
			this.connectiontimeout = 2000;
			this.usernametimout = 1000;
			this.passtimout = 1000;
			this.commandTimeout = 1000;
			this.arrCommands = new ArrayList();
			this.ID = -1;
			this.username = "";
			this.pass = "";
			this.description = "";
			this.config = Global.strCreatePuttySetting;
			this.sftpusername = "";
			this.sftppass = "";
			this.ftpusername = "";
			this.ftppass = "";
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000186 RID: 390 RVA: 0x000139C0 File Offset: 0x00011BC0
		// (set) Token: 0x06000187 RID: 391 RVA: 0x000139D8 File Offset: 0x00011BD8
		public int sessionID
		{
			get
			{
				return this.ID;
			}
			set
			{
				this.ID = value;
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000188 RID: 392 RVA: 0x000139E4 File Offset: 0x00011BE4
		// (set) Token: 0x06000189 RID: 393 RVA: 0x000139FC File Offset: 0x00011BFC
		public string sessionName
		{
			get
			{
				return this.name;
			}
			set
			{
				this.name = value;
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x0600018A RID: 394 RVA: 0x00013A08 File Offset: 0x00011C08
		// (set) Token: 0x0600018B RID: 395 RVA: 0x00013A20 File Offset: 0x00011C20
		public string sessionHost
		{
			get
			{
				return this.host;
			}
			set
			{
				this.host = value;
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x0600018C RID: 396 RVA: 0x00013A2C File Offset: 0x00011C2C
		// (set) Token: 0x0600018D RID: 397 RVA: 0x00013A44 File Offset: 0x00011C44
		public int sessionPort
		{
			get
			{
				return this.port;
			}
			set
			{
				this.port = value;
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x0600018E RID: 398 RVA: 0x00013A50 File Offset: 0x00011C50
		// (set) Token: 0x0600018F RID: 399 RVA: 0x00013A68 File Offset: 0x00011C68
		public string sessionProtocol
		{
			get
			{
				return this.protocol;
			}
			set
			{
				this.protocol = value;
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000190 RID: 400 RVA: 0x00013A74 File Offset: 0x00011C74
		// (set) Token: 0x06000191 RID: 401 RVA: 0x00013A8C File Offset: 0x00011C8C
		public string sessionDescription
		{
			get
			{
				return this.description;
			}
			set
			{
				this.description = value;
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000192 RID: 402 RVA: 0x00013A98 File Offset: 0x00011C98
		// (set) Token: 0x06000193 RID: 403 RVA: 0x00013AB0 File Offset: 0x00011CB0
		public string sessionConfig
		{
			get
			{
				return this.config;
			}
			set
			{
				this.config = value;
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000194 RID: 404 RVA: 0x00013ABC File Offset: 0x00011CBC
		// (set) Token: 0x06000195 RID: 405 RVA: 0x00013AD4 File Offset: 0x00011CD4
		public string sessionUserName
		{
			get
			{
				return this.username;
			}
			set
			{
				this.username = value;
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000196 RID: 406 RVA: 0x00013AE0 File Offset: 0x00011CE0
		// (set) Token: 0x06000197 RID: 407 RVA: 0x00013AF8 File Offset: 0x00011CF8
		public string sessionPassword
		{
			get
			{
				return this.pass;
			}
			set
			{
				this.pass = value;
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x06000198 RID: 408 RVA: 0x00013B04 File Offset: 0x00011D04
		// (set) Token: 0x06000199 RID: 409 RVA: 0x00013B1C File Offset: 0x00011D1C
		public int connectionTimeout
		{
			get
			{
				return this.connectiontimeout;
			}
			set
			{
				this.connectiontimeout = value;
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x0600019A RID: 410 RVA: 0x00013B28 File Offset: 0x00011D28
		// (set) Token: 0x0600019B RID: 411 RVA: 0x00013B40 File Offset: 0x00011D40
		public int usernameTimeout
		{
			get
			{
				return this.usernametimout;
			}
			set
			{
				this.usernametimout = value;
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x0600019C RID: 412 RVA: 0x00013B4C File Offset: 0x00011D4C
		// (set) Token: 0x0600019D RID: 413 RVA: 0x00013B64 File Offset: 0x00011D64
		public int passwordTimeout
		{
			get
			{
				return this.passtimout;
			}
			set
			{
				this.passtimout = value;
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x0600019E RID: 414 RVA: 0x00013B70 File Offset: 0x00011D70
		// (set) Token: 0x0600019F RID: 415 RVA: 0x00013B88 File Offset: 0x00011D88
		public bool postLogin
		{
			get
			{
				return this.postlogin;
			}
			set
			{
				this.postlogin = value;
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x060001A0 RID: 416 RVA: 0x00013B94 File Offset: 0x00011D94
		// (set) Token: 0x060001A1 RID: 417 RVA: 0x00013BAC File Offset: 0x00011DAC
		public int commandTimeout
		{
			get
			{
				return this.commandtimeout;
			}
			set
			{
				this.commandtimeout = value;
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x060001A2 RID: 418 RVA: 0x00013BB8 File Offset: 0x00011DB8
		// (set) Token: 0x060001A3 RID: 419 RVA: 0x00013BD0 File Offset: 0x00011DD0
		public ArrayList postLoginCommands
		{
			get
			{
				return this.arrCommands;
			}
			set
			{
				this.arrCommands = value;
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x060001A4 RID: 420 RVA: 0x00013BDC File Offset: 0x00011DDC
		// (set) Token: 0x060001A5 RID: 421 RVA: 0x00013BF4 File Offset: 0x00011DF4
		public string sftpUserName
		{
			get
			{
				return this.sftpusername;
			}
			set
			{
				this.sftpusername = value;
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x060001A6 RID: 422 RVA: 0x00013C00 File Offset: 0x00011E00
		// (set) Token: 0x060001A7 RID: 423 RVA: 0x00013C18 File Offset: 0x00011E18
		public string sftpPassword
		{
			get
			{
				return this.sftppass;
			}
			set
			{
				this.sftppass = value;
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x060001A8 RID: 424 RVA: 0x00013C24 File Offset: 0x00011E24
		// (set) Token: 0x060001A9 RID: 425 RVA: 0x00013C3C File Offset: 0x00011E3C
		public string ftpUserName
		{
			get
			{
				return this.ftpusername;
			}
			set
			{
				this.ftpusername = value;
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x060001AA RID: 426 RVA: 0x00013C48 File Offset: 0x00011E48
		// (set) Token: 0x060001AB RID: 427 RVA: 0x00013C60 File Offset: 0x00011E60
		public string ftpPassword
		{
			get
			{
				return this.ftppass;
			}
			set
			{
				this.ftppass = value;
			}
		}

		// Token: 0x060001AC RID: 428 RVA: 0x00013C6C File Offset: 0x00011E6C
		public void copySession(Session fromSession)
		{
			this.name = fromSession.name;
			this.host = fromSession.host;
			this.port = fromSession.port;
			this.protocol = fromSession.protocol;
			this.description = fromSession.description;
			this.username = fromSession.username;
			this.pass = fromSession.pass;
			this.postlogin = fromSession.postlogin;
			this.connectiontimeout = fromSession.connectiontimeout;
			this.usernametimout = fromSession.usernametimout;
			this.passtimout = fromSession.passtimout;
			this.commandtimeout = fromSession.commandtimeout;
			this.arrCommands = fromSession.arrCommands;
			this.config = fromSession.config;
			this.sftpusername = fromSession.sftpusername;
			this.sftppass = fromSession.sftppass;
			this.ftpusername = fromSession.ftpusername;
			this.ftppass = fromSession.ftppass;
			this.sessionID = fromSession.sessionID;
		}

		// Token: 0x0400014A RID: 330
		private string name;

		// Token: 0x0400014B RID: 331
		private string host;

		// Token: 0x0400014C RID: 332
		private int port;

		// Token: 0x0400014D RID: 333
		private string protocol;

		// Token: 0x0400014E RID: 334
		private string description;

		// Token: 0x0400014F RID: 335
		private string username;

		// Token: 0x04000150 RID: 336
		private string pass;

		// Token: 0x04000151 RID: 337
		private int connectiontimeout;

		// Token: 0x04000152 RID: 338
		private int usernametimout;

		// Token: 0x04000153 RID: 339
		private int passtimout;

		// Token: 0x04000154 RID: 340
		private bool postlogin;

		// Token: 0x04000155 RID: 341
		private int commandtimeout;

		// Token: 0x04000156 RID: 342
		private ArrayList arrCommands;

		// Token: 0x04000157 RID: 343
		private string config;

		// Token: 0x04000158 RID: 344
		private string sftpusername;

		// Token: 0x04000159 RID: 345
		private string sftppass;

		// Token: 0x0400015A RID: 346
		private string ftpusername;

		// Token: 0x0400015B RID: 347
		private string ftppass;

		// Token: 0x0400015C RID: 348
		private int ID;
	}
}
