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
    public partial class RolViewModel : ObservableObject, INotifyPropertyChanged
    {

        public RolViewModel()
        {
            UpdateSourcesRol();
            MostrarGuardarCancelarRol(false);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        /********Rol********/

        [ObservableProperty] private static DataView _dataviewrol = new DataView();

        public DataView DataViewRol
        {
            get { return _dataviewrol; }
            set
            {
                if (_dataviewrol != value)
                {
                    _dataviewrol = value;
                    OnPropertyChanged(nameof(DataViewRol)); // Notifica el cambio a la interfaz de usuario


                }
            }
        }

        [ObservableProperty] private int _selectindexrol = 0;

        public int SelectIndexRol
        {
            get { return _selectindexrol; }
            set
            {
                _selectindexrol = value;
                OnPropertyChanged(nameof(SelectIndexRol)); // Notifica el cambio a la interfaz de usuario
                MostrarRolSeleccionado();

            }
        }

        [ObservableProperty] private object _selectedrowrol;

        public object SelectedRowRol
        {
            get { return _selectedrowrol; }
            set
            {
                if (_selectedrowrol != value)
                {
                    _selectedrowrol = value;
                    MostrarRolSeleccionado();

                }
            }
        }

        [ObservableProperty] private bool[] _estadocontrolesrol = new bool[8];

        public bool[] EstadoControlesRol
        {
            get { return _estadocontrolesrol; }
            set
            {
                if (_estadocontrolesrol != value)
                {
                    _estadocontrolesrol = value;
                    OnPropertyChanged(nameof(EstadoControlesRol)); // Notifica el cambio a la interfaz de usuario


                }
            }
        }

        [ObservableProperty] public SIGC.Model.Rol rolseleccionado = new Model.Rol();

        public void MostrarRolSeleccionado()
        {
            // Convierte el objeto seleccionado en un objeto DataRowView
            //DataRowView selectedRow = (DataRowView)DataGridViewCliente.SelectedItem;

            if (SelectedRowRol is DataRowView selectedRow)
            {
                rolseleccionado.Id_rol = Convert.ToInt32(selectedRow.Row["Rol ID"]);
                rolseleccionado.Nombre = Convert.ToString(selectedRow.Row["Nombre del rol"]);
                rolseleccionado.Descripcion = Convert.ToString(selectedRow.Row["Descripción del rol"]);


            }
        }

        public void UpdateSourcesRol()
        {
            DataViewRol = RolModel.GetRolDataTable().DefaultView;
            MostrarRolSeleccionado();
        }

        public void MostrarGuardarCancelarRol(bool mostrar)
        {
            EstadoControlesRol[0] = !mostrar; // btnAgregar
            EstadoControlesRol[1] = !mostrar; // btnEditar
            EstadoControlesRol[2] = mostrar; // btnCancelar
            EstadoControlesRol[3] = mostrar; // btnGuardar
            EstadoControlesRol[4] = !mostrar; // btnEliminar
            EstadoControlesRol[5] = mostrar; // txtNombre
            EstadoControlesRol[6] = mostrar; // txtDescripcion
            EstadoControlesRol[7] = !mostrar; // dgvRol

            // Notificar cambio a la interfaz de usuario
            OnPropertyChanged(nameof(EstadoControlesRol));
        }

        private void LimpiarCamposRol()
        {
            rolseleccionado.Id_rol = 0;
            rolseleccionado.Nombre = string.Empty;
            rolseleccionado.Descripcion = string.Empty;
        }

        [RelayCommand]
        public void btnAgregarRol()
        {
            MostrarGuardarCancelarRol(true);
            LimpiarCamposRol();
        }

        [RelayCommand]
        public void btnEditarRol()
        {
            MostrarGuardarCancelarRol(true);
        }

        [RelayCommand]
        public void btnCancelarRol()
        {
            MostrarGuardarCancelarRol(false);
        }

        [RelayCommand]
        public void btnGuardarRol()
        {
            try
            {

                MessageBox.Show($"Hubo {RolModel.InsertarActualizarRol(rolseleccionado)} del rol");
                MostrarGuardarCancelarRol(false);
                UpdateSourcesRol();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);

            }
        }

        [RelayCommand]
        public void btnEliminarRol()
        {
            try
            {

                MessageBox.Show($"Hubo {RolModel.EliminarRol(rolseleccionado)} del rol");
                MostrarGuardarCancelarRol(false);
                UpdateSourcesRol();
                LimpiarCamposRol();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);

            }

        }
    }
}
