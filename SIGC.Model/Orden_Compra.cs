using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIGC.Model
{
    public class Orden_Compra
    {
        private int _id_orden_compra;
        private int _id_tipo_orden_compra;
        private int _id_proveedor;
        private int _id_empleado;
        private int _id_forma_pago;
        private int _numero_comprobante;
        private decimal _monto_total_impuesto;
        private decimal _monto_total;
        private string _fecha;
        private string _nota;

        public int Id_orden_compra
        {
            get { return _id_orden_compra; }
            set { _id_orden_compra = value; }
        }

        public int Id_tipo_orden_compra
        {
            get { return _id_tipo_orden_compra; }
            set { _id_tipo_orden_compra = value; }
        }

        public int Id_proveedor
        {
            get { return _id_proveedor; }
            set { _id_proveedor = value; }
        }

        public int Id_empleado
        {
            get { return _id_empleado; }
            set { _id_empleado = value; }
        }

        public int Id_forma_pago
        {
            get { return _id_forma_pago; }
            set { _id_forma_pago = value; }
        }

        public int Numero_comprobante
        {
            get { return _numero_comprobante; }
            set { _numero_comprobante = value; }
        }

        public decimal Monto_total_impuesto
        {
            get { return _monto_total_impuesto; }
            set { _monto_total_impuesto = value; }
        }

        public decimal Monto_total
        {
            get { return _monto_total; }
            set { _monto_total = value; }
        }

        public string Fecha
        {
            get { return _fecha; }
            set { _fecha = value; }
        }

        public string Nota
        {
            get { return _nota; }
            set { _nota = value; }
        }

        public Orden_Compra(int id_orden_compra, int id_tipo_orden_compra, int id_proveedor, int id_empleado, int id_forma_pago, int numero_comprobante, decimal monto_total_impuesto, decimal monto_total, string fecha, string nota)
        {
            _id_orden_compra = id_orden_compra;
            _id_tipo_orden_compra = id_tipo_orden_compra;
            _id_proveedor = id_proveedor;
            _id_empleado = id_empleado;
            _id_forma_pago = id_forma_pago;
            _numero_comprobante = numero_comprobante;
            _monto_total_impuesto = monto_total_impuesto;
            _monto_total = monto_total;
            _fecha = fecha;
            _nota = nota;
        }
    }
}
