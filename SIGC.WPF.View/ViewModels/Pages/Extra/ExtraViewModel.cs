using SIGC.Data;
using SIGC.Model;
using SIGC.WPF.View.Models.Cliente;
using SIGC.WPF.View.Models.Extra;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIGC.WPF.View.Models.Extra;

namespace SIGC.WPF.View.ViewModels.Pages.Extra
{
    public partial class ExtraViewModel : ObservableObject, INotifyPropertyChanged
    {

        public ExtraViewModel()
        {
            UpdateSourcesPuesto();
            MostrarGuardarCancelarPuesto(false);
            UpdateSourcesDepartamento();
            MostrarGuardarCancelarDepartamento(false);
        }
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        /********Puesto********/

        [ObservableProperty]
        private static DataView _dataviewpuesto = new DataView();
        public DataView DataViewPuesto
        {
            get { return _dataviewpuesto; }
            set
            {
                if (_dataviewpuesto != value)
                {
                    _dataviewpuesto = value;
                    OnPropertyChanged(nameof(DataViewPuesto)); // Notifica el cambio a la interfaz de usuario


                }
            }
        }
        [ObservableProperty]
        private int _selectindexpuesto = 0;

        public int SelectIndexPuesto
        {
            get { return _selectindexpuesto; }
            set
            {
                _selectindexpuesto = value;
                OnPropertyChanged(nameof(SelectIndexPuesto)); // Notifica el cambio a la interfaz de usuario
                MostrarPuestoSeleccionado();

            }
        }
        [ObservableProperty]
        private object _selectedrowpuesto;
        public object SelectedRowPuesto
        {
            get { return _selectedrowpuesto; }
            set
            {
                if (_selectedrowpuesto != value)
                {
                    _selectedrowpuesto = value;
                    MostrarPuestoSeleccionado();

                }
            }
        }
        [ObservableProperty]
        private bool[] _estadocontrolespuesto = new bool[8];

        public bool[] EstadoControlesPuesto
        {
            get { return _estadocontrolespuesto; }
            set
            {
                if (_estadocontrolespuesto != value)
                {
                    _estadocontrolespuesto = value;
                    OnPropertyChanged(nameof(EstadoControlesPuesto)); // Notifica el cambio a la interfaz de usuario


                }
            }
        }
        [ObservableProperty]
        public SIGC.Model.Puesto puestoseleccionado = new Model.Puesto();

        public void MostrarPuestoSeleccionado()
        {
            // Convierte el objeto seleccionado en un objeto DataRowView
            //DataRowView selectedRow = (DataRowView)DataGridViewCliente.SelectedItem;

            if (SelectedRowPuesto is DataRowView selectedRow)
            {
                puestoseleccionado.Id_puesto = Convert.ToInt32(selectedRow.Row["Puesto ID"]);
                puestoseleccionado.Nombre = Convert.ToString(selectedRow.Row["Nombre del puesto"]);
                puestoseleccionado.Descripcion = Convert.ToString(selectedRow.Row["Descripción del puesto"]);


            }
        }
        public void UpdateSourcesPuesto()
        {
            DataViewPuesto = ExtraModel.GetPuestoDataTable().DefaultView;
            MostrarPuestoSeleccionado();
        }

        public void MostrarGuardarCancelarPuesto(bool mostrar)
        {
            EstadoControlesPuesto[0] = !mostrar; // btnAgregar
            EstadoControlesPuesto[1] = !mostrar; // btnEditar
            EstadoControlesPuesto[2] = mostrar; // btnCancelar
            EstadoControlesPuesto[3] = mostrar; // btnGuardar
            EstadoControlesPuesto[4] = !mostrar; // btnEliminar
            EstadoControlesPuesto[5] = mostrar; // txtNombre
            EstadoControlesPuesto[6] = mostrar; // txtDescripcion
            EstadoControlesPuesto[7] = !mostrar; // dgvPuesto

            // Notificar cambio a la interfaz de usuario
            OnPropertyChanged(nameof(EstadoControlesPuesto));
        }
        private void LimpiarCamposPuesto()
        {
            puestoseleccionado.Id_puesto = 0;
            puestoseleccionado.Nombre = string.Empty;
            puestoseleccionado.Descripcion = string.Empty;
        }
        [RelayCommand]
        public void btnAgregarPuesto()
        {
            MostrarGuardarCancelarPuesto(true);
            LimpiarCamposPuesto();
        }

