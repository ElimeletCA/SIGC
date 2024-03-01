using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIGC.Model
{
    public class Categoria
    {
        private int _id_categoria;
        private string _nombre;
        private string _descripcion;

        public int Id_categoria
        {
            get { return _id_categoria; }
            set { _id_categoria = value; }
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

        public Categoria(int id_categoria, string nombre, string descripcion)
        {
            _id_categoria = id_categoria;
            _nombre = nombre;
            _descripcion = descripcion;
        }
    }
}
