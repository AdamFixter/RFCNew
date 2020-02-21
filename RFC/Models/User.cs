using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RFC.Models
{
    public class User
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public UserRole Role { get; set; }
        public string DomainUser { get; set; }
    }
}
