using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupBy_Extension_Mehod
{
    class Program
    {
        static void Main(string[] args)
        {
            IList<Student> studentlist = new List<Student>()
            {
                new Student(){ StudentID=1,StudentName="john",Age=18},
                new Student(){ StudentID=2,StudentName="Steve",Age=15},
                new Student(){ StudentID=3,StudentName="Bill",Age=25},
                new Student(){ StudentID=4,StudentName="Ram",Age=20},
                new Student(){ StudentID=5,StudentName="Ron",Age=20}
            };
            var groupedResult = studentlist.GroupBy(s => s.Age);
            foreach(var ageGroup in groupedResult)
            {
                Console.WriteLine("Age Group: " + ageGroup.Key);
                foreach(Student s in ageGroup)
                {
                    Console.WriteLine("Student Name: " + s.StudentName);
                }
            }
            Console.ReadLine();
        }
    }
    public class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public int Age { get; set; }
    }
}
