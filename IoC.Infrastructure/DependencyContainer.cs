using Banking.Application.Interface;
using Banking.Application.Services;
using Banking.Data.Respository;
using Banking.Domain.CommandHandlers;
using Banking.Domain.Commands;
using Banking.Domain.Interface;
using Bus.Instrastructure;
using MediatR;
using Microservice.Core.Bus;
using Microsoft.Extensions.DependencyInjection;
using Transfer.Application.Interface;
using Transfer.Application.Services;
using Transfer.Data.Context;
using Transfer.Data.Respository;
using Transfer.Domain.EventHandlers;
using Transfer.Domain.Events;
using Transfer.Domain.Interface;

namespace IoC.Infrastructure
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            services.AddSingleton<IEventBus, RabbitMQBus>(sp=>
            {
                var scopFactory = sp.GetRequiredService<IServiceScopeFactory>();
                return new RabbitMQBus(sp.GetService<IMediator>(), scopFactory);
            });
            services.AddTransient<TransferEventHandler>();
            //Application Services
            services.AddTransient<IAccountService, AccountService>();
            services.AddTransient<IAccountTransferService, AccountTransferService>();
            // Domain
            services.AddTransient<IRequestHandler<CreateTransferCommand,bool>, TransferCommandHandler>();
            services.AddTransient<IEventHandler<TransferCreatedEvent>, TransferEventHandler>();
            // Data Services
            services.AddTransient<IAccountRepository, AccountRepository>();
            services.AddTransient<IAccountTransferRepository, AccountTransferRepository>();
            services.AddTransient<TransferDbContext>();
        }
    }
}
