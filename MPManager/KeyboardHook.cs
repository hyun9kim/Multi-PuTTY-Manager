using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace SessionManagement
{
	// Token: 0x02000017 RID: 23
	public sealed class KeyboardHook : IDisposable
	{
		// Token: 0x06000156 RID: 342
		[DllImport("User32.dll")]
		private static extern bool RegisterHotKey(IntPtr hWnd, int id, uint fsModifiers, uint vk);

		// Token: 0x06000157 RID: 343
		[DllImport("User32.dll")]
		private static extern bool UnregisterHotKey(IntPtr hWnd, int id);

		// Token: 0x06000158 RID: 344 RVA: 0x0001326C File Offset: 0x0001146C
		public KeyboardHook()
		{
			this._window.KeyPressed += delegate(object sender, KeyPressedEventArgs args)
			{
				if (this.KeyPressed != null)
				{
					this.KeyPressed(this, args);
				}
			};
		}

		// Token: 0x06000159 RID: 345 RVA: 0x000132B0 File Offset: 0x000114B0
		public void RegisterHotKey(ModifierKeys modifier, Keys key)
		{
			this._currentId++;
			if (!KeyboardHook.RegisterHotKey(this._window.Handle, this._currentId, (uint)modifier, (uint)key))
			{
				throw new InvalidOperationException("Couldn’t register the hot key.");
			}
		}

		// Token: 0x14000001 RID: 1
		// (add) Token: 0x0600015A RID: 346 RVA: 0x000132F4 File Offset: 0x000114F4
		// (remove) Token: 0x0600015B RID: 347 RVA: 0x00013330 File Offset: 0x00011530
		public event EventHandler<KeyPressedEventArgs> KeyPressed;

		// Token: 0x0600015C RID: 348 RVA: 0x0001336C File Offset: 0x0001156C
		public void Dispose()
		{
			for (int i = this._currentId; i > 0; i--)
			{
				KeyboardHook.UnregisterHotKey(this._window.Handle, i);
			}
			this._window.Dispose();
		}

		// Token: 0x04000137 RID: 311
		private KeyboardHook.Window _window = new KeyboardHook.Window();

		// Token: 0x04000138 RID: 312
		private int _currentId;

		// Token: 0x02000018 RID: 24
		private class Window : NativeWindow, IDisposable
		{
			// Token: 0x0600015E RID: 350 RVA: 0x000133AF File Offset: 0x000115AF
			public Window()
			{
				this.CreateHandle(new CreateParams());
			}

			// Token: 0x0600015F RID: 351 RVA: 0x000133C8 File Offset: 0x000115C8
			protected override void WndProc(ref Message m)
			{
				base.WndProc(ref m);
				if (m.Msg == KeyboardHook.Window.WM_HOTKEY)
				{
					Keys key = (Keys)((int)m.LParam >> 16 & 65535);
					ModifierKeys modifier = (ModifierKeys)((int)m.LParam & 65535);
					if (this.KeyPressed != null)
					{
						this.KeyPressed(this, new KeyPressedEventArgs(modifier, key));
					}
				}
			}

			// Token: 0x14000002 RID: 2
			// (add) Token: 0x06000160 RID: 352 RVA: 0x0001343C File Offset: 0x0001163C
			// (remove) Token: 0x06000161 RID: 353 RVA: 0x00013478 File Offset: 0x00011678
			public event EventHandler<KeyPressedEventArgs> KeyPressed;

			// Token: 0x06000162 RID: 354 RVA: 0x000134B4 File Offset: 0x000116B4
			public void Dispose()
			{
				this.DestroyHandle();
			}

			// Token: 0x0400013A RID: 314
			private static int WM_HOTKEY = 786;
		}
	}
}
