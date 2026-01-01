using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
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

[XamlFilePath("Pages/PickersPage.xaml")]
public class PickersPage : ContentPage
{
	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private Picker ColorPicker;

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private Label ColorOutput;

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private DatePicker DatePickerControl;

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private Label DateOutput;

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private TimePicker TimePickerControl;

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private Label TimeOutput;

	public PickersPage()
	{
		InitializeComponent();
	}

	private void OnColorPickerChanged(object? sender, EventArgs e)
	{
		if (ColorPicker.SelectedIndex >= 0)
		{
			ColorOutput.Text = $"Selected: {ColorPicker.SelectedItem}";
		}
	}

	private void OnDateSelected(object? sender, DateChangedEventArgs e)
	{
		DateOutput.Text = $"Selected: {e.NewDate:d}";
	}

	private void OnTimeChanged(object? sender, PropertyChangedEventArgs e)
	{
		if (e.PropertyName == "Time")
		{
			TimeOutput.Text = $"Selected: {TimePickerControl.Time:hh\\:mm}";
		}
	}

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	[MemberNotNull("ColorPicker")]
	[MemberNotNull("ColorOutput")]
	[MemberNotNull("DatePickerControl")]
	[MemberNotNull("DateOutput")]
	[MemberNotNull("TimePickerControl")]
	[MemberNotNull("TimeOutput")]
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
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Expected O, but got Unknown
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Expected O, but got Unknown
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Expected O, but got Unknown
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Expected O, but got Unknown
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Expected O, but got Unknown
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Expected O, but got Unknown
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Expected O, but got Unknown
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Expected O, but got Unknown
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Expected O, but got Unknown
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Expected O, but got Unknown
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Expected O, but got Unknown
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Expected O, but got Unknown
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Expected O, but got Unknown
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Expected O, but got Unknown
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0126: Expected O, but got Unknown
		//IL_0126: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Expected O, but got Unknown
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Expected O, but got Unknown
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Expected O, but got Unknown
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Expected O, but got Unknown
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_0149: Expected O, but got Unknown
		//IL_0149: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Expected O, but got Unknown
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		//IL_0157: Expected O, but got Unknown
		//IL_0157: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Expected O, but got Unknown
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Expected O, but got Unknown
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_016c: Expected O, but got Unknown
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0173: Expected O, but got Unknown
		//IL_0173: Unknown result type (might be due to invalid IL or missing references)
		//IL_017a: Expected O, but got Unknown
		//IL_017a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0181: Expected O, but got Unknown
		//IL_0181: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Expected O, but got Unknown
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		//IL_018f: Expected O, but got Unknown
		//IL_018f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0196: Expected O, but got Unknown
		//IL_0196: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Expected O, but got Unknown
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a4: Expected O, but got Unknown
		//IL_01a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ab: Expected O, but got Unknown
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
		//IL_01ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d5: Expected O, but got Unknown
		//IL_01d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dc: Expected O, but got Unknown
		//IL_01dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e3: Expected O, but got Unknown
		//IL_01e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ea: Expected O, but got Unknown
		//IL_01ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f1: Expected O, but got Unknown
		//IL_01f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f8: Expected O, but got Unknown
		//IL_01f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ff: Expected O, but got Unknown
		//IL_01ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0206: Expected O, but got Unknown
		//IL_0206: Unknown result type (might be due to invalid IL or missing references)
		//IL_020d: Expected O, but got Unknown
		//IL_020d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0214: Expected O, but got Unknown
		//IL_0214: Unknown result type (might be due to invalid IL or missing references)
		//IL_021b: Expected O, but got Unknown
		//IL_021b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0222: Expected O, but got Unknown
		//IL_0222: Unknown result type (might be due to invalid IL or missing references)
		//IL_0229: Expected O, but got Unknown
		//IL_0236: Unknown result type (might be due to invalid IL or missing references)
		//IL_046f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0474: Unknown result type (might be due to invalid IL or missing references)
		//IL_047f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0484: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d8: Expected O, but got Unknown
		//IL_04dd: Expected O, but got Unknown
		//IL_04dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_04fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0507: Expected O, but got Unknown
		//IL_0502: Unknown result type (might be due to invalid IL or missing references)
		//IL_050c: Expected O, but got Unknown
		//IL_0511: Expected O, but got Unknown
		//IL_0526: Unknown result type (might be due to invalid IL or missing references)
		//IL_052b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0536: Unknown result type (might be due to invalid IL or missing references)
		//IL_053b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0587: Unknown result type (might be due to invalid IL or missing references)
		//IL_058c: Unknown result type (might be due to invalid IL or missing references)
		//IL_058f: Expected O, but got Unknown
		//IL_0594: Expected O, but got Unknown
		//IL_0594: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_05be: Expected O, but got Unknown
		//IL_05b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c3: Expected O, but got Unknown
		//IL_05c8: Expected O, but got Unknown
		//IL_05d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f4: Expected O, but got Unknown
		//IL_05f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0602: Unknown result type (might be due to invalid IL or missing references)
		//IL_060c: Expected O, but got Unknown
		//IL_0607: Unknown result type (might be due to invalid IL or missing references)
		//IL_0611: Expected O, but got Unknown
		//IL_0616: Expected O, but got Unknown
		//IL_0636: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_06bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0727: Unknown result type (might be due to invalid IL or missing references)
		//IL_072c: Unknown result type (might be due to invalid IL or missing references)
		//IL_072f: Expected O, but got Unknown
		//IL_0734: Expected O, but got Unknown
		//IL_0734: Unknown result type (might be due to invalid IL or missing references)
		//IL_0746: Unknown result type (might be due to invalid IL or missing references)
		//IL_0755: Unknown result type (might be due to invalid IL or missing references)
		//IL_075f: Expected O, but got Unknown
		//IL_075a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0764: Expected O, but got Unknown
		//IL_0769: Expected O, but got Unknown
		//IL_0780: Unknown result type (might be due to invalid IL or missing references)
		//IL_0785: Unknown result type (might be due to invalid IL or missing references)
		//IL_0790: Unknown result type (might be due to invalid IL or missing references)
		//IL_0795: Unknown result type (might be due to invalid IL or missing references)
		//IL_0800: Unknown result type (might be due to invalid IL or missing references)
		//IL_0805: Unknown result type (might be due to invalid IL or missing references)
		//IL_0808: Expected O, but got Unknown
		//IL_080d: Expected O, but got Unknown
		//IL_080d: Unknown result type (might be due to invalid IL or missing references)
		//IL_081f: Unknown result type (might be due to invalid IL or missing references)
		//IL_082e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0838: Expected O, but got Unknown
		//IL_0833: Unknown result type (might be due to invalid IL or missing references)
		//IL_083d: Expected O, but got Unknown
		//IL_0842: Expected O, but got Unknown
		//IL_084f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0854: Unknown result type (might be due to invalid IL or missing references)
		//IL_0866: Unknown result type (might be due to invalid IL or missing references)
		//IL_0870: Expected O, but got Unknown
		//IL_0870: Unknown result type (might be due to invalid IL or missing references)
		//IL_087f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0889: Expected O, but got Unknown
		//IL_0884: Unknown result type (might be due to invalid IL or missing references)
		//IL_088e: Expected O, but got Unknown
		//IL_0893: Expected O, but got Unknown
		//IL_08bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_08c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_08cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_08d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0924: Unknown result type (might be due to invalid IL or missing references)
		//IL_0929: Unknown result type (might be due to invalid IL or missing references)
		//IL_092c: Expected O, but got Unknown
		//IL_0931: Expected O, but got Unknown
		//IL_0931: Unknown result type (might be due to invalid IL or missing references)
		//IL_0943: Unknown result type (might be due to invalid IL or missing references)
		//IL_0952: Unknown result type (might be due to invalid IL or missing references)
		//IL_095c: Expected O, but got Unknown
		//IL_0957: Unknown result type (might be due to invalid IL or missing references)
		//IL_0961: Expected O, but got Unknown
		//IL_0966: Expected O, but got Unknown
		//IL_09be: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a30: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a35: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a40: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a45: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ac4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ac9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0acc: Expected O, but got Unknown
		//IL_0ad1: Expected O, but got Unknown
		//IL_0ad1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ae3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0af2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0afc: Expected O, but got Unknown
		//IL_0af7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b01: Expected O, but got Unknown
		//IL_0b06: Expected O, but got Unknown
		//IL_0b1d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b22: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b2d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b32: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bb1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bb6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bb9: Expected O, but got Unknown
		//IL_0bbe: Expected O, but got Unknown
		//IL_0bbe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bd0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bdf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0be9: Expected O, but got Unknown
		//IL_0be4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bee: Expected O, but got Unknown
		//IL_0bf3: Expected O, but got Unknown
		//IL_0c00: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c05: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c17: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c21: Expected O, but got Unknown
		//IL_0c21: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c30: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c3a: Expected O, but got Unknown
		//IL_0c35: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c3f: Expected O, but got Unknown
		//IL_0c44: Expected O, but got Unknown
		//IL_0c7f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c84: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c8f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c94: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d13: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d18: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d1b: Expected O, but got Unknown
		//IL_0d20: Expected O, but got Unknown
		//IL_0d20: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d32: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d41: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d4b: Expected O, but got Unknown
		//IL_0d46: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d50: Expected O, but got Unknown
		//IL_0d55: Expected O, but got Unknown
		//IL_0d6c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d71: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d7c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d81: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e00: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e05: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e08: Expected O, but got Unknown
		//IL_0e0d: Expected O, but got Unknown
		//IL_0e0d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e1f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e2e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e38: Expected O, but got Unknown
		//IL_0e33: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e3d: Expected O, but got Unknown
		//IL_0e42: Expected O, but got Unknown
		//IL_0e4f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e54: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e66: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e70: Expected O, but got Unknown
		//IL_0e70: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e7f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e89: Expected O, but got Unknown
		//IL_0e84: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e8e: Expected O, but got Unknown
		//IL_0e93: Expected O, but got Unknown
		//IL_0f18: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f1d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f28: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f2d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fac: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fb1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fb4: Expected O, but got Unknown
		//IL_0fb9: Expected O, but got Unknown
		//IL_0fb9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fcb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fda: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fe4: Expected O, but got Unknown
		//IL_0fdf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fe9: Expected O, but got Unknown
		//IL_0fee: Expected O, but got Unknown
		//IL_1005: Unknown result type (might be due to invalid IL or missing references)
		//IL_100a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1015: Unknown result type (might be due to invalid IL or missing references)
		//IL_101a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1099: Unknown result type (might be due to invalid IL or missing references)
		//IL_109e: Unknown result type (might be due to invalid IL or missing references)
		//IL_10a1: Expected O, but got Unknown
		//IL_10a6: Expected O, but got Unknown
		//IL_10a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_10b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_10c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_10d1: Expected O, but got Unknown
		//IL_10cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_10d6: Expected O, but got Unknown
		//IL_10db: Expected O, but got Unknown
		//IL_10e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_10ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_10ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_1109: Expected O, but got Unknown
		//IL_1109: Unknown result type (might be due to invalid IL or missing references)
		//IL_1118: Unknown result type (might be due to invalid IL or missing references)
		//IL_1122: Expected O, but got Unknown
		//IL_111d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1127: Expected O, but got Unknown
		//IL_112c: Expected O, but got Unknown
		//IL_1172: Unknown result type (might be due to invalid IL or missing references)
		//IL_1177: Unknown result type (might be due to invalid IL or missing references)
		//IL_1182: Unknown result type (might be due to invalid IL or missing references)
		//IL_1187: Unknown result type (might be due to invalid IL or missing references)
		//IL_11d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_11de: Unknown result type (might be due to invalid IL or missing references)
		//IL_11e1: Expected O, but got Unknown
		//IL_11e6: Expected O, but got Unknown
		//IL_11e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_11f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_1207: Unknown result type (might be due to invalid IL or missing references)
		//IL_1211: Expected O, but got Unknown
		//IL_120c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1216: Expected O, but got Unknown
		//IL_121b: Expected O, but got Unknown
		//IL_1273: Unknown result type (might be due to invalid IL or missing references)
		//IL_12e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_12ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_12f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_12fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_1379: Unknown result type (might be due to invalid IL or missing references)
		//IL_137e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1381: Expected O, but got Unknown
		//IL_1386: Expected O, but got Unknown
		//IL_1386: Unknown result type (might be due to invalid IL or missing references)
		//IL_1398: Unknown result type (might be due to invalid IL or missing references)
		//IL_13a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_13b1: Expected O, but got Unknown
		//IL_13ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_13b6: Expected O, but got Unknown
		//IL_13bb: Expected O, but got Unknown
		//IL_13d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_13d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_13e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_13e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_1466: Unknown result type (might be due to invalid IL or missing references)
		//IL_146b: Unknown result type (might be due to invalid IL or missing references)
		//IL_146e: Expected O, but got Unknown
		//IL_1473: Expected O, but got Unknown
		//IL_1473: Unknown result type (might be due to invalid IL or missing references)
		//IL_1485: Unknown result type (might be due to invalid IL or missing references)
		//IL_1494: Unknown result type (might be due to invalid IL or missing references)
		//IL_149e: Expected O, but got Unknown
		//IL_1499: Unknown result type (might be due to invalid IL or missing references)
		//IL_14a3: Expected O, but got Unknown
		//IL_14a8: Expected O, but got Unknown
		//IL_14b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_14ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_14cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_14d6: Expected O, but got Unknown
		//IL_14d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_14e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_14ef: Expected O, but got Unknown
		//IL_14ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_14f4: Expected O, but got Unknown
		//IL_14f9: Expected O, but got Unknown
		//IL_1534: Unknown result type (might be due to invalid IL or missing references)
		//IL_1539: Unknown result type (might be due to invalid IL or missing references)
		//IL_1544: Unknown result type (might be due to invalid IL or missing references)
		//IL_1549: Unknown result type (might be due to invalid IL or missing references)
		//IL_15c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_15cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_15d0: Expected O, but got Unknown
		//IL_15d5: Expected O, but got Unknown
		//IL_15d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_15e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_15f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_1600: Expected O, but got Unknown
		//IL_15fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_1605: Expected O, but got Unknown
		//IL_160a: Expected O, but got Unknown
		//IL_1621: Unknown result type (might be due to invalid IL or missing references)
		//IL_1626: Unknown result type (might be due to invalid IL or missing references)
		//IL_1631: Unknown result type (might be due to invalid IL or missing references)
		//IL_1636: Unknown result type (might be due to invalid IL or missing references)
		//IL_16b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_16ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_16bd: Expected O, but got Unknown
		//IL_16c2: Expected O, but got Unknown
		//IL_16c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_16d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_16e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_16ed: Expected O, but got Unknown
		//IL_16e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_16f2: Expected O, but got Unknown
		//IL_16f7: Expected O, but got Unknown
		//IL_1704: Unknown result type (might be due to invalid IL or missing references)
		//IL_1709: Unknown result type (might be due to invalid IL or missing references)
		//IL_171b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1725: Expected O, but got Unknown
		//IL_1725: Unknown result type (might be due to invalid IL or missing references)
		//IL_1734: Unknown result type (might be due to invalid IL or missing references)
		//IL_173e: Expected O, but got Unknown
		//IL_1739: Unknown result type (might be due to invalid IL or missing references)
		//IL_1743: Expected O, but got Unknown
		//IL_1748: Expected O, but got Unknown
		//IL_17ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_17b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_17be: Unknown result type (might be due to invalid IL or missing references)
		//IL_17c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_1842: Unknown result type (might be due to invalid IL or missing references)
		//IL_1847: Unknown result type (might be due to invalid IL or missing references)
		//IL_184a: Expected O, but got Unknown
		//IL_184f: Expected O, but got Unknown
		//IL_184f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1861: Unknown result type (might be due to invalid IL or missing references)
		//IL_1870: Unknown result type (might be due to invalid IL or missing references)
		//IL_187a: Expected O, but got Unknown
		//IL_1875: Unknown result type (might be due to invalid IL or missing references)
		//IL_187f: Expected O, but got Unknown
		//IL_1884: Expected O, but got Unknown
		//IL_189b: Unknown result type (might be due to invalid IL or missing references)
		//IL_18a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_18ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_18b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_192f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1934: Unknown result type (might be due to invalid IL or missing references)
		//IL_1937: Expected O, but got Unknown
		//IL_193c: Expected O, but got Unknown
		//IL_193c: Unknown result type (might be due to invalid IL or missing references)
		//IL_194e: Unknown result type (might be due to invalid IL or missing references)
		//IL_195d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1967: Expected O, but got Unknown
		//IL_1962: Unknown result type (might be due to invalid IL or missing references)
		//IL_196c: Expected O, but got Unknown
		//IL_1971: Expected O, but got Unknown
		//IL_197e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1983: Unknown result type (might be due to invalid IL or missing references)
		//IL_1995: Unknown result type (might be due to invalid IL or missing references)
		//IL_199f: Expected O, but got Unknown
		//IL_199f: Unknown result type (might be due to invalid IL or missing references)
		//IL_19ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_19b8: Expected O, but got Unknown
		//IL_19b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_19bd: Expected O, but got Unknown
		//IL_19c2: Expected O, but got Unknown
		//IL_1a08: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a0d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a18: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a1d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a6f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a74: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a77: Expected O, but got Unknown
		//IL_1a7c: Expected O, but got Unknown
		//IL_1a7c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a8e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a9d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1aa7: Expected O, but got Unknown
		//IL_1aa2: Unknown result type (might be due to invalid IL or missing references)
		//IL_1aac: Expected O, but got Unknown
		//IL_1ab1: Expected O, but got Unknown
		//IL_1b09: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b7b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b80: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b8b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b90: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c0f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c14: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c17: Expected O, but got Unknown
		//IL_1c1c: Expected O, but got Unknown
		//IL_1c1c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c2e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c3d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c47: Expected O, but got Unknown
		//IL_1c42: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c4c: Expected O, but got Unknown
		//IL_1c51: Expected O, but got Unknown
		//IL_1c68: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c6d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c78: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c7d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1cfc: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d01: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d04: Expected O, but got Unknown
		//IL_1d09: Expected O, but got Unknown
		//IL_1d09: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d1b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d2a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d34: Expected O, but got Unknown
		//IL_1d2f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d39: Expected O, but got Unknown
		//IL_1d3e: Expected O, but got Unknown
		//IL_1d4b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d50: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d62: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d6c: Expected O, but got Unknown
		//IL_1d6c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d7b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d85: Expected O, but got Unknown
		//IL_1d80: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d8a: Expected O, but got Unknown
		//IL_1d8f: Expected O, but got Unknown
		//IL_1dca: Unknown result type (might be due to invalid IL or missing references)
		//IL_1dcf: Unknown result type (might be due to invalid IL or missing references)
		//IL_1dda: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ddf: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e5e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e63: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e66: Expected O, but got Unknown
		//IL_1e6b: Expected O, but got Unknown
		//IL_1e6b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e7d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e8c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e96: Expected O, but got Unknown
		//IL_1e91: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e9b: Expected O, but got Unknown
		//IL_1ea0: Expected O, but got Unknown
		//IL_1eb7: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ebc: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ec7: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ecc: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f4b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f50: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f53: Expected O, but got Unknown
		//IL_1f58: Expected O, but got Unknown
		//IL_1f58: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f6a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f79: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f83: Expected O, but got Unknown
		//IL_1f7e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f88: Expected O, but got Unknown
		//IL_1f8d: Expected O, but got Unknown
		//IL_1f9a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f9f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1fb1: Unknown result type (might be due to invalid IL or missing references)
		//IL_1fbb: Expected O, but got Unknown
		//IL_1fbb: Unknown result type (might be due to invalid IL or missing references)
		//IL_1fca: Unknown result type (might be due to invalid IL or missing references)
		//IL_1fd4: Expected O, but got Unknown
		//IL_1fcf: Unknown result type (might be due to invalid IL or missing references)
		//IL_1fd9: Expected O, but got Unknown
		//IL_1fde: Expected O, but got Unknown
		//IL_2044: Unknown result type (might be due to invalid IL or missing references)
		//IL_2049: Unknown result type (might be due to invalid IL or missing references)
		//IL_2054: Unknown result type (might be due to invalid IL or missing references)
		//IL_2059: Unknown result type (might be due to invalid IL or missing references)
		//IL_20d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_20dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_20e0: Expected O, but got Unknown
		//IL_20e5: Expected O, but got Unknown
		//IL_20e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_20f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_2106: Unknown result type (might be due to invalid IL or missing references)
		//IL_2110: Expected O, but got Unknown
		//IL_210b: Unknown result type (might be due to invalid IL or missing references)
		//IL_2115: Expected O, but got Unknown
		//IL_211a: Expected O, but got Unknown
		//IL_2131: Unknown result type (might be due to invalid IL or missing references)
		//IL_2136: Unknown result type (might be due to invalid IL or missing references)
		//IL_2141: Unknown result type (might be due to invalid IL or missing references)
		//IL_2146: Unknown result type (might be due to invalid IL or missing references)
		//IL_21c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_21ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_21cd: Expected O, but got Unknown
		//IL_21d2: Expected O, but got Unknown
		//IL_21d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_21e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_21f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_21fd: Expected O, but got Unknown
		//IL_21f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_2202: Expected O, but got Unknown
		//IL_2207: Expected O, but got Unknown
		//IL_2214: Unknown result type (might be due to invalid IL or missing references)
		//IL_2219: Unknown result type (might be due to invalid IL or missing references)
		//IL_222b: Unknown result type (might be due to invalid IL or missing references)
		//IL_2235: Expected O, but got Unknown
		//IL_2235: Unknown result type (might be due to invalid IL or missing references)
		//IL_2244: Unknown result type (might be due to invalid IL or missing references)
		//IL_224e: Expected O, but got Unknown
		//IL_2249: Unknown result type (might be due to invalid IL or missing references)
		//IL_2253: Expected O, but got Unknown
		//IL_2258: Expected O, but got Unknown
		//IL_22b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_22e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_22e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_22f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_2302: Expected O, but got Unknown
		//IL_2302: Unknown result type (might be due to invalid IL or missing references)
		//IL_2311: Unknown result type (might be due to invalid IL or missing references)
		//IL_231b: Expected O, but got Unknown
		//IL_2316: Unknown result type (might be due to invalid IL or missing references)
		//IL_2320: Expected O, but got Unknown
		//IL_2325: Expected O, but got Unknown
		//IL_23a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_23ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_23bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_23c7: Expected O, but got Unknown
		//IL_23c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_23d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_23e0: Expected O, but got Unknown
		//IL_23db: Unknown result type (might be due to invalid IL or missing references)
		//IL_23e5: Expected O, but got Unknown
		//IL_23ea: Expected O, but got Unknown
		//IL_2425: Unknown result type (might be due to invalid IL or missing references)
		//IL_242a: Unknown result type (might be due to invalid IL or missing references)
		//IL_2435: Unknown result type (might be due to invalid IL or missing references)
		//IL_243a: Unknown result type (might be due to invalid IL or missing references)
		//IL_24a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_24a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_24a8: Expected O, but got Unknown
		//IL_24ad: Expected O, but got Unknown
		//IL_24ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_24bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_24ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_24d8: Expected O, but got Unknown
		//IL_24d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_24dd: Expected O, but got Unknown
		//IL_24e2: Expected O, but got Unknown
		//IL_2592: Unknown result type (might be due to invalid IL or missing references)
		//IL_259c: Expected O, but got Unknown
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
		StaticResourceExtension val13 = new StaticResourceExtension();
		StaticResourceExtension val14 = new StaticResourceExtension();
		AppThemeBindingExtension val15 = new AppThemeBindingExtension();
		Label val16 = new Label();
		Type typeFromHandle = typeof(string);
		string text = "Red";
		string text2 = "Green";
		string text3 = "Blue";
		string text4 = "Yellow";
		string text5 = "Purple";
		string[] array = new string[5] { text, text2, text3, text4, text5 };
		Picker val17 = new Picker();
		StaticResourceExtension val18 = new StaticResourceExtension();
		StaticResourceExtension val19 = new StaticResourceExtension();
		AppThemeBindingExtension val20 = new AppThemeBindingExtension();
		Label val21 = new Label();
		VerticalStackLayout val22 = new VerticalStackLayout();
		Frame val23 = new Frame();
		StaticResourceExtension val24 = new StaticResourceExtension();
		StaticResourceExtension val25 = new StaticResourceExtension();
		StaticResourceExtension val26 = new StaticResourceExtension();
		AppThemeBindingExtension val27 = new AppThemeBindingExtension();
		Label val28 = new Label();
		StaticResourceExtension val29 = new StaticResourceExtension();
		StaticResourceExtension val30 = new StaticResourceExtension();
		AppThemeBindingExtension val31 = new AppThemeBindingExtension();
		Label val32 = new Label();
		DatePicker val33 = new DatePicker();
		StaticResourceExtension val34 = new StaticResourceExtension();
		StaticResourceExtension val35 = new StaticResourceExtension();
		AppThemeBindingExtension val36 = new AppThemeBindingExtension();
		Label val37 = new Label();
		VerticalStackLayout val38 = new VerticalStackLayout();
		Frame val39 = new Frame();
		StaticResourceExtension val40 = new StaticResourceExtension();
		StaticResourceExtension val41 = new StaticResourceExtension();
		StaticResourceExtension val42 = new StaticResourceExtension();
		AppThemeBindingExtension val43 = new AppThemeBindingExtension();
		Label val44 = new Label();
		StaticResourceExtension val45 = new StaticResourceExtension();
		StaticResourceExtension val46 = new StaticResourceExtension();
		AppThemeBindingExtension val47 = new AppThemeBindingExtension();
		Label val48 = new Label();
		TimePicker val49 = new TimePicker();
		StaticResourceExtension val50 = new StaticResourceExtension();
		StaticResourceExtension val51 = new StaticResourceExtension();
		AppThemeBindingExtension val52 = new AppThemeBindingExtension();
		Label val53 = new Label();
		VerticalStackLayout val54 = new VerticalStackLayout();
		Frame val55 = new Frame();
		AppThemeBindingExtension val56 = new AppThemeBindingExtension();
		AppThemeBindingExtension val57 = new AppThemeBindingExtension();
		Label val58 = new Label();
		StaticResourceExtension val59 = new StaticResourceExtension();
		Entry val60 = new Entry();
		DatePicker val61 = new DatePicker();
		TimePicker val62 = new TimePicker();
		HorizontalStackLayout val63 = new HorizontalStackLayout();
		Button val64 = new Button();
		VerticalStackLayout val65 = new VerticalStackLayout();
		Frame val66 = new Frame();
		VerticalStackLayout val67 = new VerticalStackLayout();
		ScrollView val68 = new ScrollView();
		PickersPage pickersPage;
		NameScope val69 = (NameScope)(((object)NameScope.GetNameScope((BindableObject)(object)(pickersPage = this))) ?? ((object)new NameScope()));
		NameScope.SetNameScope((BindableObject)(object)pickersPage, (INameScope)(object)val69);
		((Element)val68).transientNamescope = (INameScope)(object)val69;
		((Element)val67).transientNamescope = (INameScope)(object)val69;
		((Element)val7).transientNamescope = (INameScope)(object)val69;
		((Element)val23).transientNamescope = (INameScope)(object)val69;
		((Element)val22).transientNamescope = (INameScope)(object)val69;
		((Element)val12).transientNamescope = (INameScope)(object)val69;
		((Element)val16).transientNamescope = (INameScope)(object)val69;
		((Element)val17).transientNamescope = (INameScope)(object)val69;
		((INameScope)val69).RegisterName("ColorPicker", (object)val17);
		if (((Element)val17).StyleId == null)
		{
			((Element)val17).StyleId = "ColorPicker";
		}
		((Element)val21).transientNamescope = (INameScope)(object)val69;
		((INameScope)val69).RegisterName("ColorOutput", (object)val21);
		if (((Element)val21).StyleId == null)
		{
			((Element)val21).StyleId = "ColorOutput";
		}
		((Element)val39).transientNamescope = (INameScope)(object)val69;
		((Element)val38).transientNamescope = (INameScope)(object)val69;
		((Element)val28).transientNamescope = (INameScope)(object)val69;
		((Element)val32).transientNamescope = (INameScope)(object)val69;
		((Element)val33).transientNamescope = (INameScope)(object)val69;
		((INameScope)val69).RegisterName("DatePickerControl", (object)val33);
		if (((Element)val33).StyleId == null)
		{
			((Element)val33).StyleId = "DatePickerControl";
		}
		((Element)val37).transientNamescope = (INameScope)(object)val69;
		((INameScope)val69).RegisterName("DateOutput", (object)val37);
		if (((Element)val37).StyleId == null)
		{
			((Element)val37).StyleId = "DateOutput";
		}
		((Element)val55).transientNamescope = (INameScope)(object)val69;
		((Element)val54).transientNamescope = (INameScope)(object)val69;
		((Element)val44).transientNamescope = (INameScope)(object)val69;
		((Element)val48).transientNamescope = (INameScope)(object)val69;
		((Element)val49).transientNamescope = (INameScope)(object)val69;
		((INameScope)val69).RegisterName("TimePickerControl", (object)val49);
		if (((Element)val49).StyleId == null)
		{
			((Element)val49).StyleId = "TimePickerControl";
		}
		((Element)val53).transientNamescope = (INameScope)(object)val69;
		((INameScope)val69).RegisterName("TimeOutput", (object)val53);
		if (((Element)val53).StyleId == null)
		{
			((Element)val53).StyleId = "TimeOutput";
		}
		((Element)val66).transientNamescope = (INameScope)(object)val69;
		((Element)val65).transientNamescope = (INameScope)(object)val69;
		((Element)val58).transientNamescope = (INameScope)(object)val69;
		((Element)val60).transientNamescope = (INameScope)(object)val69;
		((Element)val63).transientNamescope = (INameScope)(object)val69;
		((Element)val61).transientNamescope = (INameScope)(object)val69;
		((Element)val62).transientNamescope = (INameScope)(object)val69;
		((Element)val64).transientNamescope = (INameScope)(object)val69;
		ColorPicker = val17;
		ColorOutput = val21;
		DatePickerControl = val33;
		DateOutput = val37;
		TimePickerControl = val49;
		TimeOutput = val53;
		((BindableObject)pickersPage).SetValue(Page.TitleProperty, (object)"Pickers");
		val.Key = "PageBackgroundLight";
		StaticResourceExtension val70 = new StaticResourceExtension
		{
			Key = "PageBackgroundLight"
		};
		XamlServiceProvider val71 = new XamlServiceProvider();
		Type? typeFromHandle2 = typeof(IProvideValueTarget);
		object[] array3;
		int num;
		object[] array2 = (array3 = new object[(num = 0) + 2]);
		array2[0] = val3;
		array2[1] = pickersPage;
		SimpleValueTargetProvider val72 = new SimpleValueTargetProvider(array2, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Light"), (INameScope[])(object)new NameScope[3] { val69, val69, val69 }, false);
		object obj = (object)val72;
		val71.Add(typeFromHandle2, (object)val72);
		val71.Add(typeof(IReferenceProvider), obj);
		val71.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(6, 14)));
		object light = val70.ProvideValue((IServiceProvider)val71);
		val3.Light = light;
		val2.Key = "PageBackgroundDark";
		StaticResourceExtension val73 = new StaticResourceExtension
		{
			Key = "PageBackgroundDark"
		};
		XamlServiceProvider val74 = new XamlServiceProvider();
		Type? typeFromHandle3 = typeof(IProvideValueTarget);
		object[] array5;
		int num2;
		object[] array4 = (array5 = new object[(num2 = 0) + 2]);
		array4[0] = val3;
		array4[1] = pickersPage;
		SimpleValueTargetProvider val75 = new SimpleValueTargetProvider(array4, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Dark"), (INameScope[])(object)new NameScope[3] { val69, val69, val69 }, false);
		object obj2 = (object)val75;
		val74.Add(typeFromHandle3, (object)val75);
		val74.Add(typeof(IReferenceProvider), obj2);
		val74.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(6, 14)));
		object dark = val73.ProvideValue((IServiceProvider)val74);
		val3.Dark = dark;
		XamlServiceProvider val76 = new XamlServiceProvider();
		val76.Add(typeof(IProvideValueTarget), (object)new ValueTargetProvider((object)pickersPage, (object)VisualElement.BackgroundColorProperty));
		val76.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(6, 14)));
		BindingBase val77 = ((IMarkupExtension<BindingBase>)(object)val3).ProvideValue((IServiceProvider)val76);
		((BindableObject)pickersPage).SetBinding(VisualElement.BackgroundColorProperty, val77);
		((BindableObject)val67).SetValue(Layout.PaddingProperty, (object)new Thickness(20.0));
		((BindableObject)val67).SetValue(StackBase.SpacingProperty, (object)20.0);
		((BindableObject)val7).SetValue(Label.TextProperty, (object)"Picker Controls");
		((BindableObject)val7).SetValue(Label.FontSizeProperty, (object)24.0);
		((BindableObject)val7).SetValue(Label.FontAttributesProperty, (object)(FontAttributes)1);
		val4.Key = "TextPrimaryLight";
		StaticResourceExtension val78 = new StaticResourceExtension
		{
			Key = "TextPrimaryLight"
		};
		XamlServiceProvider val79 = new XamlServiceProvider();
		Type? typeFromHandle4 = typeof(IProvideValueTarget);
		object[] array7;
		int num3;
		object[] array6 = (array7 = new object[(num3 = 0) + 5]);
		array6[0] = val6;
		array6[1] = val7;
		array6[2] = val67;
		array6[3] = val68;
		array6[4] = pickersPage;
		SimpleValueTargetProvider val80 = new SimpleValueTargetProvider(array6, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Light"), (INameScope[])(object)new NameScope[6] { val69, val69, val69, val69, val69, val69 }, false);
		object obj3 = (object)val80;
		val79.Add(typeFromHandle4, (object)val80);
		val79.Add(typeof(IReferenceProvider), obj3);
		val79.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(11, 20)));
		object light2 = val78.ProvideValue((IServiceProvider)val79);
		val6.Light = light2;
		val5.Key = "TextPrimaryDark";
		StaticResourceExtension val81 = new StaticResourceExtension
		{
			Key = "TextPrimaryDark"
		};
		XamlServiceProvider val82 = new XamlServiceProvider();
		Type? typeFromHandle5 = typeof(IProvideValueTarget);
		object[] array9;
		int num4;
		object[] array8 = (array9 = new object[(num4 = 0) + 5]);
		array8[0] = val6;
		array8[1] = val7;
		array8[2] = val67;
		array8[3] = val68;
		array8[4] = pickersPage;
		SimpleValueTargetProvider val83 = new SimpleValueTargetProvider(array8, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Dark"), (INameScope[])(object)new NameScope[6] { val69, val69, val69, val69, val69, val69 }, false);
		object obj4 = (object)val83;
		val82.Add(typeFromHandle5, (object)val83);
		val82.Add(typeof(IReferenceProvider), obj4);
		val82.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(11, 20)));
		object dark2 = val81.ProvideValue((IServiceProvider)val82);
		val6.Dark = dark2;
		XamlServiceProvider val84 = new XamlServiceProvider();
		val84.Add(typeof(IProvideValueTarget), (object)new ValueTargetProvider((object)val7, (object)Label.TextColorProperty));
		val84.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(11, 20)));
		BindingBase val85 = ((IMarkupExtension<BindingBase>)(object)val6).ProvideValue((IServiceProvider)val84);
		((BindableObject)val7).SetBinding(Label.TextColorProperty, val85);
		((Layout)val67).Children.Add((IView)(object)val7);
		val8.Key = "ThemedFrame";
		StaticResourceExtension val86 = new StaticResourceExtension
		{
			Key = "ThemedFrame"
		};
		XamlServiceProvider val87 = new XamlServiceProvider();
		Type? typeFromHandle6 = typeof(IProvideValueTarget);
		object[] array11;
		int num5;
		object[] array10 = (array11 = new object[(num5 = 0) + 4]);
		array10[0] = val23;
		array10[1] = val67;
		array10[2] = val68;
		array10[3] = pickersPage;
		SimpleValueTargetProvider val88 = new SimpleValueTargetProvider(array10, (object)VisualElement.StyleProperty, (INameScope[])(object)new NameScope[5] { val69, val69, val69, val69, val69 }, false);
		object obj5 = (object)val88;
		val87.Add(typeFromHandle6, (object)val88);
		val87.Add(typeof(IReferenceProvider), obj5);
		val87.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(14, 20)));
		object obj6 = val86.ProvideValue((IServiceProvider)val87);
		((BindableObject)val23).SetValue(VisualElement.StyleProperty, (obj6 == null || !typeof(BindingBase).IsAssignableFrom(obj6.GetType())) ? obj6 : obj6);
		((BindableObject)val23).SetValue(Frame.CornerRadiusProperty, (object)8f);
		((BindableObject)val23).SetValue(Layout.PaddingProperty, (object)new Thickness(15.0));
		((BindableObject)val22).SetValue(StackBase.SpacingProperty, (object)10.0);
		((BindableObject)val12).SetValue(Label.TextProperty, (object)"Picker");
		((BindableObject)val12).SetValue(Label.FontSizeProperty, (object)18.0);
		((BindableObject)val12).SetValue(Label.FontAttributesProperty, (object)(FontAttributes)1);
		val9.Key = "TextPrimaryLight";
		StaticResourceExtension val89 = new StaticResourceExtension
		{
			Key = "TextPrimaryLight"
		};
		XamlServiceProvider val90 = new XamlServiceProvider();
		Type? typeFromHandle7 = typeof(IProvideValueTarget);
		object[] array13;
		int num6;
		object[] array12 = (array13 = new object[(num6 = 0) + 7]);
		array12[0] = val11;
		array12[1] = val12;
		array12[2] = val22;
		array12[3] = val23;
		array12[4] = val67;
		array12[5] = val68;
		array12[6] = pickersPage;
		SimpleValueTargetProvider val91 = new SimpleValueTargetProvider(array12, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Light"), (INameScope[])(object)new NameScope[8] { val69, val69, val69, val69, val69, val69, val69, val69 }, false);
		object obj7 = (object)val91;
		val90.Add(typeFromHandle7, (object)val91);
		val90.Add(typeof(IReferenceProvider), obj7);
		val90.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(17, 28)));
		object light3 = val89.ProvideValue((IServiceProvider)val90);
		val11.Light = light3;
		val10.Key = "TextPrimaryDark";
		StaticResourceExtension val92 = new StaticResourceExtension
		{
			Key = "TextPrimaryDark"
		};
		XamlServiceProvider val93 = new XamlServiceProvider();
		Type? typeFromHandle8 = typeof(IProvideValueTarget);
		object[] array15;
		int num7;
		object[] array14 = (array15 = new object[(num7 = 0) + 7]);
		array14[0] = val11;
		array14[1] = val12;
		array14[2] = val22;
		array14[3] = val23;
		array14[4] = val67;
		array14[5] = val68;
		array14[6] = pickersPage;
		SimpleValueTargetProvider val94 = new SimpleValueTargetProvider(array14, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Dark"), (INameScope[])(object)new NameScope[8] { val69, val69, val69, val69, val69, val69, val69, val69 }, false);
		object obj8 = (object)val94;
		val93.Add(typeFromHandle8, (object)val94);
		val93.Add(typeof(IReferenceProvider), obj8);
		val93.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(17, 28)));
		object dark3 = val92.ProvideValue((IServiceProvider)val93);
		val11.Dark = dark3;
		XamlServiceProvider val95 = new XamlServiceProvider();
		val95.Add(typeof(IProvideValueTarget), (object)new ValueTargetProvider((object)val12, (object)Label.TextColorProperty));
		val95.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(17, 28)));
		BindingBase val96 = ((IMarkupExtension<BindingBase>)(object)val11).ProvideValue((IServiceProvider)val95);
		((BindableObject)val12).SetBinding(Label.TextColorProperty, val96);
		((Layout)val22).Children.Add((IView)(object)val12);
		((BindableObject)val16).SetValue(Label.TextProperty, (object)"Select a color:");
		val13.Key = "TextPrimaryLight";
		StaticResourceExtension val97 = new StaticResourceExtension
		{
			Key = "TextPrimaryLight"
		};
		XamlServiceProvider val98 = new XamlServiceProvider();
		Type? typeFromHandle9 = typeof(IProvideValueTarget);
		object[] array17;
		int num8;
		object[] array16 = (array17 = new object[(num8 = 0) + 7]);
		array16[0] = val15;
		array16[1] = val16;
		array16[2] = val22;
		array16[3] = val23;
		array16[4] = val67;
		array16[5] = val68;
		array16[6] = pickersPage;
		SimpleValueTargetProvider val99 = new SimpleValueTargetProvider(array16, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Light"), (INameScope[])(object)new NameScope[8] { val69, val69, val69, val69, val69, val69, val69, val69 }, false);
		object obj9 = (object)val99;
		val98.Add(typeFromHandle9, (object)val99);
		val98.Add(typeof(IReferenceProvider), obj9);
		val98.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(19, 28)));
		object light4 = val97.ProvideValue((IServiceProvider)val98);
		val15.Light = light4;
		val14.Key = "TextPrimaryDark";
		StaticResourceExtension val100 = new StaticResourceExtension
		{
			Key = "TextPrimaryDark"
		};
		XamlServiceProvider val101 = new XamlServiceProvider();
		Type? typeFromHandle10 = typeof(IProvideValueTarget);
		object[] array19;
		int num9;
		object[] array18 = (array19 = new object[(num9 = 0) + 7]);
		array18[0] = val15;
		array18[1] = val16;
		array18[2] = val22;
		array18[3] = val23;
		array18[4] = val67;
		array18[5] = val68;
		array18[6] = pickersPage;
		SimpleValueTargetProvider val102 = new SimpleValueTargetProvider(array18, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Dark"), (INameScope[])(object)new NameScope[8] { val69, val69, val69, val69, val69, val69, val69, val69 }, false);
		object obj10 = (object)val102;
		val101.Add(typeFromHandle10, (object)val102);
		val101.Add(typeof(IReferenceProvider), obj10);
		val101.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(19, 28)));
		object dark4 = val100.ProvideValue((IServiceProvider)val101);
		val15.Dark = dark4;
		XamlServiceProvider val103 = new XamlServiceProvider();
		val103.Add(typeof(IProvideValueTarget), (object)new ValueTargetProvider((object)val16, (object)Label.TextColorProperty));
		val103.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(19, 28)));
		BindingBase val104 = ((IMarkupExtension<BindingBase>)(object)val15).ProvideValue((IServiceProvider)val103);
		((BindableObject)val16).SetBinding(Label.TextColorProperty, val104);
		((Layout)val22).Children.Add((IView)(object)val16);
		((BindableObject)val17).SetValue(Picker.TitleProperty, (object)"Choose a color");
		val17.SelectedIndexChanged += pickersPage.OnColorPickerChanged;
		((BindableObject)val17).SetValue(Picker.ItemsSourceProperty, (object)array);
		((Layout)val22).Children.Add((IView)(object)val17);
		((BindableObject)val21).SetValue(Label.FontSizeProperty, (object)12.0);
		val18.Key = "TextSecondaryLight";
		StaticResourceExtension val105 = new StaticResourceExtension
		{
			Key = "TextSecondaryLight"
		};
		XamlServiceProvider val106 = new XamlServiceProvider();
		Type? typeFromHandle11 = typeof(IProvideValueTarget);
		object[] array21;
		int num10;
		object[] array20 = (array21 = new object[(num10 = 0) + 7]);
		array20[0] = val20;
		array20[1] = val21;
		array20[2] = val22;
		array20[3] = val23;
		array20[4] = val67;
		array20[5] = val68;
		array20[6] = pickersPage;
		SimpleValueTargetProvider val107 = new SimpleValueTargetProvider(array20, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Light"), (INameScope[])(object)new NameScope[8] { val69, val69, val69, val69, val69, val69, val69, val69 }, false);
		object obj11 = (object)val107;
		val106.Add(typeFromHandle11, (object)val107);
		val106.Add(typeof(IReferenceProvider), obj11);
		val106.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(33, 28)));
		object light5 = val105.ProvideValue((IServiceProvider)val106);
		val20.Light = light5;
		val19.Key = "TextSecondaryDark";
		StaticResourceExtension val108 = new StaticResourceExtension
		{
			Key = "TextSecondaryDark"
		};
		XamlServiceProvider val109 = new XamlServiceProvider();
		Type? typeFromHandle12 = typeof(IProvideValueTarget);
		object[] array23;
		int num11;
		object[] array22 = (array23 = new object[(num11 = 0) + 7]);
		array22[0] = val20;
		array22[1] = val21;
		array22[2] = val22;
		array22[3] = val23;
		array22[4] = val67;
		array22[5] = val68;
		array22[6] = pickersPage;
		SimpleValueTargetProvider val110 = new SimpleValueTargetProvider(array22, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Dark"), (INameScope[])(object)new NameScope[8] { val69, val69, val69, val69, val69, val69, val69, val69 }, false);
		object obj12 = (object)val110;
		val109.Add(typeFromHandle12, (object)val110);
		val109.Add(typeof(IReferenceProvider), obj12);
		val109.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(33, 28)));
		object dark5 = val108.ProvideValue((IServiceProvider)val109);
		val20.Dark = dark5;
		XamlServiceProvider val111 = new XamlServiceProvider();
		val111.Add(typeof(IProvideValueTarget), (object)new ValueTargetProvider((object)val21, (object)Label.TextColorProperty));
		val111.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(33, 28)));
		BindingBase val112 = ((IMarkupExtension<BindingBase>)(object)val20).ProvideValue((IServiceProvider)val111);
		((BindableObject)val21).SetBinding(Label.TextColorProperty, val112);
		((Layout)val22).Children.Add((IView)(object)val21);
		((BindableObject)val23).SetValue(ContentView.ContentProperty, (object)val22);
		((Layout)val67).Children.Add((IView)(object)val23);
		val24.Key = "ThemedFrame";
		StaticResourceExtension val113 = new StaticResourceExtension
		{
			Key = "ThemedFrame"
		};
		XamlServiceProvider val114 = new XamlServiceProvider();
		Type? typeFromHandle13 = typeof(IProvideValueTarget);
		object[] array25;
		int num12;
		object[] array24 = (array25 = new object[(num12 = 0) + 4]);
		array24[0] = val39;
		array24[1] = val67;
		array24[2] = val68;
		array24[3] = pickersPage;
		SimpleValueTargetProvider val115 = new SimpleValueTargetProvider(array24, (object)VisualElement.StyleProperty, (INameScope[])(object)new NameScope[5] { val69, val69, val69, val69, val69 }, false);
		object obj13 = (object)val115;
		val114.Add(typeFromHandle13, (object)val115);
		val114.Add(typeof(IReferenceProvider), obj13);
		val114.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(38, 20)));
		object obj14 = val113.ProvideValue((IServiceProvider)val114);
		((BindableObject)val39).SetValue(VisualElement.StyleProperty, (obj14 == null || !typeof(BindingBase).IsAssignableFrom(obj14.GetType())) ? obj14 : obj14);
		((BindableObject)val39).SetValue(Frame.CornerRadiusProperty, (object)8f);
		((BindableObject)val39).SetValue(Layout.PaddingProperty, (object)new Thickness(15.0));
		((BindableObject)val38).SetValue(StackBase.SpacingProperty, (object)10.0);
		((BindableObject)val28).SetValue(Label.TextProperty, (object)"DatePicker");
		((BindableObject)val28).SetValue(Label.FontSizeProperty, (object)18.0);
		((BindableObject)val28).SetValue(Label.FontAttributesProperty, (object)(FontAttributes)1);
		val25.Key = "TextPrimaryLight";
		StaticResourceExtension val116 = new StaticResourceExtension
		{
			Key = "TextPrimaryLight"
		};
		XamlServiceProvider val117 = new XamlServiceProvider();
		Type? typeFromHandle14 = typeof(IProvideValueTarget);
		object[] array27;
		int num13;
		object[] array26 = (array27 = new object[(num13 = 0) + 7]);
		array26[0] = val27;
		array26[1] = val28;
		array26[2] = val38;
		array26[3] = val39;
		array26[4] = val67;
		array26[5] = val68;
		array26[6] = pickersPage;
		SimpleValueTargetProvider val118 = new SimpleValueTargetProvider(array26, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Light"), (INameScope[])(object)new NameScope[8] { val69, val69, val69, val69, val69, val69, val69, val69 }, false);
		object obj15 = (object)val118;
		val117.Add(typeFromHandle14, (object)val118);
		val117.Add(typeof(IReferenceProvider), obj15);
		val117.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(41, 28)));
		object light6 = val116.ProvideValue((IServiceProvider)val117);
		val27.Light = light6;
		val26.Key = "TextPrimaryDark";
		StaticResourceExtension val119 = new StaticResourceExtension
		{
			Key = "TextPrimaryDark"
		};
		XamlServiceProvider val120 = new XamlServiceProvider();
		Type? typeFromHandle15 = typeof(IProvideValueTarget);
		object[] array29;
		int num14;
		object[] array28 = (array29 = new object[(num14 = 0) + 7]);
		array28[0] = val27;
		array28[1] = val28;
		array28[2] = val38;
		array28[3] = val39;
		array28[4] = val67;
		array28[5] = val68;
		array28[6] = pickersPage;
		SimpleValueTargetProvider val121 = new SimpleValueTargetProvider(array28, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Dark"), (INameScope[])(object)new NameScope[8] { val69, val69, val69, val69, val69, val69, val69, val69 }, false);
		object obj16 = (object)val121;
		val120.Add(typeFromHandle15, (object)val121);
		val120.Add(typeof(IReferenceProvider), obj16);
		val120.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(41, 28)));
		object dark6 = val119.ProvideValue((IServiceProvider)val120);
		val27.Dark = dark6;
		XamlServiceProvider val122 = new XamlServiceProvider();
		val122.Add(typeof(IProvideValueTarget), (object)new ValueTargetProvider((object)val28, (object)Label.TextColorProperty));
		val122.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(41, 28)));
		BindingBase val123 = ((IMarkupExtension<BindingBase>)(object)val27).ProvideValue((IServiceProvider)val122);
		((BindableObject)val28).SetBinding(Label.TextColorProperty, val123);
		((Layout)val38).Children.Add((IView)(object)val28);
		((BindableObject)val32).SetValue(Label.TextProperty, (object)"Select a date:");
		val29.Key = "TextPrimaryLight";
		StaticResourceExtension val124 = new StaticResourceExtension
		{
			Key = "TextPrimaryLight"
		};
		XamlServiceProvider val125 = new XamlServiceProvider();
		Type? typeFromHandle16 = typeof(IProvideValueTarget);
		object[] array31;
		int num15;
		object[] array30 = (array31 = new object[(num15 = 0) + 7]);
		array30[0] = val31;
		array30[1] = val32;
		array30[2] = val38;
		array30[3] = val39;
		array30[4] = val67;
		array30[5] = val68;
		array30[6] = pickersPage;
		SimpleValueTargetProvider val126 = new SimpleValueTargetProvider(array30, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Light"), (INameScope[])(object)new NameScope[8] { val69, val69, val69, val69, val69, val69, val69, val69 }, false);
		object obj17 = (object)val126;
		val125.Add(typeFromHandle16, (object)val126);
		val125.Add(typeof(IReferenceProvider), obj17);
		val125.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(43, 28)));
		object light7 = val124.ProvideValue((IServiceProvider)val125);
		val31.Light = light7;
		val30.Key = "TextPrimaryDark";
		StaticResourceExtension val127 = new StaticResourceExtension
		{
			Key = "TextPrimaryDark"
		};
		XamlServiceProvider val128 = new XamlServiceProvider();
		Type? typeFromHandle17 = typeof(IProvideValueTarget);
		object[] array33;
		int num16;
		object[] array32 = (array33 = new object[(num16 = 0) + 7]);
		array32[0] = val31;
		array32[1] = val32;
		array32[2] = val38;
		array32[3] = val39;
		array32[4] = val67;
		array32[5] = val68;
		array32[6] = pickersPage;
		SimpleValueTargetProvider val129 = new SimpleValueTargetProvider(array32, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Dark"), (INameScope[])(object)new NameScope[8] { val69, val69, val69, val69, val69, val69, val69, val69 }, false);
		object obj18 = (object)val129;
		val128.Add(typeFromHandle17, (object)val129);
		val128.Add(typeof(IReferenceProvider), obj18);
		val128.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(43, 28)));
		object dark7 = val127.ProvideValue((IServiceProvider)val128);
		val31.Dark = dark7;
		XamlServiceProvider val130 = new XamlServiceProvider();
		val130.Add(typeof(IProvideValueTarget), (object)new ValueTargetProvider((object)val32, (object)Label.TextColorProperty));
		val130.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(43, 28)));
		BindingBase val131 = ((IMarkupExtension<BindingBase>)(object)val31).ProvideValue((IServiceProvider)val130);
		((BindableObject)val32).SetBinding(Label.TextColorProperty, val131);
		((Layout)val38).Children.Add((IView)(object)val32);
		val33.DateSelected += pickersPage.OnDateSelected;
		((Layout)val38).Children.Add((IView)(object)val33);
		((BindableObject)val37).SetValue(Label.FontSizeProperty, (object)12.0);
		val34.Key = "TextSecondaryLight";
		StaticResourceExtension val132 = new StaticResourceExtension
		{
			Key = "TextSecondaryLight"
		};
		XamlServiceProvider val133 = new XamlServiceProvider();
		Type? typeFromHandle18 = typeof(IProvideValueTarget);
		object[] array35;
		int num17;
		object[] array34 = (array35 = new object[(num17 = 0) + 7]);
		array34[0] = val36;
		array34[1] = val37;
		array34[2] = val38;
		array34[3] = val39;
		array34[4] = val67;
		array34[5] = val68;
		array34[6] = pickersPage;
		SimpleValueTargetProvider val134 = new SimpleValueTargetProvider(array34, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Light"), (INameScope[])(object)new NameScope[8] { val69, val69, val69, val69, val69, val69, val69, val69 }, false);
		object obj19 = (object)val134;
		val133.Add(typeFromHandle18, (object)val134);
		val133.Add(typeof(IReferenceProvider), obj19);
		val133.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(46, 28)));
		object light8 = val132.ProvideValue((IServiceProvider)val133);
		val36.Light = light8;
		val35.Key = "TextSecondaryDark";
		StaticResourceExtension val135 = new StaticResourceExtension
		{
			Key = "TextSecondaryDark"
		};
		XamlServiceProvider val136 = new XamlServiceProvider();
		Type? typeFromHandle19 = typeof(IProvideValueTarget);
		object[] array37;
		int num18;
		object[] array36 = (array37 = new object[(num18 = 0) + 7]);
		array36[0] = val36;
		array36[1] = val37;
		array36[2] = val38;
		array36[3] = val39;
		array36[4] = val67;
		array36[5] = val68;
		array36[6] = pickersPage;
		SimpleValueTargetProvider val137 = new SimpleValueTargetProvider(array36, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Dark"), (INameScope[])(object)new NameScope[8] { val69, val69, val69, val69, val69, val69, val69, val69 }, false);
		object obj20 = (object)val137;
		val136.Add(typeFromHandle19, (object)val137);
		val136.Add(typeof(IReferenceProvider), obj20);
		val136.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(46, 28)));
		object dark8 = val135.ProvideValue((IServiceProvider)val136);
		val36.Dark = dark8;
		XamlServiceProvider val138 = new XamlServiceProvider();
		val138.Add(typeof(IProvideValueTarget), (object)new ValueTargetProvider((object)val37, (object)Label.TextColorProperty));
		val138.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(46, 28)));
		BindingBase val139 = ((IMarkupExtension<BindingBase>)(object)val36).ProvideValue((IServiceProvider)val138);
		((BindableObject)val37).SetBinding(Label.TextColorProperty, val139);
		((Layout)val38).Children.Add((IView)(object)val37);
		((BindableObject)val39).SetValue(ContentView.ContentProperty, (object)val38);
		((Layout)val67).Children.Add((IView)(object)val39);
		val40.Key = "ThemedFrame";
		StaticResourceExtension val140 = new StaticResourceExtension
		{
			Key = "ThemedFrame"
		};
		XamlServiceProvider val141 = new XamlServiceProvider();
		Type? typeFromHandle20 = typeof(IProvideValueTarget);
		object[] array39;
		int num19;
		object[] array38 = (array39 = new object[(num19 = 0) + 4]);
		array38[0] = val55;
		array38[1] = val67;
		array38[2] = val68;
		array38[3] = pickersPage;
		SimpleValueTargetProvider val142 = new SimpleValueTargetProvider(array38, (object)VisualElement.StyleProperty, (INameScope[])(object)new NameScope[5] { val69, val69, val69, val69, val69 }, false);
		object obj21 = (object)val142;
		val141.Add(typeFromHandle20, (object)val142);
		val141.Add(typeof(IReferenceProvider), obj21);
		val141.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(51, 20)));
		object obj22 = val140.ProvideValue((IServiceProvider)val141);
		((BindableObject)val55).SetValue(VisualElement.StyleProperty, (obj22 == null || !typeof(BindingBase).IsAssignableFrom(obj22.GetType())) ? obj22 : obj22);
		((BindableObject)val55).SetValue(Frame.CornerRadiusProperty, (object)8f);
		((BindableObject)val55).SetValue(Layout.PaddingProperty, (object)new Thickness(15.0));
		((BindableObject)val54).SetValue(StackBase.SpacingProperty, (object)10.0);
		((BindableObject)val44).SetValue(Label.TextProperty, (object)"TimePicker");
		((BindableObject)val44).SetValue(Label.FontSizeProperty, (object)18.0);
		((BindableObject)val44).SetValue(Label.FontAttributesProperty, (object)(FontAttributes)1);
		val41.Key = "TextPrimaryLight";
		StaticResourceExtension val143 = new StaticResourceExtension
		{
			Key = "TextPrimaryLight"
		};
		XamlServiceProvider val144 = new XamlServiceProvider();
		Type? typeFromHandle21 = typeof(IProvideValueTarget);
		object[] array41;
		int num20;
		object[] array40 = (array41 = new object[(num20 = 0) + 7]);
		array40[0] = val43;
		array40[1] = val44;
		array40[2] = val54;
		array40[3] = val55;
		array40[4] = val67;
		array40[5] = val68;
		array40[6] = pickersPage;
		SimpleValueTargetProvider val145 = new SimpleValueTargetProvider(array40, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Light"), (INameScope[])(object)new NameScope[8] { val69, val69, val69, val69, val69, val69, val69, val69 }, false);
		object obj23 = (object)val145;
		val144.Add(typeFromHandle21, (object)val145);
		val144.Add(typeof(IReferenceProvider), obj23);
		val144.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(54, 28)));
		object light9 = val143.ProvideValue((IServiceProvider)val144);
		val43.Light = light9;
		val42.Key = "TextPrimaryDark";
		StaticResourceExtension val146 = new StaticResourceExtension
		{
			Key = "TextPrimaryDark"
		};
		XamlServiceProvider val147 = new XamlServiceProvider();
		Type? typeFromHandle22 = typeof(IProvideValueTarget);
		object[] array43;
		int num21;
		object[] array42 = (array43 = new object[(num21 = 0) + 7]);
		array42[0] = val43;
		array42[1] = val44;
		array42[2] = val54;
		array42[3] = val55;
		array42[4] = val67;
		array42[5] = val68;
		array42[6] = pickersPage;
		SimpleValueTargetProvider val148 = new SimpleValueTargetProvider(array42, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Dark"), (INameScope[])(object)new NameScope[8] { val69, val69, val69, val69, val69, val69, val69, val69 }, false);
		object obj24 = (object)val148;
		val147.Add(typeFromHandle22, (object)val148);
		val147.Add(typeof(IReferenceProvider), obj24);
		val147.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(54, 28)));
		object dark9 = val146.ProvideValue((IServiceProvider)val147);
		val43.Dark = dark9;
		XamlServiceProvider val149 = new XamlServiceProvider();
		val149.Add(typeof(IProvideValueTarget), (object)new ValueTargetProvider((object)val44, (object)Label.TextColorProperty));
		val149.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(54, 28)));
		BindingBase val150 = ((IMarkupExtension<BindingBase>)(object)val43).ProvideValue((IServiceProvider)val149);
		((BindableObject)val44).SetBinding(Label.TextColorProperty, val150);
		((Layout)val54).Children.Add((IView)(object)val44);
		((BindableObject)val48).SetValue(Label.TextProperty, (object)"Select a time:");
		val45.Key = "TextPrimaryLight";
		StaticResourceExtension val151 = new StaticResourceExtension
		{
			Key = "TextPrimaryLight"
		};
		XamlServiceProvider val152 = new XamlServiceProvider();
		Type? typeFromHandle23 = typeof(IProvideValueTarget);
		object[] array45;
		int num22;
		object[] array44 = (array45 = new object[(num22 = 0) + 7]);
		array44[0] = val47;
		array44[1] = val48;
		array44[2] = val54;
		array44[3] = val55;
		array44[4] = val67;
		array44[5] = val68;
		array44[6] = pickersPage;
		SimpleValueTargetProvider val153 = new SimpleValueTargetProvider(array44, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Light"), (INameScope[])(object)new NameScope[8] { val69, val69, val69, val69, val69, val69, val69, val69 }, false);
		object obj25 = (object)val153;
		val152.Add(typeFromHandle23, (object)val153);
		val152.Add(typeof(IReferenceProvider), obj25);
		val152.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(56, 28)));
		object light10 = val151.ProvideValue((IServiceProvider)val152);
		val47.Light = light10;
		val46.Key = "TextPrimaryDark";
		StaticResourceExtension val154 = new StaticResourceExtension
		{
			Key = "TextPrimaryDark"
		};
		XamlServiceProvider val155 = new XamlServiceProvider();
		Type? typeFromHandle24 = typeof(IProvideValueTarget);
		object[] array47;
		int num23;
		object[] array46 = (array47 = new object[(num23 = 0) + 7]);
		array46[0] = val47;
		array46[1] = val48;
		array46[2] = val54;
		array46[3] = val55;
		array46[4] = val67;
		array46[5] = val68;
		array46[6] = pickersPage;
		SimpleValueTargetProvider val156 = new SimpleValueTargetProvider(array46, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Dark"), (INameScope[])(object)new NameScope[8] { val69, val69, val69, val69, val69, val69, val69, val69 }, false);
		object obj26 = (object)val156;
		val155.Add(typeFromHandle24, (object)val156);
		val155.Add(typeof(IReferenceProvider), obj26);
		val155.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(56, 28)));
		object dark10 = val154.ProvideValue((IServiceProvider)val155);
		val47.Dark = dark10;
		XamlServiceProvider val157 = new XamlServiceProvider();
		val157.Add(typeof(IProvideValueTarget), (object)new ValueTargetProvider((object)val48, (object)Label.TextColorProperty));
		val157.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(56, 28)));
		BindingBase val158 = ((IMarkupExtension<BindingBase>)(object)val47).ProvideValue((IServiceProvider)val157);
		((BindableObject)val48).SetBinding(Label.TextColorProperty, val158);
		((Layout)val54).Children.Add((IView)(object)val48);
		((BindableObject)val49).PropertyChanged += pickersPage.OnTimeChanged;
		((Layout)val54).Children.Add((IView)(object)val49);
		((BindableObject)val53).SetValue(Label.FontSizeProperty, (object)12.0);
		val50.Key = "TextSecondaryLight";
		StaticResourceExtension val159 = new StaticResourceExtension
		{
			Key = "TextSecondaryLight"
		};
		XamlServiceProvider val160 = new XamlServiceProvider();
		Type? typeFromHandle25 = typeof(IProvideValueTarget);
		object[] array49;
		int num24;
		object[] array48 = (array49 = new object[(num24 = 0) + 7]);
		array48[0] = val52;
		array48[1] = val53;
		array48[2] = val54;
		array48[3] = val55;
		array48[4] = val67;
		array48[5] = val68;
		array48[6] = pickersPage;
		SimpleValueTargetProvider val161 = new SimpleValueTargetProvider(array48, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Light"), (INameScope[])(object)new NameScope[8] { val69, val69, val69, val69, val69, val69, val69, val69 }, false);
		object obj27 = (object)val161;
		val160.Add(typeFromHandle25, (object)val161);
		val160.Add(typeof(IReferenceProvider), obj27);
		val160.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(59, 28)));
		object light11 = val159.ProvideValue((IServiceProvider)val160);
		val52.Light = light11;
		val51.Key = "TextSecondaryDark";
		StaticResourceExtension val162 = new StaticResourceExtension
		{
			Key = "TextSecondaryDark"
		};
		XamlServiceProvider val163 = new XamlServiceProvider();
		Type? typeFromHandle26 = typeof(IProvideValueTarget);
		object[] array51;
		int num25;
		object[] array50 = (array51 = new object[(num25 = 0) + 7]);
		array50[0] = val52;
		array50[1] = val53;
		array50[2] = val54;
		array50[3] = val55;
		array50[4] = val67;
		array50[5] = val68;
		array50[6] = pickersPage;
		SimpleValueTargetProvider val164 = new SimpleValueTargetProvider(array50, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Dark"), (INameScope[])(object)new NameScope[8] { val69, val69, val69, val69, val69, val69, val69, val69 }, false);
		object obj28 = (object)val164;
		val163.Add(typeFromHandle26, (object)val164);
		val163.Add(typeof(IReferenceProvider), obj28);
		val163.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(59, 28)));
		object dark11 = val162.ProvideValue((IServiceProvider)val163);
		val52.Dark = dark11;
		XamlServiceProvider val165 = new XamlServiceProvider();
		val165.Add(typeof(IProvideValueTarget), (object)new ValueTargetProvider((object)val53, (object)Label.TextColorProperty));
		val165.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(59, 28)));
		BindingBase val166 = ((IMarkupExtension<BindingBase>)(object)val52).ProvideValue((IServiceProvider)val165);
		((BindableObject)val53).SetBinding(Label.TextColorProperty, val166);
		((Layout)val54).Children.Add((IView)(object)val53);
		((BindableObject)val55).SetValue(ContentView.ContentProperty, (object)val54);
		((Layout)val67).Children.Add((IView)(object)val55);
		((BindableObject)val66).SetValue(Frame.CornerRadiusProperty, (object)8f);
		((BindableObject)val66).SetValue(Layout.PaddingProperty, (object)new Thickness(15.0));
		val56.Light = "#E8F5E9";
		val56.Dark = "#1B5E20";
		XamlServiceProvider val167 = new XamlServiceProvider();
		val167.Add(typeof(IProvideValueTarget), (object)new ValueTargetProvider((object)val66, (object)VisualElement.BackgroundColorProperty));
		val167.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(65, 20)));
		BindingBase val168 = ((IMarkupExtension<BindingBase>)(object)val56).ProvideValue((IServiceProvider)val167);
		((BindableObject)val66).SetBinding(VisualElement.BackgroundColorProperty, val168);
		((BindableObject)val65).SetValue(StackBase.SpacingProperty, (object)10.0);
		((BindableObject)val58).SetValue(Label.TextProperty, (object)"Schedule an Event");
		((BindableObject)val58).SetValue(Label.FontSizeProperty, (object)18.0);
		((BindableObject)val58).SetValue(Label.FontAttributesProperty, (object)(FontAttributes)1);
		val57.Light = "#2E7D32";
		val57.Dark = "#A5D6A7";
		XamlServiceProvider val169 = new XamlServiceProvider();
		val169.Add(typeof(IProvideValueTarget), (object)new ValueTargetProvider((object)val58, (object)Label.TextColorProperty));
		val169.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(68, 28)));
		BindingBase val170 = ((IMarkupExtension<BindingBase>)(object)val57).ProvideValue((IServiceProvider)val169);
		((BindableObject)val58).SetBinding(Label.TextColorProperty, val170);
		((Layout)val65).Children.Add((IView)(object)val58);
		((BindableObject)val60).SetValue(Entry.PlaceholderProperty, (object)"Event name");
		val59.Key = "ThemedEntry";
		StaticResourceExtension val171 = new StaticResourceExtension
		{
			Key = "ThemedEntry"
		};
		XamlServiceProvider val172 = new XamlServiceProvider();
		Type? typeFromHandle27 = typeof(IProvideValueTarget);
		object[] array53;
		int num26;
		object[] array52 = (array53 = new object[(num26 = 0) + 6]);
		array52[0] = val60;
		array52[1] = val65;
		array52[2] = val66;
		array52[3] = val67;
		array52[4] = val68;
		array52[5] = pickersPage;
		SimpleValueTargetProvider val173 = new SimpleValueTargetProvider(array52, (object)VisualElement.StyleProperty, (INameScope[])(object)new NameScope[7] { val69, val69, val69, val69, val69, val69, val69 }, false);
		object obj29 = (object)val173;
		val172.Add(typeFromHandle27, (object)val173);
		val172.Add(typeof(IReferenceProvider), obj29);
		val172.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(69, 53)));
		object obj30 = val171.ProvideValue((IServiceProvider)val172);
		((BindableObject)val60).SetValue(VisualElement.StyleProperty, (obj30 == null || !typeof(BindingBase).IsAssignableFrom(obj30.GetType())) ? obj30 : obj30);
		((Layout)val65).Children.Add((IView)(object)val60);
		((BindableObject)val63).SetValue(StackBase.SpacingProperty, (object)10.0);
		((Layout)val63).Children.Add((IView)(object)val61);
		((Layout)val63).Children.Add((IView)(object)val62);
		((Layout)val65).Children.Add((IView)(object)val63);
		((BindableObject)val64).SetValue(Button.TextProperty, (object)"Schedule");
		((BindableObject)val64).SetValue(VisualElement.BackgroundColorProperty, (object)new Color(0.29803923f, 35f / 51f, 16f / 51f, 1f));
		((BindableObject)val64).SetValue(Button.TextColorProperty, (object)Colors.White);
		((Layout)val65).Children.Add((IView)(object)val64);
		((BindableObject)val66).SetValue(ContentView.ContentProperty, (object)val65);
		((Layout)val67).Children.Add((IView)(object)val66);
		val68.Content = (View)(object)val67;
		((BindableObject)pickersPage).SetValue(ContentPage.ContentProperty, (object)val68);
	}
}
