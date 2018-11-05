namespace CodeFirstDamo.Migrations
{
    using CodeFirstModels;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<CodeFirstDamo.CodeFirstModels.CourseContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }
        //种子方法
        protected override void Seed(CodeFirstDamo.CodeFirstModels.CourseContext context)
        {

            context.Database.ExecuteSqlCommand("delete Coures");
            context.Database.ExecuteSqlCommand("delete departents");  
            //初始化学院数据
            var d1 = new Departent()
            {
                Name = "电子信息工程",
                SortCode = "001",
                Description = "第一大学院"
            };
            var d2 = new Departent()
            {
                Name = "电子信息工程",
                SortCode = "002",
                Description = "第二大学院"
            };
            var d3 = new Departent()
            {
                Name = "电子信息工程",
                SortCode = "003",
                Description = "第三大学院"
            };
            var d4 = new Departent()
            {
                Name = "电子信息工程",
                SortCode = "004",
                Description = "第四大学院"
            };
            context.Departments.Add(d1);
            context.Departments.Add(d2);
            context.Departments.Add(d3);
            context.Departments.Add(d4);
            context.SaveChanges();

            var c1 = new Coures()
            {
                Title = "C#程序设计",
                Credit = 7,
                Department = context.Departments.SingleOrDefault(x => x.Name == "电子信息工程学院")
            };
            var c2 = new Coures()
            {
                Title = "Min开发与实战",
                Credit = 7,
                Department = context.Departments.SingleOrDefault(x => x.Name == "电子信息工程学院")
            };
            var c3 = new Coures()
            {
                Title = "web应用开发",
                Credit = 7,
                 Department = context.Departments.SingleOrDefault(x => x.Name == "电子信息工程学院")
            };
            var c4 = new Coures()
            {
                Title = "工业制图",
                Credit = 4,
                Department = context.Departments.SingleOrDefault(x => x.Name == "机电工程学院")
            };
            var c5 = new Coures()
            {
                Title = "发动机检测",
                Credit = 6,
                Department = context.Departments.SingleOrDefault(x => x.Name == "汽车工程学院")
            };
            var c6 = new Coures()
            {
                Title = "网络音效",
                Credit = 6,
                Department = context.Departments.SingleOrDefault(x => x.Name == "财经与物流学院")
            };
            context.Coures.Add(c1);
            context.Coures.Add(c2);
            context.Coures.Add(c3);
            context.Coures.Add(c4);
            context.Coures.Add(c5);
            context.Coures.Add(c6);
            context.SaveChanges();

            var s1 = new Student()
            {
                StudentName = "肖文斌",
                Sex = true,
                Class = "17软件技术一班",
                phone = "18877213447"
            };
            var s2 = new Student()
            {
                StudentName = "黄武建",
                Sex = true,
                Class = "17软件技术一班",
                phone = "18877213447"
            };
            var s3 = new Student()
            {
                StudentName = "黄学明",
                Sex = true,
                Class = "17软件技术一班",
                phone = "18877213447"
            };
            var s4 = new Student()
            {
                StudentName = "施扬恩",
                Sex = true,
                Class = "17软件技术一班",
                phone = "18877213447"
            };

            context.Student.Add(s1);
            context.Student.Add(s2);
            context.Student.Add(s3);
            context.Student.Add(s4);
           
            context.SaveChanges();
        }
    }
}
