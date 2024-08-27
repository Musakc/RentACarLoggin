using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACarLoggin.Entities
{
    internal class Product
    {
        public string UserName { get; set; }
        public int Password { get; set; }
        public int ConfirmPassword { get; set; }
        public int PhoneNumber { get; set;}
        public string Name { get; set;}
        public string Surname { get; set;}
        public string Email { get; set;}
    }
}
