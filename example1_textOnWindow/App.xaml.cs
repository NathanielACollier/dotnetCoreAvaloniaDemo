using Avalonia;
using Avalonia.Markup.Xaml;

namespace example1_textOnWindow
{
    class App : Application
    {
        public override void Initialize()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}