using System;
using System.CodeDom.Compiler;
using System.Reflection;
using System.Xml;
using Microsoft.Maui;
using Microsoft.Maui.ApplicationModel;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Internals;
using Microsoft.Maui.Controls.Xaml;
using Microsoft.Maui.Controls.Xaml.Internals;
using Microsoft.Maui.Graphics;

namespace XamlBrowser;

[XamlFilePath("App.xaml")]
public class BrowserApp : Application
{
	public BrowserApp()
	{
		InitializeComponent();
		((Application)this).UserAppTheme = (AppTheme)2;
		((Application)this).MainPage = (Page)(object)new MainPage();
	}

	public void ToggleTheme()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Invalid comparison between Unknown and I4
		((Application)this).UserAppTheme = (AppTheme)(((int)((Application)this).UserAppTheme != 1) ? 1 : 2);
	}

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private void InitializeComponent()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Expected O, but got Unknown
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Expected O, but got Unknown
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Expected O, but got Unknown
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Expected O, but got Unknown
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Expected O, but got Unknown
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected O, but got Unknown
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Expected O, but got Unknown
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Expected O, but got Unknown
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Expected O, but got Unknown
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0143: Expected O, but got Unknown
		//IL_0157: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Expected O, but got Unknown
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_0179: Expected O, but got Unknown
		//IL_018d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0194: Expected O, but got Unknown
		//IL_01a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01af: Expected O, but got Unknown
		//IL_01c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ca: Expected O, but got Unknown
		//IL_01de: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e5: Expected O, but got Unknown
		//IL_01e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ec: Expected O, but got Unknown
		//IL_01ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f3: Expected O, but got Unknown
		//IL_01f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fa: Expected O, but got Unknown
		//IL_01fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0201: Expected O, but got Unknown
		//IL_0201: Unknown result type (might be due to invalid IL or missing references)
		//IL_0208: Expected O, but got Unknown
		//IL_0208: Unknown result type (might be due to invalid IL or missing references)
		//IL_020f: Expected O, but got Unknown
		//IL_020f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0216: Expected O, but got Unknown
		//IL_0216: Unknown result type (might be due to invalid IL or missing references)
		//IL_021d: Expected O, but got Unknown
		//IL_021d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0224: Expected O, but got Unknown
		//IL_0224: Unknown result type (might be due to invalid IL or missing references)
		//IL_022b: Expected O, but got Unknown
		//IL_022b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0232: Expected O, but got Unknown
		//IL_0232: Unknown result type (might be due to invalid IL or missing references)
		//IL_0239: Expected O, but got Unknown
		//IL_0239: Unknown result type (might be due to invalid IL or missing references)
		//IL_0240: Expected O, but got Unknown
		//IL_0240: Unknown result type (might be due to invalid IL or missing references)
		//IL_0247: Expected O, but got Unknown
		//IL_0251: Unknown result type (might be due to invalid IL or missing references)
		//IL_0258: Expected O, but got Unknown
		//IL_0258: Unknown result type (might be due to invalid IL or missing references)
		//IL_025f: Expected O, but got Unknown
		//IL_025f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0266: Expected O, but got Unknown
		//IL_0266: Unknown result type (might be due to invalid IL or missing references)
		//IL_026d: Expected O, but got Unknown
		//IL_026d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0274: Expected O, but got Unknown
		//IL_0274: Unknown result type (might be due to invalid IL or missing references)
		//IL_027b: Expected O, but got Unknown
		//IL_027b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0282: Expected O, but got Unknown
		//IL_0282: Unknown result type (might be due to invalid IL or missing references)
		//IL_0289: Expected O, but got Unknown
		//IL_0289: Unknown result type (might be due to invalid IL or missing references)
		//IL_0290: Expected O, but got Unknown
		//IL_0290: Unknown result type (might be due to invalid IL or missing references)
		//IL_0297: Expected O, but got Unknown
		//IL_0297: Unknown result type (might be due to invalid IL or missing references)
		//IL_029e: Expected O, but got Unknown
		//IL_02a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02af: Expected O, but got Unknown
		//IL_02af: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b6: Expected O, but got Unknown
		//IL_02b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bd: Expected O, but got Unknown
		//IL_02bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c4: Expected O, but got Unknown
		//IL_02c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cb: Expected O, but got Unknown
		//IL_02cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d2: Expected O, but got Unknown
		//IL_02d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d9: Expected O, but got Unknown
		//IL_02d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e0: Expected O, but got Unknown
		//IL_02e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e7: Expected O, but got Unknown
		//IL_02e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ee: Expected O, but got Unknown
		//IL_02ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f5: Expected O, but got Unknown
		//IL_02f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fc: Expected O, but got Unknown
		//IL_02fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0303: Expected O, but got Unknown
		//IL_0303: Unknown result type (might be due to invalid IL or missing references)
		//IL_030a: Expected O, but got Unknown
		//IL_030a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0311: Expected O, but got Unknown
		//IL_031b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0322: Expected O, but got Unknown
		//IL_0322: Unknown result type (might be due to invalid IL or missing references)
		//IL_0329: Expected O, but got Unknown
		//IL_0329: Unknown result type (might be due to invalid IL or missing references)
		//IL_0330: Expected O, but got Unknown
		//IL_0330: Unknown result type (might be due to invalid IL or missing references)
		//IL_0337: Expected O, but got Unknown
		//IL_0337: Unknown result type (might be due to invalid IL or missing references)
		//IL_033e: Expected O, but got Unknown
		//IL_033e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0345: Expected O, but got Unknown
		//IL_0345: Unknown result type (might be due to invalid IL or missing references)
		//IL_034c: Expected O, but got Unknown
		//IL_0356: Unknown result type (might be due to invalid IL or missing references)
		//IL_035d: Expected O, but got Unknown
		//IL_035d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0364: Expected O, but got Unknown
		//IL_0381: Unknown result type (might be due to invalid IL or missing references)
		//IL_0388: Expected O, but got Unknown
		//IL_0388: Unknown result type (might be due to invalid IL or missing references)
		//IL_038f: Expected O, but got Unknown
		//IL_038f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0396: Expected O, but got Unknown
		//IL_0396: Unknown result type (might be due to invalid IL or missing references)
		//IL_039d: Expected O, but got Unknown
		//IL_039d: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a4: Expected O, but got Unknown
		//IL_03a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ab: Expected O, but got Unknown
		//IL_03ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b2: Expected O, but got Unknown
		//IL_03b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b9: Expected O, but got Unknown
		//IL_03b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c0: Expected O, but got Unknown
		//IL_03c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c7: Expected O, but got Unknown
		//IL_03c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ce: Expected O, but got Unknown
		//IL_03ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d5: Expected O, but got Unknown
		//IL_03d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03dc: Expected O, but got Unknown
		//IL_03dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e3: Expected O, but got Unknown
		//IL_03e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ea: Expected O, but got Unknown
		//IL_03ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f1: Expected O, but got Unknown
		//IL_03f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f8: Expected O, but got Unknown
		//IL_03f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ff: Expected O, but got Unknown
		//IL_03ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0406: Expected O, but got Unknown
		//IL_0406: Unknown result type (might be due to invalid IL or missing references)
		//IL_040d: Expected O, but got Unknown
		//IL_040d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0414: Expected O, but got Unknown
		//IL_0414: Unknown result type (might be due to invalid IL or missing references)
		//IL_041b: Expected O, but got Unknown
		//IL_0658: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_06dd: Expected O, but got Unknown
		//IL_06dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f6: Expected O, but got Unknown
		//IL_06f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_06fb: Expected O, but got Unknown
		//IL_0700: Expected O, but got Unknown
		//IL_0751: Unknown result type (might be due to invalid IL or missing references)
		//IL_0756: Unknown result type (might be due to invalid IL or missing references)
		//IL_0777: Unknown result type (might be due to invalid IL or missing references)
		//IL_0781: Expected O, but got Unknown
		//IL_0781: Unknown result type (might be due to invalid IL or missing references)
		//IL_0790: Unknown result type (might be due to invalid IL or missing references)
		//IL_079a: Expected O, but got Unknown
		//IL_0795: Unknown result type (might be due to invalid IL or missing references)
		//IL_079f: Expected O, but got Unknown
		//IL_07a4: Expected O, but got Unknown
		//IL_08e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_090e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0918: Expected O, but got Unknown
		//IL_0918: Unknown result type (might be due to invalid IL or missing references)
		//IL_0927: Unknown result type (might be due to invalid IL or missing references)
		//IL_0931: Expected O, but got Unknown
		//IL_092c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0936: Expected O, but got Unknown
		//IL_093b: Expected O, but got Unknown
		//IL_097a: Unknown result type (might be due to invalid IL or missing references)
		//IL_097f: Unknown result type (might be due to invalid IL or missing references)
		//IL_09a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_09aa: Expected O, but got Unknown
		//IL_09aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_09b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_09c3: Expected O, but got Unknown
		//IL_09be: Unknown result type (might be due to invalid IL or missing references)
		//IL_09c8: Expected O, but got Unknown
		//IL_09cd: Expected O, but got Unknown
		//IL_0aa2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aa7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ac8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ad2: Expected O, but got Unknown
		//IL_0ad2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ae1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aeb: Expected O, but got Unknown
		//IL_0ae6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0af0: Expected O, but got Unknown
		//IL_0af5: Expected O, but got Unknown
		//IL_0b46: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b4b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b6c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b76: Expected O, but got Unknown
		//IL_0b76: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b85: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b8f: Expected O, but got Unknown
		//IL_0b8a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b94: Expected O, but got Unknown
		//IL_0b99: Expected O, but got Unknown
		//IL_0bea: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bef: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c10: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c1a: Expected O, but got Unknown
		//IL_0c1a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c29: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c33: Expected O, but got Unknown
		//IL_0c2e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c38: Expected O, but got Unknown
		//IL_0c3d: Expected O, but got Unknown
		//IL_0ccb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d20: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d25: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d46: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d50: Expected O, but got Unknown
		//IL_0d50: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d5f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d69: Expected O, but got Unknown
		//IL_0d64: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d6e: Expected O, but got Unknown
		//IL_0d73: Expected O, but got Unknown
		//IL_0371: Unknown result type (might be due to invalid IL or missing references)
		Color val = new Color(0.101960786f, 23f / 51f, 0.9098039f, 1f);
		Color val2 = new Color(46f / 85f, 0.7058824f, 0.972549f, 1f);
		Color val3 = new Color(1f, 1f, 1f, 1f);
		Color val4 = new Color(0.1254902f, 11f / 85f, 12f / 85f, 1f);
		Color val5 = new Color(1f, 1f, 1f, 1f);
		Color val6 = new Color(0.16078432f, 14f / 85f, 0.1764706f, 1f);
		Color val7 = new Color(0.94509804f, 81f / 85f, 0.95686275f, 1f);
		Color val8 = new Color(0.23529412f, 0.2509804f, 0.2627451f, 1f);
		Color val9 = new Color(0.94509804f, 81f / 85f, 0.95686275f, 1f);
		Color val10 = new Color(0.23529412f, 0.2509804f, 0.2627451f, 1f);
		Color val11 = new Color(0.1254902f, 11f / 85f, 12f / 85f, 1f);
		Color val12 = new Color(0.9098039f, 78f / 85f, 79f / 85f, 1f);
		Color val13 = new Color(19f / 51f, 33f / 85f, 0.40784314f, 1f);
		Color val14 = new Color(0.6039216f, 32f / 51f, 0.6509804f, 1f);
		Color val15 = new Color(0.5019608f, 0.5254902f, 0.54509807f, 1f);
		Color val16 = new Color(0.6039216f, 32f / 51f, 0.6509804f, 1f);
		Color val17 = new Color(0.972549f, 83f / 85f, 50f / 51f, 1f);
		Color val18 = new Color(0.20784314f, 18f / 85f, 0.22745098f, 1f);
		Setter val19 = new Setter();
		Setter val20 = new Setter();
		Setter val21 = new Setter();
		Setter val22 = new Setter();
		Setter val23 = new Setter();
		Setter val24 = new Setter();
		StaticResourceExtension val25 = new StaticResourceExtension();
		StaticResourceExtension val26 = new StaticResourceExtension();
		AppThemeBindingExtension val27 = new AppThemeBindingExtension();
		Setter val28 = new Setter();
		StaticResourceExtension val29 = new StaticResourceExtension();
		StaticResourceExtension val30 = new StaticResourceExtension();
		AppThemeBindingExtension val31 = new AppThemeBindingExtension();
		Setter val32 = new Setter();
		Style val33 = new Style(typeof(Button));
		Setter val34 = new Setter();
		Setter val35 = new Setter();
		Setter val36 = new Setter();
		Setter val37 = new Setter();
		StaticResourceExtension val38 = new StaticResourceExtension();
		StaticResourceExtension val39 = new StaticResourceExtension();
		AppThemeBindingExtension val40 = new AppThemeBindingExtension();
		Setter val41 = new Setter();
		AppThemeBindingExtension val42 = new AppThemeBindingExtension();
		Setter val43 = new Setter();
		Style val44 = new Style(typeof(Button));
		Setter val45 = new Setter();
		Setter val46 = new Setter();
		StaticResourceExtension val47 = new StaticResourceExtension();
		StaticResourceExtension val48 = new StaticResourceExtension();
		AppThemeBindingExtension val49 = new AppThemeBindingExtension();
		Setter val50 = new Setter();
		StaticResourceExtension val51 = new StaticResourceExtension();
		StaticResourceExtension val52 = new StaticResourceExtension();
		AppThemeBindingExtension val53 = new AppThemeBindingExtension();
		Setter val54 = new Setter();
		StaticResourceExtension val55 = new StaticResourceExtension();
		StaticResourceExtension val56 = new StaticResourceExtension();
		AppThemeBindingExtension val57 = new AppThemeBindingExtension();
		Setter val58 = new Setter();
		Style val59 = new Style(typeof(Entry));
		Setter val60 = new Setter();
		Setter val61 = new Setter();
		StaticResourceExtension val62 = new StaticResourceExtension();
		StaticResourceExtension val63 = new StaticResourceExtension();
		AppThemeBindingExtension val64 = new AppThemeBindingExtension();
		Setter val65 = new Setter();
		Style val66 = new Style(typeof(Label));
		ResourceDictionary val67 = new ResourceDictionary();
		BrowserApp browserApp;
		NameScope val68 = (NameScope)(((object)NameScope.GetNameScope((BindableObject)(object)(browserApp = this))) ?? ((object)new NameScope()));
		NameScope.SetNameScope((BindableObject)(object)browserApp, (INameScope)(object)val68);
		NameScope val69 = new NameScope();
		NameScope val70 = new NameScope();
		NameScope val71 = new NameScope();
		NameScope val72 = new NameScope();
		NameScope val73 = new NameScope();
		NameScope val74 = new NameScope();
		NameScope val75 = new NameScope();
		NameScope val76 = new NameScope();
		NameScope val77 = new NameScope();
		NameScope val78 = new NameScope();
		NameScope val79 = new NameScope();
		NameScope val80 = new NameScope();
		NameScope val81 = new NameScope();
		NameScope val82 = new NameScope();
		NameScope val83 = new NameScope();
		NameScope val84 = new NameScope();
		NameScope val85 = new NameScope();
		NameScope val86 = new NameScope();
		NameScope val87 = new NameScope();
		NameScope val88 = new NameScope();
		NameScope val89 = new NameScope();
		NameScope val90 = new NameScope();
		((Application)browserApp).Resources = val67;
		val67.Add("PrimaryColor", (object)val);
		val67.Add("PrimaryDarkColor", (object)val2);
		val67.Add("PageBackgroundLight", (object)val3);
		val67.Add("PageBackgroundDark", (object)val4);
		val67.Add("ToolbarBackgroundLight", (object)val5);
		val67.Add("ToolbarBackgroundDark", (object)val6);
		val67.Add("EntryBackgroundLight", (object)val7);
		val67.Add("EntryBackgroundDark", (object)val8);
		val67.Add("ButtonBackgroundLight", (object)val9);
		val67.Add("ButtonBackgroundDark", (object)val10);
		val67.Add("TextPrimaryLight", (object)val11);
		val67.Add("TextPrimaryDark", (object)val12);
		val67.Add("TextSecondaryLight", (object)val13);
		val67.Add("TextSecondaryDark", (object)val14);
		val67.Add("PlaceholderLight", (object)val15);
		val67.Add("PlaceholderDark", (object)val16);
		val67.Add("StatusBackgroundLight", (object)val17);
		val67.Add("StatusBackgroundDark", (object)val18);
		val19.Property = VisualElement.WidthRequestProperty;
		val19.Value = "40";
		val19.Value = 40.0;
		val33.Setters.Add(val19);
		val20.Property = VisualElement.HeightRequestProperty;
		val20.Value = "40";
		val20.Value = 40.0;
		val33.Setters.Add(val20);
		val21.Property = Button.CornerRadiusProperty;
		val21.Value = "20";
		val21.Value = 20;
		val33.Setters.Add(val21);
		val22.Property = Button.FontSizeProperty;
		val22.Value = "18";
		val22.Value = 18.0;
		val33.Setters.Add(val22);
		val23.Property = Button.FontFamilyProperty;
		val23.Value = "Segoe UI Symbol, Symbola, DejaVu Sans, sans-serif";
		val23.Value = "Segoe UI Symbol, Symbola, DejaVu Sans, sans-serif";
		val33.Setters.Add(val23);
		val24.Property = Button.PaddingProperty;
		val24.Value = "0";
		val24.Value = (object)new Thickness(0.0);
		val33.Setters.Add(val24);
		val28.Property = VisualElement.BackgroundColorProperty;
		val25.Key = "ButtonBackgroundLight";
		val27.Light = val9;
		val26.Key = "ButtonBackgroundDark";
		val27.Dark = val10;
		XamlServiceProvider val91 = new XamlServiceProvider();
		val91.Add(typeof(IProvideValueTarget), (object)new ValueTargetProvider((object)val28, (object)typeof(Setter).GetRuntimeProperty("Value")));
		val91.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(46, 52)));
		BindingBase value = ((IMarkupExtension<BindingBase>)(object)val27).ProvideValue((IServiceProvider)val91);
		val28.Value = value;
		val33.Setters.Add(val28);
		val32.Property = Button.TextColorProperty;
		val29.Key = "TextPrimaryLight";
		val31.Light = val11;
		val30.Key = "TextPrimaryDark";
		val31.Dark = val12;
		XamlServiceProvider val92 = new XamlServiceProvider();
		val92.Add(typeof(IProvideValueTarget), (object)new ValueTargetProvider((object)val32, (object)typeof(Setter).GetRuntimeProperty("Value")));
		val92.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(47, 46)));
		BindingBase value2 = ((IMarkupExtension<BindingBase>)(object)val31).ProvideValue((IServiceProvider)val92);
		val32.Value = value2;
		val33.Setters.Add(val32);
		val67.Add("NavButtonStyle", (object)val33);
		val34.Property = VisualElement.WidthRequestProperty;
		val34.Value = "60";
		val34.Value = 60.0;
		val44.Setters.Add(val34);
		val35.Property = VisualElement.HeightRequestProperty;
		val35.Value = "36";
		val35.Value = 36.0;
		val44.Setters.Add(val35);
		val36.Property = Button.CornerRadiusProperty;
		val36.Value = "18";
		val36.Value = 18;
		val44.Setters.Add(val36);
		val37.Property = Button.FontSizeProperty;
		val37.Value = "14";
		val37.Value = 14.0;
		val44.Setters.Add(val37);
		val41.Property = VisualElement.BackgroundColorProperty;
		val38.Key = "PrimaryColor";
		val40.Light = val;
		val39.Key = "PrimaryDarkColor";
		val40.Dark = val2;
		XamlServiceProvider val93 = new XamlServiceProvider();
		val93.Add(typeof(IProvideValueTarget), (object)new ValueTargetProvider((object)val41, (object)typeof(Setter).GetRuntimeProperty("Value")));
		val93.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(56, 52)));
		BindingBase value3 = ((IMarkupExtension<BindingBase>)(object)val40).ProvideValue((IServiceProvider)val93);
		val41.Value = value3;
		val44.Setters.Add(val41);
		val43.Property = Button.TextColorProperty;
		val42.Light = "White";
		val42.Dark = "#202124";
		XamlServiceProvider val94 = new XamlServiceProvider();
		val94.Add(typeof(IProvideValueTarget), (object)new ValueTargetProvider((object)val43, (object)typeof(Setter).GetRuntimeProperty("Value")));
		val94.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(57, 46)));
		BindingBase value4 = ((IMarkupExtension<BindingBase>)(object)val42).ProvideValue((IServiceProvider)val94);
		val43.Value = value4;
		val44.Setters.Add(val43);
		val67.Add("GoButtonStyle", (object)val44);
		val45.Property = Entry.FontSizeProperty;
		val45.Value = "14";
		val45.Value = 14.0;
		val59.Setters.Add(val45);
		val46.Property = VisualElement.HeightRequestProperty;
		val46.Value = "36";
		val46.Value = 36.0;
		val59.Setters.Add(val46);
		val50.Property = VisualElement.BackgroundColorProperty;
		val47.Key = "EntryBackgroundLight";
		val49.Light = val7;
		val48.Key = "EntryBackgroundDark";
		val49.Dark = val8;
		XamlServiceProvider val95 = new XamlServiceProvider();
		val95.Add(typeof(IProvideValueTarget), (object)new ValueTargetProvider((object)val50, (object)typeof(Setter).GetRuntimeProperty("Value")));
		val95.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(64, 52)));
		BindingBase value5 = ((IMarkupExtension<BindingBase>)(object)val49).ProvideValue((IServiceProvider)val95);
		val50.Value = value5;
		val59.Setters.Add(val50);
		val54.Property = Entry.TextColorProperty;
		val51.Key = "TextPrimaryLight";
		val53.Light = val11;
		val52.Key = "TextPrimaryDark";
		val53.Dark = val12;
		XamlServiceProvider val96 = new XamlServiceProvider();
		val96.Add(typeof(IProvideValueTarget), (object)new ValueTargetProvider((object)val54, (object)typeof(Setter).GetRuntimeProperty("Value")));
		val96.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(65, 46)));
		BindingBase value6 = ((IMarkupExtension<BindingBase>)(object)val53).ProvideValue((IServiceProvider)val96);
		val54.Value = value6;
		val59.Setters.Add(val54);
		val58.Property = Entry.PlaceholderColorProperty;
		val55.Key = "PlaceholderLight";
		val57.Light = val15;
		val56.Key = "PlaceholderDark";
		val57.Dark = val16;
		XamlServiceProvider val97 = new XamlServiceProvider();
		val97.Add(typeof(IProvideValueTarget), (object)new ValueTargetProvider((object)val58, (object)typeof(Setter).GetRuntimeProperty("Value")));
		val97.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(66, 53)));
		BindingBase value7 = ((IMarkupExtension<BindingBase>)(object)val57).ProvideValue((IServiceProvider)val97);
		val58.Value = value7;
		val59.Setters.Add(val58);
		val67.Add("AddressBarStyle", (object)val59);
		val60.Property = Label.FontSizeProperty;
		val60.Value = "12";
		val60.Value = 12.0;
		val66.Setters.Add(val60);
		val61.Property = Label.PaddingProperty;
		val61.Value = "8,4";
		val61.Value = (object)new Thickness(8.0, 4.0);
		val66.Setters.Add(val61);
		val65.Property = Label.TextColorProperty;
		val62.Key = "TextSecondaryLight";
		val64.Light = val13;
		val63.Key = "TextSecondaryDark";
		val64.Dark = val14;
		XamlServiceProvider val98 = new XamlServiceProvider();
		val98.Add(typeof(IProvideValueTarget), (object)new ValueTargetProvider((object)val65, (object)typeof(Setter).GetRuntimeProperty("Value")));
		val98.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(73, 46)));
		BindingBase value8 = ((IMarkupExtension<BindingBase>)(object)val64).ProvideValue((IServiceProvider)val98);
		val65.Value = value8;
		val66.Setters.Add(val65);
		val67.Add("StatusLabelStyle", (object)val66);
		((Application)browserApp).Resources = val67;
	}
}
