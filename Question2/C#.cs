using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFAssignmentQ2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Test Case 1: Input = 4000(10%)
            // Test Case 2: Input = 6000(20%)
            Console.WriteLine("Class ID: 120703");
            Console.WriteLine("Registration ID: 66369");
            Console.WriteLine("Name: Khadija Tahir");
            Console.WriteLine("Submission Date: 29 October 2026");

            Console.WriteLine("------------------------------");



            int amount;
            int discountPercentage;
            int discountAmount;
            int finalAmount;


            Console.WriteLine("Enter Purchase Amount");
            amount = Convert.ToInt32(Console.ReadLine());

            if (amount >= 5000)
            {
                discountPercentage = 20;
            }
            else if (amount >= 2000 && amount < 5000)
            {
                discountPercentage = 10;
            }
            else
            {
                discountPercentage = 0;
            }

            discountAmount = (amount * discountPercentage) / 100;
            finalAmount = amount - discountAmount;
            Console.WriteLine("The discount percentage: " + discountPercentage + "%");
            Console.WriteLine("The discount amount: " + discountAmount);
            Console.WriteLine("The final payable amount: " + finalAmount);
        }
    }
}

