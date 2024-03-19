using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIGC.Model
{
    public class Rol : INotifyPropertyChanged
    {
        private int _id_rol;
        private string _nombre;
        private string _descripcion;

        public int Id_rol
        {
            get { return _id_rol; }
            set
            {
                if (_id_rol != value)
                {
                    _id_rol = value;
                    OnPropertyChanged("Id_rol");
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

        public Rol()
        {

        }
        public Rol(int id_rol, string nombre, string descripcion)
        {
            _id_rol = id_rol;
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
