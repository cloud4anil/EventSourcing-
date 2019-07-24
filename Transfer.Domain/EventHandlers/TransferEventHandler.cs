using Microservice.Core.Bus;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Transfer.Domain.Events;
using Transfer.Domain.Interface;

namespace Transfer.Domain.EventHandlers
{
    public class TransferEventHandler : IEventHandler<TransferCreatedEvent>
    {
        private readonly IAccountTransferRepository _accountTransferRepository;
        public TransferEventHandler(IAccountTransferRepository accountTransferRepository)
        {
            _accountTransferRepository = accountTransferRepository;
        }
        public Task Handle(TransferCreatedEvent @event)
        {
            _accountTransferRepository.Add(new Model.TransferLog { FromAccount=@event.From, ToAccount=@event.To,TransferBalance=@event.Ammount});
            return Task.CompletedTask;
        }
    }
}
