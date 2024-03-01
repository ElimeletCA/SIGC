using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIGC.Model
{
    public class Modulo
    {
        private int _id_modulo;
        private string _nombre;
        private string _descripcion;

        public int Id_modulo
        {
            get { return _id_modulo; }
            set { _id_modulo = value; }
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

        public Modulo(int id_modulo, string nombre, string descripcion)
        {
            _id_modulo = id_modulo;
            _nombre = nombre;
            _descripcion = descripcion;
        }
    }
}
