using SIGC.WPF.View.Models.Cliente;
using SIGC.WPF.View.Models.Extra;
using SIGC.WPF.View.Models.Administracion;
using SIGC.WPF.View.Models.RecursosHumanos;


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIGC.Model;
using SIGC.Data;

namespace SIGC.WPF.View.ViewModels.Pages.RecursosHumanos
{
    public partial class EmpleadoViewModel : ObservableObject, INotifyPropertyChanged
    {
        [ObservableProperty]
        private static DataView _datatableempleado = new DataView();
        public DataView DataTableEmpleado
        {
            get { return _datatableempleado; }
            set
            {
                if (_datatableempleado != value)
                {
                    _datatableempleado = value;
                    OnPropertyChanged(nameof(DataTableEmpleado)); // Notifica el cambio a la interfaz de usuario


                }
            }
        }
        [ObservableProperty]
        private int _selectindex = 0;

        public int SelectIndex
        {
            get { return _selectindex; }
            set
            {
                _selectindex = value;
                OnPropertyChanged(nameof(SelectIndex)); // Notifica el cambio a la interfaz de usuario
                MostrarItemSeleccionado();

            }
        }

        [ObservableProperty]
        private static DataTable _datatabledepartamento = new DataTable();
        public DataTable DataTableDepartamento
        {
            get { return _datatabledepartamento; }
            set
            {
                if (_datatabledepartamento != value)
                {
                    _datatabledepartamento = value;
                    OnPropertyChanged(nameof(DataTableDepartamento)); // Notifica el cambio a la interfaz de usuario
                }
            }
        }
        [ObservableProperty]
        private static DataTable _datatablepuesto = new DataTable();
        public DataTable DataTablePuesto
        {
            get { return _datatablepuesto; }
            set
            {
                if (_datatablepuesto != value)
                {
                    _datatablepuesto = value;
                    OnPropertyChanged(nameof(DataTablePuesto)); // Notifica el cambio a la interfaz de usuario
                }
            }
        }

        [ObservableProperty]
        private object _selectedrowitem;
        public object SelectedRowItem
        {
            get { return _selectedrowitem; }
            set
            {
                if (_selectedrowitem != value)
                {
                    _selectedrowitem = value;
                    MostrarItemSeleccionado();

                }
            }
        }

        [ObservableProperty]
        private int _idpuesto;

        public int IdPuesto
        {
            get { return _idpuesto; }
            set
            {
                if (_idpuesto != value)
                {
                    _idpuesto = value;

                }
            }
        }

        [ObservableProperty]
        private string _nombrepuesto;

        public string NombrePuesto
        {
            get { return _nombrepuesto; }
            set
            {
                if (_nombrepuesto != value)
                {
                    _nombrepuesto = value;
                    OnPropertyChanged(nameof(NombrePuesto)); // Notifica el cambio a la interfaz de usuario

                }
            }
        }

        [ObservableProperty]
        private int _iddepartamento;

        public int IdDepartamento
        {
            get { return _iddepartamento; }
            set
            {
                if (_iddepartamento != value)
                {
                    _iddepartamento = value;

                }
            }
        }

        [ObservableProperty]
        private string _nombredepartamento;

        public string NombreDepartamento
        {
            get { return _nombredepartamento; }
            set
            {
                if (_nombredepartamento != value)
                {
                    _nombredepartamento = value;
                    OnPropertyChanged(nameof(NombreDepartamento)); // Notifica el cambio a la interfaz de usuario

                }
            }
        }

        [ObservableProperty]
        private bool[] _estadocontroles = new bool[7];

        public bool[] EstadoControles
        {
            get { return _estadocontroles; }
            set
            {
                if (_estadocontroles != value)
                {
                    _estadocontroles = value;
                    OnPropertyChanged(nameof(EstadoControles)); // Notifica el cambio a la interfaz de usuario


                }
            }
        }

        [ObservableProperty]
        public SIGC.Model.Empleado empleadoseleccionado = new Model.Empleado();

        public EmpleadoViewModel()
        {
            UpdateSources();
            MostrarGuardarCancelar(false);
        }

