using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIGC.Model
{
    public class Disponibilidad_Medico
    {
        private int _id_disponibilidad_medico;
        private int _id_medico;
        private string _dia;
        private string _hora_inicio;
        private string _hora_fin;

        public int Id_disponibilidad_medico
        {
            get { return _id_disponibilidad_medico; }
            set { _id_disponibilidad_medico = value; }
        }

        public int Id_medico
        {
            get { return _id_medico; }
            set { _id_medico = value; }
        }

        public string Dia
        {
            get { return _dia; }
            set { _dia = value; }
        }

        public string Hora_inicio
        {
            get { return _hora_inicio; }
            set { _hora_inicio = value; }
        }

        public string Hora_fin
        {
            get { return _hora_fin; }
            set { _hora_fin = value; }
        }

        public Disponibilidad_Medico(int id_disponibilidad_medico, int id_medico, string dia, string hora_inicio, string hora_fin)
        {
            _id_disponibilidad_medico = id_disponibilidad_medico;
            _id_medico = id_medico;
            _dia = dia;
            _hora_inicio = hora_inicio;
            _hora_fin = hora_fin;
        }
    }
}
