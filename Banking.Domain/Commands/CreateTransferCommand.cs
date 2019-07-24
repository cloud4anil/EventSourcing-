﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Banking.Domain.Commands
{
    public class CreateTransferCommand:TransferCommand
    {
        public CreateTransferCommand(int from , int to, decimal ammount)
        {
            From = from;
            To = to;
            Ammount = ammount;
        }
    }
}
