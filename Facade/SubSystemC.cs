using System;
namespace Facade
{
    public class SubSystemC
    {
        public SubSystemC()
        {
            Console.WriteLine("SubSysC is started");
        }

        public void C1()
        {
            Console.WriteLine("Operation C1");
        }

        public void C2()
        {
            Console.WriteLine("Operation C2");
        }
    }
}
