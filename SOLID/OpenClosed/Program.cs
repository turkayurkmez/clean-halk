namespace OpenClosed
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            /*
             *  Bir nesne ....Gelişime.... AÇIK .......Değişime.... KAPALI olmalıdır.
             */
            OrderManagement orderManagement = new OrderManagement();
            Customer customer = new Customer() { Name = "Türkay", Card = new Premium() };
            orderManagement.Customer = customer;

            var discountedPrice = orderManagement.GetDiscountedPrice(100);
            Console.WriteLine(discountedPrice);
        }
    }
}