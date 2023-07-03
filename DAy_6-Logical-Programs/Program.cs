using Microsoft.VisualBasic;
using static System.Net.Mime.MediaTypeNames;
using System.Diagnostics.Metrics;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Intrinsics.X86;
using System;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Dynamic;
using System.Globalization;
using System.Reflection.PortableExecutable;

public class ReverseExample
{
    public static void Main(string[] args)
    {
        int[] availableNotes = { 2000, 500, 100, 50, 20, 10, 5, 1 };

        Console.WriteLine("Enter the amount:");
        int amount = int.Parse(Console.ReadLine());

        Console.WriteLine("Fewest notes to be returned:");

        for (int i = 0; i < availableNotes.Length; i++)
        {
            int notesCount = amount / availableNotes[i];
            amount %= availableNotes[i];

            if (notesCount > 0)
            {
                Console.WriteLine($"{availableNotes[i]} - {notesCount} note(s)");
            }
        }
        Console.ReadLine();
    }
}





