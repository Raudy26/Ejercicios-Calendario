using System;
using System.Globalization;

class Program
{
    static void Main()
    {

        DateTime now = DateTime.Now;


        DateTime firstDayOfMonth = new DateTime(now.Year, now.Month, 1);


        string monthYear = now.ToString("MMMM yyyy", CultureInfo.CurrentCulture);


        int startDayOfWeek = (int)firstDayOfMonth.DayOfWeek;


        startDayOfWeek = (startDayOfWeek + 6) % 7;


        int daysInMonth = DateTime.DaysInMonth(now.Year, now.Month);


        Console.WriteLine($"{monthYear}\n");


        Console.WriteLine("lu ma mi ju vi sá do");


        for (int i = 0; i < startDayOfWeek; i++)
        {
            Console.Write("   ");
        }

        // Imprimir los días del mes
        for (int day = 1; day <= daysInMonth; day++)
        {
            Console.Write($"{day,2} ");
            if ((day + startDayOfWeek) % 7 == 0)
            {
                Console.WriteLine();
            }
        }
        Console.WriteLine();
    }
}