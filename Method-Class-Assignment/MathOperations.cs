using System;

namespace MethodClassAssignment
{
    // This class contains a method that performs a math operation.
    public class MathOperations
    {
        // This is a void method because it does not return a value.
        // It takes two integers as parameters.
        public void DoMath(int firstNumber, int secondNumber)
        {
            // This performs a math operation on the first integer.
            int result = firstNumber * 2;

            // This displays the result of the math operation.
            Console.WriteLine("The first number multiplied by 2 is: " + result);

            // This displays the second integer to the screen.
            Console.WriteLine("The second number is: " + secondNumber);
        }
    }
}
