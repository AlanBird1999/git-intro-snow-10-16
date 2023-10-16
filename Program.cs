using System;

namespace MyConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Running tests for simple functions");
            Tests.TestAllFunctions();
            Console.WriteLine("Finished running tests");
        }
    }
}