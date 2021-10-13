using _01_srp.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _01_srp
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client();
            Notify notify = new Notify(client);
            Console.ReadLine();
        }
    }
}
