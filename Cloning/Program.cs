using System;

namespace Cloning
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine
            (
                "----------------\n" +
                "Fun With Cloning\n" +
                "----------------\n"
            );

            Point A = new Point("A", 2, 3);
            Console.WriteLine(A.ToString());

            // Make a clone of Point A
            Point B = (Point)A.Clone();
            Console.WriteLine(B.ToString());

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
