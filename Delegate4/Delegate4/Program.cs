using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate4
{
	public class Program
	{
		delegate bool IsAdult(Student stud);

		public static void Main()
		{
			IsAdult isAdult = (s) => {

				int adultAge = 18;

				Console.WriteLine("Lambda expression with multiple statements in the body");

				return s.Age >= adultAge;
			};

			Student stud = new Student() { Age = 25 };

			Console.WriteLine(isAdult(stud));
			Console.Read();


		}
	}

	public class Student
	{

		public int Id { get; set; }
		public string Name { get; set; }
		public int Age { get; set; }
	}

}
