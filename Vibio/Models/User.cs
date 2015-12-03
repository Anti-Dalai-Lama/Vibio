using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vibio.Models
{
    public class User
    {
        public string Name { get; set; }
        public string PrimaryEmail { get; set; }
        public string AdditionalEmail { get; set; }
        public string Phone { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
    }
}