using DAL.Contracts.Context;
using DAL.Contracts.Repositories;
using DAL.Models.DomainModels;

namespace DAL.Data.Repositories
{
    public class MessageRepository : GenericRepository<Message> , IMessageRepository
    {
        public MessageRepository(IDbContext dbContext) : base(dbContext)
        {

        }
    }
}

