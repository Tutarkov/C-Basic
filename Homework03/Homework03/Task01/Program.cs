using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a string:");
        string input = Console.ReadLine();

        if (input.Length < 5)
        {
            Console.WriteLine("Input is not valid");
        }
        else
        {
            string lastFive = input.Substring(input.Length - 5);
            Console.WriteLine("Last 5 characters are {0}", lastFive);
        }
    }
}