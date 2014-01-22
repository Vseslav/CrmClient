using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmClient.Models
{
    class Item
    {
        public string Price { get; set; }
        public double Quantity { get; set; }
        public string Criticality { get; set; }
        public string ItemId { get; set; }
        public string Made { get; set; }
        public string Part { get; set; }
    }
}
