using DAL.Models.DomainModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BLL.Contracts
{
    public interface IJobService
    {
        Task<ICollection<Job>> GetAllJobsAsync();
        Task<Job> GetJobByIdAsync(int id);
        Task<bool> RemoveJobAsync(int id);
        Task<Job> CreateJobAsync(Job job);
        Task<Job> EditJobAsync(Job job);
    }
}
