using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.DTO
{
    public class AddressDTO
    {
        public int AddressID { get; set; }
        public string StreetName { get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; }
        public string Country { get; set; }

        public AddressDTO() { }
        public AddressDTO(AddressDTO addressDTO)
        {

        }
    }
}
