using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIGC.Model
{
    public class Estado_Caja
    {
        private int _id_estado_caja;
        private string _nombre;

        public int Id_estado_caja
        {
            get { return _id_estado_caja; }
            set { _id_estado_caja = value; }
        }

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public Estado_Caja(int id_estado_caja, string nombre)
        {
            _id_estado_caja = id_estado_caja;
            _nombre = nombre;
        }
    }
}
