using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Storege.Entity;

namespace WebApplication1.Manager.Students
{
    public interface IStudentManager
    {
        Task<Student> AddStudent(CreateOrUpdateStudent request);
        Task <IReadOnlyCollection<Student>> GetAll();
        Task<Student> UpdateStudent(Guid id, CreateOrUpdateStudent request);
        Task<Student> GetStudentId(Guid id);
        Task<Student> DelSudent(Guid id, CreateOrUpdateStudent request);
        Task<Student> Find(CreateOrUpdateStudent request);
    }

}
