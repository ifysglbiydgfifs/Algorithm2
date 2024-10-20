﻿using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using Tower_of_Hanoi.Pages;

namespace Tower_of_Hanoi
{
    /// <summary>
    /// Interaction logic for Start.xaml
    /// </summary>
    public partial class Start : Page
    {
        public Start()
        {
            InitializeComponent();
        }

        private void GenerateButton_Click(object sender, RoutedEventArgs e)
        {
            if (!int.TryParse(DisksCountTextBox.Text, out int height) || height < 1)
            {
                _ = MessageBox.Show(Window.GetWindow(this), "Height of Tower is invalid!", "",
                    MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            Generating.TowerHeight = height;
            Generating.TowerIsExtended = (bool)ExtendedRadio.IsChecked;
            _ = NavigationService.Navigate(new Uri("/Pages/Generating.xaml", UriKind.Relative));
        }
        
        private void GenerateFractalButton_Click(object sender, RoutedEventArgs e)
        {
            Fractal fractalPage = new Fractal();
            NavigationService?.Navigate(fractalPage);

        }

        private void DisksCountTextBox_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (e.Key == System.Windows.Input.Key.Enter)
            {
                GenerateButton.RaiseEvent(new RoutedEventArgs(ButtonBase.ClickEvent, GenerateButton));
            }
        }
    }
}