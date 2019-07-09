using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int three = 3;
            int sumthree = 0;
            for (int i = 0; i <= 999; i++)
                if (i % three == 0)
                    sumthree += i;
            Console.WriteLine("SumThree = " + sumthree);

            int five = 5;
            int sumfive = 0;
            for (int i = 0; i <= 999; i++)
                if (i % five == 0)
                    sumfive += i;
            Console.WriteLine("SumFive = " + sumfive);

           
            int sumtotal = (sumthree + sumfive);
            Console.WriteLine("Total = " + sumtotal);
            Console.ReadKey();

        }
    }
}
