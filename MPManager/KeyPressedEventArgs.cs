using System;
using System.Windows.Forms;

namespace SessionManagement
{
	// Token: 0x02000019 RID: 25
	public class KeyPressedEventArgs : EventArgs
	{
		// Token: 0x06000164 RID: 356 RVA: 0x000134CA File Offset: 0x000116CA
		internal KeyPressedEventArgs(ModifierKeys modifier, Keys key)
		{
			this._modifier = modifier;
			this._key = key;
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000165 RID: 357 RVA: 0x000134E4 File Offset: 0x000116E4
		public ModifierKeys Modifier
		{
			get
			{
				return this._modifier;
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000166 RID: 358 RVA: 0x000134FC File Offset: 0x000116FC
		public Keys Key
		{
			get
			{
				return this._key;
			}
		}

		// Token: 0x0400013C RID: 316
		private ModifierKeys _modifier;

		// Token: 0x0400013D RID: 317
		private Keys _key;
	}
}
