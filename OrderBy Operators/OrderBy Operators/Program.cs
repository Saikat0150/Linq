using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderBy_Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            IList<Student> studentList = new List<Student>() {
            new Student() { StudentID = 1, StudentName = "John", Age = 21, StandardID = 1 } ,
                new Student() { StudentID = 2, StudentName = "Steve",  Age = 18, StandardID = 1 } ,
                new Student() { StudentID = 3, StudentName = "Bill",  Age = 18, StandardID = 2 } ,
                new Student() { StudentID = 4, StudentName = "Ram" , Age = 20, StandardID = 2 } ,
                new Student() { StudentID = 5, StudentName = "Ron" , Age = 21 }
        };
            var sortedStudents = from s in studentList
                                 orderby s.StandardID, s.Age
                                 select new
                                 {
                                     StudentName = s.StudentName,
                                     Age = s.Age,
                                     StandatdID = s.StandardID
                                 };
            sortedStudents.ToList().ForEach(s => Console.WriteLine("Student Name: {0}, Age: {1}, StandardID: {2}", s.StudentName, s.Age, s.StandatdID));
            Console.Read();
        }
    }
    public class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public int Age { get; set; }
        public int StandardID { get; set; }
    }
}
