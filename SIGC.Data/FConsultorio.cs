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
    public class FConsultorio
    {
        public static DataSet GetAll()
        {
            SqlParameter[] dbParams = new SqlParameter[]
                {
                };
            return FDBHelper.ExecuteDataSet("usp_Data_FConsultorio_GetAll", dbParams);

        }


        public static int Insertar(Consultorio consultorio)
        {
            SqlParameter[] dbParams = new SqlParameter[]
                {
                    FDBHelper.MakeParam("@nombre", SqlDbType.VarChar, 0, consultorio.Nombre),
                    FDBHelper.MakeParam("@locacion", SqlDbType.VarChar, 0, consultorio.Locacion)

                };
            return Convert.ToInt32(FDBHelper.ExecuteScalar("usp_Data_FConsultorio_Insertar", dbParams));

        }


        public static int Actualizar(Consultorio consultorio)
        {
            SqlParameter[] dbParams = new SqlParameter[]
                {
                    FDBHelper.MakeParam("@id_consultorio", SqlDbType.Int, 0, consultorio.Id_consultorio),
                    FDBHelper.MakeParam("@nombre", SqlDbType.VarChar, 0, consultorio.Nombre),
                    FDBHelper.MakeParam("@locacion", SqlDbType.VarChar, 0, consultorio.Locacion)
                };
            return Convert.ToInt32(FDBHelper.ExecuteScalar("usp_Data_FConsultorio_Actualizar", dbParams));

        }
        public static int Eliminar(Consultorio consultorio)
        {
            SqlParameter[] dbParams = new SqlParameter[]
                {
                    FDBHelper.MakeParam("@id_consultorio", SqlDbType.Int, 0, consultorio.Id_consultorio)
               };
            return Convert.ToInt32(FDBHelper.ExecuteScalar("usp_Data_FConsultorio_Eliminar", dbParams));

        }
    }
}
