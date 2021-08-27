<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/143999799/17.2.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T830547)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
# How to return the DialogResult when using CommandsSource

This code example describes how to return the [DialogResult](https://docs.microsoft.com/dotnet/api/system.windows.forms.dialogresult) when using [CommandsSource](https://documentation.devexpress.com/WPF/DevExpress.Xpf.Core.DXDialogWindow.CommandsSource.property) in [DXDialogWindow](https://documentation.devexpress.com/WPF/DevExpress.Xpf.Core.DXDialogWindow.class).

The [DXDialogWindow](https://documentation.devexpress.com/WPF/DevExpress.Xpf.Core.DXDialogWindow.class) allows you to set custom dialog buttons. Pass a [UICommand](https://documentation.devexpress.com/CoreLibraries/DevExpress.Mvvm.UICommand.class) objects collection to the [DXDialogWindow.CommandsSource](https://documentation.devexpress.com/WPF/DevExpress.Xpf.Core.DXDialogWindow.CommandsSource.property) property to add a custom button to **DXDialogWindow**. Set the button's [UICommand.Tag](https://documentation.devexpress.com/CoreLibraries/DevExpress.Mvvm.UICommand.Tag.property) property to a [MessageBoxResult Enum](https://docs.microsoft.com/dotnet/api/system.windows.messageboxresult)'s value to set a [Dialog Result](https://docs.microsoft.com/dotnet/api/system.windows.forms.dialogresult) for the custom button. 
