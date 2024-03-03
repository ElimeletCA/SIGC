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
    public class FPaciente

    {
        public static DataSet GetAll()
        {
            SqlParameter[] dbParams = new SqlParameter[]
            {
                };
            return FDBHelper.ExecuteDataSet("usp_Data_FPaciente_GetAll", dbParams);

        }
        public static int Insertar(Paciente paciente)
        {
            SqlParameter[] dbParams = new SqlParameter[]
            {
                    FDBHelper.MakeParam("@Id_cliente", SqlDbType.Int, 0, paciente.Id_cliente),
                    FDBHelper.MakeParam("@Id_seguro", SqlDbType.Decimal, 0, paciente.Id_seguro),
                    FDBHelper.MakeParam("@Numero_seguro", SqlDbType.VarChar, 0, paciente.Numero_seguro),
                    FDBHelper.MakeParam("@Fecha_nacimiento", SqlDbType.Decimal, 0, paciente.Fecha_nacimiento),
                    FDBHelper.MakeParam("@Altura_paciente", SqlDbType.VarChar, 0, paciente.Altura_paciente),
                    FDBHelper.MakeParam("@Peso_paciente", SqlDbType.Decimal, 0, paciente.Peso_paciente),
                    FDBHelper.MakeParam("@Foto_paciente", SqlDbType.Decimal, 0, paciente.Foto_paciente)

                };
            return Convert.ToInt32(FDBHelper.ExecuteScalar("usp_Data_FPaciente_Insertar", dbParams));

        }
        public static int Actualizar(Paciente paciente)
        {
            SqlParameter[] dbParams = new SqlParameter[]
            {
                    FDBHelper.MakeParam("@Id_paciente", SqlDbType.Int, 0, paciente.Id_paciente),
                    FDBHelper.MakeParam("@Id_cliente", SqlDbType.Int, 0, paciente.Id_cliente),
                    FDBHelper.MakeParam("@Id_seguro", SqlDbType.Decimal, 0, paciente.Id_seguro),
                    FDBHelper.MakeParam("@Numero_seguro", SqlDbType.VarChar, 0, paciente.Numero_seguro),
                    FDBHelper.MakeParam("@Fecha_nacimiento", SqlDbType.Decimal, 0, paciente.Fecha_nacimiento),
                    FDBHelper.MakeParam("@Altura_paciente", SqlDbType.VarChar, 0, paciente.Altura_paciente),
                    FDBHelper.MakeParam("@Peso_paciente", SqlDbType.Decimal, 0, paciente.Peso_paciente),
                    FDBHelper.MakeParam("@Foto_paciente", SqlDbType.Decimal, 0, paciente.Foto_paciente)
                };
            return Convert.ToInt32(FDBHelper.ExecuteScalar("usp_Data_FPaciente_Actualizar", dbParams));

        }
        public static int Eliminar(Paciente paciente)
        {
            SqlParameter[] dbParams = new SqlParameter[]
            {
                    FDBHelper.MakeParam("@Id_paciente", SqlDbType.Int, 0, paciente.Id_paciente)
               };
            return Convert.ToInt32(FDBHelper.ExecuteScalar("usp_Data_FPaciente_Eliminar", dbParams));

        }
    }
}

