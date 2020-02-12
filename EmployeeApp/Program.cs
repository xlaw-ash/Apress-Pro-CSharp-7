﻿using System;

namespace EmployeeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine
            (
                "----------------------------\n" +
                "The Employee Class Hierarchy\n" +
                "----------------------------\n"
            );

            SalesPerson mark = new SalesPerson("Mark", 101, 32, 30000, "123-456-7890", 70);
            Console.WriteLine
            (
                $"Name:\t{mark.Name}\n" +
                $"ID:\t{mark.ID}\n" +
                $"Age:\t{mark.Age}\n" +
                $"Pay:\t{mark.Pay}\n" +
                $"SSN:\t{mark.empSSN}\n" +
                $"Sales:\t{mark.SalesNumber}"
            );

            Console.WriteLine
            (
                "\n--------------" +
                "\nEnd of Program" +
                "\n--------------"
            );
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }
    }
}
