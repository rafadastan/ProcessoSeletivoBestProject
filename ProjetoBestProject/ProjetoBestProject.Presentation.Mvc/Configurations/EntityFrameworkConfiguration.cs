using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ProjetoBestProject.Infra.Data.Contexts;
using ProjetoBestProject.Infra.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoBestProject.Presentation.Mvc.Configurations
{
    public class EntityFrameworkConfiguration
    {
        
        public static void AddEntityFramework(IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<SqlContext>
                (options => options.UseSqlServer(configuration.GetConnectionString("DBProjetoContato")));
        }
    }
}
