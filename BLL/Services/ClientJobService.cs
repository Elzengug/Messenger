using BLL.Contracts;
using DAL.Contracts.Repositories;
using DAL.Models.DomainModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class ClientJobService : IClientJobService
    {
        private readonly IClientJobRepository _clientJobRepository;

        public ClientJobService(IClientJobRepository clientJobRepository)
        {
            _clientJobRepository = clientJobRepository;
        }
        public async Task<ICollection<ClientJob>> GetAllClientJobsAsync()
        {
            var clientJobs = await _clientJobRepository.GetItemsAsync();
            return clientJobs;
        }

        public async Task<ClientJob> GetClientJobByIdAsync(int id)
        {
            var clientJob = await _clientJobRepository.FindFirstAsync(b => b.ClientId == id);
            return clientJob;
        }

        public async Task<bool> RemoveClientJobAsync(int id)
        {
            var clientJob = await GetClientJobByIdAsync(id);
            return await _clientJobRepository.RemoveAsync(clientJob);
        }

        public async Task<ClientJob> CreateClientJobAsync(ClientJob clientJob)
        {
            var addedClientJob = await _clientJobRepository.AddAsync(clientJob);
            return addedClientJob;
        }

        public async Task<ClientJob> EditClientJobAsync(ClientJob clientJob)
        {
            var editClientJob = await _clientJobRepository.UpdateAsync(clientJob);
            return editClientJob;
        }
    }
}
