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

[XamlFilePath("Pages/SelectionPage.xaml")]
public class SelectionPage : ContentPage
{
	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private CheckBox CheckBox1;

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private CheckBox CheckBox2;

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private Label CheckBoxOutput;

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private Switch NotifSwitch;

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private Label SwitchOutput;

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private Slider VolumeSlider;

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private Label VolumeLabel;

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private Label BrightnessLabel;

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private Stepper QuantityStepper;

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private Label StepperLabel;

	public SelectionPage()
	{
		InitializeComponent();
	}

	private void OnCheckBoxChanged(object? sender, CheckedChangedEventArgs e)
	{
		bool isChecked = CheckBox1.IsChecked;
		bool isChecked2 = CheckBox2.IsChecked;
		CheckBoxOutput.Text = "Option 1: " + (isChecked ? "checked" : "unchecked") + ", Option 2: " + (isChecked2 ? "checked" : "unchecked");
	}

	private void OnSwitchToggled(object? sender, ToggledEventArgs e)
	{
		if (sender is Switch)
		{
			SwitchOutput.Text = $"Switch toggled to: {e.Value}";
		}
	}

	private void OnSliderValueChanged(object? sender, ValueChangedEventArgs e)
	{
		VolumeLabel.Text = $"{(int)e.NewValue}%";
	}

	private void OnBrightnessChanged(object? sender, ValueChangedEventArgs e)
	{
		BrightnessLabel.Text = $"{(int)e.NewValue}%";
	}

