using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KarthickDataAccess.Entity
{
 public  class Registration
    {
        public long regsitrationId { get; set; }
        public string userName { get; set; }
        public string password { get; set; }
        public string email { get; set; }
        public string address { get; set; }
        public long mobileNumber { get; set; }
    }
}
