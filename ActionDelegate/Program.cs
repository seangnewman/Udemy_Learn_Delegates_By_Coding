using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActionDelegate
{

    //public delegate void ActionDelegate();
    class Program
    {
        static void Main(string[] args)
        {
            //ActionDelegate action = Action1;
            Action<string> action = Action1;
            action += Action2;
            action("is invoked!");
        }

        private static void Action2(string text)
        {
            Console.WriteLine("Action2 {0}", text);
        }

        private static void Action1(string text)
        {
            Console.WriteLine("Action1 {0}", text);
        }
    }
}
