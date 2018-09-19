using DAL.Models.DomainModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BLL.Contracts
{
    public interface IGroupService
    {
        Task<ICollection<Group>> GetAllGroupsAsync();
        Task<Group> GetGroupByIdAsync(int id);
        Task<bool> RemoveGroupAsync(int id);
        Task<Group> CreateGroupAsync(Group group);
        Task<Group> EditGroupAsync(Group group);
    }
}
