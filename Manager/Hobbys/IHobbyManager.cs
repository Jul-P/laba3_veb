using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Storege.Entity;

namespace WebApplication1.Manager.Hobbys
{
   public interface IHobbyManager
    {
        Task<Hobby> AddHobby(CreateHobby request);
        Task<IReadOnlyCollection<Hobby>> GetAll();
        Task<Hobby> UpdateHobby(Guid id, CreateHobby request);
        Task<Hobby> GetHobbyId(Guid id);
        Task<Hobby> DelHobby(Guid id, CreateHobby request);
    }
}
