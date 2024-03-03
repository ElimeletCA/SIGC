using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIGC.Model
{
    public class Producto
    {
        private int _id_producto;
        private int _id_categoria;
        private string _nombre;
        private decimal _precio_costo;
        private decimal _precio_venta;
        private int _cantidad_disponible;
        private byte[] _imagen_producto;


        public int Id_producto
        {
            get { return _id_producto; }
            set { _id_producto = value; }
        }

        public int Id_categoria
        {
            get { return _id_categoria; }
            set { _id_categoria = value; }
        }

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public decimal Precio_costo
        {
            get { return _precio_costo; }
            set { _precio_costo = value; }
        }

        public decimal Precio_venta
        {
            get { return _precio_venta; }
            set { _precio_venta = value; }
        }

        public int Cantidad_disponible
        {
            get { return _cantidad_disponible; }
            set { _cantidad_disponible = value; }
        }
        public byte[] Imagen_producto
        {
            get { return _imagen_producto; }
            set { _imagen_producto = value; }
        }

        public Producto(int id_producto, int id_categoria, string nombre, decimal precio_costo, decimal precio_venta, int cantidad_disponible, byte[] imagen_producto)
        {
            _id_producto = id_producto;
            _id_categoria = id_categoria;
            _nombre = nombre;
            _precio_costo = precio_costo;
            _precio_venta = precio_venta;
            _cantidad_disponible = cantidad_disponible;
            _imagen_producto = imagen_producto;
        }

    }
}
