using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aggregation_Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            //--Aggregate Method
            /*IList<string> strList = new List<string>() { "One", "Two", "Three", "Four", "Five" };
            var commaSeperatedString = strList.Aggregate((s1, s2) => s1 + "," + s2);
            Console.WriteLine(commaSeperatedString);
            */

            //--Average Method
            /*IList<int> intList = new List<int>() { 10, 20, 30, 40 };
            var avg = intList.Average();
            Console.WriteLine("Average is " + avg);*/
            /*IList<Student> studentList = new List<Student>() {
            new Student() { StudentID = 1, StudentName = "John", Age = 13 } ,
            new Student() { StudentID = 2, StudentName = "Moin",  Age = 21 } ,
            new Student() { StudentID = 3, StudentName = "Bill",  Age = 18 } ,
            new Student() { StudentID = 4, StudentName = "Ram" , Age = 20 } ,
            new Student() { StudentID = 5, StudentName = "Ron" , Age = 15 }
            };
            var avg = studentList.Average(s => s.Age);
            Console.WriteLine("Average Age is: " + avg);*/

            //--Count Method
            /*IList<int> intList = new List<int>() { 1, 2, 3, 4, 5, 6 };
            var totalElements = intList.Count();
            Console.WriteLine("Total Elements: " + totalElements);
            var evenElements = intList.Count(s => s % 2 == 0);
            Console.WriteLine("Even Elements: " + evenElements);*/
            //----------------
            /*IList<Student> studentList = new List<Student>() {
            new Student() { StudentID = 1, StudentName = "John", Age = 13 } ,
            new Student() { StudentID = 2, StudentName = "Moin",  Age = 21 } ,
            new Student() { StudentID = 3, StudentName = "Bill",  Age = 18 } ,
            new Student() { StudentID = 4, StudentName = "Ram" , Age = 20 } ,
            new Student() { StudentID = 5, StudentName = "Ron" , Age = 15 }
            };
            var totalStudent = studentList.Count();
            Console.WriteLine("Total Stidents: " + totalStudent);
            var ageCondition = studentList.Count(s => s.Age > 18);
            Console.WriteLine("No of Students whose age is greater than 18: " + ageCondition);
            var totalAge = (from s in studentList select s.Age).Count();
            Console.WriteLine(totalAge);*/

            //--------Max Method
            IList<int> intList = new List<int>() { 9, 2, 10, 5, 13, 12, 8 };
            var maxElement = intList.Max();
            var maxEven = intList.Max(i =>
                                            {
                                                if (i % 2 == 0)
                                                {
                                                    return i;
                                                }
                                                return 0;
                                            });
                                            // or intList.Where(s => s % 2 == 0).Max(); // or (from s in intList select s).Where(i => i % 2 == 0).Max();
            Console.WriteLine("The max Element is: " + maxElement);
            Console.WriteLine("Even max Element is: " + maxEven);

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
