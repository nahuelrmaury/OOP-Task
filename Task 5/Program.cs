using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Polynomial firstPoly = new Polynomial(1, 2, 3, 4, 5);
            Console.WriteLine(firstPoly);
            Polynomial secondPoly = new Polynomial(1, 2, 3, 4, 5);
            Console.WriteLine(secondPoly);
            Console.WriteLine(firstPoly + secondPoly);
            Console.WriteLine(firstPoly - secondPoly);
            Console.WriteLine(firstPoly * secondPoly);
        }
    }

    public class Polynomial
    {
        public double[] coefficients;

        /* constructor to set coefficients of the polynomial */
        public Polynomial(params double[] coefficients)
        {
            this.coefficients = coefficients;
        }

        /* method which returns a string representation of the polynomial */
        public override string ToString()
        {
            string result = "";

            for (int i = 0; i < coefficients.Length; i++)
            {
                if (coefficients[i] != 0)
                {
                    if (i == 0)
                    {
                        if (coefficients[i] < 0)
                        {
                            result += "- ";
                        }
                    }
                    else
                    {
                        if (coefficients[i] > 0)
                        {
                            result += " + ";
                        }
                        else if (coefficients[i] < 0)
                        {
                            result += " - ";
                        }
                    }

                    double absoluteCoefficients = Math.Abs(coefficients[i]);

                    if (absoluteCoefficients != 1 || i == 0)
                    {
                        result += absoluteCoefficients;
                    }

                    if (i > 0)
                    {
                        result += "x";

                        if (i > 1)
                        {
                            result += "^" + i;
                        }
                    }
                }
            }
            return result;
        }

        /* overloading binary operator for add */
        public static Polynomial operator +(Polynomial firstPolynomial, Polynomial secondPolynomial)
        {
            int maxLength = Math.Max(firstPolynomial.coefficients.Length, secondPolynomial.coefficients.Length);
            double[] polynomialResult = new double[maxLength];

            for (int i = 0; i < maxLength; i++)
            {
                double firstPolynomialCoefficient;
                double secondPolynomialCoefficient;

                if (i < firstPolynomial.coefficients.Length)
                {
                    firstPolynomialCoefficient = firstPolynomial.coefficients[i];
                }
                else
                {
                    firstPolynomialCoefficient = 0;
                }

                if (i < secondPolynomial.coefficients.Length)
                {
                    secondPolynomialCoefficient = secondPolynomial.coefficients[i];
                }
                else
                {
                    secondPolynomialCoefficient = 0;
                }
                polynomialResult[i] = firstPolynomialCoefficient + secondPolynomialCoefficient;
            }

            return new Polynomial(polynomialResult);
        }

        /* overloading binary operator for substraction */
        public static Polynomial operator -(Polynomial firstPolynomial, Polynomial secondPolynomial)
        {
            int maxLength = Math.Max(firstPolynomial.coefficients.Length, secondPolynomial.coefficients.Length);
            double[] polynomialResult = new double[maxLength];

            for (int i = 0; i < maxLength; i++)
            {
                double firstPolynomialCoefficient;
                double secondPolynomialCoefficient;

                if (i < firstPolynomial.coefficients.Length)
                {
                    firstPolynomialCoefficient = firstPolynomial.coefficients[i];
                }
                else
                {
                    firstPolynomialCoefficient = 0;
                }

                if (i < secondPolynomial.coefficients.Length)
                {
                    secondPolynomialCoefficient = secondPolynomial.coefficients[i];
                }
                else
                {
                    secondPolynomialCoefficient = 0;
                }

                polynomialResult[i] = firstPolynomialCoefficient - secondPolynomialCoefficient;
            }

            return new Polynomial(polynomialResult);
        }

        /* overloading binary operator for multiplication */
        public static Polynomial operator *(Polynomial firstPolynomial, Polynomial secondPolynomial)
        {
            int totalLength = firstPolynomial.coefficients.Length + secondPolynomial.coefficients.Length - 1;
            double[] polynomialResult = new double[totalLength];

            for (int i = 0; i < firstPolynomial.coefficients.Length; i++)
            {
                for (int j = 0; j < secondPolynomial.coefficients.Length; j++)
                {
                    polynomialResult[i + j] += firstPolynomial.coefficients[i] * secondPolynomial.coefficients[j];
                }
            }

            return new Polynomial(polynomialResult);
        }
    }
}

