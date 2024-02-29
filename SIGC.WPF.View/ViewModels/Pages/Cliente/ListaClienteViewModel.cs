
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIGC.WPF.View.Views.Pages.Cliente;
using SIGC.Data;


namespace SIGC.WPF.View.ViewModels.Pages.Cliente
{
    public partial class ListaClienteViewModel : ObservableObject
    {
        
        private static DataTable _datatablecliente = new DataTable();
        
        public static DataTable GetClienteDataTable()
        {
            try
            {
                DataSet DataSetCliente = FCliente.GetAll();
                _datatablecliente = DataSetCliente.Tables[0];
                if (_datatablecliente.Rows.Count > 0)
                {
                    return _datatablecliente;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
    }
}