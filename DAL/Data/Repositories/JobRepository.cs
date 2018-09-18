using DAL.Contracts.Context;
using DAL.Models.DomainModels;

namespace DAL.Data.Repositories
{
    public class JobRepository : GenericRepository<Job>
    {
        public JobRepository(IDbContext dbContext) : base(dbContext)
        {

        }
    }
}

