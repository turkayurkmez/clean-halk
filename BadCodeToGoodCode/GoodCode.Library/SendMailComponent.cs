namespace GoodCode.Library
{
    public class SendMailComponent
    {
        public void SendMailSimulation(List<TimeSheetEntry> timeSheetEntries, List<Company> companies)
        {
            foreach (var company in companies)
            {
                SendMail(timeSheetEntries, company);
            }
        }
        public void SendMail(List<TimeSheetEntry> timeSheetEntries, Company company)
        {
            double totalHoursWorked = new TimeSheetBillCalculator().GetTotalHoursWorkedForCompany(timeSheetEntries, company.Name);

            Console.WriteLine($"Simulating Sending email to {company.Name} ");
            Console.WriteLine("Your bill is $" + (totalHoursWorked * company.HourlyPayment) + " for the hours worked.");
        }
    }
}
