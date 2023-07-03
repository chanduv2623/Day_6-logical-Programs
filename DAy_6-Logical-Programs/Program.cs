using Microsoft.VisualBasic;
using static System.Net.Mime.MediaTypeNames;
using System.Diagnostics.Metrics;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Intrinsics.X86;
using System;
using System.ComponentModel.Design;
using System.Diagnostics;

public class ReverseExample
{
    public static void Main(string[] args)
    {
        int numCoupons;
        Console.WriteLine("Enter the number of coupon numbers to generate:");
        numCoupons = int.Parse(Console.ReadLine());

        GenerateCouponNumbers(numCoupons);

        Console.ReadLine();
    }

    static void GenerateCouponNumbers(int numCoupons)
    {
        Random random = new Random();

        for (int i = 1; i <= numCoupons; i++)
        {
            string couponNumber = GetCouponNumber(random, 10);
            Console.WriteLine($"Coupon {i}: {couponNumber}");
        }
    }

    static string GetCouponNumber(Random random, int length)
    {
        const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
        char[] couponChars = new char[length];

        for (int i = 0; i < length; i++)
        {
            couponChars[i] = chars[random.Next(chars.Length)];
        }

        return new string(couponChars);
    }
}