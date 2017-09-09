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

            var model = this.DataContext as Models.Main;
            model.Message = "Hello World from MVVM!!";
        }
    }
}