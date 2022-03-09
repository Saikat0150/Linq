using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderBy_Extension_method
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
            var orderbyResult = studentlist.OrderBy(s => s.StudentName);
            var orderByDescendingResult = studentlist.OrderByDescending(s => s.StudentName);
            
            Console.WriteLine("Accending Order");
            foreach (var std in orderbyResult)
            {
                Console.WriteLine(std.StudentName);
            }
            Console.WriteLine("Descinding Oerder");
            foreach (var std in orderByDescendingResult)
            {
                Console.WriteLine(std.StudentName);
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
