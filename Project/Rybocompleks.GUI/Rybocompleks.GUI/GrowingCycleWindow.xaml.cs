﻿using Rybocompleks.Dispatcher;
using System;
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

namespace Rybocompleks.GUI
{
    /// <summary>
    /// Логика взаимодействия для GrowingCycleWindow.xaml
    /// </summary>
    public partial class GrowingCycleWindow : Window
    {
        private IDispatcher GrowingDispatcher;
        public GrowingCycleWindow(IDispatcher dispatcher)
        {
            InitializeComponent();
            GrowingDispatcher = dispatcher;
        }
    }
}
