using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiple_Select_And_Where_Operator
{
    class Program
    {
        static void Main(string[] args)
        {
            IList<Student> studentList = new List<Student>()
            {
                new Student() { StudentId = 1, StudentName = "John", Age = 18, StandardId = 1 },
                new Student() { StudentId = 2, StudentName = "Steve", Age = 21, StandardId = 1 },
                new Student() { StudentId = 3, StudentName = "Bill", Age = 18, StandardId = 2 },
                new Student() { StudentId = 4, StudentName = "Ram", Age = 20, StandardId = 2 },
                new Student() { StudentId = 5, StudentName = "Ron", Age = 21 }
            };
            var studentNames = studentList.Where(s => s.Age > 18)
                .Select(s => s)
                .Where(st => st.StandardId > 0)
                .Select(s => s.StudentName);
            foreach(var name in studentNames)
            {
                Console.WriteLine(name);
            }
            Console.Read();
        }
    }
    public class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public int Age { get; set; }
        public int StandardId { get; set; }
    }
}
