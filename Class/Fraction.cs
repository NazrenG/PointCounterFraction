using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step_cs.Class
{
    internal class Fraction
    {
        public int Numerator { get; set; }//suret
        public int Denominator { get; set; }//mexrec
        public int num = 0;
        public int den = 0;

        public Fraction()
        {
            Numerator = 1;
            Denominator = 1;
        }
        public Fraction(int numerator, int denominator)
        {
            this.Numerator = numerator;
            this.Denominator = denominator;
        }

        public void Add(ref Fraction other)
        {
            den = Denominator * other.Denominator;
            num = (den / Denominator) * Numerator + (den / other.Denominator) * other.Numerator;
            Console.WriteLine($"{num}/{den}");

        }
        public void Subtrac(ref Fraction other)
        {
            den = Denominator * other.Denominator;
            num = (den / Denominator) * Numerator - (den / other.Denominator) * other.Numerator;
            Console.WriteLine($"{num}/{den}");
        }
        public void Multiply(ref Fraction other)
        {
            den = Denominator * other.Denominator;
            num = Numerator * other.Numerator;
            Console.WriteLine($"{num}/{den}");
        }
        public void Divide(ref Fraction other)
        {
            den = Denominator * other.Numerator;
            num = Numerator * other.Denominator;
            Console.WriteLine($"{num}/{den}");
        }
        public void Reduction()//ixtisar
        {
            
            int size_min,size_max,temp=0;
            if (num > den)
            {
                size_min = den;
                size_max = num;
            }
            else
            {
                size_min = num;
                size_max = den;
            }
            
            for (int i = 1; i <= size_min; i++)
            {
                if (size_max % i == 0) temp = i;
            }
            Console.WriteLine($"ixtisar-> {num/temp}/{den/temp}");
            
        }



    }
}
