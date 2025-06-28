using LAB12_REYES.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace LAB12_REYES.Data
{
    public class DBContext: DbContext
    {


        
        public DbSet<Course> Courses { get; set; }
       public DbSet<Grade> Grades { get; set; }

        public DbSet<Enrollment> Enrollments { get; set; }

        public DbSet<Student> Students { get; set; }

        public DBContext(DbContextOptions<DBContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=LAB411-020\SQLEXPRESS;Database=school;Trusted_Connection=True;Encrypt=True;TrustServerCertificate=True;");
        }

    }
}
