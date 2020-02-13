using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptionHandling
{
    // This is a simple custom exception that returns message. To create a proper exception, all data needs to return values.
    class ColorInRainbowException : ApplicationException
    {
        private string color = String.Empty;

        public ColorInRainbowException() { }
        public ColorInRainbowException(string color) { this.color = color; }

        // Read ApplicationException class to override methods from ApplicationException class
        public override string Message => $"Error: {color} is not a color in Rainbow";
    }
}
