using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Reflection;
using System.Xml;
using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Internals;
using Microsoft.Maui.Controls.Xaml;
using Microsoft.Maui.Controls.Xaml.Internals;

namespace ShellDemo;

[XamlFilePath("AppShell.xaml")]
public class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
		Routing.RegisterRoute("detail", typeof(DetailPage));
	}

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private void InitializeComponent()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected O, but got Unknown
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected O, but got Unknown
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected O, but got Unknown
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Expected O, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected O, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected O, but got Unknown
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Expected O, but got Unknown
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Expected O, but got Unknown
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Expected O, but got Unknown
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Expected O, but got Unknown
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected O, but got Unknown
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Expected O, but got Unknown
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Expected O, but got Unknown
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Expected O, but got Unknown
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Expected O, but got Unknown
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Expected O, but got Unknown
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Expected O, but got Unknown
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Expected O, but got Unknown
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Expected O, but got Unknown
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Expected O, but got Unknown
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Expected O, but got Unknown
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Expected O, but got Unknown
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Expected O, but got Unknown
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Expected O, but got Unknown
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Expected O, but got Unknown
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Expected O, but got Unknown
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Expected O, but got Unknown
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Expected O, but got Unknown
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_011a: Expected O, but got Unknown
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_012b: Expected O, but got Unknown
		//IL_012b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Expected O, but got Unknown
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_0139: Expected O, but got Unknown
		//IL_0139: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Expected O, but got Unknown
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Expected O, but got Unknown
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Expected O, but got Unknown
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_015f: Expected O, but got Unknown
		//IL_015f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0166: Expected O, but got Unknown
		//IL_0166: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Expected O, but got Unknown
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Expected O, but got Unknown
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0185: Expected O, but got Unknown
		//IL_0185: Unknown result type (might be due to invalid IL or missing references)
		//IL_018c: Expected O, but got Unknown
		//IL_018c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0193: Expected O, but got Unknown
		//IL_0193: Unknown result type (might be due to invalid IL or missing references)
		//IL_019a: Expected O, but got Unknown
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a1: Expected O, but got Unknown
		//IL_01ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b2: Expected O, but got Unknown
		//IL_01b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b9: Expected O, but got Unknown
		//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c0: Expected O, but got Unknown
		//IL_01c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c7: Expected O, but got Unknown
		//IL_01c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ce: Expected O, but got Unknown
		//IL_01d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01df: Expected O, but got Unknown
		//IL_01df: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e6: Expected O, but got Unknown
		//IL_01e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ed: Expected O, but got Unknown
		//IL_0361: Unknown result type (might be due to invalid IL or missing references)
		//IL_0366: Unknown result type (might be due to invalid IL or missing references)
		//IL_0371: Unknown result type (might be due to invalid IL or missing references)
		//IL_0376: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c4: Expected O, but got Unknown
		//IL_03c9: Expected O, but got Unknown
		//IL_03c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03db: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f2: Expected O, but got Unknown
		//IL_03ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f7: Expected O, but got Unknown
		//IL_03fc: Expected O, but got Unknown
		//IL_0411: Unknown result type (might be due to invalid IL or missing references)
		//IL_0416: Unknown result type (might be due to invalid IL or missing references)
		//IL_0421: Unknown result type (might be due to invalid IL or missing references)
		//IL_0426: Unknown result type (might be due to invalid IL or missing references)
		//IL_046c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0471: Unknown result type (might be due to invalid IL or missing references)
		//IL_0474: Expected O, but got Unknown
		//IL_0479: Expected O, but got Unknown
		//IL_0479: Unknown result type (might be due to invalid IL or missing references)
		//IL_048b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0498: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a2: Expected O, but got Unknown
		//IL_049d: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a7: Expected O, but got Unknown
		//IL_04ac: Expected O, but got Unknown
		//IL_04b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d8: Expected O, but got Unknown
		//IL_04d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ef: Expected O, but got Unknown
		//IL_04ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f4: Expected O, but got Unknown
		//IL_04f9: Expected O, but got Unknown
		//IL_0514: Unknown result type (might be due to invalid IL or missing references)
		//IL_0519: Unknown result type (might be due to invalid IL or missing references)
		//IL_0524: Unknown result type (might be due to invalid IL or missing references)
		//IL_0529: Unknown result type (might be due to invalid IL or missing references)
		//IL_057a: Unknown result type (might be due to invalid IL or missing references)
		//IL_057f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0582: Expected O, but got Unknown
		//IL_0587: Expected O, but got Unknown
		//IL_0587: Unknown result type (might be due to invalid IL or missing references)
		//IL_0599: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b2: Expected O, but got Unknown
		//IL_05ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b7: Expected O, but got Unknown
		//IL_05bc: Expected O, but got Unknown
		//IL_05d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_05da: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f6: Expected O, but got Unknown
		//IL_05f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0605: Unknown result type (might be due to invalid IL or missing references)
		//IL_060f: Expected O, but got Unknown
		//IL_060a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0614: Expected O, but got Unknown
		//IL_0619: Expected O, but got Unknown
		//IL_0653: Unknown result type (might be due to invalid IL or missing references)
		//IL_0669: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0757: Unknown result type (might be due to invalid IL or missing references)
		//IL_075c: Unknown result type (might be due to invalid IL or missing references)
		//IL_076e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0778: Expected O, but got Unknown
		//IL_0778: Unknown result type (might be due to invalid IL or missing references)
		//IL_0787: Unknown result type (might be due to invalid IL or missing references)
		//IL_0791: Expected O, but got Unknown
		//IL_078c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0796: Expected O, but got Unknown
		//IL_079b: Expected O, but got Unknown
		//IL_07fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0803: Unknown result type (might be due to invalid IL or missing references)
		//IL_0815: Unknown result type (might be due to invalid IL or missing references)
		//IL_081f: Expected O, but got Unknown
		//IL_081f: Unknown result type (might be due to invalid IL or missing references)
		//IL_082e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0838: Expected O, but got Unknown
		//IL_0833: Unknown result type (might be due to invalid IL or missing references)
		//IL_083d: Expected O, but got Unknown
		//IL_0842: Expected O, but got Unknown
		//IL_08fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0902: Unknown result type (might be due to invalid IL or missing references)
		//IL_0914: Unknown result type (might be due to invalid IL or missing references)
		//IL_091e: Expected O, but got Unknown
		//IL_091e: Unknown result type (might be due to invalid IL or missing references)
		//IL_092d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0937: Expected O, but got Unknown
		//IL_0932: Unknown result type (might be due to invalid IL or missing references)
		//IL_093c: Expected O, but got Unknown
		//IL_0941: Expected O, but got Unknown
		//IL_09f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_09f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a08: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a12: Expected O, but got Unknown
		//IL_0a12: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a21: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a2b: Expected O, but got Unknown
		//IL_0a26: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a30: Expected O, but got Unknown
		//IL_0a35: Expected O, but got Unknown
		//IL_0ae5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aea: Unknown result type (might be due to invalid IL or missing references)
		//IL_0afc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b06: Expected O, but got Unknown
		//IL_0b06: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b15: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b1f: Expected O, but got Unknown
		//IL_0b1a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b24: Expected O, but got Unknown
		//IL_0b29: Expected O, but got Unknown
		//IL_0bd9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bde: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bf0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bfa: Expected O, but got Unknown
		//IL_0bfa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c09: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c13: Expected O, but got Unknown
		//IL_0c0e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c18: Expected O, but got Unknown
		//IL_0c1d: Expected O, but got Unknown
		//IL_0ccd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cd2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ce4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cee: Expected O, but got Unknown
		//IL_0cee: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cfd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d07: Expected O, but got Unknown
		//IL_0d02: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d0c: Expected O, but got Unknown
		//IL_0d11: Expected O, but got Unknown
		//IL_0dc1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dc6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dd8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0de2: Expected O, but got Unknown
		//IL_0de2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0df1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dfb: Expected O, but got Unknown
		//IL_0df6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e00: Expected O, but got Unknown
		//IL_0e05: Expected O, but got Unknown
		//IL_0eb5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eba: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ecc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ed6: Expected O, but got Unknown
		//IL_0ed6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ee5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eef: Expected O, but got Unknown
		//IL_0eea: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ef4: Expected O, but got Unknown
		//IL_0ef9: Expected O, but got Unknown
		//IL_0fa9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fae: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fc0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fca: Expected O, but got Unknown
		//IL_0fca: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fd9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fe3: Expected O, but got Unknown
		//IL_0fde: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fe8: Expected O, but got Unknown
		//IL_0fed: Expected O, but got Unknown
		//IL_109d: Unknown result type (might be due to invalid IL or missing references)
		//IL_10a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_10b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_10be: Expected O, but got Unknown
		//IL_10be: Unknown result type (might be due to invalid IL or missing references)
		//IL_10cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_10d7: Expected O, but got Unknown
		//IL_10d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_10dc: Expected O, but got Unknown
		//IL_10e1: Expected O, but got Unknown
		//IL_01fa: Unknown result type (might be due to invalid IL or missing references)
		StaticResourceExtension val = new StaticResourceExtension();
		StaticResourceExtension val2 = new StaticResourceExtension();
		AppThemeBindingExtension val3 = new AppThemeBindingExtension();
		StaticResourceExtension val4 = new StaticResourceExtension();
		AppThemeBindingExtension val5 = new AppThemeBindingExtension();
		Image val6 = new Image();
		AppThemeBindingExtension val7 = new AppThemeBindingExtension();
		Label val8 = new Label();
		AppThemeBindingExtension val9 = new AppThemeBindingExtension();
		Label val10 = new Label();
		VerticalStackLayout val11 = new VerticalStackLayout();
		HorizontalStackLayout val12 = new HorizontalStackLayout();
		Grid val13 = new Grid();
		AppThemeBindingExtension val14 = new AppThemeBindingExtension();
		FontImageSource val15 = new FontImageSource();
		DataTemplate val16 = new DataTemplate(typeof(HomePage));
		ShellContent val17 = new ShellContent();
		FlyoutItem val18 = new FlyoutItem();
		AppThemeBindingExtension val19 = new AppThemeBindingExtension();
		FontImageSource val20 = new FontImageSource();
		DataTemplate val21 = new DataTemplate(typeof(ButtonsPage));
		ShellContent val22 = new ShellContent();
		FlyoutItem val23 = new FlyoutItem();
		AppThemeBindingExtension val24 = new AppThemeBindingExtension();
		FontImageSource val25 = new FontImageSource();
		DataTemplate val26 = new DataTemplate(typeof(TextInputPage));
		ShellContent val27 = new ShellContent();
		FlyoutItem val28 = new FlyoutItem();
		AppThemeBindingExtension val29 = new AppThemeBindingExtension();
		FontImageSource val30 = new FontImageSource();
		DataTemplate val31 = new DataTemplate(typeof(SelectionPage));
		ShellContent val32 = new ShellContent();
		FlyoutItem val33 = new FlyoutItem();
		AppThemeBindingExtension val34 = new AppThemeBindingExtension();
		FontImageSource val35 = new FontImageSource();
		DataTemplate val36 = new DataTemplate(typeof(PickersPage));
		ShellContent val37 = new ShellContent();
		FlyoutItem val38 = new FlyoutItem();
		AppThemeBindingExtension val39 = new AppThemeBindingExtension();
		FontImageSource val40 = new FontImageSource();
		DataTemplate val41 = new DataTemplate(typeof(ListsPage));
		ShellContent val42 = new ShellContent();
		FlyoutItem val43 = new FlyoutItem();
		AppThemeBindingExtension val44 = new AppThemeBindingExtension();
		FontImageSource val45 = new FontImageSource();
		DataTemplate val46 = new DataTemplate(typeof(ProgressPage));
		ShellContent val47 = new ShellContent();
		FlyoutItem val48 = new FlyoutItem();
		AppThemeBindingExtension val49 = new AppThemeBindingExtension();
		FontImageSource val50 = new FontImageSource();
		DataTemplate val51 = new DataTemplate(typeof(GridsPage));
		ShellContent val52 = new ShellContent();
		FlyoutItem val53 = new FlyoutItem();
		AppThemeBindingExtension val54 = new AppThemeBindingExtension();
		FontImageSource val55 = new FontImageSource();
		DataTemplate val56 = new DataTemplate(typeof(AboutPage));
		ShellContent val57 = new ShellContent();
		FlyoutItem val58 = new FlyoutItem();
		AppShell appShell;
		NameScope val59 = (NameScope)(((object)NameScope.GetNameScope((BindableObject)(object)(appShell = this))) ?? ((object)new NameScope()));
		NameScope.SetNameScope((BindableObject)(object)appShell, (INameScope)(object)val59);
		((Element)val13).transientNamescope = (INameScope)(object)val59;
		((Element)val12).transientNamescope = (INameScope)(object)val59;
		((Element)val6).transientNamescope = (INameScope)(object)val59;
		((Element)val11).transientNamescope = (INameScope)(object)val59;
		((Element)val8).transientNamescope = (INameScope)(object)val59;
		((Element)val10).transientNamescope = (INameScope)(object)val59;
		((Element)val18).transientNamescope = (INameScope)(object)val59;
		((Element)val15).transientNamescope = (INameScope)(object)val59;
		((Element)val17).transientNamescope = (INameScope)(object)val59;
		((Element)val23).transientNamescope = (INameScope)(object)val59;
		((Element)val20).transientNamescope = (INameScope)(object)val59;
		((Element)val22).transientNamescope = (INameScope)(object)val59;
		((Element)val28).transientNamescope = (INameScope)(object)val59;
		((Element)val25).transientNamescope = (INameScope)(object)val59;
		((Element)val27).transientNamescope = (INameScope)(object)val59;
		((Element)val33).transientNamescope = (INameScope)(object)val59;
		((Element)val30).transientNamescope = (INameScope)(object)val59;
		((Element)val32).transientNamescope = (INameScope)(object)val59;
		((Element)val38).transientNamescope = (INameScope)(object)val59;
		((Element)val35).transientNamescope = (INameScope)(object)val59;
		((Element)val37).transientNamescope = (INameScope)(object)val59;
		((Element)val43).transientNamescope = (INameScope)(object)val59;
		((Element)val40).transientNamescope = (INameScope)(object)val59;
		((Element)val42).transientNamescope = (INameScope)(object)val59;
		((Element)val48).transientNamescope = (INameScope)(object)val59;
		((Element)val45).transientNamescope = (INameScope)(object)val59;
		((Element)val47).transientNamescope = (INameScope)(object)val59;
		((Element)val53).transientNamescope = (INameScope)(object)val59;
		((Element)val50).transientNamescope = (INameScope)(object)val59;
		((Element)val52).transientNamescope = (INameScope)(object)val59;
		((Element)val58).transientNamescope = (INameScope)(object)val59;
		((Element)val55).transientNamescope = (INameScope)(object)val59;
		((Element)val57).transientNamescope = (INameScope)(object)val59;
		((BindableObject)appShell).SetValue(Page.TitleProperty, (object)"OpenMaui Controls Demo");
		((BindableObject)appShell).SetValue(Shell.FlyoutBehaviorProperty, (object)(FlyoutBehavior)1);
		val.Key = "FlyoutBackgroundLight";
		StaticResourceExtension val60 = new StaticResourceExtension
		{
			Key = "FlyoutBackgroundLight"
		};
		XamlServiceProvider val61 = new XamlServiceProvider();
		Type? typeFromHandle = typeof(IProvideValueTarget);
		object[] array = new object[0 + 2];
		array[0] = val3;
		array[1] = appShell;
		SimpleValueTargetProvider val62 = new SimpleValueTargetProvider(array, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Light"), (INameScope[])(object)new NameScope[3] { val59, val59, val59 }, false);
		object obj = (object)val62;
		val61.Add(typeFromHandle, (object)val62);
		val61.Add(typeof(IReferenceProvider), obj);
		val61.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(8, 8)));
		object light = val60.ProvideValue((IServiceProvider)val61);
		val3.Light = light;
		val2.Key = "FlyoutBackgroundDark";
		StaticResourceExtension val63 = new StaticResourceExtension
		{
			Key = "FlyoutBackgroundDark"
		};
		XamlServiceProvider val64 = new XamlServiceProvider();
		Type? typeFromHandle2 = typeof(IProvideValueTarget);
		object[] array2 = new object[0 + 2];
		array2[0] = val3;
		array2[1] = appShell;
		SimpleValueTargetProvider val65 = new SimpleValueTargetProvider(array2, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Dark"), (INameScope[])(object)new NameScope[3] { val59, val59, val59 }, false);
		object obj2 = (object)val65;
		val64.Add(typeFromHandle2, (object)val65);
		val64.Add(typeof(IReferenceProvider), obj2);
		val64.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(8, 8)));
		object dark = val63.ProvideValue((IServiceProvider)val64);
		val3.Dark = dark;
		XamlServiceProvider val66 = new XamlServiceProvider();
		val66.Add(typeof(IProvideValueTarget), (object)new ValueTargetProvider((object)appShell, (object)Shell.FlyoutBackgroundColorProperty));
		val66.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(8, 8)));
		BindingBase val67 = ((IMarkupExtension<BindingBase>)(object)val3).ProvideValue((IServiceProvider)val66);
		((BindableObject)appShell).SetBinding(Shell.FlyoutBackgroundColorProperty, val67);
		val4.Key = "PrimaryColor";
		StaticResourceExtension val68 = new StaticResourceExtension
		{
			Key = "PrimaryColor"
		};
		XamlServiceProvider val69 = new XamlServiceProvider();
		Type? typeFromHandle3 = typeof(IProvideValueTarget);
		object[] array3 = new object[0 + 3];
		array3[0] = val5;
		array3[1] = val13;
		array3[2] = appShell;
		SimpleValueTargetProvider val70 = new SimpleValueTargetProvider(array3, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Light"), (INameScope[])(object)new NameScope[4] { val59, val59, val59, val59 }, false);
		object obj3 = (object)val70;
		val69.Add(typeFromHandle3, (object)val70);
		val69.Add(typeof(IReferenceProvider), obj3);
		val69.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(12, 15)));
		object light2 = val68.ProvideValue((IServiceProvider)val69);
		val5.Light = light2;
		val5.Dark = "#1A1A2E";
		XamlServiceProvider val71 = new XamlServiceProvider();
		val71.Add(typeof(IProvideValueTarget), (object)new ValueTargetProvider((object)val13, (object)VisualElement.BackgroundColorProperty));
		val71.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(12, 15)));
		BindingBase val72 = ((IMarkupExtension<BindingBase>)(object)val5).ProvideValue((IServiceProvider)val71);
		((BindableObject)val13).SetBinding(VisualElement.BackgroundColorProperty, val72);
		((BindableObject)val13).SetValue(VisualElement.HeightRequestProperty, (object)140.0);
		((BindableObject)val13).SetValue(Layout.PaddingProperty, (object)new Thickness(15.0));
		((BindableObject)val12).SetValue(View.VerticalOptionsProperty, (object)LayoutOptions.Center);
		((BindableObject)val12).SetValue(StackBase.SpacingProperty, (object)12.0);
		((BindableObject)val6).SetValue(Image.SourceProperty, (object)ImageSource.FromFile("openmaui_logo.svg"));
		((BindableObject)val6).SetValue(VisualElement.WidthRequestProperty, (object)60.0);
		((BindableObject)val6).SetValue(VisualElement.HeightRequestProperty, (object)60.0);
		((Layout)val12).Children.Add((IView)(object)val6);
		((BindableObject)val11).SetValue(View.VerticalOptionsProperty, (object)LayoutOptions.Center);
		((BindableObject)val8).SetValue(Label.TextProperty, (object)"OpenMaui");
		((BindableObject)val8).SetValue(Label.FontSizeProperty, (object)22.0);
		((BindableObject)val8).SetValue(Label.FontAttributesProperty, (object)(FontAttributes)1);
		val7.Light = "White";
		val7.Dark = "#E0E0E0";
		XamlServiceProvider val73 = new XamlServiceProvider();
		val73.Add(typeof(IProvideValueTarget), (object)new ValueTargetProvider((object)val8, (object)Label.TextColorProperty));
		val73.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(23, 28)));
		BindingBase val74 = ((IMarkupExtension<BindingBase>)(object)val7).ProvideValue((IServiceProvider)val73);
		((BindableObject)val8).SetBinding(Label.TextColorProperty, val74);
		((Layout)val11).Children.Add((IView)(object)val8);
		((BindableObject)val10).SetValue(Label.TextProperty, (object)"Controls Demo");
		((BindableObject)val10).SetValue(Label.FontSizeProperty, (object)13.0);
		val9.Light = "White";
		val9.Dark = "#B0B0B0";
		XamlServiceProvider val75 = new XamlServiceProvider();
		val75.Add(typeof(IProvideValueTarget), (object)new ValueTargetProvider((object)val10, (object)Label.TextColorProperty));
		val75.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(26, 28)));
		BindingBase val76 = ((IMarkupExtension<BindingBase>)(object)val9).ProvideValue((IServiceProvider)val75);
		((BindableObject)val10).SetBinding(Label.TextColorProperty, val76);
		((BindableObject)val10).SetValue(VisualElement.OpacityProperty, (object)0.9);
		((Layout)val11).Children.Add((IView)(object)val10);
		((Layout)val12).Children.Add((IView)(object)val11);
		((Layout)val13).Children.Add((IView)(object)val12);
		((BindableObject)appShell).SetValue(Shell.FlyoutHeaderProperty, (object)val13);
		((BindableObject)val18).SetValue(BaseShellItem.TitleProperty, (object)"Home");
		((BaseShellItem)val18).Route = "Home";
		((BindableObject)val15).SetValue(FontImageSource.GlyphProperty, (object)"\ud83c\udfe0");
		((BindableObject)val15).SetValue(FontImageSource.FontFamilyProperty, (object)"Default");
		val14.Light = "#424242";
		val14.Dark = "#E0E0E0";
		XamlServiceProvider val77 = new XamlServiceProvider();
		val77.Add(typeof(IProvideValueTarget), (object)new ValueTargetProvider((object)val15, (object)FontImageSource.ColorProperty));
		val77.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(36, 69)));
		BindingBase val78 = ((IMarkupExtension<BindingBase>)(object)val14).ProvideValue((IServiceProvider)val77);
		((BindableObject)val15).SetBinding(FontImageSource.ColorProperty, val78);
		((BindableObject)val18).SetValue(BaseShellItem.IconProperty, (object)val15);
		((BindableObject)val17).SetValue(ShellContent.ContentTemplateProperty, (object)val16);
		((ICollection<ShellSection>)((BindableObject)val18).GetValue(ShellItem.ItemsProperty)).Add(ShellSection.op_Implicit(val17));
		((ICollection<ShellItem>)((BindableObject)appShell).GetValue(Shell.ItemsProperty)).Add((ShellItem)(object)val18);
		((BindableObject)val23).SetValue(BaseShellItem.TitleProperty, (object)"Buttons");
		((BaseShellItem)val23).Route = "Buttons";
		((BindableObject)val20).SetValue(FontImageSource.GlyphProperty, (object)"\ud83d\udc46");
		((BindableObject)val20).SetValue(FontImageSource.FontFamilyProperty, (object)"Default");
		val19.Light = "#424242";
		val19.Dark = "#E0E0E0";
		XamlServiceProvider val79 = new XamlServiceProvider();
		val79.Add(typeof(IProvideValueTarget), (object)new ValueTargetProvider((object)val20, (object)FontImageSource.ColorProperty));
		val79.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(44, 69)));
		BindingBase val80 = ((IMarkupExtension<BindingBase>)(object)val19).ProvideValue((IServiceProvider)val79);
		((BindableObject)val20).SetBinding(FontImageSource.ColorProperty, val80);
		((BindableObject)val23).SetValue(BaseShellItem.IconProperty, (object)val20);
		((BindableObject)val22).SetValue(ShellContent.ContentTemplateProperty, (object)val21);
		((ICollection<ShellSection>)((BindableObject)val23).GetValue(ShellItem.ItemsProperty)).Add(ShellSection.op_Implicit(val22));
		((ICollection<ShellItem>)((BindableObject)appShell).GetValue(Shell.ItemsProperty)).Add((ShellItem)(object)val23);
		((BindableObject)val28).SetValue(BaseShellItem.TitleProperty, (object)"Text Input");
		((BaseShellItem)val28).Route = "TextInput";
		((BindableObject)val25).SetValue(FontImageSource.GlyphProperty, (object)"\ud83d\udcdd");
		((BindableObject)val25).SetValue(FontImageSource.FontFamilyProperty, (object)"Default");
		val24.Light = "#424242";
		val24.Dark = "#E0E0E0";
		XamlServiceProvider val81 = new XamlServiceProvider();
		val81.Add(typeof(IProvideValueTarget), (object)new ValueTargetProvider((object)val25, (object)FontImageSource.ColorProperty));
		val81.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(52, 69)));
		BindingBase val82 = ((IMarkupExtension<BindingBase>)(object)val24).ProvideValue((IServiceProvider)val81);
		((BindableObject)val25).SetBinding(FontImageSource.ColorProperty, val82);
		((BindableObject)val28).SetValue(BaseShellItem.IconProperty, (object)val25);
		((BindableObject)val27).SetValue(ShellContent.ContentTemplateProperty, (object)val26);
		((ICollection<ShellSection>)((BindableObject)val28).GetValue(ShellItem.ItemsProperty)).Add(ShellSection.op_Implicit(val27));
		((ICollection<ShellItem>)((BindableObject)appShell).GetValue(Shell.ItemsProperty)).Add((ShellItem)(object)val28);
		((BindableObject)val33).SetValue(BaseShellItem.TitleProperty, (object)"Selection");
		((BaseShellItem)val33).Route = "Selection";
		((BindableObject)val30).SetValue(FontImageSource.GlyphProperty, (object)"☑");
		((BindableObject)val30).SetValue(FontImageSource.FontFamilyProperty, (object)"Default");
		val29.Light = "#424242";
		val29.Dark = "#E0E0E0";
		XamlServiceProvider val83 = new XamlServiceProvider();
		val83.Add(typeof(IProvideValueTarget), (object)new ValueTargetProvider((object)val30, (object)FontImageSource.ColorProperty));
		val83.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(60, 68)));
		BindingBase val84 = ((IMarkupExtension<BindingBase>)(object)val29).ProvideValue((IServiceProvider)val83);
		((BindableObject)val30).SetBinding(FontImageSource.ColorProperty, val84);
		((BindableObject)val33).SetValue(BaseShellItem.IconProperty, (object)val30);
		((BindableObject)val32).SetValue(ShellContent.ContentTemplateProperty, (object)val31);
		((ICollection<ShellSection>)((BindableObject)val33).GetValue(ShellItem.ItemsProperty)).Add(ShellSection.op_Implicit(val32));
		((ICollection<ShellItem>)((BindableObject)appShell).GetValue(Shell.ItemsProperty)).Add((ShellItem)(object)val33);
		((BindableObject)val38).SetValue(BaseShellItem.TitleProperty, (object)"Pickers");
		((BaseShellItem)val38).Route = "Pickers";
		((BindableObject)val35).SetValue(FontImageSource.GlyphProperty, (object)"\ud83d\udcc5");
		((BindableObject)val35).SetValue(FontImageSource.FontFamilyProperty, (object)"Default");
		val34.Light = "#424242";
		val34.Dark = "#E0E0E0";
		XamlServiceProvider val85 = new XamlServiceProvider();
		val85.Add(typeof(IProvideValueTarget), (object)new ValueTargetProvider((object)val35, (object)FontImageSource.ColorProperty));
		val85.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(68, 69)));
		BindingBase val86 = ((IMarkupExtension<BindingBase>)(object)val34).ProvideValue((IServiceProvider)val85);
		((BindableObject)val35).SetBinding(FontImageSource.ColorProperty, val86);
		((BindableObject)val38).SetValue(BaseShellItem.IconProperty, (object)val35);
		((BindableObject)val37).SetValue(ShellContent.ContentTemplateProperty, (object)val36);
		((ICollection<ShellSection>)((BindableObject)val38).GetValue(ShellItem.ItemsProperty)).Add(ShellSection.op_Implicit(val37));
		((ICollection<ShellItem>)((BindableObject)appShell).GetValue(Shell.ItemsProperty)).Add((ShellItem)(object)val38);
		((BindableObject)val43).SetValue(BaseShellItem.TitleProperty, (object)"Lists");
		((BaseShellItem)val43).Route = "Lists";
		((BindableObject)val40).SetValue(FontImageSource.GlyphProperty, (object)"\ud83d\udccb");
		((BindableObject)val40).SetValue(FontImageSource.FontFamilyProperty, (object)"Default");
		val39.Light = "#424242";
		val39.Dark = "#E0E0E0";
		XamlServiceProvider val87 = new XamlServiceProvider();
		val87.Add(typeof(IProvideValueTarget), (object)new ValueTargetProvider((object)val40, (object)FontImageSource.ColorProperty));
		val87.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(76, 69)));
		BindingBase val88 = ((IMarkupExtension<BindingBase>)(object)val39).ProvideValue((IServiceProvider)val87);
		((BindableObject)val40).SetBinding(FontImageSource.ColorProperty, val88);
		((BindableObject)val43).SetValue(BaseShellItem.IconProperty, (object)val40);
		((BindableObject)val42).SetValue(ShellContent.ContentTemplateProperty, (object)val41);
		((ICollection<ShellSection>)((BindableObject)val43).GetValue(ShellItem.ItemsProperty)).Add(ShellSection.op_Implicit(val42));
		((ICollection<ShellItem>)((BindableObject)appShell).GetValue(Shell.ItemsProperty)).Add((ShellItem)(object)val43);
		((BindableObject)val48).SetValue(BaseShellItem.TitleProperty, (object)"Progress");
		((BaseShellItem)val48).Route = "Progress";
		((BindableObject)val45).SetValue(FontImageSource.GlyphProperty, (object)"⏳");
		((BindableObject)val45).SetValue(FontImageSource.FontFamilyProperty, (object)"Default");
		val44.Light = "#424242";
		val44.Dark = "#E0E0E0";
		XamlServiceProvider val89 = new XamlServiceProvider();
		val89.Add(typeof(IProvideValueTarget), (object)new ValueTargetProvider((object)val45, (object)FontImageSource.ColorProperty));
		val89.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(84, 68)));
		BindingBase val90 = ((IMarkupExtension<BindingBase>)(object)val44).ProvideValue((IServiceProvider)val89);
		((BindableObject)val45).SetBinding(FontImageSource.ColorProperty, val90);
		((BindableObject)val48).SetValue(BaseShellItem.IconProperty, (object)val45);
		((BindableObject)val47).SetValue(ShellContent.ContentTemplateProperty, (object)val46);
		((ICollection<ShellSection>)((BindableObject)val48).GetValue(ShellItem.ItemsProperty)).Add(ShellSection.op_Implicit(val47));
		((ICollection<ShellItem>)((BindableObject)appShell).GetValue(Shell.ItemsProperty)).Add((ShellItem)(object)val48);
		((BindableObject)val53).SetValue(BaseShellItem.TitleProperty, (object)"Grids");
		((BaseShellItem)val53).Route = "Grids";
		((BindableObject)val50).SetValue(FontImageSource.GlyphProperty, (object)"\ud83d\udcca");
		((BindableObject)val50).SetValue(FontImageSource.FontFamilyProperty, (object)"Default");
		val49.Light = "#424242";
		val49.Dark = "#E0E0E0";
		XamlServiceProvider val91 = new XamlServiceProvider();
		val91.Add(typeof(IProvideValueTarget), (object)new ValueTargetProvider((object)val50, (object)FontImageSource.ColorProperty));
		val91.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(92, 69)));
		BindingBase val92 = ((IMarkupExtension<BindingBase>)(object)val49).ProvideValue((IServiceProvider)val91);
		((BindableObject)val50).SetBinding(FontImageSource.ColorProperty, val92);
		((BindableObject)val53).SetValue(BaseShellItem.IconProperty, (object)val50);
		((BindableObject)val52).SetValue(ShellContent.ContentTemplateProperty, (object)val51);
		((ICollection<ShellSection>)((BindableObject)val53).GetValue(ShellItem.ItemsProperty)).Add(ShellSection.op_Implicit(val52));
		((ICollection<ShellItem>)((BindableObject)appShell).GetValue(Shell.ItemsProperty)).Add((ShellItem)(object)val53);
		((BindableObject)val58).SetValue(BaseShellItem.TitleProperty, (object)"About");
		((BaseShellItem)val58).Route = "About";
		((BindableObject)val55).SetValue(FontImageSource.GlyphProperty, (object)"ℹ");
		((BindableObject)val55).SetValue(FontImageSource.FontFamilyProperty, (object)"Default");
		val54.Light = "#424242";
		val54.Dark = "#E0E0E0";
		XamlServiceProvider val93 = new XamlServiceProvider();
		val93.Add(typeof(IProvideValueTarget), (object)new ValueTargetProvider((object)val55, (object)FontImageSource.ColorProperty));
		val93.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(100, 68)));
		BindingBase val94 = ((IMarkupExtension<BindingBase>)(object)val54).ProvideValue((IServiceProvider)val93);
		((BindableObject)val55).SetBinding(FontImageSource.ColorProperty, val94);
		((BindableObject)val58).SetValue(BaseShellItem.IconProperty, (object)val55);
		((BindableObject)val57).SetValue(ShellContent.ContentTemplateProperty, (object)val56);
		((ICollection<ShellSection>)((BindableObject)val58).GetValue(ShellItem.ItemsProperty)).Add(ShellSection.op_Implicit(val57));
		((ICollection<ShellItem>)((BindableObject)appShell).GetValue(Shell.ItemsProperty)).Add((ShellItem)(object)val58);
	}
}
