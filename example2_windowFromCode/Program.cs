using System;
using Avalonia;
using Avalonia.Logging.Serilog;

namespace example2_windowFromCode
{
    class Program
    {
        static void Main(string[] args)
        {
            var app = AppBuilder.Configure<App>()
                .LogToDebug(Avalonia.Logging.LogEventLevel.Verbose)
                .UsePlatformDetect()
                .SetupWithoutStarting()
                .Instance;
                

            var win = new Avalonia.Controls.Window();
            var tb = new Avalonia.Controls.TextBlock
            {
                Text = "Hello World!"
            };
            win.Content = tb;
            win.Show();
            app.Run(win);
        }
    }
}
