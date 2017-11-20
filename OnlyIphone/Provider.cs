using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlyIphone
{
    class Provider
    {
        public string Name { get; set; }
        public int Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string City { get; set; }

        public Provider()
        {

        }

        public Provider(string Name, int Phone, string Email, string Address, string City)
        {
            this.Name = Name;
            this.Phone = Phone;
            this.Email = Email;
            this.Address = Address;
            this.City = City;
        }
    }
}
