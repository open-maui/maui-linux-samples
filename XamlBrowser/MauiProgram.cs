using Microsoft.Maui.Controls.Hosting;
using Microsoft.Maui.Hosting;
using Microsoft.Maui.Platform.Linux;
using Microsoft.Maui.Platform.Linux.Hosting;

namespace XamlBrowser;

public static class MauiProgram
{
	public static void Main(string[] args)
	{
		MauiAppBuilder obj = MauiApp.CreateBuilder(true);
		AppHostBuilderExtensions.UseMauiApp<BrowserApp>(obj).UseLinux();
		LinuxApplication.Run(obj.Build(), args, delegate(LinuxApplicationOptions options)
		{
			options.Title = "XAML Browser";
			options.Width = 1200;
			options.Height = 800;
			options.UseGtk = true;
		});
	}
}
