using ProjetoBestProject.Domain.Contracts.Services;
using ProjetoBestProject.Infra.Data.Contracts;
using ProjetoBestProject.Infra.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoBestProject.Domain.Services
{
    public class ContatoDomainService : BaseDomainService<Contato>, IContatoDomainService
    {
        private readonly IContatoRepository repository;

        public ContatoDomainService(IContatoRepository repository) : base(repository)
        {
            this.repository = repository;
        }
    }
}
