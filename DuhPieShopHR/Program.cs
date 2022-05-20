using System;

namespace DuhPieShopHR
{
    class Program
    {
        static void Main(string[] args)
        {
            int monthlyWage = 1234;
            int months = 12, hours = 1000;

            bool isActive = true;
            double rating = 99.25;

            double hourlyRate = 21.20;
            int numberOfHoursWorked = 160;

            double currentWage = hourlyRate * numberOfHoursWorked;

            Console.WriteLine(currentWage);

            hourlyRate += 3;

            if(currentWage > 4000)
            {
                Console.WriteLine("Top gold employee");
            }

            int numberOfEmployees = 15;

            numberOfEmployees--;

            int maxValue = int.MaxValue;
            int minValue = int.MinValue;

            char userSelection = 'a';
            char upperCase = char.ToUpper(userSelection);
            bool isDigit = char.IsDigit(userSelection);
            bool isLetter = char.IsLetter(userSelection);

            DateTime hireDate = new DateTime(2021, 03, 28, 14, 30, 0);

            Console.WriteLine(hireDate);

            DateTime exitDate = new DateTime(2021, 12, 11);

            DateTime startDate = hireDate.AddDays(15);

            Console.WriteLine(startDate);

            DateTime currentDate = DateTime.Now;
            bool areWeInDST = currentDate.IsDaylightSavingTime();

            DateTime startHour = DateTime.Now;
            TimeSpan workTime = new TimeSpan(0, 35, 0);
            DateTime endHour = startHour.Add(workTime);

            Console.WriteLine(startHour.ToLongDateString());
            Console.WriteLine(endHour.ToShortTimeString());

            Console.ReadLine();
        }
    }
}
 