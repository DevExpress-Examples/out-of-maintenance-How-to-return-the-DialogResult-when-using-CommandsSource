Imports DevExpress.Mvvm
Imports DevExpress.Mvvm.ModuleInjection
Imports System.Windows.Input

Namespace DialogTest
    Public Class MainWindowViewModel
        Inherits ViewModelBase

        Public Sub New()
            ShowDialogCommand = New DelegateCommand(AddressOf OnShowDialog)
        End Sub

        Public Property ShowDialogCommand() As ICommand

        Public Async Sub OnShowDialog()
            Dim injectionResult = Await ModuleManager.DefaultWindowManager.RegisterOrShowOrActivate("DialogView", New System.Reflection.Module("MyDialogView", Function() New MyDialogViewModel(), GetType(MyDialogView)))
            System.Diagnostics.Debug.WriteLine(injectionResult.Result)
        End Sub
    End Class
End Namespace
