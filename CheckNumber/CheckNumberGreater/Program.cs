﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckNumberGreater
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int year;
            Console.WriteLine("Enter Year");
            year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(year % 4 == 0 ? "This year is leap year" : "This year is not leap year");
            Console.ReadLine();

            
        }
    }
}
