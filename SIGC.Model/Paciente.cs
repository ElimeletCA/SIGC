using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIGC.Model
{
    public class Paciente
    {
        private int _id_paciente;
        private int _id_cliente;
        private int _id_seguro;
        private string _numero_seguro;
        private string _fecha_nacimiento;
        private string _altura_paciente;
        private string _peso_paciente;
        private byte[] _foto_paciente;

        public int Id_paciente
        {
            get { return _id_paciente; }
            set { _id_paciente = value; }
        }

        public int Id_cliente
        {
            get { return _id_cliente; }
            set { _id_cliente = value; }
        }

        public int Id_seguro
        {
            get { return _id_seguro; }
            set { _id_seguro = value; }
        }

        public string Numero_seguro
        {
            get { return _numero_seguro; }
            set { _numero_seguro = value; }
        }

        public string Fecha_nacimiento
        {
            get { return _fecha_nacimiento; }
            set { _fecha_nacimiento = value; }
        }

        public string Altura_paciente
        {
            get { return _altura_paciente; }
            set { _altura_paciente = value; }
        }

        public string Peso_paciente
        {
            get { return _peso_paciente; }
            set { _peso_paciente = value; }
        }
        public byte[] Foto_paciente
        {
            get { return _foto_paciente; }
            set { _foto_paciente = value; }
        }

        public Paciente(int id_paciente, int id_cliente, int id_seguro, string numero_seguro, string fecha_nacimiento, string altura_paciente, string peso_paciente, byte[] foto_paciente)
        {
            _id_paciente = id_paciente;
            _id_cliente = id_cliente;
            _id_seguro = id_seguro;
            _numero_seguro = numero_seguro;
            _fecha_nacimiento = fecha_nacimiento;
            _altura_paciente = altura_paciente;
            _peso_paciente = peso_paciente;
            _foto_paciente = foto_paciente;
        }
    }
}
