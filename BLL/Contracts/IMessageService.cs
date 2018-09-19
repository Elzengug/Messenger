using DAL.Models.DomainModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BLL.Contracts
{
    public interface IMessageService
    {
        Task<ICollection<Message>> GetAllMessagesAsync();
        Task<Message> GetMessageByIdAsync(int id);
        Task<bool> RemoveMessageAsync(int id);
        Task<Message> CreateMessageAsync(Message message);
        Task<Message> EditMessageAsync(Message message);
    }
}
