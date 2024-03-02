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
    public class FDepartamento
    {
        public static DataSet GetAll()
        {
            SqlParameter[] dbParams = new SqlParameter[]
                {
                };
            return FDBHelper.ExecuteDataSet("usp_Data_FDepartamento_GetAll", dbParams);

        }
        public static int Insertar(Departamento departamento)
        {
            SqlParameter[] dbParams = new SqlParameter[]
                {
                   FDBHelper.MakeParam("@nombre", SqlDbType.VarChar, 0, departamento.Nombre),
                   FDBHelper.MakeParam("@descripcion", SqlDbType.VarChar, 0, departamento.Descripcion)

                };
            return Convert.ToInt32(FDBHelper.ExecuteScalar("usp_Data_FDepartamento_Insertar", dbParams));

        }
        public static int Actualizar(Departamento departamento)
        {
            SqlParameter[] dbParams = new SqlParameter[]
                {
                   FDBHelper.MakeParam("@id_departamento", SqlDbType.Int, 0, departamento.Id_departamento),
                   FDBHelper.MakeParam("@nombre", SqlDbType.VarChar, 0, departamento.Nombre),
                   FDBHelper.MakeParam("@descripcion", SqlDbType.VarChar, 0, departamento.Descripcion)
                };
            return Convert.ToInt32(FDBHelper.ExecuteScalar("usp_Data_FDepartamento_Actualizar", dbParams));

        }
        public static int Eliminar(Departamento departamento)
        {
            SqlParameter[] dbParams = new SqlParameter[]
                {
                   FDBHelper.MakeParam("@id_departamento", SqlDbType.Int, 0, departamento.Id_departamento)
               };
            return Convert.ToInt32(FDBHelper.ExecuteScalar("usp_Data_FDepartamento_Eliminar", dbParams));

        }
    }
}
