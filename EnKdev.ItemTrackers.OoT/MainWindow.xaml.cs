using System;
using System.Windows;
using System.Windows.Input;

namespace EnKdev.ItemTrackers.OoT;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void MainWindow_OnMouseDown(object sender, MouseButtonEventArgs e)
    {
        if (e.ChangedButton == MouseButton.Left)
        {
            DragMove();
        }
    }

    private void MainWindow_OnDeactivated(object? sender, EventArgs e)
    {
        var window = (Window)sender!;
        window.Topmost = true;
    }
}