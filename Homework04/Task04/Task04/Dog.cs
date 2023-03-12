using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the dog's name: ");
        string name = Console.ReadLine();

        Console.Write("Enter the dog's breed: ");
        string breed = Console.ReadLine();

        Console.Write("Enter the dog's color: ");
        string color = Console.ReadLine();

        Dog dog = new Dog
        {
            Name = name,
            Breed = breed,
            Color = color
        };

        Console.WriteLine("Choose an option:");
        Console.WriteLine("1. Eat");
        Console.WriteLine("2. Play");
        Console.WriteLine("3. ChaseTail");

        int option = int.Parse(Console.ReadLine());

        switch (option)
        {
            case 1:
                dog.Eat();
                break;
            case 2:
                dog.Play();
                break;
            case 3:
                dog.ChaseTail();
                break;
            default:
                Console.WriteLine("Invalid option.");
                break;
        }
    }
}