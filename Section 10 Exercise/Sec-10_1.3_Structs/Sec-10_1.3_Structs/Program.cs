using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sec_10_1._3_Structs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            doApp();
        }
        public static void doApp()
        {
            List<Student> studentList = new List<Student>();

            while (true)
            {
                Console.WriteLine("Options:");
                Console.WriteLine("1. Add Student");
                Console.WriteLine("2. View all Students");
                Console.WriteLine("3. Exit");

                Console.Write("Enter your choice: ");
                int choice;
                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Invalid input. Please try again.");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter Student's Name: ");
                        string name = Console.ReadLine();

                        Console.Write("Enter Student's Age: ");
                        int age;
                        if (!int.TryParse(Console.ReadLine(), out age))
                        {
                            Console.WriteLine("Invalid age. Please enter a valid number.");
                            continue;
                        }

                        Console.Write("Enter Student's Roll Number: ");
                        string rollNumber = Console.ReadLine();

                        Console.Write("Enter Student's Grade: ");
                        string grade = Console.ReadLine();

                        // Create a new Student struct with the provided details
                        Student student = new Student
                        {
                            Name = name,
                            Age = age,
                            RollNumber = rollNumber,
                            Grade = grade
                        };

                        // Add the student struct to the list
                        studentList.Add(student);
                        break;

                    case 2:
                        // Display all the students
                        Console.WriteLine("\nList of Students:");
                        foreach (var stu in studentList)
                        {
                            Console.WriteLine($"Name: {stu.Name}, Age: {stu.Age}, Roll Number: {stu.RollNumber}, Grade: {stu.Grade}");
                        }
                        break;

                    case 3:
                        Console.WriteLine("Exiting the Application.");
                        return;

                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
                Console.ReadKey();
            }
        }
    }
}
