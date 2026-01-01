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
using Microsoft.Maui.Converters;

namespace ShellDemo;

[XamlFilePath("Pages/TextInputPage.xaml")]
public class TextInputPage : ContentPage
{
	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private Entry NameEntry;

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private Label EntryOutput;

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private SearchBar SearchBarControl;

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private Label SearchOutput;

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private Editor EditorControl;

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private Label EditorOutput;

	public TextInputPage()
	{
		InitializeComponent();
	}

	private void OnNameEntryTextChanged(object? sender, TextChangedEventArgs e)
	{
		EntryOutput.Text = "You typed: " + e.NewTextValue;
	}

	private void OnSearchTextChanged(object? sender, TextChangedEventArgs e)
	{
		SearchOutput.Text = "Searching: " + e.NewTextValue;
	}

	private void OnSearchButtonPressed(object? sender, EventArgs e)
	{
		SearchOutput.Text = "Search submitted: " + ((InputView)SearchBarControl).Text;
	}

	private void OnEditorTextChanged(object? sender, TextChangedEventArgs e)
	{
		int value = ((!string.IsNullOrEmpty(e.NewTextValue)) ? e.NewTextValue.Split('\n').Length : 0);
		EditorOutput.Text = $"Lines: {value}, Characters: {e.NewTextValue?.Length ?? 0}";
	}

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	[MemberNotNull("NameEntry")]
	[MemberNotNull("EntryOutput")]
	[MemberNotNull("SearchBarControl")]
	[MemberNotNull("SearchOutput")]
	[MemberNotNull("EditorControl")]
	[MemberNotNull("EditorOutput")]
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
		//IL_026c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0273: Expected O, but got Unknown
		//IL_0273: Unknown result type (might be due to invalid IL or missing references)
		//IL_027a: Expected O, but got Unknown
		//IL_027a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0281: Expected O, but got Unknown
		//IL_028e: Unknown result type (might be due to invalid IL or missing references)
		//IL_04be: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0519: Unknown result type (might be due to invalid IL or missing references)
		//IL_051e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0521: Expected O, but got Unknown
		//IL_0526: Expected O, but got Unknown
		//IL_0526: Unknown result type (might be due to invalid IL or missing references)
		//IL_0538: Unknown result type (might be due to invalid IL or missing references)
		//IL_0546: Unknown result type (might be due to invalid IL or missing references)
		//IL_0550: Expected O, but got Unknown
		//IL_054b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0555: Expected O, but got Unknown
		//IL_055a: Expected O, but got Unknown
		//IL_056f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0574: Unknown result type (might be due to invalid IL or missing references)
		//IL_057f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0584: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_05cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d2: Expected O, but got Unknown
		//IL_05d7: Expected O, but got Unknown
		//IL_05d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0601: Expected O, but got Unknown
		//IL_05fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0606: Expected O, but got Unknown
		//IL_060b: Expected O, but got Unknown
		//IL_0616: Unknown result type (might be due to invalid IL or missing references)
		//IL_061b: Unknown result type (might be due to invalid IL or missing references)
		//IL_062d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0637: Expected O, but got Unknown
		//IL_0637: Unknown result type (might be due to invalid IL or missing references)
		//IL_0645: Unknown result type (might be due to invalid IL or missing references)
		//IL_064f: Expected O, but got Unknown
		//IL_064a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0654: Expected O, but got Unknown
		//IL_0659: Expected O, but got Unknown
		//IL_0679: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_06fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0764: Unknown result type (might be due to invalid IL or missing references)
		//IL_0769: Unknown result type (might be due to invalid IL or missing references)
		//IL_076c: Expected O, but got Unknown
		//IL_0771: Expected O, but got Unknown
		//IL_0771: Unknown result type (might be due to invalid IL or missing references)
		//IL_0783: Unknown result type (might be due to invalid IL or missing references)
		//IL_0792: Unknown result type (might be due to invalid IL or missing references)
		//IL_079c: Expected O, but got Unknown
		//IL_0797: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a1: Expected O, but got Unknown
		//IL_07a6: Expected O, but got Unknown
		//IL_07bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_07c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_07cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0837: Unknown result type (might be due to invalid IL or missing references)
		//IL_083c: Unknown result type (might be due to invalid IL or missing references)
		//IL_083f: Expected O, but got Unknown
		//IL_0844: Expected O, but got Unknown
		//IL_0844: Unknown result type (might be due to invalid IL or missing references)
		//IL_0856: Unknown result type (might be due to invalid IL or missing references)
		//IL_0865: Unknown result type (might be due to invalid IL or missing references)
		//IL_086f: Expected O, but got Unknown
		//IL_086a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0874: Expected O, but got Unknown
		//IL_0879: Expected O, but got Unknown
		//IL_0886: Unknown result type (might be due to invalid IL or missing references)
		//IL_088b: Unknown result type (might be due to invalid IL or missing references)
		//IL_089d: Unknown result type (might be due to invalid IL or missing references)
		//IL_08a7: Expected O, but got Unknown
		//IL_08a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_08c0: Expected O, but got Unknown
		//IL_08bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_08c5: Expected O, but got Unknown
		//IL_08ca: Expected O, but got Unknown
		//IL_091f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0924: Unknown result type (might be due to invalid IL or missing references)
		//IL_092f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0934: Unknown result type (might be due to invalid IL or missing references)
		//IL_0999: Unknown result type (might be due to invalid IL or missing references)
		//IL_099e: Unknown result type (might be due to invalid IL or missing references)
		//IL_09a1: Expected O, but got Unknown
		//IL_09a6: Expected O, but got Unknown
		//IL_09a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_09b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_09c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_09d1: Expected O, but got Unknown
		//IL_09cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_09d6: Expected O, but got Unknown
		//IL_09db: Expected O, but got Unknown
		//IL_09f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_09f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a02: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a07: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a6c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a71: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a74: Expected O, but got Unknown
		//IL_0a79: Expected O, but got Unknown
		//IL_0a79: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a8b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a9a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aa4: Expected O, but got Unknown
		//IL_0a9f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aa9: Expected O, but got Unknown
		//IL_0aae: Expected O, but got Unknown
		//IL_0abb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ac0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ad2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0adc: Expected O, but got Unknown
		//IL_0adc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aeb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0af5: Expected O, but got Unknown
		//IL_0af0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0afa: Expected O, but got Unknown
		//IL_0aff: Expected O, but got Unknown
		//IL_0b43: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b48: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b53: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b58: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bbd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bc2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bc5: Expected O, but got Unknown
		//IL_0bca: Expected O, but got Unknown
		//IL_0bca: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bdc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0beb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bf5: Expected O, but got Unknown
		//IL_0bf0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bfa: Expected O, but got Unknown
		//IL_0bff: Expected O, but got Unknown
		//IL_0c16: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c1b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c26: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c2b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c90: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c95: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c98: Expected O, but got Unknown
		//IL_0c9d: Expected O, but got Unknown
		//IL_0c9d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0caf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cbe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cc8: Expected O, but got Unknown
		//IL_0cc3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ccd: Expected O, but got Unknown
		//IL_0cd2: Expected O, but got Unknown
		//IL_0cdf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ce4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cf6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d00: Expected O, but got Unknown
		//IL_0d00: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d0f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d19: Expected O, but got Unknown
		//IL_0d14: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d1e: Expected O, but got Unknown
		//IL_0d23: Expected O, but got Unknown
		//IL_0d8a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d8f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d9a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d9f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e04: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e09: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e0c: Expected O, but got Unknown
		//IL_0e11: Expected O, but got Unknown
		//IL_0e11: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e23: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e32: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e3c: Expected O, but got Unknown
		//IL_0e37: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e41: Expected O, but got Unknown
		//IL_0e46: Expected O, but got Unknown
		//IL_0e5d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e62: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e6d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e72: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ed7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0edc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0edf: Expected O, but got Unknown
		//IL_0ee4: Expected O, but got Unknown
		//IL_0ee4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ef6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f05: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f0f: Expected O, but got Unknown
		//IL_0f0a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f14: Expected O, but got Unknown
		//IL_0f19: Expected O, but got Unknown
		//IL_0f26: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f2b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f3d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f47: Expected O, but got Unknown
		//IL_0f47: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f56: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f60: Expected O, but got Unknown
		//IL_0f5b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f65: Expected O, but got Unknown
		//IL_0f6a: Expected O, but got Unknown
		//IL_0fbf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fc4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fcf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fd4: Unknown result type (might be due to invalid IL or missing references)
		//IL_1020: Unknown result type (might be due to invalid IL or missing references)
		//IL_1025: Unknown result type (might be due to invalid IL or missing references)
		//IL_1028: Expected O, but got Unknown
		//IL_102d: Expected O, but got Unknown
		//IL_102d: Unknown result type (might be due to invalid IL or missing references)
		//IL_103f: Unknown result type (might be due to invalid IL or missing references)
		//IL_104e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1058: Expected O, but got Unknown
		//IL_1053: Unknown result type (might be due to invalid IL or missing references)
		//IL_105d: Expected O, but got Unknown
		//IL_1062: Expected O, but got Unknown
		//IL_10dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_10e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_10ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_10f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_1156: Unknown result type (might be due to invalid IL or missing references)
		//IL_115b: Unknown result type (might be due to invalid IL or missing references)
		//IL_115e: Expected O, but got Unknown
		//IL_1163: Expected O, but got Unknown
		//IL_1163: Unknown result type (might be due to invalid IL or missing references)
		//IL_1175: Unknown result type (might be due to invalid IL or missing references)
		//IL_1184: Unknown result type (might be due to invalid IL or missing references)
		//IL_118e: Expected O, but got Unknown
		//IL_1189: Unknown result type (might be due to invalid IL or missing references)
		//IL_1193: Expected O, but got Unknown
		//IL_1198: Expected O, but got Unknown
		//IL_11af: Unknown result type (might be due to invalid IL or missing references)
		//IL_11b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_11bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_11c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_1229: Unknown result type (might be due to invalid IL or missing references)
		//IL_122e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1231: Expected O, but got Unknown
		//IL_1236: Expected O, but got Unknown
		//IL_1236: Unknown result type (might be due to invalid IL or missing references)
		//IL_1248: Unknown result type (might be due to invalid IL or missing references)
		//IL_1257: Unknown result type (might be due to invalid IL or missing references)
		//IL_1261: Expected O, but got Unknown
		//IL_125c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1266: Expected O, but got Unknown
		//IL_126b: Expected O, but got Unknown
		//IL_1278: Unknown result type (might be due to invalid IL or missing references)
		//IL_127d: Unknown result type (might be due to invalid IL or missing references)
		//IL_128f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1299: Expected O, but got Unknown
		//IL_1299: Unknown result type (might be due to invalid IL or missing references)
		//IL_12a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_12b2: Expected O, but got Unknown
		//IL_12ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_12b7: Expected O, but got Unknown
		//IL_12bc: Expected O, but got Unknown
		//IL_130c: Unknown result type (might be due to invalid IL or missing references)
		//IL_131b: Expected O, but got Unknown
		//IL_132c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1331: Unknown result type (might be due to invalid IL or missing references)
		//IL_133c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1341: Unknown result type (might be due to invalid IL or missing references)
		//IL_138d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1392: Unknown result type (might be due to invalid IL or missing references)
		//IL_1395: Expected O, but got Unknown
		//IL_139a: Expected O, but got Unknown
		//IL_139a: Unknown result type (might be due to invalid IL or missing references)
		//IL_13ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_13bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_13c5: Expected O, but got Unknown
		//IL_13c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_13ca: Expected O, but got Unknown
		//IL_13cf: Expected O, but got Unknown
		//IL_1446: Unknown result type (might be due to invalid IL or missing references)
		//IL_144b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1456: Unknown result type (might be due to invalid IL or missing references)
		//IL_145b: Unknown result type (might be due to invalid IL or missing references)
		//IL_14c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_14c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_14c8: Expected O, but got Unknown
		//IL_14cd: Expected O, but got Unknown
		//IL_14cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_14df: Unknown result type (might be due to invalid IL or missing references)
		//IL_14ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_14f8: Expected O, but got Unknown
		//IL_14f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_14fd: Expected O, but got Unknown
		//IL_1502: Expected O, but got Unknown
		//IL_1519: Unknown result type (might be due to invalid IL or missing references)
		//IL_151e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1529: Unknown result type (might be due to invalid IL or missing references)
		//IL_152e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1593: Unknown result type (might be due to invalid IL or missing references)
		//IL_1598: Unknown result type (might be due to invalid IL or missing references)
		//IL_159b: Expected O, but got Unknown
		//IL_15a0: Expected O, but got Unknown
		//IL_15a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_15b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_15c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_15cb: Expected O, but got Unknown
		//IL_15c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_15d0: Expected O, but got Unknown
		//IL_15d5: Expected O, but got Unknown
		//IL_15e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_15e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_15f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_1603: Expected O, but got Unknown
		//IL_1603: Unknown result type (might be due to invalid IL or missing references)
		//IL_1612: Unknown result type (might be due to invalid IL or missing references)
		//IL_161c: Expected O, but got Unknown
		//IL_1617: Unknown result type (might be due to invalid IL or missing references)
		//IL_1621: Expected O, but got Unknown
		//IL_1626: Expected O, but got Unknown
		//IL_168d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1692: Unknown result type (might be due to invalid IL or missing references)
		//IL_169d: Unknown result type (might be due to invalid IL or missing references)
		//IL_16a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_16ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_16f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_16f6: Expected O, but got Unknown
		//IL_16fb: Expected O, but got Unknown
		//IL_16fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_170d: Unknown result type (might be due to invalid IL or missing references)
		//IL_171c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1726: Expected O, but got Unknown
		//IL_1721: Unknown result type (might be due to invalid IL or missing references)
		//IL_172b: Expected O, but got Unknown
		//IL_1730: Expected O, but got Unknown
		//IL_17a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_17ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_17b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_17bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_1821: Unknown result type (might be due to invalid IL or missing references)
		//IL_1826: Unknown result type (might be due to invalid IL or missing references)
		//IL_1829: Expected O, but got Unknown
		//IL_182e: Expected O, but got Unknown
		//IL_182e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1840: Unknown result type (might be due to invalid IL or missing references)
		//IL_184f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1859: Expected O, but got Unknown
		//IL_1854: Unknown result type (might be due to invalid IL or missing references)
		//IL_185e: Expected O, but got Unknown
		//IL_1863: Expected O, but got Unknown
		//IL_187a: Unknown result type (might be due to invalid IL or missing references)
		//IL_187f: Unknown result type (might be due to invalid IL or missing references)
		//IL_188a: Unknown result type (might be due to invalid IL or missing references)
		//IL_188f: Unknown result type (might be due to invalid IL or missing references)
		//IL_18f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_18f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_18fc: Expected O, but got Unknown
		//IL_1901: Expected O, but got Unknown
		//IL_1901: Unknown result type (might be due to invalid IL or missing references)
		//IL_1913: Unknown result type (might be due to invalid IL or missing references)
		//IL_1922: Unknown result type (might be due to invalid IL or missing references)
		//IL_192c: Expected O, but got Unknown
		//IL_1927: Unknown result type (might be due to invalid IL or missing references)
		//IL_1931: Expected O, but got Unknown
		//IL_1936: Expected O, but got Unknown
		//IL_1943: Unknown result type (might be due to invalid IL or missing references)
		//IL_1948: Unknown result type (might be due to invalid IL or missing references)
		//IL_195a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1964: Expected O, but got Unknown
		//IL_1964: Unknown result type (might be due to invalid IL or missing references)
		//IL_1973: Unknown result type (might be due to invalid IL or missing references)
		//IL_197d: Expected O, but got Unknown
		//IL_1978: Unknown result type (might be due to invalid IL or missing references)
		//IL_1982: Expected O, but got Unknown
		//IL_1987: Expected O, but got Unknown
		//IL_19cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_19d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_19db: Unknown result type (might be due to invalid IL or missing references)
		//IL_19e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a45: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a4a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a4d: Expected O, but got Unknown
		//IL_1a52: Expected O, but got Unknown
		//IL_1a52: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a64: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a73: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a7d: Expected O, but got Unknown
		//IL_1a78: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a82: Expected O, but got Unknown
		//IL_1a87: Expected O, but got Unknown
		//IL_1a9e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1aa3: Unknown result type (might be due to invalid IL or missing references)
		//IL_1aae: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ab3: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b18: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b1d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b20: Expected O, but got Unknown
		//IL_1b25: Expected O, but got Unknown
		//IL_1b25: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b37: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b46: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b50: Expected O, but got Unknown
		//IL_1b4b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b55: Expected O, but got Unknown
		//IL_1b5a: Expected O, but got Unknown
		//IL_1b67: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b6c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b7e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b88: Expected O, but got Unknown
		//IL_1b88: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b97: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ba1: Expected O, but got Unknown
		//IL_1b9c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ba6: Expected O, but got Unknown
		//IL_1bab: Expected O, but got Unknown
		//IL_1c12: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c17: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c22: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c27: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c8c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c91: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c94: Expected O, but got Unknown
		//IL_1c99: Expected O, but got Unknown
		//IL_1c99: Unknown result type (might be due to invalid IL or missing references)
		//IL_1cab: Unknown result type (might be due to invalid IL or missing references)
		//IL_1cba: Unknown result type (might be due to invalid IL or missing references)
		//IL_1cc4: Expected O, but got Unknown
		//IL_1cbf: Unknown result type (might be due to invalid IL or missing references)
		//IL_1cc9: Expected O, but got Unknown
		//IL_1cce: Expected O, but got Unknown
		//IL_1ce5: Unknown result type (might be due to invalid IL or missing references)
		//IL_1cea: Unknown result type (might be due to invalid IL or missing references)
		//IL_1cf5: Unknown result type (might be due to invalid IL or missing references)
		//IL_1cfa: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d5f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d64: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d67: Expected O, but got Unknown
		//IL_1d6c: Expected O, but got Unknown
		//IL_1d6c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d7e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d8d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d97: Expected O, but got Unknown
		//IL_1d92: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d9c: Expected O, but got Unknown
		//IL_1da1: Expected O, but got Unknown
		//IL_1dae: Unknown result type (might be due to invalid IL or missing references)
		//IL_1db3: Unknown result type (might be due to invalid IL or missing references)
		//IL_1dc5: Unknown result type (might be due to invalid IL or missing references)
		//IL_1dcf: Expected O, but got Unknown
		//IL_1dcf: Unknown result type (might be due to invalid IL or missing references)
		//IL_1dde: Unknown result type (might be due to invalid IL or missing references)
		//IL_1de8: Expected O, but got Unknown
		//IL_1de3: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ded: Expected O, but got Unknown
		//IL_1df2: Expected O, but got Unknown
		//IL_1e2d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e32: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e3d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e42: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ea7: Unknown result type (might be due to invalid IL or missing references)
		//IL_1eac: Unknown result type (might be due to invalid IL or missing references)
		//IL_1eaf: Expected O, but got Unknown
		//IL_1eb4: Expected O, but got Unknown
		//IL_1eb4: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ec6: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ed5: Unknown result type (might be due to invalid IL or missing references)
		//IL_1edf: Expected O, but got Unknown
		//IL_1eda: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ee4: Expected O, but got Unknown
		//IL_1ee9: Expected O, but got Unknown
		//IL_1f00: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f05: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f10: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f15: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f7a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f7f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f82: Expected O, but got Unknown
		//IL_1f87: Expected O, but got Unknown
		//IL_1f87: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f99: Unknown result type (might be due to invalid IL or missing references)
		//IL_1fa8: Unknown result type (might be due to invalid IL or missing references)
		//IL_1fb2: Expected O, but got Unknown
		//IL_1fad: Unknown result type (might be due to invalid IL or missing references)
		//IL_1fb7: Expected O, but got Unknown
		//IL_1fbc: Expected O, but got Unknown
		//IL_1fc9: Unknown result type (might be due to invalid IL or missing references)
		//IL_1fce: Unknown result type (might be due to invalid IL or missing references)
		//IL_1fe0: Unknown result type (might be due to invalid IL or missing references)
		//IL_1fea: Expected O, but got Unknown
		//IL_1fea: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ff9: Unknown result type (might be due to invalid IL or missing references)
		//IL_2003: Expected O, but got Unknown
		//IL_1ffe: Unknown result type (might be due to invalid IL or missing references)
		//IL_2008: Expected O, but got Unknown
		//IL_200d: Expected O, but got Unknown
		//IL_2029: Unknown result type (might be due to invalid IL or missing references)
		//IL_202e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2039: Unknown result type (might be due to invalid IL or missing references)
		//IL_203e: Unknown result type (might be due to invalid IL or missing references)
		//IL_20a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_20a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_20ab: Expected O, but got Unknown
		//IL_20b0: Expected O, but got Unknown
		//IL_20b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_20c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_20d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_20db: Expected O, but got Unknown
		//IL_20d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_20e0: Expected O, but got Unknown
		//IL_20e5: Expected O, but got Unknown
		//IL_20fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_2101: Unknown result type (might be due to invalid IL or missing references)
		//IL_210c: Unknown result type (might be due to invalid IL or missing references)
		//IL_2111: Unknown result type (might be due to invalid IL or missing references)
		//IL_2176: Unknown result type (might be due to invalid IL or missing references)
		//IL_217b: Unknown result type (might be due to invalid IL or missing references)
		//IL_217e: Expected O, but got Unknown
		//IL_2183: Expected O, but got Unknown
		//IL_2183: Unknown result type (might be due to invalid IL or missing references)
		//IL_2195: Unknown result type (might be due to invalid IL or missing references)
		//IL_21a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_21ae: Expected O, but got Unknown
		//IL_21a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_21b3: Expected O, but got Unknown
		//IL_21b8: Expected O, but got Unknown
		//IL_21c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_21ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_21dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_21e6: Expected O, but got Unknown
		//IL_21e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_21f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_21ff: Expected O, but got Unknown
		//IL_21fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_2204: Expected O, but got Unknown
		//IL_2209: Expected O, but got Unknown
		//IL_2225: Unknown result type (might be due to invalid IL or missing references)
		//IL_222a: Unknown result type (might be due to invalid IL or missing references)
		//IL_2235: Unknown result type (might be due to invalid IL or missing references)
		//IL_223a: Unknown result type (might be due to invalid IL or missing references)
		//IL_229f: Unknown result type (might be due to invalid IL or missing references)
		//IL_22a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_22a7: Expected O, but got Unknown
		//IL_22ac: Expected O, but got Unknown
		//IL_22ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_22be: Unknown result type (might be due to invalid IL or missing references)
		//IL_22cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_22d7: Expected O, but got Unknown
		//IL_22d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_22dc: Expected O, but got Unknown
		//IL_22e1: Expected O, but got Unknown
		//IL_22f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_22fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_2308: Unknown result type (might be due to invalid IL or missing references)
		//IL_230d: Unknown result type (might be due to invalid IL or missing references)
		//IL_2372: Unknown result type (might be due to invalid IL or missing references)
		//IL_2377: Unknown result type (might be due to invalid IL or missing references)
		//IL_237a: Expected O, but got Unknown
		//IL_237f: Expected O, but got Unknown
		//IL_237f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2391: Unknown result type (might be due to invalid IL or missing references)
		//IL_23a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_23aa: Expected O, but got Unknown
		//IL_23a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_23af: Expected O, but got Unknown
		//IL_23b4: Expected O, but got Unknown
		//IL_23c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_23c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_23d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_23e2: Expected O, but got Unknown
		//IL_23e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_23f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_23fb: Expected O, but got Unknown
		//IL_23f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_2400: Expected O, but got Unknown
		//IL_2405: Expected O, but got Unknown
		//IL_2471: Unknown result type (might be due to invalid IL or missing references)
		//IL_2476: Unknown result type (might be due to invalid IL or missing references)
		//IL_2481: Unknown result type (might be due to invalid IL or missing references)
		//IL_2486: Unknown result type (might be due to invalid IL or missing references)
		//IL_24eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_24f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_24f3: Expected O, but got Unknown
		//IL_24f8: Expected O, but got Unknown
		//IL_24f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_250a: Unknown result type (might be due to invalid IL or missing references)
		//IL_2519: Unknown result type (might be due to invalid IL or missing references)
		//IL_2523: Expected O, but got Unknown
		//IL_251e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2528: Expected O, but got Unknown
		//IL_252d: Expected O, but got Unknown
		//IL_2544: Unknown result type (might be due to invalid IL or missing references)
		//IL_2549: Unknown result type (might be due to invalid IL or missing references)
		//IL_2554: Unknown result type (might be due to invalid IL or missing references)
		//IL_2559: Unknown result type (might be due to invalid IL or missing references)
		//IL_25be: Unknown result type (might be due to invalid IL or missing references)
		//IL_25c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_25c6: Expected O, but got Unknown
		//IL_25cb: Expected O, but got Unknown
		//IL_25cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_25dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_25ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_25f6: Expected O, but got Unknown
		//IL_25f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_25fb: Expected O, but got Unknown
		//IL_2600: Expected O, but got Unknown
		//IL_260d: Unknown result type (might be due to invalid IL or missing references)
		//IL_2612: Unknown result type (might be due to invalid IL or missing references)
		//IL_2624: Unknown result type (might be due to invalid IL or missing references)
		//IL_262e: Expected O, but got Unknown
		//IL_262e: Unknown result type (might be due to invalid IL or missing references)
		//IL_263d: Unknown result type (might be due to invalid IL or missing references)
		//IL_2647: Expected O, but got Unknown
		//IL_2642: Unknown result type (might be due to invalid IL or missing references)
		//IL_264c: Expected O, but got Unknown
		//IL_2651: Expected O, but got Unknown
		//IL_2695: Unknown result type (might be due to invalid IL or missing references)
		//IL_269a: Unknown result type (might be due to invalid IL or missing references)
		//IL_26a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_26aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_270f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2714: Unknown result type (might be due to invalid IL or missing references)
		//IL_2717: Expected O, but got Unknown
		//IL_271c: Expected O, but got Unknown
		//IL_271c: Unknown result type (might be due to invalid IL or missing references)
		//IL_272e: Unknown result type (might be due to invalid IL or missing references)
		//IL_273d: Unknown result type (might be due to invalid IL or missing references)
		//IL_2747: Expected O, but got Unknown
		//IL_2742: Unknown result type (might be due to invalid IL or missing references)
		//IL_274c: Expected O, but got Unknown
		//IL_2751: Expected O, but got Unknown
		//IL_2768: Unknown result type (might be due to invalid IL or missing references)
		//IL_276d: Unknown result type (might be due to invalid IL or missing references)
		//IL_2778: Unknown result type (might be due to invalid IL or missing references)
		//IL_277d: Unknown result type (might be due to invalid IL or missing references)
		//IL_27e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_27e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_27ea: Expected O, but got Unknown
		//IL_27ef: Expected O, but got Unknown
		//IL_27ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_2801: Unknown result type (might be due to invalid IL or missing references)
		//IL_2810: Unknown result type (might be due to invalid IL or missing references)
		//IL_281a: Expected O, but got Unknown
		//IL_2815: Unknown result type (might be due to invalid IL or missing references)
		//IL_281f: Expected O, but got Unknown
		//IL_2824: Expected O, but got Unknown
		//IL_2831: Unknown result type (might be due to invalid IL or missing references)
		//IL_2836: Unknown result type (might be due to invalid IL or missing references)
		//IL_2848: Unknown result type (might be due to invalid IL or missing references)
		//IL_2852: Expected O, but got Unknown
		//IL_2852: Unknown result type (might be due to invalid IL or missing references)
		//IL_2861: Unknown result type (might be due to invalid IL or missing references)
		//IL_286b: Expected O, but got Unknown
		//IL_2866: Unknown result type (might be due to invalid IL or missing references)
		//IL_2870: Expected O, but got Unknown
		//IL_2875: Expected O, but got Unknown
		//IL_28dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_28e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_28ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_28f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_2956: Unknown result type (might be due to invalid IL or missing references)
		//IL_295b: Unknown result type (might be due to invalid IL or missing references)
		//IL_295e: Expected O, but got Unknown
		//IL_2963: Expected O, but got Unknown
		//IL_2963: Unknown result type (might be due to invalid IL or missing references)
		//IL_2975: Unknown result type (might be due to invalid IL or missing references)
		//IL_2984: Unknown result type (might be due to invalid IL or missing references)
		//IL_298e: Expected O, but got Unknown
		//IL_2989: Unknown result type (might be due to invalid IL or missing references)
		//IL_2993: Expected O, but got Unknown
		//IL_2998: Expected O, but got Unknown
		//IL_29af: Unknown result type (might be due to invalid IL or missing references)
		//IL_29b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_29bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_29c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a29: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a2e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a31: Expected O, but got Unknown
		//IL_2a36: Expected O, but got Unknown
		//IL_2a36: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a48: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a57: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a61: Expected O, but got Unknown
		//IL_2a5c: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a66: Expected O, but got Unknown
		//IL_2a6b: Expected O, but got Unknown
		//IL_2a78: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a7d: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a8f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a99: Expected O, but got Unknown
		//IL_2a99: Unknown result type (might be due to invalid IL or missing references)
		//IL_2aa8: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ab2: Expected O, but got Unknown
		//IL_2aad: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ab7: Expected O, but got Unknown
		//IL_2abc: Expected O, but got Unknown
		//IL_2b2b: Unknown result type (might be due to invalid IL or missing references)
		//IL_2b30: Unknown result type (might be due to invalid IL or missing references)
		//IL_2b3b: Unknown result type (might be due to invalid IL or missing references)
		//IL_2b40: Unknown result type (might be due to invalid IL or missing references)
		//IL_2b8c: Unknown result type (might be due to invalid IL or missing references)
		//IL_2b91: Unknown result type (might be due to invalid IL or missing references)
		//IL_2b94: Expected O, but got Unknown
		//IL_2b99: Expected O, but got Unknown
		//IL_2b99: Unknown result type (might be due to invalid IL or missing references)
		//IL_2bab: Unknown result type (might be due to invalid IL or missing references)
		//IL_2bba: Unknown result type (might be due to invalid IL or missing references)
		//IL_2bc4: Expected O, but got Unknown
		//IL_2bbf: Unknown result type (might be due to invalid IL or missing references)
		//IL_2bc9: Expected O, but got Unknown
		//IL_2bce: Expected O, but got Unknown
		//IL_2c48: Unknown result type (might be due to invalid IL or missing references)
		//IL_2c4d: Unknown result type (might be due to invalid IL or missing references)
		//IL_2c58: Unknown result type (might be due to invalid IL or missing references)
		//IL_2c5d: Unknown result type (might be due to invalid IL or missing references)
		//IL_2cc2: Unknown result type (might be due to invalid IL or missing references)
		//IL_2cc7: Unknown result type (might be due to invalid IL or missing references)
		//IL_2cca: Expected O, but got Unknown
		//IL_2ccf: Expected O, but got Unknown
		//IL_2ccf: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ce1: Unknown result type (might be due to invalid IL or missing references)
		//IL_2cf0: Unknown result type (might be due to invalid IL or missing references)
		//IL_2cfa: Expected O, but got Unknown
		//IL_2cf5: Unknown result type (might be due to invalid IL or missing references)
		//IL_2cff: Expected O, but got Unknown
		//IL_2d04: Expected O, but got Unknown
		//IL_2d1b: Unknown result type (might be due to invalid IL or missing references)
		//IL_2d20: Unknown result type (might be due to invalid IL or missing references)
		//IL_2d2b: Unknown result type (might be due to invalid IL or missing references)
		//IL_2d30: Unknown result type (might be due to invalid IL or missing references)
		//IL_2d95: Unknown result type (might be due to invalid IL or missing references)
		//IL_2d9a: Unknown result type (might be due to invalid IL or missing references)
		//IL_2d9d: Expected O, but got Unknown
		//IL_2da2: Expected O, but got Unknown
		//IL_2da2: Unknown result type (might be due to invalid IL or missing references)
		//IL_2db4: Unknown result type (might be due to invalid IL or missing references)
		//IL_2dc3: Unknown result type (might be due to invalid IL or missing references)
		//IL_2dcd: Expected O, but got Unknown
		//IL_2dc8: Unknown result type (might be due to invalid IL or missing references)
		//IL_2dd2: Expected O, but got Unknown
		//IL_2dd7: Expected O, but got Unknown
		//IL_2de4: Unknown result type (might be due to invalid IL or missing references)
		//IL_2de9: Unknown result type (might be due to invalid IL or missing references)
		//IL_2dfb: Unknown result type (might be due to invalid IL or missing references)
		//IL_2e05: Expected O, but got Unknown
		//IL_2e05: Unknown result type (might be due to invalid IL or missing references)
		//IL_2e14: Unknown result type (might be due to invalid IL or missing references)
		//IL_2e1e: Expected O, but got Unknown
		//IL_2e19: Unknown result type (might be due to invalid IL or missing references)
		//IL_2e23: Expected O, but got Unknown
		//IL_2e28: Expected O, but got Unknown
		//IL_2e6c: Unknown result type (might be due to invalid IL or missing references)
		//IL_2e71: Unknown result type (might be due to invalid IL or missing references)
		//IL_2e7c: Unknown result type (might be due to invalid IL or missing references)
		//IL_2e81: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ee6: Unknown result type (might be due to invalid IL or missing references)
		//IL_2eeb: Unknown result type (might be due to invalid IL or missing references)
		//IL_2eee: Expected O, but got Unknown
		//IL_2ef3: Expected O, but got Unknown
		//IL_2ef3: Unknown result type (might be due to invalid IL or missing references)
		//IL_2f05: Unknown result type (might be due to invalid IL or missing references)
		//IL_2f14: Unknown result type (might be due to invalid IL or missing references)
		//IL_2f1e: Expected O, but got Unknown
		//IL_2f19: Unknown result type (might be due to invalid IL or missing references)
		//IL_2f23: Expected O, but got Unknown
		//IL_2f28: Expected O, but got Unknown
		//IL_2f3f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2f44: Unknown result type (might be due to invalid IL or missing references)
		//IL_2f4f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2f54: Unknown result type (might be due to invalid IL or missing references)
		//IL_2fb9: Unknown result type (might be due to invalid IL or missing references)
		//IL_2fbe: Unknown result type (might be due to invalid IL or missing references)
		//IL_2fc1: Expected O, but got Unknown
		//IL_2fc6: Expected O, but got Unknown
		//IL_2fc6: Unknown result type (might be due to invalid IL or missing references)
		//IL_2fd8: Unknown result type (might be due to invalid IL or missing references)
		//IL_2fe7: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ff1: Expected O, but got Unknown
		//IL_2fec: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ff6: Expected O, but got Unknown
		//IL_2ffb: Expected O, but got Unknown
		//IL_3008: Unknown result type (might be due to invalid IL or missing references)
		//IL_300d: Unknown result type (might be due to invalid IL or missing references)
		//IL_301f: Unknown result type (might be due to invalid IL or missing references)
		//IL_3029: Expected O, but got Unknown
		//IL_3029: Unknown result type (might be due to invalid IL or missing references)
		//IL_3038: Unknown result type (might be due to invalid IL or missing references)
		//IL_3042: Expected O, but got Unknown
		//IL_303d: Unknown result type (might be due to invalid IL or missing references)
		//IL_3047: Expected O, but got Unknown
		//IL_304c: Expected O, but got Unknown
		//IL_3090: Unknown result type (might be due to invalid IL or missing references)
		//IL_30b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_30be: Unknown result type (might be due to invalid IL or missing references)
		//IL_30d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_30da: Expected O, but got Unknown
		//IL_30da: Unknown result type (might be due to invalid IL or missing references)
		//IL_30e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_30f3: Expected O, but got Unknown
		//IL_30ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_30f8: Expected O, but got Unknown
		//IL_30fd: Expected O, but got Unknown
		//IL_3164: Unknown result type (might be due to invalid IL or missing references)
		//IL_3169: Unknown result type (might be due to invalid IL or missing references)
		//IL_317b: Unknown result type (might be due to invalid IL or missing references)
		//IL_3185: Expected O, but got Unknown
		//IL_3185: Unknown result type (might be due to invalid IL or missing references)
		//IL_3194: Unknown result type (might be due to invalid IL or missing references)
		//IL_319e: Expected O, but got Unknown
		//IL_3199: Unknown result type (might be due to invalid IL or missing references)
		//IL_31a3: Expected O, but got Unknown
		//IL_31a8: Expected O, but got Unknown
		//IL_31f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_31f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_3208: Unknown result type (might be due to invalid IL or missing references)
		//IL_3212: Expected O, but got Unknown
		//IL_3212: Unknown result type (might be due to invalid IL or missing references)
		//IL_3221: Unknown result type (might be due to invalid IL or missing references)
		//IL_322b: Expected O, but got Unknown
		//IL_3226: Unknown result type (might be due to invalid IL or missing references)
		//IL_3230: Expected O, but got Unknown
		//IL_3235: Expected O, but got Unknown
		//IL_327e: Unknown result type (might be due to invalid IL or missing references)
		//IL_3283: Unknown result type (might be due to invalid IL or missing references)
		//IL_3295: Unknown result type (might be due to invalid IL or missing references)
		//IL_329f: Expected O, but got Unknown
		//IL_329f: Unknown result type (might be due to invalid IL or missing references)
		//IL_32ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_32b8: Expected O, but got Unknown
		//IL_32b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_32bd: Expected O, but got Unknown
		//IL_32c2: Expected O, but got Unknown
		//IL_330b: Unknown result type (might be due to invalid IL or missing references)
		//IL_3310: Unknown result type (might be due to invalid IL or missing references)
		//IL_3322: Unknown result type (might be due to invalid IL or missing references)
		//IL_332c: Expected O, but got Unknown
		//IL_332c: Unknown result type (might be due to invalid IL or missing references)
		//IL_333b: Unknown result type (might be due to invalid IL or missing references)
		//IL_3345: Expected O, but got Unknown
		//IL_3340: Unknown result type (might be due to invalid IL or missing references)
		//IL_334a: Expected O, but got Unknown
		//IL_334f: Expected O, but got Unknown
		//IL_3398: Unknown result type (might be due to invalid IL or missing references)
		//IL_339d: Unknown result type (might be due to invalid IL or missing references)
		//IL_33af: Unknown result type (might be due to invalid IL or missing references)
		//IL_33b9: Expected O, but got Unknown
		//IL_33b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_33c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_33d2: Expected O, but got Unknown
		//IL_33cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_33d7: Expected O, but got Unknown
		//IL_33dc: Expected O, but got Unknown
		StaticResourceExtension val = new StaticResourceExtension();
		StaticResourceExtension val2 = new StaticResourceExtension();
		AppThemeBindingExtension val3 = new AppThemeBindingExtension();
		StaticResourceExtension val4 = new StaticResourceExtension();
		StaticResourceExtension val5 = new StaticResourceExtension();
		AppThemeBindingExtension val6 = new AppThemeBindingExtension();
		Label val7 = new Label();
		StaticResourceExtension val8 = new StaticResourceExtension();
		StaticResourceExtension val9 = new StaticResourceExtension();
		AppThemeBindingExtension val10 = new AppThemeBindingExtension();
		Label val11 = new Label();
		StaticResourceExtension val12 = new StaticResourceExtension();
		StaticResourceExtension val13 = new StaticResourceExtension();
		AppThemeBindingExtension val14 = new AppThemeBindingExtension();
		BoxView val15 = new BoxView();
		StaticResourceExtension val16 = new StaticResourceExtension();
		StaticResourceExtension val17 = new StaticResourceExtension();
		AppThemeBindingExtension val18 = new AppThemeBindingExtension();
		Label val19 = new Label();
		StaticResourceExtension val20 = new StaticResourceExtension();
		Entry val21 = new Entry();
		StaticResourceExtension val22 = new StaticResourceExtension();
		StaticResourceExtension val23 = new StaticResourceExtension();
		AppThemeBindingExtension val24 = new AppThemeBindingExtension();
		Label val25 = new Label();
		StaticResourceExtension val26 = new StaticResourceExtension();
		Entry val27 = new Entry();
		StaticResourceExtension val28 = new StaticResourceExtension();
		StaticResourceExtension val29 = new StaticResourceExtension();
		AppThemeBindingExtension val30 = new AppThemeBindingExtension();
		Label val31 = new Label();
		StaticResourceExtension val32 = new StaticResourceExtension();
		Entry val33 = new Entry();
		StaticResourceExtension val34 = new StaticResourceExtension();
		StaticResourceExtension val35 = new StaticResourceExtension();
		AppThemeBindingExtension val36 = new AppThemeBindingExtension();
		Label val37 = new Label();
		StaticResourceExtension val38 = new StaticResourceExtension();
		StaticResourceExtension val39 = new StaticResourceExtension();
		AppThemeBindingExtension val40 = new AppThemeBindingExtension();
		BoxView val41 = new BoxView();
		StaticResourceExtension val42 = new StaticResourceExtension();
		StaticResourceExtension val43 = new StaticResourceExtension();
		AppThemeBindingExtension val44 = new AppThemeBindingExtension();
		Label val45 = new Label();
		StaticResourceExtension val46 = new StaticResourceExtension();
		StaticResourceExtension val47 = new StaticResourceExtension();
		AppThemeBindingExtension val48 = new AppThemeBindingExtension();
		StaticResourceExtension val49 = new StaticResourceExtension();
		StaticResourceExtension val50 = new StaticResourceExtension();
		AppThemeBindingExtension val51 = new AppThemeBindingExtension();
		StaticResourceExtension val52 = new StaticResourceExtension();
		StaticResourceExtension val53 = new StaticResourceExtension();
		AppThemeBindingExtension val54 = new AppThemeBindingExtension();
		SearchBar val55 = new SearchBar();
		StaticResourceExtension val56 = new StaticResourceExtension();
		StaticResourceExtension val57 = new StaticResourceExtension();
		AppThemeBindingExtension val58 = new AppThemeBindingExtension();
		Label val59 = new Label();
		StaticResourceExtension val60 = new StaticResourceExtension();
		StaticResourceExtension val61 = new StaticResourceExtension();
		AppThemeBindingExtension val62 = new AppThemeBindingExtension();
		BoxView val63 = new BoxView();
		StaticResourceExtension val64 = new StaticResourceExtension();
		StaticResourceExtension val65 = new StaticResourceExtension();
		AppThemeBindingExtension val66 = new AppThemeBindingExtension();
		Label val67 = new Label();
		StaticResourceExtension val68 = new StaticResourceExtension();
		Editor val69 = new Editor();
		StaticResourceExtension val70 = new StaticResourceExtension();
		StaticResourceExtension val71 = new StaticResourceExtension();
		AppThemeBindingExtension val72 = new AppThemeBindingExtension();
		Label val73 = new Label();
		StaticResourceExtension val74 = new StaticResourceExtension();
		StaticResourceExtension val75 = new StaticResourceExtension();
		AppThemeBindingExtension val76 = new AppThemeBindingExtension();
		BoxView val77 = new BoxView();
		AppThemeBindingExtension val78 = new AppThemeBindingExtension();
		AppThemeBindingExtension val79 = new AppThemeBindingExtension();
		Label val80 = new Label();
		AppThemeBindingExtension val81 = new AppThemeBindingExtension();
		Label val82 = new Label();
		AppThemeBindingExtension val83 = new AppThemeBindingExtension();
		Label val84 = new Label();
		AppThemeBindingExtension val85 = new AppThemeBindingExtension();
		Label val86 = new Label();
		AppThemeBindingExtension val87 = new AppThemeBindingExtension();
		Label val88 = new Label();
		VerticalStackLayout val89 = new VerticalStackLayout();
		Frame val90 = new Frame();
		VerticalStackLayout val91 = new VerticalStackLayout();
		ScrollView val92 = new ScrollView();
		TextInputPage textInputPage;
		NameScope val93 = (NameScope)(((object)NameScope.GetNameScope((BindableObject)(object)(textInputPage = this))) ?? ((object)new NameScope()));
		NameScope.SetNameScope((BindableObject)(object)textInputPage, (INameScope)(object)val93);
		((Element)val92).transientNamescope = (INameScope)(object)val93;
		((Element)val91).transientNamescope = (INameScope)(object)val93;
		((Element)val7).transientNamescope = (INameScope)(object)val93;
		((Element)val11).transientNamescope = (INameScope)(object)val93;
		((Element)val15).transientNamescope = (INameScope)(object)val93;
		((Element)val19).transientNamescope = (INameScope)(object)val93;
		((Element)val21).transientNamescope = (INameScope)(object)val93;
		((INameScope)val93).RegisterName("NameEntry", (object)val21);
		if (((Element)val21).StyleId == null)
		{
			((Element)val21).StyleId = "NameEntry";
		}
		((Element)val25).transientNamescope = (INameScope)(object)val93;
		((INameScope)val93).RegisterName("EntryOutput", (object)val25);
		if (((Element)val25).StyleId == null)
		{
			((Element)val25).StyleId = "EntryOutput";
		}
		((Element)val27).transientNamescope = (INameScope)(object)val93;
		((Element)val31).transientNamescope = (INameScope)(object)val93;
		((Element)val33).transientNamescope = (INameScope)(object)val93;
		((Element)val37).transientNamescope = (INameScope)(object)val93;
		((Element)val41).transientNamescope = (INameScope)(object)val93;
		((Element)val45).transientNamescope = (INameScope)(object)val93;
		((Element)val55).transientNamescope = (INameScope)(object)val93;
		((INameScope)val93).RegisterName("SearchBarControl", (object)val55);
		if (((Element)val55).StyleId == null)
		{
			((Element)val55).StyleId = "SearchBarControl";
		}
		((Element)val59).transientNamescope = (INameScope)(object)val93;
		((INameScope)val93).RegisterName("SearchOutput", (object)val59);
		if (((Element)val59).StyleId == null)
		{
			((Element)val59).StyleId = "SearchOutput";
		}
		((Element)val63).transientNamescope = (INameScope)(object)val93;
		((Element)val67).transientNamescope = (INameScope)(object)val93;
		((Element)val69).transientNamescope = (INameScope)(object)val93;
		((INameScope)val93).RegisterName("EditorControl", (object)val69);
		if (((Element)val69).StyleId == null)
		{
			((Element)val69).StyleId = "EditorControl";
		}
		((Element)val73).transientNamescope = (INameScope)(object)val93;
		((INameScope)val93).RegisterName("EditorOutput", (object)val73);
		if (((Element)val73).StyleId == null)
		{
			((Element)val73).StyleId = "EditorOutput";
		}
		((Element)val77).transientNamescope = (INameScope)(object)val93;
		((Element)val90).transientNamescope = (INameScope)(object)val93;
		((Element)val89).transientNamescope = (INameScope)(object)val93;
		((Element)val80).transientNamescope = (INameScope)(object)val93;
		((Element)val82).transientNamescope = (INameScope)(object)val93;
		((Element)val84).transientNamescope = (INameScope)(object)val93;
		((Element)val86).transientNamescope = (INameScope)(object)val93;
		((Element)val88).transientNamescope = (INameScope)(object)val93;
		NameEntry = val21;
		EntryOutput = val25;
		SearchBarControl = val55;
		SearchOutput = val59;
		EditorControl = val69;
		EditorOutput = val73;
		((BindableObject)textInputPage).SetValue(Page.TitleProperty, (object)"Text Input");
		val.Key = "PageBackgroundLight";
		StaticResourceExtension val94 = new StaticResourceExtension
		{
			Key = "PageBackgroundLight"
		};
		XamlServiceProvider val95 = new XamlServiceProvider();
		Type? typeFromHandle = typeof(IProvideValueTarget);
		object[] array = new object[0 + 2];
		array[0] = val3;
		array[1] = textInputPage;
		SimpleValueTargetProvider val96 = new SimpleValueTargetProvider(array, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Light"), (INameScope[])(object)new NameScope[3] { val93, val93, val93 }, false);
		object obj = (object)val96;
		val95.Add(typeFromHandle, (object)val96);
		val95.Add(typeof(IReferenceProvider), obj);
		val95.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(6, 14)));
		object light = val94.ProvideValue((IServiceProvider)val95);
		val3.Light = light;
		val2.Key = "PageBackgroundDark";
		StaticResourceExtension val97 = new StaticResourceExtension
		{
			Key = "PageBackgroundDark"
		};
		XamlServiceProvider val98 = new XamlServiceProvider();
		Type? typeFromHandle2 = typeof(IProvideValueTarget);
		object[] array2 = new object[0 + 2];
		array2[0] = val3;
		array2[1] = textInputPage;
		SimpleValueTargetProvider val99 = new SimpleValueTargetProvider(array2, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Dark"), (INameScope[])(object)new NameScope[3] { val93, val93, val93 }, false);
		object obj2 = (object)val99;
		val98.Add(typeFromHandle2, (object)val99);
		val98.Add(typeof(IReferenceProvider), obj2);
		val98.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(6, 14)));
		object dark = val97.ProvideValue((IServiceProvider)val98);
		val3.Dark = dark;
		XamlServiceProvider val100 = new XamlServiceProvider();
		val100.Add(typeof(IProvideValueTarget), (object)new ValueTargetProvider((object)textInputPage, (object)VisualElement.BackgroundColorProperty));
		val100.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(6, 14)));
		BindingBase val101 = ((IMarkupExtension<BindingBase>)(object)val3).ProvideValue((IServiceProvider)val100);
		((BindableObject)textInputPage).SetBinding(VisualElement.BackgroundColorProperty, val101);
		((BindableObject)val91).SetValue(Layout.PaddingProperty, (object)new Thickness(20.0));
		((BindableObject)val91).SetValue(StackBase.SpacingProperty, (object)15.0);
		((BindableObject)val7).SetValue(Label.TextProperty, (object)"Text Input Controls");
		((BindableObject)val7).SetValue(Label.FontSizeProperty, (object)24.0);
		((BindableObject)val7).SetValue(Label.FontAttributesProperty, (object)(FontAttributes)1);
		val4.Key = "TextPrimaryLight";
		StaticResourceExtension val102 = new StaticResourceExtension
		{
			Key = "TextPrimaryLight"
		};
		XamlServiceProvider val103 = new XamlServiceProvider();
		Type? typeFromHandle3 = typeof(IProvideValueTarget);
		object[] array3 = new object[0 + 5];
		array3[0] = val6;
		array3[1] = val7;
		array3[2] = val91;
		array3[3] = val92;
		array3[4] = textInputPage;
		SimpleValueTargetProvider val104 = new SimpleValueTargetProvider(array3, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Light"), (INameScope[])(object)new NameScope[6] { val93, val93, val93, val93, val93, val93 }, false);
		object obj3 = (object)val104;
		val103.Add(typeFromHandle3, (object)val104);
		val103.Add(typeof(IReferenceProvider), obj3);
		val103.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(11, 20)));
		object light2 = val102.ProvideValue((IServiceProvider)val103);
		val6.Light = light2;
		val5.Key = "TextPrimaryDark";
		StaticResourceExtension val105 = new StaticResourceExtension
		{
			Key = "TextPrimaryDark"
		};
		XamlServiceProvider val106 = new XamlServiceProvider();
		Type? typeFromHandle4 = typeof(IProvideValueTarget);
		object[] array4 = new object[0 + 5];
		array4[0] = val6;
		array4[1] = val7;
		array4[2] = val91;
		array4[3] = val92;
		array4[4] = textInputPage;
		SimpleValueTargetProvider val107 = new SimpleValueTargetProvider(array4, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Dark"), (INameScope[])(object)new NameScope[6] { val93, val93, val93, val93, val93, val93 }, false);
		object obj4 = (object)val107;
		val106.Add(typeFromHandle4, (object)val107);
		val106.Add(typeof(IReferenceProvider), obj4);
		val106.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(11, 20)));
		object dark2 = val105.ProvideValue((IServiceProvider)val106);
		val6.Dark = dark2;
		XamlServiceProvider val108 = new XamlServiceProvider();
		val108.Add(typeof(IProvideValueTarget), (object)new ValueTargetProvider((object)val7, (object)Label.TextColorProperty));
		val108.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(11, 20)));
		BindingBase val109 = ((IMarkupExtension<BindingBase>)(object)val6).ProvideValue((IServiceProvider)val108);
		((BindableObject)val7).SetBinding(Label.TextColorProperty, val109);
		((Layout)val91).Children.Add((IView)(object)val7);
		((BindableObject)val11).SetValue(Label.TextProperty, (object)"Click on any field and start typing.");
		((BindableObject)val11).SetValue(Label.FontSizeProperty, (object)14.0);
		val8.Key = "TextSecondaryLight";
		StaticResourceExtension val110 = new StaticResourceExtension
		{
			Key = "TextSecondaryLight"
		};
		XamlServiceProvider val111 = new XamlServiceProvider();
		Type? typeFromHandle5 = typeof(IProvideValueTarget);
		object[] array5 = new object[0 + 5];
		array5[0] = val10;
		array5[1] = val11;
		array5[2] = val91;
		array5[3] = val92;
		array5[4] = textInputPage;
		SimpleValueTargetProvider val112 = new SimpleValueTargetProvider(array5, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Light"), (INameScope[])(object)new NameScope[6] { val93, val93, val93, val93, val93, val93 }, false);
		object obj5 = (object)val112;
		val111.Add(typeFromHandle5, (object)val112);
		val111.Add(typeof(IReferenceProvider), obj5);
		val111.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(14, 20)));
		object light3 = val110.ProvideValue((IServiceProvider)val111);
		val10.Light = light3;
		val9.Key = "TextSecondaryDark";
		StaticResourceExtension val113 = new StaticResourceExtension
		{
			Key = "TextSecondaryDark"
		};
		XamlServiceProvider val114 = new XamlServiceProvider();
		Type? typeFromHandle6 = typeof(IProvideValueTarget);
		object[] array6 = new object[0 + 5];
		array6[0] = val10;
		array6[1] = val11;
		array6[2] = val91;
		array6[3] = val92;
		array6[4] = textInputPage;
		SimpleValueTargetProvider val115 = new SimpleValueTargetProvider(array6, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Dark"), (INameScope[])(object)new NameScope[6] { val93, val93, val93, val93, val93, val93 }, false);
		object obj6 = (object)val115;
		val114.Add(typeFromHandle6, (object)val115);
		val114.Add(typeof(IReferenceProvider), obj6);
		val114.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(14, 20)));
		object dark3 = val113.ProvideValue((IServiceProvider)val114);
		val10.Dark = dark3;
		XamlServiceProvider val116 = new XamlServiceProvider();
		val116.Add(typeof(IProvideValueTarget), (object)new ValueTargetProvider((object)val11, (object)Label.TextColorProperty));
		val116.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(14, 20)));
		BindingBase val117 = ((IMarkupExtension<BindingBase>)(object)val10).ProvideValue((IServiceProvider)val116);
		((BindableObject)val11).SetBinding(Label.TextColorProperty, val117);
		((Layout)val91).Children.Add((IView)(object)val11);
		((BindableObject)val15).SetValue(VisualElement.HeightRequestProperty, (object)1.0);
		val12.Key = "BorderLight";
		StaticResourceExtension val118 = new StaticResourceExtension
		{
			Key = "BorderLight"
		};
		XamlServiceProvider val119 = new XamlServiceProvider();
		Type? typeFromHandle7 = typeof(IProvideValueTarget);
		object[] array7 = new object[0 + 5];
		array7[0] = val14;
		array7[1] = val15;
		array7[2] = val91;
		array7[3] = val92;
		array7[4] = textInputPage;
		SimpleValueTargetProvider val120 = new SimpleValueTargetProvider(array7, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Light"), (INameScope[])(object)new NameScope[6] { val93, val93, val93, val93, val93, val93 }, false);
		object obj7 = (object)val120;
		val119.Add(typeFromHandle7, (object)val120);
		val119.Add(typeof(IReferenceProvider), obj7);
		val119.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(17, 40)));
		object light4 = val118.ProvideValue((IServiceProvider)val119);
		val14.Light = light4;
		val13.Key = "BorderDark";
		StaticResourceExtension val121 = new StaticResourceExtension
		{
			Key = "BorderDark"
		};
		XamlServiceProvider val122 = new XamlServiceProvider();
		Type? typeFromHandle8 = typeof(IProvideValueTarget);
		object[] array8 = new object[0 + 5];
		array8[0] = val14;
		array8[1] = val15;
		array8[2] = val91;
		array8[3] = val92;
		array8[4] = textInputPage;
		SimpleValueTargetProvider val123 = new SimpleValueTargetProvider(array8, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Dark"), (INameScope[])(object)new NameScope[6] { val93, val93, val93, val93, val93, val93 }, false);
		object obj8 = (object)val123;
		val122.Add(typeFromHandle8, (object)val123);
		val122.Add(typeof(IReferenceProvider), obj8);
		val122.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(17, 40)));
		object dark4 = val121.ProvideValue((IServiceProvider)val122);
		val14.Dark = dark4;
		XamlServiceProvider val124 = new XamlServiceProvider();
		val124.Add(typeof(IProvideValueTarget), (object)new ValueTargetProvider((object)val15, (object)BoxView.ColorProperty));
		val124.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(17, 40)));
		BindingBase val125 = ((IMarkupExtension<BindingBase>)(object)val14).ProvideValue((IServiceProvider)val124);
		((BindableObject)val15).SetBinding(BoxView.ColorProperty, val125);
		((Layout)val91).Children.Add((IView)(object)val15);
		((BindableObject)val19).SetValue(Label.TextProperty, (object)"Entry (Single Line)");
		((BindableObject)val19).SetValue(Label.FontSizeProperty, (object)18.0);
		((BindableObject)val19).SetValue(Label.FontAttributesProperty, (object)(FontAttributes)1);
		val16.Key = "TextPrimaryLight";
		StaticResourceExtension val126 = new StaticResourceExtension
		{
			Key = "TextPrimaryLight"
		};
		XamlServiceProvider val127 = new XamlServiceProvider();
		Type? typeFromHandle9 = typeof(IProvideValueTarget);
		object[] array9 = new object[0 + 5];
		array9[0] = val18;
		array9[1] = val19;
		array9[2] = val91;
		array9[3] = val92;
		array9[4] = textInputPage;
		SimpleValueTargetProvider val128 = new SimpleValueTargetProvider(array9, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Light"), (INameScope[])(object)new NameScope[6] { val93, val93, val93, val93, val93, val93 }, false);
		object obj9 = (object)val128;
		val127.Add(typeFromHandle9, (object)val128);
		val127.Add(typeof(IReferenceProvider), obj9);
		val127.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(19, 20)));
		object light5 = val126.ProvideValue((IServiceProvider)val127);
		val18.Light = light5;
		val17.Key = "TextPrimaryDark";
		StaticResourceExtension val129 = new StaticResourceExtension
		{
			Key = "TextPrimaryDark"
		};
		XamlServiceProvider val130 = new XamlServiceProvider();
		Type? typeFromHandle10 = typeof(IProvideValueTarget);
		object[] array10 = new object[0 + 5];
		array10[0] = val18;
		array10[1] = val19;
		array10[2] = val91;
		array10[3] = val92;
		array10[4] = textInputPage;
		SimpleValueTargetProvider val131 = new SimpleValueTargetProvider(array10, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Dark"), (INameScope[])(object)new NameScope[6] { val93, val93, val93, val93, val93, val93 }, false);
		object obj10 = (object)val131;
		val130.Add(typeFromHandle10, (object)val131);
		val130.Add(typeof(IReferenceProvider), obj10);
		val130.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(19, 20)));
		object dark5 = val129.ProvideValue((IServiceProvider)val130);
		val18.Dark = dark5;
		XamlServiceProvider val132 = new XamlServiceProvider();
		val132.Add(typeof(IProvideValueTarget), (object)new ValueTargetProvider((object)val19, (object)Label.TextColorProperty));
		val132.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(19, 20)));
		BindingBase val133 = ((IMarkupExtension<BindingBase>)(object)val18).ProvideValue((IServiceProvider)val132);
		((BindableObject)val19).SetBinding(Label.TextColorProperty, val133);
		((Layout)val91).Children.Add((IView)(object)val19);
		((BindableObject)val21).SetValue(Entry.PlaceholderProperty, (object)"Enter your name...");
		((BindableObject)val21).SetValue(Entry.FontSizeProperty, (object)14.0);
		val20.Key = "ThemedEntry";
		StaticResourceExtension val134 = new StaticResourceExtension
		{
			Key = "ThemedEntry"
		};
		XamlServiceProvider val135 = new XamlServiceProvider();
		Type? typeFromHandle11 = typeof(IProvideValueTarget);
		object[] array11 = new object[0 + 4];
		array11[0] = val21;
		array11[1] = val91;
		array11[2] = val92;
		array11[3] = textInputPage;
		SimpleValueTargetProvider val136 = new SimpleValueTargetProvider(array11, (object)VisualElement.StyleProperty, (INameScope[])(object)new NameScope[5] { val93, val93, val93, val93, val93 }, false);
		object obj11 = (object)val136;
		val135.Add(typeFromHandle11, (object)val136);
		val135.Add(typeof(IReferenceProvider), obj11);
		val135.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(22, 20)));
		object obj12 = val134.ProvideValue((IServiceProvider)val135);
		((BindableObject)val21).SetValue(VisualElement.StyleProperty, (obj12 == null || !typeof(BindingBase).IsAssignableFrom(obj12.GetType())) ? obj12 : obj12);
		((InputView)val21).TextChanged += textInputPage.OnNameEntryTextChanged;
		((Layout)val91).Children.Add((IView)(object)val21);
		((BindableObject)val25).SetValue(Label.FontSizeProperty, (object)12.0);
		val22.Key = "TextSecondaryLight";
		StaticResourceExtension val137 = new StaticResourceExtension
		{
			Key = "TextSecondaryLight"
		};
		XamlServiceProvider val138 = new XamlServiceProvider();
		Type? typeFromHandle12 = typeof(IProvideValueTarget);
		object[] array12 = new object[0 + 5];
		array12[0] = val24;
		array12[1] = val25;
		array12[2] = val91;
		array12[3] = val92;
		array12[4] = textInputPage;
		SimpleValueTargetProvider val139 = new SimpleValueTargetProvider(array12, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Light"), (INameScope[])(object)new NameScope[6] { val93, val93, val93, val93, val93, val93 }, false);
		object obj13 = (object)val139;
		val138.Add(typeFromHandle12, (object)val139);
		val138.Add(typeof(IReferenceProvider), obj13);
		val138.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(25, 20)));
		object light6 = val137.ProvideValue((IServiceProvider)val138);
		val24.Light = light6;
		val23.Key = "TextSecondaryDark";
		StaticResourceExtension val140 = new StaticResourceExtension
		{
			Key = "TextSecondaryDark"
		};
		XamlServiceProvider val141 = new XamlServiceProvider();
		Type? typeFromHandle13 = typeof(IProvideValueTarget);
		object[] array13 = new object[0 + 5];
		array13[0] = val24;
		array13[1] = val25;
		array13[2] = val91;
		array13[3] = val92;
		array13[4] = textInputPage;
		SimpleValueTargetProvider val142 = new SimpleValueTargetProvider(array13, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Dark"), (INameScope[])(object)new NameScope[6] { val93, val93, val93, val93, val93, val93 }, false);
		object obj14 = (object)val142;
		val141.Add(typeFromHandle13, (object)val142);
		val141.Add(typeof(IReferenceProvider), obj14);
		val141.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(25, 20)));
		object dark6 = val140.ProvideValue((IServiceProvider)val141);
		val24.Dark = dark6;
		XamlServiceProvider val143 = new XamlServiceProvider();
		val143.Add(typeof(IProvideValueTarget), (object)new ValueTargetProvider((object)val25, (object)Label.TextColorProperty));
		val143.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(25, 20)));
		BindingBase val144 = ((IMarkupExtension<BindingBase>)(object)val24).ProvideValue((IServiceProvider)val143);
		((BindableObject)val25).SetBinding(Label.TextColorProperty, val144);
		((Layout)val91).Children.Add((IView)(object)val25);
		((BindableObject)val27).SetValue(Entry.PlaceholderProperty, (object)"Enter your email...");
		((BindableObject)val27).SetValue(Entry.FontSizeProperty, (object)14.0);
		((BindableObject)val27).SetValue(Entry.KeyboardProperty, ((TypeConverter)new KeyboardTypeConverter()).ConvertFromInvariantString("Email"));
		val26.Key = "ThemedEntry";
		StaticResourceExtension val145 = new StaticResourceExtension
		{
			Key = "ThemedEntry"
		};
		XamlServiceProvider val146 = new XamlServiceProvider();
		Type? typeFromHandle14 = typeof(IProvideValueTarget);
		object[] array14 = new object[0 + 4];
		array14[0] = val27;
		array14[1] = val91;
		array14[2] = val92;
		array14[3] = textInputPage;
		SimpleValueTargetProvider val147 = new SimpleValueTargetProvider(array14, (object)VisualElement.StyleProperty, (INameScope[])(object)new NameScope[5] { val93, val93, val93, val93, val93 }, false);
		object obj15 = (object)val147;
		val146.Add(typeFromHandle14, (object)val147);
		val146.Add(typeof(IReferenceProvider), obj15);
		val146.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(28, 20)));
		object obj16 = val145.ProvideValue((IServiceProvider)val146);
		((BindableObject)val27).SetValue(VisualElement.StyleProperty, (obj16 == null || !typeof(BindingBase).IsAssignableFrom(obj16.GetType())) ? obj16 : obj16);
		((Layout)val91).Children.Add((IView)(object)val27);
		((BindableObject)val31).SetValue(Label.TextProperty, (object)"Email keyboard type");
		((BindableObject)val31).SetValue(Label.FontSizeProperty, (object)12.0);
		val28.Key = "TextSecondaryLight";
		StaticResourceExtension val148 = new StaticResourceExtension
		{
			Key = "TextSecondaryLight"
		};
		XamlServiceProvider val149 = new XamlServiceProvider();
		Type? typeFromHandle15 = typeof(IProvideValueTarget);
		object[] array15 = new object[0 + 5];
		array15[0] = val30;
		array15[1] = val31;
		array15[2] = val91;
		array15[3] = val92;
		array15[4] = textInputPage;
		SimpleValueTargetProvider val150 = new SimpleValueTargetProvider(array15, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Light"), (INameScope[])(object)new NameScope[6] { val93, val93, val93, val93, val93, val93 }, false);
		object obj17 = (object)val150;
		val149.Add(typeFromHandle15, (object)val150);
		val149.Add(typeof(IReferenceProvider), obj17);
		val149.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(30, 20)));
		object light7 = val148.ProvideValue((IServiceProvider)val149);
		val30.Light = light7;
		val29.Key = "TextSecondaryDark";
		StaticResourceExtension val151 = new StaticResourceExtension
		{
			Key = "TextSecondaryDark"
		};
		XamlServiceProvider val152 = new XamlServiceProvider();
		Type? typeFromHandle16 = typeof(IProvideValueTarget);
		object[] array16 = new object[0 + 5];
		array16[0] = val30;
		array16[1] = val31;
		array16[2] = val91;
		array16[3] = val92;
		array16[4] = textInputPage;
		SimpleValueTargetProvider val153 = new SimpleValueTargetProvider(array16, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Dark"), (INameScope[])(object)new NameScope[6] { val93, val93, val93, val93, val93, val93 }, false);
		object obj18 = (object)val153;
		val152.Add(typeFromHandle16, (object)val153);
		val152.Add(typeof(IReferenceProvider), obj18);
		val152.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(30, 20)));
		object dark7 = val151.ProvideValue((IServiceProvider)val152);
		val30.Dark = dark7;
		XamlServiceProvider val154 = new XamlServiceProvider();
		val154.Add(typeof(IProvideValueTarget), (object)new ValueTargetProvider((object)val31, (object)Label.TextColorProperty));
		val154.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(30, 20)));
		BindingBase val155 = ((IMarkupExtension<BindingBase>)(object)val30).ProvideValue((IServiceProvider)val154);
		((BindableObject)val31).SetBinding(Label.TextColorProperty, val155);
		((Layout)val91).Children.Add((IView)(object)val31);
		((BindableObject)val33).SetValue(Entry.PlaceholderProperty, (object)"Enter password...");
		((BindableObject)val33).SetValue(Entry.FontSizeProperty, (object)14.0);
		((BindableObject)val33).SetValue(Entry.IsPasswordProperty, (object)true);
		val32.Key = "ThemedEntry";
		StaticResourceExtension val156 = new StaticResourceExtension
		{
			Key = "ThemedEntry"
		};
		XamlServiceProvider val157 = new XamlServiceProvider();
		Type? typeFromHandle17 = typeof(IProvideValueTarget);
		object[] array17 = new object[0 + 4];
		array17[0] = val33;
		array17[1] = val91;
		array17[2] = val92;
		array17[3] = textInputPage;
		SimpleValueTargetProvider val158 = new SimpleValueTargetProvider(array17, (object)VisualElement.StyleProperty, (INameScope[])(object)new NameScope[5] { val93, val93, val93, val93, val93 }, false);
		object obj19 = (object)val158;
		val157.Add(typeFromHandle17, (object)val158);
		val157.Add(typeof(IReferenceProvider), obj19);
		val157.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(33, 20)));
		object obj20 = val156.ProvideValue((IServiceProvider)val157);
		((BindableObject)val33).SetValue(VisualElement.StyleProperty, (obj20 == null || !typeof(BindingBase).IsAssignableFrom(obj20.GetType())) ? obj20 : obj20);
		((Layout)val91).Children.Add((IView)(object)val33);
		((BindableObject)val37).SetValue(Label.TextProperty, (object)"Password field (text hidden)");
		((BindableObject)val37).SetValue(Label.FontSizeProperty, (object)12.0);
		val34.Key = "TextSecondaryLight";
		StaticResourceExtension val159 = new StaticResourceExtension
		{
			Key = "TextSecondaryLight"
		};
		XamlServiceProvider val160 = new XamlServiceProvider();
		Type? typeFromHandle18 = typeof(IProvideValueTarget);
		object[] array18 = new object[0 + 5];
		array18[0] = val36;
		array18[1] = val37;
		array18[2] = val91;
		array18[3] = val92;
		array18[4] = textInputPage;
		SimpleValueTargetProvider val161 = new SimpleValueTargetProvider(array18, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Light"), (INameScope[])(object)new NameScope[6] { val93, val93, val93, val93, val93, val93 }, false);
		object obj21 = (object)val161;
		val160.Add(typeFromHandle18, (object)val161);
		val160.Add(typeof(IReferenceProvider), obj21);
		val160.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(35, 20)));
		object light8 = val159.ProvideValue((IServiceProvider)val160);
		val36.Light = light8;
		val35.Key = "TextSecondaryDark";
		StaticResourceExtension val162 = new StaticResourceExtension
		{
			Key = "TextSecondaryDark"
		};
		XamlServiceProvider val163 = new XamlServiceProvider();
		Type? typeFromHandle19 = typeof(IProvideValueTarget);
		object[] array19 = new object[0 + 5];
		array19[0] = val36;
		array19[1] = val37;
		array19[2] = val91;
		array19[3] = val92;
		array19[4] = textInputPage;
		SimpleValueTargetProvider val164 = new SimpleValueTargetProvider(array19, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Dark"), (INameScope[])(object)new NameScope[6] { val93, val93, val93, val93, val93, val93 }, false);
		object obj22 = (object)val164;
		val163.Add(typeFromHandle19, (object)val164);
		val163.Add(typeof(IReferenceProvider), obj22);
		val163.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(35, 20)));
		object dark8 = val162.ProvideValue((IServiceProvider)val163);
		val36.Dark = dark8;
		XamlServiceProvider val165 = new XamlServiceProvider();
		val165.Add(typeof(IProvideValueTarget), (object)new ValueTargetProvider((object)val37, (object)Label.TextColorProperty));
		val165.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(35, 20)));
		BindingBase val166 = ((IMarkupExtension<BindingBase>)(object)val36).ProvideValue((IServiceProvider)val165);
		((BindableObject)val37).SetBinding(Label.TextColorProperty, val166);
		((Layout)val91).Children.Add((IView)(object)val37);
		((BindableObject)val41).SetValue(VisualElement.HeightRequestProperty, (object)1.0);
		val38.Key = "BorderLight";
		StaticResourceExtension val167 = new StaticResourceExtension
		{
			Key = "BorderLight"
		};
		XamlServiceProvider val168 = new XamlServiceProvider();
		Type? typeFromHandle20 = typeof(IProvideValueTarget);
		object[] array20 = new object[0 + 5];
		array20[0] = val40;
		array20[1] = val41;
		array20[2] = val91;
		array20[3] = val92;
		array20[4] = textInputPage;
		SimpleValueTargetProvider val169 = new SimpleValueTargetProvider(array20, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Light"), (INameScope[])(object)new NameScope[6] { val93, val93, val93, val93, val93, val93 }, false);
		object obj23 = (object)val169;
		val168.Add(typeFromHandle20, (object)val169);
		val168.Add(typeof(IReferenceProvider), obj23);
		val168.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(38, 40)));
		object light9 = val167.ProvideValue((IServiceProvider)val168);
		val40.Light = light9;
		val39.Key = "BorderDark";
		StaticResourceExtension val170 = new StaticResourceExtension
		{
			Key = "BorderDark"
		};
		XamlServiceProvider val171 = new XamlServiceProvider();
		Type? typeFromHandle21 = typeof(IProvideValueTarget);
		object[] array21 = new object[0 + 5];
		array21[0] = val40;
		array21[1] = val41;
		array21[2] = val91;
		array21[3] = val92;
		array21[4] = textInputPage;
		SimpleValueTargetProvider val172 = new SimpleValueTargetProvider(array21, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Dark"), (INameScope[])(object)new NameScope[6] { val93, val93, val93, val93, val93, val93 }, false);
		object obj24 = (object)val172;
		val171.Add(typeFromHandle21, (object)val172);
		val171.Add(typeof(IReferenceProvider), obj24);
		val171.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(38, 40)));
		object dark9 = val170.ProvideValue((IServiceProvider)val171);
		val40.Dark = dark9;
		XamlServiceProvider val173 = new XamlServiceProvider();
		val173.Add(typeof(IProvideValueTarget), (object)new ValueTargetProvider((object)val41, (object)BoxView.ColorProperty));
		val173.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(38, 40)));
		BindingBase val174 = ((IMarkupExtension<BindingBase>)(object)val40).ProvideValue((IServiceProvider)val173);
		((BindableObject)val41).SetBinding(BoxView.ColorProperty, val174);
		((Layout)val91).Children.Add((IView)(object)val41);
		((BindableObject)val45).SetValue(Label.TextProperty, (object)"SearchBar");
		((BindableObject)val45).SetValue(Label.FontSizeProperty, (object)18.0);
		((BindableObject)val45).SetValue(Label.FontAttributesProperty, (object)(FontAttributes)1);
		val42.Key = "TextPrimaryLight";
		StaticResourceExtension val175 = new StaticResourceExtension
		{
			Key = "TextPrimaryLight"
		};
		XamlServiceProvider val176 = new XamlServiceProvider();
		Type? typeFromHandle22 = typeof(IProvideValueTarget);
		object[] array22 = new object[0 + 5];
		array22[0] = val44;
		array22[1] = val45;
		array22[2] = val91;
		array22[3] = val92;
		array22[4] = textInputPage;
		SimpleValueTargetProvider val177 = new SimpleValueTargetProvider(array22, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Light"), (INameScope[])(object)new NameScope[6] { val93, val93, val93, val93, val93, val93 }, false);
		object obj25 = (object)val177;
		val176.Add(typeFromHandle22, (object)val177);
		val176.Add(typeof(IReferenceProvider), obj25);
		val176.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(40, 20)));
		object light10 = val175.ProvideValue((IServiceProvider)val176);
		val44.Light = light10;
		val43.Key = "TextPrimaryDark";
		StaticResourceExtension val178 = new StaticResourceExtension
		{
			Key = "TextPrimaryDark"
		};
		XamlServiceProvider val179 = new XamlServiceProvider();
		Type? typeFromHandle23 = typeof(IProvideValueTarget);
		object[] array23 = new object[0 + 5];
		array23[0] = val44;
		array23[1] = val45;
		array23[2] = val91;
		array23[3] = val92;
		array23[4] = textInputPage;
		SimpleValueTargetProvider val180 = new SimpleValueTargetProvider(array23, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Dark"), (INameScope[])(object)new NameScope[6] { val93, val93, val93, val93, val93, val93 }, false);
		object obj26 = (object)val180;
		val179.Add(typeFromHandle23, (object)val180);
		val179.Add(typeof(IReferenceProvider), obj26);
		val179.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(40, 20)));
		object dark10 = val178.ProvideValue((IServiceProvider)val179);
		val44.Dark = dark10;
		XamlServiceProvider val181 = new XamlServiceProvider();
		val181.Add(typeof(IProvideValueTarget), (object)new ValueTargetProvider((object)val45, (object)Label.TextColorProperty));
		val181.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(40, 20)));
		BindingBase val182 = ((IMarkupExtension<BindingBase>)(object)val44).ProvideValue((IServiceProvider)val181);
		((BindableObject)val45).SetBinding(Label.TextColorProperty, val182);
		((Layout)val91).Children.Add((IView)(object)val45);
		((BindableObject)val55).SetValue(SearchBar.PlaceholderProperty, (object)"Search for items...");
		val46.Key = "EntryBackgroundLight";
		StaticResourceExtension val183 = new StaticResourceExtension
		{
			Key = "EntryBackgroundLight"
		};
		XamlServiceProvider val184 = new XamlServiceProvider();
		Type? typeFromHandle24 = typeof(IProvideValueTarget);
		object[] array24 = new object[0 + 5];
		array24[0] = val48;
		array24[1] = val55;
		array24[2] = val91;
		array24[3] = val92;
		array24[4] = textInputPage;
		SimpleValueTargetProvider val185 = new SimpleValueTargetProvider(array24, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Light"), (INameScope[])(object)new NameScope[6] { val93, val93, val93, val93, val93, val93 }, false);
		object obj27 = (object)val185;
		val184.Add(typeFromHandle24, (object)val185);
		val184.Add(typeof(IReferenceProvider), obj27);
		val184.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(42, 24)));
		object light11 = val183.ProvideValue((IServiceProvider)val184);
		val48.Light = light11;
		val47.Key = "EntryBackgroundDark";
		StaticResourceExtension val186 = new StaticResourceExtension
		{
			Key = "EntryBackgroundDark"
		};
		XamlServiceProvider val187 = new XamlServiceProvider();
		Type? typeFromHandle25 = typeof(IProvideValueTarget);
		object[] array25 = new object[0 + 5];
		array25[0] = val48;
		array25[1] = val55;
		array25[2] = val91;
		array25[3] = val92;
		array25[4] = textInputPage;
		SimpleValueTargetProvider val188 = new SimpleValueTargetProvider(array25, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Dark"), (INameScope[])(object)new NameScope[6] { val93, val93, val93, val93, val93, val93 }, false);
		object obj28 = (object)val188;
		val187.Add(typeFromHandle25, (object)val188);
		val187.Add(typeof(IReferenceProvider), obj28);
		val187.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(42, 24)));
		object dark11 = val186.ProvideValue((IServiceProvider)val187);
		val48.Dark = dark11;
		XamlServiceProvider val189 = new XamlServiceProvider();
		val189.Add(typeof(IProvideValueTarget), (object)new ValueTargetProvider((object)val55, (object)VisualElement.BackgroundColorProperty));
		val189.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(42, 24)));
		BindingBase val190 = ((IMarkupExtension<BindingBase>)(object)val48).ProvideValue((IServiceProvider)val189);
		((BindableObject)val55).SetBinding(VisualElement.BackgroundColorProperty, val190);
		val49.Key = "TextPrimaryLight";
		StaticResourceExtension val191 = new StaticResourceExtension
		{
			Key = "TextPrimaryLight"
		};
		XamlServiceProvider val192 = new XamlServiceProvider();
		Type? typeFromHandle26 = typeof(IProvideValueTarget);
		object[] array26 = new object[0 + 5];
		array26[0] = val51;
		array26[1] = val55;
		array26[2] = val91;
		array26[3] = val92;
		array26[4] = textInputPage;
		SimpleValueTargetProvider val193 = new SimpleValueTargetProvider(array26, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Light"), (INameScope[])(object)new NameScope[6] { val93, val93, val93, val93, val93, val93 }, false);
		object obj29 = (object)val193;
		val192.Add(typeFromHandle26, (object)val193);
		val192.Add(typeof(IReferenceProvider), obj29);
		val192.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(43, 24)));
		object light12 = val191.ProvideValue((IServiceProvider)val192);
		val51.Light = light12;
		val50.Key = "TextPrimaryDark";
		StaticResourceExtension val194 = new StaticResourceExtension
		{
			Key = "TextPrimaryDark"
		};
		XamlServiceProvider val195 = new XamlServiceProvider();
		Type? typeFromHandle27 = typeof(IProvideValueTarget);
		object[] array27 = new object[0 + 5];
		array27[0] = val51;
		array27[1] = val55;
		array27[2] = val91;
		array27[3] = val92;
		array27[4] = textInputPage;
		SimpleValueTargetProvider val196 = new SimpleValueTargetProvider(array27, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Dark"), (INameScope[])(object)new NameScope[6] { val93, val93, val93, val93, val93, val93 }, false);
		object obj30 = (object)val196;
		val195.Add(typeFromHandle27, (object)val196);
		val195.Add(typeof(IReferenceProvider), obj30);
		val195.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(43, 24)));
		object dark12 = val194.ProvideValue((IServiceProvider)val195);
		val51.Dark = dark12;
		XamlServiceProvider val197 = new XamlServiceProvider();
		val197.Add(typeof(IProvideValueTarget), (object)new ValueTargetProvider((object)val55, (object)SearchBar.TextColorProperty));
		val197.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(43, 24)));
		BindingBase val198 = ((IMarkupExtension<BindingBase>)(object)val51).ProvideValue((IServiceProvider)val197);
		((BindableObject)val55).SetBinding(SearchBar.TextColorProperty, val198);
		val52.Key = "TextSecondaryLight";
		StaticResourceExtension val199 = new StaticResourceExtension
		{
			Key = "TextSecondaryLight"
		};
		XamlServiceProvider val200 = new XamlServiceProvider();
		Type? typeFromHandle28 = typeof(IProvideValueTarget);
		object[] array28 = new object[0 + 5];
		array28[0] = val54;
		array28[1] = val55;
		array28[2] = val91;
		array28[3] = val92;
		array28[4] = textInputPage;
		SimpleValueTargetProvider val201 = new SimpleValueTargetProvider(array28, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Light"), (INameScope[])(object)new NameScope[6] { val93, val93, val93, val93, val93, val93 }, false);
		object obj31 = (object)val201;
		val200.Add(typeFromHandle28, (object)val201);
		val200.Add(typeof(IReferenceProvider), obj31);
		val200.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(44, 24)));
		object light13 = val199.ProvideValue((IServiceProvider)val200);
		val54.Light = light13;
		val53.Key = "TextSecondaryDark";
		StaticResourceExtension val202 = new StaticResourceExtension
		{
			Key = "TextSecondaryDark"
		};
		XamlServiceProvider val203 = new XamlServiceProvider();
		Type? typeFromHandle29 = typeof(IProvideValueTarget);
		object[] array29 = new object[0 + 5];
		array29[0] = val54;
		array29[1] = val55;
		array29[2] = val91;
		array29[3] = val92;
		array29[4] = textInputPage;
		SimpleValueTargetProvider val204 = new SimpleValueTargetProvider(array29, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Dark"), (INameScope[])(object)new NameScope[6] { val93, val93, val93, val93, val93, val93 }, false);
		object obj32 = (object)val204;
		val203.Add(typeFromHandle29, (object)val204);
		val203.Add(typeof(IReferenceProvider), obj32);
		val203.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(44, 24)));
		object dark13 = val202.ProvideValue((IServiceProvider)val203);
		val54.Dark = dark13;
		XamlServiceProvider val205 = new XamlServiceProvider();
		val205.Add(typeof(IProvideValueTarget), (object)new ValueTargetProvider((object)val55, (object)SearchBar.PlaceholderColorProperty));
		val205.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(44, 24)));
		BindingBase val206 = ((IMarkupExtension<BindingBase>)(object)val54).ProvideValue((IServiceProvider)val205);
		((BindableObject)val55).SetBinding(SearchBar.PlaceholderColorProperty, val206);
		((InputView)val55).TextChanged += textInputPage.OnSearchTextChanged;
		val55.SearchButtonPressed += textInputPage.OnSearchButtonPressed;
		((Layout)val91).Children.Add((IView)(object)val55);
		((BindableObject)val59).SetValue(Label.FontSizeProperty, (object)12.0);
		val56.Key = "TextSecondaryLight";
		StaticResourceExtension val207 = new StaticResourceExtension
		{
			Key = "TextSecondaryLight"
		};
		XamlServiceProvider val208 = new XamlServiceProvider();
		Type? typeFromHandle30 = typeof(IProvideValueTarget);
		object[] array30 = new object[0 + 5];
		array30[0] = val58;
		array30[1] = val59;
		array30[2] = val91;
		array30[3] = val92;
		array30[4] = textInputPage;
		SimpleValueTargetProvider val209 = new SimpleValueTargetProvider(array30, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Light"), (INameScope[])(object)new NameScope[6] { val93, val93, val93, val93, val93, val93 }, false);
		object obj33 = (object)val209;
		val208.Add(typeFromHandle30, (object)val209);
		val208.Add(typeof(IReferenceProvider), obj33);
		val208.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(48, 20)));
		object light14 = val207.ProvideValue((IServiceProvider)val208);
		val58.Light = light14;
		val57.Key = "TextSecondaryDark";
		StaticResourceExtension val210 = new StaticResourceExtension
		{
			Key = "TextSecondaryDark"
		};
		XamlServiceProvider val211 = new XamlServiceProvider();
		Type? typeFromHandle31 = typeof(IProvideValueTarget);
		object[] array31 = new object[0 + 5];
		array31[0] = val58;
		array31[1] = val59;
		array31[2] = val91;
		array31[3] = val92;
		array31[4] = textInputPage;
		SimpleValueTargetProvider val212 = new SimpleValueTargetProvider(array31, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Dark"), (INameScope[])(object)new NameScope[6] { val93, val93, val93, val93, val93, val93 }, false);
		object obj34 = (object)val212;
		val211.Add(typeFromHandle31, (object)val212);
		val211.Add(typeof(IReferenceProvider), obj34);
		val211.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(48, 20)));
		object dark14 = val210.ProvideValue((IServiceProvider)val211);
		val58.Dark = dark14;
		XamlServiceProvider val213 = new XamlServiceProvider();
		val213.Add(typeof(IProvideValueTarget), (object)new ValueTargetProvider((object)val59, (object)Label.TextColorProperty));
		val213.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(48, 20)));
		BindingBase val214 = ((IMarkupExtension<BindingBase>)(object)val58).ProvideValue((IServiceProvider)val213);
		((BindableObject)val59).SetBinding(Label.TextColorProperty, val214);
		((Layout)val91).Children.Add((IView)(object)val59);
		((BindableObject)val63).SetValue(VisualElement.HeightRequestProperty, (object)1.0);
		val60.Key = "BorderLight";
		StaticResourceExtension val215 = new StaticResourceExtension
		{
			Key = "BorderLight"
		};
		XamlServiceProvider val216 = new XamlServiceProvider();
		Type? typeFromHandle32 = typeof(IProvideValueTarget);
		object[] array32 = new object[0 + 5];
		array32[0] = val62;
		array32[1] = val63;
		array32[2] = val91;
		array32[3] = val92;
		array32[4] = textInputPage;
		SimpleValueTargetProvider val217 = new SimpleValueTargetProvider(array32, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Light"), (INameScope[])(object)new NameScope[6] { val93, val93, val93, val93, val93, val93 }, false);
		object obj35 = (object)val217;
		val216.Add(typeFromHandle32, (object)val217);
		val216.Add(typeof(IReferenceProvider), obj35);
		val216.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(51, 40)));
		object light15 = val215.ProvideValue((IServiceProvider)val216);
		val62.Light = light15;
		val61.Key = "BorderDark";
		StaticResourceExtension val218 = new StaticResourceExtension
		{
			Key = "BorderDark"
		};
		XamlServiceProvider val219 = new XamlServiceProvider();
		Type? typeFromHandle33 = typeof(IProvideValueTarget);
		object[] array33 = new object[0 + 5];
		array33[0] = val62;
		array33[1] = val63;
		array33[2] = val91;
		array33[3] = val92;
		array33[4] = textInputPage;
		SimpleValueTargetProvider val220 = new SimpleValueTargetProvider(array33, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Dark"), (INameScope[])(object)new NameScope[6] { val93, val93, val93, val93, val93, val93 }, false);
		object obj36 = (object)val220;
		val219.Add(typeFromHandle33, (object)val220);
		val219.Add(typeof(IReferenceProvider), obj36);
		val219.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(51, 40)));
		object dark15 = val218.ProvideValue((IServiceProvider)val219);
		val62.Dark = dark15;
		XamlServiceProvider val221 = new XamlServiceProvider();
		val221.Add(typeof(IProvideValueTarget), (object)new ValueTargetProvider((object)val63, (object)BoxView.ColorProperty));
		val221.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(51, 40)));
		BindingBase val222 = ((IMarkupExtension<BindingBase>)(object)val62).ProvideValue((IServiceProvider)val221);
		((BindableObject)val63).SetBinding(BoxView.ColorProperty, val222);
		((Layout)val91).Children.Add((IView)(object)val63);
		((BindableObject)val67).SetValue(Label.TextProperty, (object)"Editor (Multi-line)");
		((BindableObject)val67).SetValue(Label.FontSizeProperty, (object)18.0);
		((BindableObject)val67).SetValue(Label.FontAttributesProperty, (object)(FontAttributes)1);
		val64.Key = "TextPrimaryLight";
		StaticResourceExtension val223 = new StaticResourceExtension
		{
			Key = "TextPrimaryLight"
		};
		XamlServiceProvider val224 = new XamlServiceProvider();
		Type? typeFromHandle34 = typeof(IProvideValueTarget);
		object[] array34 = new object[0 + 5];
		array34[0] = val66;
		array34[1] = val67;
		array34[2] = val91;
		array34[3] = val92;
		array34[4] = textInputPage;
		SimpleValueTargetProvider val225 = new SimpleValueTargetProvider(array34, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Light"), (INameScope[])(object)new NameScope[6] { val93, val93, val93, val93, val93, val93 }, false);
		object obj37 = (object)val225;
		val224.Add(typeFromHandle34, (object)val225);
		val224.Add(typeof(IReferenceProvider), obj37);
		val224.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(53, 20)));
		object light16 = val223.ProvideValue((IServiceProvider)val224);
		val66.Light = light16;
		val65.Key = "TextPrimaryDark";
		StaticResourceExtension val226 = new StaticResourceExtension
		{
			Key = "TextPrimaryDark"
		};
		XamlServiceProvider val227 = new XamlServiceProvider();
		Type? typeFromHandle35 = typeof(IProvideValueTarget);
		object[] array35 = new object[0 + 5];
		array35[0] = val66;
		array35[1] = val67;
		array35[2] = val91;
		array35[3] = val92;
		array35[4] = textInputPage;
		SimpleValueTargetProvider val228 = new SimpleValueTargetProvider(array35, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Dark"), (INameScope[])(object)new NameScope[6] { val93, val93, val93, val93, val93, val93 }, false);
		object obj38 = (object)val228;
		val227.Add(typeFromHandle35, (object)val228);
		val227.Add(typeof(IReferenceProvider), obj38);
		val227.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(53, 20)));
		object dark16 = val226.ProvideValue((IServiceProvider)val227);
		val66.Dark = dark16;
		XamlServiceProvider val229 = new XamlServiceProvider();
		val229.Add(typeof(IProvideValueTarget), (object)new ValueTargetProvider((object)val67, (object)Label.TextColorProperty));
		val229.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(53, 20)));
		BindingBase val230 = ((IMarkupExtension<BindingBase>)(object)val66).ProvideValue((IServiceProvider)val229);
		((BindableObject)val67).SetBinding(Label.TextColorProperty, val230);
		((Layout)val91).Children.Add((IView)(object)val67);
		((BindableObject)val69).SetValue(Editor.PlaceholderProperty, (object)"Enter multiple lines of text...");
		((BindableObject)val69).SetValue(VisualElement.HeightRequestProperty, (object)120.0);
		((BindableObject)val69).SetValue(Editor.FontSizeProperty, (object)14.0);
		val68.Key = "ThemedEditor";
		StaticResourceExtension val231 = new StaticResourceExtension
		{
			Key = "ThemedEditor"
		};
		XamlServiceProvider val232 = new XamlServiceProvider();
		Type? typeFromHandle36 = typeof(IProvideValueTarget);
		object[] array36 = new object[0 + 4];
		array36[0] = val69;
		array36[1] = val91;
		array36[2] = val92;
		array36[3] = textInputPage;
		SimpleValueTargetProvider val233 = new SimpleValueTargetProvider(array36, (object)VisualElement.StyleProperty, (INameScope[])(object)new NameScope[5] { val93, val93, val93, val93, val93 }, false);
		object obj39 = (object)val233;
		val232.Add(typeFromHandle36, (object)val233);
		val232.Add(typeof(IReferenceProvider), obj39);
		val232.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(56, 21)));
		object obj40 = val231.ProvideValue((IServiceProvider)val232);
		((BindableObject)val69).SetValue(VisualElement.StyleProperty, (obj40 == null || !typeof(BindingBase).IsAssignableFrom(obj40.GetType())) ? obj40 : obj40);
		((InputView)val69).TextChanged += textInputPage.OnEditorTextChanged;
		((Layout)val91).Children.Add((IView)(object)val69);
		((BindableObject)val73).SetValue(Label.FontSizeProperty, (object)12.0);
		val70.Key = "TextSecondaryLight";
		StaticResourceExtension val234 = new StaticResourceExtension
		{
			Key = "TextSecondaryLight"
		};
		XamlServiceProvider val235 = new XamlServiceProvider();
		Type? typeFromHandle37 = typeof(IProvideValueTarget);
		object[] array37 = new object[0 + 5];
		array37[0] = val72;
		array37[1] = val73;
		array37[2] = val91;
		array37[3] = val92;
		array37[4] = textInputPage;
		SimpleValueTargetProvider val236 = new SimpleValueTargetProvider(array37, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Light"), (INameScope[])(object)new NameScope[6] { val93, val93, val93, val93, val93, val93 }, false);
		object obj41 = (object)val236;
		val235.Add(typeFromHandle37, (object)val236);
		val235.Add(typeof(IReferenceProvider), obj41);
		val235.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(59, 20)));
		object light17 = val234.ProvideValue((IServiceProvider)val235);
		val72.Light = light17;
		val71.Key = "TextSecondaryDark";
		StaticResourceExtension val237 = new StaticResourceExtension
		{
			Key = "TextSecondaryDark"
		};
		XamlServiceProvider val238 = new XamlServiceProvider();
		Type? typeFromHandle38 = typeof(IProvideValueTarget);
		object[] array38 = new object[0 + 5];
		array38[0] = val72;
		array38[1] = val73;
		array38[2] = val91;
		array38[3] = val92;
		array38[4] = textInputPage;
		SimpleValueTargetProvider val239 = new SimpleValueTargetProvider(array38, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Dark"), (INameScope[])(object)new NameScope[6] { val93, val93, val93, val93, val93, val93 }, false);
		object obj42 = (object)val239;
		val238.Add(typeFromHandle38, (object)val239);
		val238.Add(typeof(IReferenceProvider), obj42);
		val238.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(59, 20)));
		object dark17 = val237.ProvideValue((IServiceProvider)val238);
		val72.Dark = dark17;
		XamlServiceProvider val240 = new XamlServiceProvider();
		val240.Add(typeof(IProvideValueTarget), (object)new ValueTargetProvider((object)val73, (object)Label.TextColorProperty));
		val240.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(59, 20)));
		BindingBase val241 = ((IMarkupExtension<BindingBase>)(object)val72).ProvideValue((IServiceProvider)val240);
		((BindableObject)val73).SetBinding(Label.TextColorProperty, val241);
		((Layout)val91).Children.Add((IView)(object)val73);
		((BindableObject)val77).SetValue(VisualElement.HeightRequestProperty, (object)1.0);
		val74.Key = "BorderLight";
		StaticResourceExtension val242 = new StaticResourceExtension
		{
			Key = "BorderLight"
		};
		XamlServiceProvider val243 = new XamlServiceProvider();
		Type? typeFromHandle39 = typeof(IProvideValueTarget);
		object[] array39 = new object[0 + 5];
		array39[0] = val76;
		array39[1] = val77;
		array39[2] = val91;
		array39[3] = val92;
		array39[4] = textInputPage;
		SimpleValueTargetProvider val244 = new SimpleValueTargetProvider(array39, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Light"), (INameScope[])(object)new NameScope[6] { val93, val93, val93, val93, val93, val93 }, false);
		object obj43 = (object)val244;
		val243.Add(typeFromHandle39, (object)val244);
		val243.Add(typeof(IReferenceProvider), obj43);
		val243.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(62, 40)));
		object light18 = val242.ProvideValue((IServiceProvider)val243);
		val76.Light = light18;
		val75.Key = "BorderDark";
		StaticResourceExtension val245 = new StaticResourceExtension
		{
			Key = "BorderDark"
		};
		XamlServiceProvider val246 = new XamlServiceProvider();
		Type? typeFromHandle40 = typeof(IProvideValueTarget);
		object[] array40 = new object[0 + 5];
		array40[0] = val76;
		array40[1] = val77;
		array40[2] = val91;
		array40[3] = val92;
		array40[4] = textInputPage;
		SimpleValueTargetProvider val247 = new SimpleValueTargetProvider(array40, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Dark"), (INameScope[])(object)new NameScope[6] { val93, val93, val93, val93, val93, val93 }, false);
		object obj44 = (object)val247;
		val246.Add(typeFromHandle40, (object)val247);
		val246.Add(typeof(IReferenceProvider), obj44);
		val246.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(62, 40)));
		object dark18 = val245.ProvideValue((IServiceProvider)val246);
		val76.Dark = dark18;
		XamlServiceProvider val248 = new XamlServiceProvider();
		val248.Add(typeof(IProvideValueTarget), (object)new ValueTargetProvider((object)val77, (object)BoxView.ColorProperty));
		val248.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(62, 40)));
		BindingBase val249 = ((IMarkupExtension<BindingBase>)(object)val76).ProvideValue((IServiceProvider)val248);
		((BindableObject)val77).SetBinding(BoxView.ColorProperty, val249);
		((Layout)val91).Children.Add((IView)(object)val77);
		((BindableObject)val90).SetValue(Frame.CornerRadiusProperty, (object)8f);
		((BindableObject)val90).SetValue(Layout.PaddingProperty, (object)new Thickness(15.0));
		val78.Light = "#E3F2FD";
		val78.Dark = "#1565C0";
		XamlServiceProvider val250 = new XamlServiceProvider();
		val250.Add(typeof(IProvideValueTarget), (object)new ValueTargetProvider((object)val90, (object)VisualElement.BackgroundColorProperty));
		val250.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(64, 20)));
		BindingBase val251 = ((IMarkupExtension<BindingBase>)(object)val78).ProvideValue((IServiceProvider)val250);
		((BindableObject)val90).SetBinding(VisualElement.BackgroundColorProperty, val251);
		((BindableObject)val89).SetValue(StackBase.SpacingProperty, (object)5.0);
		((BindableObject)val80).SetValue(Label.TextProperty, (object)"Keyboard Shortcuts");
		((BindableObject)val80).SetValue(Label.FontAttributesProperty, (object)(FontAttributes)1);
		val79.Light = "#1565C0";
		val79.Dark = "White";
		XamlServiceProvider val252 = new XamlServiceProvider();
		val252.Add(typeof(IProvideValueTarget), (object)new ValueTargetProvider((object)val80, (object)Label.TextColorProperty));
		val252.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(67, 28)));
		BindingBase val253 = ((IMarkupExtension<BindingBase>)(object)val79).ProvideValue((IServiceProvider)val252);
		((BindableObject)val80).SetBinding(Label.TextColorProperty, val253);
		((Layout)val89).Children.Add((IView)(object)val80);
		((BindableObject)val82).SetValue(Label.TextProperty, (object)"Ctrl+A: Select all");
		val81.Light = "#424242";
		val81.Dark = "#E0E0E0";
		XamlServiceProvider val254 = new XamlServiceProvider();
		val254.Add(typeof(IProvideValueTarget), (object)new ValueTargetProvider((object)val82, (object)Label.TextColorProperty));
		val254.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(68, 54)));
		BindingBase val255 = ((IMarkupExtension<BindingBase>)(object)val81).ProvideValue((IServiceProvider)val254);
		((BindableObject)val82).SetBinding(Label.TextColorProperty, val255);
		((Layout)val89).Children.Add((IView)(object)val82);
		((BindableObject)val84).SetValue(Label.TextProperty, (object)"Ctrl+C: Copy");
		val83.Light = "#424242";
		val83.Dark = "#E0E0E0";
		XamlServiceProvider val256 = new XamlServiceProvider();
		val256.Add(typeof(IProvideValueTarget), (object)new ValueTargetProvider((object)val84, (object)Label.TextColorProperty));
		val256.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(69, 48)));
		BindingBase val257 = ((IMarkupExtension<BindingBase>)(object)val83).ProvideValue((IServiceProvider)val256);
		((BindableObject)val84).SetBinding(Label.TextColorProperty, val257);
		((Layout)val89).Children.Add((IView)(object)val84);
		((BindableObject)val86).SetValue(Label.TextProperty, (object)"Ctrl+V: Paste");
		val85.Light = "#424242";
		val85.Dark = "#E0E0E0";
		XamlServiceProvider val258 = new XamlServiceProvider();
		val258.Add(typeof(IProvideValueTarget), (object)new ValueTargetProvider((object)val86, (object)Label.TextColorProperty));
		val258.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(70, 49)));
		BindingBase val259 = ((IMarkupExtension<BindingBase>)(object)val85).ProvideValue((IServiceProvider)val258);
		((BindableObject)val86).SetBinding(Label.TextColorProperty, val259);
		((Layout)val89).Children.Add((IView)(object)val86);
		((BindableObject)val88).SetValue(Label.TextProperty, (object)"Ctrl+X: Cut");
		val87.Light = "#424242";
		val87.Dark = "#E0E0E0";
		XamlServiceProvider val260 = new XamlServiceProvider();
		val260.Add(typeof(IProvideValueTarget), (object)new ValueTargetProvider((object)val88, (object)Label.TextColorProperty));
		val260.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(71, 47)));
		BindingBase val261 = ((IMarkupExtension<BindingBase>)(object)val87).ProvideValue((IServiceProvider)val260);
		((BindableObject)val88).SetBinding(Label.TextColorProperty, val261);
		((Layout)val89).Children.Add((IView)(object)val88);
		((BindableObject)val90).SetValue(ContentView.ContentProperty, (object)val89);
		((Layout)val91).Children.Add((IView)(object)val90);
		val92.Content = (View)(object)val91;
		((BindableObject)textInputPage).SetValue(ContentPage.ContentProperty, (object)val92);
	}
}
