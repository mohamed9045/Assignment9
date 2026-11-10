using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment9.Models

{
    // Question 6:
    // Add operator overloading for multiplication (*)
    // of two complex numbers.

    public class ComplexNumber
    {
        public int Real { get; set; }
        public int Imag { get; set; }

        public ComplexNumber(int real, int imag)
        {
            Real = real;
            Imag = imag;
        }

        public static ComplexNumber operator *(
            ComplexNumber a, ComplexNumber b)
        {
            return new ComplexNumber(
                a.Real * b.Real - a.Imag * b.Imag,
                a.Real * b.Imag + a.Imag * b.Real
            );
        }

        public override string ToString()
        {
            return $"{Real} + {Imag}i";
        }
    }
}

