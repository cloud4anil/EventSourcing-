using Microservice.Core.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace Banking.Domain.Commands
{
    public abstract class TransferCommand:Command
    {
        public int From { get; protected set; }
        public int To { get; protected set; }
        public Decimal Ammount { get; protected set; }
    }
}
