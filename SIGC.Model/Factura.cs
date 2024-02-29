using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIGC.Model
{
    public class Factura
    {
        private int _id_factura;
        private int _id_caja;
        private int _id_tipo_factura;
        private int _id_tipo_comprobante;
        private int _id_cliente;
        private int _id_estado_factura;
        private int _id_forma_pago;
        private string _fecha;
        private string _numero_comprobante;
        private string _nota_factura;
        private decimal _monto_total_impuesto;
        private decimal _monto_total;
        private int _numero_trasaccion_forma_pago;

        public int Id_factura
        {
            get { return _id_factura; }
            set { _id_factura = value; }
        }

        public int Id_caja
        {
            get { return _id_caja; }
            set { _id_caja = value; }
        }

        public int Id_tipo_factura
        {
            get { return _id_tipo_factura; }
            set { _id_tipo_factura = value; }
        }

        public int Id_tipo_comprobante
        {
            get { return _id_tipo_comprobante; }
            set { _id_tipo_comprobante = value; }
        }

        public int Id_cliente
        {
            get { return _id_cliente; }
            set { _id_cliente = value; }
        }

        public int Id_estado_factura
        {
            get { return _id_estado_factura; }
            set { _id_estado_factura = value; }
        }

        public int Id_forma_pago
        {
            get { return _id_forma_pago; }
            set { _id_forma_pago = value; }
        }

        public string Fecha
        {
            get { return _fecha; }
            set { _fecha = value; }
        }

        public string Numero_comprobante
        {
            get { return _numero_comprobante; }
            set { _numero_comprobante = value; }
        }

        public string Nota_factura
        {
            get { return _nota_factura; }
            set { _nota_factura = value; }
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

        public int Numero_trasaccion_forma_pago
        {
            get { return _numero_trasaccion_forma_pago; }
            set { _numero_trasaccion_forma_pago = value; }
        }

        public Factura(int id_factura, int id_caja, int id_tipo_factura, int id_tipo_comprobante, int id_cliente, int id_estado_factura, int id_forma_pago, string fecha, string numero_comprobante, string nota_factura, decimal monto_total_impuesto, decimal monto_total, int numero_trasaccion_forma_pago)
        {
            _id_factura = id_factura;
            _id_caja = id_caja;
            _id_tipo_factura = id_tipo_factura;
            _id_tipo_comprobante = id_tipo_comprobante;
            _id_cliente = id_cliente;
            _id_estado_factura = id_estado_factura;
            _id_forma_pago = id_forma_pago;
            _fecha = fecha;
            _numero_comprobante = numero_comprobante;
            _nota_factura = nota_factura;
            _monto_total_impuesto = monto_total_impuesto;
            _monto_total = monto_total;
            _numero_trasaccion_forma_pago = numero_trasaccion_forma_pago;
        }
    }
}
