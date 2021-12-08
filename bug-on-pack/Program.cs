using System;

using Microsoft.Extensions.Configuration;

namespace bug_on_pack
{
    class Program
    {
        static void Main(string[] args)
        {
            IConfiguration config = new ConfigurationBuilder().Build();

            Console.WriteLine("Hello World!");
        }
    }
}
