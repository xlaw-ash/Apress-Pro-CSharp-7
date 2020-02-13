using System;
using System.Collections.Generic;
using System.Text;

namespace Cloning
{
    class Point : ICloneable
    {
        public string Name { get; set; }
        public int X { get; set; }
        public int Y { get; set; }

        public Point() { }
        public Point(string name, int x, int y) { Name = name; X = x; Y = y; }

        // Override method ToString()
        public override string ToString() => $"{Name}: ({X},{Y})";
        public object Clone() => new Point(Name, X, Y);

        // Use this when class does not contain reference types
        //public object Clone() => this.MemberwiseClone();
    }
}
