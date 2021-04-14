using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Storege;
using WebApplication1.Manager;
using WebApplication1.Storege.Entity;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Manager.Ratings
{
   
        public class RatingManager : IRatingManager
    {
            private readonly DekanatDataContext _dbConext;
            private readonly IWebHostEnvironment _hostEnvirvoment;
            public RatingManager(DekanatDataContext dbConext, IWebHostEnvironment hostEnvirvoment)
            {
                _hostEnvirvoment = hostEnvirvoment;
                _dbConext = dbConext;
            }
            public async Task<Rating> AddRating(CreateRating request)
            {
                var entity = new Rating
                {
                    Id = Guid.NewGuid(),
                    Result = request.Result
                };
                _dbConext.Ratings.Add(entity);
                await _dbConext.SaveChangesAsync();
                return entity;
            }
            public async Task<Rating> UpdateRating(Guid id, CreateRating request)
            {
                var entity = await _dbConext.Ratings.FirstOrDefaultAsync(g => g.Id == id);
                entity.Result = request.Result;
                await _dbConext.SaveChangesAsync();
                return entity;
            }
            public async Task<IReadOnlyCollection<Rating>> GetAll()
            {
                var query = _dbConext.Ratings
                                      .OrderBy(st => st.Result);
                var entitys = await query.ToListAsync();
                return entitys;
            }

            public async Task<Rating> GetRatingId(Guid id)
            {
                return await _dbConext.Ratings.FirstOrDefaultAsync(g => g.Id == id);
            }
            public async Task<Rating> DelRating(Guid id, CreateRating request)
            {
                var entity = await _dbConext.Ratings.FirstOrDefaultAsync(g => g.Id == id);
                _dbConext.Ratings.Remove(entity);
                await _dbConext.SaveChangesAsync();
                return entity;
            }
        }
}
