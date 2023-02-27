using RDA.Task._3.Core;
using RDA.Task._3.View.Pages;
using System;
using System.Windows;
using System.Windows.Controls;

namespace RDA.Task._3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            CoreNavigate.MyConnection = MainFrame;
            MainFrame.Navigate(new MainPage());
        }
    }
}
