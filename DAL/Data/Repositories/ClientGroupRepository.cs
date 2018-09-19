using DAL.Contracts.Context;
using DAL.Contracts.Repositories;
using DAL.Models.DomainModels;

namespace DAL.Data.Repositories
{
    public class ClientGroupRepository : GenericRepository<ClientGroup>, IClientGroupRepository
    {
        public ClientGroupRepository(IDbContext dbContext) : base(dbContext)
        {

        }
    }
}
