using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<string, int> converterFunc = ConvertToInt2;

            Console.WriteLine(converterFunc("15") ); 

        }

        public static int ConvertToInt1(string valueToConvert)
        {
            return Convert.ToInt32(valueToConvert);
        }

        public static int ConvertToInt2(string valueToConvert)
        {
            int result;
            return int.TryParse(valueToConvert, out result) ? result : 0;
        }
    }
}
