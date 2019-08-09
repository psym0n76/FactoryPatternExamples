namespace FactoryLibrary
{
    public class Subtraction : ICalculate
    {
        public double Calculate(int num, int num2)
        {
            return num - num2;
        }
    }
}