using DAL.Contracts.Context;
using DAL.Contracts.Repositories;
using DAL.Models.DomainModels;

namespace DAL.Data.Repositories
{
    public class ClientJobRepository : GenericRepository<ClientJob>, IClientJobRepository
    {
        public ClientJobRepository(IDbContext dbContext) : base(dbContext)
        {

        }
    }
}
