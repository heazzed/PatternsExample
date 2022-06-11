using System;
namespace AbstractFactory
{
    public class ConcreteProductB2 : AbstractProductB
    {
        public override void DoSmthB()
        {
            Console.WriteLine("Product B was created by Factory2");
        }
    }
}
