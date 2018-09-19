using BLL.Contracts;
using DAL.Contracts.Repositories;
using DAL.Models.DomainModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class ClientService : IClientService
    {
        private readonly IClientRepository _clientRepository;

        public ClientService(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }
        public async Task<ICollection<Client>> GetAllClientsAsync()
        {
            var clients = await _clientRepository.GetItemsAsync();
            return clients;
        }

        public async Task<Client> GetClientByIdAsync(int id)
        {
            var client = await _clientRepository.FindFirstAsync(b => b.Id == id);
            return client;
        }

        public async Task<bool> RemoveClientAsync(int id)
        {
            var client = await GetClientByIdAsync(id);
            return await _clientRepository.RemoveAsync(client);
        }

        public async Task<Client> CreateClientAsync(Client client)
        {
            var addedClient = await _clientRepository.AddAsync(client);
            return addedClient;
        }

        public async Task<Client> EditClientAsync(Client client)
        {
            var editClient = await _clientRepository.UpdateAsync(client);
            return editClient;
        }
    }
}
