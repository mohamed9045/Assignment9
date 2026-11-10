using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment9.Models

{
    // Question 16:
    // Create a Circle struct with Radius and Color.
    // Compare instances using == and Equals.

    public struct CircleStruct
    {
        public double Radius { get; set; }
        public string Color { get; set; }

        public CircleStruct(double radius, string color)
        {
            Radius = radius;
            Color = color;
        }

        public override bool Equals(object obj)
        {
            if (obj is CircleStruct other)
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

        public static bool operator ==(
            CircleStruct a, CircleStruct b)
        {
            return a.Equals(b);
        }

        public static bool operator !=(
            CircleStruct a, CircleStruct b)
        {
            return !a.Equals(b);
        }
    }
}
