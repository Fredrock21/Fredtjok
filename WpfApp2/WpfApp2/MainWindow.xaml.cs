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

namespace WpfApp2
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

        private void ett_Click(object sender, RoutedEventArgs e)
        {
            if(e.Source is Button button)
            {

                numerblock.Text += "1";
            }



        }

       

        private void twå_Click(object sender, RoutedEventArgs e)
        {
            if (e.Source is Button button)
            {

                numerblock.Text += "2";
            }

        }

        private void tre_Click(object sender, RoutedEventArgs e)
        {
            if (e.Source is Button button)
            {

                numerblock.Text += "3";
            }
        }

        private void fyra_Click(object sender, RoutedEventArgs e)
        {
            if (e.Source is Button button)
            {

                numerblock.Text += "4";
            }
        }

        private void fem_Click(object sender, RoutedEventArgs e)
        {
            if (e.Source is Button button)
            {

                numerblock.Text += "5";
            }

        }

        private void sex_Click(object sender, RoutedEventArgs e)
        {
            if (e.Source is Button button)
            {

                numerblock.Text += "6";
            }
        }

        private void sju_Click(object sender, RoutedEventArgs e)
        {
            if (e.Source is Button button)
            {

                numerblock.Text += "7";
            }

        }

        private void åtta_Click(object sender, RoutedEventArgs e)
        {
            if (e.Source is Button button)
            {

                numerblock.Text += "8";
            }

        } 
        private void nio_Click(object sender, RoutedEventArgs e)
        {
            if (e.Source is Button button)
            {

                numerblock.Text += "9";
            }

        }

        private void add_Click(object sender, RoutedEventArgs e)
        {

        }

        private void subtract_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
