using System.Collections.Generic;
using System.Collections.ObjectModel;
using CrmClient.Models;
using CrmClient.Repositories;

namespace CrmClient.ViewModels
{
    public class ApprovalQueueViewModel : BaseViewModel
    {
        private string title;
        public ObservableCollection<Request> Requests { get; set; }
        public string Title
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
                OnPropertyChanged();
            }
        }
        public ApprovalQueueViewModel()
        {
            Requests = new ObservableCollection<Request>();
        }

        public void GetData()
        {
            var repository = new RequestRepository();
          
            foreach (var request in repository.GetRequests())
            {
                Requests.Add(request);
            }
        }

        public ulong Count { get; set; }
    }
}
