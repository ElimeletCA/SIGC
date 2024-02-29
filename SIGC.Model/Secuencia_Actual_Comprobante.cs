using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIGC.Model
{
    public class Secuencia_Actual_Comprobante
    {
        private int _id_secuencia_actual_comprobante;
        private int _id_rango_comprobante;
        private int _numero_secuencia;

        public int Id_secuencia_actual_comprobante
        {
            get { return _id_secuencia_actual_comprobante; }
            set { _id_secuencia_actual_comprobante = value; }
        }

        public int Id_rango_comprobante
        {
            get { return _id_rango_comprobante; }
            set { _id_rango_comprobante = value; }
        }

        public int Numero_secuencia
        {
            get { return _numero_secuencia; }
            set { _numero_secuencia = value; }
        }

        public Secuencia_Actual_Comprobante(int id_secuencia_actual_comprobante, int id_rango_comprobante, int numero_secuencia)
        {
            _id_secuencia_actual_comprobante = id_secuencia_actual_comprobante;
            _id_rango_comprobante = id_rango_comprobante;
            _numero_secuencia = numero_secuencia;
        }
    }
}
