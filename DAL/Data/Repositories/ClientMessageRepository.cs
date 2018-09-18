using DAL.Contracts.Context;
using DAL.Models.DomainModels;

namespace DAL.Data.Repositories
{
    public class ClientMessageRepository : GenericRepository<ClientMessage>
    {
        public ClientMessageRepository(IDbContext dbContext) : base(dbContext)
        {

        }
    }
}
