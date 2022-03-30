using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functional_Programming
{
    internal class Factornumber
    {
        public void factor()
        {
            int factor;
            Console.Write("Enter the value of number:");
            int number = Convert.ToInt32(Console.ReadLine());


            for (factor = 1; factor <= number; factor++)
            {
                if (number % factor == 0)
                {
                    Console.Write(factor + ",");
                }
            }
        }
    }
}
