using DevExpress.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DialogTest
{
    public interface IDialogViewModel
    {
        int DialogWidth { get; set; }
        int DialogHeight { get; set; }
        string DialogTitle { get; set; }
        IEnumerable<UICommand> CommandsSource { get; set; }
    }

    public class MyDialogViewModel : IDialogViewModel
    {
        public MyDialogViewModel()
        {
            DialogTitle = "Print dialog";
            DialogWidth = 640;
            DialogHeight = 480;
            CommandsSource = new List<UICommand>
            {
                new UICommand
                {
                    Id = System.Windows.MessageBoxResult.Cancel,
                    Caption = "Cancel",
                    IsCancel = true,
                    Tag =  System.Windows.MessageBoxResult.Cancel

                },
                new UICommand
                {
                    Caption = "Print",
                    IsDefault = true,
                    Command = new DelegateCommand(Print),
                    Tag = System.Windows.MessageBoxResult.OK
                }
            };
        }

        #region IDialogViewModel
        public int DialogWidth { get; set; }
        public int DialogHeight { get; set; }
        public string DialogTitle { get; set; }
        public IEnumerable<UICommand> CommandsSource { get; set; }
        #endregion IDialogViewModel

        private void Print()
        {

        }

    }
}
