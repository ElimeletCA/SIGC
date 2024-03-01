using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIGC.Model
{
    public class Rango_Comprobante
    {
        private int _id_rango_comprobante;
        private int _id_tipo_comprobante;
        private int _numero_inicio;
        private int _numero_fin;
        private string _fecha_vencimineto;

        public int Id_rango_comprobante
        {
            get { return _id_rango_comprobante; }
            set { _id_rango_comprobante = value; }
        }

        public int Id_tipo_comprobante
        {
            get { return _id_tipo_comprobante; }
            set { _id_tipo_comprobante = value; }
        }

        public int Numero_inicio
        {
            get { return _numero_inicio; }
            set { _numero_inicio = value; }
        }

        public int Numero_fin
        {
            get { return _numero_fin; }
            set { _numero_fin = value; }
        }

        public string Fecha_vencimiento
        {
            get { return _fecha_vencimineto; }
            set { _fecha_vencimineto = value; }
        }

        public Rango_Comprobante(int id_rango_comprobante, int id_tipo_comprobante, int numero_inicio, int numero_fin, string fecha_vencimiento)
        {
            _id_rango_comprobante = id_rango_comprobante;
            _id_tipo_comprobante = id_tipo_comprobante;
            _numero_inicio = numero_inicio;
            _numero_fin = numero_fin;
            _fecha_vencimineto = fecha_vencimiento;
        }
    }
}
