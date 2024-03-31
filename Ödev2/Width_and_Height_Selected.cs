using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ödev2
{
    internal class Width_and_Height_Selected
    {
        public static int Widt_Selected()
        {
            Console.WriteLine("Genişiliği Giriniz");
            return Convert.ToInt32(Console.ReadLine());
        }

        public static int Height_Selected()
        {
            Console.WriteLine("Yükseklik Giriniz");
            return Convert.ToInt32(Console.ReadLine());
        }
    }
}
