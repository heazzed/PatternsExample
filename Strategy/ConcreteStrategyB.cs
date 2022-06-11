using System;
namespace Strategy
{
    public class ConcreteStrategyB : IStrategy
    {
        public ConcreteStrategyB()
        {
        }

        public void Algorithm()
        {
            Console.WriteLine("Doing Strategy B");
        }
    }
}
