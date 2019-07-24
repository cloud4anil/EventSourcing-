using Microservice.Core.Events;

namespace Transfer.Domain.Events
{
    public class TransferCreatedEvent:Event
    {
        public int From { get; private set; }

        public int To { get; private set; }

        public decimal Ammount { get; private set; }

        public TransferCreatedEvent(int from, int to, decimal ammount)
        {
            From = from;
            To = to;
            Ammount= ammount;        }
    }
}
