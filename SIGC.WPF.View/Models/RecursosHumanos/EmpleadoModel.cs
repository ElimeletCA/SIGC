using SIGC.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIGC.WPF.View.Models.RecursosHumanos
{
    public class EmpleadoModel
    {
        public static DataTable GetEmpleadoDataTable()
        {
            DataTable emptyDataTable = new DataTable();

            try
            {
                DataSet DataSetEmpleado = FEmpleado.GetAll();
                if (DataSetEmpleado.Tables[0].Rows.Count > 0)
                {
                    return DataSetEmpleado.Tables[0];
                }
            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show(ex.Message);
            }
            return emptyDataTable;
        }
        public static string InsertarActualizarEmpleado(SIGC.Model.Empleado empleado)
        {
            try
            {
                if (empleado.Id_empleado == 0)
                {
                    if (FEmpleado.Insertar(empleado) > 0)
                    {
                        return "éxito en el guardado";
                    }
                    else
                    {
                        return "un error en el guardado";
                    }
                }
                else if (empleado.Id_empleado > 0)
                {
                    if (FEmpleado.Actualizar(empleado) > 0)
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

        public static string EliminarEmpleado(SIGC.Model.Empleado empleado)
        {
            try
            {
                if (empleado.Id_empleado > 0)
                {
                    if (FEmpleado.Eliminar(empleado) > 0)
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
