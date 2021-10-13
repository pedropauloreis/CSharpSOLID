using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_lsp.Payments
{
    class NubankRewards : IPaymentInstrument
    {
        public void CollectPayment()
        {
            Console.WriteLine("Pagamento realizado!");
            Console.WriteLine("Pontuação Creditada!");
        }

        public void Validate()
        {
            Console.WriteLine("Limite Ok, Rewards OK!");
        }
    }
}
