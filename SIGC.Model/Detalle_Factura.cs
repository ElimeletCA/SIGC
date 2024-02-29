using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIGC.Model
{
    public class Detalle_Factura
    {
        private int _id_detalle_factura;
        private int _id_factura;
        private int _id_producto;
        private int _cantidad;
        private decimal _precio_unitario;

        public int Id_detalle_factura
        {
            get { return _id_detalle_factura; }
            set { _id_detalle_factura = value; }
        }

        public int Id_factura
        {
            get { return _id_factura; }
            set { _id_factura = value; }
        }

        public int Id_producto
        {
            get { return _id_producto; }
            set { _id_producto = value; }
        }

        public int Cantidad
        {
            get { return _cantidad; }
            set { _cantidad = value; }
        }

        public decimal Precio_unitario
        {
            get { return _precio_unitario; }
            set { _precio_unitario = value; }
        }

        public Detalle_Factura(int id_detalle_factura, int id_factura, int id_producto, int cantidad, decimal precio_unitario)
        {
            _id_detalle_factura = id_detalle_factura;
            _id_factura = id_factura;
            _id_producto = id_producto;
            _cantidad = cantidad;
            _precio_unitario = precio_unitario;
        }
    }
}
