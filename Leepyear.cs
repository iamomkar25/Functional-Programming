using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functional_Programming
{
    internal class Leepyear
    {
        public void year()
        {
            Console.WriteLine("please enter a number (only 4 degit )\n");
            int y = Convert.ToInt32(Console.ReadLine());
            if ((y % 4 == 0))
            {
                Console.WriteLine("leep year");
            }
            else
            {
                Console.WriteLine("not leep year");
            }


        }
    }
}
