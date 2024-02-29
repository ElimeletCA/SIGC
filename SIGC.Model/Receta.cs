using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIGC.Model
{
    public class Receta
    {
        private int _id_receta;
        private int _id_consulta;
        private string _diagnostico;
        private string _fecha;

        public int Id_receta
        {
            get { return _id_receta; }
            set { _id_receta = value; }
        }

        public int Id_consulta
        {
            get { return _id_consulta; }
            set { _id_consulta = value; }
        }

        public string Diagnostico
        {
            get { return _diagnostico; }
            set { _diagnostico = value; }
        }

        public string Fecha
        {
            get { return _fecha; }
            set { _fecha = value; }
        }

        public Receta(int id_receta, int id_consulta, string diagnostico, string fecha)
        {
            _id_receta = id_receta;
            _id_consulta = id_consulta;
            _diagnostico = diagnostico;
            _fecha = fecha;
        }
    }
}
