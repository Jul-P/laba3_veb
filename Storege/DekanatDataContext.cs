using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Storege.Entity;

namespace WebApplication1.Storege
{
    public class DekanatDataContext: DbContext     
    {
        public DekanatDataContext(DbContextOptions<DekanatDataContext> options): base(options)
        {

        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Rating> Ratings { get; set; }
        public DbSet<Stependia> Stependias { get; set; }
        public DbSet<Hobby> Hobbies { get; set; }
        public DbSet<Prepod> Prepods { get; set; }
        public DbSet<Predmet> Predmets { get; set; }
    }
}
