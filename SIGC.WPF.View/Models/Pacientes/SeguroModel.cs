using SIGC.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIGC.WPF.View.Models.Pacientes
{
    public class SeguroModel
    {
        public static DataTable GetSeguroDataTable()
        {
            DataTable emptyDataTable = new DataTable();

            try
            {
                DataSet DataSetSeguro = FSeguro.GetAll();
                if (DataSetSeguro.Tables[0].Rows.Count > 0)
                {
                    return DataSetSeguro.Tables[0];
                }
            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show(ex.Message);
            }
            return emptyDataTable;
        }
        public static string InsertarActualizarSeguro(SIGC.Model.Seguro seguro)
        {
            try
            {
                if (seguro.Id_seguro == 0)
                {
                    if (FSeguro.Insertar(seguro) > 0)
                    {
                        return "éxito en el guardado";
                    }
                    else
                    {
                        return "un error en el guardado";
                    }
                }
                else if (seguro.Id_seguro > 0)
                {
                    if (FSeguro.Actualizar(seguro) > 0)
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

        public static string EliminarSeguro(SIGC.Model.Seguro seguro)
        {
            try
            {
                if (seguro.Id_seguro > 0)
                {
                    if (FSeguro.Eliminar(seguro) > 0)
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
