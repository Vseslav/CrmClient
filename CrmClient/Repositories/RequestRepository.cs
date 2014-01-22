using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using CrmClient.Models;

namespace CrmClient.Repositories
{
    public class RequestRepository
    {
        public IList<Request> GetRequests()
        {

            Thread.Sleep(3000);
            var requests = new List<Request>();
            for (int i = 0; i < 25; i++)
            {
                requests.Add(new Request
                {
                    Id = i.ToString(CultureInfo.InvariantCulture),
                    Title = "Dynamics EAM" + i.ToString(CultureInfo.InvariantCulture),
                    Owner = "Owner",
                    CreatedOn = DateTime.Now.ToString(CultureInfo.InvariantCulture),
                    Price= Convert.ToString("$3,501,00")
                });
            }
            return requests;
        } 
    }
}
