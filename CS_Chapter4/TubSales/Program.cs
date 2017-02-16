using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TubSales
{
    class Program
    {
        static void Main(string[] args)
        {
            String sp = "";
            Console.WriteLine("Pick a salesperson: Andrea, Brittany, or Eric");
            while (sp.ToLower() != "z")
            {
                sp = Console.ReadLine();
                if (sp.ToLower().StartsWith("a"))
                {
                    Console.WriteLine("What was the pay")
                }
            }

        }
    }
}
