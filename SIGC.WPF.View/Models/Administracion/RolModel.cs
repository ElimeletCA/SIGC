using SIGC.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIGC.WPF.View.Models.Administracion
{
    public class RolModel
    {

        public static DataTable GetRolDataTable()
        {
            DataTable emptyDataTable = new DataTable();

            try
            {
                DataSet DataSetRol = FRol.GetAll();
                if (DataSetRol.Tables[0].Rows.Count > 0)
                {
                    return DataSetRol.Tables[0];
                }
            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show(ex.Message);
            }
            return emptyDataTable;
        }
        public static string InsertarActualizarRol(SIGC.Model.Rol rol)
        {
            try
            {
                if (rol.Id_rol == 0)
                {
                    if (FRol.Insertar(rol) > 0)
                    {
                        return "éxito en el guardado";
                    }
                    else
                    {
                        return "un error en el guardado";
                    }
                }
                else if (rol.Id_rol > 0)
                {
                    if (FRol.Actualizar(rol) > 0)
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

        public static string EliminarRol(SIGC.Model.Rol rol)
        {
            try
            {
                if (rol.Id_rol > 0)
                {
                    if (FRol.Eliminar(rol) > 0)
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
