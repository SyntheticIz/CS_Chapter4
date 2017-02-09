using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int add = 0, sum = 0;
            
            while (add != 999)
            {
                String scan = Console.ReadLine();
                add = Convert.ToInt32(scan);
                sum += add;
            }
                Console.WriteLine((sum-999));
        }
    }
}
