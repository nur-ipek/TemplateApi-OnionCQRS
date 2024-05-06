using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemplateApi.Application.Interfaces.Repositories;
using TemplateApi.Application.Interfaces.UnitOfWorks;
using TemplateApi.Persistence.Context;
using TemplateApi.Persistence.Repositories;
using TemplateApi.Persistence.UnitOfWorks;

namespace TemplateApi.Persistence
{
    public static class Registration
    {
        public static void AddPersistence(this IServiceCollection services,IConfiguration configuration) 
        {
            services.AddDbContext<AppDbContext>(opt =>
            opt.UseSqlServer(configuration.GetConnectionString("DefaultConnection"))
            );

            services.AddScoped(typeof(IReadRepository<>), typeof(ReadRepository<>));
            services.AddScoped(typeof(IWriteRepository<>), typeof(WriteRepository<>));

            //DI
            services.AddScoped<IUnitOfWork, UnitOfWork>();

        }

        
    }
}
