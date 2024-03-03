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
    public class FEstadofactura
    {
        public static DataSet GetAll()
        {
            SqlParameter[] dbParams = new SqlParameter[]
                {
                };
            return FDBHelper.ExecuteDataSet("usp_Data_FEstadoFactura_GetAll", dbParams);

        }
        public static int Insertar(Estado_Factura estado_factura)
        {
            SqlParameter[] dbParams = new SqlParameter[]
                {
                    FDBHelper.MakeParam("@nombre", SqlDbType.VarChar, 0, estado_factura.Nombre),
                };
            return Convert.ToInt32(FDBHelper.ExecuteScalar("usp_Data_FEstadoFactura_Insertar", dbParams));

        }
        public static int Actualizar(Estado_Factura estado_factura)
        {
            SqlParameter[] dbParams = new SqlParameter[]
                {
                    FDBHelper.MakeParam("@id_estado_factura", SqlDbType.Int, 0, estado_factura.Id_estado_factura),
                    FDBHelper.MakeParam("@nombre", SqlDbType.VarChar, 0, estado_factura.Nombre),
                };
            return Convert.ToInt32(FDBHelper.ExecuteScalar("usp_Data_FEstadoFactura_Actualizar", dbParams));

        }
        public static int Eliminar(Estado_Factura estado_factura)
        {
            SqlParameter[] dbParams = new SqlParameter[]
                {
                    FDBHelper.MakeParam("@id_estado_factura", SqlDbType.Int, 0, estado_factura.Id_estado_factura)
               };
            return Convert.ToInt32(FDBHelper.ExecuteScalar("usp_Data_FEstadoFactura_Eliminar", dbParams));

        }
    }
}

