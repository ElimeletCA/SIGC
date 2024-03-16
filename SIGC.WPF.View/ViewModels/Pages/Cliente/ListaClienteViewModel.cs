
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Input;
using SIGC.Data;
using SIGC.Model;
using SIGC.WPF.View.Models.Cliente;
using SIGC.WPF.View.Models.Extra;
using System.Windows;
using Wpf.Ui;
using Wpf.Ui.Controls;
namespace SIGC.WPF.View.ViewModels.Pages.Cliente
{
    public partial class ListaClienteViewModel : ObservableObject, INotifyPropertyChanged
    {


        [ObservableProperty]
        private static DataView _datatablecliente = new DataView();
        public DataView DataTableCliente
        {
            get { return _datatablecliente; }
            set
            {
                if (_datatablecliente != value)
                {
                    _datatablecliente = value;
                    OnPropertyChanged(nameof(DataTableCliente)); // Notifica el cambio a la interfaz de usuario


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
        private static DataTable _datatabletipodocumento = new DataTable();
        public DataTable DataTableTipoDocumento
        {
            get { return _datatabletipodocumento; }
            set
            {
                if (_datatabletipodocumento != value)
                {
                    _datatabletipodocumento = value;
                    OnPropertyChanged(nameof(DataTableTipoDocumento)); // Notifica el cambio a la interfaz de usuario


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
        private int _idtipodocumento;

        public int IdTipoDocumento
        {
            get { return _idtipodocumento; }
            set
            {
                if (_idtipodocumento != value)
                {
                    _idtipodocumento = value;

                }
            }
        }

        [ObservableProperty]
        private string _nombretipodocumento;

        public string NombreTipoDocumento
        {
            get { return _nombretipodocumento; }
            set
            {
                if (_nombretipodocumento != value)
                {
                    _nombretipodocumento = value;
                    OnPropertyChanged(nameof(NombreTipoDocumento)); // Notifica el cambio a la interfaz de usuario


                }
            }
        }

        [ObservableProperty]
        private bool[] _estadocontroles = new bool[15];

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
        public SIGC.Model.Cliente clienteseleccionado = new Model.Cliente();



        public ListaClienteViewModel()
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
                clienteseleccionado.Id_cliente = Convert.ToInt32(selectedRow.Row["Cliente ID"]);
                clienteseleccionado.Nombre = Convert.ToString(selectedRow.Row["Nombre"]);
                clienteseleccionado.Apellido = Convert.ToString(selectedRow.Row["Apellido"]);
                NombreTipoDocumento = Convert.ToString(selectedRow.Row["Tipo Documento"]);
                DataRow[] rows = Datatabletipodocumento.Select($"Nombre = '{NombreTipoDocumento}'");
                if (rows.Length > 0)
                {
                    clienteseleccionado.Id_tipo_documento = Convert.ToInt32(rows[0]["Tipo Documento ID"]);
                }
                clienteseleccionado.Numero_documento = Convert.ToString(selectedRow.Row["Número Documento"]);
                clienteseleccionado.Sexo = Convert.ToString(selectedRow.Row["Sexo"]);
                clienteseleccionado.Telefono = Convert.ToString(selectedRow.Row["Teléfono"]);
                clienteseleccionado.Direccion = Convert.ToString(selectedRow.Row["Dirección"]);
                clienteseleccionado.Correo_electronico = Convert.ToString(selectedRow.Row["Correo Electrónico"]);
                clienteseleccionado.Nota = Convert.ToString(selectedRow.Row["Nota"]);
            }
        }

        public void UpdateSources()
        {
            DataTableCliente = ListaClienteModel.GetClienteDataTable().DefaultView;
            DataTableTipoDocumento = TipoDocumentoModel.GetTipoDocumentoDataTable();
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
            EstadoControles[5] = mostrar; // txtNombre
            EstadoControles[6] = mostrar; // txtApellido
            EstadoControles[7] = mostrar; // cbTipoDocumento
            EstadoControles[8] = mostrar; // txtNumeroDocumento
            EstadoControles[9] = mostrar; // txtSexo
            EstadoControles[10] = mostrar; // txtTelefono
            EstadoControles[11] = mostrar; // txtDireccion
            EstadoControles[12] = mostrar; // txtCorreoElectronico
            EstadoControles[13] = mostrar; // txtNota
            EstadoControles[14] = !mostrar; // dgvCliente

            // Notificar cambio a la interfaz de usuario
            OnPropertyChanged(nameof(EstadoControles));
        }
        private void LimpiarCampos()
        {
            clienteseleccionado.Id_cliente = 0;
            clienteseleccionado.Id_tipo_documento = 0;
            IdTipoDocumento = 0;
            NombreTipoDocumento = string.Empty;
            clienteseleccionado.Numero_documento = string.Empty;
            clienteseleccionado.Nombre = string.Empty;
            clienteseleccionado.Apellido = string.Empty;
            clienteseleccionado.Sexo = string.Empty;
            clienteseleccionado.Telefono = string.Empty;
            clienteseleccionado.Direccion = string.Empty;
            clienteseleccionado.Correo_electronico = string.Empty;
            clienteseleccionado.Nota = string.Empty;

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
            if ( clienteseleccionado.Id_cliente == 0 )
            {
                clienteseleccionado.Id_tipo_documento = IdTipoDocumento;
                if (FCliente.Insertar(clienteseleccionado) > 0)
                {
                    System.Windows.MessageBox.Show("Cliente guardado con éxito");
                    MostrarGuardarCancelar(false);
                    UpdateSources();

                }
                else
                {
                    System.Windows.MessageBox.Show("Error al guardar el cliente");
                }
            }
            else
            {
                clienteseleccionado.Id_tipo_documento = IdTipoDocumento;
                if (FCliente.Actualizar(clienteseleccionado) > 0)
                {
                    System.Windows.MessageBox.Show("Cliente modificado con éxito");
                    MostrarGuardarCancelar(false);
                    UpdateSources();

                }
                else
                {
                    System.Windows.MessageBox.Show("Error al modificar el cliente");
                }
            }
        }
        [RelayCommand]
        public void btnEliminar()
        {
            if (clienteseleccionado.Id_cliente > 0)
            {
                if (FCliente.Eliminar(clienteseleccionado) > 0)
                {
                    System.Windows.MessageBox.Show("Cliente eliminado con éxito");
                    UpdateSources();
                }
                else
                {
                    System.Windows.MessageBox.Show("Error al eliminar el cliente");
                }
            }

        }

    }
}


