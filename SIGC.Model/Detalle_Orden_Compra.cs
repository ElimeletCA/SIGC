using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIGC.Model
{
    public class Detalle_Orden_Compra
    {
        private int _id_detalle_orden_compra;
        private int _id_orden_compra;
        private int _id_producto;
        private int _cantidad;
        private decimal _precio_unitario;

        public int Id_detalle_orden_compra
        {
            get { return _id_detalle_orden_compra; }
            set { _id_detalle_orden_compra = value; }
        }

        public int Id_orden_compra
        {
            get { return _id_orden_compra; }
            set { _id_orden_compra = value; }
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

        public Detalle_Orden_Compra(int id_detalle_orden_compra, int id_orden_compra, int id_producto, int cantidad, decimal precio_unitario)
        {
            _id_detalle_orden_compra = id_detalle_orden_compra;
            _id_orden_compra = id_orden_compra;
            _id_producto = id_producto;
            _cantidad = cantidad;
            _precio_unitario = precio_unitario;
        }
    }
}
