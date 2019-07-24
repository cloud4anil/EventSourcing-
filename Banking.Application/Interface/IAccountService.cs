using Banking.Application.Model;
using Banking.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Banking.Application.Interface
{
    public interface IAccountService
    {
        IEnumerable<Account> GetAccounts();
        void Transfer(AccountTransfer accountTransfer);
    }
}
