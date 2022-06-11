using System;
namespace Strategy
{
    public class Context
    {
        public IStrategy contextStrategy { get; set; }

        public Context(IStrategy strategy)
        {
            contextStrategy = strategy;
        }

        public void DoAlgorithm()
        {
            contextStrategy.Algorithm();
        }
    }
}
