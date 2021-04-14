using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Storege.Entity;
using WebApplication1.Storege;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Manager.Groups
{
    public class GroupManager : IGroupManager
    {
        private readonly DekanatDataContext _dbConext;
        private readonly IWebHostEnvironment _hostEnvirvoment;
        public GroupManager(DekanatDataContext dbConext, IWebHostEnvironment hostEnvirvoment)
        {
            _hostEnvirvoment = hostEnvirvoment;
            _dbConext = dbConext;
        }
        public async Task<Group> AddGroup(CreateGroup request)
        {
            var entity = new Group
            {
                Id = Guid.NewGuid(),
                Number = request.Number
            };
            _dbConext.Groups.Add(entity);
            await _dbConext.SaveChangesAsync();
            return entity;
        }
        public async Task<IReadOnlyCollection<Group>> GetAll()
        {
            var query = _dbConext.Groups
                                  .OrderBy(st => st.Number);
            var entitys = await query.ToListAsync();
            return entitys;
        }
        public async Task<Group> UpdateGroup(Guid id, CreateGroup request)
        {
            var entity = await _dbConext.Groups.FirstOrDefaultAsync(g => g.Id == id);
            entity.Number = request.Number;
            await _dbConext.SaveChangesAsync();
            return entity;
        }
       
        public async Task<Group> GetGroupId(Guid id)
        {
            return await _dbConext.Groups.FirstOrDefaultAsync(g => g.Id == id);
        }
        public async Task<Group> DelGroup(Guid id, CreateGroup request)
        {
            var entity = await _dbConext.Groups.FirstOrDefaultAsync(g => g.Id == id);
            _dbConext.Groups.Remove(entity);
            await _dbConext.SaveChangesAsync();
            return entity;
        }
    }
}
