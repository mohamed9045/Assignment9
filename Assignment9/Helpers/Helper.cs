using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment9.Helpers

{
    // Question 12:
    // Write a generic Max method that returns
    // the greater value of two arguments.

    public static class Helper
    {
        public static T Max<T>(T a, T b)
            where T : IComparable<T>
        {
            return a.CompareTo(b) > 0 ? a : b;
        }
    }
}
