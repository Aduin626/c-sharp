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
using System.Windows.Shapes;

namespace ПрактикумWPF2
{
    /// <summary>
    /// Логика взаимодействия для UniformGrid.xaml
    /// </summary>
    public partial class UniformGrid : Window
    {
        public UniformGrid()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            canvas canvas = new canvas();
            canvas.Show();
        }
    }
}
