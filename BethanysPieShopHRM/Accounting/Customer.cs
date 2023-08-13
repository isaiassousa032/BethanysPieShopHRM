using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BethanysPieShopHRM.Accounting
{
    internal class Customer
    {
        private string _customerId;
        private string name;

        public string CustomerId
        {
            get => _customerId;
            set => _customerId = value;
        }
        public string Name
        {
            get => name;
            set => name = value;
        }

    }
}
