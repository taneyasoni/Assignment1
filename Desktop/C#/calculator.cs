using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace introToCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("hello world");
            int Total = 0;
            int sub = 0;
            int Product = 0;
            int division = 0;
            Calculate(80, 20, out Total, out Product,out sub,out division);
            Console.WriteLine("{0} {1} {2} {3}",Total,Product,sub,division);
          

        }
        public static void Calculate(int fn, int sn,out int sum,out int product,out int sub,out int division)
        {
            sum = fn + sn;
            sub = fn - sn;
            product = fn * sn;
            division = fn / sn;
        }
    }
}
