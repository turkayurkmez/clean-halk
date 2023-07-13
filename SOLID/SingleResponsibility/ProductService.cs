namespace SingleResponsibility
{
    public class ProductService
    {
        public int CreateNewProductToDatabase(string name, decimal price)
        {
            return 13;
        }

        public void UpdateProductPrice(int product, decimal newPrice) { }

        public void GetAllProducts() { }

        public void UpdateProductStock()
        {
            Notification notification = new Notification();
            notification.SendMailToSupplier();
        }
    }
}
