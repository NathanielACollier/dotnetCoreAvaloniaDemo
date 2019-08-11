using System;
using Avalonia;

namespace example2_windowFromCode
{
    class Program
    {
        static void Main(string[] args)
        {
            var app = new Application();
            AppBuilder.Configure(app)
                .UsePlatformDetect()
                .SetupWithoutStarting();

            var win = new Avalonia.Controls.Window();
            var tb = new Avalonia.Controls.TextBlock
            {
                Text = "Hello World!"
            };
            win.Content = tb;
            app.Run(win);
        }
    }
}
