using BLL.Contracts;
using DAL.Contracts.Repositories;
using DAL.Models.DomainModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class MessageService : IMessageService
    {
        private readonly IMessageRepository _messageRepository;

        public MessageService(IMessageRepository messageRepository)
        {
            _messageRepository = messageRepository;
        }
        public async Task<ICollection<Message>> GetAllMessagesAsync()
        {
            var messages = await _messageRepository.GetItemsAsync();
            return messages;
        }

        public async Task<Message> GetMessageByIdAsync(int id)
        {
            var message = await _messageRepository.FindFirstAsync(b => b.Id == id);
            return message;
        }

        public async Task<bool> RemoveMessageAsync(int id)
        {
            var message = await GetMessageByIdAsync(id);
            return await _messageRepository.RemoveAsync(message);
        }

        public async Task<Message> CreateMessageAsync(Message message)
        {
            var addedMessage = await _messageRepository.AddAsync(message);
            return addedMessage;
        }

        public async Task<Message> EditMessageAsync(Message message)
        {
            var editMessage = await _messageRepository.UpdateAsync(message);
            return editMessage;
        }
    }
}
