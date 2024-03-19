using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIGC.Model
{
    public class Seguro : INotifyPropertyChanged
    {
        private int _id_seguro;
        private string _nombre;
        private string _descripcion;

        public int Id_seguro
        {
            get { return _id_seguro; }
            set
            {
                if (_id_seguro != value)
                {
                    _id_seguro = value;
                    OnPropertyChanged("Id_seguro");
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

        public Seguro()
        {

        }
        public Seguro(int id_seguro, string nombre, string descripcion)
        {
            _id_seguro = id_seguro;
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
