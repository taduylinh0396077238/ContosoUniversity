using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ContosoUniversity.Models;

namespace ContosoUniversity.Data
{
    public class ContosoUniversity : DbContext
    {
        public ContosoUniversity(DbContextOptions<ContosoUniversity> options)
            : base(options)
        {
        }

        public DbSet<ContosoUniversity.Models.Student> Student { get; set; } = default!;
        public DbSet<ContosoUniversity.Models.Course> Course { get; set; } = default!;
        public DbSet<ContosoUniversity.Models.Enrollment> Enrollment { get; set; } = default!;
        public DbSet<Department> Departments { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<OfficeAssignment> OfficeAssignments { get; set; }
        public DbSet<CourseAssignment> CourseAssignments { get; set; }


    }
}