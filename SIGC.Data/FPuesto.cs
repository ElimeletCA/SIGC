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
    public class FPuesto
    {
        public static DataSet GetAll()
        {
            SqlParameter[] dbParams = new SqlParameter[]
                {
                };
            return FDBHelper.ExecuteDataSet("usp_Data_FPuesto_GetAll", dbParams);

        }
        public static int Insertar(Puesto puesto)
        {
            SqlParameter[] dbParams = new SqlParameter[]
                {
                   FDBHelper.MakeParam("@nombre", SqlDbType.VarChar, 0, puesto.Nombre),
                   FDBHelper.MakeParam("@descripcion", SqlDbType.VarChar, 0, puesto.Descripcion)

                };
            return Convert.ToInt32(FDBHelper.ExecuteScalar("usp_Data_FPuesto_Insertar", dbParams));

        }
        public static int Actualizar(Puesto puesto)
        {
            SqlParameter[] dbParams = new SqlParameter[]
                {
                   FDBHelper.MakeParam("@id_puesto", SqlDbType.Int, 0, puesto.Id_puesto),
                   FDBHelper.MakeParam("@nombre", SqlDbType.VarChar, 0, puesto.Nombre),
                   FDBHelper.MakeParam("@descripcion", SqlDbType.VarChar, 0, puesto.Descripcion)
                };
            return Convert.ToInt32(FDBHelper.ExecuteScalar("usp_Data_FPuesto_Actualizar", dbParams));

        }
        public static int Eliminar(Puesto puesto)
        {
            SqlParameter[] dbParams = new SqlParameter[]
                {
                   FDBHelper.MakeParam("@id_puesto", SqlDbType.Int, 0, puesto.Id_puesto)
               };
            return Convert.ToInt32(FDBHelper.ExecuteScalar("usp_Data_FPuesto_Eliminar", dbParams));

        }
    }
}
