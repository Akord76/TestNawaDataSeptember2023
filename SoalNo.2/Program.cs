using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoalNo._2
{
    class Program
    {

        static void Main(string[] args)
        {
            BusRequirement();
            Console.ReadKey();
        }

        private static void BusRequirement()
        {
            int n;

            Console.Write("Input the number of families : ");

            n = Convert.ToInt32(Console.ReadLine());

            int[] num = new int[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
            int NumberOfFamilies;
            if (n == 5)
            {
                NumberOfFamilies = num[3];
                Console.Write("Minimum bus required is : " + NumberOfFamilies.ToString());
                Console.WriteLine();
            }

            if (n == 8)
            {
                NumberOfFamilies = num[4];
                Console.Write("Minimum bus required is : " + NumberOfFamilies.ToString());
                Console.WriteLine();
            }
        }
    }
}
