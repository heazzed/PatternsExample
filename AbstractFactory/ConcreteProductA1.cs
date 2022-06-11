using System;
namespace AbstractFactory
{
    public class ConcreteProductA1 : AbstractProductA
    {
        public override void DoSmthA()
        {
            Console.WriteLine("Product A was created by Factory1");
        }
    }
}
