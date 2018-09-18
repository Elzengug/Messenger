using DAL.Contracts.Context;
using DAL.Models.DomainModels;

namespace DAL.Data.Repositories
{
    public class MessageRepository : GenericRepository<Message>
    {
        public MessageRepository(IDbContext dbContext) : base(dbContext)
        {

        }
    }
}

