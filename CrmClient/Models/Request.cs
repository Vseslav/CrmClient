using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmClient.Models
{
    public class Request
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Owner { get; set; }
        public string CreatedOn { get; set; }
        public string Price { get; set; }
        public string Quantity { get; set; }
        public string Criticality { get; set; }
        public string ItemId { get; set; }
        public string Made { get; set; }
        public string Img { get; set; }
    }
}
