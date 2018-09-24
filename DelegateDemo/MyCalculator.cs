using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemo
{
    class MyCalculator
    {
        public int ProcessNumbers(int x, int y, Func<int, int, int> processFunc)
        {
            int result = processFunc(x, y);
            string MethodName = processFunc.Method.Name;
            string outputText = String.Format("The numbers are {0},{1} // The method name is : {2} // The result is : {3}",
                x, y, MethodName, result);
            File.AppendAllText(@"c:\results\result.txt", String.Concat(outputText, Environment.NewLine));
            return result;
        }

        //public  int Subtract(int x, int y)
        //{
        //    int result =  x - y;
        //    string MethodName = "Subtract";
        //    string outputText = String.Format("The numbers are {0},{1} // The method name is : {2} // The result is : {3}",
        //        x, y, MethodName, result);
        //    File.AppendAllText(@"c:\results\result.txt", String.Concat(outputText, Environment.NewLine));
        //    return result;
        //}

        //public int Multiply(int x, int y)
        //{
        //    int result = x * y;
        //    string MethodName = "Multiply";
        //    string outputText = String.Format("The numbers are {0},{1} // The method name is : {2} // The result is : {3}",
        //        x, y, MethodName, result);
        //    File.AppendAllText(@"c:\results\result.txt", String.Concat(outputText, Environment.NewLine));
        //    return result;
        //}
    }
}
