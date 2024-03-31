using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ödev3
{
    internal class For_Process
    {
        public static int Number()
        {
            Console.WriteLine("Sayıyı Giriniz");
            return Convert.ToInt32(Console.ReadLine());
        }

        public static void For_Digital_Process()
        {
            int number = Number();

            for(int a = 0; a < 5; a++)
            {
                for(int b = 0; b < 3; b++) 
                {
                    Console.Write(number);
                }

                Console.WriteLine();
            }


        }
    }
}