        public void MostrarItemSeleccionado()
        {
            // Convierte el objeto seleccionado en un objeto DataRowView
            //DataRowView selectedRow = (DataRowView)DataGridViewCliente.SelectedItem;

            if (SelectedRowItem is DataRowView selectedRow)
            {
                empleadoseleccionado.Id_empleado = Convert.ToInt32(selectedRow.Row["Empleado ID"]);
                empleadoseleccionado.Nombre = Convert.ToString(selectedRow.Row["Nombre"]);
                empleadoseleccionado.Apellido = Convert.ToString(selectedRow.Row["Apellido"]);
                empleadoseleccionado.Cedula = Convert.ToString(selectedRow.Row["Cédula"]);
                empleadoseleccionado.Sexo = Convert.ToString(selectedRow.Row["Sexo"]);
                empleadoseleccionado.Telefono = Convert.ToString(selectedRow.Row["Teléfono"]);
                empleadoseleccionado.Direccion = Convert.ToString(selectedRow.Row["Dirección"]);
                empleadoseleccionado.Fecha_nacimiento = Convert.ToString(selectedRow.Row["Fecha de nacimiento"]);
                empleadoseleccionado.Fecha_Contratacion = Convert.ToString(selectedRow.Row["Fecha de contratación"]);

                NombrePuesto = Convert.ToString(selectedRow.Row["Puesto"]);
                DataRow[] rowspuesto = DataTablePuesto.Select($"Nombre del puesto = '{NombrePuesto}'");
                if (rowspuesto.Length > 0)
                {
                    empleadoseleccionado.Id_puesto = Convert.ToInt32(rowspuesto[0]["Puesto ID"]);
                }



                NombreDepartamento = Convert.ToString(selectedRow.Row["Departamento"]);
                DataRow[] rowsdepartamento = DataTableDepartamento.Select($"Nombre del departamento = '{NombreDepartamento}'");
                if (rowsdepartamento.Length > 0)
                {
                    empleadoseleccionado.Id_departamento = Convert.ToInt32(rowsdepartamento[0]["Departamento ID"]);
                }
                empleadoseleccionado.Sueldo_bruto = Convert.ToDecimal(selectedRow.Row["Sueldo Bruto"]);
                empleadoseleccionado.Nota = Convert.ToString(selectedRow.Row["Nota sobre el empleado"]);
                empleadoseleccionado.Foto_empleado = (byte[])selectedRow.Row["Foto del empleado"];
                //Image.FromStream(new MemoryStream((byte[])selectedRow.Row["Foto del empleado"]));
            }
        }
        public void UpdateSources()
        {
            DataTableEmpleado = EmpleadoModel.GetEmpleadoDataTable().DefaultView;
            DataTablePuesto = ExtraModel.GetPuestoDataTable();
            DataTableDepartamento = ExtraModel.GetDepartamentoDataTable();
            MostrarItemSeleccionado();
        }
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public void MostrarGuardarCancelar(bool mostrar)
        {
            EstadoControles[0] = !mostrar; // btnAgregar
            EstadoControles[1] = !mostrar; // btnEditar
            EstadoControles[2] = mostrar; // btnCancelar
            EstadoControles[3] = mostrar; // btnGuardar
            EstadoControles[4] = !mostrar; // btnEliminar
            EstadoControles[5] = mostrar; // Controles de usuario
            // txtNombre
            // txtApellido
            // txtCedula
            // txtSexo
            // txtTelefono
            // txtDireccion
            // dtpFechaNacimiento
            // dtpFechaContratacion
            // cbPuesto
            // cbDepartamento
            // txtSueldoBruto
            // txtNota
            // btnCambiarFoto
            // btnEliminarFoto
            EstadoControles[6] = !mostrar; // dgvEmpleado

            // Notificar cambio a la interfaz de usuario
            OnPropertyChanged(nameof(EstadoControles));
        }
        private void LimpiarCampos()
        {
            empleadoseleccionado.Id_empleado = 0;
            empleadoseleccionado.Id_puesto = 0;
            empleadoseleccionado.Id_departamento = 0;
            IdPuesto = 0;
            IdDepartamento = 0;
            NombrePuesto = string.Empty;
            NombreDepartamento = string.Empty;
            empleadoseleccionado.Nombre = string.Empty;
            empleadoseleccionado.Apellido = string.Empty;
            empleadoseleccionado.Cedula = string.Empty;
            empleadoseleccionado.Sexo = string.Empty;
            empleadoseleccionado.Telefono = string.Empty;
            empleadoseleccionado.Direccion = string.Empty;
            empleadoseleccionado.Fecha_nacimiento = string.Empty;
            empleadoseleccionado.Fecha_Contratacion = string.Empty;
            empleadoseleccionado.Sueldo_bruto = 0;
            empleadoseleccionado.Nota = string.Empty;
            empleadoseleccionado.Foto_empleado = null;


        }
        [RelayCommand]
        public void btnAgregar()
        {
            MostrarGuardarCancelar(true);
            LimpiarCampos();
        }

        [RelayCommand]
        public void btnEditar()
        {
            MostrarGuardarCancelar(true);
        }
        [RelayCommand]
        public void btnCancelar()
        {
            MostrarGuardarCancelar(false);
        }
        [RelayCommand]
        public void btnGuardar()
        {
            try
            {
                empleadoseleccionado.Id_puesto = IdPuesto;
                empleadoseleccionado.Id_departamento = IdDepartamento;
                MessageBox.Show($"Hubo {EmpleadoModel.InsertarActualizarEmpleado(empleadoseleccionado)} del empleado");
                MostrarGuardarCancelar(false);
                UpdateSources();

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

                MessageBox.Show($"Hubo {EmpleadoModel.EliminarEmpleado(empleadoseleccionado)} del empleado");
                MostrarGuardarCancelar(false);
                UpdateSources();
                LimpiarCampos();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);

            }

        }

    }
}
