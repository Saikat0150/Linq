﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Filtering_operator_oftype
{
    class Program
    {
        static void Main(string[] args)
        {
            IList mixedList = new ArrayList();
            mixedList.Add(0);
            mixedList.Add("One");
            mixedList.Add("Two");
            mixedList.Add(3);
            mixedList.Add(new Student() { StudentID = 1, StudentName = "Bill" });
            var stringResult = from s in mixedList.OfType<string>() select s;
            var intResult = from s in mixedList.OfType<int>() select s;
            var stdResult = from s in mixedList.OfType<Student>() select s;
            foreach (var str in stringResult)
                Console.WriteLine(str);
            foreach (var integer in intResult)
                Console.WriteLine(integer);
            foreach (var std in stdResult)
                Console.WriteLine(std.StudentName);


            Console.ReadLine();
        }
    }
    public class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public int Age { get; set; }
    }
}
