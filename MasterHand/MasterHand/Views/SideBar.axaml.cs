using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace MasterHand.Views;

using System;

public partial class SideBar : UserControl
{
    public SideBar()
    {
        InitializeComponent();
    }

    private void ChangePage(object sender, SelectionChangedEventArgs e)
    {
        var listBox = sender as ListBox;
        var selectedItem = listBox?.SelectedItem as ListBoxItem;
        if (selectedItem?.Content != null)
        {
            switch (selectedItem.Content)
            {
                case "Home":
                    Console.WriteLine("Home");
                    break;
                case "Characters":
                    Console.WriteLine("Characters");
                    break;
                case "Stages":
                    Console.WriteLine("Stages");
                    break;
                case "Settings":
                    Console.WriteLine("Settings");
                    break;
            }
        }
    }
}