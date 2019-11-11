using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessCards;
using CreditCards;

namespace Purse
{
    class Program
    {
        static void Main(string[] args)
        {
            BusinessCard bc = new BusinessCard();

            bc.CountUAH = 100;

            bc.ShowBalance();

            Console.WriteLine(" ");


            CreditCard cr = new CreditCard();
            cr.ShowBalance();

          


        }
    }
}
