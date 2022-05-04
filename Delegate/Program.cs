using System;
using static Delegate.MulticastDelegate;

namespace Delegate
{
    public delegate int operation(int x, int y);
    class program
    {
        static int Addition(int a,int b)
        {
            return a + b;
        }
        static void Main(string[] args)
        {
            //Console.WriteLine("Delegate POC!");
            //operation obj = new operation(Addition);
            //Console.WriteLine("Addition is = {0}", obj(23, 27));
            //Operation opration = new Operation();
            //MulticastDelegate.ImplementDelegate();
            EventHandling eventHandling = new EventHandling();
            EventHandling.Implementation();
        }
    }
}