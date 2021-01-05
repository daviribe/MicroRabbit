using MicroRabbit.Banking.Application.Interfaces;
using MicroRabbit.Banking.Application.Services;
using MicroRabbit.Banking.Data.Context;
using MicroRabbit.Banking.Data.Repositories;
using MicroRabbit.Banking.Domain.Interfaces;
using MicroRabbit.Domain.Core.Bus;
using MicroRabbit.Infra.Bus;
using Microsoft.Extensions.DependencyInjection;

namespace MicroRabbit.Infra.Ioc
{
    public static class DependecyContainer
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            services.AddTransient<IEventBus, RabbitBus>();

            // Application Services
            services.AddTransient<IAccountService, AccountService>();

            // Data
            services.AddTransient<BankingDbContext>();

            services.AddTransient<IAccountRepository, AccountRepository>();
        }
    }
}
