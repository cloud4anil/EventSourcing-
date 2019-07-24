using System;
using System.Collections.Generic;
using System.Text;

namespace Transfer.Application.Model
{
    public class AccountTransfer
    {
        public int AccountTo { get; set; }
        public int AccountFrom { get; set; }

        public decimal TransferAmmount { get; set; }
    }
}
