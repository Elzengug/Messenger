using DAL.Contracts.Context;
using DAL.Models.DomainModels;

namespace DAL.Data.Repositories
{
    public class ClientRepository : GenericRepository<Client>
    {
        public ClientRepository(IDbContext dbContext) : base(dbContext)
        {

        }
    }
}
