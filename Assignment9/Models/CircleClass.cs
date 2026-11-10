using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment9.Models

{
    // Question 16:
    // Create a Circle class and compare its instances
    // using == and Equals.

    public class CircleClass
    {
        public double Radius { get; set; }
        public string Color { get; set; }

        public CircleClass(double radius, string color)
        {
            Radius = radius;
            Color = color;
        }

        public override bool Equals(object obj)
        {
            if (obj is CircleClass other)
            {
                return Radius == other.Radius &&
                       Color == other.Color;
            }

            return false;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Radius, Color);
        }
    }
}
