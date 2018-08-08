using DevExpress.Mvvm;
using DevExpress.Mvvm.ModuleInjection;
using System.Windows.Input;

namespace DialogTest
{
    public class MainWindowViewModel : ViewModelBase
    {
        public MainWindowViewModel()
        {
            ShowDialogCommand = new DelegateCommand(OnShowDialog);
        }

        public ICommand ShowDialogCommand { get; set; }

        public async void OnShowDialog()
        {
            var injectionResult = await ModuleManager.DefaultWindowManager.RegisterOrShowOrActivate("DialogView",
                                           new Module("MyDialogView", () => new MyDialogViewModel(), typeof(MyDialogView)));
            System.Diagnostics.Debug.WriteLine(injectionResult.Result);
        }
    }
}
