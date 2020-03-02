using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TktSys.Business.Entities;
using TktSys.DeskPro;
using TktSys.ZenPro;

namespace TktSys.Extensions
{
    public static class DynamicDIRegistry
    {
        public static IServiceCollection AddDependencyRegistry(this IServiceCollection services)
        {
            //services.AddScoped<ITicketService, DeskProService>();
            //services.AddScoped<ITicketService, ZenDeskService>();
            services.AddTransient<DeskProService>();
            services.AddTransient<ZenDeskService>();
            services.AddScoped<Func<TicketSystemTypeEnum, ITicketService>>(provider => (key) =>
            {
                switch (key)
                {
                    case TicketSystemTypeEnum.DeskPro: return provider.GetRequiredService<DeskProService>();
                    case TicketSystemTypeEnum.ZenDesk: return provider.GetRequiredService<ZenDeskService>();
                    default:
                        return null;
                }
            });
            return services;
        }
    }
}
