using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIGC.Model
{
    public  class Especialidad_Medica
    {
        private int _id_especialidad_medica;
        private string _nombre;
        private string _descripcion;

        public int Id_especialidad_medica
        {
            get { return _id_especialidad_medica; }
            set { _id_especialidad_medica = value; }
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

        public Especialidad_Medica(int id_especialidad_medica, string nombre, string descripcion)
        {
            _id_especialidad_medica = id_especialidad_medica;
            _nombre = nombre;
            _descripcion = descripcion;
        }
    }
}
