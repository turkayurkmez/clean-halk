namespace LiskovSubstution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //Rectangle rectangle = new Rectangle() { Width = 5, Height = 10 };
            //Square square = new Square() { Height = 15 };

            //Console.WriteLine($"Rectangle: {rectangle.GetArea()}");
            //Console.WriteLine($"Square: {square.GetArea()}");


            var aRect = Geometry.CreateRectangle(5, 6);

            Console.WriteLine(aRect.GetArea());

        }
    }
}