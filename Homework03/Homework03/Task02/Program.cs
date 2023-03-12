using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a sentence:");
        string sentence = Console.ReadLine();

        string[] words = sentence.Split(' ');

        Console.WriteLine("Words in the sentence:");
        foreach (string word in words)
        {
            Console.WriteLine(word);
        }
    }
}