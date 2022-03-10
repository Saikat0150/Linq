using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Element_Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            //--- Element , ElementOrDefault Methods
            /*IList<int> intList = new List<int>() { 10, 20, 30, 45, 50, 87 };
            IList<string> strList = new List<string>() { "one", "two", null, "four", "five" };
            Console.WriteLine("1st Element in intList: " + intList.ElementAt(0));
            Console.WriteLine("1st element in strList: " + strList.ElementAt(0));
            Console.WriteLine("2nd Element in intList: " + intList.ElementAt(1));
            Console.WriteLine("2nd element in strList: " + strList.ElementAt(1));
            Console.WriteLine("3rd Element in intList: " + intList.ElementAtOrDefault(2));
            Console.WriteLine("3rd element in strList: " + strList.ElementAtOrDefault(2));
            Console.WriteLine("10th Element in intList: " + intList.ElementAtOrDefault(9));
            Console.WriteLine("10th element in strList: " + strList.ElementAtOrDefault(9));

            Console.WriteLine("Index out of range");
            Console.WriteLine(intList.ElementAt(9));*/

            //---First , FirstOrDefault Methods
            /*IList<int> intList = new List<int>() { 7, 10, 21, 30, 45, 50, 87 };
            IList<string> strList = new List<string>() { null, "two", "three", "four", "five" };
            IList<string> emptyList = new List<string>();
            Console.WriteLine("1st Element in intList: " + intList.First(s => s > 21));
            Console.WriteLine("1st Element in intList: " + intList.First());
            Console.WriteLine("1st element in strList: " + strList.First());
            Console.WriteLine(emptyList.FirstOrDefault());*/

            //---Last, LastOrDefault Methods
            /*IList<int> intList = new List<int>() { 7, 10, 21, 30, 45, 50, 87 };
            IList<string> strList = new List<string>() { null, "two", "three", "four", "five" };
            IList<int> empint = new List<int>();
            IList<string> emptyList = new List<string>();
            Console.WriteLine("Last Element in intList: " + intList.Last());
            Console.WriteLine("Last even Element in intList: " + intList.Last(s => (s%2==0)));
            Console.WriteLine("Last element in strList: " + strList.Last());
            Console.WriteLine("Last element of empty integer list: " + empint.LastOrDefault());
            Console.WriteLine("Last element of empty string list: " + emptyList.LastOrDefault());*/

            //---Single , SingleOrDefault methods
            IList<int> intList = new List<int>() { 7, 10, 21, 30, 45, 50, 87 };
            IList<string> strList = new List<string>() { null, "two", "three", "four", "five" };
            IList<int> empint = new List<int>() { 7 };
            IList<string> emptyList = new List<string>();
            Console.WriteLine("Only Element in empint: " + empint.Single());
            //Console.WriteLine("Last even Element in intList: " + intList.Last(s => (s % 2 == 0)));
            //Console.WriteLine("Last element in strList: " + strList.Last());
            Console.WriteLine("Only Element in empint: " + empint.SingleOrDefault());
            Console.WriteLine(emptyList.SingleOrDefault());
            Console.Read();
        }
    }
}
