using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Delegate
{
    delegate bool FindStudent(Student std);

    class StudentExtension
    {
        public static Student[] where(Student[] stdArray, FindStudent del)
        {
            int i = 0;
            Student[] result = new Student[10];
            foreach (Student std in stdArray)
            {
                if (del(std))
                {
                    result[i] = std;
                    i++;
                }
                return result;
            }
            return result;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            IList<Student> Studentlist = new List<Student>()
            {
                new Student(){ StudentId = 1, StudentName ="John",Age=13},
                new Student(){ StudentId = 2, StudentName ="Moin",Age =21},
                new Student(){ StudentId = 3, StudentName ="Bill",Age = 18},
                new Student(){ StudentId = 4, StudentName ="Ram",Age = 20},
                new Student(){ StudentId = 5, StudentName ="Ron", Age = 15}
            };
            var teenAgerStudent = from s in Studentlist where s.Age >= 12 && s.Age < 20 select s;
            Console.WriteLine("Teenage Students Are:");
            foreach (var str in teenAgerStudent)
                Console.WriteLine(str.StudentName);
            Console.ReadLine();
        }
    }
    class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }

        public int Age { get; set; }
    }
}
