using DAL.Contracts.Context;
using DAL.Models.DomainModels;

namespace DAL.Data.Repositories
{
    public class ClientJobRepository : GenericRepository<ClientJob>
    {
        public ClientJobRepository(IDbContext dbContext) : base(dbContext)
        {

        }
    }
}
