using System;
using System.Collections.Generic;
using System.Text;

namespace Transfer.Domain.Model
{
    public class TransferLog
    {
          
            public int Id { get; set; }
            public int FromAccount { get; set; }
            public int ToAccount { get; set; }
            public decimal TransferBalance { get; set; }
            public string ConsumerId { get; set; }

            public string GuidId { get; set; }


    }
}
