﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraneshDataAcessLayer.Entity
{
    public class Registration
    {
        public long RegsitrationId { get; set; }
        public string UserName { get; set; }
        public string PassWord { get; set; }
        public string Email { get; set; }
        public long MobileNumber { get; set; }
        public object RegistrationId { get; internal set; }
        public object Address { get; set; }
    }
}
