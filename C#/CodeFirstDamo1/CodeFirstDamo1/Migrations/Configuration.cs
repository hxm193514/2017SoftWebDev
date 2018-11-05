namespace CodeFirstDamo1.Migrations
{
    using CodeFirstModels;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<CodeFirstDamo1.CodeFirstModels.CourseContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(CodeFirstDamo1.CodeFirstModels.CourseContext context)
        {
            //初始化学院数据
            var d1 = new School()
            {
                Name = "电子信息工程",
                SortCode = "001",
                Description = "第一大学院"
            };
            var d2 = new School()
            {
                Name = "电子信息工程",
                SortCode = "002",
                Description = "第二大学院"
            };
            var d3 = new School()
            {
                Name = "电子信息工程",
                SortCode = "003",
                Description = "第三大学院"
            };
            var d4 = new School()
            {
                Name = "电子信息工程",
                SortCode = "004",
                Description = "第四大学院"
            };
            context.School.Add(d1);
            context.School.Add(d2);
            context.School.Add(d3);
            context.School.Add(d4);
            context.SaveChanges();


            var c1 = new Course()
            {
                Title = "C#程序设计",
                Credit = 7,
                Department = context.School.SingleOrDefault(x => x.Name == "电子信息工程学院")
            };
            var c2 = new Course()
            {
                Title = "Min开发与实战",
                Credit = 7,
                Department = context.School.SingleOrDefault(x => x.Name == "电子信息工程学院")
            };
            var c3 = new Course()
            {
                Title = "web应用开发",
                Credit = 7,
                Department = context.School.SingleOrDefault(x => x.Name == "电子信息工程学院")
            };
            var c4 = new Course()
            {
                Title = "工业制图",
                Credit = 4,
                Department = context.School.SingleOrDefault(x => x.Name == "机电工程学院")
            };
            context.Course.Add(c1);
            context.Course.Add(c2);
            context.Course.Add(c3);
            context.Course.Add(c4);
            context.SaveChanges();
        }
    }
}
