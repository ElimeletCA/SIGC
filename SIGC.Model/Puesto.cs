using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIGC.Model
{
    public class Puesto : INotifyPropertyChanged
    {
        private int _id_puesto;
        private string _nombre;
        private string _descripcion;

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

        public Puesto()
        {

        }
        public Puesto(int id_puesto, string nombre, string descripcion)
        {
            _id_puesto = id_puesto;
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
