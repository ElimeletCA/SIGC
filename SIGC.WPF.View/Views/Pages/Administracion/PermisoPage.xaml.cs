﻿using SIGC.WPF.View.ViewModels.Pages.Administracion;
using SIGC.WPF.View.ViewModels.Pages.Extra;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Wpf.Ui.Controls;

namespace SIGC.WPF.View.Views.Pages.Administracion
{
    /// <summary>
    /// Interaction logic for PermisoPage.xaml
    /// </summary>
    public partial class PermisoPage : INavigableView<PermisoViewModel>
    {
        public PermisoViewModel ViewModel { get; }

        public PermisoPage(PermisoViewModel viewModel)
        {
            ViewModel = viewModel;
            DataContext = this;
            InitializeComponent();
        }

    }
}
