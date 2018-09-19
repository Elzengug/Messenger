using DAL.Contracts.Context;
using DAL.Contracts.Repositories;
using DAL.Models.DomainModels;

namespace DAL.Data.Repositories
{
    public class ClientMessageRepository : GenericRepository<ClientMessage>, IClientMessageRepository
    {
        public ClientMessageRepository(IDbContext dbContext) : base(dbContext)
        {

        }
    }
}
