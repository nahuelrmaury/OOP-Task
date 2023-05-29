using System.Text;

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
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < coefficients.Length; i++)
            {
                if (coefficients[i] != 0)
                {
                    if (i == 0)
                    {
                        if (coefficients[i] < 0)
                        {
                            result.Append("- ");
                        }
                    }
                    else
                    {
                        if (coefficients[i] > 0)
                        {
                            result.Append(" + ");
                        }
                        else if (coefficients[i] < 0)
                        {
                            result.Append(" - ");
                        }
                    }

                    double absoluteCoefficients = Math.Abs(coefficients[i]);

                    if (absoluteCoefficients != 1 || i == 0)
                    {
                        result.Append(absoluteCoefficients);
                    }

                    if (i > 0)
                    {
                        result.Append("x");

                        if (i > 1)
                        {
                            result.Append("^" + i);
                        }
                    }
                }
            }
            return result.ToString();
        }

        /* overloading binary operator for add */
        public static Polynomial operator +(Polynomial firstPolynomial, Polynomial secondPolynomial)
        {
            return AddOrSubtractPolynomials(firstPolynomial, secondPolynomial, true);
        }

        /* overloading binary operator for substraction */
        public static Polynomial operator -(Polynomial firstPolynomial, Polynomial secondPolynomial)
        {
            return AddOrSubtractPolynomials(firstPolynomial, secondPolynomial, false);
        }

        /* private method to add or subtract polynomials */
        private static Polynomial AddOrSubtractPolynomials(Polynomial firstPolynomial, Polynomial secondPolynomial, bool isAddition)
        {
            int firstPolyLength = firstPolynomial.coefficients.Length;
            int secondPolyLength = secondPolynomial.coefficients.Length;
            int maxLength = Math.Max(firstPolyLength, secondPolyLength);
            double[] polynomialResult = new double[maxLength];

            for (int i = 0; i < maxLength; i++)
            {
                double firstPolynomialCoefficient = i < firstPolyLength ? firstPolynomial.coefficients[i] : 0;
                double secondPolynomialCoefficient = i < secondPolyLength ? secondPolynomial.coefficients[i] : 0;
                double resultCoefficient = isAddition ? firstPolynomialCoefficient + secondPolynomialCoefficient : firstPolynomialCoefficient - secondPolynomialCoefficient;
                polynomialResult[i] = resultCoefficient;
            }

            return new Polynomial(polynomialResult);
        }

        /* overloading binary operator for multiplication */
        public static Polynomial operator *(Polynomial firstPolynomial, Polynomial secondPolynomial)
        {
            int firstPolyLength = firstPolynomial.coefficients.Length;
            int secondPolyLength = secondPolynomial.coefficients.Length;
            int totalLength = firstPolyLength + secondPolyLength - 1;
            double[] polynomialResult = new double[totalLength];

            for (int i = 0; i < firstPolyLength; i++)
            {
                for (int j = 0; j < secondPolyLength; j++)
                {
                    polynomialResult[i + j] += firstPolynomial.coefficients[i] * secondPolynomial.coefficients[j];
                }
            }

            return new Polynomial(polynomialResult);
        }
    }
}