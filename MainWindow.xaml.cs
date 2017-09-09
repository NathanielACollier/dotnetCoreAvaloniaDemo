using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace dotnetCoreAvaloniaDemo{
    class MainWindow : Window
    {
        public MainWindow()
        {
            AvaloniaXamlLoader.Load(this);
            this.AttachDevTools();
        }
    }
}