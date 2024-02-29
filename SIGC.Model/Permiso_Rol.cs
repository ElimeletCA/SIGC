using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIGC.Model
{
    public class Permiso_Rol
    {
        private int _id_permiso;
        private int _id_rol;

        public int Id_permiso
        {
            get { return _id_permiso; }
            set { _id_permiso = value; }
        }

        public int Id_rol
        {
            get { return _id_rol; }
            set { _id_rol = value; }
        }

        public Permiso_Rol(int id_permiso, int id_rol)
        {
            _id_permiso = id_permiso;
            _id_rol =id_rol;
        }
    }
}
