using DAL.Contracts.Context;
using DAL.Contracts.Repositories;
using DAL.Models.DomainModels;

namespace DAL.Data.Repositories
{
    public class ClientRepository : GenericRepository<Client>, IClientRepository
    {
        public ClientRepository(IDbContext dbContext) : base(dbContext)
        {

        }
    }
}
