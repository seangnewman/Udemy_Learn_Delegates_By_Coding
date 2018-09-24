using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomDelegate
{
    public delegate int NumbersProcessDelegate(int x, int y);
    class Program
    {
        static void Main(string[] args)
        {

            NumbersProcessDelegate del = new NumbersProcessDelegate(Sum);
            Console.WriteLine(del(5,5));

            del = new NumbersProcessDelegate(Subtract);
            Console.WriteLine(del(5, 5));

        }

        public static int Sum(int x, int y)
        {
            return x + y;
        }

        public static int Subtract(int x, int y)
        {
            return x - y;
        }
    }
}
