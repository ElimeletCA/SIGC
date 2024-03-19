using SIGC.WPF.View.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIGC.WPF.View.Models.Administracion;
using SIGC.WPF.View.Models.Pacientes;

namespace SIGC.WPF.View.ViewModels.Pages.Pacientes
{
    public partial class SeguroViewModel : ObservableObject, INotifyPropertyChanged
    {

        public SeguroViewModel()
        {
            UpdateSourcesSeguro();
            MostrarGuardarCancelarSeguro(false);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        /********Seguro********/

        [ObservableProperty] private static DataView _dataviewseguro = new DataView();

        public DataView DataViewSeguro
        {
            get { return _dataviewseguro; }
            set
            {
                if (_dataviewseguro != value)
                {
                    _dataviewseguro = value;
                    OnPropertyChanged(nameof(DataViewSeguro)); // Notifica el cambio a la interfaz de usuario


                }
            }
        }

        [ObservableProperty] private int _selectindexseguro = 0;

        public int SelectIndexSeguro
        {
            get { return _selectindexseguro; }
            set
            {
                _selectindexseguro = value;
                OnPropertyChanged(nameof(SelectIndexSeguro)); // Notifica el cambio a la interfaz de usuario
                MostrarSeguroSeleccionado();

            }
        }

        [ObservableProperty] private object _selectedrowseguro;

        public object SelectedRowSeguro
        {
            get { return _selectedrowseguro; }
            set
            {
                if (_selectedrowseguro != value)
                {
                    _selectedrowseguro = value;
                    MostrarSeguroSeleccionado();

                }
            }
        }

        [ObservableProperty] private bool[] _estadocontrolesseguro = new bool[8];

        public bool[] EstadoControlesSeguro
        {
            get { return _estadocontrolesseguro; }
            set
            {
                if (_estadocontrolesseguro != value)
                {
                    _estadocontrolesseguro = value;
                    OnPropertyChanged(nameof(EstadoControlesSeguro)); // Notifica el cambio a la interfaz de usuario


                }
            }
        }

        [ObservableProperty] public SIGC.Model.Seguro seguroseleccionado = new Model.Seguro();

        public void MostrarSeguroSeleccionado()
        {
            // Convierte el objeto seleccionado en un objeto DataRowView
            //DataRowView selectedRow = (DataRowView)DataGridViewCliente.SelectedItem;

            if (SelectedRowSeguro is DataRowView selectedRow)
            {
                seguroseleccionado.Id_seguro = Convert.ToInt32(selectedRow.Row["Seguro ID"]);
                seguroseleccionado.Nombre = Convert.ToString(selectedRow.Row["Nombre del seguro"]);
                seguroseleccionado.Descripcion = Convert.ToString(selectedRow.Row["Descripción del seguro"]);


            }
        }

        public void UpdateSourcesSeguro()
        {
            DataViewSeguro = SeguroModel.GetSeguroDataTable().DefaultView;
            MostrarSeguroSeleccionado();
        }

        public void MostrarGuardarCancelarSeguro(bool mostrar)
        {
            EstadoControlesSeguro[0] = !mostrar; // btnAgregar
            EstadoControlesSeguro[1] = !mostrar; // btnEditar
            EstadoControlesSeguro[2] = mostrar; // btnCancelar
            EstadoControlesSeguro[3] = mostrar; // btnGuardar
            EstadoControlesSeguro[4] = !mostrar; // btnEliminar
            EstadoControlesSeguro[5] = mostrar; // txtNombre
            EstadoControlesSeguro[6] = mostrar; // txtDescripcion
            EstadoControlesSeguro[7] = !mostrar; // dgvSeguro

            // Notificar cambio a la interfaz de usuario
            OnPropertyChanged(nameof(EstadoControlesSeguro));
        }

        private void LimpiarCamposSeguro()
        {
            seguroseleccionado.Id_seguro = 0;
            seguroseleccionado.Nombre = string.Empty;
            seguroseleccionado.Descripcion = string.Empty;
        }

        [RelayCommand]
        public void btnAgregarSeguro()
        {
            MostrarGuardarCancelarSeguro(true);
            LimpiarCamposSeguro();
        }

        [RelayCommand]
        public void btnEditarSeguro()
        {
            MostrarGuardarCancelarSeguro(true);
        }

        [RelayCommand]
        public void btnCancelarSeguro()
        {
            MostrarGuardarCancelarSeguro(false);
        }

        [RelayCommand]
        public void btnGuardarSeguro()
        {
            try
            {

                MessageBox.Show($"Hubo {SeguroModel.InsertarActualizarSeguro(seguroseleccionado)} del seguro");
                MostrarGuardarCancelarSeguro(false);
                UpdateSourcesSeguro();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);

            }
        }

        [RelayCommand]
        public void btnEliminarSeguro()
        {
            try
            {

                MessageBox.Show($"Hubo {SeguroModel.EliminarSeguro(seguroseleccionado)} del seguro");
                MostrarGuardarCancelarSeguro(false);
                UpdateSourcesSeguro();
                LimpiarCamposSeguro();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);

            }

        }
    }
}
