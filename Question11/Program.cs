using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question11
{
    class Program
    {
        public int max3(int a,int b,int c)
        {
            int max=0;
            if (a > b && a > c)
            {
                max = a;
            }
            else if (c > b && c > a)
            {
                max = c;
            }
            else if (b > a && b > c)
            {
                max = b;
            }
            else if (b == a && a == c)
            {
                max = b;
            }

            return max;
        }
        public int max4(int n1, int n2, int n3)
        {
            int max=0;
            max = (n1 > n2 && n1 > n3) ? n1 : (n2 > n1 && n2 > n3) ? n2 : (n3 > n1 && n3 > n2) ? n3 : n1 ;

            return max;
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            Console.WriteLine("Enter 1st Number");
            int a1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter 1st Number");
            int a2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter st Number");
            int a3 = int.Parse(Console.ReadLine());

            while (true)
            {
                Console.WriteLine("Choose\n1.Using If else\n2.Conditional Oprator");
                int c = int.Parse(Console.ReadLine());
                switch (c)
                {
                    case 1:
                        Console.WriteLine("The max Number is"+ p.max3(a1,a2,a3));
                        
                        break;


                    default:
                        break;
                }

            }


        }
    }
}
