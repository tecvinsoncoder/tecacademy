using TecAcademy.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace TecAcademy.Repositories.Data
{
    public class AcademyContext : DbContext
    {
        public AcademyContext(DbContextOptions<AcademyContext> options)
        : base(options)
        {
        }

        public DbSet<Institution> Institutions {set; get;}
        public DbSet<Faculty> Faculties {set; get;}
        public DbSet<Department> Departments {set; get;}
        public DbSet<Program> Programs {set; get;}
        public DbSet<Course> Courses {set; get;}
    }
}