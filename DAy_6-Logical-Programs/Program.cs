using Microsoft.VisualBasic;
using static System.Net.Mime.MediaTypeNames;
using System.Diagnostics.Metrics;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Intrinsics.X86;
using System;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Dynamic;

public class ReverseExample
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Stopwatch Simulation");
        Console.WriteLine("Press ENTER to start the stopwatch.");
        Console.ReadLine();

        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();

        Console.WriteLine("Stopwatch is running.");
        Console.WriteLine("Press ENTER to stop the stopwatch.");
        Console.ReadLine();

        stopwatch.Stop();

        TimeSpan elapsed = stopwatch.Elapsed;
        Console.WriteLine($"Elapsed Time: {elapsed.TotalSeconds} seconds");

        Console.ReadLine();
    }
}