using LINQ;


    class Program
    {        static void Main(string[] args)

        {
           
            List<Animal> animals = new List<Animal> {
            new Animal { Name = "Max", Color = "Brown", Age = 4, Gender = Gender.Male },
            new Animal { Name = "Molly", Color = "Black", Age = 7, Gender = Gender.Female },
            new Animal { Name = "Ava", Color = "Brown", Age = 2, Gender = Gender.Female },
            new Animal { Name = "DelfiMaltezer", Color = "White", Age = 1 , Gender = Gender.Male },
            new Animal { Name = "Bella", Color = "Gray", Age = 3, Gender = Gender.Female },
            new Animal { Name = "Alfie", Color = "Brown", Age = 6, Gender = Gender.Male }
        };

            var animalsAge5more = animals.Where(a => a.Age >= 5).Select(a => a.Name);
            Console.WriteLine("Names of all the animals aged 5 or more:");
            foreach (var name in animalsAge5more)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine();

            var namesWithA = animals.Where(a => a.Name.StartsWith("A")).Select(a => a.Name);
            Console.WriteLine("Names of all the animals that start with 'A':");
            foreach (var name in namesWithA)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine();
  
            var maleBrownAnimals = animals.Where(a => a.Gender == Gender.Male && a.Color == "Brown");
            Console.WriteLine("Male, brown animals:");
            foreach (var animal in maleBrownAnimals)
            {
                Console.WriteLine($"Name: {animal.Name}, Age: {animal.Age}, Gender: {animal.Gender}");
            }
            Console.WriteLine();

            var animalLongName = animals.Where(a => a.Name.Length > 10);
            if (animalLongName != null)
            {
                Console.WriteLine($"First animal with a name longer than 10 characters: {animalLongName.Name}");
            }
            else
            {
                Console.WriteLine("No animal with a name longer than 10 characters was found.");
            }
        }
   }