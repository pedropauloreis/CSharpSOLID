

namespace _03_lsp.Payments
{
    interface IPaymentInstrument
    {
        void Validate();
        void CollectPayment();
    }
}
