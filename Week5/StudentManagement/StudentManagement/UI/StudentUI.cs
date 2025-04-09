using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentManagement.BL;

namespace StudentManagement.UI
{
    class StudentUI
    {
        public Student addStudent()
        {
            Console.Write("Enter Student Name : ");
            string name = Console.ReadLine();
            Console.Write("Enter Student Age : ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("Enter Student Fsc Marks : ");
            double fscMarks = double.Parse(Console.ReadLine());
            Console.Write("Enter Student Ecat Marks : ");
            double ecatMarks = double.Parse(Console.ReadLine());
            Console.Write("Enter the number of preferences : ");
            int num = int.Parse(Console.ReadLine());
            List<string> preference = new List<string>();
            for(int x =0; x < num; x++)
            {
                Console.Write("Enter Preference Degree : ");
                preference[x] = Console.ReadLine();
            }
            Student s = new Student(name, age, fscMarks, ecatMarks, preference);
            return s;
        }
    }
}
