using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIGC.Model
{
    public class Tipo_Factura
    {
        private int _id_tipo_factura;
        private string _nombre_tipo_factura;

        public int Id_tipo_factura
        {
            get { return _id_tipo_factura; }
            set { _id_tipo_factura = value; }
        }

        public string Nombre_tipo_factura
        {
            get { return _nombre_tipo_factura; }
            set { _nombre_tipo_factura = value; }
        }

        public Tipo_Factura(int id_tipo_factura, string nombre_tipo_factura) 
        { 
            _id_tipo_factura = id_tipo_factura;
            _nombre_tipo_factura = nombre_tipo_factura;
        }
    }
}
