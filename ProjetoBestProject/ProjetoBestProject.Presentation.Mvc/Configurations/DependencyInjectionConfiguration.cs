using Microsoft.Extensions.DependencyInjection;
using ProjetoBestProject.Domain.Contracts.Services;
using ProjetoBestProject.Domain.Services;
using ProjetoBestProject.Infra.Data.Contracts;
using ProjetoBestProject.Infra.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoBestProject.Presentation.Mvc.Configurations
{
    public class DependencyInjectionConfiguration
    {
        public static void AddDependencyInjection(IServiceCollection services)
        {
            #region Domain

            services.AddScoped<IContatoDomainService, ContatoDomainService>();

            #endregion

            #region InfraStructure

            services.AddTransient<IContatoRepository, ContatoRepository>();

            #endregion

        }
    }
}
