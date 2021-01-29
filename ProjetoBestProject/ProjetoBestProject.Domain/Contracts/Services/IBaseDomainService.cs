using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoBestProject.Domain.Contracts.Services
{
    public interface IBaseDomainService<TEntity> 
        where TEntity : class
    {
        void Inserir(TEntity entity);
        void Alterar(TEntity entity);
        void Excluir(TEntity entity);
        List<TEntity> Consultar();
        TEntity ObterPorId(int id);
    }
}
