using System;
using System.Collections;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.Win32;

namespace SessionManagement
{
	// Token: 0x02000016 RID: 22
	public static class Global
	{
		// Token: 0x0600014A RID: 330
		[DllImport("user32.dll", SetLastError = true)]
		private static extern bool PostMessage(IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam);

		// Token: 0x0600014B RID: 331 RVA: 0x00012708 File Offset: 0x00010908
		public static void sendString(IntPtr handle, string text)
		{
			foreach (char value in text)
			{
				Global.PostMessage(handle, Global.WM_CHAR, (IntPtr)((int)value), IntPtr.Zero);
			}
			Global.PostMessage(handle, Global.WM_KEYDOWN, (IntPtr)13L, IntPtr.Zero);
		}

		// Token: 0x0600014C RID: 332 RVA: 0x00012768 File Offset: 0x00010968
		public static void createNewParametersInRegistry()
		{
			try
			{
				RegistryKey currentUser = Registry.CurrentUser;
				RegistryKey registryKey = currentUser.OpenSubKey("Software\\TVH\\SessionManager", true);
				if (registryKey != null)
				{
					if (registryKey.GetValue("QuickPuttyProtocol") == null)
					{
						registryKey.SetValue("QuickPuttyProtocol", "SSH", RegistryValueKind.String);
					}
					if (registryKey.GetValue("ViewToolbarsQuickSession") == null)
					{
						registryKey.SetValue("ViewToolbarsQuickSession", "Yes", RegistryValueKind.String);
					}
					if (registryKey.GetValue("ViewToolbarsMSC") == null)
					{
						registryKey.SetValue("ViewToolbarsMSC", "Yes", RegistryValueKind.String);
					}
					if (registryKey.GetValue("ViewToolbarsStandard") == null)
					{
						registryKey.SetValue("ViewToolbarsStandard", "Yes", RegistryValueKind.String);
					}
					if (registryKey.GetValue("ViewSessionManager") == null)
					{
						registryKey.SetValue("ViewSessionManager", "Yes", RegistryValueKind.String);
					}
					if (registryKey.GetValue("SessionManagerPosition") == null)
					{
						registryKey.SetValue("SessionManagerPosition", "Left", RegistryValueKind.String);
					}
					if (registryKey.GetValue("SessionManagerWidth") == null)
					{
						registryKey.SetValue("SessionManagerWidth", 22, RegistryValueKind.DWord);
					}
					registryKey.Close();
					currentUser.Close();
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x0600014D RID: 333 RVA: 0x000128E4 File Offset: 0x00010AE4
		public static void saveLatestQuickPuttySettingsToRegistry()
		{
			try
			{
				RegistryKey currentUser = Registry.CurrentUser;
				RegistryKey registryKey = currentUser.OpenSubKey("Software\\TVH\\SessionManager", true);
				if (registryKey != null)
				{
					registryKey.SetValue("QuickPuttySetting", Global.strQuickPuttySetting);
					registryKey.SetValue("QuickPuttyProtocol", Global.strQuickPuttyProtocol);
					registryKey.Close();
					currentUser.Close();
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x0600014E RID: 334 RVA: 0x00012960 File Offset: 0x00010B60
		public static void saveLatestDisplayedMainItems()
		{
			try
			{
				RegistryKey currentUser = Registry.CurrentUser;
				RegistryKey registryKey = currentUser.OpenSubKey("Software\\TVH\\SessionManager", true);
				if (registryKey != null)
				{
					registryKey.SetValue("ViewToolbarsQuickSession", Global.strViewToolbarsQuickSession);
					registryKey.SetValue("ViewToolbarsMSC", Global.strViewToolbarsMSC);
					registryKey.SetValue("ViewToolbarsStandard", Global.strViewToolbarsStandard);
					registryKey.SetValue("ViewSessionManager", Global.strViewSessionManager);
					registryKey.SetValue("SessionManagerWidth", Global.iSessionManagerWidth);
					registryKey.Close();
					currentUser.Close();
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x0600014F RID: 335 RVA: 0x00012A14 File Offset: 0x00010C14
		public static void saveLatestCreatePuttySettingToRegistry()
		{
			try
			{
				RegistryKey currentUser = Registry.CurrentUser;
				RegistryKey registryKey = currentUser.OpenSubKey("Software\\TVH\\SessionManager", true);
				if (registryKey != null)
				{
					registryKey.SetValue("CreatePuttySetting", Global.strCreatePuttySetting);
					registryKey.Close();
					currentUser.Close();
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06000150 RID: 336 RVA: 0x00012A80 File Offset: 0x00010C80
		public static void saveDefaultDatabaseLocationToRegistry()
		{
			try
			{
				RegistryKey currentUser = Registry.CurrentUser;
				RegistryKey registryKey = currentUser.OpenSubKey("Software", true);
				RegistryKey registryKey2 = registryKey.OpenSubKey("TVH", true);
				if (registryKey2 != null)
				{
					RegistryKey registryKey3 = registryKey2.OpenSubKey("SessionManager", true);
					if (registryKey3 != null)
					{
						registryKey3.SetValue("Database", Global.strDefaultDatabaseLocation);
						registryKey3.Close();
						registryKey2.Close();
						registryKey.Close();
						currentUser.Close();
					}
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06000151 RID: 337 RVA: 0x00012B28 File Offset: 0x00010D28
		public static void writeInfoToWindowRegistry()
		{
			try
			{
				RegistryKey currentUser = Registry.CurrentUser;
				RegistryKey registryKey = currentUser.OpenSubKey("Software", true);
				RegistryKey registryKey2 = registryKey.OpenSubKey("TVH", true);
				if (registryKey2 != null)
				{
					RegistryKey registryKey3 = registryKey2.OpenSubKey("SessionManager", true);
					if (registryKey3 != null)
					{
						registryKey3.SetValue("Database", Global.strDefaultDatabaseLocation);
						registryKey3.SetValue("Putty", Global.strPuttyLocation);
						registryKey3.SetValue("WinSCP", Global.strWinSCPLocation);
						registryKey3.SetValue("SessionManagerPosition", Global.strSessionManagerPosition);
						registryKey3.Close();
						registryKey2.Close();
						registryKey.Close();
						currentUser.Close();
					}
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06000152 RID: 338 RVA: 0x00012C04 File Offset: 0x00010E04
		public static void readInfoFromWindowRegistry()
		{
			try
			{
				RegistryKey currentUser = Registry.CurrentUser;
				RegistryKey registryKey = currentUser.OpenSubKey("Software", true);
				RegistryKey registryKey2 = registryKey.OpenSubKey("TVH", true);
				if (registryKey2 == null)
				{
					registryKey2 = registryKey.CreateSubKey("TVH");
				}
				RegistryKey registryKey3 = registryKey2.OpenSubKey("SessionManager", true);
				if (registryKey3 == null)
				{
					registryKey3 = registryKey2.CreateSubKey("SessionManager");
					registryKey3.SetValue("Database", "", RegistryValueKind.String);
					registryKey3.SetValue("Putty", "", RegistryValueKind.String);
					registryKey3.SetValue("WinSCP", "", RegistryValueKind.String);
					registryKey3.SetValue("QuickPuttySetting", "Default Settings", RegistryValueKind.String);
					registryKey3.SetValue("CreatePuttySetting", "Default Settings", RegistryValueKind.String);
					registryKey3.SetValue("QuickConnectionTimeout", "2000", RegistryValueKind.String);
					registryKey3.SetValue("QuickUsernameTimeout", "1000", RegistryValueKind.String);
					registryKey3.SetValue("QuickPasswordTimout", "1000", RegistryValueKind.String);
				}
				else
				{
					Global.strDefaultDatabaseLocation = registryKey3.GetValue("Database").ToString();
					Global.strPuttyLocation = registryKey3.GetValue("Putty").ToString();
					Global.strWinSCPLocation = registryKey3.GetValue("WinSCP").ToString();
					Global.strQuickPuttySetting = registryKey3.GetValue("QuickPuttySetting").ToString();
					Global.strQuickPuttyProtocol = registryKey3.GetValue("QuickPuttyProtocol").ToString();
					Global.strCreatePuttySetting = registryKey3.GetValue("CreatePuttySetting").ToString();
					Global.strViewToolbarsQuickSession = registryKey3.GetValue("ViewToolbarsQuickSession").ToString();
					Global.strViewToolbarsMSC = registryKey3.GetValue("ViewToolbarsMSC").ToString();
					Global.strViewToolbarsStandard = registryKey3.GetValue("ViewToolbarsStandard").ToString();
					Global.strViewSessionManager = registryKey3.GetValue("ViewSessionManager").ToString();
					Global.strSessionManagerPosition = registryKey3.GetValue("SessionManagerPosition").ToString();
					Global.iSessionManagerWidth = (int)registryKey3.GetValue("SessionManagerWidth");
				}
				registryKey3.Close();
				registryKey2.Close();
				registryKey.Close();
				currentUser.Close();
				Global.readPuttySessionFromRegistry();
			}
			catch (Exception ex)
			{
				MessageBox.Show("readInfoFromWindowRegistry\n" + ex.ToString());
			}
		}

		// Token: 0x06000153 RID: 339 RVA: 0x00012E6C File Offset: 0x0001106C
		public static void readPuttySessionFromRegistry()
		{
			try
			{
				string[] array = new string[2];
				RegistryKey currentUser = Registry.CurrentUser;
				RegistryKey registryKey = currentUser.OpenSubKey("Software\\SimonTatham\\PuTTY\\Sessions", true);
				string[] array2 = new string[0];
				if (registryKey != null)
				{
					array2 = registryKey.GetSubKeyNames();
					Global.arrPuttySessionsList.Clear();
					for (int i = 0; i < array2.Count<string>(); i++)
					{
						PuttySession puttySession = new PuttySession();
						RegistryKey registryKey2 = registryKey.OpenSubKey(array2[i], true);
						puttySession.sessionName = array2[i];
						puttySession.sessionHost = registryKey2.GetValue("HostName").ToString();
						puttySession.protocol = registryKey2.GetValue("Protocol").ToString();
						puttySession.portNumber = int.Parse(registryKey2.GetValue("PortNumber").ToString());
						puttySession.userName = registryKey2.GetValue("UserName").ToString();
						if (puttySession.sessionHost.Contains("@"))
						{
							array = puttySession.sessionHost.Split(new char[]
							{
								'@'
							});
							puttySession.sessionHost = array[1];
							if (puttySession.userName.Trim() == "")
							{
								puttySession.userName = array[0];
							}
						}
						registryKey2.Close();
						Global.arrPuttySessionsList.Add(puttySession);
					}
					registryKey.Close();
					currentUser.Close();
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06000154 RID: 340 RVA: 0x00013024 File Offset: 0x00011224
		public static DialogResult InputBox(string title, string promptText, ref string value)
		{
			Form form = new Form();
			Label label = new Label();
			TextBox textBox = new TextBox();
			Button button = new Button();
			Button button2 = new Button();
			form.Text = title;
			label.Text = promptText;
			textBox.Text = value;
			button.Text = "OK";
			button2.Text = "Cancel";
			button.DialogResult = DialogResult.OK;
			button2.DialogResult = DialogResult.Cancel;
			label.SetBounds(9, 18, 372, 13);
			textBox.SetBounds(12, 36, 372, 20);
			button.SetBounds(228, 72, 75, 23);
			button2.SetBounds(309, 72, 75, 23);
			label.AutoSize = true;
			textBox.Anchor |= AnchorStyles.Right;
			button.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
			button2.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
			form.ClientSize = new Size(396, 107);
			form.Controls.AddRange(new Control[]
			{
				label,
				textBox,
				button,
				button2
			});
			form.ClientSize = new Size(Math.Max(300, label.Right + 10), form.ClientSize.Height);
			form.FormBorderStyle = FormBorderStyle.FixedDialog;
			form.StartPosition = FormStartPosition.CenterScreen;
			form.MinimizeBox = false;
			form.MaximizeBox = false;
			form.AcceptButton = button;
			form.CancelButton = button2;
			DialogResult result = form.ShowDialog();
			value = textBox.Text;
			return result;
		}

		// Token: 0x04000125 RID: 293
		public static ArrayList arrAvailableSessions;

		// Token: 0x04000126 RID: 294
		public static ArrayList arrOpenSessions;

		// Token: 0x04000127 RID: 295
		public static ArrayList arrDatabaseLocation;

		// Token: 0x04000128 RID: 296
		public static string strDefaultDatabaseLocation = "";

		// Token: 0x04000129 RID: 297
		public static string strPuttyLocation;

		// Token: 0x0400012A RID: 298
		public static string strWinSCPLocation;

		// Token: 0x0400012B RID: 299
		public static string strViewToolbarsQuickSession = "Yes";

		// Token: 0x0400012C RID: 300
		public static string strViewToolbarsMSC = "Yes";

		// Token: 0x0400012D RID: 301
		public static string strViewToolbarsStandard = "Yes";

		// Token: 0x0400012E RID: 302
		public static string strViewSessionManager = "Yes";

		// Token: 0x0400012F RID: 303
		public static string strSessionManagerPosition = "Left";

		// Token: 0x04000130 RID: 304
		public static int iSessionManagerWidth = 22;

		// Token: 0x04000131 RID: 305
		public static string strQuickPuttySetting = "Default Settings";

		// Token: 0x04000132 RID: 306
		public static string strQuickPuttyProtocol = "SSH";

		// Token: 0x04000133 RID: 307
		public static string strCreatePuttySetting = "Default Settings";

		// Token: 0x04000134 RID: 308
		public static ArrayList arrPuttySessionsList;

		// Token: 0x04000135 RID: 309
		private static uint WM_KEYDOWN = 256u;

		// Token: 0x04000136 RID: 310
		private static uint WM_CHAR = 258u;
	}
}
