using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Xml;
using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Compatibility;
using Microsoft.Maui.Controls.Internals;
using Microsoft.Maui.Controls.Xaml;
using Microsoft.Maui.Controls.Xaml.Internals;
using Microsoft.Maui.Graphics;

namespace ShellDemo;

[XamlFilePath("Pages/AboutPage.xaml")]
public class AboutPage : ContentPage
{
	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private Label WebsiteLink;

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private Label GitHubLink;

	public AboutPage()
	{
		InitializeComponent();
	}

	private void OnWebsiteTapped(object? sender, TappedEventArgs e)
	{
		OpenUrl("https://openmaui.net");
	}

	private void OnGitHubTapped(object? sender, TappedEventArgs e)
	{
		OpenUrl("https://github.com/openmaui/maui-linux");
	}

	private void OpenUrl(string url)
	{
		try
		{
			Process.Start(new ProcessStartInfo
			{
				FileName = "xdg-open",
				Arguments = url,
				UseShellExecute = false,
				CreateNoWindow = true
			});
		}
		catch (Exception ex)
		{
			Console.WriteLine("Failed to open URL: " + ex.Message);
		}
	}

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	[MemberNotNull("WebsiteLink")]
	[MemberNotNull("GitHubLink")]
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
		//IL_0279: Unknown result type (might be due to invalid IL or missing references)
		//IL_0453: Unknown result type (might be due to invalid IL or missing references)
		//IL_0458: Unknown result type (might be due to invalid IL or missing references)
		//IL_0463: Unknown result type (might be due to invalid IL or missing references)
		//IL_0468: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b6: Expected O, but got Unknown
		//IL_04bb: Expected O, but got Unknown
		//IL_04bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_04cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_04db: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e5: Expected O, but got Unknown
		//IL_04e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ea: Expected O, but got Unknown
		//IL_04ef: Expected O, but got Unknown
		//IL_0504: Unknown result type (might be due to invalid IL or missing references)
		//IL_0509: Unknown result type (might be due to invalid IL or missing references)
		//IL_0514: Unknown result type (might be due to invalid IL or missing references)
		//IL_0519: Unknown result type (might be due to invalid IL or missing references)
		//IL_055f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0564: Unknown result type (might be due to invalid IL or missing references)
		//IL_0567: Expected O, but got Unknown
		//IL_056c: Expected O, but got Unknown
		//IL_056c: Unknown result type (might be due to invalid IL or missing references)
		//IL_057e: Unknown result type (might be due to invalid IL or missing references)
		//IL_058c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0596: Expected O, but got Unknown
		//IL_0591: Unknown result type (might be due to invalid IL or missing references)
		//IL_059b: Expected O, but got Unknown
		//IL_05a0: Expected O, but got Unknown
		//IL_05ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_05cc: Expected O, but got Unknown
		//IL_05cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_05da: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e4: Expected O, but got Unknown
		//IL_05df: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e9: Expected O, but got Unknown
		//IL_05ee: Expected O, but got Unknown
		//IL_060e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0688: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0722: Unknown result type (might be due to invalid IL or missing references)
		//IL_0727: Unknown result type (might be due to invalid IL or missing references)
		//IL_072a: Expected O, but got Unknown
		//IL_072f: Expected O, but got Unknown
		//IL_072f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0741: Unknown result type (might be due to invalid IL or missing references)
		//IL_0750: Unknown result type (might be due to invalid IL or missing references)
		//IL_075a: Expected O, but got Unknown
		//IL_0755: Unknown result type (might be due to invalid IL or missing references)
		//IL_075f: Expected O, but got Unknown
		//IL_0764: Expected O, but got Unknown
		//IL_07eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0801: Unknown result type (might be due to invalid IL or missing references)
		//IL_0870: Unknown result type (might be due to invalid IL or missing references)
		//IL_088b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0890: Unknown result type (might be due to invalid IL or missing references)
		//IL_089b: Unknown result type (might be due to invalid IL or missing references)
		//IL_08a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0905: Unknown result type (might be due to invalid IL or missing references)
		//IL_090a: Unknown result type (might be due to invalid IL or missing references)
		//IL_090d: Expected O, but got Unknown
		//IL_0912: Expected O, but got Unknown
		//IL_0912: Unknown result type (might be due to invalid IL or missing references)
		//IL_0924: Unknown result type (might be due to invalid IL or missing references)
		//IL_0933: Unknown result type (might be due to invalid IL or missing references)
		//IL_093d: Expected O, but got Unknown
		//IL_0938: Unknown result type (might be due to invalid IL or missing references)
		//IL_0942: Expected O, but got Unknown
		//IL_0947: Expected O, but got Unknown
		//IL_095e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0963: Unknown result type (might be due to invalid IL or missing references)
		//IL_096e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0973: Unknown result type (might be due to invalid IL or missing references)
		//IL_09d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_09dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_09e0: Expected O, but got Unknown
		//IL_09e5: Expected O, but got Unknown
		//IL_09e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_09f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a06: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a10: Expected O, but got Unknown
		//IL_0a0b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a15: Expected O, but got Unknown
		//IL_0a1a: Expected O, but got Unknown
		//IL_0a27: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a2c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a3e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a48: Expected O, but got Unknown
		//IL_0a48: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a57: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a61: Expected O, but got Unknown
		//IL_0a5c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a66: Expected O, but got Unknown
		//IL_0a6b: Expected O, but got Unknown
		//IL_0abb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ad6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0adb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ae6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aeb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b50: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b55: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b58: Expected O, but got Unknown
		//IL_0b5d: Expected O, but got Unknown
		//IL_0b5d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b6f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b7e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b88: Expected O, but got Unknown
		//IL_0b83: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b8d: Expected O, but got Unknown
		//IL_0b92: Expected O, but got Unknown
		//IL_0ba9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bae: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bb9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bbe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c23: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c28: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c2b: Expected O, but got Unknown
		//IL_0c30: Expected O, but got Unknown
		//IL_0c30: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c42: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c51: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c5b: Expected O, but got Unknown
		//IL_0c56: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c60: Expected O, but got Unknown
		//IL_0c65: Expected O, but got Unknown
		//IL_0c72: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c77: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c89: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c93: Expected O, but got Unknown
		//IL_0c93: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ca2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cac: Expected O, but got Unknown
		//IL_0ca7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cb1: Expected O, but got Unknown
		//IL_0cb6: Expected O, but got Unknown
		//IL_0d06: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d21: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d26: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d31: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d36: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d9b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0da0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0da3: Expected O, but got Unknown
		//IL_0da8: Expected O, but got Unknown
		//IL_0da8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dba: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dc9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dd3: Expected O, but got Unknown
		//IL_0dce: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dd8: Expected O, but got Unknown
		//IL_0ddd: Expected O, but got Unknown
		//IL_0df4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0df9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e04: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e09: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e6e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e73: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e76: Expected O, but got Unknown
		//IL_0e7b: Expected O, but got Unknown
		//IL_0e7b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e8d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e9c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ea6: Expected O, but got Unknown
		//IL_0ea1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eab: Expected O, but got Unknown
		//IL_0eb0: Expected O, but got Unknown
		//IL_0ebd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ec2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ed4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ede: Expected O, but got Unknown
		//IL_0ede: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eed: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ef7: Expected O, but got Unknown
		//IL_0ef2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0efc: Expected O, but got Unknown
		//IL_0f01: Expected O, but got Unknown
		//IL_0f52: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f6d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f72: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f7d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f82: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fe7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fec: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fef: Expected O, but got Unknown
		//IL_0ff4: Expected O, but got Unknown
		//IL_0ff4: Unknown result type (might be due to invalid IL or missing references)
		//IL_1006: Unknown result type (might be due to invalid IL or missing references)
		//IL_1015: Unknown result type (might be due to invalid IL or missing references)
		//IL_101f: Expected O, but got Unknown
		//IL_101a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1024: Expected O, but got Unknown
		//IL_1029: Expected O, but got Unknown
		//IL_1040: Unknown result type (might be due to invalid IL or missing references)
		//IL_1045: Unknown result type (might be due to invalid IL or missing references)
		//IL_1050: Unknown result type (might be due to invalid IL or missing references)
		//IL_1055: Unknown result type (might be due to invalid IL or missing references)
		//IL_10ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_10bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_10c2: Expected O, but got Unknown
		//IL_10c7: Expected O, but got Unknown
		//IL_10c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_10d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_10e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_10f2: Expected O, but got Unknown
		//IL_10ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_10f7: Expected O, but got Unknown
		//IL_10fc: Expected O, but got Unknown
		//IL_1109: Unknown result type (might be due to invalid IL or missing references)
		//IL_110e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1120: Unknown result type (might be due to invalid IL or missing references)
		//IL_112a: Expected O, but got Unknown
		//IL_112a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1139: Unknown result type (might be due to invalid IL or missing references)
		//IL_1143: Expected O, but got Unknown
		//IL_113e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1148: Expected O, but got Unknown
		//IL_114d: Expected O, but got Unknown
		//IL_1177: Unknown result type (might be due to invalid IL or missing references)
		//IL_117c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1187: Unknown result type (might be due to invalid IL or missing references)
		//IL_118c: Unknown result type (might be due to invalid IL or missing references)
		//IL_11d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_11dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_11e0: Expected O, but got Unknown
		//IL_11e5: Expected O, but got Unknown
		//IL_11e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_11f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_1206: Unknown result type (might be due to invalid IL or missing references)
		//IL_1210: Expected O, but got Unknown
		//IL_120b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1215: Expected O, but got Unknown
		//IL_121a: Expected O, but got Unknown
		//IL_1272: Unknown result type (might be due to invalid IL or missing references)
		//IL_12e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_12e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_12f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_12f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_1372: Unknown result type (might be due to invalid IL or missing references)
		//IL_1377: Unknown result type (might be due to invalid IL or missing references)
		//IL_137a: Expected O, but got Unknown
		//IL_137f: Expected O, but got Unknown
		//IL_137f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1391: Unknown result type (might be due to invalid IL or missing references)
		//IL_13a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_13aa: Expected O, but got Unknown
		//IL_13a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_13af: Expected O, but got Unknown
		//IL_13b4: Expected O, but got Unknown
		//IL_13cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_13d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_13db: Unknown result type (might be due to invalid IL or missing references)
		//IL_13e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_1459: Unknown result type (might be due to invalid IL or missing references)
		//IL_145e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1461: Expected O, but got Unknown
		//IL_1466: Expected O, but got Unknown
		//IL_1466: Unknown result type (might be due to invalid IL or missing references)
		//IL_1478: Unknown result type (might be due to invalid IL or missing references)
		//IL_1487: Unknown result type (might be due to invalid IL or missing references)
		//IL_1491: Expected O, but got Unknown
		//IL_148c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1496: Expected O, but got Unknown
		//IL_149b: Expected O, but got Unknown
		//IL_14a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_14ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_14bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_14c9: Expected O, but got Unknown
		//IL_14c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_14d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_14e2: Expected O, but got Unknown
		//IL_14dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_14e7: Expected O, but got Unknown
		//IL_14ec: Expected O, but got Unknown
		//IL_1553: Unknown result type (might be due to invalid IL or missing references)
		//IL_1558: Unknown result type (might be due to invalid IL or missing references)
		//IL_1563: Unknown result type (might be due to invalid IL or missing references)
		//IL_1568: Unknown result type (might be due to invalid IL or missing references)
		//IL_15e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_15e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_15e9: Expected O, but got Unknown
		//IL_15ee: Expected O, but got Unknown
		//IL_15ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_1600: Unknown result type (might be due to invalid IL or missing references)
		//IL_160f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1619: Expected O, but got Unknown
		//IL_1614: Unknown result type (might be due to invalid IL or missing references)
		//IL_161e: Expected O, but got Unknown
		//IL_1623: Expected O, but got Unknown
		//IL_163a: Unknown result type (might be due to invalid IL or missing references)
		//IL_163f: Unknown result type (might be due to invalid IL or missing references)
		//IL_164a: Unknown result type (might be due to invalid IL or missing references)
		//IL_164f: Unknown result type (might be due to invalid IL or missing references)
		//IL_16c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_16cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_16d0: Expected O, but got Unknown
		//IL_16d5: Expected O, but got Unknown
		//IL_16d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_16e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_16f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_1700: Expected O, but got Unknown
		//IL_16fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_1705: Expected O, but got Unknown
		//IL_170a: Expected O, but got Unknown
		//IL_1717: Unknown result type (might be due to invalid IL or missing references)
		//IL_171c: Unknown result type (might be due to invalid IL or missing references)
		//IL_172e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1738: Expected O, but got Unknown
		//IL_1738: Unknown result type (might be due to invalid IL or missing references)
		//IL_1747: Unknown result type (might be due to invalid IL or missing references)
		//IL_1751: Expected O, but got Unknown
		//IL_174c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1756: Expected O, but got Unknown
		//IL_175b: Expected O, but got Unknown
		//IL_17a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_17a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_17b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_17b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_1802: Unknown result type (might be due to invalid IL or missing references)
		//IL_1807: Unknown result type (might be due to invalid IL or missing references)
		//IL_180a: Expected O, but got Unknown
		//IL_180f: Expected O, but got Unknown
		//IL_180f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1821: Unknown result type (might be due to invalid IL or missing references)
		//IL_1830: Unknown result type (might be due to invalid IL or missing references)
		//IL_183a: Expected O, but got Unknown
		//IL_1835: Unknown result type (might be due to invalid IL or missing references)
		//IL_183f: Expected O, but got Unknown
		//IL_1844: Expected O, but got Unknown
		//IL_189c: Unknown result type (might be due to invalid IL or missing references)
		//IL_190e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1913: Unknown result type (might be due to invalid IL or missing references)
		//IL_191e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1923: Unknown result type (might be due to invalid IL or missing references)
		//IL_199c: Unknown result type (might be due to invalid IL or missing references)
		//IL_19a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_19a4: Expected O, but got Unknown
		//IL_19a9: Expected O, but got Unknown
		//IL_19a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_19bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_19ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_19d4: Expected O, but got Unknown
		//IL_19cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_19d9: Expected O, but got Unknown
		//IL_19de: Expected O, but got Unknown
		//IL_19f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_19fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a05: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a0a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a83: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a88: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a8b: Expected O, but got Unknown
		//IL_1a90: Expected O, but got Unknown
		//IL_1a90: Unknown result type (might be due to invalid IL or missing references)
		//IL_1aa2: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ab1: Unknown result type (might be due to invalid IL or missing references)
		//IL_1abb: Expected O, but got Unknown
		//IL_1ab6: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ac0: Expected O, but got Unknown
		//IL_1ac5: Expected O, but got Unknown
		//IL_1ad2: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ad7: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ae9: Unknown result type (might be due to invalid IL or missing references)
		//IL_1af3: Expected O, but got Unknown
		//IL_1af3: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b02: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b0c: Expected O, but got Unknown
		//IL_1b07: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b11: Expected O, but got Unknown
		//IL_1b16: Expected O, but got Unknown
		//IL_1b7a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b84: Expected O, but got Unknown
		//IL_1bc9: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bce: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bd9: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bde: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c62: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c67: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c6a: Expected O, but got Unknown
		//IL_1c6f: Expected O, but got Unknown
		//IL_1c6f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c81: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c90: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c9a: Expected O, but got Unknown
		//IL_1c95: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c9f: Expected O, but got Unknown
		//IL_1ca4: Expected O, but got Unknown
		//IL_1cbb: Unknown result type (might be due to invalid IL or missing references)
		//IL_1cc0: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ccb: Unknown result type (might be due to invalid IL or missing references)
		//IL_1cd0: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d54: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d59: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d5c: Expected O, but got Unknown
		//IL_1d61: Expected O, but got Unknown
		//IL_1d61: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d73: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d82: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d8c: Expected O, but got Unknown
		//IL_1d87: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d91: Expected O, but got Unknown
		//IL_1d96: Expected O, but got Unknown
		//IL_1da3: Unknown result type (might be due to invalid IL or missing references)
		//IL_1da8: Unknown result type (might be due to invalid IL or missing references)
		//IL_1dba: Unknown result type (might be due to invalid IL or missing references)
		//IL_1dc4: Expected O, but got Unknown
		//IL_1dc4: Unknown result type (might be due to invalid IL or missing references)
		//IL_1dd3: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ddd: Expected O, but got Unknown
		//IL_1dd8: Unknown result type (might be due to invalid IL or missing references)
		//IL_1de2: Expected O, but got Unknown
		//IL_1de7: Expected O, but got Unknown
		//IL_1e59: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e63: Expected O, but got Unknown
		//IL_1ea8: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ead: Unknown result type (might be due to invalid IL or missing references)
		//IL_1eb8: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ebd: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f41: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f46: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f49: Expected O, but got Unknown
		//IL_1f4e: Expected O, but got Unknown
		//IL_1f4e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f60: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f6f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f79: Expected O, but got Unknown
		//IL_1f74: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f7e: Expected O, but got Unknown
		//IL_1f83: Expected O, but got Unknown
		//IL_1f9a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f9f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1faa: Unknown result type (might be due to invalid IL or missing references)
		//IL_1faf: Unknown result type (might be due to invalid IL or missing references)
		//IL_2033: Unknown result type (might be due to invalid IL or missing references)
		//IL_2038: Unknown result type (might be due to invalid IL or missing references)
		//IL_203b: Expected O, but got Unknown
		//IL_2040: Expected O, but got Unknown
		//IL_2040: Unknown result type (might be due to invalid IL or missing references)
		//IL_2052: Unknown result type (might be due to invalid IL or missing references)
		//IL_2061: Unknown result type (might be due to invalid IL or missing references)
		//IL_206b: Expected O, but got Unknown
		//IL_2066: Unknown result type (might be due to invalid IL or missing references)
		//IL_2070: Expected O, but got Unknown
		//IL_2075: Expected O, but got Unknown
		//IL_2082: Unknown result type (might be due to invalid IL or missing references)
		//IL_2087: Unknown result type (might be due to invalid IL or missing references)
		//IL_2099: Unknown result type (might be due to invalid IL or missing references)
		//IL_20a3: Expected O, but got Unknown
		//IL_20a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_20b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_20bc: Expected O, but got Unknown
		//IL_20b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_20c1: Expected O, but got Unknown
		//IL_20c6: Expected O, but got Unknown
		//IL_2138: Unknown result type (might be due to invalid IL or missing references)
		//IL_2142: Expected O, but got Unknown
		//IL_2187: Unknown result type (might be due to invalid IL or missing references)
		//IL_218c: Unknown result type (might be due to invalid IL or missing references)
		//IL_2197: Unknown result type (might be due to invalid IL or missing references)
		//IL_219c: Unknown result type (might be due to invalid IL or missing references)
		//IL_2220: Unknown result type (might be due to invalid IL or missing references)
		//IL_2225: Unknown result type (might be due to invalid IL or missing references)
		//IL_2228: Expected O, but got Unknown
		//IL_222d: Expected O, but got Unknown
		//IL_222d: Unknown result type (might be due to invalid IL or missing references)
		//IL_223f: Unknown result type (might be due to invalid IL or missing references)
		//IL_224e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2258: Expected O, but got Unknown
		//IL_2253: Unknown result type (might be due to invalid IL or missing references)
		//IL_225d: Expected O, but got Unknown
		//IL_2262: Expected O, but got Unknown
		//IL_2279: Unknown result type (might be due to invalid IL or missing references)
		//IL_227e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2289: Unknown result type (might be due to invalid IL or missing references)
		//IL_228e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2312: Unknown result type (might be due to invalid IL or missing references)
		//IL_2317: Unknown result type (might be due to invalid IL or missing references)
		//IL_231a: Expected O, but got Unknown
		//IL_231f: Expected O, but got Unknown
		//IL_231f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2331: Unknown result type (might be due to invalid IL or missing references)
		//IL_2340: Unknown result type (might be due to invalid IL or missing references)
		//IL_234a: Expected O, but got Unknown
		//IL_2345: Unknown result type (might be due to invalid IL or missing references)
		//IL_234f: Expected O, but got Unknown
		//IL_2354: Expected O, but got Unknown
		//IL_2361: Unknown result type (might be due to invalid IL or missing references)
		//IL_2366: Unknown result type (might be due to invalid IL or missing references)
		//IL_2378: Unknown result type (might be due to invalid IL or missing references)
		//IL_2382: Expected O, but got Unknown
		//IL_2382: Unknown result type (might be due to invalid IL or missing references)
		//IL_2391: Unknown result type (might be due to invalid IL or missing references)
		//IL_239b: Expected O, but got Unknown
		//IL_2396: Unknown result type (might be due to invalid IL or missing references)
		//IL_23a0: Expected O, but got Unknown
		//IL_23a5: Expected O, but got Unknown
		//IL_2417: Unknown result type (might be due to invalid IL or missing references)
		//IL_2421: Expected O, but got Unknown
		//IL_2466: Unknown result type (might be due to invalid IL or missing references)
		//IL_246b: Unknown result type (might be due to invalid IL or missing references)
		//IL_2476: Unknown result type (might be due to invalid IL or missing references)
		//IL_247b: Unknown result type (might be due to invalid IL or missing references)
		//IL_24ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_2504: Unknown result type (might be due to invalid IL or missing references)
		//IL_2507: Expected O, but got Unknown
		//IL_250c: Expected O, but got Unknown
		//IL_250c: Unknown result type (might be due to invalid IL or missing references)
		//IL_251e: Unknown result type (might be due to invalid IL or missing references)
		//IL_252d: Unknown result type (might be due to invalid IL or missing references)
		//IL_2537: Expected O, but got Unknown
		//IL_2532: Unknown result type (might be due to invalid IL or missing references)
		//IL_253c: Expected O, but got Unknown
		//IL_2541: Expected O, but got Unknown
		//IL_2558: Unknown result type (might be due to invalid IL or missing references)
		//IL_255d: Unknown result type (might be due to invalid IL or missing references)
		//IL_2568: Unknown result type (might be due to invalid IL or missing references)
		//IL_256d: Unknown result type (might be due to invalid IL or missing references)
		//IL_25f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_25f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_25f9: Expected O, but got Unknown
		//IL_25fe: Expected O, but got Unknown
		//IL_25fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_2610: Unknown result type (might be due to invalid IL or missing references)
		//IL_261f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2629: Expected O, but got Unknown
		//IL_2624: Unknown result type (might be due to invalid IL or missing references)
		//IL_262e: Expected O, but got Unknown
		//IL_2633: Expected O, but got Unknown
		//IL_2640: Unknown result type (might be due to invalid IL or missing references)
		//IL_2645: Unknown result type (might be due to invalid IL or missing references)
		//IL_2657: Unknown result type (might be due to invalid IL or missing references)
		//IL_2661: Expected O, but got Unknown
		//IL_2661: Unknown result type (might be due to invalid IL or missing references)
		//IL_2670: Unknown result type (might be due to invalid IL or missing references)
		//IL_267a: Expected O, but got Unknown
		//IL_2675: Unknown result type (might be due to invalid IL or missing references)
		//IL_267f: Expected O, but got Unknown
		//IL_2684: Expected O, but got Unknown
		//IL_26f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_2700: Expected O, but got Unknown
		//IL_2745: Unknown result type (might be due to invalid IL or missing references)
		//IL_274a: Unknown result type (might be due to invalid IL or missing references)
		//IL_2755: Unknown result type (might be due to invalid IL or missing references)
		//IL_275a: Unknown result type (might be due to invalid IL or missing references)
		//IL_27de: Unknown result type (might be due to invalid IL or missing references)
		//IL_27e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_27e6: Expected O, but got Unknown
		//IL_27eb: Expected O, but got Unknown
		//IL_27eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_27fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_280c: Unknown result type (might be due to invalid IL or missing references)
		//IL_2816: Expected O, but got Unknown
		//IL_2811: Unknown result type (might be due to invalid IL or missing references)
		//IL_281b: Expected O, but got Unknown
		//IL_2820: Expected O, but got Unknown
		//IL_2837: Unknown result type (might be due to invalid IL or missing references)
		//IL_283c: Unknown result type (might be due to invalid IL or missing references)
		//IL_2847: Unknown result type (might be due to invalid IL or missing references)
		//IL_284c: Unknown result type (might be due to invalid IL or missing references)
		//IL_28d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_28d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_28d8: Expected O, but got Unknown
		//IL_28dd: Expected O, but got Unknown
		//IL_28dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_28ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_28fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_2908: Expected O, but got Unknown
		//IL_2903: Unknown result type (might be due to invalid IL or missing references)
		//IL_290d: Expected O, but got Unknown
		//IL_2912: Expected O, but got Unknown
		//IL_291f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2924: Unknown result type (might be due to invalid IL or missing references)
		//IL_2936: Unknown result type (might be due to invalid IL or missing references)
		//IL_2940: Expected O, but got Unknown
		//IL_2940: Unknown result type (might be due to invalid IL or missing references)
		//IL_294f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2959: Expected O, but got Unknown
		//IL_2954: Unknown result type (might be due to invalid IL or missing references)
		//IL_295e: Expected O, but got Unknown
		//IL_2963: Expected O, but got Unknown
		//IL_29b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_29bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_29c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_29cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a18: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a1d: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a20: Expected O, but got Unknown
		//IL_2a25: Expected O, but got Unknown
		//IL_2a25: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a37: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a46: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a50: Expected O, but got Unknown
		//IL_2a4b: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a55: Expected O, but got Unknown
		//IL_2a5a: Expected O, but got Unknown
		//IL_2ab2: Unknown result type (might be due to invalid IL or missing references)
		//IL_2b24: Unknown result type (might be due to invalid IL or missing references)
		//IL_2b29: Unknown result type (might be due to invalid IL or missing references)
		//IL_2b34: Unknown result type (might be due to invalid IL or missing references)
		//IL_2b39: Unknown result type (might be due to invalid IL or missing references)
		//IL_2bb2: Unknown result type (might be due to invalid IL or missing references)
		//IL_2bb7: Unknown result type (might be due to invalid IL or missing references)
		//IL_2bba: Expected O, but got Unknown
		//IL_2bbf: Expected O, but got Unknown
		//IL_2bbf: Unknown result type (might be due to invalid IL or missing references)
		//IL_2bd1: Unknown result type (might be due to invalid IL or missing references)
		//IL_2be0: Unknown result type (might be due to invalid IL or missing references)
		//IL_2bea: Expected O, but got Unknown
		//IL_2be5: Unknown result type (might be due to invalid IL or missing references)
		//IL_2bef: Expected O, but got Unknown
		//IL_2bf4: Expected O, but got Unknown
		//IL_2c0b: Unknown result type (might be due to invalid IL or missing references)
		//IL_2c10: Unknown result type (might be due to invalid IL or missing references)
		//IL_2c1b: Unknown result type (might be due to invalid IL or missing references)
		//IL_2c20: Unknown result type (might be due to invalid IL or missing references)
		//IL_2c99: Unknown result type (might be due to invalid IL or missing references)
		//IL_2c9e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ca1: Expected O, but got Unknown
		//IL_2ca6: Expected O, but got Unknown
		//IL_2ca6: Unknown result type (might be due to invalid IL or missing references)
		//IL_2cb8: Unknown result type (might be due to invalid IL or missing references)
		//IL_2cc7: Unknown result type (might be due to invalid IL or missing references)
		//IL_2cd1: Expected O, but got Unknown
		//IL_2ccc: Unknown result type (might be due to invalid IL or missing references)
		//IL_2cd6: Expected O, but got Unknown
		//IL_2cdb: Expected O, but got Unknown
		//IL_2ce8: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ced: Unknown result type (might be due to invalid IL or missing references)
		//IL_2cff: Unknown result type (might be due to invalid IL or missing references)
		//IL_2d09: Expected O, but got Unknown
		//IL_2d09: Unknown result type (might be due to invalid IL or missing references)
		//IL_2d18: Unknown result type (might be due to invalid IL or missing references)
		//IL_2d22: Expected O, but got Unknown
		//IL_2d1d: Unknown result type (might be due to invalid IL or missing references)
		//IL_2d27: Expected O, but got Unknown
		//IL_2d2c: Expected O, but got Unknown
		//IL_2d81: Unknown result type (might be due to invalid IL or missing references)
		//IL_2d86: Unknown result type (might be due to invalid IL or missing references)
		//IL_2d91: Unknown result type (might be due to invalid IL or missing references)
		//IL_2d96: Unknown result type (might be due to invalid IL or missing references)
		//IL_2df6: Unknown result type (might be due to invalid IL or missing references)
		//IL_2dfb: Unknown result type (might be due to invalid IL or missing references)
		//IL_2dfe: Expected O, but got Unknown
		//IL_2e03: Expected O, but got Unknown
		//IL_2e03: Unknown result type (might be due to invalid IL or missing references)
		//IL_2e15: Unknown result type (might be due to invalid IL or missing references)
		//IL_2e24: Unknown result type (might be due to invalid IL or missing references)
		//IL_2e2e: Expected O, but got Unknown
		//IL_2e29: Unknown result type (might be due to invalid IL or missing references)
		//IL_2e33: Expected O, but got Unknown
		//IL_2e38: Expected O, but got Unknown
		//IL_2ee3: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ee8: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ef3: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ef8: Unknown result type (might be due to invalid IL or missing references)
		//IL_2f58: Unknown result type (might be due to invalid IL or missing references)
		//IL_2f5d: Unknown result type (might be due to invalid IL or missing references)
		//IL_2f60: Expected O, but got Unknown
		//IL_2f65: Expected O, but got Unknown
		//IL_2f65: Unknown result type (might be due to invalid IL or missing references)
		//IL_2f77: Unknown result type (might be due to invalid IL or missing references)
		//IL_2f86: Unknown result type (might be due to invalid IL or missing references)
		//IL_2f90: Expected O, but got Unknown
		//IL_2f8b: Unknown result type (might be due to invalid IL or missing references)
		//IL_2f95: Expected O, but got Unknown
		//IL_2f9a: Expected O, but got Unknown
		//IL_305c: Unknown result type (might be due to invalid IL or missing references)
		//IL_3077: Unknown result type (might be due to invalid IL or missing references)
		//IL_307c: Unknown result type (might be due to invalid IL or missing references)
		//IL_3087: Unknown result type (might be due to invalid IL or missing references)
		//IL_308c: Unknown result type (might be due to invalid IL or missing references)
		//IL_30f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_30f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_30f9: Expected O, but got Unknown
		//IL_30fe: Expected O, but got Unknown
		//IL_30fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_3110: Unknown result type (might be due to invalid IL or missing references)
		//IL_311f: Unknown result type (might be due to invalid IL or missing references)
		//IL_3129: Expected O, but got Unknown
		//IL_3124: Unknown result type (might be due to invalid IL or missing references)
		//IL_312e: Expected O, but got Unknown
		//IL_3133: Expected O, but got Unknown
		//IL_314a: Unknown result type (might be due to invalid IL or missing references)
		//IL_314f: Unknown result type (might be due to invalid IL or missing references)
		//IL_315a: Unknown result type (might be due to invalid IL or missing references)
		//IL_315f: Unknown result type (might be due to invalid IL or missing references)
		//IL_31c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_31c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_31cc: Expected O, but got Unknown
		//IL_31d1: Expected O, but got Unknown
		//IL_31d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_31e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_31f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_31fc: Expected O, but got Unknown
		//IL_31f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_3201: Expected O, but got Unknown
		//IL_3206: Expected O, but got Unknown
		//IL_3213: Unknown result type (might be due to invalid IL or missing references)
		//IL_3218: Unknown result type (might be due to invalid IL or missing references)
		//IL_322a: Unknown result type (might be due to invalid IL or missing references)
		//IL_3234: Expected O, but got Unknown
		//IL_3234: Unknown result type (might be due to invalid IL or missing references)
		//IL_3243: Unknown result type (might be due to invalid IL or missing references)
		//IL_324d: Expected O, but got Unknown
		//IL_3248: Unknown result type (might be due to invalid IL or missing references)
		//IL_3252: Expected O, but got Unknown
		//IL_3257: Expected O, but got Unknown
		StaticResourceExtension val = new StaticResourceExtension();
		StaticResourceExtension val2 = new StaticResourceExtension();
		AppThemeBindingExtension val3 = new AppThemeBindingExtension();
		StaticResourceExtension val4 = new StaticResourceExtension();
		Label val5 = new Label();
		Frame val6 = new Frame();
		StaticResourceExtension val7 = new StaticResourceExtension();
		StaticResourceExtension val8 = new StaticResourceExtension();
		AppThemeBindingExtension val9 = new AppThemeBindingExtension();
		Label val10 = new Label();
		StaticResourceExtension val11 = new StaticResourceExtension();
		StaticResourceExtension val12 = new StaticResourceExtension();
		AppThemeBindingExtension val13 = new AppThemeBindingExtension();
		Label val14 = new Label();
		StaticResourceExtension val15 = new StaticResourceExtension();
		StaticResourceExtension val16 = new StaticResourceExtension();
		AppThemeBindingExtension val17 = new AppThemeBindingExtension();
		Label val18 = new Label();
		StaticResourceExtension val19 = new StaticResourceExtension();
		StaticResourceExtension val20 = new StaticResourceExtension();
		AppThemeBindingExtension val21 = new AppThemeBindingExtension();
		BoxView val22 = new BoxView();
		StaticResourceExtension val23 = new StaticResourceExtension();
		StaticResourceExtension val24 = new StaticResourceExtension();
		StaticResourceExtension val25 = new StaticResourceExtension();
		AppThemeBindingExtension val26 = new AppThemeBindingExtension();
		Label val27 = new Label();
		StaticResourceExtension val28 = new StaticResourceExtension();
		StaticResourceExtension val29 = new StaticResourceExtension();
		AppThemeBindingExtension val30 = new AppThemeBindingExtension();
		Label val31 = new Label();
		VerticalStackLayout val32 = new VerticalStackLayout();
		Frame val33 = new Frame();
		StaticResourceExtension val34 = new StaticResourceExtension();
		StaticResourceExtension val35 = new StaticResourceExtension();
		StaticResourceExtension val36 = new StaticResourceExtension();
		AppThemeBindingExtension val37 = new AppThemeBindingExtension();
		Label val38 = new Label();
		Label val39 = new Label();
		StaticResourceExtension val40 = new StaticResourceExtension();
		StaticResourceExtension val41 = new StaticResourceExtension();
		AppThemeBindingExtension val42 = new AppThemeBindingExtension();
		Label val43 = new Label();
		HorizontalStackLayout val44 = new HorizontalStackLayout();
		Label val45 = new Label();
		StaticResourceExtension val46 = new StaticResourceExtension();
		StaticResourceExtension val47 = new StaticResourceExtension();
		AppThemeBindingExtension val48 = new AppThemeBindingExtension();
		Label val49 = new Label();
		HorizontalStackLayout val50 = new HorizontalStackLayout();
		Label val51 = new Label();
		StaticResourceExtension val52 = new StaticResourceExtension();
		StaticResourceExtension val53 = new StaticResourceExtension();
		AppThemeBindingExtension val54 = new AppThemeBindingExtension();
		Label val55 = new Label();
		HorizontalStackLayout val56 = new HorizontalStackLayout();
		Label val57 = new Label();
		StaticResourceExtension val58 = new StaticResourceExtension();
		StaticResourceExtension val59 = new StaticResourceExtension();
		AppThemeBindingExtension val60 = new AppThemeBindingExtension();
		Label val61 = new Label();
		HorizontalStackLayout val62 = new HorizontalStackLayout();
		Label val63 = new Label();
		StaticResourceExtension val64 = new StaticResourceExtension();
		StaticResourceExtension val65 = new StaticResourceExtension();
		AppThemeBindingExtension val66 = new AppThemeBindingExtension();
		Label val67 = new Label();
		HorizontalStackLayout val68 = new HorizontalStackLayout();
		VerticalStackLayout val69 = new VerticalStackLayout();
		Frame val70 = new Frame();
		StaticResourceExtension val71 = new StaticResourceExtension();
		StaticResourceExtension val72 = new StaticResourceExtension();
		StaticResourceExtension val73 = new StaticResourceExtension();
		AppThemeBindingExtension val74 = new AppThemeBindingExtension();
		Label val75 = new Label();
		StaticResourceExtension val76 = new StaticResourceExtension();
		TapGestureRecognizer val77 = new TapGestureRecognizer();
		Label val78 = new Label();
		StaticResourceExtension val79 = new StaticResourceExtension();
		TapGestureRecognizer val80 = new TapGestureRecognizer();
		Label val81 = new Label();
		VerticalStackLayout val82 = new VerticalStackLayout();
		Frame val83 = new Frame();
		StaticResourceExtension val84 = new StaticResourceExtension();
		StaticResourceExtension val85 = new StaticResourceExtension();
		AppThemeBindingExtension val86 = new AppThemeBindingExtension();
		Label val87 = new Label();
		VerticalStackLayout val88 = new VerticalStackLayout();
		ScrollView val89 = new ScrollView();
		AboutPage aboutPage;
		NameScope val90 = (NameScope)(((object)NameScope.GetNameScope((BindableObject)(object)(aboutPage = this))) ?? ((object)new NameScope()));
		NameScope.SetNameScope((BindableObject)(object)aboutPage, (INameScope)(object)val90);
		((Element)val89).transientNamescope = (INameScope)(object)val90;
		((Element)val88).transientNamescope = (INameScope)(object)val90;
		((Element)val6).transientNamescope = (INameScope)(object)val90;
		((Element)val5).transientNamescope = (INameScope)(object)val90;
		((Element)val10).transientNamescope = (INameScope)(object)val90;
		((Element)val14).transientNamescope = (INameScope)(object)val90;
		((Element)val18).transientNamescope = (INameScope)(object)val90;
		((Element)val22).transientNamescope = (INameScope)(object)val90;
		((Element)val33).transientNamescope = (INameScope)(object)val90;
		((Element)val32).transientNamescope = (INameScope)(object)val90;
		((Element)val27).transientNamescope = (INameScope)(object)val90;
		((Element)val31).transientNamescope = (INameScope)(object)val90;
		((Element)val70).transientNamescope = (INameScope)(object)val90;
		((Element)val69).transientNamescope = (INameScope)(object)val90;
		((Element)val38).transientNamescope = (INameScope)(object)val90;
		((Element)val44).transientNamescope = (INameScope)(object)val90;
		((Element)val39).transientNamescope = (INameScope)(object)val90;
		((Element)val43).transientNamescope = (INameScope)(object)val90;
		((Element)val50).transientNamescope = (INameScope)(object)val90;
		((Element)val45).transientNamescope = (INameScope)(object)val90;
		((Element)val49).transientNamescope = (INameScope)(object)val90;
		((Element)val56).transientNamescope = (INameScope)(object)val90;
		((Element)val51).transientNamescope = (INameScope)(object)val90;
		((Element)val55).transientNamescope = (INameScope)(object)val90;
		((Element)val62).transientNamescope = (INameScope)(object)val90;
		((Element)val57).transientNamescope = (INameScope)(object)val90;
		((Element)val61).transientNamescope = (INameScope)(object)val90;
		((Element)val68).transientNamescope = (INameScope)(object)val90;
		((Element)val63).transientNamescope = (INameScope)(object)val90;
		((Element)val67).transientNamescope = (INameScope)(object)val90;
		((Element)val83).transientNamescope = (INameScope)(object)val90;
		((Element)val82).transientNamescope = (INameScope)(object)val90;
		((Element)val75).transientNamescope = (INameScope)(object)val90;
		((Element)val78).transientNamescope = (INameScope)(object)val90;
		((INameScope)val90).RegisterName("WebsiteLink", (object)val78);
		if (((Element)val78).StyleId == null)
		{
			((Element)val78).StyleId = "WebsiteLink";
		}
		((Element)val77).transientNamescope = (INameScope)(object)val90;
		((Element)val81).transientNamescope = (INameScope)(object)val90;
		((INameScope)val90).RegisterName("GitHubLink", (object)val81);
		if (((Element)val81).StyleId == null)
		{
			((Element)val81).StyleId = "GitHubLink";
		}
		((Element)val80).transientNamescope = (INameScope)(object)val90;
		((Element)val87).transientNamescope = (INameScope)(object)val90;
		WebsiteLink = val78;
		GitHubLink = val81;
		((BindableObject)aboutPage).SetValue(Page.TitleProperty, (object)"About");
		val.Key = "PageBackgroundLight";
		StaticResourceExtension val91 = new StaticResourceExtension
		{
			Key = "PageBackgroundLight"
		};
		XamlServiceProvider val92 = new XamlServiceProvider();
		Type? typeFromHandle = typeof(IProvideValueTarget);
		object[] array = new object[0 + 2];
		array[0] = val3;
		array[1] = aboutPage;
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
		array2[1] = aboutPage;
		SimpleValueTargetProvider val96 = new SimpleValueTargetProvider(array2, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Dark"), (INameScope[])(object)new NameScope[3] { val90, val90, val90 }, false);
		object obj2 = (object)val96;
		val95.Add(typeFromHandle2, (object)val96);
		val95.Add(typeof(IReferenceProvider), obj2);
		val95.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(6, 14)));
		object dark = val94.ProvideValue((IServiceProvider)val95);
		val3.Dark = dark;
		XamlServiceProvider val97 = new XamlServiceProvider();
		val97.Add(typeof(IProvideValueTarget), (object)new ValueTargetProvider((object)aboutPage, (object)VisualElement.BackgroundColorProperty));
		val97.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(6, 14)));
		BindingBase val98 = ((IMarkupExtension<BindingBase>)(object)val3).ProvideValue((IServiceProvider)val97);
		((BindableObject)aboutPage).SetBinding(VisualElement.BackgroundColorProperty, val98);
		((BindableObject)val88).SetValue(Layout.PaddingProperty, (object)new Thickness(30.0));
		((BindableObject)val88).SetValue(StackBase.SpacingProperty, (object)20.0);
		((BindableObject)val6).SetValue(Frame.CornerRadiusProperty, (object)50f);
		((BindableObject)val6).SetValue(VisualElement.WidthRequestProperty, (object)100.0);
		((BindableObject)val6).SetValue(VisualElement.HeightRequestProperty, (object)100.0);
		((BindableObject)val6).SetValue(View.HorizontalOptionsProperty, (object)LayoutOptions.Center);
		((BindableObject)val6).SetValue(Layout.PaddingProperty, (object)new Thickness(0.0));
		val4.Key = "PrimaryColor";
		StaticResourceExtension val99 = new StaticResourceExtension
		{
			Key = "PrimaryColor"
		};
		XamlServiceProvider val100 = new XamlServiceProvider();
		Type? typeFromHandle3 = typeof(IProvideValueTarget);
		object[] array3 = new object[0 + 4];
		array3[0] = val6;
		array3[1] = val88;
		array3[2] = val89;
		array3[3] = aboutPage;
		SimpleValueTargetProvider val101 = new SimpleValueTargetProvider(array3, (object)VisualElement.BackgroundColorProperty, (INameScope[])(object)new NameScope[5] { val90, val90, val90, val90, val90 }, false);
		object obj3 = (object)val101;
		val100.Add(typeFromHandle3, (object)val101);
		val100.Add(typeof(IReferenceProvider), obj3);
		val100.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(13, 20)));
		object obj4 = val99.ProvideValue((IServiceProvider)val100);
		((BindableObject)val6).SetValue(VisualElement.BackgroundColorProperty, (obj4 == null || !typeof(BindingBase).IsAssignableFrom(obj4.GetType())) ? obj4 : obj4);
		((BindableObject)val5).SetValue(Label.TextProperty, (object)"OM");
		((BindableObject)val5).SetValue(Label.FontSizeProperty, (object)36.0);
		((BindableObject)val5).SetValue(Label.FontAttributesProperty, (object)(FontAttributes)1);
		((BindableObject)val5).SetValue(Label.TextColorProperty, (object)Colors.White);
		((BindableObject)val5).SetValue(View.HorizontalOptionsProperty, (object)LayoutOptions.Center);
		((BindableObject)val5).SetValue(View.VerticalOptionsProperty, (object)LayoutOptions.Center);
		((BindableObject)val6).SetValue(ContentView.ContentProperty, (object)val5);
		((Layout)val88).Children.Add((IView)(object)val6);
		((BindableObject)val10).SetValue(Label.TextProperty, (object)"OpenMaui Linux");
		((BindableObject)val10).SetValue(Label.FontSizeProperty, (object)28.0);
		((BindableObject)val10).SetValue(Label.FontAttributesProperty, (object)(FontAttributes)1);
		((BindableObject)val10).SetValue(View.HorizontalOptionsProperty, (object)LayoutOptions.Center);
		val7.Key = "TextPrimaryLight";
		StaticResourceExtension val102 = new StaticResourceExtension
		{
			Key = "TextPrimaryLight"
		};
		XamlServiceProvider val103 = new XamlServiceProvider();
		Type? typeFromHandle4 = typeof(IProvideValueTarget);
		object[] array4 = new object[0 + 5];
		array4[0] = val9;
		array4[1] = val10;
		array4[2] = val88;
		array4[3] = val89;
		array4[4] = aboutPage;
		SimpleValueTargetProvider val104 = new SimpleValueTargetProvider(array4, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Light"), (INameScope[])(object)new NameScope[6] { val90, val90, val90, val90, val90, val90 }, false);
		object obj5 = (object)val104;
		val103.Add(typeFromHandle4, (object)val104);
		val103.Add(typeof(IReferenceProvider), obj5);
		val103.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(19, 20)));
		object light2 = val102.ProvideValue((IServiceProvider)val103);
		val9.Light = light2;
		val8.Key = "TextPrimaryDark";
		StaticResourceExtension val105 = new StaticResourceExtension
		{
			Key = "TextPrimaryDark"
		};
		XamlServiceProvider val106 = new XamlServiceProvider();
		Type? typeFromHandle5 = typeof(IProvideValueTarget);
		object[] array5 = new object[0 + 5];
		array5[0] = val9;
		array5[1] = val10;
		array5[2] = val88;
		array5[3] = val89;
		array5[4] = aboutPage;
		SimpleValueTargetProvider val107 = new SimpleValueTargetProvider(array5, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Dark"), (INameScope[])(object)new NameScope[6] { val90, val90, val90, val90, val90, val90 }, false);
		object obj6 = (object)val107;
		val106.Add(typeFromHandle5, (object)val107);
		val106.Add(typeof(IReferenceProvider), obj6);
		val106.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(19, 20)));
		object dark2 = val105.ProvideValue((IServiceProvider)val106);
		val9.Dark = dark2;
		XamlServiceProvider val108 = new XamlServiceProvider();
		val108.Add(typeof(IProvideValueTarget), (object)new ValueTargetProvider((object)val10, (object)Label.TextColorProperty));
		val108.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(19, 20)));
		BindingBase val109 = ((IMarkupExtension<BindingBase>)(object)val9).ProvideValue((IServiceProvider)val108);
		((BindableObject)val10).SetBinding(Label.TextColorProperty, val109);
		((Layout)val88).Children.Add((IView)(object)val10);
		((BindableObject)val14).SetValue(Label.TextProperty, (object)"Controls Demo");
		((BindableObject)val14).SetValue(Label.FontSizeProperty, (object)16.0);
		((BindableObject)val14).SetValue(View.HorizontalOptionsProperty, (object)LayoutOptions.Center);
		val11.Key = "TextSecondaryLight";
		StaticResourceExtension val110 = new StaticResourceExtension
		{
			Key = "TextSecondaryLight"
		};
		XamlServiceProvider val111 = new XamlServiceProvider();
		Type? typeFromHandle6 = typeof(IProvideValueTarget);
		object[] array6 = new object[0 + 5];
		array6[0] = val13;
		array6[1] = val14;
		array6[2] = val88;
		array6[3] = val89;
		array6[4] = aboutPage;
		SimpleValueTargetProvider val112 = new SimpleValueTargetProvider(array6, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Light"), (INameScope[])(object)new NameScope[6] { val90, val90, val90, val90, val90, val90 }, false);
		object obj7 = (object)val112;
		val111.Add(typeFromHandle6, (object)val112);
		val111.Add(typeof(IReferenceProvider), obj7);
		val111.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(21, 20)));
		object light3 = val110.ProvideValue((IServiceProvider)val111);
		val13.Light = light3;
		val12.Key = "TextSecondaryDark";
		StaticResourceExtension val113 = new StaticResourceExtension
		{
			Key = "TextSecondaryDark"
		};
		XamlServiceProvider val114 = new XamlServiceProvider();
		Type? typeFromHandle7 = typeof(IProvideValueTarget);
		object[] array7 = new object[0 + 5];
		array7[0] = val13;
		array7[1] = val14;
		array7[2] = val88;
		array7[3] = val89;
		array7[4] = aboutPage;
		SimpleValueTargetProvider val115 = new SimpleValueTargetProvider(array7, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Dark"), (INameScope[])(object)new NameScope[6] { val90, val90, val90, val90, val90, val90 }, false);
		object obj8 = (object)val115;
		val114.Add(typeFromHandle7, (object)val115);
		val114.Add(typeof(IReferenceProvider), obj8);
		val114.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(21, 20)));
		object dark3 = val113.ProvideValue((IServiceProvider)val114);
		val13.Dark = dark3;
		XamlServiceProvider val116 = new XamlServiceProvider();
		val116.Add(typeof(IProvideValueTarget), (object)new ValueTargetProvider((object)val14, (object)Label.TextColorProperty));
		val116.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(21, 20)));
		BindingBase val117 = ((IMarkupExtension<BindingBase>)(object)val13).ProvideValue((IServiceProvider)val116);
		((BindableObject)val14).SetBinding(Label.TextColorProperty, val117);
		((Layout)val88).Children.Add((IView)(object)val14);
		((BindableObject)val18).SetValue(Label.TextProperty, (object)"Version 1.0.0");
		((BindableObject)val18).SetValue(Label.FontSizeProperty, (object)14.0);
		((BindableObject)val18).SetValue(View.HorizontalOptionsProperty, (object)LayoutOptions.Center);
		val15.Key = "TextSecondaryLight";
		StaticResourceExtension val118 = new StaticResourceExtension
		{
			Key = "TextSecondaryLight"
		};
		XamlServiceProvider val119 = new XamlServiceProvider();
		Type? typeFromHandle8 = typeof(IProvideValueTarget);
		object[] array8 = new object[0 + 5];
		array8[0] = val17;
		array8[1] = val18;
		array8[2] = val88;
		array8[3] = val89;
		array8[4] = aboutPage;
		SimpleValueTargetProvider val120 = new SimpleValueTargetProvider(array8, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Light"), (INameScope[])(object)new NameScope[6] { val90, val90, val90, val90, val90, val90 }, false);
		object obj9 = (object)val120;
		val119.Add(typeFromHandle8, (object)val120);
		val119.Add(typeof(IReferenceProvider), obj9);
		val119.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(23, 20)));
		object light4 = val118.ProvideValue((IServiceProvider)val119);
		val17.Light = light4;
		val16.Key = "TextSecondaryDark";
		StaticResourceExtension val121 = new StaticResourceExtension
		{
			Key = "TextSecondaryDark"
		};
		XamlServiceProvider val122 = new XamlServiceProvider();
		Type? typeFromHandle9 = typeof(IProvideValueTarget);
		object[] array9 = new object[0 + 5];
		array9[0] = val17;
		array9[1] = val18;
		array9[2] = val88;
		array9[3] = val89;
		array9[4] = aboutPage;
		SimpleValueTargetProvider val123 = new SimpleValueTargetProvider(array9, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Dark"), (INameScope[])(object)new NameScope[6] { val90, val90, val90, val90, val90, val90 }, false);
		object obj10 = (object)val123;
		val122.Add(typeFromHandle9, (object)val123);
		val122.Add(typeof(IReferenceProvider), obj10);
		val122.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(23, 20)));
		object dark4 = val121.ProvideValue((IServiceProvider)val122);
		val17.Dark = dark4;
		XamlServiceProvider val124 = new XamlServiceProvider();
		val124.Add(typeof(IProvideValueTarget), (object)new ValueTargetProvider((object)val18, (object)Label.TextColorProperty));
		val124.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(23, 20)));
		BindingBase val125 = ((IMarkupExtension<BindingBase>)(object)val17).ProvideValue((IServiceProvider)val124);
		((BindableObject)val18).SetBinding(Label.TextColorProperty, val125);
		((Layout)val88).Children.Add((IView)(object)val18);
		((BindableObject)val22).SetValue(VisualElement.HeightRequestProperty, (object)1.0);
		((BindableObject)val22).SetValue(View.MarginProperty, (object)new Thickness(0.0, 10.0));
		val19.Key = "BorderLight";
		StaticResourceExtension val126 = new StaticResourceExtension
		{
			Key = "BorderLight"
		};
		XamlServiceProvider val127 = new XamlServiceProvider();
		Type? typeFromHandle10 = typeof(IProvideValueTarget);
		object[] array10 = new object[0 + 5];
		array10[0] = val21;
		array10[1] = val22;
		array10[2] = val88;
		array10[3] = val89;
		array10[4] = aboutPage;
		SimpleValueTargetProvider val128 = new SimpleValueTargetProvider(array10, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Light"), (INameScope[])(object)new NameScope[6] { val90, val90, val90, val90, val90, val90 }, false);
		object obj11 = (object)val128;
		val127.Add(typeFromHandle10, (object)val128);
		val127.Add(typeof(IReferenceProvider), obj11);
		val127.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(26, 22)));
		object light5 = val126.ProvideValue((IServiceProvider)val127);
		val21.Light = light5;
		val20.Key = "BorderDark";
		StaticResourceExtension val129 = new StaticResourceExtension
		{
			Key = "BorderDark"
		};
		XamlServiceProvider val130 = new XamlServiceProvider();
		Type? typeFromHandle11 = typeof(IProvideValueTarget);
		object[] array11 = new object[0 + 5];
		array11[0] = val21;
		array11[1] = val22;
		array11[2] = val88;
		array11[3] = val89;
		array11[4] = aboutPage;
		SimpleValueTargetProvider val131 = new SimpleValueTargetProvider(array11, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Dark"), (INameScope[])(object)new NameScope[6] { val90, val90, val90, val90, val90, val90 }, false);
		object obj12 = (object)val131;
		val130.Add(typeFromHandle11, (object)val131);
		val130.Add(typeof(IReferenceProvider), obj12);
		val130.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(26, 22)));
		object dark5 = val129.ProvideValue((IServiceProvider)val130);
		val21.Dark = dark5;
		XamlServiceProvider val132 = new XamlServiceProvider();
		val132.Add(typeof(IProvideValueTarget), (object)new ValueTargetProvider((object)val22, (object)BoxView.ColorProperty));
		val132.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(26, 22)));
		BindingBase val133 = ((IMarkupExtension<BindingBase>)(object)val21).ProvideValue((IServiceProvider)val132);
		((BindableObject)val22).SetBinding(BoxView.ColorProperty, val133);
		((Layout)val88).Children.Add((IView)(object)val22);
		val23.Key = "ThemedFrame";
		StaticResourceExtension val134 = new StaticResourceExtension
		{
			Key = "ThemedFrame"
		};
		XamlServiceProvider val135 = new XamlServiceProvider();
		Type? typeFromHandle12 = typeof(IProvideValueTarget);
		object[] array12 = new object[0 + 4];
		array12[0] = val33;
		array12[1] = val88;
		array12[2] = val89;
		array12[3] = aboutPage;
		SimpleValueTargetProvider val136 = new SimpleValueTargetProvider(array12, (object)VisualElement.StyleProperty, (INameScope[])(object)new NameScope[5] { val90, val90, val90, val90, val90 }, false);
		object obj13 = (object)val136;
		val135.Add(typeFromHandle12, (object)val136);
		val135.Add(typeof(IReferenceProvider), obj13);
		val135.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(29, 20)));
		object obj14 = val134.ProvideValue((IServiceProvider)val135);
		((BindableObject)val33).SetValue(VisualElement.StyleProperty, (obj14 == null || !typeof(BindingBase).IsAssignableFrom(obj14.GetType())) ? obj14 : obj14);
		((BindableObject)val33).SetValue(Frame.CornerRadiusProperty, (object)8f);
		((BindableObject)val33).SetValue(Layout.PaddingProperty, (object)new Thickness(20.0));
		((BindableObject)val32).SetValue(StackBase.SpacingProperty, (object)10.0);
		((BindableObject)val27).SetValue(Label.TextProperty, (object)"About This App");
		((BindableObject)val27).SetValue(Label.FontSizeProperty, (object)18.0);
		((BindableObject)val27).SetValue(Label.FontAttributesProperty, (object)(FontAttributes)1);
		val24.Key = "TextPrimaryLight";
		StaticResourceExtension val137 = new StaticResourceExtension
		{
			Key = "TextPrimaryLight"
		};
		XamlServiceProvider val138 = new XamlServiceProvider();
		Type? typeFromHandle13 = typeof(IProvideValueTarget);
		object[] array13 = new object[0 + 7];
		array13[0] = val26;
		array13[1] = val27;
		array13[2] = val32;
		array13[3] = val33;
		array13[4] = val88;
		array13[5] = val89;
		array13[6] = aboutPage;
		SimpleValueTargetProvider val139 = new SimpleValueTargetProvider(array13, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Light"), (INameScope[])(object)new NameScope[8] { val90, val90, val90, val90, val90, val90, val90, val90 }, false);
		object obj15 = (object)val139;
		val138.Add(typeFromHandle13, (object)val139);
		val138.Add(typeof(IReferenceProvider), obj15);
		val138.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(32, 28)));
		object light6 = val137.ProvideValue((IServiceProvider)val138);
		val26.Light = light6;
		val25.Key = "TextPrimaryDark";
		StaticResourceExtension val140 = new StaticResourceExtension
		{
			Key = "TextPrimaryDark"
		};
		XamlServiceProvider val141 = new XamlServiceProvider();
		Type? typeFromHandle14 = typeof(IProvideValueTarget);
		object[] array14 = new object[0 + 7];
		array14[0] = val26;
		array14[1] = val27;
		array14[2] = val32;
		array14[3] = val33;
		array14[4] = val88;
		array14[5] = val89;
		array14[6] = aboutPage;
		SimpleValueTargetProvider val142 = new SimpleValueTargetProvider(array14, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Dark"), (INameScope[])(object)new NameScope[8] { val90, val90, val90, val90, val90, val90, val90, val90 }, false);
		object obj16 = (object)val142;
		val141.Add(typeFromHandle14, (object)val142);
		val141.Add(typeof(IReferenceProvider), obj16);
		val141.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(32, 28)));
		object dark6 = val140.ProvideValue((IServiceProvider)val141);
		val26.Dark = dark6;
		XamlServiceProvider val143 = new XamlServiceProvider();
		val143.Add(typeof(IProvideValueTarget), (object)new ValueTargetProvider((object)val27, (object)Label.TextColorProperty));
		val143.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(32, 28)));
		BindingBase val144 = ((IMarkupExtension<BindingBase>)(object)val26).ProvideValue((IServiceProvider)val143);
		((BindableObject)val27).SetBinding(Label.TextColorProperty, val144);
		((Layout)val32).Children.Add((IView)(object)val27);
		((BindableObject)val31).SetValue(Label.TextProperty, (object)"This demo app showcases the capabilities of OpenMaui Linux, a .NET MAUI implementation for Linux desktop using SkiaSharp rendering.");
		((BindableObject)val31).SetValue(Label.FontSizeProperty, (object)14.0);
		((BindableObject)val31).SetValue(Label.LineBreakModeProperty, (object)(LineBreakMode)1);
		val28.Key = "TextPrimaryLight";
		StaticResourceExtension val145 = new StaticResourceExtension
		{
			Key = "TextPrimaryLight"
		};
		XamlServiceProvider val146 = new XamlServiceProvider();
		Type? typeFromHandle15 = typeof(IProvideValueTarget);
		object[] array15 = new object[0 + 7];
		array15[0] = val30;
		array15[1] = val31;
		array15[2] = val32;
		array15[3] = val33;
		array15[4] = val88;
		array15[5] = val89;
		array15[6] = aboutPage;
		SimpleValueTargetProvider val147 = new SimpleValueTargetProvider(array15, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Light"), (INameScope[])(object)new NameScope[8] { val90, val90, val90, val90, val90, val90, val90, val90 }, false);
		object obj17 = (object)val147;
		val146.Add(typeFromHandle15, (object)val147);
		val146.Add(typeof(IReferenceProvider), obj17);
		val146.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(35, 28)));
		object light7 = val145.ProvideValue((IServiceProvider)val146);
		val30.Light = light7;
		val29.Key = "TextPrimaryDark";
		StaticResourceExtension val148 = new StaticResourceExtension
		{
			Key = "TextPrimaryDark"
		};
		XamlServiceProvider val149 = new XamlServiceProvider();
		Type? typeFromHandle16 = typeof(IProvideValueTarget);
		object[] array16 = new object[0 + 7];
		array16[0] = val30;
		array16[1] = val31;
		array16[2] = val32;
		array16[3] = val33;
		array16[4] = val88;
		array16[5] = val89;
		array16[6] = aboutPage;
		SimpleValueTargetProvider val150 = new SimpleValueTargetProvider(array16, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Dark"), (INameScope[])(object)new NameScope[8] { val90, val90, val90, val90, val90, val90, val90, val90 }, false);
		object obj18 = (object)val150;
		val149.Add(typeFromHandle16, (object)val150);
		val149.Add(typeof(IReferenceProvider), obj18);
		val149.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(35, 28)));
		object dark7 = val148.ProvideValue((IServiceProvider)val149);
		val30.Dark = dark7;
		XamlServiceProvider val151 = new XamlServiceProvider();
		val151.Add(typeof(IProvideValueTarget), (object)new ValueTargetProvider((object)val31, (object)Label.TextColorProperty));
		val151.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(35, 28)));
		BindingBase val152 = ((IMarkupExtension<BindingBase>)(object)val30).ProvideValue((IServiceProvider)val151);
		((BindableObject)val31).SetBinding(Label.TextColorProperty, val152);
		((Layout)val32).Children.Add((IView)(object)val31);
		((BindableObject)val33).SetValue(ContentView.ContentProperty, (object)val32);
		((Layout)val88).Children.Add((IView)(object)val33);
		val34.Key = "ThemedFrame";
		StaticResourceExtension val153 = new StaticResourceExtension
		{
			Key = "ThemedFrame"
		};
		XamlServiceProvider val154 = new XamlServiceProvider();
		Type? typeFromHandle17 = typeof(IProvideValueTarget);
		object[] array17 = new object[0 + 4];
		array17[0] = val70;
		array17[1] = val88;
		array17[2] = val89;
		array17[3] = aboutPage;
		SimpleValueTargetProvider val155 = new SimpleValueTargetProvider(array17, (object)VisualElement.StyleProperty, (INameScope[])(object)new NameScope[5] { val90, val90, val90, val90, val90 }, false);
		object obj19 = (object)val155;
		val154.Add(typeFromHandle17, (object)val155);
		val154.Add(typeof(IReferenceProvider), obj19);
		val154.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(40, 20)));
		object obj20 = val153.ProvideValue((IServiceProvider)val154);
		((BindableObject)val70).SetValue(VisualElement.StyleProperty, (obj20 == null || !typeof(BindingBase).IsAssignableFrom(obj20.GetType())) ? obj20 : obj20);
		((BindableObject)val70).SetValue(Frame.CornerRadiusProperty, (object)8f);
		((BindableObject)val70).SetValue(Layout.PaddingProperty, (object)new Thickness(20.0));
		((BindableObject)val69).SetValue(StackBase.SpacingProperty, (object)10.0);
		((BindableObject)val38).SetValue(Label.TextProperty, (object)"Features");
		((BindableObject)val38).SetValue(Label.FontSizeProperty, (object)18.0);
		((BindableObject)val38).SetValue(Label.FontAttributesProperty, (object)(FontAttributes)1);
		val35.Key = "TextPrimaryLight";
		StaticResourceExtension val156 = new StaticResourceExtension
		{
			Key = "TextPrimaryLight"
		};
		XamlServiceProvider val157 = new XamlServiceProvider();
		Type? typeFromHandle18 = typeof(IProvideValueTarget);
		object[] array18 = new object[0 + 7];
		array18[0] = val37;
		array18[1] = val38;
		array18[2] = val69;
		array18[3] = val70;
		array18[4] = val88;
		array18[5] = val89;
		array18[6] = aboutPage;
		SimpleValueTargetProvider val158 = new SimpleValueTargetProvider(array18, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Light"), (INameScope[])(object)new NameScope[8] { val90, val90, val90, val90, val90, val90, val90, val90 }, false);
		object obj21 = (object)val158;
		val157.Add(typeFromHandle18, (object)val158);
		val157.Add(typeof(IReferenceProvider), obj21);
		val157.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(43, 28)));
		object light8 = val156.ProvideValue((IServiceProvider)val157);
		val37.Light = light8;
		val36.Key = "TextPrimaryDark";
		StaticResourceExtension val159 = new StaticResourceExtension
		{
			Key = "TextPrimaryDark"
		};
		XamlServiceProvider val160 = new XamlServiceProvider();
		Type? typeFromHandle19 = typeof(IProvideValueTarget);
		object[] array19 = new object[0 + 7];
		array19[0] = val37;
		array19[1] = val38;
		array19[2] = val69;
		array19[3] = val70;
		array19[4] = val88;
		array19[5] = val89;
		array19[6] = aboutPage;
		SimpleValueTargetProvider val161 = new SimpleValueTargetProvider(array19, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Dark"), (INameScope[])(object)new NameScope[8] { val90, val90, val90, val90, val90, val90, val90, val90 }, false);
		object obj22 = (object)val161;
		val160.Add(typeFromHandle19, (object)val161);
		val160.Add(typeof(IReferenceProvider), obj22);
		val160.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(43, 28)));
		object dark8 = val159.ProvideValue((IServiceProvider)val160);
		val37.Dark = dark8;
		XamlServiceProvider val162 = new XamlServiceProvider();
		val162.Add(typeof(IProvideValueTarget), (object)new ValueTargetProvider((object)val38, (object)Label.TextColorProperty));
		val162.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(43, 28)));
		BindingBase val163 = ((IMarkupExtension<BindingBase>)(object)val37).ProvideValue((IServiceProvider)val162);
		((BindableObject)val38).SetBinding(Label.TextColorProperty, val163);
		((Layout)val69).Children.Add((IView)(object)val38);
		((BindableObject)val44).SetValue(StackBase.SpacingProperty, (object)10.0);
		((BindableObject)val39).SetValue(Label.TextProperty, (object)"✓");
		((BindableObject)val39).SetValue(Label.TextColorProperty, (object)new Color(0.29803923f, 35f / 51f, 16f / 51f, 1f));
		((BindableObject)val39).SetValue(Label.FontSizeProperty, (object)16.0);
		((Layout)val44).Children.Add((IView)(object)val39);
		((BindableObject)val43).SetValue(Label.TextProperty, (object)"35+ UI Controls");
		val40.Key = "TextPrimaryLight";
		StaticResourceExtension val164 = new StaticResourceExtension
		{
			Key = "TextPrimaryLight"
		};
		XamlServiceProvider val165 = new XamlServiceProvider();
		Type? typeFromHandle20 = typeof(IProvideValueTarget);
		object[] array20 = new object[0 + 8];
		array20[0] = val42;
		array20[1] = val43;
		array20[2] = val44;
		array20[3] = val69;
		array20[4] = val70;
		array20[5] = val88;
		array20[6] = val89;
		array20[7] = aboutPage;
		SimpleValueTargetProvider val166 = new SimpleValueTargetProvider(array20, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Light"), (INameScope[])(object)new NameScope[9] { val90, val90, val90, val90, val90, val90, val90, val90, val90 }, false);
		object obj23 = (object)val166;
		val165.Add(typeFromHandle20, (object)val166);
		val165.Add(typeof(IReferenceProvider), obj23);
		val165.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(47, 55)));
		object light9 = val164.ProvideValue((IServiceProvider)val165);
		val42.Light = light9;
		val41.Key = "TextPrimaryDark";
		StaticResourceExtension val167 = new StaticResourceExtension
		{
			Key = "TextPrimaryDark"
		};
		XamlServiceProvider val168 = new XamlServiceProvider();
		Type? typeFromHandle21 = typeof(IProvideValueTarget);
		object[] array21 = new object[0 + 8];
		array21[0] = val42;
		array21[1] = val43;
		array21[2] = val44;
		array21[3] = val69;
		array21[4] = val70;
		array21[5] = val88;
		array21[6] = val89;
		array21[7] = aboutPage;
		SimpleValueTargetProvider val169 = new SimpleValueTargetProvider(array21, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Dark"), (INameScope[])(object)new NameScope[9] { val90, val90, val90, val90, val90, val90, val90, val90, val90 }, false);
		object obj24 = (object)val169;
		val168.Add(typeFromHandle21, (object)val169);
		val168.Add(typeof(IReferenceProvider), obj24);
		val168.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(47, 55)));
		object dark9 = val167.ProvideValue((IServiceProvider)val168);
		val42.Dark = dark9;
		XamlServiceProvider val170 = new XamlServiceProvider();
		val170.Add(typeof(IProvideValueTarget), (object)new ValueTargetProvider((object)val43, (object)Label.TextColorProperty));
		val170.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(47, 55)));
		BindingBase val171 = ((IMarkupExtension<BindingBase>)(object)val42).ProvideValue((IServiceProvider)val170);
		((BindableObject)val43).SetBinding(Label.TextColorProperty, val171);
		((Layout)val44).Children.Add((IView)(object)val43);
		((Layout)val69).Children.Add((IView)(object)val44);
		((BindableObject)val50).SetValue(StackBase.SpacingProperty, (object)10.0);
		((BindableObject)val45).SetValue(Label.TextProperty, (object)"✓");
		((BindableObject)val45).SetValue(Label.TextColorProperty, (object)new Color(0.29803923f, 35f / 51f, 16f / 51f, 1f));
		((BindableObject)val45).SetValue(Label.FontSizeProperty, (object)16.0);
		((Layout)val50).Children.Add((IView)(object)val45);
		((BindableObject)val49).SetValue(Label.TextProperty, (object)"Shell Navigation");
		val46.Key = "TextPrimaryLight";
		StaticResourceExtension val172 = new StaticResourceExtension
		{
			Key = "TextPrimaryLight"
		};
		XamlServiceProvider val173 = new XamlServiceProvider();
		Type? typeFromHandle22 = typeof(IProvideValueTarget);
		object[] array22 = new object[0 + 8];
		array22[0] = val48;
		array22[1] = val49;
		array22[2] = val50;
		array22[3] = val69;
		array22[4] = val70;
		array22[5] = val88;
		array22[6] = val89;
		array22[7] = aboutPage;
		SimpleValueTargetProvider val174 = new SimpleValueTargetProvider(array22, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Light"), (INameScope[])(object)new NameScope[9] { val90, val90, val90, val90, val90, val90, val90, val90, val90 }, false);
		object obj25 = (object)val174;
		val173.Add(typeFromHandle22, (object)val174);
		val173.Add(typeof(IReferenceProvider), obj25);
		val173.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(51, 56)));
		object light10 = val172.ProvideValue((IServiceProvider)val173);
		val48.Light = light10;
		val47.Key = "TextPrimaryDark";
		StaticResourceExtension val175 = new StaticResourceExtension
		{
			Key = "TextPrimaryDark"
		};
		XamlServiceProvider val176 = new XamlServiceProvider();
		Type? typeFromHandle23 = typeof(IProvideValueTarget);
		object[] array23 = new object[0 + 8];
		array23[0] = val48;
		array23[1] = val49;
		array23[2] = val50;
		array23[3] = val69;
		array23[4] = val70;
		array23[5] = val88;
		array23[6] = val89;
		array23[7] = aboutPage;
		SimpleValueTargetProvider val177 = new SimpleValueTargetProvider(array23, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Dark"), (INameScope[])(object)new NameScope[9] { val90, val90, val90, val90, val90, val90, val90, val90, val90 }, false);
		object obj26 = (object)val177;
		val176.Add(typeFromHandle23, (object)val177);
		val176.Add(typeof(IReferenceProvider), obj26);
		val176.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(51, 56)));
		object dark10 = val175.ProvideValue((IServiceProvider)val176);
		val48.Dark = dark10;
		XamlServiceProvider val178 = new XamlServiceProvider();
		val178.Add(typeof(IProvideValueTarget), (object)new ValueTargetProvider((object)val49, (object)Label.TextColorProperty));
		val178.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(51, 56)));
		BindingBase val179 = ((IMarkupExtension<BindingBase>)(object)val48).ProvideValue((IServiceProvider)val178);
		((BindableObject)val49).SetBinding(Label.TextColorProperty, val179);
		((Layout)val50).Children.Add((IView)(object)val49);
		((Layout)val69).Children.Add((IView)(object)val50);
		((BindableObject)val56).SetValue(StackBase.SpacingProperty, (object)10.0);
		((BindableObject)val51).SetValue(Label.TextProperty, (object)"✓");
		((BindableObject)val51).SetValue(Label.TextColorProperty, (object)new Color(0.29803923f, 35f / 51f, 16f / 51f, 1f));
		((BindableObject)val51).SetValue(Label.FontSizeProperty, (object)16.0);
		((Layout)val56).Children.Add((IView)(object)val51);
		((BindableObject)val55).SetValue(Label.TextProperty, (object)"XAML Support");
		val52.Key = "TextPrimaryLight";
		StaticResourceExtension val180 = new StaticResourceExtension
		{
			Key = "TextPrimaryLight"
		};
		XamlServiceProvider val181 = new XamlServiceProvider();
		Type? typeFromHandle24 = typeof(IProvideValueTarget);
		object[] array24 = new object[0 + 8];
		array24[0] = val54;
		array24[1] = val55;
		array24[2] = val56;
		array24[3] = val69;
		array24[4] = val70;
		array24[5] = val88;
		array24[6] = val89;
		array24[7] = aboutPage;
		SimpleValueTargetProvider val182 = new SimpleValueTargetProvider(array24, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Light"), (INameScope[])(object)new NameScope[9] { val90, val90, val90, val90, val90, val90, val90, val90, val90 }, false);
		object obj27 = (object)val182;
		val181.Add(typeFromHandle24, (object)val182);
		val181.Add(typeof(IReferenceProvider), obj27);
		val181.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(55, 52)));
		object light11 = val180.ProvideValue((IServiceProvider)val181);
		val54.Light = light11;
		val53.Key = "TextPrimaryDark";
		StaticResourceExtension val183 = new StaticResourceExtension
		{
			Key = "TextPrimaryDark"
		};
		XamlServiceProvider val184 = new XamlServiceProvider();
		Type? typeFromHandle25 = typeof(IProvideValueTarget);
		object[] array25 = new object[0 + 8];
		array25[0] = val54;
		array25[1] = val55;
		array25[2] = val56;
		array25[3] = val69;
		array25[4] = val70;
		array25[5] = val88;
		array25[6] = val89;
		array25[7] = aboutPage;
		SimpleValueTargetProvider val185 = new SimpleValueTargetProvider(array25, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Dark"), (INameScope[])(object)new NameScope[9] { val90, val90, val90, val90, val90, val90, val90, val90, val90 }, false);
		object obj28 = (object)val185;
		val184.Add(typeFromHandle25, (object)val185);
		val184.Add(typeof(IReferenceProvider), obj28);
		val184.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(55, 52)));
		object dark11 = val183.ProvideValue((IServiceProvider)val184);
		val54.Dark = dark11;
		XamlServiceProvider val186 = new XamlServiceProvider();
		val186.Add(typeof(IProvideValueTarget), (object)new ValueTargetProvider((object)val55, (object)Label.TextColorProperty));
		val186.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(55, 52)));
		BindingBase val187 = ((IMarkupExtension<BindingBase>)(object)val54).ProvideValue((IServiceProvider)val186);
		((BindableObject)val55).SetBinding(Label.TextColorProperty, val187);
		((Layout)val56).Children.Add((IView)(object)val55);
		((Layout)val69).Children.Add((IView)(object)val56);
		((BindableObject)val62).SetValue(StackBase.SpacingProperty, (object)10.0);
		((BindableObject)val57).SetValue(Label.TextProperty, (object)"✓");
		((BindableObject)val57).SetValue(Label.TextColorProperty, (object)new Color(0.29803923f, 35f / 51f, 16f / 51f, 1f));
		((BindableObject)val57).SetValue(Label.FontSizeProperty, (object)16.0);
		((Layout)val62).Children.Add((IView)(object)val57);
		((BindableObject)val61).SetValue(Label.TextProperty, (object)"Light/Dark Theme");
		val58.Key = "TextPrimaryLight";
		StaticResourceExtension val188 = new StaticResourceExtension
		{
			Key = "TextPrimaryLight"
		};
		XamlServiceProvider val189 = new XamlServiceProvider();
		Type? typeFromHandle26 = typeof(IProvideValueTarget);
		object[] array26 = new object[0 + 8];
		array26[0] = val60;
		array26[1] = val61;
		array26[2] = val62;
		array26[3] = val69;
		array26[4] = val70;
		array26[5] = val88;
		array26[6] = val89;
		array26[7] = aboutPage;
		SimpleValueTargetProvider val190 = new SimpleValueTargetProvider(array26, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Light"), (INameScope[])(object)new NameScope[9] { val90, val90, val90, val90, val90, val90, val90, val90, val90 }, false);
		object obj29 = (object)val190;
		val189.Add(typeFromHandle26, (object)val190);
		val189.Add(typeof(IReferenceProvider), obj29);
		val189.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(59, 56)));
		object light12 = val188.ProvideValue((IServiceProvider)val189);
		val60.Light = light12;
		val59.Key = "TextPrimaryDark";
		StaticResourceExtension val191 = new StaticResourceExtension
		{
			Key = "TextPrimaryDark"
		};
		XamlServiceProvider val192 = new XamlServiceProvider();
		Type? typeFromHandle27 = typeof(IProvideValueTarget);
		object[] array27 = new object[0 + 8];
		array27[0] = val60;
		array27[1] = val61;
		array27[2] = val62;
		array27[3] = val69;
		array27[4] = val70;
		array27[5] = val88;
		array27[6] = val89;
		array27[7] = aboutPage;
		SimpleValueTargetProvider val193 = new SimpleValueTargetProvider(array27, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Dark"), (INameScope[])(object)new NameScope[9] { val90, val90, val90, val90, val90, val90, val90, val90, val90 }, false);
		object obj30 = (object)val193;
		val192.Add(typeFromHandle27, (object)val193);
		val192.Add(typeof(IReferenceProvider), obj30);
		val192.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(59, 56)));
		object dark12 = val191.ProvideValue((IServiceProvider)val192);
		val60.Dark = dark12;
		XamlServiceProvider val194 = new XamlServiceProvider();
		val194.Add(typeof(IProvideValueTarget), (object)new ValueTargetProvider((object)val61, (object)Label.TextColorProperty));
		val194.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(59, 56)));
		BindingBase val195 = ((IMarkupExtension<BindingBase>)(object)val60).ProvideValue((IServiceProvider)val194);
		((BindableObject)val61).SetBinding(Label.TextColorProperty, val195);
		((Layout)val62).Children.Add((IView)(object)val61);
		((Layout)val69).Children.Add((IView)(object)val62);
		((BindableObject)val68).SetValue(StackBase.SpacingProperty, (object)10.0);
		((BindableObject)val63).SetValue(Label.TextProperty, (object)"✓");
		((BindableObject)val63).SetValue(Label.TextColorProperty, (object)new Color(0.29803923f, 35f / 51f, 16f / 51f, 1f));
		((BindableObject)val63).SetValue(Label.FontSizeProperty, (object)16.0);
		((Layout)val68).Children.Add((IView)(object)val63);
		((BindableObject)val67).SetValue(Label.TextProperty, (object)"X11 & Wayland Support");
		val64.Key = "TextPrimaryLight";
		StaticResourceExtension val196 = new StaticResourceExtension
		{
			Key = "TextPrimaryLight"
		};
		XamlServiceProvider val197 = new XamlServiceProvider();
		Type? typeFromHandle28 = typeof(IProvideValueTarget);
		object[] array28 = new object[0 + 8];
		array28[0] = val66;
		array28[1] = val67;
		array28[2] = val68;
		array28[3] = val69;
		array28[4] = val70;
		array28[5] = val88;
		array28[6] = val89;
		array28[7] = aboutPage;
		SimpleValueTargetProvider val198 = new SimpleValueTargetProvider(array28, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Light"), (INameScope[])(object)new NameScope[9] { val90, val90, val90, val90, val90, val90, val90, val90, val90 }, false);
		object obj31 = (object)val198;
		val197.Add(typeFromHandle28, (object)val198);
		val197.Add(typeof(IReferenceProvider), obj31);
		val197.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(63, 65)));
		object light13 = val196.ProvideValue((IServiceProvider)val197);
		val66.Light = light13;
		val65.Key = "TextPrimaryDark";
		StaticResourceExtension val199 = new StaticResourceExtension
		{
			Key = "TextPrimaryDark"
		};
		XamlServiceProvider val200 = new XamlServiceProvider();
		Type? typeFromHandle29 = typeof(IProvideValueTarget);
		object[] array29 = new object[0 + 8];
		array29[0] = val66;
		array29[1] = val67;
		array29[2] = val68;
		array29[3] = val69;
		array29[4] = val70;
		array29[5] = val88;
		array29[6] = val89;
		array29[7] = aboutPage;
		SimpleValueTargetProvider val201 = new SimpleValueTargetProvider(array29, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Dark"), (INameScope[])(object)new NameScope[9] { val90, val90, val90, val90, val90, val90, val90, val90, val90 }, false);
		object obj32 = (object)val201;
		val200.Add(typeFromHandle29, (object)val201);
		val200.Add(typeof(IReferenceProvider), obj32);
		val200.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(63, 65)));
		object dark13 = val199.ProvideValue((IServiceProvider)val200);
		val66.Dark = dark13;
		XamlServiceProvider val202 = new XamlServiceProvider();
		val202.Add(typeof(IProvideValueTarget), (object)new ValueTargetProvider((object)val67, (object)Label.TextColorProperty));
		val202.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(63, 65)));
		BindingBase val203 = ((IMarkupExtension<BindingBase>)(object)val66).ProvideValue((IServiceProvider)val202);
		((BindableObject)val67).SetBinding(Label.TextColorProperty, val203);
		((Layout)val68).Children.Add((IView)(object)val67);
		((Layout)val69).Children.Add((IView)(object)val68);
		((BindableObject)val70).SetValue(ContentView.ContentProperty, (object)val69);
		((Layout)val88).Children.Add((IView)(object)val70);
		val71.Key = "ThemedFrame";
		StaticResourceExtension val204 = new StaticResourceExtension
		{
			Key = "ThemedFrame"
		};
		XamlServiceProvider val205 = new XamlServiceProvider();
		Type? typeFromHandle30 = typeof(IProvideValueTarget);
		object[] array30 = new object[0 + 4];
		array30[0] = val83;
		array30[1] = val88;
		array30[2] = val89;
		array30[3] = aboutPage;
		SimpleValueTargetProvider val206 = new SimpleValueTargetProvider(array30, (object)VisualElement.StyleProperty, (INameScope[])(object)new NameScope[5] { val90, val90, val90, val90, val90 }, false);
		object obj33 = (object)val206;
		val205.Add(typeFromHandle30, (object)val206);
		val205.Add(typeof(IReferenceProvider), obj33);
		val205.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(69, 20)));
		object obj34 = val204.ProvideValue((IServiceProvider)val205);
		((BindableObject)val83).SetValue(VisualElement.StyleProperty, (obj34 == null || !typeof(BindingBase).IsAssignableFrom(obj34.GetType())) ? obj34 : obj34);
		((BindableObject)val83).SetValue(Frame.CornerRadiusProperty, (object)8f);
		((BindableObject)val83).SetValue(Layout.PaddingProperty, (object)new Thickness(20.0));
		((BindableObject)val82).SetValue(StackBase.SpacingProperty, (object)10.0);
		((BindableObject)val75).SetValue(Label.TextProperty, (object)"Links");
		((BindableObject)val75).SetValue(Label.FontSizeProperty, (object)18.0);
		((BindableObject)val75).SetValue(Label.FontAttributesProperty, (object)(FontAttributes)1);
		val72.Key = "TextPrimaryLight";
		StaticResourceExtension val207 = new StaticResourceExtension
		{
			Key = "TextPrimaryLight"
		};
		XamlServiceProvider val208 = new XamlServiceProvider();
		Type? typeFromHandle31 = typeof(IProvideValueTarget);
		object[] array31 = new object[0 + 7];
		array31[0] = val74;
		array31[1] = val75;
		array31[2] = val82;
		array31[3] = val83;
		array31[4] = val88;
		array31[5] = val89;
		array31[6] = aboutPage;
		SimpleValueTargetProvider val209 = new SimpleValueTargetProvider(array31, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Light"), (INameScope[])(object)new NameScope[8] { val90, val90, val90, val90, val90, val90, val90, val90 }, false);
		object obj35 = (object)val209;
		val208.Add(typeFromHandle31, (object)val209);
		val208.Add(typeof(IReferenceProvider), obj35);
		val208.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(72, 28)));
		object light14 = val207.ProvideValue((IServiceProvider)val208);
		val74.Light = light14;
		val73.Key = "TextPrimaryDark";
		StaticResourceExtension val210 = new StaticResourceExtension
		{
			Key = "TextPrimaryDark"
		};
		XamlServiceProvider val211 = new XamlServiceProvider();
		Type? typeFromHandle32 = typeof(IProvideValueTarget);
		object[] array32 = new object[0 + 7];
		array32[0] = val74;
		array32[1] = val75;
		array32[2] = val82;
		array32[3] = val83;
		array32[4] = val88;
		array32[5] = val89;
		array32[6] = aboutPage;
		SimpleValueTargetProvider val212 = new SimpleValueTargetProvider(array32, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Dark"), (INameScope[])(object)new NameScope[8] { val90, val90, val90, val90, val90, val90, val90, val90 }, false);
		object obj36 = (object)val212;
		val211.Add(typeFromHandle32, (object)val212);
		val211.Add(typeof(IReferenceProvider), obj36);
		val211.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(72, 28)));
		object dark14 = val210.ProvideValue((IServiceProvider)val211);
		val74.Dark = dark14;
		XamlServiceProvider val213 = new XamlServiceProvider();
		val213.Add(typeof(IProvideValueTarget), (object)new ValueTargetProvider((object)val75, (object)Label.TextColorProperty));
		val213.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(72, 28)));
		BindingBase val214 = ((IMarkupExtension<BindingBase>)(object)val74).ProvideValue((IServiceProvider)val213);
		((BindableObject)val75).SetBinding(Label.TextColorProperty, val214);
		((Layout)val82).Children.Add((IView)(object)val75);
		((BindableObject)val78).SetValue(Label.TextProperty, (object)"Website: https://openmaui.net");
		((BindableObject)val78).SetValue(Label.FontSizeProperty, (object)14.0);
		val76.Key = "PrimaryColor";
		StaticResourceExtension val215 = new StaticResourceExtension
		{
			Key = "PrimaryColor"
		};
		XamlServiceProvider val216 = new XamlServiceProvider();
		Type? typeFromHandle33 = typeof(IProvideValueTarget);
		object[] array33 = new object[0 + 6];
		array33[0] = val78;
		array33[1] = val82;
		array33[2] = val83;
		array33[3] = val88;
		array33[4] = val89;
		array33[5] = aboutPage;
		SimpleValueTargetProvider val217 = new SimpleValueTargetProvider(array33, (object)Label.TextColorProperty, (INameScope[])(object)new NameScope[7] { val90, val90, val90, val90, val90, val90, val90 }, false);
		object obj37 = (object)val217;
		val216.Add(typeFromHandle33, (object)val217);
		val216.Add(typeof(IReferenceProvider), obj37);
		val216.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(74, 28)));
		object obj38 = val215.ProvideValue((IServiceProvider)val216);
		((BindableObject)val78).SetValue(Label.TextColorProperty, (obj38 == null || !typeof(BindingBase).IsAssignableFrom(obj38.GetType())) ? obj38 : obj38);
		((BindableObject)val78).SetValue(Label.TextDecorationsProperty, (object)(TextDecorations)1);
		val77.Tapped += aboutPage.OnWebsiteTapped;
		((View)val78).GestureRecognizers.Add((IGestureRecognizer)(object)val77);
		((Layout)val82).Children.Add((IView)(object)val78);
		((BindableObject)val81).SetValue(Label.TextProperty, (object)"GitHub: github.com/openmaui/maui-linux");
		((BindableObject)val81).SetValue(Label.FontSizeProperty, (object)14.0);
		val79.Key = "PrimaryColor";
		StaticResourceExtension val218 = new StaticResourceExtension
		{
			Key = "PrimaryColor"
		};
		XamlServiceProvider val219 = new XamlServiceProvider();
		Type? typeFromHandle34 = typeof(IProvideValueTarget);
		object[] array34 = new object[0 + 6];
		array34[0] = val81;
		array34[1] = val82;
		array34[2] = val83;
		array34[3] = val88;
		array34[4] = val89;
		array34[5] = aboutPage;
		SimpleValueTargetProvider val220 = new SimpleValueTargetProvider(array34, (object)Label.TextColorProperty, (INameScope[])(object)new NameScope[7] { val90, val90, val90, val90, val90, val90, val90 }, false);
		object obj39 = (object)val220;
		val219.Add(typeFromHandle34, (object)val220);
		val219.Add(typeof(IReferenceProvider), obj39);
		val219.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(80, 28)));
		object obj40 = val218.ProvideValue((IServiceProvider)val219);
		((BindableObject)val81).SetValue(Label.TextColorProperty, (obj40 == null || !typeof(BindingBase).IsAssignableFrom(obj40.GetType())) ? obj40 : obj40);
		((BindableObject)val81).SetValue(Label.TextDecorationsProperty, (object)(TextDecorations)1);
		val80.Tapped += aboutPage.OnGitHubTapped;
		((View)val81).GestureRecognizers.Add((IGestureRecognizer)(object)val80);
		((Layout)val82).Children.Add((IView)(object)val81);
		((BindableObject)val83).SetValue(ContentView.ContentProperty, (object)val82);
		((Layout)val88).Children.Add((IView)(object)val83);
		((BindableObject)val87).SetValue(Label.TextProperty, (object)"© 2025 MarketAlly LLC");
		((BindableObject)val87).SetValue(Label.FontSizeProperty, (object)12.0);
		((BindableObject)val87).SetValue(View.HorizontalOptionsProperty, (object)LayoutOptions.Center);
		val84.Key = "TextSecondaryLight";
		StaticResourceExtension val221 = new StaticResourceExtension
		{
			Key = "TextSecondaryLight"
		};
		XamlServiceProvider val222 = new XamlServiceProvider();
		Type? typeFromHandle35 = typeof(IProvideValueTarget);
		object[] array35 = new object[0 + 5];
		array35[0] = val86;
		array35[1] = val87;
		array35[2] = val88;
		array35[3] = val89;
		array35[4] = aboutPage;
		SimpleValueTargetProvider val223 = new SimpleValueTargetProvider(array35, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Light"), (INameScope[])(object)new NameScope[6] { val90, val90, val90, val90, val90, val90 }, false);
		object obj41 = (object)val223;
		val222.Add(typeFromHandle35, (object)val223);
		val222.Add(typeof(IReferenceProvider), obj41);
		val222.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(90, 20)));
		object light15 = val221.ProvideValue((IServiceProvider)val222);
		val86.Light = light15;
		val85.Key = "TextSecondaryDark";
		StaticResourceExtension val224 = new StaticResourceExtension
		{
			Key = "TextSecondaryDark"
		};
		XamlServiceProvider val225 = new XamlServiceProvider();
		Type? typeFromHandle36 = typeof(IProvideValueTarget);
		object[] array36 = new object[0 + 5];
		array36[0] = val86;
		array36[1] = val87;
		array36[2] = val88;
		array36[3] = val89;
		array36[4] = aboutPage;
		SimpleValueTargetProvider val226 = new SimpleValueTargetProvider(array36, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Dark"), (INameScope[])(object)new NameScope[6] { val90, val90, val90, val90, val90, val90 }, false);
		object obj42 = (object)val226;
		val225.Add(typeFromHandle36, (object)val226);
		val225.Add(typeof(IReferenceProvider), obj42);
		val225.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(90, 20)));
		object dark15 = val224.ProvideValue((IServiceProvider)val225);
		val86.Dark = dark15;
		XamlServiceProvider val227 = new XamlServiceProvider();
		val227.Add(typeof(IProvideValueTarget), (object)new ValueTargetProvider((object)val87, (object)Label.TextColorProperty));
		val227.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(90, 20)));
		BindingBase val228 = ((IMarkupExtension<BindingBase>)(object)val86).ProvideValue((IServiceProvider)val227);
		((BindableObject)val87).SetBinding(Label.TextColorProperty, val228);
		((Layout)val88).Children.Add((IView)(object)val87);
		val89.Content = (View)(object)val88;
		((BindableObject)aboutPage).SetValue(ContentPage.ContentProperty, (object)val89);
	}
}
