using System;

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

            Console.WriteLine("Two ways to call BenefitPackage's ComputePayDeduction method: ");
            Console.WriteLine($"Method: {mark.GetBenefitsCost()}");
            Console.WriteLine($"Property: {mark.BenefitsCost}");

            mark.GiveBonus(100);
            Console.WriteLine($"Pay after bonus: {mark.Pay}");

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
