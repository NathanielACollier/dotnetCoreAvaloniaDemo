using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace example1_textOnWindow{
    class MainWindow : Window
    {
        public MainWindow()
        {
            AvaloniaXamlLoader.Load(this);
            this.AttachDevTools();
        }
    }
}