using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment9.Models;

namespace Assignment9.Helpers

{
    // Question 14

    public static class RectangleHelper
    {
        public static void Swap(
            ref Rectangle a, ref Rectangle b)
        {
            Rectangle temp = a;
            a = b;
            b = temp;
        }
    }
}