	private void OnStepperChanged(object? sender, ValueChangedEventArgs e)
	{
		StepperLabel.Text = $"Quantity: {(int)e.NewValue}";
	}

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	[MemberNotNull("CheckBox1")]
	[MemberNotNull("CheckBox2")]
	[MemberNotNull("CheckBoxOutput")]
	[MemberNotNull("NotifSwitch")]
	[MemberNotNull("SwitchOutput")]
	[MemberNotNull("VolumeSlider")]
	[MemberNotNull("VolumeLabel")]
	[MemberNotNull("BrightnessLabel")]
	[MemberNotNull("QuantityStepper")]
	[MemberNotNull("StepperLabel")]
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
		//IL_02e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0640: Unknown result type (might be due to invalid IL or missing references)
		//IL_0645: Unknown result type (might be due to invalid IL or missing references)
		//IL_0650: Unknown result type (might be due to invalid IL or missing references)
		//IL_0655: Unknown result type (might be due to invalid IL or missing references)
		//IL_069b: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a3: Expected O, but got Unknown
		//IL_06a8: Expected O, but got Unknown
		//IL_06a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d2: Expected O, but got Unknown
		//IL_06cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d7: Expected O, but got Unknown
		//IL_06dc: Expected O, but got Unknown
		//IL_06f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0701: Unknown result type (might be due to invalid IL or missing references)
		//IL_0706: Unknown result type (might be due to invalid IL or missing references)
		//IL_074c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0751: Unknown result type (might be due to invalid IL or missing references)
		//IL_0754: Expected O, but got Unknown
		//IL_0759: Expected O, but got Unknown
		//IL_0759: Unknown result type (might be due to invalid IL or missing references)
		//IL_076b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0779: Unknown result type (might be due to invalid IL or missing references)
		//IL_0783: Expected O, but got Unknown
		//IL_077e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0788: Expected O, but got Unknown
		//IL_078d: Expected O, but got Unknown
		//IL_0798: Unknown result type (might be due to invalid IL or missing references)
		//IL_079d: Unknown result type (might be due to invalid IL or missing references)
		//IL_07af: Unknown result type (might be due to invalid IL or missing references)
		//IL_07b9: Expected O, but got Unknown
		//IL_07b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_07c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d1: Expected O, but got Unknown
		//IL_07cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d6: Expected O, but got Unknown
		//IL_07db: Expected O, but got Unknown
		//IL_07fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_086c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0871: Unknown result type (might be due to invalid IL or missing references)
		//IL_087c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0881: Unknown result type (might be due to invalid IL or missing references)
		//IL_08e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_08eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ee: Expected O, but got Unknown
		//IL_08f3: Expected O, but got Unknown
		//IL_08f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0905: Unknown result type (might be due to invalid IL or missing references)
		//IL_0914: Unknown result type (might be due to invalid IL or missing references)
		//IL_091e: Expected O, but got Unknown
		//IL_0919: Unknown result type (might be due to invalid IL or missing references)
		//IL_0923: Expected O, but got Unknown
		//IL_0928: Expected O, but got Unknown
		//IL_093f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0944: Unknown result type (might be due to invalid IL or missing references)
		//IL_094f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0954: Unknown result type (might be due to invalid IL or missing references)
		//IL_09b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_09be: Unknown result type (might be due to invalid IL or missing references)
		//IL_09c1: Expected O, but got Unknown
		//IL_09c6: Expected O, but got Unknown
		//IL_09c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_09d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_09e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_09f1: Expected O, but got Unknown
		//IL_09ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_09f6: Expected O, but got Unknown
		//IL_09fb: Expected O, but got Unknown
		//IL_0a08: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a0d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a1f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a29: Expected O, but got Unknown
		//IL_0a29: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a38: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a42: Expected O, but got Unknown
		//IL_0a3d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a47: Expected O, but got Unknown
		//IL_0a4c: Expected O, but got Unknown
		//IL_0a76: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a7b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a86: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a8b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ad7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0adc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0adf: Expected O, but got Unknown
		//IL_0ae4: Expected O, but got Unknown
		//IL_0ae4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0af6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b05: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b0f: Expected O, but got Unknown
		//IL_0b0a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b14: Expected O, but got Unknown
		//IL_0b19: Expected O, but got Unknown
		//IL_0b71: Unknown result type (might be due to invalid IL or missing references)
		//IL_0be3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0be8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bf3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bf8: Unknown result type (might be due to invalid IL or missing references)
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
		//IL_0d58: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d5d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d60: Expected O, but got Unknown
		//IL_0d65: Expected O, but got Unknown
		//IL_0d65: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d77: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d86: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d90: Expected O, but got Unknown
		//IL_0d8b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d95: Expected O, but got Unknown
		//IL_0d9a: Expected O, but got Unknown
		//IL_0da7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dac: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dbe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dc8: Expected O, but got Unknown
		//IL_0dc8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dd7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0de1: Expected O, but got Unknown
		//IL_0ddc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0de6: Expected O, but got Unknown
		//IL_0deb: Expected O, but got Unknown
		//IL_0e5d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e78: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e7d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e88: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e8d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f11: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f16: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f19: Expected O, but got Unknown
		//IL_0f1e: Expected O, but got Unknown
		//IL_0f1e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f30: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f3f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f49: Expected O, but got Unknown
		//IL_0f44: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f4e: Expected O, but got Unknown
		//IL_0f53: Expected O, but got Unknown
		//IL_0f6a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f6f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f7a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f7f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1003: Unknown result type (might be due to invalid IL or missing references)
		//IL_1008: Unknown result type (might be due to invalid IL or missing references)
		//IL_100b: Expected O, but got Unknown
		//IL_1010: Expected O, but got Unknown
		//IL_1010: Unknown result type (might be due to invalid IL or missing references)
		//IL_1022: Unknown result type (might be due to invalid IL or missing references)
		//IL_1031: Unknown result type (might be due to invalid IL or missing references)
		//IL_103b: Expected O, but got Unknown
		//IL_1036: Unknown result type (might be due to invalid IL or missing references)
		//IL_1040: Expected O, but got Unknown
		//IL_1045: Expected O, but got Unknown
		//IL_1052: Unknown result type (might be due to invalid IL or missing references)
		//IL_1057: Unknown result type (might be due to invalid IL or missing references)
		//IL_1069: Unknown result type (might be due to invalid IL or missing references)
		//IL_1073: Expected O, but got Unknown
		//IL_1073: Unknown result type (might be due to invalid IL or missing references)
		//IL_1082: Unknown result type (might be due to invalid IL or missing references)
		//IL_108c: Expected O, but got Unknown
		//IL_1087: Unknown result type (might be due to invalid IL or missing references)
		//IL_1091: Expected O, but got Unknown
		//IL_1096: Expected O, but got Unknown
		//IL_1128: Unknown result type (might be due to invalid IL or missing references)
		//IL_1143: Unknown result type (might be due to invalid IL or missing references)
		//IL_1148: Unknown result type (might be due to invalid IL or missing references)
		//IL_1153: Unknown result type (might be due to invalid IL or missing references)
		//IL_1158: Unknown result type (might be due to invalid IL or missing references)
		//IL_11dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_11e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_11e4: Expected O, but got Unknown
		//IL_11e9: Expected O, but got Unknown
		//IL_11e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_11fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_120a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1214: Expected O, but got Unknown
		//IL_120f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1219: Expected O, but got Unknown
		//IL_121e: Expected O, but got Unknown
		//IL_1235: Unknown result type (might be due to invalid IL or missing references)
		//IL_123a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1245: Unknown result type (might be due to invalid IL or missing references)
		//IL_124a: Unknown result type (might be due to invalid IL or missing references)
		//IL_12ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_12d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_12d6: Expected O, but got Unknown
		//IL_12db: Expected O, but got Unknown
		//IL_12db: Unknown result type (might be due to invalid IL or missing references)
		//IL_12ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_12fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_1306: Expected O, but got Unknown
		//IL_1301: Unknown result type (might be due to invalid IL or missing references)
		//IL_130b: Expected O, but got Unknown
		//IL_1310: Expected O, but got Unknown
		//IL_131d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1322: Unknown result type (might be due to invalid IL or missing references)
		//IL_1334: Unknown result type (might be due to invalid IL or missing references)
		//IL_133e: Expected O, but got Unknown
		//IL_133e: Unknown result type (might be due to invalid IL or missing references)
		//IL_134d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1357: Expected O, but got Unknown
		//IL_1352: Unknown result type (might be due to invalid IL or missing references)
		//IL_135c: Expected O, but got Unknown
		//IL_1361: Expected O, but got Unknown
		//IL_13df: Unknown result type (might be due to invalid IL or missing references)
		//IL_13fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_13ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_140a: Unknown result type (might be due to invalid IL or missing references)
		//IL_140f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1493: Unknown result type (might be due to invalid IL or missing references)
		//IL_1498: Unknown result type (might be due to invalid IL or missing references)
		//IL_149b: Expected O, but got Unknown
		//IL_14a0: Expected O, but got Unknown
		//IL_14a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_14b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_14c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_14cb: Expected O, but got Unknown
		//IL_14c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_14d0: Expected O, but got Unknown
		//IL_14d5: Expected O, but got Unknown
		//IL_14ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_14f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_14fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_1501: Unknown result type (might be due to invalid IL or missing references)
		//IL_1585: Unknown result type (might be due to invalid IL or missing references)
		//IL_158a: Unknown result type (might be due to invalid IL or missing references)
		//IL_158d: Expected O, but got Unknown
		//IL_1592: Expected O, but got Unknown
		//IL_1592: Unknown result type (might be due to invalid IL or missing references)
		//IL_15a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_15b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_15bd: Expected O, but got Unknown
		//IL_15b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_15c2: Expected O, but got Unknown
		//IL_15c7: Expected O, but got Unknown
		//IL_15d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_15d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_15eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_15f5: Expected O, but got Unknown
		//IL_15f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_1604: Unknown result type (might be due to invalid IL or missing references)
		//IL_160e: Expected O, but got Unknown
		//IL_1609: Unknown result type (might be due to invalid IL or missing references)
		//IL_1613: Expected O, but got Unknown
		//IL_1618: Expected O, but got Unknown
		//IL_166a: Unknown result type (might be due to invalid IL or missing references)
		//IL_166f: Unknown result type (might be due to invalid IL or missing references)
		//IL_167a: Unknown result type (might be due to invalid IL or missing references)
		//IL_167f: Unknown result type (might be due to invalid IL or missing references)
		//IL_16f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_16fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_1700: Expected O, but got Unknown
		//IL_1705: Expected O, but got Unknown
		//IL_1705: Unknown result type (might be due to invalid IL or missing references)
		//IL_1717: Unknown result type (might be due to invalid IL or missing references)
		//IL_1726: Unknown result type (might be due to invalid IL or missing references)
		//IL_1730: Expected O, but got Unknown
		//IL_172b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1735: Expected O, but got Unknown
		//IL_173a: Expected O, but got Unknown
		//IL_1751: Unknown result type (might be due to invalid IL or missing references)
		//IL_1756: Unknown result type (might be due to invalid IL or missing references)
		//IL_1761: Unknown result type (might be due to invalid IL or missing references)
		//IL_1766: Unknown result type (might be due to invalid IL or missing references)
		//IL_17df: Unknown result type (might be due to invalid IL or missing references)
		//IL_17e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_17e7: Expected O, but got Unknown
		//IL_17ec: Expected O, but got Unknown
		//IL_17ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_17fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_180d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1817: Expected O, but got Unknown
		//IL_1812: Unknown result type (might be due to invalid IL or missing references)
		//IL_181c: Expected O, but got Unknown
		//IL_1821: Expected O, but got Unknown
		//IL_182e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1833: Unknown result type (might be due to invalid IL or missing references)
		//IL_1845: Unknown result type (might be due to invalid IL or missing references)
		//IL_184f: Expected O, but got Unknown
		//IL_184f: Unknown result type (might be due to invalid IL or missing references)
		//IL_185e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1868: Expected O, but got Unknown
		//IL_1863: Unknown result type (might be due to invalid IL or missing references)
		//IL_186d: Expected O, but got Unknown
		//IL_1872: Expected O, but got Unknown
		//IL_18b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_18bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_18c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_18cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_1919: Unknown result type (might be due to invalid IL or missing references)
		//IL_191e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1921: Expected O, but got Unknown
		//IL_1926: Expected O, but got Unknown
		//IL_1926: Unknown result type (might be due to invalid IL or missing references)
		//IL_1938: Unknown result type (might be due to invalid IL or missing references)
		//IL_1947: Unknown result type (might be due to invalid IL or missing references)
		//IL_1951: Expected O, but got Unknown
		//IL_194c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1956: Expected O, but got Unknown
		//IL_195b: Expected O, but got Unknown
		//IL_19b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a25: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a2a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a35: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a3a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ab3: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ab8: Unknown result type (might be due to invalid IL or missing references)
		//IL_1abb: Expected O, but got Unknown
		//IL_1ac0: Expected O, but got Unknown
		//IL_1ac0: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ad2: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ae1: Unknown result type (might be due to invalid IL or missing references)
		//IL_1aeb: Expected O, but got Unknown
		//IL_1ae6: Unknown result type (might be due to invalid IL or missing references)
		//IL_1af0: Expected O, but got Unknown
		//IL_1af5: Expected O, but got Unknown
		//IL_1b0c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b11: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b1c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b21: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b9a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b9f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ba2: Expected O, but got Unknown
		//IL_1ba7: Expected O, but got Unknown
		//IL_1ba7: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bb9: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bc8: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bd2: Expected O, but got Unknown
		//IL_1bcd: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bd7: Expected O, but got Unknown
		//IL_1bdc: Expected O, but got Unknown
		//IL_1be9: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bee: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c00: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c0a: Expected O, but got Unknown
		//IL_1c0a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c19: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c23: Expected O, but got Unknown
		//IL_1c1e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c28: Expected O, but got Unknown
		//IL_1c2d: Expected O, but got Unknown
		//IL_1c5a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c5f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c65: Expected O, but got Unknown
		//IL_1c67: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c6c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c72: Expected O, but got Unknown
		//IL_1c72: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c7c: Expected O, but got Unknown
		//IL_1c8b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c90: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c96: Expected O, but got Unknown
		//IL_1c98: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c9d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ca3: Expected O, but got Unknown
		//IL_1ca5: Unknown result type (might be due to invalid IL or missing references)
		//IL_1caa: Unknown result type (might be due to invalid IL or missing references)
		//IL_1cb0: Expected O, but got Unknown
		//IL_1cb0: Unknown result type (might be due to invalid IL or missing references)
		//IL_1cba: Expected O, but got Unknown
		//IL_1cec: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d07: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d0c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d17: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d1c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1da0: Unknown result type (might be due to invalid IL or missing references)
		//IL_1da5: Unknown result type (might be due to invalid IL or missing references)
		//IL_1da8: Expected O, but got Unknown
		//IL_1dad: Expected O, but got Unknown
		//IL_1dad: Unknown result type (might be due to invalid IL or missing references)
		//IL_1dbf: Unknown result type (might be due to invalid IL or missing references)
		//IL_1dce: Unknown result type (might be due to invalid IL or missing references)
		//IL_1dd8: Expected O, but got Unknown
		//IL_1dd3: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ddd: Expected O, but got Unknown
		//IL_1de2: Expected O, but got Unknown
		//IL_1df9: Unknown result type (might be due to invalid IL or missing references)
		//IL_1dfe: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e09: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e0e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e92: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e97: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e9a: Expected O, but got Unknown
		//IL_1e9f: Expected O, but got Unknown
		//IL_1e9f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1eb1: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ec0: Unknown result type (might be due to invalid IL or missing references)
		//IL_1eca: Expected O, but got Unknown
		//IL_1ec5: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ecf: Expected O, but got Unknown
		//IL_1ed4: Expected O, but got Unknown
		//IL_1ee1: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ee6: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ef8: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f02: Expected O, but got Unknown
		//IL_1f02: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f11: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f1b: Expected O, but got Unknown
		//IL_1f16: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f20: Expected O, but got Unknown
		//IL_1f25: Expected O, but got Unknown
		//IL_1fa1: Unknown result type (might be due to invalid IL or missing references)
		//IL_1fbc: Unknown result type (might be due to invalid IL or missing references)
		//IL_1fc1: Unknown result type (might be due to invalid IL or missing references)
		//IL_1fcc: Unknown result type (might be due to invalid IL or missing references)
		//IL_1fd1: Unknown result type (might be due to invalid IL or missing references)
		//IL_2055: Unknown result type (might be due to invalid IL or missing references)
		//IL_205a: Unknown result type (might be due to invalid IL or missing references)
		//IL_205d: Expected O, but got Unknown
		//IL_2062: Expected O, but got Unknown
		//IL_2062: Unknown result type (might be due to invalid IL or missing references)
		//IL_2074: Unknown result type (might be due to invalid IL or missing references)
		//IL_2083: Unknown result type (might be due to invalid IL or missing references)
		//IL_208d: Expected O, but got Unknown
		//IL_2088: Unknown result type (might be due to invalid IL or missing references)
		//IL_2092: Expected O, but got Unknown
		//IL_2097: Expected O, but got Unknown
		//IL_20ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_20b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_20be: Unknown result type (might be due to invalid IL or missing references)
		//IL_20c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_2147: Unknown result type (might be due to invalid IL or missing references)
		//IL_214c: Unknown result type (might be due to invalid IL or missing references)
		//IL_214f: Expected O, but got Unknown
		//IL_2154: Expected O, but got Unknown
		//IL_2154: Unknown result type (might be due to invalid IL or missing references)
		//IL_2166: Unknown result type (might be due to invalid IL or missing references)
		//IL_2175: Unknown result type (might be due to invalid IL or missing references)
		//IL_217f: Expected O, but got Unknown
		//IL_217a: Unknown result type (might be due to invalid IL or missing references)
		//IL_2184: Expected O, but got Unknown
		//IL_2189: Expected O, but got Unknown
		//IL_2196: Unknown result type (might be due to invalid IL or missing references)
		//IL_219b: Unknown result type (might be due to invalid IL or missing references)
		//IL_21ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_21b7: Expected O, but got Unknown
		//IL_21b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_21c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_21d0: Expected O, but got Unknown
		//IL_21cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_21d5: Expected O, but got Unknown
		//IL_21da: Expected O, but got Unknown
		//IL_2237: Unknown result type (might be due to invalid IL or missing references)
		//IL_2241: Expected O, but got Unknown
		//IL_228d: Unknown result type (might be due to invalid IL or missing references)
		//IL_22a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_22ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_22b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_22bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_2341: Unknown result type (might be due to invalid IL or missing references)
		//IL_2346: Unknown result type (might be due to invalid IL or missing references)
		//IL_2349: Expected O, but got Unknown
		//IL_234e: Expected O, but got Unknown
		//IL_234e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2360: Unknown result type (might be due to invalid IL or missing references)
		//IL_236f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2379: Expected O, but got Unknown
		//IL_2374: Unknown result type (might be due to invalid IL or missing references)
		//IL_237e: Expected O, but got Unknown
		//IL_2383: Expected O, but got Unknown
		//IL_239a: Unknown result type (might be due to invalid IL or missing references)
		//IL_239f: Unknown result type (might be due to invalid IL or missing references)
		//IL_23aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_23af: Unknown result type (might be due to invalid IL or missing references)
		//IL_2433: Unknown result type (might be due to invalid IL or missing references)
		//IL_2438: Unknown result type (might be due to invalid IL or missing references)
		//IL_243b: Expected O, but got Unknown
		//IL_2440: Expected O, but got Unknown
		//IL_2440: Unknown result type (might be due to invalid IL or missing references)
		//IL_2452: Unknown result type (might be due to invalid IL or missing references)
		//IL_2461: Unknown result type (might be due to invalid IL or missing references)
		//IL_246b: Expected O, but got Unknown
		//IL_2466: Unknown result type (might be due to invalid IL or missing references)
		//IL_2470: Expected O, but got Unknown
		//IL_2475: Expected O, but got Unknown
		//IL_2482: Unknown result type (might be due to invalid IL or missing references)
		//IL_2487: Unknown result type (might be due to invalid IL or missing references)
		//IL_2499: Unknown result type (might be due to invalid IL or missing references)
		//IL_24a3: Expected O, but got Unknown
		//IL_24a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_24b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_24bc: Expected O, but got Unknown
		//IL_24b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_24c1: Expected O, but got Unknown
		//IL_24c6: Expected O, but got Unknown
		//IL_255c: Unknown result type (might be due to invalid IL or missing references)
		//IL_2561: Unknown result type (might be due to invalid IL or missing references)
		//IL_256c: Unknown result type (might be due to invalid IL or missing references)
		//IL_2571: Unknown result type (might be due to invalid IL or missing references)
		//IL_25ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_25ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_25f2: Expected O, but got Unknown
		//IL_25f7: Expected O, but got Unknown
		//IL_25f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_2609: Unknown result type (might be due to invalid IL or missing references)
		//IL_2618: Unknown result type (might be due to invalid IL or missing references)
		//IL_2622: Expected O, but got Unknown
		//IL_261d: Unknown result type (might be due to invalid IL or missing references)
		//IL_2627: Expected O, but got Unknown
		//IL_262c: Expected O, but got Unknown
		//IL_2643: Unknown result type (might be due to invalid IL or missing references)
		//IL_2648: Unknown result type (might be due to invalid IL or missing references)
		//IL_2653: Unknown result type (might be due to invalid IL or missing references)
		//IL_2658: Unknown result type (might be due to invalid IL or missing references)
		//IL_26d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_26d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_26d9: Expected O, but got Unknown
		//IL_26de: Expected O, but got Unknown
		//IL_26de: Unknown result type (might be due to invalid IL or missing references)
		//IL_26f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_26ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_2709: Expected O, but got Unknown
		//IL_2704: Unknown result type (might be due to invalid IL or missing references)
		//IL_270e: Expected O, but got Unknown
		//IL_2713: Expected O, but got Unknown
		//IL_2720: Unknown result type (might be due to invalid IL or missing references)
		//IL_2725: Unknown result type (might be due to invalid IL or missing references)
		//IL_2737: Unknown result type (might be due to invalid IL or missing references)
		//IL_2741: Expected O, but got Unknown
		//IL_2741: Unknown result type (might be due to invalid IL or missing references)
		//IL_2750: Unknown result type (might be due to invalid IL or missing references)
		//IL_275a: Expected O, but got Unknown
		//IL_2755: Unknown result type (might be due to invalid IL or missing references)
		//IL_275f: Expected O, but got Unknown
		//IL_2764: Expected O, but got Unknown
		//IL_27aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_27af: Unknown result type (might be due to invalid IL or missing references)
		//IL_27ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_27bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_280b: Unknown result type (might be due to invalid IL or missing references)
		//IL_2810: Unknown result type (might be due to invalid IL or missing references)
		//IL_2813: Expected O, but got Unknown
		//IL_2818: Expected O, but got Unknown
		//IL_2818: Unknown result type (might be due to invalid IL or missing references)
		//IL_282a: Unknown result type (might be due to invalid IL or missing references)
		//IL_2839: Unknown result type (might be due to invalid IL or missing references)
		//IL_2843: Expected O, but got Unknown
		//IL_283e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2848: Expected O, but got Unknown
		//IL_284d: Expected O, but got Unknown
		//IL_28a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_2917: Unknown result type (might be due to invalid IL or missing references)
		//IL_291c: Unknown result type (might be due to invalid IL or missing references)
		//IL_2927: Unknown result type (might be due to invalid IL or missing references)
		//IL_292c: Unknown result type (might be due to invalid IL or missing references)
		//IL_29a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_29aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_29ad: Expected O, but got Unknown
		//IL_29b2: Expected O, but got Unknown
		//IL_29b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_29c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_29d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_29dd: Expected O, but got Unknown
		//IL_29d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_29e2: Expected O, but got Unknown
		//IL_29e7: Expected O, but got Unknown
		//IL_29fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a03: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a0e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a13: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a8c: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a91: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a94: Expected O, but got Unknown
		//IL_2a99: Expected O, but got Unknown
		//IL_2a99: Unknown result type (might be due to invalid IL or missing references)
		//IL_2aab: Unknown result type (might be due to invalid IL or missing references)
		//IL_2aba: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ac4: Expected O, but got Unknown
		//IL_2abf: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ac9: Expected O, but got Unknown
		//IL_2ace: Expected O, but got Unknown
		//IL_2adb: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ae0: Unknown result type (might be due to invalid IL or missing references)
		//IL_2af2: Unknown result type (might be due to invalid IL or missing references)
		//IL_2afc: Expected O, but got Unknown
		//IL_2afc: Unknown result type (might be due to invalid IL or missing references)
		//IL_2b0b: Unknown result type (might be due to invalid IL or missing references)
		//IL_2b15: Expected O, but got Unknown
		//IL_2b10: Unknown result type (might be due to invalid IL or missing references)
		//IL_2b1a: Expected O, but got Unknown
		//IL_2b1f: Expected O, but got Unknown
		//IL_2b5a: Unknown result type (might be due to invalid IL or missing references)
		//IL_2b5f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2b6a: Unknown result type (might be due to invalid IL or missing references)
		//IL_2b6f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2be8: Unknown result type (might be due to invalid IL or missing references)
		//IL_2bed: Unknown result type (might be due to invalid IL or missing references)
		//IL_2bf0: Expected O, but got Unknown
		//IL_2bf5: Expected O, but got Unknown
		//IL_2bf5: Unknown result type (might be due to invalid IL or missing references)
		//IL_2c07: Unknown result type (might be due to invalid IL or missing references)
		//IL_2c16: Unknown result type (might be due to invalid IL or missing references)
		//IL_2c20: Expected O, but got Unknown
		//IL_2c1b: Unknown result type (might be due to invalid IL or missing references)
		//IL_2c25: Expected O, but got Unknown
		//IL_2c2a: Expected O, but got Unknown
		//IL_2c41: Unknown result type (might be due to invalid IL or missing references)
		//IL_2c46: Unknown result type (might be due to invalid IL or missing references)
		//IL_2c51: Unknown result type (might be due to invalid IL or missing references)
		//IL_2c56: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ccf: Unknown result type (might be due to invalid IL or missing references)
		//IL_2cd4: Unknown result type (might be due to invalid IL or missing references)
		//IL_2cd7: Expected O, but got Unknown
		//IL_2cdc: Expected O, but got Unknown
		//IL_2cdc: Unknown result type (might be due to invalid IL or missing references)
		//IL_2cee: Unknown result type (might be due to invalid IL or missing references)
		//IL_2cfd: Unknown result type (might be due to invalid IL or missing references)
		//IL_2d07: Expected O, but got Unknown
		//IL_2d02: Unknown result type (might be due to invalid IL or missing references)
		//IL_2d0c: Expected O, but got Unknown
		//IL_2d11: Expected O, but got Unknown
		//IL_2d1e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2d23: Unknown result type (might be due to invalid IL or missing references)
		//IL_2d35: Unknown result type (might be due to invalid IL or missing references)
		//IL_2d3f: Expected O, but got Unknown
		//IL_2d3f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2d4e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2d58: Expected O, but got Unknown
		//IL_2d53: Unknown result type (might be due to invalid IL or missing references)
		//IL_2d5d: Expected O, but got Unknown
		//IL_2d62: Expected O, but got Unknown
		//IL_2dda: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ddf: Unknown result type (might be due to invalid IL or missing references)
		//IL_2dea: Unknown result type (might be due to invalid IL or missing references)
		//IL_2def: Unknown result type (might be due to invalid IL or missing references)
		//IL_2e4f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2e54: Unknown result type (might be due to invalid IL or missing references)
		//IL_2e57: Expected O, but got Unknown
		//IL_2e5c: Expected O, but got Unknown
		//IL_2e5c: Unknown result type (might be due to invalid IL or missing references)
		//IL_2e6e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2e7d: Unknown result type (might be due to invalid IL or missing references)
		//IL_2e87: Expected O, but got Unknown
		//IL_2e82: Unknown result type (might be due to invalid IL or missing references)
		//IL_2e8c: Expected O, but got Unknown
		//IL_2e91: Expected O, but got Unknown
		//IL_2efd: Unknown result type (might be due to invalid IL or missing references)
		//IL_2f18: Unknown result type (might be due to invalid IL or missing references)
		//IL_2f1d: Unknown result type (might be due to invalid IL or missing references)
		//IL_2f28: Unknown result type (might be due to invalid IL or missing references)
		//IL_2f2d: Unknown result type (might be due to invalid IL or missing references)
		//IL_2fa6: Unknown result type (might be due to invalid IL or missing references)
		//IL_2fab: Unknown result type (might be due to invalid IL or missing references)
		//IL_2fae: Expected O, but got Unknown
		//IL_2fb3: Expected O, but got Unknown
		//IL_2fb3: Unknown result type (might be due to invalid IL or missing references)
		//IL_2fc5: Unknown result type (might be due to invalid IL or missing references)
		//IL_2fd4: Unknown result type (might be due to invalid IL or missing references)
		//IL_2fde: Expected O, but got Unknown
		//IL_2fd9: Unknown result type (might be due to invalid IL or missing references)
		//IL_2fe3: Expected O, but got Unknown
		//IL_2fe8: Expected O, but got Unknown
		//IL_2fff: Unknown result type (might be due to invalid IL or missing references)
		//IL_3004: Unknown result type (might be due to invalid IL or missing references)
		//IL_300f: Unknown result type (might be due to invalid IL or missing references)
		//IL_3014: Unknown result type (might be due to invalid IL or missing references)
		//IL_308d: Unknown result type (might be due to invalid IL or missing references)
		//IL_3092: Unknown result type (might be due to invalid IL or missing references)
		//IL_3095: Expected O, but got Unknown
		//IL_309a: Expected O, but got Unknown
		//IL_309a: Unknown result type (might be due to invalid IL or missing references)
		//IL_30ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_30bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_30c5: Expected O, but got Unknown
		//IL_30c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_30ca: Expected O, but got Unknown
		//IL_30cf: Expected O, but got Unknown
		//IL_30dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_30e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_30f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_30fd: Expected O, but got Unknown
		//IL_30fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_310c: Unknown result type (might be due to invalid IL or missing references)
		//IL_3116: Expected O, but got Unknown
		//IL_3111: Unknown result type (might be due to invalid IL or missing references)
		//IL_311b: Expected O, but got Unknown
		//IL_3120: Expected O, but got Unknown
		//IL_315b: Unknown result type (might be due to invalid IL or missing references)
		//IL_3160: Unknown result type (might be due to invalid IL or missing references)
		//IL_316b: Unknown result type (might be due to invalid IL or missing references)
		//IL_3170: Unknown result type (might be due to invalid IL or missing references)
		//IL_31e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_31ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_31f1: Expected O, but got Unknown
		//IL_31f6: Expected O, but got Unknown
		//IL_31f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_3208: Unknown result type (might be due to invalid IL or missing references)
		//IL_3217: Unknown result type (might be due to invalid IL or missing references)
		//IL_3221: Expected O, but got Unknown
		//IL_321c: Unknown result type (might be due to invalid IL or missing references)
		//IL_3226: Expected O, but got Unknown
		//IL_322b: Expected O, but got Unknown
		//IL_3242: Unknown result type (might be due to invalid IL or missing references)
		//IL_3247: Unknown result type (might be due to invalid IL or missing references)
		//IL_3252: Unknown result type (might be due to invalid IL or missing references)
		//IL_3257: Unknown result type (might be due to invalid IL or missing references)
		//IL_32d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_32d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_32d8: Expected O, but got Unknown
		//IL_32dd: Expected O, but got Unknown
		//IL_32dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_32ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_32fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_3308: Expected O, but got Unknown
		//IL_3303: Unknown result type (might be due to invalid IL or missing references)
		//IL_330d: Expected O, but got Unknown
		//IL_3312: Expected O, but got Unknown
		//IL_331f: Unknown result type (might be due to invalid IL or missing references)
		//IL_3324: Unknown result type (might be due to invalid IL or missing references)
		//IL_3336: Unknown result type (might be due to invalid IL or missing references)
		//IL_3340: Expected O, but got Unknown
		//IL_3340: Unknown result type (might be due to invalid IL or missing references)
		//IL_334f: Unknown result type (might be due to invalid IL or missing references)
		//IL_3359: Expected O, but got Unknown
		//IL_3354: Unknown result type (might be due to invalid IL or missing references)
		//IL_335e: Expected O, but got Unknown
		//IL_3363: Expected O, but got Unknown
		//IL_33ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_33f4: Expected O, but got Unknown
		//IL_342e: Unknown result type (might be due to invalid IL or missing references)
		//IL_3449: Unknown result type (might be due to invalid IL or missing references)
		//IL_344e: Unknown result type (might be due to invalid IL or missing references)
		//IL_3459: Unknown result type (might be due to invalid IL or missing references)
		//IL_345e: Unknown result type (might be due to invalid IL or missing references)
		//IL_34d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_34dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_34df: Expected O, but got Unknown
		//IL_34e4: Expected O, but got Unknown
		//IL_34e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_34f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_3505: Unknown result type (might be due to invalid IL or missing references)
		//IL_350f: Expected O, but got Unknown
		//IL_350a: Unknown result type (might be due to invalid IL or missing references)
		//IL_3514: Expected O, but got Unknown
		//IL_3519: Expected O, but got Unknown
		//IL_3530: Unknown result type (might be due to invalid IL or missing references)
		//IL_3535: Unknown result type (might be due to invalid IL or missing references)
		//IL_3540: Unknown result type (might be due to invalid IL or missing references)
		//IL_3545: Unknown result type (might be due to invalid IL or missing references)
		//IL_35be: Unknown result type (might be due to invalid IL or missing references)
		//IL_35c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_35c6: Expected O, but got Unknown
		//IL_35cb: Expected O, but got Unknown
		//IL_35cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_35dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_35ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_35f6: Expected O, but got Unknown
		//IL_35f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_35fb: Expected O, but got Unknown
		//IL_3600: Expected O, but got Unknown
		//IL_360d: Unknown result type (might be due to invalid IL or missing references)
		//IL_3612: Unknown result type (might be due to invalid IL or missing references)
		//IL_3624: Unknown result type (might be due to invalid IL or missing references)
		//IL_362e: Expected O, but got Unknown
		//IL_362e: Unknown result type (might be due to invalid IL or missing references)
		//IL_363d: Unknown result type (might be due to invalid IL or missing references)
		//IL_3647: Expected O, but got Unknown
		//IL_3642: Unknown result type (might be due to invalid IL or missing references)
		//IL_364c: Expected O, but got Unknown
		//IL_3651: Expected O, but got Unknown
		//IL_3697: Unknown result type (might be due to invalid IL or missing references)
		//IL_369c: Unknown result type (might be due to invalid IL or missing references)
		//IL_36a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_36ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_36f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_36fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_3700: Expected O, but got Unknown
		//IL_3705: Expected O, but got Unknown
		//IL_3705: Unknown result type (might be due to invalid IL or missing references)
		//IL_3717: Unknown result type (might be due to invalid IL or missing references)
		//IL_3726: Unknown result type (might be due to invalid IL or missing references)
		//IL_3730: Expected O, but got Unknown
		//IL_372b: Unknown result type (might be due to invalid IL or missing references)
		//IL_3735: Expected O, but got Unknown
		//IL_373a: Expected O, but got Unknown
		//IL_3792: Unknown result type (might be due to invalid IL or missing references)
		//IL_3804: Unknown result type (might be due to invalid IL or missing references)
		//IL_3809: Unknown result type (might be due to invalid IL or missing references)
		//IL_3814: Unknown result type (might be due to invalid IL or missing references)
		//IL_3819: Unknown result type (might be due to invalid IL or missing references)
		//IL_3892: Unknown result type (might be due to invalid IL or missing references)
		//IL_3897: Unknown result type (might be due to invalid IL or missing references)
		//IL_389a: Expected O, but got Unknown
		//IL_389f: Expected O, but got Unknown
		//IL_389f: Unknown result type (might be due to invalid IL or missing references)
		//IL_38b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_38c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_38ca: Expected O, but got Unknown
		//IL_38c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_38cf: Expected O, but got Unknown
		//IL_38d4: Expected O, but got Unknown
		//IL_38eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_38f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_38fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_3900: Unknown result type (might be due to invalid IL or missing references)
		//IL_3979: Unknown result type (might be due to invalid IL or missing references)
		//IL_397e: Unknown result type (might be due to invalid IL or missing references)
		//IL_3981: Expected O, but got Unknown
		//IL_3986: Expected O, but got Unknown
		//IL_3986: Unknown result type (might be due to invalid IL or missing references)
		//IL_3998: Unknown result type (might be due to invalid IL or missing references)
		//IL_39a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_39b1: Expected O, but got Unknown
		//IL_39ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_39b6: Expected O, but got Unknown
		//IL_39bb: Expected O, but got Unknown
		//IL_39c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_39cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_39df: Unknown result type (might be due to invalid IL or missing references)
		//IL_39e9: Expected O, but got Unknown
		//IL_39e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_39f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_3a02: Expected O, but got Unknown
		//IL_39fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_3a07: Expected O, but got Unknown
		//IL_3a0c: Expected O, but got Unknown
		//IL_3a4b: Unknown result type (might be due to invalid IL or missing references)
		//IL_3afc: Unknown result type (might be due to invalid IL or missing references)
		//IL_3b31: Unknown result type (might be due to invalid IL or missing references)
		//IL_3b36: Unknown result type (might be due to invalid IL or missing references)
		//IL_3b41: Unknown result type (might be due to invalid IL or missing references)
		//IL_3b46: Unknown result type (might be due to invalid IL or missing references)
		//IL_3bca: Unknown result type (might be due to invalid IL or missing references)
		//IL_3bcf: Unknown result type (might be due to invalid IL or missing references)
		//IL_3bd2: Expected O, but got Unknown
		//IL_3bd7: Expected O, but got Unknown
		//IL_3bd7: Unknown result type (might be due to invalid IL or missing references)
		//IL_3be9: Unknown result type (might be due to invalid IL or missing references)
		//IL_3bf8: Unknown result type (might be due to invalid IL or missing references)
		//IL_3c02: Expected O, but got Unknown
		//IL_3bfd: Unknown result type (might be due to invalid IL or missing references)
		//IL_3c07: Expected O, but got Unknown
		//IL_3c0c: Expected O, but got Unknown
		//IL_3c23: Unknown result type (might be due to invalid IL or missing references)
		//IL_3c28: Unknown result type (might be due to invalid IL or missing references)
		//IL_3c33: Unknown result type (might be due to invalid IL or missing references)
		//IL_3c38: Unknown result type (might be due to invalid IL or missing references)
		//IL_3cbc: Unknown result type (might be due to invalid IL or missing references)
		//IL_3cc1: Unknown result type (might be due to invalid IL or missing references)
		//IL_3cc4: Expected O, but got Unknown
		//IL_3cc9: Expected O, but got Unknown
		//IL_3cc9: Unknown result type (might be due to invalid IL or missing references)
		//IL_3cdb: Unknown result type (might be due to invalid IL or missing references)
		//IL_3cea: Unknown result type (might be due to invalid IL or missing references)
		//IL_3cf4: Expected O, but got Unknown
		//IL_3cef: Unknown result type (might be due to invalid IL or missing references)
		//IL_3cf9: Expected O, but got Unknown
		//IL_3cfe: Expected O, but got Unknown
		//IL_3d0b: Unknown result type (might be due to invalid IL or missing references)
		//IL_3d10: Unknown result type (might be due to invalid IL or missing references)
		//IL_3d22: Unknown result type (might be due to invalid IL or missing references)
		//IL_3d2c: Expected O, but got Unknown
		//IL_3d2c: Unknown result type (might be due to invalid IL or missing references)
		//IL_3d3b: Unknown result type (might be due to invalid IL or missing references)
		//IL_3d45: Expected O, but got Unknown
		//IL_3d40: Unknown result type (might be due to invalid IL or missing references)
		//IL_3d4a: Expected O, but got Unknown
		//IL_3d4f: Expected O, but got Unknown
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
		CheckBox val13 = new CheckBox();
		StaticResourceExtension val14 = new StaticResourceExtension();
		StaticResourceExtension val15 = new StaticResourceExtension();
		AppThemeBindingExtension val16 = new AppThemeBindingExtension();
		Label val17 = new Label();
		HorizontalStackLayout val18 = new HorizontalStackLayout();
		CheckBox val19 = new CheckBox();
		StaticResourceExtension val20 = new StaticResourceExtension();
		StaticResourceExtension val21 = new StaticResourceExtension();
		AppThemeBindingExtension val22 = new AppThemeBindingExtension();
		Label val23 = new Label();
		HorizontalStackLayout val24 = new HorizontalStackLayout();
		CheckBox val25 = new CheckBox();
		StaticResourceExtension val26 = new StaticResourceExtension();
		StaticResourceExtension val27 = new StaticResourceExtension();
		AppThemeBindingExtension val28 = new AppThemeBindingExtension();
		Label val29 = new Label();
		HorizontalStackLayout val30 = new HorizontalStackLayout();
		StaticResourceExtension val31 = new StaticResourceExtension();
		StaticResourceExtension val32 = new StaticResourceExtension();
		AppThemeBindingExtension val33 = new AppThemeBindingExtension();
		Label val34 = new Label();
		VerticalStackLayout val35 = new VerticalStackLayout();
		Frame val36 = new Frame();
		StaticResourceExtension val37 = new StaticResourceExtension();
		StaticResourceExtension val38 = new StaticResourceExtension();
		StaticResourceExtension val39 = new StaticResourceExtension();
		AppThemeBindingExtension val40 = new AppThemeBindingExtension();
		Label val41 = new Label();
		StaticResourceExtension val42 = new StaticResourceExtension();
		StaticResourceExtension val43 = new StaticResourceExtension();
		AppThemeBindingExtension val44 = new AppThemeBindingExtension();
		Label val45 = new Label();
		Switch val46 = new Switch();
		StaticResourceExtension val47 = new StaticResourceExtension();
		StaticResourceExtension val48 = new StaticResourceExtension();
		AppThemeBindingExtension val49 = new AppThemeBindingExtension();
		Label val50 = new Label();
		Switch val51 = new Switch();
		StaticResourceExtension val52 = new StaticResourceExtension();
		StaticResourceExtension val53 = new StaticResourceExtension();
		AppThemeBindingExtension val54 = new AppThemeBindingExtension();
		Label val55 = new Label();
		Switch val56 = new Switch();
		Grid val57 = new Grid();
		StaticResourceExtension val58 = new StaticResourceExtension();
		StaticResourceExtension val59 = new StaticResourceExtension();
		AppThemeBindingExtension val60 = new AppThemeBindingExtension();
		Label val61 = new Label();
		VerticalStackLayout val62 = new VerticalStackLayout();
		Frame val63 = new Frame();
		StaticResourceExtension val64 = new StaticResourceExtension();
		StaticResourceExtension val65 = new StaticResourceExtension();
		StaticResourceExtension val66 = new StaticResourceExtension();
		AppThemeBindingExtension val67 = new AppThemeBindingExtension();
		Label val68 = new Label();
		StaticResourceExtension val69 = new StaticResourceExtension();
		StaticResourceExtension val70 = new StaticResourceExtension();
		AppThemeBindingExtension val71 = new AppThemeBindingExtension();
		Label val72 = new Label();
		StaticResourceExtension val73 = new StaticResourceExtension();
		Slider val74 = new Slider();
		StaticResourceExtension val75 = new StaticResourceExtension();
		StaticResourceExtension val76 = new StaticResourceExtension();
		AppThemeBindingExtension val77 = new AppThemeBindingExtension();
		Label val78 = new Label();
		StaticResourceExtension val79 = new StaticResourceExtension();
		StaticResourceExtension val80 = new StaticResourceExtension();
		AppThemeBindingExtension val81 = new AppThemeBindingExtension();
		Label val82 = new Label();
		Slider val83 = new Slider();
		StaticResourceExtension val84 = new StaticResourceExtension();
		StaticResourceExtension val85 = new StaticResourceExtension();
		AppThemeBindingExtension val86 = new AppThemeBindingExtension();
		Label val87 = new Label();
		VerticalStackLayout val88 = new VerticalStackLayout();
		Frame val89 = new Frame();
		StaticResourceExtension val90 = new StaticResourceExtension();
		StaticResourceExtension val91 = new StaticResourceExtension();
		StaticResourceExtension val92 = new StaticResourceExtension();
		AppThemeBindingExtension val93 = new AppThemeBindingExtension();
		Label val94 = new Label();
		Stepper val95 = new Stepper();
		StaticResourceExtension val96 = new StaticResourceExtension();
		StaticResourceExtension val97 = new StaticResourceExtension();
		AppThemeBindingExtension val98 = new AppThemeBindingExtension();
		Label val99 = new Label();
		HorizontalStackLayout val100 = new HorizontalStackLayout();
		VerticalStackLayout val101 = new VerticalStackLayout();
		Frame val102 = new Frame();
		VerticalStackLayout val103 = new VerticalStackLayout();
		ScrollView val104 = new ScrollView();
		SelectionPage selectionPage;
		NameScope val105 = (NameScope)(((object)NameScope.GetNameScope((BindableObject)(object)(selectionPage = this))) ?? ((object)new NameScope()));
		NameScope.SetNameScope((BindableObject)(object)selectionPage, (INameScope)(object)val105);
		((Element)val104).transientNamescope = (INameScope)(object)val105;
		((Element)val103).transientNamescope = (INameScope)(object)val105;
		((Element)val7).transientNamescope = (INameScope)(object)val105;
		((Element)val36).transientNamescope = (INameScope)(object)val105;
		((Element)val35).transientNamescope = (INameScope)(object)val105;
		((Element)val12).transientNamescope = (INameScope)(object)val105;
		((Element)val18).transientNamescope = (INameScope)(object)val105;
		((Element)val13).transientNamescope = (INameScope)(object)val105;
		((INameScope)val105).RegisterName("CheckBox1", (object)val13);
		if (((Element)val13).StyleId == null)
		{
			((Element)val13).StyleId = "CheckBox1";
		}
		((Element)val17).transientNamescope = (INameScope)(object)val105;
		((Element)val24).transientNamescope = (INameScope)(object)val105;
		((Element)val19).transientNamescope = (INameScope)(object)val105;
		((INameScope)val105).RegisterName("CheckBox2", (object)val19);
		if (((Element)val19).StyleId == null)
		{
			((Element)val19).StyleId = "CheckBox2";
		}
		((Element)val23).transientNamescope = (INameScope)(object)val105;
		((Element)val30).transientNamescope = (INameScope)(object)val105;
		((Element)val25).transientNamescope = (INameScope)(object)val105;
		((Element)val29).transientNamescope = (INameScope)(object)val105;
		((Element)val34).transientNamescope = (INameScope)(object)val105;
		((INameScope)val105).RegisterName("CheckBoxOutput", (object)val34);
		if (((Element)val34).StyleId == null)
		{
			((Element)val34).StyleId = "CheckBoxOutput";
		}
		((Element)val63).transientNamescope = (INameScope)(object)val105;
		((Element)val62).transientNamescope = (INameScope)(object)val105;
		((Element)val41).transientNamescope = (INameScope)(object)val105;
		((Element)val57).transientNamescope = (INameScope)(object)val105;
		((Element)val45).transientNamescope = (INameScope)(object)val105;
		((Element)val46).transientNamescope = (INameScope)(object)val105;
		((INameScope)val105).RegisterName("NotifSwitch", (object)val46);
		if (((Element)val46).StyleId == null)
		{
			((Element)val46).StyleId = "NotifSwitch";
		}
		((Element)val50).transientNamescope = (INameScope)(object)val105;
		((Element)val51).transientNamescope = (INameScope)(object)val105;
		((Element)val55).transientNamescope = (INameScope)(object)val105;
		((Element)val56).transientNamescope = (INameScope)(object)val105;
		((Element)val61).transientNamescope = (INameScope)(object)val105;
		((INameScope)val105).RegisterName("SwitchOutput", (object)val61);
		if (((Element)val61).StyleId == null)
		{
			((Element)val61).StyleId = "SwitchOutput";
		}
		((Element)val89).transientNamescope = (INameScope)(object)val105;
		((Element)val88).transientNamescope = (INameScope)(object)val105;
		((Element)val68).transientNamescope = (INameScope)(object)val105;
		((Element)val72).transientNamescope = (INameScope)(object)val105;
		((Element)val74).transientNamescope = (INameScope)(object)val105;
		((INameScope)val105).RegisterName("VolumeSlider", (object)val74);
		if (((Element)val74).StyleId == null)
		{
			((Element)val74).StyleId = "VolumeSlider";
		}
		((Element)val78).transientNamescope = (INameScope)(object)val105;
		((INameScope)val105).RegisterName("VolumeLabel", (object)val78);
		if (((Element)val78).StyleId == null)
		{
			((Element)val78).StyleId = "VolumeLabel";
		}
		((Element)val82).transientNamescope = (INameScope)(object)val105;
		((Element)val83).transientNamescope = (INameScope)(object)val105;
		((Element)val87).transientNamescope = (INameScope)(object)val105;
		((INameScope)val105).RegisterName("BrightnessLabel", (object)val87);
		if (((Element)val87).StyleId == null)
		{
			((Element)val87).StyleId = "BrightnessLabel";
		}
		((Element)val102).transientNamescope = (INameScope)(object)val105;
		((Element)val101).transientNamescope = (INameScope)(object)val105;
		((Element)val94).transientNamescope = (INameScope)(object)val105;
		((Element)val100).transientNamescope = (INameScope)(object)val105;
		((Element)val95).transientNamescope = (INameScope)(object)val105;
		((INameScope)val105).RegisterName("QuantityStepper", (object)val95);
		if (((Element)val95).StyleId == null)
		{
			((Element)val95).StyleId = "QuantityStepper";
		}
		((Element)val99).transientNamescope = (INameScope)(object)val105;
		((INameScope)val105).RegisterName("StepperLabel", (object)val99);
		if (((Element)val99).StyleId == null)
		{
			((Element)val99).StyleId = "StepperLabel";
		}
		CheckBox1 = val13;
		CheckBox2 = val19;
		CheckBoxOutput = val34;
		NotifSwitch = val46;
		SwitchOutput = val61;
		VolumeSlider = val74;
		VolumeLabel = val78;
		BrightnessLabel = val87;
		QuantityStepper = val95;
		StepperLabel = val99;
		((BindableObject)selectionPage).SetValue(Page.TitleProperty, (object)"Selection");
		val.Key = "PageBackgroundLight";
		StaticResourceExtension val106 = new StaticResourceExtension
		{
			Key = "PageBackgroundLight"
		};
		XamlServiceProvider val107 = new XamlServiceProvider();
		Type? typeFromHandle = typeof(IProvideValueTarget);
		object[] array = new object[0 + 2];
		array[0] = val3;
		array[1] = selectionPage;
		SimpleValueTargetProvider val108 = new SimpleValueTargetProvider(array, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Light"), (INameScope[])(object)new NameScope[3] { val105, val105, val105 }, false);
		object obj = (object)val108;
		val107.Add(typeFromHandle, (object)val108);
		val107.Add(typeof(IReferenceProvider), obj);
		val107.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(6, 14)));
		object light = val106.ProvideValue((IServiceProvider)val107);
		val3.Light = light;
		val2.Key = "PageBackgroundDark";
		StaticResourceExtension val109 = new StaticResourceExtension
		{
			Key = "PageBackgroundDark"
		};
		XamlServiceProvider val110 = new XamlServiceProvider();
		Type? typeFromHandle2 = typeof(IProvideValueTarget);
		object[] array2 = new object[0 + 2];
		array2[0] = val3;
		array2[1] = selectionPage;
		SimpleValueTargetProvider val111 = new SimpleValueTargetProvider(array2, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Dark"), (INameScope[])(object)new NameScope[3] { val105, val105, val105 }, false);
		object obj2 = (object)val111;
		val110.Add(typeFromHandle2, (object)val111);
		val110.Add(typeof(IReferenceProvider), obj2);
		val110.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(6, 14)));
		object dark = val109.ProvideValue((IServiceProvider)val110);
		val3.Dark = dark;
		XamlServiceProvider val112 = new XamlServiceProvider();
		val112.Add(typeof(IProvideValueTarget), (object)new ValueTargetProvider((object)selectionPage, (object)VisualElement.BackgroundColorProperty));
		val112.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(6, 14)));
		BindingBase val113 = ((IMarkupExtension<BindingBase>)(object)val3).ProvideValue((IServiceProvider)val112);
		((BindableObject)selectionPage).SetBinding(VisualElement.BackgroundColorProperty, val113);
		((BindableObject)val103).SetValue(Layout.PaddingProperty, (object)new Thickness(20.0));
		((BindableObject)val103).SetValue(StackBase.SpacingProperty, (object)20.0);
		((BindableObject)val7).SetValue(Label.TextProperty, (object)"Selection Controls");
		((BindableObject)val7).SetValue(Label.FontSizeProperty, (object)24.0);
		((BindableObject)val7).SetValue(Label.FontAttributesProperty, (object)(FontAttributes)1);
		val4.Key = "TextPrimaryLight";
		StaticResourceExtension val114 = new StaticResourceExtension
		{
			Key = "TextPrimaryLight"
		};
		XamlServiceProvider val115 = new XamlServiceProvider();
		Type? typeFromHandle3 = typeof(IProvideValueTarget);
		object[] array3 = new object[0 + 5];
		array3[0] = val6;
		array3[1] = val7;
		array3[2] = val103;
		array3[3] = val104;
		array3[4] = selectionPage;
		SimpleValueTargetProvider val116 = new SimpleValueTargetProvider(array3, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Light"), (INameScope[])(object)new NameScope[6] { val105, val105, val105, val105, val105, val105 }, false);
		object obj3 = (object)val116;
		val115.Add(typeFromHandle3, (object)val116);
		val115.Add(typeof(IReferenceProvider), obj3);
		val115.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(11, 20)));
		object light2 = val114.ProvideValue((IServiceProvider)val115);
		val6.Light = light2;
		val5.Key = "TextPrimaryDark";
		StaticResourceExtension val117 = new StaticResourceExtension
		{
			Key = "TextPrimaryDark"
		};
		XamlServiceProvider val118 = new XamlServiceProvider();
		Type? typeFromHandle4 = typeof(IProvideValueTarget);
		object[] array4 = new object[0 + 5];
		array4[0] = val6;
		array4[1] = val7;
		array4[2] = val103;
		array4[3] = val104;
		array4[4] = selectionPage;
		SimpleValueTargetProvider val119 = new SimpleValueTargetProvider(array4, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Dark"), (INameScope[])(object)new NameScope[6] { val105, val105, val105, val105, val105, val105 }, false);
		object obj4 = (object)val119;
		val118.Add(typeFromHandle4, (object)val119);
		val118.Add(typeof(IReferenceProvider), obj4);
		val118.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(11, 20)));
		object dark2 = val117.ProvideValue((IServiceProvider)val118);
		val6.Dark = dark2;
		XamlServiceProvider val120 = new XamlServiceProvider();
		val120.Add(typeof(IProvideValueTarget), (object)new ValueTargetProvider((object)val7, (object)Label.TextColorProperty));
		val120.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(11, 20)));
		BindingBase val121 = ((IMarkupExtension<BindingBase>)(object)val6).ProvideValue((IServiceProvider)val120);
		((BindableObject)val7).SetBinding(Label.TextColorProperty, val121);
		((Layout)val103).Children.Add((IView)(object)val7);
		val8.Key = "ThemedFrame";
		StaticResourceExtension val122 = new StaticResourceExtension
		{
			Key = "ThemedFrame"
		};
		XamlServiceProvider val123 = new XamlServiceProvider();
		Type? typeFromHandle5 = typeof(IProvideValueTarget);
		object[] array5 = new object[0 + 4];
		array5[0] = val36;
		array5[1] = val103;
		array5[2] = val104;
		array5[3] = selectionPage;
		SimpleValueTargetProvider val124 = new SimpleValueTargetProvider(array5, (object)VisualElement.StyleProperty, (INameScope[])(object)new NameScope[5] { val105, val105, val105, val105, val105 }, false);
		object obj5 = (object)val124;
		val123.Add(typeFromHandle5, (object)val124);
		val123.Add(typeof(IReferenceProvider), obj5);
		val123.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(14, 20)));
		object obj6 = val122.ProvideValue((IServiceProvider)val123);
		((BindableObject)val36).SetValue(VisualElement.StyleProperty, (obj6 == null || !typeof(BindingBase).IsAssignableFrom(obj6.GetType())) ? obj6 : obj6);
		((BindableObject)val36).SetValue(Frame.CornerRadiusProperty, (object)8f);
		((BindableObject)val36).SetValue(Layout.PaddingProperty, (object)new Thickness(15.0));
		((BindableObject)val35).SetValue(StackBase.SpacingProperty, (object)10.0);
		((BindableObject)val12).SetValue(Label.TextProperty, (object)"CheckBox");
		((BindableObject)val12).SetValue(Label.FontSizeProperty, (object)18.0);
		((BindableObject)val12).SetValue(Label.FontAttributesProperty, (object)(FontAttributes)1);
		val9.Key = "TextPrimaryLight";
		StaticResourceExtension val125 = new StaticResourceExtension
		{
			Key = "TextPrimaryLight"
		};
		XamlServiceProvider val126 = new XamlServiceProvider();
		Type? typeFromHandle6 = typeof(IProvideValueTarget);
		object[] array6 = new object[0 + 7];
		array6[0] = val11;
		array6[1] = val12;
		array6[2] = val35;
		array6[3] = val36;
		array6[4] = val103;
		array6[5] = val104;
		array6[6] = selectionPage;
		SimpleValueTargetProvider val127 = new SimpleValueTargetProvider(array6, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Light"), (INameScope[])(object)new NameScope[8] { val105, val105, val105, val105, val105, val105, val105, val105 }, false);
		object obj7 = (object)val127;
		val126.Add(typeFromHandle6, (object)val127);
		val126.Add(typeof(IReferenceProvider), obj7);
		val126.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(17, 28)));
		object light3 = val125.ProvideValue((IServiceProvider)val126);
		val11.Light = light3;
		val10.Key = "TextPrimaryDark";
		StaticResourceExtension val128 = new StaticResourceExtension
		{
			Key = "TextPrimaryDark"
		};
		XamlServiceProvider val129 = new XamlServiceProvider();
		Type? typeFromHandle7 = typeof(IProvideValueTarget);
		object[] array7 = new object[0 + 7];
		array7[0] = val11;
		array7[1] = val12;
		array7[2] = val35;
		array7[3] = val36;
		array7[4] = val103;
		array7[5] = val104;
		array7[6] = selectionPage;
		SimpleValueTargetProvider val130 = new SimpleValueTargetProvider(array7, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Dark"), (INameScope[])(object)new NameScope[8] { val105, val105, val105, val105, val105, val105, val105, val105 }, false);
		object obj8 = (object)val130;
		val129.Add(typeFromHandle7, (object)val130);
		val129.Add(typeof(IReferenceProvider), obj8);
		val129.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(17, 28)));
		object dark3 = val128.ProvideValue((IServiceProvider)val129);
		val11.Dark = dark3;
		XamlServiceProvider val131 = new XamlServiceProvider();
		val131.Add(typeof(IProvideValueTarget), (object)new ValueTargetProvider((object)val12, (object)Label.TextColorProperty));
		val131.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(17, 28)));
		BindingBase val132 = ((IMarkupExtension<BindingBase>)(object)val11).ProvideValue((IServiceProvider)val131);
		((BindableObject)val12).SetBinding(Label.TextColorProperty, val132);
		((Layout)val35).Children.Add((IView)(object)val12);
		((BindableObject)val18).SetValue(StackBase.SpacingProperty, (object)10.0);
		val13.CheckedChanged += selectionPage.OnCheckBoxChanged;
		((Layout)val18).Children.Add((IView)(object)val13);
		((BindableObject)val17).SetValue(Label.TextProperty, (object)"Option 1");
		((BindableObject)val17).SetValue(View.VerticalOptionsProperty, (object)LayoutOptions.Center);
		val14.Key = "TextPrimaryLight";
		StaticResourceExtension val133 = new StaticResourceExtension
		{
			Key = "TextPrimaryLight"
		};
		XamlServiceProvider val134 = new XamlServiceProvider();
		Type? typeFromHandle8 = typeof(IProvideValueTarget);
		object[] array8 = new object[0 + 8];
		array8[0] = val16;
		array8[1] = val17;
		array8[2] = val18;
		array8[3] = val35;
		array8[4] = val36;
		array8[5] = val103;
		array8[6] = val104;
		array8[7] = selectionPage;
		SimpleValueTargetProvider val135 = new SimpleValueTargetProvider(array8, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Light"), (INameScope[])(object)new NameScope[9] { val105, val105, val105, val105, val105, val105, val105, val105, val105 }, false);
		object obj9 = (object)val135;
		val134.Add(typeFromHandle8, (object)val135);
		val134.Add(typeof(IReferenceProvider), obj9);
		val134.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(22, 32)));
		object light4 = val133.ProvideValue((IServiceProvider)val134);
		val16.Light = light4;
		val15.Key = "TextPrimaryDark";
		StaticResourceExtension val136 = new StaticResourceExtension
		{
			Key = "TextPrimaryDark"
		};
		XamlServiceProvider val137 = new XamlServiceProvider();
		Type? typeFromHandle9 = typeof(IProvideValueTarget);
		object[] array9 = new object[0 + 8];
		array9[0] = val16;
		array9[1] = val17;
		array9[2] = val18;
		array9[3] = val35;
		array9[4] = val36;
		array9[5] = val103;
		array9[6] = val104;
		array9[7] = selectionPage;
		SimpleValueTargetProvider val138 = new SimpleValueTargetProvider(array9, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Dark"), (INameScope[])(object)new NameScope[9] { val105, val105, val105, val105, val105, val105, val105, val105, val105 }, false);
		object obj10 = (object)val138;
		val137.Add(typeFromHandle9, (object)val138);
		val137.Add(typeof(IReferenceProvider), obj10);
		val137.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(22, 32)));
		object dark4 = val136.ProvideValue((IServiceProvider)val137);
		val16.Dark = dark4;
		XamlServiceProvider val139 = new XamlServiceProvider();
		val139.Add(typeof(IProvideValueTarget), (object)new ValueTargetProvider((object)val17, (object)Label.TextColorProperty));
		val139.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(22, 32)));
		BindingBase val140 = ((IMarkupExtension<BindingBase>)(object)val16).ProvideValue((IServiceProvider)val139);
		((BindableObject)val17).SetBinding(Label.TextColorProperty, val140);
		((Layout)val18).Children.Add((IView)(object)val17);
		((Layout)val35).Children.Add((IView)(object)val18);
		((BindableObject)val24).SetValue(StackBase.SpacingProperty, (object)10.0);
		((BindableObject)val19).SetValue(CheckBox.IsCheckedProperty, (object)true);
		val19.CheckedChanged += selectionPage.OnCheckBoxChanged;
		((Layout)val24).Children.Add((IView)(object)val19);
		((BindableObject)val23).SetValue(Label.TextProperty, (object)"Option 2 (checked)");
		((BindableObject)val23).SetValue(View.VerticalOptionsProperty, (object)LayoutOptions.Center);
		val20.Key = "TextPrimaryLight";
		StaticResourceExtension val141 = new StaticResourceExtension
		{
			Key = "TextPrimaryLight"
		};
		XamlServiceProvider val142 = new XamlServiceProvider();
		Type? typeFromHandle10 = typeof(IProvideValueTarget);
		object[] array10 = new object[0 + 8];
		array10[0] = val22;
		array10[1] = val23;
		array10[2] = val24;
		array10[3] = val35;
		array10[4] = val36;
		array10[5] = val103;
		array10[6] = val104;
		array10[7] = selectionPage;
		SimpleValueTargetProvider val143 = new SimpleValueTargetProvider(array10, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Light"), (INameScope[])(object)new NameScope[9] { val105, val105, val105, val105, val105, val105, val105, val105, val105 }, false);
		object obj11 = (object)val143;
		val142.Add(typeFromHandle10, (object)val143);
		val142.Add(typeof(IReferenceProvider), obj11);
		val142.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(28, 32)));
		object light5 = val141.ProvideValue((IServiceProvider)val142);
		val22.Light = light5;
		val21.Key = "TextPrimaryDark";
		StaticResourceExtension val144 = new StaticResourceExtension
		{
			Key = "TextPrimaryDark"
		};
		XamlServiceProvider val145 = new XamlServiceProvider();
		Type? typeFromHandle11 = typeof(IProvideValueTarget);
		object[] array11 = new object[0 + 8];
		array11[0] = val22;
		array11[1] = val23;
		array11[2] = val24;
		array11[3] = val35;
		array11[4] = val36;
		array11[5] = val103;
		array11[6] = val104;
		array11[7] = selectionPage;
		SimpleValueTargetProvider val146 = new SimpleValueTargetProvider(array11, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Dark"), (INameScope[])(object)new NameScope[9] { val105, val105, val105, val105, val105, val105, val105, val105, val105 }, false);
		object obj12 = (object)val146;
		val145.Add(typeFromHandle11, (object)val146);
		val145.Add(typeof(IReferenceProvider), obj12);
		val145.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(28, 32)));
		object dark5 = val144.ProvideValue((IServiceProvider)val145);
		val22.Dark = dark5;
		XamlServiceProvider val147 = new XamlServiceProvider();
		val147.Add(typeof(IProvideValueTarget), (object)new ValueTargetProvider((object)val23, (object)Label.TextColorProperty));
		val147.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(28, 32)));
		BindingBase val148 = ((IMarkupExtension<BindingBase>)(object)val22).ProvideValue((IServiceProvider)val147);
		((BindableObject)val23).SetBinding(Label.TextColorProperty, val148);
		((Layout)val24).Children.Add((IView)(object)val23);
		((Layout)val35).Children.Add((IView)(object)val24);
		((BindableObject)val30).SetValue(StackBase.SpacingProperty, (object)10.0);
		((BindableObject)val25).SetValue(VisualElement.IsEnabledProperty, (object)false);
		((Layout)val30).Children.Add((IView)(object)val25);
		((BindableObject)val29).SetValue(Label.TextProperty, (object)"Disabled");
		((BindableObject)val29).SetValue(View.VerticalOptionsProperty, (object)LayoutOptions.Center);
		val26.Key = "TextSecondaryLight";
		StaticResourceExtension val149 = new StaticResourceExtension
		{
			Key = "TextSecondaryLight"
		};
		XamlServiceProvider val150 = new XamlServiceProvider();
		Type? typeFromHandle12 = typeof(IProvideValueTarget);
		object[] array12 = new object[0 + 8];
		array12[0] = val28;
		array12[1] = val29;
		array12[2] = val30;
		array12[3] = val35;
		array12[4] = val36;
		array12[5] = val103;
		array12[6] = val104;
		array12[7] = selectionPage;
		SimpleValueTargetProvider val151 = new SimpleValueTargetProvider(array12, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Light"), (INameScope[])(object)new NameScope[9] { val105, val105, val105, val105, val105, val105, val105, val105, val105 }, false);
		object obj13 = (object)val151;
		val150.Add(typeFromHandle12, (object)val151);
		val150.Add(typeof(IReferenceProvider), obj13);
		val150.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(34, 32)));
		object light6 = val149.ProvideValue((IServiceProvider)val150);
		val28.Light = light6;
		val27.Key = "TextSecondaryDark";
		StaticResourceExtension val152 = new StaticResourceExtension
		{
			Key = "TextSecondaryDark"
		};
		XamlServiceProvider val153 = new XamlServiceProvider();
		Type? typeFromHandle13 = typeof(IProvideValueTarget);
		object[] array13 = new object[0 + 8];
		array13[0] = val28;
		array13[1] = val29;
		array13[2] = val30;
		array13[3] = val35;
		array13[4] = val36;
		array13[5] = val103;
		array13[6] = val104;
		array13[7] = selectionPage;
		SimpleValueTargetProvider val154 = new SimpleValueTargetProvider(array13, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Dark"), (INameScope[])(object)new NameScope[9] { val105, val105, val105, val105, val105, val105, val105, val105, val105 }, false);
		object obj14 = (object)val154;
		val153.Add(typeFromHandle13, (object)val154);
		val153.Add(typeof(IReferenceProvider), obj14);
		val153.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(34, 32)));
		object dark6 = val152.ProvideValue((IServiceProvider)val153);
		val28.Dark = dark6;
		XamlServiceProvider val155 = new XamlServiceProvider();
		val155.Add(typeof(IProvideValueTarget), (object)new ValueTargetProvider((object)val29, (object)Label.TextColorProperty));
		val155.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(34, 32)));
		BindingBase val156 = ((IMarkupExtension<BindingBase>)(object)val28).ProvideValue((IServiceProvider)val155);
		((BindableObject)val29).SetBinding(Label.TextColorProperty, val156);
		((Layout)val30).Children.Add((IView)(object)val29);
		((Layout)val35).Children.Add((IView)(object)val30);
		((BindableObject)val34).SetValue(Label.FontSizeProperty, (object)12.0);
		val31.Key = "TextSecondaryLight";
		StaticResourceExtension val157 = new StaticResourceExtension
		{
			Key = "TextSecondaryLight"
		};
		XamlServiceProvider val158 = new XamlServiceProvider();
		Type? typeFromHandle14 = typeof(IProvideValueTarget);
		object[] array14 = new object[0 + 7];
		array14[0] = val33;
		array14[1] = val34;
		array14[2] = val35;
		array14[3] = val36;
		array14[4] = val103;
		array14[5] = val104;
		array14[6] = selectionPage;
		SimpleValueTargetProvider val159 = new SimpleValueTargetProvider(array14, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Light"), (INameScope[])(object)new NameScope[8] { val105, val105, val105, val105, val105, val105, val105, val105 }, false);
		object obj15 = (object)val159;
		val158.Add(typeFromHandle14, (object)val159);
		val158.Add(typeof(IReferenceProvider), obj15);
		val158.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(38, 28)));
		object light7 = val157.ProvideValue((IServiceProvider)val158);
		val33.Light = light7;
		val32.Key = "TextSecondaryDark";
		StaticResourceExtension val160 = new StaticResourceExtension
		{
			Key = "TextSecondaryDark"
		};
		XamlServiceProvider val161 = new XamlServiceProvider();
		Type? typeFromHandle15 = typeof(IProvideValueTarget);
		object[] array15 = new object[0 + 7];
		array15[0] = val33;
		array15[1] = val34;
		array15[2] = val35;
		array15[3] = val36;
		array15[4] = val103;
		array15[5] = val104;
		array15[6] = selectionPage;
		SimpleValueTargetProvider val162 = new SimpleValueTargetProvider(array15, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Dark"), (INameScope[])(object)new NameScope[8] { val105, val105, val105, val105, val105, val105, val105, val105 }, false);
		object obj16 = (object)val162;
		val161.Add(typeFromHandle15, (object)val162);
		val161.Add(typeof(IReferenceProvider), obj16);
		val161.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(38, 28)));
		object dark7 = val160.ProvideValue((IServiceProvider)val161);
		val33.Dark = dark7;
		XamlServiceProvider val163 = new XamlServiceProvider();
		val163.Add(typeof(IProvideValueTarget), (object)new ValueTargetProvider((object)val34, (object)Label.TextColorProperty));
		val163.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(38, 28)));
		BindingBase val164 = ((IMarkupExtension<BindingBase>)(object)val33).ProvideValue((IServiceProvider)val163);
		((BindableObject)val34).SetBinding(Label.TextColorProperty, val164);
		((Layout)val35).Children.Add((IView)(object)val34);
		((BindableObject)val36).SetValue(ContentView.ContentProperty, (object)val35);
		((Layout)val103).Children.Add((IView)(object)val36);
		val37.Key = "ThemedFrame";
		StaticResourceExtension val165 = new StaticResourceExtension
		{
			Key = "ThemedFrame"
		};
		XamlServiceProvider val166 = new XamlServiceProvider();
		Type? typeFromHandle16 = typeof(IProvideValueTarget);
		object[] array16 = new object[0 + 4];
		array16[0] = val63;
		array16[1] = val103;
		array16[2] = val104;
		array16[3] = selectionPage;
		SimpleValueTargetProvider val167 = new SimpleValueTargetProvider(array16, (object)VisualElement.StyleProperty, (INameScope[])(object)new NameScope[5] { val105, val105, val105, val105, val105 }, false);
		object obj17 = (object)val167;
		val166.Add(typeFromHandle16, (object)val167);
		val166.Add(typeof(IReferenceProvider), obj17);
		val166.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(43, 20)));
		object obj18 = val165.ProvideValue((IServiceProvider)val166);
		((BindableObject)val63).SetValue(VisualElement.StyleProperty, (obj18 == null || !typeof(BindingBase).IsAssignableFrom(obj18.GetType())) ? obj18 : obj18);
		((BindableObject)val63).SetValue(Frame.CornerRadiusProperty, (object)8f);
		((BindableObject)val63).SetValue(Layout.PaddingProperty, (object)new Thickness(15.0));
		((BindableObject)val62).SetValue(StackBase.SpacingProperty, (object)10.0);
		((BindableObject)val41).SetValue(Label.TextProperty, (object)"Switch");
		((BindableObject)val41).SetValue(Label.FontSizeProperty, (object)18.0);
		((BindableObject)val41).SetValue(Label.FontAttributesProperty, (object)(FontAttributes)1);
		val38.Key = "TextPrimaryLight";
		StaticResourceExtension val168 = new StaticResourceExtension
		{
			Key = "TextPrimaryLight"
		};
		XamlServiceProvider val169 = new XamlServiceProvider();
		Type? typeFromHandle17 = typeof(IProvideValueTarget);
		object[] array17 = new object[0 + 7];
		array17[0] = val40;
		array17[1] = val41;
		array17[2] = val62;
		array17[3] = val63;
		array17[4] = val103;
		array17[5] = val104;
		array17[6] = selectionPage;
		SimpleValueTargetProvider val170 = new SimpleValueTargetProvider(array17, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Light"), (INameScope[])(object)new NameScope[8] { val105, val105, val105, val105, val105, val105, val105, val105 }, false);
		object obj19 = (object)val170;
		val169.Add(typeFromHandle17, (object)val170);
		val169.Add(typeof(IReferenceProvider), obj19);
		val169.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(46, 28)));
		object light8 = val168.ProvideValue((IServiceProvider)val169);
		val40.Light = light8;
		val39.Key = "TextPrimaryDark";
		StaticResourceExtension val171 = new StaticResourceExtension
		{
			Key = "TextPrimaryDark"
		};
		XamlServiceProvider val172 = new XamlServiceProvider();
		Type? typeFromHandle18 = typeof(IProvideValueTarget);
		object[] array18 = new object[0 + 7];
		array18[0] = val40;
		array18[1] = val41;
		array18[2] = val62;
		array18[3] = val63;
		array18[4] = val103;
		array18[5] = val104;
		array18[6] = selectionPage;
		SimpleValueTargetProvider val173 = new SimpleValueTargetProvider(array18, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Dark"), (INameScope[])(object)new NameScope[8] { val105, val105, val105, val105, val105, val105, val105, val105 }, false);
		object obj20 = (object)val173;
		val172.Add(typeFromHandle18, (object)val173);
		val172.Add(typeof(IReferenceProvider), obj20);
		val172.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(46, 28)));
		object dark8 = val171.ProvideValue((IServiceProvider)val172);
		val40.Dark = dark8;
		XamlServiceProvider val174 = new XamlServiceProvider();
		val174.Add(typeof(IProvideValueTarget), (object)new ValueTargetProvider((object)val41, (object)Label.TextColorProperty));
		val174.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(46, 28)));
		BindingBase val175 = ((IMarkupExtension<BindingBase>)(object)val40).ProvideValue((IServiceProvider)val174);
		((BindableObject)val41).SetBinding(Label.TextColorProperty, val175);
		((Layout)val62).Children.Add((IView)(object)val41);
		((BindableObject)val57).SetValue(Grid.ColumnDefinitionsProperty, (object)new ColumnDefinitionCollection((ColumnDefinition[])(object)new ColumnDefinition[2]
		{
			new ColumnDefinition(GridLength.Star),
			new ColumnDefinition(GridLength.Auto)
		}));
		((BindableObject)val57).SetValue(Grid.RowDefinitionsProperty, (object)new RowDefinitionCollection((RowDefinition[])(object)new RowDefinition[3]
		{
			new RowDefinition(GridLength.Auto),
			new RowDefinition(GridLength.Auto),
			new RowDefinition(GridLength.Auto)
		}));
		((BindableObject)val57).SetValue(Grid.RowSpacingProperty, (object)10.0);
		((BindableObject)val45).SetValue(Label.TextProperty, (object)"Enable notifications");
		((BindableObject)val45).SetValue(View.VerticalOptionsProperty, (object)LayoutOptions.Center);
		val42.Key = "TextPrimaryLight";
		StaticResourceExtension val176 = new StaticResourceExtension
		{
			Key = "TextPrimaryLight"
		};
		XamlServiceProvider val177 = new XamlServiceProvider();
		Type? typeFromHandle19 = typeof(IProvideValueTarget);
		object[] array19 = new object[0 + 8];
		array19[0] = val44;
		array19[1] = val45;
		array19[2] = val57;
		array19[3] = val62;
		array19[4] = val63;
		array19[5] = val103;
		array19[6] = val104;
		array19[7] = selectionPage;
		SimpleValueTargetProvider val178 = new SimpleValueTargetProvider(array19, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Light"), (INameScope[])(object)new NameScope[9] { val105, val105, val105, val105, val105, val105, val105, val105, val105 }, false);
		object obj21 = (object)val178;
		val177.Add(typeFromHandle19, (object)val178);
		val177.Add(typeof(IReferenceProvider), obj21);
		val177.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(50, 32)));
		object light9 = val176.ProvideValue((IServiceProvider)val177);
		val44.Light = light9;
		val43.Key = "TextPrimaryDark";
		StaticResourceExtension val179 = new StaticResourceExtension
		{
			Key = "TextPrimaryDark"
		};
		XamlServiceProvider val180 = new XamlServiceProvider();
		Type? typeFromHandle20 = typeof(IProvideValueTarget);
		object[] array20 = new object[0 + 8];
		array20[0] = val44;
		array20[1] = val45;
		array20[2] = val57;
		array20[3] = val62;
		array20[4] = val63;
		array20[5] = val103;
		array20[6] = val104;
		array20[7] = selectionPage;
		SimpleValueTargetProvider val181 = new SimpleValueTargetProvider(array20, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Dark"), (INameScope[])(object)new NameScope[9] { val105, val105, val105, val105, val105, val105, val105, val105, val105 }, false);
		object obj22 = (object)val181;
		val180.Add(typeFromHandle20, (object)val181);
		val180.Add(typeof(IReferenceProvider), obj22);
		val180.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(50, 32)));
		object dark9 = val179.ProvideValue((IServiceProvider)val180);
		val44.Dark = dark9;
		XamlServiceProvider val182 = new XamlServiceProvider();
		val182.Add(typeof(IProvideValueTarget), (object)new ValueTargetProvider((object)val45, (object)Label.TextColorProperty));
		val182.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(50, 32)));
		BindingBase val183 = ((IMarkupExtension<BindingBase>)(object)val44).ProvideValue((IServiceProvider)val182);
		((BindableObject)val45).SetBinding(Label.TextColorProperty, val183);
		((Layout)val57).Children.Add((IView)(object)val45);
		((BindableObject)val46).SetValue(Grid.ColumnProperty, (object)1);
		val46.Toggled += selectionPage.OnSwitchToggled;
		((Layout)val57).Children.Add((IView)(object)val46);
		((BindableObject)val50).SetValue(Grid.RowProperty, (object)1);
		((BindableObject)val50).SetValue(Label.TextProperty, (object)"Dark mode");
		((BindableObject)val50).SetValue(View.VerticalOptionsProperty, (object)LayoutOptions.Center);
		val47.Key = "TextPrimaryLight";
		StaticResourceExtension val184 = new StaticResourceExtension
		{
			Key = "TextPrimaryLight"
		};
		XamlServiceProvider val185 = new XamlServiceProvider();
		Type? typeFromHandle21 = typeof(IProvideValueTarget);
		object[] array21 = new object[0 + 8];
		array21[0] = val49;
		array21[1] = val50;
		array21[2] = val57;
		array21[3] = val62;
		array21[4] = val63;
		array21[5] = val103;
		array21[6] = val104;
		array21[7] = selectionPage;
		SimpleValueTargetProvider val186 = new SimpleValueTargetProvider(array21, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Light"), (INameScope[])(object)new NameScope[9] { val105, val105, val105, val105, val105, val105, val105, val105, val105 }, false);
		object obj23 = (object)val186;
		val185.Add(typeFromHandle21, (object)val186);
		val185.Add(typeof(IReferenceProvider), obj23);
		val185.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(54, 32)));
		object light10 = val184.ProvideValue((IServiceProvider)val185);
		val49.Light = light10;
		val48.Key = "TextPrimaryDark";
		StaticResourceExtension val187 = new StaticResourceExtension
		{
			Key = "TextPrimaryDark"
		};
		XamlServiceProvider val188 = new XamlServiceProvider();
		Type? typeFromHandle22 = typeof(IProvideValueTarget);
		object[] array22 = new object[0 + 8];
		array22[0] = val49;
		array22[1] = val50;
		array22[2] = val57;
		array22[3] = val62;
		array22[4] = val63;
		array22[5] = val103;
		array22[6] = val104;
		array22[7] = selectionPage;
		SimpleValueTargetProvider val189 = new SimpleValueTargetProvider(array22, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Dark"), (INameScope[])(object)new NameScope[9] { val105, val105, val105, val105, val105, val105, val105, val105, val105 }, false);
		object obj24 = (object)val189;
		val188.Add(typeFromHandle22, (object)val189);
		val188.Add(typeof(IReferenceProvider), obj24);
		val188.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(54, 32)));
		object dark10 = val187.ProvideValue((IServiceProvider)val188);
		val49.Dark = dark10;
		XamlServiceProvider val190 = new XamlServiceProvider();
		val190.Add(typeof(IProvideValueTarget), (object)new ValueTargetProvider((object)val50, (object)Label.TextColorProperty));
		val190.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(54, 32)));
		BindingBase val191 = ((IMarkupExtension<BindingBase>)(object)val49).ProvideValue((IServiceProvider)val190);
		((BindableObject)val50).SetBinding(Label.TextColorProperty, val191);
		((Layout)val57).Children.Add((IView)(object)val50);
		((BindableObject)val51).SetValue(Grid.RowProperty, (object)1);
		((BindableObject)val51).SetValue(Grid.ColumnProperty, (object)1);
		((BindableObject)val51).SetValue(Switch.OnColorProperty, (object)new Color(11f / 85f, 0.5882353f, 81f / 85f, 1f));
		val51.Toggled += selectionPage.OnSwitchToggled;
		((Layout)val57).Children.Add((IView)(object)val51);
		((BindableObject)val55).SetValue(Grid.RowProperty, (object)2);
		((BindableObject)val55).SetValue(Label.TextProperty, (object)"Disabled switch");
		((BindableObject)val55).SetValue(View.VerticalOptionsProperty, (object)LayoutOptions.Center);
		val52.Key = "TextSecondaryLight";
		StaticResourceExtension val192 = new StaticResourceExtension
		{
			Key = "TextSecondaryLight"
		};
		XamlServiceProvider val193 = new XamlServiceProvider();
		Type? typeFromHandle23 = typeof(IProvideValueTarget);
		object[] array23 = new object[0 + 8];
		array23[0] = val54;
		array23[1] = val55;
		array23[2] = val57;
		array23[3] = val62;
		array23[4] = val63;
		array23[5] = val103;
		array23[6] = val104;
		array23[7] = selectionPage;
		SimpleValueTargetProvider val194 = new SimpleValueTargetProvider(array23, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Light"), (INameScope[])(object)new NameScope[9] { val105, val105, val105, val105, val105, val105, val105, val105, val105 }, false);
		object obj25 = (object)val194;
		val193.Add(typeFromHandle23, (object)val194);
		val193.Add(typeof(IReferenceProvider), obj25);
		val193.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(58, 32)));
		object light11 = val192.ProvideValue((IServiceProvider)val193);
		val54.Light = light11;
		val53.Key = "TextSecondaryDark";
		StaticResourceExtension val195 = new StaticResourceExtension
		{
			Key = "TextSecondaryDark"
		};
		XamlServiceProvider val196 = new XamlServiceProvider();
		Type? typeFromHandle24 = typeof(IProvideValueTarget);
		object[] array24 = new object[0 + 8];
		array24[0] = val54;
		array24[1] = val55;
		array24[2] = val57;
		array24[3] = val62;
		array24[4] = val63;
		array24[5] = val103;
		array24[6] = val104;
		array24[7] = selectionPage;
		SimpleValueTargetProvider val197 = new SimpleValueTargetProvider(array24, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Dark"), (INameScope[])(object)new NameScope[9] { val105, val105, val105, val105, val105, val105, val105, val105, val105 }, false);
		object obj26 = (object)val197;
		val196.Add(typeFromHandle24, (object)val197);
		val196.Add(typeof(IReferenceProvider), obj26);
		val196.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(58, 32)));
		object dark11 = val195.ProvideValue((IServiceProvider)val196);
		val54.Dark = dark11;
		XamlServiceProvider val198 = new XamlServiceProvider();
		val198.Add(typeof(IProvideValueTarget), (object)new ValueTargetProvider((object)val55, (object)Label.TextColorProperty));
		val198.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(58, 32)));
		BindingBase val199 = ((IMarkupExtension<BindingBase>)(object)val54).ProvideValue((IServiceProvider)val198);
		((BindableObject)val55).SetBinding(Label.TextColorProperty, val199);
		((Layout)val57).Children.Add((IView)(object)val55);
		((BindableObject)val56).SetValue(Grid.RowProperty, (object)2);
		((BindableObject)val56).SetValue(Grid.ColumnProperty, (object)1);
		((BindableObject)val56).SetValue(VisualElement.IsEnabledProperty, (object)false);
		((Layout)val57).Children.Add((IView)(object)val56);
		((Layout)val62).Children.Add((IView)(object)val57);
		((BindableObject)val61).SetValue(Label.FontSizeProperty, (object)12.0);
		val58.Key = "TextSecondaryLight";
		StaticResourceExtension val200 = new StaticResourceExtension
		{
			Key = "TextSecondaryLight"
		};
		XamlServiceProvider val201 = new XamlServiceProvider();
		Type? typeFromHandle25 = typeof(IProvideValueTarget);
		object[] array25 = new object[0 + 7];
		array25[0] = val60;
		array25[1] = val61;
		array25[2] = val62;
		array25[3] = val63;
		array25[4] = val103;
		array25[5] = val104;
		array25[6] = selectionPage;
		SimpleValueTargetProvider val202 = new SimpleValueTargetProvider(array25, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Light"), (INameScope[])(object)new NameScope[8] { val105, val105, val105, val105, val105, val105, val105, val105 }, false);
		object obj27 = (object)val202;
		val201.Add(typeFromHandle25, (object)val202);
		val201.Add(typeof(IReferenceProvider), obj27);
		val201.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(63, 28)));
		object light12 = val200.ProvideValue((IServiceProvider)val201);
		val60.Light = light12;
		val59.Key = "TextSecondaryDark";
		StaticResourceExtension val203 = new StaticResourceExtension
		{
			Key = "TextSecondaryDark"
		};
		XamlServiceProvider val204 = new XamlServiceProvider();
		Type? typeFromHandle26 = typeof(IProvideValueTarget);
		object[] array26 = new object[0 + 7];
		array26[0] = val60;
		array26[1] = val61;
		array26[2] = val62;
		array26[3] = val63;
		array26[4] = val103;
		array26[5] = val104;
		array26[6] = selectionPage;
		SimpleValueTargetProvider val205 = new SimpleValueTargetProvider(array26, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Dark"), (INameScope[])(object)new NameScope[8] { val105, val105, val105, val105, val105, val105, val105, val105 }, false);
		object obj28 = (object)val205;
		val204.Add(typeFromHandle26, (object)val205);
		val204.Add(typeof(IReferenceProvider), obj28);
		val204.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(63, 28)));
		object dark12 = val203.ProvideValue((IServiceProvider)val204);
		val60.Dark = dark12;
		XamlServiceProvider val206 = new XamlServiceProvider();
		val206.Add(typeof(IProvideValueTarget), (object)new ValueTargetProvider((object)val61, (object)Label.TextColorProperty));
		val206.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(63, 28)));
		BindingBase val207 = ((IMarkupExtension<BindingBase>)(object)val60).ProvideValue((IServiceProvider)val206);
		((BindableObject)val61).SetBinding(Label.TextColorProperty, val207);
		((Layout)val62).Children.Add((IView)(object)val61);
		((BindableObject)val63).SetValue(ContentView.ContentProperty, (object)val62);
		((Layout)val103).Children.Add((IView)(object)val63);
		val64.Key = "ThemedFrame";
		StaticResourceExtension val208 = new StaticResourceExtension
		{
			Key = "ThemedFrame"
		};
		XamlServiceProvider val209 = new XamlServiceProvider();
		Type? typeFromHandle27 = typeof(IProvideValueTarget);
		object[] array27 = new object[0 + 4];
		array27[0] = val89;
		array27[1] = val103;
		array27[2] = val104;
		array27[3] = selectionPage;
		SimpleValueTargetProvider val210 = new SimpleValueTargetProvider(array27, (object)VisualElement.StyleProperty, (INameScope[])(object)new NameScope[5] { val105, val105, val105, val105, val105 }, false);
		object obj29 = (object)val210;
		val209.Add(typeFromHandle27, (object)val210);
		val209.Add(typeof(IReferenceProvider), obj29);
		val209.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(68, 20)));
		object obj30 = val208.ProvideValue((IServiceProvider)val209);
		((BindableObject)val89).SetValue(VisualElement.StyleProperty, (obj30 == null || !typeof(BindingBase).IsAssignableFrom(obj30.GetType())) ? obj30 : obj30);
		((BindableObject)val89).SetValue(Frame.CornerRadiusProperty, (object)8f);
		((BindableObject)val89).SetValue(Layout.PaddingProperty, (object)new Thickness(15.0));
		((BindableObject)val88).SetValue(StackBase.SpacingProperty, (object)10.0);
		((BindableObject)val68).SetValue(Label.TextProperty, (object)"Slider");
		((BindableObject)val68).SetValue(Label.FontSizeProperty, (object)18.0);
		((BindableObject)val68).SetValue(Label.FontAttributesProperty, (object)(FontAttributes)1);
		val65.Key = "TextPrimaryLight";
		StaticResourceExtension val211 = new StaticResourceExtension
		{
			Key = "TextPrimaryLight"
		};
		XamlServiceProvider val212 = new XamlServiceProvider();
		Type? typeFromHandle28 = typeof(IProvideValueTarget);
		object[] array28 = new object[0 + 7];
		array28[0] = val67;
		array28[1] = val68;
		array28[2] = val88;
		array28[3] = val89;
		array28[4] = val103;
		array28[5] = val104;
		array28[6] = selectionPage;
		SimpleValueTargetProvider val213 = new SimpleValueTargetProvider(array28, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Light"), (INameScope[])(object)new NameScope[8] { val105, val105, val105, val105, val105, val105, val105, val105 }, false);
		object obj31 = (object)val213;
		val212.Add(typeFromHandle28, (object)val213);
		val212.Add(typeof(IReferenceProvider), obj31);
		val212.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(71, 28)));
		object light13 = val211.ProvideValue((IServiceProvider)val212);
		val67.Light = light13;
		val66.Key = "TextPrimaryDark";
		StaticResourceExtension val214 = new StaticResourceExtension
		{
			Key = "TextPrimaryDark"
		};
		XamlServiceProvider val215 = new XamlServiceProvider();
		Type? typeFromHandle29 = typeof(IProvideValueTarget);
		object[] array29 = new object[0 + 7];
		array29[0] = val67;
		array29[1] = val68;
		array29[2] = val88;
		array29[3] = val89;
		array29[4] = val103;
		array29[5] = val104;
		array29[6] = selectionPage;
		SimpleValueTargetProvider val216 = new SimpleValueTargetProvider(array29, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Dark"), (INameScope[])(object)new NameScope[8] { val105, val105, val105, val105, val105, val105, val105, val105 }, false);
		object obj32 = (object)val216;
		val215.Add(typeFromHandle29, (object)val216);
		val215.Add(typeof(IReferenceProvider), obj32);
		val215.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(71, 28)));
		object dark13 = val214.ProvideValue((IServiceProvider)val215);
		val67.Dark = dark13;
		XamlServiceProvider val217 = new XamlServiceProvider();
		val217.Add(typeof(IProvideValueTarget), (object)new ValueTargetProvider((object)val68, (object)Label.TextColorProperty));
		val217.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(71, 28)));
		BindingBase val218 = ((IMarkupExtension<BindingBase>)(object)val67).ProvideValue((IServiceProvider)val217);
		((BindableObject)val68).SetBinding(Label.TextColorProperty, val218);
		((Layout)val88).Children.Add((IView)(object)val68);
		((BindableObject)val72).SetValue(Label.TextProperty, (object)"Volume");
		val69.Key = "TextPrimaryLight";
		StaticResourceExtension val219 = new StaticResourceExtension
		{
			Key = "TextPrimaryLight"
		};
		XamlServiceProvider val220 = new XamlServiceProvider();
		Type? typeFromHandle30 = typeof(IProvideValueTarget);
		object[] array30 = new object[0 + 7];
		array30[0] = val71;
		array30[1] = val72;
		array30[2] = val88;
		array30[3] = val89;
		array30[4] = val103;
		array30[5] = val104;
		array30[6] = selectionPage;
		SimpleValueTargetProvider val221 = new SimpleValueTargetProvider(array30, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Light"), (INameScope[])(object)new NameScope[8] { val105, val105, val105, val105, val105, val105, val105, val105 }, false);
		object obj33 = (object)val221;
		val220.Add(typeFromHandle30, (object)val221);
		val220.Add(typeof(IReferenceProvider), obj33);
		val220.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(73, 42)));
		object light14 = val219.ProvideValue((IServiceProvider)val220);
		val71.Light = light14;
		val70.Key = "TextPrimaryDark";
		StaticResourceExtension val222 = new StaticResourceExtension
		{
			Key = "TextPrimaryDark"
		};
		XamlServiceProvider val223 = new XamlServiceProvider();
		Type? typeFromHandle31 = typeof(IProvideValueTarget);
		object[] array31 = new object[0 + 7];
		array31[0] = val71;
		array31[1] = val72;
		array31[2] = val88;
		array31[3] = val89;
		array31[4] = val103;
		array31[5] = val104;
		array31[6] = selectionPage;
		SimpleValueTargetProvider val224 = new SimpleValueTargetProvider(array31, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Dark"), (INameScope[])(object)new NameScope[8] { val105, val105, val105, val105, val105, val105, val105, val105 }, false);
		object obj34 = (object)val224;
		val223.Add(typeFromHandle31, (object)val224);
		val223.Add(typeof(IReferenceProvider), obj34);
		val223.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(73, 42)));
		object dark14 = val222.ProvideValue((IServiceProvider)val223);
		val71.Dark = dark14;
		XamlServiceProvider val225 = new XamlServiceProvider();
		val225.Add(typeof(IProvideValueTarget), (object)new ValueTargetProvider((object)val72, (object)Label.TextColorProperty));
		val225.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(73, 42)));
		BindingBase val226 = ((IMarkupExtension<BindingBase>)(object)val71).ProvideValue((IServiceProvider)val225);
		((BindableObject)val72).SetBinding(Label.TextColorProperty, val226);
		((Layout)val88).Children.Add((IView)(object)val72);
		((BindableObject)val74).SetValue(Slider.MinimumProperty, (object)0.0);
		((BindableObject)val74).SetValue(Slider.MaximumProperty, (object)100.0);
		((BindableObject)val74).SetValue(Slider.ValueProperty, (object)50.0);
		val73.Key = "PrimaryColor";
		StaticResourceExtension val227 = new StaticResourceExtension
		{
			Key = "PrimaryColor"
		};
		XamlServiceProvider val228 = new XamlServiceProvider();
		Type? typeFromHandle32 = typeof(IProvideValueTarget);
		object[] array32 = new object[0 + 6];
		array32[0] = val74;
		array32[1] = val88;
		array32[2] = val89;
		array32[3] = val103;
		array32[4] = val104;
		array32[5] = selectionPage;
		SimpleValueTargetProvider val229 = new SimpleValueTargetProvider(array32, (object)Slider.MinimumTrackColorProperty, (INameScope[])(object)new NameScope[7] { val105, val105, val105, val105, val105, val105, val105 }, false);
		object obj35 = (object)val229;
		val228.Add(typeFromHandle32, (object)val229);
		val228.Add(typeof(IReferenceProvider), obj35);
		val228.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(75, 29)));
		object obj36 = val227.ProvideValue((IServiceProvider)val228);
		((BindableObject)val74).SetValue(Slider.MinimumTrackColorProperty, (obj36 == null || !typeof(BindingBase).IsAssignableFrom(obj36.GetType())) ? obj36 : obj36);
		val74.ValueChanged += selectionPage.OnSliderValueChanged;
		((Layout)val88).Children.Add((IView)(object)val74);
		((BindableObject)val78).SetValue(Label.TextProperty, (object)"50%");
		((BindableObject)val78).SetValue(View.HorizontalOptionsProperty, (object)LayoutOptions.End);
		val75.Key = "TextSecondaryLight";
		StaticResourceExtension val230 = new StaticResourceExtension
		{
			Key = "TextSecondaryLight"
		};
		XamlServiceProvider val231 = new XamlServiceProvider();
		Type? typeFromHandle33 = typeof(IProvideValueTarget);
		object[] array33 = new object[0 + 7];
		array33[0] = val77;
		array33[1] = val78;
		array33[2] = val88;
		array33[3] = val89;
		array33[4] = val103;
		array33[5] = val104;
		array33[6] = selectionPage;
		SimpleValueTargetProvider val232 = new SimpleValueTargetProvider(array33, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Light"), (INameScope[])(object)new NameScope[8] { val105, val105, val105, val105, val105, val105, val105, val105 }, false);
		object obj37 = (object)val232;
		val231.Add(typeFromHandle33, (object)val232);
		val231.Add(typeof(IReferenceProvider), obj37);
		val231.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(78, 28)));
		object light15 = val230.ProvideValue((IServiceProvider)val231);
		val77.Light = light15;
		val76.Key = "TextSecondaryDark";
		StaticResourceExtension val233 = new StaticResourceExtension
		{
			Key = "TextSecondaryDark"
		};
		XamlServiceProvider val234 = new XamlServiceProvider();
		Type? typeFromHandle34 = typeof(IProvideValueTarget);
		object[] array34 = new object[0 + 7];
		array34[0] = val77;
		array34[1] = val78;
		array34[2] = val88;
		array34[3] = val89;
		array34[4] = val103;
		array34[5] = val104;
		array34[6] = selectionPage;
		SimpleValueTargetProvider val235 = new SimpleValueTargetProvider(array34, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Dark"), (INameScope[])(object)new NameScope[8] { val105, val105, val105, val105, val105, val105, val105, val105 }, false);
		object obj38 = (object)val235;
		val234.Add(typeFromHandle34, (object)val235);
		val234.Add(typeof(IReferenceProvider), obj38);
		val234.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(78, 28)));
		object dark15 = val233.ProvideValue((IServiceProvider)val234);
		val77.Dark = dark15;
		XamlServiceProvider val236 = new XamlServiceProvider();
		val236.Add(typeof(IProvideValueTarget), (object)new ValueTargetProvider((object)val78, (object)Label.TextColorProperty));
		val236.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(78, 28)));
		BindingBase val237 = ((IMarkupExtension<BindingBase>)(object)val77).ProvideValue((IServiceProvider)val236);
		((BindableObject)val78).SetBinding(Label.TextColorProperty, val237);
		((Layout)val88).Children.Add((IView)(object)val78);
		((BindableObject)val82).SetValue(Label.TextProperty, (object)"Brightness");
		val79.Key = "TextPrimaryLight";
		StaticResourceExtension val238 = new StaticResourceExtension
		{
			Key = "TextPrimaryLight"
		};
		XamlServiceProvider val239 = new XamlServiceProvider();
		Type? typeFromHandle35 = typeof(IProvideValueTarget);
		object[] array35 = new object[0 + 7];
		array35[0] = val81;
		array35[1] = val82;
		array35[2] = val88;
		array35[3] = val89;
		array35[4] = val103;
		array35[5] = val104;
		array35[6] = selectionPage;
		SimpleValueTargetProvider val240 = new SimpleValueTargetProvider(array35, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Light"), (INameScope[])(object)new NameScope[8] { val105, val105, val105, val105, val105, val105, val105, val105 }, false);
		object obj39 = (object)val240;
		val239.Add(typeFromHandle35, (object)val240);
		val239.Add(typeof(IReferenceProvider), obj39);
		val239.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(80, 46)));
		object light16 = val238.ProvideValue((IServiceProvider)val239);
		val81.Light = light16;
		val80.Key = "TextPrimaryDark";
		StaticResourceExtension val241 = new StaticResourceExtension
		{
			Key = "TextPrimaryDark"
		};
		XamlServiceProvider val242 = new XamlServiceProvider();
		Type? typeFromHandle36 = typeof(IProvideValueTarget);
		object[] array36 = new object[0 + 7];
		array36[0] = val81;
		array36[1] = val82;
		array36[2] = val88;
		array36[3] = val89;
		array36[4] = val103;
		array36[5] = val104;
		array36[6] = selectionPage;
		SimpleValueTargetProvider val243 = new SimpleValueTargetProvider(array36, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Dark"), (INameScope[])(object)new NameScope[8] { val105, val105, val105, val105, val105, val105, val105, val105 }, false);
		object obj40 = (object)val243;
		val242.Add(typeFromHandle36, (object)val243);
		val242.Add(typeof(IReferenceProvider), obj40);
		val242.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(80, 46)));
		object dark16 = val241.ProvideValue((IServiceProvider)val242);
		val81.Dark = dark16;
		XamlServiceProvider val244 = new XamlServiceProvider();
		val244.Add(typeof(IProvideValueTarget), (object)new ValueTargetProvider((object)val82, (object)Label.TextColorProperty));
		val244.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(80, 46)));
		BindingBase val245 = ((IMarkupExtension<BindingBase>)(object)val81).ProvideValue((IServiceProvider)val244);
		((BindableObject)val82).SetBinding(Label.TextColorProperty, val245);
		((Layout)val88).Children.Add((IView)(object)val82);
		((BindableObject)val83).SetValue(Slider.MinimumProperty, (object)0.0);
		((BindableObject)val83).SetValue(Slider.MaximumProperty, (object)100.0);
		((BindableObject)val83).SetValue(Slider.ValueProperty, (object)75.0);
		((BindableObject)val83).SetValue(Slider.MinimumTrackColorProperty, (object)new Color(1f, 0.59607846f, 0f, 1f));
		val83.ValueChanged += selectionPage.OnBrightnessChanged;
		((Layout)val88).Children.Add((IView)(object)val83);
		((BindableObject)val87).SetValue(Label.TextProperty, (object)"75%");
		((BindableObject)val87).SetValue(View.HorizontalOptionsProperty, (object)LayoutOptions.End);
		val84.Key = "TextSecondaryLight";
		StaticResourceExtension val246 = new StaticResourceExtension
		{
			Key = "TextSecondaryLight"
		};
		XamlServiceProvider val247 = new XamlServiceProvider();
		Type? typeFromHandle37 = typeof(IProvideValueTarget);
		object[] array37 = new object[0 + 7];
		array37[0] = val86;
		array37[1] = val87;
		array37[2] = val88;
		array37[3] = val89;
		array37[4] = val103;
		array37[5] = val104;
		array37[6] = selectionPage;
		SimpleValueTargetProvider val248 = new SimpleValueTargetProvider(array37, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Light"), (INameScope[])(object)new NameScope[8] { val105, val105, val105, val105, val105, val105, val105, val105 }, false);
		object obj41 = (object)val248;
		val247.Add(typeFromHandle37, (object)val248);
		val247.Add(typeof(IReferenceProvider), obj41);
		val247.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(85, 28)));
		object light17 = val246.ProvideValue((IServiceProvider)val247);
		val86.Light = light17;
		val85.Key = "TextSecondaryDark";
		StaticResourceExtension val249 = new StaticResourceExtension
		{
			Key = "TextSecondaryDark"
		};
		XamlServiceProvider val250 = new XamlServiceProvider();
		Type? typeFromHandle38 = typeof(IProvideValueTarget);
		object[] array38 = new object[0 + 7];
		array38[0] = val86;
		array38[1] = val87;
		array38[2] = val88;
		array38[3] = val89;
		array38[4] = val103;
		array38[5] = val104;
		array38[6] = selectionPage;
		SimpleValueTargetProvider val251 = new SimpleValueTargetProvider(array38, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Dark"), (INameScope[])(object)new NameScope[8] { val105, val105, val105, val105, val105, val105, val105, val105 }, false);
		object obj42 = (object)val251;
		val250.Add(typeFromHandle38, (object)val251);
		val250.Add(typeof(IReferenceProvider), obj42);
		val250.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(85, 28)));
		object dark17 = val249.ProvideValue((IServiceProvider)val250);
		val86.Dark = dark17;
		XamlServiceProvider val252 = new XamlServiceProvider();
		val252.Add(typeof(IProvideValueTarget), (object)new ValueTargetProvider((object)val87, (object)Label.TextColorProperty));
		val252.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(85, 28)));
		BindingBase val253 = ((IMarkupExtension<BindingBase>)(object)val86).ProvideValue((IServiceProvider)val252);
		((BindableObject)val87).SetBinding(Label.TextColorProperty, val253);
		((Layout)val88).Children.Add((IView)(object)val87);
		((BindableObject)val89).SetValue(ContentView.ContentProperty, (object)val88);
		((Layout)val103).Children.Add((IView)(object)val89);
		val90.Key = "ThemedFrame";
		StaticResourceExtension val254 = new StaticResourceExtension
		{
			Key = "ThemedFrame"
		};
		XamlServiceProvider val255 = new XamlServiceProvider();
		Type? typeFromHandle39 = typeof(IProvideValueTarget);
		object[] array39 = new object[0 + 4];
		array39[0] = val102;
		array39[1] = val103;
		array39[2] = val104;
		array39[3] = selectionPage;
		SimpleValueTargetProvider val256 = new SimpleValueTargetProvider(array39, (object)VisualElement.StyleProperty, (INameScope[])(object)new NameScope[5] { val105, val105, val105, val105, val105 }, false);
		object obj43 = (object)val256;
		val255.Add(typeFromHandle39, (object)val256);
		val255.Add(typeof(IReferenceProvider), obj43);
		val255.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(90, 20)));
		object obj44 = val254.ProvideValue((IServiceProvider)val255);
		((BindableObject)val102).SetValue(VisualElement.StyleProperty, (obj44 == null || !typeof(BindingBase).IsAssignableFrom(obj44.GetType())) ? obj44 : obj44);
		((BindableObject)val102).SetValue(Frame.CornerRadiusProperty, (object)8f);
		((BindableObject)val102).SetValue(Layout.PaddingProperty, (object)new Thickness(15.0));
		((BindableObject)val101).SetValue(StackBase.SpacingProperty, (object)10.0);
		((BindableObject)val94).SetValue(Label.TextProperty, (object)"Stepper");
		((BindableObject)val94).SetValue(Label.FontSizeProperty, (object)18.0);
		((BindableObject)val94).SetValue(Label.FontAttributesProperty, (object)(FontAttributes)1);
		val91.Key = "TextPrimaryLight";
		StaticResourceExtension val257 = new StaticResourceExtension
		{
			Key = "TextPrimaryLight"
		};
		XamlServiceProvider val258 = new XamlServiceProvider();
		Type? typeFromHandle40 = typeof(IProvideValueTarget);
		object[] array40 = new object[0 + 7];
		array40[0] = val93;
		array40[1] = val94;
		array40[2] = val101;
		array40[3] = val102;
		array40[4] = val103;
		array40[5] = val104;
		array40[6] = selectionPage;
		SimpleValueTargetProvider val259 = new SimpleValueTargetProvider(array40, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Light"), (INameScope[])(object)new NameScope[8] { val105, val105, val105, val105, val105, val105, val105, val105 }, false);
		object obj45 = (object)val259;
		val258.Add(typeFromHandle40, (object)val259);
		val258.Add(typeof(IReferenceProvider), obj45);
		val258.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(93, 28)));
		object light18 = val257.ProvideValue((IServiceProvider)val258);
		val93.Light = light18;
		val92.Key = "TextPrimaryDark";
		StaticResourceExtension val260 = new StaticResourceExtension
		{
			Key = "TextPrimaryDark"
		};
		XamlServiceProvider val261 = new XamlServiceProvider();
		Type? typeFromHandle41 = typeof(IProvideValueTarget);
		object[] array41 = new object[0 + 7];
		array41[0] = val93;
		array41[1] = val94;
		array41[2] = val101;
		array41[3] = val102;
		array41[4] = val103;
		array41[5] = val104;
		array41[6] = selectionPage;
		SimpleValueTargetProvider val262 = new SimpleValueTargetProvider(array41, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Dark"), (INameScope[])(object)new NameScope[8] { val105, val105, val105, val105, val105, val105, val105, val105 }, false);
		object obj46 = (object)val262;
		val261.Add(typeFromHandle41, (object)val262);
		val261.Add(typeof(IReferenceProvider), obj46);
		val261.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(93, 28)));
		object dark18 = val260.ProvideValue((IServiceProvider)val261);
		val93.Dark = dark18;
		XamlServiceProvider val263 = new XamlServiceProvider();
		val263.Add(typeof(IProvideValueTarget), (object)new ValueTargetProvider((object)val94, (object)Label.TextColorProperty));
		val263.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(93, 28)));
		BindingBase val264 = ((IMarkupExtension<BindingBase>)(object)val93).ProvideValue((IServiceProvider)val263);
		((BindableObject)val94).SetBinding(Label.TextColorProperty, val264);
		((Layout)val101).Children.Add((IView)(object)val94);
		((BindableObject)val100).SetValue(StackBase.SpacingProperty, (object)15.0);
		((BindableObject)val100).SetValue(View.HorizontalOptionsProperty, (object)LayoutOptions.Center);
		((BindableObject)val95).SetValue(Stepper.MinimumProperty, (object)0.0);
		((BindableObject)val95).SetValue(Stepper.MaximumProperty, (object)10.0);
		((BindableObject)val95).SetValue(Stepper.IncrementProperty, (object)1.0);
		((BindableObject)val95).SetValue(Stepper.ValueProperty, (object)1.0);
		val95.ValueChanged += selectionPage.OnStepperChanged;
		((Layout)val100).Children.Add((IView)(object)val95);
		((BindableObject)val99).SetValue(Label.TextProperty, (object)"Quantity: 1");
		((BindableObject)val99).SetValue(View.VerticalOptionsProperty, (object)LayoutOptions.Center);
		((BindableObject)val99).SetValue(Label.FontSizeProperty, (object)16.0);
		val96.Key = "TextPrimaryLight";
		StaticResourceExtension val265 = new StaticResourceExtension
		{
			Key = "TextPrimaryLight"
		};
		XamlServiceProvider val266 = new XamlServiceProvider();
		Type? typeFromHandle42 = typeof(IProvideValueTarget);
		object[] array42 = new object[0 + 8];
		array42[0] = val98;
		array42[1] = val99;
		array42[2] = val100;
		array42[3] = val101;
		array42[4] = val102;
		array42[5] = val103;
		array42[6] = val104;
		array42[7] = selectionPage;
		SimpleValueTargetProvider val267 = new SimpleValueTargetProvider(array42, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Light"), (INameScope[])(object)new NameScope[9] { val105, val105, val105, val105, val105, val105, val105, val105, val105 }, false);
		object obj47 = (object)val267;
		val266.Add(typeFromHandle42, (object)val267);
		val266.Add(typeof(IReferenceProvider), obj47);
		val266.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(99, 32)));
		object light19 = val265.ProvideValue((IServiceProvider)val266);
		val98.Light = light19;
		val97.Key = "TextPrimaryDark";
		StaticResourceExtension val268 = new StaticResourceExtension
		{
			Key = "TextPrimaryDark"
		};
		XamlServiceProvider val269 = new XamlServiceProvider();
		Type? typeFromHandle43 = typeof(IProvideValueTarget);
		object[] array43 = new object[0 + 8];
		array43[0] = val98;
		array43[1] = val99;
		array43[2] = val100;
		array43[3] = val101;
		array43[4] = val102;
		array43[5] = val103;
		array43[6] = val104;
		array43[7] = selectionPage;
		SimpleValueTargetProvider val270 = new SimpleValueTargetProvider(array43, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Dark"), (INameScope[])(object)new NameScope[9] { val105, val105, val105, val105, val105, val105, val105, val105, val105 }, false);
		object obj48 = (object)val270;
		val269.Add(typeFromHandle43, (object)val270);
		val269.Add(typeof(IReferenceProvider), obj48);
		val269.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(99, 32)));
		object dark19 = val268.ProvideValue((IServiceProvider)val269);
		val98.Dark = dark19;
		XamlServiceProvider val271 = new XamlServiceProvider();
		val271.Add(typeof(IProvideValueTarget), (object)new ValueTargetProvider((object)val99, (object)Label.TextColorProperty));
		val271.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(99, 32)));
		BindingBase val272 = ((IMarkupExtension<BindingBase>)(object)val98).ProvideValue((IServiceProvider)val271);
		((BindableObject)val99).SetBinding(Label.TextColorProperty, val272);
		((Layout)val100).Children.Add((IView)(object)val99);
		((Layout)val101).Children.Add((IView)(object)val100);
		((BindableObject)val102).SetValue(ContentView.ContentProperty, (object)val101);
		((Layout)val103).Children.Add((IView)(object)val102);
		val104.Content = (View)(object)val103;
		((BindableObject)selectionPage).SetValue(ContentPage.ContentProperty, (object)val104);
	}
}
