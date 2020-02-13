using System;

namespace Iterations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine
            (
                "------------------\n" +
                "Fun With Iterators\n" +
                "------------------\n"
            );

            // A simple iterator foreach.
            int[] intArray = new int[] { 1,2,3,4,5 };
            foreach(int num in intArray) { Console.Write(num + " "); }
            Console.WriteLine();

            // Let's create some flowers
            Flower rose = new Flower("Rose", Flower.Colors.Red);
            Flower lily = new Flower("Lily", Flower.Colors.White);
            Flower lotus = new Flower("Lotus", Flower.Colors.Pink);
            Flower sunflower = new Flower("Sunflower", Flower.Colors.Yellow);
            Flower jasmine = new Flower("Jasmine", Flower.Colors.White);

            // These flowers will look good in a bouquet.
            Bouquet bouquet = new Bouquet();
            try
            {
                bouquet.Add(rose);
                bouquet.Add(lily);
                bouquet.Add(sunflower);
                bouquet.Add(jasmine);
                bouquet.Add(rose);
                bouquet.Add(lily);
                bouquet.Add(lotus);

            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            foreach(Flower flower in bouquet.GetFlowers())
            {
                Console.Write(flower.Name + " ");
            }
            Console.WriteLine();

            // Another way is to use enumerator. Enumerator can be used directly with class instead of creating a method.
            // Since a bouquet is a collection of flowers, ideally there should be no need to create a method to get list of flowers.

            foreach(Flower flower in bouquet)
            {
                Console.Write(flower.Name + " ");
            }
            Console.WriteLine();

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
