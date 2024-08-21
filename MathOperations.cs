using System;

namespace ConsoleApp
{
    public class MathOperations
    {
        // This method takes two integers and performs an operation on the first integer.
        // It also displays the second integer.
        public void PerformOperation(int num1, int num2)
        {
            int result = num1 + num1; // Double the first integer
            Console.WriteLine("The result of the operation is: " + result);
            Console.WriteLine("The second integer is: " + num2);
        }
    }
}
