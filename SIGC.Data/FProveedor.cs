using Microsoft.Data.SqlClient;
using SIGC.Data;
using SIGC.Model;
using System.Data;
namespace SIGC.Data
{
    public class FProveedor
    {
        public static DataSet GetAll()
        {
            SqlParameter[] dbParams = new SqlParameter[]
            {
                };
            return FDBHelper.ExecuteDataSet("usp_Data_FProveedor_GetAll", dbParams);

        }
        public static int Insertar(Proveedor proveedor)
        {
            SqlParameter[] dbParams = new SqlParameter[]
            {
                   FDBHelper.MakeParam("@Nombre", SqlDbType.VarChar, 0, proveedor.Nombre),
                   FDBHelper.MakeParam("@Id_tipo_documento", SqlDbType.Int, 0, proveedor.Id_tipo_documento),
                   FDBHelper.MakeParam("@Numero_documento", SqlDbType.VarChar, 0, proveedor.Numero_documento),
                   FDBHelper.MakeParam("@Telefono", SqlDbType.VarChar, 0, proveedor.Telefono),
                   FDBHelper.MakeParam("@Direccion", SqlDbType.VarChar, 0, proveedor.Direccion),
                   FDBHelper.MakeParam("@Correo_electronico", SqlDbType.VarChar, 0, proveedor.Correo_electronico),
                   FDBHelper.MakeParam("@Nota", SqlDbType.VarChar, 0, proveedor.Nota)
                };
            return Convert.ToInt32(FDBHelper.ExecuteScalar("usp_Data_FProveedor_Insertar", dbParams));

        }
        public static int Actualizar(Proveedor proveedor)
        {
            SqlParameter[] dbParams = new SqlParameter[]
            {
                   FDBHelper.MakeParam("@Id_proveedor", SqlDbType.Int, 0, proveedor.Id_proveedor),
                   FDBHelper.MakeParam("@Nombre", SqlDbType.VarChar, 0, proveedor.Nombre),
                   FDBHelper.MakeParam("@Id_tipo_documento", SqlDbType.Int, 0, proveedor.Id_tipo_documento),
                   FDBHelper.MakeParam("@Numero_documento", SqlDbType.VarChar, 0, proveedor.Numero_documento),
                   FDBHelper.MakeParam("@Telefono", SqlDbType.VarChar, 0, proveedor.Telefono),
                   FDBHelper.MakeParam("@Direccion", SqlDbType.VarChar, 0, proveedor.Direccion),
                   FDBHelper.MakeParam("@Correo_electronico", SqlDbType.VarChar, 0, proveedor.Correo_electronico),
                   FDBHelper.MakeParam("@Nota", SqlDbType.VarChar, 0, proveedor.Nota)
                };
            return Convert.ToInt32(FDBHelper.ExecuteScalar("usp_Data_FProveedor_Actualizar", dbParams));

        }
        public static int Eliminar(Proveedor proveedor)
        {
            SqlParameter[] dbParams = new SqlParameter[]
            {
                   FDBHelper.MakeParam("@Id_proveedor", SqlDbType.Int, 0, proveedor.Id_proveedor)
               };
            return Convert.ToInt32(FDBHelper.ExecuteScalar("usp_Data_FProveedor_Eliminar", dbParams));

        }
    }
}