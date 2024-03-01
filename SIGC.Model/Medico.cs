using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIGC.Model
{
    public class Medico
    {
        private int _id_medico;
        private int _id_empleado;
        private int _id_especialidad_medica;
        private string _numero_exequatur;

        public int Id_medico
        {
            get { return _id_medico; }
            set { _id_medico = value; }
        }

        public int Id_empleado
        {
            get { return _id_empleado; }
            set { _id_empleado = value; }
        }

        public int Id_especialidad_medica
        {
            get { return _id_especialidad_medica; }
            set { _id_especialidad_medica = value; }
        }

        public string Numero_exequatur
        {
            get { return _numero_exequatur; }
            set { _numero_exequatur = value; }
        }

        public Medico(int id_medico, int id_empleado, int id_especialidad_medica, string numero_exequatur)
        {
            _id_medico = id_medico;
            _id_empleado = id_empleado;
            _id_especialidad_medica = id_especialidad_medica;
            _numero_exequatur = numero_exequatur;
        }
    }
}
