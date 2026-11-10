using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment9.Models

{
    // Question 3:
    // Add a Department property to the Person class.
    // Instantiate two Person objects with different departments
    // and print their details.

    public class Person
    {
        public string Name { get; set; }

        public virtual string Department { get; set; }

        public override string ToString()
        {
            return $"Name: {Name}, Department: {Department}";
        }
    }
}
