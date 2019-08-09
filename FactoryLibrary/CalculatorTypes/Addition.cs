namespace FactoryLibrary
{
    public class Addition : ICalculate
    {
        public double Calculate(int num, int num2)
        {
            return num + num2;
        }
    }
}