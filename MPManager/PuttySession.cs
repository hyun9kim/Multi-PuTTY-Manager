using System;

namespace SessionManagement
{
	// Token: 0x0200001D RID: 29
	internal class PuttySession
	{
		// Token: 0x17000013 RID: 19
		// (get) Token: 0x0600017B RID: 379 RVA: 0x00013850 File Offset: 0x00011A50
		// (set) Token: 0x0600017C RID: 380 RVA: 0x00013868 File Offset: 0x00011A68
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

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x0600017D RID: 381 RVA: 0x00013874 File Offset: 0x00011A74
		// (set) Token: 0x0600017E RID: 382 RVA: 0x0001388C File Offset: 0x00011A8C
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

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x0600017F RID: 383 RVA: 0x00013898 File Offset: 0x00011A98
		// (set) Token: 0x06000180 RID: 384 RVA: 0x000138B0 File Offset: 0x00011AB0
		public string userName
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

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000181 RID: 385 RVA: 0x000138BC File Offset: 0x00011ABC
		// (set) Token: 0x06000182 RID: 386 RVA: 0x000138D4 File Offset: 0x00011AD4
		public string protocol
		{
			get
			{
				return this.prot;
			}
			set
			{
				this.prot = value;
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000183 RID: 387 RVA: 0x000138E0 File Offset: 0x00011AE0
		// (set) Token: 0x06000184 RID: 388 RVA: 0x000138F8 File Offset: 0x00011AF8
		public int portNumber
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

		// Token: 0x04000145 RID: 325
		private string name;

		// Token: 0x04000146 RID: 326
		private string host;

		// Token: 0x04000147 RID: 327
		private string prot;

		// Token: 0x04000148 RID: 328
		private int port;

		// Token: 0x04000149 RID: 329
		private string username;
	}
}
