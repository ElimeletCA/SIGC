// This Source Code Form is subject to the terms of the MIT License.
// If a copy of the MIT was not distributed with this file, You can obtain one at https://opensource.org/licenses/MIT.
// Copyright (C) Leszek Pomianowski and WPF UI Contributors.
// All Rights Reserved.
using SIGC.WPF.View.ViewModels.Pages.Cliente;
using SIGC.WPF.View.Models.Cliente;
using System.Data;
namespace SIGC.WPF.View.ViewModels.Pages
{
    public partial class DashboardViewModel : ObservableObject
    {
        [ObservableProperty]
        private DataTable _clientes;



        [RelayCommand]
        private void OnCounterIncrement()
        {
        }


    }
}
