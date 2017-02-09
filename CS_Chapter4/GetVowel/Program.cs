using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetVowel
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Enter Vowel: ");
                String scan = Console.ReadLine();
                scan = scan.ToLower();
                if (scan.Equals("a") || scan.Equals("e") || scan.Equals("i") || scan.Equals("o") || scan.Equals("u"))
                {
                    Console.WriteLine("OK");
                }
                else if (scan.Equals("y"))
                {
                    Console.WriteLine("Sometimes");
                }
                else if (scan == "!")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Error! Idiot doesn't know what a vowel is!");
                }
            }
        }
    }
}
