

using Transfer.Domain.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using Transfer.Data.Context;
using Transfer.Domain.Model;
using Microsoft.Extensions.Options;

namespace Transfer.Data.Respository
{
    public class AccountTransferRepository : IAccountTransferRepository
    {
        private TransferDbContext _ctx;
      
        public AccountTransferRepository(TransferDbContext ctx)
        {
            _ctx = ctx;
           
        }

        public void Add(TransferLog transferLog)
        {
            transferLog.ConsumerId = System.Diagnostics.Process.GetCurrentProcess().Id.ToString();
            transferLog.GuidId = Guid.NewGuid().ToString();
            _ctx.TransferLogs.Add(transferLog);
            
            _ctx.SaveChanges();
        }

        public IEnumerable<TransferLog> GetTransferAccounts()
        {
           return  _ctx.TransferLogs;
        }
    }
}
