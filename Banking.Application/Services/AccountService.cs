using Banking.Application.Interface;
using Banking.Application.Model;
using Banking.Domain.Commands;
using Banking.Domain.Interface;
using Banking.Domain.Models;
using Microservice.Core.Bus;
using System;
using System.Collections.Generic;
using System.Text;

namespace Banking.Application.Services
{
    public class AccountService : IAccountService
    {
        private readonly IAccountRepository _accountRepository;
        private readonly IEventBus _bus;
        public AccountService(IAccountRepository accountRepository, IEventBus bus)
        {
            _accountRepository = accountRepository;
            _bus = bus;
        }
        public IEnumerable<Account> GetAccounts()
        {
            return _accountRepository.GetAccounts();
        }

        public void Transfer(AccountTransfer accountTransfer)
        {
            var createTransferCommand = new CreateTransferCommand(accountTransfer.AccountFrom, accountTransfer.AccountTo, accountTransfer.TransferAmmount);
            _bus.SendCommand(createTransferCommand);
        }
    }
}
