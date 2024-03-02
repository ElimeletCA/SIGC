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
    public class FSeguro
    {
        public static DataSet GetAll()
        {
            SqlParameter[] dbParams = new SqlParameter[]
                {
                };
            return FDBHelper.ExecuteDataSet("usp_Data_FSeguro_GetAll", dbParams);

        }
        public static int Insertar(Seguro seguro)
        {
            SqlParameter[] dbParams = new SqlParameter[]
                {
                    FDBHelper.MakeParam("@nombre", SqlDbType.VarChar, 0, seguro.Nombre),
                    FDBHelper.MakeParam("@descripcion", SqlDbType.VarChar, 0, seguro.Descripcion)

                };
            return Convert.ToInt32(FDBHelper.ExecuteScalar("usp_Data_FSeguro_Insertar", dbParams));

        }
        public static int Actualizar(Seguro seguro)
        {
            SqlParameter[] dbParams = new SqlParameter[]
                {
                    FDBHelper.MakeParam("@id_seguro", SqlDbType.Int, 0, seguro.Id_seguro),
                    FDBHelper.MakeParam("@nombre", SqlDbType.VarChar, 0, seguro.Nombre),
                    FDBHelper.MakeParam("@descripcion", SqlDbType.VarChar, 0, seguro.Descripcion)
                };
            return Convert.ToInt32(FDBHelper.ExecuteScalar("usp_Data_FSeguro_Actualizar", dbParams));

        }
        public static int Eliminar(Seguro seguro)
        {
            SqlParameter[] dbParams = new SqlParameter[]
                {
                    FDBHelper.MakeParam("@id_seguro", SqlDbType.Int, 0, seguro.Id_seguro)
               };
            return Convert.ToInt32(FDBHelper.ExecuteScalar("usp_Data_FSeguro_Eliminar", dbParams));

        }
    }
}



