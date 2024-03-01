using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIGC.Model
{
    public class Tipo_Comprobante
    {
        private int _id_tipo_comprobante;
        private string _nombre;

        public int Id_tipo_comprobante
        {
            get { return _id_tipo_comprobante; }
            set { _id_tipo_comprobante = value; }
        }

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public Tipo_Comprobante(int id_tipo_comprobante, string nombre)
        {
            _id_tipo_comprobante = id_tipo_comprobante;
            _nombre = nombre;
        }
    }
}
