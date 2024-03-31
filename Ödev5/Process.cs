using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ödev5
{
    internal class Process
    {

        public static int Get_Width()
        {
            Console.WriteLine("Genişiliği Giriniz");
            return Convert.ToInt32(Console.ReadLine());
        }
        public static void For_Process()
        {
            int Width = Get_Width();

            for (int i = 0; i < Width; i++)
            {
                for (int space = 0; space < i; space++)
                {
                    Console.Write(" ");
                }
                for (int multiplacition = i; multiplacition < Width; multiplacition++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

    }
}
