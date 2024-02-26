using System;

class Program
{
    static void Main()
    {

        Console.Write("Enter your name: ");
        string name = Console.ReadLine();

        Console.Write("Enter your date of birth (yyyy-MM-dd): ");
        DateTime dob = DateTime.Parse(Console.ReadLine());
        DateTime currentDate = DateTime.Now;
        TimeSpan ageTimeSpan = currentDate - dob;
        int years = currentDate.Year - dob.Year;
        int months = currentDate.Month - dob.Month;
        int days = currentDate.Day - dob.Day;
        if (days < 0)
        {
            months--;
            days += DateTime.DaysInMonth(currentDate.Year, currentDate.Month - 1);
        }

        if (months < 0)
        {
            years--;
            months += 12;
        }
        Console.WriteLine($"Hello, {name}!");
        Console.WriteLine($"Your DOB: {dob.ToShortDateString()}");
        Console.WriteLine($"Age as of now: {years} Years {months} Months {ageTimeSpan.Days} Days");
    }
}
