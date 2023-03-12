using System.Diagnostics.Metrics;
using System.Runtime.Intrinsics.X86;
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter your birthday (yyyy-MM-dd):");
        DateTime birthday = DateTime.Parse(Console.ReadLine());

        int age = AgeCalculator(birthday);

        Console.WriteLine("You are {0} years old.", age);
    }

    static int AgeCalculator(DateTime birthday)
    {
        DateTime today = DateTime.Today;
        int age = today.Year - birthday.Year;
        return age;
    }
}
