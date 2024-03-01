using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIGC.Model
{
    public class Empresa
    {
        private int _id_empresa;
        private string _rnc;
        private string _nombre;
        private string _direccion;
        private byte[] _logo;
        private string _telefono;
        private string _correo_electronico;
        private string _sitio_web;

        public int Id_empresa
        {
            get { return _id_empresa; }
            set { _id_empresa = value; }
        }

        public string Rnc
        {
            get { return _rnc; }
            set { _rnc = value; }
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

        public byte[] Logo
        {
            get { return _logo; }
            set { _logo = value; }
        }

        public string Telefono
        {
            get { return _telefono; }
            set { _telefono = value; }
        }

        public string Correo_electronico
        {
            get { return _correo_electronico; }
            set { _correo_electronico = value; }
        }

        public string Sitio_web
        {
            get { return _sitio_web; }
            set { _sitio_web = value; }
        }

        public Empresa(int id_empresa, string rnc, string nombre, string direccion, byte[] logo, string telefono, string correo_electronico, string sitio_web)
        {
            _id_empresa = id_empresa;
            _rnc = rnc;
            _nombre = nombre;
            _direccion = direccion;
            _logo = logo;
            _telefono = telefono;
            _correo_electronico = correo_electronico;
            _sitio_web = sitio_web;
        }
    }
}
