using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question05
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5, b = 10;
            Console.WriteLine("a={0} and b={1}",a,b);
            int c = a;
            a = b;
            b = c;
            Console.WriteLine("After Swap opration Value is");
            Console.WriteLine("a={0} and b={1}", a, b);
            Console.ReadKey();


        }
    }
}
