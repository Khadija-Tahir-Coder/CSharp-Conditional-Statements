using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFAssignmentQ3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Test Case 1: Input = 2000
            // Test Case 2: Input = 2005
            Console.WriteLine("Class ID: 120703");
            Console.WriteLine("Registration ID: 66369");
            Console.WriteLine("Name: Khadija Tahir");
            Console.WriteLine("Submission Date: 29 October 2026");

            Console.WriteLine("------------------------------");


            int year;

        
            Console.WriteLine("Enter Year");
            year = Convert.ToInt32(Console.ReadLine());


            if (year % 400 == 0)
            {
                Console.WriteLine("leap year");
            }
            else if (year % 100 == 0)
            {
                Console.WriteLine("not a leap year");
            }
            else if (year % 4 == 0)
            {
                Console.WriteLine("leap year");
            }
            else
            {
                Console.WriteLine("not a leap year");
            }
        }
    }
}

