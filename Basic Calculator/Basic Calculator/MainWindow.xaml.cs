﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Basic_Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void One_click(object sender, RoutedEventArgs e)
        {
            number_box.Text += '1';
        }

        private void Zero_click(object sender, RoutedEventArgs e)
        {
            number_box.Text += '0';
        }

        private void Two_click(object sender, RoutedEventArgs e)
        {
            number_box.Text += '2';
        }

        private void Three_click(object sender, RoutedEventArgs e)
        {
            number_box.Text += '3';
        }

        private void Four_click(object sender, RoutedEventArgs e)
        {
            number_box.Text += '4';
        }

        private void Five_click(object sender, RoutedEventArgs e)
        {
            number_box.Text += '5';
        }

        private void Six_click(object sender, RoutedEventArgs e)
        {
            number_box.Text += '6';
        }

        private void Seven_click(object sender, RoutedEventArgs e)
        {
            number_box.Text += '7';
        }

        private void Eight_click(object sender, RoutedEventArgs e)
        {
            number_box.Text += '8';
        }

        private void Nine_click(object sender, RoutedEventArgs e)
        {
            number_box.Text += '9';
        }

        private void Minus_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Divide_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
