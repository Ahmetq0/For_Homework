using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Ödev4
{
    internal class For_Digital_Process
    {
        public static int Width()
        {
            Console.WriteLine("Genişiliği Giriniz");
            return Convert.ToInt32(Console.ReadLine());
        }

        public static int Height() 
        {
            Console.WriteLine("Yüksekliği Giriniz");
            return Convert.ToInt32(Console.ReadLine());
        }

        public static void For_Process()
        {
            int width = Width();
            int height = Height();

            for (int i = width - 1; i >= 0; i--)
            {
                for (int a = 0; a <= i && a <= width; a++)
                {
                    Console.Write(height + "");
                }
                Console.WriteLine();
            }
        }
    }
}
