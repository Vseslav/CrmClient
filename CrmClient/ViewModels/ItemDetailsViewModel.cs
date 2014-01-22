using System.Collections.ObjectModel;
using CrmClient.Models;
using CrmClient.Repositories;

namespace CrmClient.ViewModels
{
    public class ItemDetailsViewModel : BaseViewModel
    {
        public ObservableCollection<Request> Requests { get; set; }

        public ItemDetailsViewModel()
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
