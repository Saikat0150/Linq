using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Delegate
{
    delegate bool FindStudent(FindStudent std);
    class StudentExtension
    {
        public static StudentExtension[] where(Student[] stdArray, FindStudent del)
        {
            int i = 0;
            Student[] result = new Student[10];
            foreach(Student std in stdArray)
            {
                if (del(std))
                {
                    result[i] = std;
                    i++;
                }
                return result;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student[] studentArray=
            {
                new Student(){ StudentID=1,StudentName="John",Age=13},
                new Student(){ StudentID=2,StudentName="Moin",Age=21},
                new Student(){StudentID=3,StudentName="Bill",Age=18},
                new Student(){ StudentID=4,StudentName="Ram",Age=20}
            };
            //var teenAgerStudent = from s in studentlist where s.Age > 12 && s.Age < 20 select s;
            //Console.WriteLine("Teenage Student");
            //foreach (Student std in teenAgerStudent)
            //{
            //    Console.WriteLine(std.StudentName);
            //}
            Student[] students = StudentExtension.where(studentArray, delegate (Student std)
               {
                   return std.Age > 12 && std.Age < 40;
               });
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
