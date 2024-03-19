using System.ComponentModel;

namespace SIGC.Model
{
    public class Empleado : INotifyPropertyChanged
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
        private byte[] _foto_empleado;

        public int Id_empleado
        {
            get { return _id_empleado; }
            set
            {
                if (_id_empleado != value)
                {
                    _id_empleado = value;
                    OnPropertyChanged("Id_empleado");
                }
            }
        }

        public int Id_departamento
        {
            get { return _id_departamento; }
            set
            {
                if (_id_departamento != value)
                {
                    _id_departamento = value;
                    OnPropertyChanged("Id_departamento");
                }
            }
        }

        public int Id_puesto
        {
            get { return _id_puesto; }
            set
            {
                if (_id_puesto != value)
                {
                    _id_puesto = value;
                    OnPropertyChanged("Id_puesto");
                }
            }
        }

        public string Cedula
        {
            get { return _cedula; }
            set
            {
                if (_cedula != value)
                {
                    _cedula = value;
                    OnPropertyChanged("Cedula");
                }
            }
        }

        public string Nombre
        {
            get { return _nombre; }
            set
            {
                if (_nombre != value)
                {
                    _nombre = value;
                    OnPropertyChanged("Nombre");
                }
            }
        }

        public string Apellido
        {
            get { return _apellido; }
            set
            {
                if (_apellido != value)
                {
                    _apellido = value;
                    OnPropertyChanged("Apellido");
                }
            }
        }

        public string Sexo
        {
            get { return _sexo; }
            set
            {
                if (_sexo != value)
                {
                    _sexo = value;
                    OnPropertyChanged("Sexo");
                }
            }
        }

        public string Telefono
        {
            get { return _telefono; }
            set
            {
                if (_telefono != value)
                {
                    _telefono = value;
                    OnPropertyChanged("Telefono");
                }
            }
        }

        public string Direccion
        {
            get { return _direccion; }
            set
            {
                if (_direccion != value)
                {
                    _direccion = value;
                    OnPropertyChanged("Direccion");
                }
            }
        }

        public string Fecha_nacimiento
        {
            get { return _fecha_nacimiento; }
            set
            {
                if (_fecha_nacimiento != value)
                {
                    _fecha_nacimiento = value;
                    OnPropertyChanged("Fecha_nacimiento");
                }
            }
        }

        public string Fecha_Contratacion
        {
            get { return _fecha_contratacion; }
            set
            {
                if (_fecha_contratacion != value)
                {
                    _fecha_contratacion = value;
                    OnPropertyChanged("Fecha_Contratacion");
                }
            }
        }

        public decimal Sueldo_bruto
        {
            get { return _sueldo_bruto; }
            set
            {
                if (_sueldo_bruto != value)
                {
                    _sueldo_bruto = value;
                    OnPropertyChanged("Sueldo_bruto");
                }
            }
        }

        public string Nota
        {
            get { return _nota; }
            set
            {
                if (_nota != value)
                {
                    _nota = value;
                    OnPropertyChanged("Nota");
                }
            }
        }
        public byte[] Foto_empleado
        {
            get { return _foto_empleado; }
            set
            {
                if (_foto_empleado != value)
                {
                    _foto_empleado = value;
                    OnPropertyChanged("Foto_empleado");
                }
            }
        }
        public Empleado()
        {

        }
        public Empleado(int id_empleado, int id_departamento, int id_puesto, string cedula, string nombre, string apellido, string sexo, string telefono, string direccion, string fecha_nacimiento, string fecha_contratacion, decimal sueldo_bruto, string nota, byte[] foto_empleado)
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
            _foto_empleado = foto_empleado;
        }
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
