using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sec_10_1._9_Inheritance
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

            // Creating class teacher objects and adding them to myClass
            ClassTeacher classTeacher = new ClassTeacher { Name = "Nikhil Rastogi", Age = 25, ClassAssigned = "Class A" };
            myClass.Teachers.Add(classTeacher);

            // Creating subject teacher objects and adding them to myClass
            SubjectTeacher mathTeacher = new SubjectTeacher { Name = "Manoj Tiwari", Age = 30, SubjectTaught = "Mathematics" };
            SubjectTeacher scienceTeacher = new SubjectTeacher { Name = "Rakesh Maurya", Age = 32, SubjectTaught = "Science" };
            myClass.Teachers.Add(mathTeacher);
            myClass.Teachers.Add(scienceTeacher);

            // Displaying the class details with teachers
            Console.WriteLine($"Class Name: {myClass.ClassName}");
            Console.WriteLine("\nTeachers:");
            foreach (var teacher in myClass.Teachers)
            {
                if (teacher is ClassTeacher)
                {
                    var classTeacherObj = (ClassTeacher)teacher;
                    Console.WriteLine($"Class Teacher Name: {classTeacherObj.Name}, Age: {classTeacherObj.Age}, Class Assigned: {classTeacherObj.ClassAssigned}");
                }
                else if (teacher is SubjectTeacher)
                {
                    var subjectTeacherObj = (SubjectTeacher)teacher;
                    Console.WriteLine($"Subject Teacher Name: {subjectTeacherObj.Name}, Age: {subjectTeacherObj.Age}, Subject Taught: {subjectTeacherObj.SubjectTaught}");
                }
            }
            Console.ReadKey();
        }
    }
}
