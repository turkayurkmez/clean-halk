namespace InterfaceSegregation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            DividerComponent dividerComponent = new DividerComponent();
            var result = dividerComponent.Divide(new OnlyComplexMath(), 12, 3);
            Console.WriteLine(result);

        }
    }
}