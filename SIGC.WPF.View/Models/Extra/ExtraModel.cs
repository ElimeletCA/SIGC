using SIGC.Data;
using SIGC.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIGC.WPF.View.Models.Extra
{
    public class ExtraModel
    {
        /********* Puesto  *********/
        public static DataTable GetPuestoDataTable()
        {
            DataTable emptyDataTable = new DataTable();

            try
            {
                DataSet DataSetPuesto = FPuesto.GetAll();
                if (DataSetPuesto.Tables[0].Rows.Count > 0)
                {
                    return DataSetPuesto.Tables[0];
                }
            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show(ex.Message);
            }
            return emptyDataTable;
        }
        public static string InsertarActualizarPuesto(SIGC.Model.Puesto puesto)
        {
            try
            {
                if (puesto.Id_puesto == 0)
                {
                    if (FPuesto.Insertar(puesto) > 0)
                    {
                        return "éxito en el guardado";
                    }
                    else
                    {
                        return "un error en el guardado";
                    }
                }
                else if (puesto.Id_puesto > 0)
                {
                    if (FPuesto.Actualizar(puesto) > 0)
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

        public static string EliminarPuesto(SIGC.Model.Puesto puesto)
        {
            try
            {
                if (puesto.Id_puesto > 0)
                {
                    if (FPuesto.Eliminar(puesto) > 0)
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



        /********* Departamento  *********/
        public static DataTable GetDepartamentoDataTable()
        {
            DataTable emptyDataTable = new DataTable();

            try
            {
                DataSet DataSetDepartamento = FDepartamento.GetAll();
                if (DataSetDepartamento.Tables[0].Rows.Count > 0)
                {
                    return DataSetDepartamento.Tables[0];
                }
            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show(ex.Message);
            }
            return emptyDataTable;
        }
        public static string InsertarActualizarDepartamento(SIGC.Model.Departamento departamento)
        {
            try
            {
                if (departamento.Id_departamento == 0)
                {
                    if (FDepartamento.Insertar(departamento) > 0)
                    {
                        return "éxito en el guardado";
                    }
                    else
                    {
                        return "un error en el guardado";
                    }
                }
                else if (departamento.Id_departamento > 0)
                {
                    if (FDepartamento.Actualizar(departamento) > 0)
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

        public static string EliminarDepartamento(SIGC.Model.Departamento departamento)
        {
            try
            {
                if (departamento.Id_departamento > 0)
                {
                    if (FDepartamento.Eliminar(departamento) > 0)
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





        /********* Tipo Documento  *********/
        public static DataTable GetTipoDocumentoDataTable()
        {
            DataTable emptyDataTable = new DataTable();

            try
            {
                DataSet DataSetTipoDocumento = FTipodocumento.GetAll();
                if (DataSetTipoDocumento.Tables[0].Rows.Count > 0)
                {
                    return DataSetTipoDocumento.Tables[0];
                }
            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show(ex.Message);
            }
            return emptyDataTable;
        }
        public static string InsertarActualizarTipoDocumento(SIGC.Model.Tipo_Documento tipo_documento)
        {
            try
            {
                if (tipo_documento.Id_tipo_documento == 0)
                {
                    if (FTipodocumento.Insertar(tipo_documento) > 0)
                    {
                        return "éxito en el guardado";
                    }
                    else
                    {
                        return "un error en el guardado";
                    }
                }
                else if (tipo_documento.Id_tipo_documento > 0)
                {
                    if (FTipodocumento.Actualizar(tipo_documento) > 0)
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

        public static string EliminarTipoDocumento(SIGC.Model.Tipo_Documento tipo_documento)
        {
            try
            {
                if (tipo_documento.Id_tipo_documento > 0)
                {
                    if (FTipodocumento.Eliminar(tipo_documento) > 0)
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
