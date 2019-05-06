using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leap_Year
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a year to check ..");
            int year = Convert.ToInt32(Console.ReadLine());
            if (CheckLeapYear(year))

                Console.WriteLine(year + " Is leap year");
            else
                Console.WriteLine(year + " Is not leap year");

        }
        static bool CheckLeapYear(int yearcheck)
        {
            if (yearcheck % 400 == 0)
                return true;
            if (yearcheck % 100 == 0)
                return false;
            if (yearcheck % 4 == 0)
                return true;
            return false;

        }
    } 

}
