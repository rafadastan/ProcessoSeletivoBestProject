using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoBestProject.Infra.Data.Contracts
{
    public interface IBaseRepository<TEntity> 
    {
        void Inserir(TEntity entity);
        void Alterar(TEntity entity);
        void Excluir(TEntity entity);
        List<TEntity> Consultar();
        TEntity ObterPorId(int id);
    }
}
