using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            MyCalculator calc = new MyCalculator();


            //Console.WriteLine(calc.ProcessNumbers(5, 5, new NumbersProcessDelegate(Sum)));
            //Console.WriteLine(calc.ProcessNumbers(5, 5, new NumbersProcessDelegate(Subtract)));
            //Console.WriteLine(calc.ProcessNumbers(5, 5, new NumbersProcessDelegate(Multiply)));
            //Console.WriteLine(calc.ProcessNumbers(5, 5, new NumbersProcessDelegate(Divide)));

            Console.WriteLine(calc.ProcessNumbers(5, 5, Sum));
            Console.WriteLine(calc.ProcessNumbers(5, 5, Subtract));
            Console.WriteLine(calc.ProcessNumbers(5, 5, Multiply));
            Console.WriteLine(calc.ProcessNumbers(5, 5, Divide));

            //loggerDel = new LoggerDelegate(WriteFancyString);
            //LoggerDelegate simpleLogger = new LoggerDelegate(WriteSimpleString);
            //LoggerDelegate fancyLogger = new LoggerDelegate(WriteFancyString);

            //simpleLogger(logMessage);
            //fancyLogger(logMessage);

            string logMessage = "We are logging to the console";


            //LoggerDelegate loggerDel = new LoggerDelegate(WriteSimpleString);
            //loggerDel += new LoggerDelegate(WriteFancyString);
            //loggerDel += new LoggerDelegate(WriteAsterickString);

            // Using Delegate Inference
            // I had no idea this could be done

            //LoggerDelegate loggerDel = WriteSimpleString;
            Action<string> loggerDel = WriteSimpleString;

            loggerDel += WriteFancyString;
            loggerDel +=  WriteAsterickString;

            

            loggerDel(logMessage);
        }

        private static void WriteAsterickString(string logMessage)
        {
            Console.WriteLine(String.Format("****** {0} ******", logMessage));
        }

        public static void WriteSimpleString(string logMessage)
        {
            Console.WriteLine(logMessage);
        }

        public static void WriteFancyString(string logMessage)
        {
            Console.WriteLine(String.Format(".-=*** {0} ***=-.", logMessage));
        }

        private static int Divide(int x, int y)
        {
            return x / y;
        }

        private static int Multiply(int x, int y)
        {
            return x * y;
        }

        private static int Subtract(int x, int y)
        {
            return x - y;
        }

        private static int Sum(int x, int y)
        {
            return x + y;
        }

        
    }
}
