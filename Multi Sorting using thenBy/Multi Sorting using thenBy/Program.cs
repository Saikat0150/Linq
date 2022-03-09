using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multi_Sorting_using_thenBy
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
                new Student(){ StudentID=5,StudentName="Ron",Age=19}
            };
            var thenByResult = studentlist.OrderBy(s => s.Age);
            var thenByDescResult = studentlist.OrderBy(s => s.StudentName).ThenByDescending(s => s.Age);
            Console.WriteLine("ThenBy");
            foreach(var std in thenByResult)
            {
                Console.WriteLine("Name: " + std.StudentName + ", Age: " + std.Age);
            }
            Console.WriteLine("ThenBy Descending");
            foreach (var std in thenByDescResult)
            {
                Console.WriteLine("Name: " + std.StudentName + ", Age: " + std.Age);
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
