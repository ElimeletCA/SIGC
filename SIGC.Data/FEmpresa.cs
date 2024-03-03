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
    public class FEmpresa
    {
        public static DataSet GetAll()
        {
            SqlParameter[] dbParams = new SqlParameter[]
                {
                };
            return FDBHelper.ExecuteDataSet("usp_Data_FEmpresa_GetAll", dbParams);

        }
        public static int Insertar(Empresa empresa)
        {
            SqlParameter[] dbParams = new SqlParameter[]
                {
                    FDBHelper.MakeParam("@Rnc", SqlDbType.VarChar, 0, empresa.Rnc),
                    FDBHelper.MakeParam("@Nombre", SqlDbType.VarChar, 0, empresa.Nombre),
                    FDBHelper.MakeParam("@Direccion", SqlDbType.VarChar, 0, empresa.Direccion),
                    FDBHelper.MakeParam("@Logo", SqlDbType.Image, 0, empresa.Logo),
                    FDBHelper.MakeParam("@Telefono", SqlDbType.VarChar, 0, empresa.Telefono),
                    FDBHelper.MakeParam("@Correo_electronico", SqlDbType.VarChar, 0, empresa.Correo_electronico),
                    FDBHelper.MakeParam("@Sitio_web", SqlDbType.VarChar, 0, empresa.Sitio_web)
                };
            return Convert.ToInt32(FDBHelper.ExecuteScalar("usp_Data_FEmpresa_Insertar", dbParams));

        }
        public static int Actualizar(Empresa empresa)
        {
            SqlParameter[] dbParams = new SqlParameter[]
                {
                    FDBHelper.MakeParam("@Id_empresa", SqlDbType.Int, 0, empresa.Id_empresa),
                    FDBHelper.MakeParam("@Rnc", SqlDbType.VarChar, 0, empresa.Rnc),
                    FDBHelper.MakeParam("@Nombre", SqlDbType.VarChar, 0, empresa.Nombre),
                    FDBHelper.MakeParam("@Direccion", SqlDbType.VarChar, 0, empresa.Direccion),
                    FDBHelper.MakeParam("@Logo", SqlDbType.Image, 0, empresa.Logo),
                    FDBHelper.MakeParam("@Telefono", SqlDbType.VarChar, 0, empresa.Telefono),
                    FDBHelper.MakeParam("@Correo_electronico", SqlDbType.VarChar, 0, empresa.Correo_electronico),
                    FDBHelper.MakeParam("@Sitio_web", SqlDbType.VarChar, 0, empresa.Sitio_web)
                };
            return Convert.ToInt32(FDBHelper.ExecuteScalar("usp_Data_FEmpresa_Actualizar", dbParams));

        }
        public static int Eliminar(Empresa empresa)
        {
            SqlParameter[] dbParams = new SqlParameter[]
                {
                    FDBHelper.MakeParam("@Id_empresa", SqlDbType.Int, 0, empresa.Id_empresa)
               };
            return Convert.ToInt32(FDBHelper.ExecuteScalar("usp_Data_FEmpresa_Eliminar", dbParams));

        }
    }
}
