using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFAssignmentQ1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Test Case 1: Input = 5
            // Test Case 2: Input = 9
            Console.WriteLine("Class ID: 120703");
            Console.WriteLine("Registration ID: 66369");
            Console.WriteLine("Name: Khadija Tahir");
            Console.WriteLine("Submission Date: 29 October 2026");

            Console.WriteLine("------------------------------");

            int day;

            Console.WriteLine("Enter Day Number (1-7):");
            day = Convert.ToInt32(Console.ReadLine());

            if (day == 1)
            {
                Console.WriteLine("Monday");
            }
            else if (day == 2)
            {
                Console.WriteLine("Tuesday");
            }
            else if (day == 3)
            {
                Console.WriteLine("Wednesday");
            }
            else if (day == 4)
            {
                Console.WriteLine("Thursday");
            }
            else if (day == 5)
            {
                Console.WriteLine("Friday");
            }
            else if (day == 6)
            {
                Console.WriteLine("Saturday");
            }
            else if (day == 7)
            {
                Console.WriteLine("Sunday");
            }
            else
            {
                Console.WriteLine("Invalid number");
            }
        }
    }
}

