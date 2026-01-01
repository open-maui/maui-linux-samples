using System;
using System.CodeDom.Compiler;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Xml;
using Microsoft.Maui;
using Microsoft.Maui.ApplicationModel;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Compatibility;
using Microsoft.Maui.Controls.Internals;
using Microsoft.Maui.Controls.Xaml;
using Microsoft.Maui.Controls.Xaml.Internals;
using Microsoft.Maui.Graphics;
using Microsoft.Maui.Platform.Linux.Hosting;

namespace ShellDemo;

[XamlFilePath("Pages/HomePage.xaml")]
public class HomePage : ContentPage
{
	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private Switch ThemeSwitch;

	public HomePage()
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Invalid comparison between Unknown and I4
		InitializeComponent();
		Switch themeSwitch = ThemeSwitch;
		Application current = Application.Current;
		themeSwitch.IsToggled = current != null && (int)current.UserAppTheme == 2;
	}

	private void OnThemeToggled(object? sender, ToggledEventArgs e)
	{
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		if (Application.Current != null)
		{
			Application.Current.UserAppTheme = (AppTheme)((!e.Value) ? 1 : 2);
			Console.WriteLine($"[HomePage] Theme changed to: {Application.Current.UserAppTheme}");
		}
	}

	private void OnButtonsDemoClicked(object? sender, EventArgs e)
	{
		LinuxViewRenderer.NavigateToRoute("Buttons");
	}

	private void OnListsDemoClicked(object? sender, EventArgs e)
	{
		LinuxViewRenderer.NavigateToRoute("Lists");
	}

	private void OnPushDetailClicked(object? sender, EventArgs e)
	{
		Console.WriteLine("[HomePage] Push button clicked, navigating to detail");
		bool value = LinuxViewRenderer.PushPage((Page)(object)new DetailPage());
		Console.WriteLine($"[HomePage] PushPage result: {value}");
	}

	private void OnButtonsCardTapped(object? sender, EventArgs e)
	{
		Console.WriteLine("[HomePage] Buttons card tapped");
		LinuxViewRenderer.NavigateToRoute("Buttons");
	}

	private void OnTextInputCardTapped(object? sender, EventArgs e)
	{
		Console.WriteLine("[HomePage] Text Input card tapped");
		LinuxViewRenderer.NavigateToRoute("TextInput");
	}

	private void OnSelectionCardTapped(object? sender, EventArgs e)
	{
		Console.WriteLine("[HomePage] Selection card tapped");
		LinuxViewRenderer.NavigateToRoute("Selection");
	}

	private void OnPickersCardTapped(object? sender, EventArgs e)
	{
		Console.WriteLine("[HomePage] Pickers card tapped");
		LinuxViewRenderer.NavigateToRoute("Pickers");
	}

	private void OnListsCardTapped(object? sender, EventArgs e)
	{
		Console.WriteLine("[HomePage] Lists card tapped");
		LinuxViewRenderer.NavigateToRoute("Lists");
	}

	private void OnProgressCardTapped(object? sender, EventArgs e)
	{
		Console.WriteLine("[HomePage] Progress card tapped");
		LinuxViewRenderer.NavigateToRoute("Progress");
	}

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	[MemberNotNull("ThemeSwitch")]
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
		//IL_0281: Unknown result type (might be due to invalid IL or missing references)
		//IL_0288: Expected O, but got Unknown
		//IL_0288: Unknown result type (might be due to invalid IL or missing references)
		//IL_028f: Expected O, but got Unknown
		//IL_028f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0296: Expected O, but got Unknown
		//IL_0296: Unknown result type (might be due to invalid IL or missing references)
		//IL_029d: Expected O, but got Unknown
		//IL_029d: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a4: Expected O, but got Unknown
		//IL_02a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ab: Expected O, but got Unknown
		//IL_02ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b2: Expected O, but got Unknown
		//IL_02b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b9: Expected O, but got Unknown
		//IL_02b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c0: Expected O, but got Unknown
		//IL_02c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c7: Expected O, but got Unknown
		//IL_02c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ce: Expected O, but got Unknown
		//IL_02ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d5: Expected O, but got Unknown
		//IL_02d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02dc: Expected O, but got Unknown
		//IL_02dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e3: Expected O, but got Unknown
		//IL_02e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ea: Expected O, but got Unknown
		//IL_02ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f1: Expected O, but got Unknown
		//IL_02f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f8: Expected O, but got Unknown
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
		//IL_034c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0353: Expected O, but got Unknown
		//IL_0353: Unknown result type (might be due to invalid IL or missing references)
		//IL_035a: Expected O, but got Unknown
		//IL_035a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0361: Expected O, but got Unknown
		//IL_0361: Unknown result type (might be due to invalid IL or missing references)
		//IL_0368: Expected O, but got Unknown
		//IL_0368: Unknown result type (might be due to invalid IL or missing references)
		//IL_036f: Expected O, but got Unknown
		//IL_036f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0376: Expected O, but got Unknown
		//IL_0376: Unknown result type (might be due to invalid IL or missing references)
		//IL_037d: Expected O, but got Unknown
		//IL_037d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0384: Expected O, but got Unknown
		//IL_0384: Unknown result type (might be due to invalid IL or missing references)
		//IL_038b: Expected O, but got Unknown
		//IL_0398: Unknown result type (might be due to invalid IL or missing references)
		//IL_0639: Unknown result type (might be due to invalid IL or missing references)
		//IL_063e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0649: Unknown result type (might be due to invalid IL or missing references)
		//IL_064e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0694: Unknown result type (might be due to invalid IL or missing references)
		//IL_0699: Unknown result type (might be due to invalid IL or missing references)
		//IL_069c: Expected O, but got Unknown
		//IL_06a1: Expected O, but got Unknown
		//IL_06a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_06cb: Expected O, but got Unknown
		//IL_06c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d0: Expected O, but got Unknown
		//IL_06d5: Expected O, but got Unknown
		//IL_06ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_06fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0745: Unknown result type (might be due to invalid IL or missing references)
		//IL_074a: Unknown result type (might be due to invalid IL or missing references)
		//IL_074d: Expected O, but got Unknown
		//IL_0752: Expected O, but got Unknown
		//IL_0752: Unknown result type (might be due to invalid IL or missing references)
		//IL_0764: Unknown result type (might be due to invalid IL or missing references)
		//IL_0772: Unknown result type (might be due to invalid IL or missing references)
		//IL_077c: Expected O, but got Unknown
		//IL_0777: Unknown result type (might be due to invalid IL or missing references)
		//IL_0781: Expected O, but got Unknown
		//IL_0786: Expected O, but got Unknown
		//IL_0791: Unknown result type (might be due to invalid IL or missing references)
		//IL_0796: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_07b2: Expected O, but got Unknown
		//IL_07b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_07c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ca: Expected O, but got Unknown
		//IL_07c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_07cf: Expected O, but got Unknown
		//IL_07d4: Expected O, but got Unknown
		//IL_07f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0861: Unknown result type (might be due to invalid IL or missing references)
		//IL_087b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0880: Unknown result type (might be due to invalid IL or missing references)
		//IL_088b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0890: Unknown result type (might be due to invalid IL or missing references)
		//IL_08dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_08e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_08e4: Expected O, but got Unknown
		//IL_08e9: Expected O, but got Unknown
		//IL_08e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_08fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_090a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0914: Expected O, but got Unknown
		//IL_090f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0919: Expected O, but got Unknown
		//IL_091e: Expected O, but got Unknown
		//IL_0990: Unknown result type (might be due to invalid IL or missing references)
		//IL_09ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_09b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_09bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_09c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a25: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a2a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a2d: Expected O, but got Unknown
		//IL_0a32: Expected O, but got Unknown
		//IL_0a32: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a44: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a53: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a5d: Expected O, but got Unknown
		//IL_0a58: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a62: Expected O, but got Unknown
		//IL_0a67: Expected O, but got Unknown
		//IL_0a7e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a83: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a8e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a93: Unknown result type (might be due to invalid IL or missing references)
		//IL_0af8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0afd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b00: Expected O, but got Unknown
		//IL_0b05: Expected O, but got Unknown
		//IL_0b05: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b17: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b26: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b30: Expected O, but got Unknown
		//IL_0b2b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b35: Expected O, but got Unknown
		//IL_0b3a: Expected O, but got Unknown
		//IL_0b47: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b4c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b5e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b68: Expected O, but got Unknown
		//IL_0b68: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b77: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b81: Expected O, but got Unknown
		//IL_0b7c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b86: Expected O, but got Unknown
		//IL_0b8b: Expected O, but got Unknown
		//IL_0bdc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bf7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bfc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c07: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c0c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c71: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c76: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c79: Expected O, but got Unknown
		//IL_0c7e: Expected O, but got Unknown
		//IL_0c7e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c90: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c9f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ca9: Expected O, but got Unknown
		//IL_0ca4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cae: Expected O, but got Unknown
		//IL_0cb3: Expected O, but got Unknown
		//IL_0cca: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ccf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cda: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cdf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d44: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d49: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d4c: Expected O, but got Unknown
		//IL_0d51: Expected O, but got Unknown
		//IL_0d51: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d63: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d72: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d7c: Expected O, but got Unknown
		//IL_0d77: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d81: Expected O, but got Unknown
		//IL_0d86: Expected O, but got Unknown
		//IL_0d93: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d98: Unknown result type (might be due to invalid IL or missing references)
		//IL_0daa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0db4: Expected O, but got Unknown
		//IL_0db4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dc3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dcd: Expected O, but got Unknown
		//IL_0dc8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dd2: Expected O, but got Unknown
		//IL_0dd7: Expected O, but got Unknown
		//IL_0e50: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e55: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e60: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e65: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eca: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ecf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ed2: Expected O, but got Unknown
		//IL_0ed7: Expected O, but got Unknown
		//IL_0ed7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ee9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ef8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f02: Expected O, but got Unknown
		//IL_0efd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f07: Expected O, but got Unknown
		//IL_0f0c: Expected O, but got Unknown
		//IL_0f23: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f28: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f33: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f38: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f9d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fa2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fa5: Expected O, but got Unknown
		//IL_0faa: Expected O, but got Unknown
		//IL_0faa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fbc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fcb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fd5: Expected O, but got Unknown
		//IL_0fd0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fda: Expected O, but got Unknown
		//IL_0fdf: Expected O, but got Unknown
		//IL_0fec: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ff1: Unknown result type (might be due to invalid IL or missing references)
		//IL_1003: Unknown result type (might be due to invalid IL or missing references)
		//IL_100d: Expected O, but got Unknown
		//IL_100d: Unknown result type (might be due to invalid IL or missing references)
		//IL_101c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1026: Expected O, but got Unknown
		//IL_1021: Unknown result type (might be due to invalid IL or missing references)
		//IL_102b: Expected O, but got Unknown
		//IL_1030: Expected O, but got Unknown
		//IL_1074: Unknown result type (might be due to invalid IL or missing references)
		//IL_10ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_10d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_10dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_10ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_10f8: Expected O, but got Unknown
		//IL_10f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_1107: Unknown result type (might be due to invalid IL or missing references)
		//IL_1111: Expected O, but got Unknown
		//IL_110c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1116: Expected O, but got Unknown
		//IL_111b: Expected O, but got Unknown
		//IL_114c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1175: Unknown result type (might be due to invalid IL or missing references)
		//IL_117a: Unknown result type (might be due to invalid IL or missing references)
		//IL_118c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1196: Expected O, but got Unknown
		//IL_1196: Unknown result type (might be due to invalid IL or missing references)
		//IL_11a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_11af: Expected O, but got Unknown
		//IL_11aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_11b4: Expected O, but got Unknown
		//IL_11b9: Expected O, but got Unknown
		//IL_1204: Unknown result type (might be due to invalid IL or missing references)
		//IL_1265: Unknown result type (might be due to invalid IL or missing references)
		//IL_128e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1293: Unknown result type (might be due to invalid IL or missing references)
		//IL_12a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_12af: Expected O, but got Unknown
		//IL_12af: Unknown result type (might be due to invalid IL or missing references)
		//IL_12be: Unknown result type (might be due to invalid IL or missing references)
		//IL_12c8: Expected O, but got Unknown
		//IL_12c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_12cd: Expected O, but got Unknown
		//IL_12d2: Expected O, but got Unknown
		//IL_12fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_1301: Unknown result type (might be due to invalid IL or missing references)
		//IL_130c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1311: Unknown result type (might be due to invalid IL or missing references)
		//IL_1371: Unknown result type (might be due to invalid IL or missing references)
		//IL_1376: Unknown result type (might be due to invalid IL or missing references)
		//IL_1379: Expected O, but got Unknown
		//IL_137e: Expected O, but got Unknown
		//IL_137e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1390: Unknown result type (might be due to invalid IL or missing references)
		//IL_139f: Unknown result type (might be due to invalid IL or missing references)
		//IL_13a9: Expected O, but got Unknown
		//IL_13a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_13ae: Expected O, but got Unknown
		//IL_13b3: Expected O, but got Unknown
		//IL_13fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_1459: Unknown result type (might be due to invalid IL or missing references)
		//IL_145e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1464: Expected O, but got Unknown
		//IL_1466: Unknown result type (might be due to invalid IL or missing references)
		//IL_146b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1471: Expected O, but got Unknown
		//IL_1471: Unknown result type (might be due to invalid IL or missing references)
		//IL_147b: Expected O, but got Unknown
		//IL_148a: Unknown result type (might be due to invalid IL or missing references)
		//IL_148f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1495: Expected O, but got Unknown
		//IL_1497: Unknown result type (might be due to invalid IL or missing references)
		//IL_149c: Unknown result type (might be due to invalid IL or missing references)
		//IL_14a2: Expected O, but got Unknown
		//IL_14a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_14a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_14af: Expected O, but got Unknown
		//IL_14af: Unknown result type (might be due to invalid IL or missing references)
		//IL_14b9: Expected O, but got Unknown
		//IL_1506: Unknown result type (might be due to invalid IL or missing references)
		//IL_1545: Unknown result type (might be due to invalid IL or missing references)
		//IL_154a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1555: Unknown result type (might be due to invalid IL or missing references)
		//IL_155a: Unknown result type (might be due to invalid IL or missing references)
		//IL_15b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_15b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_15b8: Expected O, but got Unknown
		//IL_15bd: Expected O, but got Unknown
		//IL_15bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_15cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_15de: Unknown result type (might be due to invalid IL or missing references)
		//IL_15e8: Expected O, but got Unknown
		//IL_15e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_15ed: Expected O, but got Unknown
		//IL_15f2: Expected O, but got Unknown
		//IL_164a: Unknown result type (might be due to invalid IL or missing references)
		//IL_16c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_16c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_16d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_16e2: Expected O, but got Unknown
		//IL_16e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_16f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_16fb: Expected O, but got Unknown
		//IL_16f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_1700: Expected O, but got Unknown
		//IL_1705: Expected O, but got Unknown
		//IL_1750: Unknown result type (might be due to invalid IL or missing references)
		//IL_178e: Unknown result type (might be due to invalid IL or missing references)
		//IL_17e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_17eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_17f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_17fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_1870: Unknown result type (might be due to invalid IL or missing references)
		//IL_1875: Unknown result type (might be due to invalid IL or missing references)
		//IL_1878: Expected O, but got Unknown
		//IL_187d: Expected O, but got Unknown
		//IL_187d: Unknown result type (might be due to invalid IL or missing references)
		//IL_188f: Unknown result type (might be due to invalid IL or missing references)
		//IL_189e: Unknown result type (might be due to invalid IL or missing references)
		//IL_18a8: Expected O, but got Unknown
		//IL_18a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_18ad: Expected O, but got Unknown
		//IL_18b2: Expected O, but got Unknown
		//IL_1929: Unknown result type (might be due to invalid IL or missing references)
		//IL_192e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1939: Unknown result type (might be due to invalid IL or missing references)
		//IL_193e: Unknown result type (might be due to invalid IL or missing references)
		//IL_19ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_19d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_19d6: Expected O, but got Unknown
		//IL_19db: Expected O, but got Unknown
		//IL_19db: Unknown result type (might be due to invalid IL or missing references)
		//IL_19ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_19fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a06: Expected O, but got Unknown
		//IL_1a01: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a0b: Expected O, but got Unknown
		//IL_1a10: Expected O, but got Unknown
		//IL_1a27: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a2c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a37: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a3c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1acc: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ad1: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ad4: Expected O, but got Unknown
		//IL_1ad9: Expected O, but got Unknown
		//IL_1ad9: Unknown result type (might be due to invalid IL or missing references)
		//IL_1aeb: Unknown result type (might be due to invalid IL or missing references)
		//IL_1afa: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b04: Expected O, but got Unknown
		//IL_1aff: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b09: Expected O, but got Unknown
		//IL_1b0e: Expected O, but got Unknown
		//IL_1b1b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b20: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b32: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b3c: Expected O, but got Unknown
		//IL_1b3c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b4b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b55: Expected O, but got Unknown
		//IL_1b50: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b5a: Expected O, but got Unknown
		//IL_1b5f: Expected O, but got Unknown
		//IL_1bd7: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bdc: Unknown result type (might be due to invalid IL or missing references)
		//IL_1be7: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bec: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c42: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c47: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c4a: Expected O, but got Unknown
		//IL_1c4f: Expected O, but got Unknown
		//IL_1c4f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c61: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c70: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c7a: Expected O, but got Unknown
		//IL_1c75: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c7f: Expected O, but got Unknown
		//IL_1c84: Expected O, but got Unknown
		//IL_1cdc: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d53: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d58: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d6a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d74: Expected O, but got Unknown
		//IL_1d74: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d83: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d8d: Expected O, but got Unknown
		//IL_1d88: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d92: Expected O, but got Unknown
		//IL_1d97: Expected O, but got Unknown
		//IL_1de2: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e20: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e78: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e7d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e88: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e8d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f02: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f07: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f0a: Expected O, but got Unknown
		//IL_1f0f: Expected O, but got Unknown
		//IL_1f0f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f21: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f30: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f3a: Expected O, but got Unknown
		//IL_1f35: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f3f: Expected O, but got Unknown
		//IL_1f44: Expected O, but got Unknown
		//IL_1fbb: Unknown result type (might be due to invalid IL or missing references)
		//IL_1fc0: Unknown result type (might be due to invalid IL or missing references)
		//IL_1fcb: Unknown result type (might be due to invalid IL or missing references)
		//IL_1fd0: Unknown result type (might be due to invalid IL or missing references)
		//IL_2060: Unknown result type (might be due to invalid IL or missing references)
		//IL_2065: Unknown result type (might be due to invalid IL or missing references)
		//IL_2068: Expected O, but got Unknown
		//IL_206d: Expected O, but got Unknown
		//IL_206d: Unknown result type (might be due to invalid IL or missing references)
		//IL_207f: Unknown result type (might be due to invalid IL or missing references)
		//IL_208e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2098: Expected O, but got Unknown
		//IL_2093: Unknown result type (might be due to invalid IL or missing references)
		//IL_209d: Expected O, but got Unknown
		//IL_20a2: Expected O, but got Unknown
		//IL_20b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_20be: Unknown result type (might be due to invalid IL or missing references)
		//IL_20c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_20ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_215e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2163: Unknown result type (might be due to invalid IL or missing references)
		//IL_2166: Expected O, but got Unknown
		//IL_216b: Expected O, but got Unknown
		//IL_216b: Unknown result type (might be due to invalid IL or missing references)
		//IL_217d: Unknown result type (might be due to invalid IL or missing references)
		//IL_218c: Unknown result type (might be due to invalid IL or missing references)
		//IL_2196: Expected O, but got Unknown
		//IL_2191: Unknown result type (might be due to invalid IL or missing references)
		//IL_219b: Expected O, but got Unknown
		//IL_21a0: Expected O, but got Unknown
		//IL_21ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_21b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_21c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_21ce: Expected O, but got Unknown
		//IL_21ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_21dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_21e7: Expected O, but got Unknown
		//IL_21e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_21ec: Expected O, but got Unknown
		//IL_21f1: Expected O, but got Unknown
		//IL_2269: Unknown result type (might be due to invalid IL or missing references)
		//IL_226e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2279: Unknown result type (might be due to invalid IL or missing references)
		//IL_227e: Unknown result type (might be due to invalid IL or missing references)
		//IL_22d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_22d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_22dc: Expected O, but got Unknown
		//IL_22e1: Expected O, but got Unknown
		//IL_22e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_22f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_2302: Unknown result type (might be due to invalid IL or missing references)
		//IL_230c: Expected O, but got Unknown
		//IL_2307: Unknown result type (might be due to invalid IL or missing references)
		//IL_2311: Expected O, but got Unknown
		//IL_2316: Expected O, but got Unknown
		//IL_236e: Unknown result type (might be due to invalid IL or missing references)
		//IL_23e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_23ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_23fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_2406: Expected O, but got Unknown
		//IL_2406: Unknown result type (might be due to invalid IL or missing references)
		//IL_2415: Unknown result type (might be due to invalid IL or missing references)
		//IL_241f: Expected O, but got Unknown
		//IL_241a: Unknown result type (might be due to invalid IL or missing references)
		//IL_2424: Expected O, but got Unknown
		//IL_2429: Expected O, but got Unknown
		//IL_2474: Unknown result type (might be due to invalid IL or missing references)
		//IL_24b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_250a: Unknown result type (might be due to invalid IL or missing references)
		//IL_250f: Unknown result type (might be due to invalid IL or missing references)
		//IL_251a: Unknown result type (might be due to invalid IL or missing references)
		//IL_251f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2594: Unknown result type (might be due to invalid IL or missing references)
		//IL_2599: Unknown result type (might be due to invalid IL or missing references)
		//IL_259c: Expected O, but got Unknown
		//IL_25a1: Expected O, but got Unknown
		//IL_25a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_25b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_25c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_25cc: Expected O, but got Unknown
		//IL_25c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_25d1: Expected O, but got Unknown
		//IL_25d6: Expected O, but got Unknown
		//IL_264d: Unknown result type (might be due to invalid IL or missing references)
		//IL_2652: Unknown result type (might be due to invalid IL or missing references)
		//IL_265d: Unknown result type (might be due to invalid IL or missing references)
		//IL_2662: Unknown result type (might be due to invalid IL or missing references)
		//IL_26f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_26f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_26fa: Expected O, but got Unknown
		//IL_26ff: Expected O, but got Unknown
		//IL_26ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_2711: Unknown result type (might be due to invalid IL or missing references)
		//IL_2720: Unknown result type (might be due to invalid IL or missing references)
		//IL_272a: Expected O, but got Unknown
		//IL_2725: Unknown result type (might be due to invalid IL or missing references)
		//IL_272f: Expected O, but got Unknown
		//IL_2734: Expected O, but got Unknown
		//IL_274b: Unknown result type (might be due to invalid IL or missing references)
		//IL_2750: Unknown result type (might be due to invalid IL or missing references)
		//IL_275b: Unknown result type (might be due to invalid IL or missing references)
		//IL_2760: Unknown result type (might be due to invalid IL or missing references)
		//IL_27f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_27f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_27f8: Expected O, but got Unknown
		//IL_27fd: Expected O, but got Unknown
		//IL_27fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_280f: Unknown result type (might be due to invalid IL or missing references)
		//IL_281e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2828: Expected O, but got Unknown
		//IL_2823: Unknown result type (might be due to invalid IL or missing references)
		//IL_282d: Expected O, but got Unknown
		//IL_2832: Expected O, but got Unknown
		//IL_283f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2844: Unknown result type (might be due to invalid IL or missing references)
		//IL_2856: Unknown result type (might be due to invalid IL or missing references)
		//IL_2860: Expected O, but got Unknown
		//IL_2860: Unknown result type (might be due to invalid IL or missing references)
		//IL_286f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2879: Expected O, but got Unknown
		//IL_2874: Unknown result type (might be due to invalid IL or missing references)
		//IL_287e: Expected O, but got Unknown
		//IL_2883: Expected O, but got Unknown
		//IL_28fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_2900: Unknown result type (might be due to invalid IL or missing references)
		//IL_290b: Unknown result type (might be due to invalid IL or missing references)
		//IL_2910: Unknown result type (might be due to invalid IL or missing references)
		//IL_2966: Unknown result type (might be due to invalid IL or missing references)
		//IL_296b: Unknown result type (might be due to invalid IL or missing references)
		//IL_296e: Expected O, but got Unknown
		//IL_2973: Expected O, but got Unknown
		//IL_2973: Unknown result type (might be due to invalid IL or missing references)
		//IL_2985: Unknown result type (might be due to invalid IL or missing references)
		//IL_2994: Unknown result type (might be due to invalid IL or missing references)
		//IL_299e: Expected O, but got Unknown
		//IL_2999: Unknown result type (might be due to invalid IL or missing references)
		//IL_29a3: Expected O, but got Unknown
		//IL_29a8: Expected O, but got Unknown
		//IL_2a00: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a77: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a7c: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a8e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a98: Expected O, but got Unknown
		//IL_2a98: Unknown result type (might be due to invalid IL or missing references)
		//IL_2aa7: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ab1: Expected O, but got Unknown
		//IL_2aac: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ab6: Expected O, but got Unknown
		//IL_2abb: Expected O, but got Unknown
		//IL_2b06: Unknown result type (might be due to invalid IL or missing references)
		//IL_2b44: Unknown result type (might be due to invalid IL or missing references)
		//IL_2b9c: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ba1: Unknown result type (might be due to invalid IL or missing references)
		//IL_2bac: Unknown result type (might be due to invalid IL or missing references)
		//IL_2bb1: Unknown result type (might be due to invalid IL or missing references)
		//IL_2c26: Unknown result type (might be due to invalid IL or missing references)
		//IL_2c2b: Unknown result type (might be due to invalid IL or missing references)
		//IL_2c2e: Expected O, but got Unknown
		//IL_2c33: Expected O, but got Unknown
		//IL_2c33: Unknown result type (might be due to invalid IL or missing references)
		//IL_2c45: Unknown result type (might be due to invalid IL or missing references)
		//IL_2c57: Unknown result type (might be due to invalid IL or missing references)
		//IL_2c61: Expected O, but got Unknown
		//IL_2c5c: Unknown result type (might be due to invalid IL or missing references)
		//IL_2c66: Expected O, but got Unknown
		//IL_2c6b: Expected O, but got Unknown
		//IL_2ce2: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ce7: Unknown result type (might be due to invalid IL or missing references)
		//IL_2cf2: Unknown result type (might be due to invalid IL or missing references)
		//IL_2cf7: Unknown result type (might be due to invalid IL or missing references)
		//IL_2d87: Unknown result type (might be due to invalid IL or missing references)
		//IL_2d8c: Unknown result type (might be due to invalid IL or missing references)
		//IL_2d8f: Expected O, but got Unknown
		//IL_2d94: Expected O, but got Unknown
		//IL_2d94: Unknown result type (might be due to invalid IL or missing references)
		//IL_2da6: Unknown result type (might be due to invalid IL or missing references)
		//IL_2db8: Unknown result type (might be due to invalid IL or missing references)
		//IL_2dc2: Expected O, but got Unknown
		//IL_2dbd: Unknown result type (might be due to invalid IL or missing references)
		//IL_2dc7: Expected O, but got Unknown
		//IL_2dcc: Expected O, but got Unknown
		//IL_2de3: Unknown result type (might be due to invalid IL or missing references)
		//IL_2de8: Unknown result type (might be due to invalid IL or missing references)
		//IL_2df3: Unknown result type (might be due to invalid IL or missing references)
		//IL_2df8: Unknown result type (might be due to invalid IL or missing references)
		//IL_2e88: Unknown result type (might be due to invalid IL or missing references)
		//IL_2e8d: Unknown result type (might be due to invalid IL or missing references)
		//IL_2e90: Expected O, but got Unknown
		//IL_2e95: Expected O, but got Unknown
		//IL_2e95: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ea7: Unknown result type (might be due to invalid IL or missing references)
		//IL_2eb9: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ec3: Expected O, but got Unknown
		//IL_2ebe: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ec8: Expected O, but got Unknown
		//IL_2ecd: Expected O, but got Unknown
		//IL_2eda: Unknown result type (might be due to invalid IL or missing references)
		//IL_2edf: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ef1: Unknown result type (might be due to invalid IL or missing references)
		//IL_2efb: Expected O, but got Unknown
		//IL_2efb: Unknown result type (might be due to invalid IL or missing references)
		//IL_2f0d: Unknown result type (might be due to invalid IL or missing references)
		//IL_2f17: Expected O, but got Unknown
		//IL_2f12: Unknown result type (might be due to invalid IL or missing references)
		//IL_2f1c: Expected O, but got Unknown
		//IL_2f21: Expected O, but got Unknown
		//IL_2f99: Unknown result type (might be due to invalid IL or missing references)
		//IL_2f9e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2fa9: Unknown result type (might be due to invalid IL or missing references)
		//IL_2fae: Unknown result type (might be due to invalid IL or missing references)
		//IL_3004: Unknown result type (might be due to invalid IL or missing references)
		//IL_3009: Unknown result type (might be due to invalid IL or missing references)
		//IL_300c: Expected O, but got Unknown
		//IL_3011: Expected O, but got Unknown
		//IL_3011: Unknown result type (might be due to invalid IL or missing references)
		//IL_3023: Unknown result type (might be due to invalid IL or missing references)
		//IL_3035: Unknown result type (might be due to invalid IL or missing references)
		//IL_303f: Expected O, but got Unknown
		//IL_303a: Unknown result type (might be due to invalid IL or missing references)
		//IL_3044: Expected O, but got Unknown
		//IL_3049: Expected O, but got Unknown
		//IL_30a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_3118: Unknown result type (might be due to invalid IL or missing references)
		//IL_311d: Unknown result type (might be due to invalid IL or missing references)
		//IL_312f: Unknown result type (might be due to invalid IL or missing references)
		//IL_3139: Expected O, but got Unknown
		//IL_3139: Unknown result type (might be due to invalid IL or missing references)
		//IL_314b: Unknown result type (might be due to invalid IL or missing references)
		//IL_3155: Expected O, but got Unknown
		//IL_3150: Unknown result type (might be due to invalid IL or missing references)
		//IL_315a: Expected O, but got Unknown
		//IL_315f: Expected O, but got Unknown
		//IL_31aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_31e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_3240: Unknown result type (might be due to invalid IL or missing references)
		//IL_3245: Unknown result type (might be due to invalid IL or missing references)
		//IL_3250: Unknown result type (might be due to invalid IL or missing references)
		//IL_3255: Unknown result type (might be due to invalid IL or missing references)
		//IL_32ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_32cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_32d2: Expected O, but got Unknown
		//IL_32d7: Expected O, but got Unknown
		//IL_32d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_32e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_32fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_3305: Expected O, but got Unknown
		//IL_3300: Unknown result type (might be due to invalid IL or missing references)
		//IL_330a: Expected O, but got Unknown
		//IL_330f: Expected O, but got Unknown
		//IL_3386: Unknown result type (might be due to invalid IL or missing references)
		//IL_338b: Unknown result type (might be due to invalid IL or missing references)
		//IL_3396: Unknown result type (might be due to invalid IL or missing references)
		//IL_339b: Unknown result type (might be due to invalid IL or missing references)
		//IL_342b: Unknown result type (might be due to invalid IL or missing references)
		//IL_3430: Unknown result type (might be due to invalid IL or missing references)
		//IL_3433: Expected O, but got Unknown
		//IL_3438: Expected O, but got Unknown
		//IL_3438: Unknown result type (might be due to invalid IL or missing references)
		//IL_344a: Unknown result type (might be due to invalid IL or missing references)
		//IL_345c: Unknown result type (might be due to invalid IL or missing references)
		//IL_3466: Expected O, but got Unknown
		//IL_3461: Unknown result type (might be due to invalid IL or missing references)
		//IL_346b: Expected O, but got Unknown
		//IL_3470: Expected O, but got Unknown
		//IL_3487: Unknown result type (might be due to invalid IL or missing references)
		//IL_348c: Unknown result type (might be due to invalid IL or missing references)
		//IL_3497: Unknown result type (might be due to invalid IL or missing references)
		//IL_349c: Unknown result type (might be due to invalid IL or missing references)
		//IL_352c: Unknown result type (might be due to invalid IL or missing references)
		//IL_3531: Unknown result type (might be due to invalid IL or missing references)
		//IL_3534: Expected O, but got Unknown
		//IL_3539: Expected O, but got Unknown
		//IL_3539: Unknown result type (might be due to invalid IL or missing references)
		//IL_354b: Unknown result type (might be due to invalid IL or missing references)
		//IL_355d: Unknown result type (might be due to invalid IL or missing references)
		//IL_3567: Expected O, but got Unknown
		//IL_3562: Unknown result type (might be due to invalid IL or missing references)
		//IL_356c: Expected O, but got Unknown
		//IL_3571: Expected O, but got Unknown
		//IL_357e: Unknown result type (might be due to invalid IL or missing references)
		//IL_3583: Unknown result type (might be due to invalid IL or missing references)
		//IL_3595: Unknown result type (might be due to invalid IL or missing references)
		//IL_359f: Expected O, but got Unknown
		//IL_359f: Unknown result type (might be due to invalid IL or missing references)
		//IL_35b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_35bb: Expected O, but got Unknown
		//IL_35b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_35c0: Expected O, but got Unknown
		//IL_35c5: Expected O, but got Unknown
		//IL_363d: Unknown result type (might be due to invalid IL or missing references)
		//IL_3642: Unknown result type (might be due to invalid IL or missing references)
		//IL_364d: Unknown result type (might be due to invalid IL or missing references)
		//IL_3652: Unknown result type (might be due to invalid IL or missing references)
		//IL_36a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_36ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_36b0: Expected O, but got Unknown
		//IL_36b5: Expected O, but got Unknown
		//IL_36b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_36c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_36d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_36e3: Expected O, but got Unknown
		//IL_36de: Unknown result type (might be due to invalid IL or missing references)
		//IL_36e8: Expected O, but got Unknown
		//IL_36ed: Expected O, but got Unknown
		//IL_3745: Unknown result type (might be due to invalid IL or missing references)
		//IL_37bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_37c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_37d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_37dd: Expected O, but got Unknown
		//IL_37dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_37ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_37f9: Expected O, but got Unknown
		//IL_37f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_37fe: Expected O, but got Unknown
		//IL_3803: Expected O, but got Unknown
		//IL_384e: Unknown result type (might be due to invalid IL or missing references)
		//IL_388c: Unknown result type (might be due to invalid IL or missing references)
		//IL_38e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_38e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_38f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_38f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_396e: Unknown result type (might be due to invalid IL or missing references)
		//IL_3973: Unknown result type (might be due to invalid IL or missing references)
		//IL_3976: Expected O, but got Unknown
		//IL_397b: Expected O, but got Unknown
		//IL_397b: Unknown result type (might be due to invalid IL or missing references)
		//IL_398d: Unknown result type (might be due to invalid IL or missing references)
		//IL_399f: Unknown result type (might be due to invalid IL or missing references)
		//IL_39a9: Expected O, but got Unknown
		//IL_39a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_39ae: Expected O, but got Unknown
		//IL_39b3: Expected O, but got Unknown
		//IL_3a2a: Unknown result type (might be due to invalid IL or missing references)
		//IL_3a2f: Unknown result type (might be due to invalid IL or missing references)
		//IL_3a3a: Unknown result type (might be due to invalid IL or missing references)
		//IL_3a3f: Unknown result type (might be due to invalid IL or missing references)
		//IL_3acf: Unknown result type (might be due to invalid IL or missing references)
		//IL_3ad4: Unknown result type (might be due to invalid IL or missing references)
		//IL_3ad7: Expected O, but got Unknown
		//IL_3adc: Expected O, but got Unknown
		//IL_3adc: Unknown result type (might be due to invalid IL or missing references)
		//IL_3aee: Unknown result type (might be due to invalid IL or missing references)
		//IL_3b00: Unknown result type (might be due to invalid IL or missing references)
		//IL_3b0a: Expected O, but got Unknown
		//IL_3b05: Unknown result type (might be due to invalid IL or missing references)
		//IL_3b0f: Expected O, but got Unknown
		//IL_3b14: Expected O, but got Unknown
		//IL_3b2b: Unknown result type (might be due to invalid IL or missing references)
		//IL_3b30: Unknown result type (might be due to invalid IL or missing references)
		//IL_3b3b: Unknown result type (might be due to invalid IL or missing references)
		//IL_3b40: Unknown result type (might be due to invalid IL or missing references)
		//IL_3bd0: Unknown result type (might be due to invalid IL or missing references)
		//IL_3bd5: Unknown result type (might be due to invalid IL or missing references)
		//IL_3bd8: Expected O, but got Unknown
		//IL_3bdd: Expected O, but got Unknown
		//IL_3bdd: Unknown result type (might be due to invalid IL or missing references)
		//IL_3bef: Unknown result type (might be due to invalid IL or missing references)
		//IL_3c01: Unknown result type (might be due to invalid IL or missing references)
		//IL_3c0b: Expected O, but got Unknown
		//IL_3c06: Unknown result type (might be due to invalid IL or missing references)
		//IL_3c10: Expected O, but got Unknown
		//IL_3c15: Expected O, but got Unknown
		//IL_3c22: Unknown result type (might be due to invalid IL or missing references)
		//IL_3c27: Unknown result type (might be due to invalid IL or missing references)
		//IL_3c39: Unknown result type (might be due to invalid IL or missing references)
		//IL_3c43: Expected O, but got Unknown
		//IL_3c43: Unknown result type (might be due to invalid IL or missing references)
		//IL_3c55: Unknown result type (might be due to invalid IL or missing references)
		//IL_3c5f: Expected O, but got Unknown
		//IL_3c5a: Unknown result type (might be due to invalid IL or missing references)
		//IL_3c64: Expected O, but got Unknown
		//IL_3c69: Expected O, but got Unknown
		//IL_3d39: Unknown result type (might be due to invalid IL or missing references)
		//IL_3d54: Unknown result type (might be due to invalid IL or missing references)
		//IL_3d59: Unknown result type (might be due to invalid IL or missing references)
		//IL_3d64: Unknown result type (might be due to invalid IL or missing references)
		//IL_3d69: Unknown result type (might be due to invalid IL or missing references)
		//IL_3dce: Unknown result type (might be due to invalid IL or missing references)
		//IL_3dd3: Unknown result type (might be due to invalid IL or missing references)
		//IL_3dd6: Expected O, but got Unknown
		//IL_3ddb: Expected O, but got Unknown
		//IL_3ddb: Unknown result type (might be due to invalid IL or missing references)
		//IL_3ded: Unknown result type (might be due to invalid IL or missing references)
		//IL_3dff: Unknown result type (might be due to invalid IL or missing references)
		//IL_3e09: Expected O, but got Unknown
		//IL_3e04: Unknown result type (might be due to invalid IL or missing references)
		//IL_3e0e: Expected O, but got Unknown
		//IL_3e13: Expected O, but got Unknown
		//IL_3e2a: Unknown result type (might be due to invalid IL or missing references)
		//IL_3e2f: Unknown result type (might be due to invalid IL or missing references)
		//IL_3e3a: Unknown result type (might be due to invalid IL or missing references)
		//IL_3e3f: Unknown result type (might be due to invalid IL or missing references)
		//IL_3ea4: Unknown result type (might be due to invalid IL or missing references)
		//IL_3ea9: Unknown result type (might be due to invalid IL or missing references)
		//IL_3eac: Expected O, but got Unknown
		//IL_3eb1: Expected O, but got Unknown
		//IL_3eb1: Unknown result type (might be due to invalid IL or missing references)
		//IL_3ec3: Unknown result type (might be due to invalid IL or missing references)
		//IL_3ed5: Unknown result type (might be due to invalid IL or missing references)
		//IL_3edf: Expected O, but got Unknown
		//IL_3eda: Unknown result type (might be due to invalid IL or missing references)
		//IL_3ee4: Expected O, but got Unknown
		//IL_3ee9: Expected O, but got Unknown
		//IL_3ef6: Unknown result type (might be due to invalid IL or missing references)
		//IL_3efb: Unknown result type (might be due to invalid IL or missing references)
		//IL_3f0d: Unknown result type (might be due to invalid IL or missing references)
		//IL_3f17: Expected O, but got Unknown
		//IL_3f17: Unknown result type (might be due to invalid IL or missing references)
		//IL_3f29: Unknown result type (might be due to invalid IL or missing references)
		//IL_3f33: Expected O, but got Unknown
		//IL_3f2e: Unknown result type (might be due to invalid IL or missing references)
		//IL_3f38: Expected O, but got Unknown
		//IL_3f3d: Expected O, but got Unknown
		//IL_3fa0: Unknown result type (might be due to invalid IL or missing references)
		//IL_3ff3: Unknown result type (might be due to invalid IL or missing references)
		//IL_400e: Unknown result type (might be due to invalid IL or missing references)
		//IL_4013: Unknown result type (might be due to invalid IL or missing references)
		//IL_401e: Unknown result type (might be due to invalid IL or missing references)
		//IL_4023: Unknown result type (might be due to invalid IL or missing references)
		//IL_4092: Unknown result type (might be due to invalid IL or missing references)
		//IL_4097: Unknown result type (might be due to invalid IL or missing references)
		//IL_409a: Expected O, but got Unknown
		//IL_409f: Expected O, but got Unknown
		//IL_409f: Unknown result type (might be due to invalid IL or missing references)
		//IL_40b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_40c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_40cd: Expected O, but got Unknown
		//IL_40c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_40d2: Expected O, but got Unknown
		//IL_40d7: Expected O, but got Unknown
		//IL_40ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_40f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_40fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_4103: Unknown result type (might be due to invalid IL or missing references)
		//IL_4172: Unknown result type (might be due to invalid IL or missing references)
		//IL_4177: Unknown result type (might be due to invalid IL or missing references)
		//IL_417a: Expected O, but got Unknown
		//IL_417f: Expected O, but got Unknown
		//IL_417f: Unknown result type (might be due to invalid IL or missing references)
		//IL_4191: Unknown result type (might be due to invalid IL or missing references)
		//IL_41a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_41ad: Expected O, but got Unknown
		//IL_41a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_41b2: Expected O, but got Unknown
		//IL_41b7: Expected O, but got Unknown
		//IL_41c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_41c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_41db: Unknown result type (might be due to invalid IL or missing references)
		//IL_41e5: Expected O, but got Unknown
		//IL_41e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_41f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_4201: Expected O, but got Unknown
		//IL_41fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_4206: Expected O, but got Unknown
		//IL_420b: Expected O, but got Unknown
		//IL_424a: Unknown result type (might be due to invalid IL or missing references)
		//IL_4276: Unknown result type (might be due to invalid IL or missing references)
		//IL_427b: Unknown result type (might be due to invalid IL or missing references)
		//IL_4286: Unknown result type (might be due to invalid IL or missing references)
		//IL_428b: Unknown result type (might be due to invalid IL or missing references)
		//IL_42eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_42f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_42f3: Expected O, but got Unknown
		//IL_42f8: Expected O, but got Unknown
		//IL_42f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_430a: Unknown result type (might be due to invalid IL or missing references)
		//IL_431c: Unknown result type (might be due to invalid IL or missing references)
		//IL_4326: Expected O, but got Unknown
		//IL_4321: Unknown result type (might be due to invalid IL or missing references)
		//IL_432b: Expected O, but got Unknown
		//IL_4330: Expected O, but got Unknown
		//IL_43b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_43ba: Expected O, but got Unknown
		//IL_442f: Unknown result type (might be due to invalid IL or missing references)
		//IL_4469: Unknown result type (might be due to invalid IL or missing references)
		//IL_4492: Unknown result type (might be due to invalid IL or missing references)
		//IL_4497: Unknown result type (might be due to invalid IL or missing references)
		//IL_44a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_44b3: Expected O, but got Unknown
		//IL_44b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_44c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_44cf: Expected O, but got Unknown
		//IL_44ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_44d4: Expected O, but got Unknown
		//IL_44d9: Expected O, but got Unknown
		//IL_455a: Unknown result type (might be due to invalid IL or missing references)
		//IL_455f: Unknown result type (might be due to invalid IL or missing references)
		//IL_4571: Unknown result type (might be due to invalid IL or missing references)
		//IL_457b: Expected O, but got Unknown
		//IL_457b: Unknown result type (might be due to invalid IL or missing references)
		//IL_458d: Unknown result type (might be due to invalid IL or missing references)
		//IL_4597: Expected O, but got Unknown
		//IL_4592: Unknown result type (might be due to invalid IL or missing references)
		//IL_459c: Expected O, but got Unknown
		//IL_45a1: Expected O, but got Unknown
		//IL_45b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_461e: Unknown result type (might be due to invalid IL or missing references)
		//IL_4623: Unknown result type (might be due to invalid IL or missing references)
		//IL_462e: Unknown result type (might be due to invalid IL or missing references)
		//IL_4633: Unknown result type (might be due to invalid IL or missing references)
		//IL_46ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_46b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_46b4: Expected O, but got Unknown
		//IL_46b9: Expected O, but got Unknown
		//IL_46b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_46cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_46dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_46e7: Expected O, but got Unknown
		//IL_46e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_46ec: Expected O, but got Unknown
		//IL_46f1: Expected O, but got Unknown
		//IL_4708: Unknown result type (might be due to invalid IL or missing references)
		//IL_470d: Unknown result type (might be due to invalid IL or missing references)
		//IL_4718: Unknown result type (might be due to invalid IL or missing references)
		//IL_471d: Unknown result type (might be due to invalid IL or missing references)
		//IL_4796: Unknown result type (might be due to invalid IL or missing references)
		//IL_479b: Unknown result type (might be due to invalid IL or missing references)
		//IL_479e: Expected O, but got Unknown
		//IL_47a3: Expected O, but got Unknown
		//IL_47a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_47b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_47c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_47d1: Expected O, but got Unknown
		//IL_47cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_47d6: Expected O, but got Unknown
		//IL_47db: Expected O, but got Unknown
		//IL_47e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_47ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_47ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_4809: Expected O, but got Unknown
		//IL_4809: Unknown result type (might be due to invalid IL or missing references)
		//IL_481b: Unknown result type (might be due to invalid IL or missing references)
		//IL_4825: Expected O, but got Unknown
		//IL_4820: Unknown result type (might be due to invalid IL or missing references)
		//IL_482a: Expected O, but got Unknown
		//IL_482f: Expected O, but got Unknown
		//IL_4879: Unknown result type (might be due to invalid IL or missing references)
		//IL_4883: Expected O, but got Unknown
		//IL_489b: Unknown result type (might be due to invalid IL or missing references)
		//IL_48c3: Unknown result type (might be due to invalid IL or missing references)
		StaticResourceExtension val = new StaticResourceExtension();
		StaticResourceExtension val2 = new StaticResourceExtension();
		AppThemeBindingExtension val3 = new AppThemeBindingExtension();
		StaticResourceExtension val4 = new StaticResourceExtension();
		Label val5 = new Label();
		StaticResourceExtension val6 = new StaticResourceExtension();
		StaticResourceExtension val7 = new StaticResourceExtension();
		AppThemeBindingExtension val8 = new AppThemeBindingExtension();
		Label val9 = new Label();
		StaticResourceExtension val10 = new StaticResourceExtension();
		StaticResourceExtension val11 = new StaticResourceExtension();
		AppThemeBindingExtension val12 = new AppThemeBindingExtension();
		BoxView val13 = new BoxView();
		StaticResourceExtension val14 = new StaticResourceExtension();
		StaticResourceExtension val15 = new StaticResourceExtension();
		AppThemeBindingExtension val16 = new AppThemeBindingExtension();
		Label val17 = new Label();
		AppThemeBindingExtension val18 = new AppThemeBindingExtension();
		AppThemeBindingExtension val19 = new AppThemeBindingExtension();
		Image val20 = new Image();
		AppThemeBindingExtension val21 = new AppThemeBindingExtension();
		Label val22 = new Label();
		StaticResourceExtension val23 = new StaticResourceExtension();
		Switch val24 = new Switch();
		HorizontalStackLayout val25 = new HorizontalStackLayout();
		Frame val26 = new Frame();
		StaticResourceExtension val27 = new StaticResourceExtension();
		TapGestureRecognizer val28 = new TapGestureRecognizer();
		AppThemeBindingExtension val29 = new AppThemeBindingExtension();
		Image val30 = new Image();
		StaticResourceExtension val31 = new StaticResourceExtension();
		Label val32 = new Label();
		StaticResourceExtension val33 = new StaticResourceExtension();
		StaticResourceExtension val34 = new StaticResourceExtension();
		AppThemeBindingExtension val35 = new AppThemeBindingExtension();
		Label val36 = new Label();
		VerticalStackLayout val37 = new VerticalStackLayout();
		HorizontalStackLayout val38 = new HorizontalStackLayout();
		Frame val39 = new Frame();
		StaticResourceExtension val40 = new StaticResourceExtension();
		TapGestureRecognizer val41 = new TapGestureRecognizer();
		AppThemeBindingExtension val42 = new AppThemeBindingExtension();
		Image val43 = new Image();
		StaticResourceExtension val44 = new StaticResourceExtension();
		Label val45 = new Label();
		StaticResourceExtension val46 = new StaticResourceExtension();
		StaticResourceExtension val47 = new StaticResourceExtension();
		AppThemeBindingExtension val48 = new AppThemeBindingExtension();
		Label val49 = new Label();
		VerticalStackLayout val50 = new VerticalStackLayout();
		HorizontalStackLayout val51 = new HorizontalStackLayout();
		Frame val52 = new Frame();
		StaticResourceExtension val53 = new StaticResourceExtension();
		TapGestureRecognizer val54 = new TapGestureRecognizer();
		AppThemeBindingExtension val55 = new AppThemeBindingExtension();
		Image val56 = new Image();
		StaticResourceExtension val57 = new StaticResourceExtension();
		Label val58 = new Label();
		StaticResourceExtension val59 = new StaticResourceExtension();
		StaticResourceExtension val60 = new StaticResourceExtension();
		AppThemeBindingExtension val61 = new AppThemeBindingExtension();
		Label val62 = new Label();
		VerticalStackLayout val63 = new VerticalStackLayout();
		HorizontalStackLayout val64 = new HorizontalStackLayout();
		Frame val65 = new Frame();
		StaticResourceExtension val66 = new StaticResourceExtension();
		TapGestureRecognizer val67 = new TapGestureRecognizer();
		AppThemeBindingExtension val68 = new AppThemeBindingExtension();
		Image val69 = new Image();
		StaticResourceExtension val70 = new StaticResourceExtension();
		Label val71 = new Label();
		StaticResourceExtension val72 = new StaticResourceExtension();
		StaticResourceExtension val73 = new StaticResourceExtension();
		AppThemeBindingExtension val74 = new AppThemeBindingExtension();
		Label val75 = new Label();
		VerticalStackLayout val76 = new VerticalStackLayout();
		HorizontalStackLayout val77 = new HorizontalStackLayout();
		Frame val78 = new Frame();
		StaticResourceExtension val79 = new StaticResourceExtension();
		TapGestureRecognizer val80 = new TapGestureRecognizer();
		AppThemeBindingExtension val81 = new AppThemeBindingExtension();
		Image val82 = new Image();
		StaticResourceExtension val83 = new StaticResourceExtension();
		Label val84 = new Label();
		StaticResourceExtension val85 = new StaticResourceExtension();
		StaticResourceExtension val86 = new StaticResourceExtension();
		AppThemeBindingExtension val87 = new AppThemeBindingExtension();
		Label val88 = new Label();
		VerticalStackLayout val89 = new VerticalStackLayout();
		HorizontalStackLayout val90 = new HorizontalStackLayout();
		Frame val91 = new Frame();
		StaticResourceExtension val92 = new StaticResourceExtension();
		TapGestureRecognizer val93 = new TapGestureRecognizer();
		AppThemeBindingExtension val94 = new AppThemeBindingExtension();
		Image val95 = new Image();
		StaticResourceExtension val96 = new StaticResourceExtension();
		Label val97 = new Label();
		StaticResourceExtension val98 = new StaticResourceExtension();
		StaticResourceExtension val99 = new StaticResourceExtension();
		AppThemeBindingExtension val100 = new AppThemeBindingExtension();
		Label val101 = new Label();
		VerticalStackLayout val102 = new VerticalStackLayout();
		HorizontalStackLayout val103 = new HorizontalStackLayout();
		Frame val104 = new Frame();
		Grid val105 = new Grid();
		StaticResourceExtension val106 = new StaticResourceExtension();
		StaticResourceExtension val107 = new StaticResourceExtension();
		AppThemeBindingExtension val108 = new AppThemeBindingExtension();
		Label val109 = new Label();
		StaticResourceExtension val110 = new StaticResourceExtension();
		StaticResourceExtension val111 = new StaticResourceExtension();
		AppThemeBindingExtension val112 = new AppThemeBindingExtension();
		Label val113 = new Label();
		StaticResourceExtension val114 = new StaticResourceExtension();
		Button val115 = new Button();
		Button val116 = new Button();
		HorizontalStackLayout val117 = new HorizontalStackLayout();
		VerticalStackLayout val118 = new VerticalStackLayout();
		AppThemeBindingExtension val119 = new AppThemeBindingExtension();
		AppThemeBindingExtension val120 = new AppThemeBindingExtension();
		Label val121 = new Label();
		StaticResourceExtension val122 = new StaticResourceExtension();
		StaticResourceExtension val123 = new StaticResourceExtension();
		AppThemeBindingExtension val124 = new AppThemeBindingExtension();
		Label val125 = new Label();
		Button val126 = new Button();
		VerticalStackLayout val127 = new VerticalStackLayout();
		Frame val128 = new Frame();
		VerticalStackLayout val129 = new VerticalStackLayout();
		ScrollView val130 = new ScrollView();
		HomePage homePage;
		NameScope val131 = (NameScope)(((object)NameScope.GetNameScope((BindableObject)(object)(homePage = this))) ?? ((object)new NameScope()));
		NameScope.SetNameScope((BindableObject)(object)homePage, (INameScope)(object)val131);
		((Element)val130).transientNamescope = (INameScope)(object)val131;
		((Element)val129).transientNamescope = (INameScope)(object)val131;
		((Element)val5).transientNamescope = (INameScope)(object)val131;
		((Element)val9).transientNamescope = (INameScope)(object)val131;
		((Element)val13).transientNamescope = (INameScope)(object)val131;
		((Element)val17).transientNamescope = (INameScope)(object)val131;
		((Element)val26).transientNamescope = (INameScope)(object)val131;
		((Element)val25).transientNamescope = (INameScope)(object)val131;
		((Element)val20).transientNamescope = (INameScope)(object)val131;
		((Element)val22).transientNamescope = (INameScope)(object)val131;
		((Element)val24).transientNamescope = (INameScope)(object)val131;
		((INameScope)val131).RegisterName("ThemeSwitch", (object)val24);
		if (((Element)val24).StyleId == null)
		{
			((Element)val24).StyleId = "ThemeSwitch";
		}
		((Element)val105).transientNamescope = (INameScope)(object)val131;
		((Element)val39).transientNamescope = (INameScope)(object)val131;
		((Element)val28).transientNamescope = (INameScope)(object)val131;
		((Element)val38).transientNamescope = (INameScope)(object)val131;
		((Element)val30).transientNamescope = (INameScope)(object)val131;
		((Element)val37).transientNamescope = (INameScope)(object)val131;
		((Element)val32).transientNamescope = (INameScope)(object)val131;
		((Element)val36).transientNamescope = (INameScope)(object)val131;
		((Element)val52).transientNamescope = (INameScope)(object)val131;
		((Element)val41).transientNamescope = (INameScope)(object)val131;
		((Element)val51).transientNamescope = (INameScope)(object)val131;
		((Element)val43).transientNamescope = (INameScope)(object)val131;
		((Element)val50).transientNamescope = (INameScope)(object)val131;
		((Element)val45).transientNamescope = (INameScope)(object)val131;
		((Element)val49).transientNamescope = (INameScope)(object)val131;
		((Element)val65).transientNamescope = (INameScope)(object)val131;
		((Element)val54).transientNamescope = (INameScope)(object)val131;
		((Element)val64).transientNamescope = (INameScope)(object)val131;
		((Element)val56).transientNamescope = (INameScope)(object)val131;
		((Element)val63).transientNamescope = (INameScope)(object)val131;
		((Element)val58).transientNamescope = (INameScope)(object)val131;
		((Element)val62).transientNamescope = (INameScope)(object)val131;
		((Element)val78).transientNamescope = (INameScope)(object)val131;
		((Element)val67).transientNamescope = (INameScope)(object)val131;
		((Element)val77).transientNamescope = (INameScope)(object)val131;
		((Element)val69).transientNamescope = (INameScope)(object)val131;
		((Element)val76).transientNamescope = (INameScope)(object)val131;
		((Element)val71).transientNamescope = (INameScope)(object)val131;
		((Element)val75).transientNamescope = (INameScope)(object)val131;
		((Element)val91).transientNamescope = (INameScope)(object)val131;
		((Element)val80).transientNamescope = (INameScope)(object)val131;
		((Element)val90).transientNamescope = (INameScope)(object)val131;
		((Element)val82).transientNamescope = (INameScope)(object)val131;
		((Element)val89).transientNamescope = (INameScope)(object)val131;
		((Element)val84).transientNamescope = (INameScope)(object)val131;
		((Element)val88).transientNamescope = (INameScope)(object)val131;
		((Element)val104).transientNamescope = (INameScope)(object)val131;
		((Element)val93).transientNamescope = (INameScope)(object)val131;
		((Element)val103).transientNamescope = (INameScope)(object)val131;
		((Element)val95).transientNamescope = (INameScope)(object)val131;
		((Element)val102).transientNamescope = (INameScope)(object)val131;
		((Element)val97).transientNamescope = (INameScope)(object)val131;
		((Element)val101).transientNamescope = (INameScope)(object)val131;
		((Element)val109).transientNamescope = (INameScope)(object)val131;
		((Element)val118).transientNamescope = (INameScope)(object)val131;
		((Element)val113).transientNamescope = (INameScope)(object)val131;
		((Element)val117).transientNamescope = (INameScope)(object)val131;
		((Element)val115).transientNamescope = (INameScope)(object)val131;
		((Element)val116).transientNamescope = (INameScope)(object)val131;
		((Element)val128).transientNamescope = (INameScope)(object)val131;
		((Element)val127).transientNamescope = (INameScope)(object)val131;
		((Element)val121).transientNamescope = (INameScope)(object)val131;
		((Element)val125).transientNamescope = (INameScope)(object)val131;
		((Element)val126).transientNamescope = (INameScope)(object)val131;
		ThemeSwitch = val24;
		((BindableObject)homePage).SetValue(Page.TitleProperty, (object)"Home");
		val.Key = "PageBackgroundLight";
		StaticResourceExtension val132 = new StaticResourceExtension
		{
			Key = "PageBackgroundLight"
		};
		XamlServiceProvider val133 = new XamlServiceProvider();
		Type? typeFromHandle = typeof(IProvideValueTarget);
		object[] array = new object[0 + 2];
		array[0] = val3;
		array[1] = homePage;
		SimpleValueTargetProvider val134 = new SimpleValueTargetProvider(array, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Light"), (INameScope[])(object)new NameScope[3] { val131, val131, val131 }, false);
		object obj = (object)val134;
		val133.Add(typeFromHandle, (object)val134);
		val133.Add(typeof(IReferenceProvider), obj);
		val133.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(6, 14)));
		object light = val132.ProvideValue((IServiceProvider)val133);
		val3.Light = light;
		val2.Key = "PageBackgroundDark";
		StaticResourceExtension val135 = new StaticResourceExtension
		{
			Key = "PageBackgroundDark"
		};
		XamlServiceProvider val136 = new XamlServiceProvider();
		Type? typeFromHandle2 = typeof(IProvideValueTarget);
		object[] array2 = new object[0 + 2];
		array2[0] = val3;
		array2[1] = homePage;
		SimpleValueTargetProvider val137 = new SimpleValueTargetProvider(array2, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Dark"), (INameScope[])(object)new NameScope[3] { val131, val131, val131 }, false);
		object obj2 = (object)val137;
		val136.Add(typeFromHandle2, (object)val137);
		val136.Add(typeof(IReferenceProvider), obj2);
		val136.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(6, 14)));
		object dark = val135.ProvideValue((IServiceProvider)val136);
		val3.Dark = dark;
		XamlServiceProvider val138 = new XamlServiceProvider();
		val138.Add(typeof(IProvideValueTarget), (object)new ValueTargetProvider((object)homePage, (object)VisualElement.BackgroundColorProperty));
		val138.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(6, 14)));
		BindingBase val139 = ((IMarkupExtension<BindingBase>)(object)val3).ProvideValue((IServiceProvider)val138);
		((BindableObject)homePage).SetBinding(VisualElement.BackgroundColorProperty, val139);
		((BindableObject)val129).SetValue(Layout.PaddingProperty, (object)new Thickness(30.0));
		((BindableObject)val129).SetValue(StackBase.SpacingProperty, (object)20.0);
		((BindableObject)val5).SetValue(Label.TextProperty, (object)"OpenMaui Linux");
		((BindableObject)val5).SetValue(Label.FontSizeProperty, (object)32.0);
		((BindableObject)val5).SetValue(Label.FontAttributesProperty, (object)(FontAttributes)1);
		((BindableObject)val5).SetValue(View.HorizontalOptionsProperty, (object)LayoutOptions.Center);
		val4.Key = "PrimaryColor";
		StaticResourceExtension val140 = new StaticResourceExtension
		{
			Key = "PrimaryColor"
		};
		XamlServiceProvider val141 = new XamlServiceProvider();
		Type? typeFromHandle3 = typeof(IProvideValueTarget);
		object[] array3 = new object[0 + 4];
		array3[0] = val5;
		array3[1] = val129;
		array3[2] = val130;
		array3[3] = homePage;
		SimpleValueTargetProvider val142 = new SimpleValueTargetProvider(array3, (object)Label.TextColorProperty, (INameScope[])(object)new NameScope[5] { val131, val131, val131, val131, val131 }, false);
		object obj3 = (object)val142;
		val141.Add(typeFromHandle3, (object)val142);
		val141.Add(typeof(IReferenceProvider), obj3);
		val141.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(16, 20)));
		object obj4 = val140.ProvideValue((IServiceProvider)val141);
		((BindableObject)val5).SetValue(Label.TextColorProperty, (obj4 == null || !typeof(BindingBase).IsAssignableFrom(obj4.GetType())) ? obj4 : obj4);
		((Layout)val129).Children.Add((IView)(object)val5);
		((BindableObject)val9).SetValue(Label.TextProperty, (object)"Controls Demo");
		((BindableObject)val9).SetValue(Label.FontSizeProperty, (object)20.0);
		((BindableObject)val9).SetValue(View.HorizontalOptionsProperty, (object)LayoutOptions.Center);
		val6.Key = "TextSecondaryLight";
		StaticResourceExtension val143 = new StaticResourceExtension
		{
			Key = "TextSecondaryLight"
		};
		XamlServiceProvider val144 = new XamlServiceProvider();
		Type? typeFromHandle4 = typeof(IProvideValueTarget);
		object[] array4 = new object[0 + 5];
		array4[0] = val8;
		array4[1] = val9;
		array4[2] = val129;
		array4[3] = val130;
		array4[4] = homePage;
		SimpleValueTargetProvider val145 = new SimpleValueTargetProvider(array4, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Light"), (INameScope[])(object)new NameScope[6] { val131, val131, val131, val131, val131, val131 }, false);
		object obj5 = (object)val145;
		val144.Add(typeFromHandle4, (object)val145);
		val144.Add(typeof(IReferenceProvider), obj5);
		val144.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(21, 20)));
		object light2 = val143.ProvideValue((IServiceProvider)val144);
		val8.Light = light2;
		val7.Key = "TextSecondaryDark";
		StaticResourceExtension val146 = new StaticResourceExtension
		{
			Key = "TextSecondaryDark"
		};
		XamlServiceProvider val147 = new XamlServiceProvider();
		Type? typeFromHandle5 = typeof(IProvideValueTarget);
		object[] array5 = new object[0 + 5];
		array5[0] = val8;
		array5[1] = val9;
		array5[2] = val129;
		array5[3] = val130;
		array5[4] = homePage;
		SimpleValueTargetProvider val148 = new SimpleValueTargetProvider(array5, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Dark"), (INameScope[])(object)new NameScope[6] { val131, val131, val131, val131, val131, val131 }, false);
		object obj6 = (object)val148;
		val147.Add(typeFromHandle5, (object)val148);
		val147.Add(typeof(IReferenceProvider), obj6);
		val147.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(21, 20)));
		object dark2 = val146.ProvideValue((IServiceProvider)val147);
		val8.Dark = dark2;
		XamlServiceProvider val149 = new XamlServiceProvider();
		val149.Add(typeof(IProvideValueTarget), (object)new ValueTargetProvider((object)val9, (object)Label.TextColorProperty));
		val149.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(21, 20)));
		BindingBase val150 = ((IMarkupExtension<BindingBase>)(object)val8).ProvideValue((IServiceProvider)val149);
		((BindableObject)val9).SetBinding(Label.TextColorProperty, val150);
		((Layout)val129).Children.Add((IView)(object)val9);
		((BindableObject)val13).SetValue(VisualElement.HeightRequestProperty, (object)2.0);
		((BindableObject)val13).SetValue(View.MarginProperty, (object)new Thickness(0.0, 10.0));
		val10.Key = "BorderLight";
		StaticResourceExtension val151 = new StaticResourceExtension
		{
			Key = "BorderLight"
		};
		XamlServiceProvider val152 = new XamlServiceProvider();
		Type? typeFromHandle6 = typeof(IProvideValueTarget);
		object[] array6 = new object[0 + 5];
		array6[0] = val12;
		array6[1] = val13;
		array6[2] = val129;
		array6[3] = val130;
		array6[4] = homePage;
		SimpleValueTargetProvider val153 = new SimpleValueTargetProvider(array6, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Light"), (INameScope[])(object)new NameScope[6] { val131, val131, val131, val131, val131, val131 }, false);
		object obj7 = (object)val153;
		val152.Add(typeFromHandle6, (object)val153);
		val152.Add(typeof(IReferenceProvider), obj7);
		val152.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(25, 22)));
		object light3 = val151.ProvideValue((IServiceProvider)val152);
		val12.Light = light3;
		val11.Key = "BorderDark";
		StaticResourceExtension val154 = new StaticResourceExtension
		{
			Key = "BorderDark"
		};
		XamlServiceProvider val155 = new XamlServiceProvider();
		Type? typeFromHandle7 = typeof(IProvideValueTarget);
		object[] array7 = new object[0 + 5];
		array7[0] = val12;
		array7[1] = val13;
		array7[2] = val129;
		array7[3] = val130;
		array7[4] = homePage;
		SimpleValueTargetProvider val156 = new SimpleValueTargetProvider(array7, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Dark"), (INameScope[])(object)new NameScope[6] { val131, val131, val131, val131, val131, val131 }, false);
		object obj8 = (object)val156;
		val155.Add(typeFromHandle7, (object)val156);
		val155.Add(typeof(IReferenceProvider), obj8);
		val155.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(25, 22)));
		object dark3 = val154.ProvideValue((IServiceProvider)val155);
		val12.Dark = dark3;
		XamlServiceProvider val157 = new XamlServiceProvider();
		val157.Add(typeof(IProvideValueTarget), (object)new ValueTargetProvider((object)val13, (object)BoxView.ColorProperty));
		val157.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(25, 22)));
		BindingBase val158 = ((IMarkupExtension<BindingBase>)(object)val12).ProvideValue((IServiceProvider)val157);
		((BindableObject)val13).SetBinding(BoxView.ColorProperty, val158);
		((Layout)val129).Children.Add((IView)(object)val13);
		((BindableObject)val17).SetValue(Label.TextProperty, (object)"Welcome to the comprehensive controls demonstration for OpenMaui Linux. This app showcases all the major UI controls available in the framework.");
		((BindableObject)val17).SetValue(Label.FontSizeProperty, (object)14.0);
		((BindableObject)val17).SetValue(Label.LineBreakModeProperty, (object)(LineBreakMode)1);
		((BindableObject)val17).SetValue(Label.HorizontalTextAlignmentProperty, (object)(TextAlignment)1);
		val14.Key = "TextPrimaryLight";
		StaticResourceExtension val159 = new StaticResourceExtension
		{
			Key = "TextPrimaryLight"
		};
		XamlServiceProvider val160 = new XamlServiceProvider();
		Type? typeFromHandle8 = typeof(IProvideValueTarget);
		object[] array8 = new object[0 + 5];
		array8[0] = val16;
		array8[1] = val17;
		array8[2] = val129;
		array8[3] = val130;
		array8[4] = homePage;
		SimpleValueTargetProvider val161 = new SimpleValueTargetProvider(array8, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Light"), (INameScope[])(object)new NameScope[6] { val131, val131, val131, val131, val131, val131 }, false);
		object obj9 = (object)val161;
		val160.Add(typeFromHandle8, (object)val161);
		val160.Add(typeof(IReferenceProvider), obj9);
		val160.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(31, 20)));
		object light4 = val159.ProvideValue((IServiceProvider)val160);
		val16.Light = light4;
		val15.Key = "TextPrimaryDark";
		StaticResourceExtension val162 = new StaticResourceExtension
		{
			Key = "TextPrimaryDark"
		};
		XamlServiceProvider val163 = new XamlServiceProvider();
		Type? typeFromHandle9 = typeof(IProvideValueTarget);
		object[] array9 = new object[0 + 5];
		array9[0] = val16;
		array9[1] = val17;
		array9[2] = val129;
		array9[3] = val130;
		array9[4] = homePage;
		SimpleValueTargetProvider val164 = new SimpleValueTargetProvider(array9, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Dark"), (INameScope[])(object)new NameScope[6] { val131, val131, val131, val131, val131, val131 }, false);
		object obj10 = (object)val164;
		val163.Add(typeFromHandle9, (object)val164);
		val163.Add(typeof(IReferenceProvider), obj10);
		val163.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(31, 20)));
		object dark4 = val162.ProvideValue((IServiceProvider)val163);
		val16.Dark = dark4;
		XamlServiceProvider val165 = new XamlServiceProvider();
		val165.Add(typeof(IProvideValueTarget), (object)new ValueTargetProvider((object)val17, (object)Label.TextColorProperty));
		val165.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(31, 20)));
		BindingBase val166 = ((IMarkupExtension<BindingBase>)(object)val16).ProvideValue((IServiceProvider)val165);
		((BindableObject)val17).SetBinding(Label.TextColorProperty, val166);
		((Layout)val129).Children.Add((IView)(object)val17);
		((BindableObject)val26).SetValue(Frame.CornerRadiusProperty, (object)8f);
		((BindableObject)val26).SetValue(Layout.PaddingProperty, (object)new Thickness(15.0));
		((BindableObject)val26).SetValue(Frame.HasShadowProperty, (object)true);
		((BindableObject)val26).SetValue(View.MarginProperty, (object)new Thickness(0.0, 10.0));
		val18.Light = "#E3F2FD";
		val18.Dark = "#1565C0";
		XamlServiceProvider val167 = new XamlServiceProvider();
		val167.Add(typeof(IProvideValueTarget), (object)new ValueTargetProvider((object)val26, (object)VisualElement.BackgroundColorProperty));
		val167.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(38, 20)));
		BindingBase val168 = ((IMarkupExtension<BindingBase>)(object)val18).ProvideValue((IServiceProvider)val167);
		((BindableObject)val26).SetBinding(VisualElement.BackgroundColorProperty, val168);
		((BindableObject)val25).SetValue(StackBase.SpacingProperty, (object)15.0);
		((BindableObject)val25).SetValue(View.HorizontalOptionsProperty, (object)LayoutOptions.Center);
		val19.Light = "theme_dark.png";
		val19.Dark = "theme_light.png";
		XamlServiceProvider val169 = new XamlServiceProvider();
		val169.Add(typeof(IProvideValueTarget), (object)new ValueTargetProvider((object)val20, (object)Image.SourceProperty));
		val169.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(40, 28)));
		BindingBase val170 = ((IMarkupExtension<BindingBase>)(object)val19).ProvideValue((IServiceProvider)val169);
		((BindableObject)val20).SetBinding(Image.SourceProperty, val170);
		((BindableObject)val20).SetValue(VisualElement.WidthRequestProperty, (object)24.0);
		((BindableObject)val20).SetValue(VisualElement.HeightRequestProperty, (object)24.0);
		((BindableObject)val20).SetValue(View.VerticalOptionsProperty, (object)LayoutOptions.Center);
		((Layout)val25).Children.Add((IView)(object)val20);
		((BindableObject)val22).SetValue(Label.TextProperty, (object)"Toggle Theme");
		((BindableObject)val22).SetValue(Label.FontSizeProperty, (object)16.0);
		((BindableObject)val22).SetValue(Label.FontAttributesProperty, (object)(FontAttributes)1);
		((BindableObject)val22).SetValue(View.VerticalOptionsProperty, (object)LayoutOptions.Center);
		val21.Light = "#1565C0";
		val21.Dark = "White";
		XamlServiceProvider val171 = new XamlServiceProvider();
		val171.Add(typeof(IProvideValueTarget), (object)new ValueTargetProvider((object)val22, (object)Label.TextColorProperty));
		val171.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(48, 28)));
		BindingBase val172 = ((IMarkupExtension<BindingBase>)(object)val21).ProvideValue((IServiceProvider)val171);
		((BindableObject)val22).SetBinding(Label.TextColorProperty, val172);
		((Layout)val25).Children.Add((IView)(object)val22);
		val23.Key = "PrimaryColor";
		StaticResourceExtension val173 = new StaticResourceExtension
		{
			Key = "PrimaryColor"
		};
		XamlServiceProvider val174 = new XamlServiceProvider();
		Type? typeFromHandle10 = typeof(IProvideValueTarget);
		object[] array10 = new object[0 + 6];
		array10[0] = val24;
		array10[1] = val25;
		array10[2] = val26;
		array10[3] = val129;
		array10[4] = val130;
		array10[5] = homePage;
		SimpleValueTargetProvider val175 = new SimpleValueTargetProvider(array10, (object)Switch.OnColorProperty, (INameScope[])(object)new NameScope[7] { val131, val131, val131, val131, val131, val131, val131 }, false);
		object obj11 = (object)val175;
		val174.Add(typeFromHandle10, (object)val175);
		val174.Add(typeof(IReferenceProvider), obj11);
		val174.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(50, 29)));
		object obj12 = val173.ProvideValue((IServiceProvider)val174);
		((BindableObject)val24).SetValue(Switch.OnColorProperty, (obj12 == null || !typeof(BindingBase).IsAssignableFrom(obj12.GetType())) ? obj12 : obj12);
		((BindableObject)val24).SetValue(Switch.ThumbColorProperty, (object)Colors.White);
		((BindableObject)val24).SetValue(View.VerticalOptionsProperty, (object)LayoutOptions.Center);
		val24.Toggled += homePage.OnThemeToggled;
		((Layout)val25).Children.Add((IView)(object)val24);
		((BindableObject)val26).SetValue(ContentView.ContentProperty, (object)val25);
		((Layout)val129).Children.Add((IView)(object)val26);
		((BindableObject)val105).SetValue(Grid.ColumnDefinitionsProperty, (object)new ColumnDefinitionCollection((ColumnDefinition[])(object)new ColumnDefinition[2]
		{
			new ColumnDefinition(GridLength.Star),
			new ColumnDefinition(GridLength.Star)
		}));
		((BindableObject)val105).SetValue(Grid.RowDefinitionsProperty, (object)new RowDefinitionCollection((RowDefinition[])(object)new RowDefinition[3]
		{
			new RowDefinition(GridLength.Auto),
			new RowDefinition(GridLength.Auto),
			new RowDefinition(GridLength.Auto)
		}));
		((BindableObject)val105).SetValue(Grid.ColumnSpacingProperty, (object)15.0);
		((BindableObject)val105).SetValue(Grid.RowSpacingProperty, (object)15.0);
		((BindableObject)val105).SetValue(View.MarginProperty, (object)new Thickness(0.0, 20.0));
		((BindableObject)val39).SetValue(Grid.RowProperty, (object)0);
		((BindableObject)val39).SetValue(Grid.ColumnProperty, (object)0);
		val27.Key = "ThemedFrame";
		StaticResourceExtension val176 = new StaticResourceExtension
		{
			Key = "ThemedFrame"
		};
		XamlServiceProvider val177 = new XamlServiceProvider();
		Type? typeFromHandle11 = typeof(IProvideValueTarget);
		object[] array11 = new object[0 + 5];
		array11[0] = val39;
		array11[1] = val105;
		array11[2] = val129;
		array11[3] = val130;
		array11[4] = homePage;
		SimpleValueTargetProvider val178 = new SimpleValueTargetProvider(array11, (object)VisualElement.StyleProperty, (INameScope[])(object)new NameScope[6] { val131, val131, val131, val131, val131, val131 }, false);
		object obj13 = (object)val178;
		val177.Add(typeFromHandle11, (object)val178);
		val177.Add(typeof(IReferenceProvider), obj13);
		val177.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(66, 24)));
		object obj14 = val176.ProvideValue((IServiceProvider)val177);
		((BindableObject)val39).SetValue(VisualElement.StyleProperty, (obj14 == null || !typeof(BindingBase).IsAssignableFrom(obj14.GetType())) ? obj14 : obj14);
		((BindableObject)val39).SetValue(Frame.CornerRadiusProperty, (object)8f);
		((BindableObject)val39).SetValue(Layout.PaddingProperty, (object)new Thickness(15.0));
		((BindableObject)val39).SetValue(Frame.HasShadowProperty, (object)true);
		val28.Tapped += homePage.OnButtonsCardTapped;
		((View)val39).GestureRecognizers.Add((IGestureRecognizer)(object)val28);
		((BindableObject)val38).SetValue(StackBase.SpacingProperty, (object)12.0);
		val29.Light = "touch_app_dark.png";
		val29.Dark = "touch_app_light.png";
		XamlServiceProvider val179 = new XamlServiceProvider();
		val179.Add(typeof(IProvideValueTarget), (object)new ValueTargetProvider((object)val30, (object)Image.SourceProperty));
		val179.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(72, 32)));
		BindingBase val180 = ((IMarkupExtension<BindingBase>)(object)val29).ProvideValue((IServiceProvider)val179);
		((BindableObject)val30).SetBinding(Image.SourceProperty, val180);
		((BindableObject)val30).SetValue(VisualElement.WidthRequestProperty, (object)32.0);
		((BindableObject)val30).SetValue(VisualElement.HeightRequestProperty, (object)32.0);
		((BindableObject)val30).SetValue(View.VerticalOptionsProperty, (object)LayoutOptions.Center);
		((Layout)val38).Children.Add((IView)(object)val30);
		((BindableObject)val37).SetValue(StackBase.SpacingProperty, (object)3.0);
		((BindableObject)val37).SetValue(View.VerticalOptionsProperty, (object)LayoutOptions.Center);
		((BindableObject)val32).SetValue(Label.TextProperty, (object)"Buttons");
		((BindableObject)val32).SetValue(Label.FontSizeProperty, (object)14.0);
		((BindableObject)val32).SetValue(Label.FontAttributesProperty, (object)(FontAttributes)1);
		val31.Key = "PrimaryColor";
		StaticResourceExtension val181 = new StaticResourceExtension
		{
			Key = "PrimaryColor"
		};
		XamlServiceProvider val182 = new XamlServiceProvider();
		Type? typeFromHandle12 = typeof(IProvideValueTarget);
		object[] array12 = new object[0 + 8];
		array12[0] = val32;
		array12[1] = val37;
		array12[2] = val38;
		array12[3] = val39;
		array12[4] = val105;
		array12[5] = val129;
		array12[6] = val130;
		array12[7] = homePage;
		SimpleValueTargetProvider val183 = new SimpleValueTargetProvider(array12, (object)Label.TextColorProperty, (INameScope[])(object)new NameScope[9] { val131, val131, val131, val131, val131, val131, val131, val131, val131 }, false);
		object obj15 = (object)val183;
		val182.Add(typeFromHandle12, (object)val183);
		val182.Add(typeof(IReferenceProvider), obj15);
		val182.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(75, 87)));
		object obj16 = val181.ProvideValue((IServiceProvider)val182);
		((BindableObject)val32).SetValue(Label.TextColorProperty, (obj16 == null || !typeof(BindingBase).IsAssignableFrom(obj16.GetType())) ? obj16 : obj16);
		((Layout)val37).Children.Add((IView)(object)val32);
		((BindableObject)val36).SetValue(Label.TextProperty, (object)"Various button styles");
		((BindableObject)val36).SetValue(Label.FontSizeProperty, (object)11.0);
		val33.Key = "TextSecondaryLight";
		StaticResourceExtension val184 = new StaticResourceExtension
		{
			Key = "TextSecondaryLight"
		};
		XamlServiceProvider val185 = new XamlServiceProvider();
		Type? typeFromHandle13 = typeof(IProvideValueTarget);
		object[] array13 = new object[0 + 9];
		array13[0] = val35;
		array13[1] = val36;
		array13[2] = val37;
		array13[3] = val38;
		array13[4] = val39;
		array13[5] = val105;
		array13[6] = val129;
		array13[7] = val130;
		array13[8] = homePage;
		SimpleValueTargetProvider val186 = new SimpleValueTargetProvider(array13, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Light"), (INameScope[])(object)new NameScope[10] { val131, val131, val131, val131, val131, val131, val131, val131, val131, val131 }, false);
		object obj17 = (object)val186;
		val185.Add(typeFromHandle13, (object)val186);
		val185.Add(typeof(IReferenceProvider), obj17);
		val185.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(77, 36)));
		object light5 = val184.ProvideValue((IServiceProvider)val185);
		val35.Light = light5;
		val34.Key = "TextSecondaryDark";
		StaticResourceExtension val187 = new StaticResourceExtension
		{
			Key = "TextSecondaryDark"
		};
		XamlServiceProvider val188 = new XamlServiceProvider();
		Type? typeFromHandle14 = typeof(IProvideValueTarget);
		object[] array14 = new object[0 + 9];
		array14[0] = val35;
		array14[1] = val36;
		array14[2] = val37;
		array14[3] = val38;
		array14[4] = val39;
		array14[5] = val105;
		array14[6] = val129;
		array14[7] = val130;
		array14[8] = homePage;
		SimpleValueTargetProvider val189 = new SimpleValueTargetProvider(array14, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Dark"), (INameScope[])(object)new NameScope[10] { val131, val131, val131, val131, val131, val131, val131, val131, val131, val131 }, false);
		object obj18 = (object)val189;
		val188.Add(typeFromHandle14, (object)val189);
		val188.Add(typeof(IReferenceProvider), obj18);
		val188.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(77, 36)));
		object dark5 = val187.ProvideValue((IServiceProvider)val188);
		val35.Dark = dark5;
		XamlServiceProvider val190 = new XamlServiceProvider();
		val190.Add(typeof(IProvideValueTarget), (object)new ValueTargetProvider((object)val36, (object)Label.TextColorProperty));
		val190.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(77, 36)));
		BindingBase val191 = ((IMarkupExtension<BindingBase>)(object)val35).ProvideValue((IServiceProvider)val190);
		((BindableObject)val36).SetBinding(Label.TextColorProperty, val191);
		((Layout)val37).Children.Add((IView)(object)val36);
		((Layout)val38).Children.Add((IView)(object)val37);
		((BindableObject)val39).SetValue(ContentView.ContentProperty, (object)val38);
		((Layout)val105).Children.Add((IView)(object)val39);
		((BindableObject)val52).SetValue(Grid.RowProperty, (object)0);
		((BindableObject)val52).SetValue(Grid.ColumnProperty, (object)1);
		val40.Key = "ThemedFrame";
		StaticResourceExtension val192 = new StaticResourceExtension
		{
			Key = "ThemedFrame"
		};
		XamlServiceProvider val193 = new XamlServiceProvider();
		Type? typeFromHandle15 = typeof(IProvideValueTarget);
		object[] array15 = new object[0 + 5];
		array15[0] = val52;
		array15[1] = val105;
		array15[2] = val129;
		array15[3] = val130;
		array15[4] = homePage;
		SimpleValueTargetProvider val194 = new SimpleValueTargetProvider(array15, (object)VisualElement.StyleProperty, (INameScope[])(object)new NameScope[6] { val131, val131, val131, val131, val131, val131 }, false);
		object obj19 = (object)val194;
		val193.Add(typeFromHandle15, (object)val194);
		val193.Add(typeof(IReferenceProvider), obj19);
		val193.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(84, 24)));
		object obj20 = val192.ProvideValue((IServiceProvider)val193);
		((BindableObject)val52).SetValue(VisualElement.StyleProperty, (obj20 == null || !typeof(BindingBase).IsAssignableFrom(obj20.GetType())) ? obj20 : obj20);
		((BindableObject)val52).SetValue(Frame.CornerRadiusProperty, (object)8f);
		((BindableObject)val52).SetValue(Layout.PaddingProperty, (object)new Thickness(15.0));
		((BindableObject)val52).SetValue(Frame.HasShadowProperty, (object)true);
		val41.Tapped += homePage.OnTextInputCardTapped;
		((View)val52).GestureRecognizers.Add((IGestureRecognizer)(object)val41);
		((BindableObject)val51).SetValue(StackBase.SpacingProperty, (object)12.0);
		val42.Light = "text_fields_dark.png";
		val42.Dark = "text_fields_light.png";
		XamlServiceProvider val195 = new XamlServiceProvider();
		val195.Add(typeof(IProvideValueTarget), (object)new ValueTargetProvider((object)val43, (object)Image.SourceProperty));
		val195.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(90, 32)));
		BindingBase val196 = ((IMarkupExtension<BindingBase>)(object)val42).ProvideValue((IServiceProvider)val195);
		((BindableObject)val43).SetBinding(Image.SourceProperty, val196);
		((BindableObject)val43).SetValue(VisualElement.WidthRequestProperty, (object)32.0);
		((BindableObject)val43).SetValue(VisualElement.HeightRequestProperty, (object)32.0);
		((BindableObject)val43).SetValue(View.VerticalOptionsProperty, (object)LayoutOptions.Center);
		((Layout)val51).Children.Add((IView)(object)val43);
		((BindableObject)val50).SetValue(StackBase.SpacingProperty, (object)3.0);
		((BindableObject)val50).SetValue(View.VerticalOptionsProperty, (object)LayoutOptions.Center);
		((BindableObject)val45).SetValue(Label.TextProperty, (object)"Text Input");
		((BindableObject)val45).SetValue(Label.FontSizeProperty, (object)14.0);
		((BindableObject)val45).SetValue(Label.FontAttributesProperty, (object)(FontAttributes)1);
		val44.Key = "PrimaryColor";
		StaticResourceExtension val197 = new StaticResourceExtension
		{
			Key = "PrimaryColor"
		};
		XamlServiceProvider val198 = new XamlServiceProvider();
		Type? typeFromHandle16 = typeof(IProvideValueTarget);
		object[] array16 = new object[0 + 8];
		array16[0] = val45;
		array16[1] = val50;
		array16[2] = val51;
		array16[3] = val52;
		array16[4] = val105;
		array16[5] = val129;
		array16[6] = val130;
		array16[7] = homePage;
		SimpleValueTargetProvider val199 = new SimpleValueTargetProvider(array16, (object)Label.TextColorProperty, (INameScope[])(object)new NameScope[9] { val131, val131, val131, val131, val131, val131, val131, val131, val131 }, false);
		object obj21 = (object)val199;
		val198.Add(typeFromHandle16, (object)val199);
		val198.Add(typeof(IReferenceProvider), obj21);
		val198.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(93, 90)));
		object obj22 = val197.ProvideValue((IServiceProvider)val198);
		((BindableObject)val45).SetValue(Label.TextColorProperty, (obj22 == null || !typeof(BindingBase).IsAssignableFrom(obj22.GetType())) ? obj22 : obj22);
		((Layout)val50).Children.Add((IView)(object)val45);
		((BindableObject)val49).SetValue(Label.TextProperty, (object)"Entry, Editor, SearchBar");
		((BindableObject)val49).SetValue(Label.FontSizeProperty, (object)11.0);
		val46.Key = "TextSecondaryLight";
		StaticResourceExtension val200 = new StaticResourceExtension
		{
			Key = "TextSecondaryLight"
		};
		XamlServiceProvider val201 = new XamlServiceProvider();
		Type? typeFromHandle17 = typeof(IProvideValueTarget);
		object[] array17 = new object[0 + 9];
		array17[0] = val48;
		array17[1] = val49;
		array17[2] = val50;
		array17[3] = val51;
		array17[4] = val52;
		array17[5] = val105;
		array17[6] = val129;
		array17[7] = val130;
		array17[8] = homePage;
		SimpleValueTargetProvider val202 = new SimpleValueTargetProvider(array17, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Light"), (INameScope[])(object)new NameScope[10] { val131, val131, val131, val131, val131, val131, val131, val131, val131, val131 }, false);
		object obj23 = (object)val202;
		val201.Add(typeFromHandle17, (object)val202);
		val201.Add(typeof(IReferenceProvider), obj23);
		val201.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(95, 36)));
		object light6 = val200.ProvideValue((IServiceProvider)val201);
		val48.Light = light6;
		val47.Key = "TextSecondaryDark";
		StaticResourceExtension val203 = new StaticResourceExtension
		{
			Key = "TextSecondaryDark"
		};
		XamlServiceProvider val204 = new XamlServiceProvider();
		Type? typeFromHandle18 = typeof(IProvideValueTarget);
		object[] array18 = new object[0 + 9];
		array18[0] = val48;
		array18[1] = val49;
		array18[2] = val50;
		array18[3] = val51;
		array18[4] = val52;
		array18[5] = val105;
		array18[6] = val129;
		array18[7] = val130;
		array18[8] = homePage;
		SimpleValueTargetProvider val205 = new SimpleValueTargetProvider(array18, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Dark"), (INameScope[])(object)new NameScope[10] { val131, val131, val131, val131, val131, val131, val131, val131, val131, val131 }, false);
		object obj24 = (object)val205;
		val204.Add(typeFromHandle18, (object)val205);
		val204.Add(typeof(IReferenceProvider), obj24);
		val204.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(95, 36)));
		object dark6 = val203.ProvideValue((IServiceProvider)val204);
		val48.Dark = dark6;
		XamlServiceProvider val206 = new XamlServiceProvider();
		val206.Add(typeof(IProvideValueTarget), (object)new ValueTargetProvider((object)val49, (object)Label.TextColorProperty));
		val206.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(95, 36)));
		BindingBase val207 = ((IMarkupExtension<BindingBase>)(object)val48).ProvideValue((IServiceProvider)val206);
		((BindableObject)val49).SetBinding(Label.TextColorProperty, val207);
		((Layout)val50).Children.Add((IView)(object)val49);
		((Layout)val51).Children.Add((IView)(object)val50);
		((BindableObject)val52).SetValue(ContentView.ContentProperty, (object)val51);
		((Layout)val105).Children.Add((IView)(object)val52);
		((BindableObject)val65).SetValue(Grid.RowProperty, (object)1);
		((BindableObject)val65).SetValue(Grid.ColumnProperty, (object)0);
		val53.Key = "ThemedFrame";
		StaticResourceExtension val208 = new StaticResourceExtension
		{
			Key = "ThemedFrame"
		};
		XamlServiceProvider val209 = new XamlServiceProvider();
		Type? typeFromHandle19 = typeof(IProvideValueTarget);
		object[] array19 = new object[0 + 5];
		array19[0] = val65;
		array19[1] = val105;
		array19[2] = val129;
		array19[3] = val130;
		array19[4] = homePage;
		SimpleValueTargetProvider val210 = new SimpleValueTargetProvider(array19, (object)VisualElement.StyleProperty, (INameScope[])(object)new NameScope[6] { val131, val131, val131, val131, val131, val131 }, false);
		object obj25 = (object)val210;
		val209.Add(typeFromHandle19, (object)val210);
		val209.Add(typeof(IReferenceProvider), obj25);
		val209.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(102, 24)));
		object obj26 = val208.ProvideValue((IServiceProvider)val209);
		((BindableObject)val65).SetValue(VisualElement.StyleProperty, (obj26 == null || !typeof(BindingBase).IsAssignableFrom(obj26.GetType())) ? obj26 : obj26);
		((BindableObject)val65).SetValue(Frame.CornerRadiusProperty, (object)8f);
		((BindableObject)val65).SetValue(Layout.PaddingProperty, (object)new Thickness(15.0));
		((BindableObject)val65).SetValue(Frame.HasShadowProperty, (object)true);
		val54.Tapped += homePage.OnSelectionCardTapped;
		((View)val65).GestureRecognizers.Add((IGestureRecognizer)(object)val54);
		((BindableObject)val64).SetValue(StackBase.SpacingProperty, (object)12.0);
		val55.Light = "check_box_dark.png";
		val55.Dark = "check_box_light.png";
		XamlServiceProvider val211 = new XamlServiceProvider();
		val211.Add(typeof(IProvideValueTarget), (object)new ValueTargetProvider((object)val56, (object)Image.SourceProperty));
		val211.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(108, 32)));
		BindingBase val212 = ((IMarkupExtension<BindingBase>)(object)val55).ProvideValue((IServiceProvider)val211);
		((BindableObject)val56).SetBinding(Image.SourceProperty, val212);
		((BindableObject)val56).SetValue(VisualElement.WidthRequestProperty, (object)32.0);
		((BindableObject)val56).SetValue(VisualElement.HeightRequestProperty, (object)32.0);
		((BindableObject)val56).SetValue(View.VerticalOptionsProperty, (object)LayoutOptions.Center);
		((Layout)val64).Children.Add((IView)(object)val56);
		((BindableObject)val63).SetValue(StackBase.SpacingProperty, (object)3.0);
		((BindableObject)val63).SetValue(View.VerticalOptionsProperty, (object)LayoutOptions.Center);
		((BindableObject)val58).SetValue(Label.TextProperty, (object)"Selection");
		((BindableObject)val58).SetValue(Label.FontSizeProperty, (object)14.0);
		((BindableObject)val58).SetValue(Label.FontAttributesProperty, (object)(FontAttributes)1);
		val57.Key = "PrimaryColor";
		StaticResourceExtension val213 = new StaticResourceExtension
		{
			Key = "PrimaryColor"
		};
		XamlServiceProvider val214 = new XamlServiceProvider();
		Type? typeFromHandle20 = typeof(IProvideValueTarget);
		object[] array20 = new object[0 + 8];
		array20[0] = val58;
		array20[1] = val63;
		array20[2] = val64;
		array20[3] = val65;
		array20[4] = val105;
		array20[5] = val129;
		array20[6] = val130;
		array20[7] = homePage;
		SimpleValueTargetProvider val215 = new SimpleValueTargetProvider(array20, (object)Label.TextColorProperty, (INameScope[])(object)new NameScope[9] { val131, val131, val131, val131, val131, val131, val131, val131, val131 }, false);
		object obj27 = (object)val215;
		val214.Add(typeFromHandle20, (object)val215);
		val214.Add(typeof(IReferenceProvider), obj27);
		val214.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(111, 89)));
		object obj28 = val213.ProvideValue((IServiceProvider)val214);
		((BindableObject)val58).SetValue(Label.TextColorProperty, (obj28 == null || !typeof(BindingBase).IsAssignableFrom(obj28.GetType())) ? obj28 : obj28);
		((Layout)val63).Children.Add((IView)(object)val58);
		((BindableObject)val62).SetValue(Label.TextProperty, (object)"CheckBox, Switch, Slider");
		((BindableObject)val62).SetValue(Label.FontSizeProperty, (object)11.0);
		val59.Key = "TextSecondaryLight";
		StaticResourceExtension val216 = new StaticResourceExtension
		{
			Key = "TextSecondaryLight"
		};
		XamlServiceProvider val217 = new XamlServiceProvider();
		Type? typeFromHandle21 = typeof(IProvideValueTarget);
		object[] array21 = new object[0 + 9];
		array21[0] = val61;
		array21[1] = val62;
		array21[2] = val63;
		array21[3] = val64;
		array21[4] = val65;
		array21[5] = val105;
		array21[6] = val129;
		array21[7] = val130;
		array21[8] = homePage;
		SimpleValueTargetProvider val218 = new SimpleValueTargetProvider(array21, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Light"), (INameScope[])(object)new NameScope[10] { val131, val131, val131, val131, val131, val131, val131, val131, val131, val131 }, false);
		object obj29 = (object)val218;
		val217.Add(typeFromHandle21, (object)val218);
		val217.Add(typeof(IReferenceProvider), obj29);
		val217.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(113, 36)));
		object light7 = val216.ProvideValue((IServiceProvider)val217);
		val61.Light = light7;
		val60.Key = "TextSecondaryDark";
		StaticResourceExtension val219 = new StaticResourceExtension
		{
			Key = "TextSecondaryDark"
		};
		XamlServiceProvider val220 = new XamlServiceProvider();
		Type? typeFromHandle22 = typeof(IProvideValueTarget);
		object[] array22 = new object[0 + 9];
		array22[0] = val61;
		array22[1] = val62;
		array22[2] = val63;
		array22[3] = val64;
		array22[4] = val65;
		array22[5] = val105;
		array22[6] = val129;
		array22[7] = val130;
		array22[8] = homePage;
		SimpleValueTargetProvider val221 = new SimpleValueTargetProvider(array22, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Dark"), (INameScope[])(object)new NameScope[10] { val131, val131, val131, val131, val131, val131, val131, val131, val131, val131 }, false);
		object obj30 = (object)val221;
		val220.Add(typeFromHandle22, (object)val221);
		val220.Add(typeof(IReferenceProvider), obj30);
		val220.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(113, 36)));
		object dark7 = val219.ProvideValue((IServiceProvider)val220);
		val61.Dark = dark7;
		XamlServiceProvider val222 = new XamlServiceProvider();
		val222.Add(typeof(IProvideValueTarget), (object)new ValueTargetProvider((object)val62, (object)Label.TextColorProperty));
		val222.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(113, 36)));
		BindingBase val223 = ((IMarkupExtension<BindingBase>)(object)val61).ProvideValue((IServiceProvider)val222);
		((BindableObject)val62).SetBinding(Label.TextColorProperty, val223);
		((Layout)val63).Children.Add((IView)(object)val62);
		((Layout)val64).Children.Add((IView)(object)val63);
		((BindableObject)val65).SetValue(ContentView.ContentProperty, (object)val64);
		((Layout)val105).Children.Add((IView)(object)val65);
		((BindableObject)val78).SetValue(Grid.RowProperty, (object)1);
		((BindableObject)val78).SetValue(Grid.ColumnProperty, (object)1);
		val66.Key = "ThemedFrame";
		StaticResourceExtension val224 = new StaticResourceExtension
		{
			Key = "ThemedFrame"
		};
		XamlServiceProvider val225 = new XamlServiceProvider();
		Type? typeFromHandle23 = typeof(IProvideValueTarget);
		object[] array23 = new object[0 + 5];
		array23[0] = val78;
		array23[1] = val105;
		array23[2] = val129;
		array23[3] = val130;
		array23[4] = homePage;
		SimpleValueTargetProvider val226 = new SimpleValueTargetProvider(array23, (object)VisualElement.StyleProperty, (INameScope[])(object)new NameScope[6] { val131, val131, val131, val131, val131, val131 }, false);
		object obj31 = (object)val226;
		val225.Add(typeFromHandle23, (object)val226);
		val225.Add(typeof(IReferenceProvider), obj31);
		val225.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(120, 24)));
		object obj32 = val224.ProvideValue((IServiceProvider)val225);
		((BindableObject)val78).SetValue(VisualElement.StyleProperty, (obj32 == null || !typeof(BindingBase).IsAssignableFrom(obj32.GetType())) ? obj32 : obj32);
		((BindableObject)val78).SetValue(Frame.CornerRadiusProperty, (object)8f);
		((BindableObject)val78).SetValue(Layout.PaddingProperty, (object)new Thickness(15.0));
		((BindableObject)val78).SetValue(Frame.HasShadowProperty, (object)true);
		val67.Tapped += homePage.OnPickersCardTapped;
		((View)val78).GestureRecognizers.Add((IGestureRecognizer)(object)val67);
		((BindableObject)val77).SetValue(StackBase.SpacingProperty, (object)12.0);
		val68.Light = "calendar_dark.png";
		val68.Dark = "calendar_light.png";
		XamlServiceProvider val227 = new XamlServiceProvider();
		val227.Add(typeof(IProvideValueTarget), (object)new ValueTargetProvider((object)val69, (object)Image.SourceProperty));
		val227.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(126, 32)));
		BindingBase val228 = ((IMarkupExtension<BindingBase>)(object)val68).ProvideValue((IServiceProvider)val227);
		((BindableObject)val69).SetBinding(Image.SourceProperty, val228);
		((BindableObject)val69).SetValue(VisualElement.WidthRequestProperty, (object)32.0);
		((BindableObject)val69).SetValue(VisualElement.HeightRequestProperty, (object)32.0);
		((BindableObject)val69).SetValue(View.VerticalOptionsProperty, (object)LayoutOptions.Center);
		((Layout)val77).Children.Add((IView)(object)val69);
		((BindableObject)val76).SetValue(StackBase.SpacingProperty, (object)3.0);
		((BindableObject)val76).SetValue(View.VerticalOptionsProperty, (object)LayoutOptions.Center);
		((BindableObject)val71).SetValue(Label.TextProperty, (object)"Pickers");
		((BindableObject)val71).SetValue(Label.FontSizeProperty, (object)14.0);
		((BindableObject)val71).SetValue(Label.FontAttributesProperty, (object)(FontAttributes)1);
		val70.Key = "PrimaryColor";
		StaticResourceExtension val229 = new StaticResourceExtension
		{
			Key = "PrimaryColor"
		};
		XamlServiceProvider val230 = new XamlServiceProvider();
		Type? typeFromHandle24 = typeof(IProvideValueTarget);
		object[] array24 = new object[0 + 8];
		array24[0] = val71;
		array24[1] = val76;
		array24[2] = val77;
		array24[3] = val78;
		array24[4] = val105;
		array24[5] = val129;
		array24[6] = val130;
		array24[7] = homePage;
		SimpleValueTargetProvider val231 = new SimpleValueTargetProvider(array24, (object)Label.TextColorProperty, (INameScope[])(object)new NameScope[9] { val131, val131, val131, val131, val131, val131, val131, val131, val131 }, false);
		object obj33 = (object)val231;
		val230.Add(typeFromHandle24, (object)val231);
		val230.Add(typeof(IReferenceProvider), obj33);
		val230.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(129, 87)));
		object obj34 = val229.ProvideValue((IServiceProvider)val230);
		((BindableObject)val71).SetValue(Label.TextColorProperty, (obj34 == null || !typeof(BindingBase).IsAssignableFrom(obj34.GetType())) ? obj34 : obj34);
		((Layout)val76).Children.Add((IView)(object)val71);
		((BindableObject)val75).SetValue(Label.TextProperty, (object)"Date, Time, Picker");
		((BindableObject)val75).SetValue(Label.FontSizeProperty, (object)11.0);
		val72.Key = "TextSecondaryLight";
		StaticResourceExtension val232 = new StaticResourceExtension
		{
			Key = "TextSecondaryLight"
		};
		XamlServiceProvider val233 = new XamlServiceProvider();
		Type? typeFromHandle25 = typeof(IProvideValueTarget);
		object[] array25 = new object[0 + 9];
		array25[0] = val74;
		array25[1] = val75;
		array25[2] = val76;
		array25[3] = val77;
		array25[4] = val78;
		array25[5] = val105;
		array25[6] = val129;
		array25[7] = val130;
		array25[8] = homePage;
		SimpleValueTargetProvider val234 = new SimpleValueTargetProvider(array25, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Light"), (INameScope[])(object)new NameScope[10] { val131, val131, val131, val131, val131, val131, val131, val131, val131, val131 }, false);
		object obj35 = (object)val234;
		val233.Add(typeFromHandle25, (object)val234);
		val233.Add(typeof(IReferenceProvider), obj35);
		val233.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(131, 36)));
		object light8 = val232.ProvideValue((IServiceProvider)val233);
		val74.Light = light8;
		val73.Key = "TextSecondaryDark";
		StaticResourceExtension val235 = new StaticResourceExtension
		{
			Key = "TextSecondaryDark"
		};
		XamlServiceProvider val236 = new XamlServiceProvider();
		Type? typeFromHandle26 = typeof(IProvideValueTarget);
		object[] array26 = new object[0 + 9];
		array26[0] = val74;
		array26[1] = val75;
		array26[2] = val76;
		array26[3] = val77;
		array26[4] = val78;
		array26[5] = val105;
		array26[6] = val129;
		array26[7] = val130;
		array26[8] = homePage;
		SimpleValueTargetProvider val237 = new SimpleValueTargetProvider(array26, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Dark"), (INameScope[])(object)new NameScope[10] { val131, val131, val131, val131, val131, val131, val131, val131, val131, val131 }, false);
		object obj36 = (object)val237;
		val236.Add(typeFromHandle26, (object)val237);
		val236.Add(typeof(IReferenceProvider), obj36);
		val236.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(131, 36)));
		object dark8 = val235.ProvideValue((IServiceProvider)val236);
		val74.Dark = dark8;
		XamlServiceProvider val238 = new XamlServiceProvider();
		val238.Add(typeof(IProvideValueTarget), (object)new ValueTargetProvider((object)val75, (object)Label.TextColorProperty));
		val238.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(131, 36)));
		BindingBase val239 = ((IMarkupExtension<BindingBase>)(object)val74).ProvideValue((IServiceProvider)val238);
		((BindableObject)val75).SetBinding(Label.TextColorProperty, val239);
		((Layout)val76).Children.Add((IView)(object)val75);
		((Layout)val77).Children.Add((IView)(object)val76);
		((BindableObject)val78).SetValue(ContentView.ContentProperty, (object)val77);
		((Layout)val105).Children.Add((IView)(object)val78);
		((BindableObject)val91).SetValue(Grid.RowProperty, (object)2);
		((BindableObject)val91).SetValue(Grid.ColumnProperty, (object)0);
		val79.Key = "ThemedFrame";
		StaticResourceExtension val240 = new StaticResourceExtension
		{
			Key = "ThemedFrame"
		};
		XamlServiceProvider val241 = new XamlServiceProvider();
		Type? typeFromHandle27 = typeof(IProvideValueTarget);
		object[] array27 = new object[0 + 5];
		array27[0] = val91;
		array27[1] = val105;
		array27[2] = val129;
		array27[3] = val130;
		array27[4] = homePage;
		SimpleValueTargetProvider val242 = new SimpleValueTargetProvider(array27, (object)VisualElement.StyleProperty, (INameScope[])(object)new NameScope[6] { val131, val131, val131, val131, val131, val131 }, false);
		object obj37 = (object)val242;
		val241.Add(typeFromHandle27, (object)val242);
		val241.Add(typeof(IReferenceProvider), obj37);
		val241.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(138, 24)));
		object obj38 = val240.ProvideValue((IServiceProvider)val241);
		((BindableObject)val91).SetValue(VisualElement.StyleProperty, (obj38 == null || !typeof(BindingBase).IsAssignableFrom(obj38.GetType())) ? obj38 : obj38);
		((BindableObject)val91).SetValue(Frame.CornerRadiusProperty, (object)8f);
		((BindableObject)val91).SetValue(Layout.PaddingProperty, (object)new Thickness(15.0));
		((BindableObject)val91).SetValue(Frame.HasShadowProperty, (object)true);
		val80.Tapped += homePage.OnListsCardTapped;
		((View)val91).GestureRecognizers.Add((IGestureRecognizer)(object)val80);
		((BindableObject)val90).SetValue(StackBase.SpacingProperty, (object)12.0);
		val81.Light = "list_dark.png";
		val81.Dark = "list_light.png";
		XamlServiceProvider val243 = new XamlServiceProvider();
		val243.Add(typeof(IProvideValueTarget), (object)new ValueTargetProvider((object)val82, (object)Image.SourceProperty));
		val243.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(144, 32)));
		BindingBase val244 = ((IMarkupExtension<BindingBase>)(object)val81).ProvideValue((IServiceProvider)val243);
		((BindableObject)val82).SetBinding(Image.SourceProperty, val244);
		((BindableObject)val82).SetValue(VisualElement.WidthRequestProperty, (object)32.0);
		((BindableObject)val82).SetValue(VisualElement.HeightRequestProperty, (object)32.0);
		((BindableObject)val82).SetValue(View.VerticalOptionsProperty, (object)LayoutOptions.Center);
		((Layout)val90).Children.Add((IView)(object)val82);
		((BindableObject)val89).SetValue(StackBase.SpacingProperty, (object)3.0);
		((BindableObject)val89).SetValue(View.VerticalOptionsProperty, (object)LayoutOptions.Center);
		((BindableObject)val84).SetValue(Label.TextProperty, (object)"Lists");
		((BindableObject)val84).SetValue(Label.FontSizeProperty, (object)14.0);
		((BindableObject)val84).SetValue(Label.FontAttributesProperty, (object)(FontAttributes)1);
		val83.Key = "PrimaryColor";
		StaticResourceExtension val245 = new StaticResourceExtension
		{
			Key = "PrimaryColor"
		};
		XamlServiceProvider val246 = new XamlServiceProvider();
		Type? typeFromHandle28 = typeof(IProvideValueTarget);
		object[] array28 = new object[0 + 8];
		array28[0] = val84;
		array28[1] = val89;
		array28[2] = val90;
		array28[3] = val91;
		array28[4] = val105;
		array28[5] = val129;
		array28[6] = val130;
		array28[7] = homePage;
		SimpleValueTargetProvider val247 = new SimpleValueTargetProvider(array28, (object)Label.TextColorProperty, (INameScope[])(object)new NameScope[9] { val131, val131, val131, val131, val131, val131, val131, val131, val131 }, false);
		object obj39 = (object)val247;
		val246.Add(typeFromHandle28, (object)val247);
		val246.Add(typeof(IReferenceProvider), obj39);
		val246.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(147, 85)));
		object obj40 = val245.ProvideValue((IServiceProvider)val246);
		((BindableObject)val84).SetValue(Label.TextColorProperty, (obj40 == null || !typeof(BindingBase).IsAssignableFrom(obj40.GetType())) ? obj40 : obj40);
		((Layout)val89).Children.Add((IView)(object)val84);
		((BindableObject)val88).SetValue(Label.TextProperty, (object)"CollectionView");
		((BindableObject)val88).SetValue(Label.FontSizeProperty, (object)11.0);
		val85.Key = "TextSecondaryLight";
		StaticResourceExtension val248 = new StaticResourceExtension
		{
			Key = "TextSecondaryLight"
		};
		XamlServiceProvider val249 = new XamlServiceProvider();
		Type? typeFromHandle29 = typeof(IProvideValueTarget);
		object[] array29 = new object[0 + 9];
		array29[0] = val87;
		array29[1] = val88;
		array29[2] = val89;
		array29[3] = val90;
		array29[4] = val91;
		array29[5] = val105;
		array29[6] = val129;
		array29[7] = val130;
		array29[8] = homePage;
		SimpleValueTargetProvider val250 = new SimpleValueTargetProvider(array29, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Light"), (INameScope[])(object)new NameScope[10] { val131, val131, val131, val131, val131, val131, val131, val131, val131, val131 }, false);
		object obj41 = (object)val250;
		val249.Add(typeFromHandle29, (object)val250);
		val249.Add(typeof(IReferenceProvider), obj41);
		val249.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(149, 36)));
		object light9 = val248.ProvideValue((IServiceProvider)val249);
		val87.Light = light9;
		val86.Key = "TextSecondaryDark";
		StaticResourceExtension val251 = new StaticResourceExtension
		{
			Key = "TextSecondaryDark"
		};
		XamlServiceProvider val252 = new XamlServiceProvider();
		Type? typeFromHandle30 = typeof(IProvideValueTarget);
		object[] array30 = new object[0 + 9];
		array30[0] = val87;
		array30[1] = val88;
		array30[2] = val89;
		array30[3] = val90;
		array30[4] = val91;
		array30[5] = val105;
		array30[6] = val129;
		array30[7] = val130;
		array30[8] = homePage;
		SimpleValueTargetProvider val253 = new SimpleValueTargetProvider(array30, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Dark"), (INameScope[])(object)new NameScope[10] { val131, val131, val131, val131, val131, val131, val131, val131, val131, val131 }, false);
		object obj42 = (object)val253;
		val252.Add(typeFromHandle30, (object)val253);
		val252.Add(typeof(IReferenceProvider), obj42);
		val252.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(149, 36)));
		object dark9 = val251.ProvideValue((IServiceProvider)val252);
		val87.Dark = dark9;
		XamlServiceProvider val254 = new XamlServiceProvider();
		val254.Add(typeof(IProvideValueTarget), (object)new ValueTargetProvider((object)val88, (object)Label.TextColorProperty));
		val254.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(149, 36)));
		BindingBase val255 = ((IMarkupExtension<BindingBase>)(object)val87).ProvideValue((IServiceProvider)val254);
		((BindableObject)val88).SetBinding(Label.TextColorProperty, val255);
		((Layout)val89).Children.Add((IView)(object)val88);
		((Layout)val90).Children.Add((IView)(object)val89);
		((BindableObject)val91).SetValue(ContentView.ContentProperty, (object)val90);
		((Layout)val105).Children.Add((IView)(object)val91);
		((BindableObject)val104).SetValue(Grid.RowProperty, (object)2);
		((BindableObject)val104).SetValue(Grid.ColumnProperty, (object)1);
		val92.Key = "ThemedFrame";
		StaticResourceExtension val256 = new StaticResourceExtension
		{
			Key = "ThemedFrame"
		};
		XamlServiceProvider val257 = new XamlServiceProvider();
		Type? typeFromHandle31 = typeof(IProvideValueTarget);
		object[] array31 = new object[0 + 5];
		array31[0] = val104;
		array31[1] = val105;
		array31[2] = val129;
		array31[3] = val130;
		array31[4] = homePage;
		SimpleValueTargetProvider val258 = new SimpleValueTargetProvider(array31, (object)VisualElement.StyleProperty, (INameScope[])(object)new NameScope[6] { val131, val131, val131, val131, val131, val131 }, false);
		object obj43 = (object)val258;
		val257.Add(typeFromHandle31, (object)val258);
		val257.Add(typeof(IReferenceProvider), obj43);
		val257.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(156, 24)));
		object obj44 = val256.ProvideValue((IServiceProvider)val257);
		((BindableObject)val104).SetValue(VisualElement.StyleProperty, (obj44 == null || !typeof(BindingBase).IsAssignableFrom(obj44.GetType())) ? obj44 : obj44);
		((BindableObject)val104).SetValue(Frame.CornerRadiusProperty, (object)8f);
		((BindableObject)val104).SetValue(Layout.PaddingProperty, (object)new Thickness(15.0));
		((BindableObject)val104).SetValue(Frame.HasShadowProperty, (object)true);
		val93.Tapped += homePage.OnProgressCardTapped;
		((View)val104).GestureRecognizers.Add((IGestureRecognizer)(object)val93);
		((BindableObject)val103).SetValue(StackBase.SpacingProperty, (object)12.0);
		val94.Light = "hourglass_dark.png";
		val94.Dark = "hourglass_light.png";
		XamlServiceProvider val259 = new XamlServiceProvider();
		val259.Add(typeof(IProvideValueTarget), (object)new ValueTargetProvider((object)val95, (object)Image.SourceProperty));
		val259.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(162, 32)));
		BindingBase val260 = ((IMarkupExtension<BindingBase>)(object)val94).ProvideValue((IServiceProvider)val259);
		((BindableObject)val95).SetBinding(Image.SourceProperty, val260);
		((BindableObject)val95).SetValue(VisualElement.WidthRequestProperty, (object)32.0);
		((BindableObject)val95).SetValue(VisualElement.HeightRequestProperty, (object)32.0);
		((BindableObject)val95).SetValue(View.VerticalOptionsProperty, (object)LayoutOptions.Center);
		((Layout)val103).Children.Add((IView)(object)val95);
		((BindableObject)val102).SetValue(StackBase.SpacingProperty, (object)3.0);
		((BindableObject)val102).SetValue(View.VerticalOptionsProperty, (object)LayoutOptions.Center);
		((BindableObject)val97).SetValue(Label.TextProperty, (object)"Progress");
		((BindableObject)val97).SetValue(Label.FontSizeProperty, (object)14.0);
		((BindableObject)val97).SetValue(Label.FontAttributesProperty, (object)(FontAttributes)1);
		val96.Key = "PrimaryColor";
		StaticResourceExtension val261 = new StaticResourceExtension
		{
			Key = "PrimaryColor"
		};
		XamlServiceProvider val262 = new XamlServiceProvider();
		Type? typeFromHandle32 = typeof(IProvideValueTarget);
		object[] array32 = new object[0 + 8];
		array32[0] = val97;
		array32[1] = val102;
		array32[2] = val103;
		array32[3] = val104;
		array32[4] = val105;
		array32[5] = val129;
		array32[6] = val130;
		array32[7] = homePage;
		SimpleValueTargetProvider val263 = new SimpleValueTargetProvider(array32, (object)Label.TextColorProperty, (INameScope[])(object)new NameScope[9] { val131, val131, val131, val131, val131, val131, val131, val131, val131 }, false);
		object obj45 = (object)val263;
		val262.Add(typeFromHandle32, (object)val263);
		val262.Add(typeof(IReferenceProvider), obj45);
		val262.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(165, 88)));
		object obj46 = val261.ProvideValue((IServiceProvider)val262);
		((BindableObject)val97).SetValue(Label.TextColorProperty, (obj46 == null || !typeof(BindingBase).IsAssignableFrom(obj46.GetType())) ? obj46 : obj46);
		((Layout)val102).Children.Add((IView)(object)val97);
		((BindableObject)val101).SetValue(Label.TextProperty, (object)"ProgressBar, Activity");
		((BindableObject)val101).SetValue(Label.FontSizeProperty, (object)11.0);
		val98.Key = "TextSecondaryLight";
		StaticResourceExtension val264 = new StaticResourceExtension
		{
			Key = "TextSecondaryLight"
		};
		XamlServiceProvider val265 = new XamlServiceProvider();
		Type? typeFromHandle33 = typeof(IProvideValueTarget);
		object[] array33 = new object[0 + 9];
		array33[0] = val100;
		array33[1] = val101;
		array33[2] = val102;
		array33[3] = val103;
		array33[4] = val104;
		array33[5] = val105;
		array33[6] = val129;
		array33[7] = val130;
		array33[8] = homePage;
		SimpleValueTargetProvider val266 = new SimpleValueTargetProvider(array33, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Light"), (INameScope[])(object)new NameScope[10] { val131, val131, val131, val131, val131, val131, val131, val131, val131, val131 }, false);
		object obj47 = (object)val266;
		val265.Add(typeFromHandle33, (object)val266);
		val265.Add(typeof(IReferenceProvider), obj47);
		val265.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(167, 36)));
		object light10 = val264.ProvideValue((IServiceProvider)val265);
		val100.Light = light10;
		val99.Key = "TextSecondaryDark";
		StaticResourceExtension val267 = new StaticResourceExtension
		{
			Key = "TextSecondaryDark"
		};
		XamlServiceProvider val268 = new XamlServiceProvider();
		Type? typeFromHandle34 = typeof(IProvideValueTarget);
		object[] array34 = new object[0 + 9];
		array34[0] = val100;
		array34[1] = val101;
		array34[2] = val102;
		array34[3] = val103;
		array34[4] = val104;
		array34[5] = val105;
		array34[6] = val129;
		array34[7] = val130;
		array34[8] = homePage;
		SimpleValueTargetProvider val269 = new SimpleValueTargetProvider(array34, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Dark"), (INameScope[])(object)new NameScope[10] { val131, val131, val131, val131, val131, val131, val131, val131, val131, val131 }, false);
		object obj48 = (object)val269;
		val268.Add(typeFromHandle34, (object)val269);
		val268.Add(typeof(IReferenceProvider), obj48);
		val268.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(167, 36)));
		object dark10 = val267.ProvideValue((IServiceProvider)val268);
		val100.Dark = dark10;
		XamlServiceProvider val270 = new XamlServiceProvider();
		val270.Add(typeof(IProvideValueTarget), (object)new ValueTargetProvider((object)val101, (object)Label.TextColorProperty));
		val270.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(167, 36)));
		BindingBase val271 = ((IMarkupExtension<BindingBase>)(object)val100).ProvideValue((IServiceProvider)val270);
		((BindableObject)val101).SetBinding(Label.TextColorProperty, val271);
		((Layout)val102).Children.Add((IView)(object)val101);
		((Layout)val103).Children.Add((IView)(object)val102);
		((BindableObject)val104).SetValue(ContentView.ContentProperty, (object)val103);
		((Layout)val105).Children.Add((IView)(object)val104);
		((Layout)val129).Children.Add((IView)(object)val105);
		((BindableObject)val109).SetValue(Label.TextProperty, (object)"Use the flyout menu to navigate between different control demos.");
		((BindableObject)val109).SetValue(Label.FontSizeProperty, (object)12.0);
		((BindableObject)val109).SetValue(Label.LineBreakModeProperty, (object)(LineBreakMode)1);
		((BindableObject)val109).SetValue(Label.HorizontalTextAlignmentProperty, (object)(TextAlignment)1);
		((BindableObject)val109).SetValue(View.MarginProperty, (object)new Thickness(0.0, 20.0, 0.0, 0.0));
		val106.Key = "TextSecondaryLight";
		StaticResourceExtension val272 = new StaticResourceExtension
		{
			Key = "TextSecondaryLight"
		};
		XamlServiceProvider val273 = new XamlServiceProvider();
		Type? typeFromHandle35 = typeof(IProvideValueTarget);
		object[] array35 = new object[0 + 5];
		array35[0] = val108;
		array35[1] = val109;
		array35[2] = val129;
		array35[3] = val130;
		array35[4] = homePage;
		SimpleValueTargetProvider val274 = new SimpleValueTargetProvider(array35, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Light"), (INameScope[])(object)new NameScope[6] { val131, val131, val131, val131, val131, val131 }, false);
		object obj49 = (object)val274;
		val273.Add(typeFromHandle35, (object)val274);
		val273.Add(typeof(IReferenceProvider), obj49);
		val273.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(179, 20)));
		object light11 = val272.ProvideValue((IServiceProvider)val273);
		val108.Light = light11;
		val107.Key = "TextSecondaryDark";
		StaticResourceExtension val275 = new StaticResourceExtension
		{
			Key = "TextSecondaryDark"
		};
		XamlServiceProvider val276 = new XamlServiceProvider();
		Type? typeFromHandle36 = typeof(IProvideValueTarget);
		object[] array36 = new object[0 + 5];
		array36[0] = val108;
		array36[1] = val109;
		array36[2] = val129;
		array36[3] = val130;
		array36[4] = homePage;
		SimpleValueTargetProvider val277 = new SimpleValueTargetProvider(array36, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Dark"), (INameScope[])(object)new NameScope[6] { val131, val131, val131, val131, val131, val131 }, false);
		object obj50 = (object)val277;
		val276.Add(typeFromHandle36, (object)val277);
		val276.Add(typeof(IReferenceProvider), obj50);
		val276.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(179, 20)));
		object dark11 = val275.ProvideValue((IServiceProvider)val276);
		val108.Dark = dark11;
		XamlServiceProvider val278 = new XamlServiceProvider();
		val278.Add(typeof(IProvideValueTarget), (object)new ValueTargetProvider((object)val109, (object)Label.TextColorProperty));
		val278.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(179, 20)));
		BindingBase val279 = ((IMarkupExtension<BindingBase>)(object)val108).ProvideValue((IServiceProvider)val278);
		((BindableObject)val109).SetBinding(Label.TextColorProperty, val279);
		((Layout)val129).Children.Add((IView)(object)val109);
		((BindableObject)val118).SetValue(StackBase.SpacingProperty, (object)10.0);
		((BindableObject)val118).SetValue(View.MarginProperty, (object)new Thickness(0.0, 20.0, 0.0, 0.0));
		((BindableObject)val113).SetValue(Label.TextProperty, (object)"Quick Actions");
		((BindableObject)val113).SetValue(Label.FontSizeProperty, (object)16.0);
		((BindableObject)val113).SetValue(Label.FontAttributesProperty, (object)(FontAttributes)1);
		((BindableObject)val113).SetValue(View.HorizontalOptionsProperty, (object)LayoutOptions.Center);
		val110.Key = "TextPrimaryLight";
		StaticResourceExtension val280 = new StaticResourceExtension
		{
			Key = "TextPrimaryLight"
		};
		XamlServiceProvider val281 = new XamlServiceProvider();
		Type? typeFromHandle37 = typeof(IProvideValueTarget);
		object[] array37 = new object[0 + 6];
		array37[0] = val112;
		array37[1] = val113;
		array37[2] = val118;
		array37[3] = val129;
		array37[4] = val130;
		array37[5] = homePage;
		SimpleValueTargetProvider val282 = new SimpleValueTargetProvider(array37, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Light"), (INameScope[])(object)new NameScope[7] { val131, val131, val131, val131, val131, val131, val131 }, false);
		object obj51 = (object)val282;
		val281.Add(typeFromHandle37, (object)val282);
		val281.Add(typeof(IReferenceProvider), obj51);
		val281.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(187, 24)));
		object light12 = val280.ProvideValue((IServiceProvider)val281);
		val112.Light = light12;
		val111.Key = "TextPrimaryDark";
		StaticResourceExtension val283 = new StaticResourceExtension
		{
			Key = "TextPrimaryDark"
		};
		XamlServiceProvider val284 = new XamlServiceProvider();
		Type? typeFromHandle38 = typeof(IProvideValueTarget);
		object[] array38 = new object[0 + 6];
		array38[0] = val112;
		array38[1] = val113;
		array38[2] = val118;
		array38[3] = val129;
		array38[4] = val130;
		array38[5] = homePage;
		SimpleValueTargetProvider val285 = new SimpleValueTargetProvider(array38, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Dark"), (INameScope[])(object)new NameScope[7] { val131, val131, val131, val131, val131, val131, val131 }, false);
		object obj52 = (object)val285;
		val284.Add(typeFromHandle38, (object)val285);
		val284.Add(typeof(IReferenceProvider), obj52);
		val284.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(187, 24)));
		object dark12 = val283.ProvideValue((IServiceProvider)val284);
		val112.Dark = dark12;
		XamlServiceProvider val286 = new XamlServiceProvider();
		val286.Add(typeof(IProvideValueTarget), (object)new ValueTargetProvider((object)val113, (object)Label.TextColorProperty));
		val286.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(187, 24)));
		BindingBase val287 = ((IMarkupExtension<BindingBase>)(object)val112).ProvideValue((IServiceProvider)val286);
		((BindableObject)val113).SetBinding(Label.TextColorProperty, val287);
		((Layout)val118).Children.Add((IView)(object)val113);
		((BindableObject)val117).SetValue(StackBase.SpacingProperty, (object)10.0);
		((BindableObject)val117).SetValue(View.HorizontalOptionsProperty, (object)LayoutOptions.Center);
		((BindableObject)val115).SetValue(Button.TextProperty, (object)"Try Buttons");
		val114.Key = "PrimaryButton";
		StaticResourceExtension val288 = new StaticResourceExtension
		{
			Key = "PrimaryButton"
		};
		XamlServiceProvider val289 = new XamlServiceProvider();
		Type? typeFromHandle39 = typeof(IProvideValueTarget);
		object[] array39 = new object[0 + 6];
		array39[0] = val115;
		array39[1] = val117;
		array39[2] = val118;
		array39[3] = val129;
		array39[4] = val130;
		array39[5] = homePage;
		SimpleValueTargetProvider val290 = new SimpleValueTargetProvider(array39, (object)VisualElement.StyleProperty, (INameScope[])(object)new NameScope[7] { val131, val131, val131, val131, val131, val131, val131 }, false);
		object obj53 = (object)val290;
		val289.Add(typeFromHandle39, (object)val290);
		val289.Add(typeof(IReferenceProvider), obj53);
		val289.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(191, 29)));
		object obj54 = val288.ProvideValue((IServiceProvider)val289);
		((BindableObject)val115).SetValue(VisualElement.StyleProperty, (obj54 == null || !typeof(BindingBase).IsAssignableFrom(obj54.GetType())) ? obj54 : obj54);
		val115.Clicked += homePage.OnButtonsDemoClicked;
		((Layout)val117).Children.Add((IView)(object)val115);
		((BindableObject)val116).SetValue(Button.TextProperty, (object)"Try Lists");
		((BindableObject)val116).SetValue(VisualElement.BackgroundColorProperty, (object)new Color(0.29803923f, 35f / 51f, 16f / 51f, 1f));
		((BindableObject)val116).SetValue(Button.TextColorProperty, (object)Colors.White);
		val116.Clicked += homePage.OnListsDemoClicked;
		((Layout)val117).Children.Add((IView)(object)val116);
		((Layout)val118).Children.Add((IView)(object)val117);
		((Layout)val129).Children.Add((IView)(object)val118);
		((BindableObject)val128).SetValue(Frame.CornerRadiusProperty, (object)8f);
		((BindableObject)val128).SetValue(Layout.PaddingProperty, (object)new Thickness(20.0));
		((BindableObject)val128).SetValue(View.MarginProperty, (object)new Thickness(0.0, 20.0, 0.0, 0.0));
		val119.Light = "#F3E5F5";
		val119.Dark = "#4A148C";
		XamlServiceProvider val291 = new XamlServiceProvider();
		val291.Add(typeof(IProvideValueTarget), (object)new ValueTargetProvider((object)val128, (object)VisualElement.BackgroundColorProperty));
		val291.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(204, 20)));
		BindingBase val292 = ((IMarkupExtension<BindingBase>)(object)val119).ProvideValue((IServiceProvider)val291);
		((BindableObject)val128).SetBinding(VisualElement.BackgroundColorProperty, val292);
		((BindableObject)val127).SetValue(StackBase.SpacingProperty, (object)15.0);
		((BindableObject)val121).SetValue(Label.TextProperty, (object)"Navigation Stack Demo");
		((BindableObject)val121).SetValue(Label.FontSizeProperty, (object)18.0);
		((BindableObject)val121).SetValue(Label.FontAttributesProperty, (object)(FontAttributes)1);
		val120.Light = "#9C27B0";
		val120.Dark = "#CE93D8";
		XamlServiceProvider val293 = new XamlServiceProvider();
		val293.Add(typeof(IProvideValueTarget), (object)new ValueTargetProvider((object)val121, (object)Label.TextColorProperty));
		val293.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(209, 28)));
		BindingBase val294 = ((IMarkupExtension<BindingBase>)(object)val120).ProvideValue((IServiceProvider)val293);
		((BindableObject)val121).SetBinding(Label.TextColorProperty, val294);
		((BindableObject)val121).SetValue(View.HorizontalOptionsProperty, (object)LayoutOptions.Center);
		((Layout)val127).Children.Add((IView)(object)val121);
		((BindableObject)val125).SetValue(Label.TextProperty, (object)"Demonstrate push/pop navigation");
		((BindableObject)val125).SetValue(Label.FontSizeProperty, (object)12.0);
		((BindableObject)val125).SetValue(Label.HorizontalTextAlignmentProperty, (object)(TextAlignment)1);
		val122.Key = "TextSecondaryLight";
		StaticResourceExtension val295 = new StaticResourceExtension
		{
			Key = "TextSecondaryLight"
		};
		XamlServiceProvider val296 = new XamlServiceProvider();
		Type? typeFromHandle40 = typeof(IProvideValueTarget);
		object[] array40 = new object[0 + 7];
		array40[0] = val124;
		array40[1] = val125;
		array40[2] = val127;
		array40[3] = val128;
		array40[4] = val129;
		array40[5] = val130;
		array40[6] = homePage;
		SimpleValueTargetProvider val297 = new SimpleValueTargetProvider(array40, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Light"), (INameScope[])(object)new NameScope[8] { val131, val131, val131, val131, val131, val131, val131, val131 }, false);
		object obj55 = (object)val297;
		val296.Add(typeFromHandle40, (object)val297);
		val296.Add(typeof(IReferenceProvider), obj55);
		val296.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(215, 28)));
		object light13 = val295.ProvideValue((IServiceProvider)val296);
		val124.Light = light13;
		val123.Key = "TextSecondaryDark";
		StaticResourceExtension val298 = new StaticResourceExtension
		{
			Key = "TextSecondaryDark"
		};
		XamlServiceProvider val299 = new XamlServiceProvider();
		Type? typeFromHandle41 = typeof(IProvideValueTarget);
		object[] array41 = new object[0 + 7];
		array41[0] = val124;
		array41[1] = val125;
		array41[2] = val127;
		array41[3] = val128;
		array41[4] = val129;
		array41[5] = val130;
		array41[6] = homePage;
		SimpleValueTargetProvider val300 = new SimpleValueTargetProvider(array41, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Dark"), (INameScope[])(object)new NameScope[8] { val131, val131, val131, val131, val131, val131, val131, val131 }, false);
		object obj56 = (object)val300;
		val299.Add(typeFromHandle41, (object)val300);
		val299.Add(typeof(IReferenceProvider), obj56);
		val299.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(215, 28)));
		object dark13 = val298.ProvideValue((IServiceProvider)val299);
		val124.Dark = dark13;
		XamlServiceProvider val301 = new XamlServiceProvider();
		val301.Add(typeof(IProvideValueTarget), (object)new ValueTargetProvider((object)val125, (object)Label.TextColorProperty));
		val301.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(215, 28)));
		BindingBase val302 = ((IMarkupExtension<BindingBase>)(object)val124).ProvideValue((IServiceProvider)val301);
		((BindableObject)val125).SetBinding(Label.TextColorProperty, val302);
		((Layout)val127).Children.Add((IView)(object)val125);
		((BindableObject)val126).SetValue(Button.TextProperty, (object)"Push Detail Page");
		((BindableObject)val126).SetValue(VisualElement.BackgroundColorProperty, (object)new Color(52f / 85f, 13f / 85f, 0.6901961f, 1f));
		((BindableObject)val126).SetValue(Button.TextColorProperty, (object)Colors.White);
		((BindableObject)val126).SetValue(View.HorizontalOptionsProperty, (object)LayoutOptions.Center);
		((BindableObject)val126).SetValue(Button.PaddingProperty, (object)new Thickness(30.0, 10.0));
		val126.Clicked += homePage.OnPushDetailClicked;
		((Layout)val127).Children.Add((IView)(object)val126);
		((BindableObject)val128).SetValue(ContentView.ContentProperty, (object)val127);
		((Layout)val129).Children.Add((IView)(object)val128);
		val130.Content = (View)(object)val129;
		((BindableObject)homePage).SetValue(ContentPage.ContentProperty, (object)val130);
	}
}