        [RelayCommand]
        public void btnEditarPuesto()
        {
            MostrarGuardarCancelarPuesto(true);
        }
        [RelayCommand]
        public void btnCancelarPuesto()
        {
            MostrarGuardarCancelarPuesto(false);
        }
        [RelayCommand]
        public void btnGuardarPuesto()
        {
            try
            {

                MessageBox.Show($"Hubo {ExtraModel.InsertarActualizarPuesto(puestoseleccionado)} del puesto");
                MostrarGuardarCancelarPuesto(false);
                UpdateSourcesPuesto();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);

            }
        }
        [RelayCommand]
        public void btnEliminarPuesto()
        {
            try
            {

                MessageBox.Show($"Hubo {ExtraModel.EliminarPuesto(puestoseleccionado)} del puesto");
                MostrarGuardarCancelarPuesto(false);
                UpdateSourcesPuesto();
                LimpiarCamposPuesto();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);

            }

        }

        /********Departamento********/

        [ObservableProperty]
        private static DataView _dataviewdepartamento = new DataView();
        public DataView DataViewDepartamento
        {
            get { return _dataviewdepartamento; }
            set
            {
                if (_dataviewdepartamento != value)
                {
                    _dataviewdepartamento = value;
                    OnPropertyChanged(nameof(DataViewDepartamento)); // Notifica el cambio a la interfaz de usuario


                }
            }
        }
        [ObservableProperty]
        private int _selectindexdepartamento = 0;

        public int SelectIndexDepartamento
        {
            get { return _selectindexdepartamento; }
            set
            {
                _selectindexdepartamento = value;
                OnPropertyChanged(nameof(SelectIndexDepartamento)); // Notifica el cambio a la interfaz de usuario
                MostrarDepartamentoSeleccionado();

            }
        }
        [ObservableProperty]
        private object _selectedrowdepartamento;
        public object SelectedRowDepartamento
        {
            get { return _selectedrowdepartamento; }
            set
            {
                if (_selectedrowdepartamento != value)
                {
                    _selectedrowdepartamento = value;
                    MostrarDepartamentoSeleccionado();

                }
            }
        }
        [ObservableProperty]
        private bool[] _estadocontrolesdepartamento = new bool[8];

        public bool[] EstadoControlesDepartamento
        {
            get { return _estadocontrolesdepartamento; }
            set
            {
                if (_estadocontrolesdepartamento != value)
                {
                    _estadocontrolesdepartamento = value;
                    OnPropertyChanged(nameof(EstadoControlesDepartamento)); // Notifica el cambio a la interfaz de usuario


                }
            }
        }
        [ObservableProperty]
        public SIGC.Model.Departamento departamentoseleccionado = new Model.Departamento();

        public void MostrarDepartamentoSeleccionado()
        {
            // Convierte el objeto seleccionado en un objeto DataRowView
            //DataRowView selectedRow = (DataRowView)DataGridViewCliente.SelectedItem;

            if (SelectedRowDepartamento is DataRowView selectedRow)
            {
                departamentoseleccionado.Id_departamento = Convert.ToInt32(selectedRow.Row["Departamento ID"]);
                departamentoseleccionado.Nombre = Convert.ToString(selectedRow.Row["Nombre del departamento"]);
                departamentoseleccionado.Descripcion = Convert.ToString(selectedRow.Row["Descripción del departamento"]);


            }
        }
        public void UpdateSourcesDepartamento()
        {
            DataViewDepartamento = ExtraModel.GetDepartamentoDataTable().DefaultView;
            MostrarDepartamentoSeleccionado();
        }

        public void MostrarGuardarCancelarDepartamento(bool mostrar)
        {
            EstadoControlesDepartamento[0] = !mostrar; // btnAgregar
            EstadoControlesDepartamento[1] = !mostrar; // btnEditar
            EstadoControlesDepartamento[2] = mostrar; // btnCancelar
            EstadoControlesDepartamento[3] = mostrar; // btnGuardar
            EstadoControlesDepartamento[4] = !mostrar; // btnEliminar
            EstadoControlesDepartamento[5] = mostrar; // txtNombre
            EstadoControlesDepartamento[6] = mostrar; // txtDescripcion
            EstadoControlesDepartamento[7] = !mostrar; // dgvDepartamento

            // Notificar cambio a la interfaz de usuario
            OnPropertyChanged(nameof(EstadoControlesDepartamento));
        }
        private void LimpiarCamposDepartamento()
        {
            departamentoseleccionado.Id_departamento = 0;
            departamentoseleccionado.Nombre = string.Empty;
            departamentoseleccionado.Descripcion = string.Empty;
        }
        [RelayCommand]
        public void btnAgregarDepartamento()
        {
            MostrarGuardarCancelarDepartamento(true);
            LimpiarCamposDepartamento();
        }

        [RelayCommand]
        public void btnEditarDepartamento()
        {
            MostrarGuardarCancelarDepartamento(true);
        }
        [RelayCommand]
        public void btnCancelarDepartamento()
        {
            MostrarGuardarCancelarDepartamento(false);
        }
        [RelayCommand]
        public void btnGuardarDepartamento()
        {
            try
            {

                MessageBox.Show($"Hubo {ExtraModel.InsertarActualizarDepartamento(departamentoseleccionado)} del departamento");
                MostrarGuardarCancelarDepartamento(false);
                UpdateSourcesDepartamento();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);

            }
        }
        [RelayCommand]
        public void btnEliminarDepartamento()
        {
            try
            {

                MessageBox.Show($"Hubo {ExtraModel.EliminarDepartamento(departamentoseleccionado)} del departamento");
                MostrarGuardarCancelarDepartamento(false);
                UpdateSourcesDepartamento();
                LimpiarCamposDepartamento();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);

            }

        }







    }
}
