using SIGC.WPF.View.ViewModels.Pages.Cliente;
using Wpf.Ui.Controls;

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

        private void Page_Initialized(object sender, EventArgs e)
        {
        }
    }


}
