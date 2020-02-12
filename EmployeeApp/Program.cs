using System;

namespace EmployeeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine
            (
                "-----------------------\n" +
                "Fun With Employee Class\n" +
                "-----------------------\n"
            );

            Employee emp = new Employee("Mark", 101, 32, 12000);
            emp.GiveBonus(1000);
            emp.DisplayState();

            //Reset and get the Name property
            emp.Name = "John";            
            Console.WriteLine($"\nChanged the name to {emp.Name}");
            emp.DisplayState();

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
