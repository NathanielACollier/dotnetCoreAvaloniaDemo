using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace dotnetCoreAvaloniaDemo.views{
    public class Main: UserControl{

        public Main(){
            AvaloniaXamlLoader.Load(this);
        }

    }
}
