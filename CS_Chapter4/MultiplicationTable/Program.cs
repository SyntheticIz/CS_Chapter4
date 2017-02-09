using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 11; i++)
            {
                for (int p = 1; p < 11; p++)
                {
                    Console.Write(p * i + "\t");
                }
                Console.Write("\n\n");
            }
        }
    }
}
