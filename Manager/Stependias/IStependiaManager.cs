using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Storege.Entity;

namespace WebApplication1.Manager.Stependias
{
   public interface IStependiaManager
    {
        Task<Stependia> AddStependia(CreateStependia request);
        Task<IReadOnlyCollection<Stependia>> GetAll();
        Task<Stependia> UpdateStependia(Guid id, CreateStependia request);
        Task<Stependia> GetStependiaId(Guid id);
        Task<Stependia> DelStependia(Guid id, CreateStependia request);
    }
}
