using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIGC.Model
{
    public class Departamento : INotifyPropertyChanged
    {
        private int _id_departamento;
        private string _nombre;
        private string _descripcion;

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

        public Departamento()
        {

        }
        public Departamento(int id_departamento, string nombre, string descripcion)
        {
            _id_departamento = id_departamento;
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
