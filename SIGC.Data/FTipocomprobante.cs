using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIGC.Model;
namespace SIGC.Data
{
    public class FTipocomprobante
    {
        public static DataSet GetAll()
        {
            SqlParameter[] dbParams = new SqlParameter[]
                {
                };
            return FDBHelper.ExecuteDataSet("usp_Data_FTipoComprobante_GetAll", dbParams);

        }
        public static int Insertar(Tipo_Comprobante tipo_comprobante)
        {
            SqlParameter[] dbParams = new SqlParameter[]
                {
                    FDBHelper.MakeParam("@Nombre", SqlDbType.VarChar, 0, tipo_comprobante.Nombre),
                          };
            return Convert.ToInt32(FDBHelper.ExecuteScalar("usp_Data_FTipoComprobante_Insertar", dbParams));

        }
        public static int Actualizar(Tipo_Comprobante tipo_comprobante)
        {
            SqlParameter[] dbParams = new SqlParameter[]
                {
                    FDBHelper.MakeParam("@Id_tipo_comprobante", SqlDbType.Int, 0, tipo_comprobante.Id_tipo_comprobante),
                    FDBHelper.MakeParam("@Nombre", SqlDbType.VarChar, 0, tipo_comprobante.Nombre),
                };
            return Convert.ToInt32(FDBHelper.ExecuteScalar("usp_Data_FTipoComprobante_Actualizar", dbParams));
        }
        public static int Eliminar(Tipo_Comprobante tipo_comprobante)
        {
            SqlParameter[] dbParams = new SqlParameter[]
                {
                    FDBHelper.MakeParam("@Id_tipo_comprobante", SqlDbType.Int, 0, tipo_comprobante.Id_tipo_comprobante),
               };
            return Convert.ToInt32(FDBHelper.ExecuteScalar("usp_Data_FTipoComprobante_Eliminar", dbParams));

        }
    }
}
