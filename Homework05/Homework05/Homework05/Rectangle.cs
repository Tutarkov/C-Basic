namespace Inheritance.Models
{
    public class Rectangle : Shape
    {
        private int sideA;
        private int sideB;

        public Rectangle(string name, string color, int[] position, int sideA, int sideB) : base(name, color, position)
        {
            this.sideA = sideA;
            this.sideB = sideB;
        }

        public int SideA
        {
            get { return sideA; }
            set { sideA = value; }
        }

        public int SideB
        {
            get { return sideB; }
            set { sideB = value; }
        }

        public override void getArea()
        {
            Console.WriteLine($"The area of the {Color} {Name} is {sideA * sideB}");
        }

        public override void getPerimeter()
        {
            Console.WriteLine($"The perimeter of the {Color} {Name}  is {((sideA + sideB) * 2)}");
        }
    }
}