
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIGC.Data;
using SIGC.WPF.View.Models.Cliente;


namespace SIGC.WPF.View.ViewModels.Pages.Cliente
{
    public partial class ListaClienteViewModel : ObservableObject
    {
        [ObservableProperty]
        private static DataView _datatablecliente = new DataView();

        public ListaClienteViewModel()
        {
            // Inicializa la propiedad ListaClientes con los datos deseados
            Datatablecliente = ListaClienteModel.GetClienteDataTable().DefaultView;
        }

    }
}