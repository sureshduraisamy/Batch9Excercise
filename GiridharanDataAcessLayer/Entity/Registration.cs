using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiridharanDataAcessLayer.Entity
{
   public class Registration
    {
        public long RegistrationID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public long MobileNumber { get; set; }
    }
}
