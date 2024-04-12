using DALHangfire.Repository.EventRepos;
using DALHangfire.Repository.HangfireRepos.SendTransaction;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PLHangfire.Services.Eventservs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLHangfire
{
    public static class PLServiceRegistration
    {
        public static IServiceCollection AddPLServices(this IServiceCollection services, IConfiguration configuration)
        {

            services.AddScoped<IEventService, EventService>();

            return services;
        }
    }
}
