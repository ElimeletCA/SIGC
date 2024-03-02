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
    public class FEspecialidadmedica
    {
        public static DataSet GetAll()
        {
            SqlParameter[] dbParams = new SqlParameter[]
                {
                };
            return FDBHelper.ExecuteDataSet("usp_Data_FEspecialidadMedica_GetAll", dbParams);

        }
        public static int Insertar(Especialidad_Medica especialidad_medica)
        {
            SqlParameter[] dbParams = new SqlParameter[]
                {
                   FDBHelper.MakeParam("@nombre", SqlDbType.VarChar, 0, especialidad_medica.Nombre),
                   FDBHelper.MakeParam("@descripcion", SqlDbType.VarChar, 0, especialidad_medica.Descripcion)

                };
            return Convert.ToInt32(FDBHelper.ExecuteScalar("usp_Data_FEspecialidadMedica_Insertar", dbParams));

        }
        public static int Actualizar(Especialidad_Medica especialidad_medica)
        {
            SqlParameter[] dbParams = new SqlParameter[]
                {
                   FDBHelper.MakeParam("@id_especialidad_medica", SqlDbType.Int, 0, especialidad_medica.Id_especialidad_medica),
                   FDBHelper.MakeParam("@nombre", SqlDbType.VarChar, 0, especialidad_medica.Nombre),
                   FDBHelper.MakeParam("@descripcion", SqlDbType.VarChar, 0, especialidad_medica.Descripcion)
                };
            return Convert.ToInt32(FDBHelper.ExecuteScalar("usp_Data_FEspecialidadMedica_Actualizar", dbParams));

        }
        public static int Eliminar(Especialidad_Medica especialidad_medica)
        {
            SqlParameter[] dbParams = new SqlParameter[]
                {
                   FDBHelper.MakeParam("@id_especialidad_medica", SqlDbType.Int, 0, especialidad_medica.Id_especialidad_medica)
               };
            return Convert.ToInt32(FDBHelper.ExecuteScalar("usp_Data_FEspecialidadMedica_Eliminar", dbParams));

        }
    }
}
