using DALHangfire.Context;
using DALHangfire.Repository.EventRepos;
using DALHangfire.Repository.HangfireRepos.SendTransaction;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALHangfire
{
    public static class DALServiceRegistration
    {
        public static IServiceCollection AddDALServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<HangFireContext>(options => options.UseSqlServer(configuration.GetConnectionString("DbConnection")));

            services.AddScoped<IEventRepository, EventRepository>();
            services.AddScoped<ISendTransactionRepository, SendTransactionRepository>();

            return services;
        }
    }
}
