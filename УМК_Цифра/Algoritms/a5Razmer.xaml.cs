﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace УМК_Цифра.Algoritms
{
    /// <summary>
    /// Логика взаимодействия для aRazmer.xaml
    /// </summary>
    public partial class a5Razmer : Page
    {
        public a5Razmer()
        {
            InitializeComponent();
        }
        private void Start(object sender, RoutedEventArgs e)
        {
            Process.Start("main4.exe");
        }
        private void Button_Click_COLAB(object sender, RoutedEventArgs e)
        {
            Process.Start("https://colab.research.google.com/drive/1Ndd1s0lNQqUfpSBpF0SYX9vT-YEvkHXG?usp=sharing");
        }
    }
}
