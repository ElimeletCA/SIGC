using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIGC.Model
{
    public class Seguro
    {
        private int _id_seguro;
        private string _nombre;
        private string _descripcion;

        public int Id_seguro
        {
            get { return _id_seguro; }
            set { _id_seguro = value; }
        }

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public string Descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }

        public Seguro(int id_seguro, string nombre, string descripcion)
        {
            _id_seguro = id_seguro;
            _nombre = nombre;
            _descripcion = descripcion;
        }

    }
}
