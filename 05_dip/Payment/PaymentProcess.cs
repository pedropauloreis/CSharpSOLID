using _05_dip.Model;
using _05_dip.Factory;
using System;

namespace _05_dip.Payment
{
    class PaymentProcess
    {
        public void Pay(string id)
        {
            DBProduct product = DBProductFactory.Create();
            string productData = product.getProductById(id);
            Console.WriteLine(productData);
        }
    }
}
