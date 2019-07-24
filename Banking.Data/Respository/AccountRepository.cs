using Banking.Data.Context;
using Banking.Domain.Interface;
using Banking.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Banking.Data.Respository
{
    public class AccountRepository : IAccountRepository
    {
        private BankingDbContext _ctx;

        public AccountRepository(BankingDbContext ctx)
        {
            _ctx = ctx;
        }
        public IEnumerable<Account> GetAccounts()
        {
           return  _ctx.Accounts;
        }
    }
}
