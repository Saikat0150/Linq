using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupBy_Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            IList<Student> studentList = new List<Student>()
            {
                new Student(){ StudentId=1, StudentName="John", Age=18, StandardId = 1},
                new Student() { StudentId = 2, StudentName = "Steve",  Age = 21, StandardId = 1 } ,
                new Student() { StudentId = 3, StudentName = "Bill",  Age = 18, StandardId = 2 } ,
                new Student() { StudentId = 4, StudentName = "Ram" , Age = 20, StandardId = 2 } ,
                new Student() { StudentId = 5, StudentName = "Ron" , Age = 21 }
            };
            var studentsGroupByStandard = from s in studentList
                                          where s.StandardId > 0
                                          group s by s.StandardId into sg
                                          orderby sg.Key
                                          select new { sg.Key, sg };
            foreach(var group in studentsGroupByStandard)
            {
                Console.WriteLine("StandardId {0}: ", group.Key);
                group.sg.ToList().ForEach(st => Console.WriteLine(st.StudentName));
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
