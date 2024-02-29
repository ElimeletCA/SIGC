using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIGC.Model
{
    public class Proveedor
    {
        private int _id_proveedor;
        private int _id_tipo_documento;
        private string _numero_documento;
        private string _nombre;
        private string _direccion;
        private string _telefono;
        private string _correo_electronico;
        private string _fecha_registro;
        private string _nota;

        public int Id_proveedor
        {
            get { return _id_proveedor; }
            set { _id_proveedor = value; }
        }

        public int Id_tipo_documento
        {
            get { return _id_tipo_documento; }
            set { _id_tipo_documento = value; }
        }

        public string Numero_documento
        {
            get { return _numero_documento; }
            set { _numero_documento = value; }
        }

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public string Direccion
        {
            get { return _direccion; }
            set { _direccion = value; }
        }

        public string Telefono
        {
            get { return _telefono; }
            set { _telefono = value;}
        }

        public string Correo_electronico
        {
            get { return _correo_electronico; }
            set { _correo_electronico = value; }
        }

        public string Fecha_Registro
        {
            get { return _fecha_registro; }
            set { _fecha_registro = value; }
        }

        public string Nota
        {
            get { return _nota; }
            set { _nota = value; }
        }

        public Proveedor(int id_proveedor, int id_tipo_documento, string numero_documento, string nombre, string direccion, string telefono, string correo_electronico, string fecha_registro, string nota)
        {
            _id_proveedor = id_proveedor;
            _id_tipo_documento = id_tipo_documento;
            _numero_documento = numero_documento;
            _nombre = nombre;
            _direccion = direccion;
            _telefono = telefono;
            _correo_electronico = correo_electronico;
            _fecha_registro = fecha_registro;
            _nota = nota;
        }
    }
}
