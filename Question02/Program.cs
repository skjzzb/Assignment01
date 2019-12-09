using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question02
{
    class Program
    {
        static void Main(string[] args)
        {
            int []marks=new int[5];
            int sum=0;
            Console.WriteLine("Enter The Marsks");
            for (int i = 0; i < 5; i++)
            {
                marks[i] = int.Parse(Console.ReadLine());
                sum += marks[i];
            }
            Console.WriteLine("Total marks\n "+ sum);
            Console.WriteLine("Total Avrage\n " + sum/5);
            Console.ReadKey();

        }
    }
}
