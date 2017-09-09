using System.Collections.ObjectModel;
using ViewModelBase;

namespace dotnetCoreAvaloniaDemo.Models
{
    public class Test001_Listbox : ViewModelBase.ViewModelBase{

        public string Message {
            get { return this.GetValue(() => this.Message); }
            set { this.SetValue(() => this.Message, value);}
        }

        public ObservableCollection<string> Items {
            get { return this.GetValue(() => this.Items);}
        }
    }    
}