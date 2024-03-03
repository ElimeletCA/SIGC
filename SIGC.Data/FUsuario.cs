using Microsoft.Data.SqlClient;
using SIGC.Data;
using SIGC.Model;
using System.Data;
namespace SIGC.Data
{
    public class FUsuario
    {
        public static DataSet GetAll()
        {
            SqlParameter[] dbParams = new SqlParameter[]
                {
                };
            return FDBHelper.ExecuteDataSet("usp_Data_FUsuario_GetAll", dbParams);

        }
        public static int Insertar(Usuario usuario)
        {
            SqlParameter[] dbParams = new SqlParameter[]
                {
                   FDBHelper.MakeParam("@Id_empleado", SqlDbType.Int, 0, usuario.Id_empleado),
                   FDBHelper.MakeParam("@Id_rol", SqlDbType.Int, 0, usuario.Id_rol),
                   FDBHelper.MakeParam("@descripcion", SqlDbType.VarChar, 0, usuario.Nombre_usuario),
                   FDBHelper.MakeParam("@descripcion", SqlDbType.VarChar, 0, usuario.Contrasena)

                };
            return Convert.ToInt32(FDBHelper.ExecuteScalar("usp_Data_FUsuario_Insertar", dbParams));

        }
        public static int Actualizar(Usuario usuario)
        {
            SqlParameter[] dbParams = new SqlParameter[]
                {
                   FDBHelper.MakeParam("@Id_usuario", SqlDbType.Int, 0, usuario.Id_usuario),
                   FDBHelper.MakeParam("@Id_empleado", SqlDbType.Int, 0, usuario.Id_empleado),
                   FDBHelper.MakeParam("@Id_rol", SqlDbType.Int, 0, usuario.Id_rol),
                   FDBHelper.MakeParam("@descripcion", SqlDbType.VarChar, 0, usuario.Nombre_usuario),
                   FDBHelper.MakeParam("@descripcion", SqlDbType.VarChar, 0, usuario.Contrasena)
                };
            return Convert.ToInt32(FDBHelper.ExecuteScalar("usp_Data_FUsuario_Actualizar", dbParams));

        }
        public static int Eliminar(Usuario usuario)
        {
            SqlParameter[] dbParams = new SqlParameter[]
                {
                   FDBHelper.MakeParam("@Id_usuario", SqlDbType.Int, 0, usuario.Id_usuario)
               };
            return Convert.ToInt32(FDBHelper.ExecuteScalar("usp_Data_FUsuario_Eliminar", dbParams));

        }
    }
}