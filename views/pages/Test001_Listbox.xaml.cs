using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace dotnetCoreAvaloniaDemo.views.pages{
    public class Test001_ListBox: UserControl{

        public Test001_ListBox(){
            AvaloniaXamlLoader.Load(this);
            // inside controls wpf always had problems with setting <UserControl.DataContext models:Test001_ListBox /> so for now do it like this
            this.DataContext = new Models.Test001_ListBox();

            var model = this.DataContext as Models.Test001_ListBox;
            model.Message = "Hello World from MVVM!!";
        }

    }
}
