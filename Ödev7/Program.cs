using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ödev7
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string stars = "*";

            Console.WriteLine("Bir sayı giriniz");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("İkinci sayıyı giriniz");
            int y = Convert.ToInt32(Console.ReadLine());

            for (int i =x ; i < y; i++) 
            {
                int total = (i - 4) * (i - 4);
                Console.WriteLine(stars);
                for (int j =0 ; j < total; j++)
                {
                    Console.Write(stars);
                }
            }
            Console.ReadKey();
           

        }


    }
}
