using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using TktSys.Business.Entities;
using TktSys.DeskPro;
using TktSys.Extensions;
using TktSys.ZenPro;

namespace TktSys
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDependencyRegistry();
            //services.AddTransient<ITicketService, DeskProService>();
            //services.AddTransient<ITicketService, ZenDeskService>();

            //services.AddTransient<DeskProService>();
            //services.AddTransient<ZenDeskService>();
            //services.AddTransient<Func<TicketSystemTypeEnum, ITicketService>>(serviceProvider => key =>
            //{
            //    switch (key)
            //    {
            //        case TicketSystemTypeEnum.DeskPro: return serviceProvider.GetRequiredService<DeskProService>();
            //        case TicketSystemTypeEnum.ZenDesk: return serviceProvider.GetRequiredService<ZenDeskService>();
            //        default:
            //            throw new KeyNotFoundException();
            //    }
            //});

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
