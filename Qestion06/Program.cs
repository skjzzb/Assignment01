using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qestion06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The Char");
            char c = Char.Parse(Console.ReadLine());
            int x = c;
            Console.WriteLine("Character is "+ c );
            Console.WriteLine("Assci Value of Character is " + x);
            Console.ReadKey();
        }
    }
}
