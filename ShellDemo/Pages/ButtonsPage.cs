using System;
using System.CodeDom.Compiler;
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

[XamlFilePath("Pages/ButtonsPage.xaml")]
public class ButtonsPage : ContentPage
{
	private int _eventCount;

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private Button DefaultBtn;

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private Button DisabledBtn;

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private Label EventLog;

	public ButtonsPage()
	{
		InitializeComponent();
	}

	private void LogEvent(string message)
	{
		_eventCount++;
		string value = DateTime.Now.ToString("HH:mm:ss");
		EventLog.Text = $"[{value}] {_eventCount}. {message}\n{EventLog.Text}";
	}

	private void OnDefaultBtnClicked(object? sender, EventArgs e)
	{
		LogEvent("Default Button clicked");
	}

	private void OnTextBtnClicked(object? sender, EventArgs e)
	{
		LogEvent("Text Button clicked");
	}

	private void OnColorBtnClicked(object? sender, EventArgs e)
	{
		Button val = (Button)((sender is Button) ? sender : null);
		if (val != null)
		{
			LogEvent(val.Text + " button clicked");
		}
	}

	private void OnEnabledBtnClicked(object? sender, EventArgs e)
	{
		LogEvent("Enabled button clicked");
	}

	private void OnToggleBtnClicked(object? sender, EventArgs e)
	{
		((VisualElement)DisabledBtn).IsEnabled = !((VisualElement)DisabledBtn).IsEnabled;
		DisabledBtn.Text = (((VisualElement)DisabledBtn).IsEnabled ? "Now Enabled!" : "Disabled Button");
		LogEvent("Toggled button to: " + (((VisualElement)DisabledBtn).IsEnabled ? "Enabled" : "Disabled"));
	}

	private void OnWideBtnClicked(object? sender, EventArgs e)
	{
		LogEvent("Wide button clicked");
	}

	private void OnTallBtnClicked(object? sender, EventArgs e)
	{
		LogEvent("Tall button clicked");
	}

