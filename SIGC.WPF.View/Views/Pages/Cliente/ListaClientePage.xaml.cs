using SIGC.WPF.View.ViewModels.Pages.Cliente;
using System;
using System.Collections.Generic;
using System.Data;
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
using MessageBox = System.Windows.MessageBox;

namespace SIGC.WPF.View.Views.Pages.Cliente
{
    /// <summary>
    /// Interaction logic for ListaClientePage.xaml
    /// </summary>
    public partial class ListaClientePage : INavigableView<ListaClienteViewModel>
    {
        public ListaClienteViewModel ViewModel { get; }

        public ListaClientePage(ListaClienteViewModel viewModel)
        {
            ViewModel = viewModel;
            DataContext = this;

            InitializeComponent(); 
        }

    }
}
