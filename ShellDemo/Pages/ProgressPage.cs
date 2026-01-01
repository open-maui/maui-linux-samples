using System;
using System.CodeDom.Compiler;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Threading.Tasks;
using System.Xml;
using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Compatibility;
using Microsoft.Maui.Controls.Internals;
using Microsoft.Maui.Controls.Xaml;
using Microsoft.Maui.Controls.Xaml.Internals;
using Microsoft.Maui.Graphics;

namespace ShellDemo;

[XamlFilePath("Pages/ProgressPage.xaml")]
public class ProgressPage : ContentPage
{
	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private ProgressBar AnimatedProgress;

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private ProgressBar InteractiveProgress;

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private Label ProgressLabel;

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private Slider ProgressSlider;

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private ActivityIndicator ToggleIndicator;

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private Button LoadButton;

	public ProgressPage()
	{
		InitializeComponent();
	}

	private async void OnAnimateClicked(object? sender, EventArgs e)
	{
		AnimatedProgress.Progress = 0.0;
		await AnimatedProgress.ProgressTo(1.0, 2000u, Easing.CubicInOut);
	}

	private void OnSliderValueChanged(object? sender, ValueChangedEventArgs e)
	{
		InteractiveProgress.Progress = e.NewValue;
		ProgressLabel.Text = $"{(int)(e.NewValue * 100.0)}%";
	}

	private void OnToggleIndicatorClicked(object? sender, EventArgs e)
	{
		ToggleIndicator.IsRunning = !ToggleIndicator.IsRunning;
	}

