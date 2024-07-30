using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FloatDoubleDecimal
{
    class Program
    {
        static void Main(string[] args)
        {
            float flt = 1f / 3;
            double db1 = 1d / 3;
            decimal dcm = 1m / 3;

            Console.WriteLine("float : {0}\n double : {1}\n decimal : {2}", flt, db1, dcm);
            Console.WriteLine("float : {0} bytes \n double : {1} bytes \n decimal : {2} bytes", sizeof(float), sizeof(double), sizeof(decimal));
            Console.WriteLine("float : {0} ~ {1}", float.MinValue, float.MaxValue);
            Console.WriteLine("double : {0} ~ {1}", double.MinValue, double.MaxValue);
            Console.WriteLine("decimal : {0} ~ {1}", decimal.MinValue, decimal.MaxValue);
        }
    }
}
