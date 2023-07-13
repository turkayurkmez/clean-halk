namespace Functions
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string HomeAddress { get; set; }
        public string Phone { get; set; }


    }
    public class CustomerService
    {
        public void AddCustomer(Customer customer) { }
    }
}
