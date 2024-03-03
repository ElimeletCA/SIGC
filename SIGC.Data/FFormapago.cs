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
    public class FFormapago
    {
        public static DataSet GetAll()
        {
            SqlParameter[] dbParams = new SqlParameter[]
            {
                };
            return FDBHelper.ExecuteDataSet("usp_Data_FFormaPago_GetAll", dbParams);

        }
        public static int Insertar(Forma_Pago forma_pago)
        {
            SqlParameter[] dbParams = new SqlParameter[]
            {
                    FDBHelper.MakeParam("@Nombre_forma_pago", SqlDbType.VarChar, 0, forma_pago.Nombre_forma_pago),
                };
            return Convert.ToInt32(FDBHelper.ExecuteScalar("usp_Data_FFormaPago_Insertar", dbParams));

        }
        public static int Actualizar(Forma_Pago forma_pago)
        {
            SqlParameter[] dbParams = new SqlParameter[]
            {
                    FDBHelper.MakeParam("@Id_forma_pago", SqlDbType.Int, 0, forma_pago.Id_forma_pago),
                    FDBHelper.MakeParam("@Nombre_forma_pago", SqlDbType.VarChar, 0, forma_pago.Nombre_forma_pago),
                };
            return Convert.ToInt32(FDBHelper.ExecuteScalar("usp_Data_FFormaPago_Actualizar", dbParams));

        }
        public static int Eliminar(Forma_Pago forma_pago)
        {
            SqlParameter[] dbParams = new SqlParameter[]
            {
                    FDBHelper.MakeParam("@Id_forma_pago", SqlDbType.Int, 0, forma_pago.Id_forma_pago)
               };
            return Convert.ToInt32(FDBHelper.ExecuteScalar("usp_Data_FFormaPago_Eliminar", dbParams));

        }
    }   
}
