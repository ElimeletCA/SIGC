using Microsoft.Data.SqlClient;
using SIGC.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIGC.Data
{
    public class FEmpleado
    {
        public static DataSet GetAll()
        {
            SqlParameter[] dbParams = new SqlParameter[]
                {
                };
            return FDBHelper.ExecuteDataSet("usp_Data_FEmpleado_GetAll", dbParams);

        }
        public static int Insertar(Empleado empleado)
        {
            SqlParameter[] dbParams = new SqlParameter[]
                {
                    FDBHelper.MakeParam("@Id_departamento", SqlDbType.Int, 0, empleado.Id_departamento),
                    FDBHelper.MakeParam("@Id_puesto", SqlDbType.Int, 0, empleado.Id_puesto),
                    FDBHelper.MakeParam("@Cedula", SqlDbType.VarChar, 0, empleado.Cedula),
                    FDBHelper.MakeParam("@Nombre", SqlDbType.VarChar, 0, empleado.Nombre),
                    FDBHelper.MakeParam("@Apellido", SqlDbType.VarChar, 0, empleado.Apellido),
                    FDBHelper.MakeParam("@Sexo", SqlDbType.VarChar, 0, empleado.Sexo),
                    FDBHelper.MakeParam("@Telefono", SqlDbType.VarChar, 0, empleado.Telefono),
                    FDBHelper.MakeParam("@Direccion", SqlDbType.VarChar, 0, empleado.Direccion),
                    FDBHelper.MakeParam("@Fecha_nacimiento", SqlDbType.VarChar, 0, empleado.Fecha_nacimiento),
                    FDBHelper.MakeParam("@Fecha_contratacion", SqlDbType.VarChar, 0, empleado.Fecha_Contratacion),
                    FDBHelper.MakeParam("@Sueldo_bruto", SqlDbType.Decimal, 0, empleado.Sueldo_bruto),
                    FDBHelper.MakeParam("@Nota", SqlDbType.VarChar, 0, empleado.Nota),
                    FDBHelper.MakeParam("@Foto_empleado", SqlDbType.Image, 0, empleado.Foto_empleado)

                };
            return Convert.ToInt32(FDBHelper.ExecuteScalar("usp_Data_FEmpleado_Insertar", dbParams));

        }
        public static int Actualizar(Empleado empleado)
        {
            SqlParameter[] dbParams = new SqlParameter[]
                {
                    FDBHelper.MakeParam("@Id_empleado", SqlDbType.Int, 0, empleado.Id_empleado),
                    FDBHelper.MakeParam("@Id_departamento", SqlDbType.Int, 0, empleado.Id_departamento),
                    FDBHelper.MakeParam("@Id_puesto", SqlDbType.Int, 0, empleado.Id_puesto),
                    FDBHelper.MakeParam("@Cedula", SqlDbType.VarChar, 0, empleado.Cedula),
                    FDBHelper.MakeParam("@Nombre", SqlDbType.VarChar, 0, empleado.Nombre),
                    FDBHelper.MakeParam("@Apellido", SqlDbType.VarChar, 0, empleado.Apellido),
                    FDBHelper.MakeParam("@Sexo", SqlDbType.VarChar, 0, empleado.Sexo),
                    FDBHelper.MakeParam("@Telefono", SqlDbType.VarChar, 0, empleado.Telefono),
                    FDBHelper.MakeParam("@Direccion", SqlDbType.VarChar, 0, empleado.Direccion),
                    FDBHelper.MakeParam("@Fecha_nacimiento", SqlDbType.VarChar, 0, empleado.Fecha_nacimiento),
                    FDBHelper.MakeParam("@Fecha_contratacion", SqlDbType.VarChar, 0, empleado.Fecha_Contratacion),
                    FDBHelper.MakeParam("@Sueldo_bruto", SqlDbType.Decimal, 0, empleado.Sueldo_bruto),
                    FDBHelper.MakeParam("@Nota", SqlDbType.VarChar, 0, empleado.Nota),
                    FDBHelper.MakeParam("@Foto_empleado", SqlDbType.Image, 0, empleado.Foto_empleado)
                };
            return Convert.ToInt32(FDBHelper.ExecuteScalar("usp_Data_FEmpleado_Actualizar", dbParams));

        }
        public static int Eliminar(Empleado empleado)
        {
            SqlParameter[] dbParams = new SqlParameter[]
                {
                    FDBHelper.MakeParam("@id_empleado", SqlDbType.Int, 0, empleado.Id_empleado)
               };
            return Convert.ToInt32(FDBHelper.ExecuteScalar("usp_Data_FEmpleado_Eliminar", dbParams));

        }
    }
}
