namespace GoodCode.Library
{
    public class TimeSheetBillCalculator
    {
        public double GetTotalHoursWorkedForCompany(List<TimeSheetEntry> timeSheetEntries, string companyName)
        {
            double totalHoursWorked = 0;
            for (int i = 0; i < timeSheetEntries.Count; i++)
            {
                if (timeSheetEntries[i].WorkDone.ToLower().Contains(companyName.ToLower()))
                {
                    totalHoursWorked += timeSheetEntries[i].HoursWorked;
                }
            }
            return totalHoursWorked;
        }

        public double GetTotalHoursWorked(List<TimeSheetEntry> timeSheetEntries)
        {
            double totalHoursWorked = 0;
            for (int i = 0; i < timeSheetEntries.Count; i++)
            {
                totalHoursWorked += timeSheetEntries[i].HoursWorked;
            }
            return totalHoursWorked;
        }

        public double CalculateExtraPayment(double totalHoursWorked, double maxHourInAWeek, double extraPayment, double standartPayment)
        {

            if (totalHoursWorked > maxHourInAWeek)
            {
                var paymentForMoreThanMax = (totalHoursWorked - maxHourInAWeek) * extraPayment;
                var paymentForStandard = maxHourInAWeek * standartPayment;
                var totalPayment = paymentForMoreThanMax + paymentForStandard;

                return totalPayment;
                //Console.WriteLine($"You will get paid ${totalPayment} for your work.");
            }
            else
            {
                return totalHoursWorked * standartPayment;
                //Console.WriteLine("You will get paid $" + (totalHoursWorked * standartPayment) + " for your time.");
            }
        }
    }
}
