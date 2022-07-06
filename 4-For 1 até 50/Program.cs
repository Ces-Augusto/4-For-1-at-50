using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_For_1_até_50
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Contador do 1 ao 50");

            

            for (int num1 = 1;num1 <=50;  num1++)
            {
                Console.WriteLine("\t" + num1);
            }

            Console.ReadKey();
        }
    }
}
