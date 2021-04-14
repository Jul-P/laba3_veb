using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Storege.Entity;
using WebApplication1.Storege;
using WebApplication1.Manager;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Manager.Hobbys

{
    public class HobbyManager : IHobbyManager
    {
        private readonly DekanatDataContext _dbConext;
        private readonly IWebHostEnvironment _hostEnvirvoment;
        public HobbyManager(DekanatDataContext dbConext, IWebHostEnvironment hostEnvirvoment)
        {
            _hostEnvirvoment = hostEnvirvoment;
            _dbConext = dbConext;
        }
        public async Task<Hobby> AddHobby(CreateHobby request)
        {
            var entity = new Hobby
            {
                Id = Guid.NewGuid(),
                hobby = request.hobby
            };
            _dbConext.Hobbies.Add(entity);
            await _dbConext.SaveChangesAsync();
            return entity;
        }
        public async Task<IReadOnlyCollection<Hobby>> GetAll()
        {
            var query = _dbConext.Hobbies
                                  .OrderBy(st => st.hobby);
            var entitys = await query.ToListAsync();
            return entitys;
        }
        public async Task<Hobby> UpdateHobby(Guid id, CreateHobby request)
        {
            var entity = await _dbConext.Hobbies.FirstOrDefaultAsync(g => g.Id == id);
            entity.hobby = request.hobby;
            await _dbConext.SaveChangesAsync();
            return entity;
        }
       
        public async Task<Hobby> GetHobbyId(Guid id)
        {
            return await _dbConext.Hobbies.FirstOrDefaultAsync(g => g.Id == id);
        }
        public async Task<Hobby> DelHobby(Guid id, CreateHobby request)
        {
            var entity = await _dbConext.Hobbies.FirstOrDefaultAsync(g => g.Id == id);
            _dbConext.Hobbies.Remove(entity);
            await _dbConext.SaveChangesAsync();
            return entity;
        }
    }
}