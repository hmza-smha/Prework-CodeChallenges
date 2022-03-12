using System;

namespace Prework_CodeChallenges
{
    class Program
    {

        bool IsLeapYear(int year)
        {
            if (year % 4 == 0 && year % 100 == 0 && year % 400 == 0)
                return true;
            else if (year % 4 == 0 && year % 100 == 0)
                return false;
            else if (year % 4 == 0)
                return true;
            else
                return false;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(new Program().IsLeapYear(2000));
            Console.WriteLine(new Program().IsLeapYear(1997));
        }
    }
}
