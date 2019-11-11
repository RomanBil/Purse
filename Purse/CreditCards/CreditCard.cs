using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditCards
{
    public class CreditCard
    {
        public int CountUAH { get; set; }

        public CreditCard()
        {
            CountUAH = 100;
        }

        public void ShowBalance()
        {
            Console.WriteLine("Count UAH on business card: " + CountUAH);
        }


    }
}
