using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Problem_25
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ThousandDigitFibonacci());
            Console.Read();
        }

        private static int ThousandDigitFibonacci()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            int index = 0;
            BigInteger previous = 0;
            BigInteger prePrevious = 0;
            BigInteger fibonacci = 1;
            BigInteger fibSum = 0;

            while(fibSum.ToString().Length < 1000)
            {
                index++;

                fibonacci += previous + prePrevious;

                prePrevious = previous;
                previous = fibonacci;
                fibSum = fibonacci;
                fibonacci = 0;
                
            }

            stopwatch.Stop();
            return index;
        }
    }
}
