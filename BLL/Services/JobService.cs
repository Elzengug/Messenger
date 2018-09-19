using BLL.Contracts;
using DAL.Contracts.Repositories;
using DAL.Models.DomainModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class JobService  : IJobService
    {
        private readonly IJobRepository _jobRepository;

        public JobService(IJobRepository jobRepository)
        {
            _jobRepository = jobRepository;
        }
        public async Task<ICollection<Job>> GetAllJobsAsync()
        {
            var jobs = await _jobRepository.GetItemsAsync();
            return jobs;
        }

        public async Task<Job> GetJobByIdAsync(int id)
        {
            var job = await _jobRepository.FindFirstAsync(b => b.Id == id);
            return job;
        }

        public async Task<bool> RemoveJobAsync(int id)
        {
            var job = await GetJobByIdAsync(id);
            return await _jobRepository.RemoveAsync(job);
        }

        public async Task<Job> CreateJobAsync(Job job)
        {
            var addedJob = await _jobRepository.AddAsync(job);
            return addedJob;
        }

        public async Task<Job> EditJobAsync(Job job)
        {
            var editJob = await _jobRepository.UpdateAsync(job);
            return editJob;
        }
    }
}
