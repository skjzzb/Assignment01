using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question09
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The Basics Sal of SalesPerson");
            float sal = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter The Total Salse Amount of SalesPerson");
            float tsel = float.Parse(Console.ReadLine());
            Console.WriteLine("The Basics Sal of SalesPerson "+ sal + "\n ");
            Console.WriteLine("The Total Salse Amount of SalesPerson "+tsel +"\n ");
            float com = 0;
            float net = 0;
            if (tsel >=5000 && tsel<=7500)
            {
                com = tsel * 0.3f;
                net = sal + com;
            }
            else if (tsel >= 7501 && tsel <= 10500)
            {
                com = tsel * 0.8f;
                net = sal + com;
            }
            else if (tsel >= 10501 && tsel <= 15000)
            {
                com = tsel * 1.1f;
                net = sal + com;
            }
            else if (tsel >= 15001 )
            {
                com = tsel * 1.5f;
                net = sal + com;

            }


            Console.WriteLine(" The Net Salary of SalesPerson \n "+net + "\n ");
            Console.WriteLine(" The Commison of SalesPerson \n " + com +"\n ");
            Console.ReadKey();

        }
    }
}
