using Microsoft.EntityFrameworkCore;
using ProjetoBestProject.Infra.Data.Contexts;
using ProjetoBestProject.Infra.Data.Contracts;
using System.Collections.Generic;
using System.Linq;

namespace ProjetoBestProject.Infra.Data.Repositories
{
    public abstract class BaseRepository<TEntity> : IBaseRepository<TEntity>
        where TEntity : class
    {
        private readonly SqlContext _sqlContext;

        protected BaseRepository(SqlContext sqlContext)
        {
            _sqlContext = sqlContext;
        }

        public void Alterar(TEntity entity)
        {
            _sqlContext.Entry(entity).State = EntityState.Modified;
            _sqlContext.SaveChanges();
        }

        public List<TEntity> Consultar()
        {
            return _sqlContext
                .Set<TEntity>()
                .ToList();
        }

        public void Excluir(TEntity entity)
        {
            _sqlContext.Entry(entity).State = EntityState.Deleted;
            _sqlContext.SaveChanges();
        }

        public void Inserir(TEntity entity)
        {
            _sqlContext.Entry(entity).State = EntityState.Added;
            _sqlContext.SaveChanges();
        }

        public TEntity ObterPorId(int id)
        {
            return _sqlContext
                .Set<TEntity>()
                .Find(id);
        }

        public void Dispose()
        {
            Dispose();
        }
    }
}
