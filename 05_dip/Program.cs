using System;
using _05_dip.Payment;

namespace _05_dip
{
    class Program
    {
        static void Main(string[] args)
        {
            PaymentProcess payment = new PaymentProcess();
            payment.Pay("ABC123");

            Console.ReadKey();
        }
    }
}
