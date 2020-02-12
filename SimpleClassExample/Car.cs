using System;

namespace SimpleClassExample
{
    class Car
    {
        //The 'state' of the Car
        public string petName;
        public int currSpeed;

        // The Functionality of the Car
        // Using the expression-bodied member syntax introduced in C# 6
        public void PrintState() => Console.WriteLine($"{petName} is going {currSpeed} MPH");
        public void SpeedUp(int delta) => currSpeed += delta;
    }
}
