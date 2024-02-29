using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIGC.Model
{
    public class Cajero
    {
        private int _id_cajero;
        private int _id_empleado;
        private string _turno;

        public int Id_cajero 
        { 
            get {  return _id_cajero; } 
            set { _id_cajero = value; } 
        }

        public int Id_empleado
        {
            get { return _id_empleado; }
            set { _id_empleado = value; }
        }

        public string Turno
        {
            get { return _turno; }
            set { _turno = value; }
        }

        public Cajero(int id_cajero, int id_empleado, string turno)
        {
            _id_cajero = id_cajero;
            _id_empleado = id_empleado;
            _turno = turno;
        }
    }
}
