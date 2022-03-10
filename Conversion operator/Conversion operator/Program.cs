using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversion_operator
{
    class Program
    {
        static void Main(string[] args)
        {
            IList<string> strList = new List<string>()
            {
                "One",
                "Two",
                "Three",
                "Four",
                "Three"
            };
            Console.WriteLine("strList type: " + strList.GetType().Name);

            string[] strArray = strList.ToArray<string>(); //converts list to Array

            Console.WriteLine("strList type: " + strArray.GetType().Name);

            IList<string> newList = strArray.ToList<string>(); //Converts Array to List

            Console.WriteLine("NewList type: " + newList.GetType().Name);

            Console.Read();
        }
    }
}
