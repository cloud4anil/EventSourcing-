using Banking.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Banking.Domain.Interface
{
    public interface IAccountRepository
    {
        IEnumerable<Account> GetAccounts();
    }
}
