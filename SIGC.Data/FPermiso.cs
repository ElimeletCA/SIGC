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
    public class FPermiso
    {
        public static DataSet GetAll()
        {
            SqlParameter[] dbParams = new SqlParameter[]
                {
                };
            return FDBHelper.ExecuteDataSet("usp_Data_FPermiso_GetAll", dbParams);

        }
        public static int Insertar(Permiso permiso)
        {
            SqlParameter[] dbParams = new SqlParameter[]
                {
                   FDBHelper.MakeParam("@nombre", SqlDbType.VarChar, 0, permiso.Nombre),
                   FDBHelper.MakeParam("@descripcion", SqlDbType.VarChar, 0, permiso.Descripcion)

                };
            return Convert.ToInt32(FDBHelper.ExecuteScalar("usp_Data_FPermiso_Insertar", dbParams));

        }
        public static int Actualizar(Permiso permiso)
        {
            SqlParameter[] dbParams = new SqlParameter[]
                {
                   FDBHelper.MakeParam("@id_permiso", SqlDbType.Int, 0, permiso.Id_permiso),
                   FDBHelper.MakeParam("@nombre", SqlDbType.VarChar, 0, permiso.Nombre),
                   FDBHelper.MakeParam("@descripcion", SqlDbType.VarChar, 0, permiso.Descripcion)
                };
            return Convert.ToInt32(FDBHelper.ExecuteScalar("usp_Data_FPermiso_Actualizar", dbParams));

        }
        public static int Eliminar(Permiso permiso)
        {
            SqlParameter[] dbParams = new SqlParameter[]
                {
                   FDBHelper.MakeParam("@id_permiso", SqlDbType.Int, 0, permiso.Id_permiso)
               };
            return Convert.ToInt32(FDBHelper.ExecuteScalar("usp_Data_FPermiso_Eliminar", dbParams));

        }
    }
}
