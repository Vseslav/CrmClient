using System.Globalization;
using CrmClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CrmClient.Repositories
{
    public class ItemRepository
    {
        public IList<Request> GetRequests()
        {

            Thread.Sleep(3000);
            var requests = new List<Request>();
            for (int i = 0; i < 1; i++)
            {
                requests.Add(new Request
                {
                    Img = "/1.jpg",
                    Price =Convert.ToString("$600.60 EA"),
                    Quantity = i.ToString(CultureInfo.InvariantCulture),
                    Criticality = "Owner",
                    ItemId = DateTime.Now.ToString(CultureInfo.InvariantCulture),
                    Made = "WINDSOR INDUSTRIAL"
                });
            }
            return requests;
        } 
    }
}
