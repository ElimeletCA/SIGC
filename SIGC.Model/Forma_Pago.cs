using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIGC.Model
{
    public class Forma_Pago
    {
        private int _id_forma_pago;
        private string _nombre_forma_pago;

        public int Id_forma_pago
        {
            get { return _id_forma_pago; }
            set { _id_forma_pago = value; }
        }

        public string Nombre_forma_pago
        {
            get { return _nombre_forma_pago; }
            set { _nombre_forma_pago = value; }
        }

        public Forma_Pago(int id_forma_pago, string nombre_forma_pago)
        {
            _id_forma_pago = id_forma_pago;
            _nombre_forma_pago = nombre_forma_pago;
        }
    }
}
