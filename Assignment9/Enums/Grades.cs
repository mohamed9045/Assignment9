using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment9.Enums

{
    // Question 2:
    // Modify the Grades enum to use short
    // as its underlying type and set F to -1.

    public enum Grades : short
    {
        F = -1,
        D = 0,
        C = 1,
        B = 2,
        A = 3
    }
}
