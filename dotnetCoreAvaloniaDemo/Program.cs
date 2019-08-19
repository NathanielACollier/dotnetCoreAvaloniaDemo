using System;
using Avalonia;
using Avalonia.Logging.Serilog;

namespace dotnetCoreAvaloniaDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            AppBuilder.Configure<App>()
                //.LogToDebug(Avalonia.Logging.LogEventLevel.Verbose)
                .UsePlatformDetect()
                .Start<MainWindow>();
        }
    }
}
