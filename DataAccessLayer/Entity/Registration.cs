using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entity
{
    public class Registration
    {
        public long RegsitrationId { get; set; }
        [Required]
        [MinLength(8)]
        public string UserName { get; set; }
        [Required]
        //[Compare("PassWord")]
        public string PassWord { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public long MobileNumber { get; set; }
        public string Address { get; set; }
    }
}
