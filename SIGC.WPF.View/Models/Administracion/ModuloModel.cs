using SIGC.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIGC.WPF.View.Models.Administracion
{
    public class ModuloModel
    {
        public static DataTable GetModuloDataTable()
        {
            DataTable emptyDataTable = new DataTable();

            try
            {
                DataSet DataSetModulo = FModulo.GetAll();
                if (DataSetModulo.Tables[0].Rows.Count > 0)
                {
                    return DataSetModulo.Tables[0];
                }
            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show(ex.Message);
            }
            return emptyDataTable;
        }
        public static string InsertarActualizarModulo(SIGC.Model.Modulo modulo)
        {
            try
            {
                if (modulo.Id_modulo == 0)
                {
                    if (FModulo.Insertar(modulo) > 0)
                    {
                        return "éxito en el guardado";
                    }
                    else
                    {
                        return "un error en el guardado";
                    }
                }
                else if (modulo.Id_modulo > 0)
                {
                    if (FModulo.Actualizar(modulo) > 0)
                    {
                        return "éxito en la modificación";
                    }
                    else
                    {
                        return "un error en la modificación";
                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);

            }
            return "un error al realizar la operación";


        }

        public static string EliminarModulo(SIGC.Model.Modulo modulo)
        {
            try
            {
                if (modulo.Id_modulo > 0)
                {
                    if (FModulo.Eliminar(modulo) > 0)
                    {
                        return "éxito en la eliminación";
                    }
                    else
                    {
                        return "un error en la eliminación";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
            return "un error al realizar la operación";


        }

    }
}
