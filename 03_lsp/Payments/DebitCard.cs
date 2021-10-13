using System;


namespace _03_lsp.Payments
{
    class DebitCard : NubankCard
    {
        public override void Validate()
        {
            Console.WriteLine("Validando saldo...");
            Console.WriteLine("Saldo disponível.");
        }
    }
}
