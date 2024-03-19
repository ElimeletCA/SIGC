using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIGC.Model
{
    public class Modulo : INotifyPropertyChanged
    {
        private int _id_modulo;
        private string _nombre;
        private string _descripcion;

        public int Id_modulo
        {
            get { return _id_modulo; }
            set
            {
                if (_id_modulo != value)
                {
                    _id_modulo = value;
                    OnPropertyChanged("Id_modulo");
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

        public string Descripcion
        {
            get { return _descripcion; }
            set
            {
                if (_descripcion != value)
                {
                    _descripcion = value;
                    OnPropertyChanged("Descripcion");
                }
            }
        }

        public Modulo()
        {

        }
        public Modulo(int id_modulo, string nombre, string descripcion)
        {
            _id_modulo = id_modulo;
            _nombre = nombre;
            _descripcion = descripcion;
        }
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
