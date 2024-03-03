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
    public class FTipofactura
    {
        public static DataSet GetAll()
        {
            SqlParameter[] dbParams = new SqlParameter[]
                {
                };
            return FDBHelper.ExecuteDataSet("usp_Data_FTipoFactura_GetAll", dbParams);

        }
        public static int Insertar(Tipo_Factura tipo_factura)
        {
            SqlParameter[] dbParams = new SqlParameter[]
                {
                    FDBHelper.MakeParam("@Nombre_tipo_factura", SqlDbType.VarChar, 0, tipo_factura.Nombre_tipo_factura),
                          };
            return Convert.ToInt32(FDBHelper.ExecuteScalar("usp_Data_FTipoFactura_Insertar", dbParams));

        }
        public static int Actualizar(Tipo_Factura tipo_factura)
        {
            SqlParameter[] dbParams = new SqlParameter[]
                {
                    FDBHelper.MakeParam("@Id_tipo_factura", SqlDbType.Int, 0, tipo_factura.Id_tipo_factura),
                    FDBHelper.MakeParam("@Nombre_tipo_factura", SqlDbType.VarChar, 0, tipo_factura.Nombre_tipo_factura),
                };
            return Convert.ToInt32(FDBHelper.ExecuteScalar("usp_Data_FTipoFactura_Actualizar", dbParams));
        }
        public static int Eliminar(Tipo_Factura tipo_factura)
        {
            SqlParameter[] dbParams = new SqlParameter[]
                {
                    FDBHelper.MakeParam("@Id_tipo_factura", SqlDbType.Int, 0, tipo_factura.Id_tipo_factura),
               };
            return Convert.ToInt32(FDBHelper.ExecuteScalar("usp_Data_FTipoFactura_Eliminar", dbParams));

        }
    }
}

