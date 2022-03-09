using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Joining_with_standard_method
{
    class Program
    {
        static void Main(string[] args)
        {
            IList<Student> studentlist = new List<Student>()
            {
                new Student(){ StudentId=1,StudentName="John",StandardId=1},
                new Student(){ StudentId=2,StudentName="Moin",StandardId=1},
                new Student(){ StudentId=3,StudentName="Bill",StandardId=2},
                new Student(){ StudentId=4,StudentName="Ram",StandardId=2},
                new Student(){ StudentId=5,StudentName="Ron"}
            };
            IList<Standard> standardlist = new List<Standard>()
            {
                new Standard(){ StandardId=1,StandardName="StandardId 1"},
                new Standard(){ StandardId=2,StandardName="StandardId 2"},
                new Standard(){ StandardId=3,StandardName="StandardId 3"}
            };
            //var innerJoin = studentlist.Join(
            //                                 standardlist,
            //                                            student => student.StandardId,
            //                                            standard => standard.StandardId,
            //                                            (student, standard) => new
            //                                            {
            //                                                StudentName = student.StudentName,
            //                                                StandardName = standard.StandardName
            //                                            }
            //                                            );

            //or
            var innerJoin = from s in studentlist
                            join st in standardlist on s.StandardId equals st.StandardId
                            select new
                            {
                                StudentName = s.StudentName,
                                StandardName = st.StandardName
                            };
            foreach(var obj in innerJoin)
            {
                Console.WriteLine(obj.StudentName + " - " + obj.StandardName);
            }
            Console.Read();

        }
    }
    public class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public int StandardId { get; set; }
    }
    public class Standard
    {
        public int StandardId { get; set; }
        public string StandardName { get; set; }
    }
}
