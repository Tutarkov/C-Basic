using System;
class Program
{

    public static int sumNum(int number)
    {
        int sum = 0;
        while (number != 0)
        {
            sum += number % 10;
            number /= 10;
        }
        return sum;
    }
    public static void Main()
    {
        Console.WriteLine("Enter a number:");
        int number = int.Parse(Console.ReadLine());
        int sum = sumNum(number);
        Console.WriteLine("Sum of numbers in {0} is {1}", number, sum);
    }
}



