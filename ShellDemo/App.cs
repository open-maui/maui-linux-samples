using System;
using System.CodeDom.Compiler;
using System.Reflection;
using System.Xml;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Internals;
using Microsoft.Maui.Controls.Xaml;
using Microsoft.Maui.Controls.Xaml.Internals;
using Microsoft.Maui.Graphics;

namespace ShellDemo;

[XamlFilePath("App.xaml")]
public class App : Application
{
	public App()
	{
		InitializeComponent();
		((Application)this).MainPage = (Page)(object)new AppShell();
	}

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private void InitializeComponent()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected O, but got Unknown
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected O, but got Unknown
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected O, but got Unknown
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Expected O, but got Unknown
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected O, but got Unknown
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected O, but got Unknown
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Expected O, but got Unknown
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Expected O, but got Unknown
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Expected O, but got Unknown
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_0127: Expected O, but got Unknown
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Expected O, but got Unknown
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Expected O, but got Unknown
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_0178: Expected O, but got Unknown
		//IL_018c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0193: Expected O, but got Unknown
		//IL_01a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ae: Expected O, but got Unknown
		//IL_01c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c9: Expected O, but got Unknown
		//IL_01dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e4: Expected O, but got Unknown
		//IL_01f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ff: Expected O, but got Unknown
		//IL_0213: Unknown result type (might be due to invalid IL or missing references)
		//IL_021a: Expected O, but got Unknown
		//IL_022e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0235: Expected O, but got Unknown
		//IL_0235: Unknown result type (might be due to invalid IL or missing references)
		//IL_023c: Expected O, but got Unknown
		//IL_023c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0243: Expected O, but got Unknown
		//IL_0243: Unknown result type (might be due to invalid IL or missing references)
		//IL_024a: Expected O, but got Unknown
		//IL_024a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0251: Expected O, but got Unknown
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
		//IL_0293: Unknown result type (might be due to invalid IL or missing references)
		//IL_029a: Expected O, but got Unknown
		//IL_029a: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a1: Expected O, but got Unknown
		//IL_02a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a8: Expected O, but got Unknown
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
		//IL_02f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ff: Expected O, but got Unknown
		//IL_02ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0306: Expected O, but got Unknown
		//IL_0306: Unknown result type (might be due to invalid IL or missing references)
		//IL_030d: Expected O, but got Unknown
		//IL_030d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0314: Expected O, but got Unknown
		//IL_0314: Unknown result type (might be due to invalid IL or missing references)
		//IL_031b: Expected O, but got Unknown
		//IL_031b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0322: Expected O, but got Unknown
		//IL_0322: Unknown result type (might be due to invalid IL or missing references)
		//IL_0329: Expected O, but got Unknown
		//IL_0333: Unknown result type (might be due to invalid IL or missing references)
		//IL_033a: Expected O, but got Unknown
		//IL_033a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0341: Expected O, but got Unknown
		//IL_0341: Unknown result type (might be due to invalid IL or missing references)
		//IL_0348: Expected O, but got Unknown
		//IL_0348: Unknown result type (might be due to invalid IL or missing references)
		//IL_034f: Expected O, but got Unknown
		//IL_034f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0356: Expected O, but got Unknown
		//IL_0356: Unknown result type (might be due to invalid IL or missing references)
		//IL_035d: Expected O, but got Unknown
		//IL_0367: Unknown result type (might be due to invalid IL or missing references)
		//IL_036e: Expected O, but got Unknown
		//IL_036e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0375: Expected O, but got Unknown
		//IL_0375: Unknown result type (might be due to invalid IL or missing references)
		//IL_037c: Expected O, but got Unknown
		//IL_037c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0383: Expected O, but got Unknown
		//IL_0383: Unknown result type (might be due to invalid IL or missing references)
		//IL_038a: Expected O, but got Unknown
		//IL_038a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0391: Expected O, but got Unknown
		//IL_0391: Unknown result type (might be due to invalid IL or missing references)
		//IL_0398: Expected O, but got Unknown
		//IL_0398: Unknown result type (might be due to invalid IL or missing references)
		//IL_039f: Expected O, but got Unknown
		//IL_039f: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a6: Expected O, but got Unknown
		//IL_03b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b7: Expected O, but got Unknown
		//IL_03b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03be: Expected O, but got Unknown
		//IL_03be: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c5: Expected O, but got Unknown
		//IL_03c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03cc: Expected O, but got Unknown
		//IL_03cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d3: Expected O, but got Unknown
		//IL_03d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03da: Expected O, but got Unknown
		//IL_03da: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e1: Expected O, but got Unknown
		//IL_03eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f2: Expected O, but got Unknown
		//IL_03f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f9: Expected O, but got Unknown
		//IL_03f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0400: Expected O, but got Unknown
		//IL_0400: Unknown result type (might be due to invalid IL or missing references)
		//IL_0407: Expected O, but got Unknown
		//IL_0411: Unknown result type (might be due to invalid IL or missing references)
		//IL_0418: Expected O, but got Unknown
		//IL_0418: Unknown result type (might be due to invalid IL or missing references)
		//IL_041f: Expected O, but got Unknown
		//IL_041f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0426: Expected O, but got Unknown
		//IL_0426: Unknown result type (might be due to invalid IL or missing references)
		//IL_042d: Expected O, but got Unknown
		//IL_042d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0434: Expected O, but got Unknown
		//IL_0434: Unknown result type (might be due to invalid IL or missing references)
		//IL_043b: Expected O, but got Unknown
		//IL_0445: Unknown result type (might be due to invalid IL or missing references)
		//IL_044c: Expected O, but got Unknown
		//IL_044c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0453: Expected O, but got Unknown
		//IL_0470: Unknown result type (might be due to invalid IL or missing references)
		//IL_0477: Expected O, but got Unknown
		//IL_0477: Unknown result type (might be due to invalid IL or missing references)
		//IL_047e: Expected O, but got Unknown
		//IL_047e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0485: Expected O, but got Unknown
		//IL_0485: Unknown result type (might be due to invalid IL or missing references)
		//IL_048c: Expected O, but got Unknown
		//IL_048c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0493: Expected O, but got Unknown
		//IL_0493: Unknown result type (might be due to invalid IL or missing references)
		//IL_049a: Expected O, but got Unknown
		//IL_049a: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a1: Expected O, but got Unknown
		//IL_04a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a8: Expected O, but got Unknown
		//IL_04a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04af: Expected O, but got Unknown
		//IL_04af: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b6: Expected O, but got Unknown
		//IL_04b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04bd: Expected O, but got Unknown
		//IL_04bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c4: Expected O, but got Unknown
		//IL_04c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04cb: Expected O, but got Unknown
		//IL_04cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d2: Expected O, but got Unknown
		//IL_04d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d9: Expected O, but got Unknown
		//IL_04d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e0: Expected O, but got Unknown
		//IL_04e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e7: Expected O, but got Unknown
		//IL_04e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ee: Expected O, but got Unknown
		//IL_04ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f5: Expected O, but got Unknown
		//IL_0659: Unknown result type (might be due to invalid IL or missing references)
		//IL_065e: Unknown result type (might be due to invalid IL or missing references)
		//IL_067f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0689: Expected O, but got Unknown
		//IL_0689: Unknown result type (might be due to invalid IL or missing references)
		//IL_0698: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a2: Expected O, but got Unknown
		//IL_069d: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a7: Expected O, but got Unknown
		//IL_06ac: Expected O, but got Unknown
		//IL_06fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0702: Unknown result type (might be due to invalid IL or missing references)
		//IL_0723: Unknown result type (might be due to invalid IL or missing references)
		//IL_072d: Expected O, but got Unknown
		//IL_072d: Unknown result type (might be due to invalid IL or missing references)
		//IL_073c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0746: Expected O, but got Unknown
		//IL_0741: Unknown result type (might be due to invalid IL or missing references)
		//IL_074b: Expected O, but got Unknown
		//IL_0750: Expected O, but got Unknown
		//IL_07a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_07c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d1: Expected O, but got Unknown
		//IL_07d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ea: Expected O, but got Unknown
		//IL_07e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ef: Expected O, but got Unknown
		//IL_07f4: Expected O, but got Unknown
		//IL_0853: Unknown result type (might be due to invalid IL or missing references)
		//IL_0858: Unknown result type (might be due to invalid IL or missing references)
		//IL_0879: Unknown result type (might be due to invalid IL or missing references)
		//IL_0883: Expected O, but got Unknown
		//IL_0883: Unknown result type (might be due to invalid IL or missing references)
		//IL_0892: Unknown result type (might be due to invalid IL or missing references)
		//IL_089c: Expected O, but got Unknown
		//IL_0897: Unknown result type (might be due to invalid IL or missing references)
		//IL_08a1: Expected O, but got Unknown
		//IL_08a6: Expected O, but got Unknown
		//IL_08f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_08fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_091d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0927: Expected O, but got Unknown
		//IL_0927: Unknown result type (might be due to invalid IL or missing references)
		//IL_0936: Unknown result type (might be due to invalid IL or missing references)
		//IL_0940: Expected O, but got Unknown
		//IL_093b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0945: Expected O, but got Unknown
		//IL_094a: Expected O, but got Unknown
		//IL_099b: Unknown result type (might be due to invalid IL or missing references)
		//IL_09a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_09c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_09cb: Expected O, but got Unknown
		//IL_09cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_09da: Unknown result type (might be due to invalid IL or missing references)
		//IL_09e4: Expected O, but got Unknown
		//IL_09df: Unknown result type (might be due to invalid IL or missing references)
		//IL_09e9: Expected O, but got Unknown
		//IL_09ee: Expected O, but got Unknown
		//IL_0abb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ac0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ae1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aeb: Expected O, but got Unknown
		//IL_0aeb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0afa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b04: Expected O, but got Unknown
		//IL_0aff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b09: Expected O, but got Unknown
		//IL_0b0e: Expected O, but got Unknown
		//IL_0ba8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bad: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bce: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bd8: Expected O, but got Unknown
		//IL_0bd8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0be7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bf1: Expected O, but got Unknown
		//IL_0bec: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bf6: Expected O, but got Unknown
		//IL_0bfb: Expected O, but got Unknown
		//IL_0c5a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c5f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c80: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c8a: Expected O, but got Unknown
		//IL_0c8a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c99: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ca3: Expected O, but got Unknown
		//IL_0c9e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ca8: Expected O, but got Unknown
		//IL_0cad: Expected O, but got Unknown
		//IL_0cfe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d03: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d24: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d2e: Expected O, but got Unknown
		//IL_0d2e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d3d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d47: Expected O, but got Unknown
		//IL_0d42: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d4c: Expected O, but got Unknown
		//IL_0d51: Expected O, but got Unknown
		//IL_0ddf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0de4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e05: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e0f: Expected O, but got Unknown
		//IL_0e0f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e1e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e28: Expected O, but got Unknown
		//IL_0e23: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e2d: Expected O, but got Unknown
		//IL_0e32: Expected O, but got Unknown
		//IL_0eee: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ef3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f14: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f1e: Expected O, but got Unknown
		//IL_0f1e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f2d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f37: Expected O, but got Unknown
		//IL_0f32: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f3c: Expected O, but got Unknown
		//IL_0f41: Expected O, but got Unknown
		//IL_0f89: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f8e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0faf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fb9: Expected O, but got Unknown
		//IL_0fb9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fc8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fd2: Expected O, but got Unknown
		//IL_0fcd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fd7: Expected O, but got Unknown
		//IL_0fdc: Expected O, but got Unknown
		//IL_0460: Unknown result type (might be due to invalid IL or missing references)
		Color val = new Color(11f / 85f, 0.5882353f, 81f / 85f, 1f);
		Color val2 = new Color(5f / 51f, 0.4627451f, 0.8235294f, 1f);
		Color val3 = new Color(1f, 0.2509804f, 43f / 85f, 1f);
		Color val4 = new Color(50f / 51f, 50f / 51f, 50f / 51f, 1f);
		Color val5 = new Color(1f, 1f, 1f, 1f);
		Color val6 = new Color(11f / 85f, 11f / 85f, 11f / 85f, 1f);
		Color val7 = new Color(39f / 85f, 39f / 85f, 39f / 85f, 1f);
		Color val8 = new Color(0.8784314f, 0.8784314f, 0.8784314f, 1f);
		Color val9 = new Color(49f / 51f, 49f / 51f, 49f / 51f, 1f);
		Color val10 = new Color(1f, 1f, 1f, 1f);
		Color val11 = new Color(1f, 1f, 1f, 1f);
		Color val12 = new Color(0.8784314f, 0.8784314f, 0.8784314f, 1f);
		Color val13 = new Color(6f / 85f, 6f / 85f, 6f / 85f, 1f);
		Color val14 = new Color(0.11764706f, 0.11764706f, 0.11764706f, 1f);
		Color val15 = new Color(1f, 1f, 1f, 1f);
		Color val16 = new Color(0.6901961f, 0.6901961f, 0.6901961f, 1f);
		Color val17 = new Color(22f / 85f, 22f / 85f, 22f / 85f, 1f);
		Color val18 = new Color(0.17254902f, 0.17254902f, 0.17254902f, 1f);
		Color val19 = new Color(0.11764706f, 0.11764706f, 0.11764706f, 1f);
		Color val20 = new Color(0.11764706f, 0.11764706f, 0.11764706f, 1f);
		Color val21 = new Color(22f / 85f, 22f / 85f, 22f / 85f, 1f);
		StaticResourceExtension val22 = new StaticResourceExtension();
		StaticResourceExtension val23 = new StaticResourceExtension();
		AppThemeBindingExtension val24 = new AppThemeBindingExtension();
		Setter val25 = new Setter();
		StaticResourceExtension val26 = new StaticResourceExtension();
		StaticResourceExtension val27 = new StaticResourceExtension();
		AppThemeBindingExtension val28 = new AppThemeBindingExtension();
		Setter val29 = new Setter();
		StaticResourceExtension val30 = new StaticResourceExtension();
		StaticResourceExtension val31 = new StaticResourceExtension();
		AppThemeBindingExtension val32 = new AppThemeBindingExtension();
		Setter val33 = new Setter();
		Style val34 = new Style(typeof(Entry));
		StaticResourceExtension val35 = new StaticResourceExtension();
		StaticResourceExtension val36 = new StaticResourceExtension();
		AppThemeBindingExtension val37 = new AppThemeBindingExtension();
		Setter val38 = new Setter();
		StaticResourceExtension val39 = new StaticResourceExtension();
		StaticResourceExtension val40 = new StaticResourceExtension();
		AppThemeBindingExtension val41 = new AppThemeBindingExtension();
		Setter val42 = new Setter();
		StaticResourceExtension val43 = new StaticResourceExtension();
		StaticResourceExtension val44 = new StaticResourceExtension();
		AppThemeBindingExtension val45 = new AppThemeBindingExtension();
		Setter val46 = new Setter();
		Style val47 = new Style(typeof(Editor));
		Setter val48 = new Setter();
		Setter val49 = new Setter();
		StaticResourceExtension val50 = new StaticResourceExtension();
		StaticResourceExtension val51 = new StaticResourceExtension();
		AppThemeBindingExtension val52 = new AppThemeBindingExtension();
		Setter val53 = new Setter();
		Style val54 = new Style(typeof(Label));
		Setter val55 = new Setter();
		StaticResourceExtension val56 = new StaticResourceExtension();
		StaticResourceExtension val57 = new StaticResourceExtension();
		AppThemeBindingExtension val58 = new AppThemeBindingExtension();
		Setter val59 = new Setter();
		Style val60 = new Style(typeof(Label));
		StaticResourceExtension val61 = new StaticResourceExtension();
		StaticResourceExtension val62 = new StaticResourceExtension();
		AppThemeBindingExtension val63 = new AppThemeBindingExtension();
		Setter val64 = new Setter();
		StaticResourceExtension val65 = new StaticResourceExtension();
		StaticResourceExtension val66 = new StaticResourceExtension();
		AppThemeBindingExtension val67 = new AppThemeBindingExtension();
		Setter val68 = new Setter();
		Style val69 = new Style(typeof(Frame));
		StaticResourceExtension val70 = new StaticResourceExtension();
		Setter val71 = new Setter();
		StaticResourceExtension val72 = new StaticResourceExtension();
		StaticResourceExtension val73 = new StaticResourceExtension();
		AppThemeBindingExtension val74 = new AppThemeBindingExtension();
		Setter val75 = new Setter();
		Style val76 = new Style(typeof(ProgressBar));
		StaticResourceExtension val77 = new StaticResourceExtension();
		Setter val78 = new Setter();
		Setter val79 = new Setter();
		Style val80 = new Style(typeof(Button));
		AppThemeBindingExtension val81 = new AppThemeBindingExtension();
		Setter val82 = new Setter();
		StaticResourceExtension val83 = new StaticResourceExtension();
		AppThemeBindingExtension val84 = new AppThemeBindingExtension();
		Setter val85 = new Setter();
		Style val86 = new Style(typeof(Button));
		ResourceDictionary val87 = new ResourceDictionary();
		App app;
		NameScope val88 = (NameScope)(((object)NameScope.GetNameScope((BindableObject)(object)(app = this))) ?? ((object)new NameScope()));
		NameScope.SetNameScope((BindableObject)(object)app, (INameScope)(object)val88);
		NameScope val89 = new NameScope();
		NameScope val90 = new NameScope();
		NameScope val91 = new NameScope();
		NameScope val92 = new NameScope();
		NameScope val93 = new NameScope();
		NameScope val94 = new NameScope();
		NameScope val95 = new NameScope();
		NameScope val96 = new NameScope();
		NameScope val97 = new NameScope();
		NameScope val98 = new NameScope();
		NameScope val99 = new NameScope();
		NameScope val100 = new NameScope();
		NameScope val101 = new NameScope();
		NameScope val102 = new NameScope();
		NameScope val103 = new NameScope();
		NameScope val104 = new NameScope();
		NameScope val105 = new NameScope();
		NameScope val106 = new NameScope();
		NameScope val107 = new NameScope();
		((Application)app).Resources = val87;
		val87.Add("PrimaryColor", (object)val);
		val87.Add("PrimaryDarkColor", (object)val2);
		val87.Add("AccentColor", (object)val3);
		val87.Add("PageBackgroundLight", (object)val4);
		val87.Add("CardBackgroundLight", (object)val5);
		val87.Add("TextPrimaryLight", (object)val6);
		val87.Add("TextSecondaryLight", (object)val7);
		val87.Add("BorderLight", (object)val8);
		val87.Add("EntryBackgroundLight", (object)val9);
		val87.Add("ShellBackgroundLight", (object)val10);
		val87.Add("FlyoutBackgroundLight", (object)val11);
		val87.Add("ProgressTrackLight", (object)val12);
		val87.Add("PageBackgroundDark", (object)val13);
		val87.Add("CardBackgroundDark", (object)val14);
		val87.Add("TextPrimaryDark", (object)val15);
		val87.Add("TextSecondaryDark", (object)val16);
		val87.Add("BorderDark", (object)val17);
		val87.Add("EntryBackgroundDark", (object)val18);
		val87.Add("ShellBackgroundDark", (object)val19);
		val87.Add("FlyoutBackgroundDark", (object)val20);
		val87.Add("ProgressTrackDark", (object)val21);
		val25.Property = VisualElement.BackgroundColorProperty;
		val22.Key = "EntryBackgroundLight";
		val24.Light = val9;
		val23.Key = "EntryBackgroundDark";
		val24.Dark = val18;
		XamlServiceProvider val108 = new XamlServiceProvider();
		val108.Add(typeof(IProvideValueTarget), (object)new ValueTargetProvider((object)val25, (object)typeof(Setter).GetRuntimeProperty("Value")));
		val108.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(36, 52)));
		BindingBase value = ((IMarkupExtension<BindingBase>)(object)val24).ProvideValue((IServiceProvider)val108);
		val25.Value = value;
		val34.Setters.Add(val25);
		val29.Property = Entry.TextColorProperty;
		val26.Key = "TextPrimaryLight";
		val28.Light = val6;
		val27.Key = "TextPrimaryDark";
		val28.Dark = val15;
		XamlServiceProvider val109 = new XamlServiceProvider();
		val109.Add(typeof(IProvideValueTarget), (object)new ValueTargetProvider((object)val29, (object)typeof(Setter).GetRuntimeProperty("Value")));
		val109.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(37, 46)));
		BindingBase value2 = ((IMarkupExtension<BindingBase>)(object)val28).ProvideValue((IServiceProvider)val109);
		val29.Value = value2;
		val34.Setters.Add(val29);
		val33.Property = Entry.PlaceholderColorProperty;
		val30.Key = "TextSecondaryLight";
		val32.Light = val7;
		val31.Key = "TextSecondaryDark";
		val32.Dark = val16;
		XamlServiceProvider val110 = new XamlServiceProvider();
		val110.Add(typeof(IProvideValueTarget), (object)new ValueTargetProvider((object)val33, (object)typeof(Setter).GetRuntimeProperty("Value")));
		val110.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(38, 53)));
		BindingBase value3 = ((IMarkupExtension<BindingBase>)(object)val32).ProvideValue((IServiceProvider)val110);
		val33.Value = value3;
		val34.Setters.Add(val33);
		val87.Add("ThemedEntry", (object)val34);
		val38.Property = VisualElement.BackgroundColorProperty;
		val35.Key = "EntryBackgroundLight";
		val37.Light = val9;
		val36.Key = "EntryBackgroundDark";
		val37.Dark = val18;
		XamlServiceProvider val111 = new XamlServiceProvider();
		val111.Add(typeof(IProvideValueTarget), (object)new ValueTargetProvider((object)val38, (object)typeof(Setter).GetRuntimeProperty("Value")));
		val111.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(43, 52)));
		BindingBase value4 = ((IMarkupExtension<BindingBase>)(object)val37).ProvideValue((IServiceProvider)val111);
		val38.Value = value4;
		val47.Setters.Add(val38);
		val42.Property = Editor.TextColorProperty;
		val39.Key = "TextPrimaryLight";
		val41.Light = val6;
		val40.Key = "TextPrimaryDark";
		val41.Dark = val15;
		XamlServiceProvider val112 = new XamlServiceProvider();
		val112.Add(typeof(IProvideValueTarget), (object)new ValueTargetProvider((object)val42, (object)typeof(Setter).GetRuntimeProperty("Value")));
		val112.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(44, 46)));
		BindingBase value5 = ((IMarkupExtension<BindingBase>)(object)val41).ProvideValue((IServiceProvider)val112);
		val42.Value = value5;
		val47.Setters.Add(val42);
		val46.Property = Editor.PlaceholderColorProperty;
		val43.Key = "TextSecondaryLight";
		val45.Light = val7;
		val44.Key = "TextSecondaryDark";
		val45.Dark = val16;
		XamlServiceProvider val113 = new XamlServiceProvider();
		val113.Add(typeof(IProvideValueTarget), (object)new ValueTargetProvider((object)val46, (object)typeof(Setter).GetRuntimeProperty("Value")));
		val113.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(45, 53)));
		BindingBase value6 = ((IMarkupExtension<BindingBase>)(object)val45).ProvideValue((IServiceProvider)val113);
		val46.Value = value6;
		val47.Setters.Add(val46);
		val87.Add("ThemedEditor", (object)val47);
		val48.Property = Label.FontSizeProperty;
		val48.Value = "24";
		val48.Value = 24.0;
		val54.Setters.Add(val48);
		val49.Property = Label.FontAttributesProperty;
		val49.Value = "Bold";
		val49.Value = (object)(FontAttributes)1;
		val54.Setters.Add(val49);
		val53.Property = Label.TextColorProperty;
		val50.Key = "TextPrimaryLight";
		val52.Light = val6;
		val51.Key = "TextPrimaryDark";
		val52.Dark = val15;
		XamlServiceProvider val114 = new XamlServiceProvider();
		val114.Add(typeof(IProvideValueTarget), (object)new ValueTargetProvider((object)val53, (object)typeof(Setter).GetRuntimeProperty("Value")));
		val114.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(52, 46)));
		BindingBase value7 = ((IMarkupExtension<BindingBase>)(object)val52).ProvideValue((IServiceProvider)val114);
		val53.Value = value7;
		val54.Setters.Add(val53);
		val87.Add("TitleLabel", (object)val54);
		val55.Property = Label.FontSizeProperty;
		val55.Value = "16";
		val55.Value = 16.0;
		val60.Setters.Add(val55);
		val59.Property = Label.TextColorProperty;
		val56.Key = "TextSecondaryLight";
		val58.Light = val7;
		val57.Key = "TextSecondaryDark";
		val58.Dark = val16;
		XamlServiceProvider val115 = new XamlServiceProvider();
		val115.Add(typeof(IProvideValueTarget), (object)new ValueTargetProvider((object)val59, (object)typeof(Setter).GetRuntimeProperty("Value")));
		val115.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(57, 46)));
		BindingBase value8 = ((IMarkupExtension<BindingBase>)(object)val58).ProvideValue((IServiceProvider)val115);
		val59.Value = value8;
		val60.Setters.Add(val59);
		val87.Add("SubtitleLabel", (object)val60);
		val64.Property = VisualElement.BackgroundColorProperty;
		val61.Key = "CardBackgroundLight";
		val63.Light = val5;
		val62.Key = "CardBackgroundDark";
		val63.Dark = val14;
		XamlServiceProvider val116 = new XamlServiceProvider();
		val116.Add(typeof(IProvideValueTarget), (object)new ValueTargetProvider((object)val64, (object)typeof(Setter).GetRuntimeProperty("Value")));
		val116.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(62, 52)));
		BindingBase value9 = ((IMarkupExtension<BindingBase>)(object)val63).ProvideValue((IServiceProvider)val116);
		val64.Value = value9;
		val69.Setters.Add(val64);
		val68.Property = Frame.BorderColorProperty;
		val65.Key = "BorderLight";
		val67.Light = val8;
		val66.Key = "BorderDark";
		val67.Dark = val17;
		XamlServiceProvider val117 = new XamlServiceProvider();
		val117.Add(typeof(IProvideValueTarget), (object)new ValueTargetProvider((object)val68, (object)typeof(Setter).GetRuntimeProperty("Value")));
		val117.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(63, 48)));
		BindingBase value10 = ((IMarkupExtension<BindingBase>)(object)val67).ProvideValue((IServiceProvider)val117);
		val68.Value = value10;
		val69.Setters.Add(val68);
		val87.Add("ThemedFrame", (object)val69);
		val71.Property = ProgressBar.ProgressColorProperty;
		val70.Key = "PrimaryColor";
		val71.Value = val;
		val76.Setters.Add(val71);
		val75.Property = VisualElement.BackgroundColorProperty;
		val72.Key = "ProgressTrackLight";
		val74.Light = val12;
		val73.Key = "ProgressTrackDark";
		val74.Dark = val21;
		XamlServiceProvider val118 = new XamlServiceProvider();
		val118.Add(typeof(IProvideValueTarget), (object)new ValueTargetProvider((object)val75, (object)typeof(Setter).GetRuntimeProperty("Value")));
		val118.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(69, 52)));
		BindingBase value11 = ((IMarkupExtension<BindingBase>)(object)val74).ProvideValue((IServiceProvider)val118);
		val75.Value = value11;
		val76.Setters.Add(val75);
		val87.Add("ThemedProgressBar", (object)val76);
		val78.Property = VisualElement.BackgroundColorProperty;
		val77.Key = "PrimaryColor";
		val78.Value = val;
		val80.Setters.Add(val78);
		val79.Property = Button.TextColorProperty;
		val79.Value = "White";
		val79.Value = Colors.White;
		val80.Setters.Add(val79);
		val87.Add("PrimaryButton", (object)val80);
		val82.Property = VisualElement.BackgroundColorProperty;
		val81.Light = "#E3F2FD";
		val81.Dark = "#1565C0";
		XamlServiceProvider val119 = new XamlServiceProvider();
		val119.Add(typeof(IProvideValueTarget), (object)new ValueTargetProvider((object)val82, (object)typeof(Setter).GetRuntimeProperty("Value")));
		val119.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(79, 52)));
		BindingBase value12 = ((IMarkupExtension<BindingBase>)(object)val81).ProvideValue((IServiceProvider)val119);
		val82.Value = value12;
		val86.Setters.Add(val82);
		val85.Property = Button.TextColorProperty;
		val83.Key = "PrimaryColor";
		val84.Light = val;
		val84.Dark = "White";
		XamlServiceProvider val120 = new XamlServiceProvider();
		val120.Add(typeof(IProvideValueTarget), (object)new ValueTargetProvider((object)val85, (object)typeof(Setter).GetRuntimeProperty("Value")));
		val120.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(80, 46)));
		BindingBase value13 = ((IMarkupExtension<BindingBase>)(object)val84).ProvideValue((IServiceProvider)val120);
		val85.Value = value13;
		val86.Setters.Add(val85);
		val87.Add("SecondaryButton", (object)val86);
		((Application)app).Resources = val87;
	}
}
