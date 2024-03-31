using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ödev8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir dize giriniz");
            string dize = Console.ReadLine();

            for (int i = 0; i <= dize.Length; i++)
            {
                for (int a = i; a <= dize.Length; a++)
                {
                    Console.Write(" ");
                }


                for (int c = 0; c <= i; c++)
                {
                    Console.Write(dize[c]);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }

            

            //for (int a = 1; a < dize.Length; a++)
            //{
              //  Console.Write(dize[a]);
            //}
        }
    }
}
