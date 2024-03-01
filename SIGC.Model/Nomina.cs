using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIGC.Model
{
    public class Nomina
    {
        private int _id_nomina;
        private int _id_empleado;
        private string _fecha_nomina;
        private decimal _monto_deduccion;
        private string _nota_deduccion;
        private decimal _monto_bonificacion;
        private string _nota_bonificacion;
        private decimal _sueldo_neto;

        public int Id_nomina
        {
            get { return _id_nomina; }
            set { _id_nomina = value; }
        }

        public int Id_empleado
        {
            get { return _id_empleado; }
            set { _id_empleado = value; }
        }

        public string Fecha_nomina
        {
            get { return _fecha_nomina; }
            set { _fecha_nomina = value; }
        }

        public decimal Monto_deduccion
        {
            get { return _monto_deduccion; }
            set { _monto_deduccion = value; }
        }

        public string Nota_deduccion
        {
            get { return _nota_deduccion; }
            set { _nota_deduccion = value; }
        }

        public decimal Monto_bonificacion
        {
            get { return _monto_bonificacion; }
            set { _monto_bonificacion = value; }
        }

        public string Nota_bonificacion
        {
            get { return _nota_bonificacion; }
            set { _nota_bonificacion = value; }
        }

        public decimal Sueldo_neto
        {
            get { return _sueldo_neto; }
            set { _sueldo_neto = value; }
        }

        public Nomina(int id_nomina, int id_empleado, string fecha_nomina, decimal monto_deduccion, string nota_deduccion, decimal monto_bonificacion, string nota_bonificacion, decimal sueldo_neto)
        {
            _id_nomina = id_nomina;
            _id_empleado = id_empleado;
            _fecha_nomina = fecha_nomina;
            _monto_deduccion = monto_deduccion;
            _nota_deduccion = nota_deduccion;
            _monto_bonificacion = monto_bonificacion;
            _nota_bonificacion = nota_bonificacion;
            _sueldo_neto = sueldo_neto;

        }

    }
}
