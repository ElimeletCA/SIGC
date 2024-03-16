using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace SIGC.Model
{
    public class Cliente : INotifyPropertyChanged
    {
        private int _id_cliente;
        private int _id_tipo_documento;
        private string _numero_documento;
        private string _nombre;
        private string _apellido;
        private string _sexo;
        private string _telefono;
        private string _direccion;
        private string _correo_electronico;
        private string _fecha_registro;
        private string _nota;

        public int Id_cliente
        {
            get { return _id_cliente; }
            set
            {
                if (_id_cliente != value)
                {
                    _id_cliente = value;
                    OnPropertyChanged("Id_cliente");
                }
            }
        }
        public int Id_tipo_documento
        {
            get { return _id_tipo_documento; }
            set
            {
                if (_id_tipo_documento != value)
                {
                    _id_tipo_documento = value;
                    OnPropertyChanged("Id_tipo_documento");
                }
            }
        }
        public string Numero_documento
        {
            get { return _numero_documento; }
            set
            {
                if (_numero_documento != value)
                {
                    _numero_documento = value;
                    OnPropertyChanged("Numero_documento");
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
        public string Correo_electronico
        {
            get { return _correo_electronico; }
            set
            {
                if (_correo_electronico != value)
                {
                    _correo_electronico = value;
                    OnPropertyChanged("Correo_electronico");
                }
            }
        }
        public string Fecha_registro
        {
            get { return _fecha_registro; }
            set
            {
                if (_fecha_registro != value)
                {
                    _fecha_registro = value;
                    OnPropertyChanged("Fecha_registro");
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
        public Cliente(){

        }
        public Cliente(int id_cliente, int id_tipo_documento, string numero_documento, string nombre, string apellido, string sexo, string telefono, string direccion, string correo_electronico, string fecha_registro, string nota)
        {
            _id_cliente = id_cliente;
            _id_tipo_documento = id_tipo_documento;
            _numero_documento = numero_documento;
            _nombre = nombre;
            _apellido = apellido;
            _sexo = sexo;
            _telefono = telefono;
            _direccion = direccion;
            _correo_electronico = correo_electronico;
            _fecha_registro = fecha_registro;
            _nota = nota;
        }
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
