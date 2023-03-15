using DataAccess.StudentDB;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsManagement.DataAcces.DataContext
{
    public class StudentsManagementDBContext:DbContext
    {
        public StudentsManagementDBContext(DbContextOptions<StudentsManagementDBContext> options) : base(options)
        {

        }

        DbSet<Student> students { get; set; }
        DbSet<Class> classes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }

    }
}
