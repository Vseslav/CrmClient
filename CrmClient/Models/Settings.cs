using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmClient.Models
{
    class Settings
    {
        public string Host { get; set; }
        public string UserName { get; set; }
        public string Organization { get; set; }
        public bool UseHttps { get; set; }
        public string Password { get; set; }
    }
}
