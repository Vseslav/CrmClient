using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using CrmClient.ViewModels;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace CrmClient.Pages
{
    public partial class RequestDetailsPage : PhoneApplicationPage
    {
         private readonly ItemDetailsViewModel _viewModel;
         public RequestDetailsPage()
        {
            InitializeComponent();
            _viewModel = new ItemDetailsViewModel();
           DataContext = _viewModel.Requests;
            Loaded += ItemDetailsPage_Loaded;

        }

        void ItemDetailsPage_Loaded(object sender, RoutedEventArgs e)
        {
            _viewModel.GetData();
        }

    
    }
}