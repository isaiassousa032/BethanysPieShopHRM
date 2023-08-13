using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BethanysPieShopHRM.HR
{
    public class Address
    {
        private string _street;
        private string _houseNumber;
        private string _zipCode;
        private string _city;

        public Address(string street, string houseNumber, string zipCode, string city)
        {
            Street = street;
            HouseNumber = houseNumber;
            ZipCode = zipCode;
            City = city;
        }

        public string Street
        {
            get => _street;
            set => _street = value;
        }
        public string HouseNumber
        {
            get => _houseNumber;
            set => _houseNumber = value;
        }
        public string ZipCode
        {
            get => _zipCode;
            set => _zipCode = value;
        }
        public string City
        {
            get => _city;
            set => _city = value;
        }
    }
}
