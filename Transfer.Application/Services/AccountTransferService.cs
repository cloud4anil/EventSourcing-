using Transfer.Application.Interface;
using Transfer.Application.Model;
using Transfer.Domain.Interface;

using Microservice.Core.Bus;
using System;
using System.Collections.Generic;
using System.Text;
using Transfer.Domain.Model;

namespace Transfer.Application.Services
{
    public class AccountTransferService : IAccountTransferService
    {
        private readonly IAccountTransferRepository _accountRepository;
        private readonly IEventBus _bus;
        public AccountTransferService(IAccountTransferRepository accountRepository, IEventBus bus)
        {
            _accountRepository = accountRepository;
            _bus = bus;
        }
        public IEnumerable<TransferLog> GetTransferLog()
        {
            return _accountRepository.GetTransferAccounts();
        }

        //public IEnumerable<TransferLog> GetTransferLog()
        //{
        //    throw new NotImplementedException();
        //}

        //public void Transfer(AccountTransfer accountTransfer)
        //{
        //    var createTransferCommand = new CreateTransferCommand(accountTransfer.AccountFrom, accountTransfer.AccountTo, accountTransfer.TransferAmmount);
        //    _bus.SendCommand(createTransferCommand);
        //}
    }
}
