using ViewModelBase;

namespace dotnetCoreAvaloniaDemo.Models
{
    class Main : ViewModelBase.ViewModelBase{

        public string Message {
            get { return this.GetValue(() => this.Message); }
            set { this.SetValue(() => this.Message, value);}
        }
    }    
}