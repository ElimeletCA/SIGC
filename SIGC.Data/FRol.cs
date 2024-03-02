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
    public class FRol
    {
        public static DataSet GetAll()
        {
            SqlParameter[] dbParams = new SqlParameter[]
                {
                };
            return FDBHelper.ExecuteDataSet("usp_Data_FRol_GetAll", dbParams);

        }
        public static int Insertar(Rol rol)
        {
            SqlParameter[] dbParams = new SqlParameter[]
                {
                   FDBHelper.MakeParam("@nombre", SqlDbType.VarChar, 0, rol.Nombre),
                   FDBHelper.MakeParam("@descripcion", SqlDbType.VarChar, 0, rol.Descripcion)

                };
            return Convert.ToInt32(FDBHelper.ExecuteScalar("usp_Data_FRol_Insertar", dbParams));

        }
        public static int Actualizar(Rol rol)
        {
            SqlParameter[] dbParams = new SqlParameter[]
                {
                   FDBHelper.MakeParam("@id_rol", SqlDbType.Int, 0, rol.Id_rol),
                   FDBHelper.MakeParam("@nombre", SqlDbType.VarChar, 0, rol.Nombre),
                   FDBHelper.MakeParam("@descripcion", SqlDbType.VarChar, 0, rol.Descripcion)
                };
            return Convert.ToInt32(FDBHelper.ExecuteScalar("usp_Data_FRol_Actualizar", dbParams));

        }
        public static int Eliminar(Rol rol)
        {
            SqlParameter[] dbParams = new SqlParameter[]
                {
                   FDBHelper.MakeParam("@id_rol", SqlDbType.Int, 0, rol.Id_rol)
               };
            return Convert.ToInt32(FDBHelper.ExecuteScalar("usp_Data_FRol_Eliminar", dbParams));

        }
    }
}
