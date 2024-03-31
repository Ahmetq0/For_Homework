using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ödev6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir Dize Giriniz");
            string dize = Console.ReadLine();

            for (int i = 0; i < dize.Length; i++)
            {
                for (int j = 0; j <= i; j++) 
                {
                    Console.Write(dize[j]);
                }
                Console.WriteLine();
            }
        }
    }
}
