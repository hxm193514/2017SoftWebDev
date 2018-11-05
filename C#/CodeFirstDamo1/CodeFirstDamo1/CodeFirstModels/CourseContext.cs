using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstDamo1.CodeFirstModels
{
  public  class CourseContext: DbContext
    {
        public DbSet<Course> Course { get; set; }
        public DbSet<School> School { get; set; }
        public DbSet<Student> Student { get; set; }
    }
}
