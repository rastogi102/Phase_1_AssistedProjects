using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sec_10_1._13_Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            runApp();
        }
        public static void runApp()
        {

            Teacher teacher = new Teacher();
            teacher.Name = "Pawan Kohli";
            teacher.Address = "New Delhi";
            teacher.DateOfJoining = DateTime.Today;

            Student student = new Student();
            student.Name = "Nikhil Rastogi";
            student.Address = "Ghaziabad";
            student.DateOfJoining = DateTime.Today;

            OfficeStaff staff = new OfficeStaff();
            staff.Name = "Aman Gupta";
            staff.Address = "Noida";
            staff.DateOfJoining = DateTime.Today;


            Console.WriteLine(teacher.getInfo() + "\n" + teacher.getTypeOfPerson());
            Console.WriteLine(student.getInfo() + "\n" + student.getTypeOfPerson());
            Console.WriteLine(staff.getInfo() + "\n" + staff.getTypeOfPerson());
            Console.ReadKey();
        }
    }
}

   

