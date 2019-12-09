using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter First No ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter First No ");
            int b = int.Parse(Console.ReadLine());

            while (true)
            {
                Console.WriteLine("Choose \n1.Addtion\n2.Substraction\n3.Multiplication\n4.Division\n5.Exit");
                int c = int.Parse(Console.ReadLine());
                int reslut = 0;
                switch (c)
                {
                    case 1:
                         reslut = a + b;
                        Console.WriteLine("The Addition is "+reslut);
                        break;
                    case 2:
                         reslut = a - b;
                        Console.WriteLine("The Subtraction is " + reslut);
                        break;
                    case 3:
                        reslut = a * b;
                        Console.WriteLine("The Multiplication is " + reslut);
                        break;
                    case 4:

                        float x = a/b;
                        Console.WriteLine("The Divison is " + x);
                        break;
                    case 5:
                        return;
                       
                    default:
                        break;
                }

            }
            Console.ReadKey();
        }
    }
}
