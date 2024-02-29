using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIGC.Model
{
    public class Historial_Clinico
    {
        private int _id_historial_clinico;
        private int _id_paciente;
        private string _condicion_medica;
        private string _alergia;
        private string _cirugia;
        private string _tratamiento;
        private string _nota_historial;

        public int Id_historial_clinico
        {
            get { return _id_historial_clinico; }
            set { _id_historial_clinico = value; }
        }

        public int Id_paciente
        {
            get { return _id_paciente; }
            set { _id_paciente = value; }
        }

        public string Condicion_medica
        {
            get { return _condicion_medica; }
            set { _condicion_medica = value; }
        }

        public string Alergia
        {
            get { return _alergia; }
            set { _alergia = value; }
        }

        public string Cirugia
        {
            get { return _cirugia; }
            set { _cirugia = value; }
        }

        public string Tratamiento
        {
            get { return _tratamiento; }
            set { _tratamiento = value; }
        }

        public string Nota_historial
        {
            get { return _nota_historial; }
            set { _nota_historial = value; }
        }

        public Historial_Clinico(int id_historial_clinico, int id_paciente, string condicion_medica, string alergia, string cirugia, string tratamiento, string nota_historial)
        {
            _id_historial_clinico = id_historial_clinico;
            _id_paciente = id_paciente;
            _condicion_medica = condicion_medica;
            _alergia = alergia;
            _cirugia = cirugia;
            _tratamiento = tratamiento;
            _nota_historial = nota_historial;
        }
    }
}
