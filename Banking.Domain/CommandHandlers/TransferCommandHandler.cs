using Banking.Domain.Commands;
using Banking.Domain.Events;
using MediatR;
using Microservice.Core.Bus;
using System.Threading;
using System.Threading.Tasks;
namespace Banking.Domain.CommandHandlers
{
    public class TransferCommandHandler : IRequestHandler<CreateTransferCommand,bool>
    {
        private readonly IEventBus _bus;
        public TransferCommandHandler(IEventBus bus)
        {
            _bus = bus;
        }
            
        public Task<bool> Handle(CreateTransferCommand request, CancellationToken cancellationToken)
        {
            // publish event to RabbitMQ
            _bus.Publish(new TransferCreatedEvent(request.From, request.To, request.Ammount));
            return Task.FromResult(true);
        }
    }
}
