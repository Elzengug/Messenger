using DAL.Models.DomainModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BLL.Contracts
{
    public interface IClientJobService
    {
        Task<ICollection<ClientJob>> GetAllClientJobsAsync();
        Task<ClientJob> GetClientJobByIdAsync(int id);
        Task<bool> RemoveClientJobAsync(int id);
        Task<ClientJob> CreateClientJobAsync(ClientJob clientJob);
        Task<ClientJob> EditClientJobAsync(ClientJob clientJob);
    }
}
