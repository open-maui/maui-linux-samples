using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Xml;
using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Internals;
using Microsoft.Maui.Controls.Xaml;
using Microsoft.Maui.Controls.Xaml.Internals;
using Microsoft.Maui.Graphics;

namespace XamlBrowser;

[XamlFilePath("MainPage.xaml")]
public class MainPage : ContentPage
{
	private const string HomeUrl = "https://openmaui.net";

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private Entry AddressBar;

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private ProgressBar LoadingProgress;

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private WebView BrowserWebView;

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private Label StatusLabel;

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private ImageButton ThemeToggle;

	public MainPage()
	{
		InitializeComponent();
		((InputView)AddressBar).Text = "https://openmaui.net";
	}

	private void OnBackClicked(object? sender, EventArgs e)
	{
		Console.WriteLine($"[MainPage] OnBackClicked, CanGoBack={BrowserWebView.CanGoBack}");
		if (BrowserWebView.CanGoBack)
		{
			BrowserWebView.GoBack();
		}
	}

	private void OnForwardClicked(object? sender, EventArgs e)
	{
		Console.WriteLine($"[MainPage] OnForwardClicked, CanGoForward={BrowserWebView.CanGoForward}");
		if (BrowserWebView.CanGoForward)
		{
			BrowserWebView.GoForward();
		}
	}

	private void OnRefreshClicked(object? sender, EventArgs e)
	{
		Console.WriteLine("[MainPage] OnRefreshClicked");
		BrowserWebView.Reload();
	}

	private void OnStopClicked(object? sender, EventArgs e)
	{
		((VisualElement)LoadingProgress).IsVisible = false;
		StatusLabel.Text = "Stopped";
	}

	private void OnHomeClicked(object? sender, EventArgs e)
	{
		NavigateTo("https://openmaui.net");
	}

	private void OnAddressBarCompleted(object? sender, EventArgs e)
	{
		NavigateTo(((InputView)AddressBar).Text);
	}

	private void OnGoClicked(object? sender, EventArgs e)
	{
		NavigateTo(((InputView)AddressBar).Text);
	}

	private void NavigateTo(string? url)
	{
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Expected O, but got Unknown
		if (!string.IsNullOrWhiteSpace(url))
		{
			if (!url.StartsWith("http://", StringComparison.OrdinalIgnoreCase) && !url.StartsWith("https://", StringComparison.OrdinalIgnoreCase))
			{
				url = ((!url.Contains('.') || url.Contains(' ')) ? ("https://www.google.com/search?q=" + Uri.EscapeDataString(url)) : ("https://" + url));
			}
			((InputView)AddressBar).Text = url;
			BrowserWebView.Source = (WebViewSource)new UrlWebViewSource
			{
				Url = url
			};
		}
	}

	private void OnWebViewNavigating(object? sender, WebNavigatingEventArgs e)
	{
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Expected O, but got Unknown
		Console.WriteLine("[MainPage] Navigating to: " + ((WebNavigationEventArgs)e).Url);
		StatusLabel.Text = "Loading " + ((WebNavigationEventArgs)e).Url + "...";
		AnimationExtensions.AbortAnimation((IAnimatable)(object)LoadingProgress, "Progress");
		LoadingProgress.Progress = 0.0;
		((VisualElement)LoadingProgress).IsVisible = true;
		AnimationExtensions.Animate((IAnimatable)(object)LoadingProgress, "Progress", new Animation((Action<double>)delegate(double v)
		{
			LoadingProgress.Progress = v;
		}, 0.0, 0.9, (Easing)null, (Action)null), 16u, 2000u, Easing.CubicOut, (Action<double, bool>)null, (Func<bool>)null);
		((InputView)AddressBar).Text = ((WebNavigationEventArgs)e).Url;
	}

