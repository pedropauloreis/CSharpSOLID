using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_dip.Model
{
    class MongoDBProduct : DBProduct
    {
        public string getProductById(string id)
        {
            return $"MongoDB: Exibindo dados do produto {id}";
        }
    }
}
