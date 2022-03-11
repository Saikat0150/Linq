using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversion_Operators_1
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace Conversion_Operators1
    {
        class Program
        {
            static void Main(string[] args)
            {
                IList<Student> studentList = new List<Student>()
            {
                new Student(){ StudentId=1,StudentName="John",Age=18},
                new Student(){ StudentId=2,StudentName="Steve",Age=21},
                new Student(){ StudentId=3, StudentName="Bill", Age=18},
                new Student(){ StudentId=4, StudentName="Ram", Age=20},
                new Student(){ StudentId=5, StudentName="Ron", Age=21}
            };
                IDictionary<int, Student> studentDic = studentList.ToDictionary<Student, int>(s => s.StudentId);
                foreach (var key in studentDic.Keys)
                    Console.WriteLine("Key: " + key + " Value: " + (studentDic[key] as Student).StudentName);
            }
        }
        public class Student
        {
            public int StudentId { get; set; }
            public string StudentName { get; set; }
            public int Age { get; set; }
        }
    }

}
