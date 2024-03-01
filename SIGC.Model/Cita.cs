using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIGC.Model
{
    public class Cita
    {
        private int _id_cita;
        private int _id_paciente;
        private int _id_empleado;
        private int _id_medico;
        private int _id_consultorio;
        private string _fecha_creacion;
        private string _fecha_asignada;
        private string _hora_ssignada;
        private string _descripcion_motivo;

        public int Id_cita
        {
            get { return _id_cita; }
            set { _id_cita = value; }
        }

        public int Id_paciente
        {
            get { return _id_paciente; }
            set { _id_paciente = value; }
        }

        public int Id_empleado
        {
            get { return _id_empleado; }
            set { _id_empleado = value; }
        }

        public int Id_medico
        {
            get { return _id_medico; }
            set { _id_medico = value; }
        }

        public int Id_consultorio
        {
            get { return _id_consultorio; }
            set { _id_consultorio = value; }
        }

        public string Fecha_creacion
        {
            get { return _fecha_creacion; }
            set { _fecha_creacion = value; }
        }

        public string Fecha_asignada
        {
            get { return _fecha_asignada; }
            set { _fecha_asignada = value; }
        }

        public string Hora_asignada
        {
            get { return _hora_ssignada; }
            set { _hora_ssignada = value; }
        }

        public string Descripcion_motivo
        {
            get { return _descripcion_motivo; }
            set { _descripcion_motivo = value; }
        }

        public Cita(int id_cita, int id_paciente, int id_empleado, int id_medico, int id_consultorio, string fecha_creacion, string fecha_asignada, string hora_ssignada, string descripcion_motivo)
        {
            _id_cita = id_cita;
            _id_paciente = id_paciente;
            _id_empleado = id_empleado;
            _id_medico = id_medico;
            _id_consultorio = id_consultorio;
            _fecha_creacion = fecha_creacion;
            _fecha_asignada = fecha_asignada;
            _hora_ssignada = hora_ssignada;
            _descripcion_motivo = descripcion_motivo;
        }
    }
}
