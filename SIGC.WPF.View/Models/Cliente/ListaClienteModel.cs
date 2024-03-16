using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using SIGC.Model;
using SIGC.Data;
using MessageBox = System.Windows.MessageBox;


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
                System.Windows.MessageBox.Show(ex.Message);
                return null;

            }
        }
        public static void InsertarActualizarCliente(SIGC.Model.Cliente cliente)
        {
            try
            {
                if (!(cliente.Id_cliente >= 0))
                {
                    if (FCliente.Insertar(cliente) > 0)
                    {
                        MessageBox.Show("Cliente guardado con éxito");
                    }
                    else
                    {
                        MessageBox.Show("Error al guardar el cliente");
                    }
                }
                else
                {
                    if (FCliente.Actualizar(cliente) > 0)
                    {
                        MessageBox.Show("Cliente modificado con éxito");
                    }
                    else
                    {
                        MessageBox.Show("Error al modificar el cliente");
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }

        }
        public static void EliminarCliente(SIGC.Model.Cliente cliente)
        {
            try
            {
                if (cliente.Id_cliente >= 0)
                {
                    if (FCliente.Eliminar(cliente) > 0)
                    {
                        MessageBox.Show("Cliente eliminado con éxito");
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar el cliente");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }

        }

    }
}
