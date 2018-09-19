﻿using DAL.Contracts.Context;
using DAL.Contracts.Repositories;
using DAL.Models.DomainModels;

namespace DAL.Data.Repositories
{
    public class JobRepository : GenericRepository<Job>, IJobRepository
    {
        public JobRepository(IDbContext dbContext) : base(dbContext)
        {

        }
    }
}

