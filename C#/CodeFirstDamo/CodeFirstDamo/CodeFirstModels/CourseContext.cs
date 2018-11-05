using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstDamo.CodeFirstModels
{
   public class CourseContext:DbContext
    {
        public DbSet<Departent> Departments { get; set; }
        public DbSet<Coures> Coures { get; set; }
        public DbSet<Student> Student { get; set; }
    }
}
