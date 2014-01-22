using System;
using System.IO.IsolatedStorage;
using System.ServiceModel.Channels;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using CrmClient.ViewModels;
using System.Windows.Input;

namespace CrmClient.Pages
{
    public partial class SettingsPage
    {
        private SettingsViewModel _settingsViewModel;

        public SettingsPage()
        {
            InitializeComponent();
            _settingsViewModel = new SettingsViewModel();
            DataContext = _settingsViewModel;
            Loaded += SettingsPage_Loaded;
            
        }

        void SettingsPage_Loaded(object sender, RoutedEventArgs e)
        {
            _settingsViewModel.GetSettings();
        }

        private void ApplySettingsClick(object sender, EventArgs e)
        {
            _settingsViewModel.SaveSettings();
            NavigationService.Navigate(new Uri("/Pages/ApprovalQueuePage.xaml", UriKind.Relative));
        }
    }
}