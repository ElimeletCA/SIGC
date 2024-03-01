using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIGC.Model
{
    public class Permiso
    {
        private int _id_permiso;
        private string _nombre;
        private string _descripcion;

        public int Id_permiso
        {
            get { return _id_permiso; }
            set { _id_permiso = value; }
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

        public Permiso(int id_permiso, string nombre, string descripcion)
        {
            _id_permiso = id_permiso;
            _nombre = nombre;
            _descripcion = descripcion;
        }
    }
}
