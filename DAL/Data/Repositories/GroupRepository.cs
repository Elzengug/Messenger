using DAL.Contracts.Context;
using DAL.Models.DomainModels;

namespace DAL.Data.Repositories
{
    public class GroupRepository : GenericRepository<Group>
    {
        public GroupRepository(IDbContext dbContext) : base(dbContext)
        {

        }
    }
}
