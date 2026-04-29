using System;
using Avalonia.Controls;
using Avalonia.Interactivity;

namespace TargContpp;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    public void ShowTimeButtonOnClick(object sender, RoutedEventArgs e)
    {
        var timeText = this.FindControl<TextBlock>("TimeText");
        if (timeText != null)
        {
            timeText.Text = DateTime.Now.ToString("HH:mm:ss");
        }
    }
}