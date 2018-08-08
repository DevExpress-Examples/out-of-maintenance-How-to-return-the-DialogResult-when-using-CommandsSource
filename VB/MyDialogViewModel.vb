Imports DevExpress.Mvvm
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace DialogTest
    Public Interface IDialogViewModel
        Property DialogWidth() As Integer
        Property DialogHeight() As Integer
        Property DialogTitle() As String
        Property CommandsSource() As IEnumerable(Of UICommand)
    End Interface

    Public Class MyDialogViewModel
        Implements IDialogViewModel

        Public Sub New()
            DialogTitle = "Print dialog"
            DialogWidth = 640
            DialogHeight = 480
            CommandsSource = New List(Of UICommand) From { _
                New UICommand With { _
                    .Id = System.Windows.MessageBoxResult.Cancel, _
                    .Caption = "Cancel", _
                    .IsCancel = True, _
                    .Tag = System.Windows.MessageBoxResult.Cancel _
                }, _
                New UICommand With { _
                    .Caption = "Print", _
                    .IsDefault = True, _
                    .Command = New DelegateCommand(AddressOf Print), _
                    .Tag = System.Windows.MessageBoxResult.OK _
                } _
            }
        End Sub

        #Region "IDialogViewModel"
        Public Property DialogWidth() As Integer Implements IDialogViewModel.DialogWidth
        Public Property DialogHeight() As Integer Implements IDialogViewModel.DialogHeight
        Public Property DialogTitle() As String Implements IDialogViewModel.DialogTitle
        Public Property CommandsSource() As IEnumerable(Of UICommand) Implements IDialogViewModel.CommandsSource
        #End Region ' IDialogViewModel

        Private Sub Print()

        End Sub

    End Class
End Namespace
