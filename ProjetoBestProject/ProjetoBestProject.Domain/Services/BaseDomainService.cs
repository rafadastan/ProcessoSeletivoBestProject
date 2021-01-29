using ProjetoBestProject.Infra.Data.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoBestProject.Domain.Services
{
    public abstract class BaseDomainService<TEntity> : IBaseRepository<TEntity>
        where TEntity : class
    {
        private readonly IBaseRepository<TEntity> _baseRepository;

        protected BaseDomainService(IBaseRepository<TEntity> baseRepository)
        {
            _baseRepository = baseRepository;
        }

        public virtual void Alterar(TEntity entity)
        {
            _baseRepository.Alterar(entity);
        }

        public virtual List<TEntity> Consultar()
        {
            return _baseRepository.Consultar();
        }

        public virtual void Excluir(TEntity entity)
        {
            _baseRepository.Excluir(entity);
        }

        public virtual void Inserir(TEntity entity)
        {
            _baseRepository.Inserir(entity);
        }

        public virtual TEntity ObterPorId(int id)
        {
            return _baseRepository.ObterPorId(id);
        }

    }
}
