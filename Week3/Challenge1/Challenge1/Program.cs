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
            int h, m, s;
            Clocktype time;
            string option = "0";
            while(option != "4")
            {
                Console.Clear();
                Console.WriteLine("1. Elapsed Time");
                Console.WriteLine("2. Remaining Time");
                Console.WriteLine("3. Difference of Time");
                Console.WriteLine("Enter your option : ");
                option = Console.ReadLine();
                if(option == "1")
                {
                    Console.WriteLine("Enter hours : ");
                    h = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter minutes : ");
                    m = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter seconds : ");
                    s = int.Parse(Console.ReadLine());
                    time = new Clocktype(h, m, s);
                    Console.WriteLine($"Time Elapsed : {time.ElapsedTime(time)}");
                    Console.Read();
                }
                else if(option == "2")
                {
                    Console.WriteLine("Enter hours : ");
                    h = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter minutes : ");
                    m = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter seconds : ");
                    s = int.Parse(Console.ReadLine());
                    time = new Clocktype(h, m, s);
                    Console.WriteLine($"Time Elapsed : {time.remainingTime(time)}");
                    Console.Read();
                }
                else if(option == "3")
                {
                    Console.WriteLine("Enter hours : ");
                    h = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter minutes : ");
                    m = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter seconds : ");
                    s = int.Parse(Console.ReadLine());
                    Clocktype time1 = new Clocktype(h, m, s);
                    Console.WriteLine("Enter hours : ");
                    h = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter minutes : ");
                    m = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter seconds : ");
                    s = int.Parse(Console.ReadLine());
                    time1.timePassed(time1, h, m, s);
                    Console.Read();
                }
            }
        }
    }
}
