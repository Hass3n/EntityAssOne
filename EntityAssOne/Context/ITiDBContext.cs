using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityAssOne.Entities;
using Microsoft.EntityFrameworkCore;

namespace EntityAssOne.Context
{
    internal class ITiDBContext : DbContext
    {


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=ITIdb; Trusted_connection=true;Encrypt=false");
        }

        public DbSet<Course> Courses { get; set; }
        public DbSet<CourseInstructor> CourseInstructors { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Student> students { get; set; }
        public DbSet<StudentCourse> StudentCourse { get; set; }
        public DbSet<Topic> Topics { get; set; }



    }
}
