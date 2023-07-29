using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sec_10_1._7_Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            runApp();
        }
        public static void runApp()
        {
            CClass myClass = new CClass();
            myClass.ClassName = "Class A";

            // Creating subject objects and adding them to myClass
            Subject mathSubject = new Subject { Name = "Mathematics", Code = "MATH101" };
            Subject scienceSubject = new Subject { Name = "Science", Code = "SCI101" };
            myClass.Subjects.Add(mathSubject);
            myClass.Subjects.Add(scienceSubject);

            // Creating teacher objects and adding them to myClass
            Teacher mathTeacher = new Teacher { Name = "Tarun Sharma", Age = 38 };
            Teacher scienceTeacher = new Teacher { Name = "Pawan Kohli", Age = 45 };
            myClass.Teachers.Add(mathTeacher);
            myClass.Teachers.Add(scienceTeacher);

            // Creating student objects and adding them to myClass
            Student student1 = new Student { Name = "Aman", Age = 15, RollNumber = "A001" };
            Student student2 = new Student { Name = "Neha", Age = 16, RollNumber = "A002" };
            Student student3 = new Student { Name = "Piyush", Age = 17, RollNumber = "A003" };
            Student student4 = new Student { Name = "Sonal", Age = 18, RollNumber = "A004" };

            myClass.Students.Add(student1);
            myClass.Students.Add(student2);
            myClass.Students.Add(student3);
            myClass.Students.Add(student4);



            // Displaying the class details
            Console.WriteLine($"Class Name: {myClass.ClassName}");
            Console.WriteLine("\nSubjects:");
            foreach (var subject in myClass.Subjects)
            {
                Console.WriteLine($"Subject Name: {subject.Name}, Code: {subject.Code}");
            }

            Console.WriteLine("\nTeachers:");
            foreach (var teacher in myClass.Teachers)
            {
                Console.WriteLine($"Teacher Name: {teacher.Name}, Age: {teacher.Age}");
            }

            Console.WriteLine("\nStudents:");
            foreach (var student in myClass.Students)
            {
                Console.WriteLine($"Student Name: {student.Name}, Age: {student.Age}, Roll Number: {student.RollNumber}");
            }
            Console.ReadKey();
        }
    }
}
