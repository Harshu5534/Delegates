using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{

    public delegate void EventHandler(string x);
    public class EventHandling
    {
        public class Operations
        {
            public event EventHandler xyz;
            public void Action(string a)
            {
                if (xyz != null)
                {
                    xyz(a);
                    Console.WriteLine(a);
                }
                else
                {
                    Console.WriteLine("Not Registered");
                }
            }
        }
        private static void CatchEvent(string s)
        {
            Console.WriteLine("Method Calling");
        }
        public static void Implementation()
        {
            Operations o = new Operations();
            o.Action("Event Calling");
            Console.WriteLine();
            o.xyz+=new EventHandler(CatchEvent);
            o.Action("Event Called");
        }
    }
}
