using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraneshDataAcessLayer.Entity
{
    public class Registration
    {
        public long RegestrationID { get; set; }
        public string userName { get; set; }
        public string password { get; set; }
        public string email { get; set; }
        public string address { get; set; }
        public long mobileNumber { get; set; }
    }
}
