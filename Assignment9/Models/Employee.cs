using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment9.Models

{
    // Question 10:
    // Enhance Employee with Equals method
    // to compare employees by their IDs.
    //
    // Question 15:
    // Add Department property to Employee
    // to support searching by department.

    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Department Department { get; set; }

        public Employee(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public Employee(int id, string name, Department department)
        {
            Id = id;
            Name = name;
            Department = department;
        }

        public override bool Equals(object obj)
        {
            if (obj is Employee other)
            {
                return Id == other.Id;
            }

            return false;
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }

        public override string ToString()
        {
            return $"ID: {Id}, Name: {Name}";
        }
    }
}
