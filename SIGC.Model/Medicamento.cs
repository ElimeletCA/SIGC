using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIGC.Model
{
    public class Medicamento
    {
        private int _id_medicamento;
        private string _nombre;
        private string _descripcion;

        public int Id_medicamento 
        { 
            get {  return _id_medicamento; } 
            set {  _id_medicamento = value;} 
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

        public Medicamento(int id_medicamento, string nombre, string descripcion)
        {
            _id_medicamento = id_medicamento;
            _nombre = nombre;
            _descripcion = descripcion;
        }
    }
}
