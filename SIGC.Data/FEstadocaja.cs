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
    public class FEstadocaja
    {
        public static DataSet GetAll()
        {
            SqlParameter[] dbParams = new SqlParameter[]
                {
                };
            return FDBHelper.ExecuteDataSet("usp_Data_FEstadoCaja_GetAll", dbParams);

        }
        public static int Insertar(Estado_Caja estado_caja)
        {
            SqlParameter[] dbParams = new SqlParameter[]
                {
                    FDBHelper.MakeParam("@nombre", SqlDbType.VarChar, 0, estado_caja.Nombre),
                };
            return Convert.ToInt32(FDBHelper.ExecuteScalar("usp_Data_FEstadoCaja_Insertar", dbParams));

        }
        public static int Actualizar(Estado_Caja estado_caja)
        {
            SqlParameter[] dbParams = new SqlParameter[]
                {
                    FDBHelper.MakeParam("@id_estado_caja", SqlDbType.Int, 0, estado_caja.Id_estado_caja),
                    FDBHelper.MakeParam("@nombre", SqlDbType.VarChar, 0, estado_caja.Nombre),
                };
            return Convert.ToInt32(FDBHelper.ExecuteScalar("usp_Data_FEstadoCaja_Actualizar", dbParams));

        }
        public static int Eliminar(Estado_Caja estado_caja)
        {
            SqlParameter[] dbParams = new SqlParameter[]
                {
                    FDBHelper.MakeParam("@id_estado_caja", SqlDbType.Int, 0, estado_caja.Id_estado_caja)
               };
            return Convert.ToInt32(FDBHelper.ExecuteScalar("usp_Data_FEstadoCaja_Eliminar", dbParams));

        }
    }
}
