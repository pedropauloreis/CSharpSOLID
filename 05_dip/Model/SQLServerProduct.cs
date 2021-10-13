using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_dip.Model
{
    class SQLServerProduct : DBProduct
    {
        public string getProductById(string id)
        {
            return $"SQLServer: Exibindo dados do produto {id}";
        }

    }
}
