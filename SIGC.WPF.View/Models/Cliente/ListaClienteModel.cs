using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using SIGC.Data;


namespace SIGC.WPF.View.Models.Cliente
{
    public class ListaClienteModel
    {
        public static DataTable GetClienteDataTable()
        {
            try
            {
                DataSet DataSetCliente = FCliente.GetAll();
                if (DataSetCliente.Tables[0].Rows.Count > 0)
                {
                    return DataSetCliente.Tables[0];
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
