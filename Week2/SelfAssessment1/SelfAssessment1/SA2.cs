using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfAssessment1
{
    public class SA2
    {
        public void sa2()
        {
            Calculator calculator = new Calculator();
            Console.Write("Enter number 1 : ");
            calculator.num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter number 2 : ");
            calculator.num2 = int.Parse(Console.ReadLine());
            Console.Write("Enter operation you want to perform : ");
            string option = Console.ReadLine();
            if(option == "+")
            {
                Console.WriteLine($"Result : {calculator.sum()}");
            }
            else if (option == "-")
            {
                Console.WriteLine($"Result : {calculator.subtract()}");
            }
            else if (option == "*")
            {
                Console.WriteLine($"Result : {calculator.multiply()}");
            }
            else if (option == "/")
            {
                Console.WriteLine($"Result : {calculator.divide()}");
            }
            else
            {
                Console.WriteLine("Invalid input!");
            }

        }
        public class Calculator
        {
            public int num1;
            public int num2;
            public Calculator()
            {
                
            }
            public int sum()
            {
                return (num1 + num2);
            }
            public int subtract()
            {
                return num1 - num2;
            }
            public int multiply()
            {
                return num1 * num2;
            }
            public int divide()
            {
                return num1 / num2;
            }
        }
    }
}
