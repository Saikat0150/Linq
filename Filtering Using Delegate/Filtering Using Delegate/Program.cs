using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filtering_Using_Delegate
{
    class Program
    {
        static void Main(string[] args)
        {
            IList<Student> studentlist = new List<Student>()
            {
                new Student(){ StudentID=1,StudentName="John",Age=13},
                new Student(){ StudentID=2,StudentName="Moin",Age=21},
                new Student(){StudentID=3,StudentName="Bill",Age=18},
                new Student(){ StudentID=4,StudentName="Ram",Age=20},
                new Student(){ StudentID=5,StudentName="Kiran",Age=25},
                new Student(){ StudentID=6,StudentName="Sunil",Age=24},
                new Student(){ StudentID=7,StudentName="Sai",Age=25}
            };
            Func<Student, bool> isTeenAger = delegate (Student s)
               {
                   return s.Age > 12 && s.Age < 20;
               };


            //var filteredResult = from s in studentlist where isTeenAger(s) select s;
            var filteredResult = studentlist.Where((s, i) =>
                {
                    if (i % 2 == 0)
                        return true;
                    return false;
                });
            foreach (Student std in filteredResult)
            {
                Console.WriteLine(std.StudentName);
            }
            Console.Read();
        }
    }
    public class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public int Age { get; set; }
    }
}
