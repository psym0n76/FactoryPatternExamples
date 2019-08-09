using System;

namespace FactoryLibrary
{
    public class CalculationFactory
    {
        public ICalculate GetCalculate(string type)
        {
            switch (type)
            {
                case "a":
                    return new Addition();
                case "b":
                    return new Subtraction();
                default:
                    throw new Exception("Missing type");
            }
        }
    }
}