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
            Console.WriteLine(factWheel.randomFact());
            Console.WriteLine(factWheel.randomFact());
            Console.WriteLine(factWheel.randomFact());
            Console.ReadKey();
        }
    }
}
