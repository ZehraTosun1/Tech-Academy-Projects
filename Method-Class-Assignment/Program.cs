using System;

namespace MethodClassAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // This creates an object of the MathOperations class.
            MathOperations math = new MathOperations();

            // This calls the method and passes in two numbers.
            math.DoMath(10, 20);

            // This calls the same method again using named parameters.
            math.DoMath(firstNumber: 15, secondNumber: 30);

            // This keeps the console window open.
            Console.ReadLine();
        }
    }
}
