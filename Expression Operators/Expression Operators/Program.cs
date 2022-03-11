using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Linq.Expressions;

namespace Expression_Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            Expression<Func<Student, bool>> isTeenAgerExpr = s => s.Age > 12 && s.Age < 20;
            //compile Expression using Compile Method to invoke it as delegate
            Func<Student, bool> isTeenAger = isTeenAgerExpr.Compile();
            //invoke
            bool result = isTeenAger(new Student() { StudentId = 1, StudentName = "Steve", Age = 20 });
            Console.WriteLine(result);
            Console.Read();
        }
    }
    public class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public int Age { get; set; }
    }
}
