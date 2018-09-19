using DAL.Models.DomainModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BLL.Contracts
{
    public interface IClientService
    {
        Task<ICollection<Client>> GetAllClientsAsync();
        Task<Client> GetClientByIdAsync(int id);
        Task<bool> RemoveClientAsync(int id);
        Task<Client> CreateClientAsync(Client client);
        Task<Client> EditClientAsync(Client client);
    }
}
