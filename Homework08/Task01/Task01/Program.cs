using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        var squaresNumb = numbers.Select(n => n * n);

        foreach (var square in squaresNumb)
        {
            Console.WriteLine(square);
        }
    }
}
