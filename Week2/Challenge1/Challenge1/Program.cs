using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            float matricmarks;
            float fscmarks;
            float ecatmarks;
            Console.WriteLine("1. Add student");
            Console.WriteLine("2. Show students");
            Console.WriteLine("3. Calculate Aggregate");
            string option = "0";
            while(option!="4")
            {
                Console.Write("Enter your option : ");
                option = Console.ReadLine();
                if(option=="1")
                {
                    Console.Write("Enter name : ");
                    name = Console.ReadLine();
                    Console.Write("Enter matric marks : ");
                    matricmarks = float.Parse(Console.ReadLine());
                    Console.Write("Enter fsc marks : ");
                    fscmarks = float.Parse(Console.ReadLine());
                    Console.Write("Enter ecat marks : ");
                    ecatmarks = float.Parse(Console.ReadLine());
                    Student ali = new Student(name,matricmarks,fscmarks,ecatmarks);
                    ali.AddStudent(ali);
                }
                else if(option=="2")
                {
                    Student.ShowStudents();
                }
                else if(option=="3")
                {
                    Console.Write("Enter name : ");
                    name = Console.ReadLine();
                    Student ali = new Student();
                    ali.CalculateAggregate(name);
                }
            }
        }
    }
}
