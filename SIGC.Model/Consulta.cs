using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIGC.Model
{
    public class Consulta
    {
        private int _id_consulta;
        private int _id_cita;
        private int _id_factura;
        private string _fecha;
        private string _nota_consulta;

        public int Id_consulta
        {
            get { return _id_consulta; }
            set { _id_consulta = value; }
        }

        public int Id_cita
        {
            get { return _id_cita; }
            set { _id_cita = value; }
        }

        public int Id_factura
        {
            get { return _id_factura; }
            set { _id_factura = value; }
        }

        public string Fecha
        {
            get { return _fecha; }
            set { _fecha = value; }
        }

        public string Nota_consulta
        {
            get { return _nota_consulta; }
            set { _nota_consulta = value; }
        }

        public Consulta(int id_consulta, int id_cita, int id_factura, string fecha, string nota_consulta)
        {
            _id_consulta = id_consulta;
            _id_cita = id_cita;
            _id_factura = id_factura;
            _fecha = fecha;
            _nota_consulta = nota_consulta;
        }
    }
}
