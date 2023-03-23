using System;
namespace Inheritance.Models
{

    public class Shape
    {
        private string name;
        private string color;
        private int[] position = new int[2];

        public Shape(string name, string color, int[] position)
        {
            this.name = name;
            this.color = color;
            this.position = position;
        }

        public string Name
        {
            get { return name; }
            set
            {
                Console.WriteLine($"Changing the name of the {color} {name} to {value}");
                name = value;
            }
        }

        public string Color
        {
            get { return color; }
            set
            {
                Console.WriteLine($"Changing the color of {name} from {color} to {value}");
                color = value;
            }
        }

        public int[] Position
        {
            get { return position; }
        }

        public virtual void getArea()
        {
            Console.WriteLine("There is no special implementation for area");
        }

        public virtual void getPerimeter()
        {
            Console.WriteLine("There is no special implementation for perimeter");
        }

        public static void move(Shape shape)
        {
            shape.position[0] += 5;
            shape.position[1] += 5;
        }
    }
}


