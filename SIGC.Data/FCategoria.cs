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
    public class FCategoria
    {
        public static DataSet GetAll()
        {
            SqlParameter[] dbParams = new SqlParameter[]
                {
                };
            return FDBHelper.ExecuteDataSet("usp_Data_FCategoria_GetAll", dbParams);

        }
        public static int Insertar(Categoria categoria)
        {
            SqlParameter[] dbParams = new SqlParameter[]
                {
                    FDBHelper.MakeParam("@nombre", SqlDbType.VarChar, 0, categoria.Nombre),
                    FDBHelper.MakeParam("@descripcion", SqlDbType.VarChar, 0, categoria.Descripcion)

                };
            return Convert.ToInt32(FDBHelper.ExecuteScalar("usp_Data_FCategoria_Insertar", dbParams));

        }
        public static int Actualizar(Categoria categoria)
        {
            SqlParameter[] dbParams = new SqlParameter[]
                {
                    FDBHelper.MakeParam("@id_categoria", SqlDbType.Int, 0, categoria.Id_categoria),
                    FDBHelper.MakeParam("@nombre", SqlDbType.VarChar, 0, categoria.Nombre),
                    FDBHelper.MakeParam("@descripcion", SqlDbType.VarChar, 0, categoria.Descripcion)
                };
            return Convert.ToInt32(FDBHelper.ExecuteScalar("usp_Data_FCategoria_Actualizar", dbParams));

        }
        public static int Eliminar(Categoria categoria)
        {
            SqlParameter[] dbParams = new SqlParameter[]
                {
                    FDBHelper.MakeParam("@id_categoria", SqlDbType.Int, 0, categoria.Id_categoria)
               };
            return Convert.ToInt32(FDBHelper.ExecuteScalar("usp_Data_FCategoria_Eliminar", dbParams));

        }
    }
}
