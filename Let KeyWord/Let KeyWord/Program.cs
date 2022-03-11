﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Let_KeyWord
{
    class Program
    {
        static void Main(string[] args)
        {
            IList<Student> studentList = new List<Student>()
            {
                new Student(){ StudentId=1, StudentName="John", Age=18},
                new Student(){ StudentId=2, StudentName="Steve", Age=21},
                new Student(){ StudentId=3, StudentName="Bill", Age=18},
                new Student(){ StudentId=4, StudentName="Ram", Age=20},
                new Student(){ StudentId=5, StudentName="Ron", Age=21}
            };
            var lowercaseStudentNames = from s in studentList
                                        let lowercaseStudentName = s.StudentName.ToLower()
                                        where lowercaseStudentName.StartsWith("r")
                                        select lowercaseStudentName;
            foreach (var name in lowercaseStudentNames)
                Console.WriteLine(name);




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
