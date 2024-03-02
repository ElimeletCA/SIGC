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
    public class FMedicamento
    {
        public static DataSet GetAll()
        {
            SqlParameter[] dbParams = new SqlParameter[]
                {
                };
            return FDBHelper.ExecuteDataSet("usp_Data_FMedicamento_GetAll", dbParams);

        }
        public static int Insertar(Medicamento medicamento)
        {
            SqlParameter[] dbParams = new SqlParameter[]
                {
                   FDBHelper.MakeParam("@nombre", SqlDbType.VarChar, 0, medicamento.Nombre),
                   FDBHelper.MakeParam("@descripcion", SqlDbType.VarChar, 0, medicamento.Descripcion)

                };
            return Convert.ToInt32(FDBHelper.ExecuteScalar("usp_Data_FMedicamento_Insertar", dbParams));

        }
        public static int Actualizar(Medicamento medicamento)
        {
            SqlParameter[] dbParams = new SqlParameter[]
                {
                   FDBHelper.MakeParam("@id_medicamento", SqlDbType.Int, 0, medicamento.Id_medicamento),
                   FDBHelper.MakeParam("@nombre", SqlDbType.VarChar, 0, medicamento.Nombre),
                   FDBHelper.MakeParam("@descripcion", SqlDbType.VarChar, 0, medicamento.Descripcion)
                };
            return Convert.ToInt32(FDBHelper.ExecuteScalar("usp_Data_FMedicamento_Actualizar", dbParams));

        }
        public static int Eliminar(Medicamento medicamento)
        {
            SqlParameter[] dbParams = new SqlParameter[]
                {
                   FDBHelper.MakeParam("@id_medicamento", SqlDbType.Int, 0, medicamento.Id_medicamento)
               };
            return Convert.ToInt32(FDBHelper.ExecuteScalar("usp_Data_FMedicamento_Eliminar", dbParams));

        }
    }
}
