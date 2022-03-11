using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumerable_Extension_Method
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
            var teenAgerStudents = from s in studentList.GetTeenAgerStudents() select s;
            foreach (Student teenStudent in teenAgerStudents)
                Console.WriteLine("Student name: " + teenStudent.StudentName);

            

            Console.Read();
        }
    }
    public class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public int Age { get; set; }
    }
    public static class EnumerableExtensionMethods
    {
        public static IEnumerable<Student> GetTeenAgerStudents(this IEnumerable<Student> source)
        {
            foreach(Student std in source)
            {
                Console.WriteLine("Accessing student: " + std.StudentName);
                if(std.Age>12 && std.Age < 20)
                {
                    yield return std;
                }
            }
        }
    }
}
