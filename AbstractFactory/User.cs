using System;
namespace AbstractFactory
{
    public class User
    {
        AbstractProductA abstractProductA;

        AbstractProductB abstractProductB;

        public User(AbstractFactory abstractFactory)
        {
            abstractProductA = abstractFactory.CreateProductA();
            abstractProductB = abstractFactory.CreateProductB();
        }

        public void DoWithA()
        {
            abstractProductA.DoSmthA();
        }

        public void DoWithB()
        {
            abstractProductB.DoSmthB();
        }
    }
}
