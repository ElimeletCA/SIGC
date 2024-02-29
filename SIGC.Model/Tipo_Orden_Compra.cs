using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIGC.Model
{
    public class Tipo_Orden_Compra
    {
        private int _id_tipo_orden_compra;
        private string _nombre_tipo_orden_compra;

        public int Id_tipo_orden_compra
        { 
            get { return _id_tipo_orden_compra; }
            set { _id_tipo_orden_compra = value; } 
        }

        public string Nombre_tipo_orden_compra
        {
            get { return _nombre_tipo_orden_compra; }
            set { _nombre_tipo_orden_compra= value; }
        }

        public Tipo_Orden_Compra(int id_tipo_orden_compra, string nombre_tipo_orden_compra)
        {
            _id_tipo_orden_compra = id_tipo_orden_compra;
            _nombre_tipo_orden_compra = nombre_tipo_orden_compra;
        }
    }
}
