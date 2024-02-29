using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIGC.Model
{
    public class Rol
    {
        private int _id_rol;
        private string _nombre;
        private string _descripcion;

        public int Id_rol
        {
            get { return _id_rol; }
            set { _id_rol = value; }
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

        public Rol(int id_rol, string nombre, string descripcion)
        {
            _id_rol = id_rol;
            _nombre = nombre;
            _descripcion = descripcion;
        }
    }
}
