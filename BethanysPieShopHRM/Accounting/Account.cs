﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BethanysPieShopHRM.Accounting
{
    internal class Account
    {
        public string accountNumber { get; set; }

        public string AccountNumber
        {
            get { return accountNumber; }
            set
            {
                accountNumber = value;
            }
        }
    }
}
