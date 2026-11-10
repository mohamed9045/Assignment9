using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment9.Models

{
    // Question 4:
    // Extend the Child class to include DisplaySalary
    // and use the sealed Salary property.

    public class ChildSalary : ParentSalary
    {
        public sealed override decimal Salary
        {
            get { return base.Salary; }
            set { base.Salary = value; }
        }

        public void DisplaySalary()
        {
            Console.WriteLine($"Salary: {Salary}");
        }
    }
}

