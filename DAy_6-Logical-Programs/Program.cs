using Microsoft.VisualBasic;
using static System.Net.Mime.MediaTypeNames;
using System.Diagnostics.Metrics;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Intrinsics.X86;
using System;

namespace DAy_6_Logical_Programs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.WriteLine("Enter a number:");
            number = int.Parse(Console.ReadLine());

            bool isPerfect = IsPerfectNumber(number);

            if (isPerfect)
            {
                Console.WriteLine($"{number} is a perfect number.");
            }
            else
            {
                Console.WriteLine($"{number} is not a perfect number.");
            }

            Console.ReadLine();
        }

        static bool IsPerfectNumber(int number)
        {
            int sum = 0;

            // Find the divisors and calculate the sum
            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                {
                    sum += i;
                }
            }

            // Check if the sum of divisors equals the number
            return sum == number;
        }
    }
}