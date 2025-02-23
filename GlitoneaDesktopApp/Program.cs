namespace GlitoneaDesktopApp;

using System;
using Avalonia;
using Glitonea;

internal static class Program
{
    [STAThread]
    public static void Main(string[] args)
        => BuildAvaloniaApp()
            .StartWithClassicDesktopLifetime(args);

    public static AppBuilder BuildAvaloniaApp()
        => AppBuilder.Configure<App>()
            .UseGlitoneaFramework()
            .UsePlatformDetect()
            .WithInterFont()
            .LogToTrace();
}