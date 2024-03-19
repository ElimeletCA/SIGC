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
    public partial class PermisoViewModel : ObservableObject, INotifyPropertyChanged
    {

        public PermisoViewModel()
        {
            UpdateSourcesPermiso();
            MostrarGuardarCancelarPermiso(false);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        /********Permiso********/

        [ObservableProperty] private static DataView _dataviewpermiso = new DataView();

        public DataView DataViewPermiso
        {
            get { return _dataviewpermiso; }
            set
            {
                if (_dataviewpermiso != value)
                {
                    _dataviewpermiso = value;
                    OnPropertyChanged(nameof(DataViewPermiso)); // Notifica el cambio a la interfaz de usuario


                }
            }
        }

        [ObservableProperty] private int _selectindexpermiso = 0;

        public int SelectIndexPermiso
        {
            get { return _selectindexpermiso; }
            set
            {
                _selectindexpermiso = value;
                OnPropertyChanged(nameof(SelectIndexPermiso)); // Notifica el cambio a la interfaz de usuario
                MostrarPermisoSeleccionado();

            }
        }

        [ObservableProperty] private object _selectedrowpermiso;

        public object SelectedRowPermiso
        {
            get { return _selectedrowpermiso; }
            set
            {
                if (_selectedrowpermiso != value)
                {
                    _selectedrowpermiso = value;
                    MostrarPermisoSeleccionado();

                }
            }
        }

        [ObservableProperty] private bool[] _estadocontrolespermiso = new bool[8];

        public bool[] EstadoControlesPermiso
        {
            get { return _estadocontrolespermiso; }
            set
            {
                if (_estadocontrolespermiso != value)
                {
                    _estadocontrolespermiso = value;
                    OnPropertyChanged(nameof(EstadoControlesPermiso)); // Notifica el cambio a la interfaz de usuario


                }
            }
        }

        [ObservableProperty] public SIGC.Model.Permiso permisoseleccionado = new Model.Permiso();

        public void MostrarPermisoSeleccionado()
        {
            // Convierte el objeto seleccionado en un objeto DataRowView
            //DataRowView selectedRow = (DataRowView)DataGridViewCliente.SelectedItem;

            if (SelectedRowPermiso is DataRowView selectedRow)
            {
                permisoseleccionado.Id_permiso = Convert.ToInt32(selectedRow.Row["Permiso ID"]);
                permisoseleccionado.Nombre = Convert.ToString(selectedRow.Row["Nombre del permiso"]);
                permisoseleccionado.Descripcion = Convert.ToString(selectedRow.Row["Descripción del permiso"]);


            }
        }

        public void UpdateSourcesPermiso()
        {
            DataViewPermiso = PermisoModel.GetPermisoDataTable().DefaultView;
            MostrarPermisoSeleccionado();
        }

        public void MostrarGuardarCancelarPermiso(bool mostrar)
        {
            EstadoControlesPermiso[0] = !mostrar; // btnAgregar
            EstadoControlesPermiso[1] = !mostrar; // btnEditar
            EstadoControlesPermiso[2] = mostrar; // btnCancelar
            EstadoControlesPermiso[3] = mostrar; // btnGuardar
            EstadoControlesPermiso[4] = !mostrar; // btnEliminar
            EstadoControlesPermiso[5] = mostrar; // txtNombre
            EstadoControlesPermiso[6] = mostrar; // txtDescripcion
            EstadoControlesPermiso[7] = !mostrar; // dgvPermiso

            // Notificar cambio a la interfaz de usuario
            OnPropertyChanged(nameof(EstadoControlesPermiso));
        }

        private void LimpiarCamposPermiso()
        {
            permisoseleccionado.Id_permiso = 0;
            permisoseleccionado.Nombre = string.Empty;
            permisoseleccionado.Descripcion = string.Empty;
        }

        [RelayCommand]
        public void btnAgregarPermiso()
        {
            MostrarGuardarCancelarPermiso(true);
            LimpiarCamposPermiso();
        }

        [RelayCommand]
        public void btnEditarPermiso()
        {
            MostrarGuardarCancelarPermiso(true);
        }

        [RelayCommand]
        public void btnCancelarPermiso()
        {
            MostrarGuardarCancelarPermiso(false);
        }

        [RelayCommand]
        public void btnGuardarPermiso()
        {
            try
            {

                MessageBox.Show($"Hubo {PermisoModel.InsertarActualizarPermiso(permisoseleccionado)} del permiso");
                MostrarGuardarCancelarPermiso(false);
                UpdateSourcesPermiso();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);

            }
        }

        [RelayCommand]
        public void btnEliminarPermiso()
        {
            try
            {

                MessageBox.Show($"Hubo {PermisoModel.EliminarPermiso(permisoseleccionado)} del permiso");
                MostrarGuardarCancelarPermiso(false);
                UpdateSourcesPermiso();
                LimpiarCamposPermiso();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);

            }

        }
    }
}
