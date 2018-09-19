using DAL.Models.DomainModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BLL.Contracts
{
    public interface IClientMessageService
    {
        Task<ICollection<ClientMessage>> GetAllClientMessagesAsync();
        Task<ClientMessage> GetClientMessageByIdAsync(int id);
        Task<bool> RemoveClientMessageAsync(int id);
        Task<ClientMessage> CreateClientMessageAsync(ClientMessage clientMessage);
        Task<ClientMessage> EditCLientMessageAsync(ClientMessage clientMessage);
    }
}
