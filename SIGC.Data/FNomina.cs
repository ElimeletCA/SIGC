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
    public class FNominas
    {
        public static DataSet GetAll()
        {
            SqlParameter[] dbParams = new SqlParameter[]
            {
                };
            return FDBHelper.ExecuteDataSet("usp_Data_FNomina_GetAll", dbParams);

        }
        public static int Insertar(Nomina nomina)
        {
            SqlParameter[] dbParams = new SqlParameter[]
            {
                    FDBHelper.MakeParam("@Id_empleado", SqlDbType.Int, 0, nomina.Id_empleado),
                    FDBHelper.MakeParam("@Monto_deduccion", SqlDbType.Decimal, 0, nomina.Monto_deduccion),
                    FDBHelper.MakeParam("@Nota_deduccion", SqlDbType.VarChar, 0, nomina.Nota_deduccion),
                    FDBHelper.MakeParam("@Monto_bonificacion", SqlDbType.Decimal, 0, nomina.Monto_bonificacion),
                    FDBHelper.MakeParam("@Nota_bonificacion", SqlDbType.VarChar, 0, nomina.Nota_bonificacion),
                    FDBHelper.MakeParam("@Sueldo_neto", SqlDbType.Decimal, 0, nomina.Sueldo_neto)
                };
            return Convert.ToInt32(FDBHelper.ExecuteScalar("usp_Data_FNomina_Insertar", dbParams));

        }
        public static int Actualizar(Nomina nomina)
        {
            SqlParameter[] dbParams = new SqlParameter[]
            {
                    FDBHelper.MakeParam("@id_nomina", SqlDbType.Int, 0, nomina.Id_nomina),
                    FDBHelper.MakeParam("@Id_empleado", SqlDbType.Int, 0, nomina.Id_empleado),
                    FDBHelper.MakeParam("@Monto_deduccion", SqlDbType.Decimal, 0, nomina.Monto_deduccion),
                    FDBHelper.MakeParam("@Nota_deduccion", SqlDbType.VarChar, 0, nomina.Nota_deduccion),
                    FDBHelper.MakeParam("@Monto_bonificacion", SqlDbType.Decimal, 0, nomina.Monto_bonificacion),
                    FDBHelper.MakeParam("@Nota_bonificacion", SqlDbType.VarChar, 0, nomina.Nota_bonificacion),
                    FDBHelper.MakeParam("@Sueldo_neto", SqlDbType.Decimal, 0, nomina.Sueldo_neto)
                };
            return Convert.ToInt32(FDBHelper.ExecuteScalar("usp_Data_FNomina_Actualizar", dbParams));

        }
        public static int Eliminar(Nomina nomina)
        {
            SqlParameter[] dbParams = new SqlParameter[]
            {
                    FDBHelper.MakeParam("@Id_nomina", SqlDbType.Int, 0, nomina.Id_nomina)
               };
            return Convert.ToInt32(FDBHelper.ExecuteScalar("usp_Data_FNomina_Eliminar", dbParams));

        }
    }
}

