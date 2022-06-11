using System;
namespace TemplateMethod
{
    public class ConcreteClassB : AbstractClass
    {
        public override void Operation1()
        {
            Console.WriteLine("Do first operation");
        }

        public override void Operation2()
        {
            Console.WriteLine("Do second operation");
        }

        public override void DefaultOperation()
        {
            Console.WriteLine("Do default operation");
        }
    }
}
