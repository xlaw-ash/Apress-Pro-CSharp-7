using System;
using System.Collections.Generic;
using System.Text;

namespace Iterations
{
    class Flower
    {
        public enum Colors { Red, Pink, White, Yellow}
        public string Name { get; set; }
        public Colors Color { get; set; }

        public Flower(string name, Colors color) { this.Name = name; this.Color = color; }
    }
}
