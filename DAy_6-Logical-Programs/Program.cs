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
            int count;
            Console.WriteLine("Enter the number of Fibonacci numbers to generate:");
            count = int.Parse(Console.ReadLine());

            Random random = new Random();
            int first = random.Next(10); // Generate a random number between 0 and 9
            int second = random.Next(10); // Generate a random number between 0 and 9

            Console.WriteLine($"Random Fibonacci Series of {count} numbers:");

            // Generate the Fibonacci series
            for (int i = 0; i < count; i++)
            {
                int fibonacci = first + second;
                Console.WriteLine(fibonacci);

                // Shift the numbers
                first = second;
                second = fibonacci;
            }
            Console.ReadLine();
        }
    }
}