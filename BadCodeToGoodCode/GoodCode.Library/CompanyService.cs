namespace GoodCode.Library
{
    public class CompanyService
    {
        public List<Company> GetCompanies()
        {
            return new List<Company>()
            {
                 new(){ Name="Acme", HourlyPayment=150},
                 new(){ Name="ABC", HourlyPayment=125},

            };
        }
    }
}
