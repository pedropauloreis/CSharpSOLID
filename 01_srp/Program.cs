using _01_srp.Utils;
using System;



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
