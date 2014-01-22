using System.Collections.ObjectModel;
using CrmClient.Models;
using CrmClient.Repositories;

namespace CrmClient.ViewModels
{
    public class RequestDetailsViewModel : BaseViewModel
    {
        public ObservableCollection<Request> Requests { get; set; }

        public RequestDetailsViewModel()
        {
            Requests = new ObservableCollection<Request>();
        }

        public void GetData()
        {
            var repository = new ItemRepository();
            foreach (var request in repository.GetRequests())
            {
                Requests.Add(request);
            }
        }
    }
}
