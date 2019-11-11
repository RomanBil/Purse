using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessCards;
using CreditCards;
using Moneys;

namespace Purse
{
    class Program
    {
        static void Main(string[] args)
        {
            BusinessCard bc = new BusinessCard();
            Money m = new Money();
            bc.CountUAH = 100;

            bc.ShowBalance();
            m.ShowMoney();
            Console.WriteLine("... ");


            CreditCard cr = new CreditCard();
        

          


        }
    }
}
