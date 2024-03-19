using SIGC.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIGC.WPF.View.Models.Administracion
{
    public class PermisoModel
    {
        public static DataTable GetPermisoDataTable()
        {
            DataTable emptyDataTable = new DataTable(); 
            try
            {
                DataSet DataSetPermiso = FPermiso.GetAll();
                if (DataSetPermiso.Tables[0].Rows.Count > 0)
                {
                    return DataSetPermiso.Tables[0];
                }
            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show(ex.Message);
            }
            return emptyDataTable;
        }
        public static string InsertarActualizarPermiso(SIGC.Model.Permiso permiso)
        {
            try
            {
                if (permiso.Id_permiso == 0)
                {
                    if (FPermiso.Insertar(permiso) > 0)
                    {
                        return "éxito en el guardado";
                    }
                    else
                    {
                        return "un error en el guardado";
                    }
                }
                else if (permiso.Id_permiso > 0)
                {
                    if (FPermiso.Actualizar(permiso) > 0)
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

        public static string EliminarPermiso(SIGC.Model.Permiso permiso)
        {
            try
            {
                if (permiso.Id_permiso > 0)
                {
                    if (FPermiso.Eliminar(permiso) > 0)
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
