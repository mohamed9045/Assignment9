using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment9.Helpers

{
    // Question 5:
    // Create a static method to calculate
    // the perimeter of a rectangle.
    //
    // Question 8:
    // Create static methods to convert
    // Celsius to Fahrenheit and Fahrenheit to Celsius.

    public static class Utility
    {
        public static double CalculatePerimeter(
            double length, double width)
        {
            return 2 * (length + width);
        }

        public static double CelsiusToFahrenheit(double celsius)
        {
            return (celsius * 9 / 5) + 32;
        }

        public static double FahrenheitToCelsius(double fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9;
        }
    }
}

