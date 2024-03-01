using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIGC.Model
{
    public class Tipo_Documento
    {
        private int _id_tipo_documento;
        private string _nombre;

        public int Id_tipo_documento 
        { 
            get {  return _id_tipo_documento;} 
            set { _id_tipo_documento = value; }
        }

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public Tipo_Documento(int id_tipo_documento, string nombre)
        {
            _id_tipo_documento = id_tipo_documento;
            _nombre = nombre;
        }
    }
}
