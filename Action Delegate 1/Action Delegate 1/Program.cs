using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Action_Delegate_1
{
	public class Program
	{


		public static void Main()
		{
			Action<Student> PrintStudentDetail = s => Console.WriteLine("Name: {0}, Age: {1} ", s.Name, s.Age);

			Student std = new Student() { Name = "Bill", Age = 21 };
			PrintStudentDetail(std);

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
