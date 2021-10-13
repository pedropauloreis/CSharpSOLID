using System;

namespace _03_lsp.Payments
{
    class CreditCard : NubankCard
    {
        public override void Validate()
        {
            Console.WriteLine("Validando Limite...");
            Console.WriteLine("Limite OK.");
        }
    }
}
