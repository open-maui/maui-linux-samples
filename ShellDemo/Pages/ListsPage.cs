using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Xml;
using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Compatibility;
using Microsoft.Maui.Controls.Internals;
using Microsoft.Maui.Controls.Xaml;
using Microsoft.Maui.Controls.Xaml.Internals;
using Microsoft.Maui.Graphics;

namespace ShellDemo;

[XamlFilePath("Pages/ListsPage.xaml")]
public class ListsPage : ContentPage
{
	public record ListItem(string Name, string Description, string Price, Color Color);

	[CompilerGenerated]
	private sealed class _003CInitializeComponent_003E_anonXamlCDataTemplate_0
	{
		internal object[] parentValues;

		internal ListsPage root;

		internal NameScope _scope0;

		internal NameScope _scope1;

		internal NameScope _scope2;

		internal NameScope _scope3;

		internal NameScope _scope4;

		internal NameScope _scope5;

		internal NameScope _scope6;

		internal NameScope _scope7;

		internal NameScope _scope8;

		internal NameScope _scope9;

		internal NameScope _scope10;

		internal NameScope _scope11;

		internal NameScope _scope12;

		internal NameScope _scope13;

		internal NameScope _scope14;

		internal NameScope _scope15;

		internal NameScope _scope16;

		internal NameScope _scope17;

		internal NameScope _scope18;

		internal NameScope _scope19;

		internal NameScope _scope20;

		internal NameScope _scope21;

		internal NameScope _scope22;

		internal NameScope _scope23;

		internal NameScope _scope24;

		internal NameScope _scope25;

		internal NameScope _scope26;

		internal NameScope _scope27;

		internal NameScope _scope28;

		internal NameScope _scope29;

		internal NameScope _scope30;

		internal NameScope _scope31;

		internal NameScope _scope32;

		internal NameScope _scope33;

		internal NameScope _scope34;

		internal NameScope _scope35;

		internal NameScope _scope36;

		internal NameScope _scope37;

		internal NameScope _scope38;

		internal NameScope _scope39;

		internal NameScope _scope40;

		internal NameScope _scope41;

		internal NameScope _scope42;

		internal NameScope _scope43;

		internal NameScope _scope44;

		internal NameScope _scope45;

		internal NameScope _scope46;

		internal NameScope _scope47;

		internal NameScope _scope48;

		internal NameScope _scope49;

		internal NameScope _scope50;

