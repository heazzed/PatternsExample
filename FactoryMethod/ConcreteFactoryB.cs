using System;
namespace FactoryMethod
{
    public class ConcreteFactoryB : AbstractFactory
    {
        public ConcreteFactoryB() : base("Factory B") { }

        public override AbstractProduct Create()
        {
            return new ConcreteProductB();
        }
    }
}
