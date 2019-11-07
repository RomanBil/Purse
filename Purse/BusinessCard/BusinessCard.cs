using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessCards
{
    public class BusinessCard
    {
        public int CountUAH { get; set; }

        public BusinessCard()
        {
            CountUAH = 0;
        }

        public void ShowBalance()
        {
            Console.WriteLine("Count UAH on business card: " + CountUAH);
        }
    }
}
