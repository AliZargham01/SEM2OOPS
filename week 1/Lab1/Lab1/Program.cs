using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N, X, T, money = 0;
            Console.Write("Enter lily's age : ");
            N = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter price of washing machine : ");
            X = int.Parse(Console.ReadLine());
            Console.Write("Enter price of Toy : ");
            T = int.Parse(Console.ReadLine());
            int var = 10;
            for (int i = 1; i <= N; i++)
            {
                if (i % 2 == 0)
                {
                    money = money + (var - 1);
                    var += 10;
                }
                else
                {
                    money = money + T;
                }
            }
            if (money >= X)
            {
                Console.WriteLine("Yes");
                Console.Write(money - X);
            }
            else
            {
                Console.WriteLine("No");
                Console.Write(X - money);
            }s
        }
    }
}
