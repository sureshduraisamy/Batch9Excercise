﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesslayerkavi
{
    public class Registration
    {

        public long RegsitrationId { get; set; }
        public string UserName { get; set; }
        public string PassWord { get; set; }
        public string Email { get; set; }
       
        public long MobileNumber { get; set; }
       
        public string Address { get; set; }
    }
}

