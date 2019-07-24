using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Banking.Web.Models
{
    public class TransferViewModel
    {
        public int FromAccount { get; set; }
        public int ToAccount { get; set; }
        public decimal TeansferAmmount { get; set; }
    }
}
