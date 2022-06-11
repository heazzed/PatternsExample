using System;
namespace State
{
    public class StateB : IState
    {
        public StateB()
        {
            Console.WriteLine("Now in State B");
        }

        public void Handle(Context context)
        {
            context.State = new StateA();
            Console.WriteLine("State Changed to A");
        }
    }
}
