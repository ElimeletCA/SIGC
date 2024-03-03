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
    public class FProducto
    {
        public static DataSet GetAll()
        {
            SqlParameter[] dbParams = new SqlParameter[]
            {
                };
            return FDBHelper.ExecuteDataSet("usp_Data_FProducto_GetAll", dbParams);

        }
        public static int Insertar(Producto producto)
        {
            SqlParameter[] dbParams = new SqlParameter[]
            {
                    FDBHelper.MakeParam("@Id_categoria", SqlDbType.Int, 0, producto.Id_categoria),
                    FDBHelper.MakeParam("@Nombre", SqlDbType.VarChar, 0, producto.Nombre),
                    FDBHelper.MakeParam("@Precio_costo", SqlDbType.Decimal, 0, producto.Precio_costo),
                    FDBHelper.MakeParam("@Precio_venta", SqlDbType.Decimal, 0, producto.Precio_venta),
                    FDBHelper.MakeParam("@Cantidad_disponible", SqlDbType.Int, 0, producto.Cantidad_disponible),
                    FDBHelper.MakeParam("@Imagen_producto", SqlDbType.Image, 0, producto.Imagen_producto)
                };
            return Convert.ToInt32(FDBHelper.ExecuteScalar("usp_Data_FProducto_Insertar", dbParams));

        }
        public static int Actualizar(Producto producto)
        {
            SqlParameter[] dbParams = new SqlParameter[]
            {
                    FDBHelper.MakeParam("@Id_producto", SqlDbType.Int, 0, producto.Id_producto),
                    FDBHelper.MakeParam("@Id_categoria", SqlDbType.Int, 0, producto.Id_categoria),
                    FDBHelper.MakeParam("@Nombre", SqlDbType.VarChar, 0, producto.Nombre),
                    FDBHelper.MakeParam("@Precio_costo", SqlDbType.Decimal, 0, producto.Precio_costo),
                    FDBHelper.MakeParam("@Precio_venta", SqlDbType.Decimal, 0, producto.Precio_venta),
                    FDBHelper.MakeParam("@Cantidad_disponible", SqlDbType.Int, 0, producto.Cantidad_disponible),
                    FDBHelper.MakeParam("@Imagen_producto", SqlDbType.Image, 0, producto.Imagen_producto)
                };
            return Convert.ToInt32(FDBHelper.ExecuteScalar("usp_Data_FProducto_Actualizar", dbParams));

        }
        public static int Eliminar(Producto producto)
        {
            SqlParameter[] dbParams = new SqlParameter[]
            {
                    FDBHelper.MakeParam("@Id_producto", SqlDbType.Int, 0, producto.Id_producto)
               };
            return Convert.ToInt32(FDBHelper.ExecuteScalar("usp_Data_FProducto_Eliminar", dbParams));

        }
    }
}


