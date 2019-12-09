using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The Basics Salary Of Employee");
            float bsal = float.Parse(Console.ReadLine());
            Console.WriteLine("The Basics Salary Of Employee \n"+ bsal +"\n");
            float hra = bsal * 0.2f;
            float da = bsal * 0.4f;
            float pf = bsal * 0.1f;
            float gs = bsal + hra + da;
            float ns = gs - pf;

            Console.WriteLine("The HRA On Basics Salary \n" + hra + "\n");
            Console.WriteLine("The DA On Basics Salary \n" + da + "\n");
            Console.WriteLine("The PF On Basics Salary \n" + pf + "\n");
            Console.WriteLine("The Gross Sal On Basics Salary \n" + gs + "\n");
            Console.WriteLine("The Net Sal On Basics Salary \n" + ns + "\n");


            Console.ReadKey();


        }
    }
}
