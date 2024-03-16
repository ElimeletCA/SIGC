using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIGC.Model
{
    public class Tipo_Documento : INotifyPropertyChanged
    {
        private int _id_tipo_documento;
        private string _nombre;

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

        public Tipo_Documento(int id_tipo_documento, string nombre)
        {
            _id_tipo_documento = id_tipo_documento;
            _nombre = nombre;
        }
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
