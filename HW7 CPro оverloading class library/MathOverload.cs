using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace HW7_CPro_оverloading_class_library
{
 
    public class ComplexNumber
    {
        public double Real { get; set; }
        public double Imaginary { get; set; }

        public ComplexNumber(double real, double imaginary)
        {
            Real = real;
            Imaginary = imaginary;

        }

        public static ComplexNumber operator +(ComplexNumber c1, ComplexNumber c2)
        {
            return new ComplexNumber(c1.Real + c2.Real, c1.Imaginary + c2.Imaginary);

        }
       
        public static ComplexNumber operator -(ComplexNumber c1, ComplexNumber c2)
        {
            return new ComplexNumber(c1.Real - c2.Real, c1.Imaginary - c2.Imaginary);

        }
      
        public static ComplexNumber operator *(ComplexNumber c1, ComplexNumber c2)
        {
            return new ComplexNumber(
                c1.Real * c2.Real - c1.Imaginary * c2.Imaginary,
                c1.Real * c2.Imaginary + c1.Imaginary
     * c2.Real
            );
        }
  
        public static ComplexNumber operator / (ComplexNumber c1, ComplexNumber c2)
        {
           double denominator  = c2.Real * c2.Real + c2.Imaginary * c2.Imaginary;
            if (denominator == 0)
            { throw new DivideByZeroException("Divide By Zero "); }
                
            return new ComplexNumber((c1.Real + c2.Real + c1.Imaginary * c2.Imaginary)/denominator,
                                     (c1.Imaginary*c2.Real - c1.Real*c2.Imaginary)/denominator);

        }


        public override string ToString()
        {
            return $"{Real} + {Imaginary}i";
        }


        public static bool operator ==(ComplexNumber c1, ComplexNumber c2)
        {
            if (ReferenceEquals(c1, c2))
            {
                return true;
            }
            if (ReferenceEquals(c1, null) || ReferenceEquals(c2, null))
            {
                return false;
            }
            return c1.Real == c2.Real && c1.Imaginary == c2.Imaginary;
        }

        public static bool operator !=(ComplexNumber c1, ComplexNumber c2)
        {
            return !(c1 == c2);
        }

    
        public override bool Equals(object obj)
        {
            if (obj is ComplexNumber other)
            {
                return this == other;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return Real.GetHashCode() ^ Imaginary.GetHashCode();
        }


    }



}
