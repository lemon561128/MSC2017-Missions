using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace  Myfirstapp
{
    class Program
    {
        class Complex
        {
            public Complex() { realPart = 0;imaginaryPart = 0; }
            public Complex(float real, float imaginary) { realPart = real; imaginaryPart = imaginary; }
            public override string ToString()
            {
                string result = realPart.ToString();
                if (imaginaryPart >= 0) result += "+";
                result += imaginaryPart.ToString() + "i";
                return result;
            }


            static public Complex operator +(Complex a, Complex b)
            {
                Complex result = new Complex();
                result.realPart = a.realPart + b.realPart;
                result.imaginaryPart = a.imaginaryPart + b.imaginaryPart;
                return result;
            }
           
            private float realPart;
            private float imaginaryPart;
        }
          static void Main(string[] args)
           {
            Complex a = new Complex(1, 1);
            Complex b = new Complex(2, 8);
            Console.WriteLine(a + b);
            Console.WriteLine(5 * 6);
            Console.WriteLine(793 / 20);
            double n = Math.Pow(11, 20);
            Console.WriteLine(n);
           }
        }
}


