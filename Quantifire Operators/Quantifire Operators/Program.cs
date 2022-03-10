using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quantifire_Operators
{
	public class Program
	{
		public static void Main()
		{
			IList<Student> studentList = new List<Student>() {
			new Student() { StudentID = 1, StudentName = "John", Age = 13 } ,
			new Student() { StudentID = 2, StudentName = "Moin",  Age = 21 } ,
			new Student() { StudentID = 3, StudentName = "Bill",  Age = 18 } ,
			new Student() { StudentID = 4, StudentName = "Ram" , Age = 20 } ,
			new Student() { StudentID = 5, StudentName = "Ron" , Age = 15 }
		};
			//--All operators
			bool areAllStudentsTeenAger = studentList.All(s => s.Age > 12 && s.Age < 20);
			Console.WriteLine(areAllStudentsTeenAger);

			//--Any Operators
			bool areAnyStudentsTeenAger = studentList.Any(s => s.Age > 12 && s.Age < 20);
			Console.WriteLine(areAnyStudentsTeenAger);
			Console.Read();

			//-------------------Contains Operator
			/*IList<int> intList = new List<int>() { 1, 2, 3, 4, 5, 6 };
			bool result = intList.Contains(2);
			Console.WriteLine(result);
			Console.Read();*/
		}
	}

	public class Student
	{

		public int StudentID { get; set; }
		public string StudentName { get; set; }
		public int Age { get; set; }
	}
}