	private void OnWebViewNavigated(object? sender, WebNavigatedEventArgs e)
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Invalid comparison between Unknown and I4
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		Console.WriteLine($"[MainPage] Navigated: {((WebNavigationEventArgs)e).Url} - Result: {e.Result}");
		StatusLabel.Text = (((int)e.Result == 1) ? "Done" : $"Error: {e.Result}");
		AnimationExtensions.AbortAnimation((IAnimatable)(object)LoadingProgress, "Progress");
		LoadingProgress.Progress = 1.0;
		((InputView)AddressBar).Text = ((WebNavigationEventArgs)e).Url;
		((BindableObject)this).Dispatcher.DispatchDelayed(TimeSpan.FromMilliseconds(300L, 0L), (Action)delegate
		{
			((VisualElement)LoadingProgress).IsVisible = false;
			LoadingProgress.Progress = 0.0;
		});
	}

	private void OnThemeToggleClicked(object? sender, EventArgs e)
	{
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		if (Application.Current is BrowserApp browserApp)
		{
			browserApp.ToggleTheme();
			Console.WriteLine($"[MainPage] Theme changed to: {Application.Current.UserAppTheme}");
		}
	}

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	[MemberNotNull("AddressBar")]
	[MemberNotNull("LoadingProgress")]
	[MemberNotNull("BrowserWebView")]
	[MemberNotNull("StatusLabel")]
	[MemberNotNull("ThemeToggle")]
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
		//IL_0168: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0303: Unknown result type (might be due to invalid IL or missing references)
		//IL_0349: Unknown result type (might be due to invalid IL or missing references)
		//IL_034e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0351: Expected O, but got Unknown
		//IL_0356: Expected O, but got Unknown
		//IL_0356: Unknown result type (might be due to invalid IL or missing references)
		//IL_0368: Unknown result type (might be due to invalid IL or missing references)
		//IL_0376: Unknown result type (might be due to invalid IL or missing references)
		//IL_0380: Expected O, but got Unknown
		//IL_037b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0385: Expected O, but got Unknown
		//IL_038a: Expected O, but got Unknown
		//IL_039f: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03af: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0402: Expected O, but got Unknown
		//IL_0407: Expected O, but got Unknown
		//IL_0407: Unknown result type (might be due to invalid IL or missing references)
		//IL_0419: Unknown result type (might be due to invalid IL or missing references)
		//IL_0427: Unknown result type (might be due to invalid IL or missing references)
		//IL_0431: Expected O, but got Unknown
		//IL_042c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0436: Expected O, but got Unknown
		//IL_043b: Expected O, but got Unknown
		//IL_0446: Unknown result type (might be due to invalid IL or missing references)
		//IL_044b: Unknown result type (might be due to invalid IL or missing references)
		//IL_045d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0467: Expected O, but got Unknown
		//IL_0467: Unknown result type (might be due to invalid IL or missing references)
		//IL_0475: Unknown result type (might be due to invalid IL or missing references)
		//IL_047f: Expected O, but got Unknown
		//IL_047a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0484: Expected O, but got Unknown
		//IL_0489: Expected O, but got Unknown
		//IL_04a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b3: Expected O, but got Unknown
		//IL_04b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c0: Expected O, but got Unknown
		//IL_04c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04cd: Expected O, but got Unknown
		//IL_04cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04da: Expected O, but got Unknown
		//IL_04da: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e4: Expected O, but got Unknown
		//IL_0505: Unknown result type (might be due to invalid IL or missing references)
		//IL_050a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0510: Expected O, but got Unknown
		//IL_0512: Unknown result type (might be due to invalid IL or missing references)
		//IL_0517: Unknown result type (might be due to invalid IL or missing references)
		//IL_051d: Expected O, but got Unknown
		//IL_051f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0524: Unknown result type (might be due to invalid IL or missing references)
		//IL_052a: Expected O, but got Unknown
		//IL_052c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0531: Unknown result type (might be due to invalid IL or missing references)
		//IL_0537: Expected O, but got Unknown
		//IL_0539: Unknown result type (might be due to invalid IL or missing references)
		//IL_053e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0544: Expected O, but got Unknown
		//IL_0546: Unknown result type (might be due to invalid IL or missing references)
		//IL_054b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0551: Expected O, but got Unknown
		//IL_0553: Unknown result type (might be due to invalid IL or missing references)
		//IL_0558: Unknown result type (might be due to invalid IL or missing references)
		//IL_055e: Expected O, but got Unknown
		//IL_055e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0568: Expected O, but got Unknown
		//IL_0581: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_0625: Unknown result type (might be due to invalid IL or missing references)
		//IL_062a: Unknown result type (might be due to invalid IL or missing references)
		//IL_062d: Expected O, but got Unknown
		//IL_0632: Expected O, but got Unknown
		//IL_0632: Unknown result type (might be due to invalid IL or missing references)
		//IL_0644: Unknown result type (might be due to invalid IL or missing references)
		//IL_0653: Unknown result type (might be due to invalid IL or missing references)
		//IL_065d: Expected O, but got Unknown
		//IL_0658: Unknown result type (might be due to invalid IL or missing references)
		//IL_0662: Expected O, but got Unknown
		//IL_0667: Expected O, but got Unknown
		//IL_067e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0683: Unknown result type (might be due to invalid IL or missing references)
		//IL_068e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0693: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f6: Expected O, but got Unknown
		//IL_06fb: Expected O, but got Unknown
		//IL_06fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_070d: Unknown result type (might be due to invalid IL or missing references)
		//IL_071c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0726: Expected O, but got Unknown
		//IL_0721: Unknown result type (might be due to invalid IL or missing references)
		//IL_072b: Expected O, but got Unknown
		//IL_0730: Expected O, but got Unknown
		//IL_073d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0742: Unknown result type (might be due to invalid IL or missing references)
		//IL_0754: Unknown result type (might be due to invalid IL or missing references)
		//IL_075e: Expected O, but got Unknown
		//IL_075e: Unknown result type (might be due to invalid IL or missing references)
		//IL_076d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0777: Expected O, but got Unknown
		//IL_0772: Unknown result type (might be due to invalid IL or missing references)
		//IL_077c: Expected O, but got Unknown
		//IL_0781: Expected O, but got Unknown
		//IL_07bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_07c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_07de: Expected O, but got Unknown
		//IL_07de: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f7: Expected O, but got Unknown
		//IL_07f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_07fc: Expected O, but got Unknown
		//IL_0801: Expected O, but got Unknown
		//IL_0868: Unknown result type (might be due to invalid IL or missing references)
		//IL_0883: Unknown result type (might be due to invalid IL or missing references)
		//IL_0888: Unknown result type (might be due to invalid IL or missing references)
		//IL_0893: Unknown result type (might be due to invalid IL or missing references)
		//IL_0898: Unknown result type (might be due to invalid IL or missing references)
		//IL_08fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0902: Unknown result type (might be due to invalid IL or missing references)
		//IL_0905: Expected O, but got Unknown
		//IL_090a: Expected O, but got Unknown
		//IL_090a: Unknown result type (might be due to invalid IL or missing references)
		//IL_091c: Unknown result type (might be due to invalid IL or missing references)
		//IL_092b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0935: Expected O, but got Unknown
		//IL_0930: Unknown result type (might be due to invalid IL or missing references)
		//IL_093a: Expected O, but got Unknown
		//IL_093f: Expected O, but got Unknown
		//IL_0956: Unknown result type (might be due to invalid IL or missing references)
		//IL_095b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0966: Unknown result type (might be due to invalid IL or missing references)
		//IL_096b: Unknown result type (might be due to invalid IL or missing references)
		//IL_09d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_09d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_09d8: Expected O, but got Unknown
		//IL_09dd: Expected O, but got Unknown
		//IL_09dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_09ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_09fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a08: Expected O, but got Unknown
		//IL_0a03: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a0d: Expected O, but got Unknown
		//IL_0a12: Expected O, but got Unknown
		//IL_0a1f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a24: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a36: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a40: Expected O, but got Unknown
		//IL_0a40: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a4f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a59: Expected O, but got Unknown
		//IL_0a54: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a5e: Expected O, but got Unknown
		//IL_0a63: Expected O, but got Unknown
		//IL_0ae3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ae8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0afa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b04: Expected O, but got Unknown
		//IL_0b04: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b13: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b1d: Expected O, but got Unknown
		//IL_0b18: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b22: Expected O, but got Unknown
		//IL_0b27: Expected O, but got Unknown
		//IL_0b8e: Unknown result type (might be due to invalid IL or missing references)
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
		//IL_0c7c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c81: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c8c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c91: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cf6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cfb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cfe: Expected O, but got Unknown
		//IL_0d03: Expected O, but got Unknown
		//IL_0d03: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d15: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d24: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d2e: Expected O, but got Unknown
		//IL_0d29: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d33: Expected O, but got Unknown
		//IL_0d38: Expected O, but got Unknown
		//IL_0d45: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d4a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d5c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d66: Expected O, but got Unknown
		//IL_0d66: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d75: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d7f: Expected O, but got Unknown
		//IL_0d7a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d84: Expected O, but got Unknown
		//IL_0d89: Expected O, but got Unknown
		//IL_0e09: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e0e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e20: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e2a: Expected O, but got Unknown
		//IL_0e2a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e39: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e43: Expected O, but got Unknown
		//IL_0e3e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e48: Expected O, but got Unknown
		//IL_0e4d: Expected O, but got Unknown
		//IL_0eb4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ecf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ed4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0edf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ee4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f49: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f4e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f51: Expected O, but got Unknown
		//IL_0f56: Expected O, but got Unknown
		//IL_0f56: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f68: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f77: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f81: Expected O, but got Unknown
		//IL_0f7c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f86: Expected O, but got Unknown
		//IL_0f8b: Expected O, but got Unknown
		//IL_0fa2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fa7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fb2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fb7: Unknown result type (might be due to invalid IL or missing references)
		//IL_101c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1021: Unknown result type (might be due to invalid IL or missing references)
		//IL_1024: Expected O, but got Unknown
		//IL_1029: Expected O, but got Unknown
		//IL_1029: Unknown result type (might be due to invalid IL or missing references)
		//IL_103b: Unknown result type (might be due to invalid IL or missing references)
		//IL_104a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1054: Expected O, but got Unknown
		//IL_104f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1059: Expected O, but got Unknown
		//IL_105e: Expected O, but got Unknown
		//IL_106b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1070: Unknown result type (might be due to invalid IL or missing references)
		//IL_1082: Unknown result type (might be due to invalid IL or missing references)
		//IL_108c: Expected O, but got Unknown
		//IL_108c: Unknown result type (might be due to invalid IL or missing references)
		//IL_109b: Unknown result type (might be due to invalid IL or missing references)
		//IL_10a5: Expected O, but got Unknown
		//IL_10a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_10aa: Expected O, but got Unknown
		//IL_10af: Expected O, but got Unknown
		//IL_112f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1134: Unknown result type (might be due to invalid IL or missing references)
		//IL_1146: Unknown result type (might be due to invalid IL or missing references)
		//IL_1150: Expected O, but got Unknown
		//IL_1150: Unknown result type (might be due to invalid IL or missing references)
		//IL_115f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1169: Expected O, but got Unknown
		//IL_1164: Unknown result type (might be due to invalid IL or missing references)
		//IL_116e: Expected O, but got Unknown
		//IL_1173: Expected O, but got Unknown
		//IL_11da: Unknown result type (might be due to invalid IL or missing references)
		//IL_11f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_11fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_1205: Unknown result type (might be due to invalid IL or missing references)
		//IL_120a: Unknown result type (might be due to invalid IL or missing references)
		//IL_126f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1274: Unknown result type (might be due to invalid IL or missing references)
		//IL_1277: Expected O, but got Unknown
		//IL_127c: Expected O, but got Unknown
		//IL_127c: Unknown result type (might be due to invalid IL or missing references)
		//IL_128e: Unknown result type (might be due to invalid IL or missing references)
		//IL_129d: Unknown result type (might be due to invalid IL or missing references)
		//IL_12a7: Expected O, but got Unknown
		//IL_12a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_12ac: Expected O, but got Unknown
		//IL_12b1: Expected O, but got Unknown
		//IL_12c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_12cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_12d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_12dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_1342: Unknown result type (might be due to invalid IL or missing references)
		//IL_1347: Unknown result type (might be due to invalid IL or missing references)
		//IL_134a: Expected O, but got Unknown
		//IL_134f: Expected O, but got Unknown
		//IL_134f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1361: Unknown result type (might be due to invalid IL or missing references)
		//IL_1370: Unknown result type (might be due to invalid IL or missing references)
		//IL_137a: Expected O, but got Unknown
		//IL_1375: Unknown result type (might be due to invalid IL or missing references)
		//IL_137f: Expected O, but got Unknown
		//IL_1384: Expected O, but got Unknown
		//IL_1391: Unknown result type (might be due to invalid IL or missing references)
		//IL_1396: Unknown result type (might be due to invalid IL or missing references)
		//IL_13a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_13b2: Expected O, but got Unknown
		//IL_13b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_13c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_13cb: Expected O, but got Unknown
		//IL_13c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_13d0: Expected O, but got Unknown
		//IL_13d5: Expected O, but got Unknown
		//IL_1455: Unknown result type (might be due to invalid IL or missing references)
		//IL_145a: Unknown result type (might be due to invalid IL or missing references)
		//IL_146c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1476: Expected O, but got Unknown
		//IL_1476: Unknown result type (might be due to invalid IL or missing references)
		//IL_1485: Unknown result type (might be due to invalid IL or missing references)
		//IL_148f: Expected O, but got Unknown
		//IL_148a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1494: Expected O, but got Unknown
		//IL_1499: Expected O, but got Unknown
		//IL_1500: Unknown result type (might be due to invalid IL or missing references)
		//IL_151b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1520: Unknown result type (might be due to invalid IL or missing references)
		//IL_152b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1530: Unknown result type (might be due to invalid IL or missing references)
		//IL_1595: Unknown result type (might be due to invalid IL or missing references)
		//IL_159a: Unknown result type (might be due to invalid IL or missing references)
		//IL_159d: Expected O, but got Unknown
		//IL_15a2: Expected O, but got Unknown
		//IL_15a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_15b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_15c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_15cd: Expected O, but got Unknown
		//IL_15c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_15d2: Expected O, but got Unknown
		//IL_15d7: Expected O, but got Unknown
		//IL_15ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_15f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_15fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_1603: Unknown result type (might be due to invalid IL or missing references)
		//IL_1668: Unknown result type (might be due to invalid IL or missing references)
		//IL_166d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1670: Expected O, but got Unknown
		//IL_1675: Expected O, but got Unknown
		//IL_1675: Unknown result type (might be due to invalid IL or missing references)
		//IL_1687: Unknown result type (might be due to invalid IL or missing references)
		//IL_1696: Unknown result type (might be due to invalid IL or missing references)
		//IL_16a0: Expected O, but got Unknown
		//IL_169b: Unknown result type (might be due to invalid IL or missing references)
		//IL_16a5: Expected O, but got Unknown
		//IL_16aa: Expected O, but got Unknown
		//IL_16b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_16bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_16ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_16d8: Expected O, but got Unknown
		//IL_16d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_16e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_16f1: Expected O, but got Unknown
		//IL_16ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_16f6: Expected O, but got Unknown
		//IL_16fb: Expected O, but got Unknown
		//IL_177e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1783: Unknown result type (might be due to invalid IL or missing references)
		//IL_178e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1793: Unknown result type (might be due to invalid IL or missing references)
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
		//IL_18a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_18a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_18b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_18b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_1905: Unknown result type (might be due to invalid IL or missing references)
		//IL_190a: Unknown result type (might be due to invalid IL or missing references)
		//IL_190d: Expected O, but got Unknown
		//IL_1912: Expected O, but got Unknown
		//IL_1912: Unknown result type (might be due to invalid IL or missing references)
		//IL_1924: Unknown result type (might be due to invalid IL or missing references)
		//IL_1933: Unknown result type (might be due to invalid IL or missing references)
		//IL_193d: Expected O, but got Unknown
		//IL_1938: Unknown result type (might be due to invalid IL or missing references)
		//IL_1942: Expected O, but got Unknown
		//IL_1947: Expected O, but got Unknown
		//IL_19f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_19f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a02: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a07: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a62: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a67: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a6a: Expected O, but got Unknown
		//IL_1a6f: Expected O, but got Unknown
		//IL_1a6f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a81: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a90: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a9a: Expected O, but got Unknown
		//IL_1a95: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a9f: Expected O, but got Unknown
		//IL_1aa4: Expected O, but got Unknown
		//IL_1abb: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ac0: Unknown result type (might be due to invalid IL or missing references)
		//IL_1acb: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ad0: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b2b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b30: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b33: Expected O, but got Unknown
		//IL_1b38: Expected O, but got Unknown
		//IL_1b38: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b4a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b59: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b63: Expected O, but got Unknown
		//IL_1b5e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b68: Expected O, but got Unknown
		//IL_1b6d: Expected O, but got Unknown
		//IL_1b7a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b7f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b91: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b9b: Expected O, but got Unknown
		//IL_1b9b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1baa: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bb4: Expected O, but got Unknown
		//IL_1baf: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bb9: Expected O, but got Unknown
		//IL_1bbe: Expected O, but got Unknown
		//IL_1bef: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bfe: Expected O, but got Unknown
		//IL_1c2a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c39: Expected O, but got Unknown
		//IL_1c9f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1cbd: Unknown result type (might be due to invalid IL or missing references)
		//IL_1cc2: Unknown result type (might be due to invalid IL or missing references)
		//IL_1cc8: Expected O, but got Unknown
		//IL_1cca: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ccf: Unknown result type (might be due to invalid IL or missing references)
		//IL_1cd5: Expected O, but got Unknown
		//IL_1cd5: Unknown result type (might be due to invalid IL or missing references)
		//IL_1cdf: Expected O, but got Unknown
		//IL_1ceb: Unknown result type (might be due to invalid IL or missing references)
		//IL_1cf0: Unknown result type (might be due to invalid IL or missing references)
		//IL_1cfb: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d00: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d5b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d60: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d63: Expected O, but got Unknown
		//IL_1d68: Expected O, but got Unknown
		//IL_1d68: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d7a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d89: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d93: Expected O, but got Unknown
		//IL_1d8e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d98: Expected O, but got Unknown
		//IL_1d9d: Expected O, but got Unknown
		//IL_1db4: Unknown result type (might be due to invalid IL or missing references)
		//IL_1db9: Unknown result type (might be due to invalid IL or missing references)
		//IL_1dc4: Unknown result type (might be due to invalid IL or missing references)
		//IL_1dc9: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e24: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e29: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e2c: Expected O, but got Unknown
		//IL_1e31: Expected O, but got Unknown
		//IL_1e31: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e43: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e52: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e5c: Expected O, but got Unknown
		//IL_1e57: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e61: Expected O, but got Unknown
		//IL_1e66: Expected O, but got Unknown
		//IL_1e73: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e78: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e8a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e94: Expected O, but got Unknown
		//IL_1e94: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ea3: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ead: Expected O, but got Unknown
		//IL_1ea8: Unknown result type (might be due to invalid IL or missing references)
		//IL_1eb2: Expected O, but got Unknown
		//IL_1eb7: Expected O, but got Unknown
		//IL_1ef6: Unknown result type (might be due to invalid IL or missing references)
		//IL_1efb: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f06: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f0b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f57: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f5c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f5f: Expected O, but got Unknown
		//IL_1f64: Expected O, but got Unknown
		//IL_1f64: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f76: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f85: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f8f: Expected O, but got Unknown
		//IL_1f8a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f94: Expected O, but got Unknown
		//IL_1f99: Expected O, but got Unknown
		//IL_2005: Unknown result type (might be due to invalid IL or missing references)
		//IL_200a: Unknown result type (might be due to invalid IL or missing references)
		//IL_201c: Unknown result type (might be due to invalid IL or missing references)
		//IL_2026: Expected O, but got Unknown
		//IL_2026: Unknown result type (might be due to invalid IL or missing references)
		//IL_2035: Unknown result type (might be due to invalid IL or missing references)
		//IL_203f: Expected O, but got Unknown
		//IL_203a: Unknown result type (might be due to invalid IL or missing references)
		//IL_2044: Expected O, but got Unknown
		//IL_2049: Expected O, but got Unknown
		//IL_20af: Unknown result type (might be due to invalid IL or missing references)
		StaticResourceExtension val = new StaticResourceExtension();
		StaticResourceExtension val2 = new StaticResourceExtension();
		AppThemeBindingExtension val3 = new AppThemeBindingExtension();
		StaticResourceExtension val4 = new StaticResourceExtension();
		StaticResourceExtension val5 = new StaticResourceExtension();
		AppThemeBindingExtension val6 = new AppThemeBindingExtension();
		AppThemeBindingExtension val7 = new AppThemeBindingExtension();
		StaticResourceExtension val8 = new StaticResourceExtension();
		StaticResourceExtension val9 = new StaticResourceExtension();
		AppThemeBindingExtension val10 = new AppThemeBindingExtension();
		ImageButton val11 = new ImageButton();
		AppThemeBindingExtension val12 = new AppThemeBindingExtension();
		StaticResourceExtension val13 = new StaticResourceExtension();
		StaticResourceExtension val14 = new StaticResourceExtension();
		AppThemeBindingExtension val15 = new AppThemeBindingExtension();
		ImageButton val16 = new ImageButton();
		AppThemeBindingExtension val17 = new AppThemeBindingExtension();
		StaticResourceExtension val18 = new StaticResourceExtension();
		StaticResourceExtension val19 = new StaticResourceExtension();
		AppThemeBindingExtension val20 = new AppThemeBindingExtension();
		ImageButton val21 = new ImageButton();
		AppThemeBindingExtension val22 = new AppThemeBindingExtension();
		StaticResourceExtension val23 = new StaticResourceExtension();
		StaticResourceExtension val24 = new StaticResourceExtension();
		AppThemeBindingExtension val25 = new AppThemeBindingExtension();
		ImageButton val26 = new ImageButton();
		AppThemeBindingExtension val27 = new AppThemeBindingExtension();
		StaticResourceExtension val28 = new StaticResourceExtension();
		StaticResourceExtension val29 = new StaticResourceExtension();
		AppThemeBindingExtension val30 = new AppThemeBindingExtension();
		ImageButton val31 = new ImageButton();
		StaticResourceExtension val32 = new StaticResourceExtension();
		Entry val33 = new Entry();
		StaticResourceExtension val34 = new StaticResourceExtension();
		Button val35 = new Button();
		Grid val36 = new Grid();
		StaticResourceExtension val37 = new StaticResourceExtension();
		StaticResourceExtension val38 = new StaticResourceExtension();
		AppThemeBindingExtension val39 = new AppThemeBindingExtension();
		ProgressBar val40 = new ProgressBar();
		WebView val41 = new WebView();
		StaticResourceExtension val42 = new StaticResourceExtension();
		StaticResourceExtension val43 = new StaticResourceExtension();
		AppThemeBindingExtension val44 = new AppThemeBindingExtension();
		StaticResourceExtension val45 = new StaticResourceExtension();
		Label val46 = new Label();
		AppThemeBindingExtension val47 = new AppThemeBindingExtension();
		ImageButton val48 = new ImageButton();
		Grid val49 = new Grid();
		Grid val50 = new Grid();
		MainPage mainPage;
		NameScope val51 = (NameScope)(((object)NameScope.GetNameScope((BindableObject)(object)(mainPage = this))) ?? ((object)new NameScope()));
		NameScope.SetNameScope((BindableObject)(object)mainPage, (INameScope)(object)val51);
		((Element)val50).transientNamescope = (INameScope)(object)val51;
		((Element)val36).transientNamescope = (INameScope)(object)val51;
		((Element)val11).transientNamescope = (INameScope)(object)val51;
		((Element)val16).transientNamescope = (INameScope)(object)val51;
		((Element)val21).transientNamescope = (INameScope)(object)val51;
		((Element)val26).transientNamescope = (INameScope)(object)val51;
		((Element)val31).transientNamescope = (INameScope)(object)val51;
		((Element)val33).transientNamescope = (INameScope)(object)val51;
		((INameScope)val51).RegisterName("AddressBar", (object)val33);
		if (((Element)val33).StyleId == null)
		{
			((Element)val33).StyleId = "AddressBar";
		}
		((Element)val35).transientNamescope = (INameScope)(object)val51;
		((Element)val40).transientNamescope = (INameScope)(object)val51;
		((INameScope)val51).RegisterName("LoadingProgress", (object)val40);
		if (((Element)val40).StyleId == null)
		{
			((Element)val40).StyleId = "LoadingProgress";
		}
		((Element)val41).transientNamescope = (INameScope)(object)val51;
		((INameScope)val51).RegisterName("BrowserWebView", (object)val41);
		if (((Element)val41).StyleId == null)
		{
			((Element)val41).StyleId = "BrowserWebView";
		}
		((Element)val49).transientNamescope = (INameScope)(object)val51;
		((Element)val46).transientNamescope = (INameScope)(object)val51;
		((INameScope)val51).RegisterName("StatusLabel", (object)val46);
		if (((Element)val46).StyleId == null)
		{
			((Element)val46).StyleId = "StatusLabel";
		}
		((Element)val48).transientNamescope = (INameScope)(object)val51;
		((INameScope)val51).RegisterName("ThemeToggle", (object)val48);
		if (((Element)val48).StyleId == null)
		{
			((Element)val48).StyleId = "ThemeToggle";
		}
		AddressBar = val33;
		LoadingProgress = val40;
		BrowserWebView = val41;
		StatusLabel = val46;
		ThemeToggle = val48;
		((BindableObject)mainPage).SetValue(Page.TitleProperty, (object)"XAML Browser");
		val.Key = "PageBackgroundLight";
		StaticResourceExtension val52 = new StaticResourceExtension
		{
			Key = "PageBackgroundLight"
		};
		XamlServiceProvider val53 = new XamlServiceProvider();
		Type? typeFromHandle = typeof(IProvideValueTarget);
		object[] array = new object[0 + 2];
		array[0] = val3;
		array[1] = mainPage;
		SimpleValueTargetProvider val54 = new SimpleValueTargetProvider(array, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Light"), (INameScope[])(object)new NameScope[3] { val51, val51, val51 }, false);
		object obj = (object)val54;
		val53.Add(typeFromHandle, (object)val54);
		val53.Add(typeof(IReferenceProvider), obj);
		val53.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(6, 14)));
		object light = val52.ProvideValue((IServiceProvider)val53);
		val3.Light = light;
		val2.Key = "PageBackgroundDark";
		StaticResourceExtension val55 = new StaticResourceExtension
		{
			Key = "PageBackgroundDark"
		};
		XamlServiceProvider val56 = new XamlServiceProvider();
		Type? typeFromHandle2 = typeof(IProvideValueTarget);
		object[] array2 = new object[0 + 2];
		array2[0] = val3;
		array2[1] = mainPage;
		SimpleValueTargetProvider val57 = new SimpleValueTargetProvider(array2, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Dark"), (INameScope[])(object)new NameScope[3] { val51, val51, val51 }, false);
		object obj2 = (object)val57;
		val56.Add(typeFromHandle2, (object)val57);
		val56.Add(typeof(IReferenceProvider), obj2);
		val56.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(6, 14)));
		object dark = val55.ProvideValue((IServiceProvider)val56);
		val3.Dark = dark;
		XamlServiceProvider val58 = new XamlServiceProvider();
		val58.Add(typeof(IProvideValueTarget), (object)new ValueTargetProvider((object)mainPage, (object)VisualElement.BackgroundColorProperty));
		val58.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(6, 14)));
		BindingBase val59 = ((IMarkupExtension<BindingBase>)(object)val3).ProvideValue((IServiceProvider)val58);
		((BindableObject)mainPage).SetBinding(VisualElement.BackgroundColorProperty, val59);
		((BindableObject)val50).SetValue(Grid.RowDefinitionsProperty, (object)new RowDefinitionCollection((RowDefinition[])(object)new RowDefinition[4]
		{
			new RowDefinition(GridLength.Auto),
			new RowDefinition(GridLength.Auto),
			new RowDefinition(GridLength.Star),
			new RowDefinition(GridLength.Auto)
		}));
		((BindableObject)val36).SetValue(Grid.RowProperty, (object)0);
		((BindableObject)val36).SetValue(Grid.ColumnDefinitionsProperty, (object)new ColumnDefinitionCollection((ColumnDefinition[])(object)new ColumnDefinition[7]
		{
			new ColumnDefinition(GridLength.Auto),
			new ColumnDefinition(GridLength.Auto),
			new ColumnDefinition(GridLength.Auto),
			new ColumnDefinition(GridLength.Auto),
			new ColumnDefinition(GridLength.Auto),
			new ColumnDefinition(GridLength.Star),
			new ColumnDefinition(GridLength.Auto)
		}));
		((BindableObject)val36).SetValue(Layout.PaddingProperty, (object)new Thickness(12.0, 8.0));
		((BindableObject)val36).SetValue(Grid.ColumnSpacingProperty, (object)8.0);
		val4.Key = "ToolbarBackgroundLight";
		StaticResourceExtension val60 = new StaticResourceExtension
		{
			Key = "ToolbarBackgroundLight"
		};
		XamlServiceProvider val61 = new XamlServiceProvider();
		Type? typeFromHandle3 = typeof(IProvideValueTarget);
		object[] array3 = new object[0 + 4];
		array3[0] = val6;
		array3[1] = val36;
		array3[2] = val50;
		array3[3] = mainPage;
		SimpleValueTargetProvider val62 = new SimpleValueTargetProvider(array3, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Light"), (INameScope[])(object)new NameScope[5] { val51, val51, val51, val51, val51 }, false);
		object obj3 = (object)val62;
		val61.Add(typeFromHandle3, (object)val62);
		val61.Add(typeof(IReferenceProvider), obj3);
		val61.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(14, 15)));
		object light2 = val60.ProvideValue((IServiceProvider)val61);
		val6.Light = light2;
		val5.Key = "ToolbarBackgroundDark";
		StaticResourceExtension val63 = new StaticResourceExtension
		{
			Key = "ToolbarBackgroundDark"
		};
		XamlServiceProvider val64 = new XamlServiceProvider();
		Type? typeFromHandle4 = typeof(IProvideValueTarget);
		object[] array4 = new object[0 + 4];
		array4[0] = val6;
		array4[1] = val36;
		array4[2] = val50;
		array4[3] = mainPage;
		SimpleValueTargetProvider val65 = new SimpleValueTargetProvider(array4, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Dark"), (INameScope[])(object)new NameScope[5] { val51, val51, val51, val51, val51 }, false);
		object obj4 = (object)val65;
		val64.Add(typeFromHandle4, (object)val65);
		val64.Add(typeof(IReferenceProvider), obj4);
		val64.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(14, 15)));
		object dark2 = val63.ProvideValue((IServiceProvider)val64);
		val6.Dark = dark2;
		XamlServiceProvider val66 = new XamlServiceProvider();
		val66.Add(typeof(IProvideValueTarget), (object)new ValueTargetProvider((object)val36, (object)VisualElement.BackgroundColorProperty));
		val66.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(14, 15)));
		BindingBase val67 = ((IMarkupExtension<BindingBase>)(object)val6).ProvideValue((IServiceProvider)val66);
		((BindableObject)val36).SetBinding(VisualElement.BackgroundColorProperty, val67);
		((BindableObject)val11).SetValue(Grid.ColumnProperty, (object)0);
		val7.Light = "arrow_back_dark.png";
		val7.Dark = "arrow_back_light.png";
		XamlServiceProvider val68 = new XamlServiceProvider();
		val68.Add(typeof(IProvideValueTarget), (object)new ValueTargetProvider((object)val11, (object)ImageButton.SourceProperty));
		val68.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(18, 26)));
		BindingBase val69 = ((IMarkupExtension<BindingBase>)(object)val7).ProvideValue((IServiceProvider)val68);
		((BindableObject)val11).SetBinding(ImageButton.SourceProperty, val69);
		((BindableObject)val11).SetValue(VisualElement.WidthRequestProperty, (object)40.0);
		((BindableObject)val11).SetValue(VisualElement.HeightRequestProperty, (object)40.0);
		((BindableObject)val11).SetValue(ImageButton.CornerRadiusProperty, (object)20);
		((BindableObject)val11).SetValue(ImageButton.PaddingProperty, (object)new Thickness(8.0));
		val8.Key = "ButtonBackgroundLight";
		StaticResourceExtension val70 = new StaticResourceExtension
		{
			Key = "ButtonBackgroundLight"
		};
		XamlServiceProvider val71 = new XamlServiceProvider();
		Type? typeFromHandle5 = typeof(IProvideValueTarget);
		object[] array5 = new object[0 + 5];
		array5[0] = val10;
		array5[1] = val11;
		array5[2] = val36;
		array5[3] = val50;
		array5[4] = mainPage;
		SimpleValueTargetProvider val72 = new SimpleValueTargetProvider(array5, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Light"), (INameScope[])(object)new NameScope[6] { val51, val51, val51, val51, val51, val51 }, false);
		object obj5 = (object)val72;
		val71.Add(typeFromHandle5, (object)val72);
		val71.Add(typeof(IReferenceProvider), obj5);
		val71.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(23, 26)));
		object light3 = val70.ProvideValue((IServiceProvider)val71);
		val10.Light = light3;
		val9.Key = "ButtonBackgroundDark";
		StaticResourceExtension val73 = new StaticResourceExtension
		{
			Key = "ButtonBackgroundDark"
		};
		XamlServiceProvider val74 = new XamlServiceProvider();
		Type? typeFromHandle6 = typeof(IProvideValueTarget);
		object[] array6 = new object[0 + 5];
		array6[0] = val10;
		array6[1] = val11;
		array6[2] = val36;
		array6[3] = val50;
		array6[4] = mainPage;
		SimpleValueTargetProvider val75 = new SimpleValueTargetProvider(array6, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Dark"), (INameScope[])(object)new NameScope[6] { val51, val51, val51, val51, val51, val51 }, false);
		object obj6 = (object)val75;
		val74.Add(typeFromHandle6, (object)val75);
		val74.Add(typeof(IReferenceProvider), obj6);
		val74.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(23, 26)));
		object dark3 = val73.ProvideValue((IServiceProvider)val74);
		val10.Dark = dark3;
		XamlServiceProvider val76 = new XamlServiceProvider();
		val76.Add(typeof(IProvideValueTarget), (object)new ValueTargetProvider((object)val11, (object)VisualElement.BackgroundColorProperty));
		val76.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(23, 26)));
		BindingBase val77 = ((IMarkupExtension<BindingBase>)(object)val10).ProvideValue((IServiceProvider)val76);
		((BindableObject)val11).SetBinding(VisualElement.BackgroundColorProperty, val77);
		val11.Clicked += mainPage.OnBackClicked;
		((BindableObject)val11).SetValue(Element.AutomationIdProperty, (object)"BackButton");
		((BindableObject)val11).SetValue(ToolTipProperties.TextProperty, (object)"Go Back");
		((Layout)val36).Children.Add((IView)(object)val11);
		((BindableObject)val16).SetValue(Grid.ColumnProperty, (object)1);
		val12.Light = "arrow_forward_dark.png";
		val12.Dark = "arrow_forward_light.png";
		XamlServiceProvider val78 = new XamlServiceProvider();
		val78.Add(typeof(IProvideValueTarget), (object)new ValueTargetProvider((object)val16, (object)ImageButton.SourceProperty));
		val78.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(30, 26)));
		BindingBase val79 = ((IMarkupExtension<BindingBase>)(object)val12).ProvideValue((IServiceProvider)val78);
		((BindableObject)val16).SetBinding(ImageButton.SourceProperty, val79);
		((BindableObject)val16).SetValue(VisualElement.WidthRequestProperty, (object)40.0);
		((BindableObject)val16).SetValue(VisualElement.HeightRequestProperty, (object)40.0);
		((BindableObject)val16).SetValue(ImageButton.CornerRadiusProperty, (object)20);
		((BindableObject)val16).SetValue(ImageButton.PaddingProperty, (object)new Thickness(8.0));
		val13.Key = "ButtonBackgroundLight";
		StaticResourceExtension val80 = new StaticResourceExtension
		{
			Key = "ButtonBackgroundLight"
		};
		XamlServiceProvider val81 = new XamlServiceProvider();
		Type? typeFromHandle7 = typeof(IProvideValueTarget);
		object[] array7 = new object[0 + 5];
		array7[0] = val15;
		array7[1] = val16;
		array7[2] = val36;
		array7[3] = val50;
		array7[4] = mainPage;
		SimpleValueTargetProvider val82 = new SimpleValueTargetProvider(array7, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Light"), (INameScope[])(object)new NameScope[6] { val51, val51, val51, val51, val51, val51 }, false);
		object obj7 = (object)val82;
		val81.Add(typeFromHandle7, (object)val82);
		val81.Add(typeof(IReferenceProvider), obj7);
		val81.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(35, 26)));
		object light4 = val80.ProvideValue((IServiceProvider)val81);
		val15.Light = light4;
		val14.Key = "ButtonBackgroundDark";
		StaticResourceExtension val83 = new StaticResourceExtension
		{
			Key = "ButtonBackgroundDark"
		};
		XamlServiceProvider val84 = new XamlServiceProvider();
		Type? typeFromHandle8 = typeof(IProvideValueTarget);
		object[] array8 = new object[0 + 5];
		array8[0] = val15;
		array8[1] = val16;
		array8[2] = val36;
		array8[3] = val50;
		array8[4] = mainPage;
		SimpleValueTargetProvider val85 = new SimpleValueTargetProvider(array8, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Dark"), (INameScope[])(object)new NameScope[6] { val51, val51, val51, val51, val51, val51 }, false);
		object obj8 = (object)val85;
		val84.Add(typeFromHandle8, (object)val85);
		val84.Add(typeof(IReferenceProvider), obj8);
		val84.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(35, 26)));
		object dark4 = val83.ProvideValue((IServiceProvider)val84);
		val15.Dark = dark4;
		XamlServiceProvider val86 = new XamlServiceProvider();
		val86.Add(typeof(IProvideValueTarget), (object)new ValueTargetProvider((object)val16, (object)VisualElement.BackgroundColorProperty));
		val86.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(35, 26)));
		BindingBase val87 = ((IMarkupExtension<BindingBase>)(object)val15).ProvideValue((IServiceProvider)val86);
		((BindableObject)val16).SetBinding(VisualElement.BackgroundColorProperty, val87);
		val16.Clicked += mainPage.OnForwardClicked;
		((BindableObject)val16).SetValue(Element.AutomationIdProperty, (object)"ForwardButton");
		((BindableObject)val16).SetValue(ToolTipProperties.TextProperty, (object)"Go Forward");
		((Layout)val36).Children.Add((IView)(object)val16);
		((BindableObject)val21).SetValue(Grid.ColumnProperty, (object)2);
		val17.Light = "refresh_dark.png";
		val17.Dark = "refresh_light.png";
		XamlServiceProvider val88 = new XamlServiceProvider();
		val88.Add(typeof(IProvideValueTarget), (object)new ValueTargetProvider((object)val21, (object)ImageButton.SourceProperty));
		val88.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(42, 26)));
		BindingBase val89 = ((IMarkupExtension<BindingBase>)(object)val17).ProvideValue((IServiceProvider)val88);
		((BindableObject)val21).SetBinding(ImageButton.SourceProperty, val89);
		((BindableObject)val21).SetValue(VisualElement.WidthRequestProperty, (object)40.0);
		((BindableObject)val21).SetValue(VisualElement.HeightRequestProperty, (object)40.0);
		((BindableObject)val21).SetValue(ImageButton.CornerRadiusProperty, (object)20);
		((BindableObject)val21).SetValue(ImageButton.PaddingProperty, (object)new Thickness(8.0));
		val18.Key = "ButtonBackgroundLight";
		StaticResourceExtension val90 = new StaticResourceExtension
		{
			Key = "ButtonBackgroundLight"
		};
		XamlServiceProvider val91 = new XamlServiceProvider();
		Type? typeFromHandle9 = typeof(IProvideValueTarget);
		object[] array9 = new object[0 + 5];
		array9[0] = val20;
		array9[1] = val21;
		array9[2] = val36;
		array9[3] = val50;
		array9[4] = mainPage;
		SimpleValueTargetProvider val92 = new SimpleValueTargetProvider(array9, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Light"), (INameScope[])(object)new NameScope[6] { val51, val51, val51, val51, val51, val51 }, false);
		object obj9 = (object)val92;
		val91.Add(typeFromHandle9, (object)val92);
		val91.Add(typeof(IReferenceProvider), obj9);
		val91.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(47, 26)));
		object light5 = val90.ProvideValue((IServiceProvider)val91);
		val20.Light = light5;
		val19.Key = "ButtonBackgroundDark";
		StaticResourceExtension val93 = new StaticResourceExtension
		{
			Key = "ButtonBackgroundDark"
		};
		XamlServiceProvider val94 = new XamlServiceProvider();
		Type? typeFromHandle10 = typeof(IProvideValueTarget);
		object[] array10 = new object[0 + 5];
		array10[0] = val20;
		array10[1] = val21;
		array10[2] = val36;
		array10[3] = val50;
		array10[4] = mainPage;
		SimpleValueTargetProvider val95 = new SimpleValueTargetProvider(array10, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Dark"), (INameScope[])(object)new NameScope[6] { val51, val51, val51, val51, val51, val51 }, false);
		object obj10 = (object)val95;
		val94.Add(typeFromHandle10, (object)val95);
		val94.Add(typeof(IReferenceProvider), obj10);
		val94.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(47, 26)));
		object dark5 = val93.ProvideValue((IServiceProvider)val94);
		val20.Dark = dark5;
		XamlServiceProvider val96 = new XamlServiceProvider();
		val96.Add(typeof(IProvideValueTarget), (object)new ValueTargetProvider((object)val21, (object)VisualElement.BackgroundColorProperty));
		val96.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(47, 26)));
		BindingBase val97 = ((IMarkupExtension<BindingBase>)(object)val20).ProvideValue((IServiceProvider)val96);
		((BindableObject)val21).SetBinding(VisualElement.BackgroundColorProperty, val97);
		val21.Clicked += mainPage.OnRefreshClicked;
		((BindableObject)val21).SetValue(Element.AutomationIdProperty, (object)"RefreshButton");
		((BindableObject)val21).SetValue(ToolTipProperties.TextProperty, (object)"Refresh Page");
		((Layout)val36).Children.Add((IView)(object)val21);
		((BindableObject)val26).SetValue(Grid.ColumnProperty, (object)3);
		val22.Light = "close_dark.png";
		val22.Dark = "close_light.png";
		XamlServiceProvider val98 = new XamlServiceProvider();
		val98.Add(typeof(IProvideValueTarget), (object)new ValueTargetProvider((object)val26, (object)ImageButton.SourceProperty));
		val98.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(54, 26)));
		BindingBase val99 = ((IMarkupExtension<BindingBase>)(object)val22).ProvideValue((IServiceProvider)val98);
		((BindableObject)val26).SetBinding(ImageButton.SourceProperty, val99);
		((BindableObject)val26).SetValue(VisualElement.WidthRequestProperty, (object)40.0);
		((BindableObject)val26).SetValue(VisualElement.HeightRequestProperty, (object)40.0);
		((BindableObject)val26).SetValue(ImageButton.CornerRadiusProperty, (object)20);
		((BindableObject)val26).SetValue(ImageButton.PaddingProperty, (object)new Thickness(8.0));
		val23.Key = "ButtonBackgroundLight";
		StaticResourceExtension val100 = new StaticResourceExtension
		{
			Key = "ButtonBackgroundLight"
		};
		XamlServiceProvider val101 = new XamlServiceProvider();
		Type? typeFromHandle11 = typeof(IProvideValueTarget);
		object[] array11 = new object[0 + 5];
		array11[0] = val25;
		array11[1] = val26;
		array11[2] = val36;
		array11[3] = val50;
		array11[4] = mainPage;
		SimpleValueTargetProvider val102 = new SimpleValueTargetProvider(array11, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Light"), (INameScope[])(object)new NameScope[6] { val51, val51, val51, val51, val51, val51 }, false);
		object obj11 = (object)val102;
		val101.Add(typeFromHandle11, (object)val102);
		val101.Add(typeof(IReferenceProvider), obj11);
		val101.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(59, 26)));
		object light6 = val100.ProvideValue((IServiceProvider)val101);
		val25.Light = light6;
		val24.Key = "ButtonBackgroundDark";
		StaticResourceExtension val103 = new StaticResourceExtension
		{
			Key = "ButtonBackgroundDark"
		};
		XamlServiceProvider val104 = new XamlServiceProvider();
		Type? typeFromHandle12 = typeof(IProvideValueTarget);
		object[] array12 = new object[0 + 5];
		array12[0] = val25;
		array12[1] = val26;
		array12[2] = val36;
		array12[3] = val50;
		array12[4] = mainPage;
		SimpleValueTargetProvider val105 = new SimpleValueTargetProvider(array12, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Dark"), (INameScope[])(object)new NameScope[6] { val51, val51, val51, val51, val51, val51 }, false);
		object obj12 = (object)val105;
		val104.Add(typeFromHandle12, (object)val105);
		val104.Add(typeof(IReferenceProvider), obj12);
		val104.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(59, 26)));
		object dark6 = val103.ProvideValue((IServiceProvider)val104);
		val25.Dark = dark6;
		XamlServiceProvider val106 = new XamlServiceProvider();
		val106.Add(typeof(IProvideValueTarget), (object)new ValueTargetProvider((object)val26, (object)VisualElement.BackgroundColorProperty));
		val106.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(59, 26)));
		BindingBase val107 = ((IMarkupExtension<BindingBase>)(object)val25).ProvideValue((IServiceProvider)val106);
		((BindableObject)val26).SetBinding(VisualElement.BackgroundColorProperty, val107);
		val26.Clicked += mainPage.OnStopClicked;
		((BindableObject)val26).SetValue(Element.AutomationIdProperty, (object)"StopButton");
		((BindableObject)val26).SetValue(ToolTipProperties.TextProperty, (object)"Stop Loading");
		((Layout)val36).Children.Add((IView)(object)val26);
		((BindableObject)val31).SetValue(Grid.ColumnProperty, (object)4);
		val27.Light = "home_dark.png";
		val27.Dark = "home_light.png";
		XamlServiceProvider val108 = new XamlServiceProvider();
		val108.Add(typeof(IProvideValueTarget), (object)new ValueTargetProvider((object)val31, (object)ImageButton.SourceProperty));
		val108.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(66, 26)));
		BindingBase val109 = ((IMarkupExtension<BindingBase>)(object)val27).ProvideValue((IServiceProvider)val108);
		((BindableObject)val31).SetBinding(ImageButton.SourceProperty, val109);
		((BindableObject)val31).SetValue(VisualElement.WidthRequestProperty, (object)40.0);
		((BindableObject)val31).SetValue(VisualElement.HeightRequestProperty, (object)40.0);
		((BindableObject)val31).SetValue(ImageButton.CornerRadiusProperty, (object)20);
		((BindableObject)val31).SetValue(ImageButton.PaddingProperty, (object)new Thickness(8.0));
		val28.Key = "ButtonBackgroundLight";
		StaticResourceExtension val110 = new StaticResourceExtension
		{
			Key = "ButtonBackgroundLight"
		};
		XamlServiceProvider val111 = new XamlServiceProvider();
		Type? typeFromHandle13 = typeof(IProvideValueTarget);
		object[] array13 = new object[0 + 5];
		array13[0] = val30;
		array13[1] = val31;
		array13[2] = val36;
		array13[3] = val50;
		array13[4] = mainPage;
		SimpleValueTargetProvider val112 = new SimpleValueTargetProvider(array13, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Light"), (INameScope[])(object)new NameScope[6] { val51, val51, val51, val51, val51, val51 }, false);
		object obj13 = (object)val112;
		val111.Add(typeFromHandle13, (object)val112);
		val111.Add(typeof(IReferenceProvider), obj13);
		val111.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(71, 26)));
		object light7 = val110.ProvideValue((IServiceProvider)val111);
		val30.Light = light7;
		val29.Key = "ButtonBackgroundDark";
		StaticResourceExtension val113 = new StaticResourceExtension
		{
			Key = "ButtonBackgroundDark"
		};
		XamlServiceProvider val114 = new XamlServiceProvider();
		Type? typeFromHandle14 = typeof(IProvideValueTarget);
		object[] array14 = new object[0 + 5];
		array14[0] = val30;
		array14[1] = val31;
		array14[2] = val36;
		array14[3] = val50;
		array14[4] = mainPage;
		SimpleValueTargetProvider val115 = new SimpleValueTargetProvider(array14, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Dark"), (INameScope[])(object)new NameScope[6] { val51, val51, val51, val51, val51, val51 }, false);
		object obj14 = (object)val115;
		val114.Add(typeFromHandle14, (object)val115);
		val114.Add(typeof(IReferenceProvider), obj14);
		val114.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(71, 26)));
		object dark7 = val113.ProvideValue((IServiceProvider)val114);
		val30.Dark = dark7;
		XamlServiceProvider val116 = new XamlServiceProvider();
		val116.Add(typeof(IProvideValueTarget), (object)new ValueTargetProvider((object)val31, (object)VisualElement.BackgroundColorProperty));
		val116.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(71, 26)));
		BindingBase val117 = ((IMarkupExtension<BindingBase>)(object)val30).ProvideValue((IServiceProvider)val116);
		((BindableObject)val31).SetBinding(VisualElement.BackgroundColorProperty, val117);
		val31.Clicked += mainPage.OnHomeClicked;
		((BindableObject)val31).SetValue(Element.AutomationIdProperty, (object)"HomeButton");
		((BindableObject)val31).SetValue(ToolTipProperties.TextProperty, (object)"Go Home");
		((Layout)val36).Children.Add((IView)(object)val31);
		((BindableObject)val33).SetValue(Grid.ColumnProperty, (object)5);
		((BindableObject)val33).SetValue(Entry.PlaceholderProperty, (object)"Enter URL or search...");
		val32.Key = "AddressBarStyle";
		StaticResourceExtension val118 = new StaticResourceExtension
		{
			Key = "AddressBarStyle"
		};
		XamlServiceProvider val119 = new XamlServiceProvider();
		Type? typeFromHandle15 = typeof(IProvideValueTarget);
		object[] array15 = new object[0 + 4];
		array15[0] = val33;
		array15[1] = val36;
		array15[2] = val50;
		array15[3] = mainPage;
		SimpleValueTargetProvider val120 = new SimpleValueTargetProvider(array15, (object)VisualElement.StyleProperty, (INameScope[])(object)new NameScope[5] { val51, val51, val51, val51, val51 }, false);
		object obj15 = (object)val120;
		val119.Add(typeFromHandle15, (object)val120);
		val119.Add(typeof(IReferenceProvider), obj15);
		val119.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(80, 20)));
		object obj16 = val118.ProvideValue((IServiceProvider)val119);
		((BindableObject)val33).SetValue(VisualElement.StyleProperty, (obj16 == null || !typeof(BindingBase).IsAssignableFrom(obj16.GetType())) ? obj16 : obj16);
		val33.Completed += mainPage.OnAddressBarCompleted;
		((Layout)val36).Children.Add((IView)(object)val33);
		((BindableObject)val35).SetValue(Grid.ColumnProperty, (object)6);
		((BindableObject)val35).SetValue(Button.TextProperty, (object)"Go");
		val34.Key = "GoButtonStyle";
		StaticResourceExtension val121 = new StaticResourceExtension
		{
			Key = "GoButtonStyle"
		};
		XamlServiceProvider val122 = new XamlServiceProvider();
		Type? typeFromHandle16 = typeof(IProvideValueTarget);
		object[] array16 = new object[0 + 4];
		array16[0] = val35;
		array16[1] = val36;
		array16[2] = val50;
		array16[3] = mainPage;
		SimpleValueTargetProvider val123 = new SimpleValueTargetProvider(array16, (object)VisualElement.StyleProperty, (INameScope[])(object)new NameScope[5] { val51, val51, val51, val51, val51 }, false);
		object obj17 = (object)val123;
		val122.Add(typeFromHandle16, (object)val123);
		val122.Add(typeof(IReferenceProvider), obj17);
		val122.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(86, 21)));
		object obj18 = val121.ProvideValue((IServiceProvider)val122);
		((BindableObject)val35).SetValue(VisualElement.StyleProperty, (obj18 == null || !typeof(BindingBase).IsAssignableFrom(obj18.GetType())) ? obj18 : obj18);
		val35.Clicked += mainPage.OnGoClicked;
		((BindableObject)val35).SetValue(Element.AutomationIdProperty, (object)"GoButton");
		((Layout)val36).Children.Add((IView)(object)val35);
		((Layout)val50).Children.Add((IView)(object)val36);
		((BindableObject)val40).SetValue(Grid.RowProperty, (object)1);
		((BindableObject)val40).SetValue(ProgressBar.ProgressProperty, (object)0.0);
		val37.Key = "PrimaryColor";
		StaticResourceExtension val124 = new StaticResourceExtension
		{
			Key = "PrimaryColor"
		};
		XamlServiceProvider val125 = new XamlServiceProvider();
		Type? typeFromHandle17 = typeof(IProvideValueTarget);
		object[] array17 = new object[0 + 4];
		array17[0] = val39;
		array17[1] = val40;
		array17[2] = val50;
		array17[3] = mainPage;
		SimpleValueTargetProvider val126 = new SimpleValueTargetProvider(array17, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Light"), (INameScope[])(object)new NameScope[5] { val51, val51, val51, val51, val51 }, false);
		object obj19 = (object)val126;
		val125.Add(typeFromHandle17, (object)val126);
		val125.Add(typeof(IReferenceProvider), obj19);
		val125.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(95, 22)));
		object light8 = val124.ProvideValue((IServiceProvider)val125);
		val39.Light = light8;
		val38.Key = "PrimaryDarkColor";
		StaticResourceExtension val127 = new StaticResourceExtension
		{
			Key = "PrimaryDarkColor"
		};
		XamlServiceProvider val128 = new XamlServiceProvider();
		Type? typeFromHandle18 = typeof(IProvideValueTarget);
		object[] array18 = new object[0 + 4];
		array18[0] = val39;
		array18[1] = val40;
		array18[2] = val50;
		array18[3] = mainPage;
		SimpleValueTargetProvider val129 = new SimpleValueTargetProvider(array18, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Dark"), (INameScope[])(object)new NameScope[5] { val51, val51, val51, val51, val51 }, false);
		object obj20 = (object)val129;
		val128.Add(typeFromHandle18, (object)val129);
		val128.Add(typeof(IReferenceProvider), obj20);
		val128.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(95, 22)));
		object dark8 = val127.ProvideValue((IServiceProvider)val128);
		val39.Dark = dark8;
		XamlServiceProvider val130 = new XamlServiceProvider();
		val130.Add(typeof(IProvideValueTarget), (object)new ValueTargetProvider((object)val40, (object)ProgressBar.ProgressColorProperty));
		val130.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(95, 22)));
		BindingBase val131 = ((IMarkupExtension<BindingBase>)(object)val39).ProvideValue((IServiceProvider)val130);
		((BindableObject)val40).SetBinding(ProgressBar.ProgressColorProperty, val131);
		((BindableObject)val40).SetValue(VisualElement.HeightRequestProperty, (object)3.0);
		((BindableObject)val40).SetValue(VisualElement.IsVisibleProperty, ((TypeConverter)new VisibilityConverter()).ConvertFromInvariantString("False"));
		((Layout)val50).Children.Add((IView)(object)val40);
		((BindableObject)val41).SetValue(Grid.RowProperty, (object)2);
		((BindableObject)val41).SetValue(WebView.SourceProperty, ((TypeConverter)new WebViewSourceTypeConverter()).ConvertFromInvariantString("https://openmaui.net"));
		val41.Navigating += mainPage.OnWebViewNavigating;
		val41.Navigated += mainPage.OnWebViewNavigated;
		((Layout)val50).Children.Add((IView)(object)val41);
		((BindableObject)val49).SetValue(Grid.RowProperty, (object)3);
		((BindableObject)val49).SetValue(Layout.PaddingProperty, (object)new Thickness(8.0, 4.0));
		((BindableObject)val49).SetValue(Grid.ColumnDefinitionsProperty, (object)new ColumnDefinitionCollection((ColumnDefinition[])(object)new ColumnDefinition[2]
		{
			new ColumnDefinition(GridLength.Star),
			new ColumnDefinition(GridLength.Auto)
		}));
		val42.Key = "StatusBackgroundLight";
		StaticResourceExtension val132 = new StaticResourceExtension
		{
			Key = "StatusBackgroundLight"
		};
		XamlServiceProvider val133 = new XamlServiceProvider();
		Type? typeFromHandle19 = typeof(IProvideValueTarget);
		object[] array19 = new object[0 + 4];
		array19[0] = val44;
		array19[1] = val49;
		array19[2] = val50;
		array19[3] = mainPage;
		SimpleValueTargetProvider val134 = new SimpleValueTargetProvider(array19, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Light"), (INameScope[])(object)new NameScope[5] { val51, val51, val51, val51, val51 }, false);
		object obj21 = (object)val134;
		val133.Add(typeFromHandle19, (object)val134);
		val133.Add(typeof(IReferenceProvider), obj21);
		val133.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(110, 15)));
		object light9 = val132.ProvideValue((IServiceProvider)val133);
		val44.Light = light9;
		val43.Key = "StatusBackgroundDark";
		StaticResourceExtension val135 = new StaticResourceExtension
		{
			Key = "StatusBackgroundDark"
		};
		XamlServiceProvider val136 = new XamlServiceProvider();
		Type? typeFromHandle20 = typeof(IProvideValueTarget);
		object[] array20 = new object[0 + 4];
		array20[0] = val44;
		array20[1] = val49;
		array20[2] = val50;
		array20[3] = mainPage;
		SimpleValueTargetProvider val137 = new SimpleValueTargetProvider(array20, (object)typeof(AppThemeBindingExtension).GetRuntimeProperty("Dark"), (INameScope[])(object)new NameScope[5] { val51, val51, val51, val51, val51 }, false);
		object obj22 = (object)val137;
		val136.Add(typeFromHandle20, (object)val137);
		val136.Add(typeof(IReferenceProvider), obj22);
		val136.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(110, 15)));
		object dark9 = val135.ProvideValue((IServiceProvider)val136);
		val44.Dark = dark9;
		XamlServiceProvider val138 = new XamlServiceProvider();
		val138.Add(typeof(IProvideValueTarget), (object)new ValueTargetProvider((object)val49, (object)VisualElement.BackgroundColorProperty));
		val138.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(110, 15)));
		BindingBase val139 = ((IMarkupExtension<BindingBase>)(object)val44).ProvideValue((IServiceProvider)val138);
		((BindableObject)val49).SetBinding(VisualElement.BackgroundColorProperty, val139);
		((BindableObject)val46).SetValue(Grid.ColumnProperty, (object)0);
		((BindableObject)val46).SetValue(Label.TextProperty, (object)"Ready");
		val45.Key = "StatusLabelStyle";
		StaticResourceExtension val140 = new StaticResourceExtension
		{
			Key = "StatusLabelStyle"
		};
		XamlServiceProvider val141 = new XamlServiceProvider();
		Type? typeFromHandle21 = typeof(IProvideValueTarget);
		object[] array21 = new object[0 + 4];
		array21[0] = val46;
		array21[1] = val49;
		array21[2] = val50;
		array21[3] = mainPage;
		SimpleValueTargetProvider val142 = new SimpleValueTargetProvider(array21, (object)VisualElement.StyleProperty, (INameScope[])(object)new NameScope[5] { val51, val51, val51, val51, val51 }, false);
		object obj23 = (object)val142;
		val141.Add(typeFromHandle21, (object)val142);
		val141.Add(typeof(IReferenceProvider), obj23);
		val141.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(115, 20)));
		object obj24 = val140.ProvideValue((IServiceProvider)val141);
		((BindableObject)val46).SetValue(VisualElement.StyleProperty, (obj24 == null || !typeof(BindingBase).IsAssignableFrom(obj24.GetType())) ? obj24 : obj24);
		((Layout)val49).Children.Add((IView)(object)val46);
		((BindableObject)val48).SetValue(Grid.ColumnProperty, (object)1);
		val47.Light = "moon_dark.png";
		val47.Dark = "sun_light.png";
		XamlServiceProvider val143 = new XamlServiceProvider();
		val143.Add(typeof(IProvideValueTarget), (object)new ValueTargetProvider((object)val48, (object)ImageButton.SourceProperty));
		val143.Add(typeof(IXmlLineInfoProvider), (object)new XmlLineInfoProvider((IXmlLineInfo)new XmlLineInfo(120, 26)));
		BindingBase val144 = ((IMarkupExtension<BindingBase>)(object)val47).ProvideValue((IServiceProvider)val143);
		((BindableObject)val48).SetBinding(ImageButton.SourceProperty, val144);
		((BindableObject)val48).SetValue(VisualElement.WidthRequestProperty, (object)32.0);
		((BindableObject)val48).SetValue(VisualElement.HeightRequestProperty, (object)24.0);
		((BindableObject)val48).SetValue(ImageButton.CornerRadiusProperty, (object)4);
		((BindableObject)val48).SetValue(ImageButton.PaddingProperty, (object)new Thickness(4.0));
		((BindableObject)val48).SetValue(VisualElement.BackgroundColorProperty, (object)Colors.Transparent);
		val48.Clicked += mainPage.OnThemeToggleClicked;
		((BindableObject)val48).SetValue(ToolTipProperties.TextProperty, (object)"Toggle Light/Dark Theme");
		((Layout)val49).Children.Add((IView)(object)val48);
		((Layout)val50).Children.Add((IView)(object)val49);
		((BindableObject)mainPage).SetValue(ContentPage.ContentProperty, (object)val50);
	}
}
