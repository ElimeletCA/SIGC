using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIGC.Model
{
    public class Estado_Factura
    {
        private int _id_estado_factura;
        private string _nombre;

        public int Id_estado_factura
        {
            get { return _id_estado_factura; }
            set { _id_estado_factura = value; }
        }

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public Estado_Factura(int id_estado_factura, string nombre)
        {
            _id_estado_factura = id_estado_factura;
            _nombre = nombre;
        }
    }
}
