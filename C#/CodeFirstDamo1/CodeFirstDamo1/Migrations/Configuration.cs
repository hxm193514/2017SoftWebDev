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
            //��ʼ��ѧԺ����
            var d1 = new School()
            {
                Name = "������Ϣ����",
                SortCode = "001",
                Description = "��һ��ѧԺ"
            };
            var d2 = new School()
            {
                Name = "������Ϣ����",
                SortCode = "002",
                Description = "�ڶ���ѧԺ"
            };
            var d3 = new School()
            {
                Name = "������Ϣ����",
                SortCode = "003",
                Description = "������ѧԺ"
            };
            var d4 = new School()
            {
                Name = "������Ϣ����",
                SortCode = "004",
                Description = "���Ĵ�ѧԺ"
            };
            context.School.Add(d1);
            context.School.Add(d2);
            context.School.Add(d3);
            context.School.Add(d4);
            context.SaveChanges();


            var c1 = new Course()
            {
                Title = "C#�������",
                Credit = 7,
                Department = context.School.SingleOrDefault(x => x.Name == "������Ϣ����ѧԺ")
            };
            var c2 = new Course()
            {
                Title = "Min������ʵս",
                Credit = 7,
                Department = context.School.SingleOrDefault(x => x.Name == "������Ϣ����ѧԺ")
            };
            var c3 = new Course()
            {
                Title = "webӦ�ÿ���",
                Credit = 7,
                Department = context.School.SingleOrDefault(x => x.Name == "������Ϣ����ѧԺ")
            };
            var c4 = new Course()
            {
                Title = "��ҵ��ͼ",
                Credit = 4,
                Department = context.School.SingleOrDefault(x => x.Name == "���繤��ѧԺ")
            };
            context.Course.Add(c1);
            context.Course.Add(c2);
            context.Course.Add(c3);
            context.Course.Add(c4);
            context.SaveChanges();
        }
    }
}
