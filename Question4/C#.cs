using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFAssignmentQ4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Test Case 1: Input = 30+45
            // Test Case 2: Input = 70-25
            // Test Case 3: Input = 5*5
            // Test Case 4: Input = 25/8

            Console.WriteLine("Class ID: 120703");
            Console.WriteLine("Registration ID: 66369");
            Console.WriteLine("Name: Khadija Tahir");
            Console.WriteLine("Submission Date: 29 October 2026");

            Console.WriteLine("------------------------------");

            int a, b, sum, sub, mul, div;
            string sign;

            
            Console.WriteLine("Enter First Number");
            a = Convert.ToInt32(Console.ReadLine());

            
            Console.WriteLine("Enter Second Number");
            b = Convert.ToInt32(Console.ReadLine());

            
            Console.WriteLine("Enter Sign (+, -, *, /)");
            sign = Console.ReadLine();

            
            if (sign == "+")
            {
                sum = a + b;
                Console.WriteLine("Addition is:" + sum);
            }

           
            else if (sign == "-")
            {
                sub = a - b;
                Console.WriteLine("Subtraction is:" + sub);
            }

           
            else if (sign == "*")
            {
                mul = a * b;
                Console.WriteLine("Multiplication is:" + mul);
            }

           
            else if (sign == "/")
            {
                div = a / b;
                Console.WriteLine("Division is:" + div);
            }

            
            else
            {
                Console.WriteLine("Invalid sign or Number");
            }
        }
    }
}

