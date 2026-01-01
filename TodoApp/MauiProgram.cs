using Microsoft.Maui.Controls.Hosting;
using Microsoft.Maui.Hosting;
using Microsoft.Maui.Platform.Linux.Hosting;

namespace TodoApp;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		MauiAppBuilder obj = MauiApp.CreateBuilder(true);
		AppHostBuilderExtensions.UseMauiApp<App>(obj);
		obj.UseLinux();
		return obj.Build();
	}
}
