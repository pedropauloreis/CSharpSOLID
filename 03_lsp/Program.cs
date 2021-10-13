using System;
using _03_lsp.Payments;

namespace _03_lsp
{
    class Program
    {
        static void Main(string[] args)
        {
            //DebitCard Card = new DebitCard();
            //CreditCard Card = new CreditCard();
            NubankRewards Card = new NubankRewards();

            Card.Validate();
            Card.CollectPayment();

            Console.ReadKey();

        }
    }
}
