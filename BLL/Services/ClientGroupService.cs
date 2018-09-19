using BLL.Contracts;
using DAL.Contracts.Repositories;
using DAL.Models.DomainModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class ClientGroupService : IClientGroupService
    {
        private readonly IClientGroupRepository _clientGroupRepository;

        public ClientGroupService(IClientGroupRepository clientGroupRepository)
        {
            _clientGroupRepository = clientGroupRepository;
        }
        public async Task<ICollection<ClientGroup>> GetAllClientGroupsAsync()
        {
            var clientGroups = await _clientGroupRepository.GetItemsAsync();
            return clientGroups;
        }

        public async Task<ClientGroup> GetClientGroupByIdAsync(int id)
        {
            var clientGroup = await _clientGroupRepository.FindFirstAsync(b => b.ClientId == id);
            return clientGroup;
        }

        public async Task<bool> RemoveClientGroupAsync(int id)
        {
            var clientGroup = await GetClientGroupByIdAsync(id);
            return await _clientGroupRepository.RemoveAsync(clientGroup);
        }

        public async Task<ClientGroup> CreateClientGroupAsync(ClientGroup clientGroup)
        {
            var addedClientGroup = await _clientGroupRepository.AddAsync(clientGroup);
            return addedClientGroup;
        }

        public async Task<ClientGroup> EditClientGroupAsync(ClientGroup clientGroup)
        {
            var editClientGroup = await _clientGroupRepository.UpdateAsync(clientGroup);
            return editClientGroup;
        }
    }
}
