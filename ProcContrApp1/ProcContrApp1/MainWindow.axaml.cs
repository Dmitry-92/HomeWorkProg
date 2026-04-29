using System;
using System.Diagnostics;
using System.Linq;
using Avalonia.Controls;
using Avalonia.Interactivity;

namespace ProcContrApp1;

public partial class MainWindow : Window
{
    private Process? _targetProcess;
    private const string TargetProcessName = "TargContpp";

    public MainWindow()
    {
        InitializeComponent();
    }

    private async void StartButtonOnClick(object sender, RoutedEventArgs e)
    {
        try
        {
            // Получаем путь к запускаемому файлу TargContpp
        }
    }
}
