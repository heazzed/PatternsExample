using System;
namespace AbstractFactory
{
    public class ConcreteProductB1 : AbstractProductB
    {
        public override void DoSmthB()
        {
            Console.WriteLine("Product B was created by Factory1");
        }
    }
}
