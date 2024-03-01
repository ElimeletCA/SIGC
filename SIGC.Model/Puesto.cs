using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIGC.Model
{
    public class Puesto
    {
        private int _id_puesto;
        private string _nombre;
        private string _descripcion;

        public int Id_puesto
        {
            get { return _id_puesto; }
            set { _id_puesto = value; }
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

        public Puesto(int id_puesto, string nombre, string descripcion)
        {
            _id_puesto = id_puesto;
            _nombre = nombre;
            _descripcion = descripcion;
        }
    }
}
