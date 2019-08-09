using FactoryLibrary;
using System;

namespace ConsoleUi
{
    class Program
    {
        static void Main(string[] args)
        {
            var factory = new CalculationFactory();
            var result = factory.GetCalculate("a").Calculate(2, 3);

            Console.WriteLine($"This is the result: {result}");

            result = factory.GetCalculate("b").Calculate(2, 3);
            Console.WriteLine($"This is the result2: {result}");

            Console.ReadKey();
        }
    }
}
