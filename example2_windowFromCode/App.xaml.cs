using Avalonia;
using Avalonia.Markup.Xaml;

namespace example2_windowFromCode
{
    class App : Application
    {
        public override void Initialize()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}