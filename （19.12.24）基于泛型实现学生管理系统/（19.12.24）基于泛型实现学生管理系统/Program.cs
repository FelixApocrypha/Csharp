using System;
using System.Collections.Generic;

namespace StudentInformationManagementSystem
{
    public class Student
    {
        private int id;
        private string name;
        private int age;
        public List<Student> studentList = new List<Student>();

        public Student() { }
        public Student(int m_id, string m_name, int m_age)
        {
            this.id = m_id;
            this.name = m_name;
            this.age = m_age;
        }

        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public void InitList()
        {
            Console.Write("请输入要添加的学生数：");
            int studentNum = Convert.ToInt32(Console.ReadLine());
            int m_id, m_age;
            string m_name;
            for (int i = 1; i <= studentNum; i++)
            {
                Console.Write("请输入第" + i + "位学生的学号：");
                m_id = Convert.ToInt32(Console.ReadLine());
                Console.Write("请输入第" + i + "位学生的姓名：");
                m_name = Console.ReadLine();
                Console.Write("请输入第" + i + "位学生的年龄：");
                m_age = Convert.ToInt32(Console.ReadLine());
                studentList.Add(new Student(m_id, m_name, m_age));
                Console.WriteLine("第" + i + "位学生添加成功。");
            }

        }
        public void Inquire_id()
        {
            Console.Write("请输入要查询学生的学号：");
            int inquireId = Convert.ToInt32(Console.ReadLine());
            int i = 0;
            foreach (var item in studentList)
            {
                i++;
                if (item.ID == inquireId)
                {
                    Console.WriteLine("学号：" + item.ID);
                    Console.WriteLine("姓名：" + item.Name);
                    Console.WriteLine("年龄：" + item.Age);
                }
                if (item.ID != inquireId && i == studentList.Count)
                {
                    Console.WriteLine("查无此人。");
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.InitList();
            student.Inquire_id();

            Console.ReadKey();
        }
    }
}