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
    public class FTipoordencompra
    {
        public static DataSet GetAll()
        {
            SqlParameter[] dbParams = new SqlParameter[]
            {
                };
            return FDBHelper.ExecuteDataSet("usp_Data_FTipoOrdenCompra_GetAll", dbParams);

        }
        public static int Insertar(Tipo_Orden_Compra tipo_orden_compra)
        {
            SqlParameter[] dbParams = new SqlParameter[]
            {
                    FDBHelper.MakeParam("@Nombre_tipo_orden_compra", SqlDbType.VarChar, 0, tipo_orden_compra.Nombre_tipo_orden_compra),
                          };
            return Convert.ToInt32(FDBHelper.ExecuteScalar("usp_Data_FTipoOrdenCompra_Insertar", dbParams));

        }
        public static int Actualizar(Tipo_Orden_Compra tipo_orden_compra)
        {
            SqlParameter[] dbParams = new SqlParameter[]
            {
                    FDBHelper.MakeParam("@Id_tipo_orden_compra", SqlDbType.Int, 0, tipo_orden_compra.Id_tipo_orden_compra),
                    FDBHelper.MakeParam("@Nombre_tipo_orden_compra", SqlDbType.VarChar, 0, tipo_orden_compra.Nombre_tipo_orden_compra),
                };
            return Convert.ToInt32(FDBHelper.ExecuteScalar("usp_Data_FTipoOrdenCompra_Actualizar", dbParams));
        }
        public static int Eliminar(Tipo_Orden_Compra tipo_orden_compra)
        {
            SqlParameter[] dbParams = new SqlParameter[]
            {
                    FDBHelper.MakeParam("@Id_tipo_orden_compra", SqlDbType.Int, 0, tipo_orden_compra.Id_tipo_orden_compra),
               };
            return Convert.ToInt32(FDBHelper.ExecuteScalar("usp_Data_FTipoOrdenCompra_Eliminar", dbParams));

        }
    }
}

