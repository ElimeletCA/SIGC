using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIGC.Model
{
    public class Producto_Proveedor
    {
        private int _id_producto;
        private int _id_proveedor;

        public int Id_producto
        {
            get { return _id_producto; }
            set { _id_producto = value; }
        }

        public int Id_proveedor 
        { 
            get {  return _id_proveedor; } 
            set {  _id_proveedor = value;} 
        }

        public Producto_Proveedor(int id_producto, int id_proveedor)
        {
            _id_producto = id_producto;
            _id_proveedor = id_proveedor;
        }
    }
}
