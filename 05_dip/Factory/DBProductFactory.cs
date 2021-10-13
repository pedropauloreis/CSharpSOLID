using System.Configuration;
using _05_dip.Model;

namespace _05_dip.Factory
{
    class DBProductFactory
    {
        public static DBProduct Create()
        {
            switch(ConfigurationManager.AppSettings["DB"])
            {
                case "SQLSERVER":
                    return new SQLServerProduct();

                case "MONGODB":
                    return new MongoDBProduct();

                default:
                    return new SQLServerProduct();

            }
        }
    }
}
