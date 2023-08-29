using Avalonia.Controls;

namespace MasterHand.Views;

using System;
using Avalonia.Interactivity;

public partial class MainView : UserControl
{
    public MainView()
    {
        InitializeComponent();
    }

    private void Button_OnClick(object? sender, RoutedEventArgs e)
    {
        Console.WriteLine("Hi I clicked a button!");
    }
}