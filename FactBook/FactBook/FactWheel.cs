using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactBook
{
    class FactWheel
    {
        private String[] factBook = {"Abhishek Baghel is Superman",
        "Honey Singh is SuperStar!",
        "Dylan Bahgel uses Github repository for his projects",
        "Why ASP.Net is Better than PHP.",
        "PYTHON is a programming language and a snake also"};

        public String randomFact() {
            int randomNumber = new Random().Next(1,factBook.Length);
            return factBook[randomNumber];
        }
    }
}
