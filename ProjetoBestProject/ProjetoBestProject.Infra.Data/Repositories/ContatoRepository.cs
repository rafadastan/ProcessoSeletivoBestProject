using ProjetoBestProject.Infra.Data.Contexts;
using ProjetoBestProject.Infra.Data.Contracts;
using ProjetoBestProject.Infra.Data.Entities;

namespace ProjetoBestProject.Infra.Data.Repositories
{
    public class ContatoRepository : BaseRepository<Contato>, IContatoRepository
    {
        private readonly SqlContext _sqlContext;

        public ContatoRepository(SqlContext sqlContext) :  base(sqlContext)
        {
            _sqlContext = sqlContext;
        }
    }
}
