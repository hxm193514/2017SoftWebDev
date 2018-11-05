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
        //���ӷ���
        protected override void Seed(CodeFirstDamo.CodeFirstModels.CourseContext context)
        {

            context.Database.ExecuteSqlCommand("delete Coures");
            context.Database.ExecuteSqlCommand("delete departents");  
            //��ʼ��ѧԺ����
            var d1 = new Departent()
            {
                Name = "������Ϣ����",
                SortCode = "001",
                Description = "��һ��ѧԺ"
            };
            var d2 = new Departent()
            {
                Name = "������Ϣ����",
                SortCode = "002",
                Description = "�ڶ���ѧԺ"
            };
            var d3 = new Departent()
            {
                Name = "������Ϣ����",
                SortCode = "003",
                Description = "������ѧԺ"
            };
            var d4 = new Departent()
            {
                Name = "������Ϣ����",
                SortCode = "004",
                Description = "���Ĵ�ѧԺ"
            };
            context.Departments.Add(d1);
            context.Departments.Add(d2);
            context.Departments.Add(d3);
            context.Departments.Add(d4);
            context.SaveChanges();

            var c1 = new Coures()
            {
                Title = "C#�������",
                Credit = 7,
                Department = context.Departments.SingleOrDefault(x => x.Name == "������Ϣ����ѧԺ")
            };
            var c2 = new Coures()
            {
                Title = "Min������ʵս",
                Credit = 7,
                Department = context.Departments.SingleOrDefault(x => x.Name == "������Ϣ����ѧԺ")
            };
            var c3 = new Coures()
            {
                Title = "webӦ�ÿ���",
                Credit = 7,
                 Department = context.Departments.SingleOrDefault(x => x.Name == "������Ϣ����ѧԺ")
            };
            var c4 = new Coures()
            {
                Title = "��ҵ��ͼ",
                Credit = 4,
                Department = context.Departments.SingleOrDefault(x => x.Name == "���繤��ѧԺ")
            };
            var c5 = new Coures()
            {
                Title = "���������",
                Credit = 6,
                Department = context.Departments.SingleOrDefault(x => x.Name == "��������ѧԺ")
            };
            var c6 = new Coures()
            {
                Title = "������Ч",
                Credit = 6,
                Department = context.Departments.SingleOrDefault(x => x.Name == "�ƾ�������ѧԺ")
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
                StudentName = "Ф�ı�",
                Sex = true,
                Class = "17�������һ��",
                phone = "18877213447"
            };
            var s2 = new Student()
            {
                StudentName = "���佨",
                Sex = true,
                Class = "17�������һ��",
                phone = "18877213447"
            };
            var s3 = new Student()
            {
                StudentName = "��ѧ��",
                Sex = true,
                Class = "17�������һ��",
                phone = "18877213447"
            };
            var s4 = new Student()
            {
                StudentName = "ʩ���",
                Sex = true,
                Class = "17�������һ��",
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
