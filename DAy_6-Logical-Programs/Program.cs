using Microsoft.VisualBasic;
using static System.Net.Mime.MediaTypeNames;
using System.Diagnostics.Metrics;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Intrinsics.X86;
using System;
using System.ComponentModel.Design;

Console.WriteLine("Plese Enter Your Input Number");
int n;
n = Convert.ToInt32(Console.ReadLine());
if (n % 2 == 0)
    Console.WriteLine(n + "Is an Even Number");
else
    Console.WriteLine(n + "Is an Odd Number");
Console.ReadKey();
           