		internal object LoadDataTemplate()
		{
			//IL_0195: Unknown result type (might be due to invalid IL or missing references)
			//IL_019c: Expected O, but got Unknown
			//IL_019c: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a3: Expected O, but got Unknown
			//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_01aa: Expected O, but got Unknown
			//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b1: Expected O, but got Unknown
			//IL_01b1: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b8: Expected O, but got Unknown
			//IL_01b8: Unknown result type (might be due to invalid IL or missing references)
			//IL_01bf: Expected O, but got Unknown
			//IL_01bf: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c6: Expected O, but got Unknown
			//IL_01c6: Unknown result type (might be due to invalid IL or missing references)
			//IL_01cd: Expected O, but got Unknown
			//IL_01cd: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d4: Expected O, but got Unknown
			//IL_01d4: Unknown result type (might be due to invalid IL or missing references)
			//IL_01db: Expected O, but got Unknown
			//IL_01db: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e2: Expected O, but got Unknown
			//IL_01e2: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e9: Expected O, but got Unknown
			//IL_01e9: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f0: Expected O, but got Unknown
			//IL_01f0: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f7: Expected O, but got Unknown
			//IL_01f7: Unknown result type (might be due to invalid IL or missing references)
			//IL_01fe: Expected O, but got Unknown
			//IL_01fe: Unknown result type (might be due to invalid IL or missing references)
			//IL_0205: Expected O, but got Unknown
			//IL_0205: Unknown result type (might be due to invalid IL or missing references)
			//IL_020c: Expected O, but got Unknown
			//IL_020c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0213: Expected O, but got Unknown
			//IL_0213: Unknown result type (might be due to invalid IL or missing references)
			//IL_021a: Expected O, but got Unknown
			//IL_021a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0221: Expected O, but got Unknown
			//IL_0221: Unknown result type (might be due to invalid IL or missing references)
			//IL_0228: Expected O, but got Unknown
			//IL_0228: Unknown result type (might be due to invalid IL or missing references)
			//IL_022f: Expected O, but got Unknown
			//IL_022f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0236: Expected O, but got Unknown
			//IL_0236: Unknown result type (might be due to invalid IL or missing references)
			//IL_023d: Expected O, but got Unknown
			//IL_023d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0244: Expected O, but got Unknown
			//IL_029c: Unknown result type (might be due to invalid IL or missing references)
			//IL_02bb: Unknown result type (might be due to invalid IL or missing references)
			//IL_02ec: Unknown result type (might be due to invalid IL or missing references)
			//IL_02f1: Unknown result type (might be due to invalid IL or missing references)
			//IL_02fc: Unknown result type (might be due to invalid IL or missing references)
			//IL_0301: Unknown result type (might be due to invalid IL or missing references)
			//IL_037a: Unknown result type (might be due to invalid IL or missing references)
			//IL_037f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0382: Expected O, but got Unknown
			//IL_0387: Expected O, but got Unknown
			//IL_0387: Unknown result type (might be due to invalid IL or missing references)
			//IL_0399: Unknown result type (might be due to invalid IL or missing references)
			//IL_03a8: Unknown result type (might be due to invalid IL or missing references)
			//IL_03b2: Expected O, but got Unknown
			//IL_03ad: Unknown result type (might be due to invalid IL or missing references)
			//IL_03b7: Expected O, but got Unknown
			//IL_03bc: Expected O, but got Unknown
			//IL_03d3: Unknown result type (might be due to invalid IL or missing references)
			//IL_03d8: Unknown result type (might be due to invalid IL or missing references)
			//IL_03e3: Unknown result type (might be due to invalid IL or missing references)
			//IL_03e8: Unknown result type (might be due to invalid IL or missing references)
			//IL_0461: Unknown result type (might be due to invalid IL or missing references)
			//IL_0466: Unknown result type (might be due to invalid IL or missing references)
			//IL_0469: Expected O, but got Unknown
			//IL_046e: Expected O, but got Unknown
			//IL_046e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0480: Unknown result type (might be due to invalid IL or missing references)
			//IL_048f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0499: Expected O, but got Unknown
			//IL_0494: Unknown result type (might be due to invalid IL or missing references)
			//IL_049e: Expected O, but got Unknown
			//IL_04a3: Expected O, but got Unknown
			//IL_04b0: Unknown result type (might be due to invalid IL or missing references)
			//IL_04b5: Unknown result type (might be due to invalid IL or missing references)
			//IL_04c7: Unknown result type (might be due to invalid IL or missing references)
			//IL_04d1: Expected O, but got Unknown
			//IL_04d1: Unknown result type (might be due to invalid IL or missing references)
			//IL_04e0: Unknown result type (might be due to invalid IL or missing references)
			//IL_04ea: Expected O, but got Unknown
			//IL_04e5: Unknown result type (might be due to invalid IL or missing references)
			//IL_04ef: Expected O, but got Unknown
			//IL_04f4: Expected O, but got Unknown
			//IL_0510: Unknown result type (might be due to invalid IL or missing references)
			//IL_0515: Unknown result type (might be due to invalid IL or missing references)
			//IL_0520: Unknown result type (might be due to invalid IL or missing references)
			//IL_0525: Unknown result type (might be due to invalid IL or missing references)
			//IL_059e: Unknown result type (might be due to invalid IL or missing references)
			//IL_05a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_05a6: Expected O, but got Unknown
			//IL_05ab: Expected O, but got Unknown
			//IL_05ab: Unknown result type (might be due to invalid IL or missing references)
			//IL_05bd: Unknown result type (might be due to invalid IL or missing references)
			//IL_05cc: Unknown result type (might be due to invalid IL or missing references)
			//IL_05d6: Expected O, but got Unknown
			//IL_05d1: Unknown result type (might be due to invalid IL or missing references)
			//IL_05db: Expected O, but got Unknown
			//IL_05e0: Expected O, but got Unknown
			//IL_05f7: Unknown result type (might be due to invalid IL or missing references)
			//IL_05fc: Unknown result type (might be due to invalid IL or missing references)
			//IL_0607: Unknown result type (might be due to invalid IL or missing references)
			//IL_060c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0685: Unknown result type (might be due to invalid IL or missing references)
			//IL_068a: Unknown result type (might be due to invalid IL or missing references)
			//IL_068d: Expected O, but got Unknown
			//IL_0692: Expected O, but got Unknown
			//IL_0692: Unknown result type (might be due to invalid IL or missing references)
			//IL_06a4: Unknown result type (might be due to invalid IL or missing references)
			//IL_06b3: Unknown result type (might be due to invalid IL or missing references)
			//IL_06bd: Expected O, but got Unknown
			//IL_06b8: Unknown result type (might be due to invalid IL or missing references)
			//IL_06c2: Expected O, but got Unknown
			//IL_06c7: Expected O, but got Unknown
			//IL_06d4: Unknown result type (might be due to invalid IL or missing references)
			//IL_06d9: Unknown result type (might be due to invalid IL or missing references)
			//IL_06eb: Unknown result type (might be due to invalid IL or missing references)
			//IL_06f5: Expected O, but got Unknown
			//IL_06f5: Unknown result type (might be due to invalid IL or missing references)
			//IL_0704: Unknown result type (might be due to invalid IL or missing references)
			//IL_070e: Expected O, but got Unknown
			//IL_0709: Unknown result type (might be due to invalid IL or missing references)
			//IL_0713: Expected O, but got Unknown
			//IL_0718: Expected O, but got Unknown
			//IL_0737: Unknown result type (might be due to invalid IL or missing references)
			//IL_073c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0742: Expected O, but got Unknown
			//IL_0744: Unknown result type (might be due to invalid IL or missing references)
			//IL_0749: Unknown result type (might be due to invalid IL or missing references)
			//IL_074f: Expected O, but got Unknown
			//IL_0751: Unknown result type (might be due to invalid IL or missing references)
			//IL_0756: Unknown result type (might be due to invalid IL or missing references)
			//IL_075c: Expected O, but got Unknown
			//IL_075c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0766: Expected O, but got Unknown
			//IL_07aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_07c7: Unknown result type (might be due to invalid IL or missing references)
			//IL_07cc: Unknown result type (might be due to invalid IL or missing references)
			//IL_07d7: Unknown result type (might be due to invalid IL or missing references)
			//IL_07dc: Unknown result type (might be due to invalid IL or missing references)
			//IL_07ec: Unknown result type (might be due to invalid IL or missing references)
			//IL_0810: Expected O, but got Unknown
			//IL_080b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0815: Expected O, but got Unknown
			//IL_081a: Expected O, but got Unknown
			//IL_0863: Unknown result type (might be due to invalid IL or missing references)
			//IL_0879: Unknown result type (might be due to invalid IL or missing references)
			//IL_0896: Unknown result type (might be due to invalid IL or missing references)
			//IL_089b: Unknown result type (might be due to invalid IL or missing references)
			//IL_08a6: Unknown result type (might be due to invalid IL or missing references)
			//IL_08ab: Unknown result type (might be due to invalid IL or missing references)
			//IL_08bb: Unknown result type (might be due to invalid IL or missing references)
			//IL_08df: Expected O, but got Unknown
			//IL_08da: Unknown result type (might be due to invalid IL or missing references)
			//IL_08e4: Expected O, but got Unknown
			//IL_08e9: Expected O, but got Unknown
			//IL_0931: Unknown result type (might be due to invalid IL or missing references)
			//IL_0936: Unknown result type (might be due to invalid IL or missing references)
			//IL_0941: Unknown result type (might be due to invalid IL or missing references)
			//IL_0946: Unknown result type (might be due to invalid IL or missing references)
			//IL_09df: Unknown result type (might be due to invalid IL or missing references)
			//IL_09e4: Unknown result type (might be due to invalid IL or missing references)
			//IL_09e7: Expected O, but got Unknown
			//IL_09ec: Expected O, but got Unknown
			//IL_09ec: Unknown result type (might be due to invalid IL or missing references)
			//IL_09fe: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a0d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a17: Expected O, but got Unknown
			//IL_0a12: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a1c: Expected O, but got Unknown
			//IL_0a21: Expected O, but got Unknown
			//IL_0a38: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a3d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a48: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a4d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ae6: Unknown result type (might be due to invalid IL or missing references)
			//IL_0aeb: Unknown result type (might be due to invalid IL or missing references)
			//IL_0aee: Expected O, but got Unknown
			//IL_0af3: Expected O, but got Unknown
			//IL_0af3: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b05: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b14: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b1e: Expected O, but got Unknown
			//IL_0b19: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b23: Expected O, but got Unknown
			//IL_0b28: Expected O, but got Unknown
			//IL_0b35: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b3a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b4c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b56: Expected O, but got Unknown
			//IL_0b56: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b65: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b6f: Expected O, but got Unknown
			//IL_0b6a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b74: Expected O, but got Unknown
			//IL_0b79: Expected O, but got Unknown
			//IL_0ba5: Unknown result type (might be due to invalid IL or missing references)
			//IL_0baa: Unknown result type (might be due to invalid IL or missing references)
			//IL_0bb5: Unknown result type (might be due to invalid IL or missing references)
			//IL_0bba: Unknown result type (might be due to invalid IL or missing references)
			//IL_0bca: Unknown result type (might be due to invalid IL or missing references)
			//IL_0bee: Expected O, but got Unknown
			//IL_0be9: Unknown result type (might be due to invalid IL or missing references)
			//IL_0bf3: Expected O, but got Unknown
			//IL_0bf8: Expected O, but got Unknown
			//IL_0c2e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c33: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c3e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c43: Unknown result type (might be due to invalid IL or missing references)
			//IL_0cdc: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ce1: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ce4: Expected O, but got Unknown
			//IL_0ce9: Expected O, but got Unknown
			//IL_0ce9: Unknown result type (might be due to invalid IL or missing references)
			//IL_0cfb: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d0a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d14: Expected O, but got Unknown
			//IL_0d0f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d19: Expected O, but got Unknown
			//IL_0d1e: Expected O, but got Unknown
			//IL_0d35: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d3a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d45: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d4a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0de3: Unknown result type (might be due to invalid IL or missing references)
			//IL_0de8: Unknown result type (might be due to invalid IL or missing references)
			//IL_0deb: Expected O, but got Unknown
			//IL_0df0: Expected O, but got Unknown
			//IL_0df0: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e02: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e11: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e1b: Expected O, but got Unknown
			//IL_0e16: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e20: Expected O, but got Unknown
			//IL_0e25: Expected O, but got Unknown
			//IL_0e32: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e37: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e49: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e53: Expected O, but got Unknown
			//IL_0e53: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e62: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e6c: Expected O, but got Unknown
			//IL_0e67: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e71: Expected O, but got Unknown
			//IL_0e76: Expected O, but got Unknown
			//IL_0ec2: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ec7: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ed2: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ed7: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ee7: Unknown result type (might be due to invalid IL or missing references)
			//IL_0f0b: Expected O, but got Unknown
			//IL_0f06: Unknown result type (might be due to invalid IL or missing references)
			//IL_0f10: Expected O, but got Unknown
			//IL_0f15: Expected O, but got Unknown
			//IL_0f58: Unknown result type (might be due to invalid IL or missing references)
			//IL_0f73: Unknown result type (might be due to invalid IL or missing references)
			//IL_0f78: Unknown result type (might be due to invalid IL or missing references)
			//IL_0f83: Unknown result type (might be due to invalid IL or missing references)
			//IL_0f88: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ffc: Unknown result type (might be due to invalid IL or missing references)
			//IL_1001: Unknown result type (might be due to invalid IL or missing references)
			//IL_1004: Expected O, but got Unknown
			//IL_1009: Expected O, but got Unknown
			//IL_1009: Unknown result type (might be due to invalid IL or missing references)
			//IL_101b: Unknown result type (might be due to invalid IL or missing references)
			//IL_102a: Unknown result type (might be due to invalid IL or missing references)
			//IL_1034: Expected O, but got Unknown
			//IL_102f: Unknown result type (might be due to invalid IL or missing references)
			//IL_1039: Expected O, but got Unknown
			//IL_103e: Expected O, but got Unknown
			NameScope val = _scope0;
			NameScope val2 = _scope1;
			NameScope val3 = _scope2;
			NameScope val4 = _scope3;
			NameScope val5 = _scope4;
			NameScope val6 = _scope5;
			NameScope val7 = _scope6;
			NameScope val8 = _scope7;
			NameScope val9 = _scope8;
			NameScope val10 = _scope9;
			NameScope val11 = _scope10;
			NameScope val12 = _scope11;
			NameScope val13 = _scope12;
			NameScope val14 = _scope13;
			NameScope val15 = _scope14;
			NameScope val16 = _scope15;
			NameScope val17 = _scope16;
			NameScope val18 = _scope17;
			NameScope val19 = _scope18;
			NameScope val20 = _scope19;
			NameScope val21 = _scope20;
			NameScope val22 = _scope21;
			NameScope val23 = _scope22;
			NameScope val24 = _scope23;
			NameScope val25 = _scope24;
			NameScope val26 = _scope25;
			NameScope val27 = _scope26;
			NameScope val28 = _scope27;
			NameScope val29 = _scope28;
			NameScope val30 = _scope29;
			NameScope val31 = _scope30;
			NameScope val32 = _scope31;
			NameScope val33 = _scope32;
			NameScope val34 = _scope33;
			NameScope val35 = _scope34;
			NameScope val36 = _scope35;
			NameScope val37 = _scope36;
			NameScope val38 = _scope37;
			NameScope val39 = _scope38;
			NameScope val40 = _scope39;
			NameScope val41 = _scope40;
			NameScope val42 = _scope41;
			NameScope val43 = _scope42;
			NameScope val44 = _scope43;
			NameScope val45 = _scope44;
			NameScope val46 = _scope45;
			NameScope val47 = _scope46;
			NameScope val48 = _scope47;
			NameScope val49 = _scope48;
			NameScope val50 = _scope49;
			NameScope val51 = _scope50;
			StaticResourceExtension val52 = new StaticResourceExtension();
			StaticResourceExtension val53 = new StaticResourceExtension();
			AppThemeBindingExtension val54 = new AppThemeBindingExtension();
			StaticResourceExtension val55 = new StaticResourceExtension();
			StaticResourceExtension val56 = new StaticResourceExtension();
			AppThemeBindingExtension val57 = new AppThemeBindingExtension();
			BindingExtension val58 = new BindingExtension();
			BoxView val59 = new BoxView();
			BindingExtension val60 = new BindingExtension();
			StaticResourceExtension val61 = new StaticResourceExtension();
			StaticResourceExtension val62 = new StaticResourceExtension();
			AppThemeBindingExtension val63 = new AppThemeBindingExtension();
			Label val64 = new Label();
			BindingExtension val65 = new BindingExtension();
			StaticResourceExtension val66 = new StaticResourceExtension();
			StaticResourceExtension val67 = new StaticResourceExtension();
			AppThemeBindingExtension val68 = new AppThemeBindingExtension();
			Label val69 = new Label();
			VerticalStackLayout val70 = new VerticalStackLayout();
			BindingExtension val71 = new BindingExtension();
			StaticResourceExtension val72 = new StaticResourceExtension();
			Label val73 = new Label();
			Grid val74 = new Grid();
			Frame val75 = new Frame();
			NameScope val76 = new NameScope();
			NameScope.SetNameScope((BindableObject)(object)val75, (INameScope)(object)val76);
			((Element)val74).transientNamescope = (INameScope)(object)val76;
			((Element)val59).transientNamescope = (INameScope)(object)val76;
			((Element)val70).transientNamescope = (INameScope)(object)val76;
			((Element)val64).transientNamescope = (INameScope)(object)val76;
			((Element)val69).transientNamescope = (INameScope)(object)val76;
			((Element)val73).transientNamescope = (INameScope)(object)val76;
			((BindableObject)val75).SetValue(View.MarginProperty, (object)new Thickness(0.0, 5.0));
			((BindableObject)val75).SetValue(Layout.PaddingProperty, (object)new Thickness(15.0));
			((BindableObject)val75).SetValue(Frame.CornerRadiusProperty, (object)8f);
			val52.Key = "CardBackgroundLight";
			StaticResourceExtension val77 = new StaticResourceExtension
			{
				Key = "CardBackgroundLight"
			};
			XamlServiceProvider val78 = new XamlServiceProvider();
			Type? typeFromHandle = typeof(IProvideValueTarget);
			int length;
			object[] array = new object[(length = parentValues.Length) + 2];
			Array.Copy(parentValues, 0, array, 2, length);
			array[0] = val54;
			array[1] = val75;
			SimpleValueTargetProvider val79 = new SimpleValueTargetProvider(array, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Light"), (INameScope[])(object)new NameScope[7] { val76, val76, val76, val36, val30, val8, val }, false);
			object obj = (object)val79;
			val78.Add(typeFromHandle, (object)val79);
			val78.Add(typeof(IReferenceProvider), obj);
			val78.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(25, 28)));
			object light = val77.ProvideValue((IServiceProvider)val78);
			val54.Light = light;
			val53.Key = "CardBackgroundDark";
			StaticResourceExtension val80 = new StaticResourceExtension
			{
				Key = "CardBackgroundDark"
			};
			XamlServiceProvider val81 = new XamlServiceProvider();
			Type? typeFromHandle2 = typeof(IProvideValueTarget);
			int length2;
			object[] array2 = new object[(length2 = parentValues.Length) + 2];
			Array.Copy(parentValues, 0, array2, 2, length2);
			array2[0] = val54;
			array2[1] = val75;
			SimpleValueTargetProvider val82 = new SimpleValueTargetProvider(array2, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Dark"), (INameScope[])(object)new NameScope[7] { val76, val76, val76, val36, val30, val8, val }, false);
			object obj2 = (object)val82;
			val81.Add(typeFromHandle2, (object)val82);
			val81.Add(typeof(IReferenceProvider), obj2);
			val81.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(25, 28)));
			object dark = val80.ProvideValue((IServiceProvider)val81);
			val54.Dark = dark;
			XamlServiceProvider val83 = new XamlServiceProvider();
			val83.Add(typeof(IProvideValueTarget), (object)new ValueTargetProvider((object)val75, (object)VisualElement.BackgroundColorProperty));
			val83.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(25, 28)));
			BindingBase val84 = ((IMarkupExtension<BindingBase>)(object)val54).ProvideValue((IServiceProvider)val83);
			((BindableObject)val75).SetBinding(VisualElement.BackgroundColorProperty, val84);
			val55.Key = "BorderLight";
			StaticResourceExtension val85 = new StaticResourceExtension
			{
				Key = "BorderLight"
			};
			XamlServiceProvider val86 = new XamlServiceProvider();
			Type? typeFromHandle3 = typeof(IProvideValueTarget);
			int length3;
			object[] array3 = new object[(length3 = parentValues.Length) + 2];
			Array.Copy(parentValues, 0, array3, 2, length3);
			array3[0] = val57;
			array3[1] = val75;
			SimpleValueTargetProvider val87 = new SimpleValueTargetProvider(array3, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Light"), (INameScope[])(object)new NameScope[7] { val76, val76, val76, val36, val30, val8, val }, false);
			object obj3 = (object)val87;
			val86.Add(typeFromHandle3, (object)val87);
			val86.Add(typeof(IReferenceProvider), obj3);
			val86.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(26, 28)));
			object light2 = val85.ProvideValue((IServiceProvider)val86);
			val57.Light = light2;
			val56.Key = "BorderDark";
			StaticResourceExtension val88 = new StaticResourceExtension
			{
				Key = "BorderDark"
			};
			XamlServiceProvider val89 = new XamlServiceProvider();
			Type? typeFromHandle4 = typeof(IProvideValueTarget);
			int length4;
			object[] array4 = new object[(length4 = parentValues.Length) + 2];
			Array.Copy(parentValues, 0, array4, 2, length4);
			array4[0] = val57;
			array4[1] = val75;
			SimpleValueTargetProvider val90 = new SimpleValueTargetProvider(array4, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Dark"), (INameScope[])(object)new NameScope[7] { val76, val76, val76, val36, val30, val8, val }, false);
			object obj4 = (object)val90;
			val89.Add(typeFromHandle4, (object)val90);
			val89.Add(typeof(IReferenceProvider), obj4);
			val89.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(26, 28)));
			object dark2 = val88.ProvideValue((IServiceProvider)val89);
			val57.Dark = dark2;
			XamlServiceProvider val91 = new XamlServiceProvider();
			val91.Add(typeof(IProvideValueTarget), (object)new ValueTargetProvider((object)val75, (object)Frame.BorderColorProperty));
			val91.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(26, 28)));
			BindingBase val92 = ((IMarkupExtension<BindingBase>)(object)val57).ProvideValue((IServiceProvider)val91);
			((BindableObject)val75).SetBinding(Frame.BorderColorProperty, val92);
			((BindableObject)val74).SetValue(Grid.ColumnDefinitionsProperty, (object)new ColumnDefinitionCollection((ColumnDefinition[])(object)new ColumnDefinition[3]
			{
				new ColumnDefinition(GridLength.Auto),
				new ColumnDefinition(GridLength.Star),
				new ColumnDefinition(GridLength.Auto)
			}));
			((BindableObject)val59).SetValue(VisualElement.WidthRequestProperty, (object)40.0);
			((BindableObject)val59).SetValue(VisualElement.HeightRequestProperty, (object)40.0);
			((BindableObject)val59).SetValue(BoxView.CornerRadiusProperty, (object)new CornerRadius(20.0));
			val58.Path = "Color";
			XamlServiceProvider val93 = new XamlServiceProvider();
			Type? typeFromHandle5 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val94 = new XmlNamespaceResolver();
			val94.Add("", "http://schemas.microsoft.com/dotnet/2021/maui");
			val94.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val93.Add(typeFromHandle5, (object)new XamlTypeResolver((IXmlNamespaceResolver)val94, typeof(_003CInitializeComponent_003E_anonXamlCDataTemplate_0).Assembly));
			BindingBase val95 = ((IMarkupExtension<BindingBase>)(object)val58).ProvideValue((IServiceProvider)val93);
			((BindableObject)val59).SetBinding(BoxView.ColorProperty, val95);
			((Layout)val74).Children.Add((IView)(object)val59);
			((BindableObject)val70).SetValue(Grid.ColumnProperty, (object)1);
			((BindableObject)val70).SetValue(View.MarginProperty, (object)new Thickness(15.0, 0.0));
			((BindableObject)val70).SetValue(View.VerticalOptionsProperty, (object)LayoutOptions.Center);
			val60.Path = "Name";
			XamlServiceProvider val96 = new XamlServiceProvider();
			Type? typeFromHandle6 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val97 = new XmlNamespaceResolver();
			val97.Add("", "http://schemas.microsoft.com/dotnet/2021/maui");
			val97.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val96.Add(typeFromHandle6, (object)new XamlTypeResolver((IXmlNamespaceResolver)val97, typeof(_003CInitializeComponent_003E_anonXamlCDataTemplate_0).Assembly));
			BindingBase val98 = ((IMarkupExtension<BindingBase>)(object)val60).ProvideValue((IServiceProvider)val96);
			((BindableObject)val64).SetBinding(Label.TextProperty, val98);
			((BindableObject)val64).SetValue(Label.FontSizeProperty, (object)16.0);
			((BindableObject)val64).SetValue(Label.FontAttributesProperty, (object)(FontAttributes)1);
			val61.Key = "TextPrimaryLight";
			StaticResourceExtension val99 = new StaticResourceExtension
			{
				Key = "TextPrimaryLight"
			};
			XamlServiceProvider val100 = new XamlServiceProvider();
			Type? typeFromHandle7 = typeof(IProvideValueTarget);
			int length5;
			object[] array5 = new object[(length5 = parentValues.Length) + 5];
			Array.Copy(parentValues, 0, array5, 5, length5);
			array5[0] = val63;
			array5[1] = val64;
			array5[2] = val70;
			array5[3] = val74;
			array5[4] = val75;
			SimpleValueTargetProvider val101 = new SimpleValueTargetProvider(array5, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Light"), (INameScope[])(object)new NameScope[10] { val76, val76, val76, val76, val76, val76, val36, val30, val8, val }, false);
			object obj5 = (object)val101;
			val100.Add(typeFromHandle7, (object)val101);
			val100.Add(typeof(IReferenceProvider), obj5);
			val100.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(32, 40)));
			object light3 = val99.ProvideValue((IServiceProvider)val100);
			val63.Light = light3;
			val62.Key = "TextPrimaryDark";
			StaticResourceExtension val102 = new StaticResourceExtension
			{
				Key = "TextPrimaryDark"
			};
			XamlServiceProvider val103 = new XamlServiceProvider();
			Type? typeFromHandle8 = typeof(IProvideValueTarget);
			int length6;
			object[] array6 = new object[(length6 = parentValues.Length) + 5];
			Array.Copy(parentValues, 0, array6, 5, length6);
			array6[0] = val63;
			array6[1] = val64;
			array6[2] = val70;
			array6[3] = val74;
			array6[4] = val75;
			SimpleValueTargetProvider val104 = new SimpleValueTargetProvider(array6, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Dark"), (INameScope[])(object)new NameScope[10] { val76, val76, val76, val76, val76, val76, val36, val30, val8, val }, false);
			object obj6 = (object)val104;
			val103.Add(typeFromHandle8, (object)val104);
			val103.Add(typeof(IReferenceProvider), obj6);
			val103.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(32, 40)));
			object dark3 = val102.ProvideValue((IServiceProvider)val103);
			val63.Dark = dark3;
			XamlServiceProvider val105 = new XamlServiceProvider();
			val105.Add(typeof(IProvideValueTarget), (object)new ValueTargetProvider((object)val64, (object)Label.TextColorProperty));
			val105.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(32, 40)));
			BindingBase val106 = ((IMarkupExtension<BindingBase>)(object)val63).ProvideValue((IServiceProvider)val105);
			((BindableObject)val64).SetBinding(Label.TextColorProperty, val106);
			((Layout)val70).Children.Add((IView)(object)val64);
			val65.Path = "Description";
			XamlServiceProvider val107 = new XamlServiceProvider();
			Type? typeFromHandle9 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val108 = new XmlNamespaceResolver();
			val108.Add("", "http://schemas.microsoft.com/dotnet/2021/maui");
			val108.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val107.Add(typeFromHandle9, (object)new XamlTypeResolver((IXmlNamespaceResolver)val108, typeof(_003CInitializeComponent_003E_anonXamlCDataTemplate_0).Assembly));
			BindingBase val109 = ((IMarkupExtension<BindingBase>)(object)val65).ProvideValue((IServiceProvider)val107);
			((BindableObject)val69).SetBinding(Label.TextProperty, val109);
			((BindableObject)val69).SetValue(Label.FontSizeProperty, (object)12.0);
			val66.Key = "TextSecondaryLight";
			StaticResourceExtension val110 = new StaticResourceExtension
			{
				Key = "TextSecondaryLight"
			};
			XamlServiceProvider val111 = new XamlServiceProvider();
			Type? typeFromHandle10 = typeof(IProvideValueTarget);
			int length7;
			object[] array7 = new object[(length7 = parentValues.Length) + 5];
			Array.Copy(parentValues, 0, array7, 5, length7);
			array7[0] = val68;
			array7[1] = val69;
			array7[2] = val70;
			array7[3] = val74;
			array7[4] = val75;
			SimpleValueTargetProvider val112 = new SimpleValueTargetProvider(array7, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Light"), (INameScope[])(object)new NameScope[10] { val76, val76, val76, val76, val76, val76, val36, val30, val8, val }, false);
			object obj7 = (object)val112;
			val111.Add(typeFromHandle10, (object)val112);
			val111.Add(typeof(IReferenceProvider), obj7);
			val111.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(34, 40)));
			object light4 = val110.ProvideValue((IServiceProvider)val111);
			val68.Light = light4;
			val67.Key = "TextSecondaryDark";
			StaticResourceExtension val113 = new StaticResourceExtension
			{
				Key = "TextSecondaryDark"
			};
			XamlServiceProvider val114 = new XamlServiceProvider();
			Type? typeFromHandle11 = typeof(IProvideValueTarget);
			int length8;
			object[] array8 = new object[(length8 = parentValues.Length) + 5];
			Array.Copy(parentValues, 0, array8, 5, length8);
			array8[0] = val68;
			array8[1] = val69;
			array8[2] = val70;
			array8[3] = val74;
			array8[4] = val75;
			SimpleValueTargetProvider val115 = new SimpleValueTargetProvider(array8, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Dark"), (INameScope[])(object)new NameScope[10] { val76, val76, val76, val76, val76, val76, val36, val30, val8, val }, false);
			object obj8 = (object)val115;
			val114.Add(typeFromHandle11, (object)val115);
			val114.Add(typeof(IReferenceProvider), obj8);
			val114.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(34, 40)));
			object dark4 = val113.ProvideValue((IServiceProvider)val114);
			val68.Dark = dark4;
			XamlServiceProvider val116 = new XamlServiceProvider();
			val116.Add(typeof(IProvideValueTarget), (object)new ValueTargetProvider((object)val69, (object)Label.TextColorProperty));
			val116.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(34, 40)));
			BindingBase val117 = ((IMarkupExtension<BindingBase>)(object)val68).ProvideValue((IServiceProvider)val116);
			((BindableObject)val69).SetBinding(Label.TextColorProperty, val117);
			((Layout)val70).Children.Add((IView)(object)val69);
			((Layout)val74).Children.Add((IView)(object)val70);
			((BindableObject)val73).SetValue(Grid.ColumnProperty, (object)2);
			val71.Path = "Price";
			XamlServiceProvider val118 = new XamlServiceProvider();
			Type? typeFromHandle12 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val119 = new XmlNamespaceResolver();
			val119.Add("", "http://schemas.microsoft.com/dotnet/2021/maui");
			val119.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val118.Add(typeFromHandle12, (object)new XamlTypeResolver((IXmlNamespaceResolver)val119, typeof(_003CInitializeComponent_003E_anonXamlCDataTemplate_0).Assembly));
			BindingBase val120 = ((IMarkupExtension<BindingBase>)(object)val71).ProvideValue((IServiceProvider)val118);
			((BindableObject)val73).SetBinding(Label.TextProperty, val120);
			((BindableObject)val73).SetValue(Label.FontSizeProperty, (object)14.0);
			((BindableObject)val73).SetValue(Label.FontAttributesProperty, (object)(FontAttributes)1);
			((BindableObject)val73).SetValue(View.VerticalOptionsProperty, (object)LayoutOptions.Center);
			val72.Key = "PrimaryColor";
			StaticResourceExtension val121 = new StaticResourceExtension
			{
				Key = "PrimaryColor"
			};
			XamlServiceProvider val122 = new XamlServiceProvider();
			Type? typeFromHandle13 = typeof(IProvideValueTarget);
			int length9;
			object[] array9 = new object[(length9 = parentValues.Length) + 3];
			Array.Copy(parentValues, 0, array9, 3, length9);
			array9[0] = val73;
			array9[1] = val74;
			array9[2] = val75;
			SimpleValueTargetProvider val123 = new SimpleValueTargetProvider(array9, (object)Label.TextColorProperty, (INameScope[])(object)new NameScope[8] { val76, val76, val76, val76, val36, val30, val8, val }, false);
			object obj9 = (object)val123;
			val122.Add(typeFromHandle13, (object)val123);
			val122.Add(typeof(IReferenceProvider), obj9);
			val122.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(38, 36)));
			object obj10 = val121.ProvideValue((IServiceProvider)val122);
			((BindableObject)val73).SetValue(Label.TextColorProperty, (obj10 == null || !typeof(BindingBase).IsAssignableFrom(obj10.GetType())) ? obj10 : obj10);
			((Layout)val74).Children.Add((IView)(object)val73);
			((BindableObject)val75).SetValue(ContentView.ContentProperty, (object)val74);
			return val75;
		}
	}

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private CollectionView ItemsCollectionView;

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private Label SelectionOutput;

	public ListsPage()
	{
		InitializeComponent();
		LoadItems();
	}

	private void LoadItems()
	{
		List<ListItem> itemsSource = new List<ListItem>
		{
			new ListItem("Product A", "High quality item", "$29.99", Color.FromArgb("#2196F3")),
			new ListItem("Product B", "Best seller", "$49.99", Color.FromArgb("#4CAF50")),
			new ListItem("Product C", "Limited edition", "$99.99", Color.FromArgb("#FF9800")),
			new ListItem("Product D", "New arrival", "$19.99", Color.FromArgb("#9C27B0")),
			new ListItem("Product E", "Popular choice", "$39.99", Color.FromArgb("#F44336")),
			new ListItem("Product F", "Premium item", "$79.99", Color.FromArgb("#00BCD4")),
			new ListItem("Product G", "Budget friendly", "$9.99", Color.FromArgb("#795548")),
			new ListItem("Product H", "Top rated", "$59.99", Color.FromArgb("#607D8B"))
		};
		((ItemsView)ItemsCollectionView).ItemsSource = itemsSource;
	}

	private void OnSelectionChanged(object? sender, SelectionChangedEventArgs e)
	{
		if (e.CurrentSelection.FirstOrDefault() is ListItem listItem)
		{
			SelectionOutput.Text = "Selected: " + listItem.Name + " - " + listItem.Price;
		}
		else
		{
			SelectionOutput.Text = "No item selected";
		}
	}

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	[MemberNotNull("ItemsCollectionView")]
	[MemberNotNull("SelectionOutput")]
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
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_0170: Unknown result type (might be due to invalid IL or missing references)
		//IL_0175: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c3: Expected O, but got Unknown
		//IL_01c8: Expected O, but got Unknown
		//IL_01c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01da: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f2: Expected O, but got Unknown
		//IL_01ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f7: Expected O, but got Unknown
		//IL_01fc: Expected O, but got Unknown
		//IL_0211: Unknown result type (might be due to invalid IL or missing references)
		//IL_0216: Unknown result type (might be due to invalid IL or missing references)
		//IL_0221: Unknown result type (might be due to invalid IL or missing references)
		//IL_0226: Unknown result type (might be due to invalid IL or missing references)
		//IL_026c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0271: Unknown result type (might be due to invalid IL or missing references)
		//IL_0274: Expected O, but got Unknown
		//IL_0279: Expected O, but got Unknown
		//IL_0279: Unknown result type (might be due to invalid IL or missing references)
		//IL_028b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0299: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a3: Expected O, but got Unknown
		//IL_029e: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a8: Expected O, but got Unknown
		//IL_02ad: Expected O, but got Unknown
		//IL_02b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d9: Expected O, but got Unknown
		//IL_02d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f1: Expected O, but got Unknown
		//IL_02ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f6: Expected O, but got Unknown
		//IL_02fb: Expected O, but got Unknown
		//IL_031a: Unknown result type (might be due to invalid IL or missing references)
		//IL_031f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0325: Expected O, but got Unknown
		//IL_0327: Unknown result type (might be due to invalid IL or missing references)
		//IL_032c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0332: Expected O, but got Unknown
		//IL_0334: Unknown result type (might be due to invalid IL or missing references)
		//IL_0339: Unknown result type (might be due to invalid IL or missing references)
		//IL_033f: Expected O, but got Unknown
		//IL_033f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0349: Expected O, but got Unknown
		//IL_0386: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0407: Unknown result type (might be due to invalid IL or missing references)
		//IL_040c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0471: Unknown result type (might be due to invalid IL or missing references)
		//IL_0476: Unknown result type (might be due to invalid IL or missing references)
		//IL_0479: Expected O, but got Unknown
		//IL_047e: Expected O, but got Unknown
		//IL_047e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0490: Unknown result type (might be due to invalid IL or missing references)
		//IL_049f: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a9: Expected O, but got Unknown
		//IL_04a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ae: Expected O, but got Unknown
		//IL_04b3: Expected O, but got Unknown
		//IL_04ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_04cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_04da: Unknown result type (might be due to invalid IL or missing references)
		//IL_04df: Unknown result type (might be due to invalid IL or missing references)
		//IL_0544: Unknown result type (might be due to invalid IL or missing references)
		//IL_0549: Unknown result type (might be due to invalid IL or missing references)
		//IL_054c: Expected O, but got Unknown
		//IL_0551: Expected O, but got Unknown
		//IL_0551: Unknown result type (might be due to invalid IL or missing references)
		//IL_0563: Unknown result type (might be due to invalid IL or missing references)
		//IL_0572: Unknown result type (might be due to invalid IL or missing references)
		//IL_057c: Expected O, but got Unknown
		//IL_0577: Unknown result type (might be due to invalid IL or missing references)
		//IL_0581: Expected O, but got Unknown
		//IL_0586: Expected O, but got Unknown
		//IL_0593: Unknown result type (might be due to invalid IL or missing references)
		//IL_0598: Unknown result type (might be due to invalid IL or missing references)
		//IL_05aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b4: Expected O, but got Unknown
		//IL_05b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05cd: Expected O, but got Unknown
		//IL_05c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d2: Expected O, but got Unknown
		//IL_05d7: Expected O, but got Unknown
		//IL_0612: Unknown result type (might be due to invalid IL or missing references)
		//IL_0617: Unknown result type (might be due to invalid IL or missing references)
		//IL_0622: Unknown result type (might be due to invalid IL or missing references)
		//IL_0627: Unknown result type (might be due to invalid IL or missing references)
		//IL_068c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0691: Unknown result type (might be due to invalid IL or missing references)
		//IL_0694: Expected O, but got Unknown
		//IL_0699: Expected O, but got Unknown
		//IL_0699: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c4: Expected O, but got Unknown
		//IL_06bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c9: Expected O, but got Unknown
		//IL_06ce: Expected O, but got Unknown
		//IL_06e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_06fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_075f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0764: Unknown result type (might be due to invalid IL or missing references)
		//IL_0767: Expected O, but got Unknown
		//IL_076c: Expected O, but got Unknown
		//IL_076c: Unknown result type (might be due to invalid IL or missing references)
		//IL_077e: Unknown result type (might be due to invalid IL or missing references)
		//IL_078d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0797: Expected O, but got Unknown
		//IL_0792: Unknown result type (might be due to invalid IL or missing references)
		//IL_079c: Expected O, but got Unknown
		//IL_07a1: Expected O, but got Unknown
		//IL_07ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_07b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_07c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_07cf: Expected O, but got Unknown
		//IL_07cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_07de: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e8: Expected O, but got Unknown
		//IL_07e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ed: Expected O, but got Unknown
		//IL_07f2: Expected O, but got Unknown
		//IL_086f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a95: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ad4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ad9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aeb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0af5: Expected O, but got Unknown
		//IL_0af5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b04: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b0e: Expected O, but got Unknown
		//IL_0b09: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b13: Expected O, but got Unknown
		//IL_0b18: Expected O, but got Unknown
		//IL_0b45: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b4a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b55: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b5a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bbf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bc4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bc7: Expected O, but got Unknown
		//IL_0bcc: Expected O, but got Unknown
		//IL_0bcc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bde: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bed: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bf7: Expected O, but got Unknown
		//IL_0bf2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bfc: Expected O, but got Unknown
		//IL_0c01: Expected O, but got Unknown
		//IL_0c18: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c1d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c28: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c2d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c92: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c97: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c9a: Expected O, but got Unknown
		//IL_0c9f: Expected O, but got Unknown
		//IL_0c9f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cb1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cc0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cca: Expected O, but got Unknown
		//IL_0cc5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ccf: Expected O, but got Unknown
		//IL_0cd4: Expected O, but got Unknown
		//IL_0ce1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ce6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cf8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d02: Expected O, but got Unknown
		//IL_0d02: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d11: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d1b: Expected O, but got Unknown
		//IL_0d16: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d20: Expected O, but got Unknown
		//IL_0d25: Expected O, but got Unknown
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
		VerticalStackLayout val12 = new VerticalStackLayout();
		DataTemplate val13 = new DataTemplate();
		CollectionView val14 = new CollectionView();
		AppThemeBindingExtension val15 = new AppThemeBindingExtension();
		StaticResourceExtension val16 = new StaticResourceExtension();
		StaticResourceExtension val17 = new StaticResourceExtension();
		AppThemeBindingExtension val18 = new AppThemeBindingExtension();
		Label val19 = new Label();
		Frame val20 = new Frame();
		Grid val21 = new Grid();
		ListsPage listsPage;
		NameScope val22 = (NameScope)(((object)NameScope.GetNameScope((BindableObject)(object)(listsPage = this))) ?? ((object)new NameScope()));
		NameScope.SetNameScope((BindableObject)(object)listsPage, (INameScope)(object)val22);
		((Element)val21).transientNamescope = (INameScope)(object)val22;
		((Element)val12).transientNamescope = (INameScope)(object)val22;
		((Element)val7).transientNamescope = (INameScope)(object)val22;
		((Element)val11).transientNamescope = (INameScope)(object)val22;
		((Element)val14).transientNamescope = (INameScope)(object)val22;
		((INameScope)val22).RegisterName("ItemsCollectionView", (object)val14);
		if (((Element)val14).StyleId == null)
		{
			((Element)val14).StyleId = "ItemsCollectionView";
		}
		((Element)val20).transientNamescope = (INameScope)(object)val22;
		((Element)val19).transientNamescope = (INameScope)(object)val22;
		((INameScope)val22).RegisterName("SelectionOutput", (object)val19);
		if (((Element)val19).StyleId == null)
		{
			((Element)val19).StyleId = "SelectionOutput";
		}
		ItemsCollectionView = val14;
		SelectionOutput = val19;
		((BindableObject)listsPage).SetValue(Page.TitleProperty, (object)"Lists");
		val.Key = "PageBackgroundLight";
		StaticResourceExtension val23 = new StaticResourceExtension
		{
			Key = "PageBackgroundLight"
		};
		XamlServiceProvider val24 = new XamlServiceProvider();
		Type? typeFromHandle = typeof(IProvideValueTarget);
		object[] array = new object[0 + 2];
		array[0] = val3;
		array[1] = listsPage;
		SimpleValueTargetProvider val25 = new SimpleValueTargetProvider(array, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Light"), (INameScope[])(object)new NameScope[3] { val22, val22, val22 }, false);
		object obj = (object)val25;
		val24.Add(typeFromHandle, (object)val25);
		val24.Add(typeof(IReferenceProvider), obj);
		val24.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(6, 14)));
		object light = val23.ProvideValue((IServiceProvider)val24);
		val3.Light = light;
		val2.Key = "PageBackgroundDark";
		StaticResourceExtension val26 = new StaticResourceExtension
		{
			Key = "PageBackgroundDark"
		};
		XamlServiceProvider val27 = new XamlServiceProvider();
		Type? typeFromHandle2 = typeof(IProvideValueTarget);
		object[] array2 = new object[0 + 2];
		array2[0] = val3;
		array2[1] = listsPage;
		SimpleValueTargetProvider val28 = new SimpleValueTargetProvider(array2, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Dark"), (INameScope[])(object)new NameScope[3] { val22, val22, val22 }, false);
		object obj2 = (object)val28;
		val27.Add(typeFromHandle2, (object)val28);
		val27.Add(typeof(IReferenceProvider), obj2);
		val27.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(6, 14)));
		object dark = val26.ProvideValue((IServiceProvider)val27);
		val3.Dark = dark;
		XamlServiceProvider val29 = new XamlServiceProvider();
		val29.Add(typeof(IProvideValueTarget), (object)new ValueTargetProvider((object)listsPage, (object)VisualElement.BackgroundColorProperty));
		val29.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(6, 14)));
		BindingBase val30 = ((IMarkupExtension<BindingBase>)(object)val3).ProvideValue((IServiceProvider)val29);
		((BindableObject)listsPage).SetBinding(VisualElement.BackgroundColorProperty, val30);
		((BindableObject)val21).SetValue(Grid.RowDefinitionsProperty, (object)new RowDefinitionCollection((RowDefinition[])(object)new RowDefinition[3]
		{
			new RowDefinition(GridLength.Auto),
			new RowDefinition(GridLength.Star),
			new RowDefinition(GridLength.Auto)
		}));
		((BindableObject)val12).SetValue(Grid.RowProperty, (object)0);
		((BindableObject)val12).SetValue(Layout.PaddingProperty, (object)new Thickness(20.0, 20.0, 20.0, 10.0));
		((BindableObject)val12).SetValue(StackBase.SpacingProperty, (object)5.0);
		((BindableObject)val7).SetValue(Label.TextProperty, (object)"CollectionView Demo");
		((BindableObject)val7).SetValue(Label.FontSizeProperty, (object)24.0);
		((BindableObject)val7).SetValue(Label.FontAttributesProperty, (object)(FontAttributes)1);
		val4.Key = "TextPrimaryLight";
		StaticResourceExtension val31 = new StaticResourceExtension
		{
			Key = "TextPrimaryLight"
		};
		XamlServiceProvider val32 = new XamlServiceProvider();
		Type? typeFromHandle3 = typeof(IProvideValueTarget);
		object[] array3 = new object[0 + 5];
		array3[0] = val6;
		array3[1] = val7;
		array3[2] = val12;
		array3[3] = val21;
		array3[4] = listsPage;
		SimpleValueTargetProvider val33 = new SimpleValueTargetProvider(array3, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Light"), (INameScope[])(object)new NameScope[6] { val22, val22, val22, val22, val22, val22 }, false);
		object obj3 = (object)val33;
		val32.Add(typeFromHandle3, (object)val33);
		val32.Add(typeof(IReferenceProvider), obj3);
		val32.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(12, 20)));
		object light2 = val31.ProvideValue((IServiceProvider)val32);
		val6.Light = light2;
		val5.Key = "TextPrimaryDark";
		StaticResourceExtension val34 = new StaticResourceExtension
		{
			Key = "TextPrimaryDark"
		};
		XamlServiceProvider val35 = new XamlServiceProvider();
		Type? typeFromHandle4 = typeof(IProvideValueTarget);
		object[] array4 = new object[0 + 5];
		array4[0] = val6;
		array4[1] = val7;
		array4[2] = val12;
		array4[3] = val21;
		array4[4] = listsPage;
		SimpleValueTargetProvider val36 = new SimpleValueTargetProvider(array4, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Dark"), (INameScope[])(object)new NameScope[6] { val22, val22, val22, val22, val22, val22 }, false);
		object obj4 = (object)val36;
		val35.Add(typeFromHandle4, (object)val36);
		val35.Add(typeof(IReferenceProvider), obj4);
		val35.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(12, 20)));
		object dark2 = val34.ProvideValue((IServiceProvider)val35);
		val6.Dark = dark2;
		XamlServiceProvider val37 = new XamlServiceProvider();
		val37.Add(typeof(IProvideValueTarget), (object)new ValueTargetProvider((object)val7, (object)Label.TextColorProperty));
		val37.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(12, 20)));
		BindingBase val38 = ((IMarkupExtension<BindingBase>)(object)val6).ProvideValue((IServiceProvider)val37);
		((BindableObject)val7).SetBinding(Label.TextColorProperty, val38);
		((Layout)val12).Children.Add((IView)(object)val7);
		((BindableObject)val11).SetValue(Label.TextProperty, (object)"Tap items to select them");
		val8.Key = "TextSecondaryLight";
		StaticResourceExtension val39 = new StaticResourceExtension
		{
			Key = "TextSecondaryLight"
		};
		XamlServiceProvider val40 = new XamlServiceProvider();
		Type? typeFromHandle5 = typeof(IProvideValueTarget);
		object[] array5 = new object[0 + 5];
		array5[0] = val10;
		array5[1] = val11;
		array5[2] = val12;
		array5[3] = val21;
		array5[4] = listsPage;
		SimpleValueTargetProvider val41 = new SimpleValueTargetProvider(array5, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Light"), (INameScope[])(object)new NameScope[6] { val22, val22, val22, val22, val22, val22 }, false);
		object obj5 = (object)val41;
		val40.Add(typeFromHandle5, (object)val41);
		val40.Add(typeof(IReferenceProvider), obj5);
		val40.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(14, 20)));
		object light3 = val39.ProvideValue((IServiceProvider)val40);
		val10.Light = light3;
		val9.Key = "TextSecondaryDark";
		StaticResourceExtension val42 = new StaticResourceExtension
		{
			Key = "TextSecondaryDark"
		};
		XamlServiceProvider val43 = new XamlServiceProvider();
		Type? typeFromHandle6 = typeof(IProvideValueTarget);
		object[] array6 = new object[0 + 5];
		array6[0] = val10;
		array6[1] = val11;
		array6[2] = val12;
		array6[3] = val21;
		array6[4] = listsPage;
		SimpleValueTargetProvider val44 = new SimpleValueTargetProvider(array6, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Dark"), (INameScope[])(object)new NameScope[6] { val22, val22, val22, val22, val22, val22 }, false);
		object obj6 = (object)val44;
		val43.Add(typeFromHandle6, (object)val44);
		val43.Add(typeof(IReferenceProvider), obj6);
		val43.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(14, 20)));
		object dark3 = val42.ProvideValue((IServiceProvider)val43);
		val10.Dark = dark3;
		XamlServiceProvider val45 = new XamlServiceProvider();
		val45.Add(typeof(IProvideValueTarget), (object)new ValueTargetProvider((object)val11, (object)Label.TextColorProperty));
		val45.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(14, 20)));
		BindingBase val46 = ((IMarkupExtension<BindingBase>)(object)val10).ProvideValue((IServiceProvider)val45);
		((BindableObject)val11).SetBinding(Label.TextColorProperty, val46);
		((Layout)val12).Children.Add((IView)(object)val11);
		((Layout)val21).Children.Add((IView)(object)val12);
		((BindableObject)val14).SetValue(Grid.RowProperty, (object)1);
		((BindableObject)val14).SetValue(SelectableItemsView.SelectionModeProperty, (object)(SelectionMode)1);
		((SelectableItemsView)val14).SelectionChanged += listsPage.OnSelectionChanged;
		((BindableObject)val14).SetValue(View.MarginProperty, (object)new Thickness(20.0, 0.0));
		NameScope _scope0 = val22;
		NameScope _scope1 = val22;
		NameScope _scope2 = val22;
		NameScope _scope3 = val22;
		NameScope _scope4 = val22;
		NameScope _scope5 = val22;
		NameScope _scope6 = val22;
		NameScope _scope7 = val22;
		NameScope _scope8 = val22;
		NameScope _scope9 = val22;
		NameScope _scope10 = val22;
		NameScope _scope11 = val22;
		NameScope _scope12 = val22;
		NameScope _scope13 = val22;
		NameScope _scope14 = val22;
		NameScope _scope15 = val22;
		NameScope _scope16 = val22;
		NameScope _scope17 = val22;
		NameScope _scope18 = val22;
		NameScope _scope19 = val22;
		NameScope _scope20 = val22;
		NameScope _scope21 = val22;
		NameScope _scope22 = val22;
		NameScope _scope23 = val22;
		NameScope _scope24 = val22;
		NameScope _scope25 = val22;
		NameScope _scope26 = val22;
		NameScope _scope27 = val22;
		NameScope _scope28 = val22;
		NameScope _scope29 = val22;
		NameScope _scope30 = val22;
		NameScope _scope31 = val22;
		NameScope _scope32 = val22;
		NameScope _scope33 = val22;
		NameScope _scope34 = val22;
		NameScope _scope35 = val22;
		NameScope _scope36 = val22;
		NameScope _scope37 = val22;
		NameScope _scope38 = val22;
		NameScope _scope39 = val22;
		NameScope _scope40 = val22;
		NameScope _scope41 = val22;
		NameScope _scope42 = val22;
		NameScope _scope43 = val22;
		NameScope _scope44 = val22;
		NameScope _scope45 = val22;
		NameScope _scope46 = val22;
		NameScope _scope47 = val22;
		NameScope _scope48 = val22;
		NameScope _scope49 = val22;
		NameScope _scope50 = val22;
		object[] array7 = new object[0 + 4];
		array7[0] = val13;
		array7[1] = val14;
		array7[2] = val21;
		array7[3] = listsPage;
		object[] parentValues = array7;
		ListsPage root = listsPage;
		((ElementTemplate)val13).LoadTemplate = delegate
		{
			//IL_0195: Unknown result type (might be due to invalid IL or missing references)
			//IL_019c: Expected O, but got Unknown
			//IL_019c: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a3: Expected O, but got Unknown
			//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_01aa: Expected O, but got Unknown
			//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b1: Expected O, but got Unknown
			//IL_01b1: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b8: Expected O, but got Unknown
			//IL_01b8: Unknown result type (might be due to invalid IL or missing references)
			//IL_01bf: Expected O, but got Unknown
			//IL_01bf: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c6: Expected O, but got Unknown
			//IL_01c6: Unknown result type (might be due to invalid IL or missing references)
			//IL_01cd: Expected O, but got Unknown
			//IL_01cd: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d4: Expected O, but got Unknown
			//IL_01d4: Unknown result type (might be due to invalid IL or missing references)
			//IL_01db: Expected O, but got Unknown
			//IL_01db: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e2: Expected O, but got Unknown
			//IL_01e2: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e9: Expected O, but got Unknown
			//IL_01e9: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f0: Expected O, but got Unknown
			//IL_01f0: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f7: Expected O, but got Unknown
			//IL_01f7: Unknown result type (might be due to invalid IL or missing references)
			//IL_01fe: Expected O, but got Unknown
			//IL_01fe: Unknown result type (might be due to invalid IL or missing references)
			//IL_0205: Expected O, but got Unknown
			//IL_0205: Unknown result type (might be due to invalid IL or missing references)
			//IL_020c: Expected O, but got Unknown
			//IL_020c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0213: Expected O, but got Unknown
			//IL_0213: Unknown result type (might be due to invalid IL or missing references)
			//IL_021a: Expected O, but got Unknown
			//IL_021a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0221: Expected O, but got Unknown
			//IL_0221: Unknown result type (might be due to invalid IL or missing references)
			//IL_0228: Expected O, but got Unknown
			//IL_0228: Unknown result type (might be due to invalid IL or missing references)
			//IL_022f: Expected O, but got Unknown
			//IL_022f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0236: Expected O, but got Unknown
			//IL_0236: Unknown result type (might be due to invalid IL or missing references)
			//IL_023d: Expected O, but got Unknown
			//IL_023d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0244: Expected O, but got Unknown
			//IL_029c: Unknown result type (might be due to invalid IL or missing references)
			//IL_02bb: Unknown result type (might be due to invalid IL or missing references)
			//IL_02ec: Unknown result type (might be due to invalid IL or missing references)
			//IL_02f1: Unknown result type (might be due to invalid IL or missing references)
			//IL_02fc: Unknown result type (might be due to invalid IL or missing references)
			//IL_0301: Unknown result type (might be due to invalid IL or missing references)
			//IL_037a: Unknown result type (might be due to invalid IL or missing references)
			//IL_037f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0382: Expected O, but got Unknown
			//IL_0387: Expected O, but got Unknown
			//IL_0387: Unknown result type (might be due to invalid IL or missing references)
			//IL_0399: Unknown result type (might be due to invalid IL or missing references)
			//IL_03a8: Unknown result type (might be due to invalid IL or missing references)
			//IL_03b2: Expected O, but got Unknown
			//IL_03ad: Unknown result type (might be due to invalid IL or missing references)
			//IL_03b7: Expected O, but got Unknown
			//IL_03bc: Expected O, but got Unknown
			//IL_03d3: Unknown result type (might be due to invalid IL or missing references)
			//IL_03d8: Unknown result type (might be due to invalid IL or missing references)
			//IL_03e3: Unknown result type (might be due to invalid IL or missing references)
			//IL_03e8: Unknown result type (might be due to invalid IL or missing references)
			//IL_0461: Unknown result type (might be due to invalid IL or missing references)
			//IL_0466: Unknown result type (might be due to invalid IL or missing references)
			//IL_0469: Expected O, but got Unknown
			//IL_046e: Expected O, but got Unknown
			//IL_046e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0480: Unknown result type (might be due to invalid IL or missing references)
			//IL_048f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0499: Expected O, but got Unknown
			//IL_0494: Unknown result type (might be due to invalid IL or missing references)
			//IL_049e: Expected O, but got Unknown
			//IL_04a3: Expected O, but got Unknown
			//IL_04b0: Unknown result type (might be due to invalid IL or missing references)
			//IL_04b5: Unknown result type (might be due to invalid IL or missing references)
			//IL_04c7: Unknown result type (might be due to invalid IL or missing references)
			//IL_04d1: Expected O, but got Unknown
			//IL_04d1: Unknown result type (might be due to invalid IL or missing references)
			//IL_04e0: Unknown result type (might be due to invalid IL or missing references)
			//IL_04ea: Expected O, but got Unknown
			//IL_04e5: Unknown result type (might be due to invalid IL or missing references)
			//IL_04ef: Expected O, but got Unknown
			//IL_04f4: Expected O, but got Unknown
			//IL_0510: Unknown result type (might be due to invalid IL or missing references)
			//IL_0515: Unknown result type (might be due to invalid IL or missing references)
			//IL_0520: Unknown result type (might be due to invalid IL or missing references)
			//IL_0525: Unknown result type (might be due to invalid IL or missing references)
			//IL_059e: Unknown result type (might be due to invalid IL or missing references)
			//IL_05a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_05a6: Expected O, but got Unknown
			//IL_05ab: Expected O, but got Unknown
			//IL_05ab: Unknown result type (might be due to invalid IL or missing references)
			//IL_05bd: Unknown result type (might be due to invalid IL or missing references)
			//IL_05cc: Unknown result type (might be due to invalid IL or missing references)
			//IL_05d6: Expected O, but got Unknown
			//IL_05d1: Unknown result type (might be due to invalid IL or missing references)
			//IL_05db: Expected O, but got Unknown
			//IL_05e0: Expected O, but got Unknown
			//IL_05f7: Unknown result type (might be due to invalid IL or missing references)
			//IL_05fc: Unknown result type (might be due to invalid IL or missing references)
			//IL_0607: Unknown result type (might be due to invalid IL or missing references)
			//IL_060c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0685: Unknown result type (might be due to invalid IL or missing references)
			//IL_068a: Unknown result type (might be due to invalid IL or missing references)
			//IL_068d: Expected O, but got Unknown
			//IL_0692: Expected O, but got Unknown
			//IL_0692: Unknown result type (might be due to invalid IL or missing references)
			//IL_06a4: Unknown result type (might be due to invalid IL or missing references)
			//IL_06b3: Unknown result type (might be due to invalid IL or missing references)
			//IL_06bd: Expected O, but got Unknown
			//IL_06b8: Unknown result type (might be due to invalid IL or missing references)
			//IL_06c2: Expected O, but got Unknown
			//IL_06c7: Expected O, but got Unknown
			//IL_06d4: Unknown result type (might be due to invalid IL or missing references)
			//IL_06d9: Unknown result type (might be due to invalid IL or missing references)
			//IL_06eb: Unknown result type (might be due to invalid IL or missing references)
			//IL_06f5: Expected O, but got Unknown
			//IL_06f5: Unknown result type (might be due to invalid IL or missing references)
			//IL_0704: Unknown result type (might be due to invalid IL or missing references)
			//IL_070e: Expected O, but got Unknown
			//IL_0709: Unknown result type (might be due to invalid IL or missing references)
			//IL_0713: Expected O, but got Unknown
			//IL_0718: Expected O, but got Unknown
			//IL_0737: Unknown result type (might be due to invalid IL or missing references)
			//IL_073c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0742: Expected O, but got Unknown
			//IL_0744: Unknown result type (might be due to invalid IL or missing references)
			//IL_0749: Unknown result type (might be due to invalid IL or missing references)
			//IL_074f: Expected O, but got Unknown
			//IL_0751: Unknown result type (might be due to invalid IL or missing references)
			//IL_0756: Unknown result type (might be due to invalid IL or missing references)
			//IL_075c: Expected O, but got Unknown
			//IL_075c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0766: Expected O, but got Unknown
			//IL_07aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_07c7: Unknown result type (might be due to invalid IL or missing references)
			//IL_07cc: Unknown result type (might be due to invalid IL or missing references)
			//IL_07d7: Unknown result type (might be due to invalid IL or missing references)
			//IL_07dc: Unknown result type (might be due to invalid IL or missing references)
			//IL_07ec: Unknown result type (might be due to invalid IL or missing references)
			//IL_0810: Expected O, but got Unknown
			//IL_080b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0815: Expected O, but got Unknown
			//IL_081a: Expected O, but got Unknown
			//IL_0863: Unknown result type (might be due to invalid IL or missing references)
			//IL_0879: Unknown result type (might be due to invalid IL or missing references)
			//IL_0896: Unknown result type (might be due to invalid IL or missing references)
			//IL_089b: Unknown result type (might be due to invalid IL or missing references)
			//IL_08a6: Unknown result type (might be due to invalid IL or missing references)
			//IL_08ab: Unknown result type (might be due to invalid IL or missing references)
			//IL_08bb: Unknown result type (might be due to invalid IL or missing references)
			//IL_08df: Expected O, but got Unknown
			//IL_08da: Unknown result type (might be due to invalid IL or missing references)
			//IL_08e4: Expected O, but got Unknown
			//IL_08e9: Expected O, but got Unknown
			//IL_0931: Unknown result type (might be due to invalid IL or missing references)
			//IL_0936: Unknown result type (might be due to invalid IL or missing references)
			//IL_0941: Unknown result type (might be due to invalid IL or missing references)
			//IL_0946: Unknown result type (might be due to invalid IL or missing references)
			//IL_09df: Unknown result type (might be due to invalid IL or missing references)
			//IL_09e4: Unknown result type (might be due to invalid IL or missing references)
			//IL_09e7: Expected O, but got Unknown
			//IL_09ec: Expected O, but got Unknown
			//IL_09ec: Unknown result type (might be due to invalid IL or missing references)
			//IL_09fe: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a0d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a17: Expected O, but got Unknown
			//IL_0a12: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a1c: Expected O, but got Unknown
			//IL_0a21: Expected O, but got Unknown
			//IL_0a38: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a3d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a48: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a4d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ae6: Unknown result type (might be due to invalid IL or missing references)
			//IL_0aeb: Unknown result type (might be due to invalid IL or missing references)
			//IL_0aee: Expected O, but got Unknown
			//IL_0af3: Expected O, but got Unknown
			//IL_0af3: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b05: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b14: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b1e: Expected O, but got Unknown
			//IL_0b19: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b23: Expected O, but got Unknown
			//IL_0b28: Expected O, but got Unknown
			//IL_0b35: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b3a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b4c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b56: Expected O, but got Unknown
			//IL_0b56: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b65: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b6f: Expected O, but got Unknown
			//IL_0b6a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b74: Expected O, but got Unknown
			//IL_0b79: Expected O, but got Unknown
			//IL_0ba5: Unknown result type (might be due to invalid IL or missing references)
			//IL_0baa: Unknown result type (might be due to invalid IL or missing references)
			//IL_0bb5: Unknown result type (might be due to invalid IL or missing references)
			//IL_0bba: Unknown result type (might be due to invalid IL or missing references)
			//IL_0bca: Unknown result type (might be due to invalid IL or missing references)
			//IL_0bee: Expected O, but got Unknown
			//IL_0be9: Unknown result type (might be due to invalid IL or missing references)
			//IL_0bf3: Expected O, but got Unknown
			//IL_0bf8: Expected O, but got Unknown
			//IL_0c2e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c33: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c3e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c43: Unknown result type (might be due to invalid IL or missing references)
			//IL_0cdc: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ce1: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ce4: Expected O, but got Unknown
			//IL_0ce9: Expected O, but got Unknown
			//IL_0ce9: Unknown result type (might be due to invalid IL or missing references)
			//IL_0cfb: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d0a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d14: Expected O, but got Unknown
			//IL_0d0f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d19: Expected O, but got Unknown
			//IL_0d1e: Expected O, but got Unknown
			//IL_0d35: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d3a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d45: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d4a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0de3: Unknown result type (might be due to invalid IL or missing references)
			//IL_0de8: Unknown result type (might be due to invalid IL or missing references)
			//IL_0deb: Expected O, but got Unknown
			//IL_0df0: Expected O, but got Unknown
			//IL_0df0: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e02: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e11: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e1b: Expected O, but got Unknown
			//IL_0e16: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e20: Expected O, but got Unknown
			//IL_0e25: Expected O, but got Unknown
			//IL_0e32: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e37: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e49: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e53: Expected O, but got Unknown
			//IL_0e53: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e62: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e6c: Expected O, but got Unknown
			//IL_0e67: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e71: Expected O, but got Unknown
			//IL_0e76: Expected O, but got Unknown
			//IL_0ec2: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ec7: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ed2: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ed7: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ee7: Unknown result type (might be due to invalid IL or missing references)
			//IL_0f0b: Expected O, but got Unknown
			//IL_0f06: Unknown result type (might be due to invalid IL or missing references)
			//IL_0f10: Expected O, but got Unknown
			//IL_0f15: Expected O, but got Unknown
			//IL_0f58: Unknown result type (might be due to invalid IL or missing references)
			//IL_0f73: Unknown result type (might be due to invalid IL or missing references)
			//IL_0f78: Unknown result type (might be due to invalid IL or missing references)
			//IL_0f83: Unknown result type (might be due to invalid IL or missing references)
			//IL_0f88: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ffc: Unknown result type (might be due to invalid IL or missing references)
			//IL_1001: Unknown result type (might be due to invalid IL or missing references)
			//IL_1004: Expected O, but got Unknown
			//IL_1009: Expected O, but got Unknown
			//IL_1009: Unknown result type (might be due to invalid IL or missing references)
			//IL_101b: Unknown result type (might be due to invalid IL or missing references)
			//IL_102a: Unknown result type (might be due to invalid IL or missing references)
			//IL_1034: Expected O, but got Unknown
			//IL_102f: Unknown result type (might be due to invalid IL or missing references)
			//IL_1039: Expected O, but got Unknown
			//IL_103e: Expected O, but got Unknown
			NameScope val57 = _scope0;
			NameScope val58 = _scope1;
			NameScope val59 = _scope2;
			NameScope val60 = _scope3;
			NameScope val61 = _scope4;
			NameScope val62 = _scope5;
			NameScope val63 = _scope6;
			NameScope val64 = _scope7;
			NameScope val65 = _scope8;
			NameScope val66 = _scope9;
			NameScope val67 = _scope10;
			NameScope val68 = _scope11;
			NameScope val69 = _scope12;
			NameScope val70 = _scope13;
			NameScope val71 = _scope14;
			NameScope val72 = _scope15;
			NameScope val73 = _scope16;
			NameScope val74 = _scope17;
			NameScope val75 = _scope18;
			NameScope val76 = _scope19;
			NameScope val77 = _scope20;
			NameScope val78 = _scope21;
			NameScope val79 = _scope22;
			NameScope val80 = _scope23;
			NameScope val81 = _scope24;
			NameScope val82 = _scope25;
			NameScope val83 = _scope26;
			NameScope val84 = _scope27;
			NameScope val85 = _scope28;
			NameScope val86 = _scope29;
			NameScope val87 = _scope30;
			NameScope val88 = _scope31;
			NameScope val89 = _scope32;
			NameScope val90 = _scope33;
			NameScope val91 = _scope34;
			NameScope val92 = _scope35;
			NameScope val93 = _scope36;
			NameScope val94 = _scope37;
			NameScope val95 = _scope38;
			NameScope val96 = _scope39;
			NameScope val97 = _scope40;
			NameScope val98 = _scope41;
			NameScope val99 = _scope42;
			NameScope val100 = _scope43;
			NameScope val101 = _scope44;
			NameScope val102 = _scope45;
			NameScope val103 = _scope46;
			NameScope val104 = _scope47;
			NameScope val105 = _scope48;
			NameScope val106 = _scope49;
			NameScope val107 = _scope50;
			StaticResourceExtension val108 = new StaticResourceExtension();
			StaticResourceExtension val109 = new StaticResourceExtension();
			AppThemeBindingExtension val110 = new AppThemeBindingExtension();
			StaticResourceExtension val111 = new StaticResourceExtension();
			StaticResourceExtension val112 = new StaticResourceExtension();
			AppThemeBindingExtension val113 = new AppThemeBindingExtension();
			BindingExtension val114 = new BindingExtension();
			BoxView val115 = new BoxView();
			BindingExtension val116 = new BindingExtension();
			StaticResourceExtension val117 = new StaticResourceExtension();
			StaticResourceExtension val118 = new StaticResourceExtension();
			AppThemeBindingExtension val119 = new AppThemeBindingExtension();
			Label val120 = new Label();
			BindingExtension val121 = new BindingExtension();
			StaticResourceExtension val122 = new StaticResourceExtension();
			StaticResourceExtension val123 = new StaticResourceExtension();
			AppThemeBindingExtension val124 = new AppThemeBindingExtension();
			Label val125 = new Label();
			VerticalStackLayout val126 = new VerticalStackLayout();
			BindingExtension val127 = new BindingExtension();
			StaticResourceExtension val128 = new StaticResourceExtension();
			Label val129 = new Label();
			Grid val130 = new Grid();
			Frame val131 = new Frame();
			NameScope val132 = new NameScope();
			NameScope.SetNameScope((BindableObject)(object)val131, (INameScope)(object)val132);
			((Element)val130).transientNamescope = (INameScope)(object)val132;
			((Element)val115).transientNamescope = (INameScope)(object)val132;
			((Element)val126).transientNamescope = (INameScope)(object)val132;
			((Element)val120).transientNamescope = (INameScope)(object)val132;
			((Element)val125).transientNamescope = (INameScope)(object)val132;
			((Element)val129).transientNamescope = (INameScope)(object)val132;
			((BindableObject)val131).SetValue(View.MarginProperty, (object)new Thickness(0.0, 5.0));
			((BindableObject)val131).SetValue(Layout.PaddingProperty, (object)new Thickness(15.0));
			((BindableObject)val131).SetValue(Frame.CornerRadiusProperty, (object)8f);
			val108.Key = "CardBackgroundLight";
			StaticResourceExtension val133 = new StaticResourceExtension
			{
				Key = "CardBackgroundLight"
			};
			XamlServiceProvider val134 = new XamlServiceProvider();
			Type? typeFromHandle9 = typeof(IProvideValueTarget);
			int length;
			object[] array10 = new object[(length = parentValues.Length) + 2];
			Array.Copy(parentValues, 0, array10, 2, length);
			array10[0] = val110;
			array10[1] = val131;
			SimpleValueTargetProvider val135 = new SimpleValueTargetProvider(array10, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Light"), (INameScope[])(object)new NameScope[7] { val132, val132, val132, val92, val86, val64, val57 }, false);
			object obj9 = (object)val135;
			val134.Add(typeFromHandle9, (object)val135);
			val134.Add(typeof(IReferenceProvider), obj9);
			val134.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(25, 28)));
			object light5 = val133.ProvideValue((IServiceProvider)val134);
			val110.Light = light5;
			val109.Key = "CardBackgroundDark";
			StaticResourceExtension val136 = new StaticResourceExtension
			{
				Key = "CardBackgroundDark"
			};
			XamlServiceProvider val137 = new XamlServiceProvider();
			Type? typeFromHandle10 = typeof(IProvideValueTarget);
			int length2;
			object[] array11 = new object[(length2 = parentValues.Length) + 2];
			Array.Copy(parentValues, 0, array11, 2, length2);
			array11[0] = val110;
			array11[1] = val131;
			SimpleValueTargetProvider val138 = new SimpleValueTargetProvider(array11, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Dark"), (INameScope[])(object)new NameScope[7] { val132, val132, val132, val92, val86, val64, val57 }, false);
			object obj10 = (object)val138;
			val137.Add(typeFromHandle10, (object)val138);
			val137.Add(typeof(IReferenceProvider), obj10);
			val137.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(25, 28)));
			object dark5 = val136.ProvideValue((IServiceProvider)val137);
			val110.Dark = dark5;
			XamlServiceProvider val139 = new XamlServiceProvider();
			val139.Add(typeof(IProvideValueTarget), (object)new ValueTargetProvider((object)val131, (object)VisualElement.BackgroundColorProperty));
			val139.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(25, 28)));
			BindingBase val140 = ((IMarkupExtension<BindingBase>)(object)val110).ProvideValue((IServiceProvider)val139);
			((BindableObject)val131).SetBinding(VisualElement.BackgroundColorProperty, val140);
			val111.Key = "BorderLight";
			StaticResourceExtension val141 = new StaticResourceExtension
			{
				Key = "BorderLight"
			};
			XamlServiceProvider val142 = new XamlServiceProvider();
			Type? typeFromHandle11 = typeof(IProvideValueTarget);
			int length3;
			object[] array12 = new object[(length3 = parentValues.Length) + 2];
			Array.Copy(parentValues, 0, array12, 2, length3);
			array12[0] = val113;
			array12[1] = val131;
			SimpleValueTargetProvider val143 = new SimpleValueTargetProvider(array12, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Light"), (INameScope[])(object)new NameScope[7] { val132, val132, val132, val92, val86, val64, val57 }, false);
			object obj11 = (object)val143;
			val142.Add(typeFromHandle11, (object)val143);
			val142.Add(typeof(IReferenceProvider), obj11);
			val142.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(26, 28)));
			object light6 = val141.ProvideValue((IServiceProvider)val142);
			val113.Light = light6;
			val112.Key = "BorderDark";
			StaticResourceExtension val144 = new StaticResourceExtension
			{
				Key = "BorderDark"
			};
			XamlServiceProvider val145 = new XamlServiceProvider();
			Type? typeFromHandle12 = typeof(IProvideValueTarget);
			int length4;
			object[] array13 = new object[(length4 = parentValues.Length) + 2];
			Array.Copy(parentValues, 0, array13, 2, length4);
			array13[0] = val113;
			array13[1] = val131;
			SimpleValueTargetProvider val146 = new SimpleValueTargetProvider(array13, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Dark"), (INameScope[])(object)new NameScope[7] { val132, val132, val132, val92, val86, val64, val57 }, false);
			object obj12 = (object)val146;
			val145.Add(typeFromHandle12, (object)val146);
			val145.Add(typeof(IReferenceProvider), obj12);
			val145.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(26, 28)));
			object dark6 = val144.ProvideValue((IServiceProvider)val145);
			val113.Dark = dark6;
			XamlServiceProvider val147 = new XamlServiceProvider();
			val147.Add(typeof(IProvideValueTarget), (object)new ValueTargetProvider((object)val131, (object)Frame.BorderColorProperty));
			val147.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(26, 28)));
			BindingBase val148 = ((IMarkupExtension<BindingBase>)(object)val113).ProvideValue((IServiceProvider)val147);
			((BindableObject)val131).SetBinding(Frame.BorderColorProperty, val148);
			((BindableObject)val130).SetValue(Grid.ColumnDefinitionsProperty, (object)new ColumnDefinitionCollection((ColumnDefinition[])(object)new ColumnDefinition[3]
			{
				new ColumnDefinition(GridLength.Auto),
				new ColumnDefinition(GridLength.Star),
				new ColumnDefinition(GridLength.Auto)
			}));
			((BindableObject)val115).SetValue(VisualElement.WidthRequestProperty, (object)40.0);
			((BindableObject)val115).SetValue(VisualElement.HeightRequestProperty, (object)40.0);
			((BindableObject)val115).SetValue(BoxView.CornerRadiusProperty, (object)new CornerRadius(20.0));
			val114.Path = "Color";
			XamlServiceProvider val149 = new XamlServiceProvider();
			Type? typeFromHandle13 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val150 = new XmlNamespaceResolver();
			val150.Add("", "http://schemas.microsoft.com/dotnet/2021/maui");
			val150.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val149.Add(typeFromHandle13, (object)new XamlTypeResolver((IXmlNamespaceResolver)val150, typeof(_003CInitializeComponent_003E_anonXamlCDataTemplate_0).Assembly));
			BindingBase val151 = ((IMarkupExtension<BindingBase>)(object)val114).ProvideValue((IServiceProvider)val149);
			((BindableObject)val115).SetBinding(BoxView.ColorProperty, val151);
			((Layout)val130).Children.Add((IView)(object)val115);
			((BindableObject)val126).SetValue(Grid.ColumnProperty, (object)1);
			((BindableObject)val126).SetValue(View.MarginProperty, (object)new Thickness(15.0, 0.0));
			((BindableObject)val126).SetValue(View.VerticalOptionsProperty, (object)LayoutOptions.Center);
			val116.Path = "Name";
			XamlServiceProvider val152 = new XamlServiceProvider();
			Type? typeFromHandle14 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val153 = new XmlNamespaceResolver();
			val153.Add("", "http://schemas.microsoft.com/dotnet/2021/maui");
			val153.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val152.Add(typeFromHandle14, (object)new XamlTypeResolver((IXmlNamespaceResolver)val153, typeof(_003CInitializeComponent_003E_anonXamlCDataTemplate_0).Assembly));
			BindingBase val154 = ((IMarkupExtension<BindingBase>)(object)val116).ProvideValue((IServiceProvider)val152);
			((BindableObject)val120).SetBinding(Label.TextProperty, val154);
			((BindableObject)val120).SetValue(Label.FontSizeProperty, (object)16.0);
			((BindableObject)val120).SetValue(Label.FontAttributesProperty, (object)(FontAttributes)1);
			val117.Key = "TextPrimaryLight";
			StaticResourceExtension val155 = new StaticResourceExtension
			{
				Key = "TextPrimaryLight"
			};
			XamlServiceProvider val156 = new XamlServiceProvider();
			Type? typeFromHandle15 = typeof(IProvideValueTarget);
			int length5;
			object[] array14 = new object[(length5 = parentValues.Length) + 5];
			Array.Copy(parentValues, 0, array14, 5, length5);
			array14[0] = val119;
			array14[1] = val120;
			array14[2] = val126;
			array14[3] = val130;
			array14[4] = val131;
			SimpleValueTargetProvider val157 = new SimpleValueTargetProvider(array14, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Light"), (INameScope[])(object)new NameScope[10] { val132, val132, val132, val132, val132, val132, val92, val86, val64, val57 }, false);
			object obj13 = (object)val157;
			val156.Add(typeFromHandle15, (object)val157);
			val156.Add(typeof(IReferenceProvider), obj13);
			val156.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(32, 40)));
			object light7 = val155.ProvideValue((IServiceProvider)val156);
			val119.Light = light7;
			val118.Key = "TextPrimaryDark";
			StaticResourceExtension val158 = new StaticResourceExtension
			{
				Key = "TextPrimaryDark"
			};
			XamlServiceProvider val159 = new XamlServiceProvider();
			Type? typeFromHandle16 = typeof(IProvideValueTarget);
			int length6;
			object[] array15 = new object[(length6 = parentValues.Length) + 5];
			Array.Copy(parentValues, 0, array15, 5, length6);
			array15[0] = val119;
			array15[1] = val120;
			array15[2] = val126;
			array15[3] = val130;
			array15[4] = val131;
			SimpleValueTargetProvider val160 = new SimpleValueTargetProvider(array15, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Dark"), (INameScope[])(object)new NameScope[10] { val132, val132, val132, val132, val132, val132, val92, val86, val64, val57 }, false);
			object obj14 = (object)val160;
			val159.Add(typeFromHandle16, (object)val160);
			val159.Add(typeof(IReferenceProvider), obj14);
			val159.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(32, 40)));
			object dark7 = val158.ProvideValue((IServiceProvider)val159);
			val119.Dark = dark7;
			XamlServiceProvider val161 = new XamlServiceProvider();
			val161.Add(typeof(IProvideValueTarget), (object)new ValueTargetProvider((object)val120, (object)Label.TextColorProperty));
			val161.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(32, 40)));
			BindingBase val162 = ((IMarkupExtension<BindingBase>)(object)val119).ProvideValue((IServiceProvider)val161);
			((BindableObject)val120).SetBinding(Label.TextColorProperty, val162);
			((Layout)val126).Children.Add((IView)(object)val120);
			val121.Path = "Description";
			XamlServiceProvider val163 = new XamlServiceProvider();
			Type? typeFromHandle17 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val164 = new XmlNamespaceResolver();
			val164.Add("", "http://schemas.microsoft.com/dotnet/2021/maui");
			val164.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val163.Add(typeFromHandle17, (object)new XamlTypeResolver((IXmlNamespaceResolver)val164, typeof(_003CInitializeComponent_003E_anonXamlCDataTemplate_0).Assembly));
			BindingBase val165 = ((IMarkupExtension<BindingBase>)(object)val121).ProvideValue((IServiceProvider)val163);
			((BindableObject)val125).SetBinding(Label.TextProperty, val165);
			((BindableObject)val125).SetValue(Label.FontSizeProperty, (object)12.0);
			val122.Key = "TextSecondaryLight";
			StaticResourceExtension val166 = new StaticResourceExtension
			{
				Key = "TextSecondaryLight"
			};
			XamlServiceProvider val167 = new XamlServiceProvider();
			Type? typeFromHandle18 = typeof(IProvideValueTarget);
			int length7;
			object[] array16 = new object[(length7 = parentValues.Length) + 5];
			Array.Copy(parentValues, 0, array16, 5, length7);
			array16[0] = val124;
			array16[1] = val125;
			array16[2] = val126;
			array16[3] = val130;
			array16[4] = val131;
			SimpleValueTargetProvider val168 = new SimpleValueTargetProvider(array16, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Light"), (INameScope[])(object)new NameScope[10] { val132, val132, val132, val132, val132, val132, val92, val86, val64, val57 }, false);
			object obj15 = (object)val168;
			val167.Add(typeFromHandle18, (object)val168);
			val167.Add(typeof(IReferenceProvider), obj15);
			val167.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(34, 40)));
			object light8 = val166.ProvideValue((IServiceProvider)val167);
			val124.Light = light8;
			val123.Key = "TextSecondaryDark";
			StaticResourceExtension val169 = new StaticResourceExtension
			{
				Key = "TextSecondaryDark"
			};
			XamlServiceProvider val170 = new XamlServiceProvider();
			Type? typeFromHandle19 = typeof(IProvideValueTarget);
			int length8;
			object[] array17 = new object[(length8 = parentValues.Length) + 5];
			Array.Copy(parentValues, 0, array17, 5, length8);
			array17[0] = val124;
			array17[1] = val125;
			array17[2] = val126;
			array17[3] = val130;
			array17[4] = val131;
			SimpleValueTargetProvider val171 = new SimpleValueTargetProvider(array17, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Dark"), (INameScope[])(object)new NameScope[10] { val132, val132, val132, val132, val132, val132, val92, val86, val64, val57 }, false);
			object obj16 = (object)val171;
			val170.Add(typeFromHandle19, (object)val171);
			val170.Add(typeof(IReferenceProvider), obj16);
			val170.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(34, 40)));
			object dark8 = val169.ProvideValue((IServiceProvider)val170);
			val124.Dark = dark8;
			XamlServiceProvider val172 = new XamlServiceProvider();
			val172.Add(typeof(IProvideValueTarget), (object)new ValueTargetProvider((object)val125, (object)Label.TextColorProperty));
			val172.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(34, 40)));
			BindingBase val173 = ((IMarkupExtension<BindingBase>)(object)val124).ProvideValue((IServiceProvider)val172);
			((BindableObject)val125).SetBinding(Label.TextColorProperty, val173);
			((Layout)val126).Children.Add((IView)(object)val125);
			((Layout)val130).Children.Add((IView)(object)val126);
			((BindableObject)val129).SetValue(Grid.ColumnProperty, (object)2);
			val127.Path = "Price";
			XamlServiceProvider val174 = new XamlServiceProvider();
			Type? typeFromHandle20 = typeof(IXamlTypeResolver);
			XmlNamespaceResolver val175 = new XmlNamespaceResolver();
			val175.Add("", "http://schemas.microsoft.com/dotnet/2021/maui");
			val175.Add("x", "http://schemas.microsoft.com/winfx/2009/xaml");
			val174.Add(typeFromHandle20, (object)new XamlTypeResolver((IXmlNamespaceResolver)val175, typeof(_003CInitializeComponent_003E_anonXamlCDataTemplate_0).Assembly));
			BindingBase val176 = ((IMarkupExtension<BindingBase>)(object)val127).ProvideValue((IServiceProvider)val174);
			((BindableObject)val129).SetBinding(Label.TextProperty, val176);
			((BindableObject)val129).SetValue(Label.FontSizeProperty, (object)14.0);
			((BindableObject)val129).SetValue(Label.FontAttributesProperty, (object)(FontAttributes)1);
			((BindableObject)val129).SetValue(View.VerticalOptionsProperty, (object)LayoutOptions.Center);
			val128.Key = "PrimaryColor";
			StaticResourceExtension val177 = new StaticResourceExtension
			{
				Key = "PrimaryColor"
			};
			XamlServiceProvider val178 = new XamlServiceProvider();
			Type? typeFromHandle21 = typeof(IProvideValueTarget);
			int length9;
			object[] array18 = new object[(length9 = parentValues.Length) + 3];
			Array.Copy(parentValues, 0, array18, 3, length9);
			array18[0] = val129;
			array18[1] = val130;
			array18[2] = val131;
			SimpleValueTargetProvider val179 = new SimpleValueTargetProvider(array18, (object)Label.TextColorProperty, (INameScope[])(object)new NameScope[8] { val132, val132, val132, val132, val92, val86, val64, val57 }, false);
			object obj17 = (object)val179;
			val178.Add(typeFromHandle21, (object)val179);
			val178.Add(typeof(IReferenceProvider), obj17);
			val178.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(38, 36)));
			object obj18 = val177.ProvideValue((IServiceProvider)val178);
			((BindableObject)val129).SetValue(Label.TextColorProperty, (obj18 == null || !typeof(BindingBase).IsAssignableFrom(obj18.GetType())) ? obj18 : obj18);
			((Layout)val130).Children.Add((IView)(object)val129);
			((BindableObject)val131).SetValue(ContentView.ContentProperty, (object)val130);
			return val131;
		};
		((BindableObject)val14).SetValue(ItemsView.ItemTemplateProperty, (object)val13);
		((Layout)val21).Children.Add((IView)(object)val14);
		((BindableObject)val20).SetValue(Grid.RowProperty, (object)2);
		((BindableObject)val20).SetValue(Layout.PaddingProperty, (object)new Thickness(15.0));
		((BindableObject)val20).SetValue(Frame.CornerRadiusProperty, (object)0f);
		val15.Light = "#F5F5F5";
		val15.Dark = "#1E1E1E";
		XamlServiceProvider val47 = new XamlServiceProvider();
		val47.Add(typeof(IProvideValueTarget), (object)new ValueTargetProvider((object)val20, (object)VisualElement.BackgroundColorProperty));
		val47.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(47, 16)));
		BindingBase val48 = ((IMarkupExtension<BindingBase>)(object)val15).ProvideValue((IServiceProvider)val47);
		((BindableObject)val20).SetBinding(VisualElement.BackgroundColorProperty, val48);
		((BindableObject)val19).SetValue(Label.TextProperty, (object)"No item selected");
		val16.Key = "TextPrimaryLight";
		StaticResourceExtension val49 = new StaticResourceExtension
		{
			Key = "TextPrimaryLight"
		};
		XamlServiceProvider val50 = new XamlServiceProvider();
		Type? typeFromHandle7 = typeof(IProvideValueTarget);
		object[] array8 = new object[0 + 5];
		array8[0] = val18;
		array8[1] = val19;
		array8[2] = val20;
		array8[3] = val21;
		array8[4] = listsPage;
		SimpleValueTargetProvider val51 = new SimpleValueTargetProvider(array8, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Light"), (INameScope[])(object)new NameScope[6] { val22, val22, val22, val22, val22, val22 }, false);
		object obj7 = (object)val51;
		val50.Add(typeFromHandle7, (object)val51);
		val50.Add(typeof(IReferenceProvider), obj7);
		val50.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(49, 20)));
		object light4 = val49.ProvideValue((IServiceProvider)val50);
		val18.Light = light4;
		val17.Key = "TextPrimaryDark";
		StaticResourceExtension val52 = new StaticResourceExtension
		{
			Key = "TextPrimaryDark"
		};
		XamlServiceProvider val53 = new XamlServiceProvider();
		Type? typeFromHandle8 = typeof(IProvideValueTarget);
		object[] array9 = new object[0 + 5];
		array9[0] = val18;
		array9[1] = val19;
		array9[2] = val20;
		array9[3] = val21;
		array9[4] = listsPage;
		SimpleValueTargetProvider val54 = new SimpleValueTargetProvider(array9, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Dark"), (INameScope[])(object)new NameScope[6] { val22, val22, val22, val22, val22, val22 }, false);
		object obj8 = (object)val54;
		val53.Add(typeFromHandle8, (object)val54);
		val53.Add(typeof(IReferenceProvider), obj8);
		val53.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(49, 20)));
		object dark4 = val52.ProvideValue((IServiceProvider)val53);
		val18.Dark = dark4;
		XamlServiceProvider val55 = new XamlServiceProvider();
		val55.Add(typeof(IProvideValueTarget), (object)new ValueTargetProvider((object)val19, (object)Label.TextColorProperty));
		val55.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(49, 20)));
		BindingBase val56 = ((IMarkupExtension<BindingBase>)(object)val18).ProvideValue((IServiceProvider)val55);
		((BindableObject)val19).SetBinding(Label.TextColorProperty, val56);
		((BindableObject)val20).SetValue(ContentView.ContentProperty, (object)val19);
		((Layout)val21).Children.Add((IView)(object)val20);
		((BindableObject)listsPage).SetValue(ContentPage.ContentProperty, (object)val21);
	}
}
