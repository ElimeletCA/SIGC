using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIGC.Model;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SIGC.Data
{
    public class FCliente
    {
        public static DataSet GetAll()
        {
            SqlParameter[] dbParams = new SqlParameter[]
                {
                };
            return FDBHelper.ExecuteDataSet("usp_Data_FCliente_GetAll", dbParams);

        }
        public static int Insertar(Cliente cliente)
        {
            SqlParameter[] dbParams = new SqlParameter[]
                {
                    FDBHelper.MakeParam("@nombre", SqlDbType.VarChar, 0, cliente.Nombre),
                    FDBHelper.MakeParam("@apellido", SqlDbType.VarChar, 0, cliente.Apellido),
                    FDBHelper.MakeParam("@id_tipo_documento", SqlDbType.VarChar, 0, cliente.Id_tipo_documento),
                    FDBHelper.MakeParam("@numero_documento", SqlDbType.VarChar, 0, cliente.Numero_documento),
                    FDBHelper.MakeParam("@sexo", SqlDbType.VarChar, 0, cliente.Sexo),
                    FDBHelper.MakeParam("@telefono", SqlDbType.VarChar, 0, cliente.Telefono),
                    FDBHelper.MakeParam("@direccion", SqlDbType.VarChar, 0, cliente.Direccion),
                    FDBHelper.MakeParam("@correo_electronico", SqlDbType.VarChar, 0, cliente.Correo_electronico),
                    FDBHelper.MakeParam("@nota", SqlDbType.VarChar, 0, cliente.Nota)
                };
            return Convert.ToInt32(FDBHelper.ExecuteScalar("usp_Data_FCliente_Insertar", dbParams));
        }
        public static int Actualizar(Cliente cliente)
        {
            SqlParameter[] dbParams = new SqlParameter[]
                {
                    FDBHelper.MakeParam("@id_cliente", SqlDbType.Int, 0, cliente.Id_cliente),
                    FDBHelper.MakeParam("@nombre", SqlDbType.VarChar, 0, cliente.Nombre),
                    FDBHelper.MakeParam("@apellido", SqlDbType.VarChar, 0, cliente.Apellido),
                    FDBHelper.MakeParam("@id_tipo_documento", SqlDbType.VarChar, 0, cliente.Id_tipo_documento),
                    FDBHelper.MakeParam("@numero_documento", SqlDbType.VarChar, 0, cliente.Numero_documento),
                    FDBHelper.MakeParam("@sexo", SqlDbType.VarChar, 0, cliente.Sexo),
                    FDBHelper.MakeParam("@telefono", SqlDbType.VarChar, 0, cliente.Telefono),
                    FDBHelper.MakeParam("@direccion", SqlDbType.VarChar, 0, cliente.Direccion),
                    FDBHelper.MakeParam("@correo_electronico", SqlDbType.VarChar, 0, cliente.Correo_electronico),
                    FDBHelper.MakeParam("@nota", SqlDbType.VarChar, 0, cliente.Nota)
                };
            return Convert.ToInt32(FDBHelper.ExecuteScalar("usp_Data_FCliente_Actualizar", dbParams));

        }
        public static int Eliminar(Cliente cliente)
        {
            SqlParameter[] dbParams = new SqlParameter[]
                {
                    FDBHelper.MakeParam("@id_cliente", SqlDbType.Int, 0, cliente.Id_cliente),
               };
            return Convert.ToInt32(FDBHelper.ExecuteScalar("usp_Data_FCliente_Eliminar", dbParams));

        }
    }

}
