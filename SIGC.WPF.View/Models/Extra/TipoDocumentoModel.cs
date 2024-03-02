using SIGC.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIGC.WPF.View.Models.Extra
{
    public class TipoDocumentoModel
    {
        public static DataTable GetTipoDocumentoDataTable()
        {
            try
            {
                DataSet DataSetTipoDocumento = FTipodocumento.GetAll();
                if (DataSetTipoDocumento.Tables[0].Rows.Count > 0)
                {
                    return DataSetTipoDocumento.Tables[0];
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
    }
}
