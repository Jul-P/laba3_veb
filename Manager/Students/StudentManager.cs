using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Storege.Entity;
using WebApplication1.Storege;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Manager.Students
{
    public class StudentManager : IStudentManager
    {
        private readonly DekanatDataContext _dbConext;
        private readonly IWebHostEnvironment _hostEnvirvoment;
        public StudentManager(DekanatDataContext dbConext, IWebHostEnvironment hostEnvirvoment)
        {
            _hostEnvirvoment = hostEnvirvoment;
            _dbConext = dbConext;
        }
        public async Task<Student> AddStudent(CreateOrUpdateStudent request)
        {
            var entity = new Student
            {
                Id = Guid.NewGuid(),
                Name = request.Name
            };
            _dbConext.Students.Add(entity);
            await _dbConext.SaveChangesAsync();
            return entity;
        }
        public async Task<Student> UpdateStudent(Guid id, CreateOrUpdateStudent request)
        {
            var entity = await _dbConext.Students.FirstOrDefaultAsync(g => g.Id == id);
            entity.Name = request.Name;
            await _dbConext.SaveChangesAsync();
            return entity;
        }
        public async Task<IReadOnlyCollection<Student>> GetAll()
        {
            var query = _dbConext.Students
                                  .OrderBy(st => st.Name);
            var entitys = await query.ToListAsync();
            return entitys;
        }

        public async Task<Student> GetStudentId(Guid id)
        {
            return await _dbConext.Students.FirstOrDefaultAsync(g => g.Id == id);
        }
        public async Task<Student> DelSudent(Guid id, CreateOrUpdateStudent request)
        {
            var entity = await _dbConext.Students.FirstOrDefaultAsync(g => g.Id == id);
            _dbConext.Students.Remove(entity);
            await _dbConext.SaveChangesAsync();
            return entity;
        }
       public async Task<Student> Find(CreateOrUpdateStudent request)
        {
            var entity = await _dbConext.Students.FirstOrDefaultAsync();
  
            if (entity.Name == request.Name) return entity; else return null;
        }
    }
       
}
