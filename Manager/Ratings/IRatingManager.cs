using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Storege.Entity;
using WebApplication1.Storege;

namespace WebApplication1.Manager.Ratings
{
   public interface IRatingManager
    {
        Task<Rating> AddRating(CreateRating request);
        Task<IReadOnlyCollection<Rating>> GetAll();
        Task<Rating> UpdateRating(Guid id, CreateRating request);
        Task<Rating> GetRatingId(Guid id);
        Task<Rating> DelRating(Guid id, CreateRating request);
    }
}
