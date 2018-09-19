using DAL.Models.DomainModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BLL.Contracts
{
    public interface IClientGroupService
    {
        Task<ICollection<ClientGroup>> GetAllClientGroupsAsync();
        Task<ClientGroup> GetClientGroupByIdAsync(int id);
        Task<bool> RemoveClientGroupAsync(int id);
        Task<ClientGroup> CreateClientGroupAsync(ClientGroup clientGroup);
        Task<ClientGroup> EditClientGroupAsync(ClientGroup clientGroup);
    }
}
