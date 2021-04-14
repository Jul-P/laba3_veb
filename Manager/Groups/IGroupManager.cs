using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Storege.Entity;

namespace WebApplication1.Manager.Groups
{
   public interface IGroupManager
    {
        Task<Group> AddGroup(CreateGroup request);
        Task<IReadOnlyCollection<Group>> GetAll();
        Task<Group> UpdateGroup(Guid id, CreateGroup request);
        Task<Group> GetGroupId(Guid id);
        Task<Group> DelGroup(Guid id, CreateGroup request);
    }
}
