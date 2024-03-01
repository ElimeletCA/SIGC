using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIGC.Model
{
    public class Caja
    {
        private int _id_caja;
        private int _id_cajero;
        private int _id_estado_caja;
        private string _descripcion;
        private string _fecha_apertura;
        private string _fecha_cierre;
        private decimal _monto_apertura;
        private decimal _monto_cierre;

        private int Id_caja
        {
            get { return _id_caja; }
            set { _id_caja = value; }
        }

        private int Id_cajero
        {
            get { return _id_cajero; }
            set { _id_cajero = value; }
        }

        private int Id_estado_caja
        {
            get { return _id_estado_caja; }
            set { _id_estado_caja = value; }
        }

        private string Descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }

        private string Fecha_apertura
        {
            get { return _fecha_apertura; }
            set { _fecha_apertura = value; }
        }

        private string Fecha_cierre
        {
            get { return _fecha_cierre; }
            set { _fecha_cierre = value; }
        }

        private decimal Monto_apertura
        {
            get { return _monto_apertura; }
            set { _monto_apertura = value; }
        }

        private decimal Monto_cierre
        {
            get { return _monto_cierre; }
            set { _monto_cierre = value; }
        }

        public Caja(int id_caja, int id_cajero, int id_estado_caja, string descripcion, string fecha_apertura, string fecha_cierre, decimal monto_apertura, decimal monto_cierre)
        {
            _id_caja = id_caja;
            _id_cajero = id_cajero;
            _id_estado_caja = id_estado_caja;
            _descripcion = descripcion;
            _fecha_apertura = fecha_apertura;
            _fecha_cierre = fecha_cierre;
            _monto_apertura = monto_apertura;
            _monto_cierre = monto_cierre;
        }
    }
}
