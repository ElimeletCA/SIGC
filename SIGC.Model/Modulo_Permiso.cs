using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIGC.Model
{
    public class Modulo_Permiso
    {
        private int _id_modulo;
        private int _id_permiso;

        public int Id_modulo
        {
            get { return _id_modulo; }
            set { _id_modulo = value; }
        }

        public int Id_permiso
        {
            get { return _id_permiso; }
            set { _id_permiso = value; }
        }

        public Modulo_Permiso(int id_modulo, int id_permiso)
        {
            _id_modulo = id_modulo;
            _id_permiso = id_permiso;
        }
    }
}
