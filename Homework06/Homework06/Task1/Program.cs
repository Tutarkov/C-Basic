using System;
using System.Collections.Generic;

namespace NumberQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> numbers = new Queue<int>();
            bool inputNumb = true;

            while (inputNumb)
            {
                Console.Write("Enter a number: ");
                int number = int.Parse(Console.ReadLine());
                numbers.Enqueue(number);

                Console.Write("Do you want to input another number? (Y/N): ");
                string answerYN = Console.ReadLine();

                if (answerYN.ToUpper() != "Y")
                {
                    inputNumb = false;
                }
            }

            Console.WriteLine("Numbers entered:");

            while (numbers.Count > 0)
            {
                Console.WriteLine(numbers.Dequeue());
            }

            Console.ReadKey();
        }
    }
}
