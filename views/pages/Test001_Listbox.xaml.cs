using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;

namespace dotnetCoreAvaloniaDemo.views.pages{
    public class Test001_Listbox: UserControl{

        public Test001_Listbox(){
            AvaloniaXamlLoader.Load(this);
            // inside controls wpf always had problems with setting <UserControl.DataContext models:Test001_ListBox /> so for now do it like this
            this.DataContext = new Models.Test001_Listbox();

            var model = this.DataContext as Models.Test001_Listbox;
            model.Message = "Hello World from MVVM!!";

            var addMessageButton = this.FindControl<Button>("addMessageButton");
            addMessageButton.Click += AddMessageButton_Clicked;
        }

        private void AddMessageButton_Clicked(object sender, RoutedEventArgs args ){
            var model = this.DataContext as Models.Test001_Listbox;

            model.Items.Add(model.Message);
        }

    }
}
