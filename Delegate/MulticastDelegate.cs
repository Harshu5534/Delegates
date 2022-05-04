using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    public class MulticastDelegate
    {
        delegate void DelOp(int x, int y);
        public static void ImplementDelegate()
        {
            //Delegate Instantiation
            DelOp obj = Operation.Add;
            obj += Operation.Square;
            obj(5, 5);
            obj(8, 3);
            Console.ReadLine();
        }
        public class Operation
        {
            public static void Add(int a, int b)
            {
                Console.WriteLine("Addition is = {0}", a + b);
            }
            public static void Square(int a, int b)
            {
                Console.WriteLine("Multiple is = {0}", a * b);
            }
        }
    }
}
