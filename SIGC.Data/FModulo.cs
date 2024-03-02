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
    public class FModulo
    {
        public static DataSet GetAll()
        {
            SqlParameter[] dbParams = new SqlParameter[]
                {
                };
            return FDBHelper.ExecuteDataSet("usp_Data_FModulo_GetAll", dbParams);

        }
        public static int Insertar(Modulo modulo)
        {
            SqlParameter[] dbParams = new SqlParameter[]
                {
                   FDBHelper.MakeParam("@nombre", SqlDbType.VarChar, 0, modulo.Nombre),
                   FDBHelper.MakeParam("@descripcion", SqlDbType.VarChar, 0, modulo.Descripcion)

                };
            return Convert.ToInt32(FDBHelper.ExecuteScalar("usp_Data_FModulo_Insertar", dbParams));

        }
        public static int Actualizar(Modulo modulo)
        {
            SqlParameter[] dbParams = new SqlParameter[]
                {
                   FDBHelper.MakeParam("@id_modulo", SqlDbType.Int, 0, modulo.Id_modulo),
                   FDBHelper.MakeParam("@nombre", SqlDbType.VarChar, 0, modulo.Nombre),
                   FDBHelper.MakeParam("@descripcion", SqlDbType.VarChar, 0, modulo.Descripcion)
                };
            return Convert.ToInt32(FDBHelper.ExecuteScalar("usp_Data_FModulo_Actualizar", dbParams));

        }
        public static int Eliminar(Modulo modulo)
        {
            SqlParameter[] dbParams = new SqlParameter[]
                {
                   FDBHelper.MakeParam("@id_modulo", SqlDbType.Int, 0, modulo.Id_modulo)
               };
            return Convert.ToInt32(FDBHelper.ExecuteScalar("usp_Data_FModulo_Eliminar", dbParams));

        }
    }
}
