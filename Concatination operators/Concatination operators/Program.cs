using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concatination_operators
{
    class Program
    {
        static void Main(string[] args)
        {
            IList<string> collection1 = new List<string>() { "One", "Two", "Three" };
            IList<string> collection2 = new List<string>() { "Five", "Six" };
            var concatResult = collection1.Concat(collection2);
            foreach(string str in concatResult)
            {
                Console.Write(str + "\t");
            }
            Console.WriteLine();

            //--- For numbers
            IList<int> intcoll1 = new List<int>() { 1, 2, 3 };
            IList<int> intcoll2 = new List<int>() { 5, 6 };
            var result = intcoll1.Concat(intcoll2);
            foreach(int i in result)
            {
                Console.Write(i + "\t");
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
