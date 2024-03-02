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
    public class FTipodocumento
    {
        public static DataSet GetAll()
        {
            SqlParameter[] dbParams = new SqlParameter[]
                {
                };
            return FDBHelper.ExecuteDataSet("usp_Data_FTipoDocumento_GetAll", dbParams);

        }
        public static int Insertar(Tipo_Documento tipo_documento)
        {
            SqlParameter[] dbParams = new SqlParameter[]
                {
                    FDBHelper.MakeParam("@nombre", SqlDbType.VarChar, 0, tipo_documento.Nombre),
                          };
            return Convert.ToInt32(FDBHelper.ExecuteScalar("usp_Data_FTipoDocumento_Insertar", dbParams));

        }
        public static int Actualizar(Tipo_Documento tipo_documento)
        {
            SqlParameter[] dbParams = new SqlParameter[]
                {
                    FDBHelper.MakeParam("@id_tipo_documento", SqlDbType.Int, 0, tipo_documento.Id_tipo_documento),
                    FDBHelper.MakeParam("@nombre", SqlDbType.VarChar, 0, tipo_documento.Nombre),
                };
            return Convert.ToInt32(FDBHelper.ExecuteScalar("usp_Data_FTipoDocumento_Actualizar", dbParams));
        }
        public static int Eliminar(Tipo_Documento tipo_documento)
        {
            SqlParameter[] dbParams = new SqlParameter[]
                {
                    FDBHelper.MakeParam("@id_tipo_documento", SqlDbType.Int, 0, tipo_documento.Id_tipo_documento),
               };
            return Convert.ToInt32(FDBHelper.ExecuteScalar("usp_Data_FTipoDocumento_Eliminar", dbParams));

        }
    }
}
