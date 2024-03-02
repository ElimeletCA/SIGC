// This Source Code Form is subject to the terms of the MIT License.
// If a copy of the MIT was not distributed with this file, You can obtain one at https://opensource.org/licenses/MIT.
// Copyright (C) Leszek Pomianowski and WPF UI Contributors.
// All Rights Reserved.

using SIGC.WPF.View.ViewModels.Pages.Cliente;
using System.Collections.ObjectModel;
using System.Reflection;
using System.Windows.Media.Imaging;
using Wpf.Ui.Controls;
using Microsoft.Data.SqlClient;

namespace SIGC.WPF.View.ViewModels.Windows
{
    public partial class MainWindowViewModel : ObservableObject
    {
        [ObservableProperty]
        private string _applicationTitle = "Sistema Integral de Gestión Clinica";




        [ObservableProperty]
        private ObservableCollection<object> _menuItems = new()
        {

            new Image()
            {
                Source = new BitmapImage(new Uri(@"pack://application:,,,/Assets/perfil1.png", UriKind.Absolute)),
                Height = 100,
                MaxWidth = 100,
                CornerRadius = new CornerRadius(50),
                HorizontalAlignment = HorizontalAlignment.Center
            },
            new TextBlock()
            {
                Name = "UserName",
                Text = "Dr. Maria Dolores",
                FontWeight = FontWeights.Bold,
                Visibility = Visibility.Visible,
                HorizontalAlignment = HorizontalAlignment.Center,
            },
            new NavigationViewItemSeparator(),

            new NavigationViewItem()
            {
                Content = "Inicio",
                Icon = new SymbolIcon { Symbol = SymbolRegular.Home32, Filled = true},
                TargetPageType = typeof(Views.Pages.DashboardPage)

            },
            new NavigationViewItemSeparator(),

            new NavigationViewItem()
            {
                Content = "Facturación",
                Icon = new SymbolIcon { Symbol = SymbolRegular.Cart24, Filled = true},
                MenuItems = new object[]
                {
                    new NavigationViewItem("Facturas", SymbolRegular.WalletCreditCard32, typeof(Views.Pages.DataPage)),
                    new NavigationViewItem("Clientes", SymbolRegular.Person32, typeof(Views.Pages.Cliente.ListaClientePage)),
                    new NavigationViewItem("Cajas", SymbolRegular.MoneyCalculator24, typeof(Views.Pages.DataPage))
                }
            },
            new NavigationViewItem()
            {
                Content = "Inventario",
                Icon = new SymbolIcon { Symbol = SymbolRegular.BoxMultiple24, Filled = true},
                MenuItems = new object[]
                {
                    new NavigationViewItem("Proveedores", SymbolRegular.PersonAccounts24, typeof(Views.Pages.DataPage)),
                    new NavigationViewItem("Productos", SymbolRegular.ShoppingBag24, typeof(Views.Pages.DataPage)),
                    new NavigationViewItem("Categorías", SymbolRegular.TagMultiple24, typeof(Views.Pages.DataPage)),
                    new NavigationViewItem("Compras", SymbolRegular.ReceiptMoney24, typeof(Views.Pages.DataPage))
                }
            },            
            new NavigationViewItem()
            {
                Content = "Recursos Humanos",
                Icon = new SymbolIcon { Symbol = SymbolRegular.PeopleTeam32, Filled = true},
                MenuItems = new object[]
                {
                    new NavigationViewItem("Médicos", SymbolRegular.Doctor48, typeof(Views.Pages.DataPage)),
                    new NavigationViewItem("Empleados", SymbolRegular.PeopleToolbox20, typeof(Views.Pages.DataPage)),
                    new NavigationViewItem("Cajeros", SymbolRegular.PeopleMoney24, typeof(Views.Pages.DataPage))
                }
            },
            new NavigationViewItem()
            {
                Content = "Administración",
                Icon = new SymbolIcon { Symbol = SymbolRegular.WrenchScrewdriver24, Filled = true},
                MenuItems = new object[]
                {
                    new NavigationViewItem("Roles", SymbolRegular.PeopleSettings28, typeof(Views.Pages.DataPage)),
                    new NavigationViewItem("Permisos", SymbolRegular.Key32, typeof(Views.Pages.DataPage)),
                    new NavigationViewItem("Configuración", SymbolRegular.Settings48, typeof(Views.Pages.DataPage)),
                    new NavigationViewItem("Módulos", SymbolRegular.ContentSettings32, typeof(Views.Pages.DataPage)),
                    new NavigationViewItem("Extras", SymbolRegular.DockRow20, typeof(Views.Pages.DataPage)),

                    new NavigationViewItem("Usuarios", SymbolRegular.PeopleStar48, typeof(Views.Pages.DataPage))

                }
            },
            new NavigationViewItem()
            {
                Content = "Pacientes",
                Icon = new SymbolIcon { Symbol = SymbolRegular.PeopleAudience24, Filled = true},
                MenuItems = new object[]
                {
                    new NavigationViewItem("Citas", SymbolRegular.CalendarRtl48, typeof(Views.Pages.DataPage)),
                    new NavigationViewItem("Consultas", SymbolRegular.BriefcaseMedical32, typeof(Views.Pages.DataPage)),
                    new NavigationViewItem("Pacientes", SymbolRegular.PersonHeart24, typeof(Views.Pages.DataPage)),
                    new NavigationViewItem("Recetas", SymbolRegular.DocumentCatchUp24, typeof(Views.Pages.DataPage)),
                    new NavigationViewItem("Historial Clínico", SymbolRegular.DocumentHeart24, typeof(Views.Pages.DataPage)),
                }
            },
            new NavigationViewItem()
            {
                Content = "Reportes",
                Icon = new SymbolIcon { Symbol = SymbolRegular.DataHistogram24, Filled = true},
                MenuItems = new object[]
                {
                    new NavigationViewItem("Ventas", SymbolRegular.ArrowTrendingLines24, typeof(Views.Pages.DataPage)),
                    new NavigationViewItem("Compras", SymbolRegular.BoxMultipleCheckmark24, typeof(Views.Pages.DataPage)),
                    new NavigationViewItem("Consultas", SymbolRegular.CalendarDataBar28, typeof(Views.Pages.DataPage))
                }
            },
            new NavigationViewItemSeparator(),

            new NavigationViewItem()
            {
                Content = "Cerrar Sesión",
                Icon = new SymbolIcon { Symbol = SymbolRegular.Power24, Filled = true},
                TargetPageType = typeof(Views.Pages.DashboardPage)

            }


        };

        [ObservableProperty]
        private ObservableCollection<object> _footerMenuItems = new()
        {

            new NavigationViewItem()
            {
                Content = "Configuración",
                Icon = new SymbolIcon { Symbol = SymbolRegular.Settings32, Filled = true },
                TargetPageType = typeof(Views.Pages.SettingsPage)
            }
        };

        [ObservableProperty]
        private ObservableCollection<MenuItem> _trayMenuItems = new()
        {
            new MenuItem { Header = "Inicio", Tag = "tray_home" }
        };
    }
}
