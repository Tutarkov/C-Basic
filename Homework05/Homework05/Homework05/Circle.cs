namespace Inheritance.Models
{
    public class Circle : Shape
    {
        private int radius;

        public Circle(string name, string color, int[] position, int radius) : base(name, color, position)
        {
            this.radius = radius;
        }

        public int Radius
        {
            get { return radius; }
            set { radius = value; }
        }

        public override void getArea()
        {
            Console.WriteLine($"The area of the {Color} {Name}  is {Math.PI * radius * radius}");
        }

        public override void getPerimeter()
        {
            Console.WriteLine($"The perimeter of the {Color} {Name}  is {2 * Math.PI * radius}");
        }
    }
}