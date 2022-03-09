using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqDelegate1
{
	public class Program
	{
		delegate bool IsTeenAger(Student stud);

		public static void Main()
		{
			
			IsTeenAger isTeenAger = s => s.Age > 12 && s.Age < 20;

			Student stud = new Student() { Age = 25 };

			Console.WriteLine(isTeenAger(stud));
			Console.ReadKey();


		}
	}

	public class Student
	{

		public int StudentId { get; set; }
		public string StudentName { get; set; }
		public int Age { get; set; }
	}

}
