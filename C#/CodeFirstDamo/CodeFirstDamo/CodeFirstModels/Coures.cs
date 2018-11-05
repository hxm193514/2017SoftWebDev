using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstDamo.CodeFirstModels
{
   public class Coures
    {
        public Guid ID { get; set; }
        //课程名称
        public string Title { get; set; }
        //学分
        public int Credit { get; set; }
        //编号
        public string CourseCode { get; set; }
        //学时
        public int StudyPeriod { get; set; } = 0;
        //外键实体 用自定义的类型为属性
        public virtual Departent Department { get; set; }

        public Coures()
        {
            ID = Guid.NewGuid();
        }
    }
}
