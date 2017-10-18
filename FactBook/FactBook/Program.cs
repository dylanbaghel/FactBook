using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactBook
{
    class Program
    {
        static void Main(string[] args)
        {
            FactWheel factWheel = new FactWheel();
            String fact = factWheel.randomFact();
            Console.WriteLine(fact);
            Console.ReadKey();
        }
    }
}
