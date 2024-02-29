using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIGC.Model
{
    public class Consultorio
    {
        private int _id_consultorio;
        private string _nombre;
        private string _locacion;

        public int Id_consultorio 
        { 
            get {  return _id_consultorio; } 
            set {  _id_consultorio = value;} 
        }

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public string Locacion
        {
            get { return _locacion; }
            set { _locacion = value; }
        }

        public Consultorio(int id_consultorio, string nombre, string locacion)
        {
            _id_consultorio = id_consultorio;
            _nombre = nombre;
            _locacion = locacion;
        }
    }
}
