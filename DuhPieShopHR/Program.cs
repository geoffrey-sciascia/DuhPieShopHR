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


            Console.ReadLine();
        }
    }
}
 