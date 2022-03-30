using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functional_Programming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EvenOddNumber number = new EvenOddNumber();
            number.Number();

            Factornumber factornumber = new Factornumber();
            factornumber.factor();

            Harmonicnumber harmonicnumber = new Harmonicnumber();
            harmonicnumber.harnonic();

            Largethreenumber largethreenumber = new Largethreenumber();
            largethreenumber.large();

            Leepyear year = new Leepyear();
            year.year();


            QuotientandRemainder quotientandRemainder = new QuotientandRemainder();
            quotientandRemainder.divide();


            SwapTwoNumber swaptwonumber = new SwapTwoNumber();
            swaptwonumber.swap();

             VowelorConsonant vowelorConsonant = new VowelorConsonant();
            vowelorConsonant.vowel();


             Console.ReadLine();
        }
    }
}
