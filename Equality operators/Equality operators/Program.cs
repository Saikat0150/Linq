using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equality_operators
{
    class Program
    {
        static void Main(string[] args)
        {
            /*IList<string> string1 = new List<string>() { "one", "two", "three", "four", "three" };
            IList<string> string2 = new List<string>() { "one", "two", "three", "four", "three" };
            bool isEqual = string1.SequenceEqual(string2);
            Console.WriteLine(isEqual);*/

            Student std = new Student() { StudentId = 1, StudentName = "Bill" };
            IList<Student> studentList1 = new List<Student>() { std };
            IList<Student> studentList2 = new List<Student>() { std };
            bool isStudentEqual = studentList1.SequenceEqual(studentList2);
            Console.WriteLine(isStudentEqual);

            Student std1 = new Student() { StudentId = 1, StudentName = "Saikat" };
            Student std2 = new Student() { StudentId = 1, StudentName = "Bill" };
            IList<Student> studentList3 = new List<Student>() { std1 };
            IList<Student> studentList4 = new List<Student>() { std2 };
            isStudentEqual = studentList3.SequenceEqual(studentList4);
            Console.WriteLine(isStudentEqual);
            Console.ReadLine();
        }
    }
    public class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
    }
}
