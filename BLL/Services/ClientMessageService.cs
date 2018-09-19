using BLL.Contracts;
using DAL.Contracts.Repositories;
using DAL.Models.DomainModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class ClientMessageService
    {
        private readonly IClientMessageRepository _clientMessageRepository;

        public ClientMessageService(IClientMessageRepository clientMessageRepository)
        {
            _clientMessageRepository = clientMessageRepository;
        }
        public async Task<ICollection<ClientMessage>> GetAllClientsAsync()
        {
            var clientMessages = await _clientMessageRepository.GetItemsAsync();
            return clientMessages;
        }

        public async Task<ClientMessage> GetClientMessageByIdAsync(int id)
        {
            var clientMessage = await _clientMessageRepository.FindFirstAsync(b => b.ClientId == id);
            return clientMessage;
        }

        public async Task<bool> RemoveClientAsync(int id)
        {
            var clientMessage = await GetClientMessageByIdAsync(id);
            return await _clientMessageRepository.RemoveAsync(clientMessage);
        }

        public async Task<ClientMessage> CreateClientAsync(ClientMessage clientMessage)
        {
            var addedClientMessage = await _clientMessageRepository.AddAsync(clientMessage);
            return addedClientMessage;
        }

        public async Task<ClientMessage> EditClientMessageAsync(ClientMessage clientMessage)
        {
            var editClientMessage = await _clientMessageRepository.UpdateAsync(clientMessage);
            return editClientMessage;
        }
    }
}
