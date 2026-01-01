using System;
using System.CodeDom.Compiler;
using System.Reflection;
using System.Xml;
using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Compatibility;
using Microsoft.Maui.Controls.Internals;
using Microsoft.Maui.Controls.Xaml;
using Microsoft.Maui.Controls.Xaml.Internals;
using Microsoft.Maui.Graphics;
using Microsoft.Maui.Platform.Linux.Hosting;

namespace ShellDemo;

[XamlFilePath("Pages/DetailPage.xaml")]
public class DetailPage : ContentPage
{
	public DetailPage()
	{
		InitializeComponent();
	}

	private void OnGoBackClicked(object? sender, EventArgs e)
	{
		Console.WriteLine("[DetailPage] Go Back clicked");
		LinuxViewRenderer.PopPage();
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
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Expected O, but got Unknown
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected O, but got Unknown
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Expected O, but got Unknown
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Expected O, but got Unknown
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected O, but got Unknown
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Expected O, but got Unknown
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Expected O, but got Unknown
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Expected O, but got Unknown
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected O, but got Unknown
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Expected O, but got Unknown
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Expected O, but got Unknown
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Expected O, but got Unknown
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Expected O, but got Unknown
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Expected O, but got Unknown
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Expected O, but got Unknown
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Expected O, but got Unknown
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Expected O, but got Unknown
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Expected O, but got Unknown
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Expected O, but got Unknown
		//IL_018f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0194: Unknown result type (might be due to invalid IL or missing references)
		//IL_019f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f2: Expected O, but got Unknown
		//IL_01f7: Expected O, but got Unknown
		//IL_01f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0209: Unknown result type (might be due to invalid IL or missing references)
		//IL_0217: Unknown result type (might be due to invalid IL or missing references)
		//IL_0221: Expected O, but got Unknown
		//IL_021c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0226: Expected O, but got Unknown
		//IL_022b: Expected O, but got Unknown
		//IL_0240: Unknown result type (might be due to invalid IL or missing references)
		//IL_0245: Unknown result type (might be due to invalid IL or missing references)
		//IL_0250: Unknown result type (might be due to invalid IL or missing references)
		//IL_0255: Unknown result type (might be due to invalid IL or missing references)
		//IL_029b: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a3: Expected O, but got Unknown
		//IL_02a8: Expected O, but got Unknown
		//IL_02a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d2: Expected O, but got Unknown
		//IL_02cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d7: Expected O, but got Unknown
		//IL_02dc: Expected O, but got Unknown
		//IL_02e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0308: Expected O, but got Unknown
		//IL_0308: Unknown result type (might be due to invalid IL or missing references)
		//IL_0316: Unknown result type (might be due to invalid IL or missing references)
		//IL_0320: Expected O, but got Unknown
		//IL_031b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0325: Expected O, but got Unknown
		//IL_032a: Expected O, but got Unknown
		//IL_034a: Unknown result type (might be due to invalid IL or missing references)
		//IL_037a: Unknown result type (might be due to invalid IL or missing references)
		//IL_03da: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0423: Unknown result type (might be due to invalid IL or missing references)
		//IL_042d: Expected O, but got Unknown
		//IL_046c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0481: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_050a: Unknown result type (might be due to invalid IL or missing references)
		//IL_050f: Unknown result type (might be due to invalid IL or missing references)
		//IL_051a: Unknown result type (might be due to invalid IL or missing references)
		//IL_051f: Unknown result type (might be due to invalid IL or missing references)
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
		//IL_05d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0643: Unknown result type (might be due to invalid IL or missing references)
		//IL_0648: Unknown result type (might be due to invalid IL or missing references)
		//IL_064b: Expected O, but got Unknown
		//IL_0650: Expected O, but got Unknown
		//IL_0650: Unknown result type (might be due to invalid IL or missing references)
		//IL_0662: Unknown result type (might be due to invalid IL or missing references)
		//IL_0671: Unknown result type (might be due to invalid IL or missing references)
		//IL_067b: Expected O, but got Unknown
		//IL_0676: Unknown result type (might be due to invalid IL or missing references)
		//IL_0680: Expected O, but got Unknown
		//IL_0685: Expected O, but got Unknown
		//IL_0692: Unknown result type (might be due to invalid IL or missing references)
		//IL_0697: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b3: Expected O, but got Unknown
		//IL_06b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_06cc: Expected O, but got Unknown
		//IL_06c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d1: Expected O, but got Unknown
		//IL_06d6: Expected O, but got Unknown
		//IL_0726: Unknown result type (might be due to invalid IL or missing references)
		//IL_0753: Unknown result type (might be due to invalid IL or missing references)
		//IL_0758: Unknown result type (might be due to invalid IL or missing references)
		//IL_0763: Unknown result type (might be due to invalid IL or missing references)
		//IL_0768: Unknown result type (might be due to invalid IL or missing references)
		//IL_07c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_07c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_07cb: Expected O, but got Unknown
		//IL_07d0: Expected O, but got Unknown
		//IL_07d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_07fb: Expected O, but got Unknown
		//IL_07f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0800: Expected O, but got Unknown
		//IL_0805: Expected O, but got Unknown
		//IL_081c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0821: Unknown result type (might be due to invalid IL or missing references)
		//IL_082c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0831: Unknown result type (might be due to invalid IL or missing references)
		//IL_088c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0891: Unknown result type (might be due to invalid IL or missing references)
		//IL_0894: Expected O, but got Unknown
		//IL_0899: Expected O, but got Unknown
		//IL_0899: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_08c4: Expected O, but got Unknown
		//IL_08bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_08c9: Expected O, but got Unknown
		//IL_08ce: Expected O, but got Unknown
		//IL_08db: Unknown result type (might be due to invalid IL or missing references)
		//IL_08e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_08f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_08fc: Expected O, but got Unknown
		//IL_08fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_090b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0915: Expected O, but got Unknown
		//IL_0910: Unknown result type (might be due to invalid IL or missing references)
		//IL_091a: Expected O, but got Unknown
		//IL_091f: Expected O, but got Unknown
		//IL_0949: Unknown result type (might be due to invalid IL or missing references)
		//IL_094e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0959: Unknown result type (might be due to invalid IL or missing references)
		//IL_095e: Unknown result type (might be due to invalid IL or missing references)
		//IL_09a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_09a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_09a8: Expected O, but got Unknown
		//IL_09ad: Expected O, but got Unknown
		//IL_09ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_09bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_09ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_09d8: Expected O, but got Unknown
		//IL_09d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_09dd: Expected O, but got Unknown
		//IL_09e2: Expected O, but got Unknown
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a3a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a62: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ad4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ad9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ae4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ae9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b58: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b5d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b60: Expected O, but got Unknown
		//IL_0b65: Expected O, but got Unknown
		//IL_0b65: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b77: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b86: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b90: Expected O, but got Unknown
		//IL_0b8b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b95: Expected O, but got Unknown
		//IL_0b9a: Expected O, but got Unknown
		//IL_0bb1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bb6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bc1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bc6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c35: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c3a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c3d: Expected O, but got Unknown
		//IL_0c42: Expected O, but got Unknown
		//IL_0c42: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c54: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c63: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c6d: Expected O, but got Unknown
		//IL_0c68: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c72: Expected O, but got Unknown
		//IL_0c77: Expected O, but got Unknown
		//IL_0c84: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c89: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c9b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ca5: Expected O, but got Unknown
		//IL_0ca5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cb4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cbe: Expected O, but got Unknown
		//IL_0cb9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cc3: Expected O, but got Unknown
		//IL_0cc8: Expected O, but got Unknown
		//IL_0d1d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d22: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d2d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d32: Unknown result type (might be due to invalid IL or missing references)
		//IL_0da1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0da6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0da9: Expected O, but got Unknown
		//IL_0dae: Expected O, but got Unknown
		//IL_0dae: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dc0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dcf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dd9: Expected O, but got Unknown
		//IL_0dd4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dde: Expected O, but got Unknown
		//IL_0de3: Expected O, but got Unknown
		//IL_0dfa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e0a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e0f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e7e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e83: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e86: Expected O, but got Unknown
		//IL_0e8b: Expected O, but got Unknown
		//IL_0e8b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e9d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eac: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eb6: Expected O, but got Unknown
		//IL_0eb1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ebb: Expected O, but got Unknown
		//IL_0ec0: Expected O, but got Unknown
		//IL_0ecd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ed2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ee4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eee: Expected O, but got Unknown
		//IL_0eee: Unknown result type (might be due to invalid IL or missing references)
		//IL_0efd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f07: Expected O, but got Unknown
		//IL_0f02: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f0c: Expected O, but got Unknown
		//IL_0f11: Expected O, but got Unknown
		//IL_0f66: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f6b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f76: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f7b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fea: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fef: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ff2: Expected O, but got Unknown
		//IL_0ff7: Expected O, but got Unknown
		//IL_0ff7: Unknown result type (might be due to invalid IL or missing references)
		//IL_1009: Unknown result type (might be due to invalid IL or missing references)
		//IL_1018: Unknown result type (might be due to invalid IL or missing references)
		//IL_1022: Expected O, but got Unknown
		//IL_101d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1027: Expected O, but got Unknown
		//IL_102c: Expected O, but got Unknown
		//IL_1043: Unknown result type (might be due to invalid IL or missing references)
		//IL_1048: Unknown result type (might be due to invalid IL or missing references)
		//IL_1053: Unknown result type (might be due to invalid IL or missing references)
		//IL_1058: Unknown result type (might be due to invalid IL or missing references)
		//IL_10c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_10cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_10cf: Expected O, but got Unknown
		//IL_10d4: Expected O, but got Unknown
		//IL_10d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_10e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_10f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_10ff: Expected O, but got Unknown
		//IL_10fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_1104: Expected O, but got Unknown
		//IL_1109: Expected O, but got Unknown
		//IL_1116: Unknown result type (might be due to invalid IL or missing references)
		//IL_111b: Unknown result type (might be due to invalid IL or missing references)
		//IL_112d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1137: Expected O, but got Unknown
		//IL_1137: Unknown result type (might be due to invalid IL or missing references)
		//IL_1146: Unknown result type (might be due to invalid IL or missing references)
		//IL_1150: Expected O, but got Unknown
		//IL_114b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1155: Expected O, but got Unknown
		//IL_115a: Expected O, but got Unknown
		//IL_11af: Unknown result type (might be due to invalid IL or missing references)
		//IL_11b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_11bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_11c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_1233: Unknown result type (might be due to invalid IL or missing references)
		//IL_1238: Unknown result type (might be due to invalid IL or missing references)
		//IL_123b: Expected O, but got Unknown
		//IL_1240: Expected O, but got Unknown
		//IL_1240: Unknown result type (might be due to invalid IL or missing references)
		//IL_1252: Unknown result type (might be due to invalid IL or missing references)
		//IL_1261: Unknown result type (might be due to invalid IL or missing references)
		//IL_126b: Expected O, but got Unknown
		//IL_1266: Unknown result type (might be due to invalid IL or missing references)
		//IL_1270: Expected O, but got Unknown
		//IL_1275: Expected O, but got Unknown
		//IL_128c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1291: Unknown result type (might be due to invalid IL or missing references)
		//IL_129c: Unknown result type (might be due to invalid IL or missing references)
		//IL_12a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_1310: Unknown result type (might be due to invalid IL or missing references)
		//IL_1315: Unknown result type (might be due to invalid IL or missing references)
		//IL_1318: Expected O, but got Unknown
		//IL_131d: Expected O, but got Unknown
		//IL_131d: Unknown result type (might be due to invalid IL or missing references)
		//IL_132f: Unknown result type (might be due to invalid IL or missing references)
		//IL_133e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1348: Expected O, but got Unknown
		//IL_1343: Unknown result type (might be due to invalid IL or missing references)
		//IL_134d: Expected O, but got Unknown
		//IL_1352: Expected O, but got Unknown
		//IL_135f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1364: Unknown result type (might be due to invalid IL or missing references)
		//IL_1376: Unknown result type (might be due to invalid IL or missing references)
		//IL_1380: Expected O, but got Unknown
		//IL_1380: Unknown result type (might be due to invalid IL or missing references)
		//IL_138f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1399: Expected O, but got Unknown
		//IL_1394: Unknown result type (might be due to invalid IL or missing references)
		//IL_139e: Expected O, but got Unknown
		//IL_13a3: Expected O, but got Unknown
		//IL_141d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1427: Expected O, but got Unknown
		//IL_143f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1467: Unknown result type (might be due to invalid IL or missing references)
		StaticResourceExtension val = new StaticResourceExtension();
		StaticResourceExtension val2 = new StaticResourceExtension();
		AppThemeBindingExtension val3 = new AppThemeBindingExtension();
		Label val4 = new Label();
		Frame val5 = new Frame();
		StaticResourceExtension val6 = new StaticResourceExtension();
		StaticResourceExtension val7 = new StaticResourceExtension();
		AppThemeBindingExtension val8 = new AppThemeBindingExtension();
		Label val9 = new Label();
		StaticResourceExtension val10 = new StaticResourceExtension();
		StaticResourceExtension val11 = new StaticResourceExtension();
		AppThemeBindingExtension val12 = new AppThemeBindingExtension();
		Label val13 = new Label();
		StaticResourceExtension val14 = new StaticResourceExtension();
		StaticResourceExtension val15 = new StaticResourceExtension();
		StaticResourceExtension val16 = new StaticResourceExtension();
		AppThemeBindingExtension val17 = new AppThemeBindingExtension();
		Label val18 = new Label();
		StaticResourceExtension val19 = new StaticResourceExtension();
		StaticResourceExtension val20 = new StaticResourceExtension();
		AppThemeBindingExtension val21 = new AppThemeBindingExtension();
		Label val22 = new Label();
		StaticResourceExtension val23 = new StaticResourceExtension();
		StaticResourceExtension val24 = new StaticResourceExtension();
		AppThemeBindingExtension val25 = new AppThemeBindingExtension();
		Label val26 = new Label();
		StaticResourceExtension val27 = new StaticResourceExtension();
		StaticResourceExtension val28 = new StaticResourceExtension();
		AppThemeBindingExtension val29 = new AppThemeBindingExtension();
		Label val30 = new Label();
		VerticalStackLayout val31 = new VerticalStackLayout();
		Frame val32 = new Frame();
		Button val33 = new Button();
		VerticalStackLayout val34 = new VerticalStackLayout();
		DetailPage detailPage;
		NameScope val35 = (NameScope)(((object)NameScope.GetNameScope((BindableObject)(object)(detailPage = this))) ?? ((object)new NameScope()));
		NameScope.SetNameScope((BindableObject)(object)detailPage, (INameScope)(object)val35);
		((Element)val34).transientNamescope = (INameScope)(object)val35;
		((Element)val5).transientNamescope = (INameScope)(object)val35;
		((Element)val4).transientNamescope = (INameScope)(object)val35;
		((Element)val9).transientNamescope = (INameScope)(object)val35;
		((Element)val13).transientNamescope = (INameScope)(object)val35;
		((Element)val32).transientNamescope = (INameScope)(object)val35;
		((Element)val31).transientNamescope = (INameScope)(object)val35;
		((Element)val18).transientNamescope = (INameScope)(object)val35;
		((Element)val22).transientNamescope = (INameScope)(object)val35;
		((Element)val26).transientNamescope = (INameScope)(object)val35;
		((Element)val30).transientNamescope = (INameScope)(object)val35;
		((Element)val33).transientNamescope = (INameScope)(object)val35;
		((BindableObject)detailPage).SetValue(Page.TitleProperty, (object)"Detail Page");
		val.Key = "PageBackgroundLight";
		StaticResourceExtension val36 = new StaticResourceExtension
		{
			Key = "PageBackgroundLight"
		};
		XamlServiceProvider val37 = new XamlServiceProvider();
		Type? typeFromHandle = typeof(IProvideValueTarget);
		object[] array = new object[0 + 2];
		array[0] = val3;
		array[1] = detailPage;
		SimpleValueTargetProvider val38 = new SimpleValueTargetProvider(array, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Light"), (INameScope[])(object)new NameScope[3] { val35, val35, val35 }, false);
		object obj = (object)val38;
		val37.Add(typeFromHandle, (object)val38);
		val37.Add(typeof(IReferenceProvider), obj);
		val37.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(6, 14)));
		object light = val36.ProvideValue((IServiceProvider)val37);
		val3.Light = light;
		val2.Key = "PageBackgroundDark";
		StaticResourceExtension val39 = new StaticResourceExtension
		{
			Key = "PageBackgroundDark"
		};
		XamlServiceProvider val40 = new XamlServiceProvider();
		Type? typeFromHandle2 = typeof(IProvideValueTarget);
		object[] array2 = new object[0 + 2];
		array2[0] = val3;
		array2[1] = detailPage;
		SimpleValueTargetProvider val41 = new SimpleValueTargetProvider(array2, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Dark"), (INameScope[])(object)new NameScope[3] { val35, val35, val35 }, false);
		object obj2 = (object)val41;
		val40.Add(typeFromHandle2, (object)val41);
		val40.Add(typeof(IReferenceProvider), obj2);
		val40.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(6, 14)));
		object dark = val39.ProvideValue((IServiceProvider)val40);
		val3.Dark = dark;
		XamlServiceProvider val42 = new XamlServiceProvider();
		val42.Add(typeof(IProvideValueTarget), (object)new ValueTargetProvider((object)detailPage, (object)VisualElement.BackgroundColorProperty));
		val42.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(6, 14)));
		BindingBase val43 = ((IMarkupExtension<BindingBase>)(object)val3).ProvideValue((IServiceProvider)val42);
		((BindableObject)detailPage).SetBinding(VisualElement.BackgroundColorProperty, val43);
		((BindableObject)val34).SetValue(Layout.PaddingProperty, (object)new Thickness(30.0));
		((BindableObject)val34).SetValue(StackBase.SpacingProperty, (object)20.0);
		((BindableObject)val34).SetValue(View.VerticalOptionsProperty, (object)LayoutOptions.Center);
		((BindableObject)val5).SetValue(Frame.CornerRadiusProperty, (object)50f);
		((BindableObject)val5).SetValue(VisualElement.WidthRequestProperty, (object)80.0);
		((BindableObject)val5).SetValue(VisualElement.HeightRequestProperty, (object)80.0);
		((BindableObject)val5).SetValue(View.HorizontalOptionsProperty, (object)LayoutOptions.Center);
		((BindableObject)val5).SetValue(Layout.PaddingProperty, (object)new Thickness(0.0));
		((BindableObject)val5).SetValue(VisualElement.BackgroundColorProperty, (object)new Color(52f / 85f, 13f / 85f, 0.6901961f, 1f));
		((BindableObject)val4).SetValue(Label.TextProperty, (object)"→");
		((BindableObject)val4).SetValue(Label.FontSizeProperty, (object)32.0);
		((BindableObject)val4).SetValue(Label.TextColorProperty, (object)Colors.White);
		((BindableObject)val4).SetValue(View.HorizontalOptionsProperty, (object)LayoutOptions.Center);
		((BindableObject)val4).SetValue(View.VerticalOptionsProperty, (object)LayoutOptions.Center);
		((BindableObject)val5).SetValue(ContentView.ContentProperty, (object)val4);
		((Layout)val34).Children.Add((IView)(object)val5);
		((BindableObject)val9).SetValue(Label.TextProperty, (object)"Detail Page");
		((BindableObject)val9).SetValue(Label.FontSizeProperty, (object)28.0);
		((BindableObject)val9).SetValue(Label.FontAttributesProperty, (object)(FontAttributes)1);
		((BindableObject)val9).SetValue(View.HorizontalOptionsProperty, (object)LayoutOptions.Center);
		val6.Key = "TextPrimaryLight";
		StaticResourceExtension val44 = new StaticResourceExtension
		{
			Key = "TextPrimaryLight"
		};
		XamlServiceProvider val45 = new XamlServiceProvider();
		Type? typeFromHandle3 = typeof(IProvideValueTarget);
		object[] array3 = new object[0 + 4];
		array3[0] = val8;
		array3[1] = val9;
		array3[2] = val34;
		array3[3] = detailPage;
		SimpleValueTargetProvider val46 = new SimpleValueTargetProvider(array3, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Light"), (INameScope[])(object)new NameScope[5] { val35, val35, val35, val35, val35 }, false);
		object obj3 = (object)val46;
		val45.Add(typeFromHandle3, (object)val46);
		val45.Add(typeof(IReferenceProvider), obj3);
		val45.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(17, 16)));
		object light2 = val44.ProvideValue((IServiceProvider)val45);
		val8.Light = light2;
		val7.Key = "TextPrimaryDark";
		StaticResourceExtension val47 = new StaticResourceExtension
		{
			Key = "TextPrimaryDark"
		};
		XamlServiceProvider val48 = new XamlServiceProvider();
		Type? typeFromHandle4 = typeof(IProvideValueTarget);
		object[] array4 = new object[0 + 4];
		array4[0] = val8;
		array4[1] = val9;
		array4[2] = val34;
		array4[3] = detailPage;
		SimpleValueTargetProvider val49 = new SimpleValueTargetProvider(array4, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Dark"), (INameScope[])(object)new NameScope[5] { val35, val35, val35, val35, val35 }, false);
		object obj4 = (object)val49;
		val48.Add(typeFromHandle4, (object)val49);
		val48.Add(typeof(IReferenceProvider), obj4);
		val48.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(17, 16)));
		object dark2 = val47.ProvideValue((IServiceProvider)val48);
		val8.Dark = dark2;
		XamlServiceProvider val50 = new XamlServiceProvider();
		val50.Add(typeof(IProvideValueTarget), (object)new ValueTargetProvider((object)val9, (object)Label.TextColorProperty));
		val50.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(17, 16)));
		BindingBase val51 = ((IMarkupExtension<BindingBase>)(object)val8).ProvideValue((IServiceProvider)val50);
		((BindableObject)val9).SetBinding(Label.TextColorProperty, val51);
		((Layout)val34).Children.Add((IView)(object)val9);
		((BindableObject)val13).SetValue(Label.TextProperty, (object)"This page was pushed onto the navigation stack.");
		((BindableObject)val13).SetValue(Label.FontSizeProperty, (object)16.0);
		((BindableObject)val13).SetValue(View.HorizontalOptionsProperty, (object)LayoutOptions.Center);
		((BindableObject)val13).SetValue(Label.HorizontalTextAlignmentProperty, (object)(TextAlignment)1);
		val10.Key = "TextSecondaryLight";
		StaticResourceExtension val52 = new StaticResourceExtension
		{
			Key = "TextSecondaryLight"
		};
		XamlServiceProvider val53 = new XamlServiceProvider();
		Type? typeFromHandle5 = typeof(IProvideValueTarget);
		object[] array5 = new object[0 + 4];
		array5[0] = val12;
		array5[1] = val13;
		array5[2] = val34;
		array5[3] = detailPage;
		SimpleValueTargetProvider val54 = new SimpleValueTargetProvider(array5, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Light"), (INameScope[])(object)new NameScope[5] { val35, val35, val35, val35, val35 }, false);
		object obj5 = (object)val54;
		val53.Add(typeFromHandle5, (object)val54);
		val53.Add(typeof(IReferenceProvider), obj5);
		val53.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(21, 16)));
		object light3 = val52.ProvideValue((IServiceProvider)val53);
		val12.Light = light3;
		val11.Key = "TextSecondaryDark";
		StaticResourceExtension val55 = new StaticResourceExtension
		{
			Key = "TextSecondaryDark"
		};
		XamlServiceProvider val56 = new XamlServiceProvider();
		Type? typeFromHandle6 = typeof(IProvideValueTarget);
		object[] array6 = new object[0 + 4];
		array6[0] = val12;
		array6[1] = val13;
		array6[2] = val34;
		array6[3] = detailPage;
		SimpleValueTargetProvider val57 = new SimpleValueTargetProvider(array6, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Dark"), (INameScope[])(object)new NameScope[5] { val35, val35, val35, val35, val35 }, false);
		object obj6 = (object)val57;
		val56.Add(typeFromHandle6, (object)val57);
		val56.Add(typeof(IReferenceProvider), obj6);
		val56.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(21, 16)));
		object dark3 = val55.ProvideValue((IServiceProvider)val56);
		val12.Dark = dark3;
		XamlServiceProvider val58 = new XamlServiceProvider();
		val58.Add(typeof(IProvideValueTarget), (object)new ValueTargetProvider((object)val13, (object)Label.TextColorProperty));
		val58.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(21, 16)));
		BindingBase val59 = ((IMarkupExtension<BindingBase>)(object)val12).ProvideValue((IServiceProvider)val58);
		((BindableObject)val13).SetBinding(Label.TextColorProperty, val59);
		((Layout)val34).Children.Add((IView)(object)val13);
		val14.Key = "ThemedFrame";
		StaticResourceExtension val60 = new StaticResourceExtension
		{
			Key = "ThemedFrame"
		};
		XamlServiceProvider val61 = new XamlServiceProvider();
		Type? typeFromHandle7 = typeof(IProvideValueTarget);
		object[] array7 = new object[0 + 3];
		array7[0] = val32;
		array7[1] = val34;
		array7[2] = detailPage;
		SimpleValueTargetProvider val62 = new SimpleValueTargetProvider(array7, (object)VisualElement.StyleProperty, (INameScope[])(object)new NameScope[4] { val35, val35, val35, val35 }, false);
		object obj7 = (object)val62;
		val61.Add(typeFromHandle7, (object)val62);
		val61.Add(typeof(IReferenceProvider), obj7);
		val61.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(23, 16)));
		object obj8 = val60.ProvideValue((IServiceProvider)val61);
		((BindableObject)val32).SetValue(VisualElement.StyleProperty, (obj8 == null || !typeof(BindingBase).IsAssignableFrom(obj8.GetType())) ? obj8 : obj8);
		((BindableObject)val32).SetValue(Frame.CornerRadiusProperty, (object)8f);
		((BindableObject)val32).SetValue(Layout.PaddingProperty, (object)new Thickness(20.0));
		((BindableObject)val32).SetValue(View.MarginProperty, (object)new Thickness(0.0, 20.0));
		((BindableObject)val31).SetValue(StackBase.SpacingProperty, (object)10.0);
		((BindableObject)val18).SetValue(Label.TextProperty, (object)"Navigation Info");
		((BindableObject)val18).SetValue(Label.FontSizeProperty, (object)18.0);
		((BindableObject)val18).SetValue(Label.FontAttributesProperty, (object)(FontAttributes)1);
		val15.Key = "TextPrimaryLight";
		StaticResourceExtension val63 = new StaticResourceExtension
		{
			Key = "TextPrimaryLight"
		};
		XamlServiceProvider val64 = new XamlServiceProvider();
		Type? typeFromHandle8 = typeof(IProvideValueTarget);
		object[] array8 = new object[0 + 6];
		array8[0] = val17;
		array8[1] = val18;
		array8[2] = val31;
		array8[3] = val32;
		array8[4] = val34;
		array8[5] = detailPage;
		SimpleValueTargetProvider val65 = new SimpleValueTargetProvider(array8, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Light"), (INameScope[])(object)new NameScope[7] { val35, val35, val35, val35, val35, val35, val35 }, false);
		object obj9 = (object)val65;
		val64.Add(typeFromHandle8, (object)val65);
		val64.Add(typeof(IReferenceProvider), obj9);
		val64.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(26, 24)));
		object light4 = val63.ProvideValue((IServiceProvider)val64);
		val17.Light = light4;
		val16.Key = "TextPrimaryDark";
		StaticResourceExtension val66 = new StaticResourceExtension
		{
			Key = "TextPrimaryDark"
		};
		XamlServiceProvider val67 = new XamlServiceProvider();
		Type? typeFromHandle9 = typeof(IProvideValueTarget);
		object[] array9 = new object[0 + 6];
		array9[0] = val17;
		array9[1] = val18;
		array9[2] = val31;
		array9[3] = val32;
		array9[4] = val34;
		array9[5] = detailPage;
		SimpleValueTargetProvider val68 = new SimpleValueTargetProvider(array9, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Dark"), (INameScope[])(object)new NameScope[7] { val35, val35, val35, val35, val35, val35, val35 }, false);
		object obj10 = (object)val68;
		val67.Add(typeFromHandle9, (object)val68);
		val67.Add(typeof(IReferenceProvider), obj10);
		val67.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(26, 24)));
		object dark4 = val66.ProvideValue((IServiceProvider)val67);
		val17.Dark = dark4;
		XamlServiceProvider val69 = new XamlServiceProvider();
		val69.Add(typeof(IProvideValueTarget), (object)new ValueTargetProvider((object)val18, (object)Label.TextColorProperty));
		val69.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(26, 24)));
		BindingBase val70 = ((IMarkupExtension<BindingBase>)(object)val17).ProvideValue((IServiceProvider)val69);
		((BindableObject)val18).SetBinding(Label.TextColorProperty, val70);
		((Layout)val31).Children.Add((IView)(object)val18);
		((BindableObject)val22).SetValue(Label.TextProperty, (object)"• Use Shell.GoToAsync() to navigate");
		((BindableObject)val22).SetValue(Label.FontSizeProperty, (object)14.0);
		val19.Key = "TextPrimaryLight";
		StaticResourceExtension val71 = new StaticResourceExtension
		{
			Key = "TextPrimaryLight"
		};
		XamlServiceProvider val72 = new XamlServiceProvider();
		Type? typeFromHandle10 = typeof(IProvideValueTarget);
		object[] array10 = new object[0 + 6];
		array10[0] = val21;
		array10[1] = val22;
		array10[2] = val31;
		array10[3] = val32;
		array10[4] = val34;
		array10[5] = detailPage;
		SimpleValueTargetProvider val73 = new SimpleValueTargetProvider(array10, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Light"), (INameScope[])(object)new NameScope[7] { val35, val35, val35, val35, val35, val35, val35 }, false);
		object obj11 = (object)val73;
		val72.Add(typeFromHandle10, (object)val73);
		val72.Add(typeof(IReferenceProvider), obj11);
		val72.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(28, 24)));
		object light5 = val71.ProvideValue((IServiceProvider)val72);
		val21.Light = light5;
		val20.Key = "TextPrimaryDark";
		StaticResourceExtension val74 = new StaticResourceExtension
		{
			Key = "TextPrimaryDark"
		};
		XamlServiceProvider val75 = new XamlServiceProvider();
		Type? typeFromHandle11 = typeof(IProvideValueTarget);
		object[] array11 = new object[0 + 6];
		array11[0] = val21;
		array11[1] = val22;
		array11[2] = val31;
		array11[3] = val32;
		array11[4] = val34;
		array11[5] = detailPage;
		SimpleValueTargetProvider val76 = new SimpleValueTargetProvider(array11, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Dark"), (INameScope[])(object)new NameScope[7] { val35, val35, val35, val35, val35, val35, val35 }, false);
		object obj12 = (object)val76;
		val75.Add(typeFromHandle11, (object)val76);
		val75.Add(typeof(IReferenceProvider), obj12);
		val75.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(28, 24)));
		object dark5 = val74.ProvideValue((IServiceProvider)val75);
		val21.Dark = dark5;
		XamlServiceProvider val77 = new XamlServiceProvider();
		val77.Add(typeof(IProvideValueTarget), (object)new ValueTargetProvider((object)val22, (object)Label.TextColorProperty));
		val77.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(28, 24)));
		BindingBase val78 = ((IMarkupExtension<BindingBase>)(object)val21).ProvideValue((IServiceProvider)val77);
		((BindableObject)val22).SetBinding(Label.TextColorProperty, val78);
		((Layout)val31).Children.Add((IView)(object)val22);
		((BindableObject)val26).SetValue(Label.TextProperty, (object)"• Use the back button to return");
		((BindableObject)val26).SetValue(Label.FontSizeProperty, (object)14.0);
		val23.Key = "TextPrimaryLight";
		StaticResourceExtension val79 = new StaticResourceExtension
		{
			Key = "TextPrimaryLight"
		};
		XamlServiceProvider val80 = new XamlServiceProvider();
		Type? typeFromHandle12 = typeof(IProvideValueTarget);
		object[] array12 = new object[0 + 6];
		array12[0] = val25;
		array12[1] = val26;
		array12[2] = val31;
		array12[3] = val32;
		array12[4] = val34;
		array12[5] = detailPage;
		SimpleValueTargetProvider val81 = new SimpleValueTargetProvider(array12, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Light"), (INameScope[])(object)new NameScope[7] { val35, val35, val35, val35, val35, val35, val35 }, false);
		object obj13 = (object)val81;
		val80.Add(typeFromHandle12, (object)val81);
		val80.Add(typeof(IReferenceProvider), obj13);
		val80.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(30, 24)));
		object light6 = val79.ProvideValue((IServiceProvider)val80);
		val25.Light = light6;
		val24.Key = "TextPrimaryDark";
		StaticResourceExtension val82 = new StaticResourceExtension
		{
			Key = "TextPrimaryDark"
		};
		XamlServiceProvider val83 = new XamlServiceProvider();
		Type? typeFromHandle13 = typeof(IProvideValueTarget);
		object[] array13 = new object[0 + 6];
		array13[0] = val25;
		array13[1] = val26;
		array13[2] = val31;
		array13[3] = val32;
		array13[4] = val34;
		array13[5] = detailPage;
		SimpleValueTargetProvider val84 = new SimpleValueTargetProvider(array13, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Dark"), (INameScope[])(object)new NameScope[7] { val35, val35, val35, val35, val35, val35, val35 }, false);
		object obj14 = (object)val84;
		val83.Add(typeFromHandle13, (object)val84);
		val83.Add(typeof(IReferenceProvider), obj14);
		val83.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(30, 24)));
		object dark6 = val82.ProvideValue((IServiceProvider)val83);
		val25.Dark = dark6;
		XamlServiceProvider val85 = new XamlServiceProvider();
		val85.Add(typeof(IProvideValueTarget), (object)new ValueTargetProvider((object)val26, (object)Label.TextColorProperty));
		val85.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(30, 24)));
		BindingBase val86 = ((IMarkupExtension<BindingBase>)(object)val25).ProvideValue((IServiceProvider)val85);
		((BindableObject)val26).SetBinding(Label.TextColorProperty, val86);
		((Layout)val31).Children.Add((IView)(object)val26);
		((BindableObject)val30).SetValue(Label.TextProperty, (object)"• Or tap 'Go Back' below");
		((BindableObject)val30).SetValue(Label.FontSizeProperty, (object)14.0);
		val27.Key = "TextPrimaryLight";
		StaticResourceExtension val87 = new StaticResourceExtension
		{
			Key = "TextPrimaryLight"
		};
		XamlServiceProvider val88 = new XamlServiceProvider();
		Type? typeFromHandle14 = typeof(IProvideValueTarget);
		object[] array14 = new object[0 + 6];
		array14[0] = val29;
		array14[1] = val30;
		array14[2] = val31;
		array14[3] = val32;
		array14[4] = val34;
		array14[5] = detailPage;
		SimpleValueTargetProvider val89 = new SimpleValueTargetProvider(array14, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Light"), (INameScope[])(object)new NameScope[7] { val35, val35, val35, val35, val35, val35, val35 }, false);
		object obj15 = (object)val89;
		val88.Add(typeFromHandle14, (object)val89);
		val88.Add(typeof(IReferenceProvider), obj15);
		val88.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(32, 24)));
		object light7 = val87.ProvideValue((IServiceProvider)val88);
		val29.Light = light7;
		val28.Key = "TextPrimaryDark";
		StaticResourceExtension val90 = new StaticResourceExtension
		{
			Key = "TextPrimaryDark"
		};
		XamlServiceProvider val91 = new XamlServiceProvider();
		Type? typeFromHandle15 = typeof(IProvideValueTarget);
		object[] array15 = new object[0 + 6];
		array15[0] = val29;
		array15[1] = val30;
		array15[2] = val31;
		array15[3] = val32;
		array15[4] = val34;
		array15[5] = detailPage;
		SimpleValueTargetProvider val92 = new SimpleValueTargetProvider(array15, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Dark"), (INameScope[])(object)new NameScope[7] { val35, val35, val35, val35, val35, val35, val35 }, false);
		object obj16 = (object)val92;
		val91.Add(typeFromHandle15, (object)val92);
		val91.Add(typeof(IReferenceProvider), obj16);
		val91.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(32, 24)));
		object dark7 = val90.ProvideValue((IServiceProvider)val91);
		val29.Dark = dark7;
		XamlServiceProvider val93 = new XamlServiceProvider();
		val93.Add(typeof(IProvideValueTarget), (object)new ValueTargetProvider((object)val30, (object)Label.TextColorProperty));
		val93.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(32, 24)));
		BindingBase val94 = ((IMarkupExtension<BindingBase>)(object)val29).ProvideValue((IServiceProvider)val93);
		((BindableObject)val30).SetBinding(Label.TextColorProperty, val94);
		((Layout)val31).Children.Add((IView)(object)val30);
		((BindableObject)val32).SetValue(ContentView.ContentProperty, (object)val31);
		((Layout)val34).Children.Add((IView)(object)val32);
		((BindableObject)val33).SetValue(Button.TextProperty, (object)"Go Back");
		val33.Clicked += detailPage.OnGoBackClicked;
		((BindableObject)val33).SetValue(VisualElement.BackgroundColorProperty, (object)new Color(52f / 85f, 13f / 85f, 0.6901961f, 1f));
		((BindableObject)val33).SetValue(Button.TextColorProperty, (object)Colors.White);
		((BindableObject)val33).SetValue(View.HorizontalOptionsProperty, (object)LayoutOptions.Center);
		((BindableObject)val33).SetValue(Button.PaddingProperty, (object)new Thickness(30.0, 10.0));
		((Layout)val34).Children.Add((IView)(object)val33);
		((BindableObject)detailPage).SetValue(ContentPage.ContentProperty, (object)val34);
	}
}
