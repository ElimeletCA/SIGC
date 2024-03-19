using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIGC.Model
{
    public class Permiso : INotifyPropertyChanged
    {
        private int _id_permiso;
        private string _nombre;
        private string _descripcion;

        public int Id_permiso
        {
            get { return _id_permiso; }
            set
            {
                if (_id_permiso != value)
                {
                    _id_permiso = value;
                    OnPropertyChanged("Id_permiso");
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

        public Permiso()
        {

        }
        public Permiso(int id_permiso, string nombre, string descripcion)
        {
            _id_permiso = id_permiso;
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
