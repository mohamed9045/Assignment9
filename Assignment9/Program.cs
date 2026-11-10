
using System;
using System.Linq;
using System.Runtime.InteropServices;

using Assignment9.Enums;
using Assignment9.Models;
using Assignment9.Helpers;

namespace Assignment9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 1

            /*
            // Problem:
            // Create an enum called Weekdays with values
            // Monday = 1, Tuesday, Wednesday, Thursday, Friday.
            // Print the name and value of each day.

            foreach (Weekdays day in Enum.GetValues(typeof(Weekdays)))
            {
                Console.WriteLine($"{day} = {(int)day}");
            }

            // Question:
            // Why is it recommended to explicitly assign values
            // to enum members in some cases?

            // Answer:
            // To ensure fixed values and avoid unexpected changes
            // when adding or reordering enum members.
            */

            #endregion

            #region Question 2

            /*
            // Problem:
            // Modify Grades enum to use short as its underlying type
            // and set F to -1. Print all grade values and names.

            foreach (Grades grade in Enum.GetValues(typeof(Grades)))
            {
                Console.WriteLine($"{grade} = {(short)grade}");
            }

            // Question:
            // What happens if you assign a value to an enum member
            // that exceeds the underlying type's range?

            // Answer:
            // A compilation error occurs if the constant value
            // is outside the range of the underlying type.
           */

            #endregion

            #region Question 3

            /*
            // Problem:
            // Add a Department property to Person.
            // Create two Person objects with different departments
            // and print their details.

            Person p1 = new Person
            {
                Name = "Ahmed",
                Department = "Computer Science"
            };

            Person p2 = new Person
            {
                Name = "Ali",
                Department = "Information Systems"
            };

            Console.WriteLine(p1);
            Console.WriteLine(p2);

            // Question:
            // What is the purpose of the virtual keyword
            // when used with properties?

            // Answer:
            // It allows derived classes to override the property
            // and provide their own implementation.
            */

            #endregion

            #region Question 4

            /*
            // Problem:
            // Extend ChildSalary to include DisplaySalary
            // that uses the sealed Salary property.
            // Instantiate the class and demonstrate its usage.

            ChildSalary child = new ChildSalary
            {
                Salary = 5000
            };

            child.DisplaySalary();

            // Question:
            // Why can't you override a sealed property or method?

            // Answer:
            // Because sealed prevents further derived classes
            // from overriding that member.
            */

            #endregion

            #region Question 5

            /*
            // Problem:
            // Write a static method in Utility to calculate
            // the perimeter of a rectangle.
            // Call it without creating an instance.

            double perimeter = Utility.CalculatePerimeter(5, 3);

            Console.WriteLine($"Perimeter = {perimeter}");

            // Question:
            // What is the key difference between static
            // and object members?

            // Answer:
            // Static members belong to the class,
            // while object members belong to instances.
            */

            #endregion

            #region Question 6

            /*
            // Problem:
            // Add operator overloading for multiplication (*)
            // of two complex numbers.

            ComplexNumber c1 = new ComplexNumber(2, 3);
            ComplexNumber c2 = new ComplexNumber(4, 5);

            ComplexNumber result = c1 * c2;

            Console.WriteLine(result);

            // Question:
            // Can you overload all operators in C#?

            // Answer:
            // No. Only specific predefined operators
            // can be overloaded in C#.
            */

            #endregion

            #region Question 7

            /*
            // Problem:
            // Modify Gender enum to use byte as its underlying type.
            // Demonstrate its memory usage compared to int.

            Console.WriteLine(
                $"Gender Size = {Marshal.SizeOf<Gender>()} bytes");

            Console.WriteLine(
                $"Int Size = {sizeof(int)} bytes");

            // Question:
            // When should you consider changing the underlying
            // type of an enum?

            // Answer:
            // When memory optimization is important
            // and the enum values fit within a smaller type.
            */

            #endregion

            #region Question 8

            /*
            // Problem:
            // Create static methods to convert temperatures
            // between Celsius and Fahrenheit.

            double fahrenheit = Utility.CelsiusToFahrenheit(25);
            double celsius = Utility.FahrenheitToCelsius(77);

            Console.WriteLine($"Fahrenheit = {fahrenheit}");
            Console.WriteLine($"Celsius = {celsius}");

            // Question:
            // Why can't a static class have instance constructors?

            // Answer:
            // Because static classes cannot be instantiated
            // and cannot contain instance members.
            */

            #endregion

            #region Question 9

            /*
            // Problem:
            // Try to parse a string to a Grades enum value
            // using Enum.TryParse to handle invalid inputs.

            string input = "A";

            if (Enum.TryParse<Grades>(input, true, out Grades grade))
            {
                Console.WriteLine($"Grade = {grade}");
            }
            else
            {
                Console.WriteLine("Invalid Grade");
            }

            // Question:
            // What are the advantages of Enum.TryParse
            // over direct parsing with int.Parse?

            // Answer:
            // It safely handles invalid inputs and returns false
            // instead of throwing an exception.
            */

            #endregion

            #region Question 10

            /*
            // Problem:
            // Enhance Employee with Equals method.
            // Search for an employee in an array using
            // Helper2<Employee>.SearchArray.

            Employee e1 = new Employee(1, "Ahmed");
            Employee e2 = new Employee(2, "Ali");
            Employee e3 = new Employee(3, "Omar");

            Employee[] employees = { e1, e2, e3 };

            Employee searchEmployee = new Employee(2, "Ali");

            int index = Helper2<Employee>.SearchArray(
                employees, searchEmployee);

            Console.WriteLine($"Employee Index = {index}");

            // Question:
            // What is the difference between overriding Equals
            // and == for object comparison in C# struct and class?

            // Answer:
            // Equals can be overridden to compare values.
            // For classes, == normally compares references.
            // For structs, == must be overloaded explicitly.
            */

            #endregion

            #region Question 11

            /*
            // Question:
            // Why is overriding ToString beneficial
            // when working with custom classes?

            // Answer:
            // It provides a meaningful string representation
            // of an object instead of its class name.

            Employee employee = new Employee(1, "Ahmed");

            Console.WriteLine(employee.ToString());
            */

            #endregion

            #region Question 12

            /*
            // Problem:
            // Write a generic Max method that returns
            // the greater value of two arguments.
            // Demonstrate with integers, doubles, and strings.

            Console.WriteLine(Helper.Max(10, 20));

            Console.WriteLine(Helper.Max(5.5, 2.5));

            Console.WriteLine(Helper.Max("Ahmed", "Mohamed"));

            // Question:
            // Can generics be constrained to specific types?

            // Answer:
            // Yes, using constraints such as class, struct,
            // or IComparable<T>.
            */

            #endregion

            #region Question 13

            /*
            // Problem:
            // Add ReplaceArray method in Helper2<T>.
            // Replace all occurrences of a value in an array.

            int[] numbers = { 1, 2, 3, 2, 4 };

            Helper2<int>.ReplaceArray(numbers, 2, 9);

            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            string[] names = { "Ali", "Ahmed", "Ali" };

            Helper2<string>.ReplaceArray(names, "Ali", "Omar");

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            // Question:
            // What are the key differences between generic
            // methods and generic classes?

            // Answer:
            // Generic methods define type parameters for individual
            // methods, while generic classes define type parameters
            // for the entire class.
            */

            #endregion

            #region Question 14

            /*
            // Problem:
            // Write a non-generic Swap method for Rectangle.
            // Demonstrate swapping two Rectangle instances.

            Rectangle r1 = new Rectangle(10, 5);
            Rectangle r2 = new Rectangle(20, 8);

            Console.WriteLine(
                $"Before: R1 = {r1.Length}, {r1.Width}");

            RectangleHelper.Swap(ref r1, ref r2);

            Console.WriteLine(
                $"After: R1 = {r1.Length}, {r1.Width}");

            Console.WriteLine(
                $"After: R2 = {r2.Length}, {r2.Width}");

            // Question:
            // Why might using a generic swap method be preferable?

            // Answer:
            // It avoids code duplication and works
            // with different data types.
            */

            #endregion

            #region Question 15

            /*
            // Problem:
            // Create a Department class and add a Department
            // property to Employee.
            // Search employees by department using SearchArray.

            Department d1 = new Department(1, "IT");
            Department d2 = new Department(2, "HR");

            Employee emp1 = new Employee(1, "Ahmed", d1);
            Employee emp2 = new Employee(2, "Ali", d2);
            Employee emp3 = new Employee(3, "Omar", d1);

            Employee[] employees =
            {
                emp1,
                emp2,
                emp3
            };

            Department searchDepartment =
                new Department(1, "IT");

            int index = Helper2<Employee>.SearchArray(
                employees,
                emp => emp.Department.Equals(searchDepartment)
            );

            Console.WriteLine($"Employee Index = {index}");

            // Question:
            // How can overriding Equals for Department
            // improve the accuracy of searches?

            // Answer:
            // It compares departments by their IDs
            // instead of comparing object references.
            */

            #endregion

            #region Question 16

            /*
            // Problem:
            // Create a Circle struct and a Circle class.
            // Compare their instances using == and Equals.

            CircleStruct s1 = new CircleStruct(5, "Red");
            CircleStruct s2 = new CircleStruct(5, "Red");

            Console.WriteLine("Struct Comparison:");

            Console.WriteLine(s1 == s2);
            Console.WriteLine(s1.Equals(s2));

            CircleClass c1 = new CircleClass(5, "Red");
            CircleClass c2 = new CircleClass(5, "Red");

            Console.WriteLine("Class Comparison:");

            Console.WriteLine(c1 == c2);
            Console.WriteLine(c1.Equals(c2));

            // Question:
            // Why is == not implemented by default for structs?

            // Answer:
            // Because C# does not automatically define
            // the == operator for user-defined structs.
            // It must be overloaded explicitly.
            */

            #endregion
        }
    }
}
