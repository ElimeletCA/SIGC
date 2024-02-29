using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIGC.Model
{
    public class Usuario
    {
        private int _id_usuario;
        private int _id_empleado;
        private int _id_rol;
        private string _nombre_usuario;
        private string _contrasena;
        private string _fecha_ultimo_acceso;

        public int Id_usuario
        {
            get { return _id_usuario; }
            set { _id_usuario = value; }
        }

        public int Id_empleado
        {
            get { return _id_empleado; }
            set { _id_empleado = value; }
        }

        public int Id_rol
        {
            get { return _id_rol; }
            set { _id_rol = value; }
        }

        public string Nombre_usuario
        {
            get { return _nombre_usuario; }
            set { _nombre_usuario = value; }
        }

        public string Contrasena
        {
            get { return _contrasena; }
            set { _contrasena = value; }
        }

        public string Fecha_ultimo_acceso
        {
            get { return _fecha_ultimo_acceso; }
            set { _fecha_ultimo_acceso = value; }
        }

        public Usuario(int id_usuario, int id_empleado, int id_rol, string nombre_usuario, string contrasena, string fecha_ultimo_acceso)
        {
            _id_usuario = id_usuario;
            _id_empleado = id_empleado;
            _id_rol = id_rol;
            _nombre_usuario = nombre_usuario;
            _contrasena = contrasena;
            _fecha_ultimo_acceso = fecha_ultimo_acceso;
        }
    }
}
