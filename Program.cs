using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate the MathOperations class
            MathOperations mathOps = new MathOperations();

            // Call the PerformOperation method with two numbers
            mathOps.PerformOperation(10, 20);

            // Call the PerformOperation method, specifying parameters by name
            mathOps.PerformOperation(num1: 15, num2: 30);

            Console.ReadLine(); // Keep the console open to view the output
        }
    }
}

