using DAL.Models.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Contracts.Repositories
{
    public interface IJobRepository : IGenericRepository<Job>
    {
    }
}
