using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Reflection;
using System.Xml;
using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Compatibility;
using Microsoft.Maui.Controls.Internals;
using Microsoft.Maui.Controls.Xaml;
using Microsoft.Maui.Controls.Xaml.Internals;
using Microsoft.Maui.Converters;
using Microsoft.Maui.Graphics;

namespace ShellDemo;

[XamlFilePath("Pages/GridsPage.xaml")]
public class GridsPage : ContentPage
{
	public GridsPage()
	{
		InitializeComponent();
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
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Expected O, but got Unknown
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Expected O, but got Unknown
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Expected O, but got Unknown
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Expected O, but got Unknown
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Expected O, but got Unknown
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Expected O, but got Unknown
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Expected O, but got Unknown
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Expected O, but got Unknown
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Expected O, but got Unknown
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Expected O, but got Unknown
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Expected O, but got Unknown
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Expected O, but got Unknown
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0146: Expected O, but got Unknown
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_014d: Expected O, but got Unknown
		//IL_014d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0154: Expected O, but got Unknown
		//IL_0154: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Expected O, but got Unknown
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0162: Expected O, but got Unknown
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		//IL_0169: Expected O, but got Unknown
		//IL_0169: Unknown result type (might be due to invalid IL or missing references)
		//IL_0170: Expected O, but got Unknown
		//IL_0170: Unknown result type (might be due to invalid IL or missing references)
		//IL_0177: Expected O, but got Unknown
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Expected O, but got Unknown
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
		//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a8: Expected O, but got Unknown
		//IL_01a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01af: Expected O, but got Unknown
		//IL_01af: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b6: Expected O, but got Unknown
		//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bd: Expected O, but got Unknown
		//IL_01bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c4: Expected O, but got Unknown
		//IL_01c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cb: Expected O, but got Unknown
		//IL_01cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d2: Expected O, but got Unknown
		//IL_01d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d9: Expected O, but got Unknown
		//IL_01d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e0: Expected O, but got Unknown
		//IL_01e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e7: Expected O, but got Unknown
		//IL_01e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ee: Expected O, but got Unknown
		//IL_01ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f5: Expected O, but got Unknown
		//IL_01f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fc: Expected O, but got Unknown
		//IL_01fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0203: Expected O, but got Unknown
		//IL_0203: Unknown result type (might be due to invalid IL or missing references)
		//IL_020a: Expected O, but got Unknown
		//IL_020a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0211: Expected O, but got Unknown
		//IL_0211: Unknown result type (might be due to invalid IL or missing references)
		//IL_0218: Expected O, but got Unknown
		//IL_0218: Unknown result type (might be due to invalid IL or missing references)
		//IL_021f: Expected O, but got Unknown
		//IL_021f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0226: Expected O, but got Unknown
		//IL_0226: Unknown result type (might be due to invalid IL or missing references)
		//IL_022d: Expected O, but got Unknown
		//IL_022d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0234: Expected O, but got Unknown
		//IL_0234: Unknown result type (might be due to invalid IL or missing references)
		//IL_023b: Expected O, but got Unknown
		//IL_023b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0242: Expected O, but got Unknown
		//IL_0242: Unknown result type (might be due to invalid IL or missing references)
		//IL_0249: Expected O, but got Unknown
		//IL_0249: Unknown result type (might be due to invalid IL or missing references)
		//IL_0250: Expected O, but got Unknown
		//IL_0250: Unknown result type (might be due to invalid IL or missing references)
		//IL_0257: Expected O, but got Unknown
		//IL_0257: Unknown result type (might be due to invalid IL or missing references)
		//IL_025e: Expected O, but got Unknown
		//IL_025e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0265: Expected O, but got Unknown
		//IL_0265: Unknown result type (might be due to invalid IL or missing references)
		//IL_026c: Expected O, but got Unknown
		//IL_0470: Unknown result type (might be due to invalid IL or missing references)
		//IL_0475: Unknown result type (might be due to invalid IL or missing references)
		//IL_0480: Unknown result type (might be due to invalid IL or missing references)
		//IL_0485: Unknown result type (might be due to invalid IL or missing references)
		//IL_04cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d3: Expected O, but got Unknown
		//IL_04d8: Expected O, but got Unknown
		//IL_04d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0502: Expected O, but got Unknown
		//IL_04fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0507: Expected O, but got Unknown
		//IL_050c: Expected O, but got Unknown
		//IL_0521: Unknown result type (might be due to invalid IL or missing references)
		//IL_0526: Unknown result type (might be due to invalid IL or missing references)
		//IL_0531: Unknown result type (might be due to invalid IL or missing references)
		//IL_0536: Unknown result type (might be due to invalid IL or missing references)
		//IL_057c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0581: Unknown result type (might be due to invalid IL or missing references)
		//IL_0584: Expected O, but got Unknown
		//IL_0589: Expected O, but got Unknown
		//IL_0589: Unknown result type (might be due to invalid IL or missing references)
		//IL_059b: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b3: Expected O, but got Unknown
		//IL_05ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b8: Expected O, but got Unknown
		//IL_05bd: Expected O, but got Unknown
		//IL_05c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_05cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_05df: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e9: Expected O, but got Unknown
		//IL_05e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0601: Expected O, but got Unknown
		//IL_05fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0606: Expected O, but got Unknown
		//IL_060b: Expected O, but got Unknown
		//IL_062b: Unknown result type (might be due to invalid IL or missing references)
		//IL_069c: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0716: Unknown result type (might be due to invalid IL or missing references)
		//IL_071b: Unknown result type (might be due to invalid IL or missing references)
		//IL_071e: Expected O, but got Unknown
		//IL_0723: Expected O, but got Unknown
		//IL_0723: Unknown result type (might be due to invalid IL or missing references)
		//IL_0735: Unknown result type (might be due to invalid IL or missing references)
		//IL_0744: Unknown result type (might be due to invalid IL or missing references)
		//IL_074e: Expected O, but got Unknown
		//IL_0749: Unknown result type (might be due to invalid IL or missing references)
		//IL_0753: Expected O, but got Unknown
		//IL_0758: Expected O, but got Unknown
		//IL_076f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0774: Unknown result type (might be due to invalid IL or missing references)
		//IL_077f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0784: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f1: Expected O, but got Unknown
		//IL_07f6: Expected O, but got Unknown
		//IL_07f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0808: Unknown result type (might be due to invalid IL or missing references)
		//IL_0817: Unknown result type (might be due to invalid IL or missing references)
		//IL_0821: Expected O, but got Unknown
		//IL_081c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0826: Expected O, but got Unknown
		//IL_082b: Expected O, but got Unknown
		//IL_0838: Unknown result type (might be due to invalid IL or missing references)
		//IL_083d: Unknown result type (might be due to invalid IL or missing references)
		//IL_084f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0859: Expected O, but got Unknown
		//IL_0859: Unknown result type (might be due to invalid IL or missing references)
		//IL_0868: Unknown result type (might be due to invalid IL or missing references)
		//IL_0872: Expected O, but got Unknown
		//IL_086d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0877: Expected O, but got Unknown
		//IL_087c: Expected O, but got Unknown
		//IL_08a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_08bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0907: Unknown result type (might be due to invalid IL or missing references)
		//IL_090c: Unknown result type (might be due to invalid IL or missing references)
		//IL_090f: Expected O, but got Unknown
		//IL_0914: Expected O, but got Unknown
		//IL_0914: Unknown result type (might be due to invalid IL or missing references)
		//IL_0926: Unknown result type (might be due to invalid IL or missing references)
		//IL_0935: Unknown result type (might be due to invalid IL or missing references)
		//IL_093f: Expected O, but got Unknown
		//IL_093a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0944: Expected O, but got Unknown
		//IL_0949: Expected O, but got Unknown
		//IL_0279: Unknown result type (might be due to invalid IL or missing references)
		//IL_09a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a13: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a18: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a23: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a28: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aa1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aa6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aa9: Expected O, but got Unknown
		//IL_0aae: Expected O, but got Unknown
		//IL_0aae: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ac0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0acf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ad9: Expected O, but got Unknown
		//IL_0ad4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ade: Expected O, but got Unknown
		//IL_0ae3: Expected O, but got Unknown
		//IL_0afa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b0a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b0f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b88: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b8d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b90: Expected O, but got Unknown
		//IL_0b95: Expected O, but got Unknown
		//IL_0b95: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ba7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bb6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bc0: Expected O, but got Unknown
		//IL_0bbb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bc5: Expected O, but got Unknown
		//IL_0bca: Expected O, but got Unknown
		//IL_0bd7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bdc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bee: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bf8: Expected O, but got Unknown
		//IL_0bf8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c07: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c11: Expected O, but got Unknown
		//IL_0c0c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c16: Expected O, but got Unknown
		//IL_0c1b: Expected O, but got Unknown
		//IL_0c48: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c4d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c53: Expected O, but got Unknown
		//IL_0c55: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c5a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c60: Expected O, but got Unknown
		//IL_0c60: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c6a: Expected O, but got Unknown
		//IL_0c82: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c87: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c8d: Expected O, but got Unknown
		//IL_0c98: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c9d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ca3: Expected O, but got Unknown
		//IL_0ca3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cad: Expected O, but got Unknown
		//IL_0cfc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d06: Expected O, but got Unknown
		//IL_0d45: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d5b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0db3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dbd: Expected O, but got Unknown
		//IL_0dfc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e12: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e6a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e74: Expected O, but got Unknown
		//IL_0eb3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ec9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f33: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f3d: Expected O, but got Unknown
		//IL_0f7c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f92: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ff3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ff8: Unknown result type (might be due to invalid IL or missing references)
		//IL_1003: Unknown result type (might be due to invalid IL or missing references)
		//IL_1008: Unknown result type (might be due to invalid IL or missing references)
		//IL_1054: Unknown result type (might be due to invalid IL or missing references)
		//IL_1059: Unknown result type (might be due to invalid IL or missing references)
		//IL_105c: Expected O, but got Unknown
		//IL_1061: Expected O, but got Unknown
		//IL_1061: Unknown result type (might be due to invalid IL or missing references)
		//IL_1073: Unknown result type (might be due to invalid IL or missing references)
		//IL_1082: Unknown result type (might be due to invalid IL or missing references)
		//IL_108c: Expected O, but got Unknown
		//IL_1087: Unknown result type (might be due to invalid IL or missing references)
		//IL_1091: Expected O, but got Unknown
		//IL_1096: Expected O, but got Unknown
		//IL_10ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_1160: Unknown result type (might be due to invalid IL or missing references)
		//IL_1165: Unknown result type (might be due to invalid IL or missing references)
		//IL_1170: Unknown result type (might be due to invalid IL or missing references)
		//IL_1175: Unknown result type (might be due to invalid IL or missing references)
		//IL_11ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_11f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_11f6: Expected O, but got Unknown
		//IL_11fb: Expected O, but got Unknown
		//IL_11fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_120d: Unknown result type (might be due to invalid IL or missing references)
		//IL_121c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1226: Expected O, but got Unknown
		//IL_1221: Unknown result type (might be due to invalid IL or missing references)
		//IL_122b: Expected O, but got Unknown
		//IL_1230: Expected O, but got Unknown
		//IL_1247: Unknown result type (might be due to invalid IL or missing references)
		//IL_124c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1257: Unknown result type (might be due to invalid IL or missing references)
		//IL_125c: Unknown result type (might be due to invalid IL or missing references)
		//IL_12d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_12da: Unknown result type (might be due to invalid IL or missing references)
		//IL_12dd: Expected O, but got Unknown
		//IL_12e2: Expected O, but got Unknown
		//IL_12e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_12f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_1303: Unknown result type (might be due to invalid IL or missing references)
		//IL_130d: Expected O, but got Unknown
		//IL_1308: Unknown result type (might be due to invalid IL or missing references)
		//IL_1312: Expected O, but got Unknown
		//IL_1317: Expected O, but got Unknown
		//IL_1324: Unknown result type (might be due to invalid IL or missing references)
		//IL_1329: Unknown result type (might be due to invalid IL or missing references)
		//IL_133b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1345: Expected O, but got Unknown
		//IL_1345: Unknown result type (might be due to invalid IL or missing references)
		//IL_1354: Unknown result type (might be due to invalid IL or missing references)
		//IL_135e: Expected O, but got Unknown
		//IL_1359: Unknown result type (might be due to invalid IL or missing references)
		//IL_1363: Expected O, but got Unknown
		//IL_1368: Expected O, but got Unknown
		//IL_1395: Unknown result type (might be due to invalid IL or missing references)
		//IL_139a: Unknown result type (might be due to invalid IL or missing references)
		//IL_13a0: Expected O, but got Unknown
		//IL_13a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_13a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_13ad: Expected O, but got Unknown
		//IL_13af: Unknown result type (might be due to invalid IL or missing references)
		//IL_13b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_13ba: Expected O, but got Unknown
		//IL_13ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_13c4: Expected O, but got Unknown
		//IL_13dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_13e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_13e7: Expected O, but got Unknown
		//IL_13f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_13f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_13fd: Expected O, but got Unknown
		//IL_1408: Unknown result type (might be due to invalid IL or missing references)
		//IL_140d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1413: Expected O, but got Unknown
		//IL_1413: Unknown result type (might be due to invalid IL or missing references)
		//IL_141d: Expected O, but got Unknown
		//IL_146c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1476: Expected O, but got Unknown
		//IL_14c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_14dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_1523: Unknown result type (might be due to invalid IL or missing references)
		//IL_152d: Expected O, but got Unknown
		//IL_1590: Unknown result type (might be due to invalid IL or missing references)
		//IL_15a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_15ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_15f6: Expected O, but got Unknown
		//IL_1647: Unknown result type (might be due to invalid IL or missing references)
		//IL_165d: Unknown result type (might be due to invalid IL or missing references)
		//IL_16a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_16ad: Expected O, but got Unknown
		//IL_1710: Unknown result type (might be due to invalid IL or missing references)
		//IL_1726: Unknown result type (might be due to invalid IL or missing references)
		//IL_176c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1776: Expected O, but got Unknown
		//IL_17d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_17ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_1850: Unknown result type (might be due to invalid IL or missing references)
		//IL_1855: Unknown result type (might be due to invalid IL or missing references)
		//IL_1860: Unknown result type (might be due to invalid IL or missing references)
		//IL_1865: Unknown result type (might be due to invalid IL or missing references)
		//IL_18b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_18b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_18b9: Expected O, but got Unknown
		//IL_18be: Expected O, but got Unknown
		//IL_18be: Unknown result type (might be due to invalid IL or missing references)
		//IL_18d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_18df: Unknown result type (might be due to invalid IL or missing references)
		//IL_18e9: Expected O, but got Unknown
		//IL_18e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_18ee: Expected O, but got Unknown
		//IL_18f3: Expected O, but got Unknown
		//IL_194b: Unknown result type (might be due to invalid IL or missing references)
		//IL_19bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_19c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_19cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_19d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a4b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a50: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a53: Expected O, but got Unknown
		//IL_1a58: Expected O, but got Unknown
		//IL_1a58: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a6a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a79: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a83: Expected O, but got Unknown
		//IL_1a7e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a88: Expected O, but got Unknown
		//IL_1a8d: Expected O, but got Unknown
		//IL_1aa4: Unknown result type (might be due to invalid IL or missing references)
		//IL_1aa9: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ab4: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ab9: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b32: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b37: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b3a: Expected O, but got Unknown
		//IL_1b3f: Expected O, but got Unknown
		//IL_1b3f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b51: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b60: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b6a: Expected O, but got Unknown
		//IL_1b65: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b6f: Expected O, but got Unknown
		//IL_1b74: Expected O, but got Unknown
		//IL_1b81: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b86: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b98: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ba2: Expected O, but got Unknown
		//IL_1ba2: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bb1: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bbb: Expected O, but got Unknown
		//IL_1bb6: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bc0: Expected O, but got Unknown
		//IL_1bc5: Expected O, but got Unknown
		//IL_1bf2: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bf7: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bfd: Expected O, but got Unknown
		//IL_1bff: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c04: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c0a: Expected O, but got Unknown
		//IL_1c16: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c1b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c21: Expected O, but got Unknown
		//IL_1c21: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c2b: Expected O, but got Unknown
		//IL_1c43: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c48: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c4e: Expected O, but got Unknown
		//IL_1c4e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c58: Expected O, but got Unknown
		//IL_1c8d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c97: Expected O, but got Unknown
		//IL_1cbd: Unknown result type (might be due to invalid IL or missing references)
		//IL_1cf5: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d4d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d57: Expected O, but got Unknown
		//IL_1d96: Unknown result type (might be due to invalid IL or missing references)
		//IL_1dac: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e04: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e0e: Expected O, but got Unknown
		//IL_1e4d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e63: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ed3: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ed8: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ee3: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ee8: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f61: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f66: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f69: Expected O, but got Unknown
		//IL_1f6e: Expected O, but got Unknown
		//IL_1f6e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f80: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f8f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f99: Expected O, but got Unknown
		//IL_1f94: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f9e: Expected O, but got Unknown
		//IL_1fa3: Expected O, but got Unknown
		//IL_1fba: Unknown result type (might be due to invalid IL or missing references)
		//IL_1fbf: Unknown result type (might be due to invalid IL or missing references)
		//IL_1fca: Unknown result type (might be due to invalid IL or missing references)
		//IL_1fcf: Unknown result type (might be due to invalid IL or missing references)
		//IL_2048: Unknown result type (might be due to invalid IL or missing references)
		//IL_204d: Unknown result type (might be due to invalid IL or missing references)
		//IL_2050: Expected O, but got Unknown
		//IL_2055: Expected O, but got Unknown
		//IL_2055: Unknown result type (might be due to invalid IL or missing references)
		//IL_2067: Unknown result type (might be due to invalid IL or missing references)
		//IL_2076: Unknown result type (might be due to invalid IL or missing references)
		//IL_2080: Expected O, but got Unknown
		//IL_207b: Unknown result type (might be due to invalid IL or missing references)
		//IL_2085: Expected O, but got Unknown
		//IL_208a: Expected O, but got Unknown
		//IL_2097: Unknown result type (might be due to invalid IL or missing references)
		//IL_209c: Unknown result type (might be due to invalid IL or missing references)
		//IL_20ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_20b8: Expected O, but got Unknown
		//IL_20b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_20c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_20d1: Expected O, but got Unknown
		//IL_20cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_20d6: Expected O, but got Unknown
		//IL_20db: Expected O, but got Unknown
		//IL_2121: Unknown result type (might be due to invalid IL or missing references)
		//IL_2126: Unknown result type (might be due to invalid IL or missing references)
		//IL_2131: Unknown result type (might be due to invalid IL or missing references)
		//IL_2136: Unknown result type (might be due to invalid IL or missing references)
		//IL_2182: Unknown result type (might be due to invalid IL or missing references)
		//IL_2187: Unknown result type (might be due to invalid IL or missing references)
		//IL_218a: Expected O, but got Unknown
		//IL_218f: Expected O, but got Unknown
		//IL_218f: Unknown result type (might be due to invalid IL or missing references)
		//IL_21a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_21b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_21ba: Expected O, but got Unknown
		//IL_21b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_21bf: Expected O, but got Unknown
		//IL_21c4: Expected O, but got Unknown
		//IL_221c: Unknown result type (might be due to invalid IL or missing references)
		//IL_228e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2293: Unknown result type (might be due to invalid IL or missing references)
		//IL_229e: Unknown result type (might be due to invalid IL or missing references)
		//IL_22a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_231c: Unknown result type (might be due to invalid IL or missing references)
		//IL_2321: Unknown result type (might be due to invalid IL or missing references)
		//IL_2324: Expected O, but got Unknown
		//IL_2329: Expected O, but got Unknown
		//IL_2329: Unknown result type (might be due to invalid IL or missing references)
		//IL_233b: Unknown result type (might be due to invalid IL or missing references)
		//IL_234a: Unknown result type (might be due to invalid IL or missing references)
		//IL_2354: Expected O, but got Unknown
		//IL_234f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2359: Expected O, but got Unknown
		//IL_235e: Expected O, but got Unknown
		//IL_2375: Unknown result type (might be due to invalid IL or missing references)
		//IL_237a: Unknown result type (might be due to invalid IL or missing references)
		//IL_2385: Unknown result type (might be due to invalid IL or missing references)
		//IL_238a: Unknown result type (might be due to invalid IL or missing references)
		//IL_2403: Unknown result type (might be due to invalid IL or missing references)
		//IL_2408: Unknown result type (might be due to invalid IL or missing references)
		//IL_240b: Expected O, but got Unknown
		//IL_2410: Expected O, but got Unknown
		//IL_2410: Unknown result type (might be due to invalid IL or missing references)
		//IL_2422: Unknown result type (might be due to invalid IL or missing references)
		//IL_2431: Unknown result type (might be due to invalid IL or missing references)
		//IL_243b: Expected O, but got Unknown
		//IL_2436: Unknown result type (might be due to invalid IL or missing references)
		//IL_2440: Expected O, but got Unknown
		//IL_2445: Expected O, but got Unknown
		//IL_2452: Unknown result type (might be due to invalid IL or missing references)
		//IL_2457: Unknown result type (might be due to invalid IL or missing references)
		//IL_2469: Unknown result type (might be due to invalid IL or missing references)
		//IL_2473: Expected O, but got Unknown
		//IL_2473: Unknown result type (might be due to invalid IL or missing references)
		//IL_2482: Unknown result type (might be due to invalid IL or missing references)
		//IL_248c: Expected O, but got Unknown
		//IL_2487: Unknown result type (might be due to invalid IL or missing references)
		//IL_2491: Expected O, but got Unknown
		//IL_2496: Expected O, but got Unknown
		//IL_24c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_24c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_24ce: Expected O, but got Unknown
		//IL_24d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_24d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_24db: Expected O, but got Unknown
		//IL_24db: Unknown result type (might be due to invalid IL or missing references)
		//IL_24e5: Expected O, but got Unknown
		//IL_24f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_24f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_24ff: Expected O, but got Unknown
		//IL_2501: Unknown result type (might be due to invalid IL or missing references)
		//IL_2506: Unknown result type (might be due to invalid IL or missing references)
		//IL_250c: Expected O, but got Unknown
		//IL_250e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2513: Unknown result type (might be due to invalid IL or missing references)
		//IL_2519: Expected O, but got Unknown
		//IL_251b: Unknown result type (might be due to invalid IL or missing references)
		//IL_2520: Unknown result type (might be due to invalid IL or missing references)
		//IL_2526: Expected O, but got Unknown
		//IL_2526: Unknown result type (might be due to invalid IL or missing references)
		//IL_2530: Expected O, but got Unknown
		//IL_257c: Unknown result type (might be due to invalid IL or missing references)
		//IL_2597: Unknown result type (might be due to invalid IL or missing references)
		//IL_259c: Unknown result type (might be due to invalid IL or missing references)
		//IL_25a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_25ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_2630: Unknown result type (might be due to invalid IL or missing references)
		//IL_2635: Unknown result type (might be due to invalid IL or missing references)
		//IL_2638: Expected O, but got Unknown
		//IL_263d: Expected O, but got Unknown
		//IL_263d: Unknown result type (might be due to invalid IL or missing references)
		//IL_264f: Unknown result type (might be due to invalid IL or missing references)
		//IL_265e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2668: Expected O, but got Unknown
		//IL_2663: Unknown result type (might be due to invalid IL or missing references)
		//IL_266d: Expected O, but got Unknown
		//IL_2672: Expected O, but got Unknown
		//IL_2689: Unknown result type (might be due to invalid IL or missing references)
		//IL_268e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2699: Unknown result type (might be due to invalid IL or missing references)
		//IL_269e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2722: Unknown result type (might be due to invalid IL or missing references)
		//IL_2727: Unknown result type (might be due to invalid IL or missing references)
		//IL_272a: Expected O, but got Unknown
		//IL_272f: Expected O, but got Unknown
		//IL_272f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2741: Unknown result type (might be due to invalid IL or missing references)
		//IL_2750: Unknown result type (might be due to invalid IL or missing references)
		//IL_275a: Expected O, but got Unknown
		//IL_2755: Unknown result type (might be due to invalid IL or missing references)
		//IL_275f: Expected O, but got Unknown
		//IL_2764: Expected O, but got Unknown
		//IL_2771: Unknown result type (might be due to invalid IL or missing references)
		//IL_2776: Unknown result type (might be due to invalid IL or missing references)
		//IL_2788: Unknown result type (might be due to invalid IL or missing references)
		//IL_2792: Expected O, but got Unknown
		//IL_2792: Unknown result type (might be due to invalid IL or missing references)
		//IL_27a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_27ab: Expected O, but got Unknown
		//IL_27a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_27b0: Expected O, but got Unknown
		//IL_27b5: Expected O, but got Unknown
		//IL_2802: Unknown result type (might be due to invalid IL or missing references)
		//IL_2807: Unknown result type (might be due to invalid IL or missing references)
		//IL_2812: Unknown result type (might be due to invalid IL or missing references)
		//IL_2817: Unknown result type (might be due to invalid IL or missing references)
		//IL_2881: Unknown result type (might be due to invalid IL or missing references)
		//IL_2886: Unknown result type (might be due to invalid IL or missing references)
		//IL_2889: Expected O, but got Unknown
		//IL_288e: Expected O, but got Unknown
		//IL_288e: Unknown result type (might be due to invalid IL or missing references)
		//IL_28a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_28af: Unknown result type (might be due to invalid IL or missing references)
		//IL_28b9: Expected O, but got Unknown
		//IL_28b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_28be: Expected O, but got Unknown
		//IL_28c3: Expected O, but got Unknown
		//IL_292d: Unknown result type (might be due to invalid IL or missing references)
		//IL_2948: Unknown result type (might be due to invalid IL or missing references)
		//IL_294d: Unknown result type (might be due to invalid IL or missing references)
		//IL_2958: Unknown result type (might be due to invalid IL or missing references)
		//IL_295d: Unknown result type (might be due to invalid IL or missing references)
		//IL_29e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_29e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_29e9: Expected O, but got Unknown
		//IL_29ee: Expected O, but got Unknown
		//IL_29ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a00: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a0f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a19: Expected O, but got Unknown
		//IL_2a14: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a1e: Expected O, but got Unknown
		//IL_2a23: Expected O, but got Unknown
		//IL_2a3a: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a3f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a4a: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a4f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ad3: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ad8: Unknown result type (might be due to invalid IL or missing references)
		//IL_2adb: Expected O, but got Unknown
		//IL_2ae0: Expected O, but got Unknown
		//IL_2ae0: Unknown result type (might be due to invalid IL or missing references)
		//IL_2af2: Unknown result type (might be due to invalid IL or missing references)
		//IL_2b01: Unknown result type (might be due to invalid IL or missing references)
		//IL_2b0b: Expected O, but got Unknown
		//IL_2b06: Unknown result type (might be due to invalid IL or missing references)
		//IL_2b10: Expected O, but got Unknown
		//IL_2b15: Expected O, but got Unknown
		//IL_2b22: Unknown result type (might be due to invalid IL or missing references)
		//IL_2b27: Unknown result type (might be due to invalid IL or missing references)
		//IL_2b39: Unknown result type (might be due to invalid IL or missing references)
		//IL_2b43: Expected O, but got Unknown
		//IL_2b43: Unknown result type (might be due to invalid IL or missing references)
		//IL_2b52: Unknown result type (might be due to invalid IL or missing references)
		//IL_2b5c: Expected O, but got Unknown
		//IL_2b57: Unknown result type (might be due to invalid IL or missing references)
		//IL_2b61: Expected O, but got Unknown
		//IL_2b66: Expected O, but got Unknown
		//IL_2bc0: Unknown result type (might be due to invalid IL or missing references)
		//IL_2bcf: Expected O, but got Unknown
		//IL_2be0: Unknown result type (might be due to invalid IL or missing references)
		//IL_2be5: Unknown result type (might be due to invalid IL or missing references)
		//IL_2bf0: Unknown result type (might be due to invalid IL or missing references)
		//IL_2bf5: Unknown result type (might be due to invalid IL or missing references)
		//IL_2c5f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2c64: Unknown result type (might be due to invalid IL or missing references)
		//IL_2c67: Expected O, but got Unknown
		//IL_2c6c: Expected O, but got Unknown
		//IL_2c6c: Unknown result type (might be due to invalid IL or missing references)
		//IL_2c7e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2c8d: Unknown result type (might be due to invalid IL or missing references)
		//IL_2c97: Expected O, but got Unknown
		//IL_2c92: Unknown result type (might be due to invalid IL or missing references)
		//IL_2c9c: Expected O, but got Unknown
		//IL_2ca1: Expected O, but got Unknown
		//IL_2d0b: Unknown result type (might be due to invalid IL or missing references)
		//IL_2d26: Unknown result type (might be due to invalid IL or missing references)
		//IL_2d2b: Unknown result type (might be due to invalid IL or missing references)
		//IL_2d36: Unknown result type (might be due to invalid IL or missing references)
		//IL_2d3b: Unknown result type (might be due to invalid IL or missing references)
		//IL_2dbf: Unknown result type (might be due to invalid IL or missing references)
		//IL_2dc4: Unknown result type (might be due to invalid IL or missing references)
		//IL_2dc7: Expected O, but got Unknown
		//IL_2dcc: Expected O, but got Unknown
		//IL_2dcc: Unknown result type (might be due to invalid IL or missing references)
		//IL_2dde: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ded: Unknown result type (might be due to invalid IL or missing references)
		//IL_2df7: Expected O, but got Unknown
		//IL_2df2: Unknown result type (might be due to invalid IL or missing references)
		//IL_2dfc: Expected O, but got Unknown
		//IL_2e01: Expected O, but got Unknown
		//IL_2e18: Unknown result type (might be due to invalid IL or missing references)
		//IL_2e1d: Unknown result type (might be due to invalid IL or missing references)
		//IL_2e28: Unknown result type (might be due to invalid IL or missing references)
		//IL_2e2d: Unknown result type (might be due to invalid IL or missing references)
		//IL_2eb1: Unknown result type (might be due to invalid IL or missing references)
		//IL_2eb6: Unknown result type (might be due to invalid IL or missing references)
		//IL_2eb9: Expected O, but got Unknown
		//IL_2ebe: Expected O, but got Unknown
		//IL_2ebe: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ed0: Unknown result type (might be due to invalid IL or missing references)
		//IL_2edf: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ee9: Expected O, but got Unknown
		//IL_2ee4: Unknown result type (might be due to invalid IL or missing references)
		//IL_2eee: Expected O, but got Unknown
		//IL_2ef3: Expected O, but got Unknown
		//IL_2f00: Unknown result type (might be due to invalid IL or missing references)
		//IL_2f05: Unknown result type (might be due to invalid IL or missing references)
		//IL_2f17: Unknown result type (might be due to invalid IL or missing references)
		//IL_2f21: Expected O, but got Unknown
		//IL_2f21: Unknown result type (might be due to invalid IL or missing references)
		//IL_2f30: Unknown result type (might be due to invalid IL or missing references)
		//IL_2f3a: Expected O, but got Unknown
		//IL_2f35: Unknown result type (might be due to invalid IL or missing references)
		//IL_2f3f: Expected O, but got Unknown
		//IL_2f44: Expected O, but got Unknown
		//IL_2f9e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2fad: Expected O, but got Unknown
		//IL_2fbe: Unknown result type (might be due to invalid IL or missing references)
		//IL_2fc3: Unknown result type (might be due to invalid IL or missing references)
		//IL_2fce: Unknown result type (might be due to invalid IL or missing references)
		//IL_2fd3: Unknown result type (might be due to invalid IL or missing references)
		//IL_303d: Unknown result type (might be due to invalid IL or missing references)
		//IL_3042: Unknown result type (might be due to invalid IL or missing references)
		//IL_3045: Expected O, but got Unknown
		//IL_304a: Expected O, but got Unknown
		//IL_304a: Unknown result type (might be due to invalid IL or missing references)
		//IL_305c: Unknown result type (might be due to invalid IL or missing references)
		//IL_306b: Unknown result type (might be due to invalid IL or missing references)
		//IL_3075: Expected O, but got Unknown
		//IL_3070: Unknown result type (might be due to invalid IL or missing references)
		//IL_307a: Expected O, but got Unknown
		//IL_307f: Expected O, but got Unknown
		//IL_3100: Unknown result type (might be due to invalid IL or missing references)
		//IL_3105: Unknown result type (might be due to invalid IL or missing references)
		//IL_3110: Unknown result type (might be due to invalid IL or missing references)
		//IL_3115: Unknown result type (might be due to invalid IL or missing references)
		//IL_317f: Unknown result type (might be due to invalid IL or missing references)
		//IL_3184: Unknown result type (might be due to invalid IL or missing references)
		//IL_3187: Expected O, but got Unknown
		//IL_318c: Expected O, but got Unknown
		//IL_318c: Unknown result type (might be due to invalid IL or missing references)
		//IL_319e: Unknown result type (might be due to invalid IL or missing references)
		//IL_31ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_31b7: Expected O, but got Unknown
		//IL_31b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_31bc: Expected O, but got Unknown
		//IL_31c1: Expected O, but got Unknown
		StaticResourceExtension val = new StaticResourceExtension();
		StaticResourceExtension val2 = new StaticResourceExtension();
		AppThemeBindingExtension val3 = new AppThemeBindingExtension();
		StaticResourceExtension val4 = new StaticResourceExtension();
		StaticResourceExtension val5 = new StaticResourceExtension();
		AppThemeBindingExtension val6 = new AppThemeBindingExtension();
		Label val7 = new Label();
		StaticResourceExtension val8 = new StaticResourceExtension();
		StaticResourceExtension val9 = new StaticResourceExtension();
		StaticResourceExtension val10 = new StaticResourceExtension();
		AppThemeBindingExtension val11 = new AppThemeBindingExtension();
		Label val12 = new Label();
		Label val13 = new Label();
		Frame val14 = new Frame();
		Label val15 = new Label();
		Frame val16 = new Frame();
		Label val17 = new Label();
		Frame val18 = new Frame();
		Label val19 = new Label();
		Frame val20 = new Frame();
		Grid val21 = new Grid();
		VerticalStackLayout val22 = new VerticalStackLayout();
		Frame val23 = new Frame();
		StaticResourceExtension val24 = new StaticResourceExtension();
		StaticResourceExtension val25 = new StaticResourceExtension();
		StaticResourceExtension val26 = new StaticResourceExtension();
		AppThemeBindingExtension val27 = new AppThemeBindingExtension();
		Label val28 = new Label();
		Label val29 = new Label();
		Frame val30 = new Frame();
		Label val31 = new Label();
		Frame val32 = new Frame();
		Label val33 = new Label();
		Frame val34 = new Frame();
		Label val35 = new Label();
		Frame val36 = new Frame();
		Label val37 = new Label();
		Frame val38 = new Frame();
		Grid val39 = new Grid();
		VerticalStackLayout val40 = new VerticalStackLayout();
		Frame val41 = new Frame();
		StaticResourceExtension val42 = new StaticResourceExtension();
		StaticResourceExtension val43 = new StaticResourceExtension();
		StaticResourceExtension val44 = new StaticResourceExtension();
		AppThemeBindingExtension val45 = new AppThemeBindingExtension();
		Label val46 = new Label();
		Label val47 = new Label();
		Frame val48 = new Frame();
		Label val49 = new Label();
		Frame val50 = new Frame();
		Label val51 = new Label();
		Frame val52 = new Frame();
		Grid val53 = new Grid();
		StaticResourceExtension val54 = new StaticResourceExtension();
		StaticResourceExtension val55 = new StaticResourceExtension();
		AppThemeBindingExtension val56 = new AppThemeBindingExtension();
		Label val57 = new Label();
		VerticalStackLayout val58 = new VerticalStackLayout();
		Frame val59 = new Frame();
		StaticResourceExtension val60 = new StaticResourceExtension();
		StaticResourceExtension val61 = new StaticResourceExtension();
		StaticResourceExtension val62 = new StaticResourceExtension();
		AppThemeBindingExtension val63 = new AppThemeBindingExtension();
		Label val64 = new Label();
		StaticResourceExtension val65 = new StaticResourceExtension();
		StaticResourceExtension val66 = new StaticResourceExtension();
		AppThemeBindingExtension val67 = new AppThemeBindingExtension();
		Label val68 = new Label();
		StaticResourceExtension val69 = new StaticResourceExtension();
		Entry val70 = new Entry();
		StaticResourceExtension val71 = new StaticResourceExtension();
		StaticResourceExtension val72 = new StaticResourceExtension();
		AppThemeBindingExtension val73 = new AppThemeBindingExtension();
		Label val74 = new Label();
		StaticResourceExtension val75 = new StaticResourceExtension();
		Entry val76 = new Entry();
		StaticResourceExtension val77 = new StaticResourceExtension();
		StaticResourceExtension val78 = new StaticResourceExtension();
		AppThemeBindingExtension val79 = new AppThemeBindingExtension();
		Label val80 = new Label();
		StaticResourceExtension val81 = new StaticResourceExtension();
		Entry val82 = new Entry();
		StaticResourceExtension val83 = new StaticResourceExtension();
		Button val84 = new Button();
		Grid val85 = new Grid();
		VerticalStackLayout val86 = new VerticalStackLayout();
		Frame val87 = new Frame();
		VerticalStackLayout val88 = new VerticalStackLayout();
		ScrollView val89 = new ScrollView();
		GridsPage gridsPage;
		NameScope val90 = (NameScope)(((object)NameScope.GetNameScope((BindableObject)(object)(gridsPage = this))) ?? ((object)new NameScope()));
		NameScope.SetNameScope((BindableObject)(object)gridsPage, (INameScope)(object)val90);
		((Element)val89).transientNamescope = (INameScope)(object)val90;
		((Element)val88).transientNamescope = (INameScope)(object)val90;
		((Element)val7).transientNamescope = (INameScope)(object)val90;
		((Element)val23).transientNamescope = (INameScope)(object)val90;
		((Element)val22).transientNamescope = (INameScope)(object)val90;
		((Element)val12).transientNamescope = (INameScope)(object)val90;
		((Element)val21).transientNamescope = (INameScope)(object)val90;
		((Element)val14).transientNamescope = (INameScope)(object)val90;
		((Element)val13).transientNamescope = (INameScope)(object)val90;
		((Element)val16).transientNamescope = (INameScope)(object)val90;
		((Element)val15).transientNamescope = (INameScope)(object)val90;
		((Element)val18).transientNamescope = (INameScope)(object)val90;
		((Element)val17).transientNamescope = (INameScope)(object)val90;
		((Element)val20).transientNamescope = (INameScope)(object)val90;
		((Element)val19).transientNamescope = (INameScope)(object)val90;
		((Element)val41).transientNamescope = (INameScope)(object)val90;
		((Element)val40).transientNamescope = (INameScope)(object)val90;
		((Element)val28).transientNamescope = (INameScope)(object)val90;
		((Element)val39).transientNamescope = (INameScope)(object)val90;
		((Element)val30).transientNamescope = (INameScope)(object)val90;
		((Element)val29).transientNamescope = (INameScope)(object)val90;
		((Element)val32).transientNamescope = (INameScope)(object)val90;
		((Element)val31).transientNamescope = (INameScope)(object)val90;
		((Element)val34).transientNamescope = (INameScope)(object)val90;
		((Element)val33).transientNamescope = (INameScope)(object)val90;
		((Element)val36).transientNamescope = (INameScope)(object)val90;
		((Element)val35).transientNamescope = (INameScope)(object)val90;
		((Element)val38).transientNamescope = (INameScope)(object)val90;
		((Element)val37).transientNamescope = (INameScope)(object)val90;
		((Element)val59).transientNamescope = (INameScope)(object)val90;
		((Element)val58).transientNamescope = (INameScope)(object)val90;
		((Element)val46).transientNamescope = (INameScope)(object)val90;
		((Element)val53).transientNamescope = (INameScope)(object)val90;
		((Element)val48).transientNamescope = (INameScope)(object)val90;
		((Element)val47).transientNamescope = (INameScope)(object)val90;
		((Element)val50).transientNamescope = (INameScope)(object)val90;
		((Element)val49).transientNamescope = (INameScope)(object)val90;
		((Element)val52).transientNamescope = (INameScope)(object)val90;
		((Element)val51).transientNamescope = (INameScope)(object)val90;
		((Element)val57).transientNamescope = (INameScope)(object)val90;
		((Element)val87).transientNamescope = (INameScope)(object)val90;
		((Element)val86).transientNamescope = (INameScope)(object)val90;
		((Element)val64).transientNamescope = (INameScope)(object)val90;
		((Element)val85).transientNamescope = (INameScope)(object)val90;
		((Element)val68).transientNamescope = (INameScope)(object)val90;
		((Element)val70).transientNamescope = (INameScope)(object)val90;
		((Element)val74).transientNamescope = (INameScope)(object)val90;
		((Element)val76).transientNamescope = (INameScope)(object)val90;
		((Element)val80).transientNamescope = (INameScope)(object)val90;
		((Element)val82).transientNamescope = (INameScope)(object)val90;
		((Element)val84).transientNamescope = (INameScope)(object)val90;
		((BindableObject)gridsPage).SetValue(Page.TitleProperty, (object)"Grids");
		val.Key = "PageBackgroundLight";
		StaticResourceExtension val91 = new StaticResourceExtension
		{
			Key = "PageBackgroundLight"
		};
		XamlServiceProvider val92 = new XamlServiceProvider();
		Type? typeFromHandle = typeof(IProvideValueTarget);
		object[] array = new object[0 + 2];
		array[0] = val3;
		array[1] = gridsPage;
		SimpleValueTargetProvider val93 = new SimpleValueTargetProvider(array, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Light"), (INameScope[])(object)new NameScope[3] { val90, val90, val90 }, false);
		object obj = (object)val93;
		val92.Add(typeFromHandle, (object)val93);
		val92.Add(typeof(IReferenceProvider), obj);
		val92.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(6, 14)));
		object light = val91.ProvideValue((IServiceProvider)val92);
		val3.Light = light;
		val2.Key = "PageBackgroundDark";
		StaticResourceExtension val94 = new StaticResourceExtension
		{
			Key = "PageBackgroundDark"
		};
		XamlServiceProvider val95 = new XamlServiceProvider();
		Type? typeFromHandle2 = typeof(IProvideValueTarget);
		object[] array2 = new object[0 + 2];
		array2[0] = val3;
		array2[1] = gridsPage;
		SimpleValueTargetProvider val96 = new SimpleValueTargetProvider(array2, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Dark"), (INameScope[])(object)new NameScope[3] { val90, val90, val90 }, false);
		object obj2 = (object)val96;
		val95.Add(typeFromHandle2, (object)val96);
		val95.Add(typeof(IReferenceProvider), obj2);
		val95.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(6, 14)));
		object dark = val94.ProvideValue((IServiceProvider)val95);
		val3.Dark = dark;
		XamlServiceProvider val97 = new XamlServiceProvider();
		val97.Add(typeof(IProvideValueTarget), (object)new ValueTargetProvider((object)gridsPage, (object)VisualElement.BackgroundColorProperty));
		val97.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(6, 14)));
		BindingBase val98 = ((IMarkupExtension<BindingBase>)(object)val3).ProvideValue((IServiceProvider)val97);
		((BindableObject)gridsPage).SetBinding(VisualElement.BackgroundColorProperty, val98);
		((BindableObject)val88).SetValue(Layout.PaddingProperty, (object)new Thickness(20.0));
		((BindableObject)val88).SetValue(StackBase.SpacingProperty, (object)20.0);
		((BindableObject)val7).SetValue(Label.TextProperty, (object)"Grid Layouts");
		((BindableObject)val7).SetValue(Label.FontSizeProperty, (object)24.0);
		((BindableObject)val7).SetValue(Label.FontAttributesProperty, (object)(FontAttributes)1);
		val4.Key = "TextPrimaryLight";
		StaticResourceExtension val99 = new StaticResourceExtension
		{
			Key = "TextPrimaryLight"
		};
		XamlServiceProvider val100 = new XamlServiceProvider();
		Type? typeFromHandle3 = typeof(IProvideValueTarget);
		object[] array3 = new object[0 + 5];
		array3[0] = val6;
		array3[1] = val7;
		array3[2] = val88;
		array3[3] = val89;
		array3[4] = gridsPage;
		SimpleValueTargetProvider val101 = new SimpleValueTargetProvider(array3, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Light"), (INameScope[])(object)new NameScope[6] { val90, val90, val90, val90, val90, val90 }, false);
		object obj3 = (object)val101;
		val100.Add(typeFromHandle3, (object)val101);
		val100.Add(typeof(IReferenceProvider), obj3);
		val100.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(11, 20)));
		object light2 = val99.ProvideValue((IServiceProvider)val100);
		val6.Light = light2;
		val5.Key = "TextPrimaryDark";
		StaticResourceExtension val102 = new StaticResourceExtension
		{
			Key = "TextPrimaryDark"
		};
		XamlServiceProvider val103 = new XamlServiceProvider();
		Type? typeFromHandle4 = typeof(IProvideValueTarget);
		object[] array4 = new object[0 + 5];
		array4[0] = val6;
		array4[1] = val7;
		array4[2] = val88;
		array4[3] = val89;
		array4[4] = gridsPage;
		SimpleValueTargetProvider val104 = new SimpleValueTargetProvider(array4, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Dark"), (INameScope[])(object)new NameScope[6] { val90, val90, val90, val90, val90, val90 }, false);
		object obj4 = (object)val104;
		val103.Add(typeFromHandle4, (object)val104);
		val103.Add(typeof(IReferenceProvider), obj4);
		val103.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(11, 20)));
		object dark2 = val102.ProvideValue((IServiceProvider)val103);
		val6.Dark = dark2;
		XamlServiceProvider val105 = new XamlServiceProvider();
		val105.Add(typeof(IProvideValueTarget), (object)new ValueTargetProvider((object)val7, (object)Label.TextColorProperty));
		val105.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(11, 20)));
		BindingBase val106 = ((IMarkupExtension<BindingBase>)(object)val6).ProvideValue((IServiceProvider)val105);
		((BindableObject)val7).SetBinding(Label.TextColorProperty, val106);
		((Layout)val88).Children.Add((IView)(object)val7);
		val8.Key = "ThemedFrame";
		StaticResourceExtension val107 = new StaticResourceExtension
		{
			Key = "ThemedFrame"
		};
		XamlServiceProvider val108 = new XamlServiceProvider();
		Type? typeFromHandle5 = typeof(IProvideValueTarget);
		object[] array5 = new object[0 + 4];
		array5[0] = val23;
		array5[1] = val88;
		array5[2] = val89;
		array5[3] = gridsPage;
		SimpleValueTargetProvider val109 = new SimpleValueTargetProvider(array5, (object)VisualElement.StyleProperty, (INameScope[])(object)new NameScope[5] { val90, val90, val90, val90, val90 }, false);
		object obj5 = (object)val109;
		val108.Add(typeFromHandle5, (object)val109);
		val108.Add(typeof(IReferenceProvider), obj5);
		val108.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(14, 20)));
		object obj6 = val107.ProvideValue((IServiceProvider)val108);
		((BindableObject)val23).SetValue(VisualElement.StyleProperty, (obj6 == null || !typeof(BindingBase).IsAssignableFrom(obj6.GetType())) ? obj6 : obj6);
		((BindableObject)val23).SetValue(Frame.CornerRadiusProperty, (object)8f);
		((BindableObject)val23).SetValue(Layout.PaddingProperty, (object)new Thickness(15.0));
		((BindableObject)val22).SetValue(StackBase.SpacingProperty, (object)10.0);
		((BindableObject)val12).SetValue(Label.TextProperty, (object)"Simple 2x2 Grid");
		((BindableObject)val12).SetValue(Label.FontSizeProperty, (object)18.0);
		((BindableObject)val12).SetValue(Label.FontAttributesProperty, (object)(FontAttributes)1);
		val9.Key = "TextPrimaryLight";
		StaticResourceExtension val110 = new StaticResourceExtension
		{
			Key = "TextPrimaryLight"
		};
		XamlServiceProvider val111 = new XamlServiceProvider();
		Type? typeFromHandle6 = typeof(IProvideValueTarget);
		object[] array6 = new object[0 + 7];
		array6[0] = val11;
		array6[1] = val12;
		array6[2] = val22;
		array6[3] = val23;
		array6[4] = val88;
		array6[5] = val89;
		array6[6] = gridsPage;
		SimpleValueTargetProvider val112 = new SimpleValueTargetProvider(array6, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Light"), (INameScope[])(object)new NameScope[8] { val90, val90, val90, val90, val90, val90, val90, val90 }, false);
		object obj7 = (object)val112;
		val111.Add(typeFromHandle6, (object)val112);
		val111.Add(typeof(IReferenceProvider), obj7);
		val111.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(17, 28)));
		object light3 = val110.ProvideValue((IServiceProvider)val111);
		val11.Light = light3;
		val10.Key = "TextPrimaryDark";
		StaticResourceExtension val113 = new StaticResourceExtension
		{
			Key = "TextPrimaryDark"
		};
		XamlServiceProvider val114 = new XamlServiceProvider();
		Type? typeFromHandle7 = typeof(IProvideValueTarget);
		object[] array7 = new object[0 + 7];
		array7[0] = val11;
		array7[1] = val12;
		array7[2] = val22;
		array7[3] = val23;
		array7[4] = val88;
		array7[5] = val89;
		array7[6] = gridsPage;
		SimpleValueTargetProvider val115 = new SimpleValueTargetProvider(array7, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Dark"), (INameScope[])(object)new NameScope[8] { val90, val90, val90, val90, val90, val90, val90, val90 }, false);
		object obj8 = (object)val115;
		val114.Add(typeFromHandle7, (object)val115);
		val114.Add(typeof(IReferenceProvider), obj8);
		val114.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(17, 28)));
		object dark3 = val113.ProvideValue((IServiceProvider)val114);
		val11.Dark = dark3;
		XamlServiceProvider val116 = new XamlServiceProvider();
		val116.Add(typeof(IProvideValueTarget), (object)new ValueTargetProvider((object)val12, (object)Label.TextColorProperty));
		val116.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(17, 28)));
		BindingBase val117 = ((IMarkupExtension<BindingBase>)(object)val11).ProvideValue((IServiceProvider)val116);
		((BindableObject)val12).SetBinding(Label.TextColorProperty, val117);
		((Layout)val22).Children.Add((IView)(object)val12);
		((BindableObject)val21).SetValue(Grid.ColumnDefinitionsProperty, (object)new ColumnDefinitionCollection((ColumnDefinition[])(object)new ColumnDefinition[2]
		{
			new ColumnDefinition(GridLength.Star),
			new ColumnDefinition(GridLength.Star)
		}));
		((BindableObject)val21).SetValue(Grid.RowDefinitionsProperty, (object)new RowDefinitionCollection((RowDefinition[])(object)new RowDefinition[2]
		{
			new RowDefinition(new GridLength(60.0)),
			new RowDefinition(new GridLength(60.0))
		}));
		((BindableObject)val21).SetValue(Grid.ColumnSpacingProperty, (object)10.0);
		((BindableObject)val21).SetValue(Grid.RowSpacingProperty, (object)10.0);
		((BindableObject)val14).SetValue(VisualElement.BackgroundColorProperty, (object)new Color(11f / 85f, 0.5882353f, 81f / 85f, 1f));
		((BindableObject)val14).SetValue(Frame.CornerRadiusProperty, (object)8f);
		((BindableObject)val13).SetValue(Label.TextProperty, (object)"Cell 1");
		((BindableObject)val13).SetValue(Label.TextColorProperty, (object)Colors.White);
		((BindableObject)val13).SetValue(View.HorizontalOptionsProperty, (object)LayoutOptions.Center);
		((BindableObject)val13).SetValue(View.VerticalOptionsProperty, (object)LayoutOptions.Center);
		((BindableObject)val14).SetValue(ContentView.ContentProperty, (object)val13);
		((Layout)val21).Children.Add((IView)(object)val14);
		((BindableObject)val16).SetValue(Grid.ColumnProperty, (object)1);
		((BindableObject)val16).SetValue(VisualElement.BackgroundColorProperty, (object)new Color(0.29803923f, 35f / 51f, 16f / 51f, 1f));
		((BindableObject)val16).SetValue(Frame.CornerRadiusProperty, (object)8f);
		((BindableObject)val15).SetValue(Label.TextProperty, (object)"Cell 2");
		((BindableObject)val15).SetValue(Label.TextColorProperty, (object)Colors.White);
		((BindableObject)val15).SetValue(View.HorizontalOptionsProperty, (object)LayoutOptions.Center);
		((BindableObject)val15).SetValue(View.VerticalOptionsProperty, (object)LayoutOptions.Center);
		((BindableObject)val16).SetValue(ContentView.ContentProperty, (object)val15);
		((Layout)val21).Children.Add((IView)(object)val16);
		((BindableObject)val18).SetValue(Grid.RowProperty, (object)1);
		((BindableObject)val18).SetValue(VisualElement.BackgroundColorProperty, (object)new Color(1f, 0.59607846f, 0f, 1f));
		((BindableObject)val18).SetValue(Frame.CornerRadiusProperty, (object)8f);
		((BindableObject)val17).SetValue(Label.TextProperty, (object)"Cell 3");
		((BindableObject)val17).SetValue(Label.TextColorProperty, (object)Colors.White);
		((BindableObject)val17).SetValue(View.HorizontalOptionsProperty, (object)LayoutOptions.Center);
		((BindableObject)val17).SetValue(View.VerticalOptionsProperty, (object)LayoutOptions.Center);
		((BindableObject)val18).SetValue(ContentView.ContentProperty, (object)val17);
		((Layout)val21).Children.Add((IView)(object)val18);
		((BindableObject)val20).SetValue(Grid.RowProperty, (object)1);
		((BindableObject)val20).SetValue(Grid.ColumnProperty, (object)1);
		((BindableObject)val20).SetValue(VisualElement.BackgroundColorProperty, (object)new Color(52f / 85f, 13f / 85f, 0.6901961f, 1f));
		((BindableObject)val20).SetValue(Frame.CornerRadiusProperty, (object)8f);
		((BindableObject)val19).SetValue(Label.TextProperty, (object)"Cell 4");
		((BindableObject)val19).SetValue(Label.TextColorProperty, (object)Colors.White);
		((BindableObject)val19).SetValue(View.HorizontalOptionsProperty, (object)LayoutOptions.Center);
		((BindableObject)val19).SetValue(View.VerticalOptionsProperty, (object)LayoutOptions.Center);
		((BindableObject)val20).SetValue(ContentView.ContentProperty, (object)val19);
		((Layout)val21).Children.Add((IView)(object)val20);
		((Layout)val22).Children.Add((IView)(object)val21);
		((BindableObject)val23).SetValue(ContentView.ContentProperty, (object)val22);
		((Layout)val88).Children.Add((IView)(object)val23);
		val24.Key = "ThemedFrame";
		StaticResourceExtension val118 = new StaticResourceExtension
		{
			Key = "ThemedFrame"
		};
		XamlServiceProvider val119 = new XamlServiceProvider();
		Type? typeFromHandle8 = typeof(IProvideValueTarget);
		object[] array8 = new object[0 + 4];
		array8[0] = val41;
		array8[1] = val88;
		array8[2] = val89;
		array8[3] = gridsPage;
		SimpleValueTargetProvider val120 = new SimpleValueTargetProvider(array8, (object)VisualElement.StyleProperty, (INameScope[])(object)new NameScope[5] { val90, val90, val90, val90, val90 }, false);
		object obj9 = (object)val120;
		val119.Add(typeFromHandle8, (object)val120);
		val119.Add(typeof(IReferenceProvider), obj9);
		val119.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(36, 20)));
		object obj10 = val118.ProvideValue((IServiceProvider)val119);
		((BindableObject)val41).SetValue(VisualElement.StyleProperty, (obj10 == null || !typeof(BindingBase).IsAssignableFrom(obj10.GetType())) ? obj10 : obj10);
		((BindableObject)val41).SetValue(Frame.CornerRadiusProperty, (object)8f);
		((BindableObject)val41).SetValue(Layout.PaddingProperty, (object)new Thickness(15.0));
		((BindableObject)val40).SetValue(StackBase.SpacingProperty, (object)10.0);
		((BindableObject)val28).SetValue(Label.TextProperty, (object)"Column & Row Spanning");
		((BindableObject)val28).SetValue(Label.FontSizeProperty, (object)18.0);
		((BindableObject)val28).SetValue(Label.FontAttributesProperty, (object)(FontAttributes)1);
		val25.Key = "TextPrimaryLight";
		StaticResourceExtension val121 = new StaticResourceExtension
		{
			Key = "TextPrimaryLight"
		};
		XamlServiceProvider val122 = new XamlServiceProvider();
		Type? typeFromHandle9 = typeof(IProvideValueTarget);
		object[] array9 = new object[0 + 7];
		array9[0] = val27;
		array9[1] = val28;
		array9[2] = val40;
		array9[3] = val41;
		array9[4] = val88;
		array9[5] = val89;
		array9[6] = gridsPage;
		SimpleValueTargetProvider val123 = new SimpleValueTargetProvider(array9, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Light"), (INameScope[])(object)new NameScope[8] { val90, val90, val90, val90, val90, val90, val90, val90 }, false);
		object obj11 = (object)val123;
		val122.Add(typeFromHandle9, (object)val123);
		val122.Add(typeof(IReferenceProvider), obj11);
		val122.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(39, 28)));
		object light4 = val121.ProvideValue((IServiceProvider)val122);
		val27.Light = light4;
		val26.Key = "TextPrimaryDark";
		StaticResourceExtension val124 = new StaticResourceExtension
		{
			Key = "TextPrimaryDark"
		};
		XamlServiceProvider val125 = new XamlServiceProvider();
		Type? typeFromHandle10 = typeof(IProvideValueTarget);
		object[] array10 = new object[0 + 7];
		array10[0] = val27;
		array10[1] = val28;
		array10[2] = val40;
		array10[3] = val41;
		array10[4] = val88;
		array10[5] = val89;
		array10[6] = gridsPage;
		SimpleValueTargetProvider val126 = new SimpleValueTargetProvider(array10, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Dark"), (INameScope[])(object)new NameScope[8] { val90, val90, val90, val90, val90, val90, val90, val90 }, false);
		object obj12 = (object)val126;
		val125.Add(typeFromHandle10, (object)val126);
		val125.Add(typeof(IReferenceProvider), obj12);
		val125.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(39, 28)));
		object dark4 = val124.ProvideValue((IServiceProvider)val125);
		val27.Dark = dark4;
		XamlServiceProvider val127 = new XamlServiceProvider();
		val127.Add(typeof(IProvideValueTarget), (object)new ValueTargetProvider((object)val28, (object)Label.TextColorProperty));
		val127.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(39, 28)));
		BindingBase val128 = ((IMarkupExtension<BindingBase>)(object)val27).ProvideValue((IServiceProvider)val127);
		((BindableObject)val28).SetBinding(Label.TextColorProperty, val128);
		((Layout)val40).Children.Add((IView)(object)val28);
		((BindableObject)val39).SetValue(Grid.ColumnDefinitionsProperty, (object)new ColumnDefinitionCollection((ColumnDefinition[])(object)new ColumnDefinition[3]
		{
			new ColumnDefinition(GridLength.Star),
			new ColumnDefinition(GridLength.Star),
			new ColumnDefinition(GridLength.Star)
		}));
		((BindableObject)val39).SetValue(Grid.RowDefinitionsProperty, (object)new RowDefinitionCollection((RowDefinition[])(object)new RowDefinition[3]
		{
			new RowDefinition(new GridLength(60.0)),
			new RowDefinition(new GridLength(60.0)),
			new RowDefinition(new GridLength(60.0))
		}));
		((BindableObject)val39).SetValue(Grid.ColumnSpacingProperty, (object)10.0);
		((BindableObject)val39).SetValue(Grid.RowSpacingProperty, (object)10.0);
		((BindableObject)val30).SetValue(VisualElement.BackgroundColorProperty, (object)new Color(0.9137255f, 0.11764706f, 33f / 85f, 1f));
		((BindableObject)val30).SetValue(Grid.ColumnSpanProperty, (object)2);
		((BindableObject)val30).SetValue(Frame.CornerRadiusProperty, (object)8f);
		((BindableObject)val29).SetValue(Label.TextProperty, (object)"Span 2 Cols");
		((BindableObject)val29).SetValue(Label.TextColorProperty, (object)Colors.White);
		((BindableObject)val29).SetValue(View.HorizontalOptionsProperty, (object)LayoutOptions.Center);
		((BindableObject)val29).SetValue(View.VerticalOptionsProperty, (object)LayoutOptions.Center);
		((BindableObject)val30).SetValue(ContentView.ContentProperty, (object)val29);
		((Layout)val39).Children.Add((IView)(object)val30);
		((BindableObject)val32).SetValue(VisualElement.BackgroundColorProperty, (object)new Color(0f, 0.7372549f, 0.83137256f, 1f));
		((BindableObject)val32).SetValue(Grid.ColumnProperty, (object)2);
		((BindableObject)val32).SetValue(Grid.RowSpanProperty, (object)2);
		((BindableObject)val32).SetValue(Frame.CornerRadiusProperty, (object)8f);
		((BindableObject)val31).SetValue(Label.TextProperty, (object)"Span 2 Rows");
		((BindableObject)val31).SetValue(Label.TextColorProperty, (object)Colors.White);
		((BindableObject)val31).SetValue(View.HorizontalOptionsProperty, (object)LayoutOptions.Center);
		((BindableObject)val31).SetValue(View.VerticalOptionsProperty, (object)LayoutOptions.Center);
		((BindableObject)val32).SetValue(ContentView.ContentProperty, (object)val31);
		((Layout)val39).Children.Add((IView)(object)val32);
		((BindableObject)val34).SetValue(VisualElement.BackgroundColorProperty, (object)new Color(0.54509807f, 0.7647059f, 0.2901961f, 1f));
		((BindableObject)val34).SetValue(Grid.RowProperty, (object)1);
		((BindableObject)val34).SetValue(Frame.CornerRadiusProperty, (object)8f);
		((BindableObject)val33).SetValue(Label.TextProperty, (object)"1x1");
		((BindableObject)val33).SetValue(Label.TextColorProperty, (object)Colors.White);
		((BindableObject)val33).SetValue(View.HorizontalOptionsProperty, (object)LayoutOptions.Center);
		((BindableObject)val33).SetValue(View.VerticalOptionsProperty, (object)LayoutOptions.Center);
		((BindableObject)val34).SetValue(ContentView.ContentProperty, (object)val33);
		((Layout)val39).Children.Add((IView)(object)val34);
		((BindableObject)val36).SetValue(VisualElement.BackgroundColorProperty, (object)new Color(1f, 0.75686276f, 0.02745098f, 1f));
		((BindableObject)val36).SetValue(Grid.RowProperty, (object)1);
		((BindableObject)val36).SetValue(Grid.ColumnProperty, (object)1);
		((BindableObject)val36).SetValue(Frame.CornerRadiusProperty, (object)8f);
		((BindableObject)val35).SetValue(Label.TextProperty, (object)"1x1");
		((BindableObject)val35).SetValue(Label.TextColorProperty, (object)Colors.White);
		((BindableObject)val35).SetValue(View.HorizontalOptionsProperty, (object)LayoutOptions.Center);
		((BindableObject)val35).SetValue(View.VerticalOptionsProperty, (object)LayoutOptions.Center);
		((BindableObject)val36).SetValue(ContentView.ContentProperty, (object)val35);
		((Layout)val39).Children.Add((IView)(object)val36);
		((BindableObject)val38).SetValue(VisualElement.BackgroundColorProperty, (object)new Color(32f / 85f, 25f / 51f, 0.54509807f, 1f));
		((BindableObject)val38).SetValue(Grid.RowProperty, (object)2);
		((BindableObject)val38).SetValue(Grid.ColumnSpanProperty, (object)3);
		((BindableObject)val38).SetValue(Frame.CornerRadiusProperty, (object)8f);
		((BindableObject)val37).SetValue(Label.TextProperty, (object)"Span All Columns");
		((BindableObject)val37).SetValue(Label.TextColorProperty, (object)Colors.White);
		((BindableObject)val37).SetValue(View.HorizontalOptionsProperty, (object)LayoutOptions.Center);
		((BindableObject)val37).SetValue(View.VerticalOptionsProperty, (object)LayoutOptions.Center);
		((BindableObject)val38).SetValue(ContentView.ContentProperty, (object)val37);
		((Layout)val39).Children.Add((IView)(object)val38);
		((Layout)val40).Children.Add((IView)(object)val39);
		((BindableObject)val41).SetValue(ContentView.ContentProperty, (object)val40);
		((Layout)val88).Children.Add((IView)(object)val41);
		val42.Key = "ThemedFrame";
		StaticResourceExtension val129 = new StaticResourceExtension
		{
			Key = "ThemedFrame"
		};
		XamlServiceProvider val130 = new XamlServiceProvider();
		Type? typeFromHandle11 = typeof(IProvideValueTarget);
		object[] array11 = new object[0 + 4];
		array11[0] = val59;
		array11[1] = val88;
		array11[2] = val89;
		array11[3] = gridsPage;
		SimpleValueTargetProvider val131 = new SimpleValueTargetProvider(array11, (object)VisualElement.StyleProperty, (INameScope[])(object)new NameScope[5] { val90, val90, val90, val90, val90 }, false);
		object obj13 = (object)val131;
		val130.Add(typeFromHandle11, (object)val131);
		val130.Add(typeof(IReferenceProvider), obj13);
		val130.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(61, 20)));
		object obj14 = val129.ProvideValue((IServiceProvider)val130);
		((BindableObject)val59).SetValue(VisualElement.StyleProperty, (obj14 == null || !typeof(BindingBase).IsAssignableFrom(obj14.GetType())) ? obj14 : obj14);
		((BindableObject)val59).SetValue(Frame.CornerRadiusProperty, (object)8f);
		((BindableObject)val59).SetValue(Layout.PaddingProperty, (object)new Thickness(15.0));
		((BindableObject)val58).SetValue(StackBase.SpacingProperty, (object)10.0);
		((BindableObject)val46).SetValue(Label.TextProperty, (object)"Auto & Star Sizing");
		((BindableObject)val46).SetValue(Label.FontSizeProperty, (object)18.0);
		((BindableObject)val46).SetValue(Label.FontAttributesProperty, (object)(FontAttributes)1);
		val43.Key = "TextPrimaryLight";
		StaticResourceExtension val132 = new StaticResourceExtension
		{
			Key = "TextPrimaryLight"
		};
		XamlServiceProvider val133 = new XamlServiceProvider();
		Type? typeFromHandle12 = typeof(IProvideValueTarget);
		object[] array12 = new object[0 + 7];
		array12[0] = val45;
		array12[1] = val46;
		array12[2] = val58;
		array12[3] = val59;
		array12[4] = val88;
		array12[5] = val89;
		array12[6] = gridsPage;
		SimpleValueTargetProvider val134 = new SimpleValueTargetProvider(array12, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Light"), (INameScope[])(object)new NameScope[8] { val90, val90, val90, val90, val90, val90, val90, val90 }, false);
		object obj15 = (object)val134;
		val133.Add(typeFromHandle12, (object)val134);
		val133.Add(typeof(IReferenceProvider), obj15);
		val133.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(64, 28)));
		object light5 = val132.ProvideValue((IServiceProvider)val133);
		val45.Light = light5;
		val44.Key = "TextPrimaryDark";
		StaticResourceExtension val135 = new StaticResourceExtension
		{
			Key = "TextPrimaryDark"
		};
		XamlServiceProvider val136 = new XamlServiceProvider();
		Type? typeFromHandle13 = typeof(IProvideValueTarget);
		object[] array13 = new object[0 + 7];
		array13[0] = val45;
		array13[1] = val46;
		array13[2] = val58;
		array13[3] = val59;
		array13[4] = val88;
		array13[5] = val89;
		array13[6] = gridsPage;
		SimpleValueTargetProvider val137 = new SimpleValueTargetProvider(array13, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Dark"), (INameScope[])(object)new NameScope[8] { val90, val90, val90, val90, val90, val90, val90, val90 }, false);
		object obj16 = (object)val137;
		val136.Add(typeFromHandle13, (object)val137);
		val136.Add(typeof(IReferenceProvider), obj16);
		val136.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(64, 28)));
		object dark5 = val135.ProvideValue((IServiceProvider)val136);
		val45.Dark = dark5;
		XamlServiceProvider val138 = new XamlServiceProvider();
		val138.Add(typeof(IProvideValueTarget), (object)new ValueTargetProvider((object)val46, (object)Label.TextColorProperty));
		val138.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(64, 28)));
		BindingBase val139 = ((IMarkupExtension<BindingBase>)(object)val45).ProvideValue((IServiceProvider)val138);
		((BindableObject)val46).SetBinding(Label.TextColorProperty, val139);
		((Layout)val58).Children.Add((IView)(object)val46);
		((BindableObject)val53).SetValue(Grid.ColumnDefinitionsProperty, (object)new ColumnDefinitionCollection((ColumnDefinition[])(object)new ColumnDefinition[3]
		{
			new ColumnDefinition(GridLength.Auto),
			new ColumnDefinition(GridLength.Star),
			new ColumnDefinition(new GridLength(2.0, (GridUnitType)1))
		}));
		((BindableObject)val53).SetValue(Grid.RowDefinitionsProperty, (object)new RowDefinitionCollection((RowDefinition[])(object)new RowDefinition[1]
		{
			new RowDefinition(new GridLength(50.0))
		}));
		((BindableObject)val53).SetValue(Grid.ColumnSpacingProperty, (object)10.0);
		((BindableObject)val48).SetValue(VisualElement.BackgroundColorProperty, (object)new Color(0.4745098f, 1f / 3f, 24f / 85f, 1f));
		((BindableObject)val48).SetValue(Frame.CornerRadiusProperty, (object)8f);
		((BindableObject)val48).SetValue(Layout.PaddingProperty, (object)new Thickness(10.0));
		((BindableObject)val47).SetValue(Label.TextProperty, (object)"Auto");
		((BindableObject)val47).SetValue(Label.TextColorProperty, (object)Colors.White);
		((BindableObject)val47).SetValue(View.VerticalOptionsProperty, (object)LayoutOptions.Center);
		((BindableObject)val48).SetValue(ContentView.ContentProperty, (object)val47);
		((Layout)val53).Children.Add((IView)(object)val48);
		((BindableObject)val50).SetValue(Grid.ColumnProperty, (object)1);
		((BindableObject)val50).SetValue(VisualElement.BackgroundColorProperty, (object)new Color(0f, 0.5882353f, 8f / 15f, 1f));
		((BindableObject)val50).SetValue(Frame.CornerRadiusProperty, (object)8f);
		((BindableObject)val49).SetValue(Label.TextProperty, (object)"1*");
		((BindableObject)val49).SetValue(Label.TextColorProperty, (object)Colors.White);
		((BindableObject)val49).SetValue(View.HorizontalOptionsProperty, (object)LayoutOptions.Center);
		((BindableObject)val49).SetValue(View.VerticalOptionsProperty, (object)LayoutOptions.Center);
		((BindableObject)val50).SetValue(ContentView.ContentProperty, (object)val49);
		((Layout)val53).Children.Add((IView)(object)val50);
		((BindableObject)val52).SetValue(Grid.ColumnProperty, (object)2);
		((BindableObject)val52).SetValue(VisualElement.BackgroundColorProperty, (object)new Color(21f / 85f, 27f / 85f, 0.70980394f, 1f));
		((BindableObject)val52).SetValue(Frame.CornerRadiusProperty, (object)8f);
		((BindableObject)val51).SetValue(Label.TextProperty, (object)"2*");
		((BindableObject)val51).SetValue(Label.TextColorProperty, (object)Colors.White);
		((BindableObject)val51).SetValue(View.HorizontalOptionsProperty, (object)LayoutOptions.Center);
		((BindableObject)val51).SetValue(View.VerticalOptionsProperty, (object)LayoutOptions.Center);
		((BindableObject)val52).SetValue(ContentView.ContentProperty, (object)val51);
		((Layout)val53).Children.Add((IView)(object)val52);
		((Layout)val58).Children.Add((IView)(object)val53);
		((BindableObject)val57).SetValue(Label.TextProperty, (object)"Auto: fits content, 1*: one part, 2*: two parts");
		((BindableObject)val57).SetValue(Label.FontSizeProperty, (object)12.0);
		val54.Key = "TextSecondaryLight";
		StaticResourceExtension val140 = new StaticResourceExtension
		{
			Key = "TextSecondaryLight"
		};
		XamlServiceProvider val141 = new XamlServiceProvider();
		Type? typeFromHandle14 = typeof(IProvideValueTarget);
		object[] array14 = new object[0 + 7];
		array14[0] = val56;
		array14[1] = val57;
		array14[2] = val58;
		array14[3] = val59;
		array14[4] = val88;
		array14[5] = val89;
		array14[6] = gridsPage;
		SimpleValueTargetProvider val142 = new SimpleValueTargetProvider(array14, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Light"), (INameScope[])(object)new NameScope[8] { val90, val90, val90, val90, val90, val90, val90, val90 }, false);
		object obj17 = (object)val142;
		val141.Add(typeFromHandle14, (object)val142);
		val141.Add(typeof(IReferenceProvider), obj17);
		val141.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(77, 28)));
		object light6 = val140.ProvideValue((IServiceProvider)val141);
		val56.Light = light6;
		val55.Key = "TextSecondaryDark";
		StaticResourceExtension val143 = new StaticResourceExtension
		{
			Key = "TextSecondaryDark"
		};
		XamlServiceProvider val144 = new XamlServiceProvider();
		Type? typeFromHandle15 = typeof(IProvideValueTarget);
		object[] array15 = new object[0 + 7];
		array15[0] = val56;
		array15[1] = val57;
		array15[2] = val58;
		array15[3] = val59;
		array15[4] = val88;
		array15[5] = val89;
		array15[6] = gridsPage;
		SimpleValueTargetProvider val145 = new SimpleValueTargetProvider(array15, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Dark"), (INameScope[])(object)new NameScope[8] { val90, val90, val90, val90, val90, val90, val90, val90 }, false);
		object obj18 = (object)val145;
		val144.Add(typeFromHandle15, (object)val145);
		val144.Add(typeof(IReferenceProvider), obj18);
		val144.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(77, 28)));
		object dark6 = val143.ProvideValue((IServiceProvider)val144);
		val56.Dark = dark6;
		XamlServiceProvider val146 = new XamlServiceProvider();
		val146.Add(typeof(IProvideValueTarget), (object)new ValueTargetProvider((object)val57, (object)Label.TextColorProperty));
		val146.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(77, 28)));
		BindingBase val147 = ((IMarkupExtension<BindingBase>)(object)val56).ProvideValue((IServiceProvider)val146);
		((BindableObject)val57).SetBinding(Label.TextColorProperty, val147);
		((Layout)val58).Children.Add((IView)(object)val57);
		((BindableObject)val59).SetValue(ContentView.ContentProperty, (object)val58);
		((Layout)val88).Children.Add((IView)(object)val59);
		val60.Key = "ThemedFrame";
		StaticResourceExtension val148 = new StaticResourceExtension
		{
			Key = "ThemedFrame"
		};
		XamlServiceProvider val149 = new XamlServiceProvider();
		Type? typeFromHandle16 = typeof(IProvideValueTarget);
		object[] array16 = new object[0 + 4];
		array16[0] = val87;
		array16[1] = val88;
		array16[2] = val89;
		array16[3] = gridsPage;
		SimpleValueTargetProvider val150 = new SimpleValueTargetProvider(array16, (object)VisualElement.StyleProperty, (INameScope[])(object)new NameScope[5] { val90, val90, val90, val90, val90 }, false);
		object obj19 = (object)val150;
		val149.Add(typeFromHandle16, (object)val150);
		val149.Add(typeof(IReferenceProvider), obj19);
		val149.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(82, 20)));
		object obj20 = val148.ProvideValue((IServiceProvider)val149);
		((BindableObject)val87).SetValue(VisualElement.StyleProperty, (obj20 == null || !typeof(BindingBase).IsAssignableFrom(obj20.GetType())) ? obj20 : obj20);
		((BindableObject)val87).SetValue(Frame.CornerRadiusProperty, (object)8f);
		((BindableObject)val87).SetValue(Layout.PaddingProperty, (object)new Thickness(15.0));
		((BindableObject)val86).SetValue(StackBase.SpacingProperty, (object)10.0);
		((BindableObject)val64).SetValue(Label.TextProperty, (object)"Form Layout Example");
		((BindableObject)val64).SetValue(Label.FontSizeProperty, (object)18.0);
		((BindableObject)val64).SetValue(Label.FontAttributesProperty, (object)(FontAttributes)1);
		val61.Key = "TextPrimaryLight";
		StaticResourceExtension val151 = new StaticResourceExtension
		{
			Key = "TextPrimaryLight"
		};
		XamlServiceProvider val152 = new XamlServiceProvider();
		Type? typeFromHandle17 = typeof(IProvideValueTarget);
		object[] array17 = new object[0 + 7];
		array17[0] = val63;
		array17[1] = val64;
		array17[2] = val86;
		array17[3] = val87;
		array17[4] = val88;
		array17[5] = val89;
		array17[6] = gridsPage;
		SimpleValueTargetProvider val153 = new SimpleValueTargetProvider(array17, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Light"), (INameScope[])(object)new NameScope[8] { val90, val90, val90, val90, val90, val90, val90, val90 }, false);
		object obj21 = (object)val153;
		val152.Add(typeFromHandle17, (object)val153);
		val152.Add(typeof(IReferenceProvider), obj21);
		val152.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(85, 28)));
		object light7 = val151.ProvideValue((IServiceProvider)val152);
		val63.Light = light7;
		val62.Key = "TextPrimaryDark";
		StaticResourceExtension val154 = new StaticResourceExtension
		{
			Key = "TextPrimaryDark"
		};
		XamlServiceProvider val155 = new XamlServiceProvider();
		Type? typeFromHandle18 = typeof(IProvideValueTarget);
		object[] array18 = new object[0 + 7];
		array18[0] = val63;
		array18[1] = val64;
		array18[2] = val86;
		array18[3] = val87;
		array18[4] = val88;
		array18[5] = val89;
		array18[6] = gridsPage;
		SimpleValueTargetProvider val156 = new SimpleValueTargetProvider(array18, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Dark"), (INameScope[])(object)new NameScope[8] { val90, val90, val90, val90, val90, val90, val90, val90 }, false);
		object obj22 = (object)val156;
		val155.Add(typeFromHandle18, (object)val156);
		val155.Add(typeof(IReferenceProvider), obj22);
		val155.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(85, 28)));
		object dark7 = val154.ProvideValue((IServiceProvider)val155);
		val63.Dark = dark7;
		XamlServiceProvider val157 = new XamlServiceProvider();
		val157.Add(typeof(IProvideValueTarget), (object)new ValueTargetProvider((object)val64, (object)Label.TextColorProperty));
		val157.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(85, 28)));
		BindingBase val158 = ((IMarkupExtension<BindingBase>)(object)val63).ProvideValue((IServiceProvider)val157);
		((BindableObject)val64).SetBinding(Label.TextColorProperty, val158);
		((Layout)val86).Children.Add((IView)(object)val64);
		((BindableObject)val85).SetValue(Grid.ColumnDefinitionsProperty, (object)new ColumnDefinitionCollection((ColumnDefinition[])(object)new ColumnDefinition[2]
		{
			new ColumnDefinition(GridLength.Auto),
			new ColumnDefinition(GridLength.Star)
		}));
		((BindableObject)val85).SetValue(Grid.RowDefinitionsProperty, (object)new RowDefinitionCollection((RowDefinition[])(object)new RowDefinition[4]
		{
			new RowDefinition(GridLength.Auto),
			new RowDefinition(GridLength.Auto),
			new RowDefinition(GridLength.Auto),
			new RowDefinition(GridLength.Auto)
		}));
		((BindableObject)val85).SetValue(Grid.ColumnSpacingProperty, (object)15.0);
		((BindableObject)val85).SetValue(Grid.RowSpacingProperty, (object)10.0);
		((BindableObject)val68).SetValue(Label.TextProperty, (object)"Name:");
		((BindableObject)val68).SetValue(View.VerticalOptionsProperty, (object)LayoutOptions.Center);
		val65.Key = "TextPrimaryLight";
		StaticResourceExtension val159 = new StaticResourceExtension
		{
			Key = "TextPrimaryLight"
		};
		XamlServiceProvider val160 = new XamlServiceProvider();
		Type? typeFromHandle19 = typeof(IProvideValueTarget);
		object[] array19 = new object[0 + 8];
		array19[0] = val67;
		array19[1] = val68;
		array19[2] = val85;
		array19[3] = val86;
		array19[4] = val87;
		array19[5] = val88;
		array19[6] = val89;
		array19[7] = gridsPage;
		SimpleValueTargetProvider val161 = new SimpleValueTargetProvider(array19, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Light"), (INameScope[])(object)new NameScope[9] { val90, val90, val90, val90, val90, val90, val90, val90, val90 }, false);
		object obj23 = (object)val161;
		val160.Add(typeFromHandle19, (object)val161);
		val160.Add(typeof(IReferenceProvider), obj23);
		val160.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(88, 32)));
		object light8 = val159.ProvideValue((IServiceProvider)val160);
		val67.Light = light8;
		val66.Key = "TextPrimaryDark";
		StaticResourceExtension val162 = new StaticResourceExtension
		{
			Key = "TextPrimaryDark"
		};
		XamlServiceProvider val163 = new XamlServiceProvider();
		Type? typeFromHandle20 = typeof(IProvideValueTarget);
		object[] array20 = new object[0 + 8];
		array20[0] = val67;
		array20[1] = val68;
		array20[2] = val85;
		array20[3] = val86;
		array20[4] = val87;
		array20[5] = val88;
		array20[6] = val89;
		array20[7] = gridsPage;
		SimpleValueTargetProvider val164 = new SimpleValueTargetProvider(array20, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Dark"), (INameScope[])(object)new NameScope[9] { val90, val90, val90, val90, val90, val90, val90, val90, val90 }, false);
		object obj24 = (object)val164;
		val163.Add(typeFromHandle20, (object)val164);
		val163.Add(typeof(IReferenceProvider), obj24);
		val163.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(88, 32)));
		object dark8 = val162.ProvideValue((IServiceProvider)val163);
		val67.Dark = dark8;
		XamlServiceProvider val165 = new XamlServiceProvider();
		val165.Add(typeof(IProvideValueTarget), (object)new ValueTargetProvider((object)val68, (object)Label.TextColorProperty));
		val165.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(88, 32)));
		BindingBase val166 = ((IMarkupExtension<BindingBase>)(object)val67).ProvideValue((IServiceProvider)val165);
		((BindableObject)val68).SetBinding(Label.TextColorProperty, val166);
		((Layout)val85).Children.Add((IView)(object)val68);
		((BindableObject)val70).SetValue(Grid.ColumnProperty, (object)1);
		((BindableObject)val70).SetValue(Entry.PlaceholderProperty, (object)"Enter name");
		val69.Key = "ThemedEntry";
		StaticResourceExtension val167 = new StaticResourceExtension
		{
			Key = "ThemedEntry"
		};
		XamlServiceProvider val168 = new XamlServiceProvider();
		Type? typeFromHandle21 = typeof(IProvideValueTarget);
		object[] array21 = new object[0 + 7];
		array21[0] = val70;
		array21[1] = val85;
		array21[2] = val86;
		array21[3] = val87;
		array21[4] = val88;
		array21[5] = val89;
		array21[6] = gridsPage;
		SimpleValueTargetProvider val169 = new SimpleValueTargetProvider(array21, (object)VisualElement.StyleProperty, (INameScope[])(object)new NameScope[8] { val90, val90, val90, val90, val90, val90, val90, val90 }, false);
		object obj25 = (object)val169;
		val168.Add(typeFromHandle21, (object)val169);
		val168.Add(typeof(IReferenceProvider), obj25);
		val168.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(89, 73)));
		object obj26 = val167.ProvideValue((IServiceProvider)val168);
		((BindableObject)val70).SetValue(VisualElement.StyleProperty, (obj26 == null || !typeof(BindingBase).IsAssignableFrom(obj26.GetType())) ? obj26 : obj26);
		((Layout)val85).Children.Add((IView)(object)val70);
		((BindableObject)val74).SetValue(Grid.RowProperty, (object)1);
		((BindableObject)val74).SetValue(Label.TextProperty, (object)"Email:");
		((BindableObject)val74).SetValue(View.VerticalOptionsProperty, (object)LayoutOptions.Center);
		val71.Key = "TextPrimaryLight";
		StaticResourceExtension val170 = new StaticResourceExtension
		{
			Key = "TextPrimaryLight"
		};
		XamlServiceProvider val171 = new XamlServiceProvider();
		Type? typeFromHandle22 = typeof(IProvideValueTarget);
		object[] array22 = new object[0 + 8];
		array22[0] = val73;
		array22[1] = val74;
		array22[2] = val85;
		array22[3] = val86;
		array22[4] = val87;
		array22[5] = val88;
		array22[6] = val89;
		array22[7] = gridsPage;
		SimpleValueTargetProvider val172 = new SimpleValueTargetProvider(array22, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Light"), (INameScope[])(object)new NameScope[9] { val90, val90, val90, val90, val90, val90, val90, val90, val90 }, false);
		object obj27 = (object)val172;
		val171.Add(typeFromHandle22, (object)val172);
		val171.Add(typeof(IReferenceProvider), obj27);
		val171.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(92, 32)));
		object light9 = val170.ProvideValue((IServiceProvider)val171);
		val73.Light = light9;
		val72.Key = "TextPrimaryDark";
		StaticResourceExtension val173 = new StaticResourceExtension
		{
			Key = "TextPrimaryDark"
		};
		XamlServiceProvider val174 = new XamlServiceProvider();
		Type? typeFromHandle23 = typeof(IProvideValueTarget);
		object[] array23 = new object[0 + 8];
		array23[0] = val73;
		array23[1] = val74;
		array23[2] = val85;
		array23[3] = val86;
		array23[4] = val87;
		array23[5] = val88;
		array23[6] = val89;
		array23[7] = gridsPage;
		SimpleValueTargetProvider val175 = new SimpleValueTargetProvider(array23, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Dark"), (INameScope[])(object)new NameScope[9] { val90, val90, val90, val90, val90, val90, val90, val90, val90 }, false);
		object obj28 = (object)val175;
		val174.Add(typeFromHandle23, (object)val175);
		val174.Add(typeof(IReferenceProvider), obj28);
		val174.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(92, 32)));
		object dark9 = val173.ProvideValue((IServiceProvider)val174);
		val73.Dark = dark9;
		XamlServiceProvider val176 = new XamlServiceProvider();
		val176.Add(typeof(IProvideValueTarget), (object)new ValueTargetProvider((object)val74, (object)Label.TextColorProperty));
		val176.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(92, 32)));
		BindingBase val177 = ((IMarkupExtension<BindingBase>)(object)val73).ProvideValue((IServiceProvider)val176);
		((BindableObject)val74).SetBinding(Label.TextColorProperty, val177);
		((Layout)val85).Children.Add((IView)(object)val74);
		((BindableObject)val76).SetValue(Grid.RowProperty, (object)1);
		((BindableObject)val76).SetValue(Grid.ColumnProperty, (object)1);
		((BindableObject)val76).SetValue(Entry.PlaceholderProperty, (object)"Enter email");
		((BindableObject)val76).SetValue(Entry.KeyboardProperty, ((TypeConverter)new KeyboardTypeConverter()).ConvertFromInvariantString("Email"));
		val75.Key = "ThemedEntry";
		StaticResourceExtension val178 = new StaticResourceExtension
		{
			Key = "ThemedEntry"
		};
		XamlServiceProvider val179 = new XamlServiceProvider();
		Type? typeFromHandle24 = typeof(IProvideValueTarget);
		object[] array24 = new object[0 + 7];
		array24[0] = val76;
		array24[1] = val85;
		array24[2] = val86;
		array24[3] = val87;
		array24[4] = val88;
		array24[5] = val89;
		array24[6] = gridsPage;
		SimpleValueTargetProvider val180 = new SimpleValueTargetProvider(array24, (object)VisualElement.StyleProperty, (INameScope[])(object)new NameScope[8] { val90, val90, val90, val90, val90, val90, val90, val90 }, false);
		object obj29 = (object)val180;
		val179.Add(typeFromHandle24, (object)val180);
		val179.Add(typeof(IReferenceProvider), obj29);
		val179.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(93, 104)));
		object obj30 = val178.ProvideValue((IServiceProvider)val179);
		((BindableObject)val76).SetValue(VisualElement.StyleProperty, (obj30 == null || !typeof(BindingBase).IsAssignableFrom(obj30.GetType())) ? obj30 : obj30);
		((Layout)val85).Children.Add((IView)(object)val76);
		((BindableObject)val80).SetValue(Grid.RowProperty, (object)2);
		((BindableObject)val80).SetValue(Label.TextProperty, (object)"Phone:");
		((BindableObject)val80).SetValue(View.VerticalOptionsProperty, (object)LayoutOptions.Center);
		val77.Key = "TextPrimaryLight";
		StaticResourceExtension val181 = new StaticResourceExtension
		{
			Key = "TextPrimaryLight"
		};
		XamlServiceProvider val182 = new XamlServiceProvider();
		Type? typeFromHandle25 = typeof(IProvideValueTarget);
		object[] array25 = new object[0 + 8];
		array25[0] = val79;
		array25[1] = val80;
		array25[2] = val85;
		array25[3] = val86;
		array25[4] = val87;
		array25[5] = val88;
		array25[6] = val89;
		array25[7] = gridsPage;
		SimpleValueTargetProvider val183 = new SimpleValueTargetProvider(array25, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Light"), (INameScope[])(object)new NameScope[9] { val90, val90, val90, val90, val90, val90, val90, val90, val90 }, false);
		object obj31 = (object)val183;
		val182.Add(typeFromHandle25, (object)val183);
		val182.Add(typeof(IReferenceProvider), obj31);
		val182.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(96, 32)));
		object light10 = val181.ProvideValue((IServiceProvider)val182);
		val79.Light = light10;
		val78.Key = "TextPrimaryDark";
		StaticResourceExtension val184 = new StaticResourceExtension
		{
			Key = "TextPrimaryDark"
		};
		XamlServiceProvider val185 = new XamlServiceProvider();
		Type? typeFromHandle26 = typeof(IProvideValueTarget);
		object[] array26 = new object[0 + 8];
		array26[0] = val79;
		array26[1] = val80;
		array26[2] = val85;
		array26[3] = val86;
		array26[4] = val87;
		array26[5] = val88;
		array26[6] = val89;
		array26[7] = gridsPage;
		SimpleValueTargetProvider val186 = new SimpleValueTargetProvider(array26, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Dark"), (INameScope[])(object)new NameScope[9] { val90, val90, val90, val90, val90, val90, val90, val90, val90 }, false);
		object obj32 = (object)val186;
		val185.Add(typeFromHandle26, (object)val186);
		val185.Add(typeof(IReferenceProvider), obj32);
		val185.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(96, 32)));
		object dark10 = val184.ProvideValue((IServiceProvider)val185);
		val79.Dark = dark10;
		XamlServiceProvider val187 = new XamlServiceProvider();
		val187.Add(typeof(IProvideValueTarget), (object)new ValueTargetProvider((object)val80, (object)Label.TextColorProperty));
		val187.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(96, 32)));
		BindingBase val188 = ((IMarkupExtension<BindingBase>)(object)val79).ProvideValue((IServiceProvider)val187);
		((BindableObject)val80).SetBinding(Label.TextColorProperty, val188);
		((Layout)val85).Children.Add((IView)(object)val80);
		((BindableObject)val82).SetValue(Grid.RowProperty, (object)2);
		((BindableObject)val82).SetValue(Grid.ColumnProperty, (object)1);
		((BindableObject)val82).SetValue(Entry.PlaceholderProperty, (object)"Enter phone");
		((BindableObject)val82).SetValue(Entry.KeyboardProperty, ((TypeConverter)new KeyboardTypeConverter()).ConvertFromInvariantString("Telephone"));
		val81.Key = "ThemedEntry";
		StaticResourceExtension val189 = new StaticResourceExtension
		{
			Key = "ThemedEntry"
		};
		XamlServiceProvider val190 = new XamlServiceProvider();
		Type? typeFromHandle27 = typeof(IProvideValueTarget);
		object[] array27 = new object[0 + 7];
		array27[0] = val82;
		array27[1] = val85;
		array27[2] = val86;
		array27[3] = val87;
		array27[4] = val88;
		array27[5] = val89;
		array27[6] = gridsPage;
		SimpleValueTargetProvider val191 = new SimpleValueTargetProvider(array27, (object)VisualElement.StyleProperty, (INameScope[])(object)new NameScope[8] { val90, val90, val90, val90, val90, val90, val90, val90 }, false);
		object obj33 = (object)val191;
		val190.Add(typeFromHandle27, (object)val191);
		val190.Add(typeof(IReferenceProvider), obj33);
		val190.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(97, 108)));
		object obj34 = val189.ProvideValue((IServiceProvider)val190);
		((BindableObject)val82).SetValue(VisualElement.StyleProperty, (obj34 == null || !typeof(BindingBase).IsAssignableFrom(obj34.GetType())) ? obj34 : obj34);
		((Layout)val85).Children.Add((IView)(object)val82);
		((BindableObject)val84).SetValue(Grid.RowProperty, (object)3);
		((BindableObject)val84).SetValue(Grid.ColumnSpanProperty, (object)2);
		((BindableObject)val84).SetValue(Button.TextProperty, (object)"Submit");
		val83.Key = "PrimaryButton";
		StaticResourceExtension val192 = new StaticResourceExtension
		{
			Key = "PrimaryButton"
		};
		XamlServiceProvider val193 = new XamlServiceProvider();
		Type? typeFromHandle28 = typeof(IProvideValueTarget);
		object[] array28 = new object[0 + 7];
		array28[0] = val84;
		array28[1] = val85;
		array28[2] = val86;
		array28[3] = val87;
		array28[4] = val88;
		array28[5] = val89;
		array28[6] = gridsPage;
		SimpleValueTargetProvider val194 = new SimpleValueTargetProvider(array28, (object)VisualElement.StyleProperty, (INameScope[])(object)new NameScope[8] { val90, val90, val90, val90, val90, val90, val90, val90 }, false);
		object obj35 = (object)val194;
		val193.Add(typeFromHandle28, (object)val194);
		val193.Add(typeof(IReferenceProvider), obj35);
		val193.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(99, 80)));
		object obj36 = val192.ProvideValue((IServiceProvider)val193);
		((BindableObject)val84).SetValue(VisualElement.StyleProperty, (obj36 == null || !typeof(BindingBase).IsAssignableFrom(obj36.GetType())) ? obj36 : obj36);
		((Layout)val85).Children.Add((IView)(object)val84);
		((Layout)val86).Children.Add((IView)(object)val85);
		((BindableObject)val87).SetValue(ContentView.ContentProperty, (object)val86);
		((Layout)val88).Children.Add((IView)(object)val87);
		val89.Content = (View)(object)val88;
		((BindableObject)gridsPage).SetValue(ContentPage.ContentProperty, (object)val89);
	}
}
