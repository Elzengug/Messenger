using DAL.Contracts.Context;
using DAL.Models.DomainModels;

namespace DAL.Data.Repositories
{
    public class ClientGroupRepository : GenericRepository<ClientGroup>
    {
        public ClientGroupRepository(IDbContext dbContext) : base(dbContext)
        {

        }
    }
}
