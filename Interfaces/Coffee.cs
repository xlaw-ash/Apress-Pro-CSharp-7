using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    class Coffee : IBeverage, ICoffeePowder
    {
        // Let's start with example of making coffee.
        // Coffee is a beverage, so it should define qualities of a general beverage.
        public double Milk { get; set; }
        public double Water { get; set; }
        public int Sugar { get; set; }
        public bool Ice { get; set; }
        public bool Hot { get; set; }

        // Coffee also defines properties of Coffee powder
        public double Caffeine { get; set; }
        public bool IsDecaf { get; set; }

        // Methods
        public void Make()
        {
            Console.WriteLine($"Your {((IsDecaf) ? "Decaf" : "")} {((Hot) ? "Hot" : "Cold")} Coffee " +
                $"{((Sugar <= 0) ? "without" : $"with {Sugar} spoons sugar")} {((Ice && !Hot) ? "with Ice" : "")} is ready!\n" +
                $"Contents: {Milk} ml Milk, {Water} ml Water, and {Caffeine} units caffeine");
        }
    }
}
