using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIGC.Model
{
    public class Departamento
    {
        private int _id_departamento;
        private string _nombre;
        private string _descripcion;

        public int Id_departamento
        {
            get { return _id_departamento; }
            set {  _id_departamento = value; }
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

        public Departamento(int id_departamento, string nombre, string descripcion)
        {
            _id_departamento = id_departamento;
            _nombre = nombre;
            _descripcion = descripcion;
        }
    }
}
