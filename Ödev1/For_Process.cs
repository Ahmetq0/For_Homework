using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ödev1
{
    internal class For_Process
    {
        public static int Number_Process()
        {
            Console.WriteLine("Sayıyı Giriniz");
            return Convert.ToInt32(Console.ReadLine());
        }

        public static void Digital_Process()
        {
            int number = Number_Process();

            for (int i = 0; i <= 10; i++) 
            {
                Console.WriteLine(number*i);
            }
            


        }
    }
}
