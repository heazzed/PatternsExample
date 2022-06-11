using System;
namespace Facade
{
    public class SubSystemB
    {
        public SubSystemB()
        {
            Console.WriteLine("SubSysB is started");
        }

        public void B1()
        {
            Console.WriteLine("Operation B1");
        }

        public void B2()
        {
            Console.WriteLine("Operation B2");
        }
    }
}