	private void OnRoundBtnClicked(object? sender, EventArgs e)
	{
		LogEvent("Round button clicked");
	}

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	[MemberNotNull("DefaultBtn")]
	[MemberNotNull("DisabledBtn")]
	[MemberNotNull("EventLog")]
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
		//IL_01d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0427: Unknown result type (might be due to invalid IL or missing references)
		//IL_042c: Unknown result type (might be due to invalid IL or missing references)
		//IL_042f: Expected O, but got Unknown
		//IL_0434: Expected O, but got Unknown
		//IL_0434: Unknown result type (might be due to invalid IL or missing references)
		//IL_0446: Unknown result type (might be due to invalid IL or missing references)
		//IL_0454: Unknown result type (might be due to invalid IL or missing references)
		//IL_045e: Expected O, but got Unknown
		//IL_0459: Unknown result type (might be due to invalid IL or missing references)
		//IL_0463: Expected O, but got Unknown
		//IL_0468: Expected O, but got Unknown
		//IL_047d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0482: Unknown result type (might be due to invalid IL or missing references)
		//IL_048d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0492: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e0: Expected O, but got Unknown
		//IL_04e5: Expected O, but got Unknown
		//IL_04e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0505: Unknown result type (might be due to invalid IL or missing references)
		//IL_050f: Expected O, but got Unknown
		//IL_050a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0514: Expected O, but got Unknown
		//IL_0519: Expected O, but got Unknown
		//IL_0524: Unknown result type (might be due to invalid IL or missing references)
		//IL_0529: Unknown result type (might be due to invalid IL or missing references)
		//IL_053b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0545: Expected O, but got Unknown
		//IL_0545: Unknown result type (might be due to invalid IL or missing references)
		//IL_0553: Unknown result type (might be due to invalid IL or missing references)
		//IL_055d: Expected O, but got Unknown
		//IL_0558: Unknown result type (might be due to invalid IL or missing references)
		//IL_0562: Expected O, but got Unknown
		//IL_0567: Expected O, but got Unknown
		//IL_0586: Unknown result type (might be due to invalid IL or missing references)
		//IL_058b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0591: Expected O, but got Unknown
		//IL_059c: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a7: Expected O, but got Unknown
		//IL_05a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b1: Expected O, but got Unknown
		//IL_05d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0644: Unknown result type (might be due to invalid IL or missing references)
		//IL_0649: Unknown result type (might be due to invalid IL or missing references)
		//IL_0654: Unknown result type (might be due to invalid IL or missing references)
		//IL_0659: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_06cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d0: Expected O, but got Unknown
		//IL_06d5: Expected O, but got Unknown
		//IL_06d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0700: Expected O, but got Unknown
		//IL_06fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0705: Expected O, but got Unknown
		//IL_070a: Expected O, but got Unknown
		//IL_0721: Unknown result type (might be due to invalid IL or missing references)
		//IL_0726: Unknown result type (might be due to invalid IL or missing references)
		//IL_0731: Unknown result type (might be due to invalid IL or missing references)
		//IL_0736: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_07aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ad: Expected O, but got Unknown
		//IL_07b2: Expected O, but got Unknown
		//IL_07b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_07c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_07dd: Expected O, but got Unknown
		//IL_07d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e2: Expected O, but got Unknown
		//IL_07e7: Expected O, but got Unknown
		//IL_07f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_080b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0815: Expected O, but got Unknown
		//IL_0815: Unknown result type (might be due to invalid IL or missing references)
		//IL_0824: Unknown result type (might be due to invalid IL or missing references)
		//IL_082e: Expected O, but got Unknown
		//IL_0829: Unknown result type (might be due to invalid IL or missing references)
		//IL_0833: Expected O, but got Unknown
		//IL_0838: Expected O, but got Unknown
		//IL_0862: Unknown result type (might be due to invalid IL or missing references)
		//IL_0867: Unknown result type (might be due to invalid IL or missing references)
		//IL_0872: Unknown result type (might be due to invalid IL or missing references)
		//IL_0877: Unknown result type (might be due to invalid IL or missing references)
		//IL_08cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_08d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_08d5: Expected O, but got Unknown
		//IL_08da: Expected O, but got Unknown
		//IL_08da: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_08fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0905: Expected O, but got Unknown
		//IL_0900: Unknown result type (might be due to invalid IL or missing references)
		//IL_090a: Expected O, but got Unknown
		//IL_090f: Expected O, but got Unknown
		//IL_0967: Unknown result type (might be due to invalid IL or missing references)
		//IL_09d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_09de: Unknown result type (might be due to invalid IL or missing references)
		//IL_09e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_09ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a72: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a77: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a7a: Expected O, but got Unknown
		//IL_0a7f: Expected O, but got Unknown
		//IL_0a7f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a91: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aa0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aaa: Expected O, but got Unknown
		//IL_0aa5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aaf: Expected O, but got Unknown
		//IL_0ab4: Expected O, but got Unknown
		//IL_0acb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ad0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0adb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ae0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b64: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b69: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b6c: Expected O, but got Unknown
		//IL_0b71: Expected O, but got Unknown
		//IL_0b71: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b83: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b92: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b9c: Expected O, but got Unknown
		//IL_0b97: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ba1: Expected O, but got Unknown
		//IL_0ba6: Expected O, but got Unknown
		//IL_0bb3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bb8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bca: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bd4: Expected O, but got Unknown
		//IL_0bd4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0be3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bed: Expected O, but got Unknown
		//IL_0be8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bf2: Expected O, but got Unknown
		//IL_0bf7: Expected O, but got Unknown
		//IL_0c76: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c7b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c86: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c8b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cf5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cfa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cfd: Expected O, but got Unknown
		//IL_0d02: Expected O, but got Unknown
		//IL_0d02: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d14: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d23: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d2d: Expected O, but got Unknown
		//IL_0d28: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d32: Expected O, but got Unknown
		//IL_0d37: Expected O, but got Unknown
		//IL_0db3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0db8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dc3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dc8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e1e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e23: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e26: Expected O, but got Unknown
		//IL_0e2b: Expected O, but got Unknown
		//IL_0e2b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e3d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e4c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e56: Expected O, but got Unknown
		//IL_0e51: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e5b: Expected O, but got Unknown
		//IL_0e60: Expected O, but got Unknown
		//IL_0eb8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f2a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f2f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f3a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f3f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fc3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fc8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fcb: Expected O, but got Unknown
		//IL_0fd0: Expected O, but got Unknown
		//IL_0fd0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fe2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ff1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ffb: Expected O, but got Unknown
		//IL_0ff6: Unknown result type (might be due to invalid IL or missing references)
		//IL_1000: Expected O, but got Unknown
		//IL_1005: Expected O, but got Unknown
		//IL_101c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1021: Unknown result type (might be due to invalid IL or missing references)
		//IL_102c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1031: Unknown result type (might be due to invalid IL or missing references)
		//IL_10b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_10ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_10bd: Expected O, but got Unknown
		//IL_10c2: Expected O, but got Unknown
		//IL_10c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_10d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_10e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_10ed: Expected O, but got Unknown
		//IL_10e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_10f2: Expected O, but got Unknown
		//IL_10f7: Expected O, but got Unknown
		//IL_1104: Unknown result type (might be due to invalid IL or missing references)
		//IL_1109: Unknown result type (might be due to invalid IL or missing references)
		//IL_111b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1125: Expected O, but got Unknown
		//IL_1125: Unknown result type (might be due to invalid IL or missing references)
		//IL_1134: Unknown result type (might be due to invalid IL or missing references)
		//IL_113e: Expected O, but got Unknown
		//IL_1139: Unknown result type (might be due to invalid IL or missing references)
		//IL_1143: Expected O, but got Unknown
		//IL_1148: Expected O, but got Unknown
		//IL_11ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_11b6: Expected O, but got Unknown
		//IL_1227: Unknown result type (might be due to invalid IL or missing references)
		//IL_1231: Expected O, but got Unknown
		//IL_12a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_12ac: Expected O, but got Unknown
		//IL_131d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1327: Expected O, but got Unknown
		//IL_1398: Unknown result type (might be due to invalid IL or missing references)
		//IL_13a2: Expected O, but got Unknown
		//IL_141d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1422: Unknown result type (might be due to invalid IL or missing references)
		//IL_142d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1432: Unknown result type (might be due to invalid IL or missing references)
		//IL_1488: Unknown result type (might be due to invalid IL or missing references)
		//IL_148d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1490: Expected O, but got Unknown
		//IL_1495: Expected O, but got Unknown
		//IL_1495: Unknown result type (might be due to invalid IL or missing references)
		//IL_14a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_14b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_14c0: Expected O, but got Unknown
		//IL_14bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_14c5: Expected O, but got Unknown
		//IL_14ca: Expected O, but got Unknown
		//IL_1522: Unknown result type (might be due to invalid IL or missing references)
		//IL_1594: Unknown result type (might be due to invalid IL or missing references)
		//IL_1599: Unknown result type (might be due to invalid IL or missing references)
		//IL_15a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_15a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_162d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1632: Unknown result type (might be due to invalid IL or missing references)
		//IL_1635: Expected O, but got Unknown
		//IL_163a: Expected O, but got Unknown
		//IL_163a: Unknown result type (might be due to invalid IL or missing references)
		//IL_164c: Unknown result type (might be due to invalid IL or missing references)
		//IL_165b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1665: Expected O, but got Unknown
		//IL_1660: Unknown result type (might be due to invalid IL or missing references)
		//IL_166a: Expected O, but got Unknown
		//IL_166f: Expected O, but got Unknown
		//IL_1686: Unknown result type (might be due to invalid IL or missing references)
		//IL_168b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1696: Unknown result type (might be due to invalid IL or missing references)
		//IL_169b: Unknown result type (might be due to invalid IL or missing references)
		//IL_171f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1724: Unknown result type (might be due to invalid IL or missing references)
		//IL_1727: Expected O, but got Unknown
		//IL_172c: Expected O, but got Unknown
		//IL_172c: Unknown result type (might be due to invalid IL or missing references)
		//IL_173e: Unknown result type (might be due to invalid IL or missing references)
		//IL_174d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1757: Expected O, but got Unknown
		//IL_1752: Unknown result type (might be due to invalid IL or missing references)
		//IL_175c: Expected O, but got Unknown
		//IL_1761: Expected O, but got Unknown
		//IL_176e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1773: Unknown result type (might be due to invalid IL or missing references)
		//IL_1785: Unknown result type (might be due to invalid IL or missing references)
		//IL_178f: Expected O, but got Unknown
		//IL_178f: Unknown result type (might be due to invalid IL or missing references)
		//IL_179e: Unknown result type (might be due to invalid IL or missing references)
		//IL_17a8: Expected O, but got Unknown
		//IL_17a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_17ad: Expected O, but got Unknown
		//IL_17b2: Expected O, but got Unknown
		//IL_18a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_18a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_18b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_18b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_190c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1911: Unknown result type (might be due to invalid IL or missing references)
		//IL_1914: Expected O, but got Unknown
		//IL_1919: Expected O, but got Unknown
		//IL_1919: Unknown result type (might be due to invalid IL or missing references)
		//IL_192b: Unknown result type (might be due to invalid IL or missing references)
		//IL_193a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1944: Expected O, but got Unknown
		//IL_193f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1949: Expected O, but got Unknown
		//IL_194e: Expected O, but got Unknown
		//IL_19a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a18: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a1d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a28: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a2d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ab1: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ab6: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ab9: Expected O, but got Unknown
		//IL_1abe: Expected O, but got Unknown
		//IL_1abe: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ad0: Unknown result type (might be due to invalid IL or missing references)
		//IL_1adf: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ae9: Expected O, but got Unknown
		//IL_1ae4: Unknown result type (might be due to invalid IL or missing references)
		//IL_1aee: Expected O, but got Unknown
		//IL_1af3: Expected O, but got Unknown
		//IL_1b0a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b0f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b1a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b1f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ba3: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ba8: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bab: Expected O, but got Unknown
		//IL_1bb0: Expected O, but got Unknown
		//IL_1bb0: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bc2: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bd1: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bdb: Expected O, but got Unknown
		//IL_1bd6: Unknown result type (might be due to invalid IL or missing references)
		//IL_1be0: Expected O, but got Unknown
		//IL_1be5: Expected O, but got Unknown
		//IL_1bf2: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bf7: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c09: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c13: Expected O, but got Unknown
		//IL_1c13: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c22: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c2c: Expected O, but got Unknown
		//IL_1c27: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c31: Expected O, but got Unknown
		//IL_1c36: Expected O, but got Unknown
		//IL_1c6c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c96: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ca0: Expected O, but got Unknown
		//IL_1d19: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d23: Expected O, but got Unknown
		//IL_1dc9: Unknown result type (might be due to invalid IL or missing references)
		//IL_1dd3: Expected O, but got Unknown
		//IL_1e69: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ea8: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ead: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ebf: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ec9: Expected O, but got Unknown
		//IL_1ec9: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ed8: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ee2: Expected O, but got Unknown
		//IL_1edd: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ee7: Expected O, but got Unknown
		//IL_1eec: Expected O, but got Unknown
		//IL_1f45: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f4a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f55: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f5a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1fc9: Unknown result type (might be due to invalid IL or missing references)
		//IL_1fce: Unknown result type (might be due to invalid IL or missing references)
		//IL_1fd1: Expected O, but got Unknown
		//IL_1fd6: Expected O, but got Unknown
		//IL_1fd6: Unknown result type (might be due to invalid IL or missing references)
		//IL_1fe8: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ff7: Unknown result type (might be due to invalid IL or missing references)
		//IL_2001: Expected O, but got Unknown
		//IL_1ffc: Unknown result type (might be due to invalid IL or missing references)
		//IL_2006: Expected O, but got Unknown
		//IL_200b: Expected O, but got Unknown
		//IL_2022: Unknown result type (might be due to invalid IL or missing references)
		//IL_2027: Unknown result type (might be due to invalid IL or missing references)
		//IL_2032: Unknown result type (might be due to invalid IL or missing references)
		//IL_2037: Unknown result type (might be due to invalid IL or missing references)
		//IL_20a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_20ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_20ae: Expected O, but got Unknown
		//IL_20b3: Expected O, but got Unknown
		//IL_20b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_20c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_20d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_20de: Expected O, but got Unknown
		//IL_20d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_20e3: Expected O, but got Unknown
		//IL_20e8: Expected O, but got Unknown
		//IL_20f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_20fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_210c: Unknown result type (might be due to invalid IL or missing references)
		//IL_2116: Expected O, but got Unknown
		//IL_2116: Unknown result type (might be due to invalid IL or missing references)
		//IL_2125: Unknown result type (might be due to invalid IL or missing references)
		//IL_212f: Expected O, but got Unknown
		//IL_212a: Unknown result type (might be due to invalid IL or missing references)
		//IL_2134: Expected O, but got Unknown
		//IL_2139: Expected O, but got Unknown
		//IL_21a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_21ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_21b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_21bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_2236: Unknown result type (might be due to invalid IL or missing references)
		//IL_223b: Unknown result type (might be due to invalid IL or missing references)
		//IL_223e: Expected O, but got Unknown
		//IL_2243: Expected O, but got Unknown
		//IL_2243: Unknown result type (might be due to invalid IL or missing references)
		//IL_2255: Unknown result type (might be due to invalid IL or missing references)
		//IL_2264: Unknown result type (might be due to invalid IL or missing references)
		//IL_226e: Expected O, but got Unknown
		//IL_2269: Unknown result type (might be due to invalid IL or missing references)
		//IL_2273: Expected O, but got Unknown
		//IL_2278: Expected O, but got Unknown
		//IL_228f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2294: Unknown result type (might be due to invalid IL or missing references)
		//IL_229f: Unknown result type (might be due to invalid IL or missing references)
		//IL_22a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_231d: Unknown result type (might be due to invalid IL or missing references)
		//IL_2322: Unknown result type (might be due to invalid IL or missing references)
		//IL_2325: Expected O, but got Unknown
		//IL_232a: Expected O, but got Unknown
		//IL_232a: Unknown result type (might be due to invalid IL or missing references)
		//IL_233c: Unknown result type (might be due to invalid IL or missing references)
		//IL_234b: Unknown result type (might be due to invalid IL or missing references)
		//IL_2355: Expected O, but got Unknown
		//IL_2350: Unknown result type (might be due to invalid IL or missing references)
		//IL_235a: Expected O, but got Unknown
		//IL_235f: Expected O, but got Unknown
		//IL_236c: Unknown result type (might be due to invalid IL or missing references)
		//IL_2371: Unknown result type (might be due to invalid IL or missing references)
		//IL_2383: Unknown result type (might be due to invalid IL or missing references)
		//IL_238d: Expected O, but got Unknown
		//IL_238d: Unknown result type (might be due to invalid IL or missing references)
		//IL_239c: Unknown result type (might be due to invalid IL or missing references)
		//IL_23a6: Expected O, but got Unknown
		//IL_23a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_23ab: Expected O, but got Unknown
		//IL_23b0: Expected O, but got Unknown
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
		Button val13 = new Button();
		StaticResourceExtension val14 = new StaticResourceExtension();
		Button val15 = new Button();
		VerticalStackLayout val16 = new VerticalStackLayout();
		Frame val17 = new Frame();
		StaticResourceExtension val18 = new StaticResourceExtension();
		StaticResourceExtension val19 = new StaticResourceExtension();
		StaticResourceExtension val20 = new StaticResourceExtension();
		AppThemeBindingExtension val21 = new AppThemeBindingExtension();
		Label val22 = new Label();
		Button val23 = new Button();
		Button val24 = new Button();
		Button val25 = new Button();
		Button val26 = new Button();
		Button val27 = new Button();
		HorizontalStackLayout val28 = new HorizontalStackLayout();
		VerticalStackLayout val29 = new VerticalStackLayout();
		Frame val30 = new Frame();
		StaticResourceExtension val31 = new StaticResourceExtension();
		StaticResourceExtension val32 = new StaticResourceExtension();
		StaticResourceExtension val33 = new StaticResourceExtension();
		AppThemeBindingExtension val34 = new AppThemeBindingExtension();
		Label val35 = new Label();
		Button val36 = new Button();
		Button val37 = new Button();
		Button val38 = new Button();
		VerticalStackLayout val39 = new VerticalStackLayout();
		Frame val40 = new Frame();
		StaticResourceExtension val41 = new StaticResourceExtension();
		StaticResourceExtension val42 = new StaticResourceExtension();
		StaticResourceExtension val43 = new StaticResourceExtension();
		AppThemeBindingExtension val44 = new AppThemeBindingExtension();
		Label val45 = new Label();
		Button val46 = new Button();
		Button val47 = new Button();
		Button val48 = new Button();
		HorizontalStackLayout val49 = new HorizontalStackLayout();
		VerticalStackLayout val50 = new VerticalStackLayout();
		Frame val51 = new Frame();
		VerticalStackLayout val52 = new VerticalStackLayout();
		ScrollView val53 = new ScrollView();
		AppThemeBindingExtension val54 = new AppThemeBindingExtension();
		StaticResourceExtension val55 = new StaticResourceExtension();
		StaticResourceExtension val56 = new StaticResourceExtension();
		AppThemeBindingExtension val57 = new AppThemeBindingExtension();
		Label val58 = new Label();
		StaticResourceExtension val59 = new StaticResourceExtension();
		StaticResourceExtension val60 = new StaticResourceExtension();
		AppThemeBindingExtension val61 = new AppThemeBindingExtension();
		Label val62 = new Label();
		ScrollView val63 = new ScrollView();
		VerticalStackLayout val64 = new VerticalStackLayout();
		Frame val65 = new Frame();
		Grid val66 = new Grid();
		ButtonsPage buttonsPage;
		NameScope val67 = (NameScope)(((object)NameScope.GetNameScope((BindableObject)(object)(buttonsPage = this))) ?? ((object)new NameScope()));
		NameScope.SetNameScope((BindableObject)(object)buttonsPage, (INameScope)(object)val67);
		((Element)val66).transientNamescope = (INameScope)(object)val67;
		((Element)val53).transientNamescope = (INameScope)(object)val67;
		((Element)val52).transientNamescope = (INameScope)(object)val67;
		((Element)val7).transientNamescope = (INameScope)(object)val67;
		((Element)val17).transientNamescope = (INameScope)(object)val67;
		((Element)val16).transientNamescope = (INameScope)(object)val67;
		((Element)val12).transientNamescope = (INameScope)(object)val67;
		((Element)val13).transientNamescope = (INameScope)(object)val67;
		((INameScope)val67).RegisterName("DefaultBtn", (object)val13);
		if (((Element)val13).StyleId == null)
		{
			((Element)val13).StyleId = "DefaultBtn";
		}
		((Element)val15).transientNamescope = (INameScope)(object)val67;
		((Element)val30).transientNamescope = (INameScope)(object)val67;
		((Element)val29).transientNamescope = (INameScope)(object)val67;
		((Element)val22).transientNamescope = (INameScope)(object)val67;
		((Element)val28).transientNamescope = (INameScope)(object)val67;
		((Element)val23).transientNamescope = (INameScope)(object)val67;
		((Element)val24).transientNamescope = (INameScope)(object)val67;
		((Element)val25).transientNamescope = (INameScope)(object)val67;
		((Element)val26).transientNamescope = (INameScope)(object)val67;
		((Element)val27).transientNamescope = (INameScope)(object)val67;
		((Element)val40).transientNamescope = (INameScope)(object)val67;
		((Element)val39).transientNamescope = (INameScope)(object)val67;
		((Element)val35).transientNamescope = (INameScope)(object)val67;
		((Element)val36).transientNamescope = (INameScope)(object)val67;
		((Element)val37).transientNamescope = (INameScope)(object)val67;
		((INameScope)val67).RegisterName("DisabledBtn", (object)val37);
		if (((Element)val37).StyleId == null)
		{
			((Element)val37).StyleId = "DisabledBtn";
		}
		((Element)val38).transientNamescope = (INameScope)(object)val67;
		((Element)val51).transientNamescope = (INameScope)(object)val67;
		((Element)val50).transientNamescope = (INameScope)(object)val67;
		((Element)val45).transientNamescope = (INameScope)(object)val67;
		((Element)val46).transientNamescope = (INameScope)(object)val67;
		((Element)val47).transientNamescope = (INameScope)(object)val67;
		((Element)val49).transientNamescope = (INameScope)(object)val67;
		((Element)val48).transientNamescope = (INameScope)(object)val67;
		((Element)val65).transientNamescope = (INameScope)(object)val67;
		((Element)val64).transientNamescope = (INameScope)(object)val67;
		((Element)val58).transientNamescope = (INameScope)(object)val67;
		((Element)val63).transientNamescope = (INameScope)(object)val67;
		((Element)val62).transientNamescope = (INameScope)(object)val67;
		((INameScope)val67).RegisterName("EventLog", (object)val62);
		if (((Element)val62).StyleId == null)
		{
			((Element)val62).StyleId = "EventLog";
		}
		DefaultBtn = val13;
		DisabledBtn = val37;
		EventLog = val62;
		((BindableObject)buttonsPage).SetValue(Page.TitleProperty, (object)"Buttons Demo");
		val.Key = "PageBackgroundLight";
		StaticResourceExtension val68 = new StaticResourceExtension
		{
			Key = "PageBackgroundLight"
		};
		XamlServiceProvider val69 = new XamlServiceProvider();
		Type? typeFromHandle = typeof(IProvideValueTarget);
		object[] array = new object[0 + 2];
		array[0] = val3;
		array[1] = buttonsPage;
		SimpleValueTargetProvider val70 = new SimpleValueTargetProvider(array, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Light"), (INameScope[])(object)new NameScope[3] { val67, val67, val67 }, false);
		object obj = (object)val70;
		val69.Add(typeFromHandle, (object)val70);
		val69.Add(typeof(IReferenceProvider), obj);
		val69.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(6, 14)));
		object light = val68.ProvideValue((IServiceProvider)val69);
		val3.Light = light;
		val2.Key = "PageBackgroundDark";
		StaticResourceExtension val71 = new StaticResourceExtension
		{
			Key = "PageBackgroundDark"
		};
		XamlServiceProvider val72 = new XamlServiceProvider();
		Type? typeFromHandle2 = typeof(IProvideValueTarget);
		object[] array2 = new object[0 + 2];
		array2[0] = val3;
		array2[1] = buttonsPage;
		SimpleValueTargetProvider val73 = new SimpleValueTargetProvider(array2, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Dark"), (INameScope[])(object)new NameScope[3] { val67, val67, val67 }, false);
		object obj2 = (object)val73;
		val72.Add(typeFromHandle2, (object)val73);
		val72.Add(typeof(IReferenceProvider), obj2);
		val72.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(6, 14)));
		object dark = val71.ProvideValue((IServiceProvider)val72);
		val3.Dark = dark;
		XamlServiceProvider val74 = new XamlServiceProvider();
		val74.Add(typeof(IProvideValueTarget), (object)new ValueTargetProvider((object)buttonsPage, (object)VisualElement.BackgroundColorProperty));
		val74.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(6, 14)));
		BindingBase val75 = ((IMarkupExtension<BindingBase>)(object)val3).ProvideValue((IServiceProvider)val74);
		((BindableObject)buttonsPage).SetBinding(VisualElement.BackgroundColorProperty, val75);
		((BindableObject)val66).SetValue(Grid.RowDefinitionsProperty, (object)new RowDefinitionCollection((RowDefinition[])(object)new RowDefinition[2]
		{
			new RowDefinition(GridLength.Star),
			new RowDefinition(new GridLength(120.0))
		}));
		((BindableObject)val53).SetValue(Grid.RowProperty, (object)0);
		((BindableObject)val52).SetValue(Layout.PaddingProperty, (object)new Thickness(20.0));
		((BindableObject)val52).SetValue(StackBase.SpacingProperty, (object)20.0);
		((BindableObject)val7).SetValue(Label.TextProperty, (object)"Button Styles & Events");
		((BindableObject)val7).SetValue(Label.FontSizeProperty, (object)24.0);
		((BindableObject)val7).SetValue(Label.FontAttributesProperty, (object)(FontAttributes)1);
		val4.Key = "TextPrimaryLight";
		StaticResourceExtension val76 = new StaticResourceExtension
		{
			Key = "TextPrimaryLight"
		};
		XamlServiceProvider val77 = new XamlServiceProvider();
		Type? typeFromHandle3 = typeof(IProvideValueTarget);
		object[] array3 = new object[0 + 6];
		array3[0] = val6;
		array3[1] = val7;
		array3[2] = val52;
		array3[3] = val53;
		array3[4] = val66;
		array3[5] = buttonsPage;
		SimpleValueTargetProvider val78 = new SimpleValueTargetProvider(array3, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Light"), (INameScope[])(object)new NameScope[7] { val67, val67, val67, val67, val67, val67, val67 }, false);
		object obj3 = (object)val78;
		val77.Add(typeFromHandle3, (object)val78);
		val77.Add(typeof(IReferenceProvider), obj3);
		val77.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(15, 24)));
		object light2 = val76.ProvideValue((IServiceProvider)val77);
		val6.Light = light2;
		val5.Key = "TextPrimaryDark";
		StaticResourceExtension val79 = new StaticResourceExtension
		{
			Key = "TextPrimaryDark"
		};
		XamlServiceProvider val80 = new XamlServiceProvider();
		Type? typeFromHandle4 = typeof(IProvideValueTarget);
		object[] array4 = new object[0 + 6];
		array4[0] = val6;
		array4[1] = val7;
		array4[2] = val52;
		array4[3] = val53;
		array4[4] = val66;
		array4[5] = buttonsPage;
		SimpleValueTargetProvider val81 = new SimpleValueTargetProvider(array4, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Dark"), (INameScope[])(object)new NameScope[7] { val67, val67, val67, val67, val67, val67, val67 }, false);
		object obj4 = (object)val81;
		val80.Add(typeFromHandle4, (object)val81);
		val80.Add(typeof(IReferenceProvider), obj4);
		val80.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(15, 24)));
		object dark2 = val79.ProvideValue((IServiceProvider)val80);
		val6.Dark = dark2;
		XamlServiceProvider val82 = new XamlServiceProvider();
		val82.Add(typeof(IProvideValueTarget), (object)new ValueTargetProvider((object)val7, (object)Label.TextColorProperty));
		val82.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(15, 24)));
		BindingBase val83 = ((IMarkupExtension<BindingBase>)(object)val6).ProvideValue((IServiceProvider)val82);
		((BindableObject)val7).SetBinding(Label.TextColorProperty, val83);
		((Layout)val52).Children.Add((IView)(object)val7);
		val8.Key = "ThemedFrame";
		StaticResourceExtension val84 = new StaticResourceExtension
		{
			Key = "ThemedFrame"
		};
		XamlServiceProvider val85 = new XamlServiceProvider();
		Type? typeFromHandle5 = typeof(IProvideValueTarget);
		object[] array5 = new object[0 + 5];
		array5[0] = val17;
		array5[1] = val52;
		array5[2] = val53;
		array5[3] = val66;
		array5[4] = buttonsPage;
		SimpleValueTargetProvider val86 = new SimpleValueTargetProvider(array5, (object)VisualElement.StyleProperty, (INameScope[])(object)new NameScope[6] { val67, val67, val67, val67, val67, val67 }, false);
		object obj5 = (object)val86;
		val85.Add(typeFromHandle5, (object)val86);
		val85.Add(typeof(IReferenceProvider), obj5);
		val85.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(18, 24)));
		object obj6 = val84.ProvideValue((IServiceProvider)val85);
		((BindableObject)val17).SetValue(VisualElement.StyleProperty, (obj6 == null || !typeof(BindingBase).IsAssignableFrom(obj6.GetType())) ? obj6 : obj6);
		((BindableObject)val17).SetValue(Frame.CornerRadiusProperty, (object)8f);
		((BindableObject)val17).SetValue(Layout.PaddingProperty, (object)new Thickness(15.0));
		((BindableObject)val16).SetValue(StackBase.SpacingProperty, (object)10.0);
		((BindableObject)val12).SetValue(Label.TextProperty, (object)"Basic Buttons");
		((BindableObject)val12).SetValue(Label.FontSizeProperty, (object)16.0);
		((BindableObject)val12).SetValue(Label.FontAttributesProperty, (object)(FontAttributes)1);
		val9.Key = "TextPrimaryLight";
		StaticResourceExtension val87 = new StaticResourceExtension
		{
			Key = "TextPrimaryLight"
		};
		XamlServiceProvider val88 = new XamlServiceProvider();
		Type? typeFromHandle6 = typeof(IProvideValueTarget);
		object[] array6 = new object[0 + 8];
		array6[0] = val11;
		array6[1] = val12;
		array6[2] = val16;
		array6[3] = val17;
		array6[4] = val52;
		array6[5] = val53;
		array6[6] = val66;
		array6[7] = buttonsPage;
		SimpleValueTargetProvider val89 = new SimpleValueTargetProvider(array6, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Light"), (INameScope[])(object)new NameScope[9] { val67, val67, val67, val67, val67, val67, val67, val67, val67 }, false);
		object obj7 = (object)val89;
		val88.Add(typeFromHandle6, (object)val89);
		val88.Add(typeof(IReferenceProvider), obj7);
		val88.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(21, 32)));
		object light3 = val87.ProvideValue((IServiceProvider)val88);
		val11.Light = light3;
		val10.Key = "TextPrimaryDark";
		StaticResourceExtension val90 = new StaticResourceExtension
		{
			Key = "TextPrimaryDark"
		};
		XamlServiceProvider val91 = new XamlServiceProvider();
		Type? typeFromHandle7 = typeof(IProvideValueTarget);
		object[] array7 = new object[0 + 8];
		array7[0] = val11;
		array7[1] = val12;
		array7[2] = val16;
		array7[3] = val17;
		array7[4] = val52;
		array7[5] = val53;
		array7[6] = val66;
		array7[7] = buttonsPage;
		SimpleValueTargetProvider val92 = new SimpleValueTargetProvider(array7, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Dark"), (INameScope[])(object)new NameScope[9] { val67, val67, val67, val67, val67, val67, val67, val67, val67 }, false);
		object obj8 = (object)val92;
		val91.Add(typeFromHandle7, (object)val92);
		val91.Add(typeof(IReferenceProvider), obj8);
		val91.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(21, 32)));
		object dark3 = val90.ProvideValue((IServiceProvider)val91);
		val11.Dark = dark3;
		XamlServiceProvider val93 = new XamlServiceProvider();
		val93.Add(typeof(IProvideValueTarget), (object)new ValueTargetProvider((object)val12, (object)Label.TextColorProperty));
		val93.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(21, 32)));
		BindingBase val94 = ((IMarkupExtension<BindingBase>)(object)val11).ProvideValue((IServiceProvider)val93);
		((BindableObject)val12).SetBinding(Label.TextColorProperty, val94);
		((Layout)val16).Children.Add((IView)(object)val12);
		((BindableObject)val13).SetValue(Button.TextProperty, (object)"Default Button");
		val13.Clicked += buttonsPage.OnDefaultBtnClicked;
		((Layout)val16).Children.Add((IView)(object)val13);
		((BindableObject)val15).SetValue(Button.TextProperty, (object)"Text Only");
		((BindableObject)val15).SetValue(VisualElement.BackgroundColorProperty, (object)Colors.Transparent);
		val14.Key = "PrimaryColor";
		StaticResourceExtension val95 = new StaticResourceExtension
		{
			Key = "PrimaryColor"
		};
		XamlServiceProvider val96 = new XamlServiceProvider();
		Type? typeFromHandle8 = typeof(IProvideValueTarget);
		object[] array8 = new object[0 + 7];
		array8[0] = val15;
		array8[1] = val16;
		array8[2] = val17;
		array8[3] = val52;
		array8[4] = val53;
		array8[5] = val66;
		array8[6] = buttonsPage;
		SimpleValueTargetProvider val97 = new SimpleValueTargetProvider(array8, (object)Button.TextColorProperty, (INameScope[])(object)new NameScope[8] { val67, val67, val67, val67, val67, val67, val67, val67 }, false);
		object obj9 = (object)val97;
		val96.Add(typeFromHandle8, (object)val97);
		val96.Add(typeof(IReferenceProvider), obj9);
		val96.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(24, 33)));
		object obj10 = val95.ProvideValue((IServiceProvider)val96);
		((BindableObject)val15).SetValue(Button.TextColorProperty, (obj10 == null || !typeof(BindingBase).IsAssignableFrom(obj10.GetType())) ? obj10 : obj10);
		val15.Clicked += buttonsPage.OnTextBtnClicked;
		((Layout)val16).Children.Add((IView)(object)val15);
		((BindableObject)val17).SetValue(ContentView.ContentProperty, (object)val16);
		((Layout)val52).Children.Add((IView)(object)val17);
		val18.Key = "ThemedFrame";
		StaticResourceExtension val98 = new StaticResourceExtension
		{
			Key = "ThemedFrame"
		};
		XamlServiceProvider val99 = new XamlServiceProvider();
		Type? typeFromHandle9 = typeof(IProvideValueTarget);
		object[] array9 = new object[0 + 5];
		array9[0] = val30;
		array9[1] = val52;
		array9[2] = val53;
		array9[3] = val66;
		array9[4] = buttonsPage;
		SimpleValueTargetProvider val100 = new SimpleValueTargetProvider(array9, (object)VisualElement.StyleProperty, (INameScope[])(object)new NameScope[6] { val67, val67, val67, val67, val67, val67 }, false);
		object obj11 = (object)val100;
		val99.Add(typeFromHandle9, (object)val100);
		val99.Add(typeof(IReferenceProvider), obj11);
		val99.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(29, 24)));
		object obj12 = val98.ProvideValue((IServiceProvider)val99);
		((BindableObject)val30).SetValue(VisualElement.StyleProperty, (obj12 == null || !typeof(BindingBase).IsAssignableFrom(obj12.GetType())) ? obj12 : obj12);
		((BindableObject)val30).SetValue(Frame.CornerRadiusProperty, (object)8f);
		((BindableObject)val30).SetValue(Layout.PaddingProperty, (object)new Thickness(15.0));
		((BindableObject)val29).SetValue(StackBase.SpacingProperty, (object)10.0);
		((BindableObject)val22).SetValue(Label.TextProperty, (object)"Styled Buttons");
		((BindableObject)val22).SetValue(Label.FontSizeProperty, (object)16.0);
		((BindableObject)val22).SetValue(Label.FontAttributesProperty, (object)(FontAttributes)1);
		val19.Key = "TextPrimaryLight";
		StaticResourceExtension val101 = new StaticResourceExtension
		{
			Key = "TextPrimaryLight"
		};
		XamlServiceProvider val102 = new XamlServiceProvider();
		Type? typeFromHandle10 = typeof(IProvideValueTarget);
		object[] array10 = new object[0 + 8];
		array10[0] = val21;
		array10[1] = val22;
		array10[2] = val29;
		array10[3] = val30;
		array10[4] = val52;
		array10[5] = val53;
		array10[6] = val66;
		array10[7] = buttonsPage;
		SimpleValueTargetProvider val103 = new SimpleValueTargetProvider(array10, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Light"), (INameScope[])(object)new NameScope[9] { val67, val67, val67, val67, val67, val67, val67, val67, val67 }, false);
		object obj13 = (object)val103;
		val102.Add(typeFromHandle10, (object)val103);
		val102.Add(typeof(IReferenceProvider), obj13);
		val102.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(32, 32)));
		object light4 = val101.ProvideValue((IServiceProvider)val102);
		val21.Light = light4;
		val20.Key = "TextPrimaryDark";
		StaticResourceExtension val104 = new StaticResourceExtension
		{
			Key = "TextPrimaryDark"
		};
		XamlServiceProvider val105 = new XamlServiceProvider();
		Type? typeFromHandle11 = typeof(IProvideValueTarget);
		object[] array11 = new object[0 + 8];
		array11[0] = val21;
		array11[1] = val22;
		array11[2] = val29;
		array11[3] = val30;
		array11[4] = val52;
		array11[5] = val53;
		array11[6] = val66;
		array11[7] = buttonsPage;
		SimpleValueTargetProvider val106 = new SimpleValueTargetProvider(array11, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Dark"), (INameScope[])(object)new NameScope[9] { val67, val67, val67, val67, val67, val67, val67, val67, val67 }, false);
		object obj14 = (object)val106;
		val105.Add(typeFromHandle11, (object)val106);
		val105.Add(typeof(IReferenceProvider), obj14);
		val105.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(32, 32)));
		object dark4 = val104.ProvideValue((IServiceProvider)val105);
		val21.Dark = dark4;
		XamlServiceProvider val107 = new XamlServiceProvider();
		val107.Add(typeof(IProvideValueTarget), (object)new ValueTargetProvider((object)val22, (object)Label.TextColorProperty));
		val107.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(32, 32)));
		BindingBase val108 = ((IMarkupExtension<BindingBase>)(object)val21).ProvideValue((IServiceProvider)val107);
		((BindableObject)val22).SetBinding(Label.TextColorProperty, val108);
		((Layout)val29).Children.Add((IView)(object)val22);
		((BindableObject)val28).SetValue(StackBase.SpacingProperty, (object)10.0);
		((BindableObject)val23).SetValue(Button.TextProperty, (object)"Primary");
		((BindableObject)val23).SetValue(VisualElement.BackgroundColorProperty, (object)new Color(11f / 85f, 0.5882353f, 81f / 85f, 1f));
		((BindableObject)val23).SetValue(Button.TextColorProperty, (object)Colors.White);
		((BindableObject)val23).SetValue(Button.CornerRadiusProperty, (object)5);
		val23.Clicked += buttonsPage.OnColorBtnClicked;
		((Layout)val28).Children.Add((IView)(object)val23);
		((BindableObject)val24).SetValue(Button.TextProperty, (object)"Success");
		((BindableObject)val24).SetValue(VisualElement.BackgroundColorProperty, (object)new Color(0.29803923f, 35f / 51f, 16f / 51f, 1f));
		((BindableObject)val24).SetValue(Button.TextColorProperty, (object)Colors.White);
		((BindableObject)val24).SetValue(Button.CornerRadiusProperty, (object)5);
		val24.Clicked += buttonsPage.OnColorBtnClicked;
		((Layout)val28).Children.Add((IView)(object)val24);
		((BindableObject)val25).SetValue(Button.TextProperty, (object)"Warning");
		((BindableObject)val25).SetValue(VisualElement.BackgroundColorProperty, (object)new Color(1f, 0.59607846f, 0f, 1f));
		((BindableObject)val25).SetValue(Button.TextColorProperty, (object)Colors.White);
		((BindableObject)val25).SetValue(Button.CornerRadiusProperty, (object)5);
		val25.Clicked += buttonsPage.OnColorBtnClicked;
		((Layout)val28).Children.Add((IView)(object)val25);
		((BindableObject)val26).SetValue(Button.TextProperty, (object)"Danger");
		((BindableObject)val26).SetValue(VisualElement.BackgroundColorProperty, (object)new Color(0.95686275f, 0.2627451f, 18f / 85f, 1f));
		((BindableObject)val26).SetValue(Button.TextColorProperty, (object)Colors.White);
		((BindableObject)val26).SetValue(Button.CornerRadiusProperty, (object)5);
		val26.Clicked += buttonsPage.OnColorBtnClicked;
		((Layout)val28).Children.Add((IView)(object)val26);
		((BindableObject)val27).SetValue(Button.TextProperty, (object)"Purple");
		((BindableObject)val27).SetValue(VisualElement.BackgroundColorProperty, (object)new Color(52f / 85f, 13f / 85f, 0.6901961f, 1f));
		((BindableObject)val27).SetValue(Button.TextColorProperty, (object)Colors.White);
		((BindableObject)val27).SetValue(Button.CornerRadiusProperty, (object)5);
		val27.Clicked += buttonsPage.OnColorBtnClicked;
		((Layout)val28).Children.Add((IView)(object)val27);
		((Layout)val29).Children.Add((IView)(object)val28);
		((BindableObject)val30).SetValue(ContentView.ContentProperty, (object)val29);
		((Layout)val52).Children.Add((IView)(object)val30);
		val31.Key = "ThemedFrame";
		StaticResourceExtension val109 = new StaticResourceExtension
		{
			Key = "ThemedFrame"
		};
		XamlServiceProvider val110 = new XamlServiceProvider();
		Type? typeFromHandle12 = typeof(IProvideValueTarget);
		object[] array12 = new object[0 + 5];
		array12[0] = val40;
		array12[1] = val52;
		array12[2] = val53;
		array12[3] = val66;
		array12[4] = buttonsPage;
		SimpleValueTargetProvider val111 = new SimpleValueTargetProvider(array12, (object)VisualElement.StyleProperty, (INameScope[])(object)new NameScope[6] { val67, val67, val67, val67, val67, val67 }, false);
		object obj15 = (object)val111;
		val110.Add(typeFromHandle12, (object)val111);
		val110.Add(typeof(IReferenceProvider), obj15);
		val110.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(44, 24)));
		object obj16 = val109.ProvideValue((IServiceProvider)val110);
		((BindableObject)val40).SetValue(VisualElement.StyleProperty, (obj16 == null || !typeof(BindingBase).IsAssignableFrom(obj16.GetType())) ? obj16 : obj16);
		((BindableObject)val40).SetValue(Frame.CornerRadiusProperty, (object)8f);
		((BindableObject)val40).SetValue(Layout.PaddingProperty, (object)new Thickness(15.0));
		((BindableObject)val39).SetValue(StackBase.SpacingProperty, (object)10.0);
		((BindableObject)val35).SetValue(Label.TextProperty, (object)"Button States");
		((BindableObject)val35).SetValue(Label.FontSizeProperty, (object)16.0);
		((BindableObject)val35).SetValue(Label.FontAttributesProperty, (object)(FontAttributes)1);
		val32.Key = "TextPrimaryLight";
		StaticResourceExtension val112 = new StaticResourceExtension
		{
			Key = "TextPrimaryLight"
		};
		XamlServiceProvider val113 = new XamlServiceProvider();
		Type? typeFromHandle13 = typeof(IProvideValueTarget);
		object[] array13 = new object[0 + 8];
		array13[0] = val34;
		array13[1] = val35;
		array13[2] = val39;
		array13[3] = val40;
		array13[4] = val52;
		array13[5] = val53;
		array13[6] = val66;
		array13[7] = buttonsPage;
		SimpleValueTargetProvider val114 = new SimpleValueTargetProvider(array13, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Light"), (INameScope[])(object)new NameScope[9] { val67, val67, val67, val67, val67, val67, val67, val67, val67 }, false);
		object obj17 = (object)val114;
		val113.Add(typeFromHandle13, (object)val114);
		val113.Add(typeof(IReferenceProvider), obj17);
		val113.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(47, 32)));
		object light5 = val112.ProvideValue((IServiceProvider)val113);
		val34.Light = light5;
		val33.Key = "TextPrimaryDark";
		StaticResourceExtension val115 = new StaticResourceExtension
		{
			Key = "TextPrimaryDark"
		};
		XamlServiceProvider val116 = new XamlServiceProvider();
		Type? typeFromHandle14 = typeof(IProvideValueTarget);
		object[] array14 = new object[0 + 8];
		array14[0] = val34;
		array14[1] = val35;
		array14[2] = val39;
		array14[3] = val40;
		array14[4] = val52;
		array14[5] = val53;
		array14[6] = val66;
		array14[7] = buttonsPage;
		SimpleValueTargetProvider val117 = new SimpleValueTargetProvider(array14, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Dark"), (INameScope[])(object)new NameScope[9] { val67, val67, val67, val67, val67, val67, val67, val67, val67 }, false);
		object obj18 = (object)val117;
		val116.Add(typeFromHandle14, (object)val117);
		val116.Add(typeof(IReferenceProvider), obj18);
		val116.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(47, 32)));
		object dark5 = val115.ProvideValue((IServiceProvider)val116);
		val34.Dark = dark5;
		XamlServiceProvider val118 = new XamlServiceProvider();
		val118.Add(typeof(IProvideValueTarget), (object)new ValueTargetProvider((object)val35, (object)Label.TextColorProperty));
		val118.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(47, 32)));
		BindingBase val119 = ((IMarkupExtension<BindingBase>)(object)val34).ProvideValue((IServiceProvider)val118);
		((BindableObject)val35).SetBinding(Label.TextColorProperty, val119);
		((Layout)val39).Children.Add((IView)(object)val35);
		((BindableObject)val36).SetValue(Button.TextProperty, (object)"Enabled Button");
		((BindableObject)val36).SetValue(VisualElement.IsEnabledProperty, (object)true);
		val36.Clicked += buttonsPage.OnEnabledBtnClicked;
		((Layout)val39).Children.Add((IView)(object)val36);
		((BindableObject)val37).SetValue(Button.TextProperty, (object)"Disabled Button");
		((BindableObject)val37).SetValue(VisualElement.IsEnabledProperty, (object)false);
		((Layout)val39).Children.Add((IView)(object)val37);
		((BindableObject)val38).SetValue(Button.TextProperty, (object)"Toggle Above Button");
		val38.Clicked += buttonsPage.OnToggleBtnClicked;
		((Layout)val39).Children.Add((IView)(object)val38);
		((BindableObject)val40).SetValue(ContentView.ContentProperty, (object)val39);
		((Layout)val52).Children.Add((IView)(object)val40);
		val41.Key = "ThemedFrame";
		StaticResourceExtension val120 = new StaticResourceExtension
		{
			Key = "ThemedFrame"
		};
		XamlServiceProvider val121 = new XamlServiceProvider();
		Type? typeFromHandle15 = typeof(IProvideValueTarget);
		object[] array15 = new object[0 + 5];
		array15[0] = val51;
		array15[1] = val52;
		array15[2] = val53;
		array15[3] = val66;
		array15[4] = buttonsPage;
		SimpleValueTargetProvider val122 = new SimpleValueTargetProvider(array15, (object)VisualElement.StyleProperty, (INameScope[])(object)new NameScope[6] { val67, val67, val67, val67, val67, val67 }, false);
		object obj19 = (object)val122;
		val121.Add(typeFromHandle15, (object)val122);
		val121.Add(typeof(IReferenceProvider), obj19);
		val121.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(55, 24)));
		object obj20 = val120.ProvideValue((IServiceProvider)val121);
		((BindableObject)val51).SetValue(VisualElement.StyleProperty, (obj20 == null || !typeof(BindingBase).IsAssignableFrom(obj20.GetType())) ? obj20 : obj20);
		((BindableObject)val51).SetValue(Frame.CornerRadiusProperty, (object)8f);
		((BindableObject)val51).SetValue(Layout.PaddingProperty, (object)new Thickness(15.0));
		((BindableObject)val50).SetValue(StackBase.SpacingProperty, (object)10.0);
		((BindableObject)val45).SetValue(Label.TextProperty, (object)"Button Variations");
		((BindableObject)val45).SetValue(Label.FontSizeProperty, (object)16.0);
		((BindableObject)val45).SetValue(Label.FontAttributesProperty, (object)(FontAttributes)1);
		val42.Key = "TextPrimaryLight";
		StaticResourceExtension val123 = new StaticResourceExtension
		{
			Key = "TextPrimaryLight"
		};
		XamlServiceProvider val124 = new XamlServiceProvider();
		Type? typeFromHandle16 = typeof(IProvideValueTarget);
		object[] array16 = new object[0 + 8];
		array16[0] = val44;
		array16[1] = val45;
		array16[2] = val50;
		array16[3] = val51;
		array16[4] = val52;
		array16[5] = val53;
		array16[6] = val66;
		array16[7] = buttonsPage;
		SimpleValueTargetProvider val125 = new SimpleValueTargetProvider(array16, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Light"), (INameScope[])(object)new NameScope[9] { val67, val67, val67, val67, val67, val67, val67, val67, val67 }, false);
		object obj21 = (object)val125;
		val124.Add(typeFromHandle16, (object)val125);
		val124.Add(typeof(IReferenceProvider), obj21);
		val124.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(58, 32)));
		object light6 = val123.ProvideValue((IServiceProvider)val124);
		val44.Light = light6;
		val43.Key = "TextPrimaryDark";
		StaticResourceExtension val126 = new StaticResourceExtension
		{
			Key = "TextPrimaryDark"
		};
		XamlServiceProvider val127 = new XamlServiceProvider();
		Type? typeFromHandle17 = typeof(IProvideValueTarget);
		object[] array17 = new object[0 + 8];
		array17[0] = val44;
		array17[1] = val45;
		array17[2] = val50;
		array17[3] = val51;
		array17[4] = val52;
		array17[5] = val53;
		array17[6] = val66;
		array17[7] = buttonsPage;
		SimpleValueTargetProvider val128 = new SimpleValueTargetProvider(array17, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Dark"), (INameScope[])(object)new NameScope[9] { val67, val67, val67, val67, val67, val67, val67, val67, val67 }, false);
		object obj22 = (object)val128;
		val127.Add(typeFromHandle17, (object)val128);
		val127.Add(typeof(IReferenceProvider), obj22);
		val127.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(58, 32)));
		object dark6 = val126.ProvideValue((IServiceProvider)val127);
		val44.Dark = dark6;
		XamlServiceProvider val129 = new XamlServiceProvider();
		val129.Add(typeof(IProvideValueTarget), (object)new ValueTargetProvider((object)val45, (object)Label.TextColorProperty));
		val129.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(58, 32)));
		BindingBase val130 = ((IMarkupExtension<BindingBase>)(object)val44).ProvideValue((IServiceProvider)val129);
		((BindableObject)val45).SetBinding(Label.TextColorProperty, val130);
		((Layout)val50).Children.Add((IView)(object)val45);
		((BindableObject)val46).SetValue(Button.TextProperty, (object)"Wide Button");
		((BindableObject)val46).SetValue(View.HorizontalOptionsProperty, (object)LayoutOptions.Fill);
		((BindableObject)val46).SetValue(VisualElement.BackgroundColorProperty, (object)new Color(0.40392157f, 0.22745098f, 61f / 85f, 1f));
		((BindableObject)val46).SetValue(Button.TextColorProperty, (object)Colors.White);
		val46.Clicked += buttonsPage.OnWideBtnClicked;
		((Layout)val50).Children.Add((IView)(object)val46);
		((BindableObject)val47).SetValue(Button.TextProperty, (object)"Tall Button");
		((BindableObject)val47).SetValue(VisualElement.HeightRequestProperty, (object)60.0);
		((BindableObject)val47).SetValue(VisualElement.BackgroundColorProperty, (object)new Color(0f, 0.5882353f, 8f / 15f, 1f));
		((BindableObject)val47).SetValue(Button.TextColorProperty, (object)Colors.White);
		val47.Clicked += buttonsPage.OnTallBtnClicked;
		((Layout)val50).Children.Add((IView)(object)val47);
		((BindableObject)val48).SetValue(Button.TextProperty, (object)"Round");
		((BindableObject)val48).SetValue(VisualElement.WidthRequestProperty, (object)80.0);
		((BindableObject)val48).SetValue(VisualElement.HeightRequestProperty, (object)80.0);
		((BindableObject)val48).SetValue(Button.CornerRadiusProperty, (object)40);
		((BindableObject)val48).SetValue(VisualElement.BackgroundColorProperty, (object)new Color(0.9137255f, 0.11764706f, 33f / 85f, 1f));
		((BindableObject)val48).SetValue(Button.TextColorProperty, (object)Colors.White);
		val48.Clicked += buttonsPage.OnRoundBtnClicked;
		((Layout)val49).Children.Add((IView)(object)val48);
		((Layout)val50).Children.Add((IView)(object)val49);
		((BindableObject)val51).SetValue(ContentView.ContentProperty, (object)val50);
		((Layout)val52).Children.Add((IView)(object)val51);
		val53.Content = (View)(object)val52;
		((Layout)val66).Children.Add((IView)(object)val53);
		((BindableObject)val65).SetValue(Grid.RowProperty, (object)1);
		((BindableObject)val65).SetValue(Layout.PaddingProperty, (object)new Thickness(10.0));
		((BindableObject)val65).SetValue(Frame.CornerRadiusProperty, (object)0f);
		val54.Light = "#F5F5F5";
		val54.Dark = "#1E1E1E";
		XamlServiceProvider val131 = new XamlServiceProvider();
		val131.Add(typeof(IProvideValueTarget), (object)new ValueTargetProvider((object)val65, (object)VisualElement.BackgroundColorProperty));
		val131.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(71, 16)));
		BindingBase val132 = ((IMarkupExtension<BindingBase>)(object)val54).ProvideValue((IServiceProvider)val131);
		((BindableObject)val65).SetBinding(VisualElement.BackgroundColorProperty, val132);
		((BindableObject)val58).SetValue(Label.TextProperty, (object)"Event Log:");
		((BindableObject)val58).SetValue(Label.FontSizeProperty, (object)12.0);
		((BindableObject)val58).SetValue(Label.FontAttributesProperty, (object)(FontAttributes)1);
		val55.Key = "TextPrimaryLight";
		StaticResourceExtension val133 = new StaticResourceExtension
		{
			Key = "TextPrimaryLight"
		};
		XamlServiceProvider val134 = new XamlServiceProvider();
		Type? typeFromHandle18 = typeof(IProvideValueTarget);
		object[] array18 = new object[0 + 6];
		array18[0] = val57;
		array18[1] = val58;
		array18[2] = val64;
		array18[3] = val65;
		array18[4] = val66;
		array18[5] = buttonsPage;
		SimpleValueTargetProvider val135 = new SimpleValueTargetProvider(array18, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Light"), (INameScope[])(object)new NameScope[7] { val67, val67, val67, val67, val67, val67, val67 }, false);
		object obj23 = (object)val135;
		val134.Add(typeFromHandle18, (object)val135);
		val134.Add(typeof(IReferenceProvider), obj23);
		val134.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(74, 24)));
		object light7 = val133.ProvideValue((IServiceProvider)val134);
		val57.Light = light7;
		val56.Key = "TextPrimaryDark";
		StaticResourceExtension val136 = new StaticResourceExtension
		{
			Key = "TextPrimaryDark"
		};
		XamlServiceProvider val137 = new XamlServiceProvider();
		Type? typeFromHandle19 = typeof(IProvideValueTarget);
		object[] array19 = new object[0 + 6];
		array19[0] = val57;
		array19[1] = val58;
		array19[2] = val64;
		array19[3] = val65;
		array19[4] = val66;
		array19[5] = buttonsPage;
		SimpleValueTargetProvider val138 = new SimpleValueTargetProvider(array19, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Dark"), (INameScope[])(object)new NameScope[7] { val67, val67, val67, val67, val67, val67, val67 }, false);
		object obj24 = (object)val138;
		val137.Add(typeFromHandle19, (object)val138);
		val137.Add(typeof(IReferenceProvider), obj24);
		val137.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(74, 24)));
		object dark7 = val136.ProvideValue((IServiceProvider)val137);
		val57.Dark = dark7;
		XamlServiceProvider val139 = new XamlServiceProvider();
		val139.Add(typeof(IProvideValueTarget), (object)new ValueTargetProvider((object)val58, (object)Label.TextColorProperty));
		val139.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(74, 24)));
		BindingBase val140 = ((IMarkupExtension<BindingBase>)(object)val57).ProvideValue((IServiceProvider)val139);
		((BindableObject)val58).SetBinding(Label.TextColorProperty, val140);
		((Layout)val64).Children.Add((IView)(object)val58);
		((BindableObject)val63).SetValue(VisualElement.HeightRequestProperty, (object)80.0);
		((BindableObject)val62).SetValue(Label.TextProperty, (object)"Events will appear here...");
		((BindableObject)val62).SetValue(Label.FontSizeProperty, (object)11.0);
		val59.Key = "TextSecondaryLight";
		StaticResourceExtension val141 = new StaticResourceExtension
		{
			Key = "TextSecondaryLight"
		};
		XamlServiceProvider val142 = new XamlServiceProvider();
		Type? typeFromHandle20 = typeof(IProvideValueTarget);
		object[] array20 = new object[0 + 7];
		array20[0] = val61;
		array20[1] = val62;
		array20[2] = val63;
		array20[3] = val64;
		array20[4] = val65;
		array20[5] = val66;
		array20[6] = buttonsPage;
		SimpleValueTargetProvider val143 = new SimpleValueTargetProvider(array20, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Light"), (INameScope[])(object)new NameScope[8] { val67, val67, val67, val67, val67, val67, val67, val67 }, false);
		object obj25 = (object)val143;
		val142.Add(typeFromHandle20, (object)val143);
		val142.Add(typeof(IReferenceProvider), obj25);
		val142.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(77, 28)));
		object light8 = val141.ProvideValue((IServiceProvider)val142);
		val61.Light = light8;
		val60.Key = "TextSecondaryDark";
		StaticResourceExtension val144 = new StaticResourceExtension
		{
			Key = "TextSecondaryDark"
		};
		XamlServiceProvider val145 = new XamlServiceProvider();
		Type? typeFromHandle21 = typeof(IProvideValueTarget);
		object[] array21 = new object[0 + 7];
		array21[0] = val61;
		array21[1] = val62;
		array21[2] = val63;
		array21[3] = val64;
		array21[4] = val65;
		array21[5] = val66;
		array21[6] = buttonsPage;
		SimpleValueTargetProvider val146 = new SimpleValueTargetProvider(array21, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Dark"), (INameScope[])(object)new NameScope[8] { val67, val67, val67, val67, val67, val67, val67, val67 }, false);
		object obj26 = (object)val146;
		val145.Add(typeFromHandle21, (object)val146);
		val145.Add(typeof(IReferenceProvider), obj26);
		val145.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(77, 28)));
		object dark8 = val144.ProvideValue((IServiceProvider)val145);
		val61.Dark = dark8;
		XamlServiceProvider val147 = new XamlServiceProvider();
		val147.Add(typeof(IProvideValueTarget), (object)new ValueTargetProvider((object)val62, (object)Label.TextColorProperty));
		val147.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(77, 28)));
		BindingBase val148 = ((IMarkupExtension<BindingBase>)(object)val61).ProvideValue((IServiceProvider)val147);
		((BindableObject)val62).SetBinding(Label.TextColorProperty, val148);
		((BindableObject)val62).SetValue(Label.LineBreakModeProperty, (object)(LineBreakMode)1);
		val63.Content = (View)(object)val62;
		((Layout)val64).Children.Add((IView)(object)val63);
		((BindableObject)val65).SetValue(ContentView.ContentProperty, (object)val64);
		((Layout)val66).Children.Add((IView)(object)val65);
		((BindableObject)buttonsPage).SetValue(ContentPage.ContentProperty, (object)val66);
	}
}
