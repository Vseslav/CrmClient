using System;
using System.Windows;
using System.Windows.Input;
using CrmClient.Models;
using CrmClient.ViewModels;
using Microsoft.Phone.Shell;

namespace CrmClient.Pages
{
    public partial class ApprovalQueuePage
    {
        ProgressIndicator progressIndicator = new ProgressIndicator() { IsVisible = true, IsIndeterminate = true, Text = "Downloading items" };
        private readonly ApprovalQueueViewModel _viewModel;

        public ApprovalQueuePage()
        {
            InitializeComponent();
            SystemTray.SetProgressIndicator(this, progressIndicator);
            _viewModel = new ApprovalQueueViewModel();
            DataContext = _viewModel;           
            Loaded += ApprovalQueue_PageLoaded;
            ApplicationBar = (ApplicationBar) Resources["DefaultBar"];
        }

        private void ApprovalQueue_PageLoaded(object sender, RoutedEventArgs e)
        {
            _viewModel.GetData();
            CountItems.Text = Convert.ToString(_viewModel.Requests.Count)+"requests";
            progressIndicator.IsIndeterminate = false;
            progressIndicator.IsVisible = false;
        }


        private void MenuItemClick(object sender, EventArgs e)
        {
            NavigationService.Navigate(new Uri("/Pages/SettingsPage.xaml", UriKind.Relative));
        }

        private void Refresh_OnClick(object sender, EventArgs e)
        {
            NavigationService.Navigate(new Uri(NavigationService.Source + "?Refresh=true", UriKind.Relative));
        }

        private void Select_OnClick(object sender, EventArgs e)
        {
            RequestLongListMultiSelector.IsSelectionEnabled = Convert.ToBoolean("true");
            ApplicationBar = (ApplicationBar)Resources["SelectItemBar"];
            foreach (var button in ApplicationBar.Buttons)
            {
                ((ApplicationBarIconButton)button).IsEnabled = false;
            }
        }

        private void OnAplyClick(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
       

        private void AplyClick(object sender, EventArgs e)
        {
            NavigationService.Navigate(new Uri("/Pages/ItemDetailsPage.xaml", UriKind.Relative));
        }

        private void СancelClick(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void RequestLongListMultiSelector_OnMouseEnter(object sender, MouseEventArgs mouseEventArgs)
        {
            foreach (var button in ApplicationBar.Buttons)
            {
                ((ApplicationBarIconButton)button).IsEnabled = true;
            }
        }


        private void UIElement_OnMouseEnter(object sender, MouseEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Pages/ItemDetailsPage.xaml", UriKind.Relative));
        }

        private void RequestLongListMultiSelector_OnMouseLeave(object sender, MouseEventArgs e)
        {
            RequestLongListMultiSelector.IsSelectionEnabled = Convert.ToBoolean("true");
            foreach (var button in ApplicationBar.Buttons)
            {
                ((ApplicationBarIconButton)button).IsEnabled = false;
            } 
        }
    }
}