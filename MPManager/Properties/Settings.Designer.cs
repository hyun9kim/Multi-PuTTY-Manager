using System;
using System.CodeDom.Compiler;
using System.Configuration;
using System.Runtime.CompilerServices;

namespace SessionManagement.Properties
{
	// Token: 0x0200001F RID: 31
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "11.0.0.0")]
	[CompilerGenerated]
	internal sealed partial class Settings : ApplicationSettingsBase
	{
		// Token: 0x1700002B RID: 43
		// (get) Token: 0x060001AD RID: 429 RVA: 0x00013D60 File Offset: 0x00011F60
		public static Settings Default
		{
			get
			{
				return Settings.defaultInstance;
			}
		}

		// Token: 0x0400015D RID: 349
		private static Settings defaultInstance = (Settings)SettingsBase.Synchronized(new Settings());
	}
}
