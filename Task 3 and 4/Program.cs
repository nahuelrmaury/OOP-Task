using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3_and_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int naturalInput = 0;
            do
            {
                if (naturalInput < 2)
                {
                    Console.Clear();
                    Console.WriteLine("Enter a natural value greater than 1");
                }
                Console.Write("Natural value: ");
                naturalInput = Convert.ToInt32(Console.ReadLine());
            } while (naturalInput < 2);
            FibonacciLoop(0, 1, naturalInput);
            FibonacciRecursion(0, 1, 1, naturalInput, 0);
        }

        public static void FibonacciLoop(int firstNumber, int secondNumber, int naturalInput)
        {
            Console.Write("Fibonacci numbers (loop): " + firstNumber + " " + secondNumber + " ");
            int resultNumber = firstNumber + secondNumber;

            while (resultNumber < naturalInput)
            {
                Console.Write(resultNumber + " ");
                firstNumber = secondNumber;
                secondNumber = resultNumber;
                resultNumber = firstNumber + secondNumber;
            }
        }

        public static void FibonacciRecursion(int firstNumber, int secondNumber, int counter, int naturalInput, int resultNumber)
        {
            if (counter == 1)
            {
                Console.Write(System.Environment.NewLine);
                Console.Write("Fibonacci numbers (recursive): ");
            }
            if (resultNumber < naturalInput)
            {
                Console.Write(firstNumber + " ");
                FibonacciRecursion(secondNumber, firstNumber + secondNumber, counter + 1, naturalInput, secondNumber);
            }
        }
    }
}