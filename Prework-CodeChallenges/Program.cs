﻿using System;

namespace Prework_CodeChallenges
{
    class Program
    {

        string PerfectSequence(int[] arr)
        {
            int sum = 0;
            int multiply = 1;

            foreach(int e in arr)
            {
                if (e < 0)
                    return "NO";

                sum += e;
                multiply *= e;
            }

            if (sum == multiply)
                return "YES";

            return "NO";
        }


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
      
        int ArrayAndMax()
        {
            int[] arr = new int[5];
            int counter = 0;
            while(counter < 5)
            {
                Console.WriteLine("Enter 5 numbers between 1-10: (followed by Enter)");
                int n = Convert.ToInt32(Console.ReadLine());
                if(n < 1 || n > 10)
                {
                    Console.WriteLine("number in NOT between 1 and 10");
                    continue;
                }

                arr[counter] = n;

                counter++;
            }

            int numRepeating = 0;
            Console.WriteLine("Enter score number:");
            int num = Convert.ToInt32(Console.ReadLine());
            foreach (int e in arr)
            {
                if (e == num)
                    numRepeating++;
            }

            return numRepeating * num;

        }

        static void Main(string[] args)
        {

            Console.WriteLine(new Program().IsLeapYear(2000));
            Console.WriteLine(new Program().IsLeapYear(1997));

            int result = new Program().ArrayAndMax();
            Console.WriteLine("Scored number: " + result);

            int[] a = { 1, 3, 2 };
            int[] a1 = { 1, -3, 2 };
            int[] b = { 4,5,6 };
            Console.WriteLine(new Program().PerfectSequence(a));
            Console.WriteLine(new Program().PerfectSequence(a1));
            Console.WriteLine(new Program().PerfectSequence(b));

        }
    }
}