	private async void OnSimulateLoadingClicked(object? sender, EventArgs e)
	{
		LoadButton.Text = "Loading...";
		((VisualElement)LoadButton).IsEnabled = false;
		await Task.Delay(2000);
		LoadButton.Text = "Simulate Loading";
		((VisualElement)LoadButton).IsEnabled = true;
	}

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	[MemberNotNull("AnimatedProgress")]
	[MemberNotNull("InteractiveProgress")]
	[MemberNotNull("ProgressLabel")]
	[MemberNotNull("ProgressSlider")]
	[MemberNotNull("ToggleIndicator")]
	[MemberNotNull("LoadButton")]
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
		//IL_0295: Unknown result type (might be due to invalid IL or missing references)
		//IL_0528: Unknown result type (might be due to invalid IL or missing references)
		//IL_052d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0538: Unknown result type (might be due to invalid IL or missing references)
		//IL_053d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0583: Unknown result type (might be due to invalid IL or missing references)
		//IL_0588: Unknown result type (might be due to invalid IL or missing references)
		//IL_058b: Expected O, but got Unknown
		//IL_0590: Expected O, but got Unknown
		//IL_0590: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ba: Expected O, but got Unknown
		//IL_05b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_05bf: Expected O, but got Unknown
		//IL_05c4: Expected O, but got Unknown
		//IL_05d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_05de: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_0634: Unknown result type (might be due to invalid IL or missing references)
		//IL_0639: Unknown result type (might be due to invalid IL or missing references)
		//IL_063c: Expected O, but got Unknown
		//IL_0641: Expected O, but got Unknown
		//IL_0641: Unknown result type (might be due to invalid IL or missing references)
		//IL_0653: Unknown result type (might be due to invalid IL or missing references)
		//IL_0661: Unknown result type (might be due to invalid IL or missing references)
		//IL_066b: Expected O, but got Unknown
		//IL_0666: Unknown result type (might be due to invalid IL or missing references)
		//IL_0670: Expected O, but got Unknown
		//IL_0675: Expected O, but got Unknown
		//IL_0680: Unknown result type (might be due to invalid IL or missing references)
		//IL_0685: Unknown result type (might be due to invalid IL or missing references)
		//IL_0697: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a1: Expected O, but got Unknown
		//IL_06a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_06af: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b9: Expected O, but got Unknown
		//IL_06b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_06be: Expected O, but got Unknown
		//IL_06c3: Expected O, but got Unknown
		//IL_06e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0754: Unknown result type (might be due to invalid IL or missing references)
		//IL_0759: Unknown result type (might be due to invalid IL or missing references)
		//IL_0764: Unknown result type (might be due to invalid IL or missing references)
		//IL_0769: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d6: Expected O, but got Unknown
		//IL_07db: Expected O, but got Unknown
		//IL_07db: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_07fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0806: Expected O, but got Unknown
		//IL_0801: Unknown result type (might be due to invalid IL or missing references)
		//IL_080b: Expected O, but got Unknown
		//IL_0810: Expected O, but got Unknown
		//IL_0827: Unknown result type (might be due to invalid IL or missing references)
		//IL_082c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0837: Unknown result type (might be due to invalid IL or missing references)
		//IL_083c: Unknown result type (might be due to invalid IL or missing references)
		//IL_08a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_08a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_08a9: Expected O, but got Unknown
		//IL_08ae: Expected O, but got Unknown
		//IL_08ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_08c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_08cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_08d9: Expected O, but got Unknown
		//IL_08d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_08de: Expected O, but got Unknown
		//IL_08e3: Expected O, but got Unknown
		//IL_08f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_08f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0907: Unknown result type (might be due to invalid IL or missing references)
		//IL_0911: Expected O, but got Unknown
		//IL_0911: Unknown result type (might be due to invalid IL or missing references)
		//IL_0920: Unknown result type (might be due to invalid IL or missing references)
		//IL_092a: Expected O, but got Unknown
		//IL_0925: Unknown result type (might be due to invalid IL or missing references)
		//IL_092f: Expected O, but got Unknown
		//IL_0934: Expected O, but got Unknown
		//IL_095e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0963: Unknown result type (might be due to invalid IL or missing references)
		//IL_096e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0973: Unknown result type (might be due to invalid IL or missing references)
		//IL_09bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_09c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_09c7: Expected O, but got Unknown
		//IL_09cc: Expected O, but got Unknown
		//IL_09cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_09de: Unknown result type (might be due to invalid IL or missing references)
		//IL_09ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_09f7: Expected O, but got Unknown
		//IL_09f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_09fc: Expected O, but got Unknown
		//IL_0a01: Expected O, but got Unknown
		//IL_0a59: Unknown result type (might be due to invalid IL or missing references)
		//IL_0acb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ad0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0adb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ae0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b59: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b5e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b61: Expected O, but got Unknown
		//IL_0b66: Expected O, but got Unknown
		//IL_0b66: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b78: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b87: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b91: Expected O, but got Unknown
		//IL_0b8c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b96: Expected O, but got Unknown
		//IL_0b9b: Expected O, but got Unknown
		//IL_0bb2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bb7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bc2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bc7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c40: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c45: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c48: Expected O, but got Unknown
		//IL_0c4d: Expected O, but got Unknown
		//IL_0c4d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c5f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c6e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c78: Expected O, but got Unknown
		//IL_0c73: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c7d: Expected O, but got Unknown
		//IL_0c82: Expected O, but got Unknown
		//IL_0c8f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c94: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ca6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cb0: Expected O, but got Unknown
		//IL_0cb0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cbf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cc9: Expected O, but got Unknown
		//IL_0cc4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cce: Expected O, but got Unknown
		//IL_0cd3: Expected O, but got Unknown
		//IL_0d0e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d13: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d1e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d23: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d9c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0da1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0da4: Expected O, but got Unknown
		//IL_0da9: Expected O, but got Unknown
		//IL_0da9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dbb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dca: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dd4: Expected O, but got Unknown
		//IL_0dcf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dd9: Expected O, but got Unknown
		//IL_0dde: Expected O, but got Unknown
		//IL_0df5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dfa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e05: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e0a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e83: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e88: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e8b: Expected O, but got Unknown
		//IL_0e90: Expected O, but got Unknown
		//IL_0e90: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ea2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eb1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ebb: Expected O, but got Unknown
		//IL_0eb6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ec0: Expected O, but got Unknown
		//IL_0ec5: Expected O, but got Unknown
		//IL_0ed2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ed7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ee9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ef3: Expected O, but got Unknown
		//IL_0ef3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f02: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f0c: Expected O, but got Unknown
		//IL_0f07: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f11: Expected O, but got Unknown
		//IL_0f16: Expected O, but got Unknown
		//IL_0f5a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f5f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f6a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f6f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fcf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fd4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fd7: Expected O, but got Unknown
		//IL_0fdc: Expected O, but got Unknown
		//IL_0fdc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fee: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ffd: Unknown result type (might be due to invalid IL or missing references)
		//IL_1007: Expected O, but got Unknown
		//IL_1002: Unknown result type (might be due to invalid IL or missing references)
		//IL_100c: Expected O, but got Unknown
		//IL_1011: Expected O, but got Unknown
		//IL_106e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1073: Unknown result type (might be due to invalid IL or missing references)
		//IL_107e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1083: Unknown result type (might be due to invalid IL or missing references)
		//IL_10fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_1101: Unknown result type (might be due to invalid IL or missing references)
		//IL_1104: Expected O, but got Unknown
		//IL_1109: Expected O, but got Unknown
		//IL_1109: Unknown result type (might be due to invalid IL or missing references)
		//IL_111b: Unknown result type (might be due to invalid IL or missing references)
		//IL_112a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1134: Expected O, but got Unknown
		//IL_112f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1139: Expected O, but got Unknown
		//IL_113e: Expected O, but got Unknown
		//IL_1155: Unknown result type (might be due to invalid IL or missing references)
		//IL_115a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1165: Unknown result type (might be due to invalid IL or missing references)
		//IL_116a: Unknown result type (might be due to invalid IL or missing references)
		//IL_11e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_11e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_11eb: Expected O, but got Unknown
		//IL_11f0: Expected O, but got Unknown
		//IL_11f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_1202: Unknown result type (might be due to invalid IL or missing references)
		//IL_1211: Unknown result type (might be due to invalid IL or missing references)
		//IL_121b: Expected O, but got Unknown
		//IL_1216: Unknown result type (might be due to invalid IL or missing references)
		//IL_1220: Expected O, but got Unknown
		//IL_1225: Expected O, but got Unknown
		//IL_1232: Unknown result type (might be due to invalid IL or missing references)
		//IL_1237: Unknown result type (might be due to invalid IL or missing references)
		//IL_1249: Unknown result type (might be due to invalid IL or missing references)
		//IL_1253: Expected O, but got Unknown
		//IL_1253: Unknown result type (might be due to invalid IL or missing references)
		//IL_1262: Unknown result type (might be due to invalid IL or missing references)
		//IL_126c: Expected O, but got Unknown
		//IL_1267: Unknown result type (might be due to invalid IL or missing references)
		//IL_1271: Expected O, but got Unknown
		//IL_1276: Expected O, but got Unknown
		//IL_12c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_12d3: Expected O, but got Unknown
		//IL_12df: Unknown result type (might be due to invalid IL or missing references)
		//IL_12e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_12ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_12f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_136d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1372: Unknown result type (might be due to invalid IL or missing references)
		//IL_1375: Expected O, but got Unknown
		//IL_137a: Expected O, but got Unknown
		//IL_137a: Unknown result type (might be due to invalid IL or missing references)
		//IL_138c: Unknown result type (might be due to invalid IL or missing references)
		//IL_139b: Unknown result type (might be due to invalid IL or missing references)
		//IL_13a5: Expected O, but got Unknown
		//IL_13a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_13aa: Expected O, but got Unknown
		//IL_13af: Expected O, but got Unknown
		//IL_13c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_13cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_13d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_13db: Unknown result type (might be due to invalid IL or missing references)
		//IL_1454: Unknown result type (might be due to invalid IL or missing references)
		//IL_1459: Unknown result type (might be due to invalid IL or missing references)
		//IL_145c: Expected O, but got Unknown
		//IL_1461: Expected O, but got Unknown
		//IL_1461: Unknown result type (might be due to invalid IL or missing references)
		//IL_1473: Unknown result type (might be due to invalid IL or missing references)
		//IL_1482: Unknown result type (might be due to invalid IL or missing references)
		//IL_148c: Expected O, but got Unknown
		//IL_1487: Unknown result type (might be due to invalid IL or missing references)
		//IL_1491: Expected O, but got Unknown
		//IL_1496: Expected O, but got Unknown
		//IL_14a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_14a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_14ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_14c4: Expected O, but got Unknown
		//IL_14c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_14d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_14dd: Expected O, but got Unknown
		//IL_14d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_14e2: Expected O, but got Unknown
		//IL_14e7: Expected O, but got Unknown
		//IL_1522: Unknown result type (might be due to invalid IL or missing references)
		//IL_1527: Unknown result type (might be due to invalid IL or missing references)
		//IL_1532: Unknown result type (might be due to invalid IL or missing references)
		//IL_1537: Unknown result type (might be due to invalid IL or missing references)
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
		//IL_1609: Unknown result type (might be due to invalid IL or missing references)
		//IL_160e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1619: Unknown result type (might be due to invalid IL or missing references)
		//IL_161e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1697: Unknown result type (might be due to invalid IL or missing references)
		//IL_169c: Unknown result type (might be due to invalid IL or missing references)
		//IL_169f: Expected O, but got Unknown
		//IL_16a4: Expected O, but got Unknown
		//IL_16a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_16b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_16c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_16cf: Expected O, but got Unknown
		//IL_16ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_16d4: Expected O, but got Unknown
		//IL_16d9: Expected O, but got Unknown
		//IL_16e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_16eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_16fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_1707: Expected O, but got Unknown
		//IL_1707: Unknown result type (might be due to invalid IL or missing references)
		//IL_1716: Unknown result type (might be due to invalid IL or missing references)
		//IL_1720: Expected O, but got Unknown
		//IL_171b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1725: Expected O, but got Unknown
		//IL_172a: Expected O, but got Unknown
		//IL_177d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1787: Expected O, but got Unknown
		//IL_1793: Unknown result type (might be due to invalid IL or missing references)
		//IL_1798: Unknown result type (might be due to invalid IL or missing references)
		//IL_17a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_17a8: Unknown result type (might be due to invalid IL or missing references)
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
		//IL_1908: Unknown result type (might be due to invalid IL or missing references)
		//IL_190d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1910: Expected O, but got Unknown
		//IL_1915: Expected O, but got Unknown
		//IL_1915: Unknown result type (might be due to invalid IL or missing references)
		//IL_1927: Unknown result type (might be due to invalid IL or missing references)
		//IL_1936: Unknown result type (might be due to invalid IL or missing references)
		//IL_1940: Expected O, but got Unknown
		//IL_193b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1945: Expected O, but got Unknown
		//IL_194a: Expected O, but got Unknown
		//IL_1957: Unknown result type (might be due to invalid IL or missing references)
		//IL_195c: Unknown result type (might be due to invalid IL or missing references)
		//IL_196e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1978: Expected O, but got Unknown
		//IL_1978: Unknown result type (might be due to invalid IL or missing references)
		//IL_1987: Unknown result type (might be due to invalid IL or missing references)
		//IL_1991: Expected O, but got Unknown
		//IL_198c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1996: Expected O, but got Unknown
		//IL_199b: Expected O, but got Unknown
		//IL_19ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_19ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_19fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_19ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a5f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a64: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a67: Expected O, but got Unknown
		//IL_1a6c: Expected O, but got Unknown
		//IL_1a6c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a7e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a8d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a97: Expected O, but got Unknown
		//IL_1a92: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a9c: Expected O, but got Unknown
		//IL_1aa1: Expected O, but got Unknown
		//IL_1b09: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b0e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b19: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b1e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b6a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b6f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b72: Expected O, but got Unknown
		//IL_1b77: Expected O, but got Unknown
		//IL_1b77: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b89: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b98: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ba2: Expected O, but got Unknown
		//IL_1b9d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ba7: Expected O, but got Unknown
		//IL_1bac: Expected O, but got Unknown
		//IL_1c04: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c76: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c7b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c86: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c8b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d04: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d09: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d0c: Expected O, but got Unknown
		//IL_1d11: Expected O, but got Unknown
		//IL_1d11: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d23: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d32: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d3c: Expected O, but got Unknown
		//IL_1d37: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d41: Expected O, but got Unknown
		//IL_1d46: Expected O, but got Unknown
		//IL_1d5d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d62: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d6d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d72: Unknown result type (might be due to invalid IL or missing references)
		//IL_1deb: Unknown result type (might be due to invalid IL or missing references)
		//IL_1df0: Unknown result type (might be due to invalid IL or missing references)
		//IL_1df3: Expected O, but got Unknown
		//IL_1df8: Expected O, but got Unknown
		//IL_1df8: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e0a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e19: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e23: Expected O, but got Unknown
		//IL_1e1e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e28: Expected O, but got Unknown
		//IL_1e2d: Expected O, but got Unknown
		//IL_1e3a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e3f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e51: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e5b: Expected O, but got Unknown
		//IL_1e5b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e6a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e74: Expected O, but got Unknown
		//IL_1e6f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e79: Expected O, but got Unknown
		//IL_1e7e: Expected O, but got Unknown
		//IL_1ec2: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ec7: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ed2: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ed7: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f37: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f3c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f3f: Expected O, but got Unknown
		//IL_1f44: Expected O, but got Unknown
		//IL_1f44: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f56: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f65: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f6f: Expected O, but got Unknown
		//IL_1f6a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f74: Expected O, but got Unknown
		//IL_1f79: Expected O, but got Unknown
		//IL_1fb7: Unknown result type (might be due to invalid IL or missing references)
		//IL_1fbc: Unknown result type (might be due to invalid IL or missing references)
		//IL_1fc7: Unknown result type (might be due to invalid IL or missing references)
		//IL_1fcc: Unknown result type (might be due to invalid IL or missing references)
		//IL_2045: Unknown result type (might be due to invalid IL or missing references)
		//IL_204a: Unknown result type (might be due to invalid IL or missing references)
		//IL_204d: Expected O, but got Unknown
		//IL_2052: Expected O, but got Unknown
		//IL_2052: Unknown result type (might be due to invalid IL or missing references)
		//IL_2064: Unknown result type (might be due to invalid IL or missing references)
		//IL_2073: Unknown result type (might be due to invalid IL or missing references)
		//IL_207d: Expected O, but got Unknown
		//IL_2078: Unknown result type (might be due to invalid IL or missing references)
		//IL_2082: Expected O, but got Unknown
		//IL_2087: Expected O, but got Unknown
		//IL_209e: Unknown result type (might be due to invalid IL or missing references)
		//IL_20a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_20ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_20b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_212c: Unknown result type (might be due to invalid IL or missing references)
		//IL_2131: Unknown result type (might be due to invalid IL or missing references)
		//IL_2134: Expected O, but got Unknown
		//IL_2139: Expected O, but got Unknown
		//IL_2139: Unknown result type (might be due to invalid IL or missing references)
		//IL_214b: Unknown result type (might be due to invalid IL or missing references)
		//IL_215a: Unknown result type (might be due to invalid IL or missing references)
		//IL_2164: Expected O, but got Unknown
		//IL_215f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2169: Expected O, but got Unknown
		//IL_216e: Expected O, but got Unknown
		//IL_217b: Unknown result type (might be due to invalid IL or missing references)
		//IL_2180: Unknown result type (might be due to invalid IL or missing references)
		//IL_2192: Unknown result type (might be due to invalid IL or missing references)
		//IL_219c: Expected O, but got Unknown
		//IL_219c: Unknown result type (might be due to invalid IL or missing references)
		//IL_21ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_21b5: Expected O, but got Unknown
		//IL_21b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_21ba: Expected O, but got Unknown
		//IL_21bf: Expected O, but got Unknown
		//IL_21f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_2210: Unknown result type (might be due to invalid IL or missing references)
		//IL_2215: Unknown result type (might be due to invalid IL or missing references)
		//IL_2220: Unknown result type (might be due to invalid IL or missing references)
		//IL_2225: Unknown result type (might be due to invalid IL or missing references)
		//IL_229e: Unknown result type (might be due to invalid IL or missing references)
		//IL_22a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_22a6: Expected O, but got Unknown
		//IL_22ab: Expected O, but got Unknown
		//IL_22ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_22bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_22cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_22d6: Expected O, but got Unknown
		//IL_22d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_22db: Expected O, but got Unknown
		//IL_22e0: Expected O, but got Unknown
		//IL_22f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_22fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_2307: Unknown result type (might be due to invalid IL or missing references)
		//IL_230c: Unknown result type (might be due to invalid IL or missing references)
		//IL_2385: Unknown result type (might be due to invalid IL or missing references)
		//IL_238a: Unknown result type (might be due to invalid IL or missing references)
		//IL_238d: Expected O, but got Unknown
		//IL_2392: Expected O, but got Unknown
		//IL_2392: Unknown result type (might be due to invalid IL or missing references)
		//IL_23a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_23b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_23bd: Expected O, but got Unknown
		//IL_23b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_23c2: Expected O, but got Unknown
		//IL_23c7: Expected O, but got Unknown
		//IL_23d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_23d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_23eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_23f5: Expected O, but got Unknown
		//IL_23f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_2404: Unknown result type (might be due to invalid IL or missing references)
		//IL_240e: Expected O, but got Unknown
		//IL_2409: Unknown result type (might be due to invalid IL or missing references)
		//IL_2413: Expected O, but got Unknown
		//IL_2418: Expected O, but got Unknown
		//IL_24ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_24d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_24de: Unknown result type (might be due to invalid IL or missing references)
		//IL_24e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_252f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2534: Unknown result type (might be due to invalid IL or missing references)
		//IL_2537: Expected O, but got Unknown
		//IL_253c: Expected O, but got Unknown
		//IL_253c: Unknown result type (might be due to invalid IL or missing references)
		//IL_254e: Unknown result type (might be due to invalid IL or missing references)
		//IL_255d: Unknown result type (might be due to invalid IL or missing references)
		//IL_2567: Expected O, but got Unknown
		//IL_2562: Unknown result type (might be due to invalid IL or missing references)
		//IL_256c: Expected O, but got Unknown
		//IL_2571: Expected O, but got Unknown
		//IL_25c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_263b: Unknown result type (might be due to invalid IL or missing references)
		//IL_2640: Unknown result type (might be due to invalid IL or missing references)
		//IL_264b: Unknown result type (might be due to invalid IL or missing references)
		//IL_2650: Unknown result type (might be due to invalid IL or missing references)
		//IL_26c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_26ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_26d1: Expected O, but got Unknown
		//IL_26d6: Expected O, but got Unknown
		//IL_26d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_26e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_26f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_2701: Expected O, but got Unknown
		//IL_26fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_2706: Expected O, but got Unknown
		//IL_270b: Expected O, but got Unknown
		//IL_2722: Unknown result type (might be due to invalid IL or missing references)
		//IL_2727: Unknown result type (might be due to invalid IL or missing references)
		//IL_2732: Unknown result type (might be due to invalid IL or missing references)
		//IL_2737: Unknown result type (might be due to invalid IL or missing references)
		//IL_27b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_27b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_27b8: Expected O, but got Unknown
		//IL_27bd: Expected O, but got Unknown
		//IL_27bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_27cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_27de: Unknown result type (might be due to invalid IL or missing references)
		//IL_27e8: Expected O, but got Unknown
		//IL_27e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_27ed: Expected O, but got Unknown
		//IL_27f2: Expected O, but got Unknown
		//IL_27ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_2804: Unknown result type (might be due to invalid IL or missing references)
		//IL_2816: Unknown result type (might be due to invalid IL or missing references)
		//IL_2820: Expected O, but got Unknown
		//IL_2820: Unknown result type (might be due to invalid IL or missing references)
		//IL_282f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2839: Expected O, but got Unknown
		//IL_2834: Unknown result type (might be due to invalid IL or missing references)
		//IL_283e: Expected O, but got Unknown
		//IL_2843: Expected O, but got Unknown
		//IL_2882: Unknown result type (might be due to invalid IL or missing references)
		//IL_28b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_28df: Unknown result type (might be due to invalid IL or missing references)
		//IL_28e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_28ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_28f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_2969: Unknown result type (might be due to invalid IL or missing references)
		//IL_296e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2971: Expected O, but got Unknown
		//IL_2976: Expected O, but got Unknown
		//IL_2976: Unknown result type (might be due to invalid IL or missing references)
		//IL_2988: Unknown result type (might be due to invalid IL or missing references)
		//IL_2997: Unknown result type (might be due to invalid IL or missing references)
		//IL_29a1: Expected O, but got Unknown
		//IL_299c: Unknown result type (might be due to invalid IL or missing references)
		//IL_29a6: Expected O, but got Unknown
		//IL_29ab: Expected O, but got Unknown
		//IL_2a1d: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a38: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a3d: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a48: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a4d: Unknown result type (might be due to invalid IL or missing references)
		//IL_2add: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ae2: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ae5: Expected O, but got Unknown
		//IL_2aea: Expected O, but got Unknown
		//IL_2aea: Unknown result type (might be due to invalid IL or missing references)
		//IL_2afc: Unknown result type (might be due to invalid IL or missing references)
		//IL_2b0b: Unknown result type (might be due to invalid IL or missing references)
		//IL_2b15: Expected O, but got Unknown
		//IL_2b10: Unknown result type (might be due to invalid IL or missing references)
		//IL_2b1a: Expected O, but got Unknown
		//IL_2b1f: Expected O, but got Unknown
		//IL_2b36: Unknown result type (might be due to invalid IL or missing references)
		//IL_2b3b: Unknown result type (might be due to invalid IL or missing references)
		//IL_2b46: Unknown result type (might be due to invalid IL or missing references)
		//IL_2b4b: Unknown result type (might be due to invalid IL or missing references)
		//IL_2bdb: Unknown result type (might be due to invalid IL or missing references)
		//IL_2be0: Unknown result type (might be due to invalid IL or missing references)
		//IL_2be3: Expected O, but got Unknown
		//IL_2be8: Expected O, but got Unknown
		//IL_2be8: Unknown result type (might be due to invalid IL or missing references)
		//IL_2bfa: Unknown result type (might be due to invalid IL or missing references)
		//IL_2c09: Unknown result type (might be due to invalid IL or missing references)
		//IL_2c13: Expected O, but got Unknown
		//IL_2c0e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2c18: Expected O, but got Unknown
		//IL_2c1d: Expected O, but got Unknown
		//IL_2c2a: Unknown result type (might be due to invalid IL or missing references)
		//IL_2c2f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2c41: Unknown result type (might be due to invalid IL or missing references)
		//IL_2c4b: Expected O, but got Unknown
		//IL_2c4b: Unknown result type (might be due to invalid IL or missing references)
		//IL_2c5a: Unknown result type (might be due to invalid IL or missing references)
		//IL_2c64: Expected O, but got Unknown
		//IL_2c5f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2c69: Expected O, but got Unknown
		//IL_2c6e: Expected O, but got Unknown
		//IL_2cbb: Unknown result type (might be due to invalid IL or missing references)
		//IL_2cf7: Unknown result type (might be due to invalid IL or missing references)
		//IL_2d01: Expected O, but got Unknown
		//IL_2d41: Unknown result type (might be due to invalid IL or missing references)
		//IL_2d5c: Unknown result type (might be due to invalid IL or missing references)
		//IL_2d61: Unknown result type (might be due to invalid IL or missing references)
		//IL_2d6c: Unknown result type (might be due to invalid IL or missing references)
		//IL_2d71: Unknown result type (might be due to invalid IL or missing references)
		//IL_2e01: Unknown result type (might be due to invalid IL or missing references)
		//IL_2e06: Unknown result type (might be due to invalid IL or missing references)
		//IL_2e09: Expected O, but got Unknown
		//IL_2e0e: Expected O, but got Unknown
		//IL_2e0e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2e20: Unknown result type (might be due to invalid IL or missing references)
		//IL_2e2f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2e39: Expected O, but got Unknown
		//IL_2e34: Unknown result type (might be due to invalid IL or missing references)
		//IL_2e3e: Expected O, but got Unknown
		//IL_2e43: Expected O, but got Unknown
		//IL_2e5a: Unknown result type (might be due to invalid IL or missing references)
		//IL_2e5f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2e6a: Unknown result type (might be due to invalid IL or missing references)
		//IL_2e6f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2eff: Unknown result type (might be due to invalid IL or missing references)
		//IL_2f04: Unknown result type (might be due to invalid IL or missing references)
		//IL_2f07: Expected O, but got Unknown
		//IL_2f0c: Expected O, but got Unknown
		//IL_2f0c: Unknown result type (might be due to invalid IL or missing references)
		//IL_2f1e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2f2d: Unknown result type (might be due to invalid IL or missing references)
		//IL_2f37: Expected O, but got Unknown
		//IL_2f32: Unknown result type (might be due to invalid IL or missing references)
		//IL_2f3c: Expected O, but got Unknown
		//IL_2f41: Expected O, but got Unknown
		//IL_2f4e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2f53: Unknown result type (might be due to invalid IL or missing references)
		//IL_2f65: Unknown result type (might be due to invalid IL or missing references)
		//IL_2f6f: Expected O, but got Unknown
		//IL_2f6f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2f7e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2f88: Expected O, but got Unknown
		//IL_2f83: Unknown result type (might be due to invalid IL or missing references)
		//IL_2f8d: Expected O, but got Unknown
		//IL_2f92: Expected O, but got Unknown
		//IL_2fdf: Unknown result type (might be due to invalid IL or missing references)
		//IL_301b: Unknown result type (might be due to invalid IL or missing references)
		//IL_3025: Expected O, but got Unknown
		//IL_3065: Unknown result type (might be due to invalid IL or missing references)
		//IL_3080: Unknown result type (might be due to invalid IL or missing references)
		//IL_3085: Unknown result type (might be due to invalid IL or missing references)
		//IL_3090: Unknown result type (might be due to invalid IL or missing references)
		//IL_3095: Unknown result type (might be due to invalid IL or missing references)
		//IL_3125: Unknown result type (might be due to invalid IL or missing references)
		//IL_312a: Unknown result type (might be due to invalid IL or missing references)
		//IL_312d: Expected O, but got Unknown
		//IL_3132: Expected O, but got Unknown
		//IL_3132: Unknown result type (might be due to invalid IL or missing references)
		//IL_3144: Unknown result type (might be due to invalid IL or missing references)
		//IL_3153: Unknown result type (might be due to invalid IL or missing references)
		//IL_315d: Expected O, but got Unknown
		//IL_3158: Unknown result type (might be due to invalid IL or missing references)
		//IL_3162: Expected O, but got Unknown
		//IL_3167: Expected O, but got Unknown
		//IL_317e: Unknown result type (might be due to invalid IL or missing references)
		//IL_3183: Unknown result type (might be due to invalid IL or missing references)
		//IL_318e: Unknown result type (might be due to invalid IL or missing references)
		//IL_3193: Unknown result type (might be due to invalid IL or missing references)
		//IL_3223: Unknown result type (might be due to invalid IL or missing references)
		//IL_3228: Unknown result type (might be due to invalid IL or missing references)
		//IL_322b: Expected O, but got Unknown
		//IL_3230: Expected O, but got Unknown
		//IL_3230: Unknown result type (might be due to invalid IL or missing references)
		//IL_3242: Unknown result type (might be due to invalid IL or missing references)
		//IL_3251: Unknown result type (might be due to invalid IL or missing references)
		//IL_325b: Expected O, but got Unknown
		//IL_3256: Unknown result type (might be due to invalid IL or missing references)
		//IL_3260: Expected O, but got Unknown
		//IL_3265: Expected O, but got Unknown
		//IL_3272: Unknown result type (might be due to invalid IL or missing references)
		//IL_3277: Unknown result type (might be due to invalid IL or missing references)
		//IL_3289: Unknown result type (might be due to invalid IL or missing references)
		//IL_3293: Expected O, but got Unknown
		//IL_3293: Unknown result type (might be due to invalid IL or missing references)
		//IL_32a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_32ac: Expected O, but got Unknown
		//IL_32a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_32b1: Expected O, but got Unknown
		//IL_32b6: Expected O, but got Unknown
		//IL_3311: Unknown result type (might be due to invalid IL or missing references)
		//IL_334d: Unknown result type (might be due to invalid IL or missing references)
		//IL_3357: Expected O, but got Unknown
		//IL_33e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_3411: Unknown result type (might be due to invalid IL or missing references)
		//IL_3416: Unknown result type (might be due to invalid IL or missing references)
		//IL_3428: Unknown result type (might be due to invalid IL or missing references)
		//IL_3432: Expected O, but got Unknown
		//IL_3432: Unknown result type (might be due to invalid IL or missing references)
		//IL_3441: Unknown result type (might be due to invalid IL or missing references)
		//IL_344b: Expected O, but got Unknown
		//IL_3446: Unknown result type (might be due to invalid IL or missing references)
		//IL_3450: Expected O, but got Unknown
		//IL_3455: Expected O, but got Unknown
		//IL_34d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_34db: Unknown result type (might be due to invalid IL or missing references)
		//IL_34ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_34f7: Expected O, but got Unknown
		//IL_34f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_3506: Unknown result type (might be due to invalid IL or missing references)
		//IL_3510: Expected O, but got Unknown
		//IL_350b: Unknown result type (might be due to invalid IL or missing references)
		//IL_3515: Expected O, but got Unknown
		//IL_351a: Expected O, but got Unknown
		//IL_3578: Unknown result type (might be due to invalid IL or missing references)
		//IL_3582: Expected O, but got Unknown
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
		StaticResourceExtension val17 = new StaticResourceExtension();
		ProgressBar val18 = new ProgressBar();
		StaticResourceExtension val19 = new StaticResourceExtension();
		StaticResourceExtension val20 = new StaticResourceExtension();
		AppThemeBindingExtension val21 = new AppThemeBindingExtension();
		Label val22 = new Label();
		StaticResourceExtension val23 = new StaticResourceExtension();
		StaticResourceExtension val24 = new StaticResourceExtension();
		AppThemeBindingExtension val25 = new AppThemeBindingExtension();
		ProgressBar val26 = new ProgressBar();
		StaticResourceExtension val27 = new StaticResourceExtension();
		StaticResourceExtension val28 = new StaticResourceExtension();
		AppThemeBindingExtension val29 = new AppThemeBindingExtension();
		Label val30 = new Label();
		StaticResourceExtension val31 = new StaticResourceExtension();
		StaticResourceExtension val32 = new StaticResourceExtension();
		AppThemeBindingExtension val33 = new AppThemeBindingExtension();
		ProgressBar val34 = new ProgressBar();
		StaticResourceExtension val35 = new StaticResourceExtension();
		Button val36 = new Button();
		VerticalStackLayout val37 = new VerticalStackLayout();
		Frame val38 = new Frame();
		StaticResourceExtension val39 = new StaticResourceExtension();
		StaticResourceExtension val40 = new StaticResourceExtension();
		StaticResourceExtension val41 = new StaticResourceExtension();
		AppThemeBindingExtension val42 = new AppThemeBindingExtension();
		Label val43 = new Label();
		StaticResourceExtension val44 = new StaticResourceExtension();
		StaticResourceExtension val45 = new StaticResourceExtension();
		StaticResourceExtension val46 = new StaticResourceExtension();
		AppThemeBindingExtension val47 = new AppThemeBindingExtension();
		ProgressBar val48 = new ProgressBar();
		StaticResourceExtension val49 = new StaticResourceExtension();
		StaticResourceExtension val50 = new StaticResourceExtension();
		AppThemeBindingExtension val51 = new AppThemeBindingExtension();
		Label val52 = new Label();
		Slider val53 = new Slider();
		VerticalStackLayout val54 = new VerticalStackLayout();
		Frame val55 = new Frame();
		StaticResourceExtension val56 = new StaticResourceExtension();
		StaticResourceExtension val57 = new StaticResourceExtension();
		StaticResourceExtension val58 = new StaticResourceExtension();
		AppThemeBindingExtension val59 = new AppThemeBindingExtension();
		Label val60 = new Label();
		StaticResourceExtension val61 = new StaticResourceExtension();
		ActivityIndicator val62 = new ActivityIndicator();
		StaticResourceExtension val63 = new StaticResourceExtension();
		StaticResourceExtension val64 = new StaticResourceExtension();
		AppThemeBindingExtension val65 = new AppThemeBindingExtension();
		Label val66 = new Label();
		VerticalStackLayout val67 = new VerticalStackLayout();
		ActivityIndicator val68 = new ActivityIndicator();
		StaticResourceExtension val69 = new StaticResourceExtension();
		StaticResourceExtension val70 = new StaticResourceExtension();
		AppThemeBindingExtension val71 = new AppThemeBindingExtension();
		Label val72 = new Label();
		VerticalStackLayout val73 = new VerticalStackLayout();
		ActivityIndicator val74 = new ActivityIndicator();
		StaticResourceExtension val75 = new StaticResourceExtension();
		StaticResourceExtension val76 = new StaticResourceExtension();
		AppThemeBindingExtension val77 = new AppThemeBindingExtension();
		Label val78 = new Label();
		VerticalStackLayout val79 = new VerticalStackLayout();
		HorizontalStackLayout val80 = new HorizontalStackLayout();
		ActivityIndicator val81 = new ActivityIndicator();
		Button val82 = new Button();
		HorizontalStackLayout val83 = new HorizontalStackLayout();
		VerticalStackLayout val84 = new VerticalStackLayout();
		Frame val85 = new Frame();
		AppThemeBindingExtension val86 = new AppThemeBindingExtension();
		AppThemeBindingExtension val87 = new AppThemeBindingExtension();
		Label val88 = new Label();
		Button val89 = new Button();
		VerticalStackLayout val90 = new VerticalStackLayout();
		Frame val91 = new Frame();
		VerticalStackLayout val92 = new VerticalStackLayout();
		ScrollView val93 = new ScrollView();
		ProgressPage progressPage;
		NameScope val94 = (NameScope)(((object)NameScope.GetNameScope((BindableObject)(object)(progressPage = this))) ?? ((object)new NameScope()));
		NameScope.SetNameScope((BindableObject)(object)progressPage, (INameScope)(object)val94);
		((Element)val93).transientNamescope = (INameScope)(object)val94;
		((Element)val92).transientNamescope = (INameScope)(object)val94;
		((Element)val7).transientNamescope = (INameScope)(object)val94;
		((Element)val38).transientNamescope = (INameScope)(object)val94;
		((Element)val37).transientNamescope = (INameScope)(object)val94;
		((Element)val12).transientNamescope = (INameScope)(object)val94;
		((Element)val16).transientNamescope = (INameScope)(object)val94;
		((Element)val18).transientNamescope = (INameScope)(object)val94;
		((Element)val22).transientNamescope = (INameScope)(object)val94;
		((Element)val26).transientNamescope = (INameScope)(object)val94;
		((Element)val30).transientNamescope = (INameScope)(object)val94;
		((Element)val34).transientNamescope = (INameScope)(object)val94;
		((INameScope)val94).RegisterName("AnimatedProgress", (object)val34);
		if (((Element)val34).StyleId == null)
		{
			((Element)val34).StyleId = "AnimatedProgress";
		}
		((Element)val36).transientNamescope = (INameScope)(object)val94;
		((Element)val55).transientNamescope = (INameScope)(object)val94;
		((Element)val54).transientNamescope = (INameScope)(object)val94;
		((Element)val43).transientNamescope = (INameScope)(object)val94;
		((Element)val48).transientNamescope = (INameScope)(object)val94;
		((INameScope)val94).RegisterName("InteractiveProgress", (object)val48);
		if (((Element)val48).StyleId == null)
		{
			((Element)val48).StyleId = "InteractiveProgress";
		}
		((Element)val52).transientNamescope = (INameScope)(object)val94;
		((INameScope)val94).RegisterName("ProgressLabel", (object)val52);
		if (((Element)val52).StyleId == null)
		{
			((Element)val52).StyleId = "ProgressLabel";
		}
		((Element)val53).transientNamescope = (INameScope)(object)val94;
		((INameScope)val94).RegisterName("ProgressSlider", (object)val53);
		if (((Element)val53).StyleId == null)
		{
			((Element)val53).StyleId = "ProgressSlider";
		}
		((Element)val85).transientNamescope = (INameScope)(object)val94;
		((Element)val84).transientNamescope = (INameScope)(object)val94;
		((Element)val60).transientNamescope = (INameScope)(object)val94;
		((Element)val80).transientNamescope = (INameScope)(object)val94;
		((Element)val67).transientNamescope = (INameScope)(object)val94;
		((Element)val62).transientNamescope = (INameScope)(object)val94;
		((Element)val66).transientNamescope = (INameScope)(object)val94;
		((Element)val73).transientNamescope = (INameScope)(object)val94;
		((Element)val68).transientNamescope = (INameScope)(object)val94;
		((Element)val72).transientNamescope = (INameScope)(object)val94;
		((Element)val79).transientNamescope = (INameScope)(object)val94;
		((Element)val74).transientNamescope = (INameScope)(object)val94;
		((Element)val78).transientNamescope = (INameScope)(object)val94;
		((Element)val83).transientNamescope = (INameScope)(object)val94;
		((Element)val81).transientNamescope = (INameScope)(object)val94;
		((INameScope)val94).RegisterName("ToggleIndicator", (object)val81);
		if (((Element)val81).StyleId == null)
		{
			((Element)val81).StyleId = "ToggleIndicator";
		}
		((Element)val82).transientNamescope = (INameScope)(object)val94;
		((Element)val91).transientNamescope = (INameScope)(object)val94;
		((Element)val90).transientNamescope = (INameScope)(object)val94;
		((Element)val88).transientNamescope = (INameScope)(object)val94;
		((Element)val89).transientNamescope = (INameScope)(object)val94;
		((INameScope)val94).RegisterName("LoadButton", (object)val89);
		if (((Element)val89).StyleId == null)
		{
			((Element)val89).StyleId = "LoadButton";
		}
		AnimatedProgress = val34;
		InteractiveProgress = val48;
		ProgressLabel = val52;
		ProgressSlider = val53;
		ToggleIndicator = val81;
		LoadButton = val89;
		((BindableObject)progressPage).SetValue(Page.TitleProperty, (object)"Progress");
		val.Key = "PageBackgroundLight";
		StaticResourceExtension val95 = new StaticResourceExtension
		{
			Key = "PageBackgroundLight"
		};
		XamlServiceProvider val96 = new XamlServiceProvider();
		Type? typeFromHandle = typeof(IProvideValueTarget);
		object[] array = new object[0 + 2];
		array[0] = val3;
		array[1] = progressPage;
		SimpleValueTargetProvider val97 = new SimpleValueTargetProvider(array, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Light"), (INameScope[])(object)new NameScope[3] { val94, val94, val94 }, false);
		object obj = (object)val97;
		val96.Add(typeFromHandle, (object)val97);
		val96.Add(typeof(IReferenceProvider), obj);
		val96.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(6, 14)));
		object light = val95.ProvideValue((IServiceProvider)val96);
		val3.Light = light;
		val2.Key = "PageBackgroundDark";
		StaticResourceExtension val98 = new StaticResourceExtension
		{
			Key = "PageBackgroundDark"
		};
		XamlServiceProvider val99 = new XamlServiceProvider();
		Type? typeFromHandle2 = typeof(IProvideValueTarget);
		object[] array2 = new object[0 + 2];
		array2[0] = val3;
		array2[1] = progressPage;
		SimpleValueTargetProvider val100 = new SimpleValueTargetProvider(array2, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Dark"), (INameScope[])(object)new NameScope[3] { val94, val94, val94 }, false);
		object obj2 = (object)val100;
		val99.Add(typeFromHandle2, (object)val100);
		val99.Add(typeof(IReferenceProvider), obj2);
		val99.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(6, 14)));
		object dark = val98.ProvideValue((IServiceProvider)val99);
		val3.Dark = dark;
		XamlServiceProvider val101 = new XamlServiceProvider();
		val101.Add(typeof(IProvideValueTarget), (object)new ValueTargetProvider((object)progressPage, (object)VisualElement.BackgroundColorProperty));
		val101.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(6, 14)));
		BindingBase val102 = ((IMarkupExtension<BindingBase>)(object)val3).ProvideValue((IServiceProvider)val101);
		((BindableObject)progressPage).SetBinding(VisualElement.BackgroundColorProperty, val102);
		((BindableObject)val92).SetValue(Layout.PaddingProperty, (object)new Thickness(20.0));
		((BindableObject)val92).SetValue(StackBase.SpacingProperty, (object)20.0);
		((BindableObject)val7).SetValue(Label.TextProperty, (object)"Progress Controls");
		((BindableObject)val7).SetValue(Label.FontSizeProperty, (object)24.0);
		((BindableObject)val7).SetValue(Label.FontAttributesProperty, (object)(FontAttributes)1);
		val4.Key = "TextPrimaryLight";
		StaticResourceExtension val103 = new StaticResourceExtension
		{
			Key = "TextPrimaryLight"
		};
		XamlServiceProvider val104 = new XamlServiceProvider();
		Type? typeFromHandle3 = typeof(IProvideValueTarget);
		object[] array3 = new object[0 + 5];
		array3[0] = val6;
		array3[1] = val7;
		array3[2] = val92;
		array3[3] = val93;
		array3[4] = progressPage;
		SimpleValueTargetProvider val105 = new SimpleValueTargetProvider(array3, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Light"), (INameScope[])(object)new NameScope[6] { val94, val94, val94, val94, val94, val94 }, false);
		object obj3 = (object)val105;
		val104.Add(typeFromHandle3, (object)val105);
		val104.Add(typeof(IReferenceProvider), obj3);
		val104.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(11, 20)));
		object light2 = val103.ProvideValue((IServiceProvider)val104);
		val6.Light = light2;
		val5.Key = "TextPrimaryDark";
		StaticResourceExtension val106 = new StaticResourceExtension
		{
			Key = "TextPrimaryDark"
		};
		XamlServiceProvider val107 = new XamlServiceProvider();
		Type? typeFromHandle4 = typeof(IProvideValueTarget);
		object[] array4 = new object[0 + 5];
		array4[0] = val6;
		array4[1] = val7;
		array4[2] = val92;
		array4[3] = val93;
		array4[4] = progressPage;
		SimpleValueTargetProvider val108 = new SimpleValueTargetProvider(array4, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Dark"), (INameScope[])(object)new NameScope[6] { val94, val94, val94, val94, val94, val94 }, false);
		object obj4 = (object)val108;
		val107.Add(typeFromHandle4, (object)val108);
		val107.Add(typeof(IReferenceProvider), obj4);
		val107.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(11, 20)));
		object dark2 = val106.ProvideValue((IServiceProvider)val107);
		val6.Dark = dark2;
		XamlServiceProvider val109 = new XamlServiceProvider();
		val109.Add(typeof(IProvideValueTarget), (object)new ValueTargetProvider((object)val7, (object)Label.TextColorProperty));
		val109.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(11, 20)));
		BindingBase val110 = ((IMarkupExtension<BindingBase>)(object)val6).ProvideValue((IServiceProvider)val109);
		((BindableObject)val7).SetBinding(Label.TextColorProperty, val110);
		((Layout)val92).Children.Add((IView)(object)val7);
		val8.Key = "ThemedFrame";
		StaticResourceExtension val111 = new StaticResourceExtension
		{
			Key = "ThemedFrame"
		};
		XamlServiceProvider val112 = new XamlServiceProvider();
		Type? typeFromHandle5 = typeof(IProvideValueTarget);
		object[] array5 = new object[0 + 4];
		array5[0] = val38;
		array5[1] = val92;
		array5[2] = val93;
		array5[3] = progressPage;
		SimpleValueTargetProvider val113 = new SimpleValueTargetProvider(array5, (object)VisualElement.StyleProperty, (INameScope[])(object)new NameScope[5] { val94, val94, val94, val94, val94 }, false);
		object obj5 = (object)val113;
		val112.Add(typeFromHandle5, (object)val113);
		val112.Add(typeof(IReferenceProvider), obj5);
		val112.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(14, 20)));
		object obj6 = val111.ProvideValue((IServiceProvider)val112);
		((BindableObject)val38).SetValue(VisualElement.StyleProperty, (obj6 == null || !typeof(BindingBase).IsAssignableFrom(obj6.GetType())) ? obj6 : obj6);
		((BindableObject)val38).SetValue(Frame.CornerRadiusProperty, (object)8f);
		((BindableObject)val38).SetValue(Layout.PaddingProperty, (object)new Thickness(15.0));
		((BindableObject)val37).SetValue(StackBase.SpacingProperty, (object)15.0);
		((BindableObject)val12).SetValue(Label.TextProperty, (object)"ProgressBar");
		((BindableObject)val12).SetValue(Label.FontSizeProperty, (object)18.0);
		((BindableObject)val12).SetValue(Label.FontAttributesProperty, (object)(FontAttributes)1);
		val9.Key = "TextPrimaryLight";
		StaticResourceExtension val114 = new StaticResourceExtension
		{
			Key = "TextPrimaryLight"
		};
		XamlServiceProvider val115 = new XamlServiceProvider();
		Type? typeFromHandle6 = typeof(IProvideValueTarget);
		object[] array6 = new object[0 + 7];
		array6[0] = val11;
		array6[1] = val12;
		array6[2] = val37;
		array6[3] = val38;
		array6[4] = val92;
		array6[5] = val93;
		array6[6] = progressPage;
		SimpleValueTargetProvider val116 = new SimpleValueTargetProvider(array6, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Light"), (INameScope[])(object)new NameScope[8] { val94, val94, val94, val94, val94, val94, val94, val94 }, false);
		object obj7 = (object)val116;
		val115.Add(typeFromHandle6, (object)val116);
		val115.Add(typeof(IReferenceProvider), obj7);
		val115.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(17, 28)));
		object light3 = val114.ProvideValue((IServiceProvider)val115);
		val11.Light = light3;
		val10.Key = "TextPrimaryDark";
		StaticResourceExtension val117 = new StaticResourceExtension
		{
			Key = "TextPrimaryDark"
		};
		XamlServiceProvider val118 = new XamlServiceProvider();
		Type? typeFromHandle7 = typeof(IProvideValueTarget);
		object[] array7 = new object[0 + 7];
		array7[0] = val11;
		array7[1] = val12;
		array7[2] = val37;
		array7[3] = val38;
		array7[4] = val92;
		array7[5] = val93;
		array7[6] = progressPage;
		SimpleValueTargetProvider val119 = new SimpleValueTargetProvider(array7, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Dark"), (INameScope[])(object)new NameScope[8] { val94, val94, val94, val94, val94, val94, val94, val94 }, false);
		object obj8 = (object)val119;
		val118.Add(typeFromHandle7, (object)val119);
		val118.Add(typeof(IReferenceProvider), obj8);
		val118.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(17, 28)));
		object dark3 = val117.ProvideValue((IServiceProvider)val118);
		val11.Dark = dark3;
		XamlServiceProvider val120 = new XamlServiceProvider();
		val120.Add(typeof(IProvideValueTarget), (object)new ValueTargetProvider((object)val12, (object)Label.TextColorProperty));
		val120.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(17, 28)));
		BindingBase val121 = ((IMarkupExtension<BindingBase>)(object)val11).ProvideValue((IServiceProvider)val120);
		((BindableObject)val12).SetBinding(Label.TextColorProperty, val121);
		((Layout)val37).Children.Add((IView)(object)val12);
		((BindableObject)val16).SetValue(Label.TextProperty, (object)"Default Progress (50%)");
		val13.Key = "TextPrimaryLight";
		StaticResourceExtension val122 = new StaticResourceExtension
		{
			Key = "TextPrimaryLight"
		};
		XamlServiceProvider val123 = new XamlServiceProvider();
		Type? typeFromHandle8 = typeof(IProvideValueTarget);
		object[] array8 = new object[0 + 7];
		array8[0] = val15;
		array8[1] = val16;
		array8[2] = val37;
		array8[3] = val38;
		array8[4] = val92;
		array8[5] = val93;
		array8[6] = progressPage;
		SimpleValueTargetProvider val124 = new SimpleValueTargetProvider(array8, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Light"), (INameScope[])(object)new NameScope[8] { val94, val94, val94, val94, val94, val94, val94, val94 }, false);
		object obj9 = (object)val124;
		val123.Add(typeFromHandle8, (object)val124);
		val123.Add(typeof(IReferenceProvider), obj9);
		val123.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(20, 28)));
		object light4 = val122.ProvideValue((IServiceProvider)val123);
		val15.Light = light4;
		val14.Key = "TextPrimaryDark";
		StaticResourceExtension val125 = new StaticResourceExtension
		{
			Key = "TextPrimaryDark"
		};
		XamlServiceProvider val126 = new XamlServiceProvider();
		Type? typeFromHandle9 = typeof(IProvideValueTarget);
		object[] array9 = new object[0 + 7];
		array9[0] = val15;
		array9[1] = val16;
		array9[2] = val37;
		array9[3] = val38;
		array9[4] = val92;
		array9[5] = val93;
		array9[6] = progressPage;
		SimpleValueTargetProvider val127 = new SimpleValueTargetProvider(array9, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Dark"), (INameScope[])(object)new NameScope[8] { val94, val94, val94, val94, val94, val94, val94, val94 }, false);
		object obj10 = (object)val127;
		val126.Add(typeFromHandle9, (object)val127);
		val126.Add(typeof(IReferenceProvider), obj10);
		val126.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(20, 28)));
		object dark4 = val125.ProvideValue((IServiceProvider)val126);
		val15.Dark = dark4;
		XamlServiceProvider val128 = new XamlServiceProvider();
		val128.Add(typeof(IProvideValueTarget), (object)new ValueTargetProvider((object)val16, (object)Label.TextColorProperty));
		val128.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(20, 28)));
		BindingBase val129 = ((IMarkupExtension<BindingBase>)(object)val15).ProvideValue((IServiceProvider)val128);
		((BindableObject)val16).SetBinding(Label.TextColorProperty, val129);
		((Layout)val37).Children.Add((IView)(object)val16);
		((BindableObject)val18).SetValue(ProgressBar.ProgressProperty, (object)0.5);
		val17.Key = "ThemedProgressBar";
		StaticResourceExtension val130 = new StaticResourceExtension
		{
			Key = "ThemedProgressBar"
		};
		XamlServiceProvider val131 = new XamlServiceProvider();
		Type? typeFromHandle10 = typeof(IProvideValueTarget);
		object[] array10 = new object[0 + 6];
		array10[0] = val18;
		array10[1] = val37;
		array10[2] = val38;
		array10[3] = val92;
		array10[4] = val93;
		array10[5] = progressPage;
		SimpleValueTargetProvider val132 = new SimpleValueTargetProvider(array10, (object)VisualElement.StyleProperty, (INameScope[])(object)new NameScope[7] { val94, val94, val94, val94, val94, val94, val94 }, false);
		object obj11 = (object)val132;
		val131.Add(typeFromHandle10, (object)val132);
		val131.Add(typeof(IReferenceProvider), obj11);
		val131.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(21, 49)));
		object obj12 = val130.ProvideValue((IServiceProvider)val131);
		((BindableObject)val18).SetValue(VisualElement.StyleProperty, (obj12 == null || !typeof(BindingBase).IsAssignableFrom(obj12.GetType())) ? obj12 : obj12);
		((Layout)val37).Children.Add((IView)(object)val18);
		((BindableObject)val22).SetValue(Label.TextProperty, (object)"Colored Progress (75%)");
		val19.Key = "TextPrimaryLight";
		StaticResourceExtension val133 = new StaticResourceExtension
		{
			Key = "TextPrimaryLight"
		};
		XamlServiceProvider val134 = new XamlServiceProvider();
		Type? typeFromHandle11 = typeof(IProvideValueTarget);
		object[] array11 = new object[0 + 7];
		array11[0] = val21;
		array11[1] = val22;
		array11[2] = val37;
		array11[3] = val38;
		array11[4] = val92;
		array11[5] = val93;
		array11[6] = progressPage;
		SimpleValueTargetProvider val135 = new SimpleValueTargetProvider(array11, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Light"), (INameScope[])(object)new NameScope[8] { val94, val94, val94, val94, val94, val94, val94, val94 }, false);
		object obj13 = (object)val135;
		val134.Add(typeFromHandle11, (object)val135);
		val134.Add(typeof(IReferenceProvider), obj13);
		val134.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(24, 28)));
		object light5 = val133.ProvideValue((IServiceProvider)val134);
		val21.Light = light5;
		val20.Key = "TextPrimaryDark";
		StaticResourceExtension val136 = new StaticResourceExtension
		{
			Key = "TextPrimaryDark"
		};
		XamlServiceProvider val137 = new XamlServiceProvider();
		Type? typeFromHandle12 = typeof(IProvideValueTarget);
		object[] array12 = new object[0 + 7];
		array12[0] = val21;
		array12[1] = val22;
		array12[2] = val37;
		array12[3] = val38;
		array12[4] = val92;
		array12[5] = val93;
		array12[6] = progressPage;
		SimpleValueTargetProvider val138 = new SimpleValueTargetProvider(array12, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Dark"), (INameScope[])(object)new NameScope[8] { val94, val94, val94, val94, val94, val94, val94, val94 }, false);
		object obj14 = (object)val138;
		val137.Add(typeFromHandle12, (object)val138);
		val137.Add(typeof(IReferenceProvider), obj14);
		val137.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(24, 28)));
		object dark5 = val136.ProvideValue((IServiceProvider)val137);
		val21.Dark = dark5;
		XamlServiceProvider val139 = new XamlServiceProvider();
		val139.Add(typeof(IProvideValueTarget), (object)new ValueTargetProvider((object)val22, (object)Label.TextColorProperty));
		val139.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(24, 28)));
		BindingBase val140 = ((IMarkupExtension<BindingBase>)(object)val21).ProvideValue((IServiceProvider)val139);
		((BindableObject)val22).SetBinding(Label.TextColorProperty, val140);
		((Layout)val37).Children.Add((IView)(object)val22);
		((BindableObject)val26).SetValue(ProgressBar.ProgressProperty, (object)0.75);
		((BindableObject)val26).SetValue(ProgressBar.ProgressColorProperty, (object)new Color(0.29803923f, 35f / 51f, 16f / 51f, 1f));
		val23.Key = "ProgressTrackLight";
		StaticResourceExtension val141 = new StaticResourceExtension
		{
			Key = "ProgressTrackLight"
		};
		XamlServiceProvider val142 = new XamlServiceProvider();
		Type? typeFromHandle13 = typeof(IProvideValueTarget);
		object[] array13 = new object[0 + 7];
		array13[0] = val25;
		array13[1] = val26;
		array13[2] = val37;
		array13[3] = val38;
		array13[4] = val92;
		array13[5] = val93;
		array13[6] = progressPage;
		SimpleValueTargetProvider val143 = new SimpleValueTargetProvider(array13, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Light"), (INameScope[])(object)new NameScope[8] { val94, val94, val94, val94, val94, val94, val94, val94 }, false);
		object obj15 = (object)val143;
		val142.Add(typeFromHandle13, (object)val143);
		val142.Add(typeof(IReferenceProvider), obj15);
		val142.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(26, 34)));
		object light6 = val141.ProvideValue((IServiceProvider)val142);
		val25.Light = light6;
		val24.Key = "ProgressTrackDark";
		StaticResourceExtension val144 = new StaticResourceExtension
		{
			Key = "ProgressTrackDark"
		};
		XamlServiceProvider val145 = new XamlServiceProvider();
		Type? typeFromHandle14 = typeof(IProvideValueTarget);
		object[] array14 = new object[0 + 7];
		array14[0] = val25;
		array14[1] = val26;
		array14[2] = val37;
		array14[3] = val38;
		array14[4] = val92;
		array14[5] = val93;
		array14[6] = progressPage;
		SimpleValueTargetProvider val146 = new SimpleValueTargetProvider(array14, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Dark"), (INameScope[])(object)new NameScope[8] { val94, val94, val94, val94, val94, val94, val94, val94 }, false);
		object obj16 = (object)val146;
		val145.Add(typeFromHandle14, (object)val146);
		val145.Add(typeof(IReferenceProvider), obj16);
		val145.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(26, 34)));
		object dark6 = val144.ProvideValue((IServiceProvider)val145);
		val25.Dark = dark6;
		XamlServiceProvider val147 = new XamlServiceProvider();
		val147.Add(typeof(IProvideValueTarget), (object)new ValueTargetProvider((object)val26, (object)VisualElement.BackgroundColorProperty));
		val147.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(26, 34)));
		BindingBase val148 = ((IMarkupExtension<BindingBase>)(object)val25).ProvideValue((IServiceProvider)val147);
		((BindableObject)val26).SetBinding(VisualElement.BackgroundColorProperty, val148);
		((Layout)val37).Children.Add((IView)(object)val26);
		((BindableObject)val30).SetValue(Label.TextProperty, (object)"Animated Progress");
		val27.Key = "TextPrimaryLight";
		StaticResourceExtension val149 = new StaticResourceExtension
		{
			Key = "TextPrimaryLight"
		};
		XamlServiceProvider val150 = new XamlServiceProvider();
		Type? typeFromHandle15 = typeof(IProvideValueTarget);
		object[] array15 = new object[0 + 7];
		array15[0] = val29;
		array15[1] = val30;
		array15[2] = val37;
		array15[3] = val38;
		array15[4] = val92;
		array15[5] = val93;
		array15[6] = progressPage;
		SimpleValueTargetProvider val151 = new SimpleValueTargetProvider(array15, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Light"), (INameScope[])(object)new NameScope[8] { val94, val94, val94, val94, val94, val94, val94, val94 }, false);
		object obj17 = (object)val151;
		val150.Add(typeFromHandle15, (object)val151);
		val150.Add(typeof(IReferenceProvider), obj17);
		val150.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(29, 28)));
		object light7 = val149.ProvideValue((IServiceProvider)val150);
		val29.Light = light7;
		val28.Key = "TextPrimaryDark";
		StaticResourceExtension val152 = new StaticResourceExtension
		{
			Key = "TextPrimaryDark"
		};
		XamlServiceProvider val153 = new XamlServiceProvider();
		Type? typeFromHandle16 = typeof(IProvideValueTarget);
		object[] array16 = new object[0 + 7];
		array16[0] = val29;
		array16[1] = val30;
		array16[2] = val37;
		array16[3] = val38;
		array16[4] = val92;
		array16[5] = val93;
		array16[6] = progressPage;
		SimpleValueTargetProvider val154 = new SimpleValueTargetProvider(array16, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Dark"), (INameScope[])(object)new NameScope[8] { val94, val94, val94, val94, val94, val94, val94, val94 }, false);
		object obj18 = (object)val154;
		val153.Add(typeFromHandle16, (object)val154);
		val153.Add(typeof(IReferenceProvider), obj18);
		val153.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(29, 28)));
		object dark7 = val152.ProvideValue((IServiceProvider)val153);
		val29.Dark = dark7;
		XamlServiceProvider val155 = new XamlServiceProvider();
		val155.Add(typeof(IProvideValueTarget), (object)new ValueTargetProvider((object)val30, (object)Label.TextColorProperty));
		val155.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(29, 28)));
		BindingBase val156 = ((IMarkupExtension<BindingBase>)(object)val29).ProvideValue((IServiceProvider)val155);
		((BindableObject)val30).SetBinding(Label.TextColorProperty, val156);
		((Layout)val37).Children.Add((IView)(object)val30);
		((BindableObject)val34).SetValue(ProgressBar.ProgressProperty, (object)0.0);
		((BindableObject)val34).SetValue(ProgressBar.ProgressColorProperty, (object)new Color(1f, 0.59607846f, 0f, 1f));
		val31.Key = "ProgressTrackLight";
		StaticResourceExtension val157 = new StaticResourceExtension
		{
			Key = "ProgressTrackLight"
		};
		XamlServiceProvider val158 = new XamlServiceProvider();
		Type? typeFromHandle17 = typeof(IProvideValueTarget);
		object[] array17 = new object[0 + 7];
		array17[0] = val33;
		array17[1] = val34;
		array17[2] = val37;
		array17[3] = val38;
		array17[4] = val92;
		array17[5] = val93;
		array17[6] = progressPage;
		SimpleValueTargetProvider val159 = new SimpleValueTargetProvider(array17, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Light"), (INameScope[])(object)new NameScope[8] { val94, val94, val94, val94, val94, val94, val94, val94 }, false);
		object obj19 = (object)val159;
		val158.Add(typeFromHandle17, (object)val159);
		val158.Add(typeof(IReferenceProvider), obj19);
		val158.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(31, 34)));
		object light8 = val157.ProvideValue((IServiceProvider)val158);
		val33.Light = light8;
		val32.Key = "ProgressTrackDark";
		StaticResourceExtension val160 = new StaticResourceExtension
		{
			Key = "ProgressTrackDark"
		};
		XamlServiceProvider val161 = new XamlServiceProvider();
		Type? typeFromHandle18 = typeof(IProvideValueTarget);
		object[] array18 = new object[0 + 7];
		array18[0] = val33;
		array18[1] = val34;
		array18[2] = val37;
		array18[3] = val38;
		array18[4] = val92;
		array18[5] = val93;
		array18[6] = progressPage;
		SimpleValueTargetProvider val162 = new SimpleValueTargetProvider(array18, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Dark"), (INameScope[])(object)new NameScope[8] { val94, val94, val94, val94, val94, val94, val94, val94 }, false);
		object obj20 = (object)val162;
		val161.Add(typeFromHandle18, (object)val162);
		val161.Add(typeof(IReferenceProvider), obj20);
		val161.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(31, 34)));
		object dark8 = val160.ProvideValue((IServiceProvider)val161);
		val33.Dark = dark8;
		XamlServiceProvider val163 = new XamlServiceProvider();
		val163.Add(typeof(IProvideValueTarget), (object)new ValueTargetProvider((object)val34, (object)VisualElement.BackgroundColorProperty));
		val163.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(31, 34)));
		BindingBase val164 = ((IMarkupExtension<BindingBase>)(object)val33).ProvideValue((IServiceProvider)val163);
		((BindableObject)val34).SetBinding(VisualElement.BackgroundColorProperty, val164);
		((Layout)val37).Children.Add((IView)(object)val34);
		((BindableObject)val36).SetValue(Button.TextProperty, (object)"Animate Progress");
		val36.Clicked += progressPage.OnAnimateClicked;
		val35.Key = "PrimaryButton";
		StaticResourceExtension val165 = new StaticResourceExtension
		{
			Key = "PrimaryButton"
		};
		XamlServiceProvider val166 = new XamlServiceProvider();
		Type? typeFromHandle19 = typeof(IProvideValueTarget);
		object[] array19 = new object[0 + 6];
		array19[0] = val36;
		array19[1] = val37;
		array19[2] = val38;
		array19[3] = val92;
		array19[4] = val93;
		array19[5] = progressPage;
		SimpleValueTargetProvider val167 = new SimpleValueTargetProvider(array19, (object)VisualElement.StyleProperty, (INameScope[])(object)new NameScope[7] { val94, val94, val94, val94, val94, val94, val94 }, false);
		object obj21 = (object)val167;
		val166.Add(typeFromHandle19, (object)val167);
		val166.Add(typeof(IReferenceProvider), obj21);
		val166.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(32, 80)));
		object obj22 = val165.ProvideValue((IServiceProvider)val166);
		((BindableObject)val36).SetValue(VisualElement.StyleProperty, (obj22 == null || !typeof(BindingBase).IsAssignableFrom(obj22.GetType())) ? obj22 : obj22);
		((Layout)val37).Children.Add((IView)(object)val36);
		((BindableObject)val38).SetValue(ContentView.ContentProperty, (object)val37);
		((Layout)val92).Children.Add((IView)(object)val38);
		val39.Key = "ThemedFrame";
		StaticResourceExtension val168 = new StaticResourceExtension
		{
			Key = "ThemedFrame"
		};
		XamlServiceProvider val169 = new XamlServiceProvider();
		Type? typeFromHandle20 = typeof(IProvideValueTarget);
		object[] array20 = new object[0 + 4];
		array20[0] = val55;
		array20[1] = val92;
		array20[2] = val93;
		array20[3] = progressPage;
		SimpleValueTargetProvider val170 = new SimpleValueTargetProvider(array20, (object)VisualElement.StyleProperty, (INameScope[])(object)new NameScope[5] { val94, val94, val94, val94, val94 }, false);
		object obj23 = (object)val170;
		val169.Add(typeFromHandle20, (object)val170);
		val169.Add(typeof(IReferenceProvider), obj23);
		val169.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(37, 20)));
		object obj24 = val168.ProvideValue((IServiceProvider)val169);
		((BindableObject)val55).SetValue(VisualElement.StyleProperty, (obj24 == null || !typeof(BindingBase).IsAssignableFrom(obj24.GetType())) ? obj24 : obj24);
		((BindableObject)val55).SetValue(Frame.CornerRadiusProperty, (object)8f);
		((BindableObject)val55).SetValue(Layout.PaddingProperty, (object)new Thickness(15.0));
		((BindableObject)val54).SetValue(StackBase.SpacingProperty, (object)10.0);
		((BindableObject)val43).SetValue(Label.TextProperty, (object)"Interactive Progress");
		((BindableObject)val43).SetValue(Label.FontSizeProperty, (object)18.0);
		((BindableObject)val43).SetValue(Label.FontAttributesProperty, (object)(FontAttributes)1);
		val40.Key = "TextPrimaryLight";
		StaticResourceExtension val171 = new StaticResourceExtension
		{
			Key = "TextPrimaryLight"
		};
		XamlServiceProvider val172 = new XamlServiceProvider();
		Type? typeFromHandle21 = typeof(IProvideValueTarget);
		object[] array21 = new object[0 + 7];
		array21[0] = val42;
		array21[1] = val43;
		array21[2] = val54;
		array21[3] = val55;
		array21[4] = val92;
		array21[5] = val93;
		array21[6] = progressPage;
		SimpleValueTargetProvider val173 = new SimpleValueTargetProvider(array21, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Light"), (INameScope[])(object)new NameScope[8] { val94, val94, val94, val94, val94, val94, val94, val94 }, false);
		object obj25 = (object)val173;
		val172.Add(typeFromHandle21, (object)val173);
		val172.Add(typeof(IReferenceProvider), obj25);
		val172.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(40, 28)));
		object light9 = val171.ProvideValue((IServiceProvider)val172);
		val42.Light = light9;
		val41.Key = "TextPrimaryDark";
		StaticResourceExtension val174 = new StaticResourceExtension
		{
			Key = "TextPrimaryDark"
		};
		XamlServiceProvider val175 = new XamlServiceProvider();
		Type? typeFromHandle22 = typeof(IProvideValueTarget);
		object[] array22 = new object[0 + 7];
		array22[0] = val42;
		array22[1] = val43;
		array22[2] = val54;
		array22[3] = val55;
		array22[4] = val92;
		array22[5] = val93;
		array22[6] = progressPage;
		SimpleValueTargetProvider val176 = new SimpleValueTargetProvider(array22, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Dark"), (INameScope[])(object)new NameScope[8] { val94, val94, val94, val94, val94, val94, val94, val94 }, false);
		object obj26 = (object)val176;
		val175.Add(typeFromHandle22, (object)val176);
		val175.Add(typeof(IReferenceProvider), obj26);
		val175.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(40, 28)));
		object dark9 = val174.ProvideValue((IServiceProvider)val175);
		val42.Dark = dark9;
		XamlServiceProvider val177 = new XamlServiceProvider();
		val177.Add(typeof(IProvideValueTarget), (object)new ValueTargetProvider((object)val43, (object)Label.TextColorProperty));
		val177.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(40, 28)));
		BindingBase val178 = ((IMarkupExtension<BindingBase>)(object)val42).ProvideValue((IServiceProvider)val177);
		((BindableObject)val43).SetBinding(Label.TextColorProperty, val178);
		((Layout)val54).Children.Add((IView)(object)val43);
		((BindableObject)val48).SetValue(ProgressBar.ProgressProperty, (object)0.3);
		val44.Key = "PrimaryColor";
		StaticResourceExtension val179 = new StaticResourceExtension
		{
			Key = "PrimaryColor"
		};
		XamlServiceProvider val180 = new XamlServiceProvider();
		Type? typeFromHandle23 = typeof(IProvideValueTarget);
		object[] array23 = new object[0 + 6];
		array23[0] = val48;
		array23[1] = val54;
		array23[2] = val55;
		array23[3] = val92;
		array23[4] = val93;
		array23[5] = progressPage;
		SimpleValueTargetProvider val181 = new SimpleValueTargetProvider(array23, (object)ProgressBar.ProgressColorProperty, (INameScope[])(object)new NameScope[7] { val94, val94, val94, val94, val94, val94, val94 }, false);
		object obj27 = (object)val181;
		val180.Add(typeFromHandle23, (object)val181);
		val180.Add(typeof(IReferenceProvider), obj27);
		val180.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(43, 34)));
		object obj28 = val179.ProvideValue((IServiceProvider)val180);
		((BindableObject)val48).SetValue(ProgressBar.ProgressColorProperty, (obj28 == null || !typeof(BindingBase).IsAssignableFrom(obj28.GetType())) ? obj28 : obj28);
		val45.Key = "ProgressTrackLight";
		StaticResourceExtension val182 = new StaticResourceExtension
		{
			Key = "ProgressTrackLight"
		};
		XamlServiceProvider val183 = new XamlServiceProvider();
		Type? typeFromHandle24 = typeof(IProvideValueTarget);
		object[] array24 = new object[0 + 7];
		array24[0] = val47;
		array24[1] = val48;
		array24[2] = val54;
		array24[3] = val55;
		array24[4] = val92;
		array24[5] = val93;
		array24[6] = progressPage;
		SimpleValueTargetProvider val184 = new SimpleValueTargetProvider(array24, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Light"), (INameScope[])(object)new NameScope[8] { val94, val94, val94, val94, val94, val94, val94, val94 }, false);
		object obj29 = (object)val184;
		val183.Add(typeFromHandle24, (object)val184);
		val183.Add(typeof(IReferenceProvider), obj29);
		val183.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(44, 34)));
		object light10 = val182.ProvideValue((IServiceProvider)val183);
		val47.Light = light10;
		val46.Key = "ProgressTrackDark";
		StaticResourceExtension val185 = new StaticResourceExtension
		{
			Key = "ProgressTrackDark"
		};
		XamlServiceProvider val186 = new XamlServiceProvider();
		Type? typeFromHandle25 = typeof(IProvideValueTarget);
		object[] array25 = new object[0 + 7];
		array25[0] = val47;
		array25[1] = val48;
		array25[2] = val54;
		array25[3] = val55;
		array25[4] = val92;
		array25[5] = val93;
		array25[6] = progressPage;
		SimpleValueTargetProvider val187 = new SimpleValueTargetProvider(array25, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Dark"), (INameScope[])(object)new NameScope[8] { val94, val94, val94, val94, val94, val94, val94, val94 }, false);
		object obj30 = (object)val187;
		val186.Add(typeFromHandle25, (object)val187);
		val186.Add(typeof(IReferenceProvider), obj30);
		val186.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(44, 34)));
		object dark10 = val185.ProvideValue((IServiceProvider)val186);
		val47.Dark = dark10;
		XamlServiceProvider val188 = new XamlServiceProvider();
		val188.Add(typeof(IProvideValueTarget), (object)new ValueTargetProvider((object)val48, (object)VisualElement.BackgroundColorProperty));
		val188.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(44, 34)));
		BindingBase val189 = ((IMarkupExtension<BindingBase>)(object)val47).ProvideValue((IServiceProvider)val188);
		((BindableObject)val48).SetBinding(VisualElement.BackgroundColorProperty, val189);
		((Layout)val54).Children.Add((IView)(object)val48);
		((BindableObject)val52).SetValue(Label.TextProperty, (object)"30%");
		((BindableObject)val52).SetValue(View.HorizontalOptionsProperty, (object)LayoutOptions.Center);
		val49.Key = "TextPrimaryLight";
		StaticResourceExtension val190 = new StaticResourceExtension
		{
			Key = "TextPrimaryLight"
		};
		XamlServiceProvider val191 = new XamlServiceProvider();
		Type? typeFromHandle26 = typeof(IProvideValueTarget);
		object[] array26 = new object[0 + 7];
		array26[0] = val51;
		array26[1] = val52;
		array26[2] = val54;
		array26[3] = val55;
		array26[4] = val92;
		array26[5] = val93;
		array26[6] = progressPage;
		SimpleValueTargetProvider val192 = new SimpleValueTargetProvider(array26, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Light"), (INameScope[])(object)new NameScope[8] { val94, val94, val94, val94, val94, val94, val94, val94 }, false);
		object obj31 = (object)val192;
		val191.Add(typeFromHandle26, (object)val192);
		val191.Add(typeof(IReferenceProvider), obj31);
		val191.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(46, 28)));
		object light11 = val190.ProvideValue((IServiceProvider)val191);
		val51.Light = light11;
		val50.Key = "TextPrimaryDark";
		StaticResourceExtension val193 = new StaticResourceExtension
		{
			Key = "TextPrimaryDark"
		};
		XamlServiceProvider val194 = new XamlServiceProvider();
		Type? typeFromHandle27 = typeof(IProvideValueTarget);
		object[] array27 = new object[0 + 7];
		array27[0] = val51;
		array27[1] = val52;
		array27[2] = val54;
		array27[3] = val55;
		array27[4] = val92;
		array27[5] = val93;
		array27[6] = progressPage;
		SimpleValueTargetProvider val195 = new SimpleValueTargetProvider(array27, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Dark"), (INameScope[])(object)new NameScope[8] { val94, val94, val94, val94, val94, val94, val94, val94 }, false);
		object obj32 = (object)val195;
		val194.Add(typeFromHandle27, (object)val195);
		val194.Add(typeof(IReferenceProvider), obj32);
		val194.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(46, 28)));
		object dark11 = val193.ProvideValue((IServiceProvider)val194);
		val51.Dark = dark11;
		XamlServiceProvider val196 = new XamlServiceProvider();
		val196.Add(typeof(IProvideValueTarget), (object)new ValueTargetProvider((object)val52, (object)Label.TextColorProperty));
		val196.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(46, 28)));
		BindingBase val197 = ((IMarkupExtension<BindingBase>)(object)val51).ProvideValue((IServiceProvider)val196);
		((BindableObject)val52).SetBinding(Label.TextColorProperty, val197);
		((Layout)val54).Children.Add((IView)(object)val52);
		((BindableObject)val53).SetValue(Slider.MinimumProperty, (object)0.0);
		((BindableObject)val53).SetValue(Slider.MaximumProperty, (object)1.0);
		((BindableObject)val53).SetValue(Slider.ValueProperty, (object)0.3);
		val53.ValueChanged += progressPage.OnSliderValueChanged;
		((Layout)val54).Children.Add((IView)(object)val53);
		((BindableObject)val55).SetValue(ContentView.ContentProperty, (object)val54);
		((Layout)val92).Children.Add((IView)(object)val55);
		val56.Key = "ThemedFrame";
		StaticResourceExtension val198 = new StaticResourceExtension
		{
			Key = "ThemedFrame"
		};
		XamlServiceProvider val199 = new XamlServiceProvider();
		Type? typeFromHandle28 = typeof(IProvideValueTarget);
		object[] array28 = new object[0 + 4];
		array28[0] = val85;
		array28[1] = val92;
		array28[2] = val93;
		array28[3] = progressPage;
		SimpleValueTargetProvider val200 = new SimpleValueTargetProvider(array28, (object)VisualElement.StyleProperty, (INameScope[])(object)new NameScope[5] { val94, val94, val94, val94, val94 }, false);
		object obj33 = (object)val200;
		val199.Add(typeFromHandle28, (object)val200);
		val199.Add(typeof(IReferenceProvider), obj33);
		val199.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(53, 20)));
		object obj34 = val198.ProvideValue((IServiceProvider)val199);
		((BindableObject)val85).SetValue(VisualElement.StyleProperty, (obj34 == null || !typeof(BindingBase).IsAssignableFrom(obj34.GetType())) ? obj34 : obj34);
		((BindableObject)val85).SetValue(Frame.CornerRadiusProperty, (object)8f);
		((BindableObject)val85).SetValue(Layout.PaddingProperty, (object)new Thickness(15.0));
		((BindableObject)val84).SetValue(StackBase.SpacingProperty, (object)15.0);
		((BindableObject)val60).SetValue(Label.TextProperty, (object)"ActivityIndicator");
		((BindableObject)val60).SetValue(Label.FontSizeProperty, (object)18.0);
		((BindableObject)val60).SetValue(Label.FontAttributesProperty, (object)(FontAttributes)1);
		val57.Key = "TextPrimaryLight";
		StaticResourceExtension val201 = new StaticResourceExtension
		{
			Key = "TextPrimaryLight"
		};
		XamlServiceProvider val202 = new XamlServiceProvider();
		Type? typeFromHandle29 = typeof(IProvideValueTarget);
		object[] array29 = new object[0 + 7];
		array29[0] = val59;
		array29[1] = val60;
		array29[2] = val84;
		array29[3] = val85;
		array29[4] = val92;
		array29[5] = val93;
		array29[6] = progressPage;
		SimpleValueTargetProvider val203 = new SimpleValueTargetProvider(array29, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Light"), (INameScope[])(object)new NameScope[8] { val94, val94, val94, val94, val94, val94, val94, val94 }, false);
		object obj35 = (object)val203;
		val202.Add(typeFromHandle29, (object)val203);
		val202.Add(typeof(IReferenceProvider), obj35);
		val202.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(56, 28)));
		object light12 = val201.ProvideValue((IServiceProvider)val202);
		val59.Light = light12;
		val58.Key = "TextPrimaryDark";
		StaticResourceExtension val204 = new StaticResourceExtension
		{
			Key = "TextPrimaryDark"
		};
		XamlServiceProvider val205 = new XamlServiceProvider();
		Type? typeFromHandle30 = typeof(IProvideValueTarget);
		object[] array30 = new object[0 + 7];
		array30[0] = val59;
		array30[1] = val60;
		array30[2] = val84;
		array30[3] = val85;
		array30[4] = val92;
		array30[5] = val93;
		array30[6] = progressPage;
		SimpleValueTargetProvider val206 = new SimpleValueTargetProvider(array30, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Dark"), (INameScope[])(object)new NameScope[8] { val94, val94, val94, val94, val94, val94, val94, val94 }, false);
		object obj36 = (object)val206;
		val205.Add(typeFromHandle30, (object)val206);
		val205.Add(typeof(IReferenceProvider), obj36);
		val205.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(56, 28)));
		object dark12 = val204.ProvideValue((IServiceProvider)val205);
		val59.Dark = dark12;
		XamlServiceProvider val207 = new XamlServiceProvider();
		val207.Add(typeof(IProvideValueTarget), (object)new ValueTargetProvider((object)val60, (object)Label.TextColorProperty));
		val207.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(56, 28)));
		BindingBase val208 = ((IMarkupExtension<BindingBase>)(object)val59).ProvideValue((IServiceProvider)val207);
		((BindableObject)val60).SetBinding(Label.TextColorProperty, val208);
		((Layout)val84).Children.Add((IView)(object)val60);
		((BindableObject)val80).SetValue(StackBase.SpacingProperty, (object)20.0);
		((BindableObject)val80).SetValue(View.HorizontalOptionsProperty, (object)LayoutOptions.Center);
		((BindableObject)val67).SetValue(StackBase.SpacingProperty, (object)5.0);
		((BindableObject)val67).SetValue(View.HorizontalOptionsProperty, (object)LayoutOptions.Center);
		((BindableObject)val62).SetValue(ActivityIndicator.IsRunningProperty, (object)true);
		val61.Key = "PrimaryColor";
		StaticResourceExtension val209 = new StaticResourceExtension
		{
			Key = "PrimaryColor"
		};
		XamlServiceProvider val210 = new XamlServiceProvider();
		Type? typeFromHandle31 = typeof(IProvideValueTarget);
		object[] array31 = new object[0 + 8];
		array31[0] = val62;
		array31[1] = val67;
		array31[2] = val80;
		array31[3] = val84;
		array31[4] = val85;
		array31[5] = val92;
		array31[6] = val93;
		array31[7] = progressPage;
		SimpleValueTargetProvider val211 = new SimpleValueTargetProvider(array31, (object)ActivityIndicator.ColorProperty, (INameScope[])(object)new NameScope[9] { val94, val94, val94, val94, val94, val94, val94, val94, val94 }, false);
		object obj37 = (object)val211;
		val210.Add(typeFromHandle31, (object)val211);
		val210.Add(typeof(IReferenceProvider), obj37);
		val210.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(60, 65)));
		object obj38 = val209.ProvideValue((IServiceProvider)val210);
		((BindableObject)val62).SetValue(ActivityIndicator.ColorProperty, (obj38 == null || !typeof(BindingBase).IsAssignableFrom(obj38.GetType())) ? obj38 : obj38);
		((Layout)val67).Children.Add((IView)(object)val62);
		((BindableObject)val66).SetValue(Label.TextProperty, (object)"Default");
		((BindableObject)val66).SetValue(Label.FontSizeProperty, (object)12.0);
		((BindableObject)val66).SetValue(View.HorizontalOptionsProperty, (object)LayoutOptions.Center);
		val63.Key = "TextSecondaryLight";
		StaticResourceExtension val212 = new StaticResourceExtension
		{
			Key = "TextSecondaryLight"
		};
		XamlServiceProvider val213 = new XamlServiceProvider();
		Type? typeFromHandle32 = typeof(IProvideValueTarget);
		object[] array32 = new object[0 + 9];
		array32[0] = val65;
		array32[1] = val66;
		array32[2] = val67;
		array32[3] = val80;
		array32[4] = val84;
		array32[5] = val85;
		array32[6] = val92;
		array32[7] = val93;
		array32[8] = progressPage;
		SimpleValueTargetProvider val214 = new SimpleValueTargetProvider(array32, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Light"), (INameScope[])(object)new NameScope[10] { val94, val94, val94, val94, val94, val94, val94, val94, val94, val94 }, false);
		object obj39 = (object)val214;
		val213.Add(typeFromHandle32, (object)val214);
		val213.Add(typeof(IReferenceProvider), obj39);
		val213.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(62, 36)));
		object light13 = val212.ProvideValue((IServiceProvider)val213);
		val65.Light = light13;
		val64.Key = "TextSecondaryDark";
		StaticResourceExtension val215 = new StaticResourceExtension
		{
			Key = "TextSecondaryDark"
		};
		XamlServiceProvider val216 = new XamlServiceProvider();
		Type? typeFromHandle33 = typeof(IProvideValueTarget);
		object[] array33 = new object[0 + 9];
		array33[0] = val65;
		array33[1] = val66;
		array33[2] = val67;
		array33[3] = val80;
		array33[4] = val84;
		array33[5] = val85;
		array33[6] = val92;
		array33[7] = val93;
		array33[8] = progressPage;
		SimpleValueTargetProvider val217 = new SimpleValueTargetProvider(array33, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Dark"), (INameScope[])(object)new NameScope[10] { val94, val94, val94, val94, val94, val94, val94, val94, val94, val94 }, false);
		object obj40 = (object)val217;
		val216.Add(typeFromHandle33, (object)val217);
		val216.Add(typeof(IReferenceProvider), obj40);
		val216.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(62, 36)));
		object dark13 = val215.ProvideValue((IServiceProvider)val216);
		val65.Dark = dark13;
		XamlServiceProvider val218 = new XamlServiceProvider();
		val218.Add(typeof(IProvideValueTarget), (object)new ValueTargetProvider((object)val66, (object)Label.TextColorProperty));
		val218.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(62, 36)));
		BindingBase val219 = ((IMarkupExtension<BindingBase>)(object)val65).ProvideValue((IServiceProvider)val218);
		((BindableObject)val66).SetBinding(Label.TextColorProperty, val219);
		((Layout)val67).Children.Add((IView)(object)val66);
		((Layout)val80).Children.Add((IView)(object)val67);
		((BindableObject)val73).SetValue(StackBase.SpacingProperty, (object)5.0);
		((BindableObject)val73).SetValue(View.HorizontalOptionsProperty, (object)LayoutOptions.Center);
		((BindableObject)val68).SetValue(ActivityIndicator.IsRunningProperty, (object)true);
		((BindableObject)val68).SetValue(ActivityIndicator.ColorProperty, (object)new Color(0.29803923f, 35f / 51f, 16f / 51f, 1f));
		((Layout)val73).Children.Add((IView)(object)val68);
		((BindableObject)val72).SetValue(Label.TextProperty, (object)"Green");
		((BindableObject)val72).SetValue(Label.FontSizeProperty, (object)12.0);
		((BindableObject)val72).SetValue(View.HorizontalOptionsProperty, (object)LayoutOptions.Center);
		val69.Key = "TextSecondaryLight";
		StaticResourceExtension val220 = new StaticResourceExtension
		{
			Key = "TextSecondaryLight"
		};
		XamlServiceProvider val221 = new XamlServiceProvider();
		Type? typeFromHandle34 = typeof(IProvideValueTarget);
		object[] array34 = new object[0 + 9];
		array34[0] = val71;
		array34[1] = val72;
		array34[2] = val73;
		array34[3] = val80;
		array34[4] = val84;
		array34[5] = val85;
		array34[6] = val92;
		array34[7] = val93;
		array34[8] = progressPage;
		SimpleValueTargetProvider val222 = new SimpleValueTargetProvider(array34, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Light"), (INameScope[])(object)new NameScope[10] { val94, val94, val94, val94, val94, val94, val94, val94, val94, val94 }, false);
		object obj41 = (object)val222;
		val221.Add(typeFromHandle34, (object)val222);
		val221.Add(typeof(IReferenceProvider), obj41);
		val221.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(68, 36)));
		object light14 = val220.ProvideValue((IServiceProvider)val221);
		val71.Light = light14;
		val70.Key = "TextSecondaryDark";
		StaticResourceExtension val223 = new StaticResourceExtension
		{
			Key = "TextSecondaryDark"
		};
		XamlServiceProvider val224 = new XamlServiceProvider();
		Type? typeFromHandle35 = typeof(IProvideValueTarget);
		object[] array35 = new object[0 + 9];
		array35[0] = val71;
		array35[1] = val72;
		array35[2] = val73;
		array35[3] = val80;
		array35[4] = val84;
		array35[5] = val85;
		array35[6] = val92;
		array35[7] = val93;
		array35[8] = progressPage;
		SimpleValueTargetProvider val225 = new SimpleValueTargetProvider(array35, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Dark"), (INameScope[])(object)new NameScope[10] { val94, val94, val94, val94, val94, val94, val94, val94, val94, val94 }, false);
		object obj42 = (object)val225;
		val224.Add(typeFromHandle35, (object)val225);
		val224.Add(typeof(IReferenceProvider), obj42);
		val224.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(68, 36)));
		object dark14 = val223.ProvideValue((IServiceProvider)val224);
		val71.Dark = dark14;
		XamlServiceProvider val226 = new XamlServiceProvider();
		val226.Add(typeof(IProvideValueTarget), (object)new ValueTargetProvider((object)val72, (object)Label.TextColorProperty));
		val226.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(68, 36)));
		BindingBase val227 = ((IMarkupExtension<BindingBase>)(object)val71).ProvideValue((IServiceProvider)val226);
		((BindableObject)val72).SetBinding(Label.TextColorProperty, val227);
		((Layout)val73).Children.Add((IView)(object)val72);
		((Layout)val80).Children.Add((IView)(object)val73);
		((BindableObject)val79).SetValue(StackBase.SpacingProperty, (object)5.0);
		((BindableObject)val79).SetValue(View.HorizontalOptionsProperty, (object)LayoutOptions.Center);
		((BindableObject)val74).SetValue(ActivityIndicator.IsRunningProperty, (object)true);
		((BindableObject)val74).SetValue(ActivityIndicator.ColorProperty, (object)new Color(1f, 0.59607846f, 0f, 1f));
		((Layout)val79).Children.Add((IView)(object)val74);
		((BindableObject)val78).SetValue(Label.TextProperty, (object)"Orange");
		((BindableObject)val78).SetValue(Label.FontSizeProperty, (object)12.0);
		((BindableObject)val78).SetValue(View.HorizontalOptionsProperty, (object)LayoutOptions.Center);
		val75.Key = "TextSecondaryLight";
		StaticResourceExtension val228 = new StaticResourceExtension
		{
			Key = "TextSecondaryLight"
		};
		XamlServiceProvider val229 = new XamlServiceProvider();
		Type? typeFromHandle36 = typeof(IProvideValueTarget);
		object[] array36 = new object[0 + 9];
		array36[0] = val77;
		array36[1] = val78;
		array36[2] = val79;
		array36[3] = val80;
		array36[4] = val84;
		array36[5] = val85;
		array36[6] = val92;
		array36[7] = val93;
		array36[8] = progressPage;
		SimpleValueTargetProvider val230 = new SimpleValueTargetProvider(array36, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Light"), (INameScope[])(object)new NameScope[10] { val94, val94, val94, val94, val94, val94, val94, val94, val94, val94 }, false);
		object obj43 = (object)val230;
		val229.Add(typeFromHandle36, (object)val230);
		val229.Add(typeof(IReferenceProvider), obj43);
		val229.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(74, 36)));
		object light15 = val228.ProvideValue((IServiceProvider)val229);
		val77.Light = light15;
		val76.Key = "TextSecondaryDark";
		StaticResourceExtension val231 = new StaticResourceExtension
		{
			Key = "TextSecondaryDark"
		};
		XamlServiceProvider val232 = new XamlServiceProvider();
		Type? typeFromHandle37 = typeof(IProvideValueTarget);
		object[] array37 = new object[0 + 9];
		array37[0] = val77;
		array37[1] = val78;
		array37[2] = val79;
		array37[3] = val80;
		array37[4] = val84;
		array37[5] = val85;
		array37[6] = val92;
		array37[7] = val93;
		array37[8] = progressPage;
		SimpleValueTargetProvider val233 = new SimpleValueTargetProvider(array37, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Dark"), (INameScope[])(object)new NameScope[10] { val94, val94, val94, val94, val94, val94, val94, val94, val94, val94 }, false);
		object obj44 = (object)val233;
		val232.Add(typeFromHandle37, (object)val233);
		val232.Add(typeof(IReferenceProvider), obj44);
		val232.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(74, 36)));
		object dark15 = val231.ProvideValue((IServiceProvider)val232);
		val77.Dark = dark15;
		XamlServiceProvider val234 = new XamlServiceProvider();
		val234.Add(typeof(IProvideValueTarget), (object)new ValueTargetProvider((object)val78, (object)Label.TextColorProperty));
		val234.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(74, 36)));
		BindingBase val235 = ((IMarkupExtension<BindingBase>)(object)val77).ProvideValue((IServiceProvider)val234);
		((BindableObject)val78).SetBinding(Label.TextColorProperty, val235);
		((Layout)val79).Children.Add((IView)(object)val78);
		((Layout)val80).Children.Add((IView)(object)val79);
		((Layout)val84).Children.Add((IView)(object)val80);
		((BindableObject)val83).SetValue(StackBase.SpacingProperty, (object)10.0);
		((BindableObject)val83).SetValue(View.HorizontalOptionsProperty, (object)LayoutOptions.Center);
		((BindableObject)val81).SetValue(ActivityIndicator.IsRunningProperty, (object)false);
		((BindableObject)val81).SetValue(ActivityIndicator.ColorProperty, (object)new Color(52f / 85f, 13f / 85f, 0.6901961f, 1f));
		((Layout)val83).Children.Add((IView)(object)val81);
		((BindableObject)val82).SetValue(Button.TextProperty, (object)"Toggle");
		val82.Clicked += progressPage.OnToggleIndicatorClicked;
		((Layout)val83).Children.Add((IView)(object)val82);
		((Layout)val84).Children.Add((IView)(object)val83);
		((BindableObject)val85).SetValue(ContentView.ContentProperty, (object)val84);
		((Layout)val92).Children.Add((IView)(object)val85);
		((BindableObject)val91).SetValue(Frame.CornerRadiusProperty, (object)8f);
		((BindableObject)val91).SetValue(Layout.PaddingProperty, (object)new Thickness(20.0));
		val86.Light = "#FFF3E0";
		val86.Dark = "#E65100";
		XamlServiceProvider val236 = new XamlServiceProvider();
		val236.Add(typeof(IProvideValueTarget), (object)new ValueTargetProvider((object)val91, (object)VisualElement.BackgroundColorProperty));
		val236.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(87, 20)));
		BindingBase val237 = ((IMarkupExtension<BindingBase>)(object)val86).ProvideValue((IServiceProvider)val236);
		((BindableObject)val91).SetBinding(VisualElement.BackgroundColorProperty, val237);
		((BindableObject)val90).SetValue(StackBase.SpacingProperty, (object)15.0);
		((BindableObject)val88).SetValue(Label.TextProperty, (object)"Loading State Demo");
		((BindableObject)val88).SetValue(Label.FontSizeProperty, (object)18.0);
		((BindableObject)val88).SetValue(Label.FontAttributesProperty, (object)(FontAttributes)1);
		val87.Light = "#E65100";
		val87.Dark = "#FFCC80";
		XamlServiceProvider val238 = new XamlServiceProvider();
		val238.Add(typeof(IProvideValueTarget), (object)new ValueTargetProvider((object)val88, (object)Label.TextColorProperty));
		val238.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(90, 28)));
		BindingBase val239 = ((IMarkupExtension<BindingBase>)(object)val87).ProvideValue((IServiceProvider)val238);
		((BindableObject)val88).SetBinding(Label.TextColorProperty, val239);
		((Layout)val90).Children.Add((IView)(object)val88);
		((BindableObject)val89).SetValue(Button.TextProperty, (object)"Simulate Loading");
		val89.Clicked += progressPage.OnSimulateLoadingClicked;
		((BindableObject)val89).SetValue(VisualElement.BackgroundColorProperty, (object)new Color(1f, 0.59607846f, 0f, 1f));
		((BindableObject)val89).SetValue(Button.TextColorProperty, (object)Colors.White);
		((Layout)val90).Children.Add((IView)(object)val89);
		((BindableObject)val91).SetValue(ContentView.ContentProperty, (object)val90);
		((Layout)val92).Children.Add((IView)(object)val91);
		val93.Content = (View)(object)val92;
		((BindableObject)progressPage).SetValue(ContentPage.ContentProperty, (object)val93);
	}
}
