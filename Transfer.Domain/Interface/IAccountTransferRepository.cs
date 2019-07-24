
using System;
using System.Collections.Generic;
using System.Text;
using Transfer.Domain.Model;

namespace Transfer.Domain.Interface
{
    public interface IAccountTransferRepository
    {
        IEnumerable<TransferLog> GetTransferAccounts();
        void Add(TransferLog transferLog);
    }
}
