using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum50
{
    class Program
    {
        static void Main(string[] args)
        {
            int sums = 0;
            for (int i = 0; i < 51; i++)
            {
                sums += i;
            }
            Console.WriteLine(sums);
        }
    }
}
