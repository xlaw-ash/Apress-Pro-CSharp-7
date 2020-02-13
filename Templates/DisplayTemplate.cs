using System;
using System.Collections.Generic;
using System.Text;

namespace Templates
{
    public class DisplayTemplate
    {
        public static void Header(string title)
        {
            for(int i = 0; i < title.Length; i++) { Console.Write("-"); }
            Console.WriteLine($"\n{title}");
            for (int i = 0; i < title.Length; i++) { Console.Write("-"); }
            Console.WriteLine("\n");
        }

        public static void Footer()
        {
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
