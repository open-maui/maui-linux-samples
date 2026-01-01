using System.CodeDom.Compiler;
using Microsoft.Maui.ApplicationModel;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Internals;
using Microsoft.Maui.Controls.Xaml;
using Microsoft.Maui.Graphics;

namespace TodoApp;

[XamlFilePath("App.xaml")]
public class App : Application
{
	public App()
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected O, but got Unknown
		InitializeComponent();
		((Application)this).UserAppTheme = (AppTheme)1;
		((Application)this).MainPage = (Page)new NavigationPage((Page)(object)new TodoListPage())
		{
			BarBackgroundColor = Color.FromArgb("#5C6BC0"),
			BarTextColor = Colors.White
		};
	}

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private void InitializeComponent()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Expected O, but got Unknown
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected O, but got Unknown
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected O, but got Unknown
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Expected O, but got Unknown
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Expected O, but got Unknown
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Expected O, but got Unknown
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Expected O, but got Unknown
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Expected O, but got Unknown
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0126: Expected O, but got Unknown
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0141: Expected O, but got Unknown
		//IL_0155: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Expected O, but got Unknown
		//IL_0170: Unknown result type (might be due to invalid IL or missing references)
		//IL_0177: Expected O, but got Unknown
		//IL_018b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0192: Expected O, but got Unknown
		//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ad: Expected O, but got Unknown
		//IL_01c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c8: Expected O, but got Unknown
		//IL_01dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e3: Expected O, but got Unknown
		//IL_0206: Unknown result type (might be due to invalid IL or missing references)
		//IL_020d: Expected O, but got Unknown
		//IL_021a: Unknown result type (might be due to invalid IL or missing references)
		Color val = new Color(0.36078432f, 0.41960785f, 64f / 85f, 1f);
		Color val2 = new Color(19f / 85f, 0.28627452f, 57f / 85f, 1f);
		Color val3 = new Color(0.14901961f, 0.6509804f, 0.6039216f, 1f);
		Color val4 = new Color(0.9372549f, 0.3254902f, 16f / 51f, 1f);
		Color val5 = new Color(49f / 51f, 0.96862745f, 50f / 51f, 1f);
		Color val6 = new Color(1f, 1f, 1f, 1f);
		Color val7 = new Color(11f / 85f, 11f / 85f, 11f / 85f, 1f);
		Color val8 = new Color(39f / 85f, 39f / 85f, 39f / 85f, 1f);
		Color val9 = new Color(0.8784314f, 0.8784314f, 0.8784314f, 1f);
		Color val10 = new Color(6f / 85f, 6f / 85f, 6f / 85f, 1f);
		Color val11 = new Color(0.11764706f, 0.11764706f, 0.11764706f, 1f);
		Color val12 = new Color(1f, 1f, 1f, 1f);
		Color val13 = new Color(0.6901961f, 0.6901961f, 0.6901961f, 1f);
		Color val14 = new Color(22f / 85f, 22f / 85f, 22f / 85f, 1f);
		Color val15 = new Color(1f, 1f, 1f, 1f);
		Color val16 = new Color(0.1764706f, 0.1764706f, 0.1764706f, 1f);
		Color val17 = new Color(0.8784314f, 0.8784314f, 0.8784314f, 1f);
		Color val18 = new Color(22f / 85f, 22f / 85f, 22f / 85f, 1f);
		string text = "\ue145";
		string text2 = "\ue872";
		string text3 = "\ue161";
		string text4 = "\ue876";
		string text5 = "\ue3c9";
		ResourceDictionary val19 = new ResourceDictionary();
		App app;
		NameScope val20 = (NameScope)(((object)NameScope.GetNameScope((BindableObject)(object)(app = this))) ?? ((object)new NameScope()));
		NameScope.SetNameScope((BindableObject)(object)app, (INameScope)(object)val20);
		((Application)app).Resources = val19;
		val19.Add("PrimaryColor", (object)val);
		val19.Add("PrimaryDarkColor", (object)val2);
		val19.Add("AccentColor", (object)val3);
		val19.Add("DangerColor", (object)val4);
		val19.Add("PageBackgroundLight", (object)val5);
		val19.Add("CardBackgroundLight", (object)val6);
		val19.Add("TextPrimaryLight", (object)val7);
		val19.Add("TextSecondaryLight", (object)val8);
		val19.Add("BorderLight", (object)val9);
		val19.Add("PageBackgroundDark", (object)val10);
		val19.Add("CardBackgroundDark", (object)val11);
		val19.Add("TextPrimaryDark", (object)val12);
		val19.Add("TextSecondaryDark", (object)val13);
		val19.Add("BorderDark", (object)val14);
		val19.Add("InputBackgroundLight", (object)val15);
		val19.Add("InputBackgroundDark", (object)val16);
		val19.Add("CheckboxUncheckedLight", (object)val17);
		val19.Add("CheckboxUncheckedDark", (object)val18);
		val19.Add("IconAdd", (object)text);
		val19.Add("IconDelete", (object)text2);
		val19.Add("IconSave", (object)text3);
		val19.Add("IconCheck", (object)text4);
		val19.Add("IconEdit", (object)text5);
		((Application)app).Resources = val19;
	}
}
