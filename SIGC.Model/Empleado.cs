using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIGC.Model
{
    public class Empleado
    {
        private int _id_empleado;
        private int _id_departamento;
        private int _id_puesto;
        private string _cedula;
        private string _nombre;
        private string _apellido;
        private string _sexo;
        private string _telefono;
        private string _direccion;
        private string _fecha_nacimiento;
        private string _fecha_contratacion;
        private decimal _sueldo_bruto;
        private string _nota;

        public int Id_empleado
        {
            get { return _id_empleado; }
            set { _id_empleado = value; }
        }

        public int Id_departamento
        {
            get { return _id_departamento; }
            set { _id_departamento = value; }
        }

        public int Id_puesto
        {
            get { return _id_puesto; }
            set { _id_puesto = value; }
        }

        public string Cedula
        {
            get { return _cedula; }
            set { _cedula = value; }
        }

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public string Apellido
        {
            get { return _apellido; }
            set { _apellido = value; }
        }

        public string Sexo
        {
            get { return _sexo; }
            set { _sexo = value; }
        }

        public string Telefono
        {
            get { return _telefono; }
            set { _telefono = value; }
        }

        public string Direccion
        {
            get { return _direccion; }
            set { _direccion = value; }
        }

        public string Fecha_nacimiento
        {
            get { return _fecha_nacimiento; }
            set { _fecha_nacimiento = value; }
        }

        public string Fecha_Contratacion
        {
            get { return _fecha_contratacion; }
            set { _fecha_contratacion = value; }
        }

        public decimal Sueldo_bruto
        {
            get { return _sueldo_bruto; }
            set { _sueldo_bruto = value; }
        }

        public string Nota
        {
            get { return _nota; }
            set { _nota = value; }
        }

        public Empleado(int id_empleado, int id_departamento, int id_puesto, string cedula, string nombre, string apellido, string sexo, string telefono, string direccion, string fecha_nacimiento, string fecha_contratacion, decimal sueldo_bruto, string nota)
        {
            _id_empleado = id_empleado;
            _id_departamento = id_departamento;
            _id_puesto = id_puesto;
            _cedula = cedula;
            _nombre = nombre;
            _apellido = apellido;
            _sexo = sexo;
            _telefono = telefono;
            _direccion = direccion;
            _fecha_nacimiento = fecha_nacimiento;
            _fecha_contratacion = fecha_contratacion;
            _sueldo_bruto = sueldo_bruto;
            _nota = nota;
        }

    }
}
