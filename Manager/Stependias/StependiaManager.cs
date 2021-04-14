using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Storege.Entity;
using WebApplication1.Storege;
using Microsoft.EntityFrameworkCore;


namespace WebApplication1.Manager.Stependias
{
    public class StependiaManager: IStependiaManager
    {
        private readonly DekanatDataContext _dbConext;
        private readonly IWebHostEnvironment _hostEnvirvoment;
        public StependiaManager(DekanatDataContext dbConext, IWebHostEnvironment hostEnvirvoment)
        {
            _hostEnvirvoment = hostEnvirvoment;
            _dbConext = dbConext;
        }
        public async Task<Stependia> AddStependia(CreateStependia request)
        {
            var entity = new Stependia
            {
                Id = Guid.NewGuid(),
                Kek = request.Kek
            };
            _dbConext.Stependias.Add(entity);
            await _dbConext.SaveChangesAsync();
            return entity;
        }
        public async Task<Stependia> UpdateStependia(Guid id, CreateStependia request)
        {
            var entity = await _dbConext.Stependias.FirstOrDefaultAsync(g => g.Id == id);
            entity.Kek = request.Kek;
            await _dbConext.SaveChangesAsync();
            return entity;
        }
        public async Task<IReadOnlyCollection<Stependia>> GetAll()
        {
            var query = _dbConext.Stependias
                                  .OrderBy(st => st.Kek);
            var entitys = await query.ToListAsync();
            return entitys;
        }

        public async Task<Stependia> GetStependiaId(Guid id)
        {
            return await _dbConext.Stependias.FirstOrDefaultAsync(g => g.Id == id);
        }
        public async Task<Stependia> DelStependia(Guid id, CreateStependia request)
        {
            var entity = await _dbConext.Stependias.FirstOrDefaultAsync(g => g.Id == id);
            _dbConext.Stependias.Remove(entity);
            await _dbConext.SaveChangesAsync();
            return entity;
        }
    }
}
