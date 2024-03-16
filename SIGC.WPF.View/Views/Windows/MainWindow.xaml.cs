// This Source Code Form is subject to the terms of the MIT License.
// If a copy of the MIT was not distributed with this file, You can obtain one at https://opensource.org/licenses/MIT.
// Copyright (C) Leszek Pomianowski and WPF UI Contributors.
// All Rights Reserved.

using SIGC.WPF.View.ViewModels.Windows;
using System.Windows.Controls;
using Wpf.Ui;
using Wpf.Ui.Appearance;
using Wpf.Ui.Controls;

namespace SIGC.WPF.View.Views.Windows
{
    public partial class MainWindow : INavigationWindow
    {
        public MainWindowViewModel ViewModel { get; }

        public MainWindow(
            MainWindowViewModel viewModel,
            IPageService pageService,
            INavigationService navigationService
        )
        {
            ViewModel = viewModel;
            DataContext = this;

            SystemThemeWatcher.Watch(this);

            InitializeComponent();
            SetPageService(pageService);

            navigationService.SetNavigationControl(RootNavigation);
            ApplicationThemeManager.Apply(ApplicationTheme.Light);
        }

        #region INavigationWindow methods

        public INavigationView GetNavigation() => RootNavigation;

        public bool Navigate(Type pageType) => RootNavigation.Navigate(pageType);

        public void SetPageService(IPageService pageService) => RootNavigation.SetPageService(pageService);

        public void ShowWindow() => Show();
     
        public void CloseWindow() => Close();

        #endregion INavigationWindow methods

        /// <summary>
        /// Raises the closed event.
        /// </summary>
        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);

            // Make sure that closing this window will begin the process of closing the application.
            Application.Current.Shutdown();
        }

        INavigationView INavigationWindow.GetNavigation()
        {
            throw new NotImplementedException();
        }

        public void SetServiceProvider(IServiceProvider serviceProvider)
        {
            throw new NotImplementedException();
        }

        private void RootNavigation_ContextMenuClosing(object sender, System.Windows.Controls.ContextMenuEventArgs e)
        {

            System.Windows.MessageBox.Show("Closing");
            //Console.WriteLine(RootNavigation.MenuItems[0]);
            

        }

        private void RootNavigation_PaneOpened(NavigationView sender, RoutedEventArgs args)
        {
            var textBlock = RootNavigation.MenuItems.OfType<Wpf.Ui.Controls.TextBlock>().FirstOrDefault(tb => tb.Name == "UserName");
            textBlock.Visibility = Visibility.Visible;
        }
         private void RootNavigation_PaneClosed(NavigationView sender, RoutedEventArgs args)
         {

            var textBlock = RootNavigation.MenuItems.OfType<Wpf.Ui.Controls.TextBlock>().FirstOrDefault(tb => tb.Name == "UserName");
            textBlock.Visibility = Visibility.Hidden;
        }

    }
}
