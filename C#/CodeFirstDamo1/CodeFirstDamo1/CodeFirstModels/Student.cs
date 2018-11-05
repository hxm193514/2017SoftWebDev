using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstDamo1.CodeFirstModels
{
   public class Student
    {
        public Guid StudentID { get; set; }
        public string StudentName { get; set; }
        public string Class { get; set; }
        public bool Sex { get; set; }
        public string phone { get; set; }
        public Student()
        {
            StudentID = Guid.NewGuid();
        }
    }
}
