using Transfer.Application.Model;
using System;
using System.Collections.Generic;
using System.Text;
using Transfer.Domain.Model;

namespace Transfer.Application.Interface
{
    public interface IAccountTransferService
    {
        IEnumerable<TransferLog> GetTransferLog();
       // void Transfer(AccountTransfer accountTransfer);
    }
}
