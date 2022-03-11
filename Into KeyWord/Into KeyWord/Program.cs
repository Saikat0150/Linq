using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Into_KeyWord
{
    class Program
    {
        static void Main(string[] args)
        {
            IList<Student> studentList = new List<Student>()
            {
                new Student(){ StudentId=1, StudentName="John", Age=18},
                new Student(){ StudentId=2, StudentName="Steve", Age=21},
                new Student(){ StudentId=3, StudentName="Bill", Age=18},
                new Student(){ StudentId=4, StudentName="Ram", Age=20},
                new Student(){ StudentId=5, StudentName="Ron", Age=21}
            };
            var teenAgerStudents = from s in studentList
                                        where s.Age > 12 && s.Age < 20
                                        select s into teenstudents
                                        where teenstudents.StudentName.StartsWith("B")
                                        select teenstudents;
            foreach (Student std in teenAgerStudents)
                Console.WriteLine(std.StudentName);




            Console.Read();
        }
    }
    public class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public int Age { get; set; }
    }
}
