// ITN114 Wireless Internet and Pervasive Computing
// Convert Days: A C# operators exercise
// Azalea Mae C. Manimog

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertDays
{
    class Program
    {
        static void Main(string[] args)
        {
            int days, years, weeks;
            Console.WriteLine("Enter days:");
            days = Convert.ToInt32(Console.ReadLine());

            years = (days / 365);
            weeks = (days % 365) / 7;
            days = days - ((years * 365) + (weeks * 7));

            Console.WriteLine("Years: " + years);
            Console.WriteLine("Weeks: " + weeks);
            Console.WriteLine("Days: " + days);

            Console.ReadKey();
        }
    }
}
