using System;
namespace AbstractFactory
{
    public class ConcreteProductA2 : AbstractProductA
    {
        public override void DoSmthA()
        {
            Console.WriteLine("Product A was created by Factory2");
        }
    }
}
