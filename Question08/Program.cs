using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question08
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The Year");
            int year = int.Parse(Console.ReadLine());
            Console.WriteLine("The Year is "+year);
            if (year % 4 == 0)
            {
                if (year % 100 == 0)
                {
                    if (year % 400 == 0)
                        Console.WriteLine("{0} is a leap year.",year);
                    else
                        Console.WriteLine("{0} is not a leap year.", year);
                    
                }
                else
                    Console.WriteLine("{0} is  a leap year.", year);
               
            }
            else
                Console.WriteLine("{0} is not a leap year.", year);
           
            Console.ReadKey();

        }
    }
}
