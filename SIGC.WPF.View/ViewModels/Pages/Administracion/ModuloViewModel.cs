using SIGC.WPF.View.Models.Extra;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIGC.WPF.View.Models.Administracion;

namespace SIGC.WPF.View.ViewModels.Pages.Administracion
{
    public partial class ModuloViewModel : ObservableObject, INotifyPropertyChanged
    {

        public ModuloViewModel()
        {
            UpdateSourcesModulo();
            MostrarGuardarCancelarModulo(false);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        /********Modulo********/

        [ObservableProperty] private static DataView _dataviewmodulo = new DataView();

        public DataView DataViewModulo
        {
            get { return _dataviewmodulo; }
            set
            {
                if (_dataviewmodulo != value)
                {
                    _dataviewmodulo = value;
                    OnPropertyChanged(nameof(DataViewModulo)); // Notifica el cambio a la interfaz de usuario


                }
            }
        }

        [ObservableProperty] private int _selectindexmodulo = 0;

        public int SelectIndexModulo
        {
            get { return _selectindexmodulo; }
            set
            {
                _selectindexmodulo = value;
                OnPropertyChanged(nameof(SelectIndexModulo)); // Notifica el cambio a la interfaz de usuario
                MostrarModuloSeleccionado();

            }
        }

        [ObservableProperty] private object _selectedrowmodulo;

        public object SelectedRowModulo
        {
            get { return _selectedrowmodulo; }
            set
            {
                if (_selectedrowmodulo != value)
                {
                    _selectedrowmodulo = value;
                    MostrarModuloSeleccionado();

                }
            }
        }

        [ObservableProperty] private bool[] _estadocontrolesmodulo = new bool[8];

        public bool[] EstadoControlesModulo
        {
            get { return _estadocontrolesmodulo; }
            set
            {
                if (_estadocontrolesmodulo != value)
                {
                    _estadocontrolesmodulo = value;
                    OnPropertyChanged(nameof(EstadoControlesModulo)); // Notifica el cambio a la interfaz de usuario


                }
            }
        }

        [ObservableProperty] public SIGC.Model.Modulo moduloseleccionado = new Model.Modulo();

        public void MostrarModuloSeleccionado()
        {
            // Convierte el objeto seleccionado en un objeto DataRowView
            //DataRowView selectedRow = (DataRowView)DataGridViewCliente.SelectedItem;

            if (SelectedRowModulo is DataRowView selectedRow)
            {
                moduloseleccionado.Id_modulo = Convert.ToInt32(selectedRow.Row["Módulo ID"]);
                moduloseleccionado.Nombre = Convert.ToString(selectedRow.Row["Nombre del módulo"]);
                moduloseleccionado.Descripcion = Convert.ToString(selectedRow.Row["Descripción del módulo"]);


            }
        }

        public void UpdateSourcesModulo()
        {
            DataViewModulo = ModuloModel.GetModuloDataTable().DefaultView;
            MostrarModuloSeleccionado();
        }

        public void MostrarGuardarCancelarModulo(bool mostrar)
        {
            EstadoControlesModulo[0] = !mostrar; // btnAgregar
            EstadoControlesModulo[1] = !mostrar; // btnEditar
            EstadoControlesModulo[2] = mostrar; // btnCancelar
            EstadoControlesModulo[3] = mostrar; // btnGuardar
            EstadoControlesModulo[4] = !mostrar; // btnEliminar
            EstadoControlesModulo[5] = mostrar; // txtNombre
            EstadoControlesModulo[6] = mostrar; // txtDescripcion
            EstadoControlesModulo[7] = !mostrar; // dgvModulo

            // Notificar cambio a la interfaz de usuario
            OnPropertyChanged(nameof(EstadoControlesModulo));
        }

        private void LimpiarCamposModulo()
        {
            moduloseleccionado.Id_modulo = 0;
            moduloseleccionado.Nombre = string.Empty;
            moduloseleccionado.Descripcion = string.Empty;
        }

        [RelayCommand]
        public void btnAgregarModulo()
        {
            MostrarGuardarCancelarModulo(true);
            LimpiarCamposModulo();
        }

        [RelayCommand]
        public void btnEditarModulo()
        {
            MostrarGuardarCancelarModulo(true);
        }

        [RelayCommand]
        public void btnCancelarModulo()
        {
            MostrarGuardarCancelarModulo(false);
        }

        [RelayCommand]
        public void btnGuardarModulo()
        {
            try
            {

                MessageBox.Show($"Hubo {ModuloModel.InsertarActualizarModulo(moduloseleccionado)} del modulo");
                MostrarGuardarCancelarModulo(false);
                UpdateSourcesModulo();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);

            }
        }

        [RelayCommand]
        public void btnEliminarModulo()
        {
            try
            {

                MessageBox.Show($"Hubo {ModuloModel.EliminarModulo(moduloseleccionado)} del modulo");
                MostrarGuardarCancelarModulo(false);
                UpdateSourcesModulo();
                LimpiarCamposModulo();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);

            }

        }
    }
}
