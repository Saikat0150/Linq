using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Set_Operator
{
    class Program
    {
        static void Main(string[] args)
        {
            //---Distinct Method
            /*IList<string> strList = new List<string>() { "One", "Two", "Three", "Two", "Thre" };
            IList<int> intList = new List<int>() { 1, 2, 3, 2, 4, 4, 3, 5 };
            var distincList1 = strList.Distinct();
            foreach(var str in distincList1)
            {
                Console.WriteLine(str);
            }
            var distincList2 = intList.Distinct();
            foreach(var i in distincList2)
            {
                Console.WriteLine(i);
            }*/


            //--- Except Method
            /*IList<string> strList1 = new List<string>() { "One", "Two", "Four", "Five" };
            IList<string> strList2 = new List<string>() { "Four", "Five", "Six", "Seven", "Eight" };
            var result = strList1.Except(strList2);
            foreach(string str in result)
            {
                Console.WriteLine(str);
            }*/

            //--- Intersect Method
            /*IList<string> strList1 = new List<string>() { "One", "Two", "Four", "Five" };
            IList<string> strList2 = new List<string>() { "Four", "Five", "Six", "Seven", "Eight" };
            var result = strList1.Intersect(strList2);
            foreach (string str in result)
            {
                Console.WriteLine(str);
            }*/

            //-- Union Method
            /*IList<string> strList1 = new List<string>() { "One", "Two", "Four", "Five" };
            IList<string> strList2 = new List<string>() { "Four", "Five", "Six", "Seven", "Eight" };
            var result = strList1.Union(strList2);
            foreach (string str in result)
            {
                Console.WriteLine(str);
            }*/


            /*---- Patitioning Operators --------*/

            //--- Skip Method
            /*IList<string> strList1 = new List<string>() { "One", "Two", "Four", "Five" };
            var result = strList1.Skip(2);
            foreach (var str in result)
            {
                Console.WriteLine(str);
            }*/

            //--- SkipWhile Method
            /*IList<string> strList1 = new List<string>() { "One", "Two", "Four", "Five" };
            var result = strList1.SkipWhile(s => s.Length > 4);
            foreach (var str in result)
            {
                Console.WriteLine(str);
            }*/

            //--- Take Methods
            /*IList<string> strList1 = new List<string>() { "One", "Two", "Four", "Five" };
            var result = strList1.Take(2);
            foreach (var str in result)
            {
                Console.WriteLine(str);
            }*/

            //--- TakeWhile Method
            IList<string> strList1 = new List<string>() { "One", "Two", "Four", "Five" };
            var result = strList1.TakeWhile(s=>s.Length>=4);
            foreach (var str in result)
            {
                Console.WriteLine(str);
            }
            Console.Read();
        }
    }
    public class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
    }
}
