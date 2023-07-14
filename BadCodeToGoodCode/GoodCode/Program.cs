using GoodCode.Library;

namespace GoodCode
{
    class Program
    {
        static void Main(string[] args)
        {

            List<TimeSheetEntry> timeSheetEntries = loadEntries();
            var companies = new CompanyService().GetCompanies();

            TimeSheetBillCalculator timeSheetBillCalculator = new TimeSheetBillCalculator();
            SendMailComponent sendMailComponent = new SendMailComponent();


            sendMailComponent.SendMailSimulation(timeSheetEntries, companies);


            double totalHoursWorked = timeSheetBillCalculator.GetTotalHoursWorked(timeSheetEntries);
            var totalPayment = timeSheetBillCalculator.CalculateExtraPayment(totalHoursWorked,
                                  maxHourInAWeek: 40,
                                  extraPayment: 15,
                                  standartPayment: 10);


            Console.WriteLine($"You will get paid ${totalPayment} for your work.");
            Console.WriteLine();
            Console.Write("Press any key to exit application...");
            Console.ReadKey();
        }


        static List<TimeSheetEntry> loadEntries()
        {
            string workDone;
            string rawTimeWorked;
            double totalHoursWorked;
            double timeForWork;

            List<TimeSheetEntry> timeSheetEntries = new List<TimeSheetEntry>();
            string answer = string.Empty;

            do
            {
                Console.Write("Enter what you did: ");
                workDone = Console.ReadLine();
                Console.Write("How long did you do it for: ");

                timeForWork = getTimeForWorkFromUser();

                TimeSheetEntry timeSheetEntry = new TimeSheetEntry
                {
                    HoursWorked = timeForWork,
                    WorkDone = workDone
                };
                timeSheetEntries.Add(timeSheetEntry);
                Console.Write("Do you want to enter more time (yes/no): ");

                answer = Console.ReadLine();

            } while (answer.ToLower() == "yes");



            return timeSheetEntries;
        }

        private static double getTimeForWorkFromUser()
        {
            string rawTimeWorked = Console.ReadLine();
            double timeForWork;
            while (double.TryParse(rawTimeWorked, out timeForWork) == false)
            {
                Console.WriteLine();
                Console.WriteLine("Invalid number given");
                Console.Write("How long did you do it for: ");
                rawTimeWorked = Console.ReadLine();
            }

            return timeForWork;
        }




    }
}