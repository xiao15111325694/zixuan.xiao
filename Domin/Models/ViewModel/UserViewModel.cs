using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Domian
{
    public class UserViewModel
    {
        public int ID { get; set; }

        public string FullName { get; set; }

        public DateTime? CreateTime { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }
    }
